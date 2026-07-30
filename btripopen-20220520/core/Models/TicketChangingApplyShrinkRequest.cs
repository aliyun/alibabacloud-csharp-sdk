// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingApplyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The external order ID of the distribution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis1234</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// <para>The external change order ID of the distribution.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mid1243</para>
        /// </summary>
        [NameInMap("dis_sub_order_id")]
        [Validation(Required=false)]
        public string DisSubOrderId { get; set; }

        /// <summary>
        /// <para>Specifies whether the change is voluntary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("is_voluntary")]
        [Validation(Required=false)]
        public int? IsVoluntary { get; set; }

        /// <summary>
        /// <para>The change flight information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("modify_flight_info_list")]
        [Validation(Required=false)]
        public string ModifyFlightInfoListShrink { get; set; }

        /// <summary>
        /// <para>The OTA item ID. This value is obtained from the itemId field in the response of the change flight price inquiry API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1s8837sh991hsj92h</para>
        /// </summary>
        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        /// <summary>
        /// <para>The reason for the ticket change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>自愿改签测试</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The session ID. This value is obtained from the isessionId field in the response of the change flight price inquiry API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>us88s2bsbin22hjusd8i</para>
        /// </summary>
        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to retry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("whether_retry")]
        [Validation(Required=false)]
        public bool? WhetherRetry { get; set; }

    }

}
