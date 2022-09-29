// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class SearchFaceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SearchFaceResponseBodyData Data { get; set; }
        public class SearchFaceResponseBodyData : TeaModel {
            [NameInMap("MatchList")]
            [Validation(Required=false)]
            public List<SearchFaceResponseBodyDataMatchList> MatchList { get; set; }
            public class SearchFaceResponseBodyDataMatchList : TeaModel {
                [NameInMap("FaceItems")]
                [Validation(Required=false)]
                public List<SearchFaceResponseBodyDataMatchListFaceItems> FaceItems { get; set; }
                public class SearchFaceResponseBodyDataMatchListFaceItems : TeaModel {
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    [NameInMap("DbName")]
                    [Validation(Required=false)]
                    public string DbName { get; set; }

                    [NameInMap("EntityId")]
                    [Validation(Required=false)]
                    public string EntityId { get; set; }

                    [NameInMap("ExtraData")]
                    [Validation(Required=false)]
                    public string ExtraData { get; set; }

                    [NameInMap("FaceId")]
                    [Validation(Required=false)]
                    public string FaceId { get; set; }

                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public float? Score { get; set; }

                }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public SearchFaceResponseBodyDataMatchListLocation Location { get; set; }
                public class SearchFaceResponseBodyDataMatchListLocation : TeaModel {
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public int? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public int? Y { get; set; }

                }

                [NameInMap("QualitieScore")]
                [Validation(Required=false)]
                public float? QualitieScore { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
