// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateUserSayRequest : TeaModel {
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("UserSayDefinition")]
        [Validation(Required=false)]
        public CreateUserSayRequestUserSayDefinition UserSayDefinition { get; set; }
        public class CreateUserSayRequestUserSayDefinition : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<CreateUserSayRequestUserSayDefinitionSlotInfos> SlotInfos { get; set; }
            public class CreateUserSayRequestUserSayDefinitionSlotInfos : TeaModel {
                [NameInMap("EndIndex")]
                [Validation(Required=false)]
                public int? EndIndex { get; set; }

                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                [NameInMap("StartIndex")]
                [Validation(Required=false)]
                public int? StartIndex { get; set; }

            }

        }

    }

}
