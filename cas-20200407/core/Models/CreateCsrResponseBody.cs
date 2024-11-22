// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateCsrResponseBody : TeaModel {
        /// <summary>
        /// <para>The content of the CSR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST----- ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The unique identifier of the CSR. You can use this value to obtain the content of the CSR. For more information about the operation that you can call to obtain the content of a CSR, see <a href="https://help.aliyun.com/document_detail/2709720.html">GetCsrDetail</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3365</para>
        /// </summary>
        [NameInMap("CsrId")]
        [Validation(Required=false)]
        public long? CsrId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789ABC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
