// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class ListRegisteredTagsResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RegisteredTags")]
        [Validation(Required=false)]
        public List<ListRegisteredTagsResponseBodyRegisteredTags> RegisteredTags { get; set; }
        public class ListRegisteredTagsResponseBodyRegisteredTags : TeaModel {
            [NameInMap("TagValues")]
            [Validation(Required=false)]
            public List<ListRegisteredTagsResponseBodyRegisteredTagsTagValues> TagValues { get; set; }
            public class ListRegisteredTagsResponseBodyRegisteredTagsTagValues : TeaModel {
                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
