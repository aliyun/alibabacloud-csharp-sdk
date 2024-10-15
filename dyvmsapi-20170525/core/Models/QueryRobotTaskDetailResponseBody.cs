// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotTaskDetailResponseBody : TeaModel {
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
        /// <para>The details of the robocall task, in the JSON format.</para>
        /// <list type="bullet">
        /// <item><description><b>Id</b>: the unique ID of the robocall task.</description></item>
        /// <item><description><b>taskName</b>: the task name.</description></item>
        /// <item><description><b>robotId</b>: the robot ID.</description></item>
        /// <item><description><b>robotName</b>: the robot name.</description></item>
        /// <item><description><b>corpName</b>: the company name.</description></item>
        /// <item><description><b>caller</b>: the number displayed to the called party.</description></item>
        /// <item><description><b>numberStatusIdent</b>: indicates whether number status identification was enabled. Valid values: <b>true</b> and <b>false</b>. The value true indicates that number status identification was enabled. The value false indicates that number status identification was not enabled.</description></item>
        /// <item><description><b>status</b>: the task state. You can call the <a href="~~QueryRobotTaskList~~">QueryRobotTaskList</a> operation to obtain the task state from the <c>status</c> parameter.</description></item>
        /// <item><description><b>scheduleType</b>: the scheduling type. Valid values: <b>SINGLE</b> and <b>ORDER</b>. The value SINGLE indicates that the task was started immediately after it was created. The value ORDER indicates that the task was started at a scheduled time.</description></item>
        /// <item><description><b>retryType</b>: indicates whether auto-redial was enabled. Valid values: <b>1</b> and <b>0</b>. The value 1 indicates that auto-redial was enabled. The value 0 indicates that auto-redial was not enabled.</description></item>
        /// <item><description><b>recallStateCodes</b>: the call state in which redial is required. Valid values: <b>200010</b>, <b>200011</b>, <b>200002</b>, <b>200012</b>, and <b>200005</b>. The value 200010 indicates that the phone of the called party was powered off. The value 200011 indicates that the number of the called party was out of service. The value 200002 indicates that the line was busy. The value 200012 indicates that the call was lost. The value 200005 indicates that the called party could not be connected.</description></item>
        /// <item><description><b>recallTimes</b>: the number of redial times.</description></item>
        /// <item><description><b>recallInterval</b>: the redial interval. Unit: minutes.</description></item>
        /// <item><description><b>createTime</b>: the time when the task was created, in the yyyy-MM-dd HH:mm:ss format.</description></item>
        /// <item><description><b>fireTime</b>: the time when the task was started, in the yyyy-MM-dd HH:mm:ss format.</description></item>
        /// <item><description><b>completeTime</b>: the time when the task was completed, in the yyyy-MM-dd HH:mm:ss format.</description></item>
        /// <item><description><b>filename</b>: the name of the called number file.</description></item>
        /// <item><description><b>ossFilePath</b>: the path of the called number file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;id&quot;:1045001,&quot;taskName&quot;:&quot;Test Template&quot;,&quot;robotId&quot;:1000000075003,&quot;robotName&quot;:&quot;robot&quot;,&quot;corpName&quot;:&quot;company &quot;,&quot;caller&quot;:&quot;057156xxxx,0571568xxxx&quot;, &quot;numberStatusIdent&quot;:true,&quot;status&quot;:&quot;INIT&quot;,&quot;scheduleType&quot;:&quot;SINGLE&quot;, &quot;retryType&quot;:1,&quot;recallStateCodes&quot;:&quot;200010,200011&quot;, &quot;recallTimes&quot;:2,&quot;recallInterval&quot;:5,&quot;createTime&quot;: &quot;2019-06-14 11:04:19&quot;,&quot;fireTime&quot;:&quot;2019-06-14 11:05:23&quot;,&quot;completeTime&quot;: &quot;2019-06-14 18:21:06&quot;,&quot;called&quot;: [{&quot;fileName&quot;: &quot;5102636f-7be6-4a2d-9ac7-755a2e140a50--robotCallApi&quot;, &quot;ossFilePath&quot;: &quot;<a href="http://test.cn-hangzhou.oss.aliyun-inc.com/5102636f-7be6-4a2d-9ac7-755a2e140a50--robotCallApi.xlsx%22%7D%5D%7D">http://test.cn-hangzhou.oss.aliyun-inc.com/5102636f-7be6-4a2d-9ac7-755a2e140a50--robotCallApi.xlsx&quot;}]}</a></para>
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
