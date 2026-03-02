// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class LaneMqGroupInfo : TeaModel {
        [NameInMap("allowClean")]
        [Validation(Required=false)]
        public bool? AllowClean { get; set; }

        [NameInMap("laneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

        [NameInMap("laneName")]
        [Validation(Required=false)]
        public string LaneName { get; set; }

        [NameInMap("mqGroups")]
        [Validation(Required=false)]
        public MqGroup MqGroups { get; set; }

    }

}
