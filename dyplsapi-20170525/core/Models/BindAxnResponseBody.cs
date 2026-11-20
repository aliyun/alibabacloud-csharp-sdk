// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxnResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the request.</para>
        /// <list type="bullet">
        /// <item><description>A value of OK indicates that the request is successful.</description></item>
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
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The struct returned after the number is successfully bound.</para>
        /// </summary>
        [NameInMap("SecretBindDTO")]
        [Validation(Required=false)]
        public BindAxnResponseBodySecretBindDTO SecretBindDTO { get; set; }
        public class BindAxnResponseBodySecretBindDTO : TeaModel {
            /// <summary>
            /// <para>The extension number.</para>
            /// <remarks>
            /// <para>The BindAxn operation does not involve extension numbers. Ignore this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>The privacy number, which is Number X.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139****1111</para>
            /// </summary>
            [NameInMap("SecretNo")]
            [Validation(Required=false)]
            public string SecretNo { get; set; }

            /// <summary>
            /// <para>The ID of the binding relationship.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1***************3</para>
            /// </summary>
            [NameInMap("SubsId")]
            [Validation(Required=false)]
            public string SubsId { get; set; }

        }

    }

}
