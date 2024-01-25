// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NBF20211110_21312586.Models
{
    public class PreCheckRequest : TeaModel {
        [NameInMap("apiSchemaDTO")]
        [Validation(Required=false)]
        public string ApiSchemaDTO { get; set; }

        [NameInMap("groupVersionExtraInfo")]
        [Validation(Required=false)]
        public string GroupVersionExtraInfo { get; set; }

        [NameInMap("namespaceExternalId")]
        [Validation(Required=false)]
        public string NamespaceExternalId { get; set; }

    }

}
