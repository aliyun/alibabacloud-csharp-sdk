// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ListGroupMemberResponseBody : TeaModel {
        [NameInMap("group_items")]
        [Validation(Required=false)]
        public List<Group> GroupItems { get; set; }

        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

        [NameInMap("user_items")]
        [Validation(Required=false)]
        public List<User> UserItems { get; set; }

    }

}
