// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class EstimatedLogstashRestartTimeRequest : TeaModel {
        /// <summary>
        /// <para>The restart parameters, including the restart type, target nodes, blue-green deployment options, and concurrency settings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;restartType&quot;:&quot;nodeIp&quot;,&quot;nodes&quot;:[&quot;172.16.xx.xx&quot;],&quot;blueGreenDep&quot;:true}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly restart the instance. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
