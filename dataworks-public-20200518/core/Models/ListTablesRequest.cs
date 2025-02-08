// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListTablesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the data source. Valid values: ODPS, emr, mysql, holo, analyticdb_for_mysql, oracle, postgresql, sqlserver, clickhouse, and starrocks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps
        /// emr
        /// mysql
        /// holo</para>
        /// </summary>
        [NameInMap("DataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>Pagination information, which specifies the starting point of this read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12222</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries displayed on each page. The default value is 10 and the maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
