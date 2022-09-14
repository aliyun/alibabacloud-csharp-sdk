// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20170714.Models
{
    public class AddUsersRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ReleaseInstance")]
        [Validation(Required=false)]
        public bool? ReleaseInstance { get; set; }

        [NameInMap("User")]
        [Validation(Required=false)]
        public List<AddUsersRequestUser> User { get; set; }
        public class AddUsersRequestUser : TeaModel {
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

    }

}
