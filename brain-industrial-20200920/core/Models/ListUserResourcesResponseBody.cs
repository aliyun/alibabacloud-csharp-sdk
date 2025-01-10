// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class ListUserResourcesResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUserResourcesResponseBodyData> Data { get; set; }
        public class ListUserResourcesResponseBodyData : TeaModel {
            [NameInMap("chargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            [NameInMap("endDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("statusMsg")]
            [Validation(Required=false)]
            public string StatusMsg { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
