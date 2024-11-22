// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchCreateWafRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the WAF rules.<a href="~~2850237~~"></a></para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public List<long?> Ids { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the WAF ruleset.<a href="~~2850233~~"></a></para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("RulesetId")]
        [Validation(Required=false)]
        public long? RulesetId { get; set; }

    }

}
