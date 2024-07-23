// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The transmuxing configurations. The value is a JSON object. For more information, see the <a href="https://help.aliyun.com/document_detail/29253.html">MuxConfig</a> parameter of the &quot;Parameter details&quot; topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Codec&quot;:&quot;aac&quot;,&quot;Samplerate&quot;:&quot;44100&quot;,&quot;Bitrate&quot;:&quot;500&quot;,&quot;Channels&quot;:&quot;2&quot;}</para>
        /// </summary>
        [NameInMap("Audio")]
        [Validation(Required=false)]
        public string Audio { get; set; }

        /// <summary>
        /// <para>The configurations of the video stream. The value is a JSON object. For more information, see the <a href="https://help.aliyun.com/document_detail/29253.html">Video</a> parameter of the &quot;Parameter details&quot; topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Format&quot;:&quot;mp4&quot;}</para>
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public string Container { get; set; }

        /// <summary>
        /// <para>The general transcoding configurations. The value is a JSON object. For more information, see the <a href="https://help.aliyun.com/document_detail/29253.html">TransConfig</a> parameter of the &quot;Parameter details&quot; topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Segment&quot;:{&quot;Duration&quot;:&quot;10&quot;}}</para>
        /// </summary>
        [NameInMap("MuxConfig")]
        [Validation(Required=false)]
        public string MuxConfig { get; set; }

        /// <summary>
        /// <para>The container format. The value is a JSON object. Default format: <b>MP4</b>.</para>
        /// <list type="bullet">
        /// <item><description>Video formats: FLV, MP4, HLS (M3U8 + TS), and MPEG-DASH (MPD + fMP4)</description></item>
        /// <item><description>Audio formats: MP3, MP4, OGG, FLAC, and M4A</description></item>
        /// <item><description>Images formats: GIF and WebP</description></item>
        /// </list>
        /// <para>For more information, see the <a href="https://help.aliyun.com/document_detail/29253.html">Container</a> parameter of the &quot;Parameter details&quot; topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MPS-example</para>
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
        /// <para>The name of the template. The name can be up to 128 bytes in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16f01ad6175e4230ac42bb5182cd****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;TransMode&quot;:&quot;onepass&quot;}</para>
        /// </summary>
        [NameInMap("TransConfig")]
        [Validation(Required=false)]
        public string TransConfig { get; set; }

        /// <summary>
        /// <para>The configurations of the audio stream. The value is a JSON object. For more information, see the <a href="https://help.aliyun.com/document_detail/29253.html">Audio</a> parameter of the &quot;Parameter details&quot; topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Codec&quot;:&quot;H.264&quot;,&quot;Profile&quot;:&quot;high&quot;,&quot;Bitrate&quot;:&quot;500&quot;,&quot;Crf&quot;:&quot;15&quot;,&quot;Width&quot;:&quot;256&quot;,&quot;Height&quot;:&quot;800&quot;,&quot;Fps&quot;:&quot;25&quot;,&quot;Gop&quot;:&quot;10&quot;}</para>
        /// </summary>
        [NameInMap("Video")]
        [Validation(Required=false)]
        public string Video { get; set; }

    }

}
