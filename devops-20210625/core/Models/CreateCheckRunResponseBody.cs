// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateCheckRunResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SYSTEM_UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateCheckRunResponseBodyResult Result { get; set; }
        public class CreateCheckRunResponseBodyResult : TeaModel {
            [NameInMap("annotations")]
            [Validation(Required=false)]
            public List<CreateCheckRunResponseBodyResultAnnotations> Annotations { get; set; }
            public class CreateCheckRunResponseBodyResultAnnotations : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>notice</para>
                /// </summary>
                [NameInMap("annotationLevel")]
                [Validation(Required=false)]
                public string AnnotationLevel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("endColumn")]
                [Validation(Required=false)]
                public long? EndColumn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("endLine")]
                [Validation(Required=false)]
                public long? EndLine { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo/test.txt</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("rawDetails")]
                [Validation(Required=false)]
                public string RawDetails { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("startColumn")]
                [Validation(Required=false)]
                public long? StartColumn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("startLine")]
                [Validation(Required=false)]
                public long? StartLine { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("checkSuite")]
            [Validation(Required=false)]
            public CreateCheckRunResponseBodyResultCheckSuite CheckSuite { get; set; }
            public class CreateCheckRunResponseBodyResultCheckSuite : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-15T08:00:00Z</para>
            /// </summary>
            [NameInMap("completedAt")]
            [Validation(Required=false)]
            public string CompletedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("conclusion")]
            [Validation(Required=false)]
            public string Conclusion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-14T21:08:26+08:00</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("detailsUrl")]
            [Validation(Required=false)]
            public string DetailsUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("externalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40f4ccfe019cdd4a62d4acb0c57130106fc7e1be</para>
            /// </summary>
            [NameInMap("headSha")]
            [Validation(Required=false)]
            public string HeadSha { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>524836</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-check-ci</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("output")]
            [Validation(Required=false)]
            public CreateCheckRunResponseBodyResultOutput Output { get; set; }
            public class CreateCheckRunResponseBodyResultOutput : TeaModel {
                [NameInMap("images")]
                [Validation(Required=false)]
                public List<CreateCheckRunResponseBodyResultOutputImages> Images { get; set; }
                public class CreateCheckRunResponseBodyResultOutputImages : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-image-alt</para>
                    /// </summary>
                    [NameInMap("alt")]
                    [Validation(Required=false)]
                    public string Alt { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("caption")]
                    [Validation(Required=false)]
                    public string Caption { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("imageUrl")]
                    [Validation(Required=false)]
                    public string ImageUrl { get; set; }

                }

                [NameInMap("summary")]
                [Validation(Required=false)]
                public string Summary { get; set; }

                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Mighty Readme report</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-15T08:00:00Z</para>
            /// </summary>
            [NameInMap("startedAt")]
            [Validation(Required=false)]
            public string StartedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-14T21:08:26+08:00</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("writer")]
            [Validation(Required=false)]
            public CreateCheckRunResponseBodyResultWriter Writer { get; set; }
            public class CreateCheckRunResponseBodyResultWriter : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("logoUrl")]
                [Validation(Required=false)]
                public string LogoUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-codeup</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-codeup</para>
                /// </summary>
                [NameInMap("slug")]
                [Validation(Required=false)]
                public string Slug { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>User</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
