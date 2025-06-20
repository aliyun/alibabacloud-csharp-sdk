// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class UpdateDeliveryChannelRequest : TeaModel {
        [NameInMap("DeliveryChannelDescription")]
        [Validation(Required=false)]
        public string DeliveryChannelDescription { get; set; }

        [NameInMap("DeliveryChannelFilter")]
        [Validation(Required=false)]
        public UpdateDeliveryChannelRequestDeliveryChannelFilter DeliveryChannelFilter { get; set; }
        public class UpdateDeliveryChannelRequestDeliveryChannelFilter : TeaModel {
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
        /// <para>test-delivery-channel</para>
        /// </summary>
        [NameInMap("DeliveryChannelName")]
        [Validation(Required=false)]
        public string DeliveryChannelName { get; set; }

        [NameInMap("ResourceChangeDelivery")]
        [Validation(Required=false)]
        public UpdateDeliveryChannelRequestResourceChangeDelivery ResourceChangeDelivery { get; set; }
        public class UpdateDeliveryChannelRequestResourceChangeDelivery : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public string Enabled { get; set; }

            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public UpdateDeliveryChannelRequestResourceChangeDeliverySlsProperties SlsProperties { get; set; }
            public class UpdateDeliveryChannelRequestResourceChangeDeliverySlsProperties : TeaModel {
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
        public UpdateDeliveryChannelRequestResourceSnapshotDelivery ResourceSnapshotDelivery { get; set; }
        public class UpdateDeliveryChannelRequestResourceSnapshotDelivery : TeaModel {
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
            public UpdateDeliveryChannelRequestResourceSnapshotDeliverySlsProperties SlsProperties { get; set; }
            public class UpdateDeliveryChannelRequestResourceSnapshotDeliverySlsProperties : TeaModel {
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
