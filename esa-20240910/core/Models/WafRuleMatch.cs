// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafRuleMatch : TeaModel {
        /// <summary>
        /// <para>Specifies whether the value is case-insensitive.</para>
        /// </summary>
        [NameInMap("ConvertToLower")]
        [Validation(Required=false)]
        public bool? ConvertToLower { get; set; }

        /// <summary>
        /// <para>The logic list.</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public List<WafRuleMatch> Criteria { get; set; }

        /// <summary>
        /// <para>The logic relationship.</para>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public string Logic { get; set; }

        /// <summary>
        /// <para>The match operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eq</para>
        /// </summary>
        [NameInMap("MatchOperator")]
        [Validation(Required=false)]
        public string MatchOperator { get; set; }

        /// <summary>
        /// <para>The match field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip.src</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>The match value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("MatchValue")]
        [Validation(Required=false)]
        public object MatchValue { get; set; }

        /// <summary>
        /// <para>Specifies whether to negate the match result.</para>
        /// </summary>
        [NameInMap("Negate")]
        [Validation(Required=false)]
        public bool? Negate { get; set; }

    }

}
