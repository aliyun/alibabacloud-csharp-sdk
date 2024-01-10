// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class StartPTDetectionRequest : TeaModel {
        [NameInMap("AlgorithmInstanceUid")]
        [Validation(Required=false)]
        public string AlgorithmInstanceUid { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("DataCollectionTime")]
        [Validation(Required=false)]
        public long? DataCollectionTime { get; set; }

        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("PowerPlantsNumber")]
        [Validation(Required=false)]
        public int? PowerPlantsNumber { get; set; }

        [NameInMap("PowerStationUid")]
        [Validation(Required=false)]
        public string PowerStationUid { get; set; }

        [NameInMap("Sensitivity")]
        [Validation(Required=false)]
        public int? Sensitivity { get; set; }

    }

}
