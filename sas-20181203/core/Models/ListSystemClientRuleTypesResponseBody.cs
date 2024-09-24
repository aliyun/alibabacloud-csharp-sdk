// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSystemClientRuleTypesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>79CFF74D-E967-5407-8A78-EE03B925****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleTypes")]
        [Validation(Required=false)]
        public List<string> RuleTypes { get; set; }

    }

}
