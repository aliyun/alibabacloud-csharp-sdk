// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafDefaultRulesRequest : TeaModel {
        /// <summary>
        /// The query conditions. The value is a string in the JSON format. Format: `QueryArgs={"DefenseScene":"anti_scan"}`
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgs { get; set; }

    }

}
