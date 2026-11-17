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
        /// <para>The return result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddressCompareIntlResponseBodyResult Result { get; set; }
        public class AddressCompareIntlResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>all: Exactly the same.</description></item>
            /// <item><description>prov: Province. </description></item>
            /// <item><description>city: City.</description></item>
            /// <item><description>district: District.</description></item>
            /// <item><description>town: Town.</description></item>
            /// <item><description>road: Road.</description></item>
            /// <item><description>roadno: Road number.</description></item>
            /// <item><description>poi: Residential community.</description></item>
            /// <item><description>roomno: Room number.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///      sameLevel: &quot;city&quot;, 
            ///      distance:  5997.34m, -- Distance between addresses
            ///      same_info: {    -- Identical information
            ///               prov: &quot;Zhejiang Province&quot;,
            ///               city: &quot;Hangzhou&quot;,
            ///               district: &quot;Xihu District&quot;
            ///       } 
            /// }</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }

        }

    }

}
