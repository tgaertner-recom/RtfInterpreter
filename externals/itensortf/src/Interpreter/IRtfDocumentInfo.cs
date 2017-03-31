﻿// -- FILE ------------------------------------------------------------------
// name       : IRtfDocumentInfo.cs
// project    : RTF Framelet
// created    : Leon Poyyayil - 2008.05.23
// language   : c#
// environment: .NET 2.0
// copyright  : (c) 2004-2013 by Jani Giannoudis, Switzerland
// --------------------------------------------------------------------------
using System;

namespace Itenso.Rtf
{

	// ------------------------------------------------------------------------
	public interface IRtfDocumentInfo
	{

		// ----------------------------------------------------------------------
		int? Id { get; }

		// ----------------------------------------------------------------------
		int? Version { get; }

		// ----------------------------------------------------------------------
		int? Revision { get; }

		// ----------------------------------------------------------------------
		string Title { get; }

		// ----------------------------------------------------------------------
		string Subject { get; }

		// ----------------------------------------------------------------------
		string Author { get; }

		// ----------------------------------------------------------------------
		string Manager { get; }

		// ----------------------------------------------------------------------
		string Company { get; }

		// ----------------------------------------------------------------------
		string Operator { get; }

		// ----------------------------------------------------------------------
		string Category { get; }

		// ----------------------------------------------------------------------
		string Keywords { get; }

		// ----------------------------------------------------------------------
		string Comment { get; }

		// ----------------------------------------------------------------------
		string DocumentComment { get; }

		// ----------------------------------------------------------------------
		string HyperLinkbase { get; }

		// ----------------------------------------------------------------------
		DateTime? CreationTime { get; }

		// ----------------------------------------------------------------------
		DateTime? RevisionTime { get; }

		// ----------------------------------------------------------------------
		DateTime? PrintTime { get; }

		// ----------------------------------------------------------------------
		DateTime? BackupTime { get; }

		// ----------------------------------------------------------------------
		int? NumberOfPages { get; }

		// ----------------------------------------------------------------------
		int? NumberOfWords { get; }

		// ----------------------------------------------------------------------
		int? NumberOfCharacters { get; }

		// ----------------------------------------------------------------------
		int? EditingTimeInMinutes { get; }

	} // interface IRtfDocumentInfo

} // namespace Itenso.Rtf
// -- EOF -------------------------------------------------------------------
