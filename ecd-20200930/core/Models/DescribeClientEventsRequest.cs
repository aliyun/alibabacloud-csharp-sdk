// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeClientEventsRequest : TeaModel {
        /// <summary>
        /// The cloud desktop ID. If you do not specify a value for this parameter, events of all cloud desktops in the specified region are queried.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The IP address of the cloud desktop. If you do not specify a value for this parameter, the events of all cloud desktops in the specified region are queried.
        /// </summary>
        [NameInMap("DesktopIp")]
        [Validation(Required=false)]
        public string DesktopIp { get; set; }

        /// <summary>
        /// The cloud desktop name.
        /// </summary>
        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        /// <summary>
        /// This parameter is not available to the public.
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the [ISO 8601](~~25696~~) standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.\
        /// If you do not specify a value for this parameter, the current time is used.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The information about the end user that connects to the cloud desktop from the Elastic Desktop Service (EDS) client. The information can be a Resource Access Management (RAM) user ID or an Active Directory (AD) username. If you do not specify a value for this parameter, the events of all end users in the specified region are queried.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// The type of the events that you want to query. If you specify multiple values for the EventTypes parameter, the events of all specified types are returned. If you do not specify values for the EventTypes and EventType parameters, all events of end users in the specified region are returned.
        /// 
        /// Valid values:
        /// 
        /// *   DESKTOP_STOP: End users stop the cloud desktop.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   GET_LITE_CONNECTION_TICKET: End users obtain the credential for reconnecting to the cloud desktop upon disconnection.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   DESKTOP_DISCONNECT: End users disconnect desktop sessions.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   GET_CONNECTION_TICKET: End users request to connect to the cloud desktop.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   CLIENT_LOGIN: End users log on to the cloud desktop.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   DESKTOP_REBOOT: End users restart the cloud desktop.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   DESKTOP_CONNECT: End users establish desktop sessions.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   DESKTOP_START: End users start the cloud desktop.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The array of event types that you want to query. You can specify multiple event types. The response contains all or specified types of events.
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public List<string> EventTypes { get; set; }

        /// <summary>
        /// The number of entries per page.\
        /// Default value: 100.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the workspace to which the cloud desktop belongs. If you do not specify a value for this parameter, the events of all workspaces in the specified region are queried.
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// The workspace name.
        /// </summary>
        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the [ISO 8601](~~25696~~) standard in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.\
        /// If you do not specify a value for this parameter, all events that occurred before the point in time that you specify for `EndTime` are queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
