// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetAgentRuntimeStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of runtime statistics grouped by agent platform and agent provider. If AgentProvider is specified but no matching runtimes are found, a record with all statistical values set to 0 is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetAgentRuntimeStatisticResponseBodyData> Data { get; set; }
        public class GetAgentRuntimeStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The display name of the agent, which is determined by both the agent platform and the agent provider. For example, OpenClaw under the ENTERPRISE platform is displayed as OpenClaw, and OpenClaw under the JVS platform is displayed as JVS Claw.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Agentic Computer</para>
            /// </summary>
            [NameInMap("AgentDisplayName")]
            [Validation(Required=false)]
            public string AgentDisplayName { get; set; }

            /// <summary>
            /// <para>The agent platform, such as ENTERPRISE_AGENTIC_COMPUTER.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENTERPRISE_AGENTIC_COMPUTER</para>
            /// </summary>
            [NameInMap("AgentPlatform")]
            [Validation(Required=false)]
            public string AgentPlatform { get; set; }

            /// <summary>
            /// <para>The agent provider, such as AgenticComputer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AgenticComputer</para>
            /// </summary>
            [NameInMap("AgentProvider")]
            [Validation(Required=false)]
            public string AgentProvider { get; set; }

            /// <summary>
            /// <para>The number of expired runtime resources in this group. A runtime is counted as expired if its resource status is Expired or Ceased, case-insensitive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ExpiredCount")]
            [Validation(Required=false)]
            public int? ExpiredCount { get; set; }

            /// <summary>
            /// <para>The number of runtime resources without a configured channel in this group, which is the total number of runtime resources minus the number of runtime resources with a configured channel.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("NoChannelConfiguredRuntimeCount")]
            [Validation(Required=false)]
            public int? NoChannelConfiguredRuntimeCount { get; set; }

            /// <summary>
            /// <para>The number of runtime resources without a configured model in this group. A runtime is considered to have a configured model if either the runtime itself or its associated resource group has a model configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NoModelConfiguredRuntimeCount")]
            [Validation(Required=false)]
            public int? NoModelConfiguredRuntimeCount { get; set; }

            /// <summary>
            /// <para>The number of risky runtime resources in this group, deduplicated by runtime ID. A runtime is counted as risky if it has any of the following risks: the model configuration is modified, the third-party channel configuration is modified, or the agent is being uninstalled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskyRuntimeCount")]
            [Validation(Required=false)]
            public int? RiskyRuntimeCount { get; set; }

            /// <summary>
            /// <para>The total number of runtime resources in this group, deduplicated by runtime ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalRuntimeCount")]
            [Validation(Required=false)]
            public int? TotalRuntimeCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used to uniquely identify the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of returned statistics records, which is the length of the Data list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
