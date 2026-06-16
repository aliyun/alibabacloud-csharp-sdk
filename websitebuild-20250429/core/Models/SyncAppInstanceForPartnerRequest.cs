// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SyncAppInstanceForPartnerRequest : TeaModel {
        /// <summary>
        /// <para>The website instance object data.</para>
        /// </summary>
        [NameInMap("AppInstance")]
        [Validation(Required=false)]
        public SyncAppInstanceForPartnerRequestAppInstance AppInstance { get; set; }
        public class SyncAppInstanceForPartnerRequestAppInstance : TeaModel {
            /// <summary>
            /// <para>The application type. Set this parameter to WEBSITE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WEBSITE</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <para>The website business ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WD20250711094503000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <para>Specifies whether the instance is logically deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fase</para>
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public string Deleted { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alliveout.xntv.tv</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The end time of the event, in UNIX timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-23T02:14:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The deletion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("GmtDelete")]
            [Validation(Required=false)]
            public string GmtDelete { get; set; }

            /// <summary>
            /// <para>The timestamp when the vulnerability was published, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("GmtPublish")]
            [Validation(Required=false)]
            public string GmtPublish { get; set; }

            /// <summary>
            /// <para>The URL of the application icon.</para>
            /// 
            /// <b>Example:</b>
            /// <para>icon/WS20250626112715000001/thumbnail.jpg</para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <para>The website name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AI建站</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The website configuration information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>网站配置信息</para>
            /// </summary>
            [NameInMap("Profile")]
            [Validation(Required=false)]
            public SyncAppInstanceForPartnerRequestAppInstanceProfile Profile { get; set; }
            public class SyncAppInstanceForPartnerRequestAppInstanceProfile : TeaModel {
                /// <summary>
                /// <para>The deployment region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ChineseMainland</para>
                /// </summary>
                [NameInMap("DeployArea")]
                [Validation(Required=false)]
                public string DeployArea { get; set; }

                /// <summary>
                /// <para>The LingXiao instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12313213</para>
                /// </summary>
                [NameInMap("LxInstanceId")]
                [Validation(Required=false)]
                public string LxInstanceId { get; set; }

                /// <summary>
                /// <para>The order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>222217928591</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <para>The version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Basic_Edition</para>
                /// </summary>
                [NameInMap("SiteVersion")]
                [Validation(Required=false)]
                public string SiteVersion { get; set; }

                /// <summary>
                /// <para>The template identifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DC4D30B7BADDAFE9928A6C36416A2A4C</para>
                /// </summary>
                [NameInMap("TemplateEtag")]
                [Validation(Required=false)]
                public string TemplateEtag { get; set; }

                /// <summary>
                /// <para>The model template ID.</para>
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
            /// <para>The website SiteID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>31104757</para>
            /// </summary>
            [NameInMap("Slug")]
            [Validation(Required=false)]
            public string Slug { get; set; }

            /// <summary>
            /// <para>The start time of the query. If you do not specify the start time or end time, all historical deployment records of the instance are queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-15T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The running status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NotRun: not running.</description></item>
            /// <item><description>Running: running.</description></item>
            /// <item><description>WaitTime: waiting for TriggerTime.</description></item>
            /// <item><description>CheckingCondition: checking branch conditions.</description></item>
            /// <item><description>WaitResource: waiting for resources.</description></item>
            /// <item><description>Failure: execution failed.</description></item>
            /// <item><description>Success: execution succeeded.</description></item>
            /// <item><description>Checking: submitted for data quality check.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Phase\&quot;: \&quot;Running\&quot;, \&quot;SlotNum\&quot;: 1, \&quot;UsedCapacity\&quot;: \&quot;500.0Gi\&quot;}</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The URL of the thumbnail.</para>
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
        /// <para>The type of the system event. Valid values: CREATE, UPDATE, and COMPLETE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CREATE</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The employee ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The source business ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31104757</para>
        /// </summary>
        [NameInMap("SourceBizId")]
        [Validation(Required=false)]
        public string SourceBizId { get; set; }

        /// <summary>
        /// <para>The source. Set this parameter to MARKET_CLOUD_DREAM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MARKET_CLOUD_DREAM</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
