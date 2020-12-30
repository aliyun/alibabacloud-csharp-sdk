// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainLogDetails")]
        [Validation(Required=false)]
        public DescribeVodDomainLogResponseBodyDomainLogDetails DomainLogDetails { get; set; }
        public class DescribeVodDomainLogResponseBodyDomainLogDetails : TeaModel {
            [NameInMap("DomainLogDetail")]
            [Validation(Required=false)]
            public List<DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetail> DomainLogDetail { get; set; }
            public class DescribeVodDomainLogResponseBodyDomainLogDetailsDomainLogDetail : TeaModel {
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public long? PageNumber { get; set; }

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
