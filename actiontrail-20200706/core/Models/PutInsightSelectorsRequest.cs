// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class PutInsightSelectorsRequest : TeaModel {
        /// <summary>
        /// <para>The types of Insights events that the trail should deliver.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;insightType&quot;:&quot;AkInsight&quot;},{&quot;insightType&quot;:&quot;IpInsight&quot;}]</para>
        /// </summary>
        [NameInMap("InsightSelectors")]
        [Validation(Required=false)]
        public string InsightSelectors { get; set; }

        /// <summary>
        /// <para>The name of the trail.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trail-name</para>
        /// </summary>
        [NameInMap("TrailName")]
        [Validation(Required=false)]
        public string TrailName { get; set; }

    }

}
