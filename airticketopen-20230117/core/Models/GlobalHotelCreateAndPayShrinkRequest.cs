// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelCreateAndPayShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The distributor account ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AccountNo")]
        [Validation(Required=false)]
        public long? AccountNo { get; set; }

        /// <summary>
        /// <para>The contact information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Contact")]
        [Validation(Required=false)]
        public string ContactShrink { get; set; }

        /// <summary>
        /// <para>The external order number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXT_ORDER_001</para>
        /// </summary>
        [NameInMap("ExternalOrderNo")]
        [Validation(Required=false)]
        public string ExternalOrderNo { get; set; }

        /// <summary>
        /// <para>The guests grouped by room.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Guests")]
        [Validation(Required=false)]
        public string GuestsShrink { get; set; }

        /// <summary>
        /// <para>The offer ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>itemOffer_123</para>
        /// </summary>
        [NameInMap("ItemOfferId")]
        [Validation(Required=false)]
        public string ItemOfferId { get; set; }

        /// <summary>
        /// <para>The number of rooms.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoomCount")]
        [Validation(Required=false)]
        public int? RoomCount { get; set; }

        /// <summary>
        /// <para>TraceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>TraceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
