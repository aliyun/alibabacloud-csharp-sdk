// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddi20200617.Models
{
    public class QueryKnoxUserPasswordResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserInfoList")]
        [Validation(Required=false)]
        public QueryKnoxUserPasswordResponseBodyUserInfoList UserInfoList { get; set; }
        public class QueryKnoxUserPasswordResponseBodyUserInfoList : TeaModel {
            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public List<QueryKnoxUserPasswordResponseBodyUserInfoListUserInfo> UserInfo { get; set; }
            public class QueryKnoxUserPasswordResponseBodyUserInfoListUserInfo : TeaModel {
                public string Password { get; set; }
                public string UserName { get; set; }
                public string UserId { get; set; }
            }
        };

    }

}
