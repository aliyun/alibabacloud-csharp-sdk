// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseAccountQueryAccountGrantedRolesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<EnterpriseAccountQueryAccountGrantedRolesResponseBodyData> Data { get; set; }
        public class EnterpriseAccountQueryAccountGrantedRolesResponseBodyData : TeaModel {
            [NameInMap("BizRoleCode")]
            [Validation(Required=false)]
            public string BizRoleCode { get; set; }

            [NameInMap("BizRoleName")]
            [Validation(Required=false)]
            public string BizRoleName { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
