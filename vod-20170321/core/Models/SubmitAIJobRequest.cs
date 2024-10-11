// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIJobRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the AI job. The value is a JSON string.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <c>Types</c> to <c>AIVideoTag</c>, you can specify <c>AnalyseTypes</c> for <c>Config</c> to set the analysis algorithm of a smart tagging job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASR: automatic speech recognition (ASR)</description></item>
        /// <item><description>OCR: image optical character recognition (OCR)</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you set <c>Types</c> to <c>AIMediaDNA</c>, you can specify <c>DNADBId</c> for <c>Config</c> to set the ID of the media fingerprint library for video fingerprinting jobs.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AIVideoTag&quot;: {&quot;AnalyseTypes&quot;: &quot;Face,ASR&quot;} }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The ID of the video. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD</a> console. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the Video and Audio page, view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you call to upload media files.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation after you upload media files.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3D3D12340d9401fab46a0b847****</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of the AI job. Separate multiple types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AIMediaDNA</b>: The media fingerprinting job.</description></item>
        /// <item><description><b>AIVideoTag</b>: The smart tagging job.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AIVideoTag</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

        /// <summary>
        /// <para>The custom settings. The value is a JSON string. For more information, see <a href="~~86952#h2--userdata-div-id-userdata-div-3~~">Request parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Extend&quot;:{&quot;localId&quot;:&quot;***&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
