// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetProfileListResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetProfileListResponseBodyData Data { get; set; }
        public class GetProfileListResponseBodyData : TeaModel {
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<GetProfileListResponseBodyDataRecords> Records { get; set; }
            public class GetProfileListResponseBodyDataRecords : TeaModel {
                public int? CatalogId { get; set; }
                public int? ProfileId { get; set; }
                public string IdNumber { get; set; }
                public string SceneType { get; set; }
                public string IsvSubId { get; set; }
                public string Gender { get; set; }
                public string FaceUrl { get; set; }
                public string BizId { get; set; }
                public string SearchMatchingRate { get; set; }
                public string Name { get; set; }
                public string PersonId { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long Total { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
