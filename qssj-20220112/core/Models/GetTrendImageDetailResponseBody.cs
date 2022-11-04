// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qssj20220112.Models
{
    public class GetTrendImageDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTrendImageDetailResponseBodyData Data { get; set; }
        public class GetTrendImageDetailResponseBodyData : TeaModel {
            [NameInMap("AiImgId")]
            [Validation(Required=false)]
            public string AiImgId { get; set; }

            [NameInMap("AiImgUrl")]
            [Validation(Required=false)]
            public string AiImgUrl { get; set; }

            [NameInMap("MultiPictUrl")]
            [Validation(Required=false)]
            public string MultiPictUrl { get; set; }

            [NameInMap("Population")]
            [Validation(Required=false)]
            public string Population { get; set; }

            [NameInMap("PriceMax")]
            [Validation(Required=false)]
            public long? PriceMax { get; set; }

            [NameInMap("PriceMin")]
            [Validation(Required=false)]
            public long? PriceMin { get; set; }

            [NameInMap("SimilarGoods")]
            [Validation(Required=false)]
            public List<GetTrendImageDetailResponseBodyDataSimilarGoods> SimilarGoods { get; set; }
            public class GetTrendImageDetailResponseBodyDataSimilarGoods : TeaModel {
                [NameInMap("AiImgUrl")]
                [Validation(Required=false)]
                public string AiImgUrl { get; set; }

                [NameInMap("GoodsSales")]
                [Validation(Required=false)]
                public long? GoodsSales { get; set; }

                [NameInMap("SearchVolume")]
                [Validation(Required=false)]
                public long? SearchVolume { get; set; }

            }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessResponse")]
        [Validation(Required=false)]
        public bool? SuccessResponse { get; set; }

    }

}
