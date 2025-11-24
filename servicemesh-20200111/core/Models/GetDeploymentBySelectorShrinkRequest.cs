// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetDeploymentBySelectorShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cbe80a56d07ed45818b4d39273e23****</para>
        /// </summary>
        [NameInMap("GuestCluster")]
        [Validation(Required=false)]
        public string GuestCluster { get; set; }

        /// <summary>
        /// <para>The label selector information.</para>
        /// </summary>
        [NameInMap("LabelSelector")]
        [Validation(Required=false)]
        public string LabelSelectorShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of returned data entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>The marker of data queried last time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJ2IjoibWV0YS5rOHMuaW8vdjEiLCJydiI6NzgxODk3MCwic3RhcnQiOiJuZ2lueDQ1N1x1MDAw****</para>
        /// </summary>
        [NameInMap("Mark")]
        [Validation(Required=false)]
        public string Mark { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("NameSpace")]
        [Validation(Required=false)]
        public string NameSpace { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud Service Mesh (ASM) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ce9fc65def2aa4c918747b9360fbd****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
