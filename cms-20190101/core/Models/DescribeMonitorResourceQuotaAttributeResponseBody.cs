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
        /// <para>200 indicates success.</para>
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
        /// <para>The quota details of CloudMonitor.</para>
        /// </summary>
        [NameInMap("ResourceQuota")]
        [Validation(Required=false)]
        public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuota ResourceQuota { get; set; }
        public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuota : TeaModel {
            /// <summary>
            /// <para>The API quota.</para>
            /// </summary>
            [NameInMap("Api")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaApi Api { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaApi : TeaModel {
                /// <summary>
                /// <para>The total API quota. Unit: 10,000 calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The API quota included in the plan. Unit: 10,000 calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used API quota in the plan. Unit: calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9987</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The quota of custom monitoring.</para>
            /// </summary>
            [NameInMap("CustomMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaCustomMonitor CustomMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaCustomMonitor : TeaModel {
                /// <summary>
                /// <para>The total quota of custom monitoring time series. Unit: time series.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1200</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of custom monitoring time series included in the plan. Unit: time series.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of custom monitoring time series in the plan. Unit: time series.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The quota details of Hybrid Cloud Monitoring.</para>
            /// </summary>
            [NameInMap("EnterpriseQuota")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEnterpriseQuota EnterpriseQuota { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEnterpriseQuota : TeaModel {
                /// <summary>
                /// <para>The instance ID of Hybrid Cloud Monitoring.</para>
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
            /// <para>The quota of event monitoring.</para>
            /// </summary>
            [NameInMap("EventMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEventMonitor EventMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaEventMonitor : TeaModel {
                /// <summary>
                /// <para>The total quota of event monitoring. Unit: 10,000 events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>55</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of event monitoring included in the plan. Unit: 10,000 events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of event monitoring in the plan. Unit: 10,000 events.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The expiration time of the plan. The time follows the ISO 8601 standard in the YYYY-MM-DD format. The default time zone is UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-02-28</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The subscription plan ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cms_edition-cn-n6w20rn****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The quota of Log Monitoring.</para>
            /// </summary>
            [NameInMap("LogMonitor")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaLogMonitor LogMonitor { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaLogMonitor : TeaModel {
                /// <summary>
                /// <para>The total quota of Log Monitoring. Unit: MByte/Min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of Log Monitoring included in the plan. Unit: MByte/Min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>150</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of Log Monitoring in the plan. Unit: MByte/Min.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The quota of alert phone call packages.</para>
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
                /// <para>The quota of alert phone call packages. Unit: calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of alert phone call packages. Unit: calls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The quota of alert text message packages.</para>
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
                /// <para>The quota of alert text message packages. Unit: messages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of alert text message packages. Unit: messages.</para>
                /// 
                /// <b>Example:</b>
                /// <para>38</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The quota of browser-based monitoring tasks.</para>
            /// </summary>
            [NameInMap("SiteMonitorBrowser")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorBrowser SiteMonitorBrowser { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorBrowser : TeaModel {
                /// <summary>
                /// <para>The total quota of browser-based monitoring tasks. Unit: tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of browser-based monitoring tasks included in the plan. Unit: tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of browser-based monitoring tasks in the plan. Unit: tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The quota of ECS detection points for site monitoring.</para>
            /// </summary>
            [NameInMap("SiteMonitorEcsProbe")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorEcsProbe SiteMonitorEcsProbe { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorEcsProbe : TeaModel {
                /// <summary>
                /// <para>The total quota of ECS detection points for site monitoring.</para>
                /// <remarks>
                /// <para>The maximum number of ECS detection points that can be selected for a single site monitoring task.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of ECS detection points for site monitoring included in the plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of ECS detection points for site monitoring in the plan.</para>
                /// <remarks>
                /// <para>The total number of ECS detection points across all site monitoring tasks that have been created.</para>
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
            /// <para>The quota of mobile monitoring tasks.</para>
            /// </summary>
            [NameInMap("SiteMonitorMobile")]
            [Validation(Required=false)]
            public DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorMobile SiteMonitorMobile { get; set; }
            public class DescribeMonitorResourceQuotaAttributeResponseBodyResourceQuotaSiteMonitorMobile : TeaModel {
                /// <summary>
                /// <para>The total quota of mobile monitoring tasks. Unit: tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of mobile monitoring tasks included in the plan. Unit: tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of mobile monitoring tasks in the plan. Unit: tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("QuotaUsed")]
                [Validation(Required=false)]
                public int? QuotaUsed { get; set; }

            }

            /// <summary>
            /// <para>The quota of carrier detection points for site monitoring.</para>
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
                /// <para>The quota of carrier detection points for site monitoring included in the plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of carrier detection points for site monitoring in the plan.</para>
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
                /// <para>The total quota of site monitoring tasks. Unit: tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("QuotaLimit")]
                [Validation(Required=false)]
                public int? QuotaLimit { get; set; }

                /// <summary>
                /// <para>The quota of site monitoring tasks included in the plan. Unit: tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("QuotaPackage")]
                [Validation(Required=false)]
                public int? QuotaPackage { get; set; }

                /// <summary>
                /// <para>The used quota of site monitoring tasks in the plan. Unit: tasks.</para>
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
            /// <item><description>free: Free Edition.</description></item>
            /// <item><description>pro: Pro Edition.</description></item>
            /// <item><description>cms_post: Pay-as-you-go.</description></item>
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
