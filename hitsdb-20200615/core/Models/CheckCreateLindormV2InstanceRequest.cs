// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class CheckCreateLindormV2InstanceRequest : TeaModel {
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ArchVersion")]
        [Validation(Required=false)]
        public string ArchVersion { get; set; }

        [NameInMap("CloudStorageSize")]
        [Validation(Required=false)]
        public int? CloudStorageSize { get; set; }

        [NameInMap("CloudStorageType")]
        [Validation(Required=false)]
        public string CloudStorageType { get; set; }

        [NameInMap("ClusterPattern")]
        [Validation(Required=false)]
        public string ClusterPattern { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<CheckCreateLindormV2InstanceRequestEngineList> EngineList { get; set; }
        public class CheckCreateLindormV2InstanceRequestEngineList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            [NameInMap("NodeGroupList")]
            [Validation(Required=false)]
            public List<CheckCreateLindormV2InstanceRequestEngineListNodeGroupList> NodeGroupList { get; set; }
            public class CheckCreateLindormV2InstanceRequestEngineListNodeGroupList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                [NameInMap("NodeDiskSize")]
                [Validation(Required=false)]
                public int? NodeDiskSize { get; set; }

                [NameInMap("NodeDiskType")]
                [Validation(Required=false)]
                public string NodeDiskType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("NodeSpec")]
                [Validation(Required=false)]
                public string NodeSpec { get; set; }

                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

            }

        }

        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
