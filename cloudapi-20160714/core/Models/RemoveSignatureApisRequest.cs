// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class RemoveSignatureApisRequest : TeaModel {
        [NameInMap("ApiIds")]
        [Validation(Required=false)]
        public string ApiIds { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SignatureId")]
        [Validation(Required=false)]
        public string SignatureId { get; set; }

        [NameInMap("StageName")]
        [Validation(Required=false)]
        public string StageName { get; set; }

    }

}
