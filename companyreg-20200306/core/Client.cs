// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Companyreg20200306.Models;

namespace AlibabaCloud.SDK.Companyreg20200306
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "companyreg.aliyuncs.com"},
                {"ap-northeast-2-pop", "companyreg.aliyuncs.com"},
                {"ap-south-1", "companyreg.aliyuncs.com"},
                {"ap-southeast-1", "companyreg.aliyuncs.com"},
                {"ap-southeast-2", "companyreg.aliyuncs.com"},
                {"ap-southeast-3", "companyreg.aliyuncs.com"},
                {"ap-southeast-5", "companyreg.aliyuncs.com"},
                {"cn-beijing", "companyreg.aliyuncs.com"},
                {"cn-beijing-finance-1", "companyreg.aliyuncs.com"},
                {"cn-beijing-finance-pop", "companyreg.aliyuncs.com"},
                {"cn-beijing-gov-1", "companyreg.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "companyreg.aliyuncs.com"},
                {"cn-chengdu", "companyreg.aliyuncs.com"},
                {"cn-edge-1", "companyreg.aliyuncs.com"},
                {"cn-fujian", "companyreg.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-finance", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "companyreg.aliyuncs.com"},
                {"cn-hangzhou-test-306", "companyreg.aliyuncs.com"},
                {"cn-hongkong", "companyreg.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "companyreg.aliyuncs.com"},
                {"cn-huhehaote", "companyreg.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "companyreg.aliyuncs.com"},
                {"cn-north-2-gov-1", "companyreg.aliyuncs.com"},
                {"cn-qingdao", "companyreg.aliyuncs.com"},
                {"cn-qingdao-nebula", "companyreg.aliyuncs.com"},
                {"cn-shanghai", "companyreg.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "companyreg.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "companyreg.aliyuncs.com"},
                {"cn-shanghai-finance-1", "companyreg.aliyuncs.com"},
                {"cn-shanghai-inner", "companyreg.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "companyreg.aliyuncs.com"},
                {"cn-shenzhen", "companyreg.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "companyreg.aliyuncs.com"},
                {"cn-shenzhen-inner", "companyreg.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "companyreg.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "companyreg.aliyuncs.com"},
                {"cn-wuhan", "companyreg.aliyuncs.com"},
                {"cn-wulanchabu", "companyreg.aliyuncs.com"},
                {"cn-yushanfang", "companyreg.aliyuncs.com"},
                {"cn-zhangbei", "companyreg.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "companyreg.aliyuncs.com"},
                {"cn-zhangjiakou", "companyreg.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "companyreg.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "companyreg.aliyuncs.com"},
                {"eu-central-1", "companyreg.aliyuncs.com"},
                {"eu-west-1", "companyreg.aliyuncs.com"},
                {"eu-west-1-oxs", "companyreg.aliyuncs.com"},
                {"me-east-1", "companyreg.aliyuncs.com"},
                {"rus-west-1-pop", "companyreg.aliyuncs.com"},
                {"us-east-1", "companyreg.aliyuncs.com"},
                {"us-west-1", "companyreg.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("companyreg", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>服务单授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindProduceAuthorizationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindProduceAuthorizationResponse
        /// </returns>
        public BindProduceAuthorizationResponse BindProduceAuthorizationWithOptions(BindProduceAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedUserIds))
            {
                body["AuthorizedUserIds"] = request.AuthorizedUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindProduceAuthorization",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindProduceAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务单授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindProduceAuthorizationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindProduceAuthorizationResponse
        /// </returns>
        public async Task<BindProduceAuthorizationResponse> BindProduceAuthorizationWithOptionsAsync(BindProduceAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedUserIds))
            {
                body["AuthorizedUserIds"] = request.AuthorizedUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindProduceAuthorization",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindProduceAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务单授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindProduceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// BindProduceAuthorizationResponse
        /// </returns>
        public BindProduceAuthorizationResponse BindProduceAuthorization(BindProduceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindProduceAuthorizationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务单授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BindProduceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// BindProduceAuthorizationResponse
        /// </returns>
        public async Task<BindProduceAuthorizationResponse> BindProduceAuthorizationAsync(BindProduceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindProduceAuthorizationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CloseIntentionForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseIntentionForPartnerResponse
        /// </returns>
        public CloseIntentionForPartnerResponse CloseIntentionForPartnerWithOptions(CloseIntentionForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseIntentionForPartner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseIntentionForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CloseIntentionForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseIntentionForPartnerResponse
        /// </returns>
        public async Task<CloseIntentionForPartnerResponse> CloseIntentionForPartnerWithOptionsAsync(CloseIntentionForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseIntentionForPartner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseIntentionForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CloseIntentionForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseIntentionForPartnerResponse
        /// </returns>
        public CloseIntentionForPartnerResponse CloseIntentionForPartner(CloseIntentionForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseIntentionForPartnerWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CloseIntentionForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseIntentionForPartnerResponse
        /// </returns>
        public async Task<CloseIntentionForPartnerResponse> CloseIntentionForPartnerAsync(CloseIntentionForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseIntentionForPartnerWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CloseUserIntentionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseUserIntentionResponse
        /// </returns>
        public CloseUserIntentionResponse CloseUserIntentionWithOptions(CloseUserIntentionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseUserIntention",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseUserIntentionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CloseUserIntentionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloseUserIntentionResponse
        /// </returns>
        public async Task<CloseUserIntentionResponse> CloseUserIntentionWithOptionsAsync(CloseUserIntentionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloseUserIntention",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseUserIntentionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CloseUserIntentionRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseUserIntentionResponse
        /// </returns>
        public CloseUserIntentionResponse CloseUserIntention(CloseUserIntentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseUserIntentionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CloseUserIntentionRequest
        /// </param>
        /// 
        /// <returns>
        /// CloseUserIntentionResponse
        /// </returns>
        public async Task<CloseUserIntentionResponse> CloseUserIntentionAsync(CloseUserIntentionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseUserIntentionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBusinessOpportunity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBusinessOpportunityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBusinessOpportunityResponse
        /// </returns>
        public CreateBusinessOpportunityResponse CreateBusinessOpportunityWithOptions(CreateBusinessOpportunityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VCode))
            {
                query["VCode"] = request.VCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBusinessOpportunity",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBusinessOpportunityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBusinessOpportunity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBusinessOpportunityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBusinessOpportunityResponse
        /// </returns>
        public async Task<CreateBusinessOpportunityResponse> CreateBusinessOpportunityWithOptionsAsync(CreateBusinessOpportunityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VCode))
            {
                query["VCode"] = request.VCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBusinessOpportunity",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBusinessOpportunityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBusinessOpportunity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBusinessOpportunityRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBusinessOpportunityResponse
        /// </returns>
        public CreateBusinessOpportunityResponse CreateBusinessOpportunity(CreateBusinessOpportunityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBusinessOpportunityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateBusinessOpportunity</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBusinessOpportunityRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBusinessOpportunityResponse
        /// </returns>
        public async Task<CreateBusinessOpportunityResponse> CreateBusinessOpportunityAsync(CreateBusinessOpportunityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBusinessOpportunityWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateProduceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProduceForPartnerResponse
        /// </returns>
        public CreateProduceForPartnerResponse CreateProduceForPartnerWithOptions(CreateProduceForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProduceForPartner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProduceForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateProduceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProduceForPartnerResponse
        /// </returns>
        public async Task<CreateProduceForPartnerResponse> CreateProduceForPartnerWithOptionsAsync(CreateProduceForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProduceForPartner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProduceForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateProduceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProduceForPartnerResponse
        /// </returns>
        public CreateProduceForPartnerResponse CreateProduceForPartner(CreateProduceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProduceForPartnerWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateProduceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProduceForPartnerResponse
        /// </returns>
        public async Task<CreateProduceForPartnerResponse> CreateProduceForPartnerAsync(CreateProduceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProduceForPartnerWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribePartnerConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePartnerConfigResponse
        /// </returns>
        public DescribePartnerConfigResponse DescribePartnerConfigWithOptions(DescribePartnerConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerCode))
            {
                query["PartnerCode"] = request.PartnerCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePartnerConfig",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePartnerConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribePartnerConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePartnerConfigResponse
        /// </returns>
        public async Task<DescribePartnerConfigResponse> DescribePartnerConfigWithOptionsAsync(DescribePartnerConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerCode))
            {
                query["PartnerCode"] = request.PartnerCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePartnerConfig",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePartnerConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribePartnerConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePartnerConfigResponse
        /// </returns>
        public DescribePartnerConfigResponse DescribePartnerConfig(DescribePartnerConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePartnerConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribePartnerConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePartnerConfigResponse
        /// </returns>
        public async Task<DescribePartnerConfigResponse> DescribePartnerConfigAsync(DescribePartnerConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePartnerConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GenerateUploadFilePolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUploadFilePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadFilePolicyResponse
        /// </returns>
        public GenerateUploadFilePolicyResponse GenerateUploadFilePolicyWithOptions(GenerateUploadFilePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUploadFilePolicy",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadFilePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GenerateUploadFilePolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUploadFilePolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadFilePolicyResponse
        /// </returns>
        public async Task<GenerateUploadFilePolicyResponse> GenerateUploadFilePolicyWithOptionsAsync(GenerateUploadFilePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                query["FileType"] = request.FileType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateUploadFilePolicy",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadFilePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GenerateUploadFilePolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUploadFilePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadFilePolicyResponse
        /// </returns>
        public GenerateUploadFilePolicyResponse GenerateUploadFilePolicy(GenerateUploadFilePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateUploadFilePolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GenerateUploadFilePolicy</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUploadFilePolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadFilePolicyResponse
        /// </returns>
        public async Task<GenerateUploadFilePolicyResponse> GenerateUploadFilePolicyAsync(GenerateUploadFilePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateUploadFilePolicyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAlipayUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlipayUrlResponse
        /// </returns>
        public GetAlipayUrlResponse GetAlipayUrlWithOptions(GetAlipayUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlipayUrl",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlipayUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAlipayUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAlipayUrlResponse
        /// </returns>
        public async Task<GetAlipayUrlResponse> GetAlipayUrlWithOptionsAsync(GetAlipayUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAlipayUrl",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlipayUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAlipayUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlipayUrlResponse
        /// </returns>
        public GetAlipayUrlResponse GetAlipayUrl(GetAlipayUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAlipayUrlWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAlipayUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAlipayUrlResponse
        /// </returns>
        public async Task<GetAlipayUrlResponse> GetAlipayUrlAsync(GetAlipayUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAlipayUrlWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListIntentionNoteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntentionNoteResponse
        /// </returns>
        public ListIntentionNoteResponse ListIntentionNoteWithOptions(ListIntentionNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntentionNote",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntentionNoteResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListIntentionNoteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIntentionNoteResponse
        /// </returns>
        public async Task<ListIntentionNoteResponse> ListIntentionNoteWithOptionsAsync(ListIntentionNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIntentionNote",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIntentionNoteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListIntentionNoteRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntentionNoteResponse
        /// </returns>
        public ListIntentionNoteResponse ListIntentionNote(ListIntentionNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIntentionNoteWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListIntentionNoteRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIntentionNoteResponse
        /// </returns>
        public async Task<ListIntentionNoteResponse> ListIntentionNoteAsync(ListIntentionNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIntentionNoteWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListProduceAuthorizationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProduceAuthorizationResponse
        /// </returns>
        public ListProduceAuthorizationResponse ListProduceAuthorizationWithOptions(ListProduceAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProduceAuthorization",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProduceAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListProduceAuthorizationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProduceAuthorizationResponse
        /// </returns>
        public async Task<ListProduceAuthorizationResponse> ListProduceAuthorizationWithOptionsAsync(ListProduceAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProduceAuthorization",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProduceAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListProduceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProduceAuthorizationResponse
        /// </returns>
        public ListProduceAuthorizationResponse ListProduceAuthorization(ListProduceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProduceAuthorizationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListProduceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProduceAuthorizationResponse
        /// </returns>
        public async Task<ListProduceAuthorizationResponse> ListProduceAuthorizationAsync(ListProduceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProduceAuthorizationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListUserDetailSolutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserDetailSolutionsResponse
        /// </returns>
        public ListUserDetailSolutionsResponse ListUserDetailSolutionsWithOptions(ListUserDetailSolutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserDetailSolutions",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserDetailSolutionsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListUserDetailSolutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserDetailSolutionsResponse
        /// </returns>
        public async Task<ListUserDetailSolutionsResponse> ListUserDetailSolutionsWithOptionsAsync(ListUserDetailSolutionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserDetailSolutions",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserDetailSolutionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListUserDetailSolutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserDetailSolutionsResponse
        /// </returns>
        public ListUserDetailSolutionsResponse ListUserDetailSolutions(ListUserDetailSolutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserDetailSolutionsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListUserDetailSolutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserDetailSolutionsResponse
        /// </returns>
        public async Task<ListUserDetailSolutionsResponse> ListUserDetailSolutionsAsync(ListUserDetailSolutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserDetailSolutionsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListUserIntentionNotesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserIntentionNotesResponse
        /// </returns>
        public ListUserIntentionNotesResponse ListUserIntentionNotesWithOptions(ListUserIntentionNotesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserIntentionNotes",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserIntentionNotesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListUserIntentionNotesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserIntentionNotesResponse
        /// </returns>
        public async Task<ListUserIntentionNotesResponse> ListUserIntentionNotesWithOptionsAsync(ListUserIntentionNotesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserIntentionNotes",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserIntentionNotesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListUserIntentionNotesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserIntentionNotesResponse
        /// </returns>
        public ListUserIntentionNotesResponse ListUserIntentionNotes(ListUserIntentionNotesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserIntentionNotesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListUserIntentionNotesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserIntentionNotesResponse
        /// </returns>
        public async Task<ListUserIntentionNotesResponse> ListUserIntentionNotesAsync(ListUserIntentionNotesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserIntentionNotesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户控制天需求列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserIntentionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserIntentionsResponse
        /// </returns>
        public ListUserIntentionsResponse ListUserIntentionsWithOptions(ListUserIntentionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypes))
            {
                query["BizTypes"] = request.BizTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFiled))
            {
                query["SortFiled"] = request.SortFiled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithExtInfo))
            {
                query["WithExtInfo"] = request.WithExtInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserIntentions",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserIntentionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户控制天需求列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserIntentionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserIntentionsResponse
        /// </returns>
        public async Task<ListUserIntentionsResponse> ListUserIntentionsWithOptionsAsync(ListUserIntentionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypes))
            {
                query["BizTypes"] = request.BizTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFiled))
            {
                query["SortFiled"] = request.SortFiled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithExtInfo))
            {
                query["WithExtInfo"] = request.WithExtInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserIntentions",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserIntentionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户控制天需求列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserIntentionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserIntentionsResponse
        /// </returns>
        public ListUserIntentionsResponse ListUserIntentions(ListUserIntentionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserIntentionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>用户控制天需求列表查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserIntentionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserIntentionsResponse
        /// </returns>
        public async Task<ListUserIntentionsResponse> ListUserIntentionsAsync(ListUserIntentionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserIntentionsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListUserProduceOperateLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserProduceOperateLogsResponse
        /// </returns>
        public ListUserProduceOperateLogsResponse ListUserProduceOperateLogsWithOptions(ListUserProduceOperateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserProduceOperateLogs",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserProduceOperateLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListUserProduceOperateLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserProduceOperateLogsResponse
        /// </returns>
        public async Task<ListUserProduceOperateLogsResponse> ListUserProduceOperateLogsWithOptionsAsync(ListUserProduceOperateLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserProduceOperateLogs",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserProduceOperateLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListUserProduceOperateLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserProduceOperateLogsResponse
        /// </returns>
        public ListUserProduceOperateLogsResponse ListUserProduceOperateLogs(ListUserProduceOperateLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserProduceOperateLogsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListUserProduceOperateLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserProduceOperateLogsResponse
        /// </returns>
        public async Task<ListUserProduceOperateLogsResponse> ListUserProduceOperateLogsAsync(ListUserProduceOperateLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserProduceOperateLogsWithOptionsAsync(request, runtime);
        }

        /// <param name="tmpReq">
        /// ListUserSolutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserSolutionsResponse
        /// </returns>
        public ListUserSolutionsResponse ListUserSolutionsWithOptions(ListUserSolutionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUserSolutionsShrinkRequest request = new ListUserSolutionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExistStatus))
            {
                request.ExistStatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExistStatus, "ExistStatus", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistStatusShrink))
            {
                query["ExistStatus"] = request.ExistStatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserSolutions",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserSolutionsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// ListUserSolutionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserSolutionsResponse
        /// </returns>
        public async Task<ListUserSolutionsResponse> ListUserSolutionsWithOptionsAsync(ListUserSolutionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListUserSolutionsShrinkRequest request = new ListUserSolutionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExistStatus))
            {
                request.ExistStatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExistStatus, "ExistStatus", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExistStatusShrink))
            {
                query["ExistStatus"] = request.ExistStatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserSolutions",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserSolutionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListUserSolutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserSolutionsResponse
        /// </returns>
        public ListUserSolutionsResponse ListUserSolutions(ListUserSolutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserSolutionsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListUserSolutionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserSolutionsResponse
        /// </returns>
        public async Task<ListUserSolutionsResponse> ListUserSolutionsAsync(ListUserSolutionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserSolutionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务商玄坛呼叫中心操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateCallCenterForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateCallCenterForPartnerResponse
        /// </returns>
        public OperateCallCenterForPartnerResponse OperateCallCenterForPartnerWithOptions(OperateCallCenterForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallAction))
            {
                query["CallAction"] = request.CallAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmployeeCode))
            {
                query["EmployeeCode"] = request.EmployeeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                query["Request"] = request.Request;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateCallCenterForPartner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateCallCenterForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务商玄坛呼叫中心操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateCallCenterForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateCallCenterForPartnerResponse
        /// </returns>
        public async Task<OperateCallCenterForPartnerResponse> OperateCallCenterForPartnerWithOptionsAsync(OperateCallCenterForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallAction))
            {
                query["CallAction"] = request.CallAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmployeeCode))
            {
                query["EmployeeCode"] = request.EmployeeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                query["Request"] = request.Request;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateCallCenterForPartner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateCallCenterForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务商玄坛呼叫中心操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateCallCenterForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateCallCenterForPartnerResponse
        /// </returns>
        public OperateCallCenterForPartnerResponse OperateCallCenterForPartner(OperateCallCenterForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateCallCenterForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务商玄坛呼叫中心操作</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateCallCenterForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateCallCenterForPartnerResponse
        /// </returns>
        public async Task<OperateCallCenterForPartnerResponse> OperateCallCenterForPartnerAsync(OperateCallCenterForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateCallCenterForPartnerWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// OperateProduceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateProduceForPartnerResponse
        /// </returns>
        public OperateProduceForPartnerResponse OperateProduceForPartnerWithOptions(OperateProduceForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateProduceForPartner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateProduceForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// OperateProduceForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateProduceForPartnerResponse
        /// </returns>
        public async Task<OperateProduceForPartnerResponse> OperateProduceForPartnerWithOptionsAsync(OperateProduceForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateProduceForPartner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateProduceForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// OperateProduceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateProduceForPartnerResponse
        /// </returns>
        public OperateProduceForPartnerResponse OperateProduceForPartner(OperateProduceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateProduceForPartnerWithOptions(request, runtime);
        }

        /// <param name="request">
        /// OperateProduceForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateProduceForPartnerResponse
        /// </returns>
        public async Task<OperateProduceForPartnerResponse> OperateProduceForPartnerAsync(OperateProduceForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateProduceForPartnerWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// PutMeasureDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutMeasureDataResponse
        /// </returns>
        public PutMeasureDataResponse PutMeasureDataWithOptions(PutMeasureDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMeasureData",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMeasureDataResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// PutMeasureDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutMeasureDataResponse
        /// </returns>
        public async Task<PutMeasureDataResponse> PutMeasureDataWithOptionsAsync(PutMeasureDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                body["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutMeasureData",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMeasureDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// PutMeasureDataRequest
        /// </param>
        /// 
        /// <returns>
        /// PutMeasureDataResponse
        /// </returns>
        public PutMeasureDataResponse PutMeasureData(PutMeasureDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutMeasureDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PutMeasureDataRequest
        /// </param>
        /// 
        /// <returns>
        /// PutMeasureDataResponse
        /// </returns>
        public async Task<PutMeasureDataResponse> PutMeasureDataAsync(PutMeasureDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutMeasureDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// PutMeasureReadyFlagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutMeasureReadyFlagResponse
        /// </returns>
        public PutMeasureReadyFlagResponse PutMeasureReadyFlagWithOptions(PutMeasureReadyFlagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadyFlag))
            {
                query["ReadyFlag"] = request.ReadyFlag;
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
                Action = "PutMeasureReadyFlag",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMeasureReadyFlagResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// PutMeasureReadyFlagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PutMeasureReadyFlagResponse
        /// </returns>
        public async Task<PutMeasureReadyFlagResponse> PutMeasureReadyFlagWithOptionsAsync(PutMeasureReadyFlagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadyFlag))
            {
                query["ReadyFlag"] = request.ReadyFlag;
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
                Action = "PutMeasureReadyFlag",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutMeasureReadyFlagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// PutMeasureReadyFlagRequest
        /// </param>
        /// 
        /// <returns>
        /// PutMeasureReadyFlagResponse
        /// </returns>
        public PutMeasureReadyFlagResponse PutMeasureReadyFlag(PutMeasureReadyFlagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutMeasureReadyFlagWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PutMeasureReadyFlagRequest
        /// </param>
        /// 
        /// <returns>
        /// PutMeasureReadyFlagResponse
        /// </returns>
        public async Task<PutMeasureReadyFlagResponse> PutMeasureReadyFlagAsync(PutMeasureReadyFlagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutMeasureReadyFlagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取玄坛合作伙伴双呼时可用外呼号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailableNumbersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailableNumbersResponse
        /// </returns>
        public QueryAvailableNumbersResponse QueryAvailableNumbersWithOptions(QueryAvailableNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAvailableNumbers",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvailableNumbersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取玄坛合作伙伴双呼时可用外呼号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailableNumbersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailableNumbersResponse
        /// </returns>
        public async Task<QueryAvailableNumbersResponse> QueryAvailableNumbersWithOptionsAsync(QueryAvailableNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAvailableNumbers",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAvailableNumbersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取玄坛合作伙伴双呼时可用外呼号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailableNumbersRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailableNumbersResponse
        /// </returns>
        public QueryAvailableNumbersResponse QueryAvailableNumbers(QueryAvailableNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAvailableNumbersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取玄坛合作伙伴双呼时可用外呼号码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAvailableNumbersRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAvailableNumbersResponse
        /// </returns>
        public async Task<QueryAvailableNumbersResponse> QueryAvailableNumbersAsync(QueryAvailableNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAvailableNumbersWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryBagRemainingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBagRemainingResponse
        /// </returns>
        public QueryBagRemainingResponse QueryBagRemainingWithOptions(QueryBagRemainingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBagRemaining",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBagRemainingResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBagRemainingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBagRemainingResponse
        /// </returns>
        public async Task<QueryBagRemainingResponse> QueryBagRemainingWithOptionsAsync(QueryBagRemainingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBagRemaining",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBagRemainingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBagRemainingRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBagRemainingResponse
        /// </returns>
        public QueryBagRemainingResponse QueryBagRemaining(QueryBagRemainingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBagRemainingWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryBagRemainingRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBagRemainingResponse
        /// </returns>
        public async Task<QueryBagRemainingResponse> QueryBagRemainingAsync(QueryBagRemainingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBagRemainingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询玄坛外呼语音文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCallRecordListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCallRecordListResponse
        /// </returns>
        public QueryCallRecordListResponse QueryCallRecordListWithOptions(QueryCallRecordListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillType))
            {
                query["SkillType"] = request.SkillType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCallRecordList",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallRecordListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询玄坛外呼语音文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCallRecordListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCallRecordListResponse
        /// </returns>
        public async Task<QueryCallRecordListResponse> QueryCallRecordListWithOptionsAsync(QueryCallRecordListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillType))
            {
                query["SkillType"] = request.SkillType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCallRecordList",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCallRecordListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询玄坛外呼语音文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCallRecordListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCallRecordListResponse
        /// </returns>
        public QueryCallRecordListResponse QueryCallRecordList(QueryCallRecordListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCallRecordListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询玄坛外呼语音文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCallRecordListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCallRecordListResponse
        /// </returns>
        public async Task<QueryCallRecordListResponse> QueryCallRecordListAsync(QueryCallRecordListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCallRecordListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceResponse
        /// </returns>
        public QueryInstanceResponse QueryInstanceWithOptions(QueryInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
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
                Action = "QueryInstance",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceResponse
        /// </returns>
        public async Task<QueryInstanceResponse> QueryInstanceWithOptionsAsync(QueryInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
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
                Action = "QueryInstance",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceResponse
        /// </returns>
        public QueryInstanceResponse QueryInstance(QueryInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryInstanceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryInstanceResponse
        /// </returns>
        public async Task<QueryInstanceResponse> QueryInstanceAsync(QueryInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>QueryPartnerIntentionList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPartnerIntentionListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPartnerIntentionListResponse
        /// </returns>
        public QueryPartnerIntentionListResponse QueryPartnerIntentionListWithOptions(QueryPartnerIntentionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPartnerIntentionList",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPartnerIntentionListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>QueryPartnerIntentionList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPartnerIntentionListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPartnerIntentionListResponse
        /// </returns>
        public async Task<QueryPartnerIntentionListResponse> QueryPartnerIntentionListWithOptionsAsync(QueryPartnerIntentionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPartnerIntentionList",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPartnerIntentionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>QueryPartnerIntentionList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPartnerIntentionListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPartnerIntentionListResponse
        /// </returns>
        public QueryPartnerIntentionListResponse QueryPartnerIntentionList(QueryPartnerIntentionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPartnerIntentionListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>QueryPartnerIntentionList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPartnerIntentionListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPartnerIntentionListResponse
        /// </returns>
        public async Task<QueryPartnerIntentionListResponse> QueryPartnerIntentionListAsync(QueryPartnerIntentionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPartnerIntentionListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>QueryPartnerProduceList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPartnerProduceListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPartnerProduceListResponse
        /// </returns>
        public QueryPartnerProduceListResponse QueryPartnerProduceListWithOptions(QueryPartnerProduceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPartnerProduceList",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPartnerProduceListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>QueryPartnerProduceList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPartnerProduceListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPartnerProduceListResponse
        /// </returns>
        public async Task<QueryPartnerProduceListResponse> QueryPartnerProduceListWithOptionsAsync(QueryPartnerProduceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPartnerProduceList",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPartnerProduceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>QueryPartnerProduceList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPartnerProduceListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPartnerProduceListResponse
        /// </returns>
        public QueryPartnerProduceListResponse QueryPartnerProduceList(QueryPartnerProduceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPartnerProduceListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>QueryPartnerProduceList</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryPartnerProduceListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPartnerProduceListResponse
        /// </returns>
        public async Task<QueryPartnerProduceListResponse> QueryPartnerProduceListAsync(QueryPartnerProduceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPartnerProduceListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryUserNeedAuthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserNeedAuthResponse
        /// </returns>
        public QueryUserNeedAuthResponse QueryUserNeedAuthWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserNeedAuth",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserNeedAuthResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryUserNeedAuthRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryUserNeedAuthResponse
        /// </returns>
        public async Task<QueryUserNeedAuthResponse> QueryUserNeedAuthWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserNeedAuth",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserNeedAuthResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// QueryUserNeedAuthResponse
        /// </returns>
        public QueryUserNeedAuthResponse QueryUserNeedAuth()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUserNeedAuthWithOptions(runtime);
        }

        /// <returns>
        /// QueryUserNeedAuthResponse
        /// </returns>
        public async Task<QueryUserNeedAuthResponse> QueryUserNeedAuthAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUserNeedAuthWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务商玄坛外呼呼叫中心事件回传</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecordCallCenterEventForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecordCallCenterEventForPartnerResponse
        /// </returns>
        public RecordCallCenterEventForPartnerResponse RecordCallCenterEventForPartnerWithOptions(RecordCallCenterEventForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallAction))
            {
                query["CallAction"] = request.CallAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Callee))
            {
                query["Callee"] = request.Callee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnId))
            {
                query["ConnId"] = request.ConnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmployeeCode))
            {
                query["EmployeeCode"] = request.EmployeeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedId))
            {
                query["RelatedId"] = request.RelatedId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretMobile))
            {
                query["SecretMobile"] = request.SecretMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillType))
            {
                query["SkillType"] = request.SkillType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordCallCenterEventForPartner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordCallCenterEventForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务商玄坛外呼呼叫中心事件回传</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecordCallCenterEventForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecordCallCenterEventForPartnerResponse
        /// </returns>
        public async Task<RecordCallCenterEventForPartnerResponse> RecordCallCenterEventForPartnerWithOptionsAsync(RecordCallCenterEventForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallAction))
            {
                query["CallAction"] = request.CallAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Callee))
            {
                query["Callee"] = request.Callee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnId))
            {
                query["ConnId"] = request.ConnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmployeeCode))
            {
                query["EmployeeCode"] = request.EmployeeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedId))
            {
                query["RelatedId"] = request.RelatedId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretMobile))
            {
                query["SecretMobile"] = request.SecretMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillType))
            {
                query["SkillType"] = request.SkillType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["TenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordCallCenterEventForPartner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordCallCenterEventForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务商玄坛外呼呼叫中心事件回传</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecordCallCenterEventForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// RecordCallCenterEventForPartnerResponse
        /// </returns>
        public RecordCallCenterEventForPartnerResponse RecordCallCenterEventForPartner(RecordCallCenterEventForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecordCallCenterEventForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>服务商玄坛外呼呼叫中心事件回传</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecordCallCenterEventForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// RecordCallCenterEventForPartnerResponse
        /// </returns>
        public async Task<RecordCallCenterEventForPartnerResponse> RecordCallCenterEventForPartnerAsync(RecordCallCenterEventForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecordCallCenterEventForPartnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RecordPostBack</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecordPostBackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecordPostBackResponse
        /// </returns>
        public RecordPostBackResponse RecordPostBackWithOptions(RecordPostBackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contactor))
            {
                query["contactor"] = request.Contactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityKey))
            {
                query["entityKey"] = request.EntityKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordPostBack",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordPostBackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RecordPostBack</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecordPostBackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecordPostBackResponse
        /// </returns>
        public async Task<RecordPostBackResponse> RecordPostBackWithOptionsAsync(RecordPostBackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["bizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Contactor))
            {
                query["contactor"] = request.Contactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntityKey))
            {
                query["entityKey"] = request.EntityKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordPostBack",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordPostBackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RecordPostBack</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecordPostBackRequest
        /// </param>
        /// 
        /// <returns>
        /// RecordPostBackResponse
        /// </returns>
        public RecordPostBackResponse RecordPostBack(RecordPostBackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecordPostBackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RecordPostBack</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecordPostBackRequest
        /// </param>
        /// 
        /// <returns>
        /// RecordPostBackResponse
        /// </returns>
        public async Task<RecordPostBackResponse> RecordPostBackAsync(RecordPostBackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecordPostBackWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RejectSolutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RejectSolutionResponse
        /// </returns>
        public RejectSolutionResponse RejectSolutionWithOptions(RejectSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionBizId))
            {
                query["SolutionBizId"] = request.SolutionBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectSolution",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectSolutionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RejectSolutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RejectSolutionResponse
        /// </returns>
        public async Task<RejectSolutionResponse> RejectSolutionWithOptionsAsync(RejectSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionBizId))
            {
                query["SolutionBizId"] = request.SolutionBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectSolution",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectSolutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RejectSolutionRequest
        /// </param>
        /// 
        /// <returns>
        /// RejectSolutionResponse
        /// </returns>
        public RejectSolutionResponse RejectSolution(RejectSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RejectSolutionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RejectSolutionRequest
        /// </param>
        /// 
        /// <returns>
        /// RejectSolutionResponse
        /// </returns>
        public async Task<RejectSolutionResponse> RejectSolutionAsync(RejectSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RejectSolutionWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RejectUserSolutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RejectUserSolutionResponse
        /// </returns>
        public RejectUserSolutionResponse RejectUserSolutionWithOptions(RejectUserSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionBizId))
            {
                query["SolutionBizId"] = request.SolutionBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectUserSolution",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectUserSolutionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RejectUserSolutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RejectUserSolutionResponse
        /// </returns>
        public async Task<RejectUserSolutionResponse> RejectUserSolutionWithOptionsAsync(RejectUserSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SolutionBizId))
            {
                query["SolutionBizId"] = request.SolutionBizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectUserSolution",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectUserSolutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RejectUserSolutionRequest
        /// </param>
        /// 
        /// <returns>
        /// RejectUserSolutionResponse
        /// </returns>
        public RejectUserSolutionResponse RejectUserSolution(RejectUserSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RejectUserSolutionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RejectUserSolutionRequest
        /// </param>
        /// 
        /// <returns>
        /// RejectUserSolutionResponse
        /// </returns>
        public async Task<RejectUserSolutionResponse> RejectUserSolutionAsync(RejectUserSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RejectUserSolutionWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ReleaseProduceAuthorizationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseProduceAuthorizationResponse
        /// </returns>
        public ReleaseProduceAuthorizationResponse ReleaseProduceAuthorizationWithOptions(ReleaseProduceAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedUserId))
            {
                body["AuthorizedUserId"] = request.AuthorizedUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseProduceAuthorization",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseProduceAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ReleaseProduceAuthorizationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseProduceAuthorizationResponse
        /// </returns>
        public async Task<ReleaseProduceAuthorizationResponse> ReleaseProduceAuthorizationWithOptionsAsync(ReleaseProduceAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizedUserId))
            {
                body["AuthorizedUserId"] = request.AuthorizedUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseProduceAuthorization",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseProduceAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ReleaseProduceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseProduceAuthorizationResponse
        /// </returns>
        public ReleaseProduceAuthorizationResponse ReleaseProduceAuthorization(ReleaseProduceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseProduceAuthorizationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ReleaseProduceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseProduceAuthorizationResponse
        /// </returns>
        public async Task<ReleaseProduceAuthorizationResponse> ReleaseProduceAuthorizationAsync(ReleaseProduceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseProduceAuthorizationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>玄坛双呼外呼发起</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartBackToBackCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartBackToBackCallResponse
        /// </returns>
        public StartBackToBackCallResponse StartBackToBackCallWithOptions(StartBackToBackCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallCenterNumber))
            {
                query["CallCenterNumber"] = request.CallCenterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileKey))
            {
                query["MobileKey"] = request.MobileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillType))
            {
                query["SkillType"] = request.SkillType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartBackToBackCall",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartBackToBackCallResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>玄坛双呼外呼发起</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartBackToBackCallRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartBackToBackCallResponse
        /// </returns>
        public async Task<StartBackToBackCallResponse> StartBackToBackCallWithOptionsAsync(StartBackToBackCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallCenterNumber))
            {
                query["CallCenterNumber"] = request.CallCenterNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Caller))
            {
                query["Caller"] = request.Caller;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileKey))
            {
                query["MobileKey"] = request.MobileKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillType))
            {
                query["SkillType"] = request.SkillType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartBackToBackCall",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartBackToBackCallResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>玄坛双呼外呼发起</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartBackToBackCallRequest
        /// </param>
        /// 
        /// <returns>
        /// StartBackToBackCallResponse
        /// </returns>
        public StartBackToBackCallResponse StartBackToBackCall(StartBackToBackCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartBackToBackCallWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>玄坛双呼外呼发起</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartBackToBackCallRequest
        /// </param>
        /// 
        /// <returns>
        /// StartBackToBackCallResponse
        /// </returns>
        public async Task<StartBackToBackCallResponse> StartBackToBackCallAsync(StartBackToBackCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartBackToBackCallWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴提交需求单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitIntentionForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitIntentionForPartnerResponse
        /// </returns>
        public SubmitIntentionForPartnerResponse SubmitIntentionForPartnerWithOptions(SubmitIntentionForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                query["CommodityType"] = request.CommodityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                query["Grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
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
                Action = "SubmitIntentionForPartner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIntentionForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴提交需求单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitIntentionForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitIntentionForPartnerResponse
        /// </returns>
        public async Task<SubmitIntentionForPartnerResponse> SubmitIntentionForPartnerWithOptionsAsync(SubmitIntentionForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                query["Area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                query["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityType))
            {
                query["CommodityType"] = request.CommodityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                query["ContactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                query["ExtInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Grade))
            {
                query["Grade"] = request.Grade;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["Mobile"] = request.Mobile;
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
                Action = "SubmitIntentionForPartner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIntentionForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴提交需求单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitIntentionForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitIntentionForPartnerResponse
        /// </returns>
        public SubmitIntentionForPartnerResponse SubmitIntentionForPartner(SubmitIntentionForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitIntentionForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴提交需求单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitIntentionForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitIntentionForPartnerResponse
        /// </returns>
        public async Task<SubmitIntentionForPartnerResponse> SubmitIntentionForPartnerAsync(SubmitIntentionForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitIntentionForPartnerWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SubmitIntentionNoteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitIntentionNoteResponse
        /// </returns>
        public SubmitIntentionNoteResponse SubmitIntentionNoteWithOptions(SubmitIntentionNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIntentionNote",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIntentionNoteResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitIntentionNoteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitIntentionNoteResponse
        /// </returns>
        public async Task<SubmitIntentionNoteResponse> SubmitIntentionNoteWithOptionsAsync(SubmitIntentionNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Note))
            {
                query["Note"] = request.Note;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitIntentionNote",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitIntentionNoteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitIntentionNoteRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitIntentionNoteResponse
        /// </returns>
        public SubmitIntentionNoteResponse SubmitIntentionNote(SubmitIntentionNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitIntentionNoteWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SubmitIntentionNoteRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitIntentionNoteResponse
        /// </returns>
        public async Task<SubmitIntentionNoteResponse> SubmitIntentionNoteAsync(SubmitIntentionNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitIntentionNoteWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SubmitSolutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSolutionResponse
        /// </returns>
        public SubmitSolutionResponse SubmitSolutionWithOptions(SubmitSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solution))
            {
                query["Solution"] = request.Solution;
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
                Action = "SubmitSolution",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSolutionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitSolutionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitSolutionResponse
        /// </returns>
        public async Task<SubmitSolutionResponse> SubmitSolutionWithOptionsAsync(SubmitSolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntentionBizId))
            {
                query["IntentionBizId"] = request.IntentionBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solution))
            {
                query["Solution"] = request.Solution;
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
                Action = "SubmitSolution",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitSolutionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitSolutionRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSolutionResponse
        /// </returns>
        public SubmitSolutionResponse SubmitSolution(SubmitSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSolutionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SubmitSolutionRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitSolutionResponse
        /// </returns>
        public async Task<SubmitSolutionResponse> SubmitSolutionAsync(SubmitSolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSolutionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>玄坛需求单转派小二</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferIntentionOwnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferIntentionOwnerResponse
        /// </returns>
        public TransferIntentionOwnerResponse TransferIntentionOwnerWithOptions(TransferIntentionOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmployeeCode))
            {
                query["EmployeeCode"] = request.EmployeeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonId))
            {
                query["PersonId"] = request.PersonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferIntentionOwner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferIntentionOwnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>玄坛需求单转派小二</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferIntentionOwnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferIntentionOwnerResponse
        /// </returns>
        public async Task<TransferIntentionOwnerResponse> TransferIntentionOwnerWithOptionsAsync(TransferIntentionOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmployeeCode))
            {
                query["EmployeeCode"] = request.EmployeeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonId))
            {
                query["PersonId"] = request.PersonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferIntentionOwner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferIntentionOwnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>玄坛需求单转派小二</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferIntentionOwnerRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferIntentionOwnerResponse
        /// </returns>
        public TransferIntentionOwnerResponse TransferIntentionOwner(TransferIntentionOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferIntentionOwnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>玄坛需求单转派小二</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferIntentionOwnerRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferIntentionOwnerResponse
        /// </returns>
        public async Task<TransferIntentionOwnerResponse> TransferIntentionOwnerAsync(TransferIntentionOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferIntentionOwnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>玄坛服务单转派小二</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferProduceOwnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferProduceOwnerResponse
        /// </returns>
        public TransferProduceOwnerResponse TransferProduceOwnerWithOptions(TransferProduceOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmployeeCode))
            {
                query["EmployeeCode"] = request.EmployeeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonId))
            {
                query["PersonId"] = request.PersonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferProduceOwner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferProduceOwnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>玄坛服务单转派小二</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferProduceOwnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferProduceOwnerResponse
        /// </returns>
        public async Task<TransferProduceOwnerResponse> TransferProduceOwnerWithOptionsAsync(TransferProduceOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmployeeCode))
            {
                query["EmployeeCode"] = request.EmployeeCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonId))
            {
                query["PersonId"] = request.PersonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferProduceOwner",
                Version = "2020-03-06",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferProduceOwnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>玄坛服务单转派小二</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferProduceOwnerRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferProduceOwnerResponse
        /// </returns>
        public TransferProduceOwnerResponse TransferProduceOwner(TransferProduceOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferProduceOwnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>玄坛服务单转派小二</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TransferProduceOwnerRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferProduceOwnerResponse
        /// </returns>
        public async Task<TransferProduceOwnerResponse> TransferProduceOwnerAsync(TransferProduceOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferProduceOwnerWithOptionsAsync(request, runtime);
        }

    }
}
