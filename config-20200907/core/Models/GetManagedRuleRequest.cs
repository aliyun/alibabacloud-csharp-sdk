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
        /// You can call the [ListManagedRules](https://help.aliyun.com/document_detail/421144.html) operation to obtain the managed rule identifier.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

    }

}
