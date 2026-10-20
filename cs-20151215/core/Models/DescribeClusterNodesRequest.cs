// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterNodesRequest : TeaModel {
        /// <summary>
        /// <para>The list of node instance IDs. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;i-bp11xjhwkj8k966u****,i-bp1dmhc2bu5igkyq****&quot;</para>
        /// </summary>
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The list of node IP addresses used for filtering. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.1</para>
        /// </summary>
        [NameInMap("nodeIps")]
        [Validation(Required=false)]
        public string NodeIps { get; set; }

        /// <summary>
        /// <para>The node labels used for filtering. Specify the labels as key=value pairs separated by commas (,). Multiple labels are evaluated with the AND operator. Only nodes that match all specified labels are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nodeLabels=app=nginx,env=prod</para>
        /// </summary>
        [NameInMap("nodeLabels")]
        [Validation(Required=false)]
        public string NodeLabels { get; set; }

        /// <summary>
        /// <para>The list of node names used for filtering. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou.192.168.0.1</para>
        /// </summary>
        [NameInMap("nodeNames")]
        [Validation(Required=false)]
        public string NodeNames { get; set; }

        /// <summary>
        /// <para>The node pool ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>npe25633140a7d4fbea56cd0479c******</para>
        /// </summary>
        [NameInMap("nodepool_id")]
        [Validation(Required=false)]
        public string NodepoolId { get; set; }

        /// <summary>
        /// <para>The page number of the current query.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return per page. Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The running states of the cluster nodes used for filtering. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>all</c>: does not filter nodes by running state and queries nodes in all states.</description></item>
        /// <item><description><c>running</c>: the cluster nodes that are running.</description></item>
        /// <item><description><c>removing</c>: the cluster nodes that are being removed.</description></item>
        /// <item><description><c>initial</c>: the cluster nodes that are being initialized.</description></item>
        /// <item><description><c>failed</c>: the cluster nodes that failed to be created.</description></item>
        /// </list>
        /// <para>Default value: <c>all</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
