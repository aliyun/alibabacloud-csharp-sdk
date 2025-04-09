// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow the cancellation operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The cancellation operation is not allowed.</description></item>
        /// <item><description><b>1</b>: The cancellation operation is allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("AllowCancel")]
        [Validation(Required=false)]
        public int? AllowCancel { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow the modification operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: The modification operation is not allowed.</description></item>
        /// <item><description><b>1</b>: The modification operation is allowed.</description></item>
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
        /// <hr>
        /// </summary>
        [NameInMap("ChangeLevel")]
        [Validation(Required=false)]
        public string ChangeLevel { get; set; }

        /// <summary>
        /// <para>The type of the database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp16aaccfe10e3e4</para>
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
        /// <para>The number of the page to return. Specify the parameter to a positive integer that is greater than <b>0</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <remarks>
        /// <para> If you set the Region parameter to <b>all</b>, all tasks created within your Alibaba Cloud account are queried. In this case, you must set the <b>taskType</b> parameter to <b>all</b>.</para>
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
        /// <para>The status of the task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: waiting for execution</description></item>
        /// <item><description><b>1</b>: being executed</description></item>
        /// <item><description><b>2</b>: successful</description></item>
        /// <item><description><b>3</b>: failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
