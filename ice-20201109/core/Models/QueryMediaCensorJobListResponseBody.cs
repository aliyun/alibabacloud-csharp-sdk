// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryMediaCensorJobListResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried content moderation jobs.</para>
        /// </summary>
        [NameInMap("MediaCensorJobList")]
        [Validation(Required=false)]
        public QueryMediaCensorJobListResponseBodyMediaCensorJobList MediaCensorJobList { get; set; }
        public class QueryMediaCensorJobListResponseBodyMediaCensorJobList : TeaModel {
            [NameInMap("MediaCensorJob")]
            [Validation(Required=false)]
            public List<QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJob> MediaCensorJob { get; set; }
            public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJob : TeaModel {
                /// <summary>
                /// <para>The moderation results of live comments.</para>
                /// </summary>
                [NameInMap("BarrageCensorResult")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobBarrageCensorResult BarrageCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobBarrageCensorResult : TeaModel {
                    /// <summary>
                    /// <para>The label of the moderation result. Separate multiple labels with commas (,). Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal content.</description></item>
                    /// <item><description><b>spam</b>: spam.</description></item>
                    /// <item><description><b>ad</b>: ads.</description></item>
                    /// <item><description><b>abuse</b>: abuse content.</description></item>
                    /// <item><description><b>flood</b>: excessive junk content.</description></item>
                    /// <item><description><b>contraband</b>: prohibited content.</description></item>
                    /// <item><description><b>meaningless</b>: meaningless content.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The score. Valid values: 0 to 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>99.91</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public string Rate { get; set; }

                    /// <summary>
                    /// <para>The moderation scenario. The value is <b>antispam</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>antispam</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The recommended subsequent operation. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                    /// <item><description><b>review</b>: The content needs to be manually reviewed.</description></item>
                    /// <item><description><b>block</b>: The content needs to be blocked.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pass</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// <para>The error code returned if the job failed. This parameter is not returned if the job is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidParameter.ResourceNotFound</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The moderation results of thumbnails.</para>
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
                        /// <para>The OSS bucket in which the thumbnail is stored.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example-Bucket-****</para>
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// <para>The OSS region in which the thumbnail resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>oss-cn-shanghai</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// <para>The Object Storage Service (OSS) object that is used as the thumbnail.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test/ai/censor/v2/vme-****.jpg</para>
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                        /// <summary>
                        /// <para>The moderation results.</para>
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
                                /// <para>The label of the moderation result. Separate multiple labels with commas (,).</para>
                                /// <list type="bullet">
                                /// <item><description><para>Valid values in the pornographic content moderation scenario:</para>
                                /// <list type="bullet">
                                /// <item><description><b>normal</b>: normal content.</description></item>
                                /// <item><description><b>sexy</b>: sexy content.</description></item>
                                /// <item><description><b>porn</b>: pornographic content.</description></item>
                                /// </list>
                                /// </description></item>
                                /// <item><description><para>Valid values in the terrorist content moderation scenario:</para>
                                /// <list type="bullet">
                                /// <item><description><b>normal</b>: normal content.</description></item>
                                /// <item><description><b>bloody</b>: bloody content.</description></item>
                                /// <item><description><b>explosion</b>: explosion and smoke.</description></item>
                                /// <item><description><b>outfit</b>: special costume.</description></item>
                                /// <item><description><b>logo</b>: special logo.</description></item>
                                /// <item><description><b>weapon</b>: weapon.</description></item>
                                /// <item><description><b>politics</b>: political content.</description></item>
                                /// <item><description><b>violence</b>: violence.</description></item>
                                /// <item><description><b>crowd</b>: crowd.</description></item>
                                /// <item><description><b>parade</b>: parade.</description></item>
                                /// <item><description><b>carcrash</b>: car accident.</description></item>
                                /// <item><description><b>flag</b>: flag.</description></item>
                                /// <item><description><b>location</b>: landmark.</description></item>
                                /// <item><description><b>others</b>: other content.</description></item>
                                /// </list>
                                /// </description></item>
                                /// <item><description><para>Valid values in the ad moderation scenario:</para>
                                /// <list type="bullet">
                                /// <item><description><b>normal</b>: normal content.</description></item>
                                /// <item><description><b>ad</b>: other ads.</description></item>
                                /// <item><description><b>politics</b>: political content in text.</description></item>
                                /// <item><description><b>porn</b>: pornographic content in text.</description></item>
                                /// <item><description><b>abuse</b>: abuse in text.</description></item>
                                /// <item><description><b>terrorism</b>: terrorist content in text.</description></item>
                                /// <item><description><b>contraband</b>: prohibited content in text.</description></item>
                                /// <item><description><b>spam</b>: spam in text.</description></item>
                                /// <item><description><b>npx</b>: illegal ad.</description></item>
                                /// <item><description><b>qrcode</b>: QR code.</description></item>
                                /// <item><description><b>programCode</b>: mini program code.</description></item>
                                /// </list>
                                /// </description></item>
                                /// <item><description><para>Valid values in the undesirable scene moderation scenario:</para>
                                /// <list type="bullet">
                                /// <item><description><b>normal</b>: normal content.</description></item>
                                /// <item><description><b>meaningless</b>: meaningless content, such as a black or white screen.</description></item>
                                /// <item><description><b>PIP</b>: picture-in-picture.</description></item>
                                /// <item><description><b>smoking</b>: smoking.</description></item>
                                /// <item><description><b>drivelive</b>: live streaming in a running vehicle.</description></item>
                                /// </list>
                                /// </description></item>
                                /// <item><description><para>Valid values in the logo moderation scenario:</para>
                                /// <list type="bullet">
                                /// <item><description><b>normal</b>: normal content.</description></item>
                                /// <item><description><b>TV</b>: controlled logo.</description></item>
                                /// <item><description><b>trademark</b>: trademark.</description></item>
                                /// </list>
                                /// </description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>normal</para>
                                /// </summary>
                                [NameInMap("Label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// <para>The score. Valid values: 0 to 100.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("Rate")]
                                [Validation(Required=false)]
                                public string Rate { get; set; }

                                /// <summary>
                                /// <para>The moderation scenario. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>porn</b>: pornographic content moderation.</description></item>
                                /// <item><description><b>terrorism</b>: terrorist content moderation.</description></item>
                                /// <item><description><b>ad</b>: ad moderation.</description></item>
                                /// <item><description><b>live</b>: undesirable scene moderation.</description></item>
                                /// <item><description><b>logo</b>: logo moderation.</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>live</para>
                                /// </summary>
                                [NameInMap("Scene")]
                                [Validation(Required=false)]
                                public string Scene { get; set; }

                                /// <summary>
                                /// <para>The overall result of the moderation job. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                                /// <item><description><b>review</b>: The content needs to be manually reviewed.</description></item>
                                /// <item><description><b>block</b>: The content needs to be blocked.</description></item>
                                /// </list>
                                /// <remarks>
                                /// <para> If the moderation result of any type of content is review, the overall result is review. If the moderation result of any type of content is block, the overall result is block.</para>
                                /// </remarks>
                                /// 
                                /// <b>Example:</b>
                                /// <para>pass</para>
                                /// </summary>
                                [NameInMap("Suggestion")]
                                [Validation(Required=false)]
                                public string Suggestion { get; set; }

                            }

                        }

                    }

                }

                /// <summary>
                /// <para>The time when the content moderation job was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-04T07:25:48Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The moderation results of descriptions.</para>
                /// </summary>
                [NameInMap("DescCensorResult")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobDescCensorResult DescCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobDescCensorResult : TeaModel {
                    /// <summary>
                    /// <para>The label of the moderation result. Separate multiple labels with commas (,). Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal content.</description></item>
                    /// <item><description><b>spam</b>: spam.</description></item>
                    /// <item><description><b>ad</b>: ads.</description></item>
                    /// <item><description><b>abuse</b>: abuse content.</description></item>
                    /// <item><description><b>flood</b>: excessive junk content.</description></item>
                    /// <item><description><b>contraband</b>: prohibited content.</description></item>
                    /// <item><description><b>meaningless</b>: meaningless content.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>normal</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The score. Valid values: 0 to 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public string Rate { get; set; }

                    /// <summary>
                    /// <para>The moderation scenario. The value is <b>antispam</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>antispam</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The recommended subsequent operation. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                    /// <item><description><b>review</b>: The content needs to be manually reviewed.</description></item>
                    /// <item><description><b>block</b>: The content needs to be blocked.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pass</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// <para>The time when the content moderation job was complete.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-04T07:25:50Z</para>
                /// </summary>
                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                /// <summary>
                /// <para>The information about the job input.</para>
                /// </summary>
                [NameInMap("Input")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobInput Input { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobInput : TeaModel {
                    /// <summary>
                    /// <para>The name of the OSS bucket in which the input file is stored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bucket-test-in-****</para>
                    /// </summary>
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    /// <summary>
                    /// <para>The OSS region in which the input file resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss-cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    /// <summary>
                    /// <para>The name of the OSS object that is used as the input file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test/ai/censor/test-****.mp4</para>
                    /// </summary>
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }

                /// <summary>
                /// <para>The ID of the content moderation job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f8f166eea7a44e9bb0a4aecf9543</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The error message returned if the job failed. This parameter is not returned if the job is successful.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The resource operated cannot be found</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The ID of the MPS queue to which the job was submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>c5b30b7c0d0e4a0abde1d5f9e751****</para>
                /// </summary>
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }

                /// <summary>
                /// <para>The job state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The recommended subsequent operation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                /// <item><description><b>review</b>: The content needs to be manually reviewed.</description></item>
                /// <item><description><b>block</b>: The content needs to be blocked.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <para>The moderation results of titles.</para>
                /// </summary>
                [NameInMap("TitleCensorResult")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobTitleCensorResult TitleCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobTitleCensorResult : TeaModel {
                    /// <summary>
                    /// <para>The label of the moderation result. Separate multiple labels with commas (,). Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>normal</b>: normal content.</description></item>
                    /// <item><description><b>spam</b>: spam.</description></item>
                    /// <item><description><b>ad</b>: ads.</description></item>
                    /// <item><description><b>abuse</b>: abuse content.</description></item>
                    /// <item><description><b>flood</b>: excessive junk content.</description></item>
                    /// <item><description><b>contraband</b>: prohibited content.</description></item>
                    /// <item><description><b>meaningless</b>: meaningless content.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>meaningless</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The score. Valid values: 0 to 100.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public string Rate { get; set; }

                    /// <summary>
                    /// <para>The moderation scenario. The value is <b>antispam</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>antispam</para>
                    /// </summary>
                    [NameInMap("Scene")]
                    [Validation(Required=false)]
                    public string Scene { get; set; }

                    /// <summary>
                    /// <para>The recommended subsequent operation. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                    /// <item><description><b>review</b>: The content needs to be manually reviewed.</description></item>
                    /// <item><description><b>block</b>: The content needs to be blocked.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// <para>The user-defined data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example userdata ****</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

                /// <summary>
                /// <para>The moderation results of videos.</para>
                /// </summary>
                [NameInMap("VensorCensorResult")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResult VensorCensorResult { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVensorCensorResult : TeaModel {
                    /// <summary>
                    /// <para>A collection of moderation results. The information includes the summary about various scenarios such as pornographic content moderation and terrorist content moderation.</para>
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
                            /// <para>The label of the moderation result. Separate multiple labels with commas (,).</para>
                            /// <list type="bullet">
                            /// <item><description><para>Valid values in the pornographic content moderation scenario:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal content.</description></item>
                            /// <item><description><b>sexy</b>: sexy content.</description></item>
                            /// <item><description><b>porn</b>: pornographic content.</description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Valid values in the terrorist content moderation scenario:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal content.</description></item>
                            /// <item><description><b>bloody</b>: bloody content.</description></item>
                            /// <item><description><b>explosion</b>: explosion and smoke.</description></item>
                            /// <item><description><b>outfit</b>: special costume.</description></item>
                            /// <item><description><b>logo</b>: special logo.</description></item>
                            /// <item><description><b>weapon</b>: weapon.</description></item>
                            /// <item><description><b>politics</b>: political content.</description></item>
                            /// <item><description><b>violence</b>: violence.</description></item>
                            /// <item><description><b>crowd</b>: crowd.</description></item>
                            /// <item><description><b>parade</b>: parade.</description></item>
                            /// <item><description><b>carcrash</b>: car accident.</description></item>
                            /// <item><description><b>flag</b>: flag.</description></item>
                            /// <item><description><b>location</b>: landmark.</description></item>
                            /// <item><description><b>others</b>: other content.</description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Valid values in the ad moderation scenario:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal content.</description></item>
                            /// <item><description><b>ad</b>: other ads.</description></item>
                            /// <item><description><b>politics</b>: political content in text.</description></item>
                            /// <item><description><b>porn</b>: pornographic content in text.</description></item>
                            /// <item><description><b>abuse</b>: abuse in text.</description></item>
                            /// <item><description><b>terrorism</b>: terrorist content in text.</description></item>
                            /// <item><description><b>contraband</b>: prohibited content in text.</description></item>
                            /// <item><description><b>spam</b>: spam in text.</description></item>
                            /// <item><description><b>npx</b>: illegal ad.</description></item>
                            /// <item><description><b>qrcode</b>: QR code.</description></item>
                            /// <item><description><b>programCode</b>: mini program code.</description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Valid values in the undesirable scene moderation scenario:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal content.</description></item>
                            /// <item><description><b>meaningless</b>: meaningless content, such as a black or white screen.</description></item>
                            /// <item><description><b>PIP</b>: picture-in-picture.</description></item>
                            /// <item><description><b>smoking</b>: smoking.</description></item>
                            /// <item><description><b>drivelive</b>: live streaming in a running vehicle.</description></item>
                            /// </list>
                            /// </description></item>
                            /// <item><description><para>Valid values in the logo moderation scenario:</para>
                            /// <list type="bullet">
                            /// <item><description><b>normal</b>: normal content.</description></item>
                            /// <item><description><b>TV</b>: controlled logo.</description></item>
                            /// <item><description><b>trademark</b>: trademark.</description></item>
                            /// </list>
                            /// </description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>meaningless</para>
                            /// </summary>
                            [NameInMap("Label")]
                            [Validation(Required=false)]
                            public string Label { get; set; }

                            /// <summary>
                            /// <para>The score. Valid values: 0 to 100.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("Rate")]
                            [Validation(Required=false)]
                            public string Rate { get; set; }

                            /// <summary>
                            /// <para>The moderation scenario. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>porn</b>: pornographic content moderation.</description></item>
                            /// <item><description><b>terrorism</b>: terrorist content moderation.</description></item>
                            /// <item><description><b>ad</b>: ad moderation.</description></item>
                            /// <item><description><b>live</b>: undesirable scene moderation.</description></item>
                            /// <item><description><b>logo</b>: logo moderation.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ad</para>
                            /// </summary>
                            [NameInMap("Scene")]
                            [Validation(Required=false)]
                            public string Scene { get; set; }

                            /// <summary>
                            /// <para>The recommended subsequent operation. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                            /// <item><description><b>review</b>: The content needs to be manually reviewed.</description></item>
                            /// <item><description><b>block</b>: The content needs to be blocked.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>pass</para>
                            /// </summary>
                            [NameInMap("Suggestion")]
                            [Validation(Required=false)]
                            public string Suggestion { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ea04afcca7cd4e80b9ece8fbb251</para>
                    /// </summary>
                    [NameInMap("NextPageToken")]
                    [Validation(Required=false)]
                    public string NextPageToken { get; set; }

                    /// <summary>
                    /// <para>The moderation results that are sorted in ascending order by time.</para>
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
                            /// <para>The moderation results that include information such as labels and scores.</para>
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
                                    /// <para>The label of the moderation result. Separate multiple labels with commas (,).</para>
                                    /// <list type="bullet">
                                    /// <item><description><para>Valid values in the pornographic content moderation scenario:</para>
                                    /// <list type="bullet">
                                    /// <item><description><b>normal</b>: normal content.</description></item>
                                    /// <item><description><b>sexy</b>: sexy content.</description></item>
                                    /// <item><description><b>porn</b>: pornographic content.</description></item>
                                    /// </list>
                                    /// </description></item>
                                    /// <item><description><para>Valid values in the terrorist content moderation scenario:</para>
                                    /// <list type="bullet">
                                    /// <item><description><b>normal</b>: normal content.</description></item>
                                    /// <item><description><b>bloody</b>: bloody content.</description></item>
                                    /// <item><description><b>explosion</b>: explosion and smoke.</description></item>
                                    /// <item><description><b>outfit</b>: special costume.</description></item>
                                    /// <item><description><b>logo</b>: special logo.</description></item>
                                    /// <item><description><b>weapon</b>: weapon.</description></item>
                                    /// <item><description><b>politics</b>: political content.</description></item>
                                    /// <item><description><b>violence</b>: violence.</description></item>
                                    /// <item><description><b>crowd</b>: crowd.</description></item>
                                    /// <item><description><b>parade</b>: parade.</description></item>
                                    /// <item><description><b>carcrash</b>: car accident.</description></item>
                                    /// <item><description><b>flag</b>: flag.</description></item>
                                    /// <item><description><b>location</b>: landmark.</description></item>
                                    /// <item><description><b>others</b>: other content.</description></item>
                                    /// </list>
                                    /// </description></item>
                                    /// <item><description><para>Valid values in the ad moderation scenario:</para>
                                    /// <list type="bullet">
                                    /// <item><description><b>normal</b>: normal content.</description></item>
                                    /// <item><description><b>ad</b>: other ads.</description></item>
                                    /// <item><description><b>politics</b>: political content in text.</description></item>
                                    /// <item><description><b>porn</b>: pornographic content in text.</description></item>
                                    /// <item><description><b>abuse</b>: abuse in text.</description></item>
                                    /// <item><description><b>terrorism</b>: terrorist content in text.</description></item>
                                    /// <item><description><b>contraband</b>: prohibited content in text.</description></item>
                                    /// <item><description><b>spam</b>: spam in text.</description></item>
                                    /// <item><description><b>npx</b>: illegal ad.</description></item>
                                    /// <item><description><b>qrcode</b>: QR code.</description></item>
                                    /// <item><description><b>programCode</b>: mini program code.</description></item>
                                    /// </list>
                                    /// </description></item>
                                    /// <item><description><para>Valid values in the undesirable scene moderation scenario:</para>
                                    /// <list type="bullet">
                                    /// <item><description><b>normal</b>: normal content.</description></item>
                                    /// <item><description><b>meaningless</b>: meaningless content, such as a black or white screen.</description></item>
                                    /// <item><description><b>PIP</b>: picture-in-picture.</description></item>
                                    /// <item><description><b>smoking</b>: smoking.</description></item>
                                    /// <item><description><b>drivelive</b>: live streaming in a running vehicle.</description></item>
                                    /// </list>
                                    /// </description></item>
                                    /// <item><description><para>Valid values in the logo moderation scenario:</para>
                                    /// <list type="bullet">
                                    /// <item><description><b>normal</b>: normal content.</description></item>
                                    /// <item><description><b>TV</b>: controlled logo.</description></item>
                                    /// <item><description><b>trademark</b>: trademark.</description></item>
                                    /// </list>
                                    /// </description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>normal</para>
                                    /// </summary>
                                    [NameInMap("Label")]
                                    [Validation(Required=false)]
                                    public string Label { get; set; }

                                    /// <summary>
                                    /// <para>The score. Valid values: 0 to 100.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>100</para>
                                    /// </summary>
                                    [NameInMap("Rate")]
                                    [Validation(Required=false)]
                                    public string Rate { get; set; }

                                    /// <summary>
                                    /// <para>The moderation scenario. Valid values:</para>
                                    /// <list type="bullet">
                                    /// <item><description><b>porn</b>: pornographic content moderation.</description></item>
                                    /// <item><description><b>terrorism</b>: terrorist content moderation.</description></item>
                                    /// <item><description><b>ad</b>: ad moderation.</description></item>
                                    /// <item><description><b>live</b>: undesirable scene moderation.</description></item>
                                    /// <item><description><b>logo</b>: logo moderation.</description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>porn</para>
                                    /// </summary>
                                    [NameInMap("Scene")]
                                    [Validation(Required=false)]
                                    public string Scene { get; set; }

                                    /// <summary>
                                    /// <para>The recommended subsequent operation. Valid values:</para>
                                    /// <list type="bullet">
                                    /// <item><description><b>pass</b>: The content passes the moderation.</description></item>
                                    /// <item><description><b>review</b>: The content needs to be manually reviewed.</description></item>
                                    /// <item><description><b>block</b>: The content needs to be blocked.</description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>block</para>
                                    /// </summary>
                                    [NameInMap("Suggestion")]
                                    [Validation(Required=false)]
                                    public string Suggestion { get; set; }

                                }

                            }

                            /// <summary>
                            /// <para>The OSS object that is generated as the output snapshot.</para>
                            /// <remarks>
                            /// <para> In the example, {Count} is a placeholder. The OSS objects that are generated as output snapshots are named <c>output00001-****.jpg</c>, <c>output00002-****.jpg</c>, and so on.</para>
                            /// </remarks>
                            /// 
                            /// <b>Example:</b>
                            /// <para>output{Count}.jpg</para>
                            /// </summary>
                            [NameInMap("Object")]
                            [Validation(Required=false)]
                            public string Object { get; set; }

                            /// <summary>
                            /// <para>The position in the video. Format: <c>hh:mm:ss[.SSS]</c>.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>00:02:59.999</para>
                            /// </summary>
                            [NameInMap("Timestamp")]
                            [Validation(Required=false)]
                            public string Timestamp { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The video moderation configurations.</para>
                /// </summary>
                [NameInMap("VideoCensorConfig")]
                [Validation(Required=false)]
                public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVideoCensorConfig VideoCensorConfig { get; set; }
                public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVideoCensorConfig : TeaModel {
                    /// <summary>
                    /// <para>The moderation template. Default value: common. The default value indicates that the default template is used.</para>
                    /// <remarks>
                    /// <para> If the moderation template is not specified, the default value common is returned. If a custom moderation template that is created by submitting a ticket is specified, the UID of the template is returned.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>common</para>
                    /// </summary>
                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    /// <summary>
                    /// <para>The information about output snapshots.</para>
                    /// </summary>
                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVideoCensorConfigOutputFile OutputFile { get; set; }
                    public class QueryMediaCensorJobListResponseBodyMediaCensorJobListMediaCensorJobVideoCensorConfigOutputFile : TeaModel {
                        /// <summary>
                        /// <para>The OSS bucket in which the output snapshot is stored.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-bucket-****</para>
                        /// </summary>
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }

                        /// <summary>
                        /// <para>The ID of the region in which the output snapshot resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>oss-cn-shanghai</para>
                        /// </summary>
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        /// <summary>
                        /// <para>The OSS object that is generated as the output snapshot.</para>
                        /// <remarks>
                        /// <para> In the example, {Count} is a placeholder. The OSS objects that are generated as output snapshots are named <c>output00001-****.jpg, output00002-****.jpg</c>, and so on.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>output{Count}.jpg</para>
                        /// </summary>
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }

                    }

                    /// <summary>
                    /// <para>Indicates whether the video content needs to be moderated. Default value: <b>true</b>. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: The video content needs to be moderated.</description></item>
                    /// <item><description><b>false</b>: The video content does not need to be moderated.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("VideoCensor")]
                    [Validation(Required=false)]
                    public string VideoCensor { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. The value is 32-character UUID. If the returned query results cannot be displayed within one page, this parameter is returned. The value of this parameter is updated for each query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9b1a42bc6e8d46e6a1383b7e7f01****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The IDs of the jobs that do not exist. This parameter is not returned if all the specified jobs are found.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D1D5C080-8E2F-5030-8AB4-13092F17631B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
