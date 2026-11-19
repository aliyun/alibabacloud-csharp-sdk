// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the task can be canceled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b> (default): returns all tasks.</description></item>
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
        /// <para>Specifies whether the execution time can be modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b> (default): returns all tasks.</description></item>
        /// <item><description><b>0</b>: returns only tasks whose execution time cannot be modified.</description></item>
        /// <item><description><b>1</b>: returns only tasks whose execution time can be modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("AllowChange")]
        [Validation(Required=false)]
        public int? AllowChange { get; set; }

        /// <summary>
        /// <para>The change level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b> (default): returns all tasks.</description></item>
        /// <item><description><b>S0</b>: returns tasks at the exception remediation level.</description></item>
        /// <item><description><b>S1</b>: returns tasks at the system O&amp;M level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("ChangeLevel")]
        [Validation(Required=false)]
        public string ChangeLevel { get; set; }

        /// <summary>
        /// <para>The database type. Default value: <b>all</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mongoDb</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The name of the instance. This parameter is optional. If you specify this parameter, you can specify only one instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp16aaccfe10****</para>
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
        /// <para>The page number. The value must be greater than <b>0</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product name. For MongoDB instances, set the value to <b>MongoDB</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The ID of the region to which the pending event belongs. You can call the DescribeRegions operation to query the region ID.</para>
        /// <remarks>
        /// <para>A value of <b>all</b> specifies all region IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyiu4ekp****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The task status, which is used to filter the returned tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: all tasks</description></item>
        /// <item><description><b>3</b>: pending tasks</description></item>
        /// <item><description><b>4</b>: in-progress tasks</description></item>
        /// <item><description><b>5</b>: successfully completed tasks</description></item>
        /// <item><description><b>6</b>: failed tasks</description></item>
        /// <item><description><b>7</b>: canceled tasks</description></item>
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
        /// <item><description><b>rds_apsaradb_ha</b>: primary/secondary node switch</description></item>
        /// <item><description><b>rds_apsaradb_transfer</b>: instance migration</description></item>
        /// <item><description><b>rds_apsaradb_upgrade</b>: minor version upgrade</description></item>
        /// <item><description><b>rds_apsaradb_maxscale</b>: proxy minor version upgrade</description></item>
        /// <item><description><b>all</b>: all task types</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
