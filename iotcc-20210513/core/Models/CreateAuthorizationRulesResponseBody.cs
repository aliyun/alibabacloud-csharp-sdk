// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class CreateAuthorizationRulesResponseBody : TeaModel {
        [NameInMap("AuthorizationRuleIds")]
        [Validation(Required=false)]
        public List<string> AuthorizationRuleIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
