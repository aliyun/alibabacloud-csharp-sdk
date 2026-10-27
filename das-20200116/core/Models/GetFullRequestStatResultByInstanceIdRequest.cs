// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetFullRequestStatResultByInstanceIdRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the results in ascending order. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbtest01</para>
        /// </summary>
        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>The end time of the query. The time is a UNIX timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>The end time must be later than the start time, and the interval between the start time and the end time cannot exceed one day.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1645668213000</para>
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-2ze8g2am97624****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The query keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbtest01</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para>For PolarDB for MySQL instances, the node ID is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp12v7243x012****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. Default value: <b>count</b>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>count</b>: the number of executions.</para>
        /// </description></item>
        /// <item><description><para><b>avgRt</b>: the average execution time.</para>
        /// </description></item>
        /// <item><description><para><b>rtRate</b>: the execution time proportion.</para>
        /// </description></item>
        /// <item><description><para><b>rowsExamined</b>: the total number of scanned rows.</para>
        /// </description></item>
        /// <item><description><para><b>avgRowsExamined</b>: the average number of scanned rows.</para>
        /// </description></item>
        /// <item><description><para><b>avgRowsReturned</b>: the average number of returned rows.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>count</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The IP address of the client that executed the SQL statement.</para>
        /// <remarks>
        /// <para>This parameter is optional. If you specify a client IP address, the full request data of the specified client IP address is aggregated. If you leave this parameter empty, the full request data of the entire database instance is aggregated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>172.26.XX.XXX</para>
        /// </summary>
        [NameInMap("OriginHost")]
        [Validation(Required=false)]
        public string OriginHost { get; set; }

        /// <summary>
        /// <para>The page number for the paged query. The paging starts from 1. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The data volume per page for paging in a paged query. Default value: 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The node information of the PolarDB-X 2.0 database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>polarx_cn</b>: compute node.</para>
        /// </description></item>
        /// <item><description><para><b>polarx_dn</b>: data node.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx_cn</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The SQL ID.</para>
        /// <remarks>
        /// <para>If you specify an SQL ID, the full request data of the specified SQL ID is aggregated. If you leave this parameter empty, the full request data of the entire database instance is aggregated.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>d71f82be1eef72bd105128204d2e****</para>
        /// </summary>
        [NameInMap("SqlId")]
        [Validation(Required=false)]
        public string SqlId { get; set; }

        /// <summary>
        /// <para>The type of the SQL statement. Valid values: <b>SELECT</b>, <b>INSERT</b>, <b>UPDATE</b>, <b>DELETE</b>, <b>LOGIN</b>, <b>LOGOUT</b>, <b>MERGE</b>, <b>ALTER</b>, <b>CREATEINDEX</b>, <b>DROPINDEX</b>, <b>CREATE</b>, <b>DROP</b>, <b>SET</b>, <b>DESC</b>, <b>REPLACE</b>, <b>CALL</b>, <b>BEGIN</b>, <b>DESCRIBE</b>, <b>ROLLBACK</b>, <b>FLUSH</b>, <b>USE</b>, <b>SHOW</b>, <b>START</b>, <b>COMMIT</b>, and <b>RENAME</b>.</para>
        /// <remarks>
        /// <para>If the database instance is an ApsaraDB RDS for MySQL, PolarDB for MySQL, or PolarDB-X 2.0 instance, you can aggregate data by SQL statement type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The start time of the query. The format is a UNIX timestamp, in milliseconds.</para>
        /// <remarks>
        /// <para>The start time must be within the SQL Explorer storage duration for the database instance and cannot be more than 90 days earlier than the current time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1645581813000</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// <para>The instance ID, which is the ID of the Alibaba Cloud account that created the database instance.</para>
        /// <remarks>
        /// <para>This parameter is optional. After you enter the ID of the target database instance, the system automatically obtains the instance ID when you call the API operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>196278346919****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
