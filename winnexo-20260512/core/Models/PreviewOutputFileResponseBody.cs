// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class PreviewOutputFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The text content. This parameter is used for the CONTENT type.</para>
        /// 
        /// <b>Example:</b>
        /// <h1>Quarterly Review</h1>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Indicates whether the preview is degraded to a download. A value of true indicates that the preview is degraded to a download and cannot be opened in an online previewer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("degraded")]
        [Validation(Required=false)]
        public bool? Degraded { get; set; }

        /// <summary>
        /// <para>The expiration time of the download ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-16T14:00:00+00:00</para>
        /// </summary>
        [NameInMap("downloadExpiresAt")]
        [Validation(Required=false)]
        public string DownloadExpiresAt { get; set; }

        /// <summary>
        /// <para>The short-term signed download URL for the output. You can send a GET request to this URL before it expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/download/file">https://example.com/download/file</a></para>
        /// </summary>
        [NameInMap("downloadUrl")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// <para>The file name extension. This parameter is used for the OSS_IMM type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pptx</para>
        /// </summary>
        [NameInMap("fileExt")]
        [Validation(Required=false)]
        public string FileExt { get; set; }

        /// <summary>
        /// <para>The modification time in ISO8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-16T13:00:00+00:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The output name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quarterly_Review.pptx</para>
        /// </summary>
        [NameInMap("itemName")]
        [Validation(Required=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// <para>The output item type. Valid values: ppt, html, document, picture, slides, video, audio, email, and others.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ppt</para>
        /// </summary>
        [NameInMap("itemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid request parameters</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The output item ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleOutputItemId</para>
        /// </summary>
        [NameInMap("outputItemId")]
        [Validation(Required=false)]
        public string OutputItemId { get; set; }

        /// <summary>
        /// <para>The expiration time of the preview ticket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-16T14:00:00+00:00</para>
        /// </summary>
        [NameInMap("previewExpiresAt")]
        [Validation(Required=false)]
        public string PreviewExpiresAt { get; set; }

        /// <summary>
        /// <para>The preview type. Valid values: OSS_IMM, IMAGE, AUDIO, VIDEO, HTML, DING_TALK, VOICE_MEETING, and CONTENT.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSS_IMM</para>
        /// </summary>
        [NameInMap("previewType")]
        [Validation(Required=false)]
        public string PreviewType { get; set; }

        /// <summary>
        /// <para>The preview URL. This parameter is used for OSS_IMM, DING_TALK, and VOICE_MEETING.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/preview/document">https://example.com/preview/document</a></para>
        /// </summary>
        [NameInMap("previewUrl")]
        [Validation(Required=false)]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// <para>The read state. Valid values: AVAILABLE, PRUNED, PENDING, and UNVERSIONED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("readState")]
        [Validation(Required=false)]
        public string ReadState { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of slides for the slide deck output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("slides")]
        [Validation(Required=false)]
        public List<PreviewOutputFileResponseBodySlides> Slides { get; set; }
        public class PreviewOutputFileResponseBodySlides : TeaModel {
            /// <summary>
            /// <para>The display text of the slide.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Market Overview</para>
            /// </summary>
            [NameInMap("displayText")]
            [Validation(Required=false)]
            public string DisplayText { get; set; }

            /// <summary>
            /// <para>Specifies the detail level of the image. Valid values: low, high, and auto. Default value: auto.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/slide/1">https://example.com/slide/1</a></para>
            /// </summary>
            [NameInMap("imageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            /// <summary>
            /// <para>The slide ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleSlideId</para>
            /// </summary>
            [NameInMap("slideId")]
            [Validation(Required=false)]
            public string SlideId { get; set; }

            /// <summary>
            /// <para>The slide order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("slideIndex")]
            [Validation(Required=false)]
            public long? SlideIndex { get; set; }

            /// <summary>
            /// <para>The signing status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATED: created but not signed</description></item>
            /// <item><description>SUCCESS: signed successfully</description></item>
            /// <item><description>STOP: terminated</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The reason why the content is unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The output content is still being generated</para>
        /// </summary>
        [NameInMap("unavailableReason")]
        [Validation(Required=false)]
        public string UnavailableReason { get; set; }

        /// <summary>
        /// <para>The optimistic version number.</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public PreviewOutputFileResponseBodyVersion Version { get; set; }
        public class PreviewOutputFileResponseBodyVersion : TeaModel {
            /// <summary>
            /// <para>The number of remaining seats.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("availability")]
            [Validation(Required=false)]
            public string Availability { get; set; }

            /// <summary>
            /// <para>Specifies whether the model supports multiple tool calls in a single response.</para>
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public PreviewOutputFileResponseBodyVersionCapabilities Capabilities { get; set; }
            public class PreviewOutputFileResponseBodyVersionCapabilities : TeaModel {
                /// <summary>
                /// <para>Indicates whether the version can be opened in a browser.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("canBrowserOpen")]
                [Validation(Required=false)]
                public bool? CanBrowserOpen { get; set; }

                /// <summary>
                /// <para>Indicates whether the version can be downloaded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("canDownload")]
                [Validation(Required=false)]
                public bool? CanDownload { get; set; }

                /// <summary>
                /// <para>Indicates whether the course can be edited or deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("canEdit")]
                [Validation(Required=false)]
                public bool? CanEdit { get; set; }

                /// <summary>
                /// <para>Indicates whether the version can be restored to the latest version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("canRestore")]
                [Validation(Required=false)]
                public bool? CanRestore { get; set; }

                /// <summary>
                /// <para>Indicates whether the version can be saved as knowledge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("canSaveAsKnowledge")]
                [Validation(Required=false)]
                public bool? CanSaveAsKnowledge { get; set; }

                /// <summary>
                /// <para>Indicates whether the version can be shared.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("canShare")]
                [Validation(Required=false)]
                public bool? CanShare { get; set; }

            }

            /// <summary>
            /// <para>The content revision number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("contentRevision")]
            [Validation(Required=false)]
            public long? ContentRevision { get; set; }

            /// <summary>
            /// <para>Indicates whether the version is the latest version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isLatest")]
            [Validation(Required=false)]
            public bool? IsLatest { get; set; }

            /// <summary>
            /// <para>The ID of the current latest version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleLatestVersionId</para>
            /// </summary>
            [NameInMap("latestVersionId")]
            [Validation(Required=false)]
            public string LatestVersionId { get; set; }

            /// <summary>
            /// <para>The read state of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("readState")]
            [Validation(Required=false)]
            public string ReadState { get; set; }

            /// <summary>
            /// <para>The ID of the version that is actually read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleVersionId</para>
            /// </summary>
            [NameInMap("selectedVersionId")]
            [Validation(Required=false)]
            public string SelectedVersionId { get; set; }

            /// <summary>
            /// <para>The ID of the message that generated this version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleMessageId</para>
            /// </summary>
            [NameInMap("sourceMessageId")]
            [Validation(Required=false)]
            public string SourceMessageId { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-16T13:00:00+00:00</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The version serial number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("versionNo")]
            [Validation(Required=false)]
            public long? VersionNo { get; set; }

        }

    }

}
