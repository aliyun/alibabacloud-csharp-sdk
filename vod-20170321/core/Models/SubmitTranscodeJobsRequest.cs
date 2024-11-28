// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitTranscodeJobsRequest : TeaModel {
        /// <summary>
        /// <para>The encryption configurations. The value must be a JSON string. This parameter is required only when you use HLS encryption.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You must set <b>CipherText</b> in <a href="https://help.aliyun.com/document_detail/86952.html">EncrptConfig</a> to the AES_128 cipher text that is obtained from the response to the <a href="https://help.aliyun.com/document_detail/455051.html">GenerateKMSDataKey</a> operation. Otherwise, the HLS encryption fails. For more information about how to use HLS encryption, see <a href="https://help.aliyun.com/document_detail/68612.html">HLS encryption</a>.</para>
        /// </description></item>
        /// <item><description><para>You must select HLS encryption for the template specified by <b>TemplateGroupId</b> no matter you use HLS encryption or Alibaba Cloud proprietary cryptography. Otherwise, the transcoded file is not encrypted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CipherText&quot;:&quot;ZjJmZGViNzUtZWY1Mi00Y2RlLTk3****&quot;, &quot;DecryptKeyUri&quot;:&quot;<a href="http://demo.aliyundoc.com?CipherText=ZjJmZGViNzUtZWY1Mi00Y2RlLTk3****%22,%22KeyServiceType%22:%22KMS%22%7D">http://demo.aliyundoc.com?CipherText=ZjJmZGViNzUtZWY1Mi00Y2RlLTk3****&quot;,&quot;KeyServiceType&quot;:&quot;KMS&quot;}</a></para>
        /// </summary>
        [NameInMap("EncryptConfig")]
        [Validation(Required=false)]
        public string EncryptConfig { get; set; }

        /// <summary>
        /// <para>The override parameter. The value must be a JSON string. You can use this parameter to override the image watermark, text watermark, or subtitle file specified in the transcoding template, or override the encoding format of the subtitle file. For more information about the data structure, see <a href="https://help.aliyun.com/document_detail/98618.html">OverrideParams</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Watermarks&quot;:[{&quot;WatermarkId&quot;:&quot;af2afe4761992c47dae973374****&quot;,&quot;FileUrl&quot;:&quot;<a href="http://developer.aliyundoc.com/image/image.png%22%7D,%7B%22WatermarkId%22:%22e8e5b8038d7ada85b376c2707****%22,%22Content%22:%22watermark">http://developer.aliyundoc.com/image/image.png&quot;},{&quot;WatermarkId&quot;:&quot;e8e5b8038d7ada85b376c2707****&quot;,&quot;Content&quot;:&quot;watermark</a> test&quot;}]}</para>
        /// </summary>
        [NameInMap("OverrideParams")]
        [Validation(Required=false)]
        public string OverrideParams { get; set; }

        /// <summary>
        /// <para>The ID of the queue that you want to use to run the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d3e680e618708erf45fbf2cae7c****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The priority of the transcoding job in all queued jobs.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: <b>1</b> to <b>10</b>.</description></item>
        /// <item><description>A value of <b>10</b> indicates the highest priority.</description></item>
        /// <item><description>Default value: <b>6</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only on the queued transcoding jobs. The priorities of the in-progress transcoding jobs are not affected.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The ID of the transcoding template group that you want to use. To view the template group ID, perform the following operations: Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Processing</b> &gt; <b>Transcoding Template Groups</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e408c803baf658ee637790c5d9f****</para>
        /// </summary>
        [NameInMap("TemplateGroupId")]
        [Validation(Required=false)]
        public string TemplateGroupId { get; set; }

        /// <summary>
        /// <para>The custom settings. The value must be a JSON string. You can configure settings such as message callbacks. For more information, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
        /// <remarks>
        /// <para> To use the callback configurations specified by this parameter, you must configure an HTTP callback URL and specify the types of the callback events in the ApsaraVideo VOD console. Otherwise, the callback configurations do not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Extend&quot;:{&quot;localId&quot;:&quot;****&quot;,&quot;test&quot;:&quot;***&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the video file. You can use one of the following methods to obtain the video ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD</a> console. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the Video and Audio page, view the ID of the video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you call to upload the video.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation after you upload the video.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>142710f878bd42508932f660d7b1****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
