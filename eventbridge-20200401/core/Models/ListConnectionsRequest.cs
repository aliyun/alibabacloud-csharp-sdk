// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>The name prefix of the connection configurations to query. Supports prefix matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connection-name</para>
        /// </summary>
        [NameInMap("ConnectionNamePrefix")]
        [Validation(Required=false)]
        public string ConnectionNamePrefix { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. Can be used together with NextToken to implement pagination.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 10</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>When MaxResults is specified, NextToken is returned if there are more results to fetch.</para>
        /// <list type="bullet">
        /// <item><description>NextToken starts from 0 by default. Default value: 0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Filters query results by connection type. Valid values: Http, MySQL, PostgreSQL, Elasticsearch. If left empty, connections of all types are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Http</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
