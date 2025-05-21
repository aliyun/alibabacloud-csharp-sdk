// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ListTextbookAssistantBookDirectoriesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListTextbookAssistantBookDirectoriesResponseBodyData Data { get; set; }
        public class ListTextbookAssistantBookDirectoriesResponseBodyData : TeaModel {
            [NameInMap("directoryTree")]
            [Validation(Required=false)]
            public List<ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTree> DirectoryTree { get; set; }
            public class ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTree : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>05758807ed8e11eebe6e0c42a106bb02</para>
                /// </summary>
                [NameInMap("directoryId")]
                [Validation(Required=false)]
                public string DirectoryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2 Jobs</para>
                /// </summary>
                [NameInMap("directoryName")]
                [Validation(Required=false)]
                public string DirectoryName { get; set; }

                [NameInMap("topic")]
                [Validation(Required=false)]
                public List<ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeTopic> Topic { get; set; }
                public class ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeTopic : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1323</para>
                    /// </summary>
                    [NameInMap("labelId")]
                    [Validation(Required=false)]
                    public string LabelId { get; set; }

                    [NameInMap("labelName")]
                    [Validation(Required=false)]
                    public string LabelName { get; set; }

                }

                [NameInMap("unit")]
                [Validation(Required=false)]
                public List<ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnit> Unit { get; set; }
                public class ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnit : TeaModel {
                    [NameInMap("directoryId")]
                    [Validation(Required=false)]
                    public string DirectoryId { get; set; }

                    [NameInMap("directoryName")]
                    [Validation(Required=false)]
                    public string DirectoryName { get; set; }

                    [NameInMap("section")]
                    [Validation(Required=false)]
                    public List<ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnitSection> Section { get; set; }
                    public class ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnitSection : TeaModel {
                        [NameInMap("children")]
                        [Validation(Required=false)]
                        public object Children { get; set; }

                        [NameInMap("directoryId")]
                        [Validation(Required=false)]
                        public string DirectoryId { get; set; }

                        [NameInMap("directoryName")]
                        [Validation(Required=false)]
                        public string DirectoryName { get; set; }

                        [NameInMap("topic")]
                        [Validation(Required=false)]
                        public List<ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnitSectionTopic> Topic { get; set; }
                        public class ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnitSectionTopic : TeaModel {
                            [NameInMap("labelId")]
                            [Validation(Required=false)]
                            public string LabelId { get; set; }

                            [NameInMap("labelName")]
                            [Validation(Required=false)]
                            public string LabelName { get; set; }

                        }

                    }

                    [NameInMap("topic")]
                    [Validation(Required=false)]
                    public List<ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnitTopic> Topic { get; set; }
                    public class ListTextbookAssistantBookDirectoriesResponseBodyDataDirectoryTreeUnitTopic : TeaModel {
                        [NameInMap("labelId")]
                        [Validation(Required=false)]
                        public string LabelId { get; set; }

                        [NameInMap("labelName")]
                        [Validation(Required=false)]
                        public string LabelName { get; set; }

                    }

                }

            }

            [NameInMap("editionInfo")]
            [Validation(Required=false)]
            public ListTextbookAssistantBookDirectoriesResponseBodyDataEditionInfo EditionInfo { get; set; }
            public class ListTextbookAssistantBookDirectoriesResponseBodyDataEditionInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>55857</para>
                /// </summary>
                [NameInMap("bookId")]
                [Validation(Required=false)]
                public string BookId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("bookVolume")]
                [Validation(Required=false)]
                public string BookVolume { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2010-1(2)</para>
                /// </summary>
                [NameInMap("edition")]
                [Validation(Required=false)]
                public string Edition { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("grade")]
                [Validation(Required=false)]
                public string Grade { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-1(10)</para>
                /// </summary>
                [NameInMap("impression")]
                [Validation(Required=false)]
                public string Impression { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9787544413695</para>
                /// </summary>
                [NameInMap("isbn")]
                [Validation(Required=false)]
                public string Isbn { get; set; }

                [NameInMap("publisher")]
                [Validation(Required=false)]
                public string Publisher { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ENGLISH</para>
                /// </summary>
                [NameInMap("subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B_USER_NOT_FOUND_EXCEPTION</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0A5E9849-A2F0-551D-A7D8-1A8118557BAB</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
