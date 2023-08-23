// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateNamespaceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically create a repository when an image is pushed to the namespace.
        /// </summary>
        [NameInMap("AutoCreateRepo")]
        [Validation(Required=false)]
        public bool? AutoCreateRepo { get; set; }

        /// <summary>
        /// The default type of the repository. Valid values:
        /// 
        /// *   `PUBLIC`: The repository is a public repository.
        /// *   `PRIVATE`: The repository is a private repository.
        /// </summary>
        [NameInMap("DefaultRepoType")]
        [Validation(Required=false)]
        public string DefaultRepoType { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

    }

}
