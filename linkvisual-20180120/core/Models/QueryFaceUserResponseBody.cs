// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryFaceUserResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFaceUserResponseBodyData Data { get; set; }
        public class QueryFaceUserResponseBodyData : TeaModel {
            [NameInMap("CustomUserId")]
            [Validation(Required=false)]
            public string CustomUserId { get; set; }

            [NameInMap("FacePicList")]
            [Validation(Required=false)]
            public List<QueryFaceUserResponseBodyDataFacePicList> FacePicList { get; set; }
            public class QueryFaceUserResponseBodyDataFacePicList : TeaModel {
                [NameInMap("FaceMd5")]
                [Validation(Required=false)]
                public string FaceMd5 { get; set; }

                [NameInMap("FaceUrl")]
                [Validation(Required=false)]
                public string FaceUrl { get; set; }

                [NameInMap("FeatureDTOList")]
                [Validation(Required=false)]
                public List<QueryFaceUserResponseBodyDataFacePicListFeatureDTOList> FeatureDTOList { get; set; }
                public class QueryFaceUserResponseBodyDataFacePicListFeatureDTOList : TeaModel {
                    [NameInMap("AlgorithmName")]
                    [Validation(Required=false)]
                    public string AlgorithmName { get; set; }

                    [NameInMap("AlgorithmProvider")]
                    [Validation(Required=false)]
                    public string AlgorithmProvider { get; set; }

                    [NameInMap("AlgorithmVersion")]
                    [Validation(Required=false)]
                    public string AlgorithmVersion { get; set; }

                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("FaceMd5")]
                    [Validation(Required=false)]
                    public string FaceMd5 { get; set; }

                }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Params")]
            [Validation(Required=false)]
            public string Params { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
