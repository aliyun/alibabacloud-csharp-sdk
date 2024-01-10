// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GenerateExecutionPolicyRequest : TeaModel {
        /// <summary>
        /// The RAM role.
        /// </summary>
        [NameInMap("RamRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The content of the template in the JSON or YAML format. This parameter is the same as the Content parameter that you can specify when you call the CreateTemplate operation. You can use this parameter to specify the tasks that you want to run. This way, you do not need to create a template before you start an execution. If you select an existing template, you do not need to specify this parameter.
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// The name of the template.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The version of the template. The default value is the latest version of the template.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
