// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySecretNoDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>Other status codes indicate that the request failed. For more information, see <a href="https://help.aliyun.com/document_detail/109196.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>066E6E47-04CB-4774-A976-4F73CB76D4A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The attributes of the phone number.</para>
        /// </summary>
        [NameInMap("SecretNoInfoDTO")]
        [Validation(Required=false)]
        public QuerySecretNoDetailResponseBodySecretNoInfoDTO SecretNoInfoDTO { get; set; }
        public class QuerySecretNoDetailResponseBodySecretNoInfoDTO : TeaModel {
            /// <summary>
            /// <para>The verification status of the phone number. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The phone number is not verified.</description></item>
            /// <item><description><b>1</b>: The phone number is verified.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CertifyStatus")]
            [Validation(Required=false)]
            public int? CertifyStatus { get; set; }

            /// <summary>
            /// <para>The city.</para>
            /// 
            /// <b>Example:</b>
            /// <para>chengdu</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The province.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sichuan</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <para>The time when the phone number was purchased.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-03 15:19:27</para>
            /// </summary>
            [NameInMap("PurchaseTime")]
            [Validation(Required=false)]
            public string PurchaseTime { get; set; }

            /// <summary>
            /// <para>The status of the phone number. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The phone number is not bound to other phone numbers.</description></item>
            /// <item><description><b>1</b>: The phone number is bound to other phone numbers.</description></item>
            /// <item><description><b>2</b>: The phone number is locked.</description></item>
            /// <item><description><b>3</b>: The phone number is frozen.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SecretStatus")]
            [Validation(Required=false)]
            public long? SecretStatus { get; set; }

            /// <summary>
            /// <para>The carrier to which the phone number belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: China Mobile</description></item>
            /// <item><description><b>2</b>: China Unicom</description></item>
            /// <item><description><b>3</b>: China Telecom</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public long? Vendor { get; set; }

        }

    }

}
