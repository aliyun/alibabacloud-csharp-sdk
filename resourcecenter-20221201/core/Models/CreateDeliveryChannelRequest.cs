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
        /// 
        /// <b>Example:</b>
        /// <para>测试投递</para>
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
            /// <para>The list of resource types to be delivered.</para>
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
        /// <para>The delivery of resource configuration changes.</para>
        /// </summary>
        [NameInMap("ResourceChangeDelivery")]
        [Validation(Required=false)]
        public CreateDeliveryChannelRequestResourceChangeDelivery ResourceChangeDelivery { get; set; }
        public class CreateDeliveryChannelRequestResourceChangeDelivery : TeaModel {
            /// <summary>
            /// <para>The SLS configurations.</para>
            /// </summary>
            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public CreateDeliveryChannelRequestResourceChangeDeliverySlsProperties SlsProperties { get; set; }
            public class CreateDeliveryChannelRequestResourceChangeDeliverySlsProperties : TeaModel {
                /// <summary>
                /// <para>The ARN of the destination OSS bucket for oversized files.</para>
                /// <para>If the size of a resource configuration change event exceeds 1 MB, the event is delivered as an OSS object. Set this parameter to the ARN of an OSS bucket that has the <c>resourcecenter-</c> prefix.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:oss:cn-hangzhou:191142248777****:resourcecenter-oss</para>
                /// </summary>
                [NameInMap("OversizedDataOssTargetArn")]
                [Validation(Required=false)]
                public string OversizedDataOssTargetArn { get; set; }

            }

            /// <summary>
            /// <para>The ARN of the destination. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If you set <c>TargetType</c> to <c>OSS</c>, set <c>TargetArn</c> to the ARN of an OSS bucket that has the <c>resourcecenter-</c> prefix.</para>
            /// </description></item>
            /// <item><description><para>If you set <c>TargetType</c> to <c>SLS</c>, set <c>TargetArn</c> to the ARN of an SLS Logstore that has the <c>resourcecenter-</c> prefix.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acs:log:cn-hangzhou: 191142248777****:project/delivery/logstore/resourcecenter-sls</para>
            /// </summary>
            [NameInMap("TargetArn")]
            [Validation(Required=false)]
            public string TargetArn { get; set; }

            /// <summary>
            /// <para>The type of the destination.</para>
            /// <para>Valid value: <c>SLS</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SLS</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>The scheduled delivery of resource snapshots.</para>
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
            /// <para>The SLS configurations.</para>
            /// </summary>
            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public CreateDeliveryChannelRequestResourceSnapshotDeliverySlsProperties SlsProperties { get; set; }
            public class CreateDeliveryChannelRequestResourceSnapshotDeliverySlsProperties : TeaModel {
                /// <summary>
                /// <para>The ARN of the destination OSS bucket for oversized files.</para>
                /// <para>If the size of a resource configuration change event exceeds 1 MB, the event is delivered as an OSS object. Set this parameter to the ARN of an OSS bucket that has the <c>resourcecenter-</c> prefix.</para>
                /// <remarks>
                /// <para>This parameter is valid only for custom scheduled delivery. You do not need to specify this parameter for standard scheduled delivery.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>acs:oss:cn-hangzhou:191142248777****:resourcecenter-oss</para>
                /// </summary>
                [NameInMap("OversizedDataOssTargetArn")]
                [Validation(Required=false)]
                public string OversizedDataOssTargetArn { get; set; }

            }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the destination. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>If you set <c>TargetType</c> to <c>OSS</c>, set <c>TargetArn</c> to the ARN of an Object Storage Service (OSS) bucket that has the <c>resourcecenter-</c> prefix. Example: <c>acs:oss:cn-hangzhou:191142248777****:resourcecenter-oss</c>.</para>
            /// </description></item>
            /// <item><description><para>If you set <c>TargetType</c> to <c>SLS</c>, set <c>TargetArn</c> to the ARN of a Simple Log Service (SLS) Logstore that has the <c>resourcecenter-</c> prefix. Example: <c>acs:log:cn-hangzhou: 191142248777****:project/delivery/logstore/resourcecenter-sls</c>.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acs:log:cn-hangzhou: 191142248777****:project/delivery/logstore/resourcecenter-sls</para>
            /// </summary>
            [NameInMap("TargetArn")]
            [Validation(Required=false)]
            public string TargetArn { get; set; }

            /// <summary>
            /// <para>The type of the destination. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>For standard scheduled delivery, set this parameter to <c>OSS</c>.</para>
            /// </description></item>
            /// <item><description><para>For custom scheduled delivery, set this parameter to <c>OSS</c> or <c>SLS</c>.</para>
            /// </description></item>
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
