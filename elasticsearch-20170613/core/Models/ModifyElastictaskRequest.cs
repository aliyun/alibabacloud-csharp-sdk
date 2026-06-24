// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ModifyElastictaskRequest : TeaModel {
        /// <summary>
        /// <para>The scaling information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;elasticExpansionTask&quot;:     {         &quot;triggerType&quot;:&quot;crontab&quot;,         &quot;cronExpression&quot;:&quot;0 0 0 ? * MON&quot;,         &quot;elasticNodeCount&quot;:&quot;2&quot;,         &quot;targetIndices&quot;:[&quot;*&quot;],         &quot;replicaCount&quot;:&quot;2&quot;     } }</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
