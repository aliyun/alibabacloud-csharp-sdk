/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class AddGroupMembersRequest : TeaModel {
        /// <summary>
        /// AppId
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 群加人请求实体
        /// </summary>
        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public AddGroupMembersRequestRequestParams RequestParams { get; set; }
        public class AddGroupMembersRequestRequestParams : TeaModel {
            [NameInMap("OperatorAppUid")]
            [Validation(Required=false)]
            public string OperatorAppUid { get; set; }
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }
            [NameInMap("InitMembers")]
            [Validation(Required=false)]
            public List<AddGroupMembersRequestRequestParamsInitMembers> InitMembers { get; set; }
            public class AddGroupMembersRequestRequestParamsInitMembers : TeaModel {
                public string AppUid { get; set; }
                public int? Role { get; set; }
                public string Nick { get; set; }
                public long? JoinTime { get; set; }
                public Dictionary<string, string> Extensions { get; set; }
            }
        };

    }

}
