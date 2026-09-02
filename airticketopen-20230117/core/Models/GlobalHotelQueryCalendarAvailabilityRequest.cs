// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GlobalHotelQueryCalendarAvailabilityRequest : TeaModel {
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
        /// <para>The end date of the check-in date range to query, in the yyyy-MM-dd format. The date cannot be earlier than the start date. The date range is inclusive and supports a maximum of 30 days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-03</para>
        /// </summary>
        [NameInMap("CheckInDateEnd")]
        [Validation(Required=false)]
        public string CheckInDateEnd { get; set; }

        /// <summary>
        /// <para>The start date of the check-in date range to query, in the yyyy-MM-dd format. The date cannot be earlier than the current day.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-01</para>
        /// </summary>
        [NameInMap("CheckInDateStart")]
        [Validation(Required=false)]
        public string CheckInDateStart { get; set; }

        /// <summary>
        /// <para>The number of children.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ChildCount")]
        [Validation(Required=false)]
        public int? ChildCount { get; set; }

        /// <summary>
        /// <para>The list of children ages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("ChildrenAges")]
        [Validation(Required=false)]
        public List<int?> ChildrenAges { get; set; }

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
        /// <para>The list of standard hotel IDs on the platform. A maximum of 10 IDs are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;H001&quot;]</para>
        /// </summary>
        [NameInMap("StandardHotelIds")]
        [Validation(Required=false)]
        public List<string> StandardHotelIds { get; set; }

        /// <summary>
        /// <para>TraceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>traceId</para>
        /// </summary>
        [NameInMap("TracerId")]
        [Validation(Required=false)]
        public string TracerId { get; set; }

    }

}
