// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class PutInsightSelectorsResponseBody : TeaModel {
        /// <summary>
        /// <para>An array of Insights event types.</para>
        /// </summary>
        [NameInMap("InsightSelectors")]
        [Validation(Required=false)]
        public List<string> InsightSelectors { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7EC26DF0-35AC-5F37-82B3-F5545D0A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the trail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:actiontrail:cn-shanghai:159498693826****:trail/trail-name</para>
        /// </summary>
        [NameInMap("TrailArn")]
        [Validation(Required=false)]
        public string TrailArn { get; set; }

    }

}
