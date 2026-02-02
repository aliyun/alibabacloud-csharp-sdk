// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class SinkMQTTParameters : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Mqtt5UserProperty")]
        [Validation(Required=false)]
        public SinkMQTTParametersMqtt5UserProperty Mqtt5UserProperty { get; set; }
        public class SinkMQTTParametersMqtt5UserProperty : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("ParentTopic")]
        [Validation(Required=false)]
        public string ParentTopic { get; set; }

        [NameInMap("Payload")]
        [Validation(Required=false)]
        public SinkMQTTParametersPayload Payload { get; set; }
        public class SinkMQTTParametersPayload : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("SubTopic")]
        [Validation(Required=false)]
        public SinkMQTTParametersSubTopic SubTopic { get; set; }
        public class SinkMQTTParametersSubTopic : TeaModel {
            [NameInMap("Form")]
            [Validation(Required=false)]
            public string Form { get; set; }

            [NameInMap("Template")]
            [Validation(Required=false)]
            public string Template { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
