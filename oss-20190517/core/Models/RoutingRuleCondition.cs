// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class RoutingRuleCondition : TeaModel {
        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("HttpErrorCodeReturnedEquals")]
        [Validation(Required=false)]
        public long? HttpErrorCodeReturnedEquals { get; set; }

        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("KeyPrefixEquals")]
        [Validation(Required=false)]
        public string KeyPrefixEquals { get; set; }

    }

}
