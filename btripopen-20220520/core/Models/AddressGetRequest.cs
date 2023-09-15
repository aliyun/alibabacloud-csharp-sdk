// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AddressGetRequest : TeaModel {
        [NameInMap("action_type")]
        [Validation(Required=false)]
        public int? ActionType { get; set; }

        [NameInMap("arr_city_code")]
        [Validation(Required=false)]
        public string ArrCityCode { get; set; }

        [NameInMap("arr_city_name")]
        [Validation(Required=false)]
        public string ArrCityName { get; set; }

        [NameInMap("car_scenes_code")]
        [Validation(Required=false)]
        public string CarScenesCode { get; set; }

        [NameInMap("dep_city_code")]
        [Validation(Required=false)]
        public string DepCityCode { get; set; }

        [NameInMap("dep_city_name")]
        [Validation(Required=false)]
        public string DepCityName { get; set; }

        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        [NameInMap("itinerary_id")]
        [Validation(Required=false)]
        public string ItineraryId { get; set; }

        [NameInMap("order_Id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        [NameInMap("taobao_callback_url")]
        [Validation(Required=false)]
        public string TaobaoCallbackUrl { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
