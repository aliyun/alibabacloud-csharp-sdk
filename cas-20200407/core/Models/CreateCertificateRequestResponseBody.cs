// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateCertificateRequestResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate application order.</para>
        /// <remarks>
        /// <para> You can use the ID to query the status of the certificate application. For more information, see <a href="https://help.aliyun.com/document_detail/164111.html">DescribeCertificateState</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>98987582437920968</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
