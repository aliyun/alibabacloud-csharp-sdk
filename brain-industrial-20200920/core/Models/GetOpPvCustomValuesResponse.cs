// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetOpPvCustomValuesResponse : TeaModel {
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
        public GetOpPvCustomValuesResponseData Data { get; set; }
        public class GetOpPvCustomValuesResponseData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("OppvCustomDataInfo")]
            [Validation(Required=true)]
            public GetOpPvCustomValuesResponseDataOppvCustomDataInfo OppvCustomDataInfo { get; set; }
            public class GetOpPvCustomValuesResponseDataOppvCustomDataInfo : TeaModel {
                [NameInMap("Opzdy")]
                [Validation(Required=true)]
                public List<GetOpPvCustomValuesResponseDataOppvCustomDataInfoOpzdy> Opzdy { get; set; }
                public class GetOpPvCustomValuesResponseDataOppvCustomDataInfoOpzdy : TeaModel {
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

                [NameInMap("Pvzdy")]
                [Validation(Required=true)]
                public List<GetOpPvCustomValuesResponseDataOppvCustomDataInfoPvzdy> Pvzdy { get; set; }
                public class GetOpPvCustomValuesResponseDataOppvCustomDataInfoPvzdy : TeaModel {
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
