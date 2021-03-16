// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpShotJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("NonExistPrimaryKeys")]
        [Validation(Required=false)]
        public QueryFpShotJobListResponseBodyNonExistPrimaryKeys NonExistPrimaryKeys { get; set; }
        public class QueryFpShotJobListResponseBodyNonExistPrimaryKeys : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("FpShotJobList")]
        [Validation(Required=false)]
        public QueryFpShotJobListResponseBodyFpShotJobList FpShotJobList { get; set; }
        public class QueryFpShotJobListResponseBodyFpShotJobList : TeaModel {
            [NameInMap("FpShotJob")]
            [Validation(Required=false)]
            public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJob> FpShotJob { get; set; }
            public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJob : TeaModel {
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
                            public string PrimaryKey { get; set; }
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
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }
                                    };

                                    [NameInMap("Similarity")]
                                    [Validation(Required=false)]
                                    public string Similarity { get; set; }

                                    [NameInMap("Input")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceInput Input { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceInput : TeaModel {
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }
                                    };

                                }

                            }
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
                            public string PrimaryKey { get; set; }
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
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }
                                    };

                                    [NameInMap("Similarity")]
                                    [Validation(Required=false)]
                                    public string Similarity { get; set; }

                                    [NameInMap("Input")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceInput Input { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceInput : TeaModel {
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }
                                    };

                                }

                            }
                            public string Similarity { get; set; }
                        }
                    };

                }
                public string CreationTime { get; set; }
                public string FinishTime { get; set; }
                public string State { get; set; }
                public string Message { get; set; }
                public string TxHash { get; set; }
                public string TransactionId { get; set; }
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotConfig FpShotConfig { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotConfig : TeaModel {
                    [NameInMap("PrimaryKey")]
                    [Validation(Required=false)]
                    public string PrimaryKey { get; set; }

                    [NameInMap("SaveType")]
                    [Validation(Required=false)]
                    public string SaveType { get; set; }

                    [NameInMap("Notary")]
                    [Validation(Required=false)]
                    public string Notary { get; set; }

                    [NameInMap("FpDBId")]
                    [Validation(Required=false)]
                    public string FpDBId { get; set; }

                }
                public string FileId { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobInputFile InputFile { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobInputFile : TeaModel {
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
                public string PipelineId { get; set; }
                public string Id { get; set; }
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

    }

}
