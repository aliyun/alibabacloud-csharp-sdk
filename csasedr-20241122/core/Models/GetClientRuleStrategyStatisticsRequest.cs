// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class GetClientRuleStrategyStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The policy type. Set this parameter to 2 to query the statistics of proactive defense policies.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public int? PolicyType { get; set; }

    }

}
