// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AccountLinkInfo : TeaModel {
        [NameInMap("authentication_type")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("display_name")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        [NameInMap("identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        [NameInMap("last_login_time")]
        [Validation(Required=false)]
        public long? LastLoginTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
