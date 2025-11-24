// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGuestClusterNamespacesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Kubernetes cluster that is added to the ASM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c584d805c7bd442b8bac421f9849f****</para>
        /// </summary>
        [NameInMap("GuestClusterID")]
        [Validation(Required=false)]
        public string GuestClusterID { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce134b0727aa2492db69f6c3880e****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the labels of the namespaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowNsLabels")]
        [Validation(Required=false)]
        public bool? ShowNsLabels { get; set; }

    }

}
