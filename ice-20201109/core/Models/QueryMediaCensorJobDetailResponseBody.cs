// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryMediaCensorJobDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The results of the content moderation job.</para>
        /// </summary>
        [NameInMap("MediaCensorJobDetail")]
        [Validation(Required=false)]
        public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetail MediaCensorJobDetail { get; set; }
        public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetail : TeaModel {
            /// <summary>
            /// <para>The moderation results of live comments.</para>
            /// </summary>
            [NameInMap("BarrageCensorResult")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailBarrageCensorResult BarrageCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailBarrageCensorResult : TeaModel {
                /// <summary>
                /// <para>The label of the moderation result. Valid values:</para>
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
                /// <para>The score.</para>
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
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResults CoverImageCensorResults { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResults : TeaModel {
                [NameInMap("CoverImageCensorResult")]
                [Validation(Required=false)]
                public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResult> CoverImageCensorResult { get; set; }
                public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResult : TeaModel {
                    /// <summary>
                    /// <para>The OSS bucket in which the thumbnail is stored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bucket-out-test-****</para>
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
                    public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResultResults Results { get; set; }
                    public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResultResults : TeaModel {
                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public List<QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResultResultsResult> Result { get; set; }
                        public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailCoverImageCensorResultsCoverImageCensorResultResultsResult : TeaModel {
                            /// <summary>
                            /// <para>The label of the moderation result.</para>
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
                            /// <item><description><b>drivelive</b>: live broadcasting in a running vehicle.</description></item>
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
                            /// <para>Normal</para>
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
                            /// <para>Antispam</para>
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

                }

            }

            /// <summary>
            /// <para>The time when the content moderation job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-09-13T16:32:24Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The moderation results of descriptions.</para>
            /// </summary>
            [NameInMap("DescCensorResult")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailDescCensorResult DescCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailDescCensorResult : TeaModel {
                /// <summary>
                /// <para>The label of the moderation result. Valid values:</para>
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
                /// <para>terrorism</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The score.</para>
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
                /// <para>review</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

            }

            /// <summary>
            /// <para>The time when the content moderation job was complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-09-13T16:38:24Z</para>
            /// </summary>
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            /// <summary>
            /// <para>The information about the job input.</para>
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailInput Input { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailInput : TeaModel {
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
            /// <para>f8f166eea7a44e9bb0a4aecf9543****</para>
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
            /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue to which the job was submitted.</para>
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
            /// <para>The overall result of the content moderation job. Valid values:</para>
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
            /// <para>block</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            /// <summary>
            /// <para>The moderation results of titles.</para>
            /// </summary>
            [NameInMap("TitleCensorResult")]
            [Validation(Required=false)]
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailTitleCensorResult TitleCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailTitleCensorResult : TeaModel {
                /// <summary>
                /// <para>The label of the moderation result. Valid values:</para>
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
                /// <para>The score.</para>
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
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResult VensorCensorResult { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVensorCensorResult : TeaModel {
                /// <summary>
                /// <para>A collection of moderation results. The information includes the summary about various scenarios such as pornographic content moderation and terrorist content moderation.</para>
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
                        /// <para>The label of the moderation result.</para>
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
                        /// <item><description><b>drivelive</b>: live broadcasting in a running vehicle.</description></item>
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
                        /// <para>The score.</para>
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
                        /// <para>terrorism</para>
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
                        /// <para>review</para>
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
                /// <para>ea04afcca7cd4e80b9ece8fbb251****</para>
                /// </summary>
                [NameInMap("NextPageToken")]
                [Validation(Required=false)]
                public string NextPageToken { get; set; }

                /// <summary>
                /// <para>The moderation results that are sorted in ascending order by time.</para>
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
                        /// <para>The moderation results that include information such as labels and scores.</para>
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
                                /// <para>The label of the moderation result.</para>
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
                                /// <item><description><b>drivelive</b>: live broadcasting in a running vehicle.</description></item>
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
                                /// <para>flood</para>
                                /// </summary>
                                [NameInMap("Label")]
                                [Validation(Required=false)]
                                public string Label { get; set; }

                                /// <summary>
                                /// <para>The score.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>99.99</para>
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
            public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfig VideoCensorConfig { get; set; }
            public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfig : TeaModel {
                /// <summary>
                /// <para>The custom business type. Default value: common.</para>
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
                public QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfigOutputFile OutputFile { get; set; }
                public class QueryMediaCensorJobDetailResponseBodyMediaCensorJobDetailVideoCensorConfigOutputFile : TeaModel {
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
                    /// <para>The OSS region in which the output snapshot resides.</para>
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
                    /// <para> In the example, {Count} is a placeholder. The OSS objects that are generated as output snapshots are named <c>output00001-****.jpg</c>, <c>output00002-****.jpg</c>, and so on.</para>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B42299E6-F71F-465F-8FE9-4FC2E3D3C2CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
