// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether cancellation is allowed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: All O&amp;M events can be canceled.</description></item>
        /// <item><description><b>0</b>: Not allowed. </description></item>
        /// <item><description><b>1</b>: Allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("AllowCancel")]
        [Validation(Required=false)]
        public long? AllowCancel { get; set; }

        /// <summary>
        /// <para>Specifies whether the time can be modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: The time of all O&amp;M events can be modified.</description></item>
        /// <item><description><b>0</b>: Not allowed. </description></item>
        /// <item><description><b>1</b>: Allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("AllowChange")]
        [Validation(Required=false)]
        public long? AllowChange { get; set; }

        /// <summary>
        /// <para>The change level. Default value: all. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b>: All levels of exception recovery and system O&amp;M.</description></item>
        /// <item><description><b>S0</b>: Exception recovery.</description></item>
        /// <item><description><b>S1</b>: System O&amp;M.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("ChangeLevel")]
        [Validation(Required=false)]
        public string ChangeLevel { get; set; }

        /// <summary>
        /// <para>The database type. Set this parameter to polarx.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polarx</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The instance name. Default value: empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-xxxxx</para>
        /// </summary>
        [NameInMap("InsName")]
        [Validation(Required=false)]
        public string InsName { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 25.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The product name. Default value: polarx.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polarx</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: All pending and running tasks.  </description></item>
        /// <item><description><b>3</b>: Pending. </description></item>
        /// <item><description><b>4</b>: Running.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>The task type. A value of all indicates that all tasks of the user are queried. Set this parameter to all.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
