// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class GetHotelOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6F579407-13C4-1708-AFA2-B657BE5FE8F5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetHotelOrderDetailResponseBodyResult> Result { get; set; }
        public class GetHotelOrderDetailResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ApplyAmt")]
            [Validation(Required=false)]
            public long? ApplyAmt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1659952892000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://ailabsaicloudservice.alicdn.com/hotel/icon/jiudianmianban_fuwushangpintu/weixiu/dianqilei/chuanglian.png">https://ailabsaicloudservice.alicdn.com/hotel/icon/jiudianmianban_fuwushangpintu/weixiu/dianqilei/chuanglian.png</a></para>
            /// </summary>
            [NameInMap("ItemUrl")]
            [Validation(Required=false)]
            public string ItemUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>窗帘</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public long? Quantity { get; set; }

        }

    }

}
