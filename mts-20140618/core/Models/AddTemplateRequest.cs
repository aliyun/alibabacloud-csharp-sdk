// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddTemplateRequest : TeaModel {
        /// <summary>
        /// The audio stream settings. The value must be a JSON object. For more information, see [Audio](https://help.aliyun.com/document_detail/29253.html).
        /// 
        /// > If you do not specify this parameter, output files do not contain audio streams. This parameter is required if you want to retain the audio streams.
        /// </summary>
        [NameInMap("Audio")]
        [Validation(Required=false)]
        public string Audio { get; set; }

        /// <summary>
        /// The container format. The value must be a JSON object that contains the Format parameter. If you do not specify this parameter, the transcoded media file is in MP4 format by default. This parameter is required if you want to use the transcoding template to generate media files in other formats. For more information, see [Container](https://help.aliyun.com/document_detail/29253.html).
        /// 
        /// *   Default value: MP4.
        /// *   Video transcoding supports the following formats: FLV, MP4, HLS (M3U8 + TS), and MPEG-DASH (MPD + fMP4).
        /// 
        /// > If the container format is FLV, the video codec cannot be set to H.265.
        /// 
        /// *   Audio transcoding supports the following formats: MP3, MP4, OGG, FLAC, and M4A.
        /// *   Image transcoding supports the GIF and WebP formats.
        /// 
        /// > 
        /// 
        /// *   If the container format is GIF, the video codec must be set to GIF.
        /// 
        /// *   If the container format is WebP, the video codec must be set to WebP.
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public string Container { get; set; }

        /// <summary>
        /// The segment settings. The value must be a JSON object. For more information, see [MuxConfig](https://help.aliyun.com/document_detail/29253.html). If you do not specify this parameter, media segment files are not generated. This parameter is required if you want to generate media segment files.
        /// </summary>
        [NameInMap("MuxConfig")]
        [Validation(Required=false)]
        public string MuxConfig { get; set; }

        /// <summary>
        /// The name of the transcoding template. The name can be up to 128 bytes in length.
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
        /// The general transcoding settings. The value must be a JSON object. For more information, see [TransConfig](https://help.aliyun.com/document_detail/29253.html). If you do not specify this parameter, the default settings are used. This parameter is required if the default settings cannot meet your business requirements.
        /// </summary>
        [NameInMap("TransConfig")]
        [Validation(Required=false)]
        public string TransConfig { get; set; }

        /// <summary>
        /// The video stream settings. The value must be a JSON object. For more information, see [Video](https://help.aliyun.com/document_detail/29253.html).
        /// 
        /// > If you do not specify this parameter, output files do not contain video streams. This parameter is required if you want to retain the video streams.
        /// </summary>
        [NameInMap("Video")]
        [Validation(Required=false)]
        public string Video { get; set; }

    }

}
