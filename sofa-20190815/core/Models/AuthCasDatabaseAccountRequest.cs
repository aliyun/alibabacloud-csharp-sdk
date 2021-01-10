// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AuthCasDatabaseAccountRequest : TeaModel {
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Privilege")]
        [Validation(Required=false)]
        public string Privilege { get; set; }

        [NameInMap("SchemaId")]
        [Validation(Required=false)]
        public string SchemaId { get; set; }

    }

}
