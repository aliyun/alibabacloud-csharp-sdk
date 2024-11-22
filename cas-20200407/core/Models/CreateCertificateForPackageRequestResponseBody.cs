// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CreateCertificateForPackageRequestResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate application order.</para>
        /// <remarks>
        /// <para> You can use the ID to query the status of the certificate application order. For more information, see <a href="https://help.aliyun.com/document_detail/164111.html">DescribeCertificateState</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021010</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5890029B-938A-589E-98B9-3DEC7BA7C400</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
