// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class EstimatedRestartTimeRequest : TeaModel {
        /// <summary>
        /// <para>The restart parameters, such as the restart method, target nodes, and blue-green deployment, represented as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;restartType&quot;:&quot;nodeIp&quot;,&quot;nodes&quot;:[&quot;172.16.xx.xx&quot;],&quot;blueGreenDep&quot;:true}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        /// <summary>
        /// <para>Specifies whether to force a restart. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

    }

}
