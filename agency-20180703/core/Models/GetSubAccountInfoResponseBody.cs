// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20180703.Models
{
    public class GetSubAccountInfoResponseBody : TeaModel {
        [NameInMap("AccountInfoList")]
        [Validation(Required=false)]
        public GetSubAccountInfoResponseBodyAccountInfoList AccountInfoList { get; set; }
        public class GetSubAccountInfoResponseBodyAccountInfoList : TeaModel {
            [NameInMap("AccountInfo")]
            [Validation(Required=false)]
            public List<GetSubAccountInfoResponseBodyAccountInfoListAccountInfo> AccountInfo { get; set; }
            public class GetSubAccountInfoResponseBodyAccountInfoListAccountInfo : TeaModel {
                [NameInMap("AccountNickname")]
                [Validation(Required=false)]
                public string AccountNickname { get; set; }

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
        public GetSubAccountInfoResponseBodyPageInfo PageInfo { get; set; }
        public class GetSubAccountInfoResponseBodyPageInfo : TeaModel {
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
