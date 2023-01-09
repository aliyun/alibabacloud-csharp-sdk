// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsSceneResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Scene")]
        [Validation(Required=false)]
        public GetPtsSceneResponseBodyScene Scene { get; set; }
        public class GetPtsSceneResponseBodyScene : TeaModel {
            [NameInMap("AdvanceSetting")]
            [Validation(Required=false)]
            public GetPtsSceneResponseBodySceneAdvanceSetting AdvanceSetting { get; set; }
            public class GetPtsSceneResponseBodySceneAdvanceSetting : TeaModel {
                [NameInMap("ConnectionTimeoutInSecond")]
                [Validation(Required=false)]
                public int? ConnectionTimeoutInSecond { get; set; }

                [NameInMap("DomainBindingList")]
                [Validation(Required=false)]
                public List<GetPtsSceneResponseBodySceneAdvanceSettingDomainBindingList> DomainBindingList { get; set; }
                public class GetPtsSceneResponseBodySceneAdvanceSettingDomainBindingList : TeaModel {
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    [NameInMap("Ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                }

                [NameInMap("LogRate")]
                [Validation(Required=false)]
                public int? LogRate { get; set; }

                [NameInMap("SuccessCode")]
                [Validation(Required=false)]
                public string SuccessCode { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("FileParameterList")]
            [Validation(Required=false)]
            public List<GetPtsSceneResponseBodySceneFileParameterList> FileParameterList { get; set; }
            public class GetPtsSceneResponseBodySceneFileParameterList : TeaModel {
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FileOssAddress")]
                [Validation(Required=false)]
                public string FileOssAddress { get; set; }

            }

            [NameInMap("GlobalParameterList")]
            [Validation(Required=false)]
            public List<GetPtsSceneResponseBodySceneGlobalParameterList> GlobalParameterList { get; set; }
            public class GetPtsSceneResponseBodySceneGlobalParameterList : TeaModel {
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                [NameInMap("ParamValue")]
                [Validation(Required=false)]
                public string ParamValue { get; set; }

            }

            [NameInMap("LoadConfig")]
            [Validation(Required=false)]
            public GetPtsSceneResponseBodySceneLoadConfig LoadConfig { get; set; }
            public class GetPtsSceneResponseBodySceneLoadConfig : TeaModel {
                [NameInMap("AgentCount")]
                [Validation(Required=false)]
                public int? AgentCount { get; set; }

                [NameInMap("ApiLoadConfigList")]
                [Validation(Required=false)]
                public List<GetPtsSceneResponseBodySceneLoadConfigApiLoadConfigList> ApiLoadConfigList { get; set; }
                public class GetPtsSceneResponseBodySceneLoadConfigApiLoadConfigList : TeaModel {
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    [NameInMap("RpsBegin")]
                    [Validation(Required=false)]
                    public int? RpsBegin { get; set; }

                    [NameInMap("RpsLimit")]
                    [Validation(Required=false)]
                    public int? RpsLimit { get; set; }

                }

                [NameInMap("AutoStep")]
                [Validation(Required=false)]
                public bool? AutoStep { get; set; }

                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public GetPtsSceneResponseBodySceneLoadConfigConfiguration Configuration { get; set; }
                public class GetPtsSceneResponseBodySceneLoadConfigConfiguration : TeaModel {
                    [NameInMap("AllConcurrencyBegin")]
                    [Validation(Required=false)]
                    public int? AllConcurrencyBegin { get; set; }

                    [NameInMap("AllConcurrencyLimit")]
                    [Validation(Required=false)]
                    public int? AllConcurrencyLimit { get; set; }

                    [NameInMap("AllRpsBegin")]
                    [Validation(Required=false)]
                    public int? AllRpsBegin { get; set; }

                    [NameInMap("AllRpsLimit")]
                    [Validation(Required=false)]
                    public int? AllRpsLimit { get; set; }

                }

                [NameInMap("Increment")]
                [Validation(Required=false)]
                public int? Increment { get; set; }

                [NameInMap("KeepTime")]
                [Validation(Required=false)]
                public int? KeepTime { get; set; }

                [NameInMap("MaxRunningTime")]
                [Validation(Required=false)]
                public int? MaxRunningTime { get; set; }

                [NameInMap("RelationLoadConfigList")]
                [Validation(Required=false)]
                public List<GetPtsSceneResponseBodySceneLoadConfigRelationLoadConfigList> RelationLoadConfigList { get; set; }
                public class GetPtsSceneResponseBodySceneLoadConfigRelationLoadConfigList : TeaModel {
                    [NameInMap("ConcurrencyBegin")]
                    [Validation(Required=false)]
                    public int? ConcurrencyBegin { get; set; }

                    [NameInMap("ConcurrencyLimit")]
                    [Validation(Required=false)]
                    public int? ConcurrencyLimit { get; set; }

                    [NameInMap("RelationId")]
                    [Validation(Required=false)]
                    public string RelationId { get; set; }

                }

                [NameInMap("TestMode")]
                [Validation(Required=false)]
                public string TestMode { get; set; }

                [NameInMap("VpcLoadConfig")]
                [Validation(Required=false)]
                public GetPtsSceneResponseBodySceneLoadConfigVpcLoadConfig VpcLoadConfig { get; set; }
                public class GetPtsSceneResponseBodySceneLoadConfigVpcLoadConfig : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("SecurityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

            }

            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("RelationList")]
            [Validation(Required=false)]
            public List<GetPtsSceneResponseBodySceneRelationList> RelationList { get; set; }
            public class GetPtsSceneResponseBodySceneRelationList : TeaModel {
                [NameInMap("ApiList")]
                [Validation(Required=false)]
                public List<GetPtsSceneResponseBodySceneRelationListApiList> ApiList { get; set; }
                public class GetPtsSceneResponseBodySceneRelationListApiList : TeaModel {
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    [NameInMap("ApiName")]
                    [Validation(Required=false)]
                    public string ApiName { get; set; }

                    [NameInMap("Body")]
                    [Validation(Required=false)]
                    public GetPtsSceneResponseBodySceneRelationListApiListBody Body { get; set; }
                    public class GetPtsSceneResponseBodySceneRelationListApiListBody : TeaModel {
                        [NameInMap("BodyValue")]
                        [Validation(Required=false)]
                        public string BodyValue { get; set; }

                        [NameInMap("ContentType")]
                        [Validation(Required=false)]
                        public string ContentType { get; set; }

                    }

                    [NameInMap("CheckPointList")]
                    [Validation(Required=false)]
                    public List<GetPtsSceneResponseBodySceneRelationListApiListCheckPointList> CheckPointList { get; set; }
                    public class GetPtsSceneResponseBodySceneRelationListApiListCheckPointList : TeaModel {
                        [NameInMap("CheckPoint")]
                        [Validation(Required=false)]
                        public string CheckPoint { get; set; }

                        [NameInMap("CheckType")]
                        [Validation(Required=false)]
                        public string CheckType { get; set; }

                        [NameInMap("ExpectValue")]
                        [Validation(Required=false)]
                        public string ExpectValue { get; set; }

                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                    }

                    [NameInMap("ExportList")]
                    [Validation(Required=false)]
                    public List<GetPtsSceneResponseBodySceneRelationListApiListExportList> ExportList { get; set; }
                    public class GetPtsSceneResponseBodySceneRelationListApiListExportList : TeaModel {
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public string Count { get; set; }

                        [NameInMap("ExportName")]
                        [Validation(Required=false)]
                        public string ExportName { get; set; }

                        [NameInMap("ExportType")]
                        [Validation(Required=false)]
                        public string ExportType { get; set; }

                        [NameInMap("ExportValue")]
                        [Validation(Required=false)]
                        public string ExportValue { get; set; }

                    }

                    [NameInMap("HeaderList")]
                    [Validation(Required=false)]
                    public List<GetPtsSceneResponseBodySceneRelationListApiListHeaderList> HeaderList { get; set; }
                    public class GetPtsSceneResponseBodySceneRelationListApiListHeaderList : TeaModel {
                        [NameInMap("HeaderName")]
                        [Validation(Required=false)]
                        public string HeaderName { get; set; }

                        [NameInMap("HeaderValue")]
                        [Validation(Required=false)]
                        public string HeaderValue { get; set; }

                    }

                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    [NameInMap("RedirectCountLimit")]
                    [Validation(Required=false)]
                    public int? RedirectCountLimit { get; set; }

                    [NameInMap("TimeoutInSecond")]
                    [Validation(Required=false)]
                    public int? TimeoutInSecond { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("FileParameterExplainList")]
                [Validation(Required=false)]
                public List<GetPtsSceneResponseBodySceneRelationListFileParameterExplainList> FileParameterExplainList { get; set; }
                public class GetPtsSceneResponseBodySceneRelationListFileParameterExplainList : TeaModel {
                    [NameInMap("BaseFile")]
                    [Validation(Required=false)]
                    public bool? BaseFile { get; set; }

                    [NameInMap("CycleOnce")]
                    [Validation(Required=false)]
                    public bool? CycleOnce { get; set; }

                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("FileParamName")]
                    [Validation(Required=false)]
                    public string FileParamName { get; set; }

                }

                [NameInMap("RelationId")]
                [Validation(Required=false)]
                public string RelationId { get; set; }

                [NameInMap("RelationName")]
                [Validation(Required=false)]
                public string RelationName { get; set; }

            }

            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            [NameInMap("SceneName")]
            [Validation(Required=false)]
            public string SceneName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
