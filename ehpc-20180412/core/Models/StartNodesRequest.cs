// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class StartNodesRequest : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public List<StartNodesRequestInstance> Instance { get; set; }
        public class StartNodesRequestInstance : TeaModel {
            /// <summary>
            /// <para>The ID of the Nth node. Valid values of N: 1 to 100.</para>
            /// <para>Make sure that the node is in the Stopped state. You can call the <a href="https://help.aliyun.com/document_detail/87161.html">ListNodes</a> operation to query the status of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp13p7vlcb1uihfv****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// <para>The role of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Manager: management node</description></item>
        /// <item><description>Login: logon node</description></item>
        /// <item><description>Compute: compute node</description></item>
        /// </list>
        /// <para>Default value: Compute</para>
        /// 
        /// <b>Example:</b>
        /// <para>Compute</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
