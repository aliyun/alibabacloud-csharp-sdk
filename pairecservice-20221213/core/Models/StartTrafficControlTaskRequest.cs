// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class StartTrafficControlTaskRequest : TeaModel {
        /// <summary>
        /// <para>The environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Daily: the daily environment.</description></item>
        /// <item><description>Pre: the staging environment.</description></item>
        /// <item><description>Prod: the production environment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pre</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-123***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
