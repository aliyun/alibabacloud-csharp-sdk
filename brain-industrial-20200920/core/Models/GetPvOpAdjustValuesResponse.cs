// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetPvOpAdjustValuesResponse : TeaModel {
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
        public GetPvOpAdjustValuesResponseData Data { get; set; }
        public class GetPvOpAdjustValuesResponseData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("PvopAdjustDataInfo")]
            [Validation(Required=true)]
            public GetPvOpAdjustValuesResponseDataPvopAdjustDataInfo PvopAdjustDataInfo { get; set; }
            public class GetPvOpAdjustValuesResponseDataPvopAdjustDataInfo : TeaModel {
                [NameInMap("Op")]
                [Validation(Required=true)]
                public List<GetPvOpAdjustValuesResponseDataPvopAdjustDataInfoOp> Op { get; set; }
                public class GetPvOpAdjustValuesResponseDataPvopAdjustDataInfoOp : TeaModel {
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

                [NameInMap("Pv")]
                [Validation(Required=true)]
                public List<GetPvOpAdjustValuesResponseDataPvopAdjustDataInfoPv> Pv { get; set; }
                public class GetPvOpAdjustValuesResponseDataPvopAdjustDataInfoPv : TeaModel {
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

                [NameInMap("Sp")]
                [Validation(Required=true)]
                public List<GetPvOpAdjustValuesResponseDataPvopAdjustDataInfoSp> Sp { get; set; }
                public class GetPvOpAdjustValuesResponseDataPvopAdjustDataInfoSp : TeaModel {
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
