// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class GetPtsReportDetailsResponseBody : TeaModel {
        [NameInMap("ApiMetricsList")]
        [Validation(Required=false)]
        public List<GetPtsReportDetailsResponseBodyApiMetricsList> ApiMetricsList { get; set; }
        public class GetPtsReportDetailsResponseBodyApiMetricsList : TeaModel {
            [NameInMap("AllCount")]
            [Validation(Required=false)]
            public long? AllCount { get; set; }

            [NameInMap("ApiName")]
            [Validation(Required=false)]
            public string ApiName { get; set; }

            [NameInMap("AvgRt")]
            [Validation(Required=false)]
            public float? AvgRt { get; set; }

            [NameInMap("AvgTps")]
            [Validation(Required=false)]
            public float? AvgTps { get; set; }

            [NameInMap("FailCountBiz")]
            [Validation(Required=false)]
            public long? FailCountBiz { get; set; }

            [NameInMap("FailCountReq")]
            [Validation(Required=false)]
            public long? FailCountReq { get; set; }

            [NameInMap("MaxRt")]
            [Validation(Required=false)]
            public float? MaxRt { get; set; }

            [NameInMap("MinRt")]
            [Validation(Required=false)]
            public float? MinRt { get; set; }

            [NameInMap("Seg50Rt")]
            [Validation(Required=false)]
            public float? Seg50Rt { get; set; }

            [NameInMap("Seg75Rt")]
            [Validation(Required=false)]
            public float? Seg75Rt { get; set; }

            [NameInMap("Seg90Rt")]
            [Validation(Required=false)]
            public float? Seg90Rt { get; set; }

            [NameInMap("Seg99Rt")]
            [Validation(Required=false)]
            public float? Seg99Rt { get; set; }

            [NameInMap("SuccessRateBiz")]
            [Validation(Required=false)]
            public float? SuccessRateBiz { get; set; }

            [NameInMap("SuccessRateReq")]
            [Validation(Required=false)]
            public float? SuccessRateReq { get; set; }

        }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ReportOverView")]
        [Validation(Required=false)]
        public GetPtsReportDetailsResponseBodyReportOverView ReportOverView { get; set; }
        public class GetPtsReportDetailsResponseBodyReportOverView : TeaModel {
            [NameInMap("AgentCount")]
            [Validation(Required=false)]
            public int? AgentCount { get; set; }
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }
            [NameInMap("ReportName")]
            [Validation(Required=false)]
            public string ReportName { get; set; }
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }
            [NameInMap("Vum")]
            [Validation(Required=false)]
            public long? Vum { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SceneMetrics")]
        [Validation(Required=false)]
        public GetPtsReportDetailsResponseBodySceneMetrics SceneMetrics { get; set; }
        public class GetPtsReportDetailsResponseBodySceneMetrics : TeaModel {
            [NameInMap("AllCount")]
            [Validation(Required=false)]
            public long? AllCount { get; set; }
            [NameInMap("AvgRt")]
            [Validation(Required=false)]
            public float? AvgRt { get; set; }
            [NameInMap("AvgTps")]
            [Validation(Required=false)]
            public float? AvgTps { get; set; }
            [NameInMap("FailCountBiz")]
            [Validation(Required=false)]
            public long? FailCountBiz { get; set; }
            [NameInMap("FailCountReq")]
            [Validation(Required=false)]
            public long? FailCountReq { get; set; }
            [NameInMap("Seg90Rt")]
            [Validation(Required=false)]
            public float? Seg90Rt { get; set; }
            [NameInMap("Seg99Rt")]
            [Validation(Required=false)]
            public float? Seg99Rt { get; set; }
            [NameInMap("SuccessRateBiz")]
            [Validation(Required=false)]
            public float? SuccessRateBiz { get; set; }
            [NameInMap("SuccessRateReq")]
            [Validation(Required=false)]
            public float? SuccessRateReq { get; set; }
        };

        [NameInMap("SceneSnapShot")]
        [Validation(Required=false)]
        public GetPtsReportDetailsResponseBodySceneSnapShot SceneSnapShot { get; set; }
        public class GetPtsReportDetailsResponseBodySceneSnapShot : TeaModel {
            [NameInMap("AdvanceSetting")]
            [Validation(Required=false)]
            public GetPtsReportDetailsResponseBodySceneSnapShotAdvanceSetting AdvanceSetting { get; set; }
            public class GetPtsReportDetailsResponseBodySceneSnapShotAdvanceSetting : TeaModel {
                [NameInMap("ConnectionTimeoutInSecond")]
                [Validation(Required=false)]
                public int? ConnectionTimeoutInSecond { get; set; }

                [NameInMap("DomainBindingList")]
                [Validation(Required=false)]
                public List<GetPtsReportDetailsResponseBodySceneSnapShotAdvanceSettingDomainBindingList> DomainBindingList { get; set; }
                public class GetPtsReportDetailsResponseBodySceneSnapShotAdvanceSettingDomainBindingList : TeaModel {
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
            public List<GetPtsReportDetailsResponseBodySceneSnapShotFileParameterList> FileParameterList { get; set; }
            public class GetPtsReportDetailsResponseBodySceneSnapShotFileParameterList : TeaModel {
                public string FileName { get; set; }
                public string FileOssAddress { get; set; }
            }
            [NameInMap("GlobalParameterList")]
            [Validation(Required=false)]
            public List<GetPtsReportDetailsResponseBodySceneSnapShotGlobalParameterList> GlobalParameterList { get; set; }
            public class GetPtsReportDetailsResponseBodySceneSnapShotGlobalParameterList : TeaModel {
                public string ParamName { get; set; }
                public string ParamValue { get; set; }
            }
            [NameInMap("LoadConfig")]
            [Validation(Required=false)]
            public GetPtsReportDetailsResponseBodySceneSnapShotLoadConfig LoadConfig { get; set; }
            public class GetPtsReportDetailsResponseBodySceneSnapShotLoadConfig : TeaModel {
                [NameInMap("AgentCount")]
                [Validation(Required=false)]
                public int? AgentCount { get; set; }

                [NameInMap("ApiLoadConfigList")]
                [Validation(Required=false)]
                public List<GetPtsReportDetailsResponseBodySceneSnapShotLoadConfigApiLoadConfigList> ApiLoadConfigList { get; set; }
                public class GetPtsReportDetailsResponseBodySceneSnapShotLoadConfigApiLoadConfigList : TeaModel {
                    [NameInMap("RpsBegin")]
                    [Validation(Required=false)]
                    public int? RpsBegin { get; set; }

                    [NameInMap("RpsLimit")]
                    [Validation(Required=false)]
                    public int? RpsLimit { get; set; }

                }

                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public GetPtsReportDetailsResponseBodySceneSnapShotLoadConfigConfiguration Configuration { get; set; }
                public class GetPtsReportDetailsResponseBodySceneSnapShotLoadConfigConfiguration : TeaModel {
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
                public List<GetPtsReportDetailsResponseBodySceneSnapShotLoadConfigRelationLoadConfigList> RelationLoadConfigList { get; set; }
                public class GetPtsReportDetailsResponseBodySceneSnapShotLoadConfigRelationLoadConfigList : TeaModel {
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
            public List<GetPtsReportDetailsResponseBodySceneSnapShotRelationList> RelationList { get; set; }
            public class GetPtsReportDetailsResponseBodySceneSnapShotRelationList : TeaModel {
                public List<GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiList> ApiList { get; set; }
                public class GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiList : TeaModel {
                    public string ApiId { get; set; }
                    public string ApiName { get; set; }
                    public GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListBody Body { get; set; }
                    public class GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListBody : TeaModel {
                        [NameInMap("BodyValue")]
                        [Validation(Required=false)]
                        public string BodyValue { get; set; }

                        [NameInMap("ContentType")]
                        [Validation(Required=false)]
                        public string ContentType { get; set; }

                    }
                    public List<GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListCheckPointList> CheckPointList { get; set; }
                    public class GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListCheckPointList : TeaModel {
                        public string CheckPoint { get; set; }
                        public string CheckType { get; set; }
                        public string ExpectValue { get; set; }
                        public string Operator { get; set; }
                    }
                    public List<GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListExportList> ExportList { get; set; }
                    public class GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListExportList : TeaModel {
                        public string Count { get; set; }
                        public string ExportName { get; set; }
                        public string ExportType { get; set; }
                        public string ExportValue { get; set; }
                    }
                    public List<GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListHeaderList> HeaderList { get; set; }
                    public class GetPtsReportDetailsResponseBodySceneSnapShotRelationListApiListHeaderList : TeaModel {
                        public string HeaderName { get; set; }
                        public string HeaderValue { get; set; }
                    }
                    public string Method { get; set; }
                    public int? RedirectCountLimit { get; set; }
                    public int? TimeoutInSecond { get; set; }
                    public string Url { get; set; }
                }
                public List<GetPtsReportDetailsResponseBodySceneSnapShotRelationListFileParameterExplainList> FileParameterExplainList { get; set; }
                public class GetPtsReportDetailsResponseBodySceneSnapShotRelationListFileParameterExplainList : TeaModel {
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
