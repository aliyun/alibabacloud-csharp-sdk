// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListIntentResponseBody : TeaModel {
        [NameInMap("Intents")]
        [Validation(Required=false)]
        public List<ListIntentResponseBodyIntents> Intents { get; set; }
        public class ListIntentResponseBodyIntents : TeaModel {
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

            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<ListIntentResponseBodyIntentsSlotInfos> SlotInfos { get; set; }
            public class ListIntentResponseBodyIntentsSlotInfos : TeaModel {
                /// <summary>
                /// 是否数组
                /// </summary>
                [NameInMap("Array")]
                [Validation(Required=false)]
                public bool? Array { get; set; }

                /// <summary>
                /// 是否敏感
                /// </summary>
                [NameInMap("Encrypt")]
                [Validation(Required=false)]
                public bool? Encrypt { get; set; }

                /// <summary>
                /// 是否交互式收集
                /// </summary>
                [NameInMap("Interactive")]
                [Validation(Required=false)]
                public bool? Interactive { get; set; }

                /// <summary>
                /// 槽位名
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 槽位ID
                /// </summary>
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                /// <summary>
                /// 槽位值（实体名）
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
