// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class MarketingEndedPlan : TeaModel {
        /// <summary>
        /// <para>The end date of the plan, in yyyy-MM-dd format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-12-25</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The creation plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan_example001</para>
        /// </summary>
        [NameInMap("PlanId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The GEO project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AW20261126000000000001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
