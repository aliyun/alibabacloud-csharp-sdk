// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDiskReplicaPairProgressRequest : TeaModel {
        /// <summary>
        /// The region ID of the replication pair.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the replication pair. You can call the [DescribeDiskReplicaPairs](https://help.aliyun.com/document_detail/354206.html)operation to query the IDs of existing replication pairs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReplicaPairId")]
        [Validation(Required=false)]
        public string ReplicaPairId { get; set; }

    }

}
