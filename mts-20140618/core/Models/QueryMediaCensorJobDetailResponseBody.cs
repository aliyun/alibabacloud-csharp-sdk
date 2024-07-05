// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaCensorJobDetailResponseBody : TeaModel {
        /// <summary>
        /// The results of the content moderation job.
        /// </summary>
        [NameInMap("MediaCensorJobDetail")]
        [Validation(Required=false)]
        public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetail MediaCensorJobDetail { get; set; }
        public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetail : TeaModel {
            [NameInMap("AudioCensorResult")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailAudioCensorResult AudioCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailAudioCensorResult : TeaModel {
                [NameInMap("AudioDetailResultList")]
                [Validation(Required=false)]
                public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailAudioCensorResultAudioDetailResultList AudioDetailResultList { get; set; }
                public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailAudioCensorResultAudioDetailResultList : TeaModel {
                    [NameInMap("AudioDetailResult")]
                    [Validation(Required=false)]
                    public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailAudioCensorResultAudioDetailResultListAudioDetailResult> AudioDetailResult { get; set; }
                    public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailAudioCensorResultAudioDetailResultListAudioDetailResult : TeaModel {
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public int? EndTime { get; set; }

                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        [NameInMap("StartTime")]
                        [Validation(Required=false)]
                        public int? StartTime { get; set; }

                        [NameInMap("Text")]
                        [Validation(Required=false)]
                        public string Text { get; set; }

                    }

                }

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
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailBarrageCensorResult BarrageCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailBarrageCensorResult : TeaModel {
                /// <summary>
                /// The labels of the moderation result. Multiple labels are separated with commas (,). Valid values:
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
                /// The moderation scenario. Valid values: The value is **antispam**.
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
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResults CoverImageCensorResults { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResults : TeaModel {
                [NameInMap("CoverImageCensorResult")]
                [Validation(Required=false)]
                public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResult> CoverImageCensorResult { get; set; }
                public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResult : TeaModel {
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
                    /// The moderation results.
                    /// </summary>
                    [NameInMap("Results")]
                    [Validation(Required=false)]
                    public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResultResults Results { get; set; }
                    public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResultResults : TeaModel {
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResultResultsResult> Result { get; set; }
                        public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResultResultsResult : TeaModel {
                            /// <summary>
                            /// The labels of the moderation result. Multiple labels are separated with commas (,).
                            /// 
                            /// *   Valid values in the pornographic content moderation scenario:
                            /// 
                            ///     *   **normal**: normal content
                            ///     *   **sexy**: sexy content
                            ///     *   **porn**: pornographic content
                            /// 
                            /// *   Valid values in the terrorist content moderation scenario:
                            /// 
                            ///     *   **narmal**: normal content
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
                            /// The score. Valid values: **0 to 100**.
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
                            /// *   **logo**: logo moderation
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
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailDescCensorResult DescCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailDescCensorResult : TeaModel {
                /// <summary>
                /// The labels of the moderation result. Valid values:
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
                /// The moderation scenario. Valid values: The value is **antispam**.
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
            /// The time when the job was complete.
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// The information about the job input.
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailInput Input { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailInput : TeaModel {
                /// <summary>
                /// The name of the OSS bucket in which the input media file is stored.
                /// </summary>
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                /// <summary>
                /// The OSS region in which the input media file resides.
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// The name of the OSS object that is used as the input media file.
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
            /// The ID of the ApsaraVideo Media Processing (MPS) queue to which the content moderation job is submitted.
            /// </summary>
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            /// <summary>
            /// The status of the job. Valid values:
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The overall result of the job. Valid values:
            /// 
            /// *   **pass**: The content passes the moderation.
            /// *   **review**: The content needs to be manually reviewed again.
            /// *   **block**: The content needs to be blocked.
            /// 
            /// If the moderation result of one type of the moderated content is review, the overall result is review. If the moderation result of one type of the moderated content is block, the overall result is block.
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            /// <summary>
            /// The moderation result of the title.
            /// </summary>
            [NameInMap("TitleCensorResult")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailTitleCensorResult TitleCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailTitleCensorResult : TeaModel {
                /// <summary>
                /// The labels of the moderation result. Valid values:
                /// 
                /// *   **normal**: normal content
                /// *   **spam**: spam
                /// *   **ad**: ads
                /// *   **abuse**: abuse
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
                /// The moderation scenario. Valid values: The value is **antispam**.
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
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResult VensorCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResult : TeaModel {
                /// <summary>
                /// A collection of the moderation results. The information includes the summary of various scenarios such as pornographic content and terrorist content.
                /// </summary>
                [NameInMap("CensorResults")]
                [Validation(Required=false)]
                public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultCensorResults CensorResults { get; set; }
                public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultCensorResults : TeaModel {
                    [NameInMap("CensorResult")]
                    [Validation(Required=false)]
                    public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultCensorResultsCensorResult> CensorResult { get; set; }
                    public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultCensorResultsCensorResult : TeaModel {
                        /// <summary>
                        /// The labels of the moderation result. Multiple labels are separated with commas (,). Valid values:
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
                        /// *   **logo**: logo moderation
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
                /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.
                /// </summary>
                [NameInMap("NextPageToken")]
                [Validation(Required=false)]
                public string NextPageToken { get; set; }

                /// <summary>
                /// The moderation results that are sorted in ascending order by time.
                /// </summary>
                [NameInMap("VideoTimelines")]
                [Validation(Required=false)]
                public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelines VideoTimelines { get; set; }
                public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelines : TeaModel {
                    [NameInMap("VideoTimeline")]
                    [Validation(Required=false)]
                    public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimeline> VideoTimeline { get; set; }
                    public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimeline : TeaModel {
                        /// <summary>
                        /// The moderation results that include information such as labels and scores.
                        /// </summary>
                        [NameInMap("CensorResults")]
                        [Validation(Required=false)]
                        public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimelineCensorResults CensorResults { get; set; }
                        public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimelineCensorResults : TeaModel {
                            [NameInMap("CensorResult")]
                            [Validation(Required=false)]
                            public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimelineCensorResultsCensorResult> CensorResult { get; set; }
                            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResultVideoTimelinesVideoTimelineCensorResultsCensorResult : TeaModel {
                                /// <summary>
                                /// The labels of the moderation result. Multiple labels are separated with commas (,). Valid values:
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
                                /// *   **logo**: logo moderation
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
                        /// The one or more OSS objects that are generated as the output snapshots.
                        /// 
                        /// > In the example, {Count} is a placeholder. The OSS objects that are generated as output snapshots are named `output00001-****.jpg`, `output00002-****.jpg`, and so on.
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
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfig VideoCensorConfig { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfig : TeaModel {
                /// <summary>
                /// The custom business type. Default value: common.
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// The information about output snapshots.
                /// </summary>
                [NameInMap("OutputFile")]
                [Validation(Required=false)]
                public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfigOutputFile OutputFile { get; set; }
                public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfigOutputFile : TeaModel {
                    /// <summary>
                    /// The OSS bucket that stores the output snapshots.
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// The region in which the OSS bucket that stores the output snapshot resides.
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// The one or more OSS objects that are generated as the output snapshots.
                    /// 
                    /// > In the example, {Count} is a placeholder. The OSS objects that are generated as output snapshots are named `output00001-****.jpg`, `output00002-****.jpg`, and so on.
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// Indicates whether the video content needs to be moderated. Default value: **true** Valid values:
                /// 
                /// *   **true**: The video content needs to be moderated.
                /// *   **false**: The video content does not need to be moderated.
                /// </summary>
                [NameInMap("VideoCensor")]
                [Validation(Required=false)]
                public string VideoCensor { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
