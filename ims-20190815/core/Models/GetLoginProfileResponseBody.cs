// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetLoginProfileResponseBody : TeaModel {
        [NameInMap("LoginProfile")]
        [Validation(Required=false)]
        public GetLoginProfileResponseBodyLoginProfile LoginProfile { get; set; }
        public class GetLoginProfileResponseBodyLoginProfile : TeaModel {
            [NameInMap("LastLoginTime")]
            [Validation(Required=false)]
            public string LastLoginTime { get; set; }

            [NameInMap("MFABindRequired")]
            [Validation(Required=false)]
            public bool? MFABindRequired { get; set; }

            [NameInMap("PasswordResetRequired")]
            [Validation(Required=false)]
            public bool? PasswordResetRequired { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

            [NameInMap("UserPrincipalName")]
            [Validation(Required=false)]
            public string UserPrincipalName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
