// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListPromotionActivitiesForPartnerResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denied detail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Indicates whether retry is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spring-cloud-b</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error arguments.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The number of entries per query.</para>
        /// <para>Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public ListPromotionActivitiesForPartnerResponseBodyModule Module { get; set; }
        public class ListPromotionActivitiesForPartnerResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of promotional activities.</para>
            /// </summary>
            [NameInMap("Activities")]
            [Validation(Required=false)]
            public List<ListPromotionActivitiesForPartnerResponseBodyModuleActivities> Activities { get; set; }
            public class ListPromotionActivitiesForPartnerResponseBodyModuleActivities : TeaModel {
                /// <summary>
                /// <para>The activity code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acwfradoj5u</para>
                /// </summary>
                [NameInMap("ActivityCode")]
                [Validation(Required=false)]
                public string ActivityCode { get; set; }

                /// <summary>
                /// <para>The activity name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>IP网段过滤统计</para>
                /// </summary>
                [NameInMap("ActivityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                /// <summary>
                /// <para>The activity type.</para>
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
                /// <para>2022-02-14 11:57:51</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>onlinehoztestrolebasicallow1755461756261068111(300216315676902267)</para>
                /// </summary>
                [NameInMap("CreatedBy")]
                [Validation(Required=false)]
                public string CreatedBy { get; set; }

                /// <summary>
                /// <para>The eligibility configuration (JSON).</para>
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
                /// <para>The offer configuration (JSON).</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("OfferConfig")]
                [Validation(Required=false)]
                public string OfferConfig { get; set; }

                /// <summary>
                /// <para>The offer configuration summary.</para>
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
                /// <para>The activity status.</para>
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
                /// <para>The touchpoint configuration (JSON).</para>
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
                /// <para>The user who last updated the activity.</para>
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

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The token for the next query. This parameter is empty if no more results exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0l45bkwM022Dt+rOvPi/oQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The root error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统异常</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is processed synchronously.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
