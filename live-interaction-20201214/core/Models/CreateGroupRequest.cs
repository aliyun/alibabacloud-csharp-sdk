// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class CreateGroupRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public CreateGroupRequestRequestParams RequestParams { get; set; }
        public class CreateGroupRequestRequestParams : TeaModel {
            [NameInMap("CreatorAppUid")]
            [Validation(Required=false)]
            public string CreatorAppUid { get; set; }

            [NameInMap("EntranceId")]
            [Validation(Required=false)]
            public string EntranceId { get; set; }

            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extensions { get; set; }

            [NameInMap("IconMediaId")]
            [Validation(Required=false)]
            public string IconMediaId { get; set; }

            [NameInMap("InitMembers")]
            [Validation(Required=false)]
            public List<CreateGroupRequestRequestParamsInitMembers> InitMembers { get; set; }
            public class CreateGroupRequestRequestParamsInitMembers : TeaModel {
                [NameInMap("AppUid")]
                [Validation(Required=false)]
                public string AppUid { get; set; }

                [NameInMap("Extensions")]
                [Validation(Required=false)]
                public Dictionary<string, string> Extensions { get; set; }

                [NameInMap("JoinTime")]
                [Validation(Required=false)]
                public long? JoinTime { get; set; }

                [NameInMap("Nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public int? Role { get; set; }

            }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
