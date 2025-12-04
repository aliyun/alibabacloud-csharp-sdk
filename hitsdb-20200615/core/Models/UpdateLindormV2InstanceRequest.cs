// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class UpdateLindormV2InstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("CapacityStorageSize")]
        [Validation(Required=false)]
        public int? CapacityStorageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("CloudStorageSize")]
        [Validation(Required=false)]
        public int? CloudStorageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PerformanceStorage</para>
        /// </summary>
        [NameInMap("CloudStorageType")]
        [Validation(Required=false)]
        public string CloudStorageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCapacityStorage")]
        [Validation(Required=false)]
        public bool? EnableCapacityStorage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<UpdateLindormV2InstanceRequestEngineList> EngineList { get; set; }
        public class UpdateLindormV2InstanceRequestEngineList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            [NameInMap("NodeGroupList")]
            [Validation(Required=false)]
            public List<UpdateLindormV2InstanceRequestEngineListNodeGroupList> NodeGroupList { get; set; }
            public class UpdateLindormV2InstanceRequestEngineListNodeGroupList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ix90Yes</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NodeDiskSize")]
                [Validation(Required=false)]
                public int? NodeDiskSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("NodeDiskType")]
                [Validation(Required=false)]
                public string NodeDiskType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lindorm.g.2xlarge</para>
                /// </summary>
                [NameInMap("NodeSpec")]
                [Validation(Required=false)]
                public string NodeSpec { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>groupName</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

            }

        }

        /// <summary>
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
