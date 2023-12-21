// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.XrEngine20230313.Models
{
    public class PopGetAITryOnJobResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PopGetAITryOnJobResponseBodyData Data { get; set; }
        public class PopGetAITryOnJobResponseBodyData : TeaModel {
            [NameInMap("DummyProjectInfo")]
            [Validation(Required=false)]
            public PopGetAITryOnJobResponseBodyDataDummyProjectInfo DummyProjectInfo { get; set; }
            public class PopGetAITryOnJobResponseBodyDataDummyProjectInfo : TeaModel {
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
                public PopGetAITryOnJobResponseBodyDataDummyProjectInfoBuildDetail BuildDetail { get; set; }
                public class PopGetAITryOnJobResponseBodyDataDummyProjectInfoBuildDetail : TeaModel {
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
                public PopGetAITryOnJobResponseBodyDataDummyProjectInfoDataset Dataset { get; set; }
                public class PopGetAITryOnJobResponseBodyDataDummyProjectInfoDataset : TeaModel {
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
                    public PopGetAITryOnJobResponseBodyDataDummyProjectInfoDatasetPolicy Policy { get; set; }
                    public class PopGetAITryOnJobResponseBodyDataDummyProjectInfoDatasetPolicy : TeaModel {
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
                public PopGetAITryOnJobResponseBodyDataDummyProjectInfoSource Source { get; set; }
                public class PopGetAITryOnJobResponseBodyDataDummyProjectInfoSource : TeaModel {
                    [NameInMap("Clothes")]
                    [Validation(Required=false)]
                    public List<PopGetAITryOnJobResponseBodyDataDummyProjectInfoSourceClothes> Clothes { get; set; }
                    public class PopGetAITryOnJobResponseBodyDataDummyProjectInfoSourceClothes : TeaModel {
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
                        public List<PopGetAITryOnJobResponseBodyDataDummyProjectInfoSourceClothesSkuProps> SkuProps { get; set; }
                        public class PopGetAITryOnJobResponseBodyDataDummyProjectInfoSourceClothesSkuProps : TeaModel {
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                            [NameInMap("Options")]
                            [Validation(Required=false)]
                            public List<string> Options { get; set; }

                        }

                        [NameInMap("Skus")]
                        [Validation(Required=false)]
                        public List<PopGetAITryOnJobResponseBodyDataDummyProjectInfoSourceClothesSkus> Skus { get; set; }
                        public class PopGetAITryOnJobResponseBodyDataDummyProjectInfoSourceClothesSkus : TeaModel {
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
                    public PopGetAITryOnJobResponseBodyDataDummyProjectInfoSourcePolicy Policy { get; set; }
                    public class PopGetAITryOnJobResponseBodyDataDummyProjectInfoSourcePolicy : TeaModel {
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
                    public List<PopGetAITryOnJobResponseBodyDataDummyProjectInfoSourceSourceFiles> SourceFiles { get; set; }
                    public class PopGetAITryOnJobResponseBodyDataDummyProjectInfoSourceSourceFiles : TeaModel {
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
                    public PopGetAITryOnJobResponseBodyDataDummyProjectInfoSourceToken Token { get; set; }
                    public class PopGetAITryOnJobResponseBodyDataDummyProjectInfoSourceToken : TeaModel {
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
            public PopGetAITryOnJobResponseBodyDataMaterialInfo MaterialInfo { get; set; }
            public class PopGetAITryOnJobResponseBodyDataMaterialInfo : TeaModel {
                [NameInMap("Bottoms")]
                [Validation(Required=false)]
                public PopGetAITryOnJobResponseBodyDataMaterialInfoBottoms Bottoms { get; set; }
                public class PopGetAITryOnJobResponseBodyDataMaterialInfoBottoms : TeaModel {
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
                public PopGetAITryOnJobResponseBodyDataMaterialInfoModel Model { get; set; }
                public class PopGetAITryOnJobResponseBodyDataMaterialInfoModel : TeaModel {
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
                public PopGetAITryOnJobResponseBodyDataMaterialInfoSuit Suit { get; set; }
                public class PopGetAITryOnJobResponseBodyDataMaterialInfoSuit : TeaModel {
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
                public PopGetAITryOnJobResponseBodyDataMaterialInfoTops Tops { get; set; }
                public class PopGetAITryOnJobResponseBodyDataMaterialInfoTops : TeaModel {
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
            public List<PopGetAITryOnJobResponseBodyDataSubTasks> SubTasks { get; set; }
            public class PopGetAITryOnJobResponseBodyDataSubTasks : TeaModel {
                [NameInMap("Feedback")]
                [Validation(Required=false)]
                public PopGetAITryOnJobResponseBodyDataSubTasksFeedback Feedback { get; set; }
                public class PopGetAITryOnJobResponseBodyDataSubTasksFeedback : TeaModel {
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
                public PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfo SubProjectInfo { get; set; }
                public class PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfo : TeaModel {
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
                    public PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoBuildDetail BuildDetail { get; set; }
                    public class PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoBuildDetail : TeaModel {
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
                    public PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoDataset Dataset { get; set; }
                    public class PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoDataset : TeaModel {
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
                        public PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoDatasetPolicy Policy { get; set; }
                        public class PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoDatasetPolicy : TeaModel {
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
                    public PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSource Source { get; set; }
                    public class PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSource : TeaModel {
                        [NameInMap("Clothes")]
                        [Validation(Required=false)]
                        public List<PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSourceClothes> Clothes { get; set; }
                        public class PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSourceClothes : TeaModel {
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
                            public List<PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSourceClothesSkuProps> SkuProps { get; set; }
                            public class PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSourceClothesSkuProps : TeaModel {
                                [NameInMap("Name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                [NameInMap("Options")]
                                [Validation(Required=false)]
                                public List<string> Options { get; set; }

                            }

                            [NameInMap("Skus")]
                            [Validation(Required=false)]
                            public List<PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSourceClothesSkus> Skus { get; set; }
                            public class PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSourceClothesSkus : TeaModel {
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
                        public PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSourcePolicy Policy { get; set; }
                        public class PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSourcePolicy : TeaModel {
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
                        public List<PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSourceSourceFiles> SourceFiles { get; set; }
                        public class PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSourceSourceFiles : TeaModel {
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
                        public PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSourceToken Token { get; set; }
                        public class PopGetAITryOnJobResponseBodyDataSubTasksSubProjectInfoSourceToken : TeaModel {
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
