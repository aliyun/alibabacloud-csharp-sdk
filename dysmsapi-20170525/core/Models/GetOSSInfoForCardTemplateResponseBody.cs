// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class GetOSSInfoForCardTemplateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOSSInfoForCardTemplateResponseBodyData Data { get; set; }
        public class GetOSSInfoForCardTemplateResponseBodyData : TeaModel {
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
