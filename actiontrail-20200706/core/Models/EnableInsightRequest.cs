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
        /// <item><description>IpInsight: Insights event on IP address</description></item>
        /// <item><description>ApiCallRateInsight: Insights event on API call rate</description></item>
        /// <item><description>ApiErrorRateInsight: Insights event on API error rate</description></item>
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
