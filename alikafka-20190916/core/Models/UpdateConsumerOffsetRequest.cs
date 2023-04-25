// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UpdateConsumerOffsetRequest : TeaModel {
        [NameInMap("ConsumerId")]
        [Validation(Required=false)]
        public string ConsumerId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Offsets")]
        [Validation(Required=false)]
        public List<UpdateConsumerOffsetRequestOffsets> Offsets { get; set; }
        public class UpdateConsumerOffsetRequestOffsets : TeaModel {
            [NameInMap("Offset")]
            [Validation(Required=false)]
            public long? Offset { get; set; }

            [NameInMap("Partition")]
            [Validation(Required=false)]
            public int? Partition { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public string ResetType { get; set; }

        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
