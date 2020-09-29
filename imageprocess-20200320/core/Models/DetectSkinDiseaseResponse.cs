// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectSkinDiseaseResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public DetectSkinDiseaseResponseData Data { get; set; }
        public class DetectSkinDiseaseResponseData : TeaModel {
            [NameInMap("Results")]
            [Validation(Required=true)]
            public Dictionary<string, string> Results { get; set; }
        };

    }

}
