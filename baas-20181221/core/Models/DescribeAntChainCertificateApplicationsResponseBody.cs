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
            [NameInMap("CertificateApplications")]
            [Validation(Required=false)]
            public List<DescribeAntChainCertificateApplicationsResponseBodyResultCertificateApplications> CertificateApplications { get; set; }
            public class DescribeAntChainCertificateApplicationsResponseBodyResultCertificateApplications : TeaModel {
                [NameInMap("AntChainId")]
                [Validation(Required=false)]
                public string AntChainId { get; set; }

                /// <summary>
                /// Bid
                /// </summary>
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public string Bid { get; set; }

                [NameInMap("Createtime")]
                [Validation(Required=false)]
                public long? Createtime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Updatetime")]
                [Validation(Required=false)]
                public long? Updatetime { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public DescribeAntChainCertificateApplicationsResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainCertificateApplicationsResponseBodyResultPagination : TeaModel {
                [NameInMap("PageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

        }

    }

}
