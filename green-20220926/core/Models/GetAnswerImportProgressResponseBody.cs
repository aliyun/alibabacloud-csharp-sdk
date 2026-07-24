// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetAnswerImportProgressResponseBody : TeaModel {
        /// <summary>
        /// <para>The internationalization key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("I18nKey")]
        [Validation(Required=false)]
        public string I18nKey { get; set; }

        /// <summary>
        /// <para>The list of invalid proxy answers.</para>
        /// </summary>
        [NameInMap("IllegalLengthSamples")]
        [Validation(Required=false)]
        public List<string> IllegalLengthSamples { get; set; }

        /// <summary>
        /// <para>The number of invalid entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InvalidCount")]
        [Validation(Required=false)]
        public int? InvalidCount { get; set; }

        /// <summary>
        /// <para>The proxy answer library ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alxxxx</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <para>The task progress percentage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <para>The number of duplicate entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RepeatCount")]
        [Validation(Required=false)]
        public int? RepeatCount { get; set; }

        /// <summary>
        /// <para>The list of duplicate proxy answers.</para>
        /// </summary>
        [NameInMap("RepeatSamples")]
        [Validation(Required=false)]
        public List<string> RepeatSamples { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of successful imports.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alAxbbxxxx-xxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The prompt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("Tips")]
        [Validation(Required=false)]
        public string Tips { get; set; }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
