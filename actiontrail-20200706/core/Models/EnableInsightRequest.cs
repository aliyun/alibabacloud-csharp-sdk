// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class EnableInsightRequest : TeaModel {
        /// <summary>
        /// <para>The type of the Insights event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>IpInsight: IP address request events.</para>
        /// </description></item>
        /// <item><description><para>ApiCallRateInsight: Unusual API call events.</para>
        /// </description></item>
        /// <item><description><para>ApiErrorRateInsight: API error events.</para>
        /// </description></item>
        /// <item><description><para>AkInsight: Unusual AccessKey pair call events.</para>
        /// </description></item>
        /// <item><description><para>PolicyChangeInsight: Permission change events.</para>
        /// </description></item>
        /// <item><description><para>PasswordChangeInsight: Password change events.</para>
        /// </description></item>
        /// <item><description><para>TrailConcealmentInsight: Trail concealment events.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IpInsight</para>
        /// </summary>
        [NameInMap("InsightType")]
        [Validation(Required=false)]
        public string InsightType { get; set; }

    }

}
