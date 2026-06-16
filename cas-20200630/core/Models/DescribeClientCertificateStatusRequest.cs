// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateStatusRequest : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the client or server-side certificate that you want to query. Separate multiple identifiers with commas (,).</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/465990.html">ListClientCertificate</a> to query the unique identifiers of all client and server-side certificates.</para>
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
