// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListUserSayResponseBody : TeaModel {
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

        [NameInMap("UserSays")]
        [Validation(Required=false)]
        public List<ListUserSayResponseBodyUserSays> UserSays { get; set; }
        public class ListUserSayResponseBodyUserSays : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<ListUserSayResponseBodyUserSaysSlotInfos> SlotInfos { get; set; }
            public class ListUserSayResponseBodyUserSaysSlotInfos : TeaModel {
                /// <summary>
                /// 槽位在意图话术中的下标
                /// </summary>
                [NameInMap("EndIndex")]
                [Validation(Required=false)]
                public int? EndIndex { get; set; }

                /// <summary>
                /// 意图槽位ID
                /// </summary>
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                /// <summary>
                /// 槽位在意图话术中的下标
                /// </summary>
                [NameInMap("StartIndex")]
                [Validation(Required=false)]
                public int? StartIndex { get; set; }

            }

            [NameInMap("UserSayId")]
            [Validation(Required=false)]
            public long? UserSayId { get; set; }

        }

    }

}
