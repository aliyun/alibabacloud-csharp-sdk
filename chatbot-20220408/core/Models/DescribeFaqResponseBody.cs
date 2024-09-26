// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeFaqResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>30000055617</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-11-30T03:03:37Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("EffectStatus")]
        [Validation(Required=false)]
        public int? EffectStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-04-27T06:08:54Z</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30001979424</para>
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-12-02T06:35:50Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        [NameInMap("Outlines")]
        [Validation(Required=false)]
        public List<DescribeFaqResponseBodyOutlines> Outlines { get; set; }
        public class DescribeFaqResponseBodyOutlines : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1000098002</para>
            /// </summary>
            [NameInMap("ConnQuestionId")]
            [Validation(Required=false)]
            public long? ConnQuestionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-26T10:24:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-26T18:12:02Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>797</para>
            /// </summary>
            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8AD9FA10-7780-5E12-B701-13C928524F32</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SimQuestions")]
        [Validation(Required=false)]
        public List<DescribeFaqResponseBodySimQuestions> SimQuestions { get; set; }
        public class DescribeFaqResponseBodySimQuestions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-26T10:24:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-29T03:55:07Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000000581</para>
            /// </summary>
            [NameInMap("SimQuestionId")]
            [Validation(Required=false)]
            public long? SimQuestionId { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public List<DescribeFaqResponseBodySolutions> Solutions { get; set; }
        public class DescribeFaqResponseBodySolutions : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public int? ContentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-26T10:24:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-29T07:07:13Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("PerspectiveCodes")]
            [Validation(Required=false)]
            public List<string> PerspectiveCodes { get; set; }

            [NameInMap("PlainText")]
            [Validation(Required=false)]
            public string PlainText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000003071</para>
            /// </summary>
            [NameInMap("SolutionId")]
            [Validation(Required=false)]
            public long? SolutionId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-04-27T07:04:39Z</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
