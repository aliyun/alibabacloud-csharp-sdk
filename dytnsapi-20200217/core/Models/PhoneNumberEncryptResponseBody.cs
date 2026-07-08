// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class PhoneNumberEncryptResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description><para>The value OK indicates that the request was successful.</para>
        /// </description></item>
        /// <item><description><para>For information about other error codes, see <a href="https://help.aliyun.com/document_detail/109196.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The array.</para>
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
            /// <para>The expiration time of the phone number.</para>
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

            /// <summary>
            /// <para>The custom ID reserved for the caller when the request was initiated. This ID is eventually returned to the caller.</para>
            /// <para>The value is of the string type. The maximum length is 64 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>215044c917374256269257695e9d22</para>
            /// </summary>
            [NameInMap("OutId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

        }

        /// <summary>
        /// <para>The description of the returned status code.</para>
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
