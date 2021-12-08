// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class CreatePickUpWaybillRequest : TeaModel {
        [NameInMap("ConsigneeAddress")]
        [Validation(Required=false)]
        public CreatePickUpWaybillRequestConsigneeAddress ConsigneeAddress { get; set; }
        public class CreatePickUpWaybillRequestConsigneeAddress : TeaModel {
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
        };

        [NameInMap("ConsigneeMobile")]
        [Validation(Required=false)]
        public string ConsigneeMobile { get; set; }

        [NameInMap("ConsigneeName")]
        [Validation(Required=false)]
        public string ConsigneeName { get; set; }

        [NameInMap("ConsigneePhone")]
        [Validation(Required=false)]
        public string ConsigneePhone { get; set; }

        [NameInMap("CpCode")]
        [Validation(Required=false)]
        public string CpCode { get; set; }

        [NameInMap("GoodsInfos")]
        [Validation(Required=false)]
        public List<CreatePickUpWaybillRequestGoodsInfos> GoodsInfos { get; set; }
        public class CreatePickUpWaybillRequestGoodsInfos : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public string Quantity { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public string Weight { get; set; }

        }

        [NameInMap("OrderChannels")]
        [Validation(Required=false)]
        public string OrderChannels { get; set; }

        [NameInMap("OuterOrderCode")]
        [Validation(Required=false)]
        public string OuterOrderCode { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("SendAddress")]
        [Validation(Required=false)]
        public CreatePickUpWaybillRequestSendAddress SendAddress { get; set; }
        public class CreatePickUpWaybillRequestSendAddress : TeaModel {
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
        };

        [NameInMap("SendMobile")]
        [Validation(Required=false)]
        public string SendMobile { get; set; }

        [NameInMap("SendName")]
        [Validation(Required=false)]
        public string SendName { get; set; }

        [NameInMap("SendPhone")]
        [Validation(Required=false)]
        public string SendPhone { get; set; }

    }

}
