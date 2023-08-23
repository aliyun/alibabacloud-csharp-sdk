// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateChainRequest : TeaModel {
        /// <summary>
        /// The configuration of the delivery chain in the JSON format.
        /// </summary>
        [NameInMap("ChainConfig")]
        [Validation(Required=false)]
        public string ChainConfig { get; set; }

        /// <summary>
        /// The description of the delivery chain.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the delivery chain.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The name of the repository.
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("RepoNamespaceName")]
        [Validation(Required=false)]
        public string RepoNamespaceName { get; set; }

        /// <summary>
        /// Repositories in which the delivery chain does not take effect.
        /// </summary>
        [NameInMap("ScopeExclude")]
        [Validation(Required=false)]
        public List<string> ScopeExclude { get; set; }

    }

}
