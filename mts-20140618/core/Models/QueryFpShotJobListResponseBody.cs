// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpShotJobListResponseBody : TeaModel {
        /// <summary>
        /// The information about media fingerprint analysis jobs.
        /// </summary>
        [NameInMap("FpShotJobList")]
        [Validation(Required=false)]
        public QueryFpShotJobListResponseBodyFpShotJobList FpShotJobList { get; set; }
        public class QueryFpShotJobListResponseBodyFpShotJobList : TeaModel {
            [NameInMap("FpShotJob")]
            [Validation(Required=false)]
            public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJob> FpShotJob { get; set; }
            public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJob : TeaModel {
                /// <summary>
                /// The error code returned if the job fails.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The time when the job was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The length of the input file.
                /// Unit: seconds.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// The ID of the uploaded file.
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// The time when the job was complete.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The configurations of the job.
                /// </summary>
                [NameInMap("FpShotConfig")]
                [Validation(Required=false)]
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotConfig FpShotConfig { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotConfig : TeaModel {
                    /// <summary>
                    /// The ID of the media fingerprint library.
                    /// </summary>
                    [NameInMap("FpDBId")]
                    [Validation(Required=false)]
                    public string FpDBId { get; set; }

                    /// <summary>
                    /// The unique primary key of the video.
                    /// </summary>
                    [NameInMap("PrimaryKey")]
                    [Validation(Required=false)]
                    public string PrimaryKey { get; set; }

                    /// <summary>
                    /// The storage type. Valid values:
                    /// 
                    /// *   **nosave**: The fingerprints of the job input are not saved to the media fingerprint library.
                    /// *   **save**: The fingerprints of the job input are saved to the media fingerprint library only if the job input is not duplicated with media content in the media fingerprint library.
                    /// *   **forcesave**: The fingerprints of the job input are forcibly saved to the media fingerprint library.
                    /// </summary>
                    [NameInMap("SaveType")]
                    [Validation(Required=false)]
                    public string SaveType { get; set; }

                }

                /// <summary>
                /// The results of the media fingerprint analysis job.
                /// </summary>
                [NameInMap("FpShotResult")]
                [Validation(Required=false)]
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResult FpShotResult { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResult : TeaModel {
                    /// <summary>
                    /// The audio fingerprint analysis results.
                    /// </summary>
                    [NameInMap("AudioFpShots")]
                    [Validation(Required=false)]
                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShots AudioFpShots { get; set; }
                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShots : TeaModel {
                        [NameInMap("FpShot")]
                        [Validation(Required=false)]
                        public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShot> FpShot { get; set; }
                        public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShot : TeaModel {
                            /// <summary>
                            /// The audio files that have similar fingerprints to the input audio in the audio fingerprint library.
                            /// </summary>
                            [NameInMap("FpShotSlices")]
                            [Validation(Required=false)]
                            public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlices FpShotSlices { get; set; }
                            public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlices : TeaModel {
                                [NameInMap("FpShotSlice")]
                                [Validation(Required=false)]
                                public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSlice> FpShotSlice { get; set; }
                                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSlice : TeaModel {
                                    /// <summary>
                                    /// The start point in time and duration of the similar audio clip in the audio file that has similar fingerprints to the input audio in the audio fingerprint library.
                                    /// </summary>
                                    [NameInMap("Duplication")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceDuplication Duplication { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceDuplication : TeaModel {
                                        /// <summary>
                                        /// The duration of the similar audio clip in the audio file that has similar fingerprints to the input audio in the audio fingerprint library.
                                        /// </summary>
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }

                                        /// <summary>
                                        /// The start point in time of the similar audio clip in the audio file that has similar fingerprints to the input audio in the audio fingerprint library.
                                        /// </summary>
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }

                                    }

                                    /// <summary>
                                    /// The start point in time and duration of the similar audio clip in the input audio.
                                    /// </summary>
                                    [NameInMap("Input")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceInput Input { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceInput : TeaModel {
                                        /// <summary>
                                        /// The duration of the similar audio clip in the input audio.
                                        /// </summary>
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }

                                        /// <summary>
                                        /// The start point in time of the similar audio clip in the input audio.
                                        /// </summary>
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }

                                    }

                                    /// <summary>
                                    /// The similarity of the input audio against the audio file that has similar fingerprints to the input audio in the audio fingerprint library.
                                    /// </summary>
                                    [NameInMap("Similarity")]
                                    [Validation(Required=false)]
                                    public string Similarity { get; set; }

                                }

                            }

                            /// <summary>
                            /// The unique primary key of the input audio.
                            /// </summary>
                            [NameInMap("PrimaryKey")]
                            [Validation(Required=false)]
                            public string PrimaryKey { get; set; }

                            /// <summary>
                            /// The overall similarity of the input audio against audio files that have similar fingerprints to the input audio in the audio fingerprint library.
                            /// </summary>
                            [NameInMap("Similarity")]
                            [Validation(Required=false)]
                            public string Similarity { get; set; }

                        }

                    }

                    /// <summary>
                    /// The video fingerprint analysis results.
                    /// </summary>
                    [NameInMap("FpShots")]
                    [Validation(Required=false)]
                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShots FpShots { get; set; }
                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShots : TeaModel {
                        [NameInMap("FpShot")]
                        [Validation(Required=false)]
                        public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShot> FpShot { get; set; }
                        public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShot : TeaModel {
                            /// <summary>
                            /// The video files that have similar fingerprints to the input video in the video fingerprint library.
                            /// </summary>
                            [NameInMap("FpShotSlices")]
                            [Validation(Required=false)]
                            public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlices FpShotSlices { get; set; }
                            public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlices : TeaModel {
                                [NameInMap("FpShotSlice")]
                                [Validation(Required=false)]
                                public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSlice> FpShotSlice { get; set; }
                                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSlice : TeaModel {
                                    /// <summary>
                                    /// The start point in time and duration of the similar video clip in the video file that has similar fingerprints to the input video in the video fingerprint library.
                                    /// </summary>
                                    [NameInMap("Duplication")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceDuplication Duplication { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceDuplication : TeaModel {
                                        /// <summary>
                                        /// The duration of the similar video clip in the video file that has similar fingerprints to the input video in the video fingerprint library.
                                        /// </summary>
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }

                                        /// <summary>
                                        /// The start point in time of the similar video clip in the video file that has similar fingerprints to the input video in the video fingerprint library.
                                        /// </summary>
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }

                                    }

                                    /// <summary>
                                    /// The start time and duration of the similar video clip in the input video.
                                    /// </summary>
                                    [NameInMap("Input")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceInput Input { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceInput : TeaModel {
                                        /// <summary>
                                        /// The duration of the similar video clip in the input video.
                                        /// </summary>
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }

                                        /// <summary>
                                        /// The start point in time of the similar video clip in the input video.
                                        /// </summary>
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }

                                    }

                                    /// <summary>
                                    /// The similarity of the input video clip against the video file that has similar fingerprints to the input video in the video fingerprint library.
                                    /// </summary>
                                    [NameInMap("Similarity")]
                                    [Validation(Required=false)]
                                    public string Similarity { get; set; }

                                }

                            }

                            /// <summary>
                            /// The unique primary key of the input video.
                            /// </summary>
                            [NameInMap("PrimaryKey")]
                            [Validation(Required=false)]
                            public string PrimaryKey { get; set; }

                            /// <summary>
                            /// The overall similarity of the input video against video files that have similar fingerprints to the input video in the video fingerprint library.
                            /// 
                            /// >  The overall similarity is the average value of the similarities of the input video clips with the clips of the video that has a similar fingerprint. If multiple video files that have similar fingerprints to the input video exist in the video fingerprint library, the similarities of the input video against multiple similar video clips are returned.
                            /// </summary>
                            [NameInMap("Similarity")]
                            [Validation(Required=false)]
                            public string Similarity { get; set; }

                        }

                    }

                    /// <summary>
                    /// The text fingerprint analysis results.
                    /// </summary>
                    [NameInMap("TextFpShots")]
                    [Validation(Required=false)]
                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShots TextFpShots { get; set; }
                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShots : TeaModel {
                        [NameInMap("TextFpShot")]
                        [Validation(Required=false)]
                        public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShot> TextFpShot { get; set; }
                        public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShot : TeaModel {
                            /// <summary>
                            /// The unique primary key of the input text.
                            /// </summary>
                            [NameInMap("PrimaryKey")]
                            [Validation(Required=false)]
                            public string PrimaryKey { get; set; }

                            /// <summary>
                            /// The similarity of the input text against text snippets that have similar fingerprints to the input text in the text fingerprint library.
                            /// </summary>
                            [NameInMap("Similarity")]
                            [Validation(Required=false)]
                            public string Similarity { get; set; }

                            /// <summary>
                            /// The text snippets that have similar fingerprints to the input text in the text fingerprint library.
                            /// </summary>
                            [NameInMap("TextFpShotSlices")]
                            [Validation(Required=false)]
                            public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlices TextFpShotSlices { get; set; }
                            public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlices : TeaModel {
                                [NameInMap("TextFpShotSlice")]
                                [Validation(Required=false)]
                                public List<QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlicesTextFpShotSlice> TextFpShotSlice { get; set; }
                                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlicesTextFpShotSlice : TeaModel {
                                    /// <summary>
                                    /// The text snippet that has similar fingerprints to the input text in the text fingerprint library.
                                    /// </summary>
                                    [NameInMap("DuplicationText")]
                                    [Validation(Required=false)]
                                    public string DuplicationText { get; set; }

                                    /// <summary>
                                    /// The start point in time and duration of the similar text snippet in the input text.
                                    /// </summary>
                                    [NameInMap("InputFragment")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlicesTextFpShotSliceInputFragment InputFragment { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlicesTextFpShotSliceInputFragment : TeaModel {
                                        /// <summary>
                                        /// The duration of the similar text snippet in the input text.
                                        /// </summary>
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }

                                        /// <summary>
                                        /// The start time of the similar text snippet in the input text.
                                        /// </summary>
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }

                                    }

                                    /// <summary>
                                    /// The input text for text fingerprint analysis.
                                    /// </summary>
                                    [NameInMap("InputText")]
                                    [Validation(Required=false)]
                                    public string InputText { get; set; }

                                    /// <summary>
                                    /// The similarity of the input text against the text snippet that has similar fingerprints to the input text in the text fingerprint library.
                                    /// </summary>
                                    [NameInMap("Similarity")]
                                    [Validation(Required=false)]
                                    public string Similarity { get; set; }

                                }

                            }

                        }

                    }

                }

                /// <summary>
                /// The ID of the job.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The information about the job input.
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public string Input { get; set; }

                /// <summary>
                /// The information about the job input.
                /// </summary>
                [NameInMap("InputFile")]
                [Validation(Required=false)]
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobInputFile InputFile { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobInputFile : TeaModel {
                    /// <summary>
                    /// The OSS bucket in which the job input resides.
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// The OSS region in which the job input resides.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// The Object Storage Service (OSS) object that is used as the job input.
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// The error message returned if the job fails. This parameter is not returned if the job is successful.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The ID of the MPS queue to which the analysis job is submitted.
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// The status of the job. Valid values:
                /// 
                /// *   **Queuing**: The job is waiting in the queue.
                /// *   **Analysing**: The job is in progress.
                /// *   **Success**: The job is successful.
                /// *   **Fail**: The job fails.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The custom data.
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

        }

        /// <summary>
        /// The token that is used to retrieve the next page of the query results. The value is a 32-bit UUID. If the returned query results cannot be displayed within one page, this parameter is returned. The value of this parameter is updated for each query.
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// The IDs of the jobs that do not exist.
        /// </summary>
        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryFpShotJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryFpShotJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
