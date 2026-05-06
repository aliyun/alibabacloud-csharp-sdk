// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafRuleMatch : TeaModel {
        [NameInMap("ConvertToLower")]
        [Validation(Required=false)]
        public bool? ConvertToLower { get; set; }

        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public List<WafRuleMatch> Criteria { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public string Logic { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eq</para>
        /// </summary>
        [NameInMap("MatchOperator")]
        [Validation(Required=false)]
        public string MatchOperator { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ip.src</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("MatchValue")]
        [Validation(Required=false)]
        public object MatchValue { get; set; }

        [NameInMap("Negate")]
        [Validation(Required=false)]
        public bool? Negate { get; set; }

    }

}
