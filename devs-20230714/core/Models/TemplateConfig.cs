// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class TemplateConfig : TeaModel {
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
