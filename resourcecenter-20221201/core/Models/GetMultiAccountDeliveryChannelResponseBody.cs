// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetMultiAccountDeliveryChannelResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the delivery channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>投递描述</para>
        /// </summary>
        [NameInMap("DeliveryChannelDescription")]
        [Validation(Required=false)]
        public string DeliveryChannelDescription { get; set; }

        /// <summary>
        /// <para>The effective scope of the delivery channel.</para>
        /// </summary>
        [NameInMap("DeliveryChannelFilter")]
        [Validation(Required=false)]
        public GetMultiAccountDeliveryChannelResponseBodyDeliveryChannelFilter DeliveryChannelFilter { get; set; }
        public class GetMultiAccountDeliveryChannelResponseBodyDeliveryChannelFilter : TeaModel {
            /// <summary>
            /// <para>The accounts within the delivery scope.</para>
            /// </summary>
            [NameInMap("AccountScopes")]
            [Validation(Required=false)]
            public List<string> AccountScopes { get; set; }

            /// <summary>
            /// <para>The types of delivered resources.</para>
            /// </summary>
            [NameInMap("ResourceTypes")]
            [Validation(Required=false)]
            public List<string> ResourceTypes { get; set; }

        }

        /// <summary>
        /// <para>The ID of the delivery channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-6q79dm4o9***</para>
        /// </summary>
        [NameInMap("DeliveryChannelId")]
        [Validation(Required=false)]
        public string DeliveryChannelId { get; set; }

        /// <summary>
        /// <para>The name of the delivery channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-delivery-channel</para>
        /// </summary>
        [NameInMap("DeliveryChannelName")]
        [Validation(Required=false)]
        public string DeliveryChannelName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FE3EAB47-D3A6-5FEA-8353-31C8C0D36***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The delivery of resource configuration changes.</para>
        /// </summary>
        [NameInMap("ResourceChangeDelivery")]
        [Validation(Required=false)]
        public GetMultiAccountDeliveryChannelResponseBodyResourceChangeDelivery ResourceChangeDelivery { get; set; }
        public class GetMultiAccountDeliveryChannelResponseBodyResourceChangeDelivery : TeaModel {
            /// <summary>
            /// <para>Indicates whether to deliver resource configuration changes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public string Enabled { get; set; }

            /// <summary>
            /// <para>The Simple Log Service (SLS) configuration.</para>
            /// </summary>
            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public GetMultiAccountDeliveryChannelResponseBodyResourceChangeDeliverySlsProperties SlsProperties { get; set; }
            public class GetMultiAccountDeliveryChannelResponseBodyResourceChangeDeliverySlsProperties : TeaModel {
                /// <summary>
                /// <para>The ARN of the Object Storage Service (OSS) bucket to which oversized data is delivered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:oss:cn-hangzhou:1911422487776***:resourcecenter-oss</para>
                /// </summary>
                [NameInMap("OversizedDataOssTargetArn")]
                [Validation(Required=false)]
                public string OversizedDataOssTargetArn { get; set; }

            }

            /// <summary>
            /// <para>The ARN of the delivery destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:log:cn-hangzhou: 1911422487776***:project/delivery/logstore/resourcecenter-sls</para>
            /// </summary>
            [NameInMap("TargetArn")]
            [Validation(Required=false)]
            public string TargetArn { get; set; }

            /// <summary>
            /// <para>The type of the delivery destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SLS</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        /// <summary>
        /// <para>The configurations of scheduled delivery of resource snapshots.</para>
        /// </summary>
        [NameInMap("ResourceSnapshotDelivery")]
        [Validation(Required=false)]
        public GetMultiAccountDeliveryChannelResponseBodyResourceSnapshotDelivery ResourceSnapshotDelivery { get; set; }
        public class GetMultiAccountDeliveryChannelResponseBodyResourceSnapshotDelivery : TeaModel {
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
            /// <para>Indicates whether to enable the scheduled delivery of resource snapshots. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public string Enabled { get; set; }

            /// <summary>
            /// <para>The SLS configuration.</para>
            /// </summary>
            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public GetMultiAccountDeliveryChannelResponseBodyResourceSnapshotDeliverySlsProperties SlsProperties { get; set; }
            public class GetMultiAccountDeliveryChannelResponseBodyResourceSnapshotDeliverySlsProperties : TeaModel {
                /// <summary>
                /// <para>The ARN of the OSS bucket to which oversized data is delivered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:oss:cn-hangzhou:1911422487776***:resourcecenter-oss</para>
                /// </summary>
                [NameInMap("OversizedDataOssTargetArn")]
                [Validation(Required=false)]
                public string OversizedDataOssTargetArn { get; set; }

            }

            /// <summary>
            /// <para>The ARN of the delivery destination.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:oss:cn-hangzhou:1911422487776***:resourcecenter-oss</para>
            /// </summary>
            [NameInMap("TargetArn")]
            [Validation(Required=false)]
            public string TargetArn { get; set; }

            /// <summary>
            /// <para>The type of the delivery destination.</para>
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
