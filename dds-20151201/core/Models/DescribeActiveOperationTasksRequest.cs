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
        /// <item><description><para><b>-1</b> (default): returns all tasks.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: returns only tasks that cannot be canceled.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: returns only tasks that can be canceled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("AllowCancel")]
        [Validation(Required=false)]
        public int? AllowCancel { get; set; }

        /// <summary>
        /// <para>Specifies whether the time can be changed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>-1</b> (default): returns all tasks.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: returns only tasks whose time cannot be changed.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: returns only tasks whose time can be changed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("AllowChange")]
        [Validation(Required=false)]
        public int? AllowChange { get; set; }

        /// <summary>
        /// <para>The level of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>all</b> (default): returns all tasks.</para>
        /// </description></item>
        /// <item><description><para><b>S0</b>: returns tasks for exception fixing.</para>
        /// </description></item>
        /// <item><description><para><b>S1</b>: returns tasks for system O\&amp;M.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <hr>
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
        /// <para>The name of the instance. This parameter is optional. You can specify only one instance name.</para>
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
        /// <para>The product name. For MongoDB instances, set this parameter to <b>MongoDB</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MongoDB</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the pending event is located. Call the DescribeRegions operation to obtain the region ID.</para>
        /// <remarks>
        /// <para>A value of <b>all</b> indicates all region IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
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
        /// <para>The task status. This parameter filters the returned tasks.</para>
        /// <list type="bullet">
        /// <item><description><para><b>-1</b>: all tasks.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: pending tasks.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: running tasks.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: successfully completed tasks.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: failed tasks.</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: canceled tasks.</para>
        /// </description></item>
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
        /// <item><description><para><b>rds_apsaradb_ha</b>: primary-secondary node switchover.</para>
        /// </description></item>
        /// <item><description><para><b>rds_apsaradb_transfer</b>: instance migration.</para>
        /// </description></item>
        /// <item><description><para><b>rds_apsaradb_upgrade</b>: minor version upgrade.</para>
        /// </description></item>
        /// <item><description><para><b>rds_apsaradb_maxscale</b>: proxy minor version upgrade.</para>
        /// </description></item>
        /// <item><description><para><b>all</b>: all task types.</para>
        /// </description></item>
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
