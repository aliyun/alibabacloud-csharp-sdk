// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class BatchSetGrayDomainFunctionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;functionArgs&quot;: [{&quot;argName&quot;: &quot;key&quot;,&quot;argValue&quot;: &quot;Content-Encoding&quot;},{&quot;argName&quot;: &quot;value&quot;,&quot;argValue&quot;: &quot;gzip&quot;}],&quot;functionName&quot;: &quot;set_resp_header&quot;} ]</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public string Configs { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com,xxx.org.com</para>
        /// </summary>
        [NameInMap("DomainNames")]
        [Validation(Required=false)]
        public string DomainNames { get; set; }

    }

}
