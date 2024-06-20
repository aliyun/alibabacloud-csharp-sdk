// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainCertificateApplicationsV2ResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainCertificateApplicationsV2ResponseBodyResult Result { get; set; }
        public class DescribeAntChainCertificateApplicationsV2ResponseBodyResult : TeaModel {
            [NameInMap("CertificateApplications")]
            [Validation(Required=false)]
            public List<DescribeAntChainCertificateApplicationsV2ResponseBodyResultCertificateApplications> CertificateApplications { get; set; }
            public class DescribeAntChainCertificateApplicationsV2ResponseBodyResultCertificateApplications : TeaModel {
                [NameInMap("AntChainId")]
                [Validation(Required=false)]
                public string AntChainId { get; set; }

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
            public DescribeAntChainCertificateApplicationsV2ResponseBodyResultPagination Pagination { get; set; }
            public class DescribeAntChainCertificateApplicationsV2ResponseBodyResultPagination : TeaModel {
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

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
