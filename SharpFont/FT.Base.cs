﻿#region MIT License
/*Copyright (c) 2012 Robert Rouhani <robert.rouhani@gmail.com>

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*/
#endregion

using System;

namespace SharpFont
{
	public partial class FT
	{
		#region FaceFlags flag checks

		#region HasHorizontal

		/// <summary>
		/// A macro that returns true whenever a face object contains 
		/// horizontal metrics (this is true for all font formats though).
		/// </summary>
		/// <param name="face">The flags for a face.</param>
		/// <returns>True if the face has the horizontal flag set, false otherwise.</returns>
		public bool HasHorizontal(FaceFlags face)
		{
			return (face & FaceFlags.Horizontal) == FaceFlags.Horizontal;
		}

		/// <summary>
		/// A macro that returns true whenever a face object contains
		/// horizontal metrics (this is true for all font formats though).
		/// </summary>
		/// <param name="face">The face object to test.</param>
		/// <returns>True if the face has the horizontal flag set, false otherwise.</returns>
		public bool HasHorizontal(ref Face face)
		{
			return HasHorizontal(face.FaceFlags);
		}

		#endregion

		#region HasVertical

		/// <summary>
		/// A macro that returns true whenever a face object contains vertical
		/// metrics.
		/// </summary>
		/// <param name="face">The flags for a face.</param>
		/// <returns>True if the face has the vertical flag set, false otherwise.</returns>
		public bool HasVertical(FaceFlags face)
		{
			return (face & FaceFlags.Vertical) == FaceFlags.Vertical;
		}

		/// <summary>
		/// A macro that returns true whenever a face object contains vertical 
		/// metrics.
		/// </summary>
		/// <param name="face">The face object to test.</param>
		/// <returns>True if the face has the vertical flag set, false otherwise.</returns>
		public bool HasVertical(ref Face face)
		{
			return HasVertical(face.FaceFlags);
		}

		#endregion

		#region HasKerning

		/// <summary>
		/// A macro that returns true whenever a face object contains kerning
		/// data that can be accessed with <see cref="GetKerning"/>.
		/// </summary>
		/// <param name="face">The flags for a face.</param>
		/// <returns>True if the face has the kerning flag set, false otherwise.</returns>
		public bool HasKerning(FaceFlags face)
		{
			return (face & FaceFlags.Kerning) == FaceFlags.Kerning;
		}

		/// <summary>
		/// A macro that returns true whenever a face object contains kerning
		/// data that can be accessed with <see cref="GetKerning"/>.
		/// </summary>
		/// <param name="face">The face object to test.</param>
		/// <returns>True if the face has the kerning flag set, false otherwise.</returns>
		public bool HasKerning(ref Face face)
		{
			return HasKerning(face.FaceFlags);
		}

		#endregion

		#region IsScalable

		/// <summary>
		/// A macro that returns true whenever a face object contains a 
		/// scalable font face (true for TrueType, Type 1, Type 42, CID, 
		/// OpenType/CFF, and PFR font formats.
		/// </summary>
		/// <param name="face">The flags for a face.</param>
		/// <returns>True if the face has the scalable flag set, false otherwise.</returns>
		public bool IsScalable(FaceFlags face)
		{
			return (face & FaceFlags.Scalable) == FaceFlags.Scalable;
		}

		/// <summary>
		/// A macro that returns true whenever a face object contains a 
		/// scalable font face (true for TrueType, Type 1, Type 42, CID, 
		/// OpenType/CFF, and PFR font formats.
		/// </summary>
		/// <param name="face">The face object to test.</param>
		/// <returns>True if the face has the scalable flag set, false otherwise.</returns>
		public bool IsScalable(ref Face face)
		{
			return IsScalable(face.FaceFlags);
		}

		#endregion

		#region IsSFNT

		/// <summary>
		/// A macro that returns true whenever a face object contains a font 
		/// whose format is based on the SFNT storage scheme. This usually 
		/// means: TrueType fonts, OpenType fonts, as well as SFNT-based 
		/// embedded bitmap fonts.
		/// 
		/// If this macro is true, all functions defined in FT_SFNT_NAMES_H and
		/// FT_TRUETYPE_TABLES_H are available.
		/// </summary>
		/// <param name="face">The flags for a face.</param>
		/// <returns>True if the face has the SFNT flag set, false otherwise.</returns>
		public bool IsSFNT(FaceFlags face)
		{
			return (face & FaceFlags.SFNT) == FaceFlags.SFNT;
		}

