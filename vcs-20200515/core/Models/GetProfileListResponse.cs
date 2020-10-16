// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class GetProfileListResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetProfileListResponseData Data { get; set; }
        public class GetProfileListResponseData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public long PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public long PageSize { get; set; }
            [NameInMap("Success")]
            [Validation(Required=true)]
            public bool? Success { get; set; }
            [NameInMap("Total")]
            [Validation(Required=true)]
            public long Total { get; set; }
            [NameInMap("Records")]
            [Validation(Required=true)]
            public List<GetProfileListResponseDataRecords> Records { get; set; }
            public class GetProfileListResponseDataRecords : TeaModel {
                public string SceneType { get; set; }
                public string BizId { get; set; }
                public string FaceUrl { get; set; }
                public string Gender { get; set; }
                public string IdNumber { get; set; }
                public string IsvSubId { get; set; }
                public string SearchMatchingRate { get; set; }
                public string PersonId { get; set; }
                public int? CatalogId { get; set; }
                public int? ProfileId { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
