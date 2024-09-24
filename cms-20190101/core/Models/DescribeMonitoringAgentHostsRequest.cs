// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentHostsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query Elastic Compute Service (ECS) instances that are provided by Alibaba Cloud or to query hosts that are not provided by Alibaba Cloud. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default value): queries all the ECS instances that are provided by Alibaba Cloud.</description></item>
        /// <item><description>false: queries all the hosts that are not provided by Alibaba Cloud.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AliyunHost")]
        [Validation(Required=false)]
        public bool? AliyunHost { get; set; }

        /// <summary>
        /// <para>The name of the host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hostNam1</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-a3d1q1pm2f9yr29e****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("InstanceRegionId")]
        [Validation(Required=false)]
        public string InstanceRegionId { get; set; }

        /// <summary>
        /// <para>The keyword that is used in fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host1</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
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
        /// <item><description>10</description></item>
        /// <item><description>20</description></item>
        /// <item><description>50</description></item>
        /// <item><description>100</description></item>
        /// </list>
        /// <remarks>
        /// <para>Although Alibaba Cloud does not limit the maximum value of this parameter, we recommend that you do not set it to an excessively large value. If you set it to an excessively large value, a timeout error may occur.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The serial number of the host.</para>
        /// <para>After the CloudMonitor agent is installed on a host, a globally unique serial number is generated. A host that is not provided by Alibaba Cloud has a serial number instead of an instance ID.</para>
        /// <remarks>
        /// <para>This parameter can be used to accurately search for a monitored host.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a1ab31a3-1234-40f2-9e95-c8caa8f0****</para>
        /// </summary>
        [NameInMap("SerialNumbers")]
        [Validation(Required=false)]
        public string SerialNumbers { get; set; }

        /// <summary>
        /// <para>The status of the hosts that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Running: queries the hosts that are running.</description></item>
        /// <item><description>Stopped: queries the hosts that are stopped, are not installed, or fail to be installed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The status of SysOM. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>installing: SysOM is being installed.</description></item>
        /// <item><description>running: SysOM is running.</description></item>
        /// <item><description>stopped: SysOM is stopped.</description></item>
        /// <item><description>uninstalling: SysOM is being uninstalled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("SysomStatus")]
        [Validation(Required=false)]
        public string SysomStatus { get; set; }

    }

}
