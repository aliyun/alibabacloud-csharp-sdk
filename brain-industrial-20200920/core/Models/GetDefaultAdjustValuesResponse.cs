// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetDefaultAdjustValuesResponse : TeaModel {
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
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetDefaultAdjustValuesResponseData Data { get; set; }
        public class GetDefaultAdjustValuesResponseData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("DefaultAdjustDataInfo")]
            [Validation(Required=true)]
            public GetDefaultAdjustValuesResponseDataDefaultAdjustDataInfo DefaultAdjustDataInfo { get; set; }
            public class GetDefaultAdjustValuesResponseDataDefaultAdjustDataInfo : TeaModel {
                [NameInMap("ManualCtrl")]
                [Validation(Required=true)]
                public GetDefaultAdjustValuesResponseDataDefaultAdjustDataInfoManualCtrl ManualCtrl { get; set; }
                public class GetDefaultAdjustValuesResponseDataDefaultAdjustDataInfoManualCtrl : TeaModel {
                    [NameInMap("Kp")]
                    [Validation(Required=true)]
                    public float? Kp { get; set; }
                    [NameInMap("Ti")]
                    [Validation(Required=true)]
                    public float? Ti { get; set; }
                    [NameInMap("Td")]
                    [Validation(Required=true)]
                    public float? Td { get; set; }
                };

                [NameInMap("Perform")]
                [Validation(Required=true)]
                public GetDefaultAdjustValuesResponseDataDefaultAdjustDataInfoPerform Perform { get; set; }
                public class GetDefaultAdjustValuesResponseDataDefaultAdjustDataInfoPerform : TeaModel {
                    [NameInMap("RaiseTime")]
                    [Validation(Required=true)]
                    public float? RaiseTime { get; set; }
                    [NameInMap("FinalValue")]
                    [Validation(Required=true)]
                    public float? FinalValue { get; set; }
                    [NameInMap("OverValue")]
                    [Validation(Required=true)]
                    public float? OverValue { get; set; }
                    [NameInMap("StableError")]
                    [Validation(Required=true)]
                    public float? StableError { get; set; }
                    [NameInMap("AdjustTime")]
                    [Validation(Required=true)]
                    public float? AdjustTime { get; set; }
                    [NameInMap("Dynamic")]
                    [Validation(Required=true)]
                    public float? Dynamic { get; set; }
                    [NameInMap("Robust")]
                    [Validation(Required=true)]
                    public float? Robust { get; set; }
                };

                [NameInMap("ManualPerform")]
                [Validation(Required=true)]
                public GetDefaultAdjustValuesResponseDataDefaultAdjustDataInfoManualPerform ManualPerform { get; set; }
                public class GetDefaultAdjustValuesResponseDataDefaultAdjustDataInfoManualPerform : TeaModel {
                    [NameInMap("RaiseTime")]
                    [Validation(Required=true)]
                    public float? RaiseTime { get; set; }
                    [NameInMap("FinalValue")]
                    [Validation(Required=true)]
                    public float? FinalValue { get; set; }
                    [NameInMap("OverValue")]
                    [Validation(Required=true)]
                    public float? OverValue { get; set; }
                    [NameInMap("StableError")]
                    [Validation(Required=true)]
                    public float? StableError { get; set; }
                    [NameInMap("AdjustTime")]
                    [Validation(Required=true)]
                    public float? AdjustTime { get; set; }
                    [NameInMap("Dynamic")]
                    [Validation(Required=true)]
                    public float? Dynamic { get; set; }
                    [NameInMap("Robust")]
                    [Validation(Required=true)]
                    public float? Robust { get; set; }
                };

            }
        };

    }

}
