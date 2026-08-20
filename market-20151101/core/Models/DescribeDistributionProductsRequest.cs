// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeDistributionProductsRequest : TeaModel {
        /// <summary>
        /// <para>The list of filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeDistributionProductsRequestFilter> Filter { get; set; }
        public class DescribeDistributionProductsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The search label category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>code: the commodity code of the promotional product</description></item>
            /// <item><description>name: the name of the promotional product</description></item>
            /// <item><description>supplierName: the name of the promotion service provider.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>supplierName</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The search tag value:</para>
            /// <list type="bullet">
            /// <item><description>code: the product code to search for</description></item>
            /// <item><description>name: the product name to search for</description></item>
            /// <item><description>supplierName: the supplier name to search for.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cmj0000000</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of promotional products per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
