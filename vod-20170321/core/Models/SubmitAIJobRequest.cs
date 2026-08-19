// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIJobRequest : TeaModel {
        /// <summary>
        /// <para>The AI job configuration in JSON format.</para>
        /// <list type="bullet">
        /// <item><description>If <c>Types</c> is set to <c>AIVideoTag</c>, <c>Config</c> supports the <c>AnalyseTypes</c> parameter to specify the analysis algorithm types for the intelligent tagging job. Valid values:<list type="bullet">
        /// <item><description>ASR: speech recognition. Identifies tags from the audio speech in the video.</description></item>
        /// <item><description>OCR: optical character recognition. Identifies tags from the text in the video images.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If <c>Types</c> is set to <c>AIMediaDNA</c>, <c>Config</c> supports the <c>DNADBId</c> parameter to specify the fingerprint library ID for the media fingerprint job.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AIVideoTag&quot;: {&quot;AnalyseTypes&quot;: &quot;ASR&quot;} }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The video ID. You can obtain the video ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For videos uploaded in the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation to obtain the upload URL and credential, the video ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After the video is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the video ID, which is the value of the VideoId response parameter.</description></item>
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
        /// <para>The AI job type. Separate multiple job types with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AIMediaDNA</b>: media fingerprint.</description></item>
        /// <item><description><b>AIVideoTag</b>: intelligent tagging.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AIVideoTag</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

        /// <summary>
        /// <para>The custom settings in JSON format. For more information about the parameter structure, see <a href="~~86952#h2--userdata-div-id-userdata-div-3~~">UserData</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Extend&quot;:{&quot;localId&quot;:&quot;***&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
