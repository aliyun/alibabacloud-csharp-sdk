// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the task can be canceled. Default value: -1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: all tasks.</description></item>
        /// <item><description><b>0</b>: Only tasks that cannot be canceled are returned.</description></item>
        /// <item><description><b>1</b>: Only tasks that can be canceled are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("AllowCancel")]
        [Validation(Required=false)]
        public int? AllowCancel { get; set; }

        /// <summary>
        /// <para>Specifies whether the task time can be modified. Default value: -1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: all tasks.</description></item>
        /// <item><description><b>0</b>: Only tasks whose time cannot be modified are returned.</description></item>
        /// <item><description><b>1</b>: Only tasks whose time can be modified are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("AllowChange")]
        [Validation(Required=false)]
        public int? AllowChange { get; set; }

        /// <summary>
        /// <para>The task level. Default value: all. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b>: all levels.</description></item>
        /// <item><description><b>S0</b>: Only tasks at the exception recovery level are returned.</description></item>
        /// <item><description><b>S1</b>: Only tasks at the system O&amp;M level are returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("ChangeLevel")]
        [Validation(Required=false)]
        public string ChangeLevel { get; set; }

        /// <summary>
        /// <para>The database type. Default value: all. Valid values: mysql, pgsql, and mssql.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The instance name. This parameter is optional. You can specify at most one instance name.</para>
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
        /// <para>The page number. The value must be greater than 0. Default value: 1.</para>
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
        /// <para>The product name. Valid values: RDS, POLARDB, MongoDB, and Redis. For ApsaraDB RDS instances, set this parameter to RDS.</para>
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
        /// <para>Set this parameter to <b>all</b> to specify all region IDs.</para>
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
        /// <para>The task status. This parameter is used to filter the returned tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: all tasks.</description></item>
        /// <item><description><b>3</b>: pending tasks.</description></item>
        /// <item><description><b>4</b>: in-progress tasks.</description></item>
        /// <item><description><b>5</b>: succeeded tasks.</description></item>
        /// <item><description><b>6</b>: failed tasks.</description></item>
        /// <item><description><b>7</b>: canceled tasks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>rds_apsaradb_ha</b>: primary/secondary node switch.</description></item>
        /// <item><description><b>rds_apsaradb_transfer</b>: instance migration.</description></item>
        /// <item><description><b>rds_apsaradb_upgrade</b>: minor engine version update.</description></item>
        /// <item><description><b>rds_apsaradb_maxscale</b>: proxy minor version upgrade.</description></item>
        /// <item><description><b>all</b>: all task types.</description></item>
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
