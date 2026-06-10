// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SyncAppInstanceForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>Application instance object data</para>
        /// </summary>
        [NameInMap("AppInstance")]
        [Validation(Required=false)]
        public SyncAppInstanceForPartnerRequestAppInstance AppInstance { get; set; }
        public class SyncAppInstanceForPartnerRequestAppInstance : TeaModel {
            /// <summary>
            /// <para>Application Type: WEBSITE</para>
            /// 
            /// <b>Example:</b>
            /// <para>WEBSITE</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>Website business ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>WD20250711094503000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>Logical deletion</para>
            /// 
            /// <b>Example:</b>
            /// <para>fase</para>
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public string Deleted { get; set; }

            /// <summary>
            /// <para>Domain name</para>
            /// 
            /// <b>Example:</b>
            /// <para>alliveout.xntv.tv</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>Event end time (UNIX timestamp).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-23T02:14:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>Deletion time</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("GmtDelete")]
            [Validation(Required=false)]
            public string GmtDelete { get; set; }

            /// <summary>
            /// <para>Vulnerability published UNIX timestamp, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("GmtPublish")]
            [Validation(Required=false)]
            public string GmtPublish { get; set; }

            /// <summary>
            /// <para>Application icon URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>icon/WS20250626112715000001/thumbnail.jpg</para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <para>Website name</para>
            /// 
            /// <b>Example:</b>
            /// <para>AI建站</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Website configuration information</para>
            /// 
            /// <b>Example:</b>
            /// <para>网站配置信息</para>
            /// </summary>
            [NameInMap("Profile")]
            [Validation(Required=false)]
            public SyncAppInstanceForPartnerRequestAppInstanceProfile Profile { get; set; }
            public class SyncAppInstanceForPartnerRequestAppInstanceProfile : TeaModel {
                /// <summary>
                /// <para>Deployment region</para>
                /// 
                /// <b>Example:</b>
                /// <para>ChineseMainland</para>
                /// </summary>
                [NameInMap("DeployArea")]
                [Validation(Required=false)]
                public string DeployArea { get; set; }

                /// <summary>
                /// <para>Lingxiao instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>12313213</para>
                /// </summary>
                [NameInMap("LxInstanceId")]
                [Validation(Required=false)]
                public string LxInstanceId { get; set; }

                /// <summary>
                /// <para>Order ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>222217928591</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>Version</para>
                /// 
                /// <b>Example:</b>
                /// <para>Basic_Edition</para>
                /// </summary>
                [NameInMap("SiteVersion")]
                [Validation(Required=false)]
                public string SiteVersion { get; set; }

                /// <summary>
                /// <para>Template ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>DC4D30B7BADDAFE9928A6C36416A2A4C</para>
                /// </summary>
                [NameInMap("TemplateEtag")]
                [Validation(Required=false)]
                public string TemplateEtag { get; set; }

                /// <summary>
                /// <para>Model template ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>ST20211231160247sYG4</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

            }

            /// <summary>
            /// <para>siteId</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx.scd.wezhan.cn</para>
            /// </summary>
            [NameInMap("SiteHost")]
            [Validation(Required=false)]
            public string SiteHost { get; set; }

            /// <summary>
            /// <para>Website SiteID</para>
            /// 
            /// <b>Example:</b>
            /// <para>31104757</para>
            /// </summary>
            [NameInMap("Slug")]
            [Validation(Required=false)]
            public string Slug { get; set; }

            /// <summary>
            /// <para>Query start time. If no start and end times are provided, all historical deployment records of the instance are queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-15T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>Instance running status.  </para>
            /// <list type="bullet">
            /// <item><description>NotRun: Not running  </description></item>
            /// <item><description>Running: Running  </description></item>
            /// <item><description>WaitTime: Waiting for TriggerTime  </description></item>
            /// <item><description>CheckingCondition: Checking branch conditions  </description></item>
            /// <item><description>WaitResource: Waiting for resources  </description></item>
            /// <item><description>Failure: Execution failed  </description></item>
            /// <item><description>Success: Execution succeeded  </description></item>
            /// <item><description>Checking: Sent to Data Quality check</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Phase\&quot;: \&quot;Running\&quot;, \&quot;SlotNum\&quot;: 1, \&quot;UsedCapacity\&quot;: \&quot;500.0Gi\&quot;}</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Thumbnail URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>thumbnails/WS20250626112715000001/thumbnail.jpg</para>
            /// </summary>
            [NameInMap("ThumbnailUrl")]
            [Validation(Required=false)]
            public string ThumbnailUrl { get; set; }

            /// <summary>
            /// <para>123123123131232</para>
            /// 
            /// <b>Example:</b>
            /// <para>12313213131</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>Type of system event. CREATE, UPDATE, COMPLETE</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>Operator ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>Source business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31104757</para>
        /// </summary>
        [NameInMap("SourceBizId")]
        [Validation(Required=false)]
        public string SourceBizId { get; set; }

        /// <summary>
        /// <para>Source: MARKET_CLOUD_DREAM</para>
        /// 
        /// <b>Example:</b>
        /// <para>MARKET_CLOUD_DREAM</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
