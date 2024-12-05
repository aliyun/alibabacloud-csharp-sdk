// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetNodeConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the cluster</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc_sh_domain_2</para>
        /// </summary>
        [NameInMap("clusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The node name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-30174dhoz53_qrs</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The node type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>qrs: Query Result Searcher (QRS) worker</description></item>
        /// <item><description>search: Search worker</description></item>
        /// <item><description>index: index</description></item>
        /// <item><description>cluster: cluster</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>index</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
