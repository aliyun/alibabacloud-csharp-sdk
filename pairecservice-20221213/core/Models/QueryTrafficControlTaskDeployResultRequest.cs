// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class QueryTrafficControlTaskDeployResultRequest : TeaModel {
        /// <summary>
        /// <para>The environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Daily: daily environment.</description></item>
        /// <item><description>Pre: staging environment.</description></item>
        /// <item><description>Prod: production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec_123****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
