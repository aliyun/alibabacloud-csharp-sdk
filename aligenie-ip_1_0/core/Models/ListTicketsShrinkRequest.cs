// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class ListTicketsShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-09-14 14:23:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af7***536</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsDesc")]
        [Validation(Required=false)]
        public bool? IsDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsNeedCallback")]
        [Validation(Required=false)]
        public bool? IsNeedCallback { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsNeedCharges")]
        [Validation(Required=false)]
        public bool? IsNeedCharges { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public string PageShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1211</para>
        /// </summary>
        [NameInMap("RoomNo")]
        [Validation(Required=false)]
        public string RoomNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>gmtCalled</para>
        /// </summary>
        [NameInMap("SortField")]
        [Validation(Required=false)]
        public string SortField { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-04-08 09:39:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>waiting</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
