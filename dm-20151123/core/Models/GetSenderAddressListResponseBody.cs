// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class GetSenderAddressListResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSenderAddressListResponseBodyData Data { get; set; }
        public class GetSenderAddressListResponseBodyData : TeaModel {
            [NameInMap("senderAddressNotificationInfo")]
            [Validation(Required=false)]
            public List<GetSenderAddressListResponseBodyDataSenderAddressNotificationInfo> SenderAddressNotificationInfo { get; set; }
            public class GetSenderAddressListResponseBodyDataSenderAddressNotificationInfo : TeaModel {
                public string Status { get; set; }
                public string UpdateTime { get; set; }
                public string SenderAddress { get; set; }
                public string Region { get; set; }
                public string SenderAddressId { get; set; }
            }
        };

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

    }

}
