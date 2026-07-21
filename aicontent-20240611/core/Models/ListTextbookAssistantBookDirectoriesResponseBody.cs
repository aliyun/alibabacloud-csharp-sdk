// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantBookDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListTextbookAssistantBookDirectoriesResponseBodyData Data { get; set; }
        public class ListTextbookAssistantBookDirectoriesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The directory tree.</para>
            /// </summary>
            [NameInMap("directoryTree")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTree> DirectoryTree { get; set; }
            public class ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTree : TeaModel {
                /// <summary>
                /// <para>The directory ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>05758807ed8e11eebe6e0c42a106bb02</para>
                /// </summary>
                [NameInMap("directoryId")]
                [Validation(Required=false)]
                public string DirectoryId { get; set; }

                /// <summary>
                /// <para>The directory name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2 Jobs</para>
                /// </summary>
                [NameInMap("directoryName")]
                [Validation(Required=false)]
                public string DirectoryName { get; set; }

                /// <summary>
                /// <para>The topic.</para>
                /// </summary>
                [NameInMap("topic")]
                [Validation(Required=false)]
                public List<ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeTopic> Topic { get; set; }
                public class ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeTopic : TeaModel {
                    /// <summary>
                    /// <para>The label ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1323</para>
                    /// </summary>
                    [NameInMap("labelId")]
                    [Validation(Required=false)]
                    public string LabelId { get; set; }

                    /// <summary>
                    /// <para>The label name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>身边事物环境</para>
                    /// </summary>
                    [NameInMap("labelName")]
                    [Validation(Required=false)]
                    public string LabelName { get; set; }

                }

                /// <summary>
                /// <para>The unit.</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public List<ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnit> Unit { get; set; }
                public class ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnit : TeaModel {
                    /// <summary>
                    /// <para>The directory ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>05758807ed8e11eebe6e0c42a106bb02</para>
                    /// </summary>
                    [NameInMap("directoryId")]
                    [Validation(Required=false)]
                    public string DirectoryId { get; set; }

                    /// <summary>
                    /// <para>The directory name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>unit 2</para>
                    /// </summary>
                    [NameInMap("directoryName")]
                    [Validation(Required=false)]
                    public string DirectoryName { get; set; }

                    /// <summary>
                    /// <para>The section.</para>
                    /// </summary>
                    [NameInMap("section")]
                    [Validation(Required=false)]
                    public List<ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnitSection> Section { get; set; }
                    public class ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnitSection : TeaModel {
                        /// <summary>
                        /// <para>Child nodes for backward compatibility. This property is optional.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>可能存在的子元素，兼容数据使用，不一定存在</para>
                        /// </summary>
                        [NameInMap("children")]
                        [Validation(Required=false)]
                        public object Children { get; set; }

                        /// <summary>
                        /// <para>The directory ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>05758807ed8e11eebe6e0c42a106bb02</para>
                        /// </summary>
                        [NameInMap("directoryId")]
                        [Validation(Required=false)]
                        public string DirectoryId { get; set; }

                        /// <summary>
                        /// <para>The directory name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>section 2</para>
                        /// </summary>
                        [NameInMap("directoryName")]
                        [Validation(Required=false)]
                        public string DirectoryName { get; set; }

                        /// <summary>
                        /// <para>The topic.</para>
                        /// </summary>
                        [NameInMap("topic")]
                        [Validation(Required=false)]
                        public List<ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnitSectionTopic> Topic { get; set; }
                        public class ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnitSectionTopic : TeaModel {
                            /// <summary>
                            /// <para>The label ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1329</para>
                            /// </summary>
                            [NameInMap("labelId")]
                            [Validation(Required=false)]
                            public string LabelId { get; set; }

                            /// <summary>
                            /// <para>The label name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>自我介绍</para>
                            /// </summary>
                            [NameInMap("labelName")]
                            [Validation(Required=false)]
                            public string LabelName { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The topic.</para>
                    /// </summary>
                    [NameInMap("topic")]
                    [Validation(Required=false)]
                    public List<ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnitTopic> Topic { get; set; }
                    public class ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnitTopic : TeaModel {
                        /// <summary>
                        /// <para>The label ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1326</para>
                        /// </summary>
                        [NameInMap("labelId")]
                        [Validation(Required=false)]
                        public string LabelId { get; set; }

                        /// <summary>
                        /// <para>The label name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>自我介绍</para>
                        /// </summary>
                        [NameInMap("labelName")]
                        [Validation(Required=false)]
                        public string LabelName { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The edition details.</para>
            /// </summary>
            [NameInMap("editionInfo")]
            [Validation(Required=false)]
            public ListTextbookAssistantBookDirectoriesResponseBodyDataEditionInfo EditionInfo { get; set; }
            public class ListTextbookAssistantBookDirectoriesResponseBodyDataEditionInfo : TeaModel {
                /// <summary>
                /// <para>The book ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>55857</para>
                /// </summary>
                [NameInMap("bookId")]
                [Validation(Required=false)]
                public string BookId { get; set; }

                /// <summary>
                /// <para>The book volume. <c>0</c> indicates a single-volume edition, <c>1</c> indicates Volume 1, and <c>2</c> indicates Volume 2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("bookVolume")]
                [Validation(Required=false)]
                public string BookVolume { get; set; }

                /// <summary>
                /// <para>The edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2010-1(2)</para>
                /// </summary>
                [NameInMap("edition")]
                [Validation(Required=false)]
                public string Edition { get; set; }

                /// <summary>
                /// <para>The grade. Valid values: 1–9.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("grade")]
                [Validation(Required=false)]
                public string Grade { get; set; }

                /// <summary>
                /// <para>The impression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-1(10)</para>
                /// </summary>
                [NameInMap("impression")]
                [Validation(Required=false)]
                public string Impression { get; set; }

                /// <summary>
                /// <para>The International Standard Book Number (ISBN).</para>
                /// 
                /// <b>Example:</b>
                /// <para>9787544413695</para>
                /// </summary>
                [NameInMap("isbn")]
                [Validation(Required=false)]
                public string Isbn { get; set; }

                /// <summary>
                /// <para>The publisher.</para>
                /// 
                /// <b>Example:</b>
                /// <para>人民教育出版社</para>
                /// </summary>
                [NameInMap("publisher")]
                [Validation(Required=false)]
                public string Publisher { get; set; }

                /// <summary>
                /// <para>The subject.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENGLISH</para>
                /// </summary>
                [NameInMap("subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

                /// <summary>
                /// <para>The version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>人教版</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B_USER_NOT_FOUND_EXCEPTION</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用户不存在</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A5E9849-A2F0-551D-A7D8-1A8118557BAB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
