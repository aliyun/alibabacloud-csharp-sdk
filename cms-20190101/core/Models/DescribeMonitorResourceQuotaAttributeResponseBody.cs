// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitorResourceQuotaAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified resource is not found.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31BC7201-00F2-47B2-B7B9-6A173076ACE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about the resource quotas of CloudMonitor.</para>
        /// </summary>
        [NameInMap("ResourceQuota")]
        [Validation(Required=false)]
        public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuota ResourceQuota { get; set; }
        public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuota : TeaModel {
            /// <summary>
            /// <para>The details about the quota of API calls.</para>
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaApi Api { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaApi : TeaModel {
                /// <summary>
                /// <para>The total quota of API calls. Unit: 10,000 calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of API calls in your resource plan. Unit: 10,000 calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of API calls in your resource plan. Unit: calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9987</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The details about the quota for custom monitoring.</para>
            /// </summary>
            [NameInMap("CustomMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaCustomMonitor CustomMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaCustomMonitor : TeaModel {
                /// <summary>
                /// <para>The total quota of the time series for custom monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of the time series for custom monitoring in your resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of the time series for custom monitoring in your resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The details about the quota of Hybrid Cloud Monitoring.</para>
            /// </summary>
            [NameInMap("EnterpriseQuota")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEnterpriseQuota EnterpriseQuota { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEnterpriseQuota : TeaModel {
                /// <summary>
                /// <para>The ID of the instance monitored by Hybrid Cloud Monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cms_enterprise_public_cn-7mz27pd****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The description of Hybrid Cloud Monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENTERPRISE</para>
                /// </summary>
                [NameInMap("SuitInfo")]
                [Validation(Required=false)]
                public string SuitInfo { get; set; }

            }

            /// <summary>
            /// <para>The details about the quota for event monitoring.</para>
            /// </summary>
            [NameInMap("EventMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEventMonitor EventMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEventMonitor : TeaModel {
                /// <summary>
                /// <para>The total quota of events that can be reported in event monitoring. The total quota is the value that is multiplied by 10,000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>55</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of events that can be reported in event monitoring in your resource plan. The total quota is the value that is multiplied by 10,000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of events that can be reported in event monitoring in your resource plan. The total quota is the value that is multiplied by 10,000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The time when the resource plan expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-28</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms_edition-cn-n6w20rn****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The details about the quota for log monitoring.</para>
            /// </summary>
            [NameInMap("LogMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaLogMonitor LogMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaLogMonitor : TeaModel {
                /// <summary>
                /// <para>The total quota of processed log data in log monitoring. Unit: MB/min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of processed log data in log monitoring in your resource plan. Unit: MB/min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of processed log data in log monitoring in your resource plan. Unit: MB/min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The details about the quota of alert phone calls.</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaPhone Phone { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaPhone : TeaModel {
                /// <summary>
                /// <para>The total quota of alert phone calls. Unit: calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>550</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of alert phone calls in your resource plan. Unit: calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of alert phone calls in your resource plan. Unit: calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The details about the quota of alert text messages.</para>
            /// </summary>
            [NameInMap("SMS")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSMS SMS { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSMS : TeaModel {
                /// <summary>
                /// <para>The total quota of alert text messages. Unit: messages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>550</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of alert text messages in your resource plan. Unit: messages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of alert text messages in your resource plan. Unit: messages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The quota of browser detection tasks.</para>
            /// </summary>
            [NameInMap("SiteMonitorBrowser")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorBrowser SiteMonitorBrowser { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorBrowser : TeaModel {
                /// <summary>
                /// <para>The total quota of browser detection tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of browser detection tasks in your resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of browser detection tasks in your resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The details about the quota of ECS detection points for site monitoring.</para>
            /// </summary>
            [NameInMap("SiteMonitorEcsProbe")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorEcsProbe SiteMonitorEcsProbe { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorEcsProbe : TeaModel {
                /// <summary>
                /// <para>The total quota of ECS detection points for site monitoring.</para>
                /// <remarks>
                /// <para>The value indicates the maximum number of ECS detection points that you can select for a site monitoring task.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of ECS detection points for site monitoring in your resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of ECS detection points for site monitoring in your resource plan.</para>
                /// <remarks>
                /// <para>The value indicates the total number of ECS detection points that are used by existing site monitoring tasks.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The quota of mobile detection tasks.</para>
            /// </summary>
            [NameInMap("SiteMonitorMobile")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorMobile SiteMonitorMobile { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorMobile : TeaModel {
                /// <summary>
                /// <para>The total quota of mobile detection tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of mobile detection tasks in your resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of mobile detection tasks in your resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The details about the quota of carrier detection points for site monitoring.</para>
            /// </summary>
            [NameInMap("SiteMonitorOperatorProbe")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorOperatorProbe SiteMonitorOperatorProbe { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorOperatorProbe : TeaModel {
                /// <summary>
                /// <para>The total quota of carrier detection points for site monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of carrier detection points for site monitoring in your resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of carrier detection points for site monitoring in your resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The quota of site monitoring tasks.</para>
            /// </summary>
            [NameInMap("SiteMonitorTask")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorTask SiteMonitorTask { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorTask : TeaModel {
                /// <summary>
                /// <para>The total quota of site monitoring tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of site monitoring tasks in your resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of site monitoring tasks in your resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The current edition of CloudMonitor. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>free: Free Edition</description></item>
            /// <item><description>pro: Pro Edition</description></item>
            /// <item><description>cms_post: pay-as-you-go</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pro</para>
            /// </summary>
            [NameInMap("SuitInfo")]
            [Validation(Required=false)]
            public string SuitInfo { get; set; }

        }

    }

}
