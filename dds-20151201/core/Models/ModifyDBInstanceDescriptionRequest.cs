// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceDescriptionRequest : TeaModel {
        /// <summary>
        /// The name of the instance.
        /// 
        /// > 
        /// 
        /// *   The name cannot start with `http://` or `https://`.
        /// 
        /// *   It must start with a letter.
        /// 
        /// *   It must be 2 to 256 characters in length, and can contain letters, underscores (_), hyphens (-), and digits.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// >  To modify the name of a shard or mongos node in a sharded cluster instance, you must also specify the **NodeId** parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The ID of the shard or mongos node in the sharded cluster instance.
        /// 
        /// >  This parameter is valid only if you set the **DBInstanceId** parameter to the ID of a sharded cluster instance.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
