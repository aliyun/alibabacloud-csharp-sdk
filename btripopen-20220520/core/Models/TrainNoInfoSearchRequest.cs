// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainNoInfoSearchRequest : TeaModel {
        [NameInMap("arr_location")]
        [Validation(Required=false)]
        public string ArrLocation { get; set; }

        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        [NameInMap("dep_location")]
        [Validation(Required=false)]
        public string DepLocation { get; set; }

        [NameInMap("line_key")]
        [Validation(Required=false)]
        public string LineKey { get; set; }

        [NameInMap("middle_date")]
        [Validation(Required=false)]
        public string MiddleDate { get; set; }

        [NameInMap("middle_station")]
        [Validation(Required=false)]
        public string MiddleStation { get; set; }

        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("train_no")]
        [Validation(Required=false)]
        public string TrainNo { get; set; }

    }

}
