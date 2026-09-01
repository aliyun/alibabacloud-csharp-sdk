// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeProcessTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeProcessTasksResponseBodyPage Page { get; set; }
        public class DescribeProcessTasksResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The current page number in the paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page in the paging query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The list of disposal tasks.</para>
        /// </summary>
        [NameInMap("ProcessTasks")]
        [Validation(Required=false)]
        public List<DescribeProcessTasksResponseBodyProcessTasks> ProcessTasks { get; set; }
        public class DescribeProcessTasksResponseBodyProcessTasks : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID that submitted the disposal task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxx355</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The name of the disposed entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.1.1.x</para>
            /// </summary>
            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            /// <summary>
            /// <para>The type of the disposed entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ip</para>
            /// </summary>
            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            /// <summary>
            /// <para>The UUID of the entity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69d189e2-ec17-4676-a2fe-02969234****</para>
            /// </summary>
            [NameInMap("EntityUuid")]
            [Validation(Required=false)]
            public string EntityUuid { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sts_openapi.Info.DefenseSceneNotSupported</para>
            /// </summary>
            [NameInMap("ErrCode")]
            [Validation(Required=false)]
            public string ErrCode { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ParamError : The parameters of your request are invalid</para>
            /// </summary>
            [NameInMap("ErrMsg")]
            [Validation(Required=false)]
            public string ErrMsg { get; set; }

            /// <summary>
            /// <para>The error tip.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Verify that the input parameters of the components are correct</para>
            /// </summary>
            [NameInMap("ErrTip")]
            [Validation(Required=false)]
            public string ErrTip { get; set; }

            /// <summary>
            /// <para>The UUID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c1020ce1-d6a5-11e8-8298-00163e10****</para>
            /// </summary>
            [NameInMap("EventUuid")]
            [Validation(Required=false)]
            public string EventUuid { get; set; }

            /// <summary>
            /// <para>The creation time of the disposal task. Format: 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700031183572</para>
            /// </summary>
            [NameInMap("GmtCreateMillis")]
            [Validation(Required=false)]
            public long? GmtCreateMillis { get; set; }

            /// <summary>
            /// <para>The modification time of the disposal task. Format: 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700031183572</para>
            /// </summary>
            [NameInMap("GmtModifiedMillis")]
            [Validation(Required=false)]
            public long? GmtModifiedMillis { get; set; }

            /// <summary>
            /// <para>The input parameters of the disposal task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;groupuuid&quot;:&quot;c6a9b1df-f4ac-4078-bef4-99xxxxxx&quot;}</para>
            /// </summary>
            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

            /// <summary>
            /// <para>The ID of the associated strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>92af3c79-1754-4646-9366-9ddbd1e45536_****</para>
            /// </summary>
            [NameInMap("ProcessStrategyUuid")]
            [Validation(Required=false)]
            public string ProcessStrategyUuid { get; set; }

            /// <summary>
            /// <para>The time when the disposal task was dispatched. Format: 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700031183572</para>
            /// </summary>
            [NameInMap("ProcessTime")]
            [Validation(Required=false)]
            public long? ProcessTime { get; set; }

            /// <summary>
            /// <para>The unblocking time of the disposal task. Format: 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1700031183572</para>
            /// </summary>
            [NameInMap("RemoveTime")]
            [Validation(Required=false)]
            public long? RemoveTime { get; set; }

            /// <summary>
            /// <para>The UUID of the playbook execution record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93e5df20-3d03-42e1-b44b-58197c71****</para>
            /// </summary>
            [NameInMap("ReqUuid")]
            [Validation(Required=false)]
            public string ReqUuid { get; set; }

            /// <summary>
            /// <para>The scene code of the disposal task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>event_xxx_whole_process</para>
            /// </summary>
            [NameInMap("SceneCode")]
            [Validation(Required=false)]
            public string SceneCode { get; set; }

            /// <summary>
            /// <para>The scene name of the disposal task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf_whole_process</para>
            /// </summary>
            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID for the disposal.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123xxxxx234</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The submission source of the disposal task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The unique identifier of the disposal task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>150xxxxxxxxx95066</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The status of the disposal task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <para>The trigger source of the disposal task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>system</b>: Triggered by manual event disposal.</description></item>
            /// <item><description><b>custom</b>: Triggered by an automatic response rule based on an event.</description></item>
            /// <item><description><b>custom_alert</b>: Triggered by an automatic response rule based on an alert.</description></item>
            /// <item><description><b>soar-manual</b>: Triggered by manually invoking a SOAR playbook.</description></item>
            /// <item><description><b>soar-mdr</b>: Triggered by the Managed Security Service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

            /// <summary>
            /// <para>The code of the cloud product associated with the disposal task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WAF</para>
            /// </summary>
            [NameInMap("YunCode")]
            [Validation(Required=false)]
            public string YunCode { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7698CFB-4E1C-5840-8EC9-691B86729E94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
