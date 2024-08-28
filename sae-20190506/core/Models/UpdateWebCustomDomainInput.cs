// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateWebCustomDomainInput : TeaModel {
        [NameInMap("DefaultForwardingAppName")]
        [Validation(Required=false)]
        public string DefaultForwardingAppName { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("RouteConfig")]
        [Validation(Required=false)]
        public RouteConfig RouteConfig { get; set; }

        [NameInMap("WebCertConfig")]
        [Validation(Required=false)]
        public WebCertConfig WebCertConfig { get; set; }

        [NameInMap("WebTLSConfig")]
        [Validation(Required=false)]
        public WebTLSConfig WebTLSConfig { get; set; }

        [NameInMap("WebWAFConfig")]
        [Validation(Required=false)]
        public WebWAFConfig WebWAFConfig { get; set; }

    }

}
