// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class SearchDocResponseBody : TeaModel {
        [NameInMap("DocHits")]
        [Validation(Required=false)]
        public List<SearchDocResponseBodyDocHits> DocHits { get; set; }
        public class SearchDocResponseBodyDocHits : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn_dytns</para>
            /// </summary>
            [NameInMap("BizCode")]
            [Validation(Required=false)]
            public string BizCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30000135654</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public long? CategoryId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;Splitter&quot;:&quot;treeSplitter&quot;,&quot;ChunkSize&quot;:500,&quot;TreePatterns&quot;:[&quot;^# .<em>&quot;,&quot;^## .</em>&quot;,&quot;^### .<em>&quot;,&quot;^#### .</em>&quot;],&quot;TitleSource&quot;:&quot;docName&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-22T03:53:41Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111111111</para>
            /// </summary>
            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public long? CreateUserId { get; set; }

            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            [NameInMap("DocName")]
            [Validation(Required=false)]
            public string DocName { get; set; }

            [NameInMap("DocTags")]
            [Validation(Required=false)]
            public List<SearchDocResponseBodyDocHitsDocTags> DocTags { get; set; }
            public class SearchDocResponseBodyDocHitsDocTags : TeaModel {
                [NameInMap("DefaultTag")]
                [Validation(Required=false)]
                public bool? DefaultTag { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public long? GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("TagId")]
                [Validation(Required=false)]
                public long? TagId { get; set; }

                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("EffectStatus")]
            [Validation(Required=false)]
            public int? EffectStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2099-12-31T16:00:00Z</para>
            /// </summary>
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30002692007</para>
            /// </summary>
            [NameInMap("KnowledgeId")]
            [Validation(Required=false)]
            public long? KnowledgeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;code&quot;:&quot;xxx&quot;}</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public string Meta { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-06-25T02:27:42Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>222222222</para>
            /// </summary>
            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public long? ModifyUserId { get; set; }

            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ProcessCanRetry")]
            [Validation(Required=false)]
            public bool? ProcessCanRetry { get; set; }

            [NameInMap("ProcessMessage")]
            [Validation(Required=false)]
            public string ProcessMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ProcessStatus")]
            [Validation(Required=false)]
            public int? ProcessStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-02-28T11:40:18Z</para>
            /// </summary>
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E3E5C779-A630-45AC-B0F2-A4506A4212F1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>141</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
