// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class ListDataLevelPermissionWhiteListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListDataLevelPermissionWhiteListResponseBodyResult Result { get; set; }
        public class ListDataLevelPermissionWhiteListResponseBodyResult : TeaModel {
            [NameInMap("CubeId")]
            [Validation(Required=false)]
            public string CubeId { get; set; }

            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public string RuleType { get; set; }

            [NameInMap("UsersModel")]
            [Validation(Required=false)]
            public ListDataLevelPermissionWhiteListResponseBodyResultUsersModel UsersModel { get; set; }
            public class ListDataLevelPermissionWhiteListResponseBodyResultUsersModel : TeaModel {
                [NameInMap("UserGroups")]
                [Validation(Required=false)]
                public List<string> UserGroups { get; set; }

                [NameInMap("Users")]
                [Validation(Required=false)]
                public List<string> Users { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
