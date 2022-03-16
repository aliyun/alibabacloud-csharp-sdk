// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListUserCertificateOrderResponseBody : TeaModel {
        [NameInMap("CertificateOrderList")]
        [Validation(Required=false)]
        public List<ListUserCertificateOrderResponseBodyCertificateOrderList> CertificateOrderList { get; set; }
        public class ListUserCertificateOrderResponseBodyCertificateOrderList : TeaModel {
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            [NameInMap("AliyunOrderId")]
            [Validation(Required=false)]
            public long? AliyunOrderId { get; set; }

            [NameInMap("BuyDate")]
            [Validation(Required=false)]
            public long? BuyDate { get; set; }

            [NameInMap("CertEndTime")]
            [Validation(Required=false)]
            public long? CertEndTime { get; set; }

            [NameInMap("CertStartTime")]
            [Validation(Required=false)]
            public long? CertStartTime { get; set; }

            [NameInMap("CertType")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("DomainCount")]
            [Validation(Required=false)]
            public long? DomainCount { get; set; }

            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("PartnerOrderId")]
            [Validation(Required=false)]
            public string PartnerOrderId { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("RootBrand")]
            [Validation(Required=false)]
            public string RootBrand { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TrusteeStatus")]
            [Validation(Required=false)]
            public string TrusteeStatus { get; set; }

            [NameInMap("WildDomainCount")]
            [Validation(Required=false)]
            public long? WildDomainCount { get; set; }

        }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
