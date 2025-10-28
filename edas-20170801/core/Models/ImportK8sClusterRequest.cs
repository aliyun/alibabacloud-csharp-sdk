// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ImportK8sClusterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACK cluster or serverless Kubernetes cluster. You can obtain the cluster ID by calling the GetK8sCluster operation. For more information, see <a href="https://help.aliyun.com/document_detail/181437.html">GetK8sCluster</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9c28bbb9-****-44b3-b953-54ef8a2d0be2</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the integration with Alibaba Cloud Service Mesh (ASM). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enables the integration with ASM.</description></item>
        /// <item><description>false: Disables the integration with ASM.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAsm")]
        [Validation(Required=false)]
        public bool? EnableAsm { get; set; }

        /// <summary>
        /// <para>You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public int? Mode { get; set; }

        /// <summary>
        /// <para>The ID of the namespace. It is in the format of <c>Region ID:Identifier of the microservices namespace</c>. Example: <c>cn-hangzhou:doc</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:doc</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

    }

}
