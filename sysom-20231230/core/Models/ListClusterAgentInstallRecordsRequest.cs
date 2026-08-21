// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListClusterAgentInstallRecordsRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        [NameInMap("agent_config_id")]
        [Validation(Required=false)]
        public string AgentConfigId { get; set; }

        /// <summary>
        /// <para>Filters by cluster ID.</para>
        /// <remarks>
        /// <para>This cluster ID is not the ACK cluster ID. It is the <c>cluster_id</c> field in the data returned by this operation, or the <c>id</c> field in the data returned by the ListCluster operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cbd80af02b9d6454ebdc579c5e022d0c8</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The current page number (starting from 1).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies the agent ID to filter the installation list for the specified agent. This parameter can be used together with the plugin_version parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
        /// </summary>
        [NameInMap("plugin_id")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Cannot be used alone. Use this parameter together with plugin_id to filter the installation list for a specified version of the specified agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.4.0-1</para>
        /// </summary>
        [NameInMap("plugin_version")]
        [Validation(Required=false)]
        public string PluginVersion { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
