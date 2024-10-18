// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID. You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The hostnames of the compute nodes that you want to query.</para>
        /// </summary>
        [NameInMap("Hostnames")]
        [Validation(Required=false)]
        public List<string> Hostnames { get; set; }

        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The IP addresses of the compute nodes that you want to query.</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public List<string> PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The queues to which the nodes belong.</para>
        /// </summary>
        [NameInMap("QueueNames")]
        [Validation(Required=false)]
        public List<string> QueueNames { get; set; }

        /// <summary>
        /// <para>Specifies whether the results are sorted in ascending or descending order. Valid values: forward (ascending) and backward (descending).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public string Sequence { get; set; }

        /// <summary>
        /// <para>The sorting method of the node list. Valid values: addedtime: sorted by the time when the node was added. hostname: sorted by hostname. Default value: addedtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AddedTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The states of the compute nodes to be queried.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

    }

}
