// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AddressGetRequest : TeaModel {
        /// <summary>
        /// <para>The redirect page type. For illustrations of each page, refer to <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=4746411">How to implement SSO redirection - Appendix</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("action_type")]
        [Validation(Required=false)]
        public int? ActionType { get; set; }

        /// <summary>
        /// <para>The three-letter code of the arrival city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BJS</para>
        /// </summary>
        [NameInMap("arr_city_code")]
        [Validation(Required=false)]
        public string ArrCityCode { get; set; }

        /// <summary>
        /// <para>The arrival city name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>北京</para>
        /// </summary>
        [NameInMap("arr_city_name")]
        [Validation(Required=false)]
        public string ArrCityName { get; set; }

        /// <summary>
        /// <para>The car service scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TRAVEL</para>
        /// </summary>
        [NameInMap("car_scenes_code")]
        [Validation(Required=false)]
        public string CarScenesCode { get; set; }

        /// <summary>
        /// <para>The three-letter code of the departure city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("dep_city_code")]
        [Validation(Required=false)]
        public string DepCityCode { get; set; }

        /// <summary>
        /// <para>The departure city name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州</para>
        /// </summary>
        [NameInMap("dep_city_name")]
        [Validation(Required=false)]
        public string DepCityName { get; set; }

        /// <summary>
        /// <para>The departure date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-02-26</para>
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        /// <summary>
        /// <para>The itinerary ID.</para>
        /// <list type="bullet">
        /// <item><description>When the redirect page is the business travel booking page (<c>action_type = 1</c>), you can optionally pass this parameter to quickly redirect to the booking page of the category associated with the itinerary.</description></item>
        /// <item><description>The itinerary ID must have been submitted to the Alibaba Business Travel system through the <a href="https://openapi.alibtrip.com/doc/toDocDetail?docId=4929938">Create a business trip approval</a> operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>460e********5d78</para>
        /// </summary>
        [NameInMap("itinerary_id")]
        [Validation(Required=false)]
        public string ItineraryId { get; set; }

        /// <summary>
        /// <para>Specifies whether to skip the booking intermediate page.</para>
        /// <ol>
        /// <item><description>Set this parameter to 2 to skip the booking intermediate page. When skipping the intermediate page, the <b>itinerary_id</b> parameter is required. If this parameter is empty or set to a value other than 2, the intermediate page is not skipped.</description></item>
        /// <item><description>This parameter is available when the redirect page is the <b>H5 booking page</b> (<c>action_type = 1</c>) and the category is <b>flight</b> (<c>type = 1</c>) or <b>train</b> (<c>type = 2</c>).</description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("middle_page")]
        [Validation(Required=false)]
        public int? MiddlePage { get; set; }

        /// <summary>
        /// <para>The order ID. This parameter is required when the redirect page type is the specified order details page on either platform (<c>action_type = 11 or 12</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002************464</para>
        /// </summary>
        [NameInMap("order_Id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The contact phone number, typically used for car service scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>131****8888</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>Session parameters. The format must be a JSON string where both keys and values are strings.
        /// Example: &quot;{\&quot;returnURL\&quot;:\&quot;<a href="https://open.alibtrip.com/%5C%5C%22%7D">https://open.alibtrip.com/\\&quot;}</a>&quot;</para>
        /// </summary>
        [NameInMap("session_parameters")]
        [Validation(Required=false)]
        public string SessionParameters { get; set; }

        /// <summary>
        /// <para>The sub-enterprise ID. Pass this parameter to redirect to the business page of the specified sub-enterprise.</para>
        /// <list type="bullet">
        /// <item><description><b>View permissions</b>: Only enterprise administrators have view permissions.</description></item>
        /// <item><description><b>Path to obtain</b>: Enterprise management console &gt; Parent-child account management &gt; Account management &gt; Sub-account management &gt; Company ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>btrip01******00</para>
        /// </summary>
        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        /// <summary>
        /// <para>The redirect URL after Taobao account binding.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com">https://example.com</a></para>
        /// </summary>
        [NameInMap("taobao_callback_url")]
        [Validation(Required=false)]
        public string TaobaoCallbackUrl { get; set; }

        /// <summary>
        /// <para>The third-party approval ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TP00097732</para>
        /// </summary>
        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        /// <summary>
        /// <para>The ID of the actual traveler (the person being booked for).</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_1234</para>
        /// </summary>
        [NameInMap("traveler_id")]
        [Validation(Required=false)]
        public string TravelerId { get; set; }

        /// <summary>
        /// <para>The business type. This parameter is required when the redirect page is the <b>booking page</b> (<c>action_type = 1</c>) or the <b>order view page</b> (<c>action_type = 2</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>Specifies whether to use proxy booking mode.</para>
        /// <list type="bullet">
        /// <item><description>The proxy booking page is accessible only when this parameter is set to 1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("use_booking_proxy")]
        [Validation(Required=false)]
        public int? UseBookingProxy { get; set; }

        /// <summary>
        /// <para>The employee ID. The employee must be registered in the business travel system before you pass this parameter. Otherwise, the call fails.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_1234</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
