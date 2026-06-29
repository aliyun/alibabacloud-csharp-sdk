// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetPhysicalNodeOperationLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The node operation logs.</para>
        /// </summary>
        [NameInMap("OperationLogList")]
        [Validation(Required=false)]
        public List<GetPhysicalNodeOperationLogResponseBodyOperationLogList> OperationLogList { get; set; }
        public class GetPhysicalNodeOperationLogResponseBodyOperationLogList : TeaModel {
            /// <summary>
            /// <para>The log details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx</para>
            /// </summary>
            [NameInMap("Context")]
            [Validation(Required=false)]
            public string Context { get; set; }

            /// <summary>
            /// <para>The operation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-30 16:47:13</para>
            /// </summary>
            [NameInMap("OperationTime")]
            [Validation(Required=false)]
            public string OperationTime { get; set; }

            /// <summary>
            /// <para>The operation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TASK_UPDATE_PRIORITY: updates the node priority.</description></item>
            /// <item><description>PAUSE_TASK: pauses scheduling.</description></item>
            /// <item><description>RESUME_TASK: resumes scheduling.</description></item>
            /// <item><description>CREATE_NODE: creates a node.</description></item>
            /// <item><description>FORCE_DELETE_NODE: force deletes a node.</description></item>
            /// <item><description>UPDATE_NODE: updates a node.</description></item>
            /// <item><description>DELETE_NODE: deletes a node.</description></item>
            /// <item><description>CHANGE_NODE_OWNER: changes the node owner.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PAUSE_TASK</para>
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// <para>The operator ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>132222</para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The operator name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xx测试</para>
            /// </summary>
            [NameInMap("OperatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
