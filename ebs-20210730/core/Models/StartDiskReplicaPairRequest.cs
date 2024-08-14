// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class StartDiskReplicaPairRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to immediately synchronize data. Valid values:
        /// 
        /// *   true: immediately synchronizes data.
        /// *   false: synchronizes data based on the recovery point objective (RPO).
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("OneShot")]
        [Validation(Required=false)]
        public bool? OneShot { get; set; }

        /// <summary>
        /// The region ID of the primary or secondary disk in the replication pair. You can call the [DescribeDiskReplicaPairs](https://help.aliyun.com/document_detail/354206.html) operation to query the region information of replication pairs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the replication pair.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReplicaPairId")]
        [Validation(Required=false)]
        public string ReplicaPairId { get; set; }

    }

}
