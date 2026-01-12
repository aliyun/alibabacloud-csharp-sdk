// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20221111.Models
{
    public class ListProjectsByDependencyIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListProjectsByDependencyIdResponseBodyData> Data { get; set; }
        public class ListProjectsByDependencyIdResponseBodyData : TeaModel {
            [NameInMap("BizUsage")]
            [Validation(Required=false)]
            public string BizUsage { get; set; }

            [NameInMap("BuildDetail")]
            [Validation(Required=false)]
            public ListProjectsByDependencyIdResponseBodyDataBuildDetail BuildDetail { get; set; }
            public class ListProjectsByDependencyIdResponseBodyDataBuildDetail : TeaModel {
                [NameInMap("CompletedTime")]
                [Validation(Required=false)]
                public string CompletedTime { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("EstimatedDuration")]
                [Validation(Required=false)]
                public long? EstimatedDuration { get; set; }

                [NameInMap("RunningTime")]
                [Validation(Required=false)]
                public string RunningTime { get; set; }

                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Dataset")]
            [Validation(Required=false)]
            public ListProjectsByDependencyIdResponseBodyDataDataset Dataset { get; set; }
            public class ListProjectsByDependencyIdResponseBodyDataDataset : TeaModel {
                [NameInMap("BuildResultUrl")]
                [Validation(Required=false)]
                public Dictionary<string, object> BuildResultUrl { get; set; }

                [NameInMap("CoverUrl")]
                [Validation(Required=false)]
                public string CoverUrl { get; set; }

                [NameInMap("GlbModelUrl")]
                [Validation(Required=false)]
                public string GlbModelUrl { get; set; }

                [NameInMap("ModelUrl")]
                [Validation(Required=false)]
                public string ModelUrl { get; set; }

                [NameInMap("OriginResultUrl")]
                [Validation(Required=false)]
                public string OriginResultUrl { get; set; }

                [NameInMap("OssKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }

                [NameInMap("PoseUrl")]
                [Validation(Required=false)]
                public string PoseUrl { get; set; }

                [NameInMap("PreviewUrl")]
                [Validation(Required=false)]
                public string PreviewUrl { get; set; }

            }

            [NameInMap("Ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Intro")]
            [Validation(Required=false)]
            public string Intro { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public ListProjectsByDependencyIdResponseBodyDataSource Source { get; set; }
            public class ListProjectsByDependencyIdResponseBodyDataSource : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("OssKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                [NameInMap("SourceFiles")]
                [Validation(Required=false)]
                public List<ListProjectsByDependencyIdResponseBodyDataSourceSourceFiles> SourceFiles { get; set; }
                public class ListProjectsByDependencyIdResponseBodyDataSourceSourceFiles : TeaModel {
                    [NameInMap("CoverUrl")]
                    [Validation(Required=false)]
                    public string CoverUrl { get; set; }

                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ErrorName")]
        [Validation(Required=false)]
        public string ErrorName { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
