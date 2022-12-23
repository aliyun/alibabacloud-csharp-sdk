// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIMediaAuditJobRequest : TeaModel {
        /// <summary>
        /// The configuration information about the review task.
        /// 
        /// *   Other configuration items of the review task. Only the ResourceType field is supported. This field is used to specify the type of media files. You can adjust review standards and rules based on the type of media files.
        /// *   If you want to adjust review standards and rules based on ResourceType, submit a ticket to request technical support.
        /// *   The value of ResourceType can contain only letters, digits, and underscores (\_).
        /// </summary>
        [NameInMap("MediaAuditConfiguration")]
        [Validation(Required=false)]
        public string MediaAuditConfiguration { get; set; }

        /// <summary>
        /// The ID of the media file.
        /// 
        /// You can obtain the ID of the media file on the Content Moderation page in the ApsaraVideo VOD console.
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
        /// The ID of the AI template. If you do not specify this parameter, the ID of the default AI template for automated review is used.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The custom settings. The value is a JSON string. You can configure settings such as message callbacks. For more information, see [Request parameters](~~86952~~).
        /// 
        /// >  The callback configurations take effect only if you specify the HTTP callback URL and select the specific callback events in the ApsaraVideo VOD console.
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
