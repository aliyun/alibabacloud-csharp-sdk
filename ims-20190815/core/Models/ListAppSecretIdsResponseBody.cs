// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListAppSecretIdsResponseBody : TeaModel {
        /// <summary>
        /// The details of the application secret.
        /// </summary>
        [NameInMap("AppSecrets")]
        [Validation(Required=false)]
        public ListAppSecretIdsResponseBodyAppSecrets AppSecrets { get; set; }
        public class ListAppSecretIdsResponseBodyAppSecrets : TeaModel {
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public List<ListAppSecretIdsResponseBodyAppSecretsAppSecret> AppSecret { get; set; }
            public class ListAppSecretIdsResponseBodyAppSecretsAppSecret : TeaModel {
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
                /// The creation time.
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
