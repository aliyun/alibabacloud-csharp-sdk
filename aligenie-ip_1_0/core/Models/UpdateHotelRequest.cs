// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class UpdateHotelRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31342884</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-02-22 00:00:00</para>
        /// </summary>
        [NameInMap("EstOpenTime")]
        [Validation(Required=false)]
        public string EstOpenTime { get; set; }

        [NameInMap("HotelAddress")]
        [Validation(Required=false)]
        public string HotelAddress { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a*****@hotel.com</para>
        /// </summary>
        [NameInMap("HotelEmail")]
        [Validation(Required=false)]
        public string HotelEmail { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e6dd44fd16084db8a60d69fd625d9f0f</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        [NameInMap("HotelName")]
        [Validation(Required=false)]
        public string HotelName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>130***</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("RelatedPks")]
        [Validation(Required=false)]
        public List<string> RelatedPks { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("RoomNum")]
        [Validation(Required=false)]
        public int? RoomNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAEVK***UE3d3Z2ETwh</para>
        /// </summary>
        [NameInMap("TbOpenId")]
        [Validation(Required=false)]
        public string TbOpenId { get; set; }

    }

}