		/// <summary>
		/// A macro that returns true whenever a face object contains a font
		/// whose format is based on the SFNT storage scheme. This usually
		/// means: TrueType fonts, OpenType fonts, as well as SFNT-based
		/// embedded bitmap fonts.
		/// 
		/// If this macro is true, all functions defined in FT_SFNT_NAMES_H and
		/// FT_TRUETYPE_TABLES_H are available.
		/// </summary>
		/// <param name="face">The face object to test.</param>
		/// <returns>True if the face has the SFNT flag set, false otherwise.</returns>
		public bool IsSFNT(ref Face face)
		{
			return IsSFNT(face.FaceFlags);
		}

		#endregion

		#region IsFixedWidth

		/// <summary>
		/// A macro that returns true whenever a face object contains a font 
		/// face that contains fixed-width (or ‘monospace’, ‘fixed-pitch’, 
		/// etc.) glyphs.
		/// </summary>
		/// <param name="face">The flags for a face.</param>
		/// <returns>True if the face has the fixed width flag set, false otherwise.</returns>
		public bool IsFixedWidth(FaceFlags face)
		{
			return (face & FaceFlags.FixedWidth) == FaceFlags.FixedWidth;
		}

		/// <summary>
		/// A macro that returns true whenever a face object contains a font 
		/// face that contains fixed-width (or ‘monospace’, ‘fixed-pitch’, 
		/// etc.) glyphs.
		/// </summary>
		/// <param name="face">The face object to test.</param>
		/// <returns>True if the face has the fixed width flag set, false otherwise.</returns>
		public bool IsFixedWidth(ref Face face)
		{
			return IsFixedWidth(face.FaceFlags);
		}

		#endregion

		#region HasFixedSizes

		/// <summary>
		/// A macro that returns true whenever a face object contains some 
		/// embedded bitmaps.
		/// </summary>
		/// <param name="face">The flags for a face.</param>
		/// <returns>True if the face has the fixed sizes flag set, false otherwise.</returns>
		/// <see cref="Face.AvailableSizes"/>
		public bool HasFixedSizes(FaceFlags face)
		{
			return (face & FaceFlags.FixedSizes) == FaceFlags.FixedSizes;
		}

		/// <summary>
		/// A macro that returns true whenever a face object contains some 
		/// embedded bitmaps.
		/// </summary>
		/// <param name="face">The face object to test.</param>
		/// <returns>True if the face has the fixed sizes flag set, false otherwise.</returns>
		/// <see cref="Face.AvailableSizes"/>
		public bool HasFixedSizes(ref Face face)
		{
			return HasFixedSizes(face.FaceFlags);
		}

		#endregion

		#region HasGlyphNames

		/// <summary>
		/// A macro that returns true whenever a face object contains some 
		/// glyph names that can be accessed through 
		/// <see cref="GetGlyphName"/>.
		/// </summary>
		/// <param name="face">The flags for a face.</param>
		/// <returns>True if the face has the glyph names flag set, false otherwise.</returns>
		public bool HasGlyphNames(FaceFlags face)
		{
			return (face & FaceFlags.GlyphNames) == FaceFlags.GlyphNames;
		}

		/// <summary>
		/// A macro that returns true whenever a face object contains some 
		/// glyph names that can be accessed through 
		/// <see cref="GetGlyphName"/>.
		/// </summary>
		/// <param name="face">The face object to test.</param>
		/// <returns>True if the face has the glyph names flag set, false otherwise.</returns>
		public bool HasGlyphNames(ref Face face)
		{
			return HasGlyphNames(face.FaceFlags);
		}

		#endregion

		#region HasMultipleMasters

		/// <summary>
		/// A macro that returns true whenever a face object contains some 
		/// multiple masters. The functions provided by FT_MULTIPLE_MASTERS_H
		/// are then available to choose the exact design you want.
		/// </summary>
		/// <param name="face">The flags for a face.</param>
		/// <returns>True if the face has the multiple masters flag set, false otherwise.</returns>
		public bool HasMultipleMasters(FaceFlags face)
		{
			return (face & FaceFlags.MultipleMasters) == FaceFlags.MultipleMasters;
		}

