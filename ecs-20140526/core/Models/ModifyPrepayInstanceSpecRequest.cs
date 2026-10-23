// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyPrepayInstanceSpecRequest : TeaModel {
        [NameInMap("SystemDisk")]
        [Validation(Required=false)]
        public ModifyPrepayInstanceSpecRequestSystemDisk SystemDisk { get; set; }
        public class ModifyPrepayInstanceSpecRequestSystemDisk : TeaModel {
            /// <summary>
            /// <para>The new system disk category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_efficiency: ultra disk.</description></item>
            /// <item><description>cloud_ssd: standard SSD.<remarks>
            /// <para>This parameter is valid only when you upgrade from a <a href="https://help.aliyun.com/document_detail/55263.html">retired instance type</a> to a <a href="https://help.aliyun.com/document_detail/25378.html">normally sold instance family</a> and upgrade a non-I/O optimized instance type to an I/O optimized instance type.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_efficiency</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment when you upgrade the instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables automatic payment.</description></item>
        /// <item><description>false: generates the order without deducting fees.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When automatic payment is enabled, you must ensure that your payment method balance is sufficient. Otherwise, an abnormal order is generated and can only be canceled.</description></item>
        /// <item><description>If your payment method balance is insufficient, you can set <c>AutoPay</c> to <c>false</c> to generate an unpaid order. Then, you can log on to the ECS console to complete the payment.</description></item>
        /// <item><description>If the <c>OperatorType</c> parameter is set to <c>downgrade</c>, the <c>AutoPay</c> parameter is ignored.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
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
        public List<ModifyPrepayInstanceSpecRequestDisk> Disk { get; set; }
        public class ModifyPrepayInstanceSpecRequestDisk : TeaModel {
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
        /// <para>The end time of the temporary change. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.
        /// <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-01T12:05Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The target instance type for the upgrade or downgrade. For valid values, see <a href="https://help.aliyun.com/document_detail/25378.html">Instance families</a> or call the <a href="https://help.aliyun.com/document_detail/25620.html">DescribeInstanceTypes</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g5.xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether to allow cross-cluster instance type upgrade. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: yes.</description></item>
        /// <item><description>false: no.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <para>If the <c>MigrateAcrossZone</c> parameter is set to <c>true</c> and you upgrade the ECS instance based on the returned information, take note of the following items:</para>
        /// <para>VPC-connected instances: For <a href="https://help.aliyun.com/document_detail/55263.html">retired instance types</a>, when you upgrade a non-I/O optimized instance to an I/O optimized instance, the disk device names and software authorization codes of the ECS instance change. For Linux instances, basic disks (cloud) are identified as xvda or xvdb, and ultra disks (cloud_efficiency) and standard SSDs (cloud_ssd) are identified as vda or vdb.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MigrateAcrossZone")]
        [Validation(Required=false)]
        public bool? MigrateAcrossZone { get; set; }

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

        /// <summary>
        /// <para>The operation type. Valid values:</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter. The system automatically determines whether to upgrade or downgrade the instance type. If you specify this parameter, follow these rules:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>upgrade: upgrades the instance type. Make sure that your payment method balance is sufficient.</para>
        /// </description></item>
        /// <item><description><para>downgrade: downgrades the instance type. If the instance type specified by <c>InstanceType</c> is lower than the current instance type, set <c>OperatorType</c> to <c>downgrade</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For precautions about upgrading or downgrading instance types, see the preceding operation description section.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>upgrade</para>
        /// </summary>
        [NameInMap("OperatorType")]
        [Validation(Required=false)]
        public string OperatorType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The time to restart the instance. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mmZ format. The time must be in UTC.
        /// <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a></para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-01T12:05Z</para>
        /// </summary>
        [NameInMap("RebootTime")]
        [Validation(Required=false)]
        public string RebootTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to immediately restart the instance after the instance type change is complete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: yes.</description></item>
        /// <item><description>false: no.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>If the instance is in the <b>Stopped</b> state, it remains in the Stopped state and no action is performed even if you set <c>RebootWhenFinished</c> to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RebootWhenFinished")]
        [Validation(Required=false)]
        public bool? RebootWhenFinished { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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

    }

}
