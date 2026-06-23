// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeKubernetesVersionMetadataRequest : TeaModel {
        /// <summary>
        /// <para>The cluster type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Kubernetes</c>: ACK dedicated cluster.</description></item>
        /// <item><description><c>ManagedKubernetes</c>: ACK managed cluster, including ACK Pro cluster, ACK Basic cluster, ACK Serverless Pro cluster, ACK Serverless Basic cluster, ACK Edge Pro cluster, and ACK Edge Basic cluster.</description></item>
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
        /// <para>The cluster version, which is consistent with the Kubernetes community baseline version. We recommend that you select the latest version. If you do not specify this parameter, the latest version is used by default.</para>
        /// <para>For more information about the Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Kubernetes version release overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.32.1-aliyun.1</para>
        /// </summary>
        [NameInMap("KubernetesVersion")]
        [Validation(Required=false)]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// <para>The query mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>supported</c>: queries supported versions.</description></item>
        /// <item><description><c>creatable</c>: queries creatable versions.</description></item>
        /// </list>
        /// <para>If you specify <c>KubernetesVersion</c>, the query mode is ignored.</para>
        /// <para>If you do not specify the query mode, creatable versions are returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supported</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The cluster type for specific scenarios. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Default</c>: non-edge scenario cluster.</description></item>
        /// <item><description><c>Edge</c>: edge scenario cluster.</description></item>
        /// <item><description><c>Serverless</c>: ACK Serverless cluster.</description></item>
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
        /// <para>Specifies whether to query upgradable versions for the specified cluster version. This parameter takes effect only when the KubernetesVersion parameter is specified.</para>
        /// <list type="bullet">
        /// <item><description><para>true: queries upgradable versions.</para>
        /// </description></item>
        /// <item><description><para>false: does not query upgradable versions.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1.30.1-aliyun.1</para>
        /// </summary>
        [NameInMap("QueryUpgradableVersion")]
        [Validation(Required=false)]
        public bool? QueryUpgradableVersion { get; set; }

        /// <summary>
        /// <para>The ID of the region where the cluster is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The runtime type. You can specify the runtime type to filter the system images that are supported by the runtime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>docker</c>: Docker runtime.</description></item>
        /// <item><description><c>containerd</c>: containerd runtime.</description></item>
        /// <item><description><c>Sandboxed-Container.runv</c>: sandboxed container.</description></item>
        /// </list>
        /// <para>If you specify the runtime type, the image versions supported by the specified runtime are returned.</para>
        /// <para>If you do not specify the runtime type, all images are returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>containerd</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

    }

}
