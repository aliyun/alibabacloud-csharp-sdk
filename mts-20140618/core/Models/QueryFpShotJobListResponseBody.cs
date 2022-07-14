// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpShotJobListResponseBody : TeaModel {
        [NameInMap("FpShotJobList")]
        [Validation(Required=false)]
        public QueryFpShotJobListResponseBodyFpShotJobList FpShotJobList { get; set; }
        public class QueryFpShotJobListResponseBodyFpShotJobList : TeaModel {
            [NameInMap("FpShotJob")]
            [Validation(Required=false)]
            public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJob> FpShotJob { get; set; }
            public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJob : TeaModel {
                public string Code { get; set; }
                public string CreationTime { get; set; }
                public string FileId { get; set; }
                public string FinishTime { get; set; }
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotConfig FpShotConfig { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotConfig : TeaModel {
                    [NameInMap("FpDBId")]
                    [Validation(Required=false)]
                    public string FpDBId { get; set; }

                    [NameInMap("PrimaryKey")]
                    [Validation(Required=false)]
                    public string PrimaryKey { get; set; }

                    [NameInMap("SaveType")]
                    [Validation(Required=false)]
                    public string SaveType { get; set; }

                }
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResult FpShotResult { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResult : TeaModel {
                    [NameInMap("AudioFpShots")]
                    [Validation(Required=false)]
                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShots AudioFpShots { get; set; }
                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShots : TeaModel {
                        [NameInMap("FpShot")]
                        [Validation(Required=false)]
                        public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShot> FpShot { get; set; }
                        public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShot : TeaModel {
                            public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlices FpShotSlices { get; set; }
                            public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlices : TeaModel {
                                [NameInMap("FpShotSlice")]
                                [Validation(Required=false)]
                                public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSlice> FpShotSlice { get; set; }
                                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSlice : TeaModel {
                                    [NameInMap("Duplication")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceDuplication Duplication { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceDuplication : TeaModel {
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }
                                    };

                                    [NameInMap("Input")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceInput Input { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceInput : TeaModel {
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }
                                    };

                                    [NameInMap("Similarity")]
                                    [Validation(Required=false)]
                                    public string Similarity { get; set; }

                                }

                            }
                            public string PrimaryKey { get; set; }
                            public string Similarity { get; set; }
                        }
                    };

                    [NameInMap("FpShots")]
                    [Validation(Required=false)]
                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShots FpShots { get; set; }
                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShots : TeaModel {
                        [NameInMap("FpShot")]
                        [Validation(Required=false)]
                        public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShot> FpShot { get; set; }
                        public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShot : TeaModel {
                            public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlices FpShotSlices { get; set; }
                            public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlices : TeaModel {
                                [NameInMap("FpShotSlice")]
                                [Validation(Required=false)]
                                public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSlice> FpShotSlice { get; set; }
                                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSlice : TeaModel {
                                    [NameInMap("Duplication")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceDuplication Duplication { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceDuplication : TeaModel {
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }
                                    };

                                    [NameInMap("Input")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceInput Input { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceInput : TeaModel {
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }
                                    };

                                    [NameInMap("Similarity")]
                                    [Validation(Required=false)]
                                    public string Similarity { get; set; }

                                }

                            }
                            public string PrimaryKey { get; set; }
                            public string Similarity { get; set; }
                        }
                    };

                    [NameInMap("TextFpShots")]
                    [Validation(Required=false)]
                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShots TextFpShots { get; set; }
                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShots : TeaModel {
                        [NameInMap("TextFpShot")]
                        [Validation(Required=false)]
                        public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShot> TextFpShot { get; set; }
                        public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShot : TeaModel {
                            public string PrimaryKey { get; set; }
                            public string Similarity { get; set; }
                            public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlices TextFpShotSlices { get; set; }
                            public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlices : TeaModel {
                                [NameInMap("TextFpShotSlice")]
                                [Validation(Required=false)]
                                public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlicesTextFpShotSlice> TextFpShotSlice { get; set; }
                                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlicesTextFpShotSlice : TeaModel {
                                    [NameInMap("DuplicationText")]
                                    [Validation(Required=false)]
                                    public string DuplicationText { get; set; }

                                    [NameInMap("InputFragment")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlicesTextFpShotSliceInputFragment InputFragment { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlicesTextFpShotSliceInputFragment : TeaModel {
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }
                                    };

                                    [NameInMap("InputText")]
                                    [Validation(Required=false)]
                                    public string InputText { get; set; }

                                    [NameInMap("Similarity")]
                                    [Validation(Required=false)]
                                    public string Similarity { get; set; }

                                }

                            }
                        }
                    };

                }
                public string Id { get; set; }
                public string Input { get; set; }
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobInputFile InputFile { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobInputFile : TeaModel {
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public string State { get; set; }
                public string UserData { get; set; }
            }
        };

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryFpShotJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryFpShotJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
