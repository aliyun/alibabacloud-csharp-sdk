// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateStatusRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifiers of the client certificates or server certificates that you want to query. Separate multiple unique identifiers with commas (,).</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/330884.html">ListClientCertificate</a> operation to query the unique identifiers of all client certificates and server certificates.</para>
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
