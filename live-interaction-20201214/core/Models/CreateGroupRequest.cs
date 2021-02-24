// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 创建群聊请求实体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public CreateGroupRequestRequestParams RequestParams { get; set; }
        public class CreateGroupRequestRequestParams : TeaModel {
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }
            [NameInMap("CreatorAppUid")]
            [Validation(Required=false)]
            public string CreatorAppUid { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
            [NameInMap("IconMediaId")]
            [Validation(Required=false)]
            public string IconMediaId { get; set; }
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extensions { get; set; }
            [NameInMap("InitMembers")]
            [Validation(Required=false)]
            public List<CreateGroupRequestRequestParamsInitMembers> InitMembers { get; set; }
            public class CreateGroupRequestRequestParamsInitMembers : TeaModel {
                public string AppUid { get; set; }
                public int? Role { get; set; }
                public string Nick { get; set; }
                public long? JoinTime { get; set; }
                public Dictionary<string, string> Extensions { get; set; }
            }
        };

    }

}
