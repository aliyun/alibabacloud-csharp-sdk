// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Brain_industrial20200920.Models
{
    public class GetIdentificateValuesResponse : TeaModel {
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
        public GetIdentificateValuesResponseData Data { get; set; }
        public class GetIdentificateValuesResponseData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=true)]
            public bool? Status { get; set; }
            [NameInMap("IdentificateDataInfo")]
            [Validation(Required=true)]
            public GetIdentificateValuesResponseDataIdentificateDataInfo IdentificateDataInfo { get; set; }
            public class GetIdentificateValuesResponseDataIdentificateDataInfo : TeaModel {
                [NameInMap("Dj")]
                [Validation(Required=true)]
                public List<GetIdentificateValuesResponseDataIdentificateDataInfoDj> Dj { get; set; }
                public class GetIdentificateValuesResponseDataIdentificateDataInfoDj : TeaModel {
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

                [NameInMap("Gj")]
                [Validation(Required=true)]
                public List<GetIdentificateValuesResponseDataIdentificateDataInfoGj> Gj { get; set; }
                public class GetIdentificateValuesResponseDataIdentificateDataInfoGj : TeaModel {
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

                [NameInMap("Bs")]
                [Validation(Required=true)]
                public List<GetIdentificateValuesResponseDataIdentificateDataInfoBs> Bs { get; set; }
                public class GetIdentificateValuesResponseDataIdentificateDataInfoBs : TeaModel {
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
