// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetPvCustomSimulationValuesResponse : TeaModel {
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
        public GetPvCustomSimulationValuesResponseData Data { get; set; }
        public class GetPvCustomSimulationValuesResponseData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("PvCustomSimulateDataInfo")]
            [Validation(Required=true)]
            public GetPvCustomSimulationValuesResponseDataPvCustomSimulateDataInfo PvCustomSimulateDataInfo { get; set; }
            public class GetPvCustomSimulationValuesResponseDataPvCustomSimulateDataInfo : TeaModel {
                [NameInMap("Pv")]
                [Validation(Required=true)]
                public List<GetPvCustomSimulationValuesResponseDataPvCustomSimulateDataInfoPv> Pv { get; set; }
                public class GetPvCustomSimulationValuesResponseDataPvCustomSimulateDataInfoPv : TeaModel {
                    [NameInMap("Xlabel")]
                    [Validation(Required=true)]
                    public float? Xlabel { get; set; }

                    [NameInMap("Ylabel")]
                    [Validation(Required=true)]
                    public float? Ylabel { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=true)]
                    public string Name { get; set; }

                    [NameInMap("Quality")]
                    [Validation(Required=true)]
                    public int? Quality { get; set; }

                }

            }
        };

    }

}
