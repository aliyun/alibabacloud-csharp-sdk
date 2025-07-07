// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseAccountQueryAccountsInfoResponseBody : TeaModel {
        [NameInMap("AccountInfoDtoList")]
        [Validation(Required=false)]
        public List<EnterpriseAccountQueryAccountsInfoResponseBodyAccountInfoDtoList> AccountInfoDtoList { get; set; }
        public class EnterpriseAccountQueryAccountsInfoResponseBodyAccountInfoDtoList : TeaModel {
            [NameInMap("Alias")]
            [Validation(Required=false)]
            public string Alias { get; set; }

            [NameInMap("BelongToMasterAccount")]
            [Validation(Required=false)]
            public bool? BelongToMasterAccount { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("EnterpriseEcId")]
            [Validation(Required=false)]
            public string EnterpriseEcId { get; set; }

            [NameInMap("EnterpriseEntityId")]
            [Validation(Required=false)]
            public string EnterpriseEntityId { get; set; }

            [NameInMap("EnterpriseLicenseNo")]
            [Validation(Required=false)]
            public string EnterpriseLicenseNo { get; set; }

            [NameInMap("EnterpriseName")]
            [Validation(Required=false)]
            public string EnterpriseName { get; set; }

            [NameInMap("EnterpriseNbId")]
            [Validation(Required=false)]
            public string EnterpriseNbId { get; set; }

            [NameInMap("FreezeLogin")]
            [Validation(Required=false)]
            public bool? FreezeLogin { get; set; }

            [NameInMap("LoginId")]
            [Validation(Required=false)]
            public string LoginId { get; set; }

            [NameInMap("ManageInviteTimeStamp")]
            [Validation(Required=false)]
            public string ManageInviteTimeStamp { get; set; }

            [NameInMap("Pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

            [NameInMap("SecurityMobile")]
            [Validation(Required=false)]
            public string SecurityMobile { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
