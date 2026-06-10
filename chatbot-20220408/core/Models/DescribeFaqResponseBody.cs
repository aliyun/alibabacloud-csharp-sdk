// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeFaqResponseBody : TeaModel {
        /// <summary>
        /// <para>The category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30000055617</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// <para>The time the knowledge was created, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-11-30T03:03:37Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The creator of the knowledge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// <para>The validity status of the knowledge, calculated based on <c>StartDate</c> and <c>EndDate</c>. Valid values: <c>20</c> (Active), <c>21</c> (Expired), and <c>22</c> (Pending).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("EffectStatus")]
        [Validation(Required=false)]
        public int? EffectStatus { get; set; }

        /// <summary>
        /// <para>The expiration time of the knowledge, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-04-27T06:08:54Z</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The knowledge ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001979424</para>
        /// </summary>
        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public long? KnowledgeId { get; set; }

        /// <summary>
        /// <para>The time the knowledge was last modified, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-02T06:35:50Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <para>The user who last modified the knowledge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        /// <summary>
        /// <para>A list of related questions.</para>
        /// </summary>
        [NameInMap("Outlines")]
        [Validation(Required=false)]
        public List<DescribeFaqResponseBodyOutlines> Outlines { get; set; }
        public class DescribeFaqResponseBodyOutlines : TeaModel {
            /// <summary>
            /// <para>The related knowledge ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000098002</para>
            /// </summary>
            [NameInMap("ConnQuestionId")]
            [Validation(Required=false)]
            public long? ConnQuestionId { get; set; }

            /// <summary>
            /// <para>The time the related question was created, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-26T10:24:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time the related question was last modified, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-26T18:12:02Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The relationship ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>797</para>
            /// </summary>
            [NameInMap("OutlineId")]
            [Validation(Required=false)]
            public long? OutlineId { get; set; }

            /// <summary>
            /// <para>The related knowledge title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试关联问标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8AD9FA10-7780-5E12-B701-13C928524F32</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of similar questions.</para>
        /// </summary>
        [NameInMap("SimQuestions")]
        [Validation(Required=false)]
        public List<DescribeFaqResponseBodySimQuestions> SimQuestions { get; set; }
        public class DescribeFaqResponseBodySimQuestions : TeaModel {
            /// <summary>
            /// <para>The time the similar question was created, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-26T10:24:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time the similar question was last modified, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-29T03:55:07Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The similar question ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000000581</para>
            /// </summary>
            [NameInMap("SimQuestionId")]
            [Validation(Required=false)]
            public long? SimQuestionId { get; set; }

            /// <summary>
            /// <para>The similar question title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试相似问标题</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>A list of solutions.</para>
        /// </summary>
        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public List<DescribeFaqResponseBodySolutions> Solutions { get; set; }
        public class DescribeFaqResponseBodySolutions : TeaModel {
            /// <summary>
            /// <para>The solution content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试答案内容</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The solution content type. Valid values: <c>0</c> (plain text) and <c>1</c> (rich text).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public int? ContentType { get; set; }

            /// <summary>
            /// <para>The time the solution was created, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-26T10:24:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time the solution was last modified, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-29T07:07:13Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>A list of perspective codes.</para>
            /// </summary>
            [NameInMap("PerspectiveCodes")]
            [Validation(Required=false)]
            public List<string> PerspectiveCodes { get; set; }

            /// <summary>
            /// <para>The plain text content of the solution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试答案内容</para>
            /// </summary>
            [NameInMap("PlainText")]
            [Validation(Required=false)]
            public string PlainText { get; set; }

            /// <summary>
            /// <para>The solution ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000003071</para>
            /// </summary>
            [NameInMap("SolutionId")]
            [Validation(Required=false)]
            public long? SolutionId { get; set; }

            /// <summary>
            /// <para>A list of tag IDs.</para>
            /// </summary>
            [NameInMap("TagIdList")]
            [Validation(Required=false)]
            public List<long?> TagIdList { get; set; }

        }

        /// <summary>
        /// <para>The effective start time of the knowledge, in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-04-27T07:04:39Z</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The knowledge status. Valid values: <c>-1</c> (Deleted and unpublished), <c>1</c> (Unpublished), <c>2</c> (Published), and <c>3</c> (Updated and unpublished).</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>A list of tag IDs associated with the knowledge.</para>
        /// </summary>
        [NameInMap("TagIdList")]
        [Validation(Required=false)]
        public List<long?> TagIdList { get; set; }

        /// <summary>
        /// <para>The knowledge title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
