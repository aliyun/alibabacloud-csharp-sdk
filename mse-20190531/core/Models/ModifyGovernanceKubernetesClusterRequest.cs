// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ModifyGovernanceKubernetesClusterRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The information about the namespace for which Microservices Engine(MSE) Microservices Governance is enabled.
        /// </summary>
        [NameInMap("NamespaceInfos")]
        [Validation(Required=false)]
        public List<ModifyGovernanceKubernetesClusterRequestNamespaceInfos> NamespaceInfos { get; set; }
        public class ModifyGovernanceKubernetesClusterRequestNamespaceInfos : TeaModel {
            /// <summary>
            /// The microservice namespace. If you do not specify this parameter, Microservice Governance is not enabled for the namespace.
            /// </summary>
            [NameInMap("MseNamespace")]
            [Validation(Required=false)]
            public string MseNamespace { get; set; }

            /// <summary>
            /// The name of the Kubernetes namespace.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The ID of the region in which the instance resides. The region is supported by MSE.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
