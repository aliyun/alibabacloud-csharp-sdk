// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainLogDetails")]
        [Validation(Required=false)]
        public DescribeDcdnDomainLogResponseBodyDomainLogDetails DomainLogDetails { get; set; }
        public class DescribeDcdnDomainLogResponseBodyDomainLogDetails : TeaModel {
            [NameInMap("DomainLogDetail")]
            [Validation(Required=false)]
            public List<DescribeDcdnDomainLogResponseBodyDomainLogDetailsDomainLogDetail> DomainLogDetail { get; set; }
            public class DescribeDcdnDomainLogResponseBodyDomainLogDetailsDomainLogDetail : TeaModel {
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public long? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

            }
        };

    }

}
