// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Buss20220822.Models;

namespace AlibabaCloud.SDK.Buss20220822
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("buss", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        /**
         * @summary 处罚请求异步接口回调
         *
         * @param tmpReq BusinessResultServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BusinessResultServiceResponse
         */
        public BusinessResultServiceResponse BusinessResultServiceWithOptions(BusinessResultServiceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BusinessResultServiceShrinkRequest request = new BusinessResultServiceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Result))
            {
                request.ResultShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Result, "Result", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BusinessResultService",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BusinessResultServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 处罚请求异步接口回调
         *
         * @param tmpReq BusinessResultServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BusinessResultServiceResponse
         */
        public async Task<BusinessResultServiceResponse> BusinessResultServiceWithOptionsAsync(BusinessResultServiceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BusinessResultServiceShrinkRequest request = new BusinessResultServiceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Result))
            {
                request.ResultShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Result, "Result", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BusinessResultService",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BusinessResultServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 处罚请求异步接口回调
         *
         * @param request BusinessResultServiceRequest
         * @return BusinessResultServiceResponse
         */
        public BusinessResultServiceResponse BusinessResultService(BusinessResultServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BusinessResultServiceWithOptions(request, runtime);
        }

        /**
         * @summary 处罚请求异步接口回调
         *
         * @param request BusinessResultServiceRequest
         * @return BusinessResultServiceResponse
         */
        public async Task<BusinessResultServiceResponse> BusinessResultServiceAsync(BusinessResultServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BusinessResultServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 协查中心查询任务接口
         *
         * @param request CreateUserInvestigationInfoQueryTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserInvestigationInfoQueryTaskResponse
         */
        public CreateUserInvestigationInfoQueryTaskResponse CreateUserInvestigationInfoQueryTaskWithOptions(CreateUserInvestigationInfoQueryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserInvestigationInfoQueryTask",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserInvestigationInfoQueryTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 协查中心查询任务接口
         *
         * @param request CreateUserInvestigationInfoQueryTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserInvestigationInfoQueryTaskResponse
         */
        public async Task<CreateUserInvestigationInfoQueryTaskResponse> CreateUserInvestigationInfoQueryTaskWithOptionsAsync(CreateUserInvestigationInfoQueryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUserInvestigationInfoQueryTask",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserInvestigationInfoQueryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 协查中心查询任务接口
         *
         * @param request CreateUserInvestigationInfoQueryTaskRequest
         * @return CreateUserInvestigationInfoQueryTaskResponse
         */
        public CreateUserInvestigationInfoQueryTaskResponse CreateUserInvestigationInfoQueryTask(CreateUserInvestigationInfoQueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserInvestigationInfoQueryTaskWithOptions(request, runtime);
        }

        /**
         * @summary 协查中心查询任务接口
         *
         * @param request CreateUserInvestigationInfoQueryTaskRequest
         * @return CreateUserInvestigationInfoQueryTaskResponse
         */
        public async Task<CreateUserInvestigationInfoQueryTaskResponse> CreateUserInvestigationInfoQueryTaskAsync(CreateUserInvestigationInfoQueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserInvestigationInfoQueryTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 反查资源
         *
         * @param tmpReq FindInstanceInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FindInstanceInfoResponse
         */
        public FindInstanceInfoResponse FindInstanceInfoWithOptions(FindInstanceInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FindInstanceInfoShrinkRequest request = new FindInstanceInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extras))
            {
                request.ExtrasShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extras, "extras", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindInstanceInfo",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindInstanceInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 反查资源
         *
         * @param tmpReq FindInstanceInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FindInstanceInfoResponse
         */
        public async Task<FindInstanceInfoResponse> FindInstanceInfoWithOptionsAsync(FindInstanceInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            FindInstanceInfoShrinkRequest request = new FindInstanceInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Extras))
            {
                request.ExtrasShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Extras, "extras", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindInstanceInfo",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindInstanceInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 反查资源
         *
         * @param request FindInstanceInfoRequest
         * @return FindInstanceInfoResponse
         */
        public FindInstanceInfoResponse FindInstanceInfo(FindInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindInstanceInfoWithOptions(request, runtime);
        }

        /**
         * @summary 反查资源
         *
         * @param request FindInstanceInfoRequest
         * @return FindInstanceInfoResponse
         */
        public async Task<FindInstanceInfoResponse> FindInstanceInfoAsync(FindInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindInstanceInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据用户id查询对应产品下全部可用资产信息接口
         *
         * @param request FindUserAvailbleResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FindUserAvailbleResourcesResponse
         */
        public FindUserAvailbleResourcesResponse FindUserAvailbleResourcesWithOptions(FindUserAvailbleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindUserAvailbleResources",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindUserAvailbleResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据用户id查询对应产品下全部可用资产信息接口
         *
         * @param request FindUserAvailbleResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FindUserAvailbleResourcesResponse
         */
        public async Task<FindUserAvailbleResourcesResponse> FindUserAvailbleResourcesWithOptionsAsync(FindUserAvailbleResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindUserAvailbleResources",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindUserAvailbleResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据用户id查询对应产品下全部可用资产信息接口
         *
         * @param request FindUserAvailbleResourcesRequest
         * @return FindUserAvailbleResourcesResponse
         */
        public FindUserAvailbleResourcesResponse FindUserAvailbleResources(FindUserAvailbleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindUserAvailbleResourcesWithOptions(request, runtime);
        }

        /**
         * @summary 根据用户id查询对应产品下全部可用资产信息接口
         *
         * @param request FindUserAvailbleResourcesRequest
         * @return FindUserAvailbleResourcesResponse
         */
        public async Task<FindUserAvailbleResourcesResponse> FindUserAvailbleResourcesAsync(FindUserAvailbleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindUserAvailbleResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 处罚资源搜索
         *
         * @param tmpReq PunishResourceSearchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PunishResourceSearchResponse
         */
        public PunishResourceSearchResponse PunishResourceSearchWithOptions(PunishResourceSearchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PunishResourceSearchShrinkRequest request = new PunishResourceSearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionCodes))
            {
                request.ActionCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionCodes, "ActionCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BussinessCodes))
            {
                request.BussinessCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BussinessCodes, "BussinessCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceCodes))
            {
                request.SourceCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceCodes, "SourceCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIds))
            {
                request.UserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIds, "UserIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PunishResourceSearch",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PunishResourceSearchResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 处罚资源搜索
         *
         * @param tmpReq PunishResourceSearchRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PunishResourceSearchResponse
         */
        public async Task<PunishResourceSearchResponse> PunishResourceSearchWithOptionsAsync(PunishResourceSearchRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PunishResourceSearchShrinkRequest request = new PunishResourceSearchShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionCodes))
            {
                request.ActionCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionCodes, "ActionCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BussinessCodes))
            {
                request.BussinessCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BussinessCodes, "BussinessCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceCodes))
            {
                request.SourceCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceCodes, "SourceCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIds))
            {
                request.UserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIds, "UserIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PunishResourceSearch",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PunishResourceSearchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 处罚资源搜索
         *
         * @param request PunishResourceSearchRequest
         * @return PunishResourceSearchResponse
         */
        public PunishResourceSearchResponse PunishResourceSearch(PunishResourceSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PunishResourceSearchWithOptions(request, runtime);
        }

        /**
         * @summary 处罚资源搜索
         *
         * @param request PunishResourceSearchRequest
         * @return PunishResourceSearchResponse
         */
        public async Task<PunishResourceSearchResponse> PunishResourceSearchAsync(PunishResourceSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PunishResourceSearchWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 风险事件同步
         *
         * @param request RiskEventSyncRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RiskEventSyncResponse
         */
        public RiskEventSyncResponse RiskEventSyncWithOptions(RiskEventSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deleted))
            {
                body["Deleted"] = request.Deleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryTime))
            {
                body["DiscoveryTime"] = request.DiscoveryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                body["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventNumber))
            {
                body["EventNumber"] = request.EventNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelevanceBu))
            {
                body["RelevanceBu"] = request.RelevanceBu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskDetail))
            {
                body["RiskDetail"] = request.RiskDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskEffectType))
            {
                body["RiskEffectType"] = request.RiskEffectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskType))
            {
                body["RiskType"] = request.RiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Submitter))
            {
                body["Submitter"] = request.Submitter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RiskEventSync",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RiskEventSyncResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 风险事件同步
         *
         * @param request RiskEventSyncRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RiskEventSyncResponse
         */
        public async Task<RiskEventSyncResponse> RiskEventSyncWithOptionsAsync(RiskEventSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deleted))
            {
                body["Deleted"] = request.Deleted;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscoveryTime))
            {
                body["DiscoveryTime"] = request.DiscoveryTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                body["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventNumber))
            {
                body["EventNumber"] = request.EventNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelevanceBu))
            {
                body["RelevanceBu"] = request.RelevanceBu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskDetail))
            {
                body["RiskDetail"] = request.RiskDetail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskEffectType))
            {
                body["RiskEffectType"] = request.RiskEffectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                body["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskType))
            {
                body["RiskType"] = request.RiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Submitter))
            {
                body["Submitter"] = request.Submitter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RiskEventSync",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RiskEventSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 风险事件同步
         *
         * @param request RiskEventSyncRequest
         * @return RiskEventSyncResponse
         */
        public RiskEventSyncResponse RiskEventSync(RiskEventSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RiskEventSyncWithOptions(request, runtime);
        }

        /**
         * @summary 风险事件同步
         *
         * @param request RiskEventSyncRequest
         * @return RiskEventSyncResponse
         */
        public async Task<RiskEventSyncResponse> RiskEventSyncAsync(RiskEventSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RiskEventSyncWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 管控事件查询
         *
         * @param tmpReq SearchPunishEventsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchPunishEventsResponse
         */
        public SearchPunishEventsResponse SearchPunishEventsWithOptions(SearchPunishEventsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchPunishEventsShrinkRequest request = new SearchPunishEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BussinessCodes))
            {
                request.BussinessCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BussinessCodes, "BussinessCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CaseCodes))
            {
                request.CaseCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CaseCodes, "CaseCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventCodes))
            {
                request.EventCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventCodes, "EventCodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BussinessCodesShrink))
            {
                query["BussinessCodes"] = request.BussinessCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseCodesShrink))
            {
                query["CaseCodes"] = request.CaseCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventCodesShrink))
            {
                query["EventCodes"] = request.EventCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchPunishEvents",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchPunishEventsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 管控事件查询
         *
         * @param tmpReq SearchPunishEventsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchPunishEventsResponse
         */
        public async Task<SearchPunishEventsResponse> SearchPunishEventsWithOptionsAsync(SearchPunishEventsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchPunishEventsShrinkRequest request = new SearchPunishEventsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BussinessCodes))
            {
                request.BussinessCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BussinessCodes, "BussinessCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CaseCodes))
            {
                request.CaseCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CaseCodes, "CaseCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventCodes))
            {
                request.EventCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventCodes, "EventCodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BussinessCodesShrink))
            {
                query["BussinessCodes"] = request.BussinessCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseCodesShrink))
            {
                query["CaseCodes"] = request.CaseCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventCodesShrink))
            {
                query["EventCodes"] = request.EventCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchPunishEvents",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchPunishEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 管控事件查询
         *
         * @param request SearchPunishEventsRequest
         * @return SearchPunishEventsResponse
         */
        public SearchPunishEventsResponse SearchPunishEvents(SearchPunishEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchPunishEventsWithOptions(request, runtime);
        }

        /**
         * @summary 管控事件查询
         *
         * @param request SearchPunishEventsRequest
         * @return SearchPunishEventsResponse
         */
        public async Task<SearchPunishEventsResponse> SearchPunishEventsAsync(SearchPunishEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchPunishEventsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 管控事件查询
         *
         * @param tmpReq SearchPunishRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchPunishRecordsResponse
         */
        public SearchPunishRecordsResponse SearchPunishRecordsWithOptions(SearchPunishRecordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchPunishRecordsShrinkRequest request = new SearchPunishRecordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionCodes))
            {
                request.ActionCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionCodes, "ActionCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CaseCodes))
            {
                request.CaseCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CaseCodes, "CaseCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventCodes))
            {
                request.EventCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventCodes, "EventCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PunishStatus))
            {
                request.PunishStatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PunishStatus, "PunishStatus", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceCodes))
            {
                request.SourceCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceCodes, "SourceCodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodesShrink))
            {
                query["ActionCodes"] = request.ActionCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BussinessCodes))
            {
                query["BussinessCodes"] = request.BussinessCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseCodesShrink))
            {
                query["CaseCodes"] = request.CaseCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventCodesShrink))
            {
                query["EventCodes"] = request.EventCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunishStatusShrink))
            {
                query["PunishStatus"] = request.PunishStatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCodesShrink))
            {
                query["SourceCodes"] = request.SourceCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlFuzzy))
            {
                query["UrlFuzzy"] = request.UrlFuzzy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchPunishRecords",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchPunishRecordsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 管控事件查询
         *
         * @param tmpReq SearchPunishRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchPunishRecordsResponse
         */
        public async Task<SearchPunishRecordsResponse> SearchPunishRecordsWithOptionsAsync(SearchPunishRecordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchPunishRecordsShrinkRequest request = new SearchPunishRecordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionCodes))
            {
                request.ActionCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionCodes, "ActionCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CaseCodes))
            {
                request.CaseCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CaseCodes, "CaseCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventCodes))
            {
                request.EventCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventCodes, "EventCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PunishStatus))
            {
                request.PunishStatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PunishStatus, "PunishStatus", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceCodes))
            {
                request.SourceCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceCodes, "SourceCodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionCodesShrink))
            {
                query["ActionCodes"] = request.ActionCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliUid))
            {
                query["AliUid"] = request.AliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BussinessCodes))
            {
                query["BussinessCodes"] = request.BussinessCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseCodesShrink))
            {
                query["CaseCodes"] = request.CaseCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventCodesShrink))
            {
                query["EventCodes"] = request.EventCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PunishStatusShrink))
            {
                query["PunishStatus"] = request.PunishStatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCodesShrink))
            {
                query["SourceCodes"] = request.SourceCodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                query["Url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrlFuzzy))
            {
                query["UrlFuzzy"] = request.UrlFuzzy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchPunishRecords",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchPunishRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 管控事件查询
         *
         * @param request SearchPunishRecordsRequest
         * @return SearchPunishRecordsResponse
         */
        public SearchPunishRecordsResponse SearchPunishRecords(SearchPunishRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchPunishRecordsWithOptions(request, runtime);
        }

        /**
         * @summary 管控事件查询
         *
         * @param request SearchPunishRecordsRequest
         * @return SearchPunishRecordsResponse
         */
        public async Task<SearchPunishRecordsResponse> SearchPunishRecordsAsync(SearchPunishRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchPunishRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 处罚记录查询
         *
         * @param tmpReq SearchPunishRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchPunishRequestResponse
         */
        public SearchPunishRequestResponse SearchPunishRequestWithOptions(SearchPunishRequestRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchPunishRequestShrinkRequest request = new SearchPunishRequestShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AntiStatuses))
            {
                request.AntiStatusesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AntiStatuses, "AntiStatuses", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BussinessCodes))
            {
                request.BussinessCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BussinessCodes, "BussinessCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventCodes))
            {
                request.EventCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventCodes, "EventCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PunishStatuses))
            {
                request.PunishStatusesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PunishStatuses, "PunishStatuses", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceCodes))
            {
                request.SourceCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceCodes, "SourceCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIds))
            {
                request.UserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIds, "UserIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchPunishRequest",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchPunishRequestResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 处罚记录查询
         *
         * @param tmpReq SearchPunishRequestRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchPunishRequestResponse
         */
        public async Task<SearchPunishRequestResponse> SearchPunishRequestWithOptionsAsync(SearchPunishRequestRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchPunishRequestShrinkRequest request = new SearchPunishRequestShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AntiStatuses))
            {
                request.AntiStatusesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AntiStatuses, "AntiStatuses", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BussinessCodes))
            {
                request.BussinessCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BussinessCodes, "BussinessCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventCodes))
            {
                request.EventCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventCodes, "EventCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PunishStatuses))
            {
                request.PunishStatusesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PunishStatuses, "PunishStatuses", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceCodes))
            {
                request.SourceCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceCodes, "SourceCodes", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserIds))
            {
                request.UserIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserIds, "UserIds", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchPunishRequest",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchPunishRequestResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 处罚记录查询
         *
         * @param request SearchPunishRequestRequest
         * @return SearchPunishRequestResponse
         */
        public SearchPunishRequestResponse SearchPunishRequest(SearchPunishRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchPunishRequestWithOptions(request, runtime);
        }

        /**
         * @summary 处罚记录查询
         *
         * @param request SearchPunishRequestRequest
         * @return SearchPunishRequestResponse
         */
        public async Task<SearchPunishRequestResponse> SearchPunishRequestAsync(SearchPunishRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchPunishRequestWithOptionsAsync(request, runtime);
        }

    }
}
