// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class CreateResourceRequest : TeaModel {
        /// <summary>
        /// <para>Cluster Description</para>
        /// 
        /// <b>Example:</b>
        /// <para>ppu集群</para>
        /// </summary>
        [NameInMap("ClusterDesc")]
        [Validation(Required=false)]
        public string ClusterDesc { get; set; }

        /// <summary>
        /// <para>Cluster ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-sh-fj71c0ycfw</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Cluster Name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tre-1-ppu</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>Machine Types</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public CreateResourceRequestMachineTypes MachineTypes { get; set; }
        public class CreateResourceRequestMachineTypes : TeaModel {
            /// <summary>
            /// <para>Number of Network Bonds</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BondNum")]
            [Validation(Required=false)]
            public int? BondNum { get; set; }

            /// <summary>
            /// <para>CPU Information</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2x Intel Saphhire Rapid 8469C 48C CPU</para>
            /// </summary>
            [NameInMap("CpuInfo")]
            [Validation(Required=false)]
            public string CpuInfo { get; set; }

            /// <summary>
            /// <para>Disk Information</para>
            /// 
            /// <b>Example:</b>
            /// <para>2x 480GB SATA SSD \n 4x 3.84TB NVMe SSD</para>
            /// </summary>
            [NameInMap("DiskInfo")]
            [Validation(Required=false)]
            public string DiskInfo { get; set; }

            /// <summary>
            /// <para>GPU Information</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8x NVIDIA SXM4 80GB A100 GPU</para>
            /// </summary>
            [NameInMap("GpuInfo")]
            [Validation(Required=false)]
            public string GpuInfo { get; set; }

            /// <summary>
            /// <para>Memory Information</para>
            /// 
            /// <b>Example:</b>
            /// <para>32x 64GB DDR4 4800 Memory</para>
            /// </summary>
            [NameInMap("MemoryInfo")]
            [Validation(Required=false)]
            public string MemoryInfo { get; set; }

            /// <summary>
            /// <para>Specification Name</para>
            /// 
            /// <b>Example:</b>
            /// <para>efg1.nvga1n</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Network Information</para>
            /// 
            /// <b>Example:</b>
            /// <para>1x 200Gbps Dual Port BF3 DPU for VPC\\n4x 200Gbps Dual Port EIC</para>
            /// </summary>
            [NameInMap("NetworkInfo")]
            [Validation(Required=false)]
            public string NetworkInfo { get; set; }

            /// <summary>
            /// <para>Network Mode</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NetworkMode")]
            [Validation(Required=false)]
            public string NetworkMode { get; set; }

            /// <summary>
            /// <para>Number of Nodes</para>
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
        /// <para>User Access Parameters</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UserAccessParam")]
        [Validation(Required=false)]
        public CreateResourceRequestUserAccessParam UserAccessParam { get; set; }
        public class CreateResourceRequestUserAccessParam : TeaModel {
            /// <summary>
            /// <para>User ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// <para>User Key</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            /// <summary>
            /// <para>Endpoint</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>Workspace ID</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1245688643</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
