// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetWebContainerConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WebContainerConfig")]
        [Validation(Required=false)]
        public GetWebContainerConfigResponseBodyWebContainerConfig WebContainerConfig { get; set; }
        public class GetWebContainerConfigResponseBodyWebContainerConfig : TeaModel {
            [NameInMap("ContextInputType")]
            [Validation(Required=false)]
            public string ContextInputType { get; set; }
            [NameInMap("ContextPath")]
            [Validation(Required=false)]
            public string ContextPath { get; set; }
            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public int? HttpPort { get; set; }
            [NameInMap("MaxThreads")]
            [Validation(Required=false)]
            public int? MaxThreads { get; set; }
            [NameInMap("ServerXml")]
            [Validation(Required=false)]
            public string ServerXml { get; set; }
            [NameInMap("UriEncoding")]
            [Validation(Required=false)]
            public string UriEncoding { get; set; }
            [NameInMap("UseAdvancedServerXml")]
            [Validation(Required=false)]
            public bool? UseAdvancedServerXml { get; set; }
            [NameInMap("UseBodyEncoding")]
            [Validation(Required=false)]
            public bool? UseBodyEncoding { get; set; }
            [NameInMap("UseDefaultConfig")]
            [Validation(Required=false)]
            public bool? UseDefaultConfig { get; set; }
        };

    }

}
