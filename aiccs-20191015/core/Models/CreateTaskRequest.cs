// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class CreateTaskRequest : TeaModel {
        /// <summary>
        /// <para>Call string (callee information and parameter list). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LIST</b>: <c>05715678****,05715679****</c></description></item>
        /// <item><description><b>JSON</b>: <c>{&quot;ParamNames&quot;:[&quot;name&quot;,&quot;age&quot;],&quot;CalleeList&quot;:[{&quot;Callee&quot;:&quot;1810000****&quot;,&quot;Params&quot;:[&quot;Zhang San&quot;,&quot;20&quot;]},{&quot;Callee&quot;:&quot;1810001****&quot;,&quot;Params&quot;:[&quot;Li Si&quot;,&quot;21&quot;]}]}</c>. In this example, ParamNames represents the List of Parameter Names; Params represents the List of parameter values.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The order of the Parameter Name List and the parameter value List must correspond.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>A maximum of 1 000 callee numbers is allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ParamNames&quot;:[&quot;name&quot;,&quot;age&quot;],&quot;CalleeList&quot;:[{&quot;Callee&quot;:&quot;1810000****&quot;,&quot;Params&quot;:[&quot;张三&quot;,&quot;20&quot;]},{&quot;Callee&quot;:&quot;1810001****&quot;,&quot;Params&quot;:[&quot;李四&quot;,&quot;21&quot;]}]}</para>
        /// </summary>
        [NameInMap("CallString")]
        [Validation(Required=false)]
        public string CallString { get; set; }

        /// <summary>
        /// <para>Call string type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>LIST</b>  </description></item>
        /// <item><description><b>JSON</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("CallStringType")]
        [Validation(Required=false)]
        public string CallStringType { get; set; }

        /// <summary>
        /// <para>Outbound caller number.</para>
        /// <remarks>
        /// <para>The number must be a purchased number. Separate multiple numbers with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571<b><b>5678,0571</b></b>5679</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Retry Count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RetryCount")]
        [Validation(Required=false)]
        public int? RetryCount { get; set; }

        /// <summary>
        /// <para>Whether to enable automatic retry. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Retry.</description></item>
        /// <item><description><b>0</b>: No retry.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RetryFlag")]
        [Validation(Required=false)]
        public int? RetryFlag { get; set; }

        /// <summary>
        /// <para>Retry interval. Unit: minute. Must be greater than 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public int? RetryInterval { get; set; }

        /// <summary>
        /// <para>Call statuses that require redialing. Separate multiple statuses with commas (,). Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>200010</b>: Power off  </description></item>
        /// <item><description><b>200011</b>: Service suspended  </description></item>
        /// <item><description><b>200002</b>: Busy  </description></item>
        /// <item><description><b>200012</b>: Call failed  </description></item>
        /// <item><description><b>200005</b>: Unable to connect  </description></item>
        /// <item><description><b>200003</b>: No acknowledgement</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200010,200011</para>
        /// </summary>
        [NameInMap("RetryStatusCode")]
        [Validation(Required=false)]
        public string RetryStatusCode { get; set; }

        /// <summary>
        /// <para>ID of the specified robot (script ID), indicating which robot script to use for initiating calls.  </para>
        /// <para>You can obtain the script ID on the <a href="https://aiccs.console.aliyun.com/patter/list">Script Management</a> page in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("RobotId")]
        [Validation(Required=false)]
        public string RobotId { get; set; }

        /// <summary>
        /// <para>Concurrency (number of agents).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SeatCount")]
        [Validation(Required=false)]
        public string SeatCount { get; set; }

        /// <summary>
        /// <para>Indicates whether to start immediately.  </para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.  </description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>是</para>
        /// </summary>
        [NameInMap("StartNow")]
        [Validation(Required=false)]
        public bool? StartNow { get; set; }

        /// <summary>
        /// <para>Task Name. Supports Chinese and English characters. Length: 0 to 30 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试任务</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>Work day. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Monday.</description></item>
        /// <item><description><b>2</b>: Tuesday.</description></item>
        /// <item><description><b>3</b>: Wednesday.</description></item>
        /// <item><description><b>4</b>: Thursday.</description></item>
        /// <item><description><b>5</b>: Friday.</description></item>
        /// <item><description><b>6</b>: Saturday.</description></item>
        /// <item><description><b>7</b>: Sunday.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WorkDay")]
        [Validation(Required=false)]
        public string WorkDay { get; set; }

        /// <summary>
        /// <para>List of working hours (accurate to the minute).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10:00-12:00,13:00-14:00</para>
        /// </summary>
        [NameInMap("WorkTimeList")]
        [Validation(Required=false)]
        public string WorkTimeList { get; set; }

    }

}
