// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class UpdateGroupMembersRoleRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public UpdateGroupMembersRoleRequestRequestParams RequestParams { get; set; }
        public class UpdateGroupMembersRoleRequestRequestParams : TeaModel {
            [NameInMap("AppCid")]
            [Validation(Required=false)]
            public string AppCid { get; set; }

            [NameInMap("AppUids")]
            [Validation(Required=false)]
            public List<string> AppUids { get; set; }

            [NameInMap("OperatorAppUid")]
            [Validation(Required=false)]
            public string OperatorAppUid { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public int? Role { get; set; }

        }

    }

}
