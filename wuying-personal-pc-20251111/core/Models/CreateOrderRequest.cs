// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wuying_personal_pc20251111.Models
{
    public class CreateOrderRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DynamicProductParams")]
        [Validation(Required=false)]
        public List<CreateOrderRequestDynamicProductParams> DynamicProductParams { get; set; }
        public class CreateOrderRequestDynamicProductParams : TeaModel {
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public int? Amount { get; set; }

            [NameInMap("DeliveryAddress")]
            [Validation(Required=false)]
            public string DeliveryAddress { get; set; }

            [NameInMap("DynamicAttributes")]
            [Validation(Required=false)]
            public Dictionary<string, string> DynamicAttributes { get; set; }

            [NameInMap("InputActivateConfig")]
            [Validation(Required=false)]
            public CreateOrderRequestDynamicProductParamsInputActivateConfig InputActivateConfig { get; set; }
            public class CreateOrderRequestDynamicProductParamsInputActivateConfig : TeaModel {
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("DesktopName")]
                [Validation(Required=false)]
                public string DesktopName { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

            }

            [NameInMap("InstanceIdList")]
            [Validation(Required=false)]
            public List<string> InstanceIdList { get; set; }

            [NameInMap("LinkedResourceId")]
            [Validation(Required=false)]
            public string LinkedResourceId { get; set; }

            [NameInMap("PackageCode")]
            [Validation(Required=false)]
            public string PackageCode { get; set; }

            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ProductSkuCode")]
            [Validation(Required=false)]
            public string ProductSkuCode { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("OrderFrom")]
        [Validation(Required=false)]
        public string OrderFrom { get; set; }

        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
