// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class CreateDeliveryChannelRequest : TeaModel {
        /// <summary>
        /// <para>The description of the delivery channel.</para>
        /// </summary>
        [NameInMap("DeliveryChannelDescription")]
        [Validation(Required=false)]
        public string DeliveryChannelDescription { get; set; }

        /// <summary>
        /// <para>The effective scope of the delivery channel.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeliveryChannelFilter")]
        [Validation(Required=false)]
        public CreateDeliveryChannelRequestDeliveryChannelFilter DeliveryChannelFilter { get; set; }
        public class CreateDeliveryChannelRequestDeliveryChannelFilter : TeaModel {
            /// <summary>
            /// <para>An array of effective resource types for the delivery channel.</para>
            /// <list type="bullet">
            /// <item><description>Example: [&quot;ACS::VPC::VPC&quot;, &quot;ACS::ECS::Instance&quot;].</description></item>
            /// <item><description>If you want to deliver items of all resource types supported by Resource Center, set this parameter to [&quot;ALL&quot;].</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ResourceTypes")]
            [Validation(Required=false)]
            public List<string> ResourceTypes { get; set; }

        }

        /// <summary>
        /// <para>The name of the delivery channel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-delivery</para>
        /// </summary>
        [NameInMap("DeliveryChannelName")]
        [Validation(Required=false)]
        public string DeliveryChannelName { get; set; }

        /// <summary>
        /// <para>The configurations for delivery of resource configuration change events.</para>
        /// </summary>
        [NameInMap("ResourceChangeDelivery")]
        [Validation(Required=false)]
        public CreateDeliveryChannelRequestResourceChangeDelivery ResourceChangeDelivery { get; set; }
        public class CreateDeliveryChannelRequestResourceChangeDelivery : TeaModel {
            /// <summary>
            /// <para>The Simple Log Service configurations.</para>
            /// </summary>
            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public CreateDeliveryChannelRequestResourceChangeDeliverySlsProperties SlsProperties { get; set; }
            public class CreateDeliveryChannelRequestResourceChangeDeliverySlsProperties : TeaModel {
                /// <summary>
                /// <para>The ARN of the destination to which large files are delivered.</para>
                /// <list type="bullet">
                /// <item><description>If the size of a resource configuration change event exceeds 1 MB, the event is delivered as an OSS object.</description></item>
                /// <item><description>You need to set this parameter to the ARN of a bucket whose name is prefixed with resourcecenter-.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>acs:oss:cn-hangzhou:191142248777****:resourcecenter-oss</para>
                /// </summary>
                [NameInMap("OversizedDataOssTargetArn")]
                [Validation(Required=false)]
                public string OversizedDataOssTargetArn { get; set; }

            }

            /// <summary>
            /// <para>The ARN of the delivery destination.</para>
            /// <list type="bullet">
            /// <item><description>If you set <c>TargetType</c> to <c>OSS</c>, you must set <c>TargetArn</c> to the ARN of a bucket whose name is prefixed with resourcecenter-.</description></item>
            /// <item><description>If you set <c>TargetType</c> to <c>SLS</c>, you must set <c>TargetArn</c> to the ARN of a Logstore whose name is prefixed with resourcecenter-.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acs:log:cn-hangzhou: 191142248777****:project/delivery/logstore/resourcecenter-sls</para>
            /// </summary>
            [NameInMap("TargetArn")]
            [Validation(Required=false)]
            public string TargetArn { get; set; }

            /// <summary>
            /// <para>The type of the delivery destination.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>SLS</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SLS</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>The configurations for delivery of scheduled resource snapshots.</para>
        /// </summary>
        [NameInMap("ResourceSnapshotDelivery")]
        [Validation(Required=false)]
        public CreateDeliveryChannelRequestResourceSnapshotDelivery ResourceSnapshotDelivery { get; set; }
        public class CreateDeliveryChannelRequestResourceSnapshotDelivery : TeaModel {
            /// <summary>
            /// <para>The custom expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>select * from resources limit 100;</para>
            /// </summary>
            [NameInMap("CustomExpression")]
            [Validation(Required=false)]
            public string CustomExpression { get; set; }

            /// <summary>
            /// <para>The delivery time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>09:00Z</para>
            /// </summary>
            [NameInMap("DeliveryTime")]
            [Validation(Required=false)]
            public string DeliveryTime { get; set; }

            /// <summary>
            /// <para>The Simple Log Service configurations.</para>
            /// </summary>
            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public CreateDeliveryChannelRequestResourceSnapshotDeliverySlsProperties SlsProperties { get; set; }
            public class CreateDeliveryChannelRequestResourceSnapshotDeliverySlsProperties : TeaModel {
                /// <summary>
                /// <para>The ARN of the destination to which large files are delivered.</para>
                /// <list type="bullet">
                /// <item><description>If the size of a resource configuration change event exceeds 1 MB, the event is delivered as an OSS object.</description></item>
                /// <item><description>You need to set this parameter to the ARN of a bucket whose name is prefixed with resourcecenter-.</description></item>
                /// <item><description>This parameter takes effect only if you use custom delivery for scheduled resource snapshots. You do not need to configure this parameter if you use standard delivery for scheduled resource snapshots.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>acs:oss:cn-hangzhou:191142248777****:resourcecenter-oss</para>
                /// </summary>
                [NameInMap("OversizedDataOssTargetArn")]
                [Validation(Required=false)]
                public string OversizedDataOssTargetArn { get; set; }

            }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the delivery destination.</para>
            /// <list type="bullet">
            /// <item><description>If you set <c>TargetType</c> to <c>OSS</c>, you must set <c>TargetArn</c> to the ARN of a bucket whose name is prefixed with resourcecenter-.</description></item>
            /// <item><description>If you set <c>TargetType</c> to <c>SLS</c>, you must set <c>TargetArn</c> to the ARN of a Logstore whose name is prefixed with resourcecenter-.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acs:log:cn-hangzhou: 191142248777****:project/delivery/logstore/resourcecenter-sls</para>
            /// </summary>
            [NameInMap("TargetArn")]
            [Validation(Required=false)]
            public string TargetArn { get; set; }

            /// <summary>
            /// <para>The type of the delivery destination.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>OSS</c> for standard delivery</description></item>
            /// <item><description><c>OSS</c> or <c>SLS</c> for custom delivery</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}
