// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the connection configuration name. Supports fuzzy match by prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connection-name</para>
        /// </summary>
        [NameInMap("ConnectionNamePrefix")]
        [Validation(Required=false)]
        public string ConnectionNamePrefix { get; set; }

        /// <summary>
        /// <para>排除单个连接类型，取值范围与 Type 相同。传入单个类型名称，不支持数组或逗号分隔的多个值。例如传入 Http 可排除 HTTP 类型的连接。未传或传入空字符串时不排除任何类型；与 Type 相同时返回空列表。分页与总数均在过滤后计算。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("ExcludeType")]
        [Validation(Required=false)]
        public string ExcludeType { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per request. You can use this parameter together with NextToken to implement paging.</para>
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
        /// <para>The pagination token. If the number of results exceeds the value of MaxResults, a NextToken value is returned.</para>
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
        /// <para>Filters query results by connection type. Valid values: Http, MySQL, PostgreSQL, Elasticsearch, OSS_TABLES, SLS, OTS, MaxCompute, MongoDB, Redis, SQLServer, ClickHouse, Oracle, Hive, Iceberg, and lakehouse. If this parameter is not specified, all types are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
