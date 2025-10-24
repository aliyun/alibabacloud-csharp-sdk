// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeGlobalDesktopRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Sessions")]
        [Validation(Required=false)]
        public List<DescribeGlobalDesktopRecordsResponseBodySessions> Sessions { get; set; }
        public class DescribeGlobalDesktopRecordsResponseBodySessions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Connected</para>
            /// </summary>
            [NameInMap("ConnectionStatus")]
            [Validation(Required=false)]
            public string ConnectionStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dg-iaqu3bi2xtie****</para>
            /// </summary>
            [NameInMap("DesktopGroupId")]
            [Validation(Required=false)]
            public string DesktopGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DemoCCGroup</para>
            /// </summary>
            [NameInMap("DesktopGroupName")]
            [Validation(Required=false)]
            public string DesktopGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecd-g6t1ukbaea****</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DemoComputer</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DesktopStatus")]
            [Validation(Required=false)]
            public string DesktopStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestUser</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("EndUserIds")]
            [Validation(Required=false)]
            public List<string> EndUserIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8GiB</para>
            /// </summary>
            [NameInMap("GpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("LatestConnectionTime")]
            [Validation(Required=false)]
            public long? LatestConnectionTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4096</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public long? Memory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-8904****</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestOfficeSite</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Windows 10</para>
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ASP</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ResourceGroups")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopRecordsResponseBodySessionsResourceGroups> ResourceGroups { get; set; }
            public class DescribeGlobalDesktopRecordsResponseBodySessionsResourceGroups : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>rg-f3s3dgt8dtb0vlqc8</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dms_test</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("SessionIdleTime")]
            [Validation(Required=false)]
            public long? SessionIdleTime { get; set; }

            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeGlobalDesktopRecordsResponseBodySessionsSessions> Sessions { get; set; }
            public class DescribeGlobalDesktopRecordsResponseBodySessionsSessions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TestUser</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-08-31T06:56:45Z</para>
                /// </summary>
                [NameInMap("EstablishmentTime")]
                [Validation(Required=false)]
                public string EstablishmentTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1760583xxxx</para>
            /// </summary>
            [NameInMap("StatusChangeTime")]
            [Validation(Required=false)]
            public long? StatusChangeTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>monthPackage</para>
            /// </summary>
            [NameInMap("SubPayType")]
            [Validation(Required=false)]
            public string SubPayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>240</para>
            /// </summary>
            [NameInMap("TotalConnectionTime")]
            [Validation(Required=false)]
            public long? TotalConnectionTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("UpTime")]
            [Validation(Required=false)]
            public long? UpTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
