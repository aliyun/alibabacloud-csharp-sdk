// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListInvocationStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The command ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-hz01v8x80o3****</para>
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// <para>An array of execution statuses. An entry is returned for each node.</para>
        /// </summary>
        [NameInMap("InvokeInstances")]
        [Validation(Required=false)]
        public ListInvocationStatusResponseBodyInvokeInstances InvokeInstances { get; set; }
        public class ListInvocationStatusResponseBodyInvokeInstances : TeaModel {
            [NameInMap("InvokeInstance")]
            [Validation(Required=false)]
            public List<ListInvocationStatusResponseBodyInvokeInstancesInvokeInstance> InvokeInstance { get; set; }
            public class ListInvocationStatusResponseBodyInvokeInstancesInvokeInstance : TeaModel {
                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-uf6abz34m2714bp4****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The status of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Finished: The running of the node finished.</description></item>
                /// <item><description>Running: The node is running.</description></item>
                /// <item><description>Failed: The node failed to run.</description></item>
                /// <item><description>Stopped: The running of the node stopped.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("InstanceInvokeStatus")]
                [Validation(Required=false)]
                public string InstanceInvokeStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The status of the command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Finished: The execution of the command finished.</description></item>
        /// <item><description>Running: The command is being executed.</description></item>
        /// <item><description>Failed: The command failed to be executed.</description></item>
        /// <item><description>Stopped: The execution of the command stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Finished</para>
        /// </summary>
        [NameInMap("InvokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
