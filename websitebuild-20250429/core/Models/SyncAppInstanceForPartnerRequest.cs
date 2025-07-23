// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class SyncAppInstanceForPartnerRequest : TeaModel {
        [NameInMap("AppInstance")]
        [Validation(Required=false)]
        public SyncAppInstanceForPartnerRequestAppInstance AppInstance { get; set; }
        public class SyncAppInstanceForPartnerRequestAppInstance : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>WEBSITE</para>
            /// </summary>
            [NameInMap("AppType")]
            [Validation(Required=false)]
            public string AppType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WD20250711094503000001</para>
            /// </summary>
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fase</para>
            /// </summary>
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public string Deleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alliveout.xntv.tv</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-08-23T02:14:00Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("GmtDelete")]
            [Validation(Required=false)]
            public string GmtDelete { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("GmtPublish")]
            [Validation(Required=false)]
            public string GmtPublish { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>icon/WS20250626112715000001/thumbnail.jpg</para>
            /// </summary>
            [NameInMap("IconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Profile")]
            [Validation(Required=false)]
            public SyncAppInstanceForPartnerRequestAppInstanceProfile Profile { get; set; }
            public class SyncAppInstanceForPartnerRequestAppInstanceProfile : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ChineseMainland</para>
                /// </summary>
                [NameInMap("DeployArea")]
                [Validation(Required=false)]
                public string DeployArea { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12313213</para>
                /// </summary>
                [NameInMap("LxInstanceId")]
                [Validation(Required=false)]
                public string LxInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>222217928591</para>
                /// </summary>
                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Basic_Edition</para>
                /// </summary>
                [NameInMap("SiteVersion")]
                [Validation(Required=false)]
                public string SiteVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DC4D30B7BADDAFE9928A6C36416A2A4C</para>
                /// </summary>
                [NameInMap("TemplateEtag")]
                [Validation(Required=false)]
                public string TemplateEtag { get; set; }

                /// <summary>
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
            /// <b>Example:</b>
            /// <para>31104757</para>
            /// </summary>
            [NameInMap("Slug")]
            [Validation(Required=false)]
            public string Slug { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-15T16:00:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{\&quot;Phase\&quot;: \&quot;Running\&quot;, \&quot;SlotNum\&quot;: 1, \&quot;UsedCapacity\&quot;: \&quot;500.0Gi\&quot;}</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>CREATE</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>31104757</para>
        /// </summary>
        [NameInMap("SourceBizId")]
        [Validation(Required=false)]
        public string SourceBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>MARKET_CLOUD_DREAM</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
