// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberEncryptResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>Other values indicate that the request failed. For more information, see <a href="https://help.aliyun.com/document_detail/109196.html">Error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Details about the returned entries.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<PhoneNumberEncryptResponseBodyData> Data { get; set; }
        public class PhoneNumberEncryptResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The encrypted phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1400513****</para>
            /// </summary>
            [NameInMap("EncryptedNumber")]
            [Validation(Required=false)]
            public string EncryptedNumber { get; set; }

            /// <summary>
            /// <para>The time when the phone number expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-27 16:05:23</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The original phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1390000****</para>
            /// </summary>
            [NameInMap("OriginalNumber")]
            [Validation(Required=false)]
            public string OriginalNumber { get; set; }

            [NameInMap("OutId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

        }

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
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
