// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// The description of the template.
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the orchestration template.
        /// 
        /// The name must be 1 to 63 characters in length, and can contain digits, letters, and hyphens (-). It cannot start with a hyphen (-).
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The label of the template.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The template content in the YAML format.
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// The type of template. You can set the parameter to a custom value.
        /// 
        /// *   If the parameter is set to `kubernetes`, the template is displayed on the Templates page in the console.
        /// *   If you set the parameter to `compose`, the template is not displayed in the console.
        /// 
        /// We recommend that you set the parameter to `kubernetes`.
        /// 
        /// Default value: `compose`.
        /// </summary>
        [NameInMap("template_type")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