		/// <summary>
		/// A macro that returns true whenever a face object contains some
		/// multiple masters. The functions provided by FT_MULTIPLE_MASTERS_H
		/// are then available to choose the exact design you want.
		/// </summary>
		/// <param name="face">The face object to test.</param>
		/// <returns>True if the face has the multiple masters flag set, false otherwise.</returns>
		public bool HasMultipleMasters(ref Face face)
		{
			return HasMultipleMasters(face.FaceFlags);
		}

		#endregion

		#region IsCIDKeyed

		/// <summary>
		/// A macro that returns true whenever a face object contains a 
		/// CID-keyed font. See the discussion of FT_FACE_FLAG_CID_KEYED for 
		/// more details.
		/// 
		/// If this macro is true, all functions defined in FT_CID_H are 
		/// available.
		/// </summary>
		/// <param name="face">The flags for a face.</param>
		/// <returns>True if the face has the CID-keyed flag set, false otherwise.</returns>
		public bool IsCIDKeyed(FaceFlags face)
		{
			return (face & FaceFlags.CIDKeyed) == FaceFlags.CIDKeyed;
		}

		/// <summary>
		/// A macro that returns true whenever a face object contains a 
		/// CID-keyed font. See the discussion of FT_FACE_FLAG_CID_KEYED for 
		/// more details.
		/// 
		/// If this macro is true, all functions defined in FT_CID_H are 
		/// available.
		/// </summary>
		/// <param name="face">The face object to test.</param>
		/// <returns>True if the face has the CID-keyed flag set, false otherwise.</returns>
		public bool IsCIDKeyed(ref Face face)
		{
			return IsCIDKeyed(face.FaceFlags);
		}

		#endregion

		#region IsTricky

		/// <summary>
		/// A macro that returns true whenever a face represents a ‘tricky’ font. See the discussion of FT_FACE_FLAG_TRICKY for more details.
		/// </summary>
		/// <param name="face">The flags for a face.</param>
		/// <returns>True if the face has the tricky flag set, false otherwise.</returns>
		public bool IsTricky(FaceFlags face)
		{
			return (face & FaceFlags.Tricky) == FaceFlags.Tricky;
		}

		/// <summary>
		/// A macro that returns true whenever a face represents a ‘tricky’ font. See the discussion of FT_FACE_FLAG_TRICKY for more details.
		/// </summary>
		/// <param name="face">The face object to test.</param>
		/// <returns>True if the face has the tricky flag set, false otherwise.</returns>
		public bool IsTricky(ref Face face)
		{
			return IsTricky(face.FaceFlags);
		}

		#endregion

		#endregion

