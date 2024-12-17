// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
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
        /// <para>1</para>
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
        /// <para>The type of task configuration change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b> (default): The configurations of all O\&amp;M tasks are changed.</description></item>
        /// <item><description><b>S0</b>: The configurations of tasks initiated to fix exceptions are changed.</description></item>
        /// <item><description><b>S1</b>: The configurations of system O\&amp;M tasks are changed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("ChangeLevel")]
        [Validation(Required=false)]
        public string ChangeLevel { get; set; }

        /// <summary>
        /// <para>The database type. Valid values: <b>redis</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>redis</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The name of the instance. You can leave this parameter empty. If you configure this parameter, you can specify the name only of one instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-wz96fzmpvpr2qnqnlb</para>
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
        /// <para>The name of the service. Valid values: RDS, POLARDB, MongoDB, and Redis. For Redis instances, set the value to Redis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region ID of the O&amp;M task. You can call the <a href="~~DescribeRegions~~">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <remarks>
        /// <para>A value of <b>all</b> indicates all region IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
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
        /// <para>The status of operation and maintenance events. It is used to filter and return tasks. The values are as follows:. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: All events.</description></item>
        /// <item><description><b>3</b>: Events awaiting processing.</description></item>
        /// <item><description><b>4</b>: Events being processed.</description></item>
        /// <item><description><b>5</b>: Events that have successfully ended.</description></item>
        /// <item><description><b>6</b>: Events that have ended in failure.</description></item>
        /// <item><description><b>7</b>: Events that have been canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The type of the O\&amp;M task. If left blank, all types will be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
