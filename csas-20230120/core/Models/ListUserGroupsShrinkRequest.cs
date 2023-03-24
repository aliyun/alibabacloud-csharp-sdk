// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserGroupsShrinkRequest : TeaModel {
        [NameInMap("AttributeValue")]
        [Validation(Required=false)]
        public string AttributeValue { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PAPolicyId")]
        [Validation(Required=false)]
        public string PAPolicyId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIdsShrink { get; set; }

    }

}
