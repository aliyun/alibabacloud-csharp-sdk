// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryOrderCommissionRateResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CommissionModels")]
        [Validation(Required=false)]
        public List<QueryOrderCommissionRateResponseBodyCommissionModels> CommissionModels { get; set; }
        public class QueryOrderCommissionRateResponseBodyCommissionModels : TeaModel {
            [NameInMap("LmOrderId")]
            [Validation(Required=false)]
            public long? LmOrderId { get; set; }

            [NameInMap("CommissionInfo")]
            [Validation(Required=false)]
            public QueryOrderCommissionRateResponseBodyCommissionModelsCommissionInfo CommissionInfo { get; set; }
            public class QueryOrderCommissionRateResponseBodyCommissionModelsCommissionInfo : TeaModel {
                [NameInMap("RateConfig")]
                [Validation(Required=false)]
                public QueryOrderCommissionRateResponseBodyCommissionModelsCommissionInfoRateConfig RateConfig { get; set; }
                public class QueryOrderCommissionRateResponseBodyCommissionModelsCommissionInfoRateConfig : TeaModel {
                    [NameInMap("Configs")]
                    [Validation(Required=false)]
                    public List<QueryOrderCommissionRateResponseBodyCommissionModelsCommissionInfoRateConfigConfigs> Configs { get; set; }
                    public class QueryOrderCommissionRateResponseBodyCommissionModelsCommissionInfoRateConfigConfigs : TeaModel {
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public long? Value { get; set; }

                        [NameInMap("ValueUnit")]
                        [Validation(Required=false)]
                        public string ValueUnit { get; set; }

                    }

                }
                [NameInMap("RateType")]
                [Validation(Required=false)]
                public string RateType { get; set; }
            };

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
