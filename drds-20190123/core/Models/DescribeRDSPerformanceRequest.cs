// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeRDSPerformanceRequest : TeaModel {
        /// <summary>
        /// <para>The type of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql</para>
        /// </summary>
        [NameInMap("DbInstType")]
        [Validation(Required=false)]
        public string DbInstType { get; set; }

        /// <summary>
        /// <para>The ID of the Distributed Relational Database Service (DRDS) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds*********</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>The end time of the query. Specify the time in the UNIX timestamp format. The time must be in UTC. Unit: ms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1603209690000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The performance monitoring metrics. You can specify one or more metrics for a query at a time. Separate multiple metric parameters with commas (,).</para>
        /// <remarks>
        /// <para> For more information about the details of performance monitoring metrics, see <a href="https://help.aliyun.com/document_detail/186705.html">Storage monitoring</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL_MemCpuUsage</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        public string Keys { get; set; }

        /// <summary>
        /// <para>The ID of the storage-layer ApsaraDB RDS for MySQL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-************</para>
        /// </summary>
        [NameInMap("RdsInstanceId")]
        [Validation(Required=false)]
        public string RdsInstanceId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the UNIX timestamp format. The time must be in UTC. Unit: ms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1603123290000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
