// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class TomcatConfig : TeaModel {
        [NameInMap("ContextPath")]
        [Validation(Required=false)]
        public string ContextPath { get; set; }

        [NameInMap("MaxThreads")]
        [Validation(Required=false)]
        public int? MaxThreads { get; set; }

        [NameInMap("Port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        [NameInMap("UriEncoding")]
        [Validation(Required=false)]
        public string UriEncoding { get; set; }

        [NameInMap("UseBodyEncodingForUri")]
        [Validation(Required=false)]
        public bool? UseBodyEncodingForUri { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
