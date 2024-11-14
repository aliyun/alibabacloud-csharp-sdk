// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeLensMonitorDisksRequest : TeaModel {
        /// <summary>
        /// <para>The type of the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud</description></item>
        /// <item><description>cloud_efficiency</description></item>
        /// <item><description>cloud_ssd</description></item>
        /// <item><description>cloud_essd</description></item>
        /// <item><description>cloud_auto</description></item>
        /// <item><description>cloud_essd_entry</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The list of disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;d-1\&quot;, \&quot;d-2\&quot;]</para>
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public List<string> DiskIds { get; set; }

        /// <summary>
        /// <para>Event tags of the disk, which are used to filter the disks on which the events associated with the specified tags occurred in the previous 24 hours. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSnapshot: specifies the event that is triggered because no snapshot is created for the disk to protect data on the disk.</description></item>
        /// <item><description>BurstIOTriggered: specifies the event that is triggered when a burst I/O operation is performed on the disk.</description></item>
        /// <item><description>CostOptimizationNeeded: specifies the event that is triggered when cost optimization is required.</description></item>
        /// <item><description>DiskSpecNotMatchedWithInstance: specifies the event that is triggered if the disk specifications do not match the instance to which the disk is attached.</description></item>
        /// <item><description>DiskIONo4kAligned: specifies the event that is triggered if the physical and logical sectors involved in a read or write operation are not 4K aligned.</description></item>
        /// <item><description>DiskIOHang: specifies the event that is triggered when an I/O hang occurs on the disk.</description></item>
        /// <item><description>InstanceIOPSExceedInstanceMaxLimit: specifies the event that is triggered when the number of IOPS on the instance reaches the upper limit.</description></item>
        /// <item><description>InstanceBPSExceedInstanceMaxLimit: specifies the event that is triggered when the number of BPS on the instance reaches the upper limit.</description></item>
        /// <item><description>DiskIOPSExceedInstanceMaxLimit: specifies the event that is triggered when the number of IOPS on the disk reaches the upper limit of the instance.</description></item>
        /// <item><description>DiskBPSExceedInstanceMaxLimit: specifies the event that is triggered when the number of BPS on the disk reaches the upper limit of the instance.</description></item>
        /// <item><description>DiskIOPSExceedDiskMaxLimit: specifies the event that is triggered when the number of IOPS on the disk reaches the upper limit of the disk.</description></item>
        /// <item><description>DiskBPSExceedDiskMaxLimit: specifies the event that is triggered when the number of BPS on the disk reaches the upper limit of the disk.</description></item>
        /// <item><description>DiskSlowIOTriggerred: specifies the event that is triggered when the I/O speed on the disk is slow.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("LensTags")]
        [Validation(Required=false)]
        public List<string> LensTags { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to start the next query to retrieve more results.</para>
        /// <remarks>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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

    }

}
