// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorkspaceRoleConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryWorkspaceRoleConfigResponseBodyResult Result { get; set; }
        public class QueryWorkspaceRoleConfigResponseBodyResult : TeaModel {
            [NameInMap("AuthConfigList")]
            [Validation(Required=false)]
            public List<QueryWorkspaceRoleConfigResponseBodyResultAuthConfigList> AuthConfigList { get; set; }
            public class QueryWorkspaceRoleConfigResponseBodyResultAuthConfigList : TeaModel {
                [NameInMap("ActionAuthKeys")]
                [Validation(Required=false)]
                public List<string> ActionAuthKeys { get; set; }

                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

            }

            [NameInMap("IsSystemRole")]
            [Validation(Required=false)]
            public bool? IsSystemRole { get; set; }

            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public long? RoleId { get; set; }

            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
