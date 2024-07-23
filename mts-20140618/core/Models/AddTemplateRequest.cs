// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class AddTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The audio stream settings. The value must be a JSON object. For more information, see <a href="https://help.aliyun.com/document_detail/29253.html">Audio</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, output files do not contain audio streams. This parameter is required if you want to retain the audio streams.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Codec&quot;:&quot;H.264&quot;,&quot;Samplerate&quot;:&quot;44100&quot;,&quot;Bitrate&quot;:&quot;500&quot;,&quot;Channels&quot;:&quot;2&quot;}</para>
        /// </summary>
        [NameInMap("Audio")]
        [Validation(Required=false)]
        public string Audio { get; set; }

        /// <summary>
        /// <para>The container format. The value must be a JSON object that contains the Format parameter. If you do not specify this parameter, the transcoded media file is in MP4 format by default. This parameter is required if you want to use the transcoding template to generate media files in other formats. For more information, see <a href="https://help.aliyun.com/document_detail/29253.html">Container</a>.</para>
        /// <list type="bullet">
        /// <item><description>Default value: MP4.</description></item>
        /// <item><description>Video transcoding supports the following formats: FLV, MP4, HLS (M3U8 + TS), and MPEG-DASH (MPD + fMP4).</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the container format is FLV, the video codec cannot be set to H.265.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Audio transcoding supports the following formats: MP3, MP4, OGG, FLAC, and M4A.</description></item>
        /// <item><description>Image transcoding supports the GIF and WebP formats.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the container format is GIF, the video codec must be set to GIF.</para>
        /// </description></item>
        /// <item><description><para>If the container format is WebP, the video codec must be set to WebP.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Format&quot;:&quot;mp4&quot;}</para>
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public string Container { get; set; }

        /// <summary>
        /// <para>The segment settings. The value must be a JSON object. For more information, see <a href="https://help.aliyun.com/document_detail/29253.html">MuxConfig</a>. If you do not specify this parameter, media segment files are not generated. This parameter is required if you want to generate media segment files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Segment&quot;:{&quot;Duration&quot;:&quot;10&quot;}}</para>
        /// </summary>
        [NameInMap("MuxConfig")]
        [Validation(Required=false)]
        public string MuxConfig { get; set; }

        /// <summary>
        /// <para>The name of the transcoding template. The name can be up to 128 bytes in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mps-example</para>
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
        /// <para>The general transcoding settings. The value must be a JSON object. For more information, see <a href="https://help.aliyun.com/document_detail/29253.html">TransConfig</a>. If you do not specify this parameter, the default settings are used. This parameter is required if the default settings cannot meet your business requirements.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TransMode&quot;:&quot;onepass&quot;}</para>
        /// </summary>
        [NameInMap("TransConfig")]
        [Validation(Required=false)]
        public string TransConfig { get; set; }

        /// <summary>
        /// <para>The video stream settings. The value must be a JSON object. For more information, see <a href="https://help.aliyun.com/document_detail/29253.html">Video</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, output files do not contain video streams. This parameter is required if you want to retain the video streams.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Codec&quot;:&quot;H.264&quot;,&quot;Profile&quot;:&quot;high&quot;,&quot;Bitrate&quot;:&quot;500&quot;,&quot;Crf&quot;:&quot;15&quot;,&quot;Width&quot;:&quot;256&quot;,&quot;Height&quot;:&quot;800&quot;,&quot;Fps&quot;:&quot;25&quot;,&quot;Gop&quot;:&quot;10s&quot;}</para>
        /// </summary>
        [NameInMap("Video")]
        [Validation(Required=false)]
        public string Video { get; set; }

    }

}
