// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class PubRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

        [NameInMap("Qos")]
        [Validation(Required=false)]
        public int? Qos { get; set; }

        [NameInMap("TopicFullName")]
        [Validation(Required=true)]
        public string TopicFullName { get; set; }

        [NameInMap("MessageContent")]
        [Validation(Required=true)]
        public string MessageContent { get; set; }

        [NameInMap("ResponseTopic")]
        [Validation(Required=false)]
        public string ResponseTopic { get; set; }

        [NameInMap("CorrelationData")]
        [Validation(Required=false)]
        public string CorrelationData { get; set; }

        [NameInMap("UserProp")]
        [Validation(Required=false)]
        public List<PubRequestUserProp> UserProp { get; set; }
        public class PubRequestUserProp : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
