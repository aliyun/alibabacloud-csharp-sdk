// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateCheckRunResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateCheckRunResponseBodyResult Result { get; set; }
        public class UpdateCheckRunResponseBodyResult : TeaModel {
            [NameInMap("annotations")]
            [Validation(Required=false)]
            public List<UpdateCheckRunResponseBodyResultAnnotations> Annotations { get; set; }
            public class UpdateCheckRunResponseBodyResultAnnotations : TeaModel {
                [NameInMap("annotationLevel")]
                [Validation(Required=false)]
                public string AnnotationLevel { get; set; }

                [NameInMap("endColumn")]
                [Validation(Required=false)]
                public long? EndColumn { get; set; }

                [NameInMap("endLine")]
                [Validation(Required=false)]
                public long? EndLine { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

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

            [NameInMap("checkSuite")]
            [Validation(Required=false)]
            public UpdateCheckRunResponseBodyResultCheckSuite CheckSuite { get; set; }
            public class UpdateCheckRunResponseBodyResultCheckSuite : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

            [NameInMap("completedAt")]
            [Validation(Required=false)]
            public string CompletedAt { get; set; }

            [NameInMap("conclusion")]
            [Validation(Required=false)]
            public string Conclusion { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            [NameInMap("detailsUrl")]
            [Validation(Required=false)]
            public string DetailsUrl { get; set; }

            [NameInMap("externalId")]
            [Validation(Required=false)]
            public string ExternalId { get; set; }

            [NameInMap("headSha")]
            [Validation(Required=false)]
            public string HeadSha { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("output")]
            [Validation(Required=false)]
            public UpdateCheckRunResponseBodyResultOutput Output { get; set; }
            public class UpdateCheckRunResponseBodyResultOutput : TeaModel {
                [NameInMap("images")]
                [Validation(Required=false)]
                public List<UpdateCheckRunResponseBodyResultOutputImages> Images { get; set; }
                public class UpdateCheckRunResponseBodyResultOutputImages : TeaModel {
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

            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            [NameInMap("writer")]
            [Validation(Required=false)]
            public UpdateCheckRunResponseBodyResultWriter Writer { get; set; }
            public class UpdateCheckRunResponseBodyResultWriter : TeaModel {
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("logoUrl")]
                [Validation(Required=false)]
                public string LogoUrl { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("slug")]
                [Validation(Required=false)]
                public string Slug { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
