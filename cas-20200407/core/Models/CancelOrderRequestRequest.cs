// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class CancelOrderRequestRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate order to cancel.</para>
        /// <remarks>
        /// <para>Obtain this ID by calling <a href="https://help.aliyun.com/document_detail/455804.html">ListUserCertificateOrder</a>.</para>
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
