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
        /// <para>The session details.</para>
        /// </summary>
        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<DescribeDesktopSessionsResponseBodySessions> Sessions { get; set; }
        public class DescribeDesktopSessionsResponseBodySessions : TeaModel {
            /// <summary>
            /// <para>The type of the account.</para>
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
            /// <para>DemoComputer</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The type of the office network.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("DirectoryType")]
            [Validation(Required=false)]
            public string DirectoryType { get; set; }

            /// <summary>
            /// <para>The duration of remote assistance initiated by the end user. Unit: seconds.</para>
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
            /// <para>alice</para>
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
            /// <para>The ID of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-8904****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <para>The name of the office site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestOfficeSite</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <para>Indicates the session status of the cloud desktop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OsSessionStatus")]
            [Validation(Required=false)]
            public string OsSessionStatus { get; set; }

            /// <summary>
            /// <para>The operating system type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Windows</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The protocol type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The information about the resource group.</para>
            /// </summary>
            [NameInMap("ResourceGroups")]
            [Validation(Required=false)]
            public List<DescribeDesktopSessionsResponseBodySessionsResourceGroups> ResourceGroups { get; set; }
            public class DescribeDesktopSessionsResponseBodySessionsResourceGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-8whrmo2gtsb8bxxxx</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RgTest</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The time when the session ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-28T02:31:43Z</para>
            /// </summary>
            [NameInMap("SessionEndTime")]
            [Validation(Required=false)]
            public string SessionEndTime { get; set; }

            /// <summary>
            /// <para>The duration for which the session was idle. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("SessionIdleTime")]
            [Validation(Required=false)]
            public long? SessionIdleTime { get; set; }

            /// <summary>
            /// <para>The time when the session started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-28T02:31:43Z</para>
            /// </summary>
            [NameInMap("SessionStartTime")]
            [Validation(Required=false)]
            public string SessionStartTime { get; set; }

            /// <summary>
            /// <para>The connection status of the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("SessionStatus")]
            [Validation(Required=false)]
            public string SessionStatus { get; set; }

            /// <summary>
            /// <para>The billing method of the cloud computer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>monthPackage</para>
            /// </summary>
            [NameInMap("SubPayType")]
            [Validation(Required=false)]
            public string SubPayType { get; set; }

            /// <summary>
            /// <para>The description of the terminal device.</para>
            /// </summary>
            [NameInMap("TerminalInfo")]
            [Validation(Required=false)]
            public DescribeDesktopSessionsResponseBodySessionsTerminalInfo TerminalInfo { get; set; }
            public class DescribeDesktopSessionsResponseBodySessionsTerminalInfo : TeaModel {
                /// <summary>
                /// <para>The model of the terminal device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mac</para>
                /// </summary>
                [NameInMap("Model")]
                [Validation(Required=false)]
                public string Model { get; set; }

                /// <summary>
                /// <para>The type of the terminal device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mac</para>
                /// </summary>
                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <para>The serial number of the terminal device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>96c530bc-6095-4014-8bbc-d461b8ac****</para>
                /// </summary>
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                /// <summary>
                /// <para>The universally unique identifier (UUID) of the logon device.</para>
                /// 
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
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
