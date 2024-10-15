// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingFlightListRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>BJS</para>
        /// </summary>
        [NameInMap("arr_city")]
        [Validation(Required=false)]
        public string ArrCity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("dep_city")]
        [Validation(Required=false)]
        public string DepCity { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-00-00 00:00:00</para>
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        [NameInMap("is_voluntary")]
        [Validation(Required=false)]
        public int? IsVoluntary { get; set; }

        [NameInMap("traveler_info_list")]
        [Validation(Required=false)]
        public List<TicketChangingFlightListRequestTravelerInfoList> TravelerInfoList { get; set; }
        public class TicketChangingFlightListRequestTravelerInfoList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BJS</para>
            /// </summary>
            [NameInMap("arr_city")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HGH</para>
            /// </summary>
            [NameInMap("dep_city")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ADULT</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23231</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
