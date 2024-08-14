/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class AddDiskReplicaPairRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The region ID of the replication pair-consistent group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the replication pair-consistent group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReplicaGroupId")]
        [Validation(Required=false)]
        public string ReplicaGroupId { get; set; }

        /// <summary>
        /// The ID of the replication pair. You can call the [DescribeDiskReplicaPairs](https://help.aliyun.com/document_detail/354206.html) operation to query the IDs of existing replication pairs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReplicaPairId")]
        [Validation(Required=false)]
        public string ReplicaPairId { get; set; }

    }

}
