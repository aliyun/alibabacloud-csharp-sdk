// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ObtainMqConsoleLinkCmd : TeaModel {
        [NameInMap("env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        [NameInMap("mqGroupId")]
        [Validation(Required=false)]
        public string MqGroupId { get; set; }

        [NameInMap("pbcId")]
        [Validation(Required=false)]
        public long? PbcId { get; set; }

        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("topicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
