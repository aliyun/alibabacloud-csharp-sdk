// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ModifyDiskReplicaPairRequest : TeaModel {
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The recovery point objective (RPO) of the replication pair. Unit: seconds. Set the value to 900.
        /// </summary>
        [NameInMap("PairName")]
        [Validation(Required=false)]
        public string PairName { get; set; }

        [NameInMap("RPO")]
        [Validation(Required=false)]
        public long? RPO { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How do I ensure idempotence ](~~25693~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The bandwidth used to asynchronously replicate data between the primary and secondary disks. Unit: Kbit/s. Valid values:
        /// 
        /// *   10240: equal to 10 Mbit/s
        /// *   20480: equal to 20 Mbit/s
        /// *   51200: equal to 50 Mbit/s
        /// *   102400: equal to 100 Mbit/s
        /// 
        /// Default value: 10240.
        /// </summary>
        [NameInMap("ReplicaPairId")]
        [Validation(Required=false)]
        public string ReplicaPairId { get; set; }

    }

}
