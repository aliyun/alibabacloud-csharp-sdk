// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryEventHouseWithTimeRangeRequest : TeaModel {
        /// <summary>
        /// <para>The start time for querying internal EventHouse data. Specify a UNIX timestamp in seconds. The time range includes this point in time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787587200</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The end time for querying internal EventHouse data. Specify a UNIX timestamp in seconds. The time range excludes this point in time. The value must be greater than BeginTime.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787590800</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of result rows that can be returned for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The single read-only SQL statement to execute. You can query internal EventHouse data or perform federated queries with mounted external data sources.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT * FROM my_catalog.my_namespace.my_table LIMIT 100</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
