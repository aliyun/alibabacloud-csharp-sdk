// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryFpShotJobListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about media fingerprint analysis jobs.</para>
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
                /// <para>The error code returned if the job fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidParameter.UUIDFormatInvalid</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The time when the job was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-01-10T12:00:00Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The length of the input file.
                /// Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The ID of the uploaded file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ebb51ee30f0b49aba959823fa991****</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <para>The time when the job was complete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The configurations of the job.</para>
                /// </summary>
                [NameInMap("FpShotConfig")]
                [Validation(Required=false)]
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotConfig FpShotConfig { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotConfig : TeaModel {
                    /// <summary>
                    /// <para>The ID of the media fingerprint library.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2288c6ca184c0e47098a5b665e2a12****</para>
                    /// </summary>
                    [NameInMap("FpDBId")]
                    [Validation(Required=false)]
                    public string FpDBId { get; set; }

                    /// <summary>
                    /// <para>The unique primary key of the video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3ca84a39a9024f19853b21be9cf9****</para>
                    /// </summary>
                    [NameInMap("PrimaryKey")]
                    [Validation(Required=false)]
                    public string PrimaryKey { get; set; }

                    /// <summary>
                    /// <para>The storage type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>nosave</b>: The fingerprints of the job input are not saved to the media fingerprint library.</description></item>
                    /// <item><description><b>save</b>: The fingerprints of the job input are saved to the media fingerprint library only if the job input is not duplicated with media content in the media fingerprint library.</description></item>
                    /// <item><description><b>forcesave</b>: The fingerprints of the job input are forcibly saved to the media fingerprint library.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>save</para>
                    /// </summary>
                    [NameInMap("SaveType")]
                    [Validation(Required=false)]
                    public string SaveType { get; set; }

                }

                /// <summary>
                /// <para>The results of the media fingerprint analysis job.</para>
                /// </summary>
                [NameInMap("FpShotResult")]
                [Validation(Required=false)]
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResult FpShotResult { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResult : TeaModel {
                    /// <summary>
                    /// <para>The audio fingerprint analysis results.</para>
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
                            /// <para>The audio files that have similar fingerprints to the input audio in the audio fingerprint library.</para>
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
                                    /// <para>The start point in time and duration of the similar audio clip in the audio file that has similar fingerprints to the input audio in the audio fingerprint library.</para>
                                    /// </summary>
                                    [NameInMap("Duplication")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceDuplication Duplication { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceDuplication : TeaModel {
                                        /// <summary>
                                        /// <para>The duration of the similar audio clip in the audio file that has similar fingerprints to the input audio in the audio fingerprint library.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>3</para>
                                        /// </summary>
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }

                                        /// <summary>
                                        /// <para>The start point in time of the similar audio clip in the audio file that has similar fingerprints to the input audio in the audio fingerprint library.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>0</para>
                                        /// </summary>
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>The start point in time and duration of the similar audio clip in the input audio.</para>
                                    /// </summary>
                                    [NameInMap("Input")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceInput Input { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultAudioFpShotsFpShotFpShotSlicesFpShotSliceInput : TeaModel {
                                        /// <summary>
                                        /// <para>The duration of the similar audio clip in the input audio.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>5</para>
                                        /// </summary>
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }

                                        /// <summary>
                                        /// <para>The start point in time of the similar audio clip in the input audio.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>0</para>
                                        /// </summary>
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>The similarity of the input audio against the audio file that has similar fingerprints to the input audio in the audio fingerprint library.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0</para>
                                    /// </summary>
                                    [NameInMap("Similarity")]
                                    [Validation(Required=false)]
                                    public string Similarity { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The unique primary key of the input audio.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>498ac941373341599c4777c8d884****</para>
                            /// </summary>
                            [NameInMap("PrimaryKey")]
                            [Validation(Required=false)]
                            public string PrimaryKey { get; set; }

                            /// <summary>
                            /// <para>The overall similarity of the input audio against audio files that have similar fingerprints to the input audio in the audio fingerprint library.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("Similarity")]
                            [Validation(Required=false)]
                            public string Similarity { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The video fingerprint analysis results.</para>
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
                            /// <para>The video files that have similar fingerprints to the input video in the video fingerprint library.</para>
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
                                    /// <para>The start point in time and duration of the similar video clip in the video file that has similar fingerprints to the input video in the video fingerprint library.</para>
                                    /// </summary>
                                    [NameInMap("Duplication")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceDuplication Duplication { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceDuplication : TeaModel {
                                        /// <summary>
                                        /// <para>The duration of the similar video clip in the video file that has similar fingerprints to the input video in the video fingerprint library.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>48</para>
                                        /// </summary>
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }

                                        /// <summary>
                                        /// <para>The start point in time of the similar video clip in the video file that has similar fingerprints to the input video in the video fingerprint library.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>1260</para>
                                        /// </summary>
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>The start time and duration of the similar video clip in the input video.</para>
                                    /// </summary>
                                    [NameInMap("Input")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceInput Input { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultFpShotsFpShotFpShotSlicesFpShotSliceInput : TeaModel {
                                        /// <summary>
                                        /// <para>The duration of the similar video clip in the input video.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>48</para>
                                        /// </summary>
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }

                                        /// <summary>
                                        /// <para>The start point in time of the similar video clip in the input video.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>46</para>
                                        /// </summary>
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>The similarity of the input video clip against the video file that has similar fingerprints to the input video in the video fingerprint library.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0</para>
                                    /// </summary>
                                    [NameInMap("Similarity")]
                                    [Validation(Required=false)]
                                    public string Similarity { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The unique primary key of the input video.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>498ac941373341599c4777c8d884****</para>
                            /// </summary>
                            [NameInMap("PrimaryKey")]
                            [Validation(Required=false)]
                            public string PrimaryKey { get; set; }

                            /// <summary>
                            /// <para>The overall similarity of the input video against video files that have similar fingerprints to the input video in the video fingerprint library.</para>
                            /// <remarks>
                            /// <para> The overall similarity is the average value of the similarities of the input video clips with the clips of the video that has a similar fingerprint. If multiple video files that have similar fingerprints to the input video exist in the video fingerprint library, the similarities of the input video against multiple similar video clips are returned.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0.8914769887924194</para>
                            /// </summary>
                            [NameInMap("Similarity")]
                            [Validation(Required=false)]
                            public string Similarity { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The text fingerprint analysis results.</para>
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
                            /// <para>The unique primary key of the input text.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>3e34ac649945b53a1b0f863ce030****</para>
                            /// </summary>
                            [NameInMap("PrimaryKey")]
                            [Validation(Required=false)]
                            public string PrimaryKey { get; set; }

                            /// <summary>
                            /// <para>The similarity of the input text against text snippets that have similar fingerprints to the input text in the text fingerprint library.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1.0</para>
                            /// </summary>
                            [NameInMap("Similarity")]
                            [Validation(Required=false)]
                            public string Similarity { get; set; }

                            /// <summary>
                            /// <para>The text snippets that have similar fingerprints to the input text in the text fingerprint library.</para>
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
                                    /// <para>The text snippet that has similar fingerprints to the input text in the text fingerprint library.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>It\&quot;s snowy today.</para>
                                    /// </summary>
                                    [NameInMap("DuplicationText")]
                                    [Validation(Required=false)]
                                    public string DuplicationText { get; set; }

                                    /// <summary>
                                    /// <para>The start point in time and duration of the similar text snippet in the input text.</para>
                                    /// </summary>
                                    [NameInMap("InputFragment")]
                                    [Validation(Required=false)]
                                    public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlicesTextFpShotSliceInputFragment InputFragment { get; set; }
                                    public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobFpShotResultTextFpShotsTextFpShotTextFpShotSlicesTextFpShotSliceInputFragment : TeaModel {
                                        /// <summary>
                                        /// <para>The duration of the similar text snippet in the input text.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>3</para>
                                        /// </summary>
                                        [NameInMap("Duration")]
                                        [Validation(Required=false)]
                                        public string Duration { get; set; }

                                        /// <summary>
                                        /// <para>The start time of the similar text snippet in the input text.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>0</para>
                                        /// </summary>
                                        [NameInMap("Start")]
                                        [Validation(Required=false)]
                                        public string Start { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>The input text for text fingerprint analysis.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>It\&quot;s snowy today.</para>
                                    /// </summary>
                                    [NameInMap("InputText")]
                                    [Validation(Required=false)]
                                    public string InputText { get; set; }

                                    /// <summary>
                                    /// <para>The similarity of the input text against the text snippet that has similar fingerprints to the input text in the text fingerprint library.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1.0</para>
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
                /// <para>The ID of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88c6ca184c0e47098a5b665e2a12****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The information about the job input.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;Bucket&quot;:&quot;oss-test&quot;,&quot;Location&quot;:&quot;oss-cn-beijing&quot;,&quot;Object&quot;:&quot;test.mp4&quot;}</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public string Input { get; set; }

                /// <summary>
                /// <para>The information about the job input.</para>
                /// </summary>
                [NameInMap("InputFile")]
                [Validation(Required=false)]
                public QueryFpShotJobListResponseBodyFpShotJobListFpShotJobInputFile InputFile { get; set; }
                public class QueryFpShotJobListResponseBodyFpShotJobListFpShotJobInputFile : TeaModel {
                    /// <summary>
                    /// <para>The OSS bucket in which the job input resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-test</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>The OSS region in which the job input resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-cn-beijing</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>The Object Storage Service (OSS) object that is used as the job input.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test.mp4</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// <para>The error message returned if the job fails. This parameter is not returned if the job is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The parameter \&quot;Id\&quot; is invalid.A uuid must:1)be comprised of chracters[a-f],numbers[0-9];2)be 32 characters long</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The ID of the MPS queue to which the analysis job is submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>88c6ca184c0e47098a5b665e2a12****</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// <para>The status of the job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Queuing</b>: The job is waiting in the queue.</description></item>
                /// <item><description><b>Analysing</b>: The job is in progress.</description></item>
                /// <item><description><b>Success</b>: The job is successful.</description></item>
                /// <item><description><b>Fail</b>: The job fails.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The custom data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testid-001</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

        }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of the query results. The value is a 32-bit UUID. If the returned query results cannot be displayed within one page, this parameter is returned. The value of this parameter is updated for each query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b11c171cced04565b1f38f1ecc39****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The IDs of the jobs that do not exist.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
