// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The filter options of the node list.</para>
        /// <para>Format: {&quot;status&quot;:&quot;node_status&quot;}. Replace node_status with the node status. Valid values of node_status:</para>
        /// <list type="bullet">
        /// <item><description>uninit: The node is being installed.</description></item>
        /// <item><description>exception: An exception occurred on the node.</description></item>
        /// <item><description>running: The node is running.</description></item>
        /// <item><description>initing: The node is being initialized.</description></item>
        /// <item><description>releasing: The node is being released.</description></item>
        /// <item><description>untracking: The node is not added to the cluster.</description></item>
        /// <item><description>stopped: The node is stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;status&quot;:&quot;running&quot;}</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The name of the node. You can perform a fuzzy search. MySQL regular expressions are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-HostName</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The prefix of the hostname. You can query nodes that have a specified prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>compute</para>
        /// </summary>
        [NameInMap("HostNamePrefix")]
        [Validation(Required=false)]
        public string HostNamePrefix { get; set; }

        /// <summary>
        /// <para>The suffix of the hostname. You can query nodes that have a specified suffix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01</para>
        /// </summary>
        [NameInMap("HostNameSuffix")]
        [Validation(Required=false)]
        public string HostNameSuffix { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: 1 to 100.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The private IP address of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para><c>172.16.**.**</c></para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The type of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Manager: management node</description></item>
        /// <item><description>Login: logon node</description></item>
        /// <item><description>Compute: compute node</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Manager</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        /// <summary>
        /// <para>The sorting method of the node list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Forward: sorts the nodes in chronological order.</description></item>
        /// <item><description>Backward: sorts the nodes in reverse chronological order.</description></item>
        /// </list>
        /// <para>Default value: Forward.</para>
        /// <remarks>
        /// <para> This parameter is used together with the SortBy parameter. If you set SortBy to AddedTime and set Sequence to Forward, nodes are queried in ascending order of time that they are added.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public string Sequence { get; set; }

        /// <summary>
        /// <para>The sorting method of the node list. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AddedTime: sorts the nodes by the time that they are added.</description></item>
        /// <item><description>HostName: sorts the nodes by their host names.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AddedTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

    }

}
