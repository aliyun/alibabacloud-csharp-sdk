// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BatchResponseBody : TeaModel {
        [NameInMap("responses")]
        [Validation(Required=false)]
        public List<BatchResponseBodyResponses> Responses { get; set; }
        public class BatchResponseBodyResponses : TeaModel {
            [NameInMap("body")]
            [Validation(Required=false)]
            public Dictionary<string, string> Body { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
