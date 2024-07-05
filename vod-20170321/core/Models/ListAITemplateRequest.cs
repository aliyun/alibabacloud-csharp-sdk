// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAITemplateRequest : TeaModel {
        /// <summary>
        /// The type of the AI template. Valid values:
        /// 
        /// *   **AIMediaAudit**: automated review
        /// *   **AIImage**: smart thumbnail
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
