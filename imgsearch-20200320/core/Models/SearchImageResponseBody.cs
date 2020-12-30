// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imgsearch20200320.Models
{
    public class SearchImageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchImageResponseBodyData Data { get; set; }
        public class SearchImageResponseBodyData : TeaModel {
            [NameInMap("MatchList")]
            [Validation(Required=false)]
            public List<SearchImageResponseBodyDataMatchList> MatchList { get; set; }
            public class SearchImageResponseBodyDataMatchList : TeaModel {
                public string ImageUrl { get; set; }
                public string EntityId { get; set; }
                public float? Score { get; set; }
                public string DataId { get; set; }
                public string ExtraData { get; set; }
            }
        };

    }

}
