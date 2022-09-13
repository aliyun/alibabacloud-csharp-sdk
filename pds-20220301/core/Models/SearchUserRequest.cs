// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SearchUserRequest : TeaModel {
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        [NameInMap("nick_name_for_fuzzy")]
        [Validation(Required=false)]
        public string NickNameForFuzzy { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
