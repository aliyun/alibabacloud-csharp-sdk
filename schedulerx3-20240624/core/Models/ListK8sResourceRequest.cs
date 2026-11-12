// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class ListK8sResourceRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the Kubernetes cluster for which namespaces are synchronized. The Kubernetes cluster is added to the service mesh specified by ServiceMeshId. This parameter is required when you query Kubernetes namespaces or services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cadb451ed7af04b0297f4be396a2196fc</para>
        /// </summary>
        [NameInMap("K8sClusterId")]
        [Validation(Required=false)]
        public string K8sClusterId { get; set; }

        /// <summary>
        /// <para>The namespace ID of the Kubernetes cluster. This parameter is required when you query Kubernetes services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("K8sNamespace")]
        [Validation(Required=false)]
        public string K8sNamespace { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The VPC ID. This parameter is required when ResourceType is set to cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-aa1a18236n90rqhuhhnhh</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
