// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ahas_openapi20190901.Models
{
    public class SearchUserApplicationsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<SearchUserApplicationsResponseBodyContent> Content { get; set; }
        public class SearchUserApplicationsResponseBodyContent : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppType")]
            [Validation(Required=false)]
            public int? AppType { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
