// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFacerecogJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryFacerecogJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryFacerecogJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("FacerecogJobList")]
        [Validation(Required=false)]
        public QueryFacerecogJobListResponseBodyFacerecogJobList FacerecogJobList { get; set; }
        public class QueryFacerecogJobListResponseBodyFacerecogJobList : TeaModel {
            [NameInMap("FacerecogJob")]
            [Validation(Required=false)]
            public List<QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJob> FacerecogJob { get; set; }
            public class QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJob : TeaModel {
                public string CreationTime { get; set; }
                public QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJobVideoFacerecogResult VideoFacerecogResult { get; set; }
                public class QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJobVideoFacerecogResult : TeaModel {
                    [NameInMap("Facerecogs")]
                    [Validation(Required=false)]
                    public QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJobVideoFacerecogResultFacerecogs Facerecogs { get; set; }
                    public class QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJobVideoFacerecogResultFacerecogs : TeaModel {
                        [NameInMap("Facerecog")]
                        [Validation(Required=false)]
                        public List<QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJobVideoFacerecogResultFacerecogsFacerecog> Facerecog { get; set; }
                        public class QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJobVideoFacerecogResultFacerecogsFacerecog : TeaModel {
                            public string Time { get; set; }
                            public QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJobVideoFacerecogResultFacerecogsFacerecogFaces Faces { get; set; }
                            public class QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJobVideoFacerecogResultFacerecogsFacerecogFaces : TeaModel {
                                [NameInMap("Face")]
                                [Validation(Required=false)]
                                public List<QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJobVideoFacerecogResultFacerecogsFacerecogFacesFace> Face { get; set; }
                                public class QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJobVideoFacerecogResultFacerecogsFacerecogFacesFace : TeaModel {
                                    [NameInMap("Score")]
                                    [Validation(Required=false)]
                                    public string Score { get; set; }

                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    [NameInMap("Target")]
                                    [Validation(Required=false)]
                                    public string Target { get; set; }

                                }

                            }
                        }
                    };

                }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJobInput Input { get; set; }
                public class QueryFacerecogJobListResponseBodyFacerecogJobListFacerecogJobInput : TeaModel {
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                }
                public string Id { get; set; }
            }
        };

    }

}
