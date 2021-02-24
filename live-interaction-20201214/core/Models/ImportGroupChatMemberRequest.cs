// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ImportGroupChatMemberRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
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
                public string AppUid { get; set; }
                public long? Role { get; set; }
                public string Nick { get; set; }
                public bool? Top { get; set; }
                public long? RedPoint { get; set; }
                public bool? Mute { get; set; }
                public bool? Visible { get; set; }
                public long? JoinTime { get; set; }
                public long? ModifyTime { get; set; }
                public Dictionary<string, string> Extensions { get; set; }
            }
        };

    }

}
