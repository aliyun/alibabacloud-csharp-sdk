// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ExportClientEventsRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud desktop.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The name of the cloud desktop.
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the [ISO 8601](~~25696~~) standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.
        /// 
        /// If you do not specify a value for this parameter, the current time is used.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the endpoint user.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// The type of event that you want to query. Valid values:
        /// 
        /// *   DESKTOP_CONNECT: The desktop session is established.
        /// *   DESKTOP_DISCONNECT: The desktop session is disconnected.
        /// *   DESKTOP_REBOOT: The cloud desktop is restarted.
        /// *   CLIENT_AD_LOGIN: The AD user logs on to the client.
        /// *   GET_CONNECTION_TICKET: The request to connect to the cloud desktop is sent.
        /// *   DESKTOP_START: The cloud desktop is started.
        /// *   DESKTOP_STOP: The cloud desktop is stopped.
        /// 
        /// If you do not specify a value for this parameter, events of all types are queried.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The types of event.
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public List<string> EventTypes { get; set; }

        /// <summary>
        /// The language in which the cloud desktop is displayed in the console UI. You can export the list of cloud desktops in the specified language. Valid values:
        /// 
        /// *   `zh-CN`: Simplified Chinese
        /// *   `en-GB`: English (United Kingdom)
        /// 
        /// Default value: `zh-CN`.
        /// </summary>
        [NameInMap("LangType")]
        [Validation(Required=false)]
        public string LangType { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// *   Maximum value: 5000.
        /// *   Default value: 5000.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The ID of the workspace.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// The name of the workspace.
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the [ISO 8601](~~25696~~) standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.
        /// 
        /// If you do not specify a value for this parameter, all events that occurred before the point in time that you specify for `EndTime` are queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
