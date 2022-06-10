// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeIntentResponseBody : TeaModel {
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        [NameInMap("ModifyUserId")]
        [Validation(Required=false)]
        public string ModifyUserId { get; set; }

        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlotInfos")]
        [Validation(Required=false)]
        public List<DescribeIntentResponseBodySlotInfos> SlotInfos { get; set; }
        public class DescribeIntentResponseBodySlotInfos : TeaModel {
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
