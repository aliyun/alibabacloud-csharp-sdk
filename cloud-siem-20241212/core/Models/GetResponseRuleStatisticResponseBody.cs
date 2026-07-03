// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class GetResponseRuleStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics of automated response rules.</para>
        /// </summary>
        [NameInMap("ResponseStatistic")]
        [Validation(Required=false)]
        public GetResponseRuleStatisticResponseBodyResponseStatistic ResponseStatistic { get; set; }
        public class GetResponseRuleStatisticResponseBodyResponseStatistic : TeaModel {
            /// <summary>
            /// <para>The total number of automated response rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ResponseRuleAllCount")]
            [Validation(Required=false)]
            public int? ResponseRuleAllCount { get; set; }

            /// <summary>
            /// <para>The number of online automated response rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ResponseRuleOnlineCount")]
            [Validation(Required=false)]
            public int? ResponseRuleOnlineCount { get; set; }

        }

    }

}
