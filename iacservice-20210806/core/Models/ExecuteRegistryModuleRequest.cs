// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ExecuteRegistryModuleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;region\&quot;: \&quot;cn-hangzhou\&quot;, \&quot;vpcId\&quot;: \&quot;vpc-bp145sc90s26q0qbkfb6i\&quot;, \&quot;functionName\&quot;: \&quot;filemgr-cn-hangzhou-063fd4aead\&quot;, \&quot;mountPointsServerAddr\&quot;: \&quot;063fd4aead-dex50.cn-hangzhou.nas.aliyuncs.com\&quot;}</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

    }

}
