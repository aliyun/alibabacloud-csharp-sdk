// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class DeletePowerStationRequest : TeaModel {
        [NameInMap("AlgorithmInstanceUid")]
        [Validation(Required=false)]
        public string AlgorithmInstanceUid { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("PowerStationUid")]
        [Validation(Required=false)]
        public string PowerStationUid { get; set; }

    }

}
