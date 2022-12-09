// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class SendByAliasFileIdResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=true)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public SendByAliasFileIdResponseBody Body { get; set; }

    }

}
