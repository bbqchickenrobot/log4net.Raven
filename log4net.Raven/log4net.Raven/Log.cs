using System;
using log4net.Core;
using log4net.Util;

namespace log4net.Raven
{
	/// <summary>
	/// The log entry document entity that will be stored to the database.
	/// </summary>
	public class Log : INamedDocument
	{
		public Log()
		{
		}

		public Log(string id)
		{
			this.Id = id;
		}

		public Log(LoggingEvent logEvent)
		{
			this.LoggerName = logEvent.LoggerName;
			this.Domain = logEvent.Domain;
			this.Identity = logEvent.Identity;
			this.Level = logEvent.Level.ToString();
			this.ClassName = logEvent.LocationInformation.ClassName;
			this.FileName = logEvent.LocationInformation.FileName;
			this.LineNumber = logEvent.LocationInformation.LineNumber;
			this.FullInfo = logEvent.LocationInformation.FullInfo;
			this.MethodName = logEvent.LocationInformation.MethodName;
			this.Fix = logEvent.Fix;
			this.Properties = logEvent.Properties;
			this.ThreadName = logEvent.ThreadName;
			this.UserName = logEvent.UserName;
			this.Message = logEvent.MessageObject;
			this.TimeStamp = logEvent.TimeStamp;
			this.Exception = logEvent.ExceptionObject;
		}

		public Log(string id, LoggingEvent logEvent) : this(logEvent)
		{
			this.Id = id;
		}

		public DateTime TimeStamp { get; set; }

		public object Message { get; set; }

		public object Exception { get; set; }

		public string LoggerName { get; set; }

		public string Domain { get; set; }

		public string Identity { get; set; }

		public string Level { get; set; }

		public string ClassName { get; set; }

		public string FileName { get; set; }

		public string LineNumber { get; set; }

		public string FullInfo { get; set; }

		public string MethodName { get; set; }

		public FixFlags Fix { get; set; }

		public PropertiesDictionary Properties { get; set; }

		public string UserName { get; set; }

		public string ThreadName { get; set; }

		#region Implementation of IDocument

		public string Id { get; set; }

		#endregion
	}
}