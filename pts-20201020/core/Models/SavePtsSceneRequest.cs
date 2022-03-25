// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PTS20201020.Models
{
    public class SavePtsSceneRequest : TeaModel {
        /// <summary>
        /// 场景详细信息
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public SavePtsSceneRequestScene Scene { get; set; }
        public class SavePtsSceneRequestScene : TeaModel {
            [NameInMap("AdvanceSetting")]
            [Validation(Required=false)]
            public SavePtsSceneRequestSceneAdvanceSetting AdvanceSetting { get; set; }
            public class SavePtsSceneRequestSceneAdvanceSetting : TeaModel {
                /// <summary>
                /// 超时时间，单位秒
                /// </summary>
                [NameInMap("ConnectionTimeoutInSecond")]
                [Validation(Required=false)]
                public int? ConnectionTimeoutInSecond { get; set; }

                /// <summary>
                /// 域名绑定IP关系
                /// </summary>
                [NameInMap("DomainBindingList")]
                [Validation(Required=false)]
                public List<SavePtsSceneRequestSceneAdvanceSettingDomainBindingList> DomainBindingList { get; set; }
                public class SavePtsSceneRequestSceneAdvanceSettingDomainBindingList : TeaModel {
                    /// <summary>
                    /// 域名
                    /// </summary>
                    [NameInMap("Domain")]
                    [Validation(Required=false)]
                    public string Domain { get; set; }

                    /// <summary>
                    /// 对应的IP
                    /// </summary>
                    [NameInMap("Ips")]
                    [Validation(Required=false)]
                    public List<string> Ips { get; set; }

                }

                /// <summary>
                /// 日志采样率，[1,50]，且是10的倍数
                /// </summary>
                [NameInMap("LogRate")]
                [Validation(Required=false)]
                public int? LogRate { get; set; }

                /// <summary>
                /// 新增成功状态码，多个用英文逗号隔开
                /// </summary>
                [NameInMap("SuccessCode")]
                [Validation(Required=false)]
                public string SuccessCode { get; set; }

            }
            [NameInMap("FileParameterList")]
            [Validation(Required=false)]
            public List<SavePtsSceneRequestSceneFileParameterList> FileParameterList { get; set; }
            public class SavePtsSceneRequestSceneFileParameterList : TeaModel {
                public string FileName { get; set; }
                public string FileOssAddress { get; set; }
            }
            [NameInMap("GlobalParameterList")]
            [Validation(Required=false)]
            public List<SavePtsSceneRequestSceneGlobalParameterList> GlobalParameterList { get; set; }
            public class SavePtsSceneRequestSceneGlobalParameterList : TeaModel {
                public string ParamName { get; set; }
                public string ParamValue { get; set; }
            }
            [NameInMap("LoadConfig")]
            [Validation(Required=false)]
            public SavePtsSceneRequestSceneLoadConfig LoadConfig { get; set; }
            public class SavePtsSceneRequestSceneLoadConfig : TeaModel {
                /// <summary>
                /// 指定机器数，并发必须大于250(RPS大于2000)才能使用，最大扩展机器数不能超过 最大并发/250(最大RPS/2000)
                /// </summary>
                [NameInMap("AgentCount")]
                [Validation(Required=false)]
                public int? AgentCount { get; set; }

                /// <summary>
                /// API的起始、最大RPS值设置，在RPS模式下使用
                /// </summary>
                [NameInMap("ApiLoadConfigList")]
                [Validation(Required=false)]
                public List<SavePtsSceneRequestSceneLoadConfigApiLoadConfigList> ApiLoadConfigList { get; set; }
                public class SavePtsSceneRequestSceneLoadConfigApiLoadConfigList : TeaModel {
                    /// <summary>
                    /// apiId
                    /// </summary>
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    /// <summary>
                    /// 起始RPS值
                    /// </summary>
                    [NameInMap("RpsBegin")]
                    [Validation(Required=false)]
                    public int? RpsBegin { get; set; }

                    /// <summary>
                    /// 最大RPS值
                    /// </summary>
                    [NameInMap("RpsLimit")]
                    [Validation(Required=false)]
                    public int? RpsLimit { get; set; }

                }

                /// <summary>
                /// 是否自动递增，只有在并发模式下有效，即 testMode=concurrency_mode 时
                /// </summary>
                [NameInMap("AutoStep")]
                [Validation(Required=false)]
                public bool? AutoStep { get; set; }

                /// <summary>
                /// 场景施压量级配置信息
                /// </summary>
                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public SavePtsSceneRequestSceneLoadConfigConfiguration Configuration { get; set; }
                public class SavePtsSceneRequestSceneLoadConfigConfiguration : TeaModel {
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

                /// <summary>
                /// 递增百分比，取值范围[10,100]，且是整十倍；只有在并发模式且是自动递增模式下有效，即 testMode=concurrency_mode 且 autoStep=true 时
                /// </summary>
                [NameInMap("Increment")]
                [Validation(Required=false)]
                public int? Increment { get; set; }

                /// <summary>
                /// 单量级持续时长，单位分钟，一定是小于施压时长 maxRunningTime
                /// </summary>
                [NameInMap("KeepTime")]
                [Validation(Required=false)]
                public int? KeepTime { get; set; }

                /// <summary>
                /// 施压时长，单位分钟，[1-1440]
                /// </summary>
                [NameInMap("MaxRunningTime")]
                [Validation(Required=false)]
                public int? MaxRunningTime { get; set; }

                /// <summary>
                /// 链路的起始、最大并发值设置，在并发模式下使用
                /// </summary>
                [NameInMap("RelationLoadConfigList")]
                [Validation(Required=false)]
                public List<SavePtsSceneRequestSceneLoadConfigRelationLoadConfigList> RelationLoadConfigList { get; set; }
                public class SavePtsSceneRequestSceneLoadConfigRelationLoadConfigList : TeaModel {
                    /// <summary>
                    /// concurrencyBegin
                    /// </summary>
                    [NameInMap("ConcurrencyBegin")]
                    [Validation(Required=false)]
                    public int? ConcurrencyBegin { get; set; }

                    /// <summary>
                    /// 最大并发
                    /// </summary>
                    [NameInMap("ConcurrencyLimit")]
                    [Validation(Required=false)]
                    public int? ConcurrencyLimit { get; set; }

                    /// <summary>
                    /// 链路id
                    /// </summary>
                    [NameInMap("RelationId")]
                    [Validation(Required=false)]
                    public string RelationId { get; set; }

                }

                /// <summary>
                /// 施压模式，并发模式(concurrency_mode) 和RPS模式(tps_mode)
                /// </summary>
                [NameInMap("TestMode")]
                [Validation(Required=false)]
                public string TestMode { get; set; }

                /// <summary>
                /// VPC配置
                /// </summary>
                [NameInMap("VpcLoadConfig")]
                [Validation(Required=false)]
                public SavePtsSceneRequestSceneLoadConfigVpcLoadConfig VpcLoadConfig { get; set; }
                public class SavePtsSceneRequestSceneLoadConfigVpcLoadConfig : TeaModel {
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
                };

            }
            [NameInMap("RelationList")]
            [Validation(Required=false)]
            public List<SavePtsSceneRequestSceneRelationList> RelationList { get; set; }
            public class SavePtsSceneRequestSceneRelationList : TeaModel {
                public List<SavePtsSceneRequestSceneRelationListApiList> ApiList { get; set; }
                public class SavePtsSceneRequestSceneRelationListApiList : TeaModel {
                    public string ApiId { get; set; }
                    public string ApiName { get; set; }
                    public SavePtsSceneRequestSceneRelationListApiListBody Body { get; set; }
                    public class SavePtsSceneRequestSceneRelationListApiListBody : TeaModel {
                        /// <summary>
                        /// body 的实际内容 形式 {"key1":"value2","key2":"value2"}
                        /// </summary>
                        [NameInMap("BodyValue")]
                        [Validation(Required=false)]
                        public string BodyValue { get; set; }

                        /// <summary>
                        /// body 类型，默认 application/x-www-form-urlencoded
                        /// </summary>
                        [NameInMap("ContentType")]
                        [Validation(Required=false)]
                        public string ContentType { get; set; }

                    }
                    public List<SavePtsSceneRequestSceneRelationListApiListCheckPointList> CheckPointList { get; set; }
                    public class SavePtsSceneRequestSceneRelationListApiListCheckPointList : TeaModel {
                        public string CheckPoint { get; set; }
                        public string CheckType { get; set; }
                        public string ExpectValue { get; set; }
                        public string Operator { get; set; }
                    }
                    public List<SavePtsSceneRequestSceneRelationListApiListExportList> ExportList { get; set; }
                    public class SavePtsSceneRequestSceneRelationListApiListExportList : TeaModel {
                        public string Count { get; set; }
                        public string ExportName { get; set; }
                        public string ExportType { get; set; }
                        public string ExportValue { get; set; }
                    }
                    public List<SavePtsSceneRequestSceneRelationListApiListHeaderList> HeaderList { get; set; }
                    public class SavePtsSceneRequestSceneRelationListApiListHeaderList : TeaModel {
                        public string HeaderName { get; set; }
                        public string HeaderValue { get; set; }
                    }
                    public string Method { get; set; }
                    public int? RedirectCountLimit { get; set; }
                    public int? TimeoutInSecond { get; set; }
                    public string Url { get; set; }
                }
                public List<SavePtsSceneRequestSceneRelationListFileParameterExplainList> FileParameterExplainList { get; set; }
                public class SavePtsSceneRequestSceneRelationListFileParameterExplainList : TeaModel {
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
        };

    }

}
