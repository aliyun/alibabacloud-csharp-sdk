// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeSpec : TeaModel {
        /// <summary>
        /// <para>Rule for attaching resource nodes.</para>
        /// </summary>
        [NameInMap("BindingPolicy")]
        [Validation(Required=false)]
        public BindingPolicy BindingPolicy { get; set; }

        /// <summary>
        /// <para>Number of resource nodes with this specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>Type of supernode to use. You cannot specify both a node specification and a supernode type.</para>
        /// </summary>
        [NameInMap("HyperType")]
        [Validation(Required=false)]
        public string HyperType { get; set; }

        /// <summary>
        /// <para>Type of the resource node specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.4xlarge</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
