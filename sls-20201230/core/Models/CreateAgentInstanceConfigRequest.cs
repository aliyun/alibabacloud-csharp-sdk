// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateAgentInstanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The process that the configuration applies to.</para>
        /// </summary>
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

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
        /// <para>The type of the process-level configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apm_trace</para>
        /// </summary>
        [NameInMap("configType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>The canary release environment.</para>
        /// </summary>
        [NameInMap("grayConfigs")]
        [Validation(Required=false)]
        public List<AgentInstanceConfigGrayConfigs> GrayConfigs { get; set; }

    }

}
