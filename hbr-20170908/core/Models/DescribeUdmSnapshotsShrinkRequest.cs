// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeUdmSnapshotsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp1560750pclffpzxy70</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1643092168</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the ECS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp18x2k7sw925ir7ofh8</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the backup job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-*********************</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The list of snapshot IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;s-000e3vhhu62xsm6v92r0\&quot;]</para>
        /// </summary>
        [NameInMap("SnapshotIds")]
        [Validation(Required=false)]
        public string SnapshotIdsShrink { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UDM_ECS</b>: ECS instance backup</para>
        /// </description></item>
        /// <item><description><para><b>UDM_ECS_DISK</b>: a disk backup subtask of an ECS instance backup</para>
        /// </description></item>
        /// <item><description><para><b>UDM_DISK</b>: disk backup</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UDM_ECS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. This value is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1642057551</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The region ID of the ECS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("UdmRegionId")]
        [Validation(Required=false)]
        public string UdmRegionId { get; set; }

    }

}
