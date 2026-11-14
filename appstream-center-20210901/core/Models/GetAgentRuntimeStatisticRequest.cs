// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetAgentRuntimeStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The agent platform used to filter the statistics scope, such as ENTERPRISE_AGENTIC_COMPUTER. If this parameter is not specified, all agent platforms are included in the statistics. If an unsupported value is passed, a parameter error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE_AGENTIC_COMPUTER</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>The agent provider used to filter the statistics scope, such as AgenticComputer. If this parameter is not specified, all agent providers are included in the statistics. If an unsupported value is passed, a parameter error is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgenticComputer</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>The business type used to filter runtimes of a specified business type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The runtime environment type of the runtime resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudDesktop</para>
        /// </summary>
        [NameInMap("RuntimeType")]
        [Validation(Required=false)]
        public string RuntimeType { get; set; }

    }

}
