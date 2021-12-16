// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSecFuncInfoResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnSecFuncInfoResponseBodyContent> Content { get; set; }
        public class DescribeDcdnSecFuncInfoResponseBodyContent : TeaModel {
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
