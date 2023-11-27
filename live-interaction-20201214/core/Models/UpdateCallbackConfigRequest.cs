// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class UpdateCallbackConfigRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public UpdateCallbackConfigRequestRequestParams RequestParams { get; set; }
        public class UpdateCallbackConfigRequestRequestParams : TeaModel {
            [NameInMap("Apis")]
            [Validation(Required=false)]
            public Dictionary<string, bool?> Apis { get; set; }

            [NameInMap("CallbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            [NameInMap("Events")]
            [Validation(Required=false)]
            public Dictionary<string, bool?> Events { get; set; }

            [NameInMap("SignatureKey")]
            [Validation(Required=false)]
            public string SignatureKey { get; set; }

            [NameInMap("SignatureValue")]
            [Validation(Required=false)]
            public string SignatureValue { get; set; }

            [NameInMap("Spis")]
            [Validation(Required=false)]
            public Dictionary<string, bool?> Spis { get; set; }

        }

    }

}
