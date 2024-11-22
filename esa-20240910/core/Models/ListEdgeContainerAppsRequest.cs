// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListEdgeContainerAppsRequest : TeaModel {
        /// <summary>
        /// <para>The sorting field. This parameter is left empty by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Name: the version name.</description></item>
        /// <item><description>CreateTime: the time when the version was created.</description></item>
        /// <item><description>UpdateTime: the time when the version was last modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTime</para>
        /// </summary>
        [NameInMap("OrderKey")]
        [Validation(Required=false)]
        public string OrderKey { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the query results. This parameter is left empty by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: in ascending order.</description></item>
        /// <item><description>DESC: in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Asc</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>. Valid values: 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>20</b>. Valid values: 1 to 500.</para>
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
        /// <para>The search criterion based on which you want to perform fuzzy search. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Appid: the application ID.</description></item>
        /// <item><description>Name: the application name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Appid</para>
        /// </summary>
        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

    }

}
