// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightOtaSearchShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10023</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("cabin_type")]
        [Validation(Required=false)]
        public int? CabinType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>open12igetbis4o07v10B1TlOWcM00</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("search_journeys")]
        [Validation(Required=false)]
        public string SearchJourneysShrink { get; set; }

        [NameInMap("search_passenger_list")]
        [Validation(Required=false)]
        public string SearchPassengerListShrink { get; set; }

        /// <summary>
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
