// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeDomainExtensionAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the additional certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>de-bp1rp7ta1****</para>
        /// </summary>
        [NameInMap("DomainExtensionId")]
        [Validation(Required=false)]
        public string DomainExtensionId { get; set; }

        /// <summary>
        /// <para>The frontend port of the HTTPS listener that is configured for the SLB instance. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The ID of the SLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1o94dp5i6*****earr9g6d1l</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48C1B671-C6DB-4DDE-9B30-10557E36CDE0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the server certificate used by the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231579085529123_166f82******_1714763408_709981430</para>
        /// </summary>
        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

    }

}
