// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingEnquiryRequest : TeaModel {
        /// <summary>
        /// <para>The three-letter code of the arrival city.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BJS</para>
        /// </summary>
        [NameInMap("arr_city")]
        [Validation(Required=false)]
        public string ArrCity { get; set; }

        /// <summary>
        /// <para>The three-letter code of the departure city.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HGH</para>
        /// </summary>
        [NameInMap("dep_city")]
        [Validation(Required=false)]
        public string DepCity { get; set; }

        /// <summary>
        /// <para>The distribution external order ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// <para>Specifies whether the change is voluntary.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("is_voluntary")]
        [Validation(Required=false)]
        public int? IsVoluntary { get; set; }

        /// <summary>
        /// <para>The change date. This parameter is required for calculating the change price.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-00-00 00:00:00</para>
        /// </summary>
        [NameInMap("modify_depart_date")]
        [Validation(Required=false)]
        public string ModifyDepartDate { get; set; }

        /// <summary>
        /// <para>The change flight number. This parameter is required for calculating the change price.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA1704</para>
        /// </summary>
        [NameInMap("modify_flight_no")]
        [Validation(Required=false)]
        public string ModifyFlightNo { get; set; }

        /// <summary>
        /// <para>The session ID returned from the change search.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ece19e8b1047898a5a98b6487348c2</para>
        /// </summary>
        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
