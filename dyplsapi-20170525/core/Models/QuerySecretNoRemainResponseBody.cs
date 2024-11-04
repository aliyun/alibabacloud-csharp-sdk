// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QuerySecretNoRemainResponseBody : TeaModel {
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
        /// <para>9FC30594-3841-43AD-9008-03393BCB5CD2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information returned after the operation was called.</para>
        /// </summary>
        [NameInMap("SecretRemainDTO")]
        [Validation(Required=false)]
        public QuerySecretNoRemainResponseBodySecretRemainDTO SecretRemainDTO { get; set; }
        public class QuerySecretNoRemainResponseBodySecretRemainDTO : TeaModel {
            /// <summary>
            /// <para>The quantity of remaining phone numbers available for online purchase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            /// <summary>
            /// <para>The home location of the phone numbers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hangzhou</para>
            /// </summary>
            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The information about remaining phone numbers available for online purchase.</para>
            /// </summary>
            [NameInMap("RemainDTOList")]
            [Validation(Required=false)]
            public QuerySecretNoRemainResponseBodySecretRemainDTORemainDTOList RemainDTOList { get; set; }
            public class QuerySecretNoRemainResponseBodySecretRemainDTORemainDTOList : TeaModel {
                [NameInMap("remainDTO")]
                [Validation(Required=false)]
                public List<QuerySecretNoRemainResponseBodySecretRemainDTORemainDTOListRemainDTO> RemainDTO { get; set; }
                public class QuerySecretNoRemainResponseBodySecretRemainDTORemainDTOListRemainDTO : TeaModel {
                    /// <summary>
                    /// <para>The quantity of remaining phone numbers available for online purchase for the city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("Amount")]
                    [Validation(Required=false)]
                    public long? Amount { get; set; }

                    /// <summary>
                    /// <para>The home location of the phone numbers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Wuhan</para>
                    /// </summary>
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                }

            }

        }

    }

}
