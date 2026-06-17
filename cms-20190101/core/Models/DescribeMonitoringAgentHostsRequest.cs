// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentHostsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter for Alibaba Cloud Elastic Compute Service (ECS) instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Returns only ECS instances.</para>
        /// </description></item>
        /// <item><description><para>false: Returns only hosts that are not ECS instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AliyunHost")]
        [Validation(Required=false)]
        public bool? AliyunHost { get; set; }

        /// <summary>
        /// <para>The hostname.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hostNam1</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-a3d1q1pm2f9yr29e****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The region where the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("InstanceRegionId")]
        [Validation(Required=false)]
        public string InstanceRegionId { get; set; }

        /// <summary>
        /// <para>The keyword for a fuzzy search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>host1</para>
        /// </summary>
        [NameInMap("KeyWord")]
        [Validation(Required=false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <item><description><para>10</para>
        /// </description></item>
        /// <item><description><para>20</para>
        /// </description></item>
        /// <item><description><para>50</para>
        /// </description></item>
        /// <item><description><para>100</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Alibaba Cloud does not limit the maximum value of this parameter. However, setting this parameter to a large value may cause a timeout.</para>
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
        /// <para>A globally unique serial number is generated after the CloudMonitor agent is successfully installed on a host. Hosts that are not Alibaba Cloud instances do not have an instance ID, but have a serial number.</para>
        /// <remarks>
        /// <para>Use this parameter to find a specific monitored host.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a1ab31a3-1234-40f2-9e95-c8caa8f0****</para>
        /// </summary>
        [NameInMap("SerialNumbers")]
        [Validation(Required=false)]
        public string SerialNumbers { get; set; }

        /// <summary>
        /// <para>The status of the host. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Running: The host is running.</para>
        /// </description></item>
        /// <item><description><para>Stopped: The host is stopped, the agent is not installed, or the agent installation failed.</para>
        /// </description></item>
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
        /// <item><description><para>installing: SysOM is being enabled.</para>
        /// </description></item>
        /// <item><description><para>running: SysOM is running.</para>
        /// </description></item>
        /// <item><description><para>stopped: SysOM is stopped.</para>
        /// </description></item>
        /// <item><description><para>uninstalling: SysOM is being disabled.</para>
        /// </description></item>
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
