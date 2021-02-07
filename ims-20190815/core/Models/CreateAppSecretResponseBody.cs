// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateAppSecretResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AppSecret")]
        [Validation(Required=false)]
        public CreateAppSecretResponseBodyAppSecret AppSecret { get; set; }
        public class CreateAppSecretResponseBodyAppSecret : TeaModel {
            [NameInMap("AppSecretValue")]
            [Validation(Required=false)]
            public string AppSecretValue { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("AppSecretId")]
            [Validation(Required=false)]
            public string AppSecretId { get; set; }
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }
        };

    }

}
