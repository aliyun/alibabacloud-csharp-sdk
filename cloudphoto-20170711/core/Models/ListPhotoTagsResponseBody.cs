// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class ListPhotoTagsResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListPhotoTagsResponseBodyTags> Tags { get; set; }
        public class ListPhotoTagsResponseBodyTags : TeaModel {
            [NameInMap("IdStr")]
            [Validation(Required=false)]
            public string IdStr { get; set; }

            [NameInMap("IsSubTag")]
            [Validation(Required=false)]
            public bool? IsSubTag { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ParentTag")]
            [Validation(Required=false)]
            public string ParentTag { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

    }

}
