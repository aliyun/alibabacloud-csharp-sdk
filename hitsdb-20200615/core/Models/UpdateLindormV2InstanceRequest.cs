// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class UpdateLindormV2InstanceRequest : TeaModel {
        /// <summary>
        /// <para>The capacity storage space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("CapacityStorageSize")]
        [Validation(Required=false)]
        public int? CapacityStorageSize { get; set; }

        /// <summary>
        /// <para>The cloud storage space. Unit: GB. When you modify the cloud storage space, you must also specify EngineList. The EngineType parameter in EngineList, and the NodeSpec and NodeCount parameters in NodeGroupList are required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("CloudStorageSize")]
        [Validation(Required=false)]
        public int? CloudStorageSize { get; set; }

        /// <summary>
        /// <para>The cloud storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PerformanceStorage</b>: Performance cloud storage.</description></item>
        /// <item><description><b>StandardStorage</b>: Standard cloud storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PerformanceStorage</para>
        /// </summary>
        [NameInMap("CloudStorageType")]
        [Validation(Required=false)]
        public string CloudStorageType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable capacity storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCapacityStorage")]
        [Validation(Required=false)]
        public bool? EnableCapacityStorage { get; set; }

        /// <summary>
        /// <para>The list of engine types.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<UpdateLindormV2InstanceRequestEngineList> EngineList { get; set; }
        public class UpdateLindormV2InstanceRequestEngineList : TeaModel {
            /// <summary>
            /// <para>The engine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TABLE: LindormTable.</description></item>
            /// <item><description>TSDB: LindormTSDB.</description></item>
            /// <item><description>LSEARCH: search engine.</description></item>
            /// <item><description>LTS: Lindorm Tunnel Service.</description></item>
            /// <item><description>LVECTOR: vector engine.</description></item>
            /// <item><description>LCOLUMN: column store engine.</description></item>
            /// <item><description>LAI: AI engine.</description></item>
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
            /// <para>The list of engine node groups.</para>
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
                /// <para>The disk size per node. This parameter is not required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NodeDiskSize")]
                [Validation(Required=false)]
                public int? NodeDiskSize { get; set; }

                /// <summary>
                /// <para>The cloud disk type of the node. This parameter is not required. <b>This parameter is used in special scenarios and is available only after your account is added to the whitelist.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("NodeDiskType")]
                [Validation(Required=false)]
                public string NodeDiskType { get; set; }

                /// <summary>
                /// <para>The node specifications of the engine. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>lindorm.c.2xlarge</b>: 8 vCPUs and 16 GB of memory.</description></item>
                /// <item><description><b>lindorm.g.2xlarge</b>: 8 vCPUs and 32 GB of memory.</description></item>
                /// <item><description><b>lindorm.c.4xlarge</b>: 16 vCPUs and 32 GB of memory.</description></item>
                /// <item><description><b>lindorm.g.4xlarge</b>: 16 vCPUs and 64 GB of memory.</description></item>
                /// <item><description><b>lindorm.c.8xlarge</b>: 32 vCPUs and 64 GB of memory.</description></item>
                /// <item><description><b>lindorm.g.8xlarge</b>: 32 vCPUs and 128 GB of memory.</description></item>
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
                /// <para>The name of the node group. You can call the GetLindormV2InstanceDetails operation to query the name.</para>
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
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> operation to query the region ID. Use this parameter to specify the region where you want to create the instance.</para>
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
