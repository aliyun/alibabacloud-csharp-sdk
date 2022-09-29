// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20170622.Models
{
    public class GetAccountListResponseBody : TeaModel {
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAccountListResponseBodyData Data { get; set; }
        public class GetAccountListResponseBodyData : TeaModel {
            [NameInMap("accountNotificationInfo")]
            [Validation(Required=false)]
            public List<GetAccountListResponseBodyDataAccountNotificationInfo> AccountNotificationInfo { get; set; }
            public class GetAccountListResponseBodyDataAccountNotificationInfo : TeaModel {
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

    }

}
