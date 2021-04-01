// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class ListTagKeysResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("TagKeys")]
        [Validation(Required=true)]
        public List<ListTagKeysResponseTagKeys> TagKeys { get; set; }
        public class ListTagKeysResponseTagKeys : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=true)]
            public string TagKey { get; set; }

            [NameInMap("TagCount")]
            [Validation(Required=true)]
            public int? TagCount { get; set; }

        }

    }

}
