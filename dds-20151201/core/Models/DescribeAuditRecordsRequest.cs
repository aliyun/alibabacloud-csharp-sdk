// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAuditRecordsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>If you specify a sharded cluster instance ID for this parameter, you must also specify the <b>NodeId</b> parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp12c5b040dc****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database. The default value is all databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>database****</para>
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>The end time of the query. The end time must be later than the start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The time range between the end time and the start time cannot exceed 24 hours. If the time range exceeds 24 hours, the call fails.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-13T13:11:14Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The display format of the returned audit records. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>File</b>: Triggers the generation of an audit log file. If you set this parameter to this value, only common parameters are returned.</description></item>
        /// <item><description><b>Stream</b> (default): Returns a data stream.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The <b>File</b> value is deprecated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Stream</para>
        /// </summary>
        [NameInMap("Form")]
        [Validation(Required=false)]
        public string Form { get; set; }

        /// <summary>
        /// <para>The logical operator for keyword search. The default value is and.</para>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("LogicalOperator")]
        [Validation(Required=false)]
        public string LogicalOperator { get; set; }

        /// <summary>
        /// <para>Instance ID of a mongos node or shard node in the sharded cluster instance.</para>
        /// <remarks>
        /// <para>This parameter is available only when <b>DBInstanceId</b> is set to instance ID of a sharded cluster instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp128a003436****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The order in which the queried slow logs are sorted by time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: sorts results in ascending order by time.</description></item>
        /// <item><description><b>desc</b>: sorts results in descending order by time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0 and cannot exceed the maximum value of the Integer type. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page. Valid values: <b>30</b> (default), <b>50</b>, and <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The keywords to query. Separate multiple keywords with spaces. You can specify a maximum of 10 keywords.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slow</para>
        /// </summary>
        [NameInMap("QueryKeywords")]
        [Validation(Required=false)]
        public string QueryKeywords { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-03-13T12:11:14Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The database account. The default value is all accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
