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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处罚请求异步接口回调</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BusinessResultServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BusinessResultServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处罚请求异步接口回调</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BusinessResultServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BusinessResultServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处罚请求异步接口回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BusinessResultServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// BusinessResultServiceResponse
        /// </returns>
        public BusinessResultServiceResponse BusinessResultService(BusinessResultServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BusinessResultServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处罚请求异步接口回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BusinessResultServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// BusinessResultServiceResponse
        /// </returns>
        public async Task<BusinessResultServiceResponse> BusinessResultServiceAsync(BusinessResultServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BusinessResultServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>协查中心查询任务接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserInvestigationInfoQueryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserInvestigationInfoQueryTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>协查中心查询任务接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserInvestigationInfoQueryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserInvestigationInfoQueryTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>协查中心查询任务接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserInvestigationInfoQueryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserInvestigationInfoQueryTaskResponse
        /// </returns>
        public CreateUserInvestigationInfoQueryTaskResponse CreateUserInvestigationInfoQueryTask(CreateUserInvestigationInfoQueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserInvestigationInfoQueryTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>协查中心查询任务接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserInvestigationInfoQueryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserInvestigationInfoQueryTaskResponse
        /// </returns>
        public async Task<CreateUserInvestigationInfoQueryTaskResponse> CreateUserInvestigationInfoQueryTaskAsync(CreateUserInvestigationInfoQueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserInvestigationInfoQueryTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>反查资源</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// FindInstanceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindInstanceInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>反查资源</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// FindInstanceInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindInstanceInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>反查资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindInstanceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// FindInstanceInfoResponse
        /// </returns>
        public FindInstanceInfoResponse FindInstanceInfo(FindInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindInstanceInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>反查资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindInstanceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// FindInstanceInfoResponse
        /// </returns>
        public async Task<FindInstanceInfoResponse> FindInstanceInfoAsync(FindInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindInstanceInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据用户id查询对应产品下全部可用资产信息接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindUserAvailbleResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindUserAvailbleResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据用户id查询对应产品下全部可用资产信息接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindUserAvailbleResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindUserAvailbleResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据用户id查询对应产品下全部可用资产信息接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindUserAvailbleResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// FindUserAvailbleResourcesResponse
        /// </returns>
        public FindUserAvailbleResourcesResponse FindUserAvailbleResources(FindUserAvailbleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindUserAvailbleResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据用户id查询对应产品下全部可用资产信息接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindUserAvailbleResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// FindUserAvailbleResourcesResponse
        /// </returns>
        public async Task<FindUserAvailbleResourcesResponse> FindUserAvailbleResourcesAsync(FindUserAvailbleResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindUserAvailbleResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询安全事件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityEventDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityEventDetailResponse
        /// </returns>
        public GetSecurityEventDetailResponse GetSecurityEventDetailWithOptions(GetSecurityEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecurityEventDetail",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecurityEventDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询安全事件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityEventDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityEventDetailResponse
        /// </returns>
        public async Task<GetSecurityEventDetailResponse> GetSecurityEventDetailWithOptionsAsync(GetSecurityEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSecurityEventDetail",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSecurityEventDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询安全事件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityEventDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityEventDetailResponse
        /// </returns>
        public GetSecurityEventDetailResponse GetSecurityEventDetail(GetSecurityEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecurityEventDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询安全事件详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSecurityEventDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSecurityEventDetailResponse
        /// </returns>
        public async Task<GetSecurityEventDetailResponse> GetSecurityEventDetailAsync(GetSecurityEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecurityEventDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处罚资源搜索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PunishResourceSearchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PunishResourceSearchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处罚资源搜索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PunishResourceSearchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PunishResourceSearchResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处罚资源搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PunishResourceSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// PunishResourceSearchResponse
        /// </returns>
        public PunishResourceSearchResponse PunishResourceSearch(PunishResourceSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PunishResourceSearchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处罚资源搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PunishResourceSearchRequest
        /// </param>
        /// 
        /// <returns>
        /// PunishResourceSearchResponse
        /// </returns>
        public async Task<PunishResourceSearchResponse> PunishResourceSearchAsync(PunishResourceSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PunishResourceSearchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>记录是否点击链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecordClickLinkActionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecordClickLinkActionResponse
        /// </returns>
        public RecordClickLinkActionResponse RecordClickLinkActionWithOptions(RecordClickLinkActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordClickLinkAction",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordClickLinkActionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>记录是否点击链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecordClickLinkActionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecordClickLinkActionResponse
        /// </returns>
        public async Task<RecordClickLinkActionResponse> RecordClickLinkActionWithOptionsAsync(RecordClickLinkActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordClickLinkAction",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordClickLinkActionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>记录是否点击链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecordClickLinkActionRequest
        /// </param>
        /// 
        /// <returns>
        /// RecordClickLinkActionResponse
        /// </returns>
        public RecordClickLinkActionResponse RecordClickLinkAction(RecordClickLinkActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecordClickLinkActionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>记录是否点击链接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecordClickLinkActionRequest
        /// </param>
        /// 
        /// <returns>
        /// RecordClickLinkActionResponse
        /// </returns>
        public async Task<RecordClickLinkActionResponse> RecordClickLinkActionAsync(RecordClickLinkActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecordClickLinkActionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>风险事件同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RiskEventSyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RiskEventSyncResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>风险事件同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RiskEventSyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RiskEventSyncResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>风险事件同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RiskEventSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// RiskEventSyncResponse
        /// </returns>
        public RiskEventSyncResponse RiskEventSync(RiskEventSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RiskEventSyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>风险事件同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RiskEventSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// RiskEventSyncResponse
        /// </returns>
        public async Task<RiskEventSyncResponse> RiskEventSyncAsync(RiskEventSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RiskEventSyncWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管控事件查询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchPunishEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchPunishEventsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管控事件查询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchPunishEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchPunishEventsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管控事件查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchPunishEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchPunishEventsResponse
        /// </returns>
        public SearchPunishEventsResponse SearchPunishEvents(SearchPunishEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchPunishEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管控事件查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchPunishEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchPunishEventsResponse
        /// </returns>
        public async Task<SearchPunishEventsResponse> SearchPunishEventsAsync(SearchPunishEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchPunishEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管控事件查询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchPunishRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchPunishRecordsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管控事件查询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchPunishRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchPunishRecordsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管控事件查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchPunishRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchPunishRecordsResponse
        /// </returns>
        public SearchPunishRecordsResponse SearchPunishRecords(SearchPunishRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchPunishRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>管控事件查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchPunishRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchPunishRecordsResponse
        /// </returns>
        public async Task<SearchPunishRecordsResponse> SearchPunishRecordsAsync(SearchPunishRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchPunishRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处罚记录查询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchPunishRequestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchPunishRequestResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处罚记录查询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchPunishRequestRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchPunishRequestResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处罚记录查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchPunishRequestRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchPunishRequestResponse
        /// </returns>
        public SearchPunishRequestResponse SearchPunishRequest(SearchPunishRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchPunishRequestWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>处罚记录查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchPunishRequestRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchPunishRequestResponse
        /// </returns>
        public async Task<SearchPunishRequestResponse> SearchPunishRequestAsync(SearchPunishRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchPunishRequestWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新安全事件状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSecurityEventStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecurityEventStatusResponse
        /// </returns>
        public UpdateSecurityEventStatusResponse UpdateSecurityEventStatusWithOptions(UpdateSecurityEventStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecurityEventStatus",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSecurityEventStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新安全事件状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSecurityEventStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecurityEventStatusResponse
        /// </returns>
        public async Task<UpdateSecurityEventStatusResponse> UpdateSecurityEventStatusWithOptionsAsync(UpdateSecurityEventStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecurityEventStatus",
                Version = "2022-08-22",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSecurityEventStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新安全事件状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSecurityEventStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecurityEventStatusResponse
        /// </returns>
        public UpdateSecurityEventStatusResponse UpdateSecurityEventStatus(UpdateSecurityEventStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSecurityEventStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新安全事件状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSecurityEventStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecurityEventStatusResponse
        /// </returns>
        public async Task<UpdateSecurityEventStatusResponse> UpdateSecurityEventStatusAsync(UpdateSecurityEventStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSecurityEventStatusWithOptionsAsync(request, runtime);
        }

    }
}
