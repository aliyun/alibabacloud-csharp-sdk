// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class RunEssayCorrectionShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("answer")]
        [Validation(Required=false)]
        public string Answer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;: &quot;内容完整度&quot;, &quot;rubric&quot;: &quot;文章内容是否完整，是否涵盖了题目的核心要求&quot;, &quot;maxScore&quot;: 30}]</para>
        /// </summary>
        [NameInMap("dimensions")]
        [Validation(Required=false)]
        public string DimensionsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>高一</para>
        /// </summary>
        [NameInMap("grade")]
        [Validation(Required=false)]
        public string Grade { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-custom-correction-v1</para>
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("otherReviewPoints")]
        [Validation(Required=false)]
        public string OtherReviewPoints { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>语文</para>
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("totalScore")]
        [Validation(Required=false)]
        public int? TotalScore { get; set; }

    }

}
