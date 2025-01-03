// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateCheckRunRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f0b1e61db5961df5975a93f9129d2513</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("annotations")]
        [Validation(Required=false)]
        public List<CreateCheckRunRequestAnnotations> Annotations { get; set; }
        public class CreateCheckRunRequestAnnotations : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("endLine")]
            [Validation(Required=false)]
            public long? EndLine { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
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
            /// <para>This parameter is required.</para>
            /// 
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40f4ccfe019cdd4a62d4acb0c57130106fc7e1be</para>
        /// </summary>
        [NameInMap("headSha")]
        [Validation(Required=false)]
        public string HeadSha { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-check-ci</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("output")]
        [Validation(Required=false)]
        public CreateCheckRunRequestOutput Output { get; set; }
        public class CreateCheckRunRequestOutput : TeaModel {
            [NameInMap("images")]
            [Validation(Required=false)]
            public List<CreateCheckRunRequestOutputImages> Images { get; set; }
            public class CreateCheckRunRequestOutputImages : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
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
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("imageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            [NameInMap("text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ebbc0228123212b59xxxxx</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("repositoryIdentity")]
        [Validation(Required=false)]
        public string RepositoryIdentity { get; set; }

    }

}
