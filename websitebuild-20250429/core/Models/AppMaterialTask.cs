// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class AppMaterialTask : TeaModel {
        /// <summary>
        /// <para>The task completion time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-26 11:30:05</para>
        /// </summary>
        [NameInMap("CompleteTime")]
        [Validation(Required=false)]
        public string CompleteTime { get; set; }

        /// <summary>
        /// <para>The display format of the completion time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1分钟前</para>
        /// </summary>
        [NameInMap("CompleteTimeFormat")]
        [Validation(Required=false)]
        public string CompleteTimeFormat { get; set; }

        /// <summary>
        /// <para>The failure reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>参数不合规</para>
        /// </summary>
        [NameInMap("FailReason")]
        [Validation(Required=false)]
        public string FailReason { get; set; }

        /// <summary>
        /// <para>The list of final files.</para>
        /// </summary>
        [NameInMap("FinalFileUrls")]
        [Validation(Required=false)]
        public List<string> FinalFileUrls { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task substatus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PENDING</para>
        /// </summary>
        [NameInMap("SubStatus")]
        [Validation(Required=false)]
        public string SubStatus { get; set; }

        /// <summary>
        /// <para>The submit time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-12-26 11:30:05</para>
        /// </summary>
        [NameInMap("SubmitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81d04d62c3483b32bacf1d306d2622b2</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;brandName&quot;: &quot;品牌名称&quot;,
        ///     &quot;direction&quot;: &quot;HORIZONTAL&quot;,
        ///     &quot;userPrompt&quot;: &quot;设计要求&quot;
        /// }</para>
        /// </summary>
        [NameInMap("TaskParam")]
        [Validation(Required=false)]
        public string TaskParam { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE_LOGO</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
