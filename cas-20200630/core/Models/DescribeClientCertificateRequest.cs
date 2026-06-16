// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the client certificate or server-side certificate to query.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/465990.html">ListClientCertificate</a> to query the unique identifiers of all client certificates and server-side certificates.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d3b95700998e47afc4d95f886579****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

    }

}
