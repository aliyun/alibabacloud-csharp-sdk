// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotPriceHistoryRequest : TeaModel {
        /// <summary>
        /// <para>The end time to query the historical prices of spot instances. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <para>Default value: empty. An empty value indicates the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-08-22T08:45:08Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.t1.xsmall</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>Specifies whether the spot instance is an I/O optimized instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>optimized: The spot instance is an I/O optimized instance.</para>
        /// </description></item>
        /// <item><description><para>none: The spot instance is a non-I/O optimized instance.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value for Generation I instances: none.</para>
        /// <para>Default value for other instance family types: optimized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("IoOptimized")]
        [Validation(Required=false)]
        public string IoOptimized { get; set; }

        /// <summary>
        /// <para>The network type of the spot instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>vpc: VPC.</description></item>
        /// <item><description>classic: classic network. This feature is retired. For more information, see <a href="https://help.aliyun.com/document_detail/2833134.html">Retirement notice</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The operating system platform of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>linux</description></item>
        /// <item><description>windows</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("OSType")]
        [Validation(Required=false)]
        public string OSType { get; set; }

        /// <summary>
        /// <para>The starting row for the query.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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

        /// <summary>
        /// <para>The protection period of the spot instance. Unit: hours. Default value: 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Alibaba Cloud guarantees that the instance is not automatically released within 1 hour after it is created. After 1 hour, the system automatically compares your bid with the market price and checks resource inventory to determine whether to retain or revoke the instance.</description></item>
        /// <item><description>0: Alibaba Cloud does not guarantee that the instance runs for 1 hour after it is created. The system automatically compares your bid with the market price and checks resource inventory to determine whether to retain or revoke the instance.</description></item>
        /// </list>
        /// <para>Alibaba Cloud sends you a notification through an ECS system event 5 minutes before the instance is revoked. Spot instances are billed by the second. Select an appropriate protection period based on the execution duration of specific tasks.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit or SpotAsPriceGo.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SpotDuration")]
        [Validation(Required=false)]
        public int? SpotDuration { get; set; }

        /// <summary>
        /// <para>The start time to query the historical prices of spot instances. The time span between the start time and the specified end time cannot exceed 30 days. Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <para>Default value: empty. An empty value indicates 3 hours before the end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-08-22T08:45:08Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-g</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
