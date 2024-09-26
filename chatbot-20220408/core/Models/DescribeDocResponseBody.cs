// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribeDocResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>bizcode123</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30000049006</para>
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
        /// <para>2022-04-12T06:30:17Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1111111111</para>
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public long? CreateUserId { get; set; }

        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        [NameInMap("DocInfo")]
        [Validation(Required=false)]
        public DescribeDocResponseBodyDocInfo DocInfo { get; set; }
        public class DescribeDocResponseBodyDocInfo : TeaModel {
            [NameInMap("DocParas")]
            [Validation(Required=false)]
            public List<DescribeDocResponseBodyDocInfoDocParas> DocParas { get; set; }
            public class DescribeDocResponseBodyDocInfoDocParas : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParaLevel")]
                [Validation(Required=false)]
                public int? ParaLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParaNo")]
                [Validation(Required=false)]
                public int? ParaNo { get; set; }

                [NameInMap("ParaText")]
                [Validation(Required=false)]
                public string ParaText { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("ParaType")]
                [Validation(Required=false)]
                public string ParaType { get; set; }

            }

        }

        [NameInMap("DocMetadata")]
        [Validation(Required=false)]
        public List<DescribeDocResponseBodyDocMetadata> DocMetadata { get; set; }
        public class DescribeDocResponseBodyDocMetadata : TeaModel {
            [NameInMap("BusinessViewId")]
            [Validation(Required=false)]
            public string BusinessViewId { get; set; }

            [NameInMap("BusinessViewName")]
            [Validation(Required=false)]
            public string BusinessViewName { get; set; }

            [NameInMap("MetaCellInfoDTOList")]
            [Validation(Required=false)]
            public List<DescribeDocResponseBodyDocMetadataMetaCellInfoDTOList> MetaCellInfoDTOList { get; set; }
            public class DescribeDocResponseBodyDocMetadataMetaCellInfoDTOList : TeaModel {
                [NameInMap("FieldCode")]
                [Validation(Required=false)]
                public string FieldCode { get; set; }

                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("DocName")]
        [Validation(Required=false)]
        public string DocName { get; set; }

        [NameInMap("DocTags")]
        [Validation(Required=false)]
        public List<DescribeDocResponseBodyDocTags> DocTags { get; set; }
        public class DescribeDocResponseBodyDocTags : TeaModel {
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
        /// <para>{&quot;code&quot;:&quot;xxx&quot;}</para>
        /// </summary>
        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2020-11-25T08:56:55Z</para>
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2222222222</para>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>7F132693-212A-40A9-8A81-11E7694E478B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1979-12-31T16:00:00Z</para>
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

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
