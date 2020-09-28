// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetLowModelPerformValuesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public Dictionary<string, object> Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetLowModelPerformValuesResponseData Data { get; set; }
        public class GetLowModelPerformValuesResponseData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("LowModelPerformDataInfo")]
            [Validation(Required=true)]
            public GetLowModelPerformValuesResponseDataLowModelPerformDataInfo LowModelPerformDataInfo { get; set; }
            public class GetLowModelPerformValuesResponseDataLowModelPerformDataInfo : TeaModel {
                [NameInMap("Confidence")]
                [Validation(Required=true)]
                public float? Confidence { get; set; }

                [NameInMap("FitDegree")]
                [Validation(Required=true)]
                public float? FitDegree { get; set; }

                [NameInMap("ManualModel")]
                [Validation(Required=true)]
                public GetLowModelPerformValuesResponseDataLowModelPerformDataInfoManualModel ManualModel { get; set; }
                public class GetLowModelPerformValuesResponseDataLowModelPerformDataInfoManualModel : TeaModel {
                    [NameInMap("K")]
                    [Validation(Required=true)]
                    public float? K { get; set; }
                    [NameInMap("Tau")]
                    [Validation(Required=true)]
                    public float? Tau { get; set; }
                    [NameInMap("T1")]
                    [Validation(Required=true)]
                    public float? T1 { get; set; }
                    [NameInMap("T2")]
                    [Validation(Required=true)]
                    public float? T2 { get; set; }
                };

            }
        };

    }

}
