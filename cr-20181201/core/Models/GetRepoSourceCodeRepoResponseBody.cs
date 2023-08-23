// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetRepoSourceCodeRepoResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether image building is automatically triggered when source code is committed. Valid values:
        /// 
        /// *   `true`: Image building is automatically triggered when source code is committed.
        /// *   `false`: Image building is not triggered when source code is committed.
        /// </summary>
        [NameInMap("AutoBuild")]
        [Validation(Required=false)]
        public string AutoBuild { get; set; }

        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The address of the source code repository.
        /// </summary>
        [NameInMap("CodeRepoDomain")]
        [Validation(Required=false)]
        public string CodeRepoDomain { get; set; }

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
        /// The type of the code hosting platform. Valid values: `GITHUB`, `GITLAB`, `GITEE`, `CODE`, and `CODEUP`.
        /// </summary>
        [NameInMap("CodeRepoType")]
        [Validation(Required=false)]
        public string CodeRepoType { get; set; }

        /// <summary>
        /// Indicates whether build cache is disabled. Valid values:
        /// 
        /// *   `true`: Build cache is disabled.
        /// *   `false`: Build cache is enabled.
        /// </summary>
        [NameInMap("DisableCacheBuild")]
        [Validation(Required=false)]
        public string DisableCacheBuild { get; set; }

        /// <summary>
        /// Indicates whether the API call is successful. Valid values:
        /// 
        /// *   `true`: successful
        /// *   `false`: failed
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// Indicates whether image building is accelerated for servers outside the Chinese mainland. Valid values:
        /// 
        /// *   `true`: Image building is accelerated for servers outside the Chinese mainland.
        /// *   `false`: Image building is not accelerated for servers outside the Chinese mainland.
        /// </summary>
        [NameInMap("OverseaBuild")]
        [Validation(Required=false)]
        public string OverseaBuild { get; set; }

        /// <summary>
        /// The ID of the repository.
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
