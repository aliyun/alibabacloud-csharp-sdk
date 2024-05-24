// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ProjectSpec : TeaModel {
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("templateConfig")]
        [Validation(Required=false)]
        public TemplateConfig TemplateConfig { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

    }

}
