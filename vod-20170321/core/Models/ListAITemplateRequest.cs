// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAITemplateRequest : TeaModel {
        /// <summary>
        /// Indicates whether the template is the default AI template. Valid values:
        /// 
        /// *   **Default**
        /// *   **NotDefault**
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
