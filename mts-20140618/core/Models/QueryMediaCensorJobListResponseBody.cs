// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaCensorJobListResponseBody : TeaModel {
        /// <summary>
        /// The content moderation jobs.
        /// </summary>
        [NameInMap("MediaCensorJobList")]
        [Validation(Required=false)]
        public QueryMediaCensorJobListResponseBodyMediaCensorJobList MediaCensorJobList { get; set; }
        public class QueryMediaCensorJobListResponseBodyMediaCensorJobList : TeaModel {
            [NameInMap("MediaCensorJob")]
            [Validation(Required=false)]
            public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJob> MediaCensorJob { get; set; }
            public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJob : TeaModel {
                [NameInMap("AudioCensorResult")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobAudioCensorResult AudioCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobAudioCensorResult : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// The moderation result of live comments.
                /// </summary>
                [NameInMap("BarrageCensorResult")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobBarrageCensorResult BarrageCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobBarrageCensorResult : TeaModel {
                    /// <summary>
                    /// The labels of the moderation result. Separate multiple labels with commas (,). Valid values:
                    /// 
                    /// *   **spam**: spam
                    /// *   **ad**: ads
                    /// *   **abuse**: abuse
                    /// *   **flood**: excessive junk content
                    /// *   **contraband**: prohibited content
                    /// *   **meaningless**: meaningless content
                    /// *   **normal**: normal content
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The score.
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public string Rate { get; set; }

                    /// <summary>
                    /// The moderation scenario. The value is **antispam**.
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// The recommended subsequent operation. Valid values:
                    /// 
                    /// *   **pass**: The content passes the moderation.
                    /// *   **review**: The content needs to be manually reviewed again.
                    /// *   **block**: The content needs to be blocked.
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// The error code returned if the job fails. This parameter is not returned if the job is successful.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The moderation results of thumbnails.
                /// </summary>
                [NameInMap("CoverImageCensorResults")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResults CoverImageCensorResults { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResults : TeaModel {
                    [NameInMap("CoverImageCensorResult")]
                    [Validation(Required=false)]
                    public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResultsCoverImageCensorResult> CoverImageCensorResult { get; set; }
                    public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResultsCoverImageCensorResult : TeaModel {
                        /// <summary>
                        /// The OSS bucket that stores the video thumbnail.
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// The OSS region in which the video thumbnail resides.
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// The Object Storage Service (OSS) object that is used as the video thumbnail.
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                        /// <summary>
                        /// The moderation results of the content moderation jobs.
                        /// </summary>
                        [NameInMap("Results")]
                        [Validation(Required=false)]
                        public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResultsCoverImageCensorResultResults Results { get; set; }
                        public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResultsCoverImageCensorResultResults : TeaModel {
                            [NameInMap("Result")]
                            [Validation(Required=false)]
                            public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResultsCoverImageCensorResultResultsResult> Result { get; set; }
                            public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobCoverImageCensorResultsCoverImageCensorResultResultsResult : TeaModel {
                                /// <summary>
                                /// The labels of the moderation result. Separate multiple labels with commas (,).
                                /// 
                                /// *   Valid values in the pornographic content moderation scenario:
                                /// 
                                ///     *   **normal**: normal content
                                ///     *   **sexy**: sexy content
                                ///     *   **porn**: pornographic content
                                /// 
                                /// *   Valid values in the terrorist content moderation scenario:
                                /// 
                                ///     *   **normal**: normal content
                                ///     *   **bloody**: bloody content
                                ///     *   **explosion**: explosion and smoke
                                ///     *   **outfit**: special costume
                                ///     *   **logo**: special logo
                                ///     *   **weapon**: weapon
                                ///     *   **politics**: political content
                                ///     *   **violence**: violence
                                ///     *   **crowd**: crowd
                                ///     *   **parade**: parade
                                ///     *   **carcrash**: car accident
                                ///     *   **flag**: flag
                                ///     *   **location**: landmark
                                ///     *   **others**: other content
                                /// 
                                /// *   Valid values in the ad moderation scenario:
                                /// 
                                ///     *   **normal**: normal content
                                ///     *   **ad**: other ads
                                ///     *   **politics**: political content in text
                                ///     *   **porn**: pornographic content in text
                                ///     *   **abuse**: abuse in text
                                ///     *   **terrorism**: terrorist content in text
                                ///     *   **contraband**: prohibited content in text
                                ///     *   **spam**: spam in text
                                ///     *   **npx**: illegal ads
                                ///     *   **qrcode**: QR code
                                ///     *   **programCode**: mini program code
                                /// 
                                /// *   Valid values in the live moderation scenario:
                                /// 
                                ///     *   **normal**: normal content
                                ///     *   **meaningless**: meaningless content, such as a black or white screen
                                ///     *   **PIP**: picture-in-picture
                                ///     *   **smoking**: smoking
                                ///     *   **drivelive**: live broadcasting in a running vehicle
                                /// 
                                /// *   Valid values in the logo moderation scenario:
                                /// 
                                ///     *   **normal**: normal content
                                ///     *   **TV**: controlled TV station logo
                                ///     *   **trademark**: trademark
                                /// </summary>
                                [NameInMap("Label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// The score. Valid values: 0 to 100.
                                /// </summary>
                                [NameInMap("Rate")]
                                [Validation(Required=false)]
                                public string Rate { get; set; }

                                /// <summary>
                                /// The moderation scenario. Valid values:
                                /// 
                                /// *   **porn**: pornographic content moderation
                                /// *   **terrorism**: terrorist content moderation
                                /// *   **ad**: ad violation moderation
                                /// *   **live**: undesirable scene moderation
                                /// *   **logo**: special logo moderation
                                /// </summary>
                                [NameInMap("Scene")]
                                [Validation(Required=false)]
                                public string Scene { get; set; }

                                /// <summary>
                                /// The overall result of the job. Valid values:
                                /// 
                                /// *   **pass**: The content passes the moderation.
                                /// *   **review**: The content needs to be manually reviewed again.
                                /// *   **block**: The content needs to be blocked.
                                /// 
                                /// > If the moderation result of any type of the moderated content is review, the overall result is review. If the moderation result of any type of the moderated content is block, the overall result is block.
                                /// </summary>
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// The time when the job was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The moderation result of the description.
                /// </summary>
                [NameInMap("DescCensorResult")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobDescCensorResult DescCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobDescCensorResult : TeaModel {
                    /// <summary>
                    /// The labels of the moderation result. Separate multiple labels with commas (,). Valid values:
                    /// 
                    /// *   **spam**: spam
                    /// *   **ad**: ads
                    /// *   **abuse**: abuse
                    /// *   **flood**: excessive junk content
                    /// *   **contraband**: prohibited content
                    /// *   **meaningless**: meaningless content
                    /// *   **normal**: normal content
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The score.
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public string Rate { get; set; }

                    /// <summary>
                    /// The moderation scenario. The value is **antispam**.
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// The recommended subsequent operation. Valid values:
                    /// 
                    /// *   **pass**: The content passes the moderation.
                    /// *   **review**: The content needs to be manually reviewed again.
                    /// *   **block**: The content needs to be blocked.
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// The time when the job was completed.
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// The information about the job input.
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobInput Input { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobInput : TeaModel {
                    /// <summary>
                    /// The name of the OSS bucket in which the input file is stored.
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// The OSS region in which the input file resides.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// The name of the OSS object that is used as the input file.
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// The ID of the content moderation job.
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// The error message returned if the job fails. This parameter is not returned if the job is successful.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The ID of the MPS queue that is used to run the job.
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// The status of the job.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The recommended subsequent operation. Valid values:
                /// 
                /// *   **pass**: The content passes the moderation.
                /// *   **review**: The content needs to be manually reviewed again.
                /// *   **block**: The content needs to be blocked.
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// The moderation result of the title.
                /// </summary>
                [NameInMap("TitleCensorResult")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobTitleCensorResult TitleCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobTitleCensorResult : TeaModel {
                    /// <summary>
                    /// The labels of the moderation result. Separate multiple labels with commas (,).
                    /// 
                    /// *   **normal**: normal content
                    /// *   **spam**: spam
                    /// *   **ad**: ads
                    /// *   **abuse**: abuse content
                    /// *   **flood**: excessive junk content
                    /// *   **contraband**: prohibited content
                    /// *   **meaningless**: meaningless content
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// The score.
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public string Rate { get; set; }

                    /// <summary>
                    /// The moderation scenario. The value is **antispam**.
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// The recommended subsequent operation. Valid values:
                    /// 
                    /// *   **pass**: The content passes the moderation.
                    /// *   **review**: The content needs to be manually reviewed again.
                    /// *   **block**: The content needs to be blocked.
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// The custom data.
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

                /// <summary>
                /// The moderation results of the video.
                /// </summary>
                [NameInMap("VensorCensorResult")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResult VensorCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResult : TeaModel {
                    /// <summary>
                    /// A collection of the moderation results. The information includes the summary about various scenarios such as pornographic content and terrorist content.
                    /// </summary>
                    [NameInMap("CensorResults")]
                    [Validation(Required=false)]
                    public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultCensorResults CensorResults { get; set; }
                    public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultCensorResults : TeaModel {
                        [NameInMap("CensorResult")]
                        [Validation(Required=false)]
                        public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultCensorResultsCensorResult> CensorResult { get; set; }
                        public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultCensorResultsCensorResult : TeaModel {
                            /// <summary>
                            /// The labels of the moderation result. Separate multiple labels with commas (,).
                            /// 
                            /// *   Valid values in the pornographic content moderation scenario:
                            /// 
                            ///     *   **porn**: pornographic content
                            ///     *   **sexy**: sexy content
                            ///     *   **normal**: normal content
                            /// 
                            /// *   Valid values in the terrorist content moderation scenario:
                            /// 
                            ///     *   **normal**: normal content
                            ///     *   **bloody**: bloody content
                            ///     *   **explosion**: explosion and smoke
                            ///     *   **outfit**: special costume
                            ///     *   **logo**: special logo
                            ///     *   **weapon**: weapon
                            ///     *   **politics**: political content
                            ///     *   **violence**: violence
                            ///     *   **crowd**: crowd
                            ///     *   **parade**: parade
                            ///     *   **carcrash**: car accident
                            ///     *   **flag**: flag
                            ///     *   **location**: landmark
                            ///     *   **others**: other content
                            /// 
                            /// *   Valid values in the ad moderation scenario:
                            /// 
                            ///     *   **normal**: normal content
                            ///     *   **ad**: other ads
                            ///     *   **politics**: political content in text
                            ///     *   **porn**: pornographic content in text
                            ///     *   **abuse**: abuse in text
                            ///     *   **terrorism**: terrorist content in text
                            ///     *   **contraband**: prohibited content in text
                            ///     *   **spam**: spam in text
                            ///     *   **npx**: illegal ads
                            ///     *   **qrcode**: QR code
                            ///     *   **programCode**: mini program code
                            /// 
                            /// *   Valid values in the live moderation scenario:
                            /// 
                            ///     *   **normal**: normal content
                            ///     *   **meaningless**: meaningless content, such as a black or white screen
                            ///     *   **PIP**: picture-in-picture
                            ///     *   **smoking**: smoking
                            ///     *   **drivelive**: live broadcasting in a running vehicle
                            /// 
                            /// *   Valid values in the logo moderation scenario:
                            /// 
                            ///     *   **normal**: normal content
                            ///     *   **TV**: controlled TV station logo
                            ///     *   **trademark**: trademark
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// The score.
                            /// </summary>
                            [NameInMap("Rate")]
                            [Validation(Required=false)]
                            public string Rate { get; set; }

                            /// <summary>
                            /// The moderation scenario. Valid values:
                            /// 
                            /// *   **porn**: pornographic content moderation
                            /// *   **terrorism**: terrorist content moderation
                            /// *   **ad**: ad violation moderation
                            /// *   **live**: undesirable scene moderation
                            /// *   **logo**: special logo moderation
                            /// </summary>
                            [NameInMap("Scene")]
                            [Validation(Required=false)]
                            public string Scene { get; set; }

                            /// <summary>
                            /// The recommended subsequent operation. Valid values:
                            /// 
                            /// *   **pass**: The content passes the moderation.
                            /// *   **review**: The content needs to be manually reviewed again.
                            /// *   **block**: The content needs to be blocked.
                            /// </summary>
                            [NameInMap("Suggestion")]
                            [Validation(Required=false)]
                            public string Suggestion { get; set; }

                        }

                    }

                    /// <summary>
                    /// The pagination token that is used in the next request to retrieve a new page of results.
                    /// </summary>
                    [NameInMap("NextPageToken")]
                    [Validation(Required=false)]
                    public string NextPageToken { get; set; }

                    /// <summary>
                    /// The moderation results that are sorted in ascending order by time.
                    /// </summary>
                    [NameInMap("VideoTimelines")]
                    [Validation(Required=false)]
                    public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelines VideoTimelines { get; set; }
                    public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelines : TeaModel {
                        [NameInMap("VideoTimeline")]
                        [Validation(Required=false)]
                        public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimeline> VideoTimeline { get; set; }
                        public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimeline : TeaModel {
                            /// <summary>
                            /// The moderation results that include information such as labels and scores.
                            /// </summary>
                            [NameInMap("CensorResults")]
                            [Validation(Required=false)]
                            public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimelineCensorResults CensorResults { get; set; }
                            public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimelineCensorResults : TeaModel {
                                [NameInMap("CensorResult")]
                                [Validation(Required=false)]
                                public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimelineCensorResultsCensorResult> CensorResult { get; set; }
                                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResultVideoTimelinesVideoTimelineCensorResultsCensorResult : TeaModel {
                                    /// <summary>
                                    /// The labels of the moderation result. Separate multiple labels with commas (,). Valid values:
                                    /// 
                                    /// *   Valid values in the pornographic content moderation scenario:
                                    /// 
                                    ///     *   **porn**: pornographic content
                                    ///     *   **sexy**: sexy content
                                    ///     *   **normal**: normal content
                                    /// 
                                    /// *   Valid values in the terrorist content moderation scenario:
                                    /// 
                                    ///     *   **normal**: normal content
                                    ///     *   **bloody**: bloody content
                                    ///     *   **explosion**: explosion and smoke
                                    ///     *   **outfit**: special costume
                                    ///     *   **logo**: special logo
                                    ///     *   **weapon**: weapon
                                    ///     *   **politics**: political content
                                    ///     *   **violence**: violence
                                    ///     *   **crowd**: crowd
                                    ///     *   **parade**: parade
                                    ///     *   **carcrash**: car accident
                                    ///     *   **flag**: flag
                                    ///     *   **location**: landmark
                                    ///     *   **others**: other content
                                    /// 
                                    /// *   Valid values in the ad moderation scenario:
                                    /// 
                                    ///     *   **normal**: normal content
                                    ///     *   **ad**: other ads
                                    ///     *   **politics**: political content in text
                                    ///     *   **porn**: pornographic content in text
                                    ///     *   **abuse**: abuse in text
                                    ///     *   **terrorism**: terrorist content in text
                                    ///     *   **contraband**: prohibited content in text
                                    ///     *   **spam**: spam in text
                                    ///     *   **npx**: illegal ads
                                    ///     *   **qrcode**: QR code
                                    ///     *   **programCode**: mini program code
                                    /// 
                                    /// *   Valid values in the live moderation scenario:
                                    /// 
                                    ///     *   **normal**: normal content
                                    ///     *   **meaningless**: meaningless content, such as a black or white screen
                                    ///     *   **PIP**: picture-in-picture
                                    ///     *   **smoking**: smoking
                                    ///     *   **drivelive**: live broadcasting in a running vehicle
                                    /// 
                                    /// *   Valid values in the logo moderation scenario:
                                    /// 
                                    ///     *   **normal**: normal content
                                    ///     *   **TV**: controlled TV station logo
                                    ///     *   **trademark**: trademark
                                    /// </summary>
                                    [NameInMap("Label")]
                                    [Validation(Required=false)]
                                    public string Label { get; set; }

                                    /// <summary>
                                    /// The score.
                                    /// </summary>
                                    [NameInMap("Rate")]
                                    [Validation(Required=false)]
                                    public string Rate { get; set; }

                                    /// <summary>
                                    /// The moderation scenario. Valid values:
                                    /// 
                                    /// *   **porn**: pornographic content moderation
                                    /// *   **terrorism**: terrorist content moderation
                                    /// *   **ad**: ad violation moderation
                                    /// *   **live**: undesirable scene moderation
                                    /// *   **logo**: special logo moderation
                                    /// </summary>
                                    [NameInMap("Scene")]
                                    [Validation(Required=false)]
                                    public string Scene { get; set; }

                                    /// <summary>
                                    /// The recommended subsequent operation. Valid values:
                                    /// 
                                    /// *   **pass**: The content passes the moderation.
                                    /// *   **review**: The content needs to be manually reviewed again.
                                    /// *   **block**: The content needs to be blocked.
                                    /// </summary>
                                    [NameInMap("Suggestion")]
                                    [Validation(Required=false)]
                                    public string Suggestion { get; set; }

                                }

                            }

                            /// <summary>
                            /// The OSS object that is generated as the output snapshot.
                            /// 
                            /// > In the example, {Count} is a placeholder. The OSS objects that are generated as output snapshots are named `output00001-****.jpg, output00002-****.jpg`, and so on.
                            /// </summary>
                            [NameInMap("Object")]
                            [Validation(Required=false)]
                            public string Object { get; set; }

                            /// <summary>
                            /// The position in the video. Format: `hh:mm:ss[.SSS]`.
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                        }

                    }

                }

                /// <summary>
                /// The video moderation configurations.
                /// </summary>
                [NameInMap("VideoCensorConfig")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVideoCensorConfig VideoCensorConfig { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVideoCensorConfig : TeaModel {
                    /// <summary>
                    /// The moderation template. Default value: common. The default value indicates that the default template is used.
                    /// 
                    /// > If the moderation template is not specified, the default value common is returned. If a custom moderation template that is created by submitting a ticket is specified, a user ID is returned.
                    /// </summary>
                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    /// <summary>
                    /// The information about output snapshots.
                    /// </summary>
                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVideoCensorConfigOutputFile OutputFile { get; set; }
                    public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVideoCensorConfigOutputFile : TeaModel {
                        /// <summary>
                        /// The OSS bucket that stores the output snapshot.
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// The OSS region in which the OSS bucket for storing the output snapshot resides.
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// The one or more OSS objects that are generated as the output snapshots.
                        /// 
                        /// > In the example, {Count} is a placeholder. The OSS objects that are generated as output snapshots are named `output00001-****.jpg, output00002-****.jpg`, and so on.
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                    }

                    /// <summary>
                    /// Indicates whether the video content needs to be moderated. Default value: true. Valid values:
                    /// 
                    /// *   **true**: The video content needs to be moderated.
                    /// *   **false**: The video content does not need to be moderated.
                    /// </summary>
                    [NameInMap("VideoCensor")]
                    [Validation(Required=false)]
                    public string VideoCensor { get; set; }

                }

            }

        }

        /// <summary>
        /// The token that is used to retrieve the next page of the query results. The value is a UUID that contains 32 characters. If the returned query results cannot be displayed within one page, this parameter is returned. The value of this parameter is updated for each query.
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// The IDs of the jobs that do not exist. This parameter is not returned if all specified jobs are found.
        /// </summary>
        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryMediaCensorJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryMediaCensorJobListResponseBodyNonExistIds : TeaModel {
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
