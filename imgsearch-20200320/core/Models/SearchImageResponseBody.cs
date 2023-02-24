// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imgsearch20200320.Models
{
    public class SearchImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchImageResponseBodyData Data { get; set; }
        public class SearchImageResponseBodyData : TeaModel {
            [NameInMap("MatchList")]
            [Validation(Required=false)]
            public List<SearchImageResponseBodyDataMatchList> MatchList { get; set; }
            public class SearchImageResponseBodyDataMatchList : TeaModel {
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                [NameInMap("ExtraData")]
                [Validation(Required=false)]
                public string ExtraData { get; set; }

                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public float? Score { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
