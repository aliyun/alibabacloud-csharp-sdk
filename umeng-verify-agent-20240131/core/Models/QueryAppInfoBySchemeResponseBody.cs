// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_verify_agent20240131.Models
{
    public class QueryAppInfoBySchemeResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryAppInfoBySchemeResponseBodyData Data { get; set; }
        public class QueryAppInfoBySchemeResponseBodyData : TeaModel {
            [NameInMap("cmAppId")]
            [Validation(Required=false)]
            public string CmAppId { get; set; }

            [NameInMap("cmAppKey")]
            [Validation(Required=false)]
            public string CmAppKey { get; set; }

            [NameInMap("ctAppId")]
            [Validation(Required=false)]
            public string CtAppId { get; set; }

            [NameInMap("ctAppKey")]
            [Validation(Required=false)]
            public string CtAppKey { get; set; }

            [NameInMap("cuAppId")]
            [Validation(Required=false)]
            public string CuAppId { get; set; }

            [NameInMap("cuAppKey")]
            [Validation(Required=false)]
            public string CuAppKey { get; set; }

            [NameInMap("cuRsaPublickKey")]
            [Validation(Required=false)]
            public string CuRsaPublickKey { get; set; }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
