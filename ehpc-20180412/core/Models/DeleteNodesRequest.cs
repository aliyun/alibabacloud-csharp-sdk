// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteNodesRequest : TeaModel {
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
        public List<DeleteNodesRequestInstance> Instance { get; set; }
        public class DeleteNodesRequestInstance : TeaModel {
            /// <summary>
            /// <para>The ID of the compute node that you want to delete. Valid values of N: 1 to 100.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87126.html">DescribeCluster</a> operation to query the IDs of the nodes in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp13p7vlcb1uihfv****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to release the instances that are created by using E-HPC.</para>
        /// <para>Default value: true</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ReleaseInstance")]
        [Validation(Required=false)]
        public bool? ReleaseInstance { get; set; }

        /// <summary>
        /// <para>Specifies whether to directly delete the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Sync")]
        [Validation(Required=false)]
        public bool? Sync { get; set; }

    }

}
