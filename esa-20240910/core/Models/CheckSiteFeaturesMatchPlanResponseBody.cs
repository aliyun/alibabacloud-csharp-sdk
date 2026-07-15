// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CheckSiteFeaturesMatchPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the features of the current site are compatible with the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsPassed")]
        [Validation(Required=false)]
        public bool? IsPassed { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65705631-908C-5D24-997C-17E0397721C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about site quotas that do not meet the requirements.</para>
        /// </summary>
        [NameInMap("UnPassedSiteQuotas")]
        [Validation(Required=false)]
        public List<CheckSiteFeaturesMatchPlanResponseBodyUnPassedSiteQuotas> UnPassedSiteQuotas { get; set; }
        public class CheckSiteFeaturesMatchPlanResponseBodyUnPassedSiteQuotas : TeaModel {
            /// <summary>
            /// <para>The quota value of the current site.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CurrentQuotaValue")]
            [Validation(Required=false)]
            public string CurrentQuotaValue { get; set; }

            /// <summary>
            /// <para>The quota value of the target instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DestQuotaValue")]
            [Validation(Required=false)]
            public string DestQuotaValue { get; set; }

            /// <summary>
            /// <para>The quota name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cache_reserve</para>
            /// </summary>
            [NameInMap("QuotaName")]
            [Validation(Required=false)]
            public string QuotaName { get; set; }

        }

    }

}
