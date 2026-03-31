// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteConfigRulesRequest : TeaModel {
        /// <summary>
        /// <para>The rule IDs. Separate multiple rule IDs with commas (,).</para>
        /// <para>For more information about how to obtain the ID of a rule, see <a href="https://help.aliyun.com/document_detail/609222.html">ListConfigRules</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-9908626622af0035****</para>
        /// </summary>
        [NameInMap("ConfigRuleIds")]
        [Validation(Required=false)]
        public string ConfigRuleIds { get; set; }

    }

}
