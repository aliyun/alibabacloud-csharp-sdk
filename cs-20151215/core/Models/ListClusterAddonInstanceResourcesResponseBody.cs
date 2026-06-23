// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ListClusterAddonInstanceResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The Helm release instance information of the component.</para>
        /// </summary>
        [NameInMap("helm_release")]
        [Validation(Required=false)]
        public ListClusterAddonInstanceResourcesResponseBodyHelmRelease HelmRelease { get; set; }
        public class ListClusterAddonInstanceResourcesResponseBodyHelmRelease : TeaModel {
            /// <summary>
            /// <para>The Helm chart name of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-node-problem-detector</para>
            /// </summary>
            [NameInMap("chart_name")]
            [Validation(Required=false)]
            public string ChartName { get; set; }

            /// <summary>
            /// <para>The Helm chart version of the component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.28</para>
            /// </summary>
            [NameInMap("chart_version")]
            [Validation(Required=false)]
            public string ChartVersion { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kube-system</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The name of the Helm release instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ack-node-problem-detector</para>
            /// </summary>
            [NameInMap("release_name")]
            [Validation(Required=false)]
            public string ReleaseName { get; set; }

        }

        /// <summary>
        /// <para>The list of Kubernetes objects contained in the component.</para>
        /// </summary>
        [NameInMap("kubernetes_objects")]
        [Validation(Required=false)]
        public List<ListClusterAddonInstanceResourcesResponseBodyKubernetesObjects> KubernetesObjects { get; set; }
        public class ListClusterAddonInstanceResourcesResponseBodyKubernetesObjects : TeaModel {
            /// <summary>
            /// <para>The Kubernetes API group to which the object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rbac.authorization.k8s.io</para>
            /// </summary>
            [NameInMap("group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The Kubernetes API kind of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClusterRole</para>
            /// </summary>
            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The name of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>terway-pod-reader</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace to which the object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kube-system</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The Kubernetes API version to which the object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
