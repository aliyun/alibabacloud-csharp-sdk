// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class GetUserInfoResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LoginResult")]
        [Validation(Required=false)]
        public GetUserInfoResponseBodyLoginResult LoginResult { get; set; }
        public class GetUserInfoResponseBodyLoginResult : TeaModel {
            [NameInMap("ReturnUrl")]
            [Validation(Required=false)]
            public string ReturnUrl { get; set; }
            [NameInMap("BizUserName")]
            [Validation(Required=false)]
            public string BizUserName { get; set; }
            [NameInMap("BizUid")]
            [Validation(Required=false)]
            public string BizUid { get; set; }
            [NameInMap("BizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }
            [NameInMap("SubBizId")]
            [Validation(Required=false)]
            public List<string> SubBizId { get; set; }
            [NameInMap("LmUserId")]
            [Validation(Required=false)]
            public long? LmUserId { get; set; }
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtInfo { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
