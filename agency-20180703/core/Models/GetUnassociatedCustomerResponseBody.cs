// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetUnassociatedCustomerResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("InviteInfoList")]
        [Validation(Required=false)]
        public GetUnassociatedCustomerResponseBodyInviteInfoList InviteInfoList { get; set; }
        public class GetUnassociatedCustomerResponseBodyInviteInfoList : TeaModel {
            [NameInMap("InviteInfo")]
            [Validation(Required=false)]
            public List<GetUnassociatedCustomerResponseBodyInviteInfoListInviteInfo> InviteInfo { get; set; }
            public class GetUnassociatedCustomerResponseBodyInviteInfoListInviteInfo : TeaModel {
                [NameInMap("AccountNickname")]
                [Validation(Required=false)]
                public string AccountNickname { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("InviteId")]
                [Validation(Required=false)]
                public long? InviteId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetUnassociatedCustomerResponseBodyPageInfo PageInfo { get; set; }
        public class GetUnassociatedCustomerResponseBodyPageInfo : TeaModel {
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
