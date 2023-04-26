// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVodTemplateRequest : TeaModel {
        /// <summary>
        /// Indicates whether the template is the default one. Valid values:
        /// 
        /// *   **Default**: The template is the default one.
        /// *   **NotDefault**: The template is not the default one.
        /// </summary>
        [NameInMap("VodTemplateId")]
        [Validation(Required=false)]
        public string VodTemplateId { get; set; }

    }

}
