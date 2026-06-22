// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteAutoTagRulesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the rules. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>Call the <a href="~~ListAutoTagRules~~">ListAutoTagRules</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2331,56,5644</para>
        /// </summary>
        [NameInMap("RuleIdList")]
        [Validation(Required=false)]
        public string RuleIdList { get; set; }

    }

}
