// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Yunjian20211217.Models;

namespace AlibabaCloud.SDK.Yunjian20211217
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("yunjian", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <param name="request">
        /// CreateDemandPlanRequest
        /// </param>
        /// <param name="headers">
        /// CreateDemandPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDemandPlanResponse
        /// </returns>
        public CreateDemandPlanResponse CreateDemandPlanWithOptions(CreateDemandPlanRequest request, CreateDemandPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCid))
            {
                body["targetCid"] = request.TargetCid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDemandPlan",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/saveUrgentDemandPlanItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDemandPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateDemandPlanRequest
        /// </param>
        /// <param name="headers">
        /// CreateDemandPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDemandPlanResponse
        /// </returns>
        public async Task<CreateDemandPlanResponse> CreateDemandPlanWithOptionsAsync(CreateDemandPlanRequest request, CreateDemandPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCid))
            {
                body["targetCid"] = request.TargetCid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDemandPlan",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/saveUrgentDemandPlanItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDemandPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateDemandPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDemandPlanResponse
        /// </returns>
        public CreateDemandPlanResponse CreateDemandPlan(CreateDemandPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDemandPlanHeaders headers = new CreateDemandPlanHeaders();
            return CreateDemandPlanWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// CreateDemandPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDemandPlanResponse
        /// </returns>
        public async Task<CreateDemandPlanResponse> CreateDemandPlanAsync(CreateDemandPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDemandPlanHeaders headers = new CreateDemandPlanHeaders();
            return await CreateDemandPlanWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建plan2.0版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDemandPlanV2Request
        /// </param>
        /// <param name="headers">
        /// CreateDemandPlanV2Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDemandPlanV2Response
        /// </returns>
        public CreateDemandPlanV2Response CreateDemandPlanV2WithOptions(CreateDemandPlanV2Request request, CreateDemandPlanV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCid))
            {
                body["targetCid"] = request.TargetCid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDemandPlanV2",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/saveDemandPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDemandPlanV2Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建plan2.0版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDemandPlanV2Request
        /// </param>
        /// <param name="headers">
        /// CreateDemandPlanV2Headers
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDemandPlanV2Response
        /// </returns>
        public async Task<CreateDemandPlanV2Response> CreateDemandPlanV2WithOptionsAsync(CreateDemandPlanV2Request request, CreateDemandPlanV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["productType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCid))
            {
                body["targetCid"] = request.TargetCid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDemandPlanV2",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/saveDemandPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDemandPlanV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建plan2.0版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDemandPlanV2Request
        /// </param>
        /// 
        /// <returns>
        /// CreateDemandPlanV2Response
        /// </returns>
        public CreateDemandPlanV2Response CreateDemandPlanV2(CreateDemandPlanV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDemandPlanV2Headers headers = new CreateDemandPlanV2Headers();
            return CreateDemandPlanV2WithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建plan2.0版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDemandPlanV2Request
        /// </param>
        /// 
        /// <returns>
        /// CreateDemandPlanV2Response
        /// </returns>
        public async Task<CreateDemandPlanV2Response> CreateDemandPlanV2Async(CreateDemandPlanV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDemandPlanV2Headers headers = new CreateDemandPlanV2Headers();
            return await CreateDemandPlanV2WithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>紧急需求单ite 删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUrgentDemandItemRequest
        /// </param>
        /// <param name="headers">
        /// DeleteUrgentDemandItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUrgentDemandItemResponse
        /// </returns>
        public DeleteUrgentDemandItemResponse DeleteUrgentDemandItemWithOptions(DeleteUrgentDemandItemRequest request, DeleteUrgentDemandItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                query["modifier"] = request.Modifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUrgentDemandItem",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/deleteUrgentDemandItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUrgentDemandItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>紧急需求单ite 删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUrgentDemandItemRequest
        /// </param>
        /// <param name="headers">
        /// DeleteUrgentDemandItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUrgentDemandItemResponse
        /// </returns>
        public async Task<DeleteUrgentDemandItemResponse> DeleteUrgentDemandItemWithOptionsAsync(DeleteUrgentDemandItemRequest request, DeleteUrgentDemandItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                query["modifier"] = request.Modifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUrgentDemandItem",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/deleteUrgentDemandItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUrgentDemandItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>紧急需求单ite 删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUrgentDemandItemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUrgentDemandItemResponse
        /// </returns>
        public DeleteUrgentDemandItemResponse DeleteUrgentDemandItem(DeleteUrgentDemandItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUrgentDemandItemHeaders headers = new DeleteUrgentDemandItemHeaders();
            return DeleteUrgentDemandItemWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>紧急需求单ite 删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUrgentDemandItemRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUrgentDemandItemResponse
        /// </returns>
        public async Task<DeleteUrgentDemandItemResponse> DeleteUrgentDemandItemAsync(DeleteUrgentDemandItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUrgentDemandItemHeaders headers = new DeleteUrgentDemandItemHeaders();
            return await DeleteUrgentDemandItemWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>紧急需求单plan删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUrgentDemandPlanRequest
        /// </param>
        /// <param name="headers">
        /// DeleteUrgentDemandPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUrgentDemandPlanResponse
        /// </returns>
        public DeleteUrgentDemandPlanResponse DeleteUrgentDemandPlanWithOptions(DeleteUrgentDemandPlanRequest request, DeleteUrgentDemandPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                query["modifier"] = request.Modifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUrgentDemandPlan",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/deleteUrgentDemandPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUrgentDemandPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>紧急需求单plan删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUrgentDemandPlanRequest
        /// </param>
        /// <param name="headers">
        /// DeleteUrgentDemandPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUrgentDemandPlanResponse
        /// </returns>
        public async Task<DeleteUrgentDemandPlanResponse> DeleteUrgentDemandPlanWithOptionsAsync(DeleteUrgentDemandPlanRequest request, DeleteUrgentDemandPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                query["modifier"] = request.Modifier;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUrgentDemandPlan",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/deleteUrgentDemandPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUrgentDemandPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>紧急需求单plan删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUrgentDemandPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUrgentDemandPlanResponse
        /// </returns>
        public DeleteUrgentDemandPlanResponse DeleteUrgentDemandPlan(DeleteUrgentDemandPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUrgentDemandPlanHeaders headers = new DeleteUrgentDemandPlanHeaders();
            return DeleteUrgentDemandPlanWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>紧急需求单plan删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUrgentDemandPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUrgentDemandPlanResponse
        /// </returns>
        public async Task<DeleteUrgentDemandPlanResponse> DeleteUrgentDemandPlanAsync(DeleteUrgentDemandPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteUrgentDemandPlanHeaders headers = new DeleteUrgentDemandPlanHeaders();
            return await DeleteUrgentDemandPlanWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>交付信息同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliveryItemDetailSynRequest
        /// </param>
        /// <param name="headers">
        /// DeliveryItemDetailSynHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeliveryItemDetailSynResponse
        /// </returns>
        public DeliveryItemDetailSynResponse DeliveryItemDetailSynWithOptions(DeliveryItemDetailSynRequest request, DeliveryItemDetailSynHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryItemDetailDTOS))
            {
                body["deliveryItemDetailDTOS"] = request.DeliveryItemDetailDTOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryItemId))
            {
                body["deliveryItemId"] = request.DeliveryItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryPlanId))
            {
                body["deliveryPlanId"] = request.DeliveryPlanId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeliveryItemDetailSyn",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/supply/deliveryItemDataSync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeliveryItemDetailSynResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>交付信息同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliveryItemDetailSynRequest
        /// </param>
        /// <param name="headers">
        /// DeliveryItemDetailSynHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeliveryItemDetailSynResponse
        /// </returns>
        public async Task<DeliveryItemDetailSynResponse> DeliveryItemDetailSynWithOptionsAsync(DeliveryItemDetailSynRequest request, DeliveryItemDetailSynHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryItemDetailDTOS))
            {
                body["deliveryItemDetailDTOS"] = request.DeliveryItemDetailDTOS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryItemId))
            {
                body["deliveryItemId"] = request.DeliveryItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryPlanId))
            {
                body["deliveryPlanId"] = request.DeliveryPlanId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeliveryItemDetailSyn",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/supply/deliveryItemDataSync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeliveryItemDetailSynResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>交付信息同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliveryItemDetailSynRequest
        /// </param>
        /// 
        /// <returns>
        /// DeliveryItemDetailSynResponse
        /// </returns>
        public DeliveryItemDetailSynResponse DeliveryItemDetailSyn(DeliveryItemDetailSynRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliveryItemDetailSynHeaders headers = new DeliveryItemDetailSynHeaders();
            return DeliveryItemDetailSynWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>交付信息同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeliveryItemDetailSynRequest
        /// </param>
        /// 
        /// <returns>
        /// DeliveryItemDetailSynResponse
        /// </returns>
        public async Task<DeliveryItemDetailSynResponse> DeliveryItemDetailSynAsync(DeliveryItemDetailSynRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeliveryItemDetailSynHeaders headers = new DeliveryItemDetailSynHeaders();
            return await DeliveryItemDetailSynWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报备单中报备项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUrgentDemandItemListRequest
        /// </param>
        /// <param name="headers">
        /// GetUrgentDemandItemListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUrgentDemandItemListResponse
        /// </returns>
        public GetUrgentDemandItemListResponse GetUrgentDemandItemListWithOptions(GetUrgentDemandItemListRequest request, GetUrgentDemandItemListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["commodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityTypeCode))
            {
                body["commodityTypeCode"] = request.CommodityTypeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                body["planId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                body["zone"] = request.Zone;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUrgentDemandItemList",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/getUrgentDemandItemList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUrgentDemandItemListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报备单中报备项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUrgentDemandItemListRequest
        /// </param>
        /// <param name="headers">
        /// GetUrgentDemandItemListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUrgentDemandItemListResponse
        /// </returns>
        public async Task<GetUrgentDemandItemListResponse> GetUrgentDemandItemListWithOptionsAsync(GetUrgentDemandItemListRequest request, GetUrgentDemandItemListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["commodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityTypeCode))
            {
                body["commodityTypeCode"] = request.CommodityTypeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                body["planId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                body["zone"] = request.Zone;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUrgentDemandItemList",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/getUrgentDemandItemList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUrgentDemandItemListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报备单中报备项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUrgentDemandItemListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUrgentDemandItemListResponse
        /// </returns>
        public GetUrgentDemandItemListResponse GetUrgentDemandItemList(GetUrgentDemandItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUrgentDemandItemListHeaders headers = new GetUrgentDemandItemListHeaders();
            return GetUrgentDemandItemListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报备单中报备项列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUrgentDemandItemListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUrgentDemandItemListResponse
        /// </returns>
        public async Task<GetUrgentDemandItemListResponse> GetUrgentDemandItemListAsync(GetUrgentDemandItemListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUrgentDemandItemListHeaders headers = new GetUrgentDemandItemListHeaders();
            return await GetUrgentDemandItemListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>getUrgentDemandPlanDetail</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUrgentDemandPlanDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetUrgentDemandPlanDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUrgentDemandPlanDetailResponse
        /// </returns>
        public GetUrgentDemandPlanDetailResponse GetUrgentDemandPlanDetailWithOptions(GetUrgentDemandPlanDetailRequest request, GetUrgentDemandPlanDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                body["planId"] = request.PlanId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUrgentDemandPlanDetail",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/getUrgentDemandPlanDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUrgentDemandPlanDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>getUrgentDemandPlanDetail</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUrgentDemandPlanDetailRequest
        /// </param>
        /// <param name="headers">
        /// GetUrgentDemandPlanDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUrgentDemandPlanDetailResponse
        /// </returns>
        public async Task<GetUrgentDemandPlanDetailResponse> GetUrgentDemandPlanDetailWithOptionsAsync(GetUrgentDemandPlanDetailRequest request, GetUrgentDemandPlanDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                body["planId"] = request.PlanId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUrgentDemandPlanDetail",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/getUrgentDemandPlanDetail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUrgentDemandPlanDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>getUrgentDemandPlanDetail</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUrgentDemandPlanDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUrgentDemandPlanDetailResponse
        /// </returns>
        public GetUrgentDemandPlanDetailResponse GetUrgentDemandPlanDetail(GetUrgentDemandPlanDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUrgentDemandPlanDetailHeaders headers = new GetUrgentDemandPlanDetailHeaders();
            return GetUrgentDemandPlanDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>getUrgentDemandPlanDetail</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUrgentDemandPlanDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUrgentDemandPlanDetailResponse
        /// </returns>
        public async Task<GetUrgentDemandPlanDetailResponse> GetUrgentDemandPlanDetailAsync(GetUrgentDemandPlanDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUrgentDemandPlanDetailHeaders headers = new GetUrgentDemandPlanDetailHeaders();
            return await GetUrgentDemandPlanDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报备单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUrgentDemandPlanListRequest
        /// </param>
        /// <param name="headers">
        /// GetUrgentDemandPlanListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUrgentDemandPlanListResponse
        /// </returns>
        public GetUrgentDemandPlanListResponse GetUrgentDemandPlanListWithOptions(GetUrgentDemandPlanListRequest request, GetUrgentDemandPlanListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanType))
            {
                body["planType"] = request.PlanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUrgentDemandPlanList",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/getUrgentDemandPlanList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUrgentDemandPlanListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报备单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUrgentDemandPlanListRequest
        /// </param>
        /// <param name="headers">
        /// GetUrgentDemandPlanListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUrgentDemandPlanListResponse
        /// </returns>
        public async Task<GetUrgentDemandPlanListResponse> GetUrgentDemandPlanListWithOptionsAsync(GetUrgentDemandPlanListRequest request, GetUrgentDemandPlanListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Current))
            {
                body["current"] = request.Current;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanType))
            {
                body["planType"] = request.PlanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                body["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUrgentDemandPlanList",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/getUrgentDemandPlanList",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUrgentDemandPlanListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报备单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUrgentDemandPlanListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUrgentDemandPlanListResponse
        /// </returns>
        public GetUrgentDemandPlanListResponse GetUrgentDemandPlanList(GetUrgentDemandPlanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUrgentDemandPlanListHeaders headers = new GetUrgentDemandPlanListHeaders();
            return GetUrgentDemandPlanListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询报备单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUrgentDemandPlanListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUrgentDemandPlanListResponse
        /// </returns>
        public async Task<GetUrgentDemandPlanListResponse> GetUrgentDemandPlanListAsync(GetUrgentDemandPlanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUrgentDemandPlanListHeaders headers = new GetUrgentDemandPlanListHeaders();
            return await GetUrgentDemandPlanListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ecs资源方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushResourcePlanRequest
        /// </param>
        /// <param name="headers">
        /// PushResourcePlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushResourcePlanResponse
        /// </returns>
        public PushResourcePlanResponse PushResourcePlanWithOptions(PushResourcePlanRequest request, PushResourcePlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BufferCnt))
            {
                body["bufferCnt"] = request.BufferCnt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DemandCount))
            {
                body["demandCount"] = request.DemandCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DemandId))
            {
                body["demandId"] = request.DemandId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodList))
            {
                body["methodList"] = request.MethodList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireCnt))
            {
                body["requireCnt"] = request.RequireCnt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDemandId))
            {
                body["subDemandId"] = request.SubDemandId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushResourcePlan",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/supply/resourcePlan/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushResourcePlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ecs资源方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushResourcePlanRequest
        /// </param>
        /// <param name="headers">
        /// PushResourcePlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushResourcePlanResponse
        /// </returns>
        public async Task<PushResourcePlanResponse> PushResourcePlanWithOptionsAsync(PushResourcePlanRequest request, PushResourcePlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BufferCnt))
            {
                body["bufferCnt"] = request.BufferCnt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DemandCount))
            {
                body["demandCount"] = request.DemandCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DemandId))
            {
                body["demandId"] = request.DemandId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodList))
            {
                body["methodList"] = request.MethodList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireCnt))
            {
                body["requireCnt"] = request.RequireCnt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubDemandId))
            {
                body["subDemandId"] = request.SubDemandId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushResourcePlan",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/supply/resourcePlan/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushResourcePlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ecs资源方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushResourcePlanRequest
        /// </param>
        /// 
        /// <returns>
        /// PushResourcePlanResponse
        /// </returns>
        public PushResourcePlanResponse PushResourcePlan(PushResourcePlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushResourcePlanHeaders headers = new PushResourcePlanHeaders();
            return PushResourcePlanWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ecs资源方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushResourcePlanRequest
        /// </param>
        /// 
        /// <returns>
        /// PushResourcePlanResponse
        /// </returns>
        public async Task<PushResourcePlanResponse> PushResourcePlanAsync(PushResourcePlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushResourcePlanHeaders headers = new PushResourcePlanHeaders();
            return await PushResourcePlanWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询accountId下所有存在交付状态（包括部分）的报备数据, 以及开通数据情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeliveredSupplyItemsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeliveredSupplyItemsResponse
        /// </returns>
        public QueryDeliveredSupplyItemsResponse QueryDeliveredSupplyItemsWithOptions(QueryDeliveredSupplyItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityTypeCode))
            {
                query["commodityTypeCode"] = request.CommodityTypeCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeliveredSupplyItems",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/supply/queryDeliveredSupplyItems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<QueryDeliveredSupplyItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询accountId下所有存在交付状态（包括部分）的报备数据, 以及开通数据情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeliveredSupplyItemsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDeliveredSupplyItemsResponse
        /// </returns>
        public async Task<QueryDeliveredSupplyItemsResponse> QueryDeliveredSupplyItemsWithOptionsAsync(QueryDeliveredSupplyItemsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityTypeCode))
            {
                query["commodityTypeCode"] = request.CommodityTypeCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDeliveredSupplyItems",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/supply/queryDeliveredSupplyItems",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<QueryDeliveredSupplyItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询accountId下所有存在交付状态（包括部分）的报备数据, 以及开通数据情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeliveredSupplyItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeliveredSupplyItemsResponse
        /// </returns>
        public QueryDeliveredSupplyItemsResponse QueryDeliveredSupplyItems(QueryDeliveredSupplyItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryDeliveredSupplyItemsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询accountId下所有存在交付状态（包括部分）的报备数据, 以及开通数据情况</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDeliveredSupplyItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDeliveredSupplyItemsResponse
        /// </returns>
        public async Task<QueryDeliveredSupplyItemsResponse> QueryDeliveredSupplyItemsAsync(QueryDeliveredSupplyItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryDeliveredSupplyItemsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账单预算数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPeriodBudgetBillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPeriodBudgetBillResponse
        /// </returns>
        public QueryPeriodBudgetBillResponse QueryPeriodBudgetBillWithOptions(QueryPeriodBudgetBillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectIds))
            {
                query["objectIds"] = request.ObjectIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["period"] = request.Period;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPeriodBudgetBill",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/annual/budget/queryPeriodBudgetBill",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPeriodBudgetBillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账单预算数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPeriodBudgetBillRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPeriodBudgetBillResponse
        /// </returns>
        public async Task<QueryPeriodBudgetBillResponse> QueryPeriodBudgetBillWithOptionsAsync(QueryPeriodBudgetBillRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectIds))
            {
                query["objectIds"] = request.ObjectIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["objectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["period"] = request.Period;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPeriodBudgetBill",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/annual/budget/queryPeriodBudgetBill",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPeriodBudgetBillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账单预算数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPeriodBudgetBillRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPeriodBudgetBillResponse
        /// </returns>
        public QueryPeriodBudgetBillResponse QueryPeriodBudgetBill(QueryPeriodBudgetBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryPeriodBudgetBillWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询账单预算数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPeriodBudgetBillRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPeriodBudgetBillResponse
        /// </returns>
        public async Task<QueryPeriodBudgetBillResponse> QueryPeriodBudgetBillAsync(QueryPeriodBudgetBillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryPeriodBudgetBillWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>紧急需求单item新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveUrgentDemandItemRequest
        /// </param>
        /// <param name="headers">
        /// SaveUrgentDemandItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveUrgentDemandItemResponse
        /// </returns>
        public SaveUrgentDemandItemResponse SaveUrgentDemandItemWithOptions(SaveUrgentDemandItemRequest request, SaveUrgentDemandItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTime))
            {
                body["effectTime"] = request.EffectTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                body["modifier"] = request.Modifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["networkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayDuration))
            {
                body["payDuration"] = request.PayDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayDurationUnit))
            {
                body["payDurationUnit"] = request.PayDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                body["payType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                body["planId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrgentDemandEbsRequest))
            {
                body["urgentDemandEbsRequest"] = request.UrgentDemandEbsRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrgentDemandEcsRequest))
            {
                body["urgentDemandEcsRequest"] = request.UrgentDemandEcsRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                body["zone"] = request.Zone;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveUrgentDemandItem",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/saveUrgentDemandItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveUrgentDemandItemResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>紧急需求单item新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveUrgentDemandItemRequest
        /// </param>
        /// <param name="headers">
        /// SaveUrgentDemandItemHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveUrgentDemandItemResponse
        /// </returns>
        public async Task<SaveUrgentDemandItemResponse> SaveUrgentDemandItemWithOptionsAsync(SaveUrgentDemandItemRequest request, SaveUrgentDemandItemHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Creator))
            {
                body["creator"] = request.Creator;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectTime))
            {
                body["effectTime"] = request.EffectTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Modifier))
            {
                body["modifier"] = request.Modifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                body["networkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayDuration))
            {
                body["payDuration"] = request.PayDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayDurationUnit))
            {
                body["payDurationUnit"] = request.PayDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayType))
            {
                body["payType"] = request.PayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                body["planId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrgentDemandEbsRequest))
            {
                body["urgentDemandEbsRequest"] = request.UrgentDemandEbsRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UrgentDemandEcsRequest))
            {
                body["urgentDemandEcsRequest"] = request.UrgentDemandEcsRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                body["zone"] = request.Zone;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveUrgentDemandItem",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/saveUrgentDemandItem",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveUrgentDemandItemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>紧急需求单item新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveUrgentDemandItemRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveUrgentDemandItemResponse
        /// </returns>
        public SaveUrgentDemandItemResponse SaveUrgentDemandItem(SaveUrgentDemandItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveUrgentDemandItemHeaders headers = new SaveUrgentDemandItemHeaders();
            return SaveUrgentDemandItemWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>紧急需求单item新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveUrgentDemandItemRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveUrgentDemandItemResponse
        /// </returns>
        public async Task<SaveUrgentDemandItemResponse> SaveUrgentDemandItemAsync(SaveUrgentDemandItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveUrgentDemandItemHeaders headers = new SaveUrgentDemandItemHeaders();
            return await SaveUrgentDemandItemWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>submitUrgentDemandPlan</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitUrgentDemandPlanRequest
        /// </param>
        /// <param name="headers">
        /// SubmitUrgentDemandPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitUrgentDemandPlanResponse
        /// </returns>
        public SubmitUrgentDemandPlanResponse SubmitUrgentDemandPlanWithOptions(SubmitUrgentDemandPlanRequest request, SubmitUrgentDemandPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["planId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitUrgentDemandPlan",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/submitUrgentDemandPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitUrgentDemandPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>submitUrgentDemandPlan</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitUrgentDemandPlanRequest
        /// </param>
        /// <param name="headers">
        /// SubmitUrgentDemandPlanHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitUrgentDemandPlanResponse
        /// </returns>
        public async Task<SubmitUrgentDemandPlanResponse> SubmitUrgentDemandPlanWithOptionsAsync(SubmitUrgentDemandPlanRequest request, SubmitUrgentDemandPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["planId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.YunUserId))
            {
                realHeaders["Yun-User-Id"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.YunUserId);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitUrgentDemandPlan",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/api/demand/urgent/submitUrgentDemandPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitUrgentDemandPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>submitUrgentDemandPlan</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitUrgentDemandPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitUrgentDemandPlanResponse
        /// </returns>
        public SubmitUrgentDemandPlanResponse SubmitUrgentDemandPlan(SubmitUrgentDemandPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitUrgentDemandPlanHeaders headers = new SubmitUrgentDemandPlanHeaders();
            return SubmitUrgentDemandPlanWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>submitUrgentDemandPlan</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitUrgentDemandPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitUrgentDemandPlanResponse
        /// </returns>
        public async Task<SubmitUrgentDemandPlanResponse> SubmitUrgentDemandPlanAsync(SubmitUrgentDemandPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SubmitUrgentDemandPlanHeaders headers = new SubmitUrgentDemandPlanHeaders();
            return await SubmitUrgentDemandPlanWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云产品交付决策反馈回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AcceptFulfillmentDecisionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcceptFulfillmentDecisionResponse
        /// </returns>
        public AcceptFulfillmentDecisionResponse AcceptFulfillmentDecisionWithOptions(AcceptFulfillmentDecisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecisionConclusion))
            {
                body["DecisionConclusion"] = request.DecisionConclusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecisionType))
            {
                body["DecisionType"] = request.DecisionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "acceptFulfillmentDecision",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/acceptFulfillmentDecision",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptFulfillmentDecisionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云产品交付决策反馈回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AcceptFulfillmentDecisionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcceptFulfillmentDecisionResponse
        /// </returns>
        public async Task<AcceptFulfillmentDecisionResponse> AcceptFulfillmentDecisionWithOptionsAsync(AcceptFulfillmentDecisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecisionConclusion))
            {
                body["DecisionConclusion"] = request.DecisionConclusion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecisionType))
            {
                body["DecisionType"] = request.DecisionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["OrderId"] = request.OrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "acceptFulfillmentDecision",
                Version = "2021-12-17",
                Protocol = "HTTPS",
                Pathname = "/acceptFulfillmentDecision",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptFulfillmentDecisionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云产品交付决策反馈回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AcceptFulfillmentDecisionRequest
        /// </param>
        /// 
        /// <returns>
        /// AcceptFulfillmentDecisionResponse
        /// </returns>
        public AcceptFulfillmentDecisionResponse AcceptFulfillmentDecision(AcceptFulfillmentDecisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AcceptFulfillmentDecisionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云产品交付决策反馈回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AcceptFulfillmentDecisionRequest
        /// </param>
        /// 
        /// <returns>
        /// AcceptFulfillmentDecisionResponse
        /// </returns>
        public async Task<AcceptFulfillmentDecisionResponse> AcceptFulfillmentDecisionAsync(AcceptFulfillmentDecisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AcceptFulfillmentDecisionWithOptionsAsync(request, headers, runtime);
        }

    }
}
