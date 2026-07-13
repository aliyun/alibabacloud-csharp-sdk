// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeAtiCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate to query. Call the ListAtiCertificates operation to query the target certificate information and obtain the ID from the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2074041094504542210</para>
        /// </summary>
        [NameInMap("AgentCertificateId")]
        [Validation(Required=false)]
        public string AgentCertificateId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to ensure that the value is unique among different requests. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhbGciOiJIUzI1NiIsInR5cC.....</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
