// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class CreateTopicRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("CompactTopic")]
        [Validation(Required=false)]
        public bool? CompactTopic { get; set; }

        [NameInMap("PartitionNum")]
        [Validation(Required=false)]
        public string PartitionNum { get; set; }

        [NameInMap("LocalTopic")]
        [Validation(Required=false)]
        public bool? LocalTopic { get; set; }

    }

}
