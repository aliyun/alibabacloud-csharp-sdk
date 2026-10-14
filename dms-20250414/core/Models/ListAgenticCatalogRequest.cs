// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListAgenticCatalogRequest : TeaModel {
        /// <summary>
        /// <para>The catalog type. This parameter is used to filter catalogs by exact type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>JDBC</b>: relational database catalog</description></item>
        /// <item><description><b>DataLake</b>: data lake catalog</description></item>
        /// <item><description><b>Dataset</b>: knowledge base catalog</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>JDBC</para>
        /// </summary>
        [NameInMap("CatalogType")]
        [Validation(Required=false)]
        public string CatalogType { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. You do not need to specify this parameter for the first query. To query the next page, set this parameter to the NextToken value returned from the previous query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f056501ada12****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The search keyword for the catalog name. Matches catalogs by name prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod_</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

    }

}
