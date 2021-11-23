// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiGroupResponseBody : TeaModel {
        [NameInMap("BasePath")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        [NameInMap("BillingStatus")]
        [Validation(Required=false)]
        public string BillingStatus { get; set; }

        [NameInMap("ClassicVpcSubDomain")]
        [Validation(Required=false)]
        public string ClassicVpcSubDomain { get; set; }

        [NameInMap("CmsMonitorGroup")]
        [Validation(Required=false)]
        public string CmsMonitorGroup { get; set; }

        [NameInMap("CompatibleFlags")]
        [Validation(Required=false)]
        public string CompatibleFlags { get; set; }

        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("CustomDomains")]
        [Validation(Required=false)]
        public DescribeApiGroupResponseBodyCustomDomains CustomDomains { get; set; }
        public class DescribeApiGroupResponseBodyCustomDomains : TeaModel {
            [NameInMap("DomainItem")]
            [Validation(Required=false)]
            public List<DescribeApiGroupResponseBodyCustomDomainsDomainItem> DomainItem { get; set; }
            public class DescribeApiGroupResponseBodyCustomDomainsDomainItem : TeaModel {
                public string BindStageName { get; set; }
                public string CertificateId { get; set; }
                public string CertificateName { get; set; }
                public string CustomDomainType { get; set; }
                public string DomainBindingStatus { get; set; }
                public string DomainCNAMEStatus { get; set; }
                public string DomainLegalStatus { get; set; }
                public string DomainName { get; set; }
                public string DomainRemark { get; set; }
                public string DomainWebSocketStatus { get; set; }
                public string WildcardDomainPatterns { get; set; }
            }
        };

        [NameInMap("CustomTraceConfig")]
        [Validation(Required=false)]
        public string CustomTraceConfig { get; set; }

        [NameInMap("CustomerConfigs")]
        [Validation(Required=false)]
        public string CustomerConfigs { get; set; }

        [NameInMap("DefaultDomain")]
        [Validation(Required=false)]
        public string DefaultDomain { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("HttpsPolicy")]
        [Validation(Required=false)]
        public string HttpsPolicy { get; set; }

        [NameInMap("IllegalStatus")]
        [Validation(Required=false)]
        public string IllegalStatus { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("InstanceVipList")]
        [Validation(Required=false)]
        public string InstanceVipList { get; set; }

        [NameInMap("Ipv6Status")]
        [Validation(Required=false)]
        public string Ipv6Status { get; set; }

        [NameInMap("ModifiedTime")]
        [Validation(Required=false)]
        public string ModifiedTime { get; set; }

        [NameInMap("PassthroughHeaders")]
        [Validation(Required=false)]
        public string PassthroughHeaders { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RpcPattern")]
        [Validation(Required=false)]
        public string RpcPattern { get; set; }

        [NameInMap("StageItems")]
        [Validation(Required=false)]
        public DescribeApiGroupResponseBodyStageItems StageItems { get; set; }
        public class DescribeApiGroupResponseBodyStageItems : TeaModel {
            [NameInMap("StageInfo")]
            [Validation(Required=false)]
            public List<DescribeApiGroupResponseBodyStageItemsStageInfo> StageInfo { get; set; }
            public class DescribeApiGroupResponseBodyStageItemsStageInfo : TeaModel {
                public string Description { get; set; }
                public string StageId { get; set; }
                public string StageName { get; set; }
            }
        };

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        [NameInMap("TrafficLimit")]
        [Validation(Required=false)]
        public int? TrafficLimit { get; set; }

        [NameInMap("UserLogConfig")]
        [Validation(Required=false)]
        public string UserLogConfig { get; set; }

        [NameInMap("VpcDomain")]
        [Validation(Required=false)]
        public string VpcDomain { get; set; }

        [NameInMap("VpcSlbIntranetDomain")]
        [Validation(Required=false)]
        public string VpcSlbIntranetDomain { get; set; }

    }

}
