// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class SourceKafkaParameters : TeaModel {
        [NameInMap("ConsumerGroup")]
        [Validation(Required=false)]
        public string ConsumerGroup { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        [NameInMap("OffsetReset")]
        [Validation(Required=false)]
        public string OffsetReset { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("Topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public string VSwitchIds { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
