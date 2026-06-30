// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class RulesInfo : TeaModel {
        /// <summary>
        /// <para>Rule condition information; conditions for multiple rules are all placed in a single list</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<ConditionBasicInfo> Conditions { get; set; }

        /// <summary>
        /// <para>Total number of entries</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>Testing copy</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Dialogues")]
        [Validation(Required=false)]
        public List<RuleTestDialogue> Dialogues { get; set; }

        /// <summary>
        /// <para>Current page</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Basic rule information; multiple rules may exist</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<RuleInfo> Rules { get; set; }

    }

}
