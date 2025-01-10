// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class QueryHotelRoomDetailRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>520a0c0***5eb</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>38:c8:<b>:</b>:f5:22</para>
        /// </summary>
        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1211</para>
        /// </summary>
        [NameInMap("RoomNo")]
        [Validation(Required=false)]
        public string RoomNo { get; set; }

        /// <summary>
        /// <para>设备sn信息
        /// 注：若在mac uuid sn全都输入的情况下 按照输入正确的内容查询 若全输入都是正确的 则 按照 uuid &gt; mac &gt; sn 优先级查询
        /// 传入mac uuid sn其中一个 则酒店id和房间号可不传</para>
        /// 
        /// <b>Example:</b>
        /// <para>280**28</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>588***96j5WU</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
