// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIImageJobRequest : TeaModel {
        /// <summary>
        /// <para>The AI task pipeline ID.</para>
        /// <remarks>
        /// <para>A default ID is available, so this parameter is optional. If you need to perform batch imports, use a separate task pipeline. Submit a ticket to request configuration or contact Alibaba Cloud after-sales support for configuration. For more information about how to submit a ticket, see <a href="https://help.aliyun.com/document_detail/464625.html">Contact us</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6492025b8f*****6ba5bb755a33438</para>
        /// </summary>
        [NameInMap("AIPipelineId")]
        [Validation(Required=false)]
        public string AIPipelineId { get; set; }

        /// <summary>
        /// <para>The AI image template ID. You can obtain the template ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>When you create an image template by calling the <a href="https://help.aliyun.com/document_detail/102930.html">AddAITemplate</a> operation, the template ID is the value of the TemplateId parameter in the response.</description></item>
        /// <item><description>After the template is created, you can call the <a href="https://help.aliyun.com/document_detail/102936.html">ListAITemplate</a> operation to query the AI image template ID, which is the value of the TemplateId parameter in the response.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ef1a8842cb9f*****cea80cad902e416</para>
        /// </summary>
        [NameInMap("AITemplateId")]
        [Validation(Required=false)]
        public string AITemplateId { get; set; }

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
        /// <para>The custom settings.</para>
        /// <list type="bullet">
        /// <item><description>The value must be a JSON string.</description></item>
        /// <item><description>The value must contain the MessageCallback or Extend parameter.</description></item>
        /// <item><description>The maximum length is 512 bytes.</description></item>
        /// </list>
        /// <para>For more information about the parameter structure, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Extend&quot;:{&quot;localId&quot;:&quot;****&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The video ID. You can obtain the video ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For videos uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>When you upload a video by calling the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation, the video ID is the value of the VideoId parameter in the response.</description></item>
        /// <item><description>After the video is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the video ID, which is the value of the VideoId parameter in the response.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>357a8748c5774*****89d2726e6436aa</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
