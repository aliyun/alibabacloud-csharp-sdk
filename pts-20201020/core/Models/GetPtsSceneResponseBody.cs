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
                public string FileName { get; set; }
                public string FileOssAddress { get; set; }
            }
            [NameInMap("GlobalParameterList")]
            [Validation(Required=false)]
            public List<GetPtsSceneResponseBodySceneGlobalParameterList> GlobalParameterList { get; set; }
            public class GetPtsSceneResponseBodySceneGlobalParameterList : TeaModel {
                public string ParamName { get; set; }
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
                    [NameInMap("RpsBegin")]
                    [Validation(Required=false)]
                    public int? RpsBegin { get; set; }

                    [NameInMap("RpsLimit")]
                    [Validation(Required=false)]
                    public int? RpsLimit { get; set; }

                }

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
                };

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

                }

                [NameInMap("TestMode")]
                [Validation(Required=false)]
                public string TestMode { get; set; }

            }
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }
            [NameInMap("RelationList")]
            [Validation(Required=false)]
            public List<GetPtsSceneResponseBodySceneRelationList> RelationList { get; set; }
            public class GetPtsSceneResponseBodySceneRelationList : TeaModel {
                public List<GetPtsSceneResponseBodySceneRelationListApiList> ApiList { get; set; }
                public class GetPtsSceneResponseBodySceneRelationListApiList : TeaModel {
                    public string ApiId { get; set; }
                    public string ApiName { get; set; }
                    public GetPtsSceneResponseBodySceneRelationListApiListBody Body { get; set; }
                    public class GetPtsSceneResponseBodySceneRelationListApiListBody : TeaModel {
                        [NameInMap("BodyValue")]
                        [Validation(Required=false)]
                        public string BodyValue { get; set; }

                        [NameInMap("ContentType")]
                        [Validation(Required=false)]
                        public string ContentType { get; set; }

                    }
                    public List<GetPtsSceneResponseBodySceneRelationListApiListCheckPointList> CheckPointList { get; set; }
                    public class GetPtsSceneResponseBodySceneRelationListApiListCheckPointList : TeaModel {
                        public string CheckPoint { get; set; }
                        public string CheckType { get; set; }
                        public string ExpectValue { get; set; }
                        public string Operator { get; set; }
                    }
                    public List<GetPtsSceneResponseBodySceneRelationListApiListExportList> ExportList { get; set; }
                    public class GetPtsSceneResponseBodySceneRelationListApiListExportList : TeaModel {
                        public string Count { get; set; }
                        public string ExportName { get; set; }
                        public string ExportType { get; set; }
                        public string ExportValue { get; set; }
                    }
                    public List<GetPtsSceneResponseBodySceneRelationListApiListHeaderList> HeaderList { get; set; }
                    public class GetPtsSceneResponseBodySceneRelationListApiListHeaderList : TeaModel {
                        public string HeaderName { get; set; }
                        public string HeaderValue { get; set; }
                    }
                    public string Method { get; set; }
                    public int? RedirectCountLimit { get; set; }
                    public int? TimeoutInSecond { get; set; }
                    public string Url { get; set; }
                }
                public List<GetPtsSceneResponseBodySceneRelationListFileParameterExplainList> FileParameterExplainList { get; set; }
                public class GetPtsSceneResponseBodySceneRelationListFileParameterExplainList : TeaModel {
                    public bool? BaseFile { get; set; }
                    public bool? CycleOnce { get; set; }
                    public string FileName { get; set; }
                    public string FileParamName { get; set; }
                }
                public string RelationId { get; set; }
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
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
