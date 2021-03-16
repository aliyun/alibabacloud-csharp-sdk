// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpCompareJobListResponseBody : TeaModel {
        [NameInMap("FpCompareJobList")]
        [Validation(Required=false)]
        public QueryFpCompareJobListResponseBodyFpCompareJobList FpCompareJobList { get; set; }
        public class QueryFpCompareJobListResponseBodyFpCompareJobList : TeaModel {
            [NameInMap("FpCompareJob")]
            [Validation(Required=false)]
            public List<QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJob> FpCompareJob { get; set; }
            public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJob : TeaModel {
                public QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobMasterFile MasterFile { get; set; }
                public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobMasterFile : TeaModel {
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
                public string CreationTime { get; set; }
                public string FinishTime { get; set; }
                public string State { get; set; }
                public string Message { get; set; }
                public QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobQueryFile QueryFile { get; set; }
                public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobQueryFile : TeaModel {
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
                public string FpDBId { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobMatchFrameStorage MatchFrameStorage { get; set; }
                public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobMatchFrameStorage : TeaModel {
                    [NameInMap("MasterMediaFrames")]
                    [Validation(Required=false)]
                    public QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobMatchFrameStorageMasterMediaFrames MasterMediaFrames { get; set; }
                    public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobMatchFrameStorageMasterMediaFrames : TeaModel {
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }
                    };

                    [NameInMap("MatchedFramesDescFile")]
                    [Validation(Required=false)]
                    public QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobMatchFrameStorageMatchedFramesDescFile MatchedFramesDescFile { get; set; }
                    public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobMatchFrameStorageMatchedFramesDescFile : TeaModel {
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }
                    };

                    [NameInMap("QueryMediaFrames")]
                    [Validation(Required=false)]
                    public QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobMatchFrameStorageQueryMediaFrames QueryMediaFrames { get; set; }
                    public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobMatchFrameStorageQueryMediaFrames : TeaModel {
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }
                    };

                }
                public string PipelineId { get; set; }
                public string Id { get; set; }
                public QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobFpCompareResult FpCompareResult { get; set; }
                public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobFpCompareResult : TeaModel {
                    [NameInMap("MediaMatchSegments")]
                    [Validation(Required=false)]
                    public QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobFpCompareResultMediaMatchSegments MediaMatchSegments { get; set; }
                    public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobFpCompareResultMediaMatchSegments : TeaModel {
                        [NameInMap("MediaMatchSegment")]
                        [Validation(Required=false)]
                        public List<QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobFpCompareResultMediaMatchSegmentsMediaMatchSegment> MediaMatchSegment { get; set; }
                        public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobFpCompareResultMediaMatchSegmentsMediaMatchSegment : TeaModel {
                            public string QueryStartTime { get; set; }
                            public string QueryEndFrame { get; set; }
                            public string Score { get; set; }
                            public string TotalMatchFrameNum { get; set; }
                            public string MasterEndTime { get; set; }
                            public string MasterStartTime { get; set; }
                            public string QueryStartFrame { get; set; }
                            public string MasterEndFrame { get; set; }
                            public string MasterStartFrame { get; set; }
                            public string QueryEndTime { get; set; }
                        }
                    };

                    [NameInMap("QueryMediaInfo")]
                    [Validation(Required=false)]
                    public QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobFpCompareResultQueryMediaInfo QueryMediaInfo { get; set; }
                    public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobFpCompareResultQueryMediaInfo : TeaModel {
                        [NameInMap("AudioSampleRate")]
                        [Validation(Required=false)]
                        public string AudioSampleRate { get; set; }
                        [NameInMap("AudioBitRate")]
                        [Validation(Required=false)]
                        public string AudioBitRate { get; set; }
                        [NameInMap("FpNum")]
                        [Validation(Required=false)]
                        public string FpNum { get; set; }
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }
                        [NameInMap("TotalVideoFrame")]
                        [Validation(Required=false)]
                        public string TotalVideoFrame { get; set; }
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }
                        [NameInMap("AudioChannels")]
                        [Validation(Required=false)]
                        public string AudioChannels { get; set; }
                    };

                    [NameInMap("MasterMediaInfo")]
                    [Validation(Required=false)]
                    public QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobFpCompareResultMasterMediaInfo MasterMediaInfo { get; set; }
                    public class QueryFpCompareJobListResponseBodyFpCompareJobListFpCompareJobFpCompareResultMasterMediaInfo : TeaModel {
                        [NameInMap("AudioSampleRate")]
                        [Validation(Required=false)]
                        public string AudioSampleRate { get; set; }
                        [NameInMap("AudioBitRate")]
                        [Validation(Required=false)]
                        public string AudioBitRate { get; set; }
                        [NameInMap("FpNum")]
                        [Validation(Required=false)]
                        public string FpNum { get; set; }
                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }
                        [NameInMap("TotalVideoFrame")]
                        [Validation(Required=false)]
                        public string TotalVideoFrame { get; set; }
                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public string Duration { get; set; }
                        [NameInMap("AudioChannels")]
                        [Validation(Required=false)]
                        public string AudioChannels { get; set; }
                    };

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryFpCompareJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryFpCompareJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
