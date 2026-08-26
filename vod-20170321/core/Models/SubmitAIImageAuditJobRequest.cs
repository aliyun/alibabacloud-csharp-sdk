// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIImageAuditJobRequest : TeaModel {
        [NameInMap("CensorProvider")]
        [Validation(Required=false)]
        public string CensorProvider { get; set; }

        [NameInMap("ImageService")]
        [Validation(Required=false)]
        public string ImageService { get; set; }

        /// <summary>
        /// <para>The review node configuration.</para>
        /// <list type="bullet">
        /// <item><description>Other configuration items of the review node. Currently, only the ResourceType field is supported, which is used to specify the media file type. You can adjust the review standards and rules for the specified type.</description></item>
        /// <item><description>Usage notes for ResourceType: Only letters, digits, and underscores (_) are allowed.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can customize the ResourceType field based on the usage notes. After customization, <a href="https://yida.alibaba-inc.com/o/ticketapply">submit a Yida form</a> to commit to Alibaba Cloud for spooling before the configuration takes effect.</description></item>
        /// <item><description>To adjust the review standards and rules for a specific ResourceType, <a href="https://yida.alibaba-inc.com/o/ticketapply">submit a Yida form</a> to request technical support.</description></item>
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
        /// <para>The image ID.</para>
        /// <para>The unique identifier of the image returned after the image is uploaded to ApsaraVideo VOD.</para>
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

        [NameInMap("ServiceParameters")]
        [Validation(Required=false)]
        public string ServiceParameters { get; set; }

        /// <summary>
        /// <para>The AI template ID. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/102930.html">Add AI template</a> operation to add an AI template. The AI template ID is the value of TemplateId in the response.</description></item>
        /// <item><description>After the AI template is added, call the <a href="https://help.aliyun.com/document_detail/102936.html">Query AI template list</a> operation to query the AI template ID, which is the value of TemplateId in the response.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a07a7f7d7d10eb9fd999e56ecc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
