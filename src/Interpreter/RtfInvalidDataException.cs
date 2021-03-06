// -- FILE ------------------------------------------------------------------
// name       : RtfInvalidDataException.cs
// project    : RTF Framelet
// created    : Jani Giannoudis - 2009.02.19
// language   : c#
// environment: .NET 2.0
// copyright  : (c) 2004-2013 by Jani Giannoudis, Switzerland
// --------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace Itenso.Rtf.Interpreter
{

	// ------------------------------------------------------------------------
	/// <summary>Thrown upon RTF specific error conditions.</summary>
	[Serializable]
	public class RtfInvalidDataException : RtfInterpreterException
	{

		// ----------------------------------------------------------------------
		/// <summary>Creates a new instance.</summary>
		public RtfInvalidDataException()
		{
		} // RtfInvalidDataException

		// ----------------------------------------------------------------------
		/// <summary>Creates a new instance with the given message.</summary>
		/// <param name="message">the message to display</param>
		public RtfInvalidDataException( string message ) :
			base( message )
		{
		} // RtfInvalidDataException

		// ----------------------------------------------------------------------
		/// <summary>Creates a new instance with the given message, based on the given cause.</summary>
		/// <param name="message">the message to display</param>
		/// <param name="cause">the original cause for this exception</param>
		public RtfInvalidDataException( string message, Exception cause ) :
			base( message, cause )
		{
		} // RtfInvalidDataException

		// ----------------------------------------------------------------------
		/// <summary>Serialization support.</summary>
		/// <param name="info">the info to use for serialization</param>
		/// <param name="context">the context to use for serialization</param>
		protected RtfInvalidDataException( SerializationInfo info, StreamingContext context ) :
			base( info, context )
		{
		} // RtfInvalidDataException

	} // class RtfInvalidDataException

} // namespace Itenso.Rtf
// -- EOF -------------------------------------------------------------------
