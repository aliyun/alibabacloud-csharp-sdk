// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class DeleteRmsRuleGroupByNameRequest : TeaModel {
        [NameInMap("EnvJsonStr")]
        [Validation(Required=false)]
        public string EnvJsonStr { get; set; }

        [NameInMap("ResType")]
        [Validation(Required=false)]
        public string ResType { get; set; }

        [NameInMap("RuleGroupName")]
        [Validation(Required=false)]
        public string RuleGroupName { get; set; }

    }

}
