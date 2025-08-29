// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListWuyingServerResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("WuyingServerList")]
        [Validation(Required=false)]
        public List<ListWuyingServerResponseBodyWuyingServerList> WuyingServerList { get; set; }
        public class ListWuyingServerResponseBodyWuyingServerList : TeaModel {
            [NameInMap("AddVirtualNodePoolStatus")]
            [Validation(Required=false)]
            public string AddVirtualNodePoolStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("BizRegionId")]
            [Validation(Required=false)]
            public string BizRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-08-02T16:52:11.000+00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DataDisk")]
            [Validation(Required=false)]
            public List<ListWuyingServerResponseBodyWuyingServerListDataDisk> DataDisk { get; set; }
            public class ListWuyingServerResponseBodyWuyingServerListDataDisk : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_auto</para>
                /// </summary>
                [NameInMap("DataDiskCategory")]
                [Validation(Required=false)]
                public string DataDiskCategory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PL0</para>
                /// </summary>
                [NameInMap("DataDiskPerformanceLevel")]
                [Validation(Required=false)]
                public string DataDiskPerformanceLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("DataDiskSize")]
                [Validation(Required=false)]
                public int? DataDiskSize { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-09-03T16:00:00.000+00:00</para>
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>imgc-06****oagaev</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            [NameInMap("InstanceInfoList")]
            [Validation(Required=false)]
            public List<ListWuyingServerResponseBodyWuyingServerListInstanceInfoList> InstanceInfoList { get; set; }
            public class ListWuyingServerResponseBodyWuyingServerListInstanceInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>p-0ceitx****c5</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eni-uf65b****dfnt3wb</para>
                /// </summary>
                [NameInMap("NetworkInterfaceId")]
                [Validation(Required=false)]
                public string NetworkInterfaceId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10.80.21.149</para>
            /// </summary>
            [NameInMap("NetworkInterfaceIp")]
            [Validation(Required=false)]
            public string NetworkInterfaceIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou+dir-1b****ayv2</para>
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>exampleOfficeSite</para>
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SIMPLE</para>
            /// </summary>
            [NameInMap("OfficeSiteType")]
            [Validation(Required=false)]
            public string OfficeSiteType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            [NameInMap("SecurityGroupIds")]
            [Validation(Required=false)]
            public List<string> SecurityGroupIds { get; set; }

            [NameInMap("ServerInstanceTypeInfo")]
            [Validation(Required=false)]
            public ListWuyingServerResponseBodyWuyingServerListServerInstanceTypeInfo ServerInstanceTypeInfo { get; set; }
            public class ListWuyingServerResponseBodyWuyingServerListServerInstanceTypeInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>96</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public string Gpu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>196,608</para>
                /// </summary>
                [NameInMap("GpuMemory")]
                [Validation(Required=false)]
                public int? GpuMemory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>393,216</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public int? Memory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eds.proworkstation_flagship_elite_ne.96c384g.192g4x</para>
                /// </summary>
                [NameInMap("ServerInstanceType")]
                [Validation(Required=false)]
                public string ServerInstanceType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cloud_auto</para>
            /// </summary>
            [NameInMap("SystemDiskCategory")]
            [Validation(Required=false)]
            public string SystemDiskCategory { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("SystemDiskPerformanceLevel")]
            [Validation(Required=false)]
            public string SystemDiskPerformanceLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            [NameInMap("VirtualNodePoolId")]
            [Validation(Required=false)]
            public string VirtualNodePoolId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ws-0byd****8wn2lwi</para>
            /// </summary>
            [NameInMap("WuyingServerId")]
            [Validation(Required=false)]
            public string WuyingServerId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>exampleServerName</para>
            /// </summary>
            [NameInMap("WuyingServerName")]
            [Validation(Required=false)]
            public string WuyingServerName { get; set; }

        }

    }

}
