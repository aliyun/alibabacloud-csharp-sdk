// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceConnectionStringRequest : TeaModel {
        /// <summary>
        /// The current endpoint that is to be modified.
        /// </summary>
        [NameInMap("CurrentConnectionString")]
        [Validation(Required=false)]
        public string CurrentConnectionString { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// > If you set this parameter to the ID of a sharded cluster instance, you must also specify the **NodeId** parameter.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The new endpoint. It must be 8 to 64 characters in length and can contain letters and digits. It must start with a lowercase letter.
        /// 
        /// > You need only to specify the prefix of the endpoint. The content other than the prefix cannot be modified.
        /// </summary>
        [NameInMap("NewConnectionString")]
        [Validation(Required=false)]
        public string NewConnectionString { get; set; }

        /// <summary>
        /// 新的端口，端口范围需要在1000~65535之间。
        /// > 当**DBInstanceId**参数传入的是云盘实例ID时，本参数才可用。
        /// </summary>
        [NameInMap("NewPort")]
        [Validation(Required=false)]
        public int? NewPort { get; set; }

        /// <summary>
        /// The ID of the mongos in the specified sharded cluster instance. Only one mongos ID can be specified in each call.
        /// 
        /// > This parameter is valid only when you specify the **DBInstanceId** parameter to the ID of a sharded cluster instance.
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
