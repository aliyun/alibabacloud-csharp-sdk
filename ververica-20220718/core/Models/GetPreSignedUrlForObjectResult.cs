// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetPreSignedUrlForObjectResult : TeaModel {
        [NameInMap("jarUrl")]
        [Validation(Required=false)]
        public string JarUrl { get; set; }

        [NameInMap("preSignedUrl")]
        [Validation(Required=false)]
        public string PreSignedUrl { get; set; }

    }

}
