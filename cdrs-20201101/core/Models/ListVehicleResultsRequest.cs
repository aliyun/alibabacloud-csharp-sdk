// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CDRS20201101.Models
{
    public class ListVehicleResultsRequest : TeaModel {
        [NameInMap("CorpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("VehicleApplication")]
        [Validation(Required=false)]
        public string VehicleApplication { get; set; }

        [NameInMap("VehicleClass")]
        [Validation(Required=false)]
        public string VehicleClass { get; set; }

        [NameInMap("VehicleColor")]
        [Validation(Required=false)]
        public string VehicleColor { get; set; }

    }

}
