// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeKubernetesVersionMetadataRequest : TeaModel {
        /// <summary>
        /// <para>The cluster type that you want to use. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Kubernetes</c>: ACK dedicated cluster.</description></item>
        /// <item><description><c>ManagedKubernetes</c>: ACK managed cluster. ACK managed clusters include ACK Pro clusters, ACK Basic clusters, ACK Serverless Pro clusters, ACK Serverless Basic clusters, ACK Edge Pro clusters, and ACK Edge Basic clusters.</description></item>
        /// <item><description><c>ExternalKubernetes</c>: registered cluster.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Kubernetes</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The Kubernetes version of the cluster. The Kubernetes versions supported by ACK are the same as the Kubernetes versions supported by open source Kubernetes. We recommend that you specify the latest Kubernetes version. If you do not set this parameter, the latest Kubernetes version is used.</para>
        /// <para>You can create ACK clusters of the latest two Kubernetes versions in the ACK console. You can call the specific ACK API operation to create clusters of other Kubernetes versions. For more information about the Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Release notes for Kubernetes versions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.16.9-aliyun.1</para>
        /// </summary>
        [NameInMap("KubernetesVersion")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>The query mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>supported</c>: queries all supported versions.</description></item>
        /// <item><description><c>creatable</c>: queries only versions that allow you to create clusters.</description></item>
        /// </list>
        /// <para>If you specify <c>KubernetesVersion</c>, this parameter does not take effect.</para>
        /// <para>Default value: creatable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supported</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The scenario where clusters are used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Default</c>: non-edge computing scenarios</description></item>
        /// <item><description><c>Edge</c>: edge computing scenarios</description></item>
        /// <item><description><c>Serverless</c>: serverless scenarios.</description></item>
        /// </list>
        /// <para>Default value: <c>Default</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Default</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        /// <summary>
        /// <para>Specify whether to query the Kubernetes versions available for updates. This parameter takes effect only when the KubernetesVersion parameter is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.30.1-aliyun.1</para>
        /// </summary>
        [NameInMap("QueryUpgradableVersion")]
        [Validation(Required=false)]
        public bool? QueryUpgradableVersion { get; set; }

        /// <summary>
        /// <para>The region ID of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The container runtime type that you want to use. You can specify a runtime type to query only OS images that support the runtime type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>docker</c>: Docker</description></item>
        /// <item><description><c>containerd</c>: containerd</description></item>
        /// <item><description><c>Sandboxed-Container.runv</c>: Sandboxed-Container</description></item>
        /// </list>
        /// <para>If you specify a runtime type, only the OS images that support the specified runtime type are returned.</para>
        /// <para>Otherwise, all OS images are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>docker</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

    }

}
