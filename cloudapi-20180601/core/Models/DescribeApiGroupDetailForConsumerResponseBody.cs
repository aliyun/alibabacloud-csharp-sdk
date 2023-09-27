// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
{
    public class DescribeApiGroupDetailForConsumerResponseBody : TeaModel {
        [NameInMap("BillingStatus")]
        [Validation(Required=false)]
        public string BillingStatus { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DomainItems")]
        [Validation(Required=false)]
        public DescribeApiGroupDetailForConsumerResponseBodyDomainItems DomainItems { get; set; }
        public class DescribeApiGroupDetailForConsumerResponseBodyDomainItems : TeaModel {
            [NameInMap("DomainItem")]
            [Validation(Required=false)]
            public List<DescribeApiGroupDetailForConsumerResponseBodyDomainItemsDomainItem> DomainItem { get; set; }
            public class DescribeApiGroupDetailForConsumerResponseBodyDomainItemsDomainItem : TeaModel {
                [NameInMap("CertificateId")]
                [Validation(Required=false)]
                public string CertificateId { get; set; }

                [NameInMap("CertificateName")]
                [Validation(Required=false)]
                public string CertificateName { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DomainNameResolution")]
                [Validation(Required=false)]
                public string DomainNameResolution { get; set; }

                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

            }

        }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("IllegalStatus")]
        [Validation(Required=false)]
        public string IllegalStatus { get; set; }

        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("Purchased")]
        [Validation(Required=false)]
        public string Purchased { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        [NameInMap("TrafficLimit")]
        [Validation(Required=false)]
        public int? TrafficLimit { get; set; }

    }

}
