// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class UpdateClusterAgentConfigRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the component whose configuration you want to update.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74a86327-3170-412c-8e67-da3389ec56a9</para>
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The ID of the cluster. You can call the ListClusters operation to obtain the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c8b90bc1b2ef0436f81213c032b75c5f3</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the component configuration to be installed on the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f0078fbb-4213-11f0-a19b-00163e4ae208</para>
        /// </summary>
        [NameInMap("configId")]
        [Validation(Required=false)]
        public string ConfigId { get; set; }

    }

}
