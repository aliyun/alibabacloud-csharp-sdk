// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AddressGetRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>460e254b5a5b4bd0801744a2790e5d78</para>
        /// </summary>
        [NameInMap("itinerary_id")]
        [Validation(Required=false)]
        public string ItineraryId { get; set; }

        [NameInMap("middle_page")]
        [Validation(Required=false)]
        public int? MiddlePage { get; set; }

        [NameInMap("order_Id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("session_parameters")]
        [Validation(Required=false)]
        public string SessionParameters { get; set; }

        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://alibtrip.open.com">https://alibtrip.open.com</a></para>
        /// </summary>
        [NameInMap("taobao_callback_url")]
        [Validation(Required=false)]
        public string TaobaoCallbackUrl { get; set; }

        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        [NameInMap("traveler_id")]
        [Validation(Required=false)]
        public string TravelerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("use_booking_proxy")]
        [Validation(Required=false)]
        public int? UseBookingProxy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
