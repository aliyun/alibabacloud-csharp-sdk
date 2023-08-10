// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateApplicationClientSecretResponseBody : TeaModel {
        /// <summary>
        /// The information about the client key.
        /// </summary>
        [NameInMap("ApplicationClientSecret")]
        [Validation(Required=false)]
        public CreateApplicationClientSecretResponseBodyApplicationClientSecret ApplicationClientSecret { get; set; }
        public class CreateApplicationClientSecretResponseBodyApplicationClientSecret : TeaModel {
            /// <summary>
            /// The client ID of the application.
            /// </summary>
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            /// <summary>
            /// The client key secret of the application.
            /// </summary>
            [NameInMap("ClientSecret")]
            [Validation(Required=false)]
            public string ClientSecret { get; set; }

            /// <summary>
            /// The client key ID of the application.
            /// </summary>
            [NameInMap("SecretId")]
            [Validation(Required=false)]
            public string SecretId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
