// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryTagJobListResponseBody : TeaModel {
        [NameInMap("TagJobList")]
        [Validation(Required=false)]
        public QueryTagJobListResponseBodyTagJobList TagJobList { get; set; }
        public class QueryTagJobListResponseBodyTagJobList : TeaModel {
            [NameInMap("TagJob")]
            [Validation(Required=false)]
            public List<QueryTagJobListResponseBodyTagJobListTagJob> TagJob { get; set; }
            public class QueryTagJobListResponseBodyTagJobListTagJob : TeaModel {
                public string CreationTime { get; set; }
                public QueryTagJobListResponseBodyTagJobListTagJobVideoTagResult VideoTagResult { get; set; }
                public class QueryTagJobListResponseBodyTagJobListTagJobVideoTagResult : TeaModel {
                    [NameInMap("TagAnResults")]
                    [Validation(Required=false)]
                    public QueryTagJobListResponseBodyTagJobListTagJobVideoTagResultTagAnResults TagAnResults { get; set; }
                    public class QueryTagJobListResponseBodyTagJobListTagJobVideoTagResultTagAnResults : TeaModel {
                        [NameInMap("TagAnResult")]
                        [Validation(Required=false)]
                        public List<QueryTagJobListResponseBodyTagJobListTagJobVideoTagResultTagAnResultsTagAnResult> TagAnResult { get; set; }
                        public class QueryTagJobListResponseBodyTagJobListTagJobVideoTagResultTagAnResultsTagAnResult : TeaModel {
                            public string Score { get; set; }
                            public string Label { get; set; }
                        }
                    };

                    [NameInMap("TagFrResults")]
                    [Validation(Required=false)]
                    public QueryTagJobListResponseBodyTagJobListTagJobVideoTagResultTagFrResults TagFrResults { get; set; }
                    public class QueryTagJobListResponseBodyTagJobListTagJobVideoTagResultTagFrResults : TeaModel {
                        [NameInMap("TagFrResult")]
                        [Validation(Required=false)]
                        public List<QueryTagJobListResponseBodyTagJobListTagJobVideoTagResultTagFrResultsTagFrResult> TagFrResult { get; set; }
                        public class QueryTagJobListResponseBodyTagJobListTagJobVideoTagResultTagFrResultsTagFrResult : TeaModel {
                            public QueryTagJobListResponseBodyTagJobListTagJobVideoTagResultTagFrResultsTagFrResultTagFaces TagFaces { get; set; }
                            public class QueryTagJobListResponseBodyTagJobListTagJobVideoTagResultTagFrResultsTagFrResultTagFaces : TeaModel {
                                [NameInMap("TagFace")]
                                [Validation(Required=false)]
                                public List<QueryTagJobListResponseBodyTagJobListTagJobVideoTagResultTagFrResultsTagFrResultTagFacesTagFace> TagFace { get; set; }
                                public class QueryTagJobListResponseBodyTagJobListTagJobVideoTagResultTagFrResultsTagFrResultTagFacesTagFace : TeaModel {
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
                            public string Time { get; set; }
                        }
                    };

                    [NameInMap("Details")]
                    [Validation(Required=false)]
                    public string Details { get; set; }

                }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public QueryTagJobListResponseBodyTagJobListTagJobInput Input { get; set; }
                public class QueryTagJobListResponseBodyTagJobListTagJobInput : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryTagJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryTagJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
