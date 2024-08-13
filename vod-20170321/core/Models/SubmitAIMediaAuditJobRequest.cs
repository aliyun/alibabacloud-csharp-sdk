// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIMediaAuditJobRequest : TeaModel {
        /// <summary>
        /// The configuration information about the review job.
        /// 
        /// *   Other configuration items of the review job. Only the ResourceType field is supported. This field is used to specify the type of media files. You can adjust review standards and rules based on the type of media files.
        /// *   If you want to modify the review standard and rules based on ResourceType, submit a ticket. For more information, see [Contact us](https://help.aliyun.com/document_detail/464625.html).
        /// *   The value of ResourceType can contain only letters, digits, and underscores (_).
        /// </summary>
        [NameInMap("MediaAuditConfiguration")]
        [Validation(Required=false)]
        public string MediaAuditConfiguration { get; set; }

        /// <summary>
        /// The ID of the video file. To obtain the file ID, log on to the [ApsaraVideo VOD console](https://vod.console.aliyun.com) and choose **Review Management** > **Content Moderation** in the left-side navigation pane.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// The type of the media file. Only **video** is supported.
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// The ID of the AI template. You can use one of the following methods to obtain the ID of the AI template:
        /// 
        /// *   Obtain the value of TemplateId from the response to the [AddAITemplate](https://help.aliyun.com/document_detail/102930.html) operation that you call to create an AI template.
        /// *   Obtain the value of TemplateId from the response to the [ListAITemplate](https://help.aliyun.com/document_detail/102936.html) operation that you call to create an AI template.
        /// 
        /// >  If you do not specify an ID, the ID of the default AI template is used.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The custom settings. The value must be a JSON string. You can configure settings such as message callbacks. For more information, see [UserData](https://help.aliyun.com/document_detail/86952.html).
        /// 
        /// >  To use the callback configurations specified by this parameter, you must configure an HTTP callback URL and specify the types of the callback events in the ApsaraVideo VOD console. Otherwise, the callback configurations do not take effect. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see [Configure callback settings](https://help.aliyun.com/document_detail/86071.html).
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
