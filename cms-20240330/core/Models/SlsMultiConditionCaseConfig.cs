// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SlsMultiConditionCaseConfig : TeaModel {
        /// <summary>
        /// <para>The match expression (corresponds to V1 condition, preserved as-is without structured parsing).</para>
        /// </summary>
        [NameInMap("condition")]
        [Validation(Required=false)]
        public string Condition { get; set; }

        /// <summary>
        /// <para>The count match expression (corresponds to V1 countCondition, preserved as-is without structured parsing).</para>
        /// </summary>
        [NameInMap("countCondition")]
        [Validation(Required=false)]
        public string CountCondition { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The write path is disabled. Use countCondition instead.</para>
        /// </summary>
        [NameInMap("countOperator")]
        [Validation(Required=false)]
        [Obsolete]
        public string CountOperator { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The write path is disabled. Use countCondition instead.</para>
        /// </summary>
        [NameInMap("countThreshold")]
        [Validation(Required=false)]
        [Obsolete]
        public long? CountThreshold { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The write path is disabled. Use condition instead.</para>
        /// </summary>
        [NameInMap("matchField")]
        [Validation(Required=false)]
        [Obsolete]
        public string MatchField { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The write path is disabled. Use condition instead.</para>
        /// </summary>
        [NameInMap("matchOperator")]
        [Validation(Required=false)]
        [Obsolete]
        public string MatchOperator { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The write path is disabled. Use condition instead.</para>
        /// </summary>
        [NameInMap("matchValue")]
        [Validation(Required=false)]
        [Obsolete]
        public string MatchValue { get; set; }

        /// <summary>
        /// <para>The detection operator (aligned with V1 caseList.type): HAS_DATA / HAS_DATA_COUNT / HAS_DATA_MATCH / HAS_DATA_MATCH_COUNT.</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The write path is disabled. Use condition instead.</para>
        /// </summary>
        [NameInMap("rawCondition")]
        [Validation(Required=false)]
        [Obsolete]
        public string RawCondition { get; set; }

        /// <summary>
        /// <para>The severity level (corresponds to V1 level).</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

    }

}
