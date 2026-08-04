// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class QueryEncryptedAccountProfileInfoResponseBody : TeaModel {
        [NameInMap("EncryptedProfileInfo")]
        [Validation(Required=false)]
        public QueryEncryptedAccountProfileInfoResponseBodyEncryptedProfileInfo EncryptedProfileInfo { get; set; }
        public class QueryEncryptedAccountProfileInfoResponseBodyEncryptedProfileInfo : TeaModel {
            [NameInMap("EncryptedAliyunID")]
            [Validation(Required=false)]
            public string EncryptedAliyunID { get; set; }

            [NameInMap("EncryptedEmail")]
            [Validation(Required=false)]
            public string EncryptedEmail { get; set; }

            [NameInMap("EncryptedMobile")]
            [Validation(Required=false)]
            public string EncryptedMobile { get; set; }

            [NameInMap("EncryptedSecurityMobile")]
            [Validation(Required=false)]
            public string EncryptedSecurityMobile { get; set; }

            [NameInMap("IsAliyunIdAnEmail")]
            [Validation(Required=false)]
            public bool? IsAliyunIdAnEmail { get; set; }

            [NameInMap("pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
