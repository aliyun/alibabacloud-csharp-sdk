// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20221111.Models
{
    public class QueryProjectDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryProjectDetailResponseBodyData Data { get; set; }
        public class QueryProjectDetailResponseBodyData : TeaModel {
            [NameInMap("BizUsage")]
            [Validation(Required=false)]
            public string BizUsage { get; set; }

            [NameInMap("BuildDetail")]
            [Validation(Required=false)]
            public QueryProjectDetailResponseBodyDataBuildDetail BuildDetail { get; set; }
            public class QueryProjectDetailResponseBodyDataBuildDetail : TeaModel {
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

            [NameInMap("CreateMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Dataset")]
            [Validation(Required=false)]
            public QueryProjectDetailResponseBodyDataDataset Dataset { get; set; }
            public class QueryProjectDetailResponseBodyDataDataset : TeaModel {
                [NameInMap("BuildResultUrl")]
                [Validation(Required=false)]
                public Dictionary<string, object> BuildResultUrl { get; set; }

                [NameInMap("CoverUrl")]
                [Validation(Required=false)]
                public string CoverUrl { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("GlbModelUrl")]
                [Validation(Required=false)]
                public string GlbModelUrl { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ModelUrl")]
                [Validation(Required=false)]
                public string ModelUrl { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("OriginResultUrl")]
                [Validation(Required=false)]
                public string OriginResultUrl { get; set; }

                [NameInMap("OssKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public QueryProjectDetailResponseBodyDataDatasetPolicy Policy { get; set; }
                public class QueryProjectDetailResponseBodyDataDatasetPolicy : TeaModel {
                    [NameInMap("AccessId")]
                    [Validation(Required=false)]
                    public string AccessId { get; set; }

                    [NameInMap("Dir")]
                    [Validation(Required=false)]
                    public string Dir { get; set; }

                    [NameInMap("Expire")]
                    [Validation(Required=false)]
                    public string Expire { get; set; }

                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    [NameInMap("Signature")]
                    [Validation(Required=false)]
                    public string Signature { get; set; }

                }

                [NameInMap("PoseUrl")]
                [Validation(Required=false)]
                public string PoseUrl { get; set; }

                [NameInMap("PreviewUrl")]
                [Validation(Required=false)]
                public string PreviewUrl { get; set; }

            }

            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("Dependencies")]
            [Validation(Required=false)]
            public string Dependencies { get; set; }

            [NameInMap("Ext")]
            [Validation(Required=false)]
            public string Ext { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Intro")]
            [Validation(Required=false)]
            public string Intro { get; set; }

            [NameInMap("MaterialCoverUrl")]
            [Validation(Required=false)]
            public string MaterialCoverUrl { get; set; }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public QueryProjectDetailResponseBodyDataSource Source { get; set; }
            public class QueryProjectDetailResponseBodyDataSource : TeaModel {
                [NameInMap("Clothes")]
                [Validation(Required=false)]
                public List<QueryProjectDetailResponseBodyDataSourceClothes> Clothes { get; set; }
                public class QueryProjectDetailResponseBodyDataSourceClothes : TeaModel {
                    [NameInMap("CoverUrl")]
                    [Validation(Required=false)]
                    public string CoverUrl { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OssKey")]
                    [Validation(Required=false)]
                    public string OssKey { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }

                [NameInMap("Files")]
                [Validation(Required=false)]
                public List<QueryProjectDetailResponseBodyDataSourceFiles> Files { get; set; }
                public class QueryProjectDetailResponseBodyDataSourceFiles : TeaModel {
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

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("OssKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public QueryProjectDetailResponseBodyDataSourcePolicy Policy { get; set; }
                public class QueryProjectDetailResponseBodyDataSourcePolicy : TeaModel {
                    [NameInMap("AccessId")]
                    [Validation(Required=false)]
                    public string AccessId { get; set; }

                    [NameInMap("Dir")]
                    [Validation(Required=false)]
                    public string Dir { get; set; }

                    [NameInMap("Expire")]
                    [Validation(Required=false)]
                    public string Expire { get; set; }

                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public string Policy { get; set; }

                    [NameInMap("Signature")]
                    [Validation(Required=false)]
                    public string Signature { get; set; }

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

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

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
