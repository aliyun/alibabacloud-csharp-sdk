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
            /// <para>The new category of the system cloud disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>cloud_efficiency: ultra cloud disk</para>
            /// </description></item>
            /// <item><description><para>cloud_ssd: standard SSD</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is valid only when you upgrade a <a href="https://help.aliyun.com/document_detail/55263.html">phased-out instance type</a> to an <a href="https://help.aliyun.com/document_detail/25378.html">available instance family</a> and change a non-I/O optimized instance type to an I/O optimized instance type.</para>
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
            /// <para>This parameter is in invitational preview and is not available.</para>
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
            /// <para>This parameter is in invitational preview and is not available.</para>
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
            /// <para>This parameter is in invitational preview and is not available.</para>
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
        /// <para>Specifies whether to allow cross-cluster network type upgrades. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>When the <c>AllowMigrateAcrossZone</c> parameter is set to true, take note of the following precautions after you upgrade the instance based on the returned information:</para>
        /// <para>Classic network instances:</para>
        /// <list type="bullet">
        /// <item><description><para>For <a href="https://help.aliyun.com/document_detail/55263.html">phased-out network types</a>, when a non-I/O optimized instance is changed to an I/O optimized instance, the private IP address, disk device names, and software license codes of the instance change. For Linux instances, basic cloud disks (<c>cloud</c>) are identified as <b>xvda</b> or <b>xvdb</b>, and ultra cloud disks (<c>cloud_efficiency</c>) and standard SSDs (<c>cloud_ssd</c>) are identified as <b>vda</b> or <b>vdb</b>.</para>
        /// </description></item>
        /// <item><description><para>For <a href="https://help.aliyun.com/document_detail/25378.html">available instance families</a>, the private IP address of the instance changes.</para>
        /// </description></item>
        /// </list>
        /// <para>VPC instances: For <a href="https://help.aliyun.com/document_detail/55263.html">phased-out network types</a>, when a non-I/O optimized instance is changed to an I/O optimized instance, the disk device names and software license codes of the instance change. For Linux instances, basic cloud disks (<c>cloud</c>) are identified as <b>xvda</b> or <b>xvdb</b>, and ultra cloud disks (<c>cloud_efficiency</c>) and standard SSDs (<c>cloud_ssd</c>) are identified as <b>vda</b> or <b>vdb</b>.</para>
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
        /// <item><description>true: Yes.</description></item>
        /// <item><description>false: No.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not available.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Disk")]
        [Validation(Required=false)]
        public List<ModifyInstanceSpecRequestDisk> Disk { get; set; }
        public class ModifyInstanceSpecRequestDisk : TeaModel {
            /// <summary>
            /// <remarks>
            /// <para>This parameter is not available.</para>
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
            /// <para>This parameter is not available.</para>
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
            /// <para>This parameter is not available.</para>
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
        /// <para>Specifies whether to perform only a dry run on the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run and does not modify the instance type or Internet bandwidth of the instance. The system checks whether required parameters are specified, the request format, service limits, and ECS inventory. If the check fails, the corresponding error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description>false (default): sends a normal request. After the check succeeds, the instance type and Internet bandwidth of the instance are directly modified.</description></item>
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
        /// <para>The target instance type of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a>. You can also call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation to obtain the latest instance type list.</para>
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
        /// <para>The peak inbound and outbound bandwidth values in the <b>pay-by-traffic</b> billing mode are upper limits and are not guaranteed service level indicators. When resource contention occurs, the peak bandwidth may be limited. If your business requires guaranteed bandwidth, use the <b>pay-by-bandwidth</b> billing mode.</para>
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
        /// <para>The peak inbound and outbound bandwidth values in the <b>pay-by-traffic</b> billing mode are upper limits and are not guaranteed service level indicators. When resource contention occurs, the peak bandwidth may be limited. If your business requires guaranteed bandwidth, use the <b>pay-by-bandwidth</b> billing mode.</para>
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
        /// <para>This parameter is not available.</para>
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
