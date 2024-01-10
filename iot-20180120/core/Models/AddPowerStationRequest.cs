// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class AddPowerStationRequest : TeaModel {
        [NameInMap("AlgorithmInstanceUid")]
        [Validation(Required=false)]
        public string AlgorithmInstanceUid { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("PowerStationName")]
        [Validation(Required=false)]
        public string PowerStationName { get; set; }

        [NameInMap("RatedPower")]
        [Validation(Required=false)]
        public int? RatedPower { get; set; }

    }

}
