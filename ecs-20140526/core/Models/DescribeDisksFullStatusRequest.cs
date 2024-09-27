// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksFullStatusRequest : TeaModel {
        [NameInMap("EventTime")]
        [Validation(Required=false)]
        public DescribeDisksFullStatusRequestEventTime EventTime { get; set; }
        public class DescribeDisksFullStatusRequestEventTime : TeaModel {
            /// <summary>
            /// <para>The end of the time range to query occurred events.</para>
            /// <para>Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-08T02:48:52Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The beginning of the time range to query occurred events.</para>
            /// <para>Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-06T02:43:10Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <para>The ID of EBS device N. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public List<string> DiskId { get; set; }

        /// <summary>
        /// <para>The ID of event N. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public List<string> EventId { get; set; }

        /// <summary>
        /// <para>The event type of the EBS device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Degraded: The performance of the EBS device is degraded.</description></item>
        /// <item><description>SeverelyDegraded: The performance of the EBS device is severely degraded.</description></item>
        /// <item><description>Stalled: The performance of the EBS device is severely affected.</description></item>
        /// <item><description>ErrorDetected: The local disk is damaged.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stalled</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The health status of the EBS device. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Impaired: The EBS device is damaged.</description></item>
        /// <item><description>Warning: The performance of the EBS device is degraded.</description></item>
        /// <item><description>Initializing: The EBS device is being initialized.</description></item>
        /// <item><description>InsufficientData: The status cannot be determined due to insufficient data.</description></item>
        /// <item><description>NotApplicable: The EBS device cannot be used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Warning</para>
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. The value must be a positive integer.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the EBS device. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the EBS device belongs. If you configure this parameter to query resources, up to 1,000 resources that belong to the specified resource group can be displayed in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2kkmhmhs****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The lifecycle status of the EBS device. For more information, see <a href="https://help.aliyun.com/document_detail/25689.html">Disk status</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>In_use: The EBS device is in use.</description></item>
        /// <item><description>Available: The EBS device can be attached.</description></item>
        /// <item><description>Attaching: The EBS device is being attached.</description></item>
        /// <item><description>Detaching: The EBS device is being detached.</description></item>
        /// <item><description>Creating: The EBS device is being created.</description></item>
        /// <item><description>ReIniting: The EBS device is being initialized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags to add to the EBS device.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDisksFullStatusRequestTag> Tag { get; set; }
        public class DescribeDisksFullStatusRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the EBS device. A key-value pair consists of a key specified by the Tag.N.Key parameter and a value specified by the <c>Tag.N.Value</c> parameter. The two parameters are associated with each other. Valid values of N: 1 to 20.</para>
            /// <para>Up to 1,000 resources with the specified tags can be returned in the response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the EBS device. A key-value pair consists of a key specified by the <c>Tag.N.Key</c> parameter and a value specified by the Tag.N.Value parameter. The two parameters are associated with each other. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
