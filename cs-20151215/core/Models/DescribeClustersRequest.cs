// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClustersRequest : TeaModel {
        /// <summary>
        /// <para>The cluster type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ManagedKubernetes</para>
        /// </summary>
        [NameInMap("clusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>Perform a fuzzy match query based on the cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("resource_group_id")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
