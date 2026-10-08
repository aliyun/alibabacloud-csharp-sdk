// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetDecodeBlindWatermarkResultRequest : TeaModel {
        /// <summary>
        /// <para>The project name. For information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The task ID. You can obtain the task ID from the response parameters of the blind watermark extraction task creation operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DecodeBlindWatermark-c09b0943-ed79-4983-8dbe-7a882574****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DecodeBlindWatermark</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
