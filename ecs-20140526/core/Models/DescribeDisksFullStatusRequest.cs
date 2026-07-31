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
            /// <para>The end of the time range during which to query events.</para>
            /// <para>Specify the time in the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-05-08T02:48:52Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The start of the time range during which to query events.</para>
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
        /// <para>The block storage ID. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public List<string> DiskId { get; set; }

        /// <summary>
        /// <para>The event ID. Valid values of N: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public List<string> EventId { get; set; }

        /// <summary>
        /// <para>The event type of the block storage device. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Degraded: The block storage performance is degraded.</description></item>
        /// <item><description>SeverelyDegraded: The block storage performance is severely degraded.</description></item>
        /// <item><description>Stalled: The block storage performance is severely impacted.</description></item>
        /// <item><description>ErrorDetected: A local disk is damaged.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stalled</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The health status of the block storage device. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Impaired: temporarily unreadable and unwritable.</description></item>
        /// <item><description>Warning: degraded service.</description></item>
        /// <item><description>Initializing: being initialized.</description></item>
        /// <item><description>InsufficientData: insufficient data.</description></item>
        /// <item><description>NotApplicable: not applicable.</description></item>
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
        /// <para>The page number of the query result. Valid values: positive integers.</para>
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
        /// <para>The region ID of the block storage device. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the block storage resource belongs. When you use this parameter to filter resources, the resource count cannot exceed 1,000.</para>
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
        /// <para>The lifecycle status of the block storage device. For more information, see <a href="https://help.aliyun.com/document_detail/25689.html">Disk status table</a>. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>In_use: in use.</description></item>
        /// <item><description>Available: to be attached.</description></item>
        /// <item><description>Attaching: being attached.</description></item>
        /// <item><description>Detaching: being detached.</description></item>
        /// <item><description>Creating: being created.</description></item>
        /// <item><description>ReIniting: being initialized.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDisksFullStatusRequestTag> Tag { get; set; }
        public class DescribeDisksFullStatusRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key attached to the block storage resource. N specifies that you can set one or more tag keys. The value of N in this parameter corresponds to the value of N in the <c>Tag.N.Value</c> parameter to form a key-value pair. Valid values of N: 1 to 20.</para>
            /// <para>If you use a single tag to filter resources, the number of resources with the tag cannot exceed 1,000. If you use multiple tags to filter resources, the number of resources that are attached to all specified tags cannot exceed 1,000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value attached to the block storage resource. N specifies that you can set one or more tag values. The value of N in this parameter corresponds to the value of N in the <c>Tag.N.Key</c> parameter to form a key-value pair. Valid values of N: 1 to 20.</para>
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
