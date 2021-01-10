// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListGWAppApiResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGWAppApiResponseBodyData Data { get; set; }
        public class ListGWAppApiResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListGWAppApiResponseBodyDataList> List { get; set; }
            public class ListGWAppApiResponseBodyDataList : TeaModel {
                public string ApiGroupId { get; set; }
                public string ApiGroupName { get; set; }
                public string ApiId { get; set; }
                public string ApiName { get; set; }
                public string ApiStatus { get; set; }
                public string AppType { get; set; }
                public string AuthenticationType { get; set; }
                public long? AuthAppCount { get; set; }
                public string AuthAppInfoId { get; set; }
                public bool? CanDelete { get; set; }
                public bool? CanOperate { get; set; }
                public string Charset { get; set; }
                public string CompleteInterfaceName { get; set; }
                public string ContentType { get; set; }
                public string CorsId { get; set; }
                public string CurrentVersionNo { get; set; }
                public string DataEncryption { get; set; }
                public string Description { get; set; }
                public string DomainName { get; set; }
                public string DownstreamProtocol { get; set; }
                public string EditVersionNo { get; set; }
                public string ExternalAuthId { get; set; }
                public string FunctionName { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public string InterfaceName { get; set; }
                public string Method { get; set; }
                public string OnlineVersionNo { get; set; }
                public string OperationType { get; set; }
                public string Operator { get; set; }
                public string Path { get; set; }
                public string PathMatchType { get; set; }
                public string ReqModelId { get; set; }
                public string ReqModelName { get; set; }
                public string ReqParamMappingId { get; set; }
                public string ReqParamMappingType { get; set; }
                public string ReqType { get; set; }
                public string RespModelId { get; set; }
                public string RespModelName { get; set; }
                public string RespParamMappingId { get; set; }
                public string RespType { get; set; }
                public string RouterId { get; set; }
                public string RouterType { get; set; }
                public string SysId { get; set; }
                public string TenantId { get; set; }
                public long? Timeout { get; set; }
                public string UniqueId { get; set; }
                public string UpstreamPath { get; set; }
                public string UpstreamProtocol { get; set; }
                public string UpstreamType { get; set; }
                public string WorkspaceId { get; set; }
                public List<ListGWAppApiResponseBodyDataListHistoryVersionList> HistoryVersionList { get; set; }
                public class ListGWAppApiResponseBodyDataListHistoryVersionList : TeaModel {
                    public string ApiId { get; set; }
                    public string EditOperator { get; set; }
                    public string GmtCreate { get; set; }
                    public string GmtEdit { get; set; }
                    public string GmtModified { get; set; }
                    public string GmtOffline { get; set; }
                    public string GmtOnline { get; set; }
                    public string OfflineDesc { get; set; }
                    public string OfflineOperator { get; set; }
                    public string OnlineDesc { get; set; }
                    public string OnlineOperator { get; set; }
                    public string VersionId { get; set; }
                    public string VersionNo { get; set; }
                    public string VersionStatus { get; set; }
                }
                public List<ListGWAppApiResponseBodyDataListReqParams> ReqParams { get; set; }
                public class ListGWAppApiResponseBodyDataListReqParams : TeaModel {
                    public string ApiId { get; set; }
                    public string DefaultValue { get; set; }
                    public string Description { get; set; }
                    public string FailureDemo { get; set; }
                    public string Location { get; set; }
                    public string Name { get; set; }
                    public string RefType { get; set; }
                    public bool? Required { get; set; }
                    public string SuccessDemo { get; set; }
                    public string TenantId { get; set; }
                    public string Type { get; set; }
                    public string UpstreamLocation { get; set; }
                    public string UpstreamName { get; set; }
                    public string WorkspaceId { get; set; }
                    public List<ListGWAppApiResponseBodyDataListReqParamsRspCodeList> RspCodeList { get; set; }
                    public class ListGWAppApiResponseBodyDataListReqParamsRspCodeList : TeaModel {
                        public string ErrorCode { get; set; }
                        public string ErrorDesc { get; set; }
                        public string ErrorMsg { get; set; }
                    }
                }
                public List<ListGWAppApiResponseBodyDataListUpstreamParamMappings> UpstreamParamMappings { get; set; }
                public class ListGWAppApiResponseBodyDataListUpstreamParamMappings : TeaModel {
                    public string ApiId { get; set; }
                    public string DefaultValue { get; set; }
                    public string Description { get; set; }
                    public string FailureDemo { get; set; }
                    public string Location { get; set; }
                    public string Name { get; set; }
                    public string RefType { get; set; }
                    public bool? Required { get; set; }
                    public string SuccessDemo { get; set; }
                    public string TenantId { get; set; }
                    public string Type { get; set; }
                    public string UpstreamLocation { get; set; }
                    public string UpstreamName { get; set; }
                    public string WorkspaceId { get; set; }
                    public List<ListGWAppApiResponseBodyDataListUpstreamParamMappingsRspCodeList> RspCodeList { get; set; }
                    public class ListGWAppApiResponseBodyDataListUpstreamParamMappingsRspCodeList : TeaModel {
                        public string ErrorCode { get; set; }
                        public string ErrorDesc { get; set; }
                        public string ErrorMsg { get; set; }
                    }
                }
                public ListGWAppApiResponseBodyDataListApiCacheModel ApiCacheModel { get; set; }
                public class ListGWAppApiResponseBodyDataListApiCacheModel : TeaModel {
                    [NameInMap("NeedCache")]
                    [Validation(Required=false)]
                    public bool? NeedCache { get; set; }

                    [NameInMap("Ttl")]
                    [Validation(Required=false)]
                    public long? Ttl { get; set; }

                    [NameInMap("CacheKeys")]
                    [Validation(Required=false)]
                    public List<ListGWAppApiResponseBodyDataListApiCacheModelCacheKeys> CacheKeys { get; set; }
                    public class ListGWAppApiResponseBodyDataListApiCacheModelCacheKeys : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                    }

                }
                public ListGWAppApiResponseBodyDataListApiLimitConfig ApiLimitConfig { get; set; }
                public class ListGWAppApiResponseBodyDataListApiLimitConfig : TeaModel {
                    [NameInMap("Limit")]
                    [Validation(Required=false)]
                    public long? Limit { get; set; }

                    [NameInMap("LimitRspType")]
                    [Validation(Required=false)]
                    public string LimitRspType { get; set; }

                    [NameInMap("NeedLimit")]
                    [Validation(Required=false)]
                    public bool? NeedLimit { get; set; }

                    [NameInMap("RspMsg")]
                    [Validation(Required=false)]
                    public string RspMsg { get; set; }

                }
                public ListGWAppApiResponseBodyDataListApiMockConfig ApiMockConfig { get; set; }
                public class ListGWAppApiResponseBodyDataListApiMockConfig : TeaModel {
                    [NameInMap("MockData")]
                    [Validation(Required=false)]
                    public string MockData { get; set; }

                }
                public ListGWAppApiResponseBodyDataListCorsInfo CorsInfo { get; set; }
                public class ListGWAppApiResponseBodyDataListCorsInfo : TeaModel {
                    [NameInMap("AllowCredentials")]
                    [Validation(Required=false)]
                    public bool? AllowCredentials { get; set; }

                    [NameInMap("ApiCount")]
                    [Validation(Required=false)]
                    public long? ApiCount { get; set; }

                    [NameInMap("CorsId")]
                    [Validation(Required=false)]
                    public string CorsId { get; set; }

                    [NameInMap("CorsName")]
                    [Validation(Required=false)]
                    public string CorsName { get; set; }

                    [NameInMap("CorsScop")]
                    [Validation(Required=false)]
                    public string CorsScop { get; set; }

                    [NameInMap("CorsStatus")]
                    [Validation(Required=false)]
                    public string CorsStatus { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("MaxAge")]
                    [Validation(Required=false)]
                    public long? MaxAge { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                    [NameInMap("AllowHeaders")]
                    [Validation(Required=false)]
                    public List<string> AllowHeaders { get; set; }

                    [NameInMap("AllowMethods")]
                    [Validation(Required=false)]
                    public List<string> AllowMethods { get; set; }

                    [NameInMap("AllowOrigins")]
                    [Validation(Required=false)]
                    public List<string> AllowOrigins { get; set; }

                    [NameInMap("ExposeHeaders")]
                    [Validation(Required=false)]
                    public List<string> ExposeHeaders { get; set; }

                }
                public ListGWAppApiResponseBodyDataListEditVersion EditVersion { get; set; }
                public class ListGWAppApiResponseBodyDataListEditVersion : TeaModel {
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    [NameInMap("EditOperator")]
                    [Validation(Required=false)]
                    public string EditOperator { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtEdit")]
                    [Validation(Required=false)]
                    public string GmtEdit { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("GmtOffline")]
                    [Validation(Required=false)]
                    public string GmtOffline { get; set; }

                    [NameInMap("GmtOnline")]
                    [Validation(Required=false)]
                    public string GmtOnline { get; set; }

                    [NameInMap("OfflineDesc")]
                    [Validation(Required=false)]
                    public string OfflineDesc { get; set; }

                    [NameInMap("OfflineOperator")]
                    [Validation(Required=false)]
                    public string OfflineOperator { get; set; }

                    [NameInMap("OnlineDesc")]
                    [Validation(Required=false)]
                    public string OnlineDesc { get; set; }

                    [NameInMap("OnlineOperator")]
                    [Validation(Required=false)]
                    public string OnlineOperator { get; set; }

                    [NameInMap("VersionId")]
                    [Validation(Required=false)]
                    public string VersionId { get; set; }

                    [NameInMap("VersionNo")]
                    [Validation(Required=false)]
                    public string VersionNo { get; set; }

                    [NameInMap("VersionStatus")]
                    [Validation(Required=false)]
                    public string VersionStatus { get; set; }

                }
                public ListGWAppApiResponseBodyDataListExternalAuth ExternalAuth { get; set; }
                public class ListGWAppApiResponseBodyDataListExternalAuth : TeaModel {
                    [NameInMap("ApiCount")]
                    [Validation(Required=false)]
                    public long? ApiCount { get; set; }

                    [NameInMap("CacheSwitch")]
                    [Validation(Required=false)]
                    public string CacheSwitch { get; set; }

                    [NameInMap("CacheTtl")]
                    [Validation(Required=false)]
                    public long? CacheTtl { get; set; }

                    [NameInMap("CanDelete")]
                    [Validation(Required=false)]
                    public bool? CanDelete { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("ExternalAuthId")]
                    [Validation(Required=false)]
                    public string ExternalAuthId { get; set; }

                    [NameInMap("ExternalAuthName")]
                    [Validation(Required=false)]
                    public string ExternalAuthName { get; set; }

                    [NameInMap("FunctionName")]
                    [Validation(Required=false)]
                    public string FunctionName { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("InterfaceName")]
                    [Validation(Required=false)]
                    public string InterfaceName { get; set; }

                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    [NameInMap("OperationType")]
                    [Validation(Required=false)]
                    public string OperationType { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("RouterId")]
                    [Validation(Required=false)]
                    public string RouterId { get; set; }

                    [NameInMap("RouterType")]
                    [Validation(Required=false)]
                    public string RouterType { get; set; }

                    [NameInMap("SysId")]
                    [Validation(Required=false)]
                    public string SysId { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public long? Timeout { get; set; }

                    [NameInMap("UniqueId")]
                    [Validation(Required=false)]
                    public string UniqueId { get; set; }

                    [NameInMap("UpstreamPath")]
                    [Validation(Required=false)]
                    public string UpstreamPath { get; set; }

                    [NameInMap("UpstreamProtocol")]
                    [Validation(Required=false)]
                    public string UpstreamProtocol { get; set; }

                    [NameInMap("UpstreamType")]
                    [Validation(Required=false)]
                    public string UpstreamType { get; set; }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                    [NameInMap("Params")]
                    [Validation(Required=false)]
                    public List<ListGWAppApiResponseBodyDataListExternalAuthParams> Params { get; set; }
                    public class ListGWAppApiResponseBodyDataListExternalAuthParams : TeaModel {
                        [NameInMap("ApiId")]
                        [Validation(Required=false)]
                        public string ApiId { get; set; }

                        [NameInMap("DefaultValue")]
                        [Validation(Required=false)]
                        public string DefaultValue { get; set; }

                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        [NameInMap("FailureDemo")]
                        [Validation(Required=false)]
                        public string FailureDemo { get; set; }

                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("RefType")]
                        [Validation(Required=false)]
                        public string RefType { get; set; }

                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                        [NameInMap("SuccessDemo")]
                        [Validation(Required=false)]
                        public string SuccessDemo { get; set; }

                        [NameInMap("TenantId")]
                        [Validation(Required=false)]
                        public string TenantId { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("UpstreamLocation")]
                        [Validation(Required=false)]
                        public string UpstreamLocation { get; set; }

                        [NameInMap("UpstreamName")]
                        [Validation(Required=false)]
                        public string UpstreamName { get; set; }

                        [NameInMap("WorkspaceId")]
                        [Validation(Required=false)]
                        public string WorkspaceId { get; set; }

                        [NameInMap("RspCodeList")]
                        [Validation(Required=false)]
                        public List<ListGWAppApiResponseBodyDataListExternalAuthParamsRspCodeList> RspCodeList { get; set; }
                        public class ListGWAppApiResponseBodyDataListExternalAuthParamsRspCodeList : TeaModel {
                            [NameInMap("ErrorCode")]
                            [Validation(Required=false)]
                            public string ErrorCode { get; set; }

                            [NameInMap("ErrorDesc")]
                            [Validation(Required=false)]
                            public string ErrorDesc { get; set; }

                            [NameInMap("ErrorMsg")]
                            [Validation(Required=false)]
                            public string ErrorMsg { get; set; }

                        }

                    }

                    [NameInMap("RouterInfo")]
                    [Validation(Required=false)]
                    public ListGWAppApiResponseBodyDataListExternalAuthRouterInfo RouterInfo { get; set; }
                    public class ListGWAppApiResponseBodyDataListExternalAuthRouterInfo : TeaModel {
                        [NameInMap("ApiCount")]
                        [Validation(Required=false)]
                        public long? ApiCount { get; set; }
                        [NameInMap("CanDelete")]
                        [Validation(Required=false)]
                        public bool? CanDelete { get; set; }
                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }
                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }
                        [NameInMap("RouterId")]
                        [Validation(Required=false)]
                        public string RouterId { get; set; }
                        [NameInMap("RouterName")]
                        [Validation(Required=false)]
                        public string RouterName { get; set; }
                        [NameInMap("RouterType")]
                        [Validation(Required=false)]
                        public string RouterType { get; set; }
                        [NameInMap("TenantId")]
                        [Validation(Required=false)]
                        public string TenantId { get; set; }
                        [NameInMap("UpstreamProtocol")]
                        [Validation(Required=false)]
                        public string UpstreamProtocol { get; set; }
                        [NameInMap("WorkspaceId")]
                        [Validation(Required=false)]
                        public string WorkspaceId { get; set; }
                        [NameInMap("RouterConfigs")]
                        [Validation(Required=false)]
                        public List<ListGWAppApiResponseBodyDataListExternalAuthRouterInfoRouterConfigs> RouterConfigs { get; set; }
                        public class ListGWAppApiResponseBodyDataListExternalAuthRouterInfoRouterConfigs : TeaModel {
                            public string ArgKey { get; set; }
                            public string ArgValue { get; set; }
                            public string InterceptionRule { get; set; }
                            public string MatchType { get; set; }
                            public string ParamLocation { get; set; }
                            public string RouterType { get; set; }
                            public string SysId { get; set; }
                            public long? Weight { get; set; }
                            public ListGWAppApiResponseBodyDataListExternalAuthRouterInfoRouterConfigsSystemCluster SystemCluster { get; set; }
                            public class ListGWAppApiResponseBodyDataListExternalAuthRouterInfoRouterConfigsSystemCluster : TeaModel {
                                [NameInMap("ApiCount")]
                                [Validation(Required=false)]
                                public long? ApiCount { get; set; }

                                [NameInMap("AuthenticationType")]
                                [Validation(Required=false)]
                                public string AuthenticationType { get; set; }

                                [NameInMap("CanDelete")]
                                [Validation(Required=false)]
                                public bool? CanDelete { get; set; }

                                [NameInMap("Description")]
                                [Validation(Required=false)]
                                public string Description { get; set; }

                                [NameInMap("ExternalAuthCount")]
                                [Validation(Required=false)]
                                public long? ExternalAuthCount { get; set; }

                                [NameInMap("GmtCreate")]
                                [Validation(Required=false)]
                                public string GmtCreate { get; set; }

                                [NameInMap("GmtModified")]
                                [Validation(Required=false)]
                                public string GmtModified { get; set; }

                                [NameInMap("InstanceId")]
                                [Validation(Required=false)]
                                public string InstanceId { get; set; }

                                [NameInMap("LbType")]
                                [Validation(Required=false)]
                                public string LbType { get; set; }

                                [NameInMap("Operator")]
                                [Validation(Required=false)]
                                public string Operator { get; set; }

                                [NameInMap("Port")]
                                [Validation(Required=false)]
                                public long? Port { get; set; }

                                [NameInMap("SysId")]
                                [Validation(Required=false)]
                                public string SysId { get; set; }

                                [NameInMap("SysName")]
                                [Validation(Required=false)]
                                public string SysName { get; set; }

                                [NameInMap("SysType")]
                                [Validation(Required=false)]
                                public string SysType { get; set; }

                                [NameInMap("TenantId")]
                                [Validation(Required=false)]
                                public string TenantId { get; set; }

                                [NameInMap("UniqueId")]
                                [Validation(Required=false)]
                                public string UniqueId { get; set; }

                                [NameInMap("UpstreamProtocol")]
                                [Validation(Required=false)]
                                public string UpstreamProtocol { get; set; }

                                [NameInMap("UrlType")]
                                [Validation(Required=false)]
                                public string UrlType { get; set; }

                                [NameInMap("VpcId")]
                                [Validation(Required=false)]
                                public string VpcId { get; set; }

                                [NameInMap("WorkspaceId")]
                                [Validation(Required=false)]
                                public string WorkspaceId { get; set; }

                                [NameInMap("Host")]
                                [Validation(Required=false)]
                                public List<string> Host { get; set; }

                                [NameInMap("AuthenticationConfig")]
                                [Validation(Required=false)]
                                public ListGWAppApiResponseBodyDataListExternalAuthRouterInfoRouterConfigsSystemClusterAuthenticationConfig AuthenticationConfig { get; set; }
                                public class ListGWAppApiResponseBodyDataListExternalAuthRouterInfoRouterConfigsSystemClusterAuthenticationConfig : TeaModel {
                                    [NameInMap("AccessKey")]
                                    [Validation(Required=false)]
                                    public string AccessKey { get; set; }
                                    [NameInMap("SecretKey")]
                                    [Validation(Required=false)]
                                    public string SecretKey { get; set; }
                                };

                            }
                        }
                    };

                    [NameInMap("SystemCluster")]
                    [Validation(Required=false)]
                    public ListGWAppApiResponseBodyDataListExternalAuthSystemCluster SystemCluster { get; set; }
                    public class ListGWAppApiResponseBodyDataListExternalAuthSystemCluster : TeaModel {
                        [NameInMap("ApiCount")]
                        [Validation(Required=false)]
                        public long? ApiCount { get; set; }
                        [NameInMap("AuthenticationType")]
                        [Validation(Required=false)]
                        public string AuthenticationType { get; set; }
                        [NameInMap("CanDelete")]
                        [Validation(Required=false)]
                        public bool? CanDelete { get; set; }
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }
                        [NameInMap("ExternalAuthCount")]
                        [Validation(Required=false)]
                        public long? ExternalAuthCount { get; set; }
                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }
                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }
                        [NameInMap("LbType")]
                        [Validation(Required=false)]
                        public string LbType { get; set; }
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public long? Port { get; set; }
                        [NameInMap("SysId")]
                        [Validation(Required=false)]
                        public string SysId { get; set; }
                        [NameInMap("SysName")]
                        [Validation(Required=false)]
                        public string SysName { get; set; }
                        [NameInMap("SysType")]
                        [Validation(Required=false)]
                        public string SysType { get; set; }
                        [NameInMap("TenantId")]
                        [Validation(Required=false)]
                        public string TenantId { get; set; }
                        [NameInMap("UniqueId")]
                        [Validation(Required=false)]
                        public string UniqueId { get; set; }
                        [NameInMap("UpstreamProtocol")]
                        [Validation(Required=false)]
                        public string UpstreamProtocol { get; set; }
                        [NameInMap("UrlType")]
                        [Validation(Required=false)]
                        public string UrlType { get; set; }
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }
                        [NameInMap("WorkspaceId")]
                        [Validation(Required=false)]
                        public string WorkspaceId { get; set; }
                        [NameInMap("Host")]
                        [Validation(Required=false)]
                        public List<string> Host { get; set; }
                        [NameInMap("AuthenticationConfig")]
                        [Validation(Required=false)]
                        public ListGWAppApiResponseBodyDataListExternalAuthSystemClusterAuthenticationConfig AuthenticationConfig { get; set; }
                        public class ListGWAppApiResponseBodyDataListExternalAuthSystemClusterAuthenticationConfig : TeaModel {
                            [NameInMap("AccessKey")]
                            [Validation(Required=false)]
                            public string AccessKey { get; set; }

                            [NameInMap("SecretKey")]
                            [Validation(Required=false)]
                            public string SecretKey { get; set; }

                        }
                    };

                }
                public ListGWAppApiResponseBodyDataListOnlineVersion OnlineVersion { get; set; }
                public class ListGWAppApiResponseBodyDataListOnlineVersion : TeaModel {
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    [NameInMap("EditOperator")]
                    [Validation(Required=false)]
                    public string EditOperator { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtEdit")]
                    [Validation(Required=false)]
                    public string GmtEdit { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("GmtOffline")]
                    [Validation(Required=false)]
                    public string GmtOffline { get; set; }

                    [NameInMap("GmtOnline")]
                    [Validation(Required=false)]
                    public string GmtOnline { get; set; }

                    [NameInMap("OfflineDesc")]
                    [Validation(Required=false)]
                    public string OfflineDesc { get; set; }

                    [NameInMap("OfflineOperator")]
                    [Validation(Required=false)]
                    public string OfflineOperator { get; set; }

                    [NameInMap("OnlineDesc")]
                    [Validation(Required=false)]
                    public string OnlineDesc { get; set; }

                    [NameInMap("OnlineOperator")]
                    [Validation(Required=false)]
                    public string OnlineOperator { get; set; }

                    [NameInMap("VersionId")]
                    [Validation(Required=false)]
                    public string VersionId { get; set; }

                    [NameInMap("VersionNo")]
                    [Validation(Required=false)]
                    public string VersionNo { get; set; }

                    [NameInMap("VersionStatus")]
                    [Validation(Required=false)]
                    public string VersionStatus { get; set; }

                }
                public ListGWAppApiResponseBodyDataListReqParamMapping ReqParamMapping { get; set; }
                public class ListGWAppApiResponseBodyDataListReqParamMapping : TeaModel {
                    [NameInMap("ApiCount")]
                    [Validation(Required=false)]
                    public long? ApiCount { get; set; }

                    [NameInMap("CanDelete")]
                    [Validation(Required=false)]
                    public bool? CanDelete { get; set; }

                    [NameInMap("ConfigTemplate")]
                    [Validation(Required=false)]
                    public string ConfigTemplate { get; set; }

                    [NameInMap("ConfigTemplateName")]
                    [Validation(Required=false)]
                    public string ConfigTemplateName { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("MappingType")]
                    [Validation(Required=false)]
                    public string MappingType { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("ParamMappingId")]
                    [Validation(Required=false)]
                    public string ParamMappingId { get; set; }

                    [NameInMap("ParamMappingName")]
                    [Validation(Required=false)]
                    public string ParamMappingName { get; set; }

                    [NameInMap("ScriptConfig")]
                    [Validation(Required=false)]
                    public string ScriptConfig { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                }
                public ListGWAppApiResponseBodyDataListRespParamMapping RespParamMapping { get; set; }
                public class ListGWAppApiResponseBodyDataListRespParamMapping : TeaModel {
                    [NameInMap("ApiCount")]
                    [Validation(Required=false)]
                    public long? ApiCount { get; set; }

                    [NameInMap("CanDelete")]
                    [Validation(Required=false)]
                    public bool? CanDelete { get; set; }

                    [NameInMap("ConfigTemplate")]
                    [Validation(Required=false)]
                    public string ConfigTemplate { get; set; }

                    [NameInMap("ConfigTemplateName")]
                    [Validation(Required=false)]
                    public string ConfigTemplateName { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("MappingType")]
                    [Validation(Required=false)]
                    public string MappingType { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("ParamMappingId")]
                    [Validation(Required=false)]
                    public string ParamMappingId { get; set; }

                    [NameInMap("ParamMappingName")]
                    [Validation(Required=false)]
                    public string ParamMappingName { get; set; }

                    [NameInMap("ScriptConfig")]
                    [Validation(Required=false)]
                    public string ScriptConfig { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                }
                public ListGWAppApiResponseBodyDataListRouterInfo RouterInfo { get; set; }
                public class ListGWAppApiResponseBodyDataListRouterInfo : TeaModel {
                    [NameInMap("ApiCount")]
                    [Validation(Required=false)]
                    public long? ApiCount { get; set; }

                    [NameInMap("CanDelete")]
                    [Validation(Required=false)]
                    public bool? CanDelete { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("RouterId")]
                    [Validation(Required=false)]
                    public string RouterId { get; set; }

                    [NameInMap("RouterName")]
                    [Validation(Required=false)]
                    public string RouterName { get; set; }

                    [NameInMap("RouterType")]
                    [Validation(Required=false)]
                    public string RouterType { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("UpstreamProtocol")]
                    [Validation(Required=false)]
                    public string UpstreamProtocol { get; set; }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                    [NameInMap("RouterConfigs")]
                    [Validation(Required=false)]
                    public List<ListGWAppApiResponseBodyDataListRouterInfoRouterConfigs> RouterConfigs { get; set; }
                    public class ListGWAppApiResponseBodyDataListRouterInfoRouterConfigs : TeaModel {
                        [NameInMap("ArgKey")]
                        [Validation(Required=false)]
                        public string ArgKey { get; set; }

                        [NameInMap("ArgValue")]
                        [Validation(Required=false)]
                        public string ArgValue { get; set; }

                        [NameInMap("InterceptionRule")]
                        [Validation(Required=false)]
                        public string InterceptionRule { get; set; }

                        [NameInMap("MatchType")]
                        [Validation(Required=false)]
                        public string MatchType { get; set; }

                        [NameInMap("ParamLocation")]
                        [Validation(Required=false)]
                        public string ParamLocation { get; set; }

                        [NameInMap("RouterType")]
                        [Validation(Required=false)]
                        public string RouterType { get; set; }

                        [NameInMap("SysId")]
                        [Validation(Required=false)]
                        public string SysId { get; set; }

                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public long? Weight { get; set; }

                        [NameInMap("SystemCluster")]
                        [Validation(Required=false)]
                        public ListGWAppApiResponseBodyDataListRouterInfoRouterConfigsSystemCluster SystemCluster { get; set; }
                        public class ListGWAppApiResponseBodyDataListRouterInfoRouterConfigsSystemCluster : TeaModel {
                            [NameInMap("ApiCount")]
                            [Validation(Required=false)]
                            public long? ApiCount { get; set; }
                            [NameInMap("AuthenticationType")]
                            [Validation(Required=false)]
                            public string AuthenticationType { get; set; }
                            [NameInMap("CanDelete")]
                            [Validation(Required=false)]
                            public bool? CanDelete { get; set; }
                            [NameInMap("Description")]
                            [Validation(Required=false)]
                            public string Description { get; set; }
                            [NameInMap("ExternalAuthCount")]
                            [Validation(Required=false)]
                            public long? ExternalAuthCount { get; set; }
                            [NameInMap("GmtCreate")]
                            [Validation(Required=false)]
                            public string GmtCreate { get; set; }
                            [NameInMap("GmtModified")]
                            [Validation(Required=false)]
                            public string GmtModified { get; set; }
                            [NameInMap("InstanceId")]
                            [Validation(Required=false)]
                            public string InstanceId { get; set; }
                            [NameInMap("LbType")]
                            [Validation(Required=false)]
                            public string LbType { get; set; }
                            [NameInMap("Operator")]
                            [Validation(Required=false)]
                            public string Operator { get; set; }
                            [NameInMap("Port")]
                            [Validation(Required=false)]
                            public long? Port { get; set; }
                            [NameInMap("SysId")]
                            [Validation(Required=false)]
                            public string SysId { get; set; }
                            [NameInMap("SysName")]
                            [Validation(Required=false)]
                            public string SysName { get; set; }
                            [NameInMap("SysType")]
                            [Validation(Required=false)]
                            public string SysType { get; set; }
                            [NameInMap("TenantId")]
                            [Validation(Required=false)]
                            public string TenantId { get; set; }
                            [NameInMap("UniqueId")]
                            [Validation(Required=false)]
                            public string UniqueId { get; set; }
                            [NameInMap("UpstreamProtocol")]
                            [Validation(Required=false)]
                            public string UpstreamProtocol { get; set; }
                            [NameInMap("UrlType")]
                            [Validation(Required=false)]
                            public string UrlType { get; set; }
                            [NameInMap("VpcId")]
                            [Validation(Required=false)]
                            public string VpcId { get; set; }
                            [NameInMap("WorkspaceId")]
                            [Validation(Required=false)]
                            public string WorkspaceId { get; set; }
                            [NameInMap("Host")]
                            [Validation(Required=false)]
                            public List<string> Host { get; set; }
                            [NameInMap("AuthenticationConfig")]
                            [Validation(Required=false)]
                            public ListGWAppApiResponseBodyDataListRouterInfoRouterConfigsSystemClusterAuthenticationConfig AuthenticationConfig { get; set; }
                            public class ListGWAppApiResponseBodyDataListRouterInfoRouterConfigsSystemClusterAuthenticationConfig : TeaModel {
                                [NameInMap("AccessKey")]
                                [Validation(Required=false)]
                                public string AccessKey { get; set; }

                                [NameInMap("SecretKey")]
                                [Validation(Required=false)]
                                public string SecretKey { get; set; }

                            }
                        };

                    }

                }
                public ListGWAppApiResponseBodyDataListRsqParam RsqParam { get; set; }
                public class ListGWAppApiResponseBodyDataListRsqParam : TeaModel {
                    [NameInMap("ApiId")]
                    [Validation(Required=false)]
                    public string ApiId { get; set; }

                    [NameInMap("DefaultValue")]
                    [Validation(Required=false)]
                    public string DefaultValue { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("FailureDemo")]
                    [Validation(Required=false)]
                    public string FailureDemo { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("RefType")]
                    [Validation(Required=false)]
                    public string RefType { get; set; }

                    [NameInMap("Required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    [NameInMap("SuccessDemo")]
                    [Validation(Required=false)]
                    public string SuccessDemo { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("UpstreamLocation")]
                    [Validation(Required=false)]
                    public string UpstreamLocation { get; set; }

                    [NameInMap("UpstreamName")]
                    [Validation(Required=false)]
                    public string UpstreamName { get; set; }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                    [NameInMap("RspCodeList")]
                    [Validation(Required=false)]
                    public List<ListGWAppApiResponseBodyDataListRsqParamRspCodeList> RspCodeList { get; set; }
                    public class ListGWAppApiResponseBodyDataListRsqParamRspCodeList : TeaModel {
                        [NameInMap("ErrorCode")]
                        [Validation(Required=false)]
                        public string ErrorCode { get; set; }

                        [NameInMap("ErrorDesc")]
                        [Validation(Required=false)]
                        public string ErrorDesc { get; set; }

                        [NameInMap("ErrorMsg")]
                        [Validation(Required=false)]
                        public string ErrorMsg { get; set; }

                    }

                }
                public ListGWAppApiResponseBodyDataListSystemCluster SystemCluster { get; set; }
                public class ListGWAppApiResponseBodyDataListSystemCluster : TeaModel {
                    [NameInMap("ApiCount")]
                    [Validation(Required=false)]
                    public long? ApiCount { get; set; }

                    [NameInMap("AuthenticationType")]
                    [Validation(Required=false)]
                    public string AuthenticationType { get; set; }

                    [NameInMap("CanDelete")]
                    [Validation(Required=false)]
                    public bool? CanDelete { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("ExternalAuthCount")]
                    [Validation(Required=false)]
                    public long? ExternalAuthCount { get; set; }

                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("LbType")]
                    [Validation(Required=false)]
                    public string LbType { get; set; }

                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public long? Port { get; set; }

                    [NameInMap("SysId")]
                    [Validation(Required=false)]
                    public string SysId { get; set; }

                    [NameInMap("SysName")]
                    [Validation(Required=false)]
                    public string SysName { get; set; }

                    [NameInMap("SysType")]
                    [Validation(Required=false)]
                    public string SysType { get; set; }

                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    [NameInMap("UniqueId")]
                    [Validation(Required=false)]
                    public string UniqueId { get; set; }

                    [NameInMap("UpstreamProtocol")]
                    [Validation(Required=false)]
                    public string UpstreamProtocol { get; set; }

                    [NameInMap("UrlType")]
                    [Validation(Required=false)]
                    public string UrlType { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    [NameInMap("WorkspaceId")]
                    [Validation(Required=false)]
                    public string WorkspaceId { get; set; }

                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public List<string> Host { get; set; }

                    [NameInMap("AuthenticationConfig")]
                    [Validation(Required=false)]
                    public ListGWAppApiResponseBodyDataListSystemClusterAuthenticationConfig AuthenticationConfig { get; set; }
                    public class ListGWAppApiResponseBodyDataListSystemClusterAuthenticationConfig : TeaModel {
                        [NameInMap("AccessKey")]
                        [Validation(Required=false)]
                        public string AccessKey { get; set; }
                        [NameInMap("SecretKey")]
                        [Validation(Required=false)]
                        public string SecretKey { get; set; }
                    };

                }
            }
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public ListGWAppApiResponseBodyDataPageInfo PageInfo { get; set; }
            public class ListGWAppApiResponseBodyDataPageInfo : TeaModel {
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public long? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public long? PageSize { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public long? Total { get; set; }

                [NameInMap("OrderInfos")]
                [Validation(Required=false)]
                public List<ListGWAppApiResponseBodyDataPageInfoOrderInfos> OrderInfos { get; set; }
                public class ListGWAppApiResponseBodyDataPageInfoOrderInfos : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Order")]
                    [Validation(Required=false)]
                    public string Order { get; set; }

                }

            }
        };

    }

}
