// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20170906.Models
{
    public class ListSetTagsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SetId")]
        [Validation(Required=false)]
        public string SetId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListSetTagsResponseBodyTags> Tags { get; set; }
        public class ListSetTagsResponseBodyTags : TeaModel {
            [NameInMap("TagCount")]
            [Validation(Required=false)]
            public int? TagCount { get; set; }

            [NameInMap("TagLevel")]
            [Validation(Required=false)]
            public int? TagLevel { get; set; }

            [NameInMap("TagName")]
            [Validation(Required=false)]
            public string TagName { get; set; }

        }

    }

}
