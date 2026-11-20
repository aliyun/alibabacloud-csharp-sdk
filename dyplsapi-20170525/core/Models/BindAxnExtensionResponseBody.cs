// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class BindAxnExtensionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
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
        /// <para>9297B722-A016-43FB-B51A-E54050D9369D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The struct returned upon successful binding.</para>
        /// </summary>
        [NameInMap("SecretBindDTO")]
        [Validation(Required=false)]
        public BindAxnExtensionResponseBodySecretBindDTO SecretBindDTO { get; set; }
        public class BindAxnExtensionResponseBodySecretBindDTO : TeaModel {
            /// <summary>
            /// <para>The extension number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>The privacy number, which is number X.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139*****1111</para>
            /// </summary>
            [NameInMap("SecretNo")]
            [Validation(Required=false)]
            public string SecretNo { get; set; }

            /// <summary>
            /// <para>The binding relationship ID.</para>
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
