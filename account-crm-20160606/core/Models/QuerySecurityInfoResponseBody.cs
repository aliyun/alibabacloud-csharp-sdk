// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QuerySecurityInfoResponseBody : TeaModel {
        [NameInMap("AccountSecurityInfoDto")]
        [Validation(Required=false)]
        public QuerySecurityInfoResponseBodyAccountSecurityInfoDto AccountSecurityInfoDto { get; set; }
        public class QuerySecurityInfoResponseBodyAccountSecurityInfoDto : TeaModel {
            [NameInMap("AliyunId")]
            [Validation(Required=false)]
            public string AliyunId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NationalityCode")]
            [Validation(Required=false)]
            public string NationalityCode { get; set; }

            [NameInMap("Pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

            [NameInMap("ProfileType")]
            [Validation(Required=false)]
            public string ProfileType { get; set; }

            [NameInMap("SecurityEmail")]
            [Validation(Required=false)]
            public string SecurityEmail { get; set; }

            [NameInMap("SecurityMobile")]
            [Validation(Required=false)]
            public string SecurityMobile { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
