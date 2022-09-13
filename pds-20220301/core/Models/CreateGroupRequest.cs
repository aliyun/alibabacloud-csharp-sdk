// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateGroupRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("group_name")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("is_root")]
        [Validation(Required=false)]
        public bool? IsRoot { get; set; }

        [NameInMap("parent_group_id")]
        [Validation(Required=false)]
        public string ParentGroupId { get; set; }

    }

}
