// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class UpdateMultiAccountDeliveryChannelRequest : TeaModel {
        [NameInMap("DeliveryChannelDescription")]
        [Validation(Required=false)]
        public string DeliveryChannelDescription { get; set; }

        [NameInMap("DeliveryChannelFilter")]
        [Validation(Required=false)]
        public UpdateMultiAccountDeliveryChannelRequestDeliveryChannelFilter DeliveryChannelFilter { get; set; }
        public class UpdateMultiAccountDeliveryChannelRequestDeliveryChannelFilter : TeaModel {
            [NameInMap("AccountScopes")]
            [Validation(Required=false)]
            public List<string> AccountScopes { get; set; }

            [NameInMap("ResourceTypes")]
            [Validation(Required=false)]
            public List<string> ResourceTypes { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dc-4m6ffpkgu***</para>
        /// </summary>
        [NameInMap("DeliveryChannelId")]
        [Validation(Required=false)]
        public string DeliveryChannelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-multi-account-delivery-channel</para>
        /// </summary>
        [NameInMap("DeliveryChannelName")]
        [Validation(Required=false)]
        public string DeliveryChannelName { get; set; }

        [NameInMap("ResourceChangeDelivery")]
        [Validation(Required=false)]
        public UpdateMultiAccountDeliveryChannelRequestResourceChangeDelivery ResourceChangeDelivery { get; set; }
        public class UpdateMultiAccountDeliveryChannelRequestResourceChangeDelivery : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public string Enabled { get; set; }

            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public UpdateMultiAccountDeliveryChannelRequestResourceChangeDeliverySlsProperties SlsProperties { get; set; }
            public class UpdateMultiAccountDeliveryChannelRequestResourceChangeDeliverySlsProperties : TeaModel {
                [NameInMap("OversizedDataOssTargetArn")]
                [Validation(Required=false)]
                public string OversizedDataOssTargetArn { get; set; }

            }

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
        public UpdateMultiAccountDeliveryChannelRequestResourceSnapshotDelivery ResourceSnapshotDelivery { get; set; }
        public class UpdateMultiAccountDeliveryChannelRequestResourceSnapshotDelivery : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public string Enabled { get; set; }

            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public UpdateMultiAccountDeliveryChannelRequestResourceSnapshotDeliverySlsProperties SlsProperties { get; set; }
            public class UpdateMultiAccountDeliveryChannelRequestResourceSnapshotDeliverySlsProperties : TeaModel {
                [NameInMap("OversizedDataOssTargetArn")]
                [Validation(Required=false)]
                public string OversizedDataOssTargetArn { get; set; }

            }

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
