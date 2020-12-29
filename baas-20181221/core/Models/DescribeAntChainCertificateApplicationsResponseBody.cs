// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainCertificateApplicationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainCertificateApplicationsResponseBodyResult Result { get; set; }
        public class DescribeAntChainCertificateApplicationsResponseBodyResult : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainCertificateApplicationsResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainCertificateApplicationsResponseBodyResultPagination : TeaModel {
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }
            [NameInMap("CertificateApplications")]
            [Validation(Required=false)]
            public List<DescribeAntChainCertificateApplicationsResponseBodyResultCertificateApplications> CertificateApplications { get; set; }
            public class DescribeAntChainCertificateApplicationsResponseBodyResultCertificateApplications : TeaModel {
                public string Status { get; set; }
                public long? Updatetime { get; set; }
                public long? Createtime { get; set; }
                public string Bid { get; set; }
                public string AntChainId { get; set; }
                public string Username { get; set; }
            }
        };

    }

}
