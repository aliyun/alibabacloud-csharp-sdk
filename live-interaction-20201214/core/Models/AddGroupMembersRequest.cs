// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class AddGroupMembersRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public AddGroupMembersRequestRequestParams RequestParams { get; set; }
        public class AddGroupMembersRequestRequestParams : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }

            [NameInMap("InitMembers")]
            [Validation(Required=false)]
            public List<AddGroupMembersRequestRequestParamsInitMembers> InitMembers { get; set; }
            public class AddGroupMembersRequestRequestParamsInitMembers : TeaModel {
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

            [NameInMap("OperatorAppUid")]
            [Validation(Required=false)]
            public string OperatorAppUid { get; set; }

        }

    }

}
