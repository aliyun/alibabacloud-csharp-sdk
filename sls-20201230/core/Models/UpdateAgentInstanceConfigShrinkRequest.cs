// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateAgentInstanceConfigShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The attributes that specify the scope of the process-level configuration.</para>
        /// </summary>
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public string AttributesShrink { get; set; }

        /// <summary>
        /// <para>The default configurations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The configurations for the canary release environment.</para>
        /// </summary>
        [NameInMap("grayConfigs")]
        [Validation(Required=false)]
        public List<AgentInstanceConfigGrayConfigs> GrayConfigs { get; set; }

    }

}
