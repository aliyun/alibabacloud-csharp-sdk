// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_apm20220214.Models
{
    public class GetSymUploadParamResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSymUploadParamResponseBodyData Data { get; set; }
        public class GetSymUploadParamResponseBodyData : TeaModel {
            [NameInMap("accessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
            [NameInMap("callback")]
            [Validation(Required=false)]
            public string Callback { get; set; }
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("uploadAddress")]
            [Validation(Required=false)]
            public string UploadAddress { get; set; }
        };

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
