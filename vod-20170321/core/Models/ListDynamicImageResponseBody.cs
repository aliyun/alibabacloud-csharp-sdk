// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListDynamicImageResponseBody : TeaModel {
        /// <summary>
        /// The list of animated stickers.
        /// </summary>
        [NameInMap("DynamicImageList")]
        [Validation(Required=false)]
        public List<ListDynamicImageResponseBodyDynamicImageList> DynamicImageList { get; set; }
        public class ListDynamicImageResponseBodyDynamicImageList : TeaModel {
            /// <summary>
            /// The time when the animated sticker was created. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The duration of the animated sticker. Unit: seconds.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// The ID of the animated sticker.
            /// </summary>
            [NameInMap("DynamicImageId")]
            [Validation(Required=false)]
            public string DynamicImageId { get; set; }

            /// <summary>
            /// The size of the animated sticker file. Unit: byte.
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            /// <summary>
            /// The URL of the animated sticker file.
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// The format of the animated sticker. Valid values: gif and webp.
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// The frame rate of the animated sticker. Unit: frames per second.
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            /// <summary>
            /// The height of the animated sticker. Unit: pixel.
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public string Height { get; set; }

            /// <summary>
            /// The job ID for creating the animated sticker.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The ID of the video.
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

            /// <summary>
            /// The width of the animated sticker. Unit: pixel.
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
