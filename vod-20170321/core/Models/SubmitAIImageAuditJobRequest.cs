// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIImageAuditJobRequest : TeaModel {
        /// <summary>
        /// The configuration information about the review job.
        /// 
        /// *   Other configuration items of the review job. Only the ResourceType field is supported. This field is used to specify the type of media files. You can adjust review standards and rules based on the type of media files.
        /// *   The value of ResourceType can contain only letters, digits, and underscores (_).
        /// 
        /// > *   You can specify a value for the ResourceType field based on the preceding limits. After you specify a value for the ResourceType field, you must [submit a ticket](https://yida.alibaba-inc.com/o/ticketapply). The value takes effect after Alibaba Cloud processes your ticket.
        /// >*   If you want to change moderation policies and rules based on ResourceType, [submit a ticket](https://yida.alibaba-inc.com/o/ticketapply) to contact technical support.
        /// </summary>
        [NameInMap("MediaAuditConfiguration")]
        [Validation(Required=false)]
        public string MediaAuditConfiguration { get; set; }

        /// <summary>
        /// The ID of the image.
        /// 
        /// The unique ID of the image is returned after the image is uploaded to ApsaraVideo VOD.
        /// 
        /// This parameter is required.
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
        /// The ID of the review template.
        /// 
        /// If you want to use an AI template, you can call the following operations:
        /// 
        /// *   [ListAITemplate](https://help.aliyun.com/document_detail/102936.html)
        /// *   [AddAITemplate](https://help.aliyun.com/document_detail/102930.html)
        /// *   [GetAITemplate](https://help.aliyun.com/document_detail/102933.html)
        /// *   [SetDefaultAITemplate](https://help.aliyun.com/document_detail/102937.html)
        /// 
        /// If you do not specify this parameter, the ID of the default AI template for automated review is used.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
