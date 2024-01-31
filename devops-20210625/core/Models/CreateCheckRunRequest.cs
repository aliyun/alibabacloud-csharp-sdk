// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateCheckRunRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("annotations")]
        [Validation(Required=false)]
        public List<CreateCheckRunRequestAnnotations> Annotations { get; set; }
        public class CreateCheckRunRequestAnnotations : TeaModel {
            [NameInMap("annotationLevel")]
            [Validation(Required=false)]
            public string AnnotationLevel { get; set; }

            [NameInMap("endColumn")]
            [Validation(Required=false)]
            public long? EndColumn { get; set; }

            [NameInMap("endLine")]
            [Validation(Required=false)]
            public long? EndLine { get; set; }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("rawDetails")]
            [Validation(Required=false)]
            public string RawDetails { get; set; }

            [NameInMap("startColumn")]
            [Validation(Required=false)]
            public long? StartColumn { get; set; }

            [NameInMap("startLine")]
            [Validation(Required=false)]
            public long? StartLine { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public string CompletedAt { get; set; }

        [NameInMap("conclusion")]
        [Validation(Required=false)]
        public string Conclusion { get; set; }

        [NameInMap("detailsUrl")]
        [Validation(Required=false)]
        public string DetailsUrl { get; set; }

        [NameInMap("externalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        [NameInMap("headSha")]
        [Validation(Required=false)]
        public string HeadSha { get; set; }

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
                [NameInMap("alt")]
                [Validation(Required=false)]
                public string Alt { get; set; }

                [NameInMap("caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

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

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("repositoryIdentity")]
        [Validation(Required=false)]
        public string RepositoryIdentity { get; set; }

    }

}
