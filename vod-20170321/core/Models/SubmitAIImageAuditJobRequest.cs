// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIImageAuditJobRequest : TeaModel {
        /// <summary>
        /// <para>The configuration information about the review job.</para>
        /// <list type="bullet">
        /// <item><description>Other configuration items of the review job. Only the ResourceType field is supported. This field is used to specify the type of media files. You can adjust review standards and rules based on the type of media files.</description></item>
        /// <item><description>The value of ResourceType can contain only letters, digits, and underscores (_).</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can specify a value for the ResourceType field based on the preceding limits. After you specify a value for the ResourceType field, you must <a href="https://yida.alibaba-inc.com/o/ticketapply">submit a ticket</a>. The value takes effect after Alibaba Cloud processes your ticket.</description></item>
        /// <item><description>If you want to change moderation policies and rules based on ResourceType, <a href="https://yida.alibaba-inc.com/o/ticketapply">submit a ticket</a> to contact technical support.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ResourceType&quot;:&quot;****_short_video&quot;}</para>
        /// </summary>
        [NameInMap("MediaAuditConfiguration")]
        [Validation(Required=false)]
        public string MediaAuditConfiguration { get; set; }

        /// <summary>
        /// <para>The ID of the image.</para>
        /// <para>The unique ID of the image is returned after the image is uploaded to ApsaraVideo VOD.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1aa3024aee64*****6dc8ca20dbc320</para>
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
        /// <para>The ID of the AI template. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Obtain the value of TemplateId from the response to the <a href="https://help.aliyun.com/document_detail/102930.html">AddAITemplate</a> operation that you call to create an AI template.</description></item>
        /// <item><description>Obtain the value of TemplateId from the response to the <a href="https://help.aliyun.com/document_detail/102936.html">ListAITemplate</a> operation that you call to create an AI template.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VOD-0003-00****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
