// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotTaskCallListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For more information about other response codes, see <a href="https://help.aliyun.com/document_detail/112502.html">API error codes</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the robocall task, which is a JSON-formatted array.</para>
        /// <list type="bullet">
        /// <item><description><b>taskId</b>: the unique ID of the robocall task.</description></item>
        /// <item><description><b>caller</b>: the calling number.</description></item>
        /// <item><description><b>called</b>: the called number.</description></item>
        /// <item><description><b>duration</b>: the call duration. Unit: seconds.</description></item>
        /// <item><description><b>label</b>: the label of the called party.</description></item>
        /// <item><description><b>dialogCount</b>: the number of conversation rounds in the call.</description></item>
        /// <item><description><b>callResult</b>: the call result.</description></item>
        /// <item><description><b>hangupDirection</b>: the party who hung up. Valid values: <b>1</b> and <b>0</b>. The value 1 indicates the called party, and the value 0 indicates the robot.</description></item>
        /// <item><description><b>transferResult</b>: the result of transferring the call to an agent. Valid values: <b>1</b>, <b>0</b>, and <b>3</b>. The value 1 indicates that the call was transferred to an agent. The value 0 indicates that the call failed to be transferred to an agent. The value 3 indicates that the call was not transferred to an agent.</description></item>
        /// <item><description><b>transferNumber</b>: the phone number of the agent to whom the call was transferred.</description></item>
        /// <item><description><b>transferFailReason</b>: the reason why the call failed to be transferred to an agent.</description></item>
        /// <item><description><b>callId</b>: the unique receipt ID of the call.</description></item>
        /// <item><description><b>recallCurTimes</b>: the number of recalls.</description></item>
        /// <item><description><b>callStartTime</b>: the start time of the call.</description></item>
        /// <item><description><b>callEndTime</b>: the end time of the call.</description></item>
        /// <item><description><b>sureCount</b>: the number of times that the robocall task was acknowledged.</description></item>
        /// <item><description><b>denyCount</b>: the number of times that the robocall task was denied.</description></item>
        /// <item><description><b>rejectCount</b>: the number of times that the robocall task was rejected.</description></item>
        /// <item><description><b>customCount</b>: the number of times that the robocall task was customized.</description></item>
        /// <item><description><b>knowledgeCount</b>: the number of times that the knowledge base was queried.</description></item>
        /// <item><description><b>defaultCount</b>: the default number of calls.</description></item>
        /// <item><description><b>knowledgeBusinessCount</b>: the number of call failures caused by the business issues in the knowledge base.</description></item>
        /// <item><description><b>knowledgeCommonCount</b>: the number of call failures caused by the common issues in the knowledge base.</description></item>
        /// </list>
        /// <hr>
        /// 
        /// <b>Example:</b>
        /// <para>[ {&quot;taskId&quot;:&quot;1045001&quot;, &quot;caller&quot;:&quot;0571-889****&quot;, &quot;called&quot;: &quot;130<b><b>0000&quot;, &quot;duration&quot;:&quot;60&quot;, &quot;label&quot;:&quot;Invitation&quot;, &quot;dialogCount&quot;:&quot;3&quot;, &quot;callResult&quot;:&quot;Not Available&quot;, &quot;hangupDirection&quot;:&quot;1&quot;, &quot;transferResult&quot;:&quot;3&quot;, &quot;transferNumber&quot;:&quot;0571-8833</b></b>&quot;, &quot;transferFailReason&quot;:&quot;User hangs up&quot;, &quot;callId&quot;:&quot;116950320375^10375010****&quot;, &quot;recallCurTimes&quot;:&quot;2&quot;, &quot;callStartTime&quot;:&quot;2019.06.14 15:22:23&quot;, &quot;callEndTime&quot;:&quot;2019.06.14 15:22:55&quot;, &quot;sureCount&quot;:&quot;2&quot;, &quot;denyCount&quot;:&quot;2&quot;, &quot;rejectCount&quot;:&quot;0&quot;, &quot;customCount:&quot;0&quot;, &quot;knowledgeCount&quot;:&quot;0&quot;, &quot;defaultCount&quot;:&quot;0&quot;, &quot;knowledgeBusinessCount&quot;:&quot;0&quot;, &quot;knowledgeCommonCount&quot;:&quot;0&quot;} ]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
