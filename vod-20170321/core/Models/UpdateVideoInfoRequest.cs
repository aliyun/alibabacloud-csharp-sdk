// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVideoInfoRequest : TeaModel {
        /// <summary>
        /// The ID of the video category.
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// The URL of the video thumbnail.
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// The description of the video.
        /// 
        /// *   The value can be up to 1,024 bytes in length.
        /// *   The string must be encoded in the UTF-8 format.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The tags of the video.
        /// 
        /// *   Each tag can be up to 32 bytes in length. A maximum of 16 tags can be specified.
        /// *   Separate multiple tags with commas (,).
        /// *   The string must be encoded in the UTF-8 format.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The title of the video.
        /// 
        /// *   The value can be up to 128 bytes in length.
        /// *   The string must be encoded in the UTF-8 format.
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// The ID of the video.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
