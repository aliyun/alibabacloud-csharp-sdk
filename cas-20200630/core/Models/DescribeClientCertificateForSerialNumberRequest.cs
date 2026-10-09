// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeClientCertificateForSerialNumberRequest : TeaModel {
        /// <summary>
        /// <para>The serial numbers of the client certificates or server certificates that you want to query. Separate multiple serial numbers with commas (,).</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/330884.html">ListClientCertificate</a> to query the serial numbers of all client certificates and server certificates.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>084bde9cd233f0ddae33adc438cfbbbd****</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

    }

}
