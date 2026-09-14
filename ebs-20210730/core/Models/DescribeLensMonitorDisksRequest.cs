// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeLensMonitorDisksRequest : TeaModel {
        /// <summary>
        /// <para>The cloud disk type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud: basic cloud disk.</description></item>
        /// <item><description>cloud_efficiency: ultra cloud disk.</description></item>
        /// <item><description>cloud_ssd: standard SSD.</description></item>
        /// <item><description>cloud_essd: Enterprise SSD (ESSD).</description></item>
        /// <item><description>cloud_auto: ESSD AutoPL cloud disk.</description></item>
        /// <item><description>cloud_essd_entry: ESSD Entry disk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The regular expression pattern used for fuzzy match filtering of cloud disk IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-cd40hxfu0v*</para>
        /// </summary>
        [NameInMap("DiskIdPattern")]
        [Validation(Required=false)]
        public string DiskIdPattern { get; set; }

        /// <summary>
        /// <para>The list of cloud disk IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;d-1\&quot;, \&quot;d-2\&quot;]</para>
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public List<string> DiskIds { get; set; }

        /// <summary>
        /// <para>The ECS instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2zedroc0yv8z19ubnyos</para>
        /// </summary>
        [NameInMap("EcsInstanceId")]
        [Validation(Required=false)]
        public string EcsInstanceId { get; set; }

        /// <summary>
        /// <para>The list of cloud disk event tags, used to filter cloud disks that have experienced these event types within the last 24 hours. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSnapshot: data protection</description></item>
        /// <item><description>BurstIOTriggered: burst I/O</description></item>
        /// <item><description>CostOptimizationNeeded: cost optimization</description></item>
        /// <item><description>DiskSpecNotMatchedWithInstance: instance and cloud disk specifications do not match</description></item>
        /// <item><description>DiskIONo4kAligned: non-4K aligned read/write</description></item>
        /// <item><description>DiskIOHang: I/O hang occurred on the cloud disk</description></item>
        /// <item><description>InstanceIOPSExceedInstanceMaxLimit: instance IOPS reached the upper limit</description></item>
        /// <item><description>InstanceBPSExceedInstanceMaxLimit: instance BPS reached the upper limit</description></item>
        /// <item><description>DiskIOPSExceedInstanceMaxLimit: cloud disk IOPS reached the instance upper limit</description></item>
        /// <item><description>DiskBPSExceedInstanceMaxLimit: cloud disk BPS reached the instance upper limit</description></item>
        /// <item><description>DiskIOPSExceedDiskMaxLimit: cloud disk IOPS reached the disk upper limit</description></item>
        /// <item><description>DiskBPSExceedDiskMaxLimit: cloud disk BPS reached the disk upper limit</description></item>
        /// </list>
        /// </summary>
        [NameInMap("LensTags")]
        [Validation(Required=false)]
        public List<string> LensTags { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query. Maximum value: 100.
        /// Default value:</para>
        /// <list type="bullet">
        /// <item><description><para>The default value is 10.</para>
        /// </description></item>
        /// <item><description><para>If the specified value is greater than 100, the default value of 100 is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the NextToken value returned in the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to query the list of regions supported by EBS Lens.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
