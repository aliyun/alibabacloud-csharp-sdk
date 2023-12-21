// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class PopListObjectCaseResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<PopListObjectCaseResponseBodyData> Data { get; set; }
        public class PopListObjectCaseResponseBodyData : TeaModel {
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            [NameInMap("AutoBuild")]
            [Validation(Required=false)]
            public bool? AutoBuild { get; set; }

            [NameInMap("BizUsage")]
            [Validation(Required=false)]
            public string BizUsage { get; set; }

            [NameInMap("BuildDetail")]
            [Validation(Required=false)]
            public PopListObjectCaseResponseBodyDataBuildDetail BuildDetail { get; set; }
            public class PopListObjectCaseResponseBodyDataBuildDetail : TeaModel {
                [NameInMap("CompletedTime")]
                [Validation(Required=false)]
                public string CompletedTime { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("EstimatedDuration")]
                [Validation(Required=false)]
                public long? EstimatedDuration { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("RunningTime")]
                [Validation(Required=false)]
                public string RunningTime { get; set; }

                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

            }

            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public string CheckStatus { get; set; }

            [NameInMap("CreateMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CustomSource")]
            [Validation(Required=false)]
            public string CustomSource { get; set; }

            [NameInMap("Dataset")]
            [Validation(Required=false)]
            public PopListObjectCaseResponseBodyDataDataset Dataset { get; set; }
            public class PopListObjectCaseResponseBodyDataDataset : TeaModel {
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

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("GlbModelUrl")]
                [Validation(Required=false)]
                public string GlbModelUrl { get; set; }

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
                public PopListObjectCaseResponseBodyDataDatasetPolicy Policy { get; set; }
                public class PopListObjectCaseResponseBodyDataDatasetPolicy : TeaModel {
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

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public PopListObjectCaseResponseBodyDataSource Source { get; set; }
            public class PopListObjectCaseResponseBodyDataSource : TeaModel {
                [NameInMap("Clothes")]
                [Validation(Required=false)]
                public List<PopListObjectCaseResponseBodyDataSourceClothes> Clothes { get; set; }
                public class PopListObjectCaseResponseBodyDataSourceClothes : TeaModel {
                    [NameInMap("CoverUrl")]
                    [Validation(Required=false)]
                    public string CoverUrl { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public bool? Deleted { get; set; }

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

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

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("OssKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public PopListObjectCaseResponseBodyDataSourcePolicy Policy { get; set; }
                public class PopListObjectCaseResponseBodyDataSourcePolicy : TeaModel {
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

                [NameInMap("SourceFiles")]
                [Validation(Required=false)]
                public List<PopListObjectCaseResponseBodyDataSourceSourceFiles> SourceFiles { get; set; }
                public class PopListObjectCaseResponseBodyDataSourceSourceFiles : TeaModel {
                    [NameInMap("CoverUrl")]
                    [Validation(Required=false)]
                    public string CoverUrl { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public bool? Deleted { get; set; }

                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("Filesize")]
                    [Validation(Required=false)]
                    public long? Filesize { get; set; }

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    [NameInMap("OssKey")]
                    [Validation(Required=false)]
                    public string OssKey { get; set; }

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

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Pages")]
        [Validation(Required=false)]
        public int? Pages { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
