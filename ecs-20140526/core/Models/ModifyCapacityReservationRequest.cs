// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyCapacityReservationRequest : TeaModel {
        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public ModifyCapacityReservationRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class ModifyCapacityReservationRequestPrivatePoolOptions : TeaModel {
            /// <summary>
            /// <para>The ID of the capacity reservation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crp-bp67acfmxazb4****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the capacity reservation. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. It can contain digits, colons (:), underscores (_), or hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>eapTestName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The description of the capacity reservation. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The expiration time of the capacity reservation. This parameter takes effect only when <c>EndTimeType=Limited</c>. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-10-30T06:32:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The expiration method of the capacity reservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Limited: The capacity reservation is released at a specified time. You must also specify the <c>EndTime</c> parameter.</description></item>
        /// <item><description>Unlimited: The capacity reservation is released by manual release. No time limit is imposed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Unlimited</para>
        /// </summary>
        [NameInMap("EndTimeType")]
        [Validation(Required=false)]
        public string EndTimeType { get; set; }

        /// <summary>
        /// <para>The total number of instances that the capacity reservation needs to reserve. Valid values: the number of used instances to 1000.</para>
        /// <remarks>
        /// <para>When you increase the total number of instances, the operation may fail due to insufficient inventory.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("InstanceAmount")]
        [Validation(Required=false)]
        public int? InstanceAmount { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The operating system type of the image used by the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Windows: Windows Server operating system.</description></item>
        /// <item><description>Linux: Linux and Unix-like operating system.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The ID of the region where the capacity reservation resides. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
        /// <para>The method by which the capacity reservation takes effect. Currently, only immediate activation is supported, and you do not need to specify a value for this parameter.</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, the capacity reservation takes effect immediately.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Now</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
