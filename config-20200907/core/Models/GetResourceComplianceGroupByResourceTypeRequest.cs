// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceGroupByResourceTypeRequest : TeaModel {
        /// <summary>
        /// <para>The rule IDs. Separate multiple rule IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-a5c6626622af0058****</para>
        /// </summary>
        [NameInMap("ConfigRuleIds")]
        [Validation(Required=false)]
        public string ConfigRuleIds { get; set; }

    }

}
