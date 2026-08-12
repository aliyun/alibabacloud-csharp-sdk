// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SlsMultiConditionCaseConfig : TeaModel {
        /// <summary>
        /// <para>The count comparison operator. Valid values: GTE, GT, EQ, LTE, LT.</para>
        /// </summary>
        [NameInMap("countOperator")]
        [Validation(Required=false)]
        public string CountOperator { get; set; }

        /// <summary>
        /// <para>The count threshold. The alert is triggered when this threshold is met.</para>
        /// </summary>
        [NameInMap("countThreshold")]
        [Validation(Required=false)]
        public long? CountThreshold { get; set; }

        /// <summary>
        /// <para>The log field name. Required when matchOperator is set to CONTAINS, EQUALS, or REGEX. Specify the field name when matchOperator is set to PRESENT or NOT_PRESENT.</para>
        /// </summary>
        [NameInMap("matchField")]
        [Validation(Required=false)]
        public string MatchField { get; set; }

        /// <summary>
        /// <para>The log matching operator. Valid values: PRESENT (field exists), NOT_PRESENT (field does not exist), CONTAINS (contains), EQUALS (equals), REGEX (regular expression). If left empty, any data matches.</para>
        /// </summary>
        [NameInMap("matchOperator")]
        [Validation(Required=false)]
        public string MatchOperator { get; set; }

        /// <summary>
        /// <para>The log match value. Required when matchOperator is set to CONTAINS, EQUALS, or REGEX.</para>
        /// </summary>
        [NameInMap("matchValue")]
        [Validation(Required=false)]
        public string MatchValue { get; set; }

        /// <summary>
        /// <para>The severity level.</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

    }

}
