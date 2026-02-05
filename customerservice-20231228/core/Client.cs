// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CustomerService20231228.Models;

namespace AlibabaCloud.SDK.CustomerService20231228
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("customerservice", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>获取我的企业支持计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseSupportPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseSupportPlanResponse
        /// </returns>
        public ListEnterpriseSupportPlanResponse ListEnterpriseSupportPlanWithOptions(ListEnterpriseSupportPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnterpriseSupportPlan",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/enterpriseSupport/listEnterpriseSupportPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseSupportPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取我的企业支持计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseSupportPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseSupportPlanResponse
        /// </returns>
        public async Task<ListEnterpriseSupportPlanResponse> ListEnterpriseSupportPlanWithOptionsAsync(ListEnterpriseSupportPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnterpriseSupportPlan",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/enterpriseSupport/listEnterpriseSupportPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseSupportPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取我的企业支持计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseSupportPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseSupportPlanResponse
        /// </returns>
        public ListEnterpriseSupportPlanResponse ListEnterpriseSupportPlan(ListEnterpriseSupportPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnterpriseSupportPlanWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取我的企业支持计划</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseSupportPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseSupportPlanResponse
        /// </returns>
        public async Task<ListEnterpriseSupportPlanResponse> ListEnterpriseSupportPlanAsync(ListEnterpriseSupportPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnterpriseSupportPlanWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取我的企业支持计划(下拉)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseSupportPlanSimpleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseSupportPlanSimpleResponse
        /// </returns>
        public ListEnterpriseSupportPlanSimpleResponse ListEnterpriseSupportPlanSimpleWithOptions(ListEnterpriseSupportPlanSimpleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnterpriseSupportPlanSimple",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/enterpriseSupport/listEnterpriseSupportPlanSimple",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseSupportPlanSimpleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取我的企业支持计划(下拉)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseSupportPlanSimpleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseSupportPlanSimpleResponse
        /// </returns>
        public async Task<ListEnterpriseSupportPlanSimpleResponse> ListEnterpriseSupportPlanSimpleWithOptionsAsync(ListEnterpriseSupportPlanSimpleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnterpriseSupportPlanSimple",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/enterpriseSupport/listEnterpriseSupportPlanSimple",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnterpriseSupportPlanSimpleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取我的企业支持计划(下拉)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseSupportPlanSimpleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseSupportPlanSimpleResponse
        /// </returns>
        public ListEnterpriseSupportPlanSimpleResponse ListEnterpriseSupportPlanSimple(ListEnterpriseSupportPlanSimpleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnterpriseSupportPlanSimpleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取我的企业支持计划(下拉)</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnterpriseSupportPlanSimpleRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnterpriseSupportPlanSimpleResponse
        /// </returns>
        public async Task<ListEnterpriseSupportPlanSimpleResponse> ListEnterpriseSupportPlanSimpleAsync(ListEnterpriseSupportPlanSimpleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnterpriseSupportPlanSimpleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专家服务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceApplyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceApplyResponse
        /// </returns>
        public ListServiceApplyResponse ListServiceApplyWithOptions(ListServiceApplyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyType))
            {
                body["applyType"] = request.ApplyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceApply",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/expert/service/listServiceApply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceApplyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专家服务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceApplyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceApplyResponse
        /// </returns>
        public async Task<ListServiceApplyResponse> ListServiceApplyWithOptionsAsync(ListServiceApplyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplyType))
            {
                body["applyType"] = request.ApplyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceApply",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/expert/service/listServiceApply",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceApplyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专家服务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceApplyResponse
        /// </returns>
        public ListServiceApplyResponse ListServiceApply(ListServiceApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceApplyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取专家服务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceApplyResponse
        /// </returns>
        public async Task<ListServiceApplyResponse> ListServiceApplyAsync(ListServiceApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceApplyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过UID分页获取云企任务单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListYunQiTaskByUidRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListYunQiTaskByUidResponse
        /// </returns>
        public ListYunQiTaskByUidResponse ListYunQiTaskByUidWithOptions(ListYunQiTaskByUidRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                body["createTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                body["createTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeOrderApplyCodes))
            {
                body["freeOrderApplyCodes"] = request.FreeOrderApplyCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeOrderApplyIds))
            {
                body["freeOrderApplyIds"] = request.FreeOrderApplyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIds))
            {
                body["orderIds"] = request.OrderIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                body["statusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListYunQiTaskByUid",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/record/listYunQiTaskByUid",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListYunQiTaskByUidResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过UID分页获取云企任务单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListYunQiTaskByUidRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListYunQiTaskByUidResponse
        /// </returns>
        public async Task<ListYunQiTaskByUidResponse> ListYunQiTaskByUidWithOptionsAsync(ListYunQiTaskByUidRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeEnd))
            {
                body["createTimeEnd"] = request.CreateTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeStart))
            {
                body["createTimeStart"] = request.CreateTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeOrderApplyCodes))
            {
                body["freeOrderApplyCodes"] = request.FreeOrderApplyCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FreeOrderApplyIds))
            {
                body["freeOrderApplyIds"] = request.FreeOrderApplyIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderIds))
            {
                body["orderIds"] = request.OrderIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                body["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                body["statusList"] = request.StatusList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListYunQiTaskByUid",
                Version = "2023-12-28",
                Protocol = "HTTPS",
                Pathname = "/customerWorkbench/pop/api/record/listYunQiTaskByUid",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListYunQiTaskByUidResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过UID分页获取云企任务单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListYunQiTaskByUidRequest
        /// </param>
        /// 
        /// <returns>
        /// ListYunQiTaskByUidResponse
        /// </returns>
        public ListYunQiTaskByUidResponse ListYunQiTaskByUid(ListYunQiTaskByUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListYunQiTaskByUidWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过UID分页获取云企任务单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListYunQiTaskByUidRequest
        /// </param>
        /// 
        /// <returns>
        /// ListYunQiTaskByUidResponse
        /// </returns>
        public async Task<ListYunQiTaskByUidResponse> ListYunQiTaskByUidAsync(ListYunQiTaskByUidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListYunQiTaskByUidWithOptionsAsync(request, headers, runtime);
        }

    }
}
