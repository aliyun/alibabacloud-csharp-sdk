// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeActiveOperationTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow cancellation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>-1</b> (default): all.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: returns only tasks that do not allow cancellation.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: returns only tasks that allow cancellation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("AllowCancel")]
        [Validation(Required=false)]
        public long? AllowCancel { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow time modification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>-1</b> (default): all.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: returns only tasks that do not allow time modification.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: returns only tasks that allow time modification.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("AllowChange")]
        [Validation(Required=false)]
        public long? AllowChange { get; set; }

        /// <summary>
        /// <para>The task level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>all</b> (default): all.</para>
        /// </description></item>
        /// <item><description><para><b>S0</b>: returns tasks at the abnormal repair level.</para>
        /// </description></item>
        /// <item><description><para><b>S1</b>: returns tasks at the system maintenance level.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("ChangeLevel")]
        [Validation(Required=false)]
        public string ChangeLevel { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query detailed information about all clusters under your account, including cluster IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-3ns***********d5d</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The database engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0 and cannot exceed the maximum value of the Integer data type. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the pending event.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98041.html">DescribeRegions</a> operation to query available regions.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>-1: all tasks.</para>
        /// </description></item>
        /// <item><description><para>3: pending tasks.</para>
        /// </description></item>
        /// <item><description><para>4: tasks in progress.</para>
        /// </description></item>
        /// <item><description><para>5: successfully completed tasks.</para>
        /// </description></item>
        /// <item><description><para>6: failed tasks.</para>
        /// </description></item>
        /// <item><description><para>7: canceled tasks.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>The type of the pending event task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DatabaseSoftwareUpgrading</b>: database software upgrade</para>
        /// </description></item>
        /// <item><description><para><b>DatabaseHardwareMaintenance</b>: hardware maintenance and upgrade</para>
        /// </description></item>
        /// <item><description><para><b>DatabaseStorageUpgrading</b>: database storage upgrade</para>
        /// </description></item>
        /// <item><description><para><b>DatabaseProxyUpgrading</b>: proxy minor version upgrade</para>
        /// </description></item>
        /// <item><description><para><b>all</b>: returns all types of pending events</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When <c>Region</c> is set to <b>all</b>, <c>TaskType</c> must also be set to <b>all</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DatabaseProxyUpgrading</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
