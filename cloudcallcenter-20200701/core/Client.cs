// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CloudCallCenter20200701.Models;

namespace AlibabaCloud.SDK.CloudCallCenter20200701
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudcallcenter", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>abort campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortCampaignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbortCampaignResponse
        /// </returns>
        public AbortCampaignResponse AbortCampaignWithOptions(AbortCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortCampaignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>abort campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortCampaignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbortCampaignResponse
        /// </returns>
        public async Task<AbortCampaignResponse> AbortCampaignWithOptionsAsync(AbortCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortCampaignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>abort campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortCampaignRequest
        /// </param>
        /// 
        /// <returns>
        /// AbortCampaignResponse
        /// </returns>
        public AbortCampaignResponse AbortCampaign(AbortCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbortCampaignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>abort campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortCampaignRequest
        /// </param>
        /// 
        /// <returns>
        /// AbortCampaignResponse
        /// </returns>
        public async Task<AbortCampaignResponse> AbortCampaignAsync(AbortCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbortCampaignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>abort cases</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AbortCasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbortCasesResponse
        /// </returns>
        public AbortCasesResponse AbortCasesWithOptions(AbortCasesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AbortCasesShrinkRequest request = new AbortCasesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhoneNumberList))
            {
                request.PhoneNumberListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhoneNumberList, "PhoneNumberList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberListShrink))
            {
                query["PhoneNumberList"] = request.PhoneNumberListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortCases",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortCasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>abort cases</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AbortCasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbortCasesResponse
        /// </returns>
        public async Task<AbortCasesResponse> AbortCasesWithOptionsAsync(AbortCasesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AbortCasesShrinkRequest request = new AbortCasesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PhoneNumberList))
            {
                request.PhoneNumberListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PhoneNumberList, "PhoneNumberList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberListShrink))
            {
                query["PhoneNumberList"] = request.PhoneNumberListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortCases",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortCasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>abort cases</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortCasesRequest
        /// </param>
        /// 
        /// <returns>
        /// AbortCasesResponse
        /// </returns>
        public AbortCasesResponse AbortCases(AbortCasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbortCasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>abort cases</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortCasesRequest
        /// </param>
        /// 
        /// <returns>
        /// AbortCasesResponse
        /// </returns>
        public async Task<AbortCasesResponse> AbortCasesAsync(AbortCasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbortCasesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CheckDemoInstanceExistsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDemoInstanceExistsResponse
        /// </returns>
        public CheckDemoInstanceExistsResponse CheckDemoInstanceExistsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDemoInstanceExists",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDemoInstanceExistsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CheckDemoInstanceExistsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDemoInstanceExistsResponse
        /// </returns>
        public async Task<CheckDemoInstanceExistsResponse> CheckDemoInstanceExistsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDemoInstanceExists",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDemoInstanceExistsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// CheckDemoInstanceExistsResponse
        /// </returns>
        public CheckDemoInstanceExistsResponse CheckDemoInstanceExists()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDemoInstanceExistsWithOptions(runtime);
        }

        /// <returns>
        /// CheckDemoInstanceExistsResponse
        /// </returns>
        public async Task<CheckDemoInstanceExistsResponse> CheckDemoInstanceExistsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDemoInstanceExistsWithOptionsAsync(runtime);
        }

        /// <param name="request">
        /// CheckMQRoleAssumptionAuthorityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckMQRoleAssumptionAuthorityResponse
        /// </returns>
        public CheckMQRoleAssumptionAuthorityResponse CheckMQRoleAssumptionAuthorityWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckMQRoleAssumptionAuthority",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckMQRoleAssumptionAuthorityResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CheckMQRoleAssumptionAuthorityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckMQRoleAssumptionAuthorityResponse
        /// </returns>
        public async Task<CheckMQRoleAssumptionAuthorityResponse> CheckMQRoleAssumptionAuthorityWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckMQRoleAssumptionAuthority",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckMQRoleAssumptionAuthorityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// CheckMQRoleAssumptionAuthorityResponse
        /// </returns>
        public CheckMQRoleAssumptionAuthorityResponse CheckMQRoleAssumptionAuthority()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMQRoleAssumptionAuthorityWithOptions(runtime);
        }

        /// <returns>
        /// CheckMQRoleAssumptionAuthorityResponse
        /// </returns>
        public async Task<CheckMQRoleAssumptionAuthorityResponse> CheckMQRoleAssumptionAuthorityAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMQRoleAssumptionAuthorityWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>create campaign</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCampaignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCampaignResponse
        /// </returns>
        public CreateCampaignResponse CreateCampaignWithOptions(CreateCampaignRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCampaignShrinkRequest request = new CreateCampaignShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CaseList))
            {
                request.CaseListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CaseList, "CaseList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NumberList))
            {
                request.NumberListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NumberList, "NumberList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallableTime))
            {
                query["CallableTime"] = request.CallableTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseFileKey))
            {
                query["CaseFileKey"] = request.CaseFileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseListShrink))
            {
                query["CaseList"] = request.CaseListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactFlowId))
            {
                query["ContactFlowId"] = request.ContactFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutingUntilTimeout))
            {
                query["ExecutingUntilTimeout"] = request.ExecutingUntilTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsParameters))
            {
                query["FlashSmsParameters"] = request.FlashSmsParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstGroupId))
            {
                query["InstGroupId"] = request.InstGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttemptCount))
            {
                query["MaxAttemptCount"] = request.MaxAttemptCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAttemptInterval))
            {
                query["MinAttemptInterval"] = request.MinAttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberListShrink))
            {
                query["NumberList"] = request.NumberListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueId))
            {
                query["QueueId"] = request.QueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Simulation))
            {
                query["Simulation"] = request.Simulation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimulationParameters))
            {
                query["SimulationParameters"] = request.SimulationParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyParameters))
            {
                query["StrategyParameters"] = request.StrategyParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyType))
            {
                query["StrategyType"] = request.StrategyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCampaignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>create campaign</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCampaignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCampaignResponse
        /// </returns>
        public async Task<CreateCampaignResponse> CreateCampaignWithOptionsAsync(CreateCampaignRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCampaignShrinkRequest request = new CreateCampaignShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CaseList))
            {
                request.CaseListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CaseList, "CaseList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NumberList))
            {
                request.NumberListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NumberList, "NumberList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallableTime))
            {
                query["CallableTime"] = request.CallableTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseFileKey))
            {
                query["CaseFileKey"] = request.CaseFileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CaseListShrink))
            {
                query["CaseList"] = request.CaseListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactFlowId))
            {
                query["ContactFlowId"] = request.ContactFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecutingUntilTimeout))
            {
                query["ExecutingUntilTimeout"] = request.ExecutingUntilTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashSmsParameters))
            {
                query["FlashSmsParameters"] = request.FlashSmsParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstGroupId))
            {
                query["InstGroupId"] = request.InstGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxAttemptCount))
            {
                query["MaxAttemptCount"] = request.MaxAttemptCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinAttemptInterval))
            {
                query["MinAttemptInterval"] = request.MinAttemptInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumberListShrink))
            {
                query["NumberList"] = request.NumberListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueId))
            {
                query["QueueId"] = request.QueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Simulation))
            {
                query["Simulation"] = request.Simulation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimulationParameters))
            {
                query["SimulationParameters"] = request.SimulationParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyParameters))
            {
                query["StrategyParameters"] = request.StrategyParameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrategyType))
            {
                query["StrategyType"] = request.StrategyType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCampaignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>create campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCampaignRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCampaignResponse
        /// </returns>
        public CreateCampaignResponse CreateCampaign(CreateCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCampaignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>create campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCampaignRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCampaignResponse
        /// </returns>
        public async Task<CreateCampaignResponse> CreateCampaignAsync(CreateCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCampaignWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateChatMediaUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatMediaUrlResponse
        /// </returns>
        public CreateChatMediaUrlResponse CreateChatMediaUrlWithOptions(CreateChatMediaUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MimeType))
            {
                body["MimeType"] = request.MimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatMediaUrl",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatMediaUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateChatMediaUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatMediaUrlResponse
        /// </returns>
        public async Task<CreateChatMediaUrlResponse> CreateChatMediaUrlWithOptionsAsync(CreateChatMediaUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MimeType))
            {
                body["MimeType"] = request.MimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChatMediaUrl",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatMediaUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateChatMediaUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatMediaUrlResponse
        /// </returns>
        public CreateChatMediaUrlResponse CreateChatMediaUrl(CreateChatMediaUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChatMediaUrlWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateChatMediaUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatMediaUrlResponse
        /// </returns>
        public async Task<CreateChatMediaUrlResponse> CreateChatMediaUrlAsync(CreateChatMediaUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChatMediaUrlWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateCorpNumberGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCorpNumberGroupResponse
        /// </returns>
        public CreateCorpNumberGroupResponse CreateCorpNumberGroupWithOptions(CreateCorpNumberGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCorpNumberGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCorpNumberGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateCorpNumberGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCorpNumberGroupResponse
        /// </returns>
        public async Task<CreateCorpNumberGroupResponse> CreateCorpNumberGroupWithOptionsAsync(CreateCorpNumberGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCorpNumberGroup",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCorpNumberGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateCorpNumberGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCorpNumberGroupResponse
        /// </returns>
        public CreateCorpNumberGroupResponse CreateCorpNumberGroup(CreateCorpNumberGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCorpNumberGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateCorpNumberGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCorpNumberGroupResponse
        /// </returns>
        public async Task<CreateCorpNumberGroupResponse> CreateCorpNumberGroupAsync(CreateCorpNumberGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCorpNumberGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateDemoInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDemoInstanceResponse
        /// </returns>
        public CreateDemoInstanceResponse CreateDemoInstanceWithOptions(CreateDemoInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundCallWhitelist))
            {
                query["OutboundCallWhitelist"] = request.OutboundCallWhitelist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDemoInstance",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDemoInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateDemoInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDemoInstanceResponse
        /// </returns>
        public async Task<CreateDemoInstanceResponse> CreateDemoInstanceWithOptionsAsync(CreateDemoInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutboundCallWhitelist))
            {
                query["OutboundCallWhitelist"] = request.OutboundCallWhitelist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDemoInstance",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDemoInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateDemoInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDemoInstanceResponse
        /// </returns>
        public CreateDemoInstanceResponse CreateDemoInstance(CreateDemoInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDemoInstanceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateDemoInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDemoInstanceResponse
        /// </returns>
        public async Task<CreateDemoInstanceResponse> CreateDemoInstanceAsync(CreateDemoInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDemoInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetAccessChannelOfStaging</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessChannelOfStagingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessChannelOfStagingResponse
        /// </returns>
        public GetAccessChannelOfStagingResponse GetAccessChannelOfStagingWithOptions(GetAccessChannelOfStagingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessChannelOfStaging",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessChannelOfStagingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetAccessChannelOfStaging</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessChannelOfStagingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAccessChannelOfStagingResponse
        /// </returns>
        public async Task<GetAccessChannelOfStagingResponse> GetAccessChannelOfStagingWithOptionsAsync(GetAccessChannelOfStagingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccessChannelOfStaging",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccessChannelOfStagingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetAccessChannelOfStaging</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessChannelOfStagingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessChannelOfStagingResponse
        /// </returns>
        public GetAccessChannelOfStagingResponse GetAccessChannelOfStaging(GetAccessChannelOfStagingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessChannelOfStagingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetAccessChannelOfStaging</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAccessChannelOfStagingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAccessChannelOfStagingResponse
        /// </returns>
        public async Task<GetAccessChannelOfStagingResponse> GetAccessChannelOfStagingAsync(GetAccessChannelOfStagingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessChannelOfStagingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼活动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCampaignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCampaignResponse
        /// </returns>
        public GetCampaignResponse GetCampaignWithOptions(GetCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCampaignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼活动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCampaignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCampaignResponse
        /// </returns>
        public async Task<GetCampaignResponse> GetCampaignWithOptionsAsync(GetCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCampaignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼活动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCampaignRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCampaignResponse
        /// </returns>
        public GetCampaignResponse GetCampaign(GetCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCampaignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼活动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCampaignRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCampaignResponse
        /// </returns>
        public async Task<GetCampaignResponse> GetCampaignAsync(GetCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCampaignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetDocument</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentResponse
        /// </returns>
        public GetDocumentResponse GetDocumentWithOptions(GetDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                body["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaId))
            {
                body["SchemaId"] = request.SchemaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocument",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetDocument</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentResponse
        /// </returns>
        public async Task<GetDocumentResponse> GetDocumentWithOptionsAsync(GetDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                body["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaId))
            {
                body["SchemaId"] = request.SchemaId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDocument",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetDocument</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentResponse
        /// </returns>
        public GetDocumentResponse GetDocument(GetDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocumentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetDocument</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDocumentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDocumentResponse
        /// </returns>
        public async Task<GetDocumentResponse> GetDocumentAsync(GetDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocumentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼活动历史报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoricalCampaignReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHistoricalCampaignReportResponse
        /// </returns>
        public GetHistoricalCampaignReportResponse GetHistoricalCampaignReportWithOptions(GetHistoricalCampaignReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistoricalCampaignReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoricalCampaignReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼活动历史报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoricalCampaignReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetHistoricalCampaignReportResponse
        /// </returns>
        public async Task<GetHistoricalCampaignReportResponse> GetHistoricalCampaignReportWithOptionsAsync(GetHistoricalCampaignReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistoricalCampaignReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHistoricalCampaignReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼活动历史报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoricalCampaignReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHistoricalCampaignReportResponse
        /// </returns>
        public GetHistoricalCampaignReportResponse GetHistoricalCampaignReport(GetHistoricalCampaignReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHistoricalCampaignReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼活动历史报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetHistoricalCampaignReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetHistoricalCampaignReportResponse
        /// </returns>
        public async Task<GetHistoricalCampaignReportResponse> GetHistoricalCampaignReportAsync(GetHistoricalCampaignReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHistoricalCampaignReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据aliyunuid获取实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceIdsByAliyunUidV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceIdsByAliyunUidV2Response
        /// </returns>
        public GetInstanceIdsByAliyunUidV2Response GetInstanceIdsByAliyunUidV2WithOptions(GetInstanceIdsByAliyunUidV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUid))
            {
                query["AliyunUid"] = request.AliyunUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceIdsByAliyunUidV2",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceIdsByAliyunUidV2Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据aliyunuid获取实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceIdsByAliyunUidV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceIdsByAliyunUidV2Response
        /// </returns>
        public async Task<GetInstanceIdsByAliyunUidV2Response> GetInstanceIdsByAliyunUidV2WithOptionsAsync(GetInstanceIdsByAliyunUidV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunUid))
            {
                query["AliyunUid"] = request.AliyunUid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceIdsByAliyunUidV2",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceIdsByAliyunUidV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据aliyunuid获取实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceIdsByAliyunUidV2Request
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceIdsByAliyunUidV2Response
        /// </returns>
        public GetInstanceIdsByAliyunUidV2Response GetInstanceIdsByAliyunUidV2(GetInstanceIdsByAliyunUidV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceIdsByAliyunUidV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据aliyunuid获取实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceIdsByAliyunUidV2Request
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceIdsByAliyunUidV2Response
        /// </returns>
        public async Task<GetInstanceIdsByAliyunUidV2Response> GetInstanceIdsByAliyunUidV2Async(GetInstanceIdsByAliyunUidV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceIdsByAliyunUidV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼实时状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealtimeCampaignStatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRealtimeCampaignStatsResponse
        /// </returns>
        public GetRealtimeCampaignStatsResponse GetRealtimeCampaignStatsWithOptions(GetRealtimeCampaignStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRealtimeCampaignStats",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealtimeCampaignStatsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼实时状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealtimeCampaignStatsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRealtimeCampaignStatsResponse
        /// </returns>
        public async Task<GetRealtimeCampaignStatsResponse> GetRealtimeCampaignStatsWithOptionsAsync(GetRealtimeCampaignStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRealtimeCampaignStats",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRealtimeCampaignStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼实时状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealtimeCampaignStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRealtimeCampaignStatsResponse
        /// </returns>
        public GetRealtimeCampaignStatsResponse GetRealtimeCampaignStats(GetRealtimeCampaignStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRealtimeCampaignStatsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼实时状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRealtimeCampaignStatsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRealtimeCampaignStatsResponse
        /// </returns>
        public async Task<GetRealtimeCampaignStatsResponse> GetRealtimeCampaignStatsAsync(GetRealtimeCampaignStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRealtimeCampaignStatsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ImportAdminsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportAdminsResponse
        /// </returns>
        public ImportAdminsResponse ImportAdminsWithOptions(ImportAdminsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamIdList))
            {
                query["RamIdList"] = request.RamIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportAdmins",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportAdminsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ImportAdminsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportAdminsResponse
        /// </returns>
        public async Task<ImportAdminsResponse> ImportAdminsWithOptionsAsync(ImportAdminsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamIdList))
            {
                query["RamIdList"] = request.RamIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImportAdmins",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImportAdminsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ImportAdminsRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportAdminsResponse
        /// </returns>
        public ImportAdminsResponse ImportAdmins(ImportAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportAdminsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ImportAdminsRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportAdminsResponse
        /// </returns>
        public async Task<ImportAdminsResponse> ImportAdminsAsync(ImportAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportAdminsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// IssueSoftphoneCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IssueSoftphoneCommandResponse
        /// </returns>
        public IssueSoftphoneCommandResponse IssueSoftphoneCommandWithOptions(IssueSoftphoneCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IssueSoftphoneCommand",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IssueSoftphoneCommandResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// IssueSoftphoneCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IssueSoftphoneCommandResponse
        /// </returns>
        public async Task<IssueSoftphoneCommandResponse> IssueSoftphoneCommandWithOptionsAsync(IssueSoftphoneCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IssueSoftphoneCommand",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IssueSoftphoneCommandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// IssueSoftphoneCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// IssueSoftphoneCommandResponse
        /// </returns>
        public IssueSoftphoneCommandResponse IssueSoftphoneCommand(IssueSoftphoneCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IssueSoftphoneCommandWithOptions(request, runtime);
        }

        /// <param name="request">
        /// IssueSoftphoneCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// IssueSoftphoneCommandResponse
        /// </returns>
        public async Task<IssueSoftphoneCommandResponse> IssueSoftphoneCommandAsync(IssueSoftphoneCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IssueSoftphoneCommandWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼呼叫记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAttemptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAttemptsResponse
        /// </returns>
        public ListAttemptsResponse ListAttemptsWithOptions(ListAttemptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAttempts",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAttemptsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼呼叫记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAttemptsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAttemptsResponse
        /// </returns>
        public async Task<ListAttemptsResponse> ListAttemptsWithOptionsAsync(ListAttemptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAttempts",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAttemptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼呼叫记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAttemptsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAttemptsResponse
        /// </returns>
        public ListAttemptsResponse ListAttempts(ListAttemptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAttemptsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼呼叫记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAttemptsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAttemptsResponse
        /// </returns>
        public async Task<ListAttemptsResponse> ListAttemptsAsync(ListAttemptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAttemptsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼活动趋势报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCampaignTrendingReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCampaignTrendingReportResponse
        /// </returns>
        public ListCampaignTrendingReportResponse ListCampaignTrendingReportWithOptions(ListCampaignTrendingReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCampaignTrendingReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCampaignTrendingReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼活动趋势报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCampaignTrendingReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCampaignTrendingReportResponse
        /// </returns>
        public async Task<ListCampaignTrendingReportResponse> ListCampaignTrendingReportWithOptionsAsync(ListCampaignTrendingReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCampaignTrendingReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCampaignTrendingReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼活动趋势报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCampaignTrendingReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCampaignTrendingReportResponse
        /// </returns>
        public ListCampaignTrendingReportResponse ListCampaignTrendingReport(ListCampaignTrendingReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCampaignTrendingReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取预测式外呼活动趋势报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCampaignTrendingReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCampaignTrendingReportResponse
        /// </returns>
        public async Task<ListCampaignTrendingReportResponse> ListCampaignTrendingReportAsync(ListCampaignTrendingReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCampaignTrendingReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预测式外呼列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCampaignsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCampaignsResponse
        /// </returns>
        public ListCampaignsResponse ListCampaignsWithOptions(ListCampaignsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActualStartTimeFrom))
            {
                query["ActualStartTimeFrom"] = request.ActualStartTimeFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActualStartTimeTo))
            {
                query["ActualStartTimeTo"] = request.ActualStartTimeTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanedStartTimeFrom))
            {
                query["PlanedStartTimeFrom"] = request.PlanedStartTimeFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanedStartTimeTo))
            {
                query["PlanedStartTimeTo"] = request.PlanedStartTimeTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueId))
            {
                query["QueueId"] = request.QueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCampaigns",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCampaignsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预测式外呼列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCampaignsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCampaignsResponse
        /// </returns>
        public async Task<ListCampaignsResponse> ListCampaignsWithOptionsAsync(ListCampaignsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActualStartTimeFrom))
            {
                query["ActualStartTimeFrom"] = request.ActualStartTimeFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActualStartTimeTo))
            {
                query["ActualStartTimeTo"] = request.ActualStartTimeTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanedStartTimeFrom))
            {
                query["PlanedStartTimeFrom"] = request.PlanedStartTimeFrom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanedStartTimeTo))
            {
                query["PlanedStartTimeTo"] = request.PlanedStartTimeTo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueId))
            {
                query["QueueId"] = request.QueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCampaigns",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCampaignsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预测式外呼列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCampaignsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCampaignsResponse
        /// </returns>
        public ListCampaignsResponse ListCampaigns(ListCampaignsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCampaignsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询预测式外呼列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCampaignsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCampaignsResponse
        /// </returns>
        public async Task<ListCampaignsResponse> ListCampaignsAsync(ListCampaignsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCampaignsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>list case</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCasesResponse
        /// </returns>
        public ListCasesResponse ListCasesWithOptions(ListCasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCases",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCasesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>list case</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCasesResponse
        /// </returns>
        public async Task<ListCasesResponse> ListCasesWithOptionsAsync(ListCasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumber))
            {
                query["PhoneNumber"] = request.PhoneNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCases",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>list case</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCasesResponse
        /// </returns>
        public ListCasesResponse ListCases(ListCasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>list case</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCasesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCasesResponse
        /// </returns>
        public async Task<ListCasesResponse> ListCasesAsync(ListCasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCasesWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// ListFlashSmsSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsSettingsResponse
        /// </returns>
        public ListFlashSmsSettingsResponse ListFlashSmsSettingsWithOptions(ListFlashSmsSettingsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFlashSmsSettingsShrinkRequest request = new ListFlashSmsSettingsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SkillGroupIdList))
            {
                request.SkillGroupIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SkillGroupIdList, "SkillGroupIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIdListShrink))
            {
                query["SkillGroupIdList"] = request.SkillGroupIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupName))
            {
                query["SkillGroupName"] = request.SkillGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlashSmsSettings",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlashSmsSettingsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// ListFlashSmsSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsSettingsResponse
        /// </returns>
        public async Task<ListFlashSmsSettingsResponse> ListFlashSmsSettingsWithOptionsAsync(ListFlashSmsSettingsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListFlashSmsSettingsShrinkRequest request = new ListFlashSmsSettingsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SkillGroupIdList))
            {
                request.SkillGroupIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SkillGroupIdList, "SkillGroupIdList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIdListShrink))
            {
                query["SkillGroupIdList"] = request.SkillGroupIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupName))
            {
                query["SkillGroupName"] = request.SkillGroupName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFlashSmsSettings",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFlashSmsSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListFlashSmsSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsSettingsResponse
        /// </returns>
        public ListFlashSmsSettingsResponse ListFlashSmsSettings(ListFlashSmsSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlashSmsSettingsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListFlashSmsSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFlashSmsSettingsResponse
        /// </returns>
        public async Task<ListFlashSmsSettingsResponse> ListFlashSmsSettingsAsync(ListFlashSmsSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlashSmsSettingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询坐席技能组报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHistoricalAgentSkillGroupReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHistoricalAgentSkillGroupReportResponse
        /// </returns>
        public ListHistoricalAgentSkillGroupReportResponse ListHistoricalAgentSkillGroupReportWithOptions(ListHistoricalAgentSkillGroupReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIdList))
            {
                query["SkillGroupIdList"] = request.SkillGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIdList))
            {
                body["AgentIdList"] = request.AgentIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHistoricalAgentSkillGroupReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHistoricalAgentSkillGroupReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询坐席技能组报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHistoricalAgentSkillGroupReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListHistoricalAgentSkillGroupReportResponse
        /// </returns>
        public async Task<ListHistoricalAgentSkillGroupReportResponse> ListHistoricalAgentSkillGroupReportWithOptionsAsync(ListHistoricalAgentSkillGroupReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupIdList))
            {
                query["SkillGroupIdList"] = request.SkillGroupIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentIdList))
            {
                body["AgentIdList"] = request.AgentIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHistoricalAgentSkillGroupReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHistoricalAgentSkillGroupReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询坐席技能组报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHistoricalAgentSkillGroupReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHistoricalAgentSkillGroupReportResponse
        /// </returns>
        public ListHistoricalAgentSkillGroupReportResponse ListHistoricalAgentSkillGroupReport(ListHistoricalAgentSkillGroupReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHistoricalAgentSkillGroupReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询坐席技能组报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListHistoricalAgentSkillGroupReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ListHistoricalAgentSkillGroupReportResponse
        /// </returns>
        public async Task<ListHistoricalAgentSkillGroupReportResponse> ListHistoricalAgentSkillGroupReportAsync(ListHistoricalAgentSkillGroupReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHistoricalAgentSkillGroupReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询坐席技能组报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntervalAgentSkillGroupReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntervalAgentSkillGroupReportResponse
        /// </returns>
        public ListIntervalAgentSkillGroupReportResponse ListIntervalAgentSkillGroupReportWithOptions(ListIntervalAgentSkillGroupReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDefaultIfEmpty))
            {
                query["ShowDefaultIfEmpty"] = request.ShowDefaultIfEmpty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                query["SkillGroupId"] = request.SkillGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntervalAgentSkillGroupReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntervalAgentSkillGroupReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询坐席技能组报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntervalAgentSkillGroupReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntervalAgentSkillGroupReportResponse
        /// </returns>
        public async Task<ListIntervalAgentSkillGroupReportResponse> ListIntervalAgentSkillGroupReportWithOptionsAsync(ListIntervalAgentSkillGroupReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentId))
            {
                query["AgentId"] = request.AgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaType))
            {
                query["MediaType"] = request.MediaType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDefaultIfEmpty))
            {
                query["ShowDefaultIfEmpty"] = request.ShowDefaultIfEmpty;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillGroupId))
            {
                query["SkillGroupId"] = request.SkillGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntervalAgentSkillGroupReport",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntervalAgentSkillGroupReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询坐席技能组报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntervalAgentSkillGroupReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntervalAgentSkillGroupReportResponse
        /// </returns>
        public ListIntervalAgentSkillGroupReportResponse ListIntervalAgentSkillGroupReport(ListIntervalAgentSkillGroupReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntervalAgentSkillGroupReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询坐席技能组报表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIntervalAgentSkillGroupReportRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntervalAgentSkillGroupReportResponse
        /// </returns>
        public async Task<ListIntervalAgentSkillGroupReportResponse> ListIntervalAgentSkillGroupReportAsync(ListIntervalAgentSkillGroupReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntervalAgentSkillGroupReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>录音查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMonoRecordingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMonoRecordingsResponse
        /// </returns>
        public ListMonoRecordingsResponse ListMonoRecordingsWithOptions(ListMonoRecordingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMonoRecordings",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMonoRecordingsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>录音查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMonoRecordingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMonoRecordingsResponse
        /// </returns>
        public async Task<ListMonoRecordingsResponse> ListMonoRecordingsWithOptionsAsync(ListMonoRecordingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMonoRecordings",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMonoRecordingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>录音查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMonoRecordingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMonoRecordingsResponse
        /// </returns>
        public ListMonoRecordingsResponse ListMonoRecordings(ListMonoRecordingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMonoRecordingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>录音查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMonoRecordingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMonoRecordingsResponse
        /// </returns>
        public async Task<ListMonoRecordingsResponse> ListMonoRecordingsAsync(ListMonoRecordingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMonoRecordingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停预测式外呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PauseCampaignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PauseCampaignResponse
        /// </returns>
        public PauseCampaignResponse PauseCampaignWithOptions(PauseCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseCampaignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停预测式外呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PauseCampaignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PauseCampaignResponse
        /// </returns>
        public async Task<PauseCampaignResponse> PauseCampaignWithOptionsAsync(PauseCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseCampaignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停预测式外呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PauseCampaignRequest
        /// </param>
        /// 
        /// <returns>
        /// PauseCampaignResponse
        /// </returns>
        public PauseCampaignResponse PauseCampaign(PauseCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PauseCampaignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>暂停预测式外呼</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PauseCampaignRequest
        /// </param>
        /// 
        /// <returns>
        /// PauseCampaignResponse
        /// </returns>
        public async Task<PauseCampaignResponse> PauseCampaignAsync(PauseCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PauseCampaignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ProcessAliMeCallbackOfStaging</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProcessAliMeCallbackOfStagingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProcessAliMeCallbackOfStagingResponse
        /// </returns>
        public ProcessAliMeCallbackOfStagingResponse ProcessAliMeCallbackOfStagingWithOptions(ProcessAliMeCallbackOfStagingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProcessAliMeCallbackOfStaging",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProcessAliMeCallbackOfStagingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ProcessAliMeCallbackOfStaging</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProcessAliMeCallbackOfStagingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProcessAliMeCallbackOfStagingResponse
        /// </returns>
        public async Task<ProcessAliMeCallbackOfStagingResponse> ProcessAliMeCallbackOfStagingWithOptionsAsync(ProcessAliMeCallbackOfStagingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProcessAliMeCallbackOfStaging",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProcessAliMeCallbackOfStagingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ProcessAliMeCallbackOfStaging</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProcessAliMeCallbackOfStagingRequest
        /// </param>
        /// 
        /// <returns>
        /// ProcessAliMeCallbackOfStagingResponse
        /// </returns>
        public ProcessAliMeCallbackOfStagingResponse ProcessAliMeCallbackOfStaging(ProcessAliMeCallbackOfStagingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProcessAliMeCallbackOfStagingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ProcessAliMeCallbackOfStaging</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProcessAliMeCallbackOfStagingRequest
        /// </param>
        /// 
        /// <returns>
        /// ProcessAliMeCallbackOfStagingResponse
        /// </returns>
        public async Task<ProcessAliMeCallbackOfStagingResponse> ProcessAliMeCallbackOfStagingAsync(ProcessAliMeCallbackOfStagingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProcessAliMeCallbackOfStagingWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ProcessCustomIMCallbackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProcessCustomIMCallbackResponse
        /// </returns>
        public ProcessCustomIMCallbackResponse ProcessCustomIMCallbackWithOptions(ProcessCustomIMCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessChannelId))
            {
                body["AccessChannelId"] = request.AccessChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageContent))
            {
                body["MessageContent"] = request.MessageContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderAvatarMediaId))
            {
                body["SenderAvatarMediaId"] = request.SenderAvatarMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderId))
            {
                body["SenderId"] = request.SenderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderName))
            {
                body["SenderName"] = request.SenderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProcessCustomIMCallback",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProcessCustomIMCallbackResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ProcessCustomIMCallbackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProcessCustomIMCallbackResponse
        /// </returns>
        public async Task<ProcessCustomIMCallbackResponse> ProcessCustomIMCallbackWithOptionsAsync(ProcessCustomIMCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessChannelId))
            {
                body["AccessChannelId"] = request.AccessChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageContent))
            {
                body["MessageContent"] = request.MessageContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderAvatarMediaId))
            {
                body["SenderAvatarMediaId"] = request.SenderAvatarMediaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderId))
            {
                body["SenderId"] = request.SenderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderName))
            {
                body["SenderName"] = request.SenderName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ProcessCustomIMCallback",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProcessCustomIMCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ProcessCustomIMCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// ProcessCustomIMCallbackResponse
        /// </returns>
        public ProcessCustomIMCallbackResponse ProcessCustomIMCallback(ProcessCustomIMCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProcessCustomIMCallbackWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ProcessCustomIMCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// ProcessCustomIMCallbackResponse
        /// </returns>
        public async Task<ProcessCustomIMCallbackResponse> ProcessCustomIMCallbackAsync(ProcessCustomIMCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProcessCustomIMCallbackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ccc migration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReplaceMigrationAvailableNumbersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplaceMigrationAvailableNumbersResponse
        /// </returns>
        public ReplaceMigrationAvailableNumbersResponse ReplaceMigrationAvailableNumbersWithOptions(ReplaceMigrationAvailableNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorName))
            {
                query["OperatorName"] = request.OperatorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                query["OperatorUid"] = request.OperatorUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V1Numbers))
            {
                query["V1Numbers"] = request.V1Numbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V2Numbers))
            {
                query["V2Numbers"] = request.V2Numbers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceMigrationAvailableNumbers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceMigrationAvailableNumbersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ccc migration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReplaceMigrationAvailableNumbersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReplaceMigrationAvailableNumbersResponse
        /// </returns>
        public async Task<ReplaceMigrationAvailableNumbersResponse> ReplaceMigrationAvailableNumbersWithOptionsAsync(ReplaceMigrationAvailableNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorName))
            {
                query["OperatorName"] = request.OperatorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                query["OperatorUid"] = request.OperatorUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V1Numbers))
            {
                query["V1Numbers"] = request.V1Numbers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.V2Numbers))
            {
                query["V2Numbers"] = request.V2Numbers;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceMigrationAvailableNumbers",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceMigrationAvailableNumbersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ccc migration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReplaceMigrationAvailableNumbersRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplaceMigrationAvailableNumbersResponse
        /// </returns>
        public ReplaceMigrationAvailableNumbersResponse ReplaceMigrationAvailableNumbers(ReplaceMigrationAvailableNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceMigrationAvailableNumbersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ccc migration</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReplaceMigrationAvailableNumbersRequest
        /// </param>
        /// 
        /// <returns>
        /// ReplaceMigrationAvailableNumbersResponse
        /// </returns>
        public async Task<ReplaceMigrationAvailableNumbersResponse> ReplaceMigrationAvailableNumbersAsync(ReplaceMigrationAvailableNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceMigrationAvailableNumbersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>resume campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeCampaignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeCampaignResponse
        /// </returns>
        public ResumeCampaignResponse ResumeCampaignWithOptions(ResumeCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeCampaignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>resume campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeCampaignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResumeCampaignResponse
        /// </returns>
        public async Task<ResumeCampaignResponse> ResumeCampaignWithOptionsAsync(ResumeCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeCampaignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>resume campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeCampaignRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeCampaignResponse
        /// </returns>
        public ResumeCampaignResponse ResumeCampaign(ResumeCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeCampaignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>resume campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResumeCampaignRequest
        /// </param>
        /// 
        /// <returns>
        /// ResumeCampaignResponse
        /// </returns>
        public async Task<ResumeCampaignResponse> ResumeCampaignAsync(ResumeCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeCampaignWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveRTCStatsV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveRTCStatsV2Response
        /// </returns>
        public SaveRTCStatsV2Response SaveRTCStatsV2WithOptions(SaveRTCStatsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneralInfo))
            {
                query["GeneralInfo"] = request.GeneralInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoogAddress))
            {
                query["GoogAddress"] = request.GoogAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverReport))
            {
                query["ReceiverReport"] = request.ReceiverReport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderReport))
            {
                query["SenderReport"] = request.SenderReport;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveRTCStatsV2",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveRTCStatsV2Response>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveRTCStatsV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveRTCStatsV2Response
        /// </returns>
        public async Task<SaveRTCStatsV2Response> SaveRTCStatsV2WithOptionsAsync(SaveRTCStatsV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeneralInfo))
            {
                query["GeneralInfo"] = request.GeneralInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoogAddress))
            {
                query["GoogAddress"] = request.GoogAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverReport))
            {
                query["ReceiverReport"] = request.ReceiverReport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SenderReport))
            {
                query["SenderReport"] = request.SenderReport;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveRTCStatsV2",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveRTCStatsV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SaveRTCStatsV2Request
        /// </param>
        /// 
        /// <returns>
        /// SaveRTCStatsV2Response
        /// </returns>
        public SaveRTCStatsV2Response SaveRTCStatsV2(SaveRTCStatsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveRTCStatsV2WithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveRTCStatsV2Request
        /// </param>
        /// 
        /// <returns>
        /// SaveRTCStatsV2Response
        /// </returns>
        public async Task<SaveRTCStatsV2Response> SaveRTCStatsV2Async(SaveRTCStatsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveRTCStatsV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTerminalLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTerminalLogResponse
        /// </returns>
        public SaveTerminalLogResponse SaveTerminalLogWithOptions(SaveTerminalLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodName))
            {
                query["MethodName"] = request.MethodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueRequestId))
            {
                query["UniqueRequestId"] = request.UniqueRequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTerminalLog",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTerminalLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTerminalLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTerminalLogResponse
        /// </returns>
        public async Task<SaveTerminalLogResponse> SaveTerminalLogWithOptionsAsync(SaveTerminalLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MethodName))
            {
                query["MethodName"] = request.MethodName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueRequestId))
            {
                query["UniqueRequestId"] = request.UniqueRequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTerminalLog",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTerminalLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTerminalLogRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTerminalLogResponse
        /// </returns>
        public SaveTerminalLogResponse SaveTerminalLog(SaveTerminalLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTerminalLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTerminalLogRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTerminalLogResponse
        /// </returns>
        public async Task<SaveTerminalLogResponse> SaveTerminalLogAsync(SaveTerminalLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTerminalLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveWebRtcInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveWebRtcInfoResponse
        /// </returns>
        public SaveWebRtcInfoResponse SaveWebRtcInfoWithOptions(SaveWebRtcInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["ContentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveWebRtcInfo",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveWebRtcInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveWebRtcInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveWebRtcInfoResponse
        /// </returns>
        public async Task<SaveWebRtcInfoResponse> SaveWebRtcInfoWithOptionsAsync(SaveWebRtcInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallId))
            {
                query["CallId"] = request.CallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                query["ContentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveWebRtcInfo",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveWebRtcInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveWebRtcInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveWebRtcInfoResponse
        /// </returns>
        public SaveWebRtcInfoResponse SaveWebRtcInfo(SaveWebRtcInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveWebRtcInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveWebRtcInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveWebRtcInfoResponse
        /// </returns>
        public async Task<SaveWebRtcInfoResponse> SaveWebRtcInfoAsync(SaveWebRtcInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveWebRtcInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendNotificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendNotificationResponse
        /// </returns>
        public SendNotificationResponse SendNotificationWithOptions(SendNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageBody))
            {
                query["MessageBody"] = request.MessageBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationTarget))
            {
                query["NotificationTarget"] = request.NotificationTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationType))
            {
                query["NotificationType"] = request.NotificationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardingKey))
            {
                query["ShardingKey"] = request.ShardingKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendNotification",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendNotificationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendNotificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendNotificationResponse
        /// </returns>
        public async Task<SendNotificationResponse> SendNotificationWithOptionsAsync(SendNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageBody))
            {
                query["MessageBody"] = request.MessageBody;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationTarget))
            {
                query["NotificationTarget"] = request.NotificationTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationType))
            {
                query["NotificationType"] = request.NotificationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardingKey))
            {
                query["ShardingKey"] = request.ShardingKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendNotification",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendNotificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendNotificationRequest
        /// </param>
        /// 
        /// <returns>
        /// SendNotificationResponse
        /// </returns>
        public SendNotificationResponse SendNotification(SendNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendNotificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendNotificationRequest
        /// </param>
        /// 
        /// <returns>
        /// SendNotificationResponse
        /// </returns>
        public async Task<SendNotificationResponse> SendNotificationAsync(SendNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendNotificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>submit campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitCampaignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitCampaignResponse
        /// </returns>
        public SubmitCampaignResponse SubmitCampaignWithOptions(SubmitCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitCampaignResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>submit campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitCampaignRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitCampaignResponse
        /// </returns>
        public async Task<SubmitCampaignResponse> SubmitCampaignWithOptionsAsync(SubmitCampaignRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampaignId))
            {
                query["CampaignId"] = request.CampaignId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitCampaign",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitCampaignResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>submit campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitCampaignRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitCampaignResponse
        /// </returns>
        public SubmitCampaignResponse SubmitCampaign(SubmitCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitCampaignWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>submit campaign</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitCampaignRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitCampaignResponse
        /// </returns>
        public async Task<SubmitCampaignResponse> SubmitCampaignAsync(SubmitCampaignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitCampaignWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除注册设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnregisterDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnregisterDeviceResponse
        /// </returns>
        public UnregisterDeviceResponse UnregisterDeviceWithOptions(UnregisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnregisterDevice",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnregisterDeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除注册设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnregisterDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnregisterDeviceResponse
        /// </returns>
        public async Task<UnregisterDeviceResponse> UnregisterDeviceWithOptionsAsync(UnregisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnregisterDevice",
                Version = "2020-07-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnregisterDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除注册设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnregisterDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// UnregisterDeviceResponse
        /// </returns>
        public UnregisterDeviceResponse UnregisterDevice(UnregisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnregisterDeviceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除注册设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnregisterDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// UnregisterDeviceResponse
        /// </returns>
        public async Task<UnregisterDeviceResponse> UnregisterDeviceAsync(UnregisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnregisterDeviceWithOptionsAsync(request, runtime);
        }

    }
}
