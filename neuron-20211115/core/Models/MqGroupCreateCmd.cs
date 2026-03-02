// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MqGroupCreateCmd : TeaModel {
        [NameInMap("env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("laneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

        [NameInMap("laneName")]
        [Validation(Required=false)]
        public string LaneName { get; set; }

        [NameInMap("messageType")]
        [Validation(Required=false)]
        public int? MessageType { get; set; }

        [NameInMap("protocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

    }

}
