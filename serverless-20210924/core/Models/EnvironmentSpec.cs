// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Serverless20210924.Models
{
    public class EnvironmentSpec : TeaModel {
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        [NameInMap("templateVariables")]
        [Validation(Required=false)]
        public Dictionary<string, object> TemplateVariables { get; set; }

        [NameInMap("templateVersion")]
        [Validation(Required=false)]
        public int? TemplateVersion { get; set; }

    }

}
