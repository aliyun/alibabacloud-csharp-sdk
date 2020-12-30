// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeTagsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeTagsResponseBodyTags Tags { get; set; }
        public class DescribeTagsResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeTagsResponseBodyTagsTag> Tag { get; set; }
            public class DescribeTagsResponseBodyTagsTag : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
                public DescribeTagsResponseBodyTagsTagFileSystemIds FileSystemIds { get; set; }
                public class DescribeTagsResponseBodyTagsTagFileSystemIds : TeaModel {
                    [NameInMap("FileSystemId")]
                    [Validation(Required=false)]
                    public List<string> FileSystemId { get; set; }

                }
            }
        };

    }

}
