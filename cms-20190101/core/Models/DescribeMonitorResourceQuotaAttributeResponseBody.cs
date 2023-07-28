// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorResourceQuotaAttributeResponseBody : TeaModel {
        /// <summary>
        /// The quota of alert phone calls in your purchased resource plan. Unit: calls.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The used quota of the time series in custom monitoring in your purchased plan.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The details about the quota of detection points that are provided by other carriers in site monitoring.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total quota of alert text messages.
        /// </summary>
        [NameInMap("ResourceQuota")]
        [Validation(Required=false)]
        public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuota ResourceQuota { get; set; }
        public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuota : TeaModel {
            /// <summary>
            /// The details about the quota of API operation calls.
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaApi Api { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaApi : TeaModel {
                /// <summary>
                /// The current edition of CloudMonitor. Valid values:
                /// 
                /// *   free: free edition
                /// *   pro: Professional Edition
                /// *   cms_post: pay-as-you-go
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The used quota of API operation calls in your purchased plan. Unit: calls.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The quota of alert text messages in your purchased resource plan.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The quota of detection points that are provided by other carriers in site monitoring in your purchased plan.
            /// </summary>
            [NameInMap("CustomMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaCustomMonitor CustomMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaCustomMonitor : TeaModel {
                /// <summary>
                /// The total quota of alert phone calls. Unit: calls.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of site monitoring tasks.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The total quota of events that can be reported in event monitoring. The total quota is the value that is multiplied by 10,000.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// For more information about common request parameters, see [Common parameters](~~199331~~).
            /// </summary>
            [NameInMap("EnterpriseQuota")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEnterpriseQuota EnterpriseQuota { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEnterpriseQuota : TeaModel {
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("SuitInfo")]
                [Validation(Required=false)]
                public string SuitInfo { get; set; }

            }

            /// <summary>
            /// The details about the quota of alert phone calls.
            /// </summary>
            [NameInMap("EventMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEventMonitor EventMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEventMonitor : TeaModel {
                /// <summary>
                /// The used quota of detection points that are provided by Alibaba Cloud in site monitoring in your purchased plan.
                /// 
                /// >  The value indicates the total number of detection points provided by Alibaba Cloud that are used by existing site monitoring tasks.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The details about the quota of custom monitoring.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The description of the instance.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The total quota of detection points that are provided by Alibaba Cloud in site monitoring.
            /// 
            /// >  The value indicates the maximum number of detection points provided by Alibaba Cloud that you can select for a site monitoring task.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The operation that you want to perform. Set the value to DescribeMonitorResourceQuotaAttribute.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The total quota of site monitoring tasks.
            /// </summary>
            [NameInMap("LogMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaLogMonitor LogMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaLogMonitor : TeaModel {
                /// <summary>
                /// The used quota of events that can be reported in event monitoring in your purchased plan. The product of multiplying the value and 10,000 indicates the used quota.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The details about the resource quotas of CloudMonitor.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The used quota of alert text messages in your purchased resource plan.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The details about the quota of alert text messages.
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaPhone Phone { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaPhone : TeaModel {
                /// <summary>
                /// The quota of processed log data in log monitoring in your purchased plan. Unit: MB/min.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The quota of API operation calls in your purchased plan. Unit: 10,000 calls.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The used quota of detection points that are provided by other carriers in site monitoring in your purchased plan.
            /// </summary>
            [NameInMap("SMS")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSMS SMS { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSMS : TeaModel {
                /// <summary>
                /// The details about the quota of detection points that are provided by Alibaba Cloud in site monitoring.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The used quota of processed log data in log monitoring in your purchased plan. Unit: MB/min.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The quota of events that can be reported in event monitoring in your purchased plan. The quota of events that can be reported in event monitoring.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("SiteMonitorEcsProbe")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorEcsProbe SiteMonitorEcsProbe { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorEcsProbe : TeaModel {
                /// <summary>
                /// The used quota of site monitoring tasks in your purchased plan.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of the time series in custom monitoring in your purchased plan.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// Specifies whether to return information about used quotas. Valid values:
                /// 
                /// *   true: to include information about used quotas. Default value: true.
                /// *   false: to exclude information about used quotas.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The total quota of API operation calls. Unit: 10,000 calls.
            /// </summary>
            [NameInMap("SiteMonitorOperatorProbe")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorOperatorProbe SiteMonitorOperatorProbe { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorOperatorProbe : TeaModel {
                /// <summary>
                /// The total quota of processed log data in log monitoring. Unit: MB/min.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The time when the plan expires.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The details about the quota of event monitoring.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The quota of site monitoring tasks in your purchased plan.
            /// </summary>
            [NameInMap("SiteMonitorTask")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorTask SiteMonitorTask { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorTask : TeaModel {
                /// <summary>
                /// The total quota of the time series in custom monitoring.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The details about the quota.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The ID of the purchased subscription plan.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The HTTP status code.
            /// 
            /// >  The HTTP status code 200 indicates that the call succeeds.
            /// </summary>
            [NameInMap("SuitInfo")]
            [Validation(Required=false)]
            public string SuitInfo { get; set; }

        }

    }

}
