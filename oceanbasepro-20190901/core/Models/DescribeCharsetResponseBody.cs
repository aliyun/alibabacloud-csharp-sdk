// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeCharsetResponseBody : TeaModel {
        [NameInMap("Charset")]
        [Validation(Required=false)]
        public List<DescribeCharsetResponseBodyCharset> Charset { get; set; }
        public class DescribeCharsetResponseBodyCharset : TeaModel {
            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            [NameInMap("Collations")]
            [Validation(Required=false)]
            public List<string> Collations { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
