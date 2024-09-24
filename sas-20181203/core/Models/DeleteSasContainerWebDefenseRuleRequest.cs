// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteSasContainerWebDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The rule ID.</para>
        /// <remarks>
        /// <para> You can call the ListContainerWebDefenseRule operation to query the rule ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400597</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
