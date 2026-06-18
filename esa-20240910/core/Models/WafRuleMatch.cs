// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class WafRuleMatch : TeaModel {
        /// <summary>
        /// <para>值大小写不敏感。</para>
        /// </summary>
        [NameInMap("ConvertToLower")]
        [Validation(Required=false)]
        public bool? ConvertToLower { get; set; }

        /// <summary>
        /// <para>逻辑列表。</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public List<WafRuleMatch> Criteria { get; set; }

        /// <summary>
        /// <para>逻辑关系。</para>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("Logic")]
        [Validation(Required=false)]
        public string Logic { get; set; }

        /// <summary>
        /// <para>匹配符。</para>
        /// 
        /// <b>Example:</b>
        /// <para>eq</para>
        /// </summary>
        [NameInMap("MatchOperator")]
        [Validation(Required=false)]
        public string MatchOperator { get; set; }

        /// <summary>
        /// <para>匹配域。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ip.src</para>
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// <para>匹配值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.1</para>
        /// </summary>
        [NameInMap("MatchValue")]
        [Validation(Required=false)]
        public object MatchValue { get; set; }

        /// <summary>
        /// <para>匹配结果取反。</para>
        /// </summary>
        [NameInMap("Negate")]
        [Validation(Required=false)]
        public bool? Negate { get; set; }

    }

}
