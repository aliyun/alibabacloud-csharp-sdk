// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceGroupByRegionRequest : TeaModel {
        /// <summary>
        /// <para>The rule IDs. Separate multiple rule IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cr-2541626622af0000****</para>
        /// </summary>
        [NameInMap("ConfigRuleIds")]
        [Validation(Required=false)]
        public string ConfigRuleIds { get; set; }

    }

}
