// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class GetUserApplicationsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("AppNameAndIdPairs")]
        [Validation(Required=false)]
        public List<GetUserApplicationsResponseBodyAppNameAndIdPairs> AppNameAndIdPairs { get; set; }
        public class GetUserApplicationsResponseBodyAppNameAndIdPairs : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public int? ScopeType { get; set; }

            [NameInMap("AppType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
