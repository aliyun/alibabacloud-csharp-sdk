// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetInsightSelectorsResponseBody : TeaModel {
        [NameInMap("InsightSelectors")]
        [Validation(Required=false)]
        public List<string> InsightSelectors { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D0227506-AA8C-5998-8A62-74769106****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:actiontrail:cn-shanghai:159498693826****:trail/trail-name</para>
        /// </summary>
        [NameInMap("TrailArn")]
        [Validation(Required=false)]
        public string TrailArn { get; set; }

    }

}
