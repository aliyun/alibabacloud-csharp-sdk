// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class ListResourceCategoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListResourceCategoriesResponseBodyData Data { get; set; }
        public class ListResourceCategoriesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The collection of records returned in this request.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListResourceCategoriesResponseBodyDataContent> Content { get; set; }
            public class ListResourceCategoriesResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The applicable product type. If this parameter is empty, all products are matched.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("ProductType")]
                [Validation(Required=false)]
                public string ProductType { get; set; }

                /// <summary>
                /// <para>The resource category ID, which is globally unique.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rc-123***7890</para>
                /// </summary>
                [NameInMap("ResourceCategoryId")]
                [Validation(Required=false)]
                public string ResourceCategoryId { get; set; }

                /// <summary>
                /// <para>The resource name, which is unique within the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>My***ResourceCategory</para>
                /// </summary>
                [NameInMap("ResourceCategoryName")]
                [Validation(Required=false)]
                public string ResourceCategoryName { get; set; }

                /// <summary>
                /// <para>The resource category type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>DEFAULT: default group created by the system, cannot be deleted.</para>
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
                /// <para>The number of resources of each type.</para>
                /// </summary>
                [NameInMap("ResourceCount")]
                [Validation(Required=false)]
                public List<ListResourceCategoriesResponseBodyDataContentResourceCount> ResourceCount { get; set; }
                public class ListResourceCategoriesResponseBodyDataContentResourceCount : TeaModel {
                    /// <summary>
                    /// <para>The number of resources of each type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The resource type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACS::ECS::Instance</para>
                    /// </summary>
                    [NameInMap("ResourceType")]
                    [Validation(Required=false)]
                    public string ResourceType { get; set; }

                }

                /// <summary>
                /// <para>The resource matcher. If this parameter is empty, no resources are matched.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;type\&quot;:\&quot;BOOL\&quot;,\&quot;operator\&quot;:\&quot;AND\&quot;,\&quot;values\&quot;:[{\&quot;type\&quot;:\&quot;TAG\&quot;,\&quot;key\&quot;:\&quot;createdBy\&quot;,\&quot;operator\&quot;:\&quot;EQUAL\&quot;,\&quot;values\&quot;:[\&quot;me\&quot;]}]}</para>
                /// </summary>
                [NameInMap("ResourceMatcher")]
                [Validation(Required=false)]
                public string ResourceMatcher { get; set; }

                /// <summary>
                /// <para>The applicable resource type. If this parameter is empty, all resources are matched.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::ECS::Instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of records returned in this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>Indicates the position where the current call returns data from. An empty value indicates that all data has been read.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eKDyCM0zFQ5op7jVMWmNNA==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of data entries under the current request conditions. This parameter is optional and can be left unspecified by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

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
