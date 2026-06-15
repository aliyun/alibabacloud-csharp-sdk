// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class CheckDomainResponseBody : TeaModel {
        /// <summary>
        /// <para>Domain status. Indicates whether the verification was successful, with values as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Available, verified successfully</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Unavailable, verification failed</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DomainStatus")]
        [Validation(Required=false)]
        public int? DomainStatus { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0B82E83-A1D9-4FE6-97D2-F4B231F80B02</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
