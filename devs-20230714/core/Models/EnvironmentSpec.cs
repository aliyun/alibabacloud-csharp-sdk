// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class EnvironmentSpec : TeaModel {
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("infraStackConfig")]
        [Validation(Required=false)]
        public InfraStackSpec InfraStackConfig { get; set; }

        [NameInMap("isAutoDeploy")]
        [Validation(Required=false)]
        public bool? IsAutoDeploy { get; set; }

        [NameInMap("repositoryConfig")]
        [Validation(Required=false)]
        public RepositoryConfig RepositoryConfig { get; set; }

        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("serviceOverlay")]
        [Validation(Required=false)]
        public EnvironmentSpecServiceOverlay ServiceOverlay { get; set; }
        public class EnvironmentSpecServiceOverlay : TeaModel {
            [NameInMap("components")]
            [Validation(Required=false)]
            public Dictionary<string, object> Components { get; set; }

            [NameInMap("resources")]
            [Validation(Required=false)]
            public Dictionary<string, object> Resources { get; set; }

        }

        [NameInMap("templateConfig")]
        [Validation(Required=false)]
        public TemplateConfig TemplateConfig { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
