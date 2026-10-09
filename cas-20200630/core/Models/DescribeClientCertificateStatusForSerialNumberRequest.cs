// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateStatusForSerialNumberRequest : TeaModel {
        /// <summary>
        /// <para>Certificate serial number of the client certificate or server certificate to query. Separate multiple serial numbers with commas (,).</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/330884.html">ListClientCertificate</a> to query certificate serial numbers of all client certificates and server certificates.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b67e53ebcea9b77d65b0c3236646d715****</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

    }

}
