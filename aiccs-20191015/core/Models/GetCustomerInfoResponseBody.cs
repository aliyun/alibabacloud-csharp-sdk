// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetCustomerInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Membership information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCustomerInfoResponseBodyData Data { get; set; }
        public class GetCustomerInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Custom fields.</para>
            /// </summary>
            [NameInMap("CustomizeFields")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomizeFields { get; set; }

            /// <summary>
            /// <para>Nickname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试会员</para>
            /// </summary>
            [NameInMap("Nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

            /// <summary>
            /// <para>External ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6666666</para>
            /// </summary>
            [NameInMap("OuterId")]
            [Validation(Required=false)]
            public string OuterId { get; set; }

            /// <summary>
            /// <para>Profile picture.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://thirdwx.qlogo.cn/mmopen/vi_32/Q0j4TwGTfTLSW7XPFlJDwVunXP8pr84TvltwtLlNqTlOVSFeM3bCgn57mAB4JuZZmvMW0qicqW0PyzyUdZpxiaFQ">https://thirdwx.qlogo.cn/mmopen/vi_32/Q0j4TwGTfTLSW7XPFlJDwVunXP8pr84TvltwtLlNqTlOVSFeM3bCgn57mAB4JuZZmvMW0qicqW0PyzyUdZpxiaFQ</a></para>
            /// </summary>
            [NameInMap("Photo")]
            [Validation(Required=false)]
            public string Photo { get; set; }

            /// <summary>
            /// <para>Real name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>刘测试</para>
            /// </summary>
            [NameInMap("RealName")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            /// <summary>
            /// <para>Membership ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>823456789023</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DF6A3FB7-A5AA-43BE-A65B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
