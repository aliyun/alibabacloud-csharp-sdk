// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetManagedRuleRequest : TeaModel {
        /// <summary>
        /// The identifier of the managed rule.
        /// 
        /// For more information about how to obtain the identifier of a managed rule, see [ListManagedRules](https://help.aliyun.com/document_detail/421144.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

    }

}
