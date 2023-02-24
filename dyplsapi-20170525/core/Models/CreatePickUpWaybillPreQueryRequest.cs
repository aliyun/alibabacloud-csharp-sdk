// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillPreQueryRequest : TeaModel {
        [NameInMap("ConsigneeInfo")]
        [Validation(Required=false)]
        public CreatePickUpWaybillPreQueryRequestConsigneeInfo ConsigneeInfo { get; set; }
        public class CreatePickUpWaybillPreQueryRequestConsigneeInfo : TeaModel {
            [NameInMap("AddressInfo")]
            [Validation(Required=false)]
            public CreatePickUpWaybillPreQueryRequestConsigneeInfoAddressInfo AddressInfo { get; set; }
            public class CreatePickUpWaybillPreQueryRequestConsigneeInfoAddressInfo : TeaModel {
                [NameInMap("AddressDetail")]
                [Validation(Required=false)]
                public string AddressDetail { get; set; }

                [NameInMap("AreaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("ProvinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

                [NameInMap("TownName")]
                [Validation(Required=false)]
                public string TownName { get; set; }

            }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        [NameInMap("OrderChannels")]
        [Validation(Required=false)]
        public string OrderChannels { get; set; }

        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        [NameInMap("PreWeight")]
        [Validation(Required=false)]
        public string PreWeight { get; set; }

        [NameInMap("SenderInfo")]
        [Validation(Required=false)]
        public CreatePickUpWaybillPreQueryRequestSenderInfo SenderInfo { get; set; }
        public class CreatePickUpWaybillPreQueryRequestSenderInfo : TeaModel {
            [NameInMap("AddressInfo")]
            [Validation(Required=false)]
            public CreatePickUpWaybillPreQueryRequestSenderInfoAddressInfo AddressInfo { get; set; }
            public class CreatePickUpWaybillPreQueryRequestSenderInfoAddressInfo : TeaModel {
                [NameInMap("AddressDetail")]
                [Validation(Required=false)]
                public string AddressDetail { get; set; }

                [NameInMap("AreaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("ProvinceName")]
                [Validation(Required=false)]
                public string ProvinceName { get; set; }

                [NameInMap("TownName")]
                [Validation(Required=false)]
                public string TownName { get; set; }

            }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
