// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeClientEventsResponseBody : TeaModel {
        /// <summary>
        /// The information about the events of an end user.
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<DescribeClientEventsResponseBodyEvents> Events { get; set; }
        public class DescribeClientEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account with which the event is associated.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// The number of bytes that are received.
            /// </summary>
            [NameInMap("BytesReceived")]
            [Validation(Required=false)]
            public string BytesReceived { get; set; }

            /// <summary>
            /// The number of bytes that are sent.
            /// </summary>
            [NameInMap("BytesSend")]
            [Validation(Required=false)]
            public string BytesSend { get; set; }

            /// <summary>
            /// The IP address of the client.
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// The OS that the client runs.
            /// </summary>
            [NameInMap("ClientOS")]
            [Validation(Required=false)]
            public string ClientOS { get; set; }

            /// <summary>
            /// The client version.
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// The desktop group ID.
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// The desktop group name.
            /// </summary>
            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            /// <summary>
            /// The cloud desktop ID.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The IP address of the cloud desktop.
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
            /// The ID of the directory to which the cloud desktop belongs.
            /// </summary>
            [NameInMap("DirectoryId")]
            [Validation(Required=false)]
            public string DirectoryId { get; set; }

            /// <summary>
            /// The directory type.
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// The information about the end user that connects to the cloud desktop from the EDS client. The information can be a RAM user ID or an AD username.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The event ID.
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// The time when the event occurred.
            /// </summary>
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            /// <summary>
            /// The event type. Valid values:
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// The ID of the workspace to which the cloud desktop belongs.
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
            /// The account type of the workspace.
            /// 
            /// Valid values:
            /// 
            /// *   SIMPLE: convenience account
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   AD_CONNECTOR: enterprise AD account
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// The region ID.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The status of the event. If you set the EventType parameter to `DESKTOP_DISCONNECT` or `GET_CONNECTION_TICKET`, this parameter is returned. Valid values:
            /// 
            /// *   200\. The value indicates that the request is successful.
            /// *   An error message. The value indicates that the request failed. Example: FailedToGetConnectionTicket.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
