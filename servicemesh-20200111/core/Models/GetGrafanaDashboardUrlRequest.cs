// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetGrafanaDashboardUrlRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Container Service for Kubernetes (ACK) or ACK Serverless cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c94ca2d27f7aa47ab84ed73e6f084****</para>
        /// </summary>
        [NameInMap("K8sClusterId")]
        [Validation(Required=false)]
        public string K8sClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the Service Mesh (ASM) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb8963379255149cb98c8686f274x****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>The name of the dashboard.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Cloud ASM Istio Http Gateway</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
