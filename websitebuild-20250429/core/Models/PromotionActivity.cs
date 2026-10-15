// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class PromotionActivity : TeaModel {
        /// <summary>
        /// <para>The campaign code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acwfradoj5u</para>
        /// </summary>
        [NameInMap("ActivityCode")]
        [Validation(Required=false)]
        public string ActivityCode { get; set; }

        /// <summary>
        /// <para>The campaign name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IP CIDR block filtering statistics</para>
        /// </summary>
        [NameInMap("ActivityName")]
        [Validation(Required=false)]
        public string ActivityName { get; set; }

        /// <summary>
        /// <para>The campaign type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SCALE_IN</para>
        /// </summary>
        [NameInMap("ActivityType")]
        [Validation(Required=false)]
        public string ActivityType { get; set; }

        /// <summary>
        /// <para>The consumed quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ConsumedQuota")]
        [Validation(Required=false)]
        public long? ConsumedQuota { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-11T21:13:38.164526965+08:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123414</para>
        /// </summary>
        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>The eligibility configuration in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("EligibilityConfig")]
        [Validation(Required=false)]
        public string EligibilityConfig { get; set; }

        /// <summary>
        /// <para>The end date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-22 10:18:51 +0800</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The privilege configuration in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("OfferConfig")]
        [Validation(Required=false)]
        public string OfferConfig { get; set; }

        /// <summary>
        /// <para>The privilege configuration summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("OfferConfigSummary")]
        [Validation(Required=false)]
        public string OfferConfigSummary { get; set; }

        /// <summary>
        /// <para>The remaining quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RemainingQuota")]
        [Validation(Required=false)]
        public long? RemainingQuota { get; set; }

        /// <summary>
        /// <para>The start date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-05-12T16:00:00.000Z</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The campaign status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE_ABORTING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalQuota")]
        [Validation(Required=false)]
        public long? TotalQuota { get; set; }

        /// <summary>
        /// <para>The touchpoint configuration in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("TouchpointConfig")]
        [Validation(Required=false)]
        public string TouchpointConfig { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-10-11T21:13:38.164526965+08:00</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The updater.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123414</para>
        /// </summary>
        [NameInMap("UpdatedBy")]
        [Validation(Required=false)]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// <para>The warning threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WarningThreshold")]
        [Validation(Required=false)]
        public int? WarningThreshold { get; set; }

    }

}
