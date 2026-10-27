// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSasContainerWebDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The rule ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListSasContainerWebDefenseRule~~">ListSasContainerWebDefenseRule</a> operation to obtain this parameter.
        /// This parameter is required. If you do not specify this parameter, the API returns an HTTP 400 error with the error code -101.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1600009</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
