// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180701.Models
{
    public class GetAccountInfoResponseBody : TeaModel {
        [NameInMap("AccountInfoList")]
        [Validation(Required=false)]
        public GetAccountInfoResponseBodyAccountInfoList AccountInfoList { get; set; }
        public class GetAccountInfoResponseBodyAccountInfoList : TeaModel {
            [NameInMap("AccountInfo")]
            [Validation(Required=false)]
            public List<GetAccountInfoResponseBodyAccountInfoListAccountInfo> AccountInfo { get; set; }
            public class GetAccountInfoResponseBodyAccountInfoListAccountInfo : TeaModel {
                [NameInMap("AccountNickname")]
                [Validation(Required=false)]
                public string AccountNickname { get; set; }

                [NameInMap("AliyunId")]
                [Validation(Required=false)]
                public string AliyunId { get; set; }

                [NameInMap("AssociationSuccessTime")]
                [Validation(Required=false)]
                public string AssociationSuccessTime { get; set; }

                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public string Mobile { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("SubAccountType")]
                [Validation(Required=false)]
                public int? SubAccountType { get; set; }

                [NameInMap("Uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

            }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetAccountInfoResponseBodyPageInfo PageInfo { get; set; }
        public class GetAccountInfoResponseBodyPageInfo : TeaModel {
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
