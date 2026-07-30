// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOtaSearchShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business travel user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10023</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>The cabin class type for the search. Default value: 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: all cabin classes</description></item>
        /// <item><description>1: economy class</description></item>
        /// <item><description>2: first class and business class</description></item>
        /// <item><description>3: premium economy class</description></item>
        /// <item><description>4: first class</description></item>
        /// <item><description>5: business class</description></item>
        /// <item><description>6: economy class and premium economy class</description></item>
        /// <item><description>7: economy class, premium economy class, and business class</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("cabin_type")]
        [Validation(Required=false)]
        public int? CabinType { get; set; }

        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open12igetbis4o07v10B1TlOWcM00</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The search journeys.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("search_journeys")]
        [Validation(Required=false)]
        public string SearchJourneysShrink { get; set; }

        /// <summary>
        /// <para>The passenger information. Required if the passenger has a managed agreement price.</para>
        /// </summary>
        [NameInMap("search_passenger_list")]
        [Validation(Required=false)]
        public string SearchPassengerListShrink { get; set; }

        /// <summary>
        /// <para>The trip type. Default value: 1 (one-way).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("trip_type")]
        [Validation(Required=false)]
        public int? TripType { get; set; }

    }

}
