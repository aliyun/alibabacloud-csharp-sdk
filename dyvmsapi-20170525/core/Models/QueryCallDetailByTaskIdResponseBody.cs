// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryCallDetailByTaskIdResponseBody : TeaModel {
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
        /// <para>The call details of the outbound robocall task, in the JSON format.</para>
        /// <list type="bullet">
        /// <item><description><para><b>startDate</b>: the time when the call was answered.</para>
        /// </description></item>
        /// <item><description><para><b>stateDesc</b>: the reason why the call was hung up. If the status code of early media was returned, this parameter indicates the reason why the status code of early media was used.</para>
        /// </description></item>
        /// <item><description><para><b>statusCode</b>: the status code.</para>
        /// </description></item>
        /// <item><description><para><b>EndDate</b>: the time when the call was ended.</para>
        /// </description></item>
        /// <item><description><para><b>calleeShowNumber</b>: the calling number displayed to the called party.</para>
        /// </description></item>
        /// <item><description><para><b>callee</b>: the called number.</para>
        /// </description></item>
        /// <item><description><para><b>duration</b>: the billing duration.</para>
        /// </description></item>
        /// <item><description><para><b>gmtCreate</b>: the time when the outbound robocall task was created.</para>
        /// </description></item>
        /// <item><description><para><b>hangupDirection</b>: the party who hung up.</para>
        /// </description></item>
        /// <item><description><para><b>tags</b>: the call tags.</para>
        /// </description></item>
        /// <item><description><para><b>dialogCount</b>: the number of conversation rounds in the call.</para>
        /// </description></item>
        /// <item><description><para><b>sureCount</b>: the number of times that the robocall task was acknowledged.</para>
        /// </description></item>
        /// <item><description><para><b>denyCount</b>: the number of times that the robocall task was denied.</para>
        /// </description></item>
        /// <item><description><para><b>rejectCount</b>: the number of times that the robocall task was rejected.</para>
        /// </description></item>
        /// <item><description><para><b>customCount</b>: the number of times that the robocall task was customized.</para>
        /// </description></item>
        /// <item><description><para><b>knowledgeCount</b>: the number of times that the knowledge base was queried.</para>
        /// </description></item>
        /// <item><description><para><b>recordFile</b>: the download URL of the recording file. The URL is valid only for 48 hours. The recording file must be downloaded in time.</para>
        /// </description></item>
        /// <item><description><para><b>callId</b>: the call ID.</para>
        /// </description></item>
        /// <item><description><para><b>recordStatus</b>: indicates whether a recording file was available. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: A recording file was available.</description></item>
        /// <item><description>2: No recording file was available.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>knowledgeCommonCount</b>: the number of call failures caused by the common issues in the knowledge base.</para>
        /// </description></item>
        /// <item><description><para><b>knowledgeBusinessCount</b>: the number of call failures caused by the business issues in the knowledge base.</para>
        /// </description></item>
        /// <item><description><para><b>callee</b>: the called number.</para>
        /// </description></item>
        /// <item><description><para><b>dialogDetail</b>: the conversation details. The value is a JSON array that contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>role</b>: the role who spoke.</description></item>
        /// <item><description><b>content</b>: the content of the speech.</description></item>
        /// <item><description><b>time</b>: the start time of the speech.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The preceding parameters are for reference only. The actually returned parameters prevail.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;rejectCount&quot;:0,&quot;dialogCount&quot;:3,&quot;tags&quot;:&quot;&quot;,&quot;startDate&quot;:&quot;2019-03-27 10:34:54&quot;,&quot;gmtCreate&quot;:&quot;2019-03-27 10:34:40&quot;,&quot;sureCount&quot;:0,&quot;state&quot;:&quot;200000&quot;,&quot;recordFile&quot;:&quot;<a href="http://alicom-fc-record-biz.cn-hangzhou.oss.aliyun-inc.com/Freeswitch_RU_115987800002_02c3554f-ea24-422d-b1de-e671f455f21a_record.wav?OSSAccessKeyId=bypFNbGJVk73****&Signature=VWHOX%2FFhvvtSkxfMTw%2F5fdJUQuk%3D&Expires=1554382725%22,%22defaultCount%22:0,%22endDate%22:%222019-03-27">http://alicom-fc-record-biz.cn-hangzhou.oss.aliyun-inc.com/Freeswitch_RU_115987800002_02c3554f-ea24-422d-b1de-e671f455f21a_record.wav?OSSAccessKeyId=bypFNbGJVk73****&amp;Signature=VWHOX%2FFhvvtSkxfMTw%2F5fdJUQuk%3D&amp;Expires=1554382725&quot;,&quot;defaultCount&quot;:0,&quot;endDate&quot;:&quot;2019-03-27</a> 10:35:09&quot;,&quot;calleeShowNumber&quot;:&quot;1390000****&quot;,&quot;customCount&quot;:0,&quot;callId&quot;:&quot;1390000****&quot;,&quot;knowledgeCount&quot;:0,&quot;recordStatus&quot;:1,&quot;denyCount&quot;:0,&quot;duration&quot;:16,&quot;knowledgeCommonCount&quot;:0,&quot;callee&quot;:&quot;1390000****&quot;,&quot;knowledgeBusinessCount&quot;:0,&quot;hangupDirection&quot;:1}</para>
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
        /// <para>D86B61A8-F2EE-4E4C-9F05-08A4676FFD89</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
