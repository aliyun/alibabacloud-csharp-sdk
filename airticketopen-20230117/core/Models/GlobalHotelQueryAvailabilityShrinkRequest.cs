// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelQueryAvailabilityShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The account ID of the distributor.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AccountNo")]
        [Validation(Required=false)]
        public long? AccountNo { get; set; }

        /// <summary>
        /// <para>The number of adults.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AdultCount")]
        [Validation(Required=false)]
        public int? AdultCount { get; set; }

        /// <summary>
        /// <para>The check-in date in the format of yyyy-MM-dd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-01</para>
        /// </summary>
        [NameInMap("CheckInDate")]
        [Validation(Required=false)]
        public string CheckInDate { get; set; }

        /// <summary>
        /// <para>The check-out date in the format of yyyy-MM-dd.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-07-03</para>
        /// </summary>
        [NameInMap("CheckOutDate")]
        [Validation(Required=false)]
        public string CheckOutDate { get; set; }

        /// <summary>
        /// <para>The number of children.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ChildCount")]
        [Validation(Required=false)]
        public int? ChildCount { get; set; }

        /// <summary>
        /// <para>The list of children\&quot;s ages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[8]</para>
        /// </summary>
        [NameInMap("ChildrenAges")]
        [Validation(Required=false)]
        public string ChildrenAgesShrink { get; set; }

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
        /// <para>The list of standard hotel IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;H001&quot;]</para>
        /// </summary>
        [NameInMap("StandardHotelIds")]
        [Validation(Required=false)]
        public string StandardHotelIdsShrink { get; set; }

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
