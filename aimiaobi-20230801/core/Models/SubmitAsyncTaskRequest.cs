// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class SubmitAsyncTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2daaa2e0c209xb26acb97009ea77bd4b_p_efm</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaterialDocumentUpload</para>
        /// </summary>
        [NameInMap("TaskCode")]
        [Validation(Required=false)]
        public string TaskCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-10-14 14:30:00</para>
        /// </summary>
        [NameInMap("TaskExecuteTime")]
        [Validation(Required=false)]
        public string TaskExecuteTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>任务名称</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>任务提交参数</para>
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

    }

}
