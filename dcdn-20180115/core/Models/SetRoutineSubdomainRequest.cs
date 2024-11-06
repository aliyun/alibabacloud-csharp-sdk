// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class SetRoutineSubdomainRequest : TeaModel {
        /// <summary>
        /// <para>The parameters of the subdomain.</para>
        /// <para>The parameters are in the following format:</para>
        /// <pre><c>Subdomains: [
        ///     &quot;subdomain-test&quot;
        /// ]
        /// </c></pre>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;subdomain-test&quot;]</para>
        /// </summary>
        [NameInMap("Subdomains")]
        [Validation(Required=false)]
        public Dictionary<string, object> Subdomains { get; set; }

    }

}
