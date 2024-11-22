// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class DeleteCertificateRequestRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate application order that you want to delete.</para>
        /// <remarks>
        /// <para> After you call the <a href="https://help.aliyun.com/document_detail/455296.html">CreateCertificateForPackageRequest</a>, <a href="https://help.aliyun.com/document_detail/455292.html">CreateCertificateRequest</a>, or <a href="https://help.aliyun.com/document_detail/455801.html">CreateCertificateWithCsrRequest</a> operation to submit a certificate application, you can obtain the ID of the certificate application order from the <b>OrderId</b> response parameter. You can also call the <a href="https://help.aliyun.com/document_detail/455804.html">ListUserCertificateOrder</a> operation to obtain the order ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123451222</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

    }

}
