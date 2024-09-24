// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetSasContainerWebDefenseRuleCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>The value of the search condition. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>525</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
