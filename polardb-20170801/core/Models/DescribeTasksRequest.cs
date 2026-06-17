// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeTasksRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>Specify either <c>DBNodeId</c> or <c>DBClusterId</c>. Call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of all clusters in your account, including cluster IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-***************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <remarks>
        /// <para>Specify either <c>DBNodeId</c> or <c>DBClusterId</c>. Call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of all clusters in your account, including node IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pi-***************</para>
        /// </summary>
        [NameInMap("DBNodeId")]
        [Validation(Required=false)]
        public string DBNodeId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the <c>YYYY-MM-DDThh:mmZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-02T03:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be an integer that is greater than 0 and does not exceed the maximum value of the Integer data type.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>30</b>, <b>50</b>, and <b>100</b>.</para>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the <c>YYYY-MM-DDThh:mmZ</c> format. The time must be in UTC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-30T00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Waiting</b>: The task is waiting to be executed.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: The task is running.</para>
        /// </description></item>
        /// <item><description><para><b>Finished</b>: The task is complete.</para>
        /// </description></item>
        /// <item><description><para><b>Closed</b>: The task is closed.</para>
        /// </description></item>
        /// <item><description><para><b>Pause</b>: The task is paused.</para>
        /// </description></item>
        /// <item><description><para><b>Stop</b>: The task is interrupted.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you leave this parameter empty, the details of all tasks in the <b>Waiting</b> or <b>Running</b> state for the current cluster or node are returned.</para>
        /// </description></item>
        /// <item><description><para>To query tasks in multiple states, separate the state names with a comma (,).</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
