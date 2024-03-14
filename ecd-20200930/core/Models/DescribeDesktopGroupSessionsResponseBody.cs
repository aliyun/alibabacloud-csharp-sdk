// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopGroupSessionsResponseBody : TeaModel {
        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results.
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

        /// <summary>
        /// The sessions.
        /// </summary>
        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<DescribeDesktopGroupSessionsResponseBodySessions> Sessions { get; set; }
        public class DescribeDesktopGroupSessionsResponseBodySessions : TeaModel {
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
            /// The version of the client.
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// The ID of the desktop group.
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// The name of the desktop group.
            /// </summary>
            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            /// <summary>
            /// If the session is being established, the value of this parameter indicates the ID of the current cloud desktop. If the session is disconnected, the value of this parameter indicates the ID of the cloud desktop that was most recently connected.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The point in time when the end user applies for administrator assistance.
            /// </summary>
            [NameInMap("EndUserApplyCoordinateTime")]
            [Validation(Required=false)]
            public long? EndUserApplyCoordinateTime { get; set; }

            /// <summary>
            /// The ID of the end user.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The end time of the most recent connection.
            /// </summary>
            [NameInMap("LastSessionEndTime")]
            [Validation(Required=false)]
            public string LastSessionEndTime { get; set; }

            /// <summary>
            /// The start time of the most recent connection.
            /// </summary>
            [NameInMap("LastSessionStartTime")]
            [Validation(Required=false)]
            public string LastSessionStartTime { get; set; }

            /// <summary>
            /// The duration of the most recent session.
            /// </summary>
            [NameInMap("LatestConnectionTime")]
            [Validation(Required=false)]
            public long? LatestConnectionTime { get; set; }

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
            /// The OS. Valid values:
            /// 
            /// *   Windows
            /// *   Linux
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// The type of the session.
            /// 
            /// Valid values:
            /// 
            /// *   0
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     single-session
            /// 
            ///     <!-- -->
            /// 
            /// *   1
            /// 
            ///     <!-- -->
            /// 
            ///     :
            /// 
            ///     <!-- -->
            /// 
            ///     multi-session
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public int? OwnType { get; set; }

            /// <summary>
            /// The type of the protocol.
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// The duration during which the cloud desktop stays in the Idle state.
            /// </summary>
            [NameInMap("SessionIdleTime")]
            [Validation(Required=false)]
            public long? SessionIdleTime { get; set; }

            /// <summary>
            /// The state of the session.
            /// 
            /// Valid values:
            /// 
            /// *   Connected
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Disconnected
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            /// <summary>
            /// The total duration of the sessions.
            /// </summary>
            [NameInMap("TotalConnectionDuration")]
            [Validation(Required=false)]
            public long? TotalConnectionDuration { get; set; }

        }

        /// <summary>
        /// The total number of sessions.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
