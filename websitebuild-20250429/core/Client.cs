// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.WebsiteBuild20250429.Models;

namespace AlibabaCloud.SDK.WebsiteBuild20250429
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("websitebuild", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>提交创建Logo任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogoTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLogoTaskResponse
        /// </returns>
        public CreateLogoTaskResponse CreateLogoTaskWithOptions(CreateLogoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoVersion))
            {
                query["LogoVersion"] = request.LogoVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NegativePrompt))
            {
                query["NegativePrompt"] = request.NegativePrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogoTask",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLogoTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交创建Logo任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogoTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateLogoTaskResponse
        /// </returns>
        public async Task<CreateLogoTaskResponse> CreateLogoTaskWithOptionsAsync(CreateLogoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogoVersion))
            {
                query["LogoVersion"] = request.LogoVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NegativePrompt))
            {
                query["NegativePrompt"] = request.NegativePrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prompt))
            {
                query["Prompt"] = request.Prompt;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogoTask",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLogoTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交创建Logo任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLogoTaskResponse
        /// </returns>
        public CreateLogoTaskResponse CreateLogoTask(CreateLogoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLogoTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交创建Logo任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateLogoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateLogoTaskResponse
        /// </returns>
        public async Task<CreateLogoTaskResponse> CreateLogoTaskAsync(CreateLogoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLogoTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Logo创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreateLogoTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCreateLogoTaskResponse
        /// </returns>
        public GetCreateLogoTaskResponse GetCreateLogoTaskWithOptions(GetCreateLogoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCreateLogoTask",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreateLogoTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Logo创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreateLogoTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCreateLogoTaskResponse
        /// </returns>
        public async Task<GetCreateLogoTaskResponse> GetCreateLogoTaskWithOptionsAsync(GetCreateLogoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCreateLogoTask",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreateLogoTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Logo创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreateLogoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCreateLogoTaskResponse
        /// </returns>
        public GetCreateLogoTaskResponse GetCreateLogoTask(GetCreateLogoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCreateLogoTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Logo创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCreateLogoTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCreateLogoTaskResponse
        /// </returns>
        public async Task<GetCreateLogoTaskResponse> GetCreateLogoTaskAsync(GetCreateLogoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCreateLogoTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppInstanceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAppInstanceForPartnerResponse
        /// </returns>
        public OperateAppInstanceForPartnerResponse OperateAppInstanceForPartnerWithOptions(OperateAppInstanceForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateEvent))
            {
                query["OperateEvent"] = request.OperateEvent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateAppInstanceForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAppInstanceForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppInstanceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAppInstanceForPartnerResponse
        /// </returns>
        public async Task<OperateAppInstanceForPartnerResponse> OperateAppInstanceForPartnerWithOptionsAsync(OperateAppInstanceForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateEvent))
            {
                query["OperateEvent"] = request.OperateEvent;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateAppInstanceForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAppInstanceForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppInstanceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAppInstanceForPartnerResponse
        /// </returns>
        public OperateAppInstanceForPartnerResponse OperateAppInstanceForPartner(OperateAppInstanceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateAppInstanceForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppInstanceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAppInstanceForPartnerResponse
        /// </returns>
        public async Task<OperateAppInstanceForPartnerResponse> OperateAppInstanceForPartnerAsync(OperateAppInstanceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateAppInstanceForPartnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppServiceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAppServiceForPartnerResponse
        /// </returns>
        public OperateAppServiceForPartnerResponse OperateAppServiceForPartnerWithOptions(OperateAppServiceForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateEvent))
            {
                query["OperateEvent"] = request.OperateEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateAppServiceForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAppServiceForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppServiceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateAppServiceForPartnerResponse
        /// </returns>
        public async Task<OperateAppServiceForPartnerResponse> OperateAppServiceForPartnerWithOptionsAsync(OperateAppServiceForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                query["Extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateEvent))
            {
                query["OperateEvent"] = request.OperateEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateAppServiceForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateAppServiceForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppServiceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAppServiceForPartnerResponse
        /// </returns>
        public OperateAppServiceForPartnerResponse OperateAppServiceForPartner(OperateAppServiceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateAppServiceForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴操作应用服务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateAppServiceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateAppServiceForPartnerResponse
        /// </returns>
        public async Task<OperateAppServiceForPartnerResponse> OperateAppServiceForPartnerAsync(OperateAppServiceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateAppServiceForPartnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴同步应用实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SyncAppInstanceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncAppInstanceForPartnerResponse
        /// </returns>
        public SyncAppInstanceForPartnerResponse SyncAppInstanceForPartnerWithOptions(SyncAppInstanceForPartnerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncAppInstanceForPartnerShrinkRequest request = new SyncAppInstanceForPartnerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppInstance))
            {
                request.AppInstanceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppInstance, "AppInstance", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceShrink))
            {
                query["AppInstance"] = request.AppInstanceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceBizId))
            {
                query["SourceBizId"] = request.SourceBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncAppInstanceForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncAppInstanceForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴同步应用实例</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SyncAppInstanceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncAppInstanceForPartnerResponse
        /// </returns>
        public async Task<SyncAppInstanceForPartnerResponse> SyncAppInstanceForPartnerWithOptionsAsync(SyncAppInstanceForPartnerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncAppInstanceForPartnerShrinkRequest request = new SyncAppInstanceForPartnerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppInstance))
            {
                request.AppInstanceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppInstance, "AppInstance", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppInstanceShrink))
            {
                query["AppInstance"] = request.AppInstanceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operator))
            {
                query["Operator"] = request.Operator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceBizId))
            {
                query["SourceBizId"] = request.SourceBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncAppInstanceForPartner",
                Version = "2025-04-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncAppInstanceForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴同步应用实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncAppInstanceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncAppInstanceForPartnerResponse
        /// </returns>
        public SyncAppInstanceForPartnerResponse SyncAppInstanceForPartner(SyncAppInstanceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncAppInstanceForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴同步应用实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncAppInstanceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncAppInstanceForPartnerResponse
        /// </returns>
        public async Task<SyncAppInstanceForPartnerResponse> SyncAppInstanceForPartnerAsync(SyncAppInstanceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncAppInstanceForPartnerWithOptionsAsync(request, runtime);
        }

    }
}
