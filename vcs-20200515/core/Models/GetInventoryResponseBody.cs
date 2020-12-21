// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetInventoryResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInventoryResponseBodyData Data { get; set; }
        public class GetInventoryResponseBodyData : TeaModel {
            [NameInMap("ResultObject")]
            [Validation(Required=false)]
            public List<GetInventoryResponseBodyDataResultObject> ResultObject { get; set; }
            public class GetInventoryResponseBodyDataResultObject : TeaModel {
                public string CommodityCode { get; set; }
                public string CurrentInventory { get; set; }
                public string InventoryId { get; set; }
                public string InstanceId { get; set; }
                public string BuyerId { get; set; }
                public string ValidStartTime { get; set; }
                public string ValidEndTime { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
