// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopSessionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3EC4A6DB-EC8D-55B0-9038-543DE671****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Details of sessions.</para>
        /// </summary>
        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<DescribeDesktopSessionsResponseBodySessions> Sessions { get; set; }
        public class DescribeDesktopSessionsResponseBodySessions : TeaModel {
            /// <summary>
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
            /// <para>The client OS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>windows_\&quot;Windows10Enterprise\&quot;10.0(Build22000)</para>
            /// </summary>
            [NameInMap("ClientOS")]
            [Validation(Required=false)]
            public string ClientOS { get; set; }

            /// <summary>
            /// <para>The client version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0.0-R-20221030.08****</para>
            /// </summary>
            [NameInMap("ClientVersion")]
            [Validation(Required=false)]
            public string ClientVersion { get; set; }

            /// <summary>
            /// <para>The ID of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-g6t1ukbaea****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The name of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDesktop</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The duration of the remote assistance. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("EndUserApplyCoordinateTime")]
            [Validation(Required=false)]
            public long? EndUserApplyCoordinateTime { get; set; }

            /// <summary>
            /// <para>The ID of the end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testUser</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The duration of the last connection to the cloud computer. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("LatestConnectionTime")]
            [Validation(Required=false)]
            public long? LatestConnectionTime { get; set; }

            /// <summary>
            /// <para>The ID of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-8904****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The name of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DemoOfficeSite</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>Indicates whether the switch to check session status of cloud computers is turned on.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OsSessionStatus")]
            [Validation(Required=false)]
            public string OsSessionStatus { get; set; }

            /// <summary>
            /// <para>The OS.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Linux</description></item>
            /// <item><description>Windows</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HDX</description></item>
            /// <item><description>ASP</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            [NameInMap("ResourceGroups")]
            [Validation(Required=false)]
            public List<DescribeDesktopSessionsResponseBodySessionsResourceGroups> ResourceGroups { get; set; }
            public class DescribeDesktopSessionsResponseBodySessionsResourceGroups : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-8whrmo2gtsb8bxxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RgTest</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The end time of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-28T02:31:43Z</para>
            /// </summary>
            [NameInMap("SessionEndTime")]
            [Validation(Required=false)]
            public string SessionEndTime { get; set; }

            /// <summary>
            /// <para>The idle duration of the session. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("SessionIdleTime")]
            [Validation(Required=false)]
            public long? SessionIdleTime { get; set; }

            /// <summary>
            /// <para>The start time of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-28T02:31:43Z</para>
            /// </summary>
            [NameInMap("SessionStartTime")]
            [Validation(Required=false)]
            public string SessionStartTime { get; set; }

            /// <summary>
            /// <para>The state of the session.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Connected</description></item>
            /// <item><description>Disconnected</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            /// <summary>
            /// <para>The billing method of cloud computers.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>duration: hourly plan (available for users in the whitelist)</description></item>
            /// <item><description>postPaid: pay-as-you-go</description></item>
            /// <item><description>monthPackage: monthly subscription (120-hour computing plan and 250-hour computing plan)</description></item>
            /// <item><description>prePaid: monthly subscription (Unlimited computing plan)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>monthPackage</para>
            /// </summary>
            [NameInMap("SubPayType")]
            [Validation(Required=false)]
            public string SubPayType { get; set; }

            [NameInMap("TerminalInfo")]
            [Validation(Required=false)]
            public DescribeDesktopSessionsResponseBodySessionsTerminalInfo TerminalInfo { get; set; }
            public class DescribeDesktopSessionsResponseBodySessionsTerminalInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Mac</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Mac</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>96c530bc-6095-4014-8bbc-d461b8ac****</para>
                /// </summary>
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EBFDC7773BEBAD418A9F89429652****</para>
                /// </summary>
                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            /// <summary>
            /// <para>The total connection duration. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>240</para>
            /// </summary>
            [NameInMap("TotalConnectionTime")]
            [Validation(Required=false)]
            public long? TotalConnectionTime { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
