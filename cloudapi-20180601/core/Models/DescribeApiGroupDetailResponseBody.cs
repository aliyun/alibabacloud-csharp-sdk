// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20180601.Models
{
    public class DescribeApiGroupDetailResponseBody : TeaModel {
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
        public DescribeApiGroupDetailResponseBodyDomainItems DomainItems { get; set; }
        public class DescribeApiGroupDetailResponseBodyDomainItems : TeaModel {
            [NameInMap("DomainItem")]
            [Validation(Required=false)]
            public List<DescribeApiGroupDetailResponseBodyDomainItemsDomainItem> DomainItem { get; set; }
            public class DescribeApiGroupDetailResponseBodyDomainItemsDomainItem : TeaModel {
                [NameInMap("CertificateId")]
                [Validation(Required=false)]
                public string CertificateId { get; set; }

                [NameInMap("CertificateName")]
                [Validation(Required=false)]
                public string CertificateName { get; set; }

                [NameInMap("DomainBindingStatus")]
                [Validation(Required=false)]
                public string DomainBindingStatus { get; set; }

                [NameInMap("DomainLegalStatus")]
                [Validation(Required=false)]
                public string DomainLegalStatus { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DomainNameResolution")]
                [Validation(Required=false)]
                public string DomainNameResolution { get; set; }

                [NameInMap("DomainRemark")]
                [Validation(Required=false)]
                public string DomainRemark { get; set; }

                [NameInMap("DomainWebSocketStatus")]
                [Validation(Required=false)]
                public string DomainWebSocketStatus { get; set; }

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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StageItems")]
        [Validation(Required=false)]
        public DescribeApiGroupDetailResponseBodyStageItems StageItems { get; set; }
        public class DescribeApiGroupDetailResponseBodyStageItems : TeaModel {
            [NameInMap("StageInfo")]
            [Validation(Required=false)]
            public List<DescribeApiGroupDetailResponseBodyStageItemsStageInfo> StageInfo { get; set; }
            public class DescribeApiGroupDetailResponseBodyStageItemsStageInfo : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

                [NameInMap("StageName")]
                [Validation(Required=false)]
                public string StageName { get; set; }

            }

        }

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
