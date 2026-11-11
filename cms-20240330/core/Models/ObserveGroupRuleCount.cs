// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveGroupRuleCount : TeaModel {
        /// <summary>
        /// <para>The number of deduplicated primary entities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("mainCount")]
        [Validation(Required=false)]
        public long? MainCount { get; set; }

        /// <summary>
        /// <para>The number of deduplicated associated child entities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("relatedCount")]
        [Validation(Required=false)]
        public long? RelatedCount { get; set; }

        /// <summary>
        /// <para>The stable ID of the managed rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-rocketmq-prod</para>
        /// </summary>
        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The total number of deduplicated entities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
