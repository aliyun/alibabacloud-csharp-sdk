// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>The connection configuration name prefix used to filter results. Supports prefix matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connection-name</para>
        /// </summary>
        [NameInMap("ConnectionNamePrefix")]
        [Validation(Required=false)]
        public string ConnectionNamePrefix { get; set; }

        /// <summary>
        /// <para>Excludes a single connection type. Valid values are the same as those for Type. Specify a single type name. Arrays or comma-separated values are not supported. For example, specify Http to exclude HTTP connections. If this parameter is not specified or is set to an empty string, no types are excluded. If this parameter is set to the same value as Type, an empty list is returned. Pagination and total count are calculated after filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("ExcludeType")]
        [Validation(Required=false)]
        public string ExcludeType { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per request. You can use this parameter together with NextToken to implement pagination.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>If the number of entries exceeds the value of MaxResults, NextToken is returned in the response.</para>
        /// <list type="bullet">
        /// <item><description>The NextToken value starts from 0. Default value: 0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Filters query results by connection type. Valid values: Http, MySQL, PostgreSQL, Elasticsearch, OSS_TABLES, SLS, OTS, MaxCompute, MongoDB, Redis, SQLServer, ClickHouse, Oracle, Hive, Iceberg, lakehouse. If this parameter is not specified, all types are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
