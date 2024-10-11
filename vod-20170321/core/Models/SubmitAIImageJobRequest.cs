// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIImageJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the pipeline that is used for the AI processing job.</para>
        /// <remarks>
        /// <para> This parameter is optional if you specify a default pipeline ID. If you want to use a separate pipeline to submit multiple AI processing jobs., submit a ticket or contact Alibaba Cloud after-sales engineers. For more information about how to submit a ticket, see <a href="https://help.aliyun.com/document_detail/464625.html">Contact us</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6492025b8f*****6ba5bb755a33438</para>
        /// </summary>
        [NameInMap("AIPipelineId")]
        [Validation(Required=false)]
        public string AIPipelineId { get; set; }

        /// <summary>
        /// <para>The ID of the AI template. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Obtain the value of TemplateId from the response to the <a href="https://help.aliyun.com/document_detail/102930.html">AddAITemplate</a> that you call to create the template.</description></item>
        /// <item><description>Obtain the value of TemplateId from the response to the <a href="https://help.aliyun.com/document_detail/102936.html">ListAITemplate</a> operation after you create the template.</description></item>
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
        /// <para>The user data.</para>
        /// <list type="bullet">
        /// <item><description>The value must be a JSON string.</description></item>
        /// <item><description>You must specify the MessageCallback or Extend parameter.</description></item>
        /// <item><description>The value can contain a maximum of 512 bytes.</description></item>
        /// </list>
        /// <para>For more information, see the &quot;UserData: specifies the custom configurations for media upload&quot; section of the <a href="https://help.aliyun.com/document_detail/86952.html">Request parameters</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Extend&quot;:{&quot;localId&quot;:&quot;****&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>The ID of the video. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD</a> console. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the Video and Audio page, view the ID of the video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you call to upload the video.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation after you upload the video.</description></item>
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
