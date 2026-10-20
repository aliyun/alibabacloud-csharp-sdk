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
        /// <item><description><c>ManagedKubernetes</c>: ACK managed cluster, including ACK Pro clusters, ACK basic clusters, ACK Serverless Pro clusters, ACK Serverless basic clusters, ACK Edge Pro clusters, and ACK Edge basic clusters.</description></item>
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
        /// <para>The Kubernetes version of the cluster. This version is consistent with the Kubernetes community baseline version. We recommend that you select the latest version. If you do not specify this parameter, the latest version is used by default.</para>
        /// <para>For more information about the Kubernetes versions supported by ACK, see <a href="https://help.aliyun.com/document_detail/185269.html">Overview of Kubernetes versions</a>.</para>
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
        /// <item><description><c>supported</c>: Supported versions.</description></item>
        /// <item><description><c>creatable</c>: Versions available for cluster creation.</description></item>
        /// </list>
        /// <para>If you specify KubernetesVersion, the system ignores the query mode.</para>
        /// <para>If you do not specify a query mode, the system returns versions available for cluster creation by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>supported</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The cluster profile. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>Default</c>: cluster for non-edge scenarios.</description></item>
        /// <item><description><c>Edge</c>: cluster for edge scenarios.</description></item>
        /// <item><description><c>Serverless</c>: ASK cluster.</description></item>
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
        /// <para>Specifies whether to query the upgradable versions of the cluster version. This parameter takes effect only when the KubernetesVersion parameter is specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Queries upgradable versions.</description></item>
        /// <item><description>false: Does not query upgradable versions.</description></item>
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
        /// <para>The runtime type. You can specify a runtime type to filter system images supported by the runtime. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>docker</c>: Docker runtime.</description></item>
        /// <item><description><c>containerd</c>: containerd runtime.</description></item>
        /// <item><description><c>Sandboxed-Container.runv</c>: sandboxed container.</description></item>
        /// </list>
        /// <para>If you specify a runtime type, the system returns the image versions supported by the specified runtime.</para>
        /// <para>If you do not specify a runtime type, the system returns all images by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>containerd</para>
        /// </summary>
        [NameInMap("runtime")]
        [Validation(Required=false)]
        public string Runtime { get; set; }

    }

}
