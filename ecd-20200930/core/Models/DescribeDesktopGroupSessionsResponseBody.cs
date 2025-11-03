// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopGroupSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0920845-7359-59FC-9899-B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The sessions.</para>
        /// </summary>
        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<DescribeDesktopGroupSessionsResponseBodySessions> Sessions { get; set; }
        public class DescribeDesktopGroupSessionsResponseBodySessions : TeaModel {
            /// <summary>
            /// <para>账号类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The IP address of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.21.XX.XX</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            /// <summary>
            /// <para>The operating system of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>windows_\&quot;Windows10Enterprise\&quot;10.0(Build22000)</para>
            /// </summary>
            [NameInMap("ClientOS")]
            [Validation(Required=false)]
            public string ClientOS { get; set; }

            /// <summary>
            /// <para>The version of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0-R-20221030.08****</para>
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// <para>The ID of the shared cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dg-iaqu3bi2xtie****</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer share.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            /// <summary>
            /// <para>If the session status is Connected, it indicates the ID of the cloud computer that is currently connected. If the session status is Disconnected, it indicates the ID of the cloud computer that was last connected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-g6t1ukbaea****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>办公网络类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The point in time when the end user applies for administrator assistance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1678794261000</para>
            /// </summary>
            [NameInMap("EndUserApplyCoordinateTime")]
            [Validation(Required=false)]
            public long? EndUserApplyCoordinateTime { get; set; }

            /// <summary>
            /// <para>The user ID of the terminal that connects to the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xianqiu</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The end time of the most recent connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-31 06:56:45</para>
            /// </summary>
            [NameInMap("LastSessionEndTime")]
            [Validation(Required=false)]
            public string LastSessionEndTime { get; set; }

            /// <summary>
            /// <para>The start time of the most recent connection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-08-31 06:56:45</para>
            /// </summary>
            [NameInMap("LastSessionStartTime")]
            [Validation(Required=false)]
            public string LastSessionStartTime { get; set; }

            /// <summary>
            /// <para>The duration of the most recent session. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("LatestConnectionTime")]
            [Validation(Required=false)]
            public long? LatestConnectionTime { get; set; }

            /// <summary>
            /// <para>The office network ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-8904****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The office network name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>The operating system type of the cloud computer.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>linux.</description></item>
            /// <item><description>Windows.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The type of the session.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: single-session</description></item>
            /// <item><description>1: multi-session</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public int? OwnType { get; set; }

            /// <summary>
            /// <para>The protocol type supported by the rule.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>High-definition Experience (HDX).</description></item>
            /// <item><description>ASP.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The idle duration of the cloud computer. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("SessionIdleTime")]
            [Validation(Required=false)]
            public long? SessionIdleTime { get; set; }

            /// <summary>
            /// <para>The state of the session.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Connected</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Disconnected</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            /// <summary>
            /// <para>Terminal Info</para>
            /// </summary>
            [NameInMap("TerminalInfo")]
            [Validation(Required=false)]
            public DescribeDesktopGroupSessionsResponseBodySessionsTerminalInfo TerminalInfo { get; set; }
            public class DescribeDesktopGroupSessionsResponseBodySessionsTerminalInfo : TeaModel {
                /// <summary>
                /// <para>The type of the terminal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wuying_mac_x86_64</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The terminal type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mac</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <para>Terminal Serial Number</para>
                /// 
                /// <b>Example:</b>
                /// <para>96c530bc-6095-4014-8bbc-d461b8ac****</para>
                /// </summary>
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                /// <summary>
                /// <para>The terminal UUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EBFDC7773BEBAD418A9F89429652****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>The total duration of the sessions. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("TotalConnectionDuration")]
            [Validation(Required=false)]
            public long? TotalConnectionDuration { get; set; }

        }

        /// <summary>
        /// <para>The total number of sessions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
