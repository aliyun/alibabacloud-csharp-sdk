// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class ListClientCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The unique identifier of the client certificate or the server certificate that you want to query.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/330884.html">ListClientCertificate</a> operation to query the unique identifiers of all client certificates and server certificates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>190ae6bb538d538c70c01f81dcf2****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The number of certificates to return on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

    }

}
