// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class UpdateCallbackConfigRequest : TeaModel {
        /// <summary>
        /// 应用Id
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public UpdateCallbackConfigRequestRequestParams RequestParams { get; set; }
        public class UpdateCallbackConfigRequestRequestParams : TeaModel {
            [NameInMap("CallbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }
            [NameInMap("SignatureKey")]
            [Validation(Required=false)]
            public string SignatureKey { get; set; }
            [NameInMap("SignatureValue")]
            [Validation(Required=false)]
            public string SignatureValue { get; set; }
            [NameInMap("Apis")]
            [Validation(Required=false)]
            public Dictionary<string, string> Apis { get; set; }
        };

    }

}
