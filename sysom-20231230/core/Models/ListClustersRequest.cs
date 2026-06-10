// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListClustersRequest : TeaModel {
        /// <summary>
        /// <para>Filter by cluster ID  </para>
        /// <remarks>
        /// <para>This cluster ID is not the ACK cluster ID, but the <c>id</c> field in the data returned by this API</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cb7d4cc26c8f845fb8a8255ffd394820e</para>
        /// </summary>
        [NameInMap("cluster_id")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><c>Running</c>: Cluster management is Normal;  </description></item>
        /// <item><description><c>Installing</c>: An install Job is in progress for the cluster;  </description></item>
        /// <item><description><c>Uninstalling</c>: An uninstall Job is in progress for the cluster;  </description></item>
        /// <item><description><c>Upgrading</c>: An Update Job is in progress for the cluster;  </description></item>
        /// <item><description><c>Offline</c>: The cluster is offline and management is abnormal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("cluster_status")]
        [Validation(Required=false)]
        public string ClusterStatus { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><c>ACK</c>: ACK cluster  </description></item>
        /// <item><description><c>CUSTOM</c>: Custom cluster (default clusters are classified as custom clusters)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACK</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>Current page number (starting from page 1)</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// <para>This field is deprecated. Use the <c>cluster_id</c> field for filtering instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb7d4cc26c8f845fb8a8255ffd394820e</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Filter plugins by plugin name</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxy-next-upstream</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
