// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeTagsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=true)]
        public List<DescribeTagsResponseTags> Tags { get; set; }
        public class DescribeTagsResponseTags : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=true)]
            public string TagKey { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=true)]
            public string TagValue { get; set; }

        }

    }

}
