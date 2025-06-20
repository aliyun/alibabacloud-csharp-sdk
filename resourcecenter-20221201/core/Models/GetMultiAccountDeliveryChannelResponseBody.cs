// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetMultiAccountDeliveryChannelResponseBody : TeaModel {
        [NameInMap("DeliveryChannelDescription")]
        [Validation(Required=false)]
        public string DeliveryChannelDescription { get; set; }

        [NameInMap("DeliveryChannelFilter")]
        [Validation(Required=false)]
        public GetMultiAccountDeliveryChannelResponseBodyDeliveryChannelFilter DeliveryChannelFilter { get; set; }
        public class GetMultiAccountDeliveryChannelResponseBodyDeliveryChannelFilter : TeaModel {
            [NameInMap("AccountScopes")]
            [Validation(Required=false)]
            public List<string> AccountScopes { get; set; }

            [NameInMap("ResourceTypes")]
            [Validation(Required=false)]
            public List<string> ResourceTypes { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dc-6q79dm4o9***</para>
        /// </summary>
        [NameInMap("DeliveryChannelId")]
        [Validation(Required=false)]
        public string DeliveryChannelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-delivery-channel</para>
        /// </summary>
        [NameInMap("DeliveryChannelName")]
        [Validation(Required=false)]
        public string DeliveryChannelName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>FE3EAB47-D3A6-5FEA-8353-31C8C0D36***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceChangeDelivery")]
        [Validation(Required=false)]
        public GetMultiAccountDeliveryChannelResponseBodyResourceChangeDelivery ResourceChangeDelivery { get; set; }
        public class GetMultiAccountDeliveryChannelResponseBodyResourceChangeDelivery : TeaModel {
            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public GetMultiAccountDeliveryChannelResponseBodyResourceChangeDeliverySlsProperties SlsProperties { get; set; }
            public class GetMultiAccountDeliveryChannelResponseBodyResourceChangeDeliverySlsProperties : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>acs:oss:cn-hangzhou:1911422487776***:resourcecenter-oss</para>
                /// </summary>
                [NameInMap("OversizedDataOssTargetArn")]
                [Validation(Required=false)]
                public string OversizedDataOssTargetArn { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:log:cn-hangzhou: 1911422487776***:project/delivery/logstore/resourcecenter-sls</para>
            /// </summary>
            [NameInMap("TargetArn")]
            [Validation(Required=false)]
            public string TargetArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SLS</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

        [NameInMap("ResourceSnapshotDelivery")]
        [Validation(Required=false)]
        public GetMultiAccountDeliveryChannelResponseBodyResourceSnapshotDelivery ResourceSnapshotDelivery { get; set; }
        public class GetMultiAccountDeliveryChannelResponseBodyResourceSnapshotDelivery : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>select * from resources limit 100;</para>
            /// </summary>
            [NameInMap("CustomExpression")]
            [Validation(Required=false)]
            public string CustomExpression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>09:00Z</para>
            /// </summary>
            [NameInMap("DeliveryTime")]
            [Validation(Required=false)]
            public string DeliveryTime { get; set; }

            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public GetMultiAccountDeliveryChannelResponseBodyResourceSnapshotDeliverySlsProperties SlsProperties { get; set; }
            public class GetMultiAccountDeliveryChannelResponseBodyResourceSnapshotDeliverySlsProperties : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>acs:oss:cn-hangzhou:1911422487776***:resourcecenter-oss</para>
                /// </summary>
                [NameInMap("OversizedDataOssTargetArn")]
                [Validation(Required=false)]
                public string OversizedDataOssTargetArn { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:oss:cn-hangzhou:1911422487776***:resourcecenter-oss</para>
            /// </summary>
            [NameInMap("TargetArn")]
            [Validation(Required=false)]
            public string TargetArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

        }

    }

}
