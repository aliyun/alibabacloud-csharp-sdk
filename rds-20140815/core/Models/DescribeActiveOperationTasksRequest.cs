// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition that is used to return tasks based on the settings of task cancellation. Default value: -1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: returns all tasks.</description></item>
        /// <item><description><b>0</b>: returns only tasks that cannot be canceled.</description></item>
        /// <item><description><b>1</b>: returns only tasks that can be canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("AllowCancel")]
        [Validation(Required=false)]
        public int? AllowCancel { get; set; }

        /// <summary>
        /// <para>The filter condition that is used to return tasks based on the settings of the switching time. Default value: -1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: returns all tasks.</description></item>
        /// <item><description><b>0</b>: returns only tasks for which the switching time cannot be changed.</description></item>
        /// <item><description><b>1</b>: returns only tasks for which the switching time can be changed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("AllowChange")]
        [Validation(Required=false)]
        public int? AllowChange { get; set; }

        /// <summary>
        /// <para>The filter condition that is used to return tasks based on the task level. Default value: all. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b>: all types</description></item>
        /// <item><description><b>S0</b>: returns the tasks of the exception fixing level.</description></item>
        /// <item><description><b>S1</b>: returns the tasks of the system O\&amp;M level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("ChangeLevel")]
        [Validation(Required=false)]
        public string ChangeLevel { get; set; }

        /// <summary>
        /// <para>The type of the database. Default value: all. Valid values: mysql, pgsql, and mssql.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The name of the instance. You can leave this parameter empty. If you configure this parameter, you can specify the name only of one instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp191w771kd3****</para>
        /// </summary>
        [NameInMap("InsName")]
        [Validation(Required=false)]
        public string InsName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 25. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the service. Valid values: RDS, POLARDB, MongoDB, and Redis. For RDS instances, set the value to RDS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region ID of the pending event. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <remarks>
        /// <para> The value <b>all</b> indicates all regions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The status of the task, which is used as a filter condition to return tasks.</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: all tasks</description></item>
        /// <item><description><b>3</b>: pending</description></item>
        /// <item><description><b>4</b>: being processed</description></item>
        /// <item><description><b>5</b>: completed</description></item>
        /// <item><description><b>6</b>: failed</description></item>
        /// <item><description><b>7</b>: canceled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The type of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>rds_apsaradb_ha</b>: primary/secondary switchover</description></item>
        /// <item><description><b>rds_apsaradb_transfer</b>: instance migration</description></item>
        /// <item><description><b>rds_apsaradb_upgrade</b>: update of the minor engine version</description></item>
        /// <item><description><b>rds_apsaradb_maxscale</b>: update of the minor version of the proxy</description></item>
        /// <item><description><b>all</b>: all types</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rds_apsaradb_upgrade</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
