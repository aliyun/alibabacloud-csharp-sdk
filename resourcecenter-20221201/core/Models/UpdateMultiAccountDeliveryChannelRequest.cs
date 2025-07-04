// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class UpdateMultiAccountDeliveryChannelRequest : TeaModel {
        /// <summary>
        /// <para>The description of the delivery channel.</para>
        /// </summary>
        [NameInMap("DeliveryChannelDescription")]
        [Validation(Required=false)]
        public string DeliveryChannelDescription { get; set; }

        /// <summary>
        /// <para>The effective scope of the delivery channel.</para>
        /// </summary>
        [NameInMap("DeliveryChannelFilter")]
        [Validation(Required=false)]
        public UpdateMultiAccountDeliveryChannelRequestDeliveryChannelFilter DeliveryChannelFilter { get; set; }
        public class UpdateMultiAccountDeliveryChannelRequestDeliveryChannelFilter : TeaModel {
            /// <summary>
            /// <para>An array of effective account scopes for the delivery channel.</para>
            /// </summary>
            [NameInMap("AccountScopes")]
            [Validation(Required=false)]
            public List<string> AccountScopes { get; set; }

            /// <summary>
            /// <para>The effective resource types of the delivery channel.</para>
            /// </summary>
            [NameInMap("ResourceTypes")]
            [Validation(Required=false)]
            public List<string> ResourceTypes { get; set; }

        }

        /// <summary>
        /// <para>The ID of the delivery channel.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-4m6ffpkgu***</para>
        /// </summary>
        [NameInMap("DeliveryChannelId")]
        [Validation(Required=false)]
        public string DeliveryChannelId { get; set; }

        /// <summary>
        /// <para>The name of the delivery channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-multi-account-delivery-channel</para>
        /// </summary>
        [NameInMap("DeliveryChannelName")]
        [Validation(Required=false)]
        public string DeliveryChannelName { get; set; }

        /// <summary>
        /// <para>The configurations for delivery of resource configuration change events.</para>
        /// </summary>
        [NameInMap("ResourceChangeDelivery")]
        [Validation(Required=false)]
        public UpdateMultiAccountDeliveryChannelRequestResourceChangeDelivery ResourceChangeDelivery { get; set; }
        public class UpdateMultiAccountDeliveryChannelRequestResourceChangeDelivery : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable delivery of resource configuration change events. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public string Enabled { get; set; }

            /// <summary>
            /// <para>The Simple Log Service configurations.</para>
            /// </summary>
            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public UpdateMultiAccountDeliveryChannelRequestResourceChangeDeliverySlsProperties SlsProperties { get; set; }
            public class UpdateMultiAccountDeliveryChannelRequestResourceChangeDeliverySlsProperties : TeaModel {
                /// <summary>
                /// <para>The ARN of the destination to which large files are delivered.</para>
                /// <para>If the size of a resource configuration change event exceeds 1 MB, the event is delivered as an OSS object. You need to set this parameter to the ARN of a bucket whose name is prefixed with <c>resourcecenter-</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:oss:cn-hangzhou:1911422487776***:resourcecenter-oss</para>
                /// </summary>
                [NameInMap("OversizedDataOssTargetArn")]
                [Validation(Required=false)]
                public string OversizedDataOssTargetArn { get; set; }

            }

            /// <summary>
            /// <para>The ARN of the delivery destination. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If you set <c>TargetType</c> to <c>OSS</c>, you must set <c>TargetArn</c> to the ARN of a bucket whose name is prefixed with <c>resourcecenter-</c>.</description></item>
            /// <item><description>If you set <c>TargetType</c> to <c>SLS</c>, you must set <c>TargetArn</c> to the ARN of a Logstore whose name is prefixed with <c>resourcecenter-</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acs:log:cn-hangzhou: 1911422487776***:project/delivery/logstore/resourcecenter-sls</para>
            /// </summary>
            [NameInMap("TargetArn")]
            [Validation(Required=false)]
            public string TargetArn { get; set; }

            /// <summary>
            /// <para>The type of the delivery destination.</para>
            /// <para>Set the value to <c>SLS</c>.</para>
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
        public UpdateMultiAccountDeliveryChannelRequestResourceSnapshotDelivery ResourceSnapshotDelivery { get; set; }
        public class UpdateMultiAccountDeliveryChannelRequestResourceSnapshotDelivery : TeaModel {
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
            /// <para>Specifies whether to enable delivery of scheduled resource snapshots. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public string Enabled { get; set; }

            /// <summary>
            /// <para>The Simple Log Service configurations.</para>
            /// </summary>
            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public UpdateMultiAccountDeliveryChannelRequestResourceSnapshotDeliverySlsProperties SlsProperties { get; set; }
            public class UpdateMultiAccountDeliveryChannelRequestResourceSnapshotDeliverySlsProperties : TeaModel {
                /// <summary>
                /// <para>The ARN of the destination to which large files are delivered.</para>
                /// <para>If the size of a resource configuration change event exceeds 1 MB, the event is delivered as an OSS object. You need to set this parameter to the ARN of a bucket whose name is prefixed with <c>resourcecenter-</c>.</para>
                /// <remarks>
                /// <para> This parameter takes effect only if you use custom delivery for scheduled resource snapshots. You do not need to configure this parameter if you use standard delivery for scheduled resource snapshots.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>acs:oss:cn-hangzhou:1911422487776***:resourcecenter-oss</para>
                /// </summary>
                [NameInMap("OversizedDataOssTargetArn")]
                [Validation(Required=false)]
                public string OversizedDataOssTargetArn { get; set; }

            }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the delivery destination. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>If you set <c>TargetType</c> to <c>OSS</c>, you must set <c>TargetArn</c> to the ARN of a bucket whose name is prefixed with <c>resourcecenter-</c>. Example: <c>acs:oss:cn-hangzhou:191142248777****:resourcecenter-oss</c>.</description></item>
            /// <item><description>If you set <c>TargetType</c> to <c>SLS</c>, you must set <c>TargetArn</c> to the ARN of a Logstore whose name is prefixed with <c>resourcecenter-</c>. Example: <c>acs:log:cn-hangzhou: 191142248777****:project/delivery/logstore/resourcecenter-sls</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>acs:oss:cn-hangzhou:1911422487776***:resourcecenter-oss</para>
            /// </summary>
            [NameInMap("TargetArn")]
            [Validation(Required=false)]
            public string TargetArn { get; set; }

            /// <summary>
            /// <para>The type of the delivery destination. Valid values:</para>
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
