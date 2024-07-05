// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddMediaResponseBody : TeaModel {
        /// <summary>
        /// The detailed information about the media file.
        /// </summary>
        [NameInMap("Media")]
        [Validation(Required=false)]
        public AddMediaResponseBodyMedia Media { get; set; }
        public class AddMediaResponseBodyMedia : TeaModel {
            /// <summary>
            /// The bitrate.
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
            /// The review status of the media file. Valid values:
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
            /// The description of the media file. The description can be up to 1,024 bytes in length.
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
            public AddMediaResponseBodyMediaFile File { get; set; }
            public class AddMediaResponseBodyMediaFile : TeaModel {
                /// <summary>
                /// The status of the file. The default value is **Normal**.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The URL of the media file.
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
            /// The publishing status of the media file. Valid values:
            /// 
            /// *   **Initiated**: The media file is in the initial state.
            /// *   **UnPublish**: The media file has not been published, and the playback permission on the OSS object is Private.
            /// *   **Published**: The media file has been published, and the playback permission on the OSS object is Default.
            /// </summary>
            [NameInMap("PublishState")]
            [Validation(Required=false)]
            public string PublishState { get; set; }

            /// <summary>
            /// The IDs of the media workflow execution instances.
            /// </summary>
            [NameInMap("RunIdList")]
            [Validation(Required=false)]
            public AddMediaResponseBodyMediaRunIdList RunIdList { get; set; }
            public class AddMediaResponseBodyMediaRunIdList : TeaModel {
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
            /// The tags of the media file.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public AddMediaResponseBodyMediaTags Tags { get; set; }
            public class AddMediaResponseBodyMediaTags : TeaModel {
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public List<string> Tag { get; set; }

            }

            /// <summary>
            /// The title of the media file. The title can be up to 128 bytes in length.
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
