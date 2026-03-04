// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaConvertOutputGroupDetail : TeaModel {
        /// <summary>
        /// <para>The error code for the failed output group task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InvalidParameter.ResourceContentBad</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The time the task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-21T01:48:41Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The end time of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-21T01:48:41Z</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The reason for a task failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The resource operated &quot;InputFile&quot; is bad</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The name of the output group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hls-group</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The output details.</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<MediaConvertOutputDetail> Outputs { get; set; }

        /// <summary>
        /// <para>The status of the output group task.</para>
        /// <list type="bullet">
        /// <item><description>Init: The task is submitted.</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Success</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>Skipped</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the output group task.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>22dad741d086a50325f9</b></b></b></para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
