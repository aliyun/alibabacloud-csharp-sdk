// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainLimitResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LiveDomainLimitList")]
        [Validation(Required=false)]
        public DescribeLiveDomainLimitResponseBodyLiveDomainLimitList LiveDomainLimitList { get; set; }
        public class DescribeLiveDomainLimitResponseBodyLiveDomainLimitList : TeaModel {
            [NameInMap("LiveDomainLimit")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainLimitResponseBodyLiveDomainLimitListLiveDomainLimit> LiveDomainLimit { get; set; }
            public class DescribeLiveDomainLimitResponseBodyLiveDomainLimitListLiveDomainLimit : TeaModel {
                public string DomainName { get; set; }
                public int? LimitNum { get; set; }
                public int? LimitTranscodeNum { get; set; }
            }
        };

    }

}
