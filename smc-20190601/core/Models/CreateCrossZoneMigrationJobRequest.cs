// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smc20190601.Models
{
    public class CreateCrossZoneMigrationJobRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): enables automatic payment. Make sure that you have sufficient balance within your account.</description></item>
        /// <item><description><b>false</b>: disables automatic payment. In this case, you must manually pay for the instance. For more information, see <a href="https://help.aliyun.com/document_detail/85052.html">Renew a subscription instance</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotency of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The disk list.</para>
        /// </summary>
        [NameInMap("Disk")]
        [Validation(Required=false)]
        public List<CreateCrossZoneMigrationJobRequestDisk> Disk { get; set; }
        public class CreateCrossZoneMigrationJobRequestDisk : TeaModel {
            /// <summary>
            /// <para>The disk category. A value of cloud_essd indicates enhanced SSD (ESSD).</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The disk ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-bp1eeplkn4j29wf7irpb</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// <item><description>PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.</description></item>
            /// <item><description>PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL0</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

        }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1ff25rzvnul6kr****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the destination Alibaba Cloud region.</para>
        /// <para>For example, if you want to migrate the source server to the China (Hangzhou) region, set this parameter to <c>cn-hangzhou</c>. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmw3ty5y7****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The type of the new instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g7.large</para>
        /// </summary>
        [NameInMap("TargetInstanceType")]
        [Validation(Required=false)]
        public string TargetInstanceType { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the destination Elastic Compute Service (ECS) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1mxqnssl8nafltcx32e</para>
        /// </summary>
        [NameInMap("TargetVSwitchId")]
        [Validation(Required=false)]
        public string TargetVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the destination zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("TargetZoneId")]
        [Validation(Required=false)]
        public string TargetZoneId { get; set; }

    }

}
