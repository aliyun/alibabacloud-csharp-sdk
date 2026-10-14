// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListAgenticTableBaseInfoRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the database to which the table belongs. You can obtain the UUID by calling the ListAgenticDatabase or SearchAgenticDatabase operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md-HZ-fp9K7r***</para>
        /// </summary>
        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

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
        /// <para>The token for the next query. You do not need to specify this parameter for the first query. When you query the next page, set this parameter to the NextToken value returned in the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f056501ada12****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The search keyword. The system matches the keyword against table names. The results are sorted by exact match, prefix match, and contains match. Within the same match level, the results are sorted by the field specified by SortFieldName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order</para>
        /// </summary>
        [NameInMap("SearchKey")]
        [Validation(Required=false)]
        public string SearchKey { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. This parameter is case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: Sorts the results by table name. This value is recommended.</description></item>
        /// <item><description><b>numRows</b>: Sorts the results by the number of rows.</description></item>
        /// <item><description><b>storeCapacity</b>: Sorts the results by the storage capacity.</description></item>
        /// </list>
        /// <para>If you specify other values, the request fails. If you do not specify this parameter, the results are returned in the default order, and the SortOrder parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("SortFieldName")]
        [Validation(Required=false)]
        public string SortFieldName { get; set; }

        /// <summary>
        /// <para>The sort order. This parameter takes effect only when SortFieldName is specified. This parameter is not case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ASC</b>: Sorts the results in ascending order. This is the default value and is recommended.</description></item>
        /// <item><description><b>DESC</b>: Sorts the results in descending order.</description></item>
        /// </list>
        /// <para>If you specify other values, the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The table type. The results are strictly filtered by this type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NORMAL</b>: Regular table.</description></item>
        /// <item><description><b>VIEW</b>: View.</description></item>
        /// <item><description><b>FOREIGN</b>: Foreign table.</description></item>
        /// <item><description><b>SYNONYM</b>: Synonym. This value is supported only for Oracle data sources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("TableType")]
        [Validation(Required=false)]
        public string TableType { get; set; }

    }

}
