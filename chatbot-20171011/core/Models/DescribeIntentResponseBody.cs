// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class DescribeIntentResponseBody : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        [NameInMap("DialogId")]
        [Validation(Required=false)]
        public long? DialogId { get; set; }

        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        [NameInMap("ModifyUserId")]
        [Validation(Required=false)]
        public string ModifyUserId { get; set; }

        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleCheck")]
        [Validation(Required=false)]
        public List<DescribeIntentResponseBodyRuleCheck> RuleCheck { get; set; }
        public class DescribeIntentResponseBodyRuleCheck : TeaModel {
            [NameInMap("Error")]
            [Validation(Required=false)]
            public List<string> Error { get; set; }

            [NameInMap("Strict")]
            [Validation(Required=false)]
            public bool? Strict { get; set; }

            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            [NameInMap("Warning")]
            [Validation(Required=false)]
            public List<string> Warning { get; set; }

        }

        [NameInMap("Slot")]
        [Validation(Required=false)]
        public List<DescribeIntentResponseBodySlot> Slot { get; set; }
        public class DescribeIntentResponseBodySlot : TeaModel {
            [NameInMap("IsArray")]
            [Validation(Required=false)]
            public bool? IsArray { get; set; }

            [NameInMap("IsNecessary")]
            [Validation(Required=false)]
            public bool? IsNecessary { get; set; }

            [NameInMap("LifeSpan")]
            [Validation(Required=false)]
            public int? LifeSpan { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Question")]
            [Validation(Required=false)]
            public List<string> Question { get; set; }

            [NameInMap("SlotId")]
            [Validation(Required=false)]
            public string SlotId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeIntentResponseBodySlotTags> Tags { get; set; }
            public class DescribeIntentResponseBodySlotTags : TeaModel {
                [NameInMap("UserSayId")]
                [Validation(Required=false)]
                public string UserSayId { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("UserSay")]
        [Validation(Required=false)]
        public List<DescribeIntentResponseBodyUserSay> UserSay { get; set; }
        public class DescribeIntentResponseBodyUserSay : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DescribeIntentResponseBodyUserSayData> Data { get; set; }
            public class DescribeIntentResponseBodyUserSayData : TeaModel {
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("Strict")]
            [Validation(Required=false)]
            public bool? Strict { get; set; }

            [NameInMap("UserSayId")]
            [Validation(Required=false)]
            public string UserSayId { get; set; }

        }

    }

}
