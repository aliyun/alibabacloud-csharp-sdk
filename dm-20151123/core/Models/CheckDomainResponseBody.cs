// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class CheckDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of the domain name. Indicates whether the domain name is verified and available.</para>
        /// <list type="bullet">
        /// <item><description>0: indicates that the domain name is verified and available.</description></item>
        /// <item><description>1: indicates that the domain name fails to be verified and is unavailable.</description></item>
        /// <item><description>2: indicates that the domain name is available, but not filed or configured with a CNAME record.</description></item>
        /// <item><description>3: indicates that the domain name is available but not filed.</description></item>
        /// <item><description>4: indicates that the domain name is available but not configured with a CNAME record.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public int? DomainStatus { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0B82E83-A1D9-4FE6-97D2-F4B231F80B02</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
