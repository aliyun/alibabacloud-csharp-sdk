// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListEdgeContainerAppsRequest : TeaModel {
        /// <summary>
        /// <para>The field used for sorting. If this parameter is not specified, no sorting is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Name</b>: the version name.</description></item>
        /// <item><description><b>CreateTime</b>: the version creation time.</description></item>
        /// <item><description><b>ModifyTime</b>: the version modification time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("OrderKey")]
        [Validation(Required=false)]
        public string OrderKey { get; set; }

        /// <summary>
        /// <para>The sort order. If this parameter is not specified, no sorting is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Asc</b>: ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>Desc</b>: descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>. Valid values: <b>1 to 65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>20</b>. Valid values: <b>1 to 500</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ver-1005682639679266816</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The type of fuzzy match. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AppId</b>: the application ID.</description></item>
        /// <item><description><b>Name</b>: the application name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AppId</para>
        /// </summary>
        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

    }

}
