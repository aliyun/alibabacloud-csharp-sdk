// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitDynamicImageJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the frame animation template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a443dc52ef10abc4794d700*****</para>
        /// </summary>
        [NameInMap("DynamicImageTemplateId")]
        [Validation(Required=false)]
        public string DynamicImageTemplateId { get; set; }

        /// <summary>
        /// <para>The override parameter. Specify the value in the JSON format. For more information, see <a href="https://help.aliyun.com/document_detail/98618.html">Parameters for media processing</a>. You can use this parameter to override configurations in the animated image template. For more information, see the &quot;DynamicImageTemplateConfig: the configurations of an animated sticker template&quot; section of the <a href="https://help.aliyun.com/document_detail/52839.html">Basic data types</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Watermarks&quot;:[{&quot;Content&quot;:&quot;UserID: 666**&quot;,&quot;WatermarkId&quot;:&quot;8ca03c884944bd05efccc312367****&quot;}]}</para>
        /// </summary>
        [NameInMap("OverrideParams")]
        [Validation(Required=false)]
        public string OverrideParams { get; set; }

        /// <summary>
        /// <para>The ID of the video. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD</a> console. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the Video and Audio page, view the ID of the media file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you call to upload media files.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation after you upload media files.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7d2fbc3e273441bdb0e08e55f8****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
