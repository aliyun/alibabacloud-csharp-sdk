// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDefaultAITemplateRequest : TeaModel {
        /// <summary>
        /// The type of the AI template. Set the value to **AIMediaAudit**, which specifies the automated review.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
