/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Serverless20210924.Models
{
    public class Application : TeaModel {
        [NameInMap("autoDeploy")]
        [Validation(Required=false)]
        public string AutoDeploy { get; set; }

        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("envVars")]
        [Validation(Required=false)]
        public Dictionary<string, object> EnvVars { get; set; }

        [NameInMap("lastRelease")]
        [Validation(Required=false)]
        public Dictionary<string, object> LastRelease { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("output")]
        [Validation(Required=false)]
        public Dictionary<string, object> Output { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        [NameInMap("repoSource")]
        [Validation(Required=false)]
        public ApplicationRepoSource RepoSource { get; set; }
        public class ApplicationRepoSource : TeaModel {
            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            [NameInMap("repo")]
            [Validation(Required=false)]
            public string Repo { get; set; }

        }

        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        [NameInMap("trigger")]
        [Validation(Required=false)]
        public ApplicationTrigger Trigger { get; set; }
        public class ApplicationTrigger : TeaModel {
            [NameInMap("branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            [NameInMap("commit")]
            [Validation(Required=false)]
            public string Commit { get; set; }

            [NameInMap("on")]
            [Validation(Required=false)]
            public string On { get; set; }

        }

        [NameInMap("updatedTime")]
        [Validation(Required=false)]
        public string UpdatedTime { get; set; }

        [NameInMap("workDir")]
        [Validation(Required=false)]
        public string WorkDir { get; set; }

    }

}
