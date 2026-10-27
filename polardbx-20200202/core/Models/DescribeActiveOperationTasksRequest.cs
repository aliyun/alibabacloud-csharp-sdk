// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the event can be canceled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: All O&amp;M events can be canceled.</description></item>
        /// <item><description><b>0</b>: The event cannot be canceled. </description></item>
        /// <item><description><b>1</b>: The event can be canceled.</description></item>
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
        /// <item><description><b>0</b>: The time cannot be modified. </description></item>
        /// <item><description><b>1</b>: The time can be modified.</description></item>
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
        /// <item><description><b>all</b>: all exception fix and system O&amp;M levels</description></item>
        /// <item><description><b>S0</b>: exception fix</description></item>
        /// <item><description><b>S1</b>: system O&amp;M</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("ChangeLevel")]
        [Validation(Required=false)]
        public string ChangeLevel { get; set; }

        /// <summary>
        /// <para>The database type. Set the value to polarx.</para>
        /// 
        /// <b>Example:</b>
        /// <para>polarx</para>
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// <para>The instance name. Default value: an empty string.</para>
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
        /// <item><description><b>-1</b>: all pending and running tasks  </description></item>
        /// <item><description><b>3</b>: pending </description></item>
        /// <item><description><b>4</b>: running</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>The task type. Set the value to all to query all tasks under the current account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
