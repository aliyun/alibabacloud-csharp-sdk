// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainLimitResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("LiveDomainLimitList")]
        [Validation(Required=true)]
        public DescribeLiveDomainLimitResponseLiveDomainLimitList LiveDomainLimitList { get; set; }
        public class DescribeLiveDomainLimitResponseLiveDomainLimitList : TeaModel {
            [NameInMap("LiveDomainLimit")]
            [Validation(Required=true)]
            public List<DescribeLiveDomainLimitResponseLiveDomainLimitListLiveDomainLimit> LiveDomainLimit { get; set; }
            public class DescribeLiveDomainLimitResponseLiveDomainLimitListLiveDomainLimit : TeaModel {
                public string DomainName { get; set; }
                public int? LimitNum { get; set; }
                public int? LimitTranscodeNum { get; set; }
            }
        };

    }

}
