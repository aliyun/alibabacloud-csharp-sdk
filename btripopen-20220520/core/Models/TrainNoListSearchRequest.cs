// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainNoListSearchRequest : TeaModel {
        [NameInMap("arr_location")]
        [Validation(Required=false)]
        public string ArrLocation { get; set; }

        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        [NameInMap("dep_location")]
        [Validation(Required=false)]
        public string DepLocation { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public TrainNoListSearchRequestOption Option { get; set; }
        public class TrainNoListSearchRequestOption : TeaModel {
            [NameInMap("need_transfer")]
            [Validation(Required=false)]
            public bool? NeedTransfer { get; set; }

        }

        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
