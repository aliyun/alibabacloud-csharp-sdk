// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateMediaResponseBody : TeaModel {
        /// <summary>
        /// The information about the media file.
        /// </summary>
        [NameInMap("Media")]
        [Validation(Required=false)]
        public UpdateMediaResponseBodyMedia Media { get; set; }
        public class UpdateMediaResponseBodyMedia : TeaModel {
            /// <summary>
            /// The bitrate of the media file.
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            /// <summary>
            /// The ID of the category to which the media file belongs.
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// The review state of the media file. Valid values:
            /// 
            /// *   **Initiated**: The media file is uploaded but not reviewed.
            /// *   **Pass**: The media file is uploaded and passes the review.
            /// </summary>
            [NameInMap("CensorState")]
            [Validation(Required=false)]
            public string CensorState { get; set; }

            /// <summary>
            /// The URL of the thumbnail.
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// The time when the media file was created.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The description of the media file.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The duration of the media file.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// The information about the input file.
            /// </summary>
            [NameInMap("File")]
            [Validation(Required=false)]
            public UpdateMediaResponseBodyMediaFile File { get; set; }
            public class UpdateMediaResponseBodyMediaFile : TeaModel {
                /// <summary>
                /// The state of the input file. Valid values:
                /// 
                /// *   **Normal**: The input file is normal.
                /// *   **Deleted**: The input file is deleted.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The name of the OSS bucket in which the input media file is stored.
                /// </summary>
                [NameInMap("URL")]
                [Validation(Required=false)]
                public string URL { get; set; }

            }

            /// <summary>
            /// The format of the media file. Valid values: mov, mp4, m4a, 3gp, 3g2, and mj2.
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// The frame rate of the media file.
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            /// <summary>
            /// The height of the media file.
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            /// <summary>
            /// The ID of the media file.
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// The publishing state of the media file. Valid values:
            /// 
            /// *   **Initiated**: The media file is in the initial state.
            /// *   **UnPublish**: The media file has not been published, and the playback permission on the OSS object is Private.
            /// *   **Published**: The media file has been published, and the playback permission on the OSS object is Default.
            /// *   **Deleted**: The media file is deleted.
            /// </summary>
            [NameInMap("PublishState")]
            [Validation(Required=false)]
            public string PublishState { get; set; }

            /// <summary>
            /// The IDs of the media workflow execution instances.
            /// </summary>
            [NameInMap("RunIdList")]
            [Validation(Required=false)]
            public UpdateMediaResponseBodyMediaRunIdList RunIdList { get; set; }
            public class UpdateMediaResponseBodyMediaRunIdList : TeaModel {
                [NameInMap("RunId")]
                [Validation(Required=false)]
                public List<string> RunId { get; set; }

            }

            /// <summary>
            /// The size of the media file.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }

            /// <summary>
            /// The information about the tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public UpdateMediaResponseBodyMediaTags Tags { get; set; }
            public class UpdateMediaResponseBodyMediaTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<string> Tag { get; set; }

            }

            /// <summary>
            /// The title of the media file.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The width of the media file.
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public string Width { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
