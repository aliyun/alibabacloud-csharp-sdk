// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SetQueueRequest : TeaModel {
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
        [NameInMap("Node")]
        [Validation(Required=false)]
        public List<SetQueueRequestNode> Node { get; set; }
        public class SetQueueRequestNode : TeaModel {
            /// <summary>
            /// <para>The name of the compute node that you want to move. Valid values of N: 1 to 100.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87161.html">ListNodes</a> operation to query the names of the compute nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>compute1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The name of the destination queue.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/92176.html">ListQueues</a> operation to query the queue name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>work</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

    }

}
