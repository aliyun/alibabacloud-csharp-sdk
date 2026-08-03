// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20240313.Models
{
    public class SendSdkMessageRequest : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("header")]
        [Validation(Required=false)]
        public string Header { get; set; }

        [NameInMap("moduleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

        [NameInMap("operationName")]
        [Validation(Required=false)]
        public string OperationName { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
