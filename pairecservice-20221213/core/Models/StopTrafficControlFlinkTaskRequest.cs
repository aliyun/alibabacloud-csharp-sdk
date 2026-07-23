// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class StopTrafficControlFlinkTaskRequest : TeaModel {
        /// <summary>
        /// <para>The environment to which the instance belongs. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para>Daily: daily environment.</para>
        /// </description></item>
        /// <item><description><para>Pre: staging environment.</para>
        /// </description></item>
        /// <item><description><para>Prod: production environment.</para>
        /// </description></item>
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
