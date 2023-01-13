// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListProductTagsResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListProductTagsResponseData Data { get; set; }
        public class ListProductTagsResponseData : TeaModel {
            [NameInMap("ProductTag")]
            [Validation(Required=true)]
            public List<ListProductTagsResponseDataProductTag> ProductTag { get; set; }
            public class ListProductTagsResponseDataProductTag : TeaModel {
                [NameInMap("TagKey")]
                [Validation(Required=true)]
                public string TagKey { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=true)]
                public string TagValue { get; set; }

            }

        }

    }

}
