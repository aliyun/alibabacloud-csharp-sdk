// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class GetResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>Access denied information</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResourceResponseBodyData Data { get; set; }
        public class GetResourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Cluster description</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ClusterDesc")]
            [Validation(Required=false)]
            public string ClusterDesc { get; set; }

            /// <summary>
            /// <para>Cluster ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3123121223</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>Cluster name</para>
            /// 
            /// <b>Example:</b>
            /// <para>main_cluster</para>
            /// </summary>
            [NameInMap("ClusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// <para>Used CPU</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("CpuCoreLimit")]
            [Validation(Required=false)]
            public int? CpuCoreLimit { get; set; }

            /// <summary>
            /// <para>Used GPU</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("GpuLimit")]
            [Validation(Required=false)]
            public int? GpuLimit { get; set; }

            /// <summary>
            /// <para>Machine type</para>
            /// </summary>
            [NameInMap("MachineType")]
            [Validation(Required=false)]
            public GetResourceResponseBodyDataMachineType MachineType { get; set; }
            public class GetResourceResponseBodyDataMachineType : TeaModel {
                /// <summary>
                /// <para>Number of network bonds</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("BondNum")]
                [Validation(Required=false)]
                public int? BondNum { get; set; }

                /// <summary>
                /// <para>CPU information</para>
                /// 
                /// <b>Example:</b>
                /// <para>2x Intel Saphhire Rapid 8469C 48C CPU</para>
                /// </summary>
                [NameInMap("CpuInfo")]
                [Validation(Required=false)]
                public string CpuInfo { get; set; }

                /// <summary>
                /// <para>Disk information</para>
                /// 
                /// <b>Example:</b>
                /// <para>2x 480GB SATA SSD\n4x 3.84TB NVMe SSD</para>
                /// </summary>
                [NameInMap("DiskInfo")]
                [Validation(Required=false)]
                public string DiskInfo { get; set; }

                /// <summary>
                /// <para>GPU information</para>
                /// 
                /// <b>Example:</b>
                /// <para>8x OAM 810 GPU</para>
                /// </summary>
                [NameInMap("GpuInfo")]
                [Validation(Required=false)]
                public string GpuInfo { get; set; }

                /// <summary>
                /// <para>Memory information</para>
                /// 
                /// <b>Example:</b>
                /// <para>32x 64GB DDR4 4800 Memory</para>
                /// </summary>
                [NameInMap("MemoryInfo")]
                [Validation(Required=false)]
                public string MemoryInfo { get; set; }

                /// <summary>
                /// <para>Specification name</para>
                /// 
                /// <b>Example:</b>
                /// <para>efg2.p8en</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Network information</para>
                /// 
                /// <b>Example:</b>
                /// <para>1x 200Gbps Dual Port BF3 DPU for VPC\n4x 200Gbps Dual Port EIC</para>
                /// </summary>
                [NameInMap("NetworkInfo")]
                [Validation(Required=false)]
                public string NetworkInfo { get; set; }

                /// <summary>
                /// <para>Network mode</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("NetworkMode")]
                [Validation(Required=false)]
                public string NetworkMode { get; set; }

                /// <summary>
                /// <para>Number of nodes</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                /// <summary>
                /// <para>Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>Private</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Used memory</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("MaxCpuCore")]
            [Validation(Required=false)]
            public int? MaxCpuCore { get; set; }

            /// <summary>
            /// <para>Used memory</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MaxGpu")]
            [Validation(Required=false)]
            public int? MaxGpu { get; set; }

            /// <summary>
            /// <para>Used memory</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("MaxMemory")]
            [Validation(Required=false)]
            public long? MaxMemory { get; set; }

            /// <summary>
            /// <para>Used memory</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("MemoryLimit")]
            [Validation(Required=false)]
            public long? MemoryLimit { get; set; }

            /// <summary>
            /// <para>Cluster ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>189</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public long? ResourceId { get; set; }

            /// <summary>
            /// <para>Cluster name</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.g6.4xlarge</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>List of resource nodes</para>
            /// </summary>
            [NameInMap("ResourceNodes")]
            [Validation(Required=false)]
            public List<GetResourceResponseBodyDataResourceNodes> ResourceNodes { get; set; }
            public class GetResourceResponseBodyDataResourceNodes : TeaModel {
                /// <summary>
                /// <para>Node name</para>
                /// 
                /// <b>Example:</b>
                /// <para>lingj19q90jp66nq-mg2pa0p2l2bipnsi-17</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

            }

            /// <summary>
            /// <para>User authorization parameters</para>
            /// </summary>
            [NameInMap("UserAccessParam")]
            [Validation(Required=false)]
            public GetResourceResponseBodyDataUserAccessParam UserAccessParam { get; set; }
            public class GetResourceResponseBodyDataUserAccessParam : TeaModel {
                /// <summary>
                /// <para>User ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("AccessId")]
                [Validation(Required=false)]
                public string AccessId { get; set; }

                /// <summary>
                /// <para>User key</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AccessKey")]
                [Validation(Required=false)]
                public string AccessKey { get; set; }

                /// <summary>
                /// <para>Endpoint</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                /// <summary>
                /// <para>Workspace ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

            }

        }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>25859897-35C8-5015-8365-7A3CE52F4854</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count of the query</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
