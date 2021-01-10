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
                [NameInMap("AudioFpShots")]
                [Validation(Required=false)]
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobAudioFpShots AudioFpShots { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobAudioFpShots : TeaModel {
                    [NameInMap("FpShot")]
                    [Validation(Required=false)]
                    public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobAudioFpShotsFpShot> FpShot { get; set; }
                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobAudioFpShotsFpShot : TeaModel {
                        public string PrimaryKey { get; set; }
                        public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobAudioFpShotsFpShotFpShotSlices FpShotSlices { get; set; }
                        public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobAudioFpShotsFpShotFpShotSlices : TeaModel {
                            [NameInMap("FpShotSlice")]
                            [Validation(Required=false)]
                            public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobAudioFpShotsFpShotFpShotSlicesFpShotSlice> FpShotSlice { get; set; }
                            public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobAudioFpShotsFpShotFpShotSlicesFpShotSlice : TeaModel {
                                [NameInMap("Duplication")]
                                [Validation(Required=false)]
                                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobAudioFpShotsFpShotFpShotSlicesFpShotSliceDuplication Duplication { get; set; }
                                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobAudioFpShotsFpShotFpShotSlicesFpShotSliceDuplication : TeaModel {
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
                                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobAudioFpShotsFpShotFpShotSlicesFpShotSliceInput Input { get; set; }
                                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobAudioFpShotsFpShotFpShotSlicesFpShotSliceInput : TeaModel {
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
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShots FpShots { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShots : TeaModel {
                    [NameInMap("FpShot")]
                    [Validation(Required=false)]
                    public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotsFpShot> FpShot { get; set; }
                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotsFpShot : TeaModel {
                        public string PrimaryKey { get; set; }
                        public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotsFpShotFpShotSlices FpShotSlices { get; set; }
                        public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotsFpShotFpShotSlices : TeaModel {
                            [NameInMap("FpShotSlice")]
                            [Validation(Required=false)]
                            public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotsFpShotFpShotSlicesFpShotSlice> FpShotSlice { get; set; }
                            public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotsFpShotFpShotSlicesFpShotSlice : TeaModel {
                                [NameInMap("Duplication")]
                                [Validation(Required=false)]
                                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotsFpShotFpShotSlicesFpShotSliceDuplication Duplication { get; set; }
                                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotsFpShotFpShotSlicesFpShotSliceDuplication : TeaModel {
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
                                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotsFpShotFpShotSlicesFpShotSliceInput Input { get; set; }
                                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotsFpShotFpShotSlicesFpShotSliceInput : TeaModel {
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
