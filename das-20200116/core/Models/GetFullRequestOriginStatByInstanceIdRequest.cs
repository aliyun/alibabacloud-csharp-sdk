// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetFullRequestOriginStatByInstanceIdRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to sort the results in ascending order. By default, the results are not sorted in ascending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("Asc")]
        [Validation(Required=false)]
        public bool? Asc { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para> The end time must be later than the start time. The interval between the start time and the end time cannot exceed 24 hours.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1644803409000</para>
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
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para> This parameter must be specified if the database instance is a PolarDB for MySQL cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-bp12v7243x012****</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The field by which the results to be returned are sorted. Default value: <b>count</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>count</b>: the number of executions.</description></item>
        /// <item><description><b>avgRt</b>: the average execution duration.</description></item>
        /// <item><description><b>rtRate</b>: the execution duration percentage.</description></item>
        /// <item><description><b>rowsExamined</b>: the total number of scanned rows.</description></item>
        /// <item><description><b>avgRowsExamined</b>: the average number of scanned rows.</description></item>
        /// <item><description><b>avgRowsReturned</b>: the average number of returned rows.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>count</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The role of the PolarDB-X 2.0 node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>polarx_cn</b>: compute node.</description></item>
        /// <item><description><b>polarx_en</b>: data node.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>polarx_cn</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The type of the SQL statement. Valid values: <b>SELECT</b>, <b>INSERT</b>, <b>UPDATE</b>, <b>DELETE</b>, <b>MERGE</b>, <b>ALTER</b>, <b>CREATEINDEX</b>, <b>DROPINDEX</b>, <b>CREATE</b>, <b>DROP</b>, <b>SET</b>, <b>DESC</b>, <b>REPLACE</b>, <b>CALL</b>, <b>BEGIN</b>, <b>DESCRIBE</b>, <b>ROLLBACK</b>, <b>FLUSH</b>, <b>USE</b>, <b>SHOW</b>, <b>START</b>, <b>COMMIT</b>, and <b>RENAME</b>.</para>
        /// <remarks>
        /// <para> If the database instance is an ApsaraDB RDS for MySQL instance, a PolarDB for MySQL instance, or a PolarDB-X 2.0 instance, statistics can be collected based on the SQL statement type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT</para>
        /// </summary>
        [NameInMap("SqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Set this parameter to a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// <remarks>
        /// <para> The start time must be within the storage duration of the SQL Explorer of the database instance, and can be up to 90 days earlier than the current time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1644716649000</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used to create the database instance.</para>
        /// <remarks>
        /// <para> This parameter is optional. The system can automatically obtain the account ID based on the value of InstanceId when you call this operation.</para>
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
