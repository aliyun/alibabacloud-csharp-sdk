// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CheckCommodityStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The commodity status list. Each item contains the commodity code and indicates whether the commodity capability is enabled for the current account.</para>
        /// </summary>
        [NameInMap("commodities")]
        [Validation(Required=false)]
        public List<CheckCommodityStatusResponseBodyCommodities> Commodities { get; set; }
        public class CheckCommodityStatusResponseBodyCommodities : TeaModel {
            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apigateway_aicredits_public_cn</para>
            /// </summary>
            [NameInMap("commodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the commodity capability is enabled for the current account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
