// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetPvIdentSimulationValuesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetPvIdentSimulationValuesResponseData Data { get; set; }
        public class GetPvIdentSimulationValuesResponseData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("PvIdentSimulateDataInfo")]
            [Validation(Required=true)]
            public GetPvIdentSimulationValuesResponseDataPvIdentSimulateDataInfo PvIdentSimulateDataInfo { get; set; }
            public class GetPvIdentSimulationValuesResponseDataPvIdentSimulateDataInfo : TeaModel {
                [NameInMap("Pv")]
                [Validation(Required=true)]
                public List<GetPvIdentSimulationValuesResponseDataPvIdentSimulateDataInfoPv> Pv { get; set; }
                public class GetPvIdentSimulationValuesResponseDataPvIdentSimulateDataInfoPv : TeaModel {
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
