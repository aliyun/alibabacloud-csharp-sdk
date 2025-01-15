// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ActiveConfigRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the compliance package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cp-fe416457e0d90022****</para>
        /// </summary>
        [NameInMap("CompliancePackId")]
        [Validation(Required=false)]
        public string CompliancePackId { get; set; }

        /// <summary>
        /// <para>The rule ID. Separate multiple rule IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-2da35180a8d1008e****,cr-2da35180a8d1008e****</para>
        /// </summary>
        [NameInMap("ConfigRuleIds")]
        [Validation(Required=false)]
        public string ConfigRuleIds { get; set; }

    }

}
