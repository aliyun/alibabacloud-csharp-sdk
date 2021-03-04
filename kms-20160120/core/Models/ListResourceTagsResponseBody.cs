// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListResourceTagsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public ListResourceTagsResponseBodyTags Tags { get; set; }
        public class ListResourceTagsResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<ListResourceTagsResponseBodyTagsTag> Tag { get; set; }
            public class ListResourceTagsResponseBodyTagsTag : TeaModel {
                public string KeyId { get; set; }
                public string TagValue { get; set; }
                public string TagKey { get; set; }
            }
        };

    }

}
