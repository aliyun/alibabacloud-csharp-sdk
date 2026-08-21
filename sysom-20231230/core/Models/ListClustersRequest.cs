// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class ListClustersRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>Filters by cluster ID.</para>
        /// <remarks>
        /// <para>This cluster ID is not the ACK cluster ID. It is the <c>id</c> field returned by this operation.</para>
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
        /// <item><description><c>Running</c>: The cluster is managed normally.</description></item>
        /// <item><description><c>Installing</c>: An installation task is in progress for the cluster.</description></item>
        /// <item><description><c>Uninstalling</c>: An uninstallation task is in progress for the cluster.</description></item>
        /// <item><description><c>Upgrading</c>: An update task is in progress for the cluster.</description></item>
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
        /// <item><description><c>ACK</c>: ACK cluster.</description></item>
        /// <item><description><c>CUSTOM</c>: Custom cluster (default clusters belong to custom clusters).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACK</para>
        /// </summary>
        [NameInMap("cluster_type")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The current page number (starting from page 1).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("current")]
        [Validation(Required=false)]
        public long? Current { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> Use the cluster_id parameter to filter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb7d4cc26c8f845fb8a8255ffd394820e</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Filters plugins by plugin name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxy-next-upstream</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
