// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class ModifyLindormV2InstanceRequest : TeaModel {
        [NameInMap("CloudStorageSize")]
        [Validation(Required=false)]
        public long? CloudStorageSize { get; set; }

        [NameInMap("CloudStorageType")]
        [Validation(Required=false)]
        public string CloudStorageType { get; set; }

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("NodeGroupList")]
        [Validation(Required=false)]
        public List<ModifyLindormV2InstanceRequestNodeGroupList> NodeGroupList { get; set; }
        public class ModifyLindormV2InstanceRequestNodeGroupList : TeaModel {
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public string NodeCount { get; set; }

            [NameInMap("NodeDiskSize")]
            [Validation(Required=false)]
            public long? NodeDiskSize { get; set; }

            [NameInMap("NodeDiskType")]
            [Validation(Required=false)]
            public string NodeDiskType { get; set; }

            [NameInMap("NodeSpec")]
            [Validation(Required=false)]
            public string NodeSpec { get; set; }

            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public string UpgradeType { get; set; }

    }

}
