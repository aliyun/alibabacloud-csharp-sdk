// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class AddressCompareIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>Return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86C40EC3-5940-5F47-995C-BFE90B70E540</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Return result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddressCompareIntlResponseBodyResult Result { get; set; }
        public class AddressCompareIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The values of sameLevel include:</para>
            /// <list type="bullet">
            /// <item><description>all: Exactly the same</description></item>
            /// <item><description>prov: Provincial level</description></item>
            /// <item><description>city: City level</description></item>
            /// <item><description>district: District level</description></item>
            /// <item><description>town: Town level</description></item>
            /// <item><description>road: Road level</description></item>
            /// <item><description>roadno: Road number</description></item>
            /// <item><description>poi: Point of interest (e.g., residential area)</description></item>
            /// <item><description>roomno: Room number</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///      sameLevel: &quot;city&quot;, 
            ///      distance:  5997.34m, -- 地址相差距离
            ///      same_info: {    -- 相同信息
            ///               prov: &quot;浙江省&quot;,
            ///               city: &quot;杭州市&quot;,
            ///               district: &quot;西湖区&quot;
            ///       } 
            /// }</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

        }

    }

}
