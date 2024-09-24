// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeKubernetesVersionMetadataRequest : TeaModel {
        /// <summary>
        /// The cluster type that you want to use. Valid values:
        /// 
        /// *   `Kubernetes`: ACK dedicated cluster.
        /// *   `ManagedKubernetes`: ACK managed cluster. ACK managed clusters include ACK Pro clusters, ACK Basic clusters, ACK Serverless Pro clusters, ACK Serverless Basic clusters, ACK Edge Pro clusters, and ACK Edge Basic clusters.
        /// *   `ExternalKubernetes`: registered cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// The Kubernetes version of the cluster. The Kubernetes versions supported by ACK are the same as the Kubernetes versions supported by open source Kubernetes. We recommend that you specify the latest Kubernetes version. If you do not set this parameter, the latest Kubernetes version is used.
        /// 
        /// You can create ACK clusters of the latest two Kubernetes versions in the ACK console. You can call the specific ACK API operation to create clusters of other Kubernetes versions. For more information about the Kubernetes versions supported by ACK, see [Release notes for Kubernetes versions](https://help.aliyun.com/document_detail/185269.html).
        /// </summary>
        [NameInMap("KubernetesVersion")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// The query mode. Valid values:
        /// 
        /// *   `supported`: queries all supported versions.
        /// *   `creatable`: queries only versions that allow you to create clusters.
        /// 
        /// If you specify `KubernetesVersion`, this parameter does not take effect.
        /// 
        /// Default value: creatable.
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// The scenario where clusters are used. Valid values:
        /// 
        /// *   `Default`: non-edge computing scenarios
        /// *   `Edge`: edge computing scenarios
        /// *   `Serverless`: serverless scenarios.
        /// 
        /// Default value: `Default`.
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// Specify whether to query the Kubernetes versions available for updates. This parameter takes effect only when the KubernetesVersion parameter is specified.
        /// </summary>
        [NameInMap("QueryUpgradableVersion")]
        [Validation(Required=false)]
        public bool? QueryUpgradableVersion { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The container runtime type that you want to use. You can specify a runtime type to query only OS images that support the runtime type. Valid values:
        /// 
        /// *   `docker`: Docker
        /// *   `containerd`: containerd
        /// *   `Sandboxed-Container.runv`: Sandboxed-Container
        /// 
        /// If you specify a runtime type, only the OS images that support the specified runtime type are returned.
        /// 
        /// Otherwise, all OS images are returned.
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

    }

}
