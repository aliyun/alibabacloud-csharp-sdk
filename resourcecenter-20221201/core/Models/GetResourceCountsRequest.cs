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
            /// <para>The key of the filter condition. For more information, see <c>Supported filter parameters</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RegionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The matching mode.</para>
            /// <para>The value Equals indicates an equal match.</para>
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
        /// <para>The dimension by which resources are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ResourceType</description></item>
        /// <item><description>Region</description></item>
        /// <item><description>ResourceGroupId</description></item>
        /// <item><description>TagKey</description></item>
        /// <item><description>TagValue</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ResourceType</para>
        /// </summary>
        [NameInMap("GroupByKey")]
        [Validation(Required=false)]
        public string GroupByKey { get; set; }

        [NameInMap("IncludeDeletedResources")]
        [Validation(Required=false)]
        public bool? IncludeDeletedResources { get; set; }

        [NameInMap("SearchExpression")]
        [Validation(Required=false)]
        public string SearchExpression { get; set; }

    }

}
