// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetCustomIdentValuesResponse : TeaModel {
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
        public GetCustomIdentValuesResponseData Data { get; set; }
        public class GetCustomIdentValuesResponseData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("CustomIdentDataInfo")]
            [Validation(Required=true)]
            public GetCustomIdentValuesResponseDataCustomIdentDataInfo CustomIdentDataInfo { get; set; }
            public class GetCustomIdentValuesResponseDataCustomIdentDataInfo : TeaModel {
                [NameInMap("CustomModelTrend")]
                [Validation(Required=true)]
                public List<GetCustomIdentValuesResponseDataCustomIdentDataInfoCustomModelTrend> CustomModelTrend { get; set; }
                public class GetCustomIdentValuesResponseDataCustomIdentDataInfoCustomModelTrend : TeaModel {
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

                [NameInMap("CustomResidual")]
                [Validation(Required=true)]
                public List<GetCustomIdentValuesResponseDataCustomIdentDataInfoCustomResidual> CustomResidual { get; set; }
                public class GetCustomIdentValuesResponseDataCustomIdentDataInfoCustomResidual : TeaModel {
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
