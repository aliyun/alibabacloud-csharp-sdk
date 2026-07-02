// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListClusterAgentInstallRecordsRequest : TeaModel {
        [NameInMap("agent_config_id")]
        [Validation(Required=false)]
        public string AgentConfigId { get; set; }

        /// <summary>
        /// <para>Filter by cluster ID.</para>
        /// <remarks>
        /// <para>This cluster ID is not the ACK cluster ID, but the <c>cluster_id</c> field in the data returned by this API, or the <c>id</c> field in the data returned by the ListCluster API.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cbd80af02b9d6454ebdc579c5e022d0c8</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Current page number (starting from 1)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Specify this parameter to filter the installation list for a specific agent. Can be used in combination with the plugin_version parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
        /// </summary>
        [NameInMap("plugin_id")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>Cannot be used alone. Use in combination with plugin_id to filter the installation list for a specific agent version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.4.0-1</para>
        /// </summary>
        [NameInMap("plugin_version")]
        [Validation(Required=false)]
        public string PluginVersion { get; set; }

    }

}
