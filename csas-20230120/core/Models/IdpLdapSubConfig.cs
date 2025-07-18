// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class IdpLdapSubConfig : TeaModel {
        [NameInMap("BaseDn")]
        [Validation(Required=false)]
        public string BaseDn { get; set; }

        [NameInMap("GroupBaseDn")]
        [Validation(Required=false)]
        public string GroupBaseDn { get; set; }

        [NameInMap("GroupFilter")]
        [Validation(Required=false)]
        public string GroupFilter { get; set; }

        [NameInMap("GroupMembershipAttr")]
        [Validation(Required=false)]
        public string GroupMembershipAttr { get; set; }

        [NameInMap("GroupNameAttr")]
        [Validation(Required=false)]
        public string GroupNameAttr { get; set; }

        [NameInMap("LoginNameAttr")]
        [Validation(Required=false)]
        public string LoginNameAttr { get; set; }

        [NameInMap("ServerAddr")]
        [Validation(Required=false)]
        public string ServerAddr { get; set; }

        [NameInMap("ServerPort")]
        [Validation(Required=false)]
        public string ServerPort { get; set; }

        [NameInMap("ServerType")]
        [Validation(Required=false)]
        public string ServerType { get; set; }

        [NameInMap("UseSsl")]
        [Validation(Required=false)]
        public bool? UseSsl { get; set; }

        [NameInMap("UserDn")]
        [Validation(Required=false)]
        public string UserDn { get; set; }

        [NameInMap("UserFilter")]
        [Validation(Required=false)]
        public string UserFilter { get; set; }

        [NameInMap("UserPassword")]
        [Validation(Required=false)]
        public string UserPassword { get; set; }

    }

}
