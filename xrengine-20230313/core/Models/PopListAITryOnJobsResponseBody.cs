// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class PopListAITryOnJobsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<PopListAITryOnJobsResponseBodyData> Data { get; set; }
        public class PopListAITryOnJobsResponseBodyData : TeaModel {
            [NameInMap("DummyProjectInfo")]
            [Validation(Required=false)]
            public PopListAITryOnJobsResponseBodyDataDummyProjectInfo DummyProjectInfo { get; set; }
            public class PopListAITryOnJobsResponseBodyDataDummyProjectInfo : TeaModel {
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
                public PopListAITryOnJobsResponseBodyDataDummyProjectInfoBuildDetail BuildDetail { get; set; }
                public class PopListAITryOnJobsResponseBodyDataDummyProjectInfoBuildDetail : TeaModel {
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

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    [NameInMap("RunningTime")]
                    [Validation(Required=false)]
                    public string RunningTime { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

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
                public PopListAITryOnJobsResponseBodyDataDummyProjectInfoDataset Dataset { get; set; }
                public class PopListAITryOnJobsResponseBodyDataDummyProjectInfoDataset : TeaModel {
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
                    public long? Id { get; set; }

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
                    public PopListAITryOnJobsResponseBodyDataDummyProjectInfoDatasetPolicy Policy { get; set; }
                    public class PopListAITryOnJobsResponseBodyDataDummyProjectInfoDatasetPolicy : TeaModel {
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
                public PopListAITryOnJobsResponseBodyDataDummyProjectInfoSource Source { get; set; }
                public class PopListAITryOnJobsResponseBodyDataDummyProjectInfoSource : TeaModel {
                    [NameInMap("Clothes")]
                    [Validation(Required=false)]
                    public List<PopListAITryOnJobsResponseBodyDataDummyProjectInfoSourceClothes> Clothes { get; set; }
                    public class PopListAITryOnJobsResponseBodyDataDummyProjectInfoSourceClothes : TeaModel {
                        [NameInMap("CoverUrl")]
                        [Validation(Required=false)]
                        public string CoverUrl { get; set; }

                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        [NameInMap("Deleted")]
                        [Validation(Required=false)]
                        public bool? Deleted { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("ModifiedTime")]
                        [Validation(Required=false)]
                        public string ModifiedTime { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("OssKey")]
                        [Validation(Required=false)]
                        public string OssKey { get; set; }

                        [NameInMap("Part")]
                        [Validation(Required=false)]
                        public string Part { get; set; }

                        [NameInMap("Size")]
                        [Validation(Required=false)]
                        public string Size { get; set; }

                        [NameInMap("SkuProps")]
                        [Validation(Required=false)]
                        public List<PopListAITryOnJobsResponseBodyDataDummyProjectInfoSourceClothesSkuProps> SkuProps { get; set; }
                        public class PopListAITryOnJobsResponseBodyDataDummyProjectInfoSourceClothesSkuProps : TeaModel {
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Options")]
                            [Validation(Required=false)]
                            public List<string> Options { get; set; }

                        }

                        [NameInMap("Skus")]
                        [Validation(Required=false)]
                        public List<PopListAITryOnJobsResponseBodyDataDummyProjectInfoSourceClothesSkus> Skus { get; set; }
                        public class PopListAITryOnJobsResponseBodyDataDummyProjectInfoSourceClothesSkus : TeaModel {
                            [NameInMap("Color")]
                            [Validation(Required=false)]
                            public string Color { get; set; }

                            [NameInMap("Cover")]
                            [Validation(Required=false)]
                            public string Cover { get; set; }

                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public string Size { get; set; }

                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public string Status { get; set; }

                        }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Status { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Version")]
                        [Validation(Required=false)]
                        public int? Version { get; set; }

                    }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public bool? Deleted { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    [NameInMap("OssKey")]
                    [Validation(Required=false)]
                    public string OssKey { get; set; }

                    [NameInMap("Policy")]
                    [Validation(Required=false)]
                    public PopListAITryOnJobsResponseBodyDataDummyProjectInfoSourcePolicy Policy { get; set; }
                    public class PopListAITryOnJobsResponseBodyDataDummyProjectInfoSourcePolicy : TeaModel {
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
                    public List<PopListAITryOnJobsResponseBodyDataDummyProjectInfoSourceSourceFiles> SourceFiles { get; set; }
                    public class PopListAITryOnJobsResponseBodyDataDummyProjectInfoSourceSourceFiles : TeaModel {
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

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

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

                    [NameInMap("Token")]
                    [Validation(Required=false)]
                    public PopListAITryOnJobsResponseBodyDataDummyProjectInfoSourceToken Token { get; set; }
                    public class PopListAITryOnJobsResponseBodyDataDummyProjectInfoSourceToken : TeaModel {
                        [NameInMap("AccessKeyId")]
                        [Validation(Required=false)]
                        public string AccessKeyId { get; set; }

                        [NameInMap("AccessKeySecret")]
                        [Validation(Required=false)]
                        public string AccessKeySecret { get; set; }

                        [NameInMap("Dir")]
                        [Validation(Required=false)]
                        public string Dir { get; set; }

                        [NameInMap("Expiration")]
                        [Validation(Required=false)]
                        public string Expiration { get; set; }

                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public string Host { get; set; }

                        [NameInMap("SecurityToken")]
                        [Validation(Required=false)]
                        public string SecurityToken { get; set; }

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

            [NameInMap("MaterialInfo")]
            [Validation(Required=false)]
            public PopListAITryOnJobsResponseBodyDataMaterialInfo MaterialInfo { get; set; }
            public class PopListAITryOnJobsResponseBodyDataMaterialInfo : TeaModel {
                [NameInMap("Bottoms")]
                [Validation(Required=false)]
                public PopListAITryOnJobsResponseBodyDataMaterialInfoBottoms Bottoms { get; set; }
                public class PopListAITryOnJobsResponseBodyDataMaterialInfoBottoms : TeaModel {
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public bool? Common { get; set; }

                    [NameInMap("CoverUrl")]
                    [Validation(Required=false)]
                    public string CoverUrl { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public bool? Deleted { get; set; }

                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public string Ext { get; set; }

                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Intro")]
                    [Validation(Required=false)]
                    public string Intro { get; set; }

                    [NameInMap("ListStatus")]
                    [Validation(Required=false)]
                    public string ListStatus { get; set; }

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OssKey")]
                    [Validation(Required=false)]
                    public string OssKey { get; set; }

                    [NameInMap("PreviewUrl")]
                    [Validation(Required=false)]
                    public string PreviewUrl { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("ClothingType")]
                [Validation(Required=false)]
                public string ClothingType { get; set; }

                [NameInMap("Model")]
                [Validation(Required=false)]
                public PopListAITryOnJobsResponseBodyDataMaterialInfoModel Model { get; set; }
                public class PopListAITryOnJobsResponseBodyDataMaterialInfoModel : TeaModel {
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public bool? Common { get; set; }

                    [NameInMap("CoverUrl")]
                    [Validation(Required=false)]
                    public string CoverUrl { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public bool? Deleted { get; set; }

                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public string Ext { get; set; }

                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Intro")]
                    [Validation(Required=false)]
                    public string Intro { get; set; }

                    [NameInMap("ListStatus")]
                    [Validation(Required=false)]
                    public string ListStatus { get; set; }

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OssKey")]
                    [Validation(Required=false)]
                    public string OssKey { get; set; }

                    [NameInMap("PreviewUrl")]
                    [Validation(Required=false)]
                    public string PreviewUrl { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("ShoeType")]
                [Validation(Required=false)]
                public string ShoeType { get; set; }

                [NameInMap("Suit")]
                [Validation(Required=false)]
                public PopListAITryOnJobsResponseBodyDataMaterialInfoSuit Suit { get; set; }
                public class PopListAITryOnJobsResponseBodyDataMaterialInfoSuit : TeaModel {
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public bool? Common { get; set; }

                    [NameInMap("CoverUrl")]
                    [Validation(Required=false)]
                    public string CoverUrl { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public bool? Deleted { get; set; }

                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public string Ext { get; set; }

                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Intro")]
                    [Validation(Required=false)]
                    public string Intro { get; set; }

                    [NameInMap("ListStatus")]
                    [Validation(Required=false)]
                    public string ListStatus { get; set; }

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OssKey")]
                    [Validation(Required=false)]
                    public string OssKey { get; set; }

                    [NameInMap("PreviewUrl")]
                    [Validation(Required=false)]
                    public string PreviewUrl { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("Tops")]
                [Validation(Required=false)]
                public PopListAITryOnJobsResponseBodyDataMaterialInfoTops Tops { get; set; }
                public class PopListAITryOnJobsResponseBodyDataMaterialInfoTops : TeaModel {
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public bool? Common { get; set; }

                    [NameInMap("CoverUrl")]
                    [Validation(Required=false)]
                    public string CoverUrl { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public bool? Deleted { get; set; }

                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public string Ext { get; set; }

                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("Intro")]
                    [Validation(Required=false)]
                    public string Intro { get; set; }

                    [NameInMap("ListStatus")]
                    [Validation(Required=false)]
                    public string ListStatus { get; set; }

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("OssKey")]
                    [Validation(Required=false)]
                    public string OssKey { get; set; }

                    [NameInMap("PreviewUrl")]
                    [Validation(Required=false)]
                    public string PreviewUrl { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("SubTasks")]
            [Validation(Required=false)]
            public List<PopListAITryOnJobsResponseBodyDataSubTasks> SubTasks { get; set; }
            public class PopListAITryOnJobsResponseBodyDataSubTasks : TeaModel {
                [NameInMap("Feedback")]
                [Validation(Required=false)]
                public PopListAITryOnJobsResponseBodyDataSubTasksFeedback Feedback { get; set; }
                public class PopListAITryOnJobsResponseBodyDataSubTasksFeedback : TeaModel {
                    [NameInMap("DislikeTags")]
                    [Validation(Required=false)]
                    public List<int?> DislikeTags { get; set; }

                    [NameInMap("OtherReason")]
                    [Validation(Required=false)]
                    public string OtherReason { get; set; }

                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public long? ProjectId { get; set; }

                    [NameInMap("Rating")]
                    [Validation(Required=false)]
                    public int? Rating { get; set; }

                }

                [NameInMap("SubProjectInfo")]
                [Validation(Required=false)]
                public PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfo SubProjectInfo { get; set; }
                public class PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfo : TeaModel {
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
                    public PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoBuildDetail BuildDetail { get; set; }
                    public class PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoBuildDetail : TeaModel {
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

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("ModifiedTime")]
                        [Validation(Required=false)]
                        public string ModifiedTime { get; set; }

                        [NameInMap("RunningTime")]
                        [Validation(Required=false)]
                        public string RunningTime { get; set; }

                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

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
                    public PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoDataset Dataset { get; set; }
                    public class PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoDataset : TeaModel {
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
                        public long? Id { get; set; }

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
                        public PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoDatasetPolicy Policy { get; set; }
                        public class PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoDatasetPolicy : TeaModel {
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
                    public PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSource Source { get; set; }
                    public class PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSource : TeaModel {
                        [NameInMap("Clothes")]
                        [Validation(Required=false)]
                        public List<PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSourceClothes> Clothes { get; set; }
                        public class PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSourceClothes : TeaModel {
                            [NameInMap("CoverUrl")]
                            [Validation(Required=false)]
                            public string CoverUrl { get; set; }

                            [NameInMap("CreateTime")]
                            [Validation(Required=false)]
                            public string CreateTime { get; set; }

                            [NameInMap("Deleted")]
                            [Validation(Required=false)]
                            public bool? Deleted { get; set; }

                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public long? Id { get; set; }

                            [NameInMap("ModifiedTime")]
                            [Validation(Required=false)]
                            public string ModifiedTime { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("OssKey")]
                            [Validation(Required=false)]
                            public string OssKey { get; set; }

                            [NameInMap("Part")]
                            [Validation(Required=false)]
                            public string Part { get; set; }

                            [NameInMap("Size")]
                            [Validation(Required=false)]
                            public string Size { get; set; }

                            [NameInMap("SkuProps")]
                            [Validation(Required=false)]
                            public List<PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSourceClothesSkuProps> SkuProps { get; set; }
                            public class PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSourceClothesSkuProps : TeaModel {
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                [NameInMap("Options")]
                                [Validation(Required=false)]
                                public List<string> Options { get; set; }

                            }

                            [NameInMap("Skus")]
                            [Validation(Required=false)]
                            public List<PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSourceClothesSkus> Skus { get; set; }
                            public class PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSourceClothesSkus : TeaModel {
                                [NameInMap("Color")]
                                [Validation(Required=false)]
                                public string Color { get; set; }

                                [NameInMap("Cover")]
                                [Validation(Required=false)]
                                public string Cover { get; set; }

                                [NameInMap("Size")]
                                [Validation(Required=false)]
                                public string Size { get; set; }

                                [NameInMap("Status")]
                                [Validation(Required=false)]
                                public string Status { get; set; }

                            }

                            [NameInMap("Status")]
                            [Validation(Required=false)]
                            public Dictionary<string, string> Status { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                            [NameInMap("Version")]
                            [Validation(Required=false)]
                            public int? Version { get; set; }

                        }

                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        [NameInMap("Deleted")]
                        [Validation(Required=false)]
                        public bool? Deleted { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("ModifiedTime")]
                        [Validation(Required=false)]
                        public string ModifiedTime { get; set; }

                        [NameInMap("OssKey")]
                        [Validation(Required=false)]
                        public string OssKey { get; set; }

                        [NameInMap("Policy")]
                        [Validation(Required=false)]
                        public PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSourcePolicy Policy { get; set; }
                        public class PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSourcePolicy : TeaModel {
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
                        public List<PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSourceSourceFiles> SourceFiles { get; set; }
                        public class PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSourceSourceFiles : TeaModel {
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

                            [NameInMap("Id")]
                            [Validation(Required=false)]
                            public long? Id { get; set; }

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

                        [NameInMap("Token")]
                        [Validation(Required=false)]
                        public PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSourceToken Token { get; set; }
                        public class PopListAITryOnJobsResponseBodyDataSubTasksSubProjectInfoSourceToken : TeaModel {
                            [NameInMap("AccessKeyId")]
                            [Validation(Required=false)]
                            public string AccessKeyId { get; set; }

                            [NameInMap("AccessKeySecret")]
                            [Validation(Required=false)]
                            public string AccessKeySecret { get; set; }

                            [NameInMap("Dir")]
                            [Validation(Required=false)]
                            public string Dir { get; set; }

                            [NameInMap("Expiration")]
                            [Validation(Required=false)]
                            public string Expiration { get; set; }

                            [NameInMap("Host")]
                            [Validation(Required=false)]
                            public string Host { get; set; }

                            [NameInMap("SecurityToken")]
                            [Validation(Required=false)]
                            public string SecurityToken { get; set; }

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

            }

        }

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
