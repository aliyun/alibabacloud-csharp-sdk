// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Category : TeaModel {
        [NameInMap("categoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        [NameInMap("isLeaf")]
        [Validation(Required=false)]
        public bool? IsLeaf { get; set; }

        [NameInMap("level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

    }

}
