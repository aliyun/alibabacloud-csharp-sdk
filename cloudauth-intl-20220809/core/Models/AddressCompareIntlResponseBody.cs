// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_intl20220809.Models
{
    public class AddressCompareIntlResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86C40EC3-5940-5F47-995C-BFE90B70E540</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddressCompareIntlResponseBodyResult Result { get; set; }
        public class AddressCompareIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The sameLevel parameter has the following valid values:</para>
            /// <list type="bullet">
            /// <item><description>all: completely identical</description></item>
            /// <item><description>prov: province level </description></item>
            /// <item><description>city: city level</description></item>
            /// <item><description>district: district level</description></item>
            /// <item><description>town: street level</description></item>
            /// <item><description>road: road level</description></item>
            /// <item><description>roadno: road number level</description></item>
            /// <item><description>poi: community/neighborhood level</description></item>
            /// <item><description>roomno: room number level.</description></item>
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
