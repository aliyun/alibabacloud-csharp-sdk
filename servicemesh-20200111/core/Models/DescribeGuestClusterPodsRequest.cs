// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGuestClusterPodsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Kubernetes cluster that is added to the ASM instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c49ad2169d5a04f2d89dfc4b6bcu****</para>
        /// </summary>
        [NameInMap("GuestClusterID")]
        [Validation(Required=false)]
        public string GuestClusterID { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c78d60f98fa43403ab6e0701b2678****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
