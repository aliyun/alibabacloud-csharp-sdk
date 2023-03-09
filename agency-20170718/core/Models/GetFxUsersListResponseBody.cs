// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20170718.Models
{
    public class GetFxUsersListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetFxUsersListResponseBodyData Data { get; set; }
        public class GetFxUsersListResponseBodyData : TeaModel {
            [NameInMap("FxUserInfo")]
            [Validation(Required=false)]
            public List<GetFxUsersListResponseBodyDataFxUserInfo> FxUserInfo { get; set; }
            public class GetFxUsersListResponseBodyDataFxUserInfo : TeaModel {
                [NameInMap("CustomerRebateType")]
                [Validation(Required=false)]
                public long? CustomerRebateType { get; set; }

                [NameInMap("DistributionRebateType")]
                [Validation(Required=false)]
                public long? DistributionRebateType { get; set; }

                [NameInMap("IsSub")]
                [Validation(Required=false)]
                public int? IsSub { get; set; }

                [NameInMap("KpId")]
                [Validation(Required=false)]
                public long? KpId { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public int? Level { get; set; }

                [NameInMap("ParentUid")]
                [Validation(Required=false)]
                public long? ParentUid { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public GetFxUsersListResponseBodyPageInfo PageInfo { get; set; }
        public class GetFxUsersListResponseBodyPageInfo : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
