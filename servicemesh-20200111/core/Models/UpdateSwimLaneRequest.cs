// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateSwimLaneRequest : TeaModel {
        /// <summary>
        /// <para>The name of the lane group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The label key of the associated service workload. Set the value to <c>ASM_TRAFFIC_TAG</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASM_TRAFFIC_TAG</para>
        /// </summary>
        [NameInMap("LabelSelectorKey")]
        [Validation(Required=false)]
        public string LabelSelectorKey { get; set; }

        /// <summary>
        /// <para>The label value of the associated service workload.``</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("LabelSelectorValue")]
        [Validation(Required=false)]
        public string LabelSelectorValue { get; set; }

        /// <summary>
        /// <para>The ID of the Service Mesh (ASM) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

        /// <summary>
        /// <para>A list of services associated with the lane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mocka&quot;,&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mockb&quot;,&quot;sh01/c089443ea9e50403fa4f0a6237d11e0a9/default/mockc&quot;]</para>
        /// </summary>
        [NameInMap("ServicesList")]
        [Validation(Required=false)]
        public string ServicesList { get; set; }

        /// <summary>
        /// <para>The name of the lane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s1</para>
        /// </summary>
        [NameInMap("SwimLaneName")]
        [Validation(Required=false)]
        public string SwimLaneName { get; set; }

    }

}
