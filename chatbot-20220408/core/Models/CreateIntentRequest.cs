// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateIntentRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("IntentDefinition")]
        [Validation(Required=false)]
        public CreateIntentRequestIntentDefinition IntentDefinition { get; set; }
        public class CreateIntentRequestIntentDefinition : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<CreateIntentRequestIntentDefinitionSlotInfos> SlotInfos { get; set; }
            public class CreateIntentRequestIntentDefinitionSlotInfos : TeaModel {
                [NameInMap("Array")]
                [Validation(Required=false)]
                public bool? Array { get; set; }

                [NameInMap("Encrypt")]
                [Validation(Required=false)]
                public bool? Encrypt { get; set; }

                [NameInMap("Interactive")]
                [Validation(Required=false)]
                public bool? Interactive { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
