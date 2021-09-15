// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class SearchFaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchFaceResponseBodyData Data { get; set; }
        public class SearchFaceResponseBodyData : TeaModel {
            [NameInMap("MatchList")]
            [Validation(Required=false)]
            public List<SearchFaceResponseBodyDataMatchList> MatchList { get; set; }
            public class SearchFaceResponseBodyDataMatchList : TeaModel {
                public List<SearchFaceResponseBodyDataMatchListFaceItems> FaceItems { get; set; }
                public class SearchFaceResponseBodyDataMatchListFaceItems : TeaModel {
                    public string EntityId { get; set; }
                    public string FaceId { get; set; }
                    public float? Score { get; set; }
                    public string ExtraData { get; set; }
                    public string DbName { get; set; }
                    public float? Confidence { get; set; }
                }
                public SearchFaceResponseBodyDataMatchListLocation Location { get; set; }
                public class SearchFaceResponseBodyDataMatchListLocation : TeaModel {
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public int? Y { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public int? X { get; set; }

                }
            }
        };

    }

}
