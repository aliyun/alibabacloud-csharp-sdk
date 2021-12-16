// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnEsExceptionDataResponseBody : TeaModel {
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public List<DescribeDcdnEsExceptionDataResponseBodyContents> Contents { get; set; }
        public class DescribeDcdnEsExceptionDataResponseBodyContents : TeaModel {
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<string> Columns { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Points")]
            [Validation(Required=false)]
            public List<string> Points { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
