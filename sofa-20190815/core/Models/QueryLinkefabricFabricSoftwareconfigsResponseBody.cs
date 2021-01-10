// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkefabricFabricSoftwareconfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryLinkefabricFabricSoftwareconfigsResponseBodyData Data { get; set; }
        public class QueryLinkefabricFabricSoftwareconfigsResponseBodyData : TeaModel {
            [NameInMap("AppConfigMap")]
            [Validation(Required=false)]
            public string AppConfigMap { get; set; }
            [NameInMap("ReleaseId")]
            [Validation(Required=false)]
            public string ReleaseId { get; set; }
            [NameInMap("AppList")]
            [Validation(Required=false)]
            public List<string> AppList { get; set; }
        };

    }

}
