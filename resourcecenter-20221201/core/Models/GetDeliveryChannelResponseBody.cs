// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetDeliveryChannelResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the delivery channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a description.</para>
        /// </summary>
        [NameInMap("DeliveryChannelDescription")]
        [Validation(Required=false)]
        public string DeliveryChannelDescription { get; set; }

        /// <summary>
        /// <para>The effective scope of the delivery channel.</para>
        /// </summary>
        [NameInMap("DeliveryChannelFilter")]
        [Validation(Required=false)]
        public GetDeliveryChannelResponseBodyDeliveryChannelFilter DeliveryChannelFilter { get; set; }
        public class GetDeliveryChannelResponseBodyDeliveryChannelFilter : TeaModel {
            /// <summary>
            /// <para>The resource types that are delivered.</para>
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
        /// <para>17502A1B-7026-5551-8E1C-CCABD0CBC***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The settings for delivering resource configuration changes.</para>
        /// </summary>
        [NameInMap("ResourceChangeDelivery")]
        [Validation(Required=false)]
        public GetDeliveryChannelResponseBodyResourceChangeDelivery ResourceChangeDelivery { get; set; }
        public class GetDeliveryChannelResponseBodyResourceChangeDelivery : TeaModel {
            /// <summary>
            /// <para>Indicates whether to deliver resource configuration changes.</para>
            /// <para>Valid values:</para>
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
            /// <para>The Simple Log Service (SLS) configurations.</para>
            /// </summary>
            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public GetDeliveryChannelResponseBodyResourceChangeDeliverySlsProperties SlsProperties { get; set; }
            public class GetDeliveryChannelResponseBodyResourceChangeDeliverySlsProperties : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the Object Storage Service (OSS) bucket to which oversized data is delivered.</para>
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
        /// <para>The settings for the scheduled delivery of resource snapshots.</para>
        /// </summary>
        [NameInMap("ResourceSnapshotDelivery")]
        [Validation(Required=false)]
        public GetDeliveryChannelResponseBodyResourceSnapshotDelivery ResourceSnapshotDelivery { get; set; }
        public class GetDeliveryChannelResponseBodyResourceSnapshotDelivery : TeaModel {
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
            /// <para>The time when resource snapshots are delivered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>09:00Z</para>
            /// </summary>
            [NameInMap("DeliveryTime")]
            [Validation(Required=false)]
            public string DeliveryTime { get; set; }

            /// <summary>
            /// <para>Indicates whether to enable the scheduled delivery of resource snapshots.</para>
            /// <para>Valid values:</para>
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
            /// <para>The SLS configurations.</para>
            /// </summary>
            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public GetDeliveryChannelResponseBodyResourceSnapshotDeliverySlsProperties SlsProperties { get; set; }
            public class GetDeliveryChannelResponseBodyResourceSnapshotDeliverySlsProperties : TeaModel {
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
