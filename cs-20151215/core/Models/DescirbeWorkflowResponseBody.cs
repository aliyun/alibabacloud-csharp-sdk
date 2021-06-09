// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescirbeWorkflowResponseBody : TeaModel {
        /// <summary>
        /// 工作流创建时间。
        /// </summary>
        [NameInMap("create_time")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 工作流经过时长。
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// 任务结束时间。
        /// </summary>
        [NameInMap("finish_time")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// 输入数据大小。
        /// </summary>
        [NameInMap("input_data_size")]
        [Validation(Required=false)]
        public string InputDataSize { get; set; }

        /// <summary>
        /// 工作流名称。
        /// </summary>
        [NameInMap("job_name")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// 工作流所在命名空间。
        /// </summary>
        [NameInMap("job_namespace")]
        [Validation(Required=false)]
        public string JobNamespace { get; set; }

        /// <summary>
        /// 输出数据大小。
        /// </summary>
        [NameInMap("output_data_size")]
        [Validation(Required=false)]
        public string OutputDataSize { get; set; }

        /// <summary>
        /// 工作流当前状态。
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 碱基对个数。
        /// </summary>
        [NameInMap("total_bases")]
        [Validation(Required=false)]
        public string TotalBases { get; set; }

        /// <summary>
        /// Reads个数。
        /// </summary>
        [NameInMap("total_reads")]
        [Validation(Required=false)]
        public string TotalReads { get; set; }

        /// <summary>
        /// 用户输入参数。
        /// </summary>
        [NameInMap("user_input_data")]
        [Validation(Required=false)]
        public string UserInputData { get; set; }

    }

}