		/// <summary>
		/// Initialize a new FreeType library object. The set of modules that
		/// are registered by this function is determined at build time.
		/// </summary>
		/// <param name="alibrary">A handle to a new library object.</param>
		public static void InitFreeType(out IntPtr library)
		{
			Error err = FT_Init_FreeType(out library);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// Destroy a given FreeType library object and all of its children, 
		/// including resources, drivers, faces, sizes, etc.
		/// </summary>
		/// <param name="library">A handle to the target library object.</param>
		public static void DoneFreeType(IntPtr library)
		{
			Error err = FT_Done_FreeType(library);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// This function calls <see cref="OpenFace"/> to open a font by its 
		/// pathname.
		/// </summary>
		/// <param name="library">A handle to the library resource.</param>
		/// <param name="filepathname">A path to the font file.</param>
		/// <param name="faceIndex">The index of the face within the font. The first face has index 0.</param>
		/// <param name="aface"> A handle to a new face object. If faceIndex is greater than or equal to zero, it must be non-NULL.</param>
		/// <see cref="OpenFace"/>
		public static void NewFace(IntPtr library, string filepathname, int faceIndex, out Face face)
		{
			Error err = FT_New_Face(library, filepathname, faceIndex, out face);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// This function calls <see cref="OpenFace"/> to open a font which has
		/// been loaded into memory.
		/// </summary>
		/// <remarks>
		/// You must not deallocate the memory before calling
		/// <see cref="DoneFace"/>.
		/// </remarks>
		/// <param name="library">A handle to the library resource</param>
		/// <param name="fileBase">A pointer to the beginning of the font data</param>
		/// <param name="fileSize">The size of the memory chunk used by the font data</param>
		/// <param name="faceIndex">The index of the face within the font. The first face has index 0</param>
		/// <param name="aface">A handle to a new face object. If faceIndex is greater than or equal to zero, it must be non-NULL.</param>
		/// <see cref="OpenFace"/>
		public static void NewMemoryFace(IntPtr library, ref byte[] fileBase, int fileSize, int faceIndex, out Face face)
		{
			Error err = FT_New_Memory_Face(library, fileBase, fileSize, faceIndex, out face);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// Create a <see cref="Face"/> object from a given resource described
		/// by <see cref="OpenArgs"/>.
		/// </summary>
		/// <remarks>
		/// Unlike FreeType 1.x, this function automatically creates a glyph
		/// slot for the face object which can be accessed directly through
		/// <see cref="Face.Glyph"/>.
		/// 
		/// OpenFace can be used to quickly check whether the font format of
		/// a given font resource is supported by FreeType. If the faceIndex 
		/// field is negative, the function's return value is 0 if the font 
		/// format is recognized, or non-zero otherwise; the function returns 
		/// a more or less empty face handle in ‘*aface’ (if ‘aface’ isn't 
		/// NULL). The only useful field in this special case is 
		/// <see cref="Face.FaceCount"/> which gives the number of faces within
		/// the font file. After examination, the returned FT_Face structure
		/// should be deallocated with a call to <see cref="DoneFace"/>.
		/// 
		/// Each new face object created with this function also owns a default
		/// <see cref="Size"/> object, accessible as <see cref="Face.Size"/>.
		/// 
		/// See the discussion of reference counters in the description of 
		/// FT_Reference_Face.
		/// </remarks>
		/// <param name="library">A handle to the library resource</param>
		/// <param name="args">A pointer to an <see cref="OpenArgs"/> structure which must be filled by the caller.</param>
		/// <param name="faceIndex">The index of the face within the font. The first face has index 0.</param>
		/// <param name="aface">A handle to a new face object. If ‘face_index’ is greater than or equal to zero, it must be non-NULL.</param>
		public static void OpenFace(IntPtr library, ref OpenArgs args, int faceIndex, out Face face)
		{
			Error err = FT_Open_Face(library, ref args, faceIndex, out face);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// This function calls <see cref="AttachStream"/> to attach a file.
		/// </summary>
		/// <param name="face">The target face object.</param>
		/// <param name="filepathname">The pathname.</param>
		public static void AttachFile(ref Face face, string path)
		{
			Error err = FT_Attach_File(ref face, path);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// ‘Attach’ data to a face object. Normally, this is used to read
		/// additional information for the face object. For example, you can
		/// attach an AFM file that comes with a Type 1 font to get the kerning
		/// values and other metrics.
		/// </summary>
		/// <remarks>
		/// The meaning of the ‘attach’ (i.e., what really happens when the new
		/// file is read) is not fixed by FreeType itself. It really depends on
		/// the font format (and thus the font driver).
		/// 
		/// Client applications are expected to know what they are doing when
		/// invoking this function. Most drivers simply do not implement file
		/// attachments.
		/// </remarks>
		/// <param name="face">The target face object.</param>
		/// <param name="parameters">A pointer to <see cref="OpenArgs"/> which must be filled by the caller.</param>
		public static void AttachStream(ref Face face, ref OpenArgs parameters)
		{
			Error err = FT_Attach_Stream(ref face, ref parameters);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// A counter gets initialized to 1 at the time an FT_Face structure is
		/// created. This function increments the counter. FT_Done_Face then
		/// only destroys a face if the counter is 1, otherwise it simply
		/// decrements the counter.
		/// 
		/// This function helps in managing life-cycles of structures which
		/// reference FT_Face objects.
		/// </summary>
		/// <param name="face">A handle to a target face object.</param>
		public static void ReferenceFace(ref Face face)
		{
			Error err = FT_Reference_Face(ref face);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// Discard a given face object, as well as all of its child slots and sizes.
		/// </summary>
		/// <param name="face">A handle to a target face object.</param>
		public static void DoneFace(ref Face face)
		{
			Error err = FT_Done_Face(ref face);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// Select a bitmap strike.
		/// </summary>
		/// <param name="face">A handle to a target face object.</param>
		/// <param name="strikeIndex">The index of the bitmap strike in the <see cref="Face.AvailableSizes"/> field of <see cref="Face"/> structure.</param>
		public static void SelectSize(ref Face face, int strikeIndex)
		{
			Error err = FT_Select_Size(ref face, strikeIndex);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// Resize the scale of the active FT_Size object in a face.
		/// </summary>
		/// <param name="face">A handle to a target face object.</param>
		/// <param name="request">A pointer to a <see cref="SizeRequest"/>.</param>
		public static void RequestSize(ref Face face, ref SizeRequest request)
		{
			Error err = FT_Request_Size(ref face, ref request);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// This function calls FT_Request_Size to request the nominal size (in
		/// points).
		/// </summary>
		/// <remarks>
		/// If either the character width or height is zero, it is set equal to
		/// the other value.
		/// 
		/// If either the horizontal or vertical resolution is zero, it is set
		/// equal to the other value.
		/// 
		/// A character width or height smaller than 1pt is set to 1pt; if both
		/// resolution values are zero, they are set to 72dpi.
		/// </remarks>
		/// <param name="face">A handle to a target face object</param>
		/// <param name="char_width">The nominal width, in 26.6 fractional points.</param>
		/// <param name="char_height">The nominal height, in 26.6 fractional points.</param>
		/// <param name="horz_resolution">The horizontal resolution in dpi.</param>
		/// <param name="vert_resolution">The vertical resolution in dpi.</param>
		public static void SetCharSize(ref Face face, int charWidth, int charHeight, uint horizontalRes, uint verticalRes)
		{
			Error err = FT_Set_Char_Size(ref face, charWidth, charHeight, horizontalRes, verticalRes);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// This function calls <see cref="RequestSize"/> to request the
		/// nominal size (in pixels).
		/// </summary>
		/// <param name="face">A handle to the target face object.</param>
		/// <param name="pixel_width">The nominal width, in pixels.</param>
		/// <param name="pixel_height">The nominal height, in pixels</param>
		public static void SetPixelSizes(ref Face face, uint pixelWidth, uint pixelHeight)
		{
			Error err = FT_Set_Pixel_Sizes(ref face, pixelWidth, pixelHeight);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// A function used to load a single glyph into the glyph slot of a
		/// face object.
		/// </summary>
		/// <remarks>
		/// The loaded glyph may be transformed. See FT_Set_Transform for the
		/// details.
		/// 
		/// For subsetted CID-keyed fonts, ‘FT_Err_Invalid_Argument’ is
		/// returned for invalid CID values (this is, for CID values which
		/// don't have a corresponding glyph in the font). See the discussion
		/// of the FT_FACE_FLAG_CID_KEYED flag for more details.
		/// </remarks>
		/// <param name="face">A handle to the target face object where the glyph is loaded.</param>
		/// <param name="glyphIndex">The index of the glyph in the font file. For CID-keyed fonts (either in PS or in CFF format) this argument specifies the CID value.</param>
		/// <param name="flags">A flag indicating what to load for this glyph. The FT_LOAD_XXX constants can be used to control the glyph loading process (e.g., whether the outline should be scaled, whether to load bitmaps or not, whether to hint the outline, etc).</param>
		/// <param name="target">The target to OR with the flags.</param>
		public static void LoadGlyph(ref Face face, uint glyphIndex, LoadFlags flags, LoadTarget target)
		{
			Error err = FT_Load_Glyph(ref face, glyphIndex, (int)flags | (int)target);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// A function used to load a single glyph into the glyph slot of a
		/// face object, according to its character code.
		/// </summary>
		/// <remarks>
		/// This function simply calls <see cref="GetCharIndex"/> and
		/// <see cref="LoadGlyph"/>
		/// </remarks>
		/// <param name="face">A handle to a target face object where the glyph is loaded.</param>
		/// <param name="charCode">The glyph's character code, according to the current charmap used in the face.</param>
		/// <param name="flags">A flag indicating what to load for this glyph. The FT_LOAD_XXX constants can be used to control the glyph loading process (e.g., whether the outline should be scaled, whether to load bitmaps or not, whether to hint the outline, etc).</param>
		/// <param name="target">The target to OR with the flags.</param>
		public static void LoadChar(ref Face face, uint charCode, LoadFlags flags, LoadTarget target)
		{
			Error err = FT_Load_Char(ref face, charCode, (int)flags | (int)target);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// A function used to set the transformation that is applied to glyph
		/// images when they are loaded into a glyph slot through
		/// FT_Load_Glyph.
		/// </summary>
		/// <remarks>
		/// The transformation is only applied to scalable image formats after
		/// the glyph has been loaded. It means that hinting is unaltered by
		/// the transformation and is performed on the character size given in
		/// the last call to FT_Set_Char_Size or FT_Set_Pixel_Sizes.
		/// 
		/// Note that this also transforms the ‘face.glyph.advance’ field, but
		/// not the values in ‘face.glyph.metrics’.
		/// </remarks>
		/// <param name="face">A handle to the source face object.</param>
		/// <param name="matrix">A pointer to the transformation's 2x2 matrix. Use 0 for the identity matrix.</param>
		/// <param name="delta">A pointer to the translation vector. Use 0 for the null vector.</param>
		public static void SetTransform(ref Face face, ref Matrix2i matrix, ref Vector2i delta)
		{
			FT_Set_Transform(ref face, ref matrix, ref delta);
		}

		/// <summary>
		/// Convert a given glyph image to a bitmap. It does so by inspecting
		/// the glyph image format, finding the relevant renderer, and invoking
		/// it.
		/// </summary>
		/// <param name="slot">A handle to the glyph slot containing the image to convert.</param>
		/// <param name="mode">This is the render mode used to render the glyph image into a bitmap.</param>
		public static void RenderGlyph(ref GlyphSlot slot, RenderMode mode)
		{
			Error err = FT_Render_Glyph(ref slot, mode);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// Return the kerning vector between two glyphs of a same face.
		/// </summary>
		/// <remarks>
		/// Only horizontal layouts (left-to-right & right-to-left) are
		/// supported by this method. Other layouts, or more sophisticated
		/// kernings, are out of the scope of this API function -- they can be
		/// implemented through format-specific interfaces.
		/// </remarks>
		/// <param name="face">A handle to a source face object.</param>
		/// <param name="leftGlyph">The index of the left glyph in the kern pair.</param>
		/// <param name="rightGlyph">The index of the right glyph in the kern pair.</param>
		/// <param name="mode">Determines the scale and dimension of the returned kerning vector.</param>
		/// <param name="kerning">The kerning vector. This is either in font units or in pixels (26.6 format) for scalable formats, and in pixels for fixed-sizes formats.</param>
		public static void GetKerning(ref Face face, uint leftGlyph, uint rightGlyph, KerningMode mode, out Vector2i kerning)
		{
			Error err = FT_Get_Kerning(ref face, leftGlyph, rightGlyph, mode, out kerning);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// Return the track kerning for a given face object at a given size.
		/// </summary>
		/// <param name="face">A handle to a source face object.</param>
		/// <param name="pointSize">The point size in 16.16 fractional points.</param>
		/// <param name="degree">The degree of tightness.</param>
		/// <param name="kerning">The kerning in 16.16 fractional points.</param>
		public static void GetTrackKerning(ref Face face, int pointSize, int degree, out int kerning)
		{
			Error err = FT_Get_Track_Kerning(ref face, pointSize, degree, out kerning);

			if (err != Error.Ok)
				throw new FreeTypeException(err);
		}

		/// <summary>
		/// Retrieve the ASCII name of a given glyph in a face. This only works
		/// for those faces where FT_HAS_GLYPH_NAMES(face) returns 1.
		/// </summary>
		/// <remarks>
		/// An error is returned if the face doesn't provide glyph names or if
		/// the glyph index is invalid. In all cases of failure, the first byte
		/// of ‘buffer’ is set to 0 to indicate an empty name.
		/// 
		/// The glyph name is truncated to fit within the buffer if it is too
		/// long. The returned string is always zero-terminated.
		/// 
		/// Be aware that FreeType reorders glyph indices internally so that
		/// glyph index 0 always corresponds to the ‘missing glyph’ (called
		/// ‘.notdef’).
		/// 
		/// This function is not compiled within the library if the config
		/// macro ‘FT_CONFIG_OPTION_NO_GLYPH_NAMES’ is defined in
		/// ‘include/freetype/config/ftoptions.h’.
		/// </remarks>
		/// <param name="face">A handle to a source face object.</param>
		/// <param name="glyphIndex">The glyph index.</param>
		/// <returns>The ASCII name of a given glyph in a face.</returns>
		public static string GetGlyphName(ref Face face, uint glyphIndex)
		{
			//TODO implement this method
			return string.Empty;
		}
	}
}
