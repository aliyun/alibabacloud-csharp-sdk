// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class GetResourceCategoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetResourceCategoryResponseBodyData Data { get; set; }
        public class GetResourceCategoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Applicable product type. If empty, matches all products.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("ProductType")]
            [Validation(Required=false)]
            public string ProductType { get; set; }

            /// <summary>
            /// <para>Resource category ID, globally unique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rc-123***7890</para>
            /// </summary>
            [NameInMap("ResourceCategoryId")]
            [Validation(Required=false)]
            public string ResourceCategoryId { get; set; }

            /// <summary>
            /// <para>Resource name, unique within the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>My***ResourceCategory</para>
            /// </summary>
            [NameInMap("ResourceCategoryName")]
            [Validation(Required=false)]
            public string ResourceCategoryName { get; set; }

            /// <summary>
            /// <para>Resource category type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>DEFAULT: default group, created by the system, cannot be deleted.</para>
            /// </description></item>
            /// <item><description><para>CUSTOM: custom group, can be deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("ResourceCategoryType")]
            [Validation(Required=false)]
            public string ResourceCategoryType { get; set; }

            /// <summary>
            /// <para>Number of resources by type.</para>
            /// </summary>
            [NameInMap("ResourceCount")]
            [Validation(Required=false)]
            public List<GetResourceCategoryResponseBodyDataResourceCount> ResourceCount { get; set; }
            public class GetResourceCategoryResponseBodyDataResourceCount : TeaModel {
                /// <summary>
                /// <para>Number of resources by type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::ECS::Instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>Resource matcher. If empty, no resources are matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;type\&quot;:\&quot;BOOL\&quot;,\&quot;operator\&quot;:\&quot;AND\&quot;,\&quot;values\&quot;:[{\&quot;type\&quot;:\&quot;TAG\&quot;,\&quot;key\&quot;:\&quot;createdBy\&quot;,\&quot;operator\&quot;:\&quot;EQUAL\&quot;,\&quot;values\&quot;:[\&quot;me\&quot;]}]}</para>
            /// </summary>
            [NameInMap("ResourceMatcher")]
            [Validation(Required=false)]
            public string ResourceMatcher { get; set; }

            /// <summary>
            /// <para>Applicable resource type. If empty, matches all resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS::ECS::Instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AE43C4CB-8074-5EBD-9806-8CA6D12800B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
