// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class WebTLSConfig : TeaModel {
        [NameInMap("CipherSuites")]
        [Validation(Required=false)]
        public List<string> CipherSuites { get; set; }

        [NameInMap("MaxVersion")]
        [Validation(Required=false)]
        public string MaxVersion { get; set; }

        [NameInMap("MinVersion")]
        [Validation(Required=false)]
        public string MinVersion { get; set; }

    }

}
