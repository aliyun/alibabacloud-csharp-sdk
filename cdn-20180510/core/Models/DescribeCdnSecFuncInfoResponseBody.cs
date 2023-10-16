// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnSecFuncInfoResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeCdnSecFuncInfoResponseBodyContent> Content { get; set; }
        public class DescribeCdnSecFuncInfoResponseBodyContent : TeaModel {
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("HttpStatus")]
        [Validation(Required=false)]
        public string HttpStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public string RetCode { get; set; }

    }

}
