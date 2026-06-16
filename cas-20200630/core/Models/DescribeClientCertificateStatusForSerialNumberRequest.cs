// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateStatusForSerialNumberRequest : TeaModel {
        /// <summary>
        /// <para>The serial number of the client or server certificate to query. To query multiple certificates, separate their serial numbers with a comma.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/330884.html">ListClientCertificate</a> operation to retrieve the serial numbers of all client and server certificates.</para>
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
