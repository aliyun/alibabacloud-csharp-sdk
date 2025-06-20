// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class CreateMultiAccountDeliveryChannelRequest : TeaModel {
        [NameInMap("DeliveryChannelDescription")]
        [Validation(Required=false)]
        public string DeliveryChannelDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DeliveryChannelFilter")]
        [Validation(Required=false)]
        public CreateMultiAccountDeliveryChannelRequestDeliveryChannelFilter DeliveryChannelFilter { get; set; }
        public class CreateMultiAccountDeliveryChannelRequestDeliveryChannelFilter : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
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
        /// <para>test-multi-account-delivery</para>
        /// </summary>
        [NameInMap("DeliveryChannelName")]
        [Validation(Required=false)]
        public string DeliveryChannelName { get; set; }

        [NameInMap("ResourceChangeDelivery")]
        [Validation(Required=false)]
        public CreateMultiAccountDeliveryChannelRequestResourceChangeDelivery ResourceChangeDelivery { get; set; }
        public class CreateMultiAccountDeliveryChannelRequestResourceChangeDelivery : TeaModel {
            [NameInMap("SlsProperties")]
            [Validation(Required=false)]
            public CreateMultiAccountDeliveryChannelRequestResourceChangeDeliverySlsProperties SlsProperties { get; set; }
            public class CreateMultiAccountDeliveryChannelRequestResourceChangeDeliverySlsProperties : TeaModel {
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
        public CreateMultiAccountDeliveryChannelRequestResourceSnapshotDelivery ResourceSnapshotDelivery { get; set; }
        public class CreateMultiAccountDeliveryChannelRequestResourceSnapshotDelivery : TeaModel {
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
            public CreateMultiAccountDeliveryChannelRequestResourceSnapshotDeliverySlsProperties SlsProperties { get; set; }
            public class CreateMultiAccountDeliveryChannelRequestResourceSnapshotDeliverySlsProperties : TeaModel {
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
