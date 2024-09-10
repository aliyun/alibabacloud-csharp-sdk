// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorResourceQuotaAttributeResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details about the resource quotas of CloudMonitor.
        /// </summary>
        [NameInMap("ResourceQuota")]
        [Validation(Required=false)]
        public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuota ResourceQuota { get; set; }
        public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuota : TeaModel {
            /// <summary>
            /// The details about the quota of API calls.
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaApi Api { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaApi : TeaModel {
                /// <summary>
                /// The total quota of API calls. Unit: 10,000 calls.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of API calls in your resource plan. Unit: 10,000 calls.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The used quota of API calls in your resource plan. Unit: calls.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The details about the quota for custom monitoring.
            /// </summary>
            [NameInMap("CustomMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaCustomMonitor CustomMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaCustomMonitor : TeaModel {
                /// <summary>
                /// The total quota of the time series for custom monitoring.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of the time series for custom monitoring in your resource plan.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The used quota of the time series for custom monitoring in your resource plan.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The details about the quota of Hybrid Cloud Monitoring.
            /// </summary>
            [NameInMap("EnterpriseQuota")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEnterpriseQuota EnterpriseQuota { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEnterpriseQuota : TeaModel {
                /// <summary>
                /// The ID of the instance monitored by Hybrid Cloud Monitoring.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The description of Hybrid Cloud Monitoring.
                /// </summary>
                [NameInMap("SuitInfo")]
                [Validation(Required=false)]
                public string SuitInfo { get; set; }

            }

            /// <summary>
            /// The details about the quota for event monitoring.
            /// </summary>
            [NameInMap("EventMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEventMonitor EventMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEventMonitor : TeaModel {
                /// <summary>
                /// The total quota of events that can be reported in event monitoring. The total quota is the value that is multiplied by 10,000.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of events that can be reported in event monitoring in your resource plan. The total quota is the value that is multiplied by 10,000.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The used quota of events that can be reported in event monitoring in your resource plan. The total quota is the value that is multiplied by 10,000.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The time when the resource plan expires.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The ID of the resource plan.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The details about the quota for log monitoring.
            /// </summary>
            [NameInMap("LogMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaLogMonitor LogMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaLogMonitor : TeaModel {
                /// <summary>
                /// The total quota of processed log data in log monitoring. Unit: MB/min.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of processed log data in log monitoring in your resource plan. Unit: MB/min.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The used quota of processed log data in log monitoring in your resource plan. Unit: MB/min.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The details about the quota of alert phone calls.
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaPhone Phone { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaPhone : TeaModel {
                /// <summary>
                /// The total quota of alert phone calls. Unit: calls.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of alert phone calls in your resource plan. Unit: calls.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The used quota of alert phone calls in your resource plan. Unit: calls.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The details about the quota of alert text messages.
            /// </summary>
            [NameInMap("SMS")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSMS SMS { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSMS : TeaModel {
                /// <summary>
                /// The total quota of alert text messages. Unit: messages.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of alert text messages in your resource plan. Unit: messages.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The used quota of alert text messages in your resource plan. Unit: messages.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The quota of browser detection tasks.
            /// </summary>
            [NameInMap("SiteMonitorBrowser")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorBrowser SiteMonitorBrowser { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorBrowser : TeaModel {
                /// <summary>
                /// The total quota of browser detection tasks.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of browser detection tasks in your resource plan.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The used quota of browser detection tasks in your resource plan.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The details about the quota of ECS detection points for site monitoring.
            /// </summary>
            [NameInMap("SiteMonitorEcsProbe")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorEcsProbe SiteMonitorEcsProbe { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorEcsProbe : TeaModel {
                /// <summary>
                /// The total quota of ECS detection points for site monitoring.
                /// 
                /// > The value indicates the maximum number of ECS detection points that you can select for a site monitoring task.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of ECS detection points for site monitoring in your resource plan.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The used quota of ECS detection points for site monitoring in your resource plan.
                /// 
                /// > The value indicates the total number of ECS detection points that are used by existing site monitoring tasks.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The quota of mobile detection tasks.
            /// </summary>
            [NameInMap("SiteMonitorMobile")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorMobile SiteMonitorMobile { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorMobile : TeaModel {
                /// <summary>
                /// The total quota of mobile detection tasks.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of mobile detection tasks in your resource plan.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The used quota of mobile detection tasks in your resource plan.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The details about the quota of carrier detection points for site monitoring.
            /// </summary>
            [NameInMap("SiteMonitorOperatorProbe")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorOperatorProbe SiteMonitorOperatorProbe { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorOperatorProbe : TeaModel {
                /// <summary>
                /// The total quota of carrier detection points for site monitoring.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of carrier detection points for site monitoring in your resource plan.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The used quota of carrier detection points for site monitoring in your resource plan.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The quota of site monitoring tasks.
            /// </summary>
            [NameInMap("SiteMonitorTask")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorTask SiteMonitorTask { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorTask : TeaModel {
                /// <summary>
                /// The total quota of site monitoring tasks.
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// The quota of site monitoring tasks in your resource plan.
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// The used quota of site monitoring tasks in your resource plan.
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// The current edition of CloudMonitor. Valid values:
            /// 
            /// *   free: Free Edition
            /// *   pro: Pro Edition
            /// *   cms_post: pay-as-you-go
            /// </summary>
            [NameInMap("SuitInfo")]
            [Validation(Required=false)]
            public string SuitInfo { get; set; }

        }

    }

}
