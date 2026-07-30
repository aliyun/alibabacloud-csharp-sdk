// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSlowLogStatisticRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the results in ascending order. The default value is false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// <para>The end time of the query. This value is a UNIX timestamp in UTC. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1608888296000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeSlowLogStatisticRequestFilters> Filters { get; set; }
        public class DescribeSlowLogStatisticRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyWords</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze1jdv45i7l6****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <list type="bullet">
        /// <item><description><para>For RDS for MySQL and PolarDB for MySQL, this parameter applies only to cluster instances. If you do not specify this parameter, the slow query logs of the primary node are queried by default.</para>
        /// </description></item>
        /// <item><description><para>For PolarDB-X 2.0, specify <b>polarx_cn</b> for compute nodes or <b>polarx_dn</b> for data nodes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>r-x****-db-0</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The sorting method. Valid values:</para>
        /// <para><b>Count</b></para>
        /// <para><b>QueryTime</b></para>
        /// <para><b>LockTime</b></para>
        /// <para><b>RowsExamined</b></para>
        /// <para><b>RowsSent</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>count</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time of the query. This value is a UNIX timestamp in UTC. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1568269711000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04ea3310df40c3fa8a6b4854db49f79a</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// <para>For SQL engines:</para>
        /// <para><b>SlowLogRequestOrigin</b>: Aggregates logs by source IP address.</para>
        /// <para><b>SlowLogRequestUser</b>: Aggregates logs by source user.</para>
        /// <para><b>SQL</b>: Aggregates logs by SQL ID.</para>
        /// <para>For ApsaraDB for MongoDB engines:</para>
        /// <para><b>SlowLogRequestOrigin</b>: Aggregates logs by source IP address.</para>
        /// <para><b>SlowLogRequestUser</b>: Aggregates logs by source user.</para>
        /// <para><b>SQL</b>: Aggregates logs by query ID.</para>
        /// <para><b>SlowLogRequestOpType</b>: Aggregates logs by operation type.</para>
        /// <para><b>SlowLogRequestNamespace</b>: Aggregates logs by namespace.</para>
        /// <para>For Redis engines:</para>
        /// <para><b>SlowLogRequestNodeId</b>: Aggregates logs by node ID.</para>
        /// <para><b>SlowLogRequestHostInsId</b>: Aggregates logs by host instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
