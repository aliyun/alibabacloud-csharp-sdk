// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTaskInstanceRelationResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The information about the nodes in the execution record of the task flow.</para>
        /// </summary>
        [NameInMap("NodeList")]
        [Validation(Required=false)]
        public GetTaskInstanceRelationResponseBodyNodeList NodeList { get; set; }
        public class GetTaskInstanceRelationResponseBodyNodeList : TeaModel {
            [NameInMap("Node")]
            [Validation(Required=false)]
            public List<GetTaskInstanceRelationResponseBodyNodeListNode> Node { get; set; }
            public class GetTaskInstanceRelationResponseBodyNodeListNode : TeaModel {
                /// <summary>
                /// <para>The business time of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-09 14:37:26</para>
                /// </summary>
                [NameInMap("BusinessTime")]
                [Validation(Required=false)]
                public string BusinessTime { get; set; }

                /// <summary>
                /// <para>The time when the execution of the task flow was complete. The time is displayed in the yyyy-MM-DD HH:mm:ss format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-11 14:38:57</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The amount of time consumed for running the node. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>170655</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public long? ExecuteTime { get; set; }

                /// <summary>
                /// <para>The ID of the execution record of the task flow.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14059</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The description of the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14059</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Spark SQL-1</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The type of the node. For more information about the valid values for this parameter, see <a href="https://help.aliyun.com/document_detail/424705.html">NodeType parameter</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>36</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public int? NodeType { get; set; }

                /// <summary>
                /// <para>The status of the node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The node is waiting to be scheduled.</description></item>
                /// <item><description><b>1</b>: The node is running.</description></item>
                /// <item><description><b>2</b>: The node is suspended.</description></item>
                /// <item><description><b>3</b>: The node failed to run.</description></item>
                /// <item><description><b>4</b>: The node is run.</description></item>
                /// <item><description><b>5</b>: The node is complete.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>028BF827-3801-5869-8548-F4A039256304</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
