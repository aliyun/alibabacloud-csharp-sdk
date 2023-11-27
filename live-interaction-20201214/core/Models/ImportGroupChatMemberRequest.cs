// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ImportGroupChatMemberRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public ImportGroupChatMemberRequestRequestParams RequestParams { get; set; }
        public class ImportGroupChatMemberRequestRequestParams : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }

            [NameInMap("GroupChatMembers")]
            [Validation(Required=false)]
            public List<ImportGroupChatMemberRequestRequestParamsGroupChatMembers> GroupChatMembers { get; set; }
            public class ImportGroupChatMemberRequestRequestParamsGroupChatMembers : TeaModel {
                [NameInMap("AppUid")]
                [Validation(Required=false)]
                public string AppUid { get; set; }

                [NameInMap("Extensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extensions { get; set; }

                [NameInMap("JoinTime")]
                [Validation(Required=false)]
                public long? JoinTime { get; set; }

                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public long? ModifyTime { get; set; }

                [NameInMap("Mute")]
                [Validation(Required=false)]
                public bool? Mute { get; set; }

                [NameInMap("Nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("RedPoint")]
                [Validation(Required=false)]
                public long? RedPoint { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public long? Role { get; set; }

                [NameInMap("Top")]
                [Validation(Required=false)]
                public bool? Top { get; set; }

                [NameInMap("Visible")]
                [Validation(Required=false)]
                public bool? Visible { get; set; }

            }

        }

    }

}
