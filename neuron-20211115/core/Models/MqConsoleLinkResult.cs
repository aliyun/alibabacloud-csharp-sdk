// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class MqConsoleLinkResult : TeaModel {
        [NameInMap("groupLinkUrl")]
        [Validation(Required=false)]
        public string GroupLinkUrl { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("topicLinkUrl")]
        [Validation(Required=false)]
        public string TopicLinkUrl { get; set; }

    }

}
