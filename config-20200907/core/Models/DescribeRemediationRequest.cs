// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DescribeRemediationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cr-3184626622af0038418c</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        [NameInMap("RemediationId")]
        [Validation(Required=false)]
        public string RemediationId { get; set; }

    }

}
