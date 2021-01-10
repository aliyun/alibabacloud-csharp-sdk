// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryAnnotationJobListResponseBody : TeaModel {
        [NameInMap("AnnotationJobList")]
        [Validation(Required=false)]
        public QueryAnnotationJobListResponseBodyAnnotationJobList AnnotationJobList { get; set; }
        public class QueryAnnotationJobListResponseBodyAnnotationJobList : TeaModel {
            [NameInMap("AnnotationJob")]
            [Validation(Required=false)]
            public List<QueryAnnotationJobListResponseBodyAnnotationJobListAnnotationJob> AnnotationJob { get; set; }
            public class QueryAnnotationJobListResponseBodyAnnotationJobListAnnotationJob : TeaModel {
                public string CreationTime { get; set; }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public QueryAnnotationJobListResponseBodyAnnotationJobListAnnotationJobInput Input { get; set; }
                public class QueryAnnotationJobListResponseBodyAnnotationJobListAnnotationJobInput : TeaModel {
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
                public QueryAnnotationJobListResponseBodyAnnotationJobListAnnotationJobVideoAnnotationResult VideoAnnotationResult { get; set; }
                public class QueryAnnotationJobListResponseBodyAnnotationJobListAnnotationJobVideoAnnotationResult : TeaModel {
                    [NameInMap("Annotations")]
                    [Validation(Required=false)]
                    public QueryAnnotationJobListResponseBodyAnnotationJobListAnnotationJobVideoAnnotationResultAnnotations Annotations { get; set; }
                    public class QueryAnnotationJobListResponseBodyAnnotationJobListAnnotationJobVideoAnnotationResultAnnotations : TeaModel {
                        [NameInMap("Annotation")]
                        [Validation(Required=false)]
                        public List<QueryAnnotationJobListResponseBodyAnnotationJobListAnnotationJobVideoAnnotationResultAnnotationsAnnotation> Annotation { get; set; }
                        public class QueryAnnotationJobListResponseBodyAnnotationJobListAnnotationJobVideoAnnotationResultAnnotationsAnnotation : TeaModel {
                            public string Score { get; set; }
                            public string Label { get; set; }
                        }
                    };

                    [NameInMap("Details")]
                    [Validation(Required=false)]
                    public string Details { get; set; }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryAnnotationJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryAnnotationJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
