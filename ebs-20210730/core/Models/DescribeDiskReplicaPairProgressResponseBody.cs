// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaPairProgressResponseBody : TeaModel {
        /// <summary>
        /// The replication progress of the replication pair.
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// The timestamp that indicates the last recovery point in time. The value is returned only after the replication pair works for replicating data.
        /// </summary>
        [NameInMap("RecoverPoint")]
        [Validation(Required=false)]
        public long? RecoverPoint { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
