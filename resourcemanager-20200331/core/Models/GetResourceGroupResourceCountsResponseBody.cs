// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetResourceGroupResourceCountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B34724D-54B0-4A51-B34D-4512372FE1BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The numbers of the resources.</para>
        /// </summary>
        [NameInMap("ResourceCounts")]
        [Validation(Required=false)]
        public List<GetResourceGroupResourceCountsResponseBodyResourceCounts> ResourceCounts { get; set; }
        public class GetResourceGroupResourceCountsResponseBodyResourceCounts : TeaModel {
            /// <summary>
            /// <para>The number of the resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The dimension by which resources are queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ResourceGroupId</para>
            /// </summary>
            [NameInMap("GroupByKey")]
            [Validation(Required=false)]
            public string GroupByKey { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-9gLOoK****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

        }

    }

}
