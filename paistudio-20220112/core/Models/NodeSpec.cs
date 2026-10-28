// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeSpec : TeaModel {
        /// <summary>
        /// <para>The resource node binding policy.</para>
        /// </summary>
        [NameInMap("BindingPolicy")]
        [Validation(Required=false)]
        public BindingPolicy BindingPolicy { get; set; }

        /// <summary>
        /// <para>The number of resource node specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The supernode specifications in use. When you specify a specification, you cannot specify both the node specifications and the supernode at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>efg3.GN9A.ch72</para>
        /// </summary>
        [NameInMap("HyperType")]
        [Validation(Required=false)]
        public string HyperType { get; set; }

        /// <summary>
        /// <para>The resource node specifications type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.4xlarge</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
