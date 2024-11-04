// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxbResponseBody : TeaModel {
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
        /// <para>9297B722-A016-43FB-B51A-E54050D9369D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information returned after the phone numbers were bound.</para>
        /// </summary>
        [NameInMap("SecretBindDTO")]
        [Validation(Required=false)]
        public BindAxbResponseBodySecretBindDTO SecretBindDTO { get; set; }
        public class BindAxbResponseBodySecretBindDTO : TeaModel {
            /// <summary>
            /// <para>The extension of the phone number.</para>
            /// <remarks>
            /// <para> The BindAxb operation does not involve an extension. Ignore this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>The private number, that is, phone number X.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139****0000</para>
            /// </summary>
            [NameInMap("SecretNo")]
            [Validation(Required=false)]
            public string SecretNo { get; set; }

            /// <summary>
            /// <para>The binding ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1**************3</para>
            /// </summary>
            [NameInMap("SubsId")]
            [Validation(Required=false)]
            public string SubsId { get; set; }

        }

    }

}
