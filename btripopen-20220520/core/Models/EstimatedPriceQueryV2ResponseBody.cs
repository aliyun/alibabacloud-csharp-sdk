// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class EstimatedPriceQueryV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public List<EstimatedPriceQueryV2ResponseBodyModule> Module { get; set; }
        public class EstimatedPriceQueryV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The category, such as flight, hotel, or train.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flight</para>
            /// </summary>
            [NameInMap("biz_type")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// <para>The price map. Key: min and max.</para>
            /// </summary>
            [NameInMap("price_map")]
            [Validation(Required=false)]
            public Dictionary<string, ModulePriceMapValue> PriceMap { get; set; }

            /// <summary>
            /// <para>The type, such as economy class, business class, first class, G/D train, other, or travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>经济舱</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bcc3a16583004579056128d33d7</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
