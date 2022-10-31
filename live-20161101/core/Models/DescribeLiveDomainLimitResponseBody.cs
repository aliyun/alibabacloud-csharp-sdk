// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainLimitResponseBody : TeaModel {
        [NameInMap("LiveDomainLimitList")]
        [Validation(Required=false)]
        public DescribeLiveDomainLimitResponseBodyLiveDomainLimitList LiveDomainLimitList { get; set; }
        public class DescribeLiveDomainLimitResponseBodyLiveDomainLimitList : TeaModel {
            [NameInMap("LiveDomainLimit")]
            [Validation(Required=false)]
            public List<DescribeLiveDomainLimitResponseBodyLiveDomainLimitListLiveDomainLimit> LiveDomainLimit { get; set; }
            public class DescribeLiveDomainLimitResponseBodyLiveDomainLimitListLiveDomainLimit : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("LimitNum")]
                [Validation(Required=false)]
                public int? LimitNum { get; set; }

                [NameInMap("LimitTranscodeNum")]
                [Validation(Required=false)]
                public int? LimitTranscodeNum { get; set; }

                [NameInMap("LimitTransferNum")]
                [Validation(Required=false)]
                public int? LimitTransferNum { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
