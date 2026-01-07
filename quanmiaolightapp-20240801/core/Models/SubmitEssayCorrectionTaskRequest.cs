// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QuanMiaoLightApp20240801.Models
{
    public class SubmitEssayCorrectionTaskRequest : TeaModel {
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

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<SubmitEssayCorrectionTaskRequestTasks> Tasks { get; set; }
        public class SubmitEssayCorrectionTaskRequestTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            [NameInMap("customId")]
            [Validation(Required=false)]
            public string CustomId { get; set; }

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
            /// <para>60</para>
            /// </summary>
            [NameInMap("totalScore")]
            [Validation(Required=false)]
            public int? TotalScore { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("totalScore")]
        [Validation(Required=false)]
        public int? TotalScore { get; set; }

    }

}
