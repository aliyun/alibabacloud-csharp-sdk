// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProvisionedProductsRequest : TeaModel {
        /// <summary>
        /// <para>The access filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: queries the product instances that are created by the current requester. This is the default value.</description></item>
        /// <item><description>Account: queries the product instances that belong to the current Alibaba Cloud account.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("AccessLevelFilter")]
        [Validation(Required=false)]
        public string AccessLevelFilter { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListProvisionedProductsRequestFilters> Filters { get; set; }
        public class ListProvisionedProductsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ProvisionedProductName: performs exact matches by product instance name. Product instance names are not case-sensitive.</description></item>
            /// <item><description>FullTextSearch: performs full-text searches by product instance name. Fuzzy match is supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ProvisionedProductName</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-ECS instance</para>
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
        /// <para>The field that is used to sort the queried data.</para>
        /// <para>Set the value to CreateTime, which specifies the time when the product instance was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sorting method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Asc: the ascending order.</description></item>
        /// <item><description>Desc (default): the descending order.</description></item>
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
