// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitAsyncTaskRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the workspace. For more information, see <a href="https://help.aliyun.com/document_detail/2587494.html">AgentKey</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2daaa2e0c209xb26acb97009ea77bd4b_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>For details on the task definition, see the task definition table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaterialDocumentUpload</para>
        /// </summary>
        [NameInMap("TaskCode")]
        [Validation(Required=false)]
        public string TaskCode { get; set; }

        /// <summary>
        /// <para>The time to run the task. By default, the task runs immediately. Format: YYYY-MM-DD HH:mm:ss</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-14 14:30:00</para>
        /// </summary>
        [NameInMap("TaskExecuteTime")]
        [Validation(Required=false)]
        public string TaskExecuteTime { get; set; }

        /// <summary>
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>任务名称</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The task parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fileUrl&quot;:&quot;<a href="https://www.example.com/aaa.doc%22,%22fileName%22:%22%E6%96%87%E4%BB%B6%E5%90%8D%E7%A7%B0%22,%22shareAttr%22:1%7D">https://www.example.com/aaa.doc&quot;,&quot;fileName&quot;:&quot;文件名称&quot;,&quot;shareAttr&quot;:1}</a></para>
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

    }

}
