// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListEdgeContainerAppVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The application ID, which can be obtained by calling the <a href="~~ListEdgeContainerApps~~">ListEdgeContainerApps</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>app-88068867578379****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The sorting field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Name: the version name.</description></item>
        /// <item><description>CreateTime: the time when the version was created.</description></item>
        /// <item><description>UpdateTime: the time when the version was last modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Name</para>
        /// </summary>
        [NameInMap("OrderKey")]
        [Validation(Required=false)]
        public string OrderKey { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: in ascending order.</description></item>
        /// <item><description>DESC: in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The keyword used for the search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ver-100568263967926****</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The parameter used for fuzzy search. Valid values: VersionId and Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VersionId</para>
        /// </summary>
        [NameInMap("SearchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

    }

}
