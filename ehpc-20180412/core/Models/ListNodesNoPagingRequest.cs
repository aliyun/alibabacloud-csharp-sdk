// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListNodesNoPagingRequest : TeaModel {
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
        /// <para>The name of the node. You can perform a fuzzy search. MySQL regular expressions are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Compute0</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The type of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Manager: management node</description></item>
        /// <item><description>Login: logon node</description></item>
        /// <item><description>Compute: compute node</description></item>
        /// </list>
        /// <para>Default value: Compute.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Compute</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("Sequence")]
        [Validation(Required=false)]
        public string Sequence { get; set; }

    }

}
