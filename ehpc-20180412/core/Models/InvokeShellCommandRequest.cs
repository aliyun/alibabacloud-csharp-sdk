// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class InvokeShellCommandRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
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
        /// <para>The content of the command. The content must be 2 to 2,048 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>echo &quot;hello world&quot;</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public string Command { get; set; }

        /// <summary>
        /// <para>The information of nodes on which the command is run.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public List<InvokeShellCommandRequestInstance> Instance { get; set; }
        public class InvokeShellCommandRequestInstance : TeaModel {
            /// <summary>
            /// <para>The ID of the Nth node instance on which the command is run.</para>
            /// <remarks>
            /// <para>This parameter specifies the node on which the command is run. If it is not specified, the command will be run on all nodes of the cluster.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1in9hmw3ur52x0****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// <para>The timeout period. If a command times out, the command process will be terminated. Unit: seconds.</para>
        /// <para>Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The working directory of the command. Default value: <c>/root</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home</para>
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
