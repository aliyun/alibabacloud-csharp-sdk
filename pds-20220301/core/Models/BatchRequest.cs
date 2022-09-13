// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BatchRequest : TeaModel {
        [NameInMap("requests")]
        [Validation(Required=false)]
        public List<BatchRequestRequests> Requests { get; set; }
        public class BatchRequestRequests : TeaModel {
            [NameInMap("body")]
            [Validation(Required=false)]
            public Dictionary<string, string> Body { get; set; }

            [NameInMap("headers")]
            [Validation(Required=false)]
            public Dictionary<string, string> Headers { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

    }

}
