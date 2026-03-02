// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MqTopicSubsDigest : TeaModel {
        [NameInMap("MessageModel")]
        [Validation(Required=false)]
        public string MessageModel { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        [NameInMap("SubsExpression")]
        [Validation(Required=false)]
        public string SubsExpression { get; set; }

    }

}
