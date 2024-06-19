// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterTemplatesRequest : TeaModel {
        /// <summary>
        /// The architecture of the instance. For more information, see [Overview](https://help.aliyun.com/document_detail/86132.html). Valid values:
        /// 
        /// *   **logic**: The instance is a cluster master-replica instance or a read/write splitting instance.
        /// *   **normal**: The instance is a standard master-replica instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CharacterType")]
        [Validation(Required=false)]
        public string CharacterType { get; set; }

        /// <summary>
        /// The database engine that is run on the instance. Set the value to **Redis**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The major version that is run on the instance. Valid values: **2.8**, **4.0**, and **5.0**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The ID of the instance. You can call the [DescribeInstances](~~DescribeInstances~~) operation to query the IDs of instances.
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
        /// The ID of the resource group to which the instance belongs. You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/158855.html) operation to query the IDs of resource groups.
        /// 
        /// >  You can also query the ID of a resource group in the Resource Management console. For more information, see [View the basic information of a resource group](https://help.aliyun.com/document_detail/151181.html).
        /// </summary>
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

    }

}
