// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryAlertRulesResult : TeaModel {
        /// <summary>
        /// <para>告警规则列表</para>
        /// </summary>
        [NameInMap("alertRules")]
        [Validation(Required=false)]
        public List<AlertRuleV2> AlertRules { get; set; }

        /// <summary>
        /// <para>符合查询条件的总告警规则数</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
