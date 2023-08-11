// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class CreateAppSecretResponseBody : TeaModel {
        /// <summary>
        /// The information of the application secret.
        /// </summary>
        [NameInMap("AppSecret")]
        [Validation(Required=false)]
        public CreateAppSecretResponseBodyAppSecret AppSecret { get; set; }
        public class CreateAppSecretResponseBodyAppSecret : TeaModel {
            /// <summary>
            /// The ID of the application.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The ID of the application secret.
            /// </summary>
            [NameInMap("AppSecretId")]
            [Validation(Required=false)]
            public string AppSecretId { get; set; }

            /// <summary>
            /// The content of the application secret. This value can be used as the client secret for open authorization.
            /// </summary>
            [NameInMap("AppSecretValue")]
            [Validation(Required=false)]
            public string AppSecretValue { get; set; }

            /// <summary>
            /// The creation time.
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
