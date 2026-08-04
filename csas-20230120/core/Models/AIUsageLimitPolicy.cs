// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AIUsageLimitPolicy : TeaModel {
        /// <summary>
        /// <para>A brief description of the policy\&quot;s purpose or scope.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The timestamp (in UTC) when the policy was created, formatted as <c>YYYY-MM-DDThh:mm:ssZ</c>. This is a system-generated, read-only property.</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The timestamp (in UTC) when the policy was last modified, formatted as <c>YYYY-MM-DDThh:mm:ssZ</c>. This is a system-generated, read-only property.</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The unique identifier for the usage limit policy. This is a system-generated, read-only value.</para>
        /// </summary>
        [NameInMap("LimitPolicyId")]
        [Validation(Required=false)]
        public string LimitPolicyId { get; set; }

        /// <summary>
        /// <para>The maximum value for the specified <c>MetricType</c> allowed within the <c>ResetPeriod</c>. Once this limit is reached, further requests are throttled or rejected.</para>
        /// </summary>
        [NameInMap("LimitValue")]
        [Validation(Required=false)]
        public long? LimitValue { get; set; }

        /// <summary>
        /// <para>The type of metric the limit applies to, such as the number of API requests, tokens processed, or compute units consumed.</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>A user-friendly name for the policy. This helps you identify the policy in a list.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The priority of the policy, used to determine the evaluation order when multiple policies apply to the same request. A lower number indicates a higher priority.</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The time window during which the usage count is accumulated before it resets. For example: <c>Hour</c>, <c>Day</c>, or <c>Month</c>.</para>
        /// </summary>
        [NameInMap("ResetPeriod")]
        [Validation(Required=false)]
        public string ResetPeriod { get; set; }

        /// <summary>
        /// <para>A list of service IDs that this policy applies to. The policy is enforced only for requests made to these services.</para>
        /// </summary>
        [NameInMap("ServiceIds")]
        [Validation(Required=false)]
        public List<string> ServiceIds { get; set; }

        /// <summary>
        /// <para>The status of the policy. Valid values are <c>Enabled</c> and <c>Disabled</c>. A disabled policy is not enforced.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>A list of user group IDs that this policy applies to. The policy is enforced only for users who belong to these groups.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

    }

}
