// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProductsAsAdminRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListProductsAsAdminRequestFilters> Filters { get; set; }
        public class ListProductsAsAdminRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ProductName: performs exact matches by product name. Product names are not case-sensitive.</description></item>
            /// <item><description>FullTextSearch: performs full-text searches by product name, product provider, or product description. Fuzzy match is supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ProductName</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-Create an ECS instance</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the product portfolio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>port-bp1yt7582g****</para>
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// <para>The query scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Local: the products that are created by using the current account. This is the default value.</description></item>
        /// <item><description>Import: the products that are imported from other accounts.</description></item>
        /// <item><description>All: all available products.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Local</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The field that is used to sort the queried data.</para>
        /// <para>Set the value to CreateTime, which specifies the time when the product was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the queried data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: the ascending order</description></item>
        /// <item><description>Desc: the descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
