// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitDynamicImageJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the animated image template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1a443dc52ef10abc4794d700*****</para>
        /// </summary>
        [NameInMap("DynamicImageTemplateId")]
        [Validation(Required=false)]
        public string DynamicImageTemplateId { get; set; }

        /// <summary>
        /// <para>The override parameters in JSON string format. For more information, see <a href="https://help.aliyun.com/document_detail/98618.html">OverrideParams</a>. You can override the parameters in the animated image template configuration. For more information, see <a href="https://help.aliyun.com/document_detail/52839.html">DynamicImageTemplateConfig</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Watermarks&quot;:[{&quot;Content&quot;:&quot;UserID: 666**&quot;,&quot;WatermarkId&quot;:&quot;8ca03c884944bd05efccc312367****&quot;}]}</para>
        /// </summary>
        [NameInMap("OverrideParams")]
        [Validation(Required=false)]
        public string OverrideParams { get; set; }

        /// <summary>
        /// <para>The video ID. You can obtain the video ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For videos uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Assets</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/55407.html">Obtain the upload URL and credential for a video</a> operation to obtain the upload URL and credential, the video ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After a video is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">Search for media information</a> operation to query the video ID. The video ID is the value of the VideoId response parameter.</description></item>
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
