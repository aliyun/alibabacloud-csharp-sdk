// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListAppSecretIdsResponseBody : TeaModel {
        [NameInMap("AppSecrets")]
        [Validation(Required=false)]
        public ListAppSecretIdsResponseBodyAppSecrets AppSecrets { get; set; }
        public class ListAppSecretIdsResponseBodyAppSecrets : TeaModel {
            [NameInMap("AppSecret")]
            [Validation(Required=false)]
            public List<ListAppSecretIdsResponseBodyAppSecretsAppSecret> AppSecret { get; set; }
            public class ListAppSecretIdsResponseBodyAppSecretsAppSecret : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                [NameInMap("AppSecretId")]
                [Validation(Required=false)]
                public string AppSecretId { get; set; }

                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
