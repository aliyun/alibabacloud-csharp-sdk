// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryAlertRulesResult : TeaModel {
        /// <summary>
        /// <para>The list of alert rules for the current page.</para>
        /// </summary>
        [NameInMap("alertRules")]
        [Validation(Required=false)]
        public List<AlertRuleV2> AlertRules { get; set; }

        /// <summary>
        /// <para>The total number of alert rules that match the query.</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
