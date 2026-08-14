// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class UpdateLindormV2InstanceRequest : TeaModel {
        /// <summary>
        /// <para>The capacity of the storage-optimized storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("CapacityStorageSize")]
        [Validation(Required=false)]
        public int? CapacityStorageSize { get; set; }

        /// <summary>
        /// <para>The cloud storage capacity. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("CloudStorageSize")]
        [Validation(Required=false)]
        public int? CloudStorageSize { get; set; }

        /// <summary>
        /// <para>The cloud storage class.</para>
        /// <list type="bullet">
        /// <item><description><para><b>PerformanceStorage</b>: performance cloud storage.</para>
        /// </description></item>
        /// <item><description><para><b>StandardStorage</b>: standard cloud storage.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PerformanceStorage</para>
        /// </summary>
        [NameInMap("CloudStorageType")]
        [Validation(Required=false)]
        public string CloudStorageType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable storage-optimized storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCapacityStorage")]
        [Validation(Required=false)]
        public bool? EnableCapacityStorage { get; set; }

        /// <summary>
        /// <para>A list of engine types.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<UpdateLindormV2InstanceRequestEngineList> EngineList { get; set; }
        public class UpdateLindormV2InstanceRequestEngineList : TeaModel {
            /// <summary>
            /// <para>The engine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>TABLE: LindormTable.</para>
            /// </description></item>
            /// <item><description><para>TSDB: LindormTSDB.</para>
            /// </description></item>
            /// <item><description><para>LSEARCH: search engine.</para>
            /// </description></item>
            /// <item><description><para>LTS: LTS engine.</para>
            /// </description></item>
            /// <item><description><para>LVECTOR: vector engine.</para>
            /// </description></item>
            /// <item><description><para>LCOLUMN: column store.</para>
            /// </description></item>
            /// <item><description><para>LAI: AI engine.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>A list of engine node groups.</para>
            /// </summary>
            [NameInMap("NodeGroupList")]
            [Validation(Required=false)]
            public List<UpdateLindormV2InstanceRequestEngineListNodeGroupList> NodeGroupList { get; set; }
            public class UpdateLindormV2InstanceRequestEngineListNodeGroupList : TeaModel {
                /// <summary>
                /// <para>The ID of the node group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ix90Yes</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The number of nodes.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                /// <summary>
                /// <para>The disk size of a single node. This parameter is not required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NodeDiskSize")]
                [Validation(Required=false)]
                public int? NodeDiskSize { get; set; }

                /// <summary>
                /// <para>The disk type of the node. This parameter is not required. <b>This parameter is available only for specific scenarios and is accessible to users on a whitelist.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("NodeDiskType")]
                [Validation(Required=false)]
                public string NodeDiskType { get; set; }

                /// <summary>
                /// <para>The node specifications of the engine.</para>
                /// <list type="bullet">
                /// <item><description><para><b>lindorm.c.2xlarge</b>: 8 cores and 16 GB of memory.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.g.2xlarge</b>: 8 cores and 32 GB of memory.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.c.4xlarge</b>: 16 cores and 32 GB of memory.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.g.4xlarge</b>: 16 cores and 64 GB of memory.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.c.8xlarge</b>: 32 cores and 64 GB of memory.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.g.8xlarge</b>: 32 cores and 128 GB of memory.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lindorm.g.2xlarge</para>
                /// </summary>
                [NameInMap("NodeSpec")]
                [Validation(Required=false)]
                public string NodeSpec { get; set; }

                /// <summary>
                /// <para>The name of the node group. <b>This parameter is required.</b> You can obtain the name by calling the GetLindormV2Instance operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>groupName</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

            }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp1o3y0yme2i2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located. To query the latest region list, call the <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
