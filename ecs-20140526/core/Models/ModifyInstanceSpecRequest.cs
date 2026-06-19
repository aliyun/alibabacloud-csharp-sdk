// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceSpecRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public ModifyInstanceSpecRequestSystemDisk SystemDisk { get; set; }
        public class ModifyInstanceSpecRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>更换系统盘类型。取值范围：</para>
            /// <list type="bullet">
            /// <item><description><para>cloud_efficiency：高效云盘</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd：SSD云盘</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>该参数只有在从<a href="https://help.aliyun.com/document_detail/55263.html">已停售的实例规格</a>升级到<a href="https://help.aliyun.com/document_detail/25378.html">正常售卖的实例规格族</a>，并将非I/O优化实例规格升级为I/O优化实例规格时有效。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

        }

        [NameInMap("Temporary")]
        [Validation(Required=false)]
        public ModifyInstanceSpecRequestTemporary Temporary { get; set; }
        public class ModifyInstanceSpecRequestTemporary : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>该参数正在邀测中，暂未开放使用。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>该参数正在邀测中，暂未开放使用。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("InternetMaxBandwidthOut")]
            [Validation(Required=false)]
            public int? InternetMaxBandwidthOut { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>该参数正在邀测中，暂未开放使用。</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to support cross-cluster instance type upgrade. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Cross-cluster instance type upgrade is supported.</description></item>
        /// <item><description>false: Cross-cluster instance type upgrade is not supported.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>If you set the parameter <c>AllowMigrateAcrossZone</c> to true and upgrade the Elastic Compute Service instance based on the response, take note of the following items:</para>
        /// <para>Classic network type instances:</para>
        /// <list type="bullet">
        /// <item><description><para>For <a href="https://help.aliyun.com/document_detail/55263.html">retired instance types</a>, when a non-I/O optimized instance is changed to an I/O optimized instance, the private IP address, disk device names, and software authorization codes of the instance change. For Linux instances, basic disks (<c>cloud</c>) are identified as <b>xvda</b> or <b>xvdb</b>, and ultra disks (<c>cloud_efficiency</c>) and standard SSDs (<c>cloud_ssd</c>) are identified as <b>vda</b> or <b>vdb</b>.</para>
        /// </description></item>
        /// <item><description><para>For <a href="https://help.aliyun.com/document_detail/25378.html">instance families that are available for purchase</a>, the private IP address of the instance changes.</para>
        /// </description></item>
        /// </list>
        /// <para>VPC-type instances: For <a href="https://help.aliyun.com/document_detail/55263.html">retired instance types</a>, when a non-I/O optimized instance is changed to an I/O optimized instance, the disk device names and software authorization codes of the instance change. For Linux instances, basic disks (<c>cloud</c>) are identified as <b>xvda</b> or <b>xvdb</b>, and ultra disks (<c>cloud_efficiency</c>) and standard SSDs (<c>cloud_ssd</c>) are identified as <b>vda</b> or <b>vdb</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowMigrateAcrossZone")]
        [Validation(Required=false)]
        public bool? AllowMigrateAcrossZone { get; set; }

        /// <summary>
        /// <para>Specifies whether to submit an asynchronous request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is submitted asynchronously.</description></item>
        /// <item><description>false: The request is not submitted asynchronously.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Disk")]
        [Validation(Required=false)]
        public List<ModifyInstanceSpecRequestDisk> Disk { get; set; }
        public class ModifyInstanceSpecRequestDisk : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The instance type and public bandwidth are not changed. The system checks whether the required parameters are specified, whether the request format is valid, whether business restrictions are met, and whether ECS resources are sufficient. If the check fails, the corresponding error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description>false (default): performs a dry run and sends the request. If the check succeeds, the instance type and public bandwidth are changed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The target instance type. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance family</a>. You can also call <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> to query the most recent instance type list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The maximum inbound public bandwidth. Unit: Mbit/s. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the purchased outbound public bandwidth is less than or equal to 10 Mbit/s: 1 to 10. Default value: 10.</description></item>
        /// <item><description>If the purchased outbound public bandwidth is greater than 10 Mbit/s: 1 to the value of <c>InternetMaxBandwidthOut</c>. Default value: the value of <c>InternetMaxBandwidthOut</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>In <b>pay-by-traffic</b> mode, the peak inbound and outbound bandwidths are used as upper limits of bandwidths instead of guaranteed performance. When resource contention occurs, the peak bandwidths may be limited. If your business requires guaranteed bandwidth, use the <b>pay-by-bandwidth</b> mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthIn")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// <para>The maximum outbound public bandwidth. Unit: Mbit/s. Valid values: 0 to 100.</para>
        /// <remarks>
        /// <para>In <b>pay-by-traffic</b> mode, the peak inbound and outbound bandwidths are used as upper limits of bandwidths instead of guaranteed performance. When resource contention occurs, the peak bandwidths may be limited. If your business requires guaranteed bandwidth, use the <b>pay-by-bandwidth</b> mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidthOut")]
        [Validation(Required=false)]
        public int? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
