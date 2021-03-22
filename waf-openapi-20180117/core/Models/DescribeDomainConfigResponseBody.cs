// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20180117.Models
{
    public class DescribeDomainConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeDomainConfigResponseBodyResult Result { get; set; }
        public class DescribeDomainConfigResponseBodyResult : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("WafTaskId")]
            [Validation(Required=false)]
            public string WafTaskId { get; set; }
            [NameInMap("DomainConfig")]
            [Validation(Required=false)]
            public DescribeDomainConfigResponseBodyResultDomainConfig DomainConfig { get; set; }
            public class DescribeDomainConfigResponseBodyResultDomainConfig : TeaModel {
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public int? ProtocolType { get; set; }

                [NameInMap("SourceIps")]
                [Validation(Required=false)]
                public string SourceIps { get; set; }

            }
        };

    }

}
