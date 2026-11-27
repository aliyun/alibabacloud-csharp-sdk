// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetCustomerInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The member information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomerInfoResponseBodyData Data { get; set; }
        public class GetCustomerInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The custom fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;test&quot;:&quot;test&quot;,&quot;test2&quot;:1}</para>
            /// </summary>
            [NameInMap("CustomizeFields")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomizeFields { get; set; }

            /// <summary>
            /// <para>The nickname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test member</para>
            /// </summary>
            [NameInMap("Nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            /// <summary>
            /// <para>The external ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6666666</para>
            /// </summary>
            [NameInMap("OuterId")]
            [Validation(Required=false)]
            public string OuterId { get; set; }

            /// <summary>
            /// <para>The profile picture.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://thirdwx.qlogo.cn/mmopen/vi_32/Q0j4TwGTfTLSW7XPFlJDwVunXP8pr84TvltwtLlNqTlOVSFeM3bCgn57mAB4JuZZmvMW0qicqW0PyzyUdZpxiaFQ">https://thirdwx.qlogo.cn/mmopen/vi_32/Q0j4TwGTfTLSW7XPFlJDwVunXP8pr84TvltwtLlNqTlOVSFeM3bCgn57mAB4JuZZmvMW0qicqW0PyzyUdZpxiaFQ</a></para>
            /// </summary>
            [NameInMap("Photo")]
            [Validation(Required=false)]
            public string Photo { get; set; }

            /// <summary>
            /// <para>The real name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Liu Test</para>
            /// </summary>
            [NameInMap("RealName")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            /// <summary>
            /// <para>The member ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>823456789023</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DF6A3FB7-A5AA-43BE-A65B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
