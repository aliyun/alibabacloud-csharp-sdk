// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class UpdateQuotaScheduleRequest : TeaModel {
        /// <summary>
        /// <para>The request body parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>The quota plan immediately takes effect.</h1>
        /// <para>[
        ///   {
        ///     &quot;type&quot;: &quot;once&quot;,
        ///     &quot;plan&quot;: &quot;planA&quot;,
        ///     &quot;operator&quot;: &quot;userA&quot;
        ///   }
        /// ]</para>
        /// <h1>The quota plan is scheduled on a regular basis.</h1>
        /// <para>[
        ///   {
        ///     &quot;id&quot;: &quot;etl_time&quot;,
        ///     &quot;type&quot;: &quot;daily&quot;,
        ///     &quot;condition&quot;: {
        ///       &quot;at&quot;: &quot;0800&quot;
        ///     },
        ///     &quot;plan&quot;: &quot;planA&quot;
        ///   },
        ///   {
        ///     &quot;id&quot;: &quot;bi&quot;,
        ///     &quot;type&quot;: &quot;daily&quot;,
        ///     &quot;condition&quot;: {
        ///       &quot;at&quot;: &quot;0900&quot;
        ///     },
        ///     &quot;plan&quot;: &quot;planB&quot;
        ///   }
        /// ]</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// 
        /// <b>Example:</b>
        /// <para>478403690625249</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
