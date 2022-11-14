// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class InsertCustomRequest : TeaModel {
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public int? ApiId { get; set; }

        [NameInMap("CustomFileName")]
        [Validation(Required=false)]
        public string CustomFileName { get; set; }

        [NameInMap("CustomUrl")]
        [Validation(Required=false)]
        public string CustomUrl { get; set; }

        [NameInMap("RegFileName")]
        [Validation(Required=false)]
        public string RegFileName { get; set; }

        [NameInMap("RegUrl")]
        [Validation(Required=false)]
        public string RegUrl { get; set; }

        [NameInMap("ServiceCode")]
        [Validation(Required=false)]
        public string ServiceCode { get; set; }

    }

}
