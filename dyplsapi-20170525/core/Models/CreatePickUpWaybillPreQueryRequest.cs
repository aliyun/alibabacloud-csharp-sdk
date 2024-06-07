// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillPreQueryRequest : TeaModel {
        /// <summary>
        /// The consignee information.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ConsigneeInfo")]
        [Validation(Required=false)]
        public CreatePickUpWaybillPreQueryRequestConsigneeInfo ConsigneeInfo { get; set; }
        public class CreatePickUpWaybillPreQueryRequestConsigneeInfo : TeaModel {
            /// <summary>
            /// The address of the consignee.
            /// </summary>
            [NameInMap("AddressInfo")]
            [Validation(Required=false)]
            public CreatePickUpWaybillPreQueryRequestConsigneeInfoAddressInfo AddressInfo { get; set; }
            public class CreatePickUpWaybillPreQueryRequestConsigneeInfoAddressInfo : TeaModel {
                /// <summary>
                /// The detailed address of the consignee.
                /// </summary>
                [NameInMap("AddressDetail")]
                [Validation(Required=false)]
                public string AddressDetail { get; set; }

                /// <summary>
                /// The district where the consignee is located.
                /// </summary>
                [NameInMap("AreaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

                /// <summary>
                /// The city where the consignee is located.
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// The province where the consignee is located.
                /// </summary>
                [NameInMap("ProvinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

                /// <summary>
                /// The street where the consignee is located.
                /// </summary>
                [NameInMap("TownName")]
                [Validation(Required=false)]
                public string TownName { get; set; }

            }

            /// <summary>
            /// The mobile phone number of the consignee.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// The name of the consignee.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The code of the courier company. If no courier company is specified, the system allocates a courier company.
        /// </summary>
        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        /// <summary>
        /// The identifier of the external channel source. It cannot contain underscores.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("OrderChannels")]
        [Validation(Required=false)]
        public string OrderChannels { get; set; }

        /// <summary>
        /// The order number of the access system.
        /// </summary>
        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        /// <summary>
        /// The estimated weight. Unit: gram.
        /// 
        /// >  If you need to query the estimated price, this parameter is required.
        /// </summary>
        [NameInMap("PreWeight")]
        [Validation(Required=false)]
        public string PreWeight { get; set; }

        /// <summary>
        /// The sender information.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SenderInfo")]
        [Validation(Required=false)]
        public CreatePickUpWaybillPreQueryRequestSenderInfo SenderInfo { get; set; }
        public class CreatePickUpWaybillPreQueryRequestSenderInfo : TeaModel {
            /// <summary>
            /// The address of the sender.
            /// </summary>
            [NameInMap("AddressInfo")]
            [Validation(Required=false)]
            public CreatePickUpWaybillPreQueryRequestSenderInfoAddressInfo AddressInfo { get; set; }
            public class CreatePickUpWaybillPreQueryRequestSenderInfoAddressInfo : TeaModel {
                /// <summary>
                /// The detailed address of the sender.
                /// </summary>
                [NameInMap("AddressDetail")]
                [Validation(Required=false)]
                public string AddressDetail { get; set; }

                /// <summary>
                /// The district where the sender is located.
                /// </summary>
                [NameInMap("AreaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

                /// <summary>
                /// The city where the sender is located.
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// The province where the sender is located.
                /// </summary>
                [NameInMap("ProvinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

                /// <summary>
                /// The street where the sender is located.
                /// </summary>
                [NameInMap("TownName")]
                [Validation(Required=false)]
                public string TownName { get; set; }

            }

            /// <summary>
            /// The mobile phone number of the sender.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// The name of the sender.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
