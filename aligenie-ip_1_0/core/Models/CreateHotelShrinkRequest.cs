// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class CreateHotelShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>333566791</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-1 00:00:00</para>
        /// </summary>
        [NameInMap("EstOpenTime")]
        [Validation(Required=false)]
        public string EstOpenTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HotelAddress")]
        [Validation(Required=false)]
        public string HotelAddress { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@hotel.com">test@hotel.com</a></para>
        /// </summary>
        [NameInMap("HotelEmail")]
        [Validation(Required=false)]
        public string HotelEmail { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HotelName")]
        [Validation(Required=false)]
        public string HotelName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13xxxxxxxx</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jTO****Rw</para>
        /// </summary>
        [NameInMap("RelatedPk")]
        [Validation(Required=false)]
        public string RelatedPk { get; set; }

        /// <summary>
        /// <para>酒店关联产品列表</para>
        /// </summary>
        [NameInMap("RelatedPks")]
        [Validation(Required=false)]
        public string RelatedPksShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RoomNum")]
        [Validation(Required=false)]
        public int? RoomNum { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAEV***E3d3Z2ETwh</para>
        /// </summary>
        [NameInMap("TbOpenId")]
        [Validation(Required=false)]
        public string TbOpenId { get; set; }

    }

}
