// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ListMdsCubeTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public ListMdsCubeTemplatesResponseBodyResultContent ResultContent { get; set; }
        public class ListMdsCubeTemplatesResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListMdsCubeTemplatesResponseBodyResultContentData Data { get; set; }
            public class ListMdsCubeTemplatesResponseBodyResultContentData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public ListMdsCubeTemplatesResponseBodyResultContentDataContent Content { get; set; }
                public class ListMdsCubeTemplatesResponseBodyResultContentDataContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("FirstPage")]
                    [Validation(Required=false)]
                    public bool? FirstPage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FirstResult")]
                    [Validation(Required=false)]
                    public long? FirstResult { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("LastPage")]
                    [Validation(Required=false)]
                    public bool? LastPage { get; set; }

                    [NameInMap("List")]
                    [Validation(Required=false)]
                    public List<ListMdsCubeTemplatesResponseBodyResultContentDataContentList> List { get; set; }
                    public class ListMdsCubeTemplatesResponseBodyResultContentDataContentList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>570DA89281533-default</para>
                        /// </summary>
                        [NameInMap("AppCode")]
                        [Validation(Required=false)]
                        public string AppCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2025-10-24 11:24:34</para>
                        /// </summary>
                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2025-10-24 11:24:34</para>
                        /// </summary>
                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>template desc</para>
                        /// </summary>
                        [NameInMap("TemplateDesc")]
                        [Validation(Required=false)]
                        public string TemplateDesc { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>template_test</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>template_test</para>
                        /// </summary>
                        [NameInMap("TemplateName")]
                        [Validation(Required=false)]
                        public string TemplateName { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NextPage")]
                    [Validation(Required=false)]
                    public long? NextPage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PageNo")]
                    [Validation(Required=false)]
                    public int? PageNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PrePage")]
                    [Validation(Required=false)]
                    public long? PrePage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public int? TotalCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TotalPage")]
                    [Validation(Required=false)]
                    public long? TotalPage { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NONE</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
