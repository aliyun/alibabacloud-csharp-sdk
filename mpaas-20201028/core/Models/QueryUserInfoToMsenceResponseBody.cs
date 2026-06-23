// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryUserInfoToMsenceResponseBody : TeaModel {
        [NameInMap("MpaasUserInfoShareResponse")]
        [Validation(Required=false)]
        public QueryUserInfoToMsenceResponseBodyMpaasUserInfoShareResponse MpaasUserInfoShareResponse { get; set; }
        public class QueryUserInfoToMsenceResponseBodyMpaasUserInfoShareResponse : TeaModel {
            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
