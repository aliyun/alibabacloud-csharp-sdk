// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateTemplateRequest : TeaModel {
        /// <summary>
        /// The transmuxing configurations. The value is a JSON object. For more information, see the [MuxConfig](https://help.aliyun.com/document_detail/29253.html) parameter of the "Parameter details" topic.
        /// </summary>
        [NameInMap("Audio")]
        [Validation(Required=false)]
        public string Audio { get; set; }

        /// <summary>
        /// The configurations of the video stream. The value is a JSON object. For more information, see the [Video](https://help.aliyun.com/document_detail/29253.html) parameter of the "Parameter details" topic.
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public string Container { get; set; }

        /// <summary>
        /// The general transcoding configurations. The value is a JSON object. For more information, see the [TransConfig](https://help.aliyun.com/document_detail/29253.html) parameter of the "Parameter details" topic.
        /// </summary>
        [NameInMap("MuxConfig")]
        [Validation(Required=false)]
        public string MuxConfig { get; set; }

        /// <summary>
        /// The container format. The value is a JSON object. Default format: **MP4**.
        /// 
        /// *   Video formats: FLV, MP4, HLS (M3U8 + TS), and MPEG-DASH (MPD + fMP4)
        /// *   Audio formats: MP3, MP4, OGG, FLAC, and M4A
        /// *   Images formats: GIF and WebP
        /// 
        /// For more information, see the [Container](https://help.aliyun.com/document_detail/29253.html) parameter of the "Parameter details" topic.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The name of the template. The name can be up to 128 bytes in length.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("TransConfig")]
        [Validation(Required=false)]
        public string TransConfig { get; set; }

        /// <summary>
        /// The configurations of the audio stream. The value is a JSON object. For more information, see the [Audio](https://help.aliyun.com/document_detail/29253.html) parameter of the "Parameter details" topic.
        /// </summary>
        [NameInMap("Video")]
        [Validation(Required=false)]
        public string Video { get; set; }

    }

}
