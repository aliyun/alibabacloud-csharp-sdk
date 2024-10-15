// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class QueryRobotTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The robocall tasks, in the JSON format.</para>
        /// <list type="bullet">
        /// <item><description><b>id</b>: the unique ID of the robocall task.</description></item>
        /// <item><description><b>taskName</b>: the task name.</description></item>
        /// <item><description><b>robotId</b>: the robot ID.</description></item>
        /// <item><description><b>robotName</b>: the robot name.</description></item>
        /// <item><description><b>status</b>: the task state.</description></item>
        /// <item><description><b>scheduleType</b>: the scheduling type. Valid values: <b>SINGLE</b> and <b>ORDER</b>. The value SINGLE indicates that the task was started immediately after it was created. The value ORDER indicates that the task was started at a scheduled time.</description></item>
        /// <item><description><b>createTime</b>: the time when the task was created, in the yyyy.MM.dd HH:mm:ss format.</description></item>
        /// <item><description><b>completeTime</b>: the time when the task was completed, in the yyyy.MM.dd HH:mm:ss format.</description></item>
        /// <item><description><b>fireTime</b>: the time when the task was started, in the yyyy.MM.dd HH:mm:ss format.</description></item>
        /// <item><description><b>totalCount</b>: the total number of calls processed.</description></item>
        /// <item><description><b>finishCount</b>: the number of calls completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[ {&quot;id&quot;: 1045001, &quot;taskName&quot;: &quot;Test Template&quot;, &quot;robotId&quot;: 1000000075003, &quot;robotName&quot;: &quot;robot&quot;, &quot;status&quot;: &quot;INIT&quot;,&quot;scheduleType&quot;: &quot;SINGLE&quot;, &quot;createTime&quot;: &quot;2019.06.14 14:55:23&quot;, &quot;completeTime&quot;: &quot;2019.06.14 14:55:23&quot;, &quot;fireTime&quot;: &quot;2019.06.14 14:55:23&quot;, &quot;totalCount&quot;: 1000, &quot;finishCount&quot;: 998} ]</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
