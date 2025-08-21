// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListActionPlansResponseBody : TeaModel {
        [NameInMap("ActionPlans")]
        [Validation(Required=false)]
        public List<ListActionPlansResponseBodyActionPlans> ActionPlans { get; set; }
        public class ListActionPlansResponseBodyActionPlans : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ap-hz036ubmx2qmw93k****</para>
            /// </summary>
            [NameInMap("ActionPlanId")]
            [Validation(Required=false)]
            public string ActionPlanId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestActionPlan</para>
            /// </summary>
            [NameInMap("ActionPlanName")]
            [Validation(Required=false)]
            public string ActionPlanName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-08-10 17:58:24</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-08-10 17:58:24</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d2db86scXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
