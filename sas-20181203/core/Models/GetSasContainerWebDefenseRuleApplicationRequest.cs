// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSasContainerWebDefenseRuleApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The rule ID. This parameter is required. If this parameter is not specified, the API returns HTTP 400 with error code -101. You can call ListSasContainerWebDefenseRule to obtain valid RuleId values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400599</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
