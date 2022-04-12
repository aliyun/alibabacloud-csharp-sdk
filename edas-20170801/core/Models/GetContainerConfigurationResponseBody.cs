// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetContainerConfigurationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ContainerConfiguration")]
        [Validation(Required=false)]
        public GetContainerConfigurationResponseBodyContainerConfiguration ContainerConfiguration { get; set; }
        public class GetContainerConfigurationResponseBodyContainerConfiguration : TeaModel {
            [NameInMap("ContextPath")]
            [Validation(Required=false)]
            public string ContextPath { get; set; }
            [NameInMap("HttpPort")]
            [Validation(Required=false)]
            public int? HttpPort { get; set; }
            [NameInMap("MaxThreads")]
            [Validation(Required=false)]
            public int? MaxThreads { get; set; }
            [NameInMap("URIEncoding")]
            [Validation(Required=false)]
            public string URIEncoding { get; set; }
            [NameInMap("UseBodyEncoding")]
            [Validation(Required=false)]
            public bool? UseBodyEncoding { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
