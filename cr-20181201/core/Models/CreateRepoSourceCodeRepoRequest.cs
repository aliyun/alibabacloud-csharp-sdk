// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoSourceCodeRepoRequest : TeaModel {
        /// <summary>
        /// Specifies whether to trigger image building when source code is committed. Valid values:
        /// 
        /// *   `true`: triggers image building when source code is committed.
        /// *   `false`: does not trigger image building when source code is committed.
        /// </summary>
        [NameInMap("AutoBuild")]
        [Validation(Required=false)]
        public bool? AutoBuild { get; set; }

        /// <summary>
        /// The name of the source code repository.
        /// </summary>
        [NameInMap("CodeRepoName")]
        [Validation(Required=false)]
        public string CodeRepoName { get; set; }

        /// <summary>
        /// The namespace to which the source code repository belongs.
        /// </summary>
        [NameInMap("CodeRepoNamespaceName")]
        [Validation(Required=false)]
        public string CodeRepoNamespaceName { get; set; }

        /// <summary>
        /// The type of the source code hosting platform. Valid values: `GITHUB`, `GITLAB`, `GITEE`, `CODE`, and `CODEUP`.
        /// </summary>
        [NameInMap("CodeRepoType")]
        [Validation(Required=false)]
        public string CodeRepoType { get; set; }

        /// <summary>
        /// Specifies whether to disable building caches. Valid values:
        /// 
        /// *   `true`: disables building caches.
        /// *   `false`: enables building caches.
        /// </summary>
        [NameInMap("DisableCacheBuild")]
        [Validation(Required=false)]
        public bool? DisableCacheBuild { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to enable Build With Servers Deployed Outside Chinese Mainland. Valid values:
        /// 
        /// *   `true`: enables Build With Servers Deployed Outside Chinese Mainland.
        /// *   `false`: does not enable Build With Servers Deployed Outside Chinese Mainland.
        /// </summary>
        [NameInMap("OverseaBuild")]
        [Validation(Required=false)]
        public bool? OverseaBuild { get; set; }

        /// <summary>
        /// The ID of the image repository.
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

    }

}
