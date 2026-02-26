// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetResourceCountsRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<GetResourceCountsRequestFilter> Filter { get; set; }
        public class GetResourceCountsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition. For information about valid values, see the &quot;<c>Supported filter parameters</c>&quot; section below.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The matching method.</para>
            /// <para>Set this parameter to <c>Equals</c>, which means an equal match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Equals</para>
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// <para>The values of the filter condition.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The dimension by which the queried resources are grouped. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ResourceType: The resource type.</para>
        /// </description></item>
        /// <item><description><para>RegionId: The region.</para>
        /// </description></item>
        /// <item><description><para>ResourceGroupId: The resource group ID.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceType</para>
        /// </summary>
        [NameInMap("GroupByKey")]
        [Validation(Required=false)]
        public string GroupByKey { get; set; }

        /// <summary>
        /// <para>Specifies whether to include deleted resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeDeletedResources")]
        [Validation(Required=false)]
        public bool? IncludeDeletedResources { get; set; }

        /// <summary>
        /// <para>The search keyword. Resource Center filters the search results based on relevance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>keywords</para>
        /// </summary>
        [NameInMap("SearchExpression")]
        [Validation(Required=false)]
        public string SearchExpression { get; set; }

    }

}
