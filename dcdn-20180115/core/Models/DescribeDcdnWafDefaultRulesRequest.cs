// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDefaultRulesRequest : TeaModel {
        /// <summary>
        /// <para>The query conditions. The value is a string in the JSON format. Format: <c>QueryArgs={&quot;DefenseScene&quot;:&quot;anti_scan&quot;}</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;DefenseScene&quot;:&quot;anti_scan&quot;}</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgs { get; set; }

    }

}
