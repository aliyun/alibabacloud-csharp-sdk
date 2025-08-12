// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteEventRulesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert rule. Valid values of N: 1 to 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule1</para>
        /// </summary>
        [NameInMap("RuleNames")]
        [Validation(Required=false)]
        public List<string> RuleNames { get; set; }

    }

}
