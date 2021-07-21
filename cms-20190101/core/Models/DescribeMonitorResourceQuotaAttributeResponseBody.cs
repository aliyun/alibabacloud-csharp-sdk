// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorResourceQuotaAttributeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceQuota")]
        [Validation(Required=false)]
        public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuota ResourceQuota { get; set; }
        public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuota : TeaModel {
            [NameInMap("SuitInfo")]
            [Validation(Required=false)]
            public string SuitInfo { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }
            [NameInMap("SiteMonitorEcsProbe")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorEcsProbe SiteMonitorEcsProbe { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorEcsProbe : TeaModel {
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }
            [NameInMap("SiteMonitorOperatorProbe")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorOperatorProbe SiteMonitorOperatorProbe { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorOperatorProbe : TeaModel {
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }
            [NameInMap("SiteMonitorTask")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorTask SiteMonitorTask { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorTask : TeaModel {
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }
            [NameInMap("CustomMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaCustomMonitor CustomMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaCustomMonitor : TeaModel {
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }
            [NameInMap("EventMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEventMonitor EventMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEventMonitor : TeaModel {
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }
            [NameInMap("LogMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaLogMonitor LogMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaLogMonitor : TeaModel {
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }
            [NameInMap("Api")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaApi Api { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaApi : TeaModel {
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }
            [NameInMap("SMS")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSMS SMS { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSMS : TeaModel {
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaPhone Phone { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaPhone : TeaModel {
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }
            [NameInMap("EnterpriseQuota")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEnterpriseQuota EnterpriseQuota { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEnterpriseQuota : TeaModel {
                [NameInMap("SuitInfo")]
                [Validation(Required=false)]
                public string SuitInfo { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

            }
        };

    }

}
