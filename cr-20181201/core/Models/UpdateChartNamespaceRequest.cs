// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateChartNamespaceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically create repositories in the namespace. Valid values:
        /// 
        /// *   `true`: automatically creates repositories in the namespace.
        /// *   `false`: does not automatically create repositories in the namespace.
        /// </summary>
        [NameInMap("AutoCreateRepo")]
        [Validation(Required=false)]
        public bool? AutoCreateRepo { get; set; }

        /// <summary>
        /// The default type of the repository. Valid values:
        /// 
        /// *   `PUBLIC`: a public repository
        /// *   `PRIVATE`: a private repository
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
        /// The name of the namespace to which the repository belongs.
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

    }

}
