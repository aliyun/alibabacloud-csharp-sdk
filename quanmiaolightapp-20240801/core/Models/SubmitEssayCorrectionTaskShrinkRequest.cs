// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class SubmitEssayCorrectionTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;: &quot;内容完整度&quot;, &quot;rubric&quot;: &quot;文章内容是否完整，是否涵盖了题目的核心要求&quot;, &quot;maxScore&quot;: 30}]</para>
        /// </summary>
        [NameInMap("dimensions")]
        [Validation(Required=false)]
        public string DimensionsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>高中二年级</para>
        /// </summary>
        [NameInMap("grade")]
        [Validation(Required=false)]
        public string Grade { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
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
        /// <para>xxx</para>
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
        /// <para>[{&quot;grade&quot;: &quot;高中二年级&quot;, &quot;subject&quot;: &quot;语文&quot;, &quot;totalScore&quot;: 60, &quot;question&quot;: &quot;请以我的梦想为主题写一篇作文&quot;, &quot;answer&quot;: &quot;我的梦想是成为一名科学家...&quot;, &quot;customId&quot;: &quot;task-001&quot;}]</para>
        /// </summary>
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public string TasksShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("totalScore")]
        [Validation(Required=false)]
        public int? TotalScore { get; set; }

    }

}
