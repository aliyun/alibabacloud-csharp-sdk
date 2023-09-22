// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class CategoryListQuery : TeaModel {
        [NameInMap("categoryIds")]
        [Validation(Required=false)]
        public List<long?> CategoryIds { get; set; }

        [NameInMap("parentCategoryId")]
        [Validation(Required=false)]
        public long? ParentCategoryId { get; set; }

    }

}
