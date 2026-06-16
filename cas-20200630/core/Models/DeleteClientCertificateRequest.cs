// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DeleteClientCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the client or server-side certificate to delete. The certificate must be in the <b>REVOKE</b> state.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/465990.html">ListClientCertificate</a> to query the unique identifiers and current states of all client and server-side certificates.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>160ae6bb538d538c70c01f81dcf2****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

    }

}
