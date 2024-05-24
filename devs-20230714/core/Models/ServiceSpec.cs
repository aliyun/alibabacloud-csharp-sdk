// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ServiceSpec : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("templateVariables")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateVariables { get; set; }

        [NameInMap("templateVersion")]
        [Validation(Required=false)]
        public int? TemplateVersion { get; set; }

    }

}
