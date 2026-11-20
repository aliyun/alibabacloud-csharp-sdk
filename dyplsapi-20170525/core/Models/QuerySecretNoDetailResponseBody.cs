// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySecretNoDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
        /// <list type="bullet">
        /// <item><description>OK indicates that the request was successful.</description></item>
        /// <item><description>For other error codes, see <a href="https://help.aliyun.com/document_detail/109196.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
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
        /// <para>The number properties.</para>
        /// </summary>
        [NameInMap("SecretNoInfoDTO")]
        [Validation(Required=false)]
        public QuerySecretNoDetailResponseBodySecretNoInfoDTO SecretNoInfoDTO { get; set; }
        public class QuerySecretNoDetailResponseBodySecretNoInfoDTO : TeaModel {
            /// <summary>
            /// <para>The number verification status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Unverified.</description></item>
            /// <item><description><b>1</b>: Verified.</description></item>
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
            /// <para>Xi\&quot;an</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The province.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Shaanxi</para>
            /// </summary>
            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            /// <summary>
            /// <para>The purchase time of the number, in the format of YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-03 15:19:27</para>
            /// </summary>
            [NameInMap("PurchaseTime")]
            [Validation(Required=false)]
            public string PurchaseTime { get; set; }

            /// <summary>
            /// <para>The number status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Unbound.</description></item>
            /// <item><description><b>1</b>: Bound.</description></item>
            /// <item><description><b>2</b>: Locked.</description></item>
            /// <item><description><b>3</b>: Frozen.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SecretStatus")]
            [Validation(Required=false)]
            public long? SecretStatus { get; set; }

            /// <summary>
            /// <para>The carrier. Valid values:</para>
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
