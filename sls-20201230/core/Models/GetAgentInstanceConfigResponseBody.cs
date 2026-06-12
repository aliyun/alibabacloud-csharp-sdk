// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetAgentInstanceConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The owner of the configuration for the process.</para>
        /// </summary>
        [NameInMap("attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// <para>The default configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The type of the process-level configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apm_biz_trace</para>
        /// </summary>
        [NameInMap("configType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        /// <summary>
        /// <para>The time when the configuration was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1749543828</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The canary release configurations.</para>
        /// </summary>
        [NameInMap("grayConfigs")]
        [Validation(Required=false)]
        public List<AgentInstanceConfigGrayConfigs> GrayConfigs { get; set; }

        /// <summary>
        /// <para>The time when the configuration was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1749543828</para>
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

    }

}
