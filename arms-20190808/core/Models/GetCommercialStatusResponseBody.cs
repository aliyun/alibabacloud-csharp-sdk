// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetCommercialStatusResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserAndCommodityStatus")]
        [Validation(Required=false)]
        public GetCommercialStatusResponseBodyUserAndCommodityStatus UserAndCommodityStatus { get; set; }
        public class GetCommercialStatusResponseBodyUserAndCommodityStatus : TeaModel {
            [NameInMap("Basic")]
            [Validation(Required=false)]
            public bool? Basic { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtraInfo { get; set; }

            [NameInMap("FreeDays")]
            [Validation(Required=false)]
            public long? FreeDays { get; set; }

            [NameInMap("Lable")]
            [Validation(Required=false)]
            public string Lable { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
