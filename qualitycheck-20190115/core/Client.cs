// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Qualitycheck20190115.Models;

namespace AlibabaCloud.SDK.Qualitycheck20190115
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("qualitycheck", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// AddBusinessCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBusinessCategoryResponse
        /// </returns>
        public AddBusinessCategoryResponse AddBusinessCategoryWithOptions(AddBusinessCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBusinessCategory",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBusinessCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddBusinessCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddBusinessCategoryResponse
        /// </returns>
        public async Task<AddBusinessCategoryResponse> AddBusinessCategoryWithOptionsAsync(AddBusinessCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddBusinessCategory",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddBusinessCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddBusinessCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBusinessCategoryResponse
        /// </returns>
        public AddBusinessCategoryResponse AddBusinessCategory(AddBusinessCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBusinessCategoryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddBusinessCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// AddBusinessCategoryResponse
        /// </returns>
        public async Task<AddBusinessCategoryResponse> AddBusinessCategoryAsync(AddBusinessCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBusinessCategoryWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AddRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRuleCategoryResponse
        /// </returns>
        public AddRuleCategoryResponse AddRuleCategoryWithOptions(AddRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRuleCategory",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRuleCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRuleCategoryResponse
        /// </returns>
        public async Task<AddRuleCategoryResponse> AddRuleCategoryWithOptionsAsync(AddRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRuleCategory",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRuleCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRuleCategoryResponse
        /// </returns>
        public AddRuleCategoryResponse AddRuleCategory(AddRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRuleCategoryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRuleCategoryResponse
        /// </returns>
        public async Task<AddRuleCategoryResponse> AddRuleCategoryAsync(AddRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRuleCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4创建规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRuleV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRuleV4Response
        /// </returns>
        public AddRuleV4Response AddRuleV4WithOptions(AddRuleV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCopy))
            {
                body["IsCopy"] = request.IsCopy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStrForRule))
            {
                body["JsonStrForRule"] = request.JsonStrForRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRuleV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRuleV4Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4创建规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRuleV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRuleV4Response
        /// </returns>
        public async Task<AddRuleV4Response> AddRuleV4WithOptionsAsync(AddRuleV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCopy))
            {
                body["IsCopy"] = request.IsCopy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStrForRule))
            {
                body["JsonStrForRule"] = request.JsonStrForRule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddRuleV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRuleV4Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4创建规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRuleV4Request
        /// </param>
        /// 
        /// <returns>
        /// AddRuleV4Response
        /// </returns>
        public AddRuleV4Response AddRuleV4(AddRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRuleV4WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4创建规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRuleV4Request
        /// </param>
        /// 
        /// <returns>
        /// AddRuleV4Response
        /// </returns>
        public async Task<AddRuleV4Response> AddRuleV4Async(AddRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRuleV4WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申领实时语音所需token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyWsTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyWsTokenResponse
        /// </returns>
        public ApplyWsTokenResponse ApplyWsTokenWithOptions(ApplyWsTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyWsToken",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyWsTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申领实时语音所需token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyWsTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyWsTokenResponse
        /// </returns>
        public async Task<ApplyWsTokenResponse> ApplyWsTokenWithOptionsAsync(ApplyWsTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyWsToken",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyWsTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申领实时语音所需token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyWsTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyWsTokenResponse
        /// </returns>
        public ApplyWsTokenResponse ApplyWsToken(ApplyWsTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyWsTokenWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申领实时语音所需token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ApplyWsTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyWsTokenResponse
        /// </returns>
        public async Task<ApplyWsTokenResponse> ApplyWsTokenAsync(ApplyWsTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyWsTokenWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// AssignReviewerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignReviewerResponse
        /// </returns>
        public AssignReviewerResponse AssignReviewerWithOptions(AssignReviewerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignReviewer",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignReviewerResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AssignReviewerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignReviewerResponse
        /// </returns>
        public async Task<AssignReviewerResponse> AssignReviewerWithOptionsAsync(AssignReviewerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignReviewer",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignReviewerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AssignReviewerRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignReviewerResponse
        /// </returns>
        public AssignReviewerResponse AssignReviewer(AssignReviewerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignReviewerWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AssignReviewerRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignReviewerResponse
        /// </returns>
        public async Task<AssignReviewerResponse> AssignReviewerAsync(AssignReviewerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignReviewerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI AssignReviewerBySessionGroup is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话组批量分配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignReviewerBySessionGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignReviewerBySessionGroupResponse
        /// </returns>
        [Obsolete("OpenAPI AssignReviewerBySessionGroup is deprecated")]
        // Deprecated
        public AssignReviewerBySessionGroupResponse AssignReviewerBySessionGroupWithOptions(AssignReviewerBySessionGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignReviewerBySessionGroup",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignReviewerBySessionGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI AssignReviewerBySessionGroup is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话组批量分配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignReviewerBySessionGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssignReviewerBySessionGroupResponse
        /// </returns>
        [Obsolete("OpenAPI AssignReviewerBySessionGroup is deprecated")]
        // Deprecated
        public async Task<AssignReviewerBySessionGroupResponse> AssignReviewerBySessionGroupWithOptionsAsync(AssignReviewerBySessionGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssignReviewerBySessionGroup",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssignReviewerBySessionGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI AssignReviewerBySessionGroup is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话组批量分配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignReviewerBySessionGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignReviewerBySessionGroupResponse
        /// </returns>
        [Obsolete("OpenAPI AssignReviewerBySessionGroup is deprecated")]
        // Deprecated
        public AssignReviewerBySessionGroupResponse AssignReviewerBySessionGroup(AssignReviewerBySessionGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignReviewerBySessionGroupWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI AssignReviewerBySessionGroup is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话组批量分配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssignReviewerBySessionGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AssignReviewerBySessionGroupResponse
        /// </returns>
        [Obsolete("OpenAPI AssignReviewerBySessionGroup is deprecated")]
        // Deprecated
        public async Task<AssignReviewerBySessionGroupResponse> AssignReviewerBySessionGroupAsync(AssignReviewerBySessionGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignReviewerBySessionGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量复核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSubmitReviewInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSubmitReviewInfoResponse
        /// </returns>
        public BatchSubmitReviewInfoResponse BatchSubmitReviewInfoWithOptions(BatchSubmitReviewInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSubmitReviewInfo",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSubmitReviewInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量复核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSubmitReviewInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSubmitReviewInfoResponse
        /// </returns>
        public async Task<BatchSubmitReviewInfoResponse> BatchSubmitReviewInfoWithOptionsAsync(BatchSubmitReviewInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSubmitReviewInfo",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSubmitReviewInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量复核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSubmitReviewInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSubmitReviewInfoResponse
        /// </returns>
        public BatchSubmitReviewInfoResponse BatchSubmitReviewInfo(BatchSubmitReviewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSubmitReviewInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量复核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchSubmitReviewInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSubmitReviewInfoResponse
        /// </returns>
        public async Task<BatchSubmitReviewInfoResponse> BatchSubmitReviewInfoAsync(BatchSubmitReviewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSubmitReviewInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建热词模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAsrVocabRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAsrVocabResponse
        /// </returns>
        public CreateAsrVocabResponse CreateAsrVocabWithOptions(CreateAsrVocabRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAsrVocab",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAsrVocabResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建热词模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAsrVocabRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAsrVocabResponse
        /// </returns>
        public async Task<CreateAsrVocabResponse> CreateAsrVocabWithOptionsAsync(CreateAsrVocabRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAsrVocab",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAsrVocabResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建热词模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAsrVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAsrVocabResponse
        /// </returns>
        public CreateAsrVocabResponse CreateAsrVocab(CreateAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAsrVocabWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建热词模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAsrVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAsrVocabResponse
        /// </returns>
        public async Task<CreateAsrVocabResponse> CreateAsrVocabAsync(CreateAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAsrVocabWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建质检方案中的质检维度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCheckTypeToSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCheckTypeToSchemeResponse
        /// </returns>
        public CreateCheckTypeToSchemeResponse CreateCheckTypeToSchemeWithOptions(CreateCheckTypeToSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCheckTypeToScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCheckTypeToSchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建质检方案中的质检维度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCheckTypeToSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCheckTypeToSchemeResponse
        /// </returns>
        public async Task<CreateCheckTypeToSchemeResponse> CreateCheckTypeToSchemeWithOptionsAsync(CreateCheckTypeToSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCheckTypeToScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCheckTypeToSchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建质检方案中的质检维度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCheckTypeToSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCheckTypeToSchemeResponse
        /// </returns>
        public CreateCheckTypeToSchemeResponse CreateCheckTypeToScheme(CreateCheckTypeToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCheckTypeToSchemeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建质检方案中的质检维度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCheckTypeToSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCheckTypeToSchemeResponse
        /// </returns>
        public async Task<CreateCheckTypeToSchemeResponse> CreateCheckTypeToSchemeAsync(CreateCheckTypeToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCheckTypeToSchemeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQualityCheckSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityCheckSchemeResponse
        /// </returns>
        public CreateQualityCheckSchemeResponse CreateQualityCheckSchemeWithOptions(CreateQualityCheckSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQualityCheckScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQualityCheckSchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQualityCheckSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityCheckSchemeResponse
        /// </returns>
        public async Task<CreateQualityCheckSchemeResponse> CreateQualityCheckSchemeWithOptionsAsync(CreateQualityCheckSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQualityCheckScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQualityCheckSchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQualityCheckSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityCheckSchemeResponse
        /// </returns>
        public CreateQualityCheckSchemeResponse CreateQualityCheckScheme(CreateQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityCheckSchemeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新增质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQualityCheckSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQualityCheckSchemeResponse
        /// </returns>
        public async Task<CreateQualityCheckSchemeResponse> CreateQualityCheckSchemeAsync(CreateQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityCheckSchemeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建质检任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSchemeTaskConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSchemeTaskConfigResponse
        /// </returns>
        public CreateSchemeTaskConfigResponse CreateSchemeTaskConfigWithOptions(CreateSchemeTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSchemeTaskConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSchemeTaskConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建质检任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSchemeTaskConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSchemeTaskConfigResponse
        /// </returns>
        public async Task<CreateSchemeTaskConfigResponse> CreateSchemeTaskConfigWithOptionsAsync(CreateSchemeTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSchemeTaskConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSchemeTaskConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建质检任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSchemeTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSchemeTaskConfigResponse
        /// </returns>
        public CreateSchemeTaskConfigResponse CreateSchemeTaskConfig(CreateSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSchemeTaskConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>新建质检任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSchemeTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSchemeTaskConfigResponse
        /// </returns>
        public async Task<CreateSchemeTaskConfigResponse> CreateSchemeTaskConfigAsync(CreateSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSchemeTaskConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// CreateSkillGroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI CreateSkillGroupConfig is deprecated")]
        // Deprecated
        public CreateSkillGroupConfigResponse CreateSkillGroupConfigWithOptions(CreateSkillGroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkillGroupConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillGroupConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// CreateSkillGroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI CreateSkillGroupConfig is deprecated")]
        // Deprecated
        public async Task<CreateSkillGroupConfigResponse> CreateSkillGroupConfigWithOptionsAsync(CreateSkillGroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkillGroupConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillGroupConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// CreateSkillGroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI CreateSkillGroupConfig is deprecated")]
        // Deprecated
        public CreateSkillGroupConfigResponse CreateSkillGroupConfig(CreateSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSkillGroupConfigWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// CreateSkillGroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI CreateSkillGroupConfig is deprecated")]
        // Deprecated
        public async Task<CreateSkillGroupConfigResponse> CreateSkillGroupConfigAsync(CreateSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSkillGroupConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateTaskAssignRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskAssignRuleResponse
        /// </returns>
        public CreateTaskAssignRuleResponse CreateTaskAssignRuleWithOptions(CreateTaskAssignRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTaskAssignRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskAssignRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateTaskAssignRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskAssignRuleResponse
        /// </returns>
        public async Task<CreateTaskAssignRuleResponse> CreateTaskAssignRuleWithOptionsAsync(CreateTaskAssignRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTaskAssignRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskAssignRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateTaskAssignRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskAssignRuleResponse
        /// </returns>
        public CreateTaskAssignRuleResponse CreateTaskAssignRule(CreateTaskAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTaskAssignRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateTaskAssignRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskAssignRuleResponse
        /// </returns>
        public async Task<CreateTaskAssignRuleResponse> CreateTaskAssignRuleAsync(CreateTaskAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTaskAssignRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CreateWarningConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWarningConfigResponse
        /// </returns>
        public CreateWarningConfigResponse CreateWarningConfigWithOptions(CreateWarningConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWarningConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWarningConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateWarningConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWarningConfigResponse
        /// </returns>
        public async Task<CreateWarningConfigResponse> CreateWarningConfigWithOptionsAsync(CreateWarningConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWarningConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWarningConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateWarningConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWarningConfigResponse
        /// </returns>
        public CreateWarningConfigResponse CreateWarningConfig(CreateWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWarningConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CreateWarningConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWarningConfigResponse
        /// </returns>
        public async Task<CreateWarningConfigResponse> CreateWarningConfigAsync(CreateWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWarningConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWarningStrategyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWarningStrategyConfigResponse
        /// </returns>
        public CreateWarningStrategyConfigResponse CreateWarningStrategyConfigWithOptions(CreateWarningStrategyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWarningStrategyConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWarningStrategyConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWarningStrategyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWarningStrategyConfigResponse
        /// </returns>
        public async Task<CreateWarningStrategyConfigResponse> CreateWarningStrategyConfigWithOptionsAsync(CreateWarningStrategyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWarningStrategyConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWarningStrategyConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWarningStrategyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWarningStrategyConfigResponse
        /// </returns>
        public CreateWarningStrategyConfigResponse CreateWarningStrategyConfig(CreateWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWarningStrategyConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-新增</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWarningStrategyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWarningStrategyConfigResponse
        /// </returns>
        public async Task<CreateWarningStrategyConfigResponse> CreateWarningStrategyConfigAsync(CreateWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWarningStrategyConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DelRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelRuleCategoryResponse
        /// </returns>
        public DelRuleCategoryResponse DelRuleCategoryWithOptions(DelRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelRuleCategory",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelRuleCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DelRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DelRuleCategoryResponse
        /// </returns>
        public async Task<DelRuleCategoryResponse> DelRuleCategoryWithOptionsAsync(DelRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DelRuleCategory",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DelRuleCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DelRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DelRuleCategoryResponse
        /// </returns>
        public DelRuleCategoryResponse DelRuleCategory(DelRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DelRuleCategoryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DelRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DelRuleCategoryResponse
        /// </returns>
        public async Task<DelRuleCategoryResponse> DelRuleCategoryAsync(DelRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DelRuleCategoryWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteAsrVocabRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAsrVocabResponse
        /// </returns>
        public DeleteAsrVocabResponse DeleteAsrVocabWithOptions(DeleteAsrVocabRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAsrVocab",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAsrVocabResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteAsrVocabRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAsrVocabResponse
        /// </returns>
        public async Task<DeleteAsrVocabResponse> DeleteAsrVocabWithOptionsAsync(DeleteAsrVocabRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAsrVocab",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAsrVocabResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteAsrVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAsrVocabResponse
        /// </returns>
        public DeleteAsrVocabResponse DeleteAsrVocab(DeleteAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAsrVocabWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteAsrVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAsrVocabResponse
        /// </returns>
        public async Task<DeleteAsrVocabResponse> DeleteAsrVocabAsync(DeleteAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAsrVocabWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteBusinessCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBusinessCategoryResponse
        /// </returns>
        public DeleteBusinessCategoryResponse DeleteBusinessCategoryWithOptions(DeleteBusinessCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBusinessCategory",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBusinessCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteBusinessCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBusinessCategoryResponse
        /// </returns>
        public async Task<DeleteBusinessCategoryResponse> DeleteBusinessCategoryWithOptionsAsync(DeleteBusinessCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBusinessCategory",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBusinessCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteBusinessCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBusinessCategoryResponse
        /// </returns>
        public DeleteBusinessCategoryResponse DeleteBusinessCategory(DeleteBusinessCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBusinessCategoryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteBusinessCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBusinessCategoryResponse
        /// </returns>
        public async Task<DeleteBusinessCategoryResponse> DeleteBusinessCategoryAsync(DeleteBusinessCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBusinessCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除质检唯独</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCheckTypeToSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCheckTypeToSchemeResponse
        /// </returns>
        public DeleteCheckTypeToSchemeResponse DeleteCheckTypeToSchemeWithOptions(DeleteCheckTypeToSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCheckTypeToScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCheckTypeToSchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除质检唯独</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCheckTypeToSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCheckTypeToSchemeResponse
        /// </returns>
        public async Task<DeleteCheckTypeToSchemeResponse> DeleteCheckTypeToSchemeWithOptionsAsync(DeleteCheckTypeToSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCheckTypeToScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCheckTypeToSchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除质检唯独</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCheckTypeToSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCheckTypeToSchemeResponse
        /// </returns>
        public DeleteCheckTypeToSchemeResponse DeleteCheckTypeToScheme(DeleteCheckTypeToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCheckTypeToSchemeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除质检唯独</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCheckTypeToSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCheckTypeToSchemeResponse
        /// </returns>
        public async Task<DeleteCheckTypeToSchemeResponse> DeleteCheckTypeToSchemeAsync(DeleteCheckTypeToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCheckTypeToSchemeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteCustomizationConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomizationConfigResponse
        /// </returns>
        public DeleteCustomizationConfigResponse DeleteCustomizationConfigWithOptions(DeleteCustomizationConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomizationConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomizationConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteCustomizationConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomizationConfigResponse
        /// </returns>
        public async Task<DeleteCustomizationConfigResponse> DeleteCustomizationConfigWithOptionsAsync(DeleteCustomizationConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomizationConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomizationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteCustomizationConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomizationConfigResponse
        /// </returns>
        public DeleteCustomizationConfigResponse DeleteCustomizationConfig(DeleteCustomizationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomizationConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteCustomizationConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomizationConfigResponse
        /// </returns>
        public async Task<DeleteCustomizationConfigResponse> DeleteCustomizationConfigAsync(DeleteCustomizationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomizationConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteDataSet is deprecated
        /// 
        /// <param name="request">
        /// DeleteDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteDataSet is deprecated")]
        // Deprecated
        public DeleteDataSetResponse DeleteDataSetWithOptions(DeleteDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSet",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteDataSet is deprecated
        /// 
        /// <param name="request">
        /// DeleteDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteDataSet is deprecated")]
        // Deprecated
        public async Task<DeleteDataSetResponse> DeleteDataSetWithOptionsAsync(DeleteDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataSet",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteDataSet is deprecated
        /// 
        /// <param name="request">
        /// DeleteDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteDataSet is deprecated")]
        // Deprecated
        public DeleteDataSetResponse DeleteDataSet(DeleteDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSetWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteDataSet is deprecated
        /// 
        /// <param name="request">
        /// DeleteDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataSetResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteDataSet is deprecated")]
        // Deprecated
        public async Task<DeleteDataSetResponse> DeleteDataSetAsync(DeleteDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSetWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeletePrecisionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrecisionTaskResponse
        /// </returns>
        public DeletePrecisionTaskResponse DeletePrecisionTaskWithOptions(DeletePrecisionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrecisionTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrecisionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeletePrecisionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrecisionTaskResponse
        /// </returns>
        public async Task<DeletePrecisionTaskResponse> DeletePrecisionTaskWithOptionsAsync(DeletePrecisionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrecisionTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrecisionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeletePrecisionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrecisionTaskResponse
        /// </returns>
        public DeletePrecisionTaskResponse DeletePrecisionTask(DeletePrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePrecisionTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeletePrecisionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrecisionTaskResponse
        /// </returns>
        public async Task<DeletePrecisionTaskResponse> DeletePrecisionTaskAsync(DeletePrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePrecisionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQualityCheckSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQualityCheckSchemeResponse
        /// </returns>
        public DeleteQualityCheckSchemeResponse DeleteQualityCheckSchemeWithOptions(DeleteQualityCheckSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQualityCheckScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQualityCheckSchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQualityCheckSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQualityCheckSchemeResponse
        /// </returns>
        public async Task<DeleteQualityCheckSchemeResponse> DeleteQualityCheckSchemeWithOptionsAsync(DeleteQualityCheckSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQualityCheckScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQualityCheckSchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQualityCheckSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQualityCheckSchemeResponse
        /// </returns>
        public DeleteQualityCheckSchemeResponse DeleteQualityCheckScheme(DeleteQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityCheckSchemeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQualityCheckSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQualityCheckSchemeResponse
        /// </returns>
        public async Task<DeleteQualityCheckSchemeResponse> DeleteQualityCheckSchemeAsync(DeleteQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityCheckSchemeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.")]
        // Deprecated
        public DeleteRuleResponse DeleteRuleWithOptions(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDelete))
            {
                body["ForceDelete"] = request.ForceDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSchemeData))
            {
                body["IsSchemeData"] = request.IsSchemeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.")]
        // Deprecated
        public async Task<DeleteRuleResponse> DeleteRuleWithOptionsAsync(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDelete))
            {
                body["ForceDelete"] = request.ForceDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSchemeData))
            {
                body["IsSchemeData"] = request.IsSchemeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.")]
        // Deprecated
        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.")]
        // Deprecated
        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4删除规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRuleV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleV4Response
        /// </returns>
        public DeleteRuleV4Response DeleteRuleV4WithOptions(DeleteRuleV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDelete))
            {
                body["ForceDelete"] = request.ForceDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRuleV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleV4Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4删除规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRuleV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleV4Response
        /// </returns>
        public async Task<DeleteRuleV4Response> DeleteRuleV4WithOptionsAsync(DeleteRuleV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDelete))
            {
                body["ForceDelete"] = request.ForceDelete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRuleV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleV4Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4删除规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRuleV4Request
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleV4Response
        /// </returns>
        public DeleteRuleV4Response DeleteRuleV4(DeleteRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleV4WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4删除规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRuleV4Request
        /// </param>
        /// 
        /// <returns>
        /// DeleteRuleV4Response
        /// </returns>
        public async Task<DeleteRuleV4Response> DeleteRuleV4Async(DeleteRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleV4WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除质检任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSchemeTaskConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSchemeTaskConfigResponse
        /// </returns>
        public DeleteSchemeTaskConfigResponse DeleteSchemeTaskConfigWithOptions(DeleteSchemeTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSchemeTaskConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSchemeTaskConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除质检任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSchemeTaskConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSchemeTaskConfigResponse
        /// </returns>
        public async Task<DeleteSchemeTaskConfigResponse> DeleteSchemeTaskConfigWithOptionsAsync(DeleteSchemeTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSchemeTaskConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSchemeTaskConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除质检任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSchemeTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSchemeTaskConfigResponse
        /// </returns>
        public DeleteSchemeTaskConfigResponse DeleteSchemeTaskConfig(DeleteSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSchemeTaskConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除质检任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSchemeTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSchemeTaskConfigResponse
        /// </returns>
        public async Task<DeleteSchemeTaskConfigResponse> DeleteSchemeTaskConfigAsync(DeleteSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSchemeTaskConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// DeleteSkillGroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteSkillGroupConfig is deprecated")]
        // Deprecated
        public DeleteSkillGroupConfigResponse DeleteSkillGroupConfigWithOptions(DeleteSkillGroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkillGroupConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillGroupConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// DeleteSkillGroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteSkillGroupConfig is deprecated")]
        // Deprecated
        public async Task<DeleteSkillGroupConfigResponse> DeleteSkillGroupConfigWithOptionsAsync(DeleteSkillGroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkillGroupConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillGroupConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// DeleteSkillGroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteSkillGroupConfig is deprecated")]
        // Deprecated
        public DeleteSkillGroupConfigResponse DeleteSkillGroupConfig(DeleteSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSkillGroupConfigWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI DeleteSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// DeleteSkillGroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI DeleteSkillGroupConfig is deprecated")]
        // Deprecated
        public async Task<DeleteSkillGroupConfigResponse> DeleteSkillGroupConfigAsync(DeleteSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSkillGroupConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteTaskAssignRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTaskAssignRuleResponse
        /// </returns>
        public DeleteTaskAssignRuleResponse DeleteTaskAssignRuleWithOptions(DeleteTaskAssignRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTaskAssignRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTaskAssignRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteTaskAssignRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTaskAssignRuleResponse
        /// </returns>
        public async Task<DeleteTaskAssignRuleResponse> DeleteTaskAssignRuleWithOptionsAsync(DeleteTaskAssignRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTaskAssignRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTaskAssignRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteTaskAssignRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTaskAssignRuleResponse
        /// </returns>
        public DeleteTaskAssignRuleResponse DeleteTaskAssignRule(DeleteTaskAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTaskAssignRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteTaskAssignRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTaskAssignRuleResponse
        /// </returns>
        public async Task<DeleteTaskAssignRuleResponse> DeleteTaskAssignRuleAsync(DeleteTaskAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTaskAssignRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteWarningConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWarningConfigResponse
        /// </returns>
        public DeleteWarningConfigResponse DeleteWarningConfigWithOptions(DeleteWarningConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWarningConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWarningConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteWarningConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWarningConfigResponse
        /// </returns>
        public async Task<DeleteWarningConfigResponse> DeleteWarningConfigWithOptionsAsync(DeleteWarningConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWarningConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWarningConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteWarningConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWarningConfigResponse
        /// </returns>
        public DeleteWarningConfigResponse DeleteWarningConfig(DeleteWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWarningConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteWarningConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWarningConfigResponse
        /// </returns>
        public async Task<DeleteWarningConfigResponse> DeleteWarningConfigAsync(DeleteWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWarningConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWarningStrategyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWarningStrategyConfigResponse
        /// </returns>
        public DeleteWarningStrategyConfigResponse DeleteWarningStrategyConfigWithOptions(DeleteWarningStrategyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWarningStrategyConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWarningStrategyConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWarningStrategyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWarningStrategyConfigResponse
        /// </returns>
        public async Task<DeleteWarningStrategyConfigResponse> DeleteWarningStrategyConfigWithOptionsAsync(DeleteWarningStrategyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWarningStrategyConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWarningStrategyConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWarningStrategyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWarningStrategyConfigResponse
        /// </returns>
        public DeleteWarningStrategyConfigResponse DeleteWarningStrategyConfig(DeleteWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWarningStrategyConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteWarningStrategyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWarningStrategyConfigResponse
        /// </returns>
        public async Task<DeleteWarningStrategyConfigResponse> DeleteWarningStrategyConfigAsync(DeleteWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWarningStrategyConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAsrVocabRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsrVocabResponse
        /// </returns>
        public GetAsrVocabResponse GetAsrVocabWithOptions(GetAsrVocabRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsrVocab",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsrVocabResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAsrVocabRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAsrVocabResponse
        /// </returns>
        public async Task<GetAsrVocabResponse> GetAsrVocabWithOptionsAsync(GetAsrVocabRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsrVocab",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsrVocabResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAsrVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsrVocabResponse
        /// </returns>
        public GetAsrVocabResponse GetAsrVocab(GetAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsrVocabWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAsrVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAsrVocabResponse
        /// </returns>
        public async Task<GetAsrVocabResponse> GetAsrVocabAsync(GetAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsrVocabWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetBusinessCategoryListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBusinessCategoryListResponse
        /// </returns>
        public GetBusinessCategoryListResponse GetBusinessCategoryListWithOptions(GetBusinessCategoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBusinessCategoryList",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBusinessCategoryListResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetBusinessCategoryListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBusinessCategoryListResponse
        /// </returns>
        public async Task<GetBusinessCategoryListResponse> GetBusinessCategoryListWithOptionsAsync(GetBusinessCategoryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBusinessCategoryList",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBusinessCategoryListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetBusinessCategoryListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBusinessCategoryListResponse
        /// </returns>
        public GetBusinessCategoryListResponse GetBusinessCategoryList(GetBusinessCategoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBusinessCategoryListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetBusinessCategoryListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetBusinessCategoryListResponse
        /// </returns>
        public async Task<GetBusinessCategoryListResponse> GetBusinessCategoryListAsync(GetBusinessCategoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBusinessCategoryListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取语音模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomizationConfigListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomizationConfigListResponse
        /// </returns>
        public GetCustomizationConfigListResponse GetCustomizationConfigListWithOptions(GetCustomizationConfigListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomizationConfigList",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomizationConfigListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取语音模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomizationConfigListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomizationConfigListResponse
        /// </returns>
        public async Task<GetCustomizationConfigListResponse> GetCustomizationConfigListWithOptionsAsync(GetCustomizationConfigListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomizationConfigList",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomizationConfigListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取语音模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomizationConfigListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomizationConfigListResponse
        /// </returns>
        public GetCustomizationConfigListResponse GetCustomizationConfigList(GetCustomizationConfigListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomizationConfigListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取语音模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomizationConfigListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomizationConfigListResponse
        /// </returns>
        public async Task<GetCustomizationConfigListResponse> GetCustomizationConfigListAsync(GetCustomizationConfigListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomizationConfigListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetNextResultToVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNextResultToVerifyResponse
        /// </returns>
        public GetNextResultToVerifyResponse GetNextResultToVerifyWithOptions(GetNextResultToVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNextResultToVerify",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNextResultToVerifyResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetNextResultToVerifyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNextResultToVerifyResponse
        /// </returns>
        public async Task<GetNextResultToVerifyResponse> GetNextResultToVerifyWithOptionsAsync(GetNextResultToVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNextResultToVerify",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNextResultToVerifyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetNextResultToVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNextResultToVerifyResponse
        /// </returns>
        public GetNextResultToVerifyResponse GetNextResultToVerify(GetNextResultToVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNextResultToVerifyWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetNextResultToVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNextResultToVerifyResponse
        /// </returns>
        public async Task<GetNextResultToVerifyResponse> GetNextResultToVerifyAsync(GetNextResultToVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNextResultToVerifyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetPrecisionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrecisionTaskResponse
        /// </returns>
        public GetPrecisionTaskResponse GetPrecisionTaskWithOptions(GetPrecisionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrecisionTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrecisionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetPrecisionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrecisionTaskResponse
        /// </returns>
        public async Task<GetPrecisionTaskResponse> GetPrecisionTaskWithOptionsAsync(GetPrecisionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrecisionTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrecisionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetPrecisionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrecisionTaskResponse
        /// </returns>
        public GetPrecisionTaskResponse GetPrecisionTask(GetPrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPrecisionTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetPrecisionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrecisionTaskResponse
        /// </returns>
        public async Task<GetPrecisionTaskResponse> GetPrecisionTaskAsync(GetPrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPrecisionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQualityCheckSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityCheckSchemeResponse
        /// </returns>
        public GetQualityCheckSchemeResponse GetQualityCheckSchemeWithOptions(GetQualityCheckSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQualityCheckScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityCheckSchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQualityCheckSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualityCheckSchemeResponse
        /// </returns>
        public async Task<GetQualityCheckSchemeResponse> GetQualityCheckSchemeWithOptionsAsync(GetQualityCheckSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQualityCheckScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualityCheckSchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQualityCheckSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityCheckSchemeResponse
        /// </returns>
        public GetQualityCheckSchemeResponse GetQualityCheckScheme(GetQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityCheckSchemeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQualityCheckSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualityCheckSchemeResponse
        /// </returns>
        public async Task<GetQualityCheckSchemeResponse> GetQualityCheckSchemeAsync(GetQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityCheckSchemeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResultResponse
        /// </returns>
        public GetResultResponse GetResultWithOptions(GetResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResult",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResultResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResultResponse
        /// </returns>
        public async Task<GetResultResponse> GetResultWithOptionsAsync(GetResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResult",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResultResponse
        /// </returns>
        public GetResultResponse GetResult(GetResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResultWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResultResponse
        /// </returns>
        public async Task<GetResultResponse> GetResultAsync(GetResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResultWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetResultToReviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResultToReviewResponse
        /// </returns>
        public GetResultToReviewResponse GetResultToReviewWithOptions(GetResultToReviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResultToReview",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResultToReviewResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetResultToReviewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResultToReviewResponse
        /// </returns>
        public async Task<GetResultToReviewResponse> GetResultToReviewWithOptionsAsync(GetResultToReviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResultToReview",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResultToReviewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetResultToReviewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResultToReviewResponse
        /// </returns>
        public GetResultToReviewResponse GetResultToReview(GetResultToReviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResultToReviewWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetResultToReviewRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResultToReviewResponse
        /// </returns>
        public async Task<GetResultToReviewResponse> GetResultToReviewAsync(GetResultToReviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResultToReviewWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetRule is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
        /// 
        /// <param name="request">
        /// GetRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuleResponse
        /// </returns>
        [Obsolete("OpenAPI GetRule is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.")]
        // Deprecated
        public GetRuleResponse GetRuleWithOptions(GetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetRule is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
        /// 
        /// <param name="request">
        /// GetRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuleResponse
        /// </returns>
        [Obsolete("OpenAPI GetRule is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.")]
        // Deprecated
        public async Task<GetRuleResponse> GetRuleWithOptionsAsync(GetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetRule is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
        /// 
        /// <param name="request">
        /// GetRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuleResponse
        /// </returns>
        [Obsolete("OpenAPI GetRule is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.")]
        // Deprecated
        public GetRuleResponse GetRule(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetRule is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
        /// 
        /// <param name="request">
        /// GetRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuleResponse
        /// </returns>
        [Obsolete("OpenAPI GetRule is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.")]
        // Deprecated
        public async Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetRuleById is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRuleByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuleByIdResponse
        /// </returns>
        [Obsolete("OpenAPI GetRuleById is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.")]
        // Deprecated
        public GetRuleByIdResponse GetRuleByIdWithOptions(GetRuleByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRuleById",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetRuleById is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRuleByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuleByIdResponse
        /// </returns>
        [Obsolete("OpenAPI GetRuleById is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.")]
        // Deprecated
        public async Task<GetRuleByIdResponse> GetRuleByIdWithOptionsAsync(GetRuleByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRuleById",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetRuleById is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRuleByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuleByIdResponse
        /// </returns>
        [Obsolete("OpenAPI GetRuleById is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.")]
        // Deprecated
        public GetRuleByIdResponse GetRuleById(GetRuleByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleByIdWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetRuleById is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRuleByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuleByIdResponse
        /// </returns>
        [Obsolete("OpenAPI GetRuleById is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.")]
        // Deprecated
        public async Task<GetRuleByIdResponse> GetRuleByIdAsync(GetRuleByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleByIdWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuleCategoryResponse
        /// </returns>
        public GetRuleCategoryResponse GetRuleCategoryWithOptions(GetRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRuleCategory",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleCategoryResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRuleCategoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuleCategoryResponse
        /// </returns>
        public async Task<GetRuleCategoryResponse> GetRuleCategoryWithOptionsAsync(GetRuleCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRuleCategory",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleCategoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuleCategoryResponse
        /// </returns>
        public GetRuleCategoryResponse GetRuleCategory(GetRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleCategoryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetRuleCategoryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuleCategoryResponse
        /// </returns>
        public async Task<GetRuleCategoryResponse> GetRuleCategoryAsync(GetRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleCategoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetRuleDetail is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
        /// 
        /// <param name="request">
        /// GetRuleDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuleDetailResponse
        /// </returns>
        [Obsolete("OpenAPI GetRuleDetail is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.")]
        // Deprecated
        public GetRuleDetailResponse GetRuleDetailWithOptions(GetRuleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRuleDetail",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetRuleDetail is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
        /// 
        /// <param name="request">
        /// GetRuleDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuleDetailResponse
        /// </returns>
        [Obsolete("OpenAPI GetRuleDetail is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.")]
        // Deprecated
        public async Task<GetRuleDetailResponse> GetRuleDetailWithOptionsAsync(GetRuleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRuleDetail",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetRuleDetail is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
        /// 
        /// <param name="request">
        /// GetRuleDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuleDetailResponse
        /// </returns>
        [Obsolete("OpenAPI GetRuleDetail is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.")]
        // Deprecated
        public GetRuleDetailResponse GetRuleDetail(GetRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleDetailWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetRuleDetail is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
        /// 
        /// <param name="request">
        /// GetRuleDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRuleDetailResponse
        /// </returns>
        [Obsolete("OpenAPI GetRuleDetail is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.")]
        // Deprecated
        public async Task<GetRuleDetailResponse> GetRuleDetailAsync(GetRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4获取规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRuleV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuleV4Response
        /// </returns>
        public GetRuleV4Response GetRuleV4WithOptions(GetRuleV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRuleV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleV4Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4获取规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRuleV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRuleV4Response
        /// </returns>
        public async Task<GetRuleV4Response> GetRuleV4WithOptionsAsync(GetRuleV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRuleV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleV4Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4获取规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRuleV4Request
        /// </param>
        /// 
        /// <returns>
        /// GetRuleV4Response
        /// </returns>
        public GetRuleV4Response GetRuleV4(GetRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleV4WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4获取规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRuleV4Request
        /// </param>
        /// 
        /// <returns>
        /// GetRuleV4Response
        /// </returns>
        public async Task<GetRuleV4Response> GetRuleV4Async(GetRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleV4WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRulesCountListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRulesCountListResponse
        /// </returns>
        public GetRulesCountListResponse GetRulesCountListWithOptions(GetRulesCountListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessName))
            {
                body["BusinessName"] = request.BusinessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessRange))
            {
                body["BusinessRange"] = request.BusinessRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountTotal))
            {
                body["CountTotal"] = request.CountTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEmpid))
            {
                body["CreateEmpid"] = request.CreateEmpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                body["CreateUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastUpdateEmpid))
            {
                body["LastUpdateEmpid"] = request.LastUpdateEmpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireInfos))
            {
                body["RequireInfos"] = request.RequireInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rid))
            {
                body["Rid"] = request.Rid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIdOrRuleName))
            {
                body["RuleIdOrRuleName"] = request.RuleIdOrRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleScoreSingleType))
            {
                body["RuleScoreSingleType"] = request.RuleScoreSingleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeId))
            {
                body["SchemeId"] = request.SchemeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeName))
            {
                body["TypeName"] = request.TypeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                body["UpdateEndTime"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                body["UpdateStartTime"] = request.UpdateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateUserId))
            {
                body["UpdateUserId"] = request.UpdateUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRulesCountList",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRulesCountListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRulesCountListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRulesCountListResponse
        /// </returns>
        public async Task<GetRulesCountListResponse> GetRulesCountListWithOptionsAsync(GetRulesCountListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessName))
            {
                body["BusinessName"] = request.BusinessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessRange))
            {
                body["BusinessRange"] = request.BusinessRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountTotal))
            {
                body["CountTotal"] = request.CountTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEmpid))
            {
                body["CreateEmpid"] = request.CreateEmpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                body["CreateUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastUpdateEmpid))
            {
                body["LastUpdateEmpid"] = request.LastUpdateEmpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireInfos))
            {
                body["RequireInfos"] = request.RequireInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rid))
            {
                body["Rid"] = request.Rid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIdOrRuleName))
            {
                body["RuleIdOrRuleName"] = request.RuleIdOrRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleScoreSingleType))
            {
                body["RuleScoreSingleType"] = request.RuleScoreSingleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeId))
            {
                body["SchemeId"] = request.SchemeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeName))
            {
                body["TypeName"] = request.TypeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                body["UpdateEndTime"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                body["UpdateStartTime"] = request.UpdateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateUserId))
            {
                body["UpdateUserId"] = request.UpdateUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRulesCountList",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRulesCountListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRulesCountListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRulesCountListResponse
        /// </returns>
        public GetRulesCountListResponse GetRulesCountList(GetRulesCountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRulesCountListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获得规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRulesCountListRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRulesCountListResponse
        /// </returns>
        public async Task<GetRulesCountListResponse> GetRulesCountListAsync(GetRulesCountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRulesCountListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质检任务配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSchemeTaskConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSchemeTaskConfigResponse
        /// </returns>
        public GetSchemeTaskConfigResponse GetSchemeTaskConfigWithOptions(GetSchemeTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSchemeTaskConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSchemeTaskConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质检任务配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSchemeTaskConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSchemeTaskConfigResponse
        /// </returns>
        public async Task<GetSchemeTaskConfigResponse> GetSchemeTaskConfigWithOptionsAsync(GetSchemeTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSchemeTaskConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSchemeTaskConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质检任务配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSchemeTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSchemeTaskConfigResponse
        /// </returns>
        public GetSchemeTaskConfigResponse GetSchemeTaskConfig(GetSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSchemeTaskConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质检任务配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSchemeTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSchemeTaskConfigResponse
        /// </returns>
        public async Task<GetSchemeTaskConfigResponse> GetSchemeTaskConfigAsync(GetSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSchemeTaskConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetScoreInfo is deprecated
        /// 
        /// <param name="request">
        /// GetScoreInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScoreInfoResponse
        /// </returns>
        [Obsolete("OpenAPI GetScoreInfo is deprecated")]
        // Deprecated
        public GetScoreInfoResponse GetScoreInfoWithOptions(GetScoreInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScoreInfo",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScoreInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetScoreInfo is deprecated
        /// 
        /// <param name="request">
        /// GetScoreInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScoreInfoResponse
        /// </returns>
        [Obsolete("OpenAPI GetScoreInfo is deprecated")]
        // Deprecated
        public async Task<GetScoreInfoResponse> GetScoreInfoWithOptionsAsync(GetScoreInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScoreInfo",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScoreInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetScoreInfo is deprecated
        /// 
        /// <param name="request">
        /// GetScoreInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScoreInfoResponse
        /// </returns>
        [Obsolete("OpenAPI GetScoreInfo is deprecated")]
        // Deprecated
        public GetScoreInfoResponse GetScoreInfo(GetScoreInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetScoreInfoWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetScoreInfo is deprecated
        /// 
        /// <param name="request">
        /// GetScoreInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScoreInfoResponse
        /// </returns>
        [Obsolete("OpenAPI GetScoreInfo is deprecated")]
        // Deprecated
        public async Task<GetScoreInfoResponse> GetScoreInfoAsync(GetScoreInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetScoreInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// GetSkillGroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI GetSkillGroupConfig is deprecated")]
        // Deprecated
        public GetSkillGroupConfigResponse GetSkillGroupConfigWithOptions(GetSkillGroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// GetSkillGroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI GetSkillGroupConfig is deprecated")]
        // Deprecated
        public async Task<GetSkillGroupConfigResponse> GetSkillGroupConfigWithOptionsAsync(GetSkillGroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkillGroupConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillGroupConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// GetSkillGroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI GetSkillGroupConfig is deprecated")]
        // Deprecated
        public GetSkillGroupConfigResponse GetSkillGroupConfig(GetSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupConfigWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// GetSkillGroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI GetSkillGroupConfig is deprecated")]
        // Deprecated
        public async Task<GetSkillGroupConfigResponse> GetSkillGroupConfigAsync(GetSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetSyncResult is deprecated, please use Qualitycheck::2019-01-15::GetResult instead.
        /// 
        /// <param name="request">
        /// GetSyncResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSyncResultResponse
        /// </returns>
        [Obsolete("OpenAPI GetSyncResult is deprecated, please use Qualitycheck::2019-01-15::GetResult instead.")]
        // Deprecated
        public GetSyncResultResponse GetSyncResultWithOptions(GetSyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSyncResult",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSyncResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetSyncResult is deprecated, please use Qualitycheck::2019-01-15::GetResult instead.
        /// 
        /// <param name="request">
        /// GetSyncResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSyncResultResponse
        /// </returns>
        [Obsolete("OpenAPI GetSyncResult is deprecated, please use Qualitycheck::2019-01-15::GetResult instead.")]
        // Deprecated
        public async Task<GetSyncResultResponse> GetSyncResultWithOptionsAsync(GetSyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSyncResult",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSyncResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetSyncResult is deprecated, please use Qualitycheck::2019-01-15::GetResult instead.
        /// 
        /// <param name="request">
        /// GetSyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSyncResultResponse
        /// </returns>
        [Obsolete("OpenAPI GetSyncResult is deprecated, please use Qualitycheck::2019-01-15::GetResult instead.")]
        // Deprecated
        public GetSyncResultResponse GetSyncResult(GetSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSyncResultWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetSyncResult is deprecated, please use Qualitycheck::2019-01-15::GetResult instead.
        /// 
        /// <param name="request">
        /// GetSyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSyncResultResponse
        /// </returns>
        [Obsolete("OpenAPI GetSyncResult is deprecated, please use Qualitycheck::2019-01-15::GetResult instead.")]
        // Deprecated
        public async Task<GetSyncResultResponse> GetSyncResultAsync(GetSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSyncResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWarningStrategyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWarningStrategyConfigResponse
        /// </returns>
        public GetWarningStrategyConfigResponse GetWarningStrategyConfigWithOptions(GetWarningStrategyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWarningStrategyConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWarningStrategyConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWarningStrategyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWarningStrategyConfigResponse
        /// </returns>
        public async Task<GetWarningStrategyConfigResponse> GetWarningStrategyConfigWithOptionsAsync(GetWarningStrategyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWarningStrategyConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWarningStrategyConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWarningStrategyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWarningStrategyConfigResponse
        /// </returns>
        public GetWarningStrategyConfigResponse GetWarningStrategyConfig(GetWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWarningStrategyConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWarningStrategyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWarningStrategyConfigResponse
        /// </returns>
        public async Task<GetWarningStrategyConfigResponse> GetWarningStrategyConfigAsync(GetWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWarningStrategyConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// HandleComplaintRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HandleComplaintResponse
        /// </returns>
        public HandleComplaintResponse HandleComplaintWithOptions(HandleComplaintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HandleComplaint",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HandleComplaintResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// HandleComplaintRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HandleComplaintResponse
        /// </returns>
        public async Task<HandleComplaintResponse> HandleComplaintWithOptionsAsync(HandleComplaintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HandleComplaint",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<HandleComplaintResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// HandleComplaintRequest
        /// </param>
        /// 
        /// <returns>
        /// HandleComplaintResponse
        /// </returns>
        public HandleComplaintResponse HandleComplaint(HandleComplaintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HandleComplaintWithOptions(request, runtime);
        }

        /// <param name="request">
        /// HandleComplaintRequest
        /// </param>
        /// 
        /// <returns>
        /// HandleComplaintResponse
        /// </returns>
        public async Task<HandleComplaintResponse> HandleComplaintAsync(HandleComplaintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HandleComplaintWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI InvalidRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
        /// 
        /// <param name="request">
        /// InvalidRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvalidRuleResponse
        /// </returns>
        [Obsolete("OpenAPI InvalidRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.")]
        // Deprecated
        public InvalidRuleResponse InvalidRuleWithOptions(InvalidRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvalidRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvalidRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI InvalidRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
        /// 
        /// <param name="request">
        /// InvalidRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvalidRuleResponse
        /// </returns>
        [Obsolete("OpenAPI InvalidRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.")]
        // Deprecated
        public async Task<InvalidRuleResponse> InvalidRuleWithOptionsAsync(InvalidRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvalidRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvalidRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI InvalidRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
        /// 
        /// <param name="request">
        /// InvalidRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// InvalidRuleResponse
        /// </returns>
        [Obsolete("OpenAPI InvalidRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.")]
        // Deprecated
        public InvalidRuleResponse InvalidRule(InvalidRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvalidRuleWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI InvalidRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
        /// 
        /// <param name="request">
        /// InvalidRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// InvalidRuleResponse
        /// </returns>
        [Obsolete("OpenAPI InvalidRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.")]
        // Deprecated
        public async Task<InvalidRuleResponse> InvalidRuleAsync(InvalidRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvalidRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热词模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsrVocabRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAsrVocabResponse
        /// </returns>
        public ListAsrVocabResponse ListAsrVocabWithOptions(ListAsrVocabRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAsrVocab",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAsrVocabResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热词模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsrVocabRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAsrVocabResponse
        /// </returns>
        public async Task<ListAsrVocabResponse> ListAsrVocabWithOptionsAsync(ListAsrVocabRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAsrVocab",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAsrVocabResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热词模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsrVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAsrVocabResponse
        /// </returns>
        public ListAsrVocabResponse ListAsrVocab(ListAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAsrVocabWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取热词模型列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAsrVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAsrVocabResponse
        /// </returns>
        public async Task<ListAsrVocabResponse> ListAsrVocabAsync(ListAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAsrVocabWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListDataSet is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetResponse
        /// </returns>
        [Obsolete("OpenAPI ListDataSet is deprecated")]
        // Deprecated
        public ListDataSetResponse ListDataSetWithOptions(ListDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSet",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListDataSet is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetResponse
        /// </returns>
        [Obsolete("OpenAPI ListDataSet is deprecated")]
        // Deprecated
        public async Task<ListDataSetResponse> ListDataSetWithOptionsAsync(ListDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataSet",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListDataSet is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetResponse
        /// </returns>
        [Obsolete("OpenAPI ListDataSet is deprecated")]
        // Deprecated
        public ListDataSetResponse ListDataSet(ListDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSetWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListDataSet is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDataSetResponse
        /// </returns>
        [Obsolete("OpenAPI ListDataSet is deprecated")]
        // Deprecated
        public async Task<ListDataSetResponse> ListDataSetAsync(ListDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSetWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListPrecisionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrecisionTaskResponse
        /// </returns>
        public ListPrecisionTaskResponse ListPrecisionTaskWithOptions(ListPrecisionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrecisionTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrecisionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListPrecisionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrecisionTaskResponse
        /// </returns>
        public async Task<ListPrecisionTaskResponse> ListPrecisionTaskWithOptionsAsync(ListPrecisionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrecisionTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrecisionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListPrecisionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrecisionTaskResponse
        /// </returns>
        public ListPrecisionTaskResponse ListPrecisionTask(ListPrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrecisionTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListPrecisionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrecisionTaskResponse
        /// </returns>
        public async Task<ListPrecisionTaskResponse> ListPrecisionTaskAsync(ListPrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrecisionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>质检方案列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQualityCheckSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQualityCheckSchemeResponse
        /// </returns>
        public ListQualityCheckSchemeResponse ListQualityCheckSchemeWithOptions(ListQualityCheckSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQualityCheckScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQualityCheckSchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>质检方案列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQualityCheckSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQualityCheckSchemeResponse
        /// </returns>
        public async Task<ListQualityCheckSchemeResponse> ListQualityCheckSchemeWithOptionsAsync(ListQualityCheckSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQualityCheckScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQualityCheckSchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>质检方案列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQualityCheckSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQualityCheckSchemeResponse
        /// </returns>
        public ListQualityCheckSchemeResponse ListQualityCheckScheme(ListQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQualityCheckSchemeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>质检方案列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQualityCheckSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQualityCheckSchemeResponse
        /// </returns>
        public async Task<ListQualityCheckSchemeResponse> ListQualityCheckSchemeAsync(ListQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQualityCheckSchemeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListRules is deprecated, please use Qualitycheck::2019-01-15::ListRulesV4 instead.
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        [Obsolete("OpenAPI ListRules is deprecated, please use Qualitycheck::2019-01-15::ListRulesV4 instead.")]
        // Deprecated
        public ListRulesResponse ListRulesWithOptions(ListRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRules",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListRules is deprecated, please use Qualitycheck::2019-01-15::ListRulesV4 instead.
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        [Obsolete("OpenAPI ListRules is deprecated, please use Qualitycheck::2019-01-15::ListRulesV4 instead.")]
        // Deprecated
        public async Task<ListRulesResponse> ListRulesWithOptionsAsync(ListRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRules",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListRules is deprecated, please use Qualitycheck::2019-01-15::ListRulesV4 instead.
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        [Obsolete("OpenAPI ListRules is deprecated, please use Qualitycheck::2019-01-15::ListRulesV4 instead.")]
        // Deprecated
        public ListRulesResponse ListRules(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRulesWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListRules is deprecated, please use Qualitycheck::2019-01-15::ListRulesV4 instead.
        /// 
        /// <param name="request">
        /// ListRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRulesResponse
        /// </returns>
        [Obsolete("OpenAPI ListRules is deprecated, please use Qualitycheck::2019-01-15::ListRulesV4 instead.")]
        // Deprecated
        public async Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4获得规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRulesV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRulesV4Response
        /// </returns>
        public ListRulesV4Response ListRulesV4WithOptions(ListRulesV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessName))
            {
                body["BusinessName"] = request.BusinessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessRange))
            {
                body["BusinessRange"] = request.BusinessRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountTotal))
            {
                body["CountTotal"] = request.CountTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEmpid))
            {
                body["CreateEmpid"] = request.CreateEmpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                body["CreateUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastUpdateEmpid))
            {
                body["LastUpdateEmpid"] = request.LastUpdateEmpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireInfos))
            {
                body["RequireInfos"] = request.RequireInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rid))
            {
                body["Rid"] = request.Rid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIdOrRuleName))
            {
                body["RuleIdOrRuleName"] = request.RuleIdOrRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleScoreSingleType))
            {
                body["RuleScoreSingleType"] = request.RuleScoreSingleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeId))
            {
                body["SchemeId"] = request.SchemeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeName))
            {
                body["TypeName"] = request.TypeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                body["UpdateEndTime"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                body["UpdateStartTime"] = request.UpdateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateUserId))
            {
                body["UpdateUserId"] = request.UpdateUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRulesV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesV4Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4获得规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRulesV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRulesV4Response
        /// </returns>
        public async Task<ListRulesV4Response> ListRulesV4WithOptionsAsync(ListRulesV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessName))
            {
                body["BusinessName"] = request.BusinessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessRange))
            {
                body["BusinessRange"] = request.BusinessRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CategoryName))
            {
                body["CategoryName"] = request.CategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountTotal))
            {
                body["CountTotal"] = request.CountTotal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateEmpid))
            {
                body["CreateEmpid"] = request.CreateEmpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateUserId))
            {
                body["CreateUserId"] = request.CreateUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastUpdateEmpid))
            {
                body["LastUpdateEmpid"] = request.LastUpdateEmpid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireInfos))
            {
                body["RequireInfos"] = request.RequireInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rid))
            {
                body["Rid"] = request.Rid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIdOrRuleName))
            {
                body["RuleIdOrRuleName"] = request.RuleIdOrRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleScoreSingleType))
            {
                body["RuleScoreSingleType"] = request.RuleScoreSingleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["RuleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemeId))
            {
                body["SchemeId"] = request.SchemeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                body["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeName))
            {
                body["TypeName"] = request.TypeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateEndTime))
            {
                body["UpdateEndTime"] = request.UpdateEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStartTime))
            {
                body["UpdateStartTime"] = request.UpdateStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateUserId))
            {
                body["UpdateUserId"] = request.UpdateUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRulesV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesV4Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4获得规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRulesV4Request
        /// </param>
        /// 
        /// <returns>
        /// ListRulesV4Response
        /// </returns>
        public ListRulesV4Response ListRulesV4(ListRulesV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRulesV4WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4获得规则列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRulesV4Request
        /// </param>
        /// 
        /// <returns>
        /// ListRulesV4Response
        /// </returns>
        public async Task<ListRulesV4Response> ListRulesV4Async(ListRulesV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRulesV4WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质检任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSchemeTaskConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSchemeTaskConfigResponse
        /// </returns>
        public ListSchemeTaskConfigResponse ListSchemeTaskConfigWithOptions(ListSchemeTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSchemeTaskConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSchemeTaskConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质检任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSchemeTaskConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSchemeTaskConfigResponse
        /// </returns>
        public async Task<ListSchemeTaskConfigResponse> ListSchemeTaskConfigWithOptionsAsync(ListSchemeTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSchemeTaskConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSchemeTaskConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质检任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSchemeTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSchemeTaskConfigResponse
        /// </returns>
        public ListSchemeTaskConfigResponse ListSchemeTaskConfig(ListSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSchemeTaskConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取质检任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSchemeTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSchemeTaskConfigResponse
        /// </returns>
        public async Task<ListSchemeTaskConfigResponse> ListSchemeTaskConfigAsync(ListSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSchemeTaskConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListSessionGroup is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSessionGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSessionGroupResponse
        /// </returns>
        [Obsolete("OpenAPI ListSessionGroup is deprecated")]
        // Deprecated
        public ListSessionGroupResponse ListSessionGroupWithOptions(ListSessionGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSessionGroup",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSessionGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListSessionGroup is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSessionGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSessionGroupResponse
        /// </returns>
        [Obsolete("OpenAPI ListSessionGroup is deprecated")]
        // Deprecated
        public async Task<ListSessionGroupResponse> ListSessionGroupWithOptionsAsync(ListSessionGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSessionGroup",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSessionGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListSessionGroup is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSessionGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSessionGroupResponse
        /// </returns>
        [Obsolete("OpenAPI ListSessionGroup is deprecated")]
        // Deprecated
        public ListSessionGroupResponse ListSessionGroup(ListSessionGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSessionGroupWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListSessionGroup is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取会话组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSessionGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSessionGroupResponse
        /// </returns>
        [Obsolete("OpenAPI ListSessionGroup is deprecated")]
        // Deprecated
        public async Task<ListSessionGroupResponse> ListSessionGroupAsync(ListSessionGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSessionGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// ListSkillGroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI ListSkillGroupConfig is deprecated")]
        // Deprecated
        public ListSkillGroupConfigResponse ListSkillGroupConfigWithOptions(ListSkillGroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkillGroupConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillGroupConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// ListSkillGroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI ListSkillGroupConfig is deprecated")]
        // Deprecated
        public async Task<ListSkillGroupConfigResponse> ListSkillGroupConfigWithOptionsAsync(ListSkillGroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkillGroupConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillGroupConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// ListSkillGroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI ListSkillGroupConfig is deprecated")]
        // Deprecated
        public ListSkillGroupConfigResponse ListSkillGroupConfig(ListSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillGroupConfigWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// ListSkillGroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI ListSkillGroupConfig is deprecated")]
        // Deprecated
        public async Task<ListSkillGroupConfigResponse> ListSkillGroupConfigAsync(ListSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillGroupConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListTaskAssignRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTaskAssignRulesResponse
        /// </returns>
        public ListTaskAssignRulesResponse ListTaskAssignRulesWithOptions(ListTaskAssignRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTaskAssignRules",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaskAssignRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListTaskAssignRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTaskAssignRulesResponse
        /// </returns>
        public async Task<ListTaskAssignRulesResponse> ListTaskAssignRulesWithOptionsAsync(ListTaskAssignRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTaskAssignRules",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTaskAssignRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListTaskAssignRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTaskAssignRulesResponse
        /// </returns>
        public ListTaskAssignRulesResponse ListTaskAssignRules(ListTaskAssignRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTaskAssignRulesWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListTaskAssignRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTaskAssignRulesResponse
        /// </returns>
        public async Task<ListTaskAssignRulesResponse> ListTaskAssignRulesAsync(ListTaskAssignRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTaskAssignRulesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListWarningConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWarningConfigResponse
        /// </returns>
        public ListWarningConfigResponse ListWarningConfigWithOptions(ListWarningConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWarningConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWarningConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ListWarningConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWarningConfigResponse
        /// </returns>
        public async Task<ListWarningConfigResponse> ListWarningConfigWithOptionsAsync(ListWarningConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWarningConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWarningConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ListWarningConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWarningConfigResponse
        /// </returns>
        public ListWarningConfigResponse ListWarningConfig(ListWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWarningConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListWarningConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWarningConfigResponse
        /// </returns>
        public async Task<ListWarningConfigResponse> ListWarningConfigAsync(ListWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWarningConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWarningStrategyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWarningStrategyConfigResponse
        /// </returns>
        public ListWarningStrategyConfigResponse ListWarningStrategyConfigWithOptions(ListWarningStrategyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWarningStrategyConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWarningStrategyConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWarningStrategyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWarningStrategyConfigResponse
        /// </returns>
        public async Task<ListWarningStrategyConfigResponse> ListWarningStrategyConfigWithOptionsAsync(ListWarningStrategyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWarningStrategyConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWarningStrategyConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWarningStrategyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWarningStrategyConfigResponse
        /// </returns>
        public ListWarningStrategyConfigResponse ListWarningStrategyConfig(ListWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWarningStrategyConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWarningStrategyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWarningStrategyConfigResponse
        /// </returns>
        public async Task<ListWarningStrategyConfigResponse> ListWarningStrategyConfigAsync(ListWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWarningStrategyConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量回收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertAssignedSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevertAssignedSessionResponse
        /// </returns>
        public RevertAssignedSessionResponse RevertAssignedSessionWithOptions(RevertAssignedSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevertAssignedSession",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertAssignedSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量回收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertAssignedSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevertAssignedSessionResponse
        /// </returns>
        public async Task<RevertAssignedSessionResponse> RevertAssignedSessionWithOptionsAsync(RevertAssignedSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevertAssignedSession",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertAssignedSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量回收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertAssignedSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// RevertAssignedSessionResponse
        /// </returns>
        public RevertAssignedSessionResponse RevertAssignedSession(RevertAssignedSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevertAssignedSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量回收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertAssignedSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// RevertAssignedSessionResponse
        /// </returns>
        public async Task<RevertAssignedSessionResponse> RevertAssignedSessionAsync(RevertAssignedSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevertAssignedSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI RevertAssignedSessionGroup is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话组批量回收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertAssignedSessionGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevertAssignedSessionGroupResponse
        /// </returns>
        [Obsolete("OpenAPI RevertAssignedSessionGroup is deprecated")]
        // Deprecated
        public RevertAssignedSessionGroupResponse RevertAssignedSessionGroupWithOptions(RevertAssignedSessionGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevertAssignedSessionGroup",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertAssignedSessionGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI RevertAssignedSessionGroup is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话组批量回收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertAssignedSessionGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevertAssignedSessionGroupResponse
        /// </returns>
        [Obsolete("OpenAPI RevertAssignedSessionGroup is deprecated")]
        // Deprecated
        public async Task<RevertAssignedSessionGroupResponse> RevertAssignedSessionGroupWithOptionsAsync(RevertAssignedSessionGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevertAssignedSessionGroup",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevertAssignedSessionGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI RevertAssignedSessionGroup is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话组批量回收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertAssignedSessionGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RevertAssignedSessionGroupResponse
        /// </returns>
        [Obsolete("OpenAPI RevertAssignedSessionGroup is deprecated")]
        // Deprecated
        public RevertAssignedSessionGroupResponse RevertAssignedSessionGroup(RevertAssignedSessionGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevertAssignedSessionGroupWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI RevertAssignedSessionGroup is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>会话组批量回收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevertAssignedSessionGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RevertAssignedSessionGroupResponse
        /// </returns>
        [Obsolete("OpenAPI RevertAssignedSessionGroup is deprecated")]
        // Deprecated
        public async Task<RevertAssignedSessionGroupResponse> RevertAssignedSessionGroupAsync(RevertAssignedSessionGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevertAssignedSessionGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI SaveConfigDataSet is deprecated
        /// 
        /// <param name="request">
        /// SaveConfigDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveConfigDataSetResponse
        /// </returns>
        [Obsolete("OpenAPI SaveConfigDataSet is deprecated")]
        // Deprecated
        public SaveConfigDataSetResponse SaveConfigDataSetWithOptions(SaveConfigDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveConfigDataSet",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveConfigDataSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI SaveConfigDataSet is deprecated
        /// 
        /// <param name="request">
        /// SaveConfigDataSetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveConfigDataSetResponse
        /// </returns>
        [Obsolete("OpenAPI SaveConfigDataSet is deprecated")]
        // Deprecated
        public async Task<SaveConfigDataSetResponse> SaveConfigDataSetWithOptionsAsync(SaveConfigDataSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveConfigDataSet",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveConfigDataSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI SaveConfigDataSet is deprecated
        /// 
        /// <param name="request">
        /// SaveConfigDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveConfigDataSetResponse
        /// </returns>
        [Obsolete("OpenAPI SaveConfigDataSet is deprecated")]
        // Deprecated
        public SaveConfigDataSetResponse SaveConfigDataSet(SaveConfigDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveConfigDataSetWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI SaveConfigDataSet is deprecated
        /// 
        /// <param name="request">
        /// SaveConfigDataSetRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveConfigDataSetResponse
        /// </returns>
        [Obsolete("OpenAPI SaveConfigDataSet is deprecated")]
        // Deprecated
        public async Task<SaveConfigDataSetResponse> SaveConfigDataSetAsync(SaveConfigDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveConfigDataSetWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SubmitComplaintRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitComplaintResponse
        /// </returns>
        public SubmitComplaintResponse SubmitComplaintWithOptions(SubmitComplaintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitComplaint",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitComplaintResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitComplaintRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitComplaintResponse
        /// </returns>
        public async Task<SubmitComplaintResponse> SubmitComplaintWithOptionsAsync(SubmitComplaintRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitComplaint",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitComplaintResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitComplaintRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitComplaintResponse
        /// </returns>
        public SubmitComplaintResponse SubmitComplaint(SubmitComplaintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitComplaintWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SubmitComplaintRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitComplaintResponse
        /// </returns>
        public async Task<SubmitComplaintResponse> SubmitComplaintAsync(SubmitComplaintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitComplaintWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SubmitPrecisionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitPrecisionTaskResponse
        /// </returns>
        public SubmitPrecisionTaskResponse SubmitPrecisionTaskWithOptions(SubmitPrecisionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitPrecisionTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitPrecisionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitPrecisionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitPrecisionTaskResponse
        /// </returns>
        public async Task<SubmitPrecisionTaskResponse> SubmitPrecisionTaskWithOptionsAsync(SubmitPrecisionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitPrecisionTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitPrecisionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitPrecisionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitPrecisionTaskResponse
        /// </returns>
        public SubmitPrecisionTaskResponse SubmitPrecisionTask(SubmitPrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitPrecisionTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SubmitPrecisionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitPrecisionTaskResponse
        /// </returns>
        public async Task<SubmitPrecisionTaskResponse> SubmitPrecisionTaskAsync(SubmitPrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitPrecisionTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SubmitQualityCheckTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitQualityCheckTaskResponse
        /// </returns>
        public SubmitQualityCheckTaskResponse SubmitQualityCheckTaskWithOptions(SubmitQualityCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitQualityCheckTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitQualityCheckTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitQualityCheckTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitQualityCheckTaskResponse
        /// </returns>
        public async Task<SubmitQualityCheckTaskResponse> SubmitQualityCheckTaskWithOptionsAsync(SubmitQualityCheckTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitQualityCheckTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitQualityCheckTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitQualityCheckTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitQualityCheckTaskResponse
        /// </returns>
        public SubmitQualityCheckTaskResponse SubmitQualityCheckTask(SubmitQualityCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitQualityCheckTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SubmitQualityCheckTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitQualityCheckTaskResponse
        /// </returns>
        public async Task<SubmitQualityCheckTaskResponse> SubmitQualityCheckTaskAsync(SubmitQualityCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitQualityCheckTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SubmitReviewInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitReviewInfoResponse
        /// </returns>
        public SubmitReviewInfoResponse SubmitReviewInfoWithOptions(SubmitReviewInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitReviewInfo",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitReviewInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitReviewInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitReviewInfoResponse
        /// </returns>
        public async Task<SubmitReviewInfoResponse> SubmitReviewInfoWithOptionsAsync(SubmitReviewInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitReviewInfo",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitReviewInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SubmitReviewInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitReviewInfoResponse
        /// </returns>
        public SubmitReviewInfoResponse SubmitReviewInfo(SubmitReviewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitReviewInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SubmitReviewInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitReviewInfoResponse
        /// </returns>
        public async Task<SubmitReviewInfoResponse> SubmitReviewInfoAsync(SubmitReviewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitReviewInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SyncQualityCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncQualityCheckResponse
        /// </returns>
        public SyncQualityCheckResponse SyncQualityCheckWithOptions(SyncQualityCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncQualityCheck",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncQualityCheckResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SyncQualityCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncQualityCheckResponse
        /// </returns>
        public async Task<SyncQualityCheckResponse> SyncQualityCheckWithOptionsAsync(SyncQualityCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncQualityCheck",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncQualityCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SyncQualityCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncQualityCheckResponse
        /// </returns>
        public SyncQualityCheckResponse SyncQualityCheck(SyncQualityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncQualityCheckWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SyncQualityCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncQualityCheckResponse
        /// </returns>
        public async Task<SyncQualityCheckResponse> SyncQualityCheckAsync(SyncQualityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncQualityCheckWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TestRuleV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestRuleV4Response
        /// </returns>
        public TestRuleV4Response TestRuleV4WithOptions(TestRuleV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSchemeData))
            {
                body["IsSchemeData"] = request.IsSchemeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestJson))
            {
                body["TestJson"] = request.TestJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestRuleV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestRuleV4Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TestRuleV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestRuleV4Response
        /// </returns>
        public async Task<TestRuleV4Response> TestRuleV4WithOptionsAsync(TestRuleV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSchemeData))
            {
                body["IsSchemeData"] = request.IsSchemeData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TestJson))
            {
                body["TestJson"] = request.TestJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestRuleV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestRuleV4Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TestRuleV4Request
        /// </param>
        /// 
        /// <returns>
        /// TestRuleV4Response
        /// </returns>
        public TestRuleV4Response TestRuleV4(TestRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestRuleV4WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>测试规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TestRuleV4Request
        /// </param>
        /// 
        /// <returns>
        /// TestRuleV4Response
        /// </returns>
        public async Task<TestRuleV4Response> TestRuleV4Async(TestRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestRuleV4WithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateAsrVocabRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAsrVocabResponse
        /// </returns>
        public UpdateAsrVocabResponse UpdateAsrVocabWithOptions(UpdateAsrVocabRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAsrVocab",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAsrVocabResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAsrVocabRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAsrVocabResponse
        /// </returns>
        public async Task<UpdateAsrVocabResponse> UpdateAsrVocabWithOptionsAsync(UpdateAsrVocabRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAsrVocab",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAsrVocabResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAsrVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAsrVocabResponse
        /// </returns>
        public UpdateAsrVocabResponse UpdateAsrVocab(UpdateAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAsrVocabWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateAsrVocabRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAsrVocabResponse
        /// </returns>
        public async Task<UpdateAsrVocabResponse> UpdateAsrVocabAsync(UpdateAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAsrVocabWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检方案中的质检维度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCheckTypeToSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCheckTypeToSchemeResponse
        /// </returns>
        public UpdateCheckTypeToSchemeResponse UpdateCheckTypeToSchemeWithOptions(UpdateCheckTypeToSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCheckTypeToScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCheckTypeToSchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检方案中的质检维度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCheckTypeToSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCheckTypeToSchemeResponse
        /// </returns>
        public async Task<UpdateCheckTypeToSchemeResponse> UpdateCheckTypeToSchemeWithOptionsAsync(UpdateCheckTypeToSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCheckTypeToScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCheckTypeToSchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检方案中的质检维度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCheckTypeToSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCheckTypeToSchemeResponse
        /// </returns>
        public UpdateCheckTypeToSchemeResponse UpdateCheckTypeToScheme(UpdateCheckTypeToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCheckTypeToSchemeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检方案中的质检维度</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCheckTypeToSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCheckTypeToSchemeResponse
        /// </returns>
        public async Task<UpdateCheckTypeToSchemeResponse> UpdateCheckTypeToSchemeAsync(UpdateCheckTypeToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCheckTypeToSchemeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会话随录数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQualityCheckDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQualityCheckDataResponse
        /// </returns>
        public UpdateQualityCheckDataResponse UpdateQualityCheckDataWithOptions(UpdateQualityCheckDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQualityCheckData",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQualityCheckDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会话随录数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQualityCheckDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQualityCheckDataResponse
        /// </returns>
        public async Task<UpdateQualityCheckDataResponse> UpdateQualityCheckDataWithOptionsAsync(UpdateQualityCheckDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQualityCheckData",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQualityCheckDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会话随录数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQualityCheckDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQualityCheckDataResponse
        /// </returns>
        public UpdateQualityCheckDataResponse UpdateQualityCheckData(UpdateQualityCheckDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQualityCheckDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新会话随录数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQualityCheckDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQualityCheckDataResponse
        /// </returns>
        public async Task<UpdateQualityCheckDataResponse> UpdateQualityCheckDataAsync(UpdateQualityCheckDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQualityCheckDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQualityCheckSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQualityCheckSchemeResponse
        /// </returns>
        public UpdateQualityCheckSchemeResponse UpdateQualityCheckSchemeWithOptions(UpdateQualityCheckSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQualityCheckScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQualityCheckSchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQualityCheckSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQualityCheckSchemeResponse
        /// </returns>
        public async Task<UpdateQualityCheckSchemeResponse> UpdateQualityCheckSchemeWithOptionsAsync(UpdateQualityCheckSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQualityCheckScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQualityCheckSchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQualityCheckSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQualityCheckSchemeResponse
        /// </returns>
        public UpdateQualityCheckSchemeResponse UpdateQualityCheckScheme(UpdateQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQualityCheckSchemeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检方案</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQualityCheckSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQualityCheckSchemeResponse
        /// </returns>
        public async Task<UpdateQualityCheckSchemeResponse> UpdateQualityCheckSchemeAsync(UpdateQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQualityCheckSchemeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateRule is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
        /// 
        /// <param name="request">
        /// UpdateRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateRule is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.")]
        // Deprecated
        public UpdateRuleResponse UpdateRuleWithOptions(UpdateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateRule is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
        /// 
        /// <param name="request">
        /// UpdateRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateRule is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.")]
        // Deprecated
        public async Task<UpdateRuleResponse> UpdateRuleWithOptionsAsync(UpdateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateRule is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
        /// 
        /// <param name="request">
        /// UpdateRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateRule is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.")]
        // Deprecated
        public UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateRule is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
        /// 
        /// <param name="request">
        /// UpdateRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateRule is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.")]
        // Deprecated
        public async Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateRuleById is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRuleByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleByIdResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateRuleById is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.")]
        // Deprecated
        public UpdateRuleByIdResponse UpdateRuleByIdWithOptions(UpdateRuleByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCopy))
            {
                body["IsCopy"] = request.IsCopy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStrForRule))
            {
                body["JsonStrForRule"] = request.JsonStrForRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnRelatedSchemes))
            {
                body["ReturnRelatedSchemes"] = request.ReturnRelatedSchemes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRuleById",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleByIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateRuleById is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRuleByIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleByIdResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateRuleById is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.")]
        // Deprecated
        public async Task<UpdateRuleByIdResponse> UpdateRuleByIdWithOptionsAsync(UpdateRuleByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCopy))
            {
                body["IsCopy"] = request.IsCopy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStrForRule))
            {
                body["JsonStrForRule"] = request.JsonStrForRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnRelatedSchemes))
            {
                body["ReturnRelatedSchemes"] = request.ReturnRelatedSchemes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRuleById",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateRuleById is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRuleByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleByIdResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateRuleById is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.")]
        // Deprecated
        public UpdateRuleByIdResponse UpdateRuleById(UpdateRuleByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleByIdWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateRuleById is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRuleByIdRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleByIdResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateRuleById is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.")]
        // Deprecated
        public async Task<UpdateRuleByIdResponse> UpdateRuleByIdAsync(UpdateRuleByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleByIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检方案的规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRuleToSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleToSchemeResponse
        /// </returns>
        public UpdateRuleToSchemeResponse UpdateRuleToSchemeWithOptions(UpdateRuleToSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRuleToScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleToSchemeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检方案的规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRuleToSchemeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleToSchemeResponse
        /// </returns>
        public async Task<UpdateRuleToSchemeResponse> UpdateRuleToSchemeWithOptionsAsync(UpdateRuleToSchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRuleToScheme",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleToSchemeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检方案的规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRuleToSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleToSchemeResponse
        /// </returns>
        public UpdateRuleToSchemeResponse UpdateRuleToScheme(UpdateRuleToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleToSchemeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检方案的规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRuleToSchemeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleToSchemeResponse
        /// </returns>
        public async Task<UpdateRuleToSchemeResponse> UpdateRuleToSchemeAsync(UpdateRuleToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleToSchemeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4更新规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRuleV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleV4Response
        /// </returns>
        public UpdateRuleV4Response UpdateRuleV4WithOptions(UpdateRuleV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStrForRule))
            {
                body["JsonStrForRule"] = request.JsonStrForRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRuleV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleV4Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4更新规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRuleV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleV4Response
        /// </returns>
        public async Task<UpdateRuleV4Response> UpdateRuleV4WithOptionsAsync(UpdateRuleV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStrForRule))
            {
                body["JsonStrForRule"] = request.JsonStrForRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRuleV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleV4Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4更新规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRuleV4Request
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleV4Response
        /// </returns>
        public UpdateRuleV4Response UpdateRuleV4(UpdateRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleV4WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>V4更新规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRuleV4Request
        /// </param>
        /// 
        /// <returns>
        /// UpdateRuleV4Response
        /// </returns>
        public async Task<UpdateRuleV4Response> UpdateRuleV4Async(UpdateRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleV4WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSchemeTaskConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSchemeTaskConfigResponse
        /// </returns>
        public UpdateSchemeTaskConfigResponse UpdateSchemeTaskConfigWithOptions(UpdateSchemeTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSchemeTaskConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSchemeTaskConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSchemeTaskConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSchemeTaskConfigResponse
        /// </returns>
        public async Task<UpdateSchemeTaskConfigResponse> UpdateSchemeTaskConfigWithOptionsAsync(UpdateSchemeTaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["jsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSchemeTaskConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSchemeTaskConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSchemeTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSchemeTaskConfigResponse
        /// </returns>
        public UpdateSchemeTaskConfigResponse UpdateSchemeTaskConfig(UpdateSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSchemeTaskConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新质检任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSchemeTaskConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSchemeTaskConfigResponse
        /// </returns>
        public async Task<UpdateSchemeTaskConfigResponse> UpdateSchemeTaskConfigAsync(UpdateSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSchemeTaskConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// UpdateSkillGroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateSkillGroupConfig is deprecated")]
        // Deprecated
        public UpdateSkillGroupConfigResponse UpdateSkillGroupConfigWithOptions(UpdateSkillGroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkillGroupConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillGroupConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// UpdateSkillGroupConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateSkillGroupConfig is deprecated")]
        // Deprecated
        public async Task<UpdateSkillGroupConfigResponse> UpdateSkillGroupConfigWithOptionsAsync(UpdateSkillGroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkillGroupConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillGroupConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// UpdateSkillGroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateSkillGroupConfig is deprecated")]
        // Deprecated
        public UpdateSkillGroupConfigResponse UpdateSkillGroupConfig(UpdateSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSkillGroupConfigWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UpdateSkillGroupConfig is deprecated
        /// 
        /// <param name="request">
        /// UpdateSkillGroupConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillGroupConfigResponse
        /// </returns>
        [Obsolete("OpenAPI UpdateSkillGroupConfig is deprecated")]
        // Deprecated
        public async Task<UpdateSkillGroupConfigResponse> UpdateSkillGroupConfigAsync(UpdateSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSkillGroupConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateSyncQualityCheckDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSyncQualityCheckDataResponse
        /// </returns>
        public UpdateSyncQualityCheckDataResponse UpdateSyncQualityCheckDataWithOptions(UpdateSyncQualityCheckDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSyncQualityCheckData",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSyncQualityCheckDataResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateSyncQualityCheckDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSyncQualityCheckDataResponse
        /// </returns>
        public async Task<UpdateSyncQualityCheckDataResponse> UpdateSyncQualityCheckDataWithOptionsAsync(UpdateSyncQualityCheckDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSyncQualityCheckData",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSyncQualityCheckDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateSyncQualityCheckDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSyncQualityCheckDataResponse
        /// </returns>
        public UpdateSyncQualityCheckDataResponse UpdateSyncQualityCheckData(UpdateSyncQualityCheckDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSyncQualityCheckDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateSyncQualityCheckDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSyncQualityCheckDataResponse
        /// </returns>
        public async Task<UpdateSyncQualityCheckDataResponse> UpdateSyncQualityCheckDataAsync(UpdateSyncQualityCheckDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSyncQualityCheckDataWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateTaskAssignRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTaskAssignRuleResponse
        /// </returns>
        public UpdateTaskAssignRuleResponse UpdateTaskAssignRuleWithOptions(UpdateTaskAssignRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTaskAssignRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskAssignRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateTaskAssignRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTaskAssignRuleResponse
        /// </returns>
        public async Task<UpdateTaskAssignRuleResponse> UpdateTaskAssignRuleWithOptionsAsync(UpdateTaskAssignRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTaskAssignRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskAssignRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateTaskAssignRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTaskAssignRuleResponse
        /// </returns>
        public UpdateTaskAssignRuleResponse UpdateTaskAssignRule(UpdateTaskAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTaskAssignRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateTaskAssignRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTaskAssignRuleResponse
        /// </returns>
        public async Task<UpdateTaskAssignRuleResponse> UpdateTaskAssignRuleAsync(UpdateTaskAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTaskAssignRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateWarningConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWarningConfigResponse
        /// </returns>
        public UpdateWarningConfigResponse UpdateWarningConfigWithOptions(UpdateWarningConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWarningConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWarningConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateWarningConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWarningConfigResponse
        /// </returns>
        public async Task<UpdateWarningConfigResponse> UpdateWarningConfigWithOptionsAsync(UpdateWarningConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWarningConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWarningConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateWarningConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWarningConfigResponse
        /// </returns>
        public UpdateWarningConfigResponse UpdateWarningConfig(UpdateWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWarningConfigWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateWarningConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWarningConfigResponse
        /// </returns>
        public async Task<UpdateWarningConfigResponse> UpdateWarningConfigAsync(UpdateWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWarningConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWarningStrategyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWarningStrategyConfigResponse
        /// </returns>
        public UpdateWarningStrategyConfigResponse UpdateWarningStrategyConfigWithOptions(UpdateWarningStrategyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWarningStrategyConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWarningStrategyConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWarningStrategyConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWarningStrategyConfigResponse
        /// </returns>
        public async Task<UpdateWarningStrategyConfigResponse> UpdateWarningStrategyConfigWithOptionsAsync(UpdateWarningStrategyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWarningStrategyConfig",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWarningStrategyConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWarningStrategyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWarningStrategyConfigResponse
        /// </returns>
        public UpdateWarningStrategyConfigResponse UpdateWarningStrategyConfig(UpdateWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWarningStrategyConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>预警策略-更新</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateWarningStrategyConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWarningStrategyConfigResponse
        /// </returns>
        public async Task<UpdateWarningStrategyConfigResponse> UpdateWarningStrategyConfigAsync(UpdateWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWarningStrategyConfigWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UploadAudioDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadAudioDataResponse
        /// </returns>
        public UploadAudioDataResponse UploadAudioDataWithOptions(UploadAudioDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadAudioData",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadAudioDataResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadAudioDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadAudioDataResponse
        /// </returns>
        public async Task<UploadAudioDataResponse> UploadAudioDataWithOptionsAsync(UploadAudioDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadAudioData",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadAudioDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadAudioDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadAudioDataResponse
        /// </returns>
        public UploadAudioDataResponse UploadAudioData(UploadAudioDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadAudioDataWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UploadAudioDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadAudioDataResponse
        /// </returns>
        public async Task<UploadAudioDataResponse> UploadAudioDataAsync(UploadAudioDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadAudioDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UploadData is deprecated, please use Qualitycheck::2019-01-15::UploadDataV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推荐使用UploadDataV4接口,支持更长的JsonStr,但仅支持POST方法.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDataResponse
        /// </returns>
        [Obsolete("OpenAPI UploadData is deprecated, please use Qualitycheck::2019-01-15::UploadDataV4 instead.")]
        // Deprecated
        public UploadDataResponse UploadDataWithOptions(UploadDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadData",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UploadData is deprecated, please use Qualitycheck::2019-01-15::UploadDataV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推荐使用UploadDataV4接口,支持更长的JsonStr,但仅支持POST方法.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDataResponse
        /// </returns>
        [Obsolete("OpenAPI UploadData is deprecated, please use Qualitycheck::2019-01-15::UploadDataV4 instead.")]
        // Deprecated
        public async Task<UploadDataResponse> UploadDataWithOptionsAsync(UploadDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadData",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UploadData is deprecated, please use Qualitycheck::2019-01-15::UploadDataV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推荐使用UploadDataV4接口,支持更长的JsonStr,但仅支持POST方法.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDataResponse
        /// </returns>
        [Obsolete("OpenAPI UploadData is deprecated, please use Qualitycheck::2019-01-15::UploadDataV4 instead.")]
        // Deprecated
        public UploadDataResponse UploadData(UploadDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDataWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI UploadData is deprecated, please use Qualitycheck::2019-01-15::UploadDataV4 instead.
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推荐使用UploadDataV4接口,支持更长的JsonStr,但仅支持POST方法.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDataResponse
        /// </returns>
        [Obsolete("OpenAPI UploadData is deprecated, please use Qualitycheck::2019-01-15::UploadDataV4 instead.")]
        // Deprecated
        public async Task<UploadDataResponse> UploadDataAsync(UploadDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>http_hsf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataSyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDataSyncResponse
        /// </returns>
        public UploadDataSyncResponse UploadDataSyncWithOptions(UploadDataSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDataSync",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDataSyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>http_hsf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataSyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDataSyncResponse
        /// </returns>
        public async Task<UploadDataSyncResponse> UploadDataSyncWithOptionsAsync(UploadDataSyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDataSync",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDataSyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>http_hsf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDataSyncResponse
        /// </returns>
        public UploadDataSyncResponse UploadDataSync(UploadDataSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDataSyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>http_hsf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataSyncRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDataSyncResponse
        /// </returns>
        public async Task<UploadDataSyncResponse> UploadDataSyncAsync(UploadDataSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDataSyncWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>http_hsf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataSyncForLLMRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDataSyncForLLMResponse
        /// </returns>
        public UploadDataSyncForLLMResponse UploadDataSyncForLLMWithOptions(UploadDataSyncForLLMRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDataSyncForLLM",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDataSyncForLLMResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>http_hsf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataSyncForLLMRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDataSyncForLLMResponse
        /// </returns>
        public async Task<UploadDataSyncForLLMResponse> UploadDataSyncForLLMWithOptionsAsync(UploadDataSyncForLLMRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDataSyncForLLM",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDataSyncForLLMResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>http_hsf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataSyncForLLMRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDataSyncForLLMResponse
        /// </returns>
        public UploadDataSyncForLLMResponse UploadDataSyncForLLM(UploadDataSyncForLLMRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDataSyncForLLMWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>http_hsf</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataSyncForLLMRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadDataSyncForLLMResponse
        /// </returns>
        public async Task<UploadDataSyncForLLMResponse> UploadDataSyncForLLMAsync(UploadDataSyncForLLMRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDataSyncForLLMWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UploadDataV4</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDataV4Response
        /// </returns>
        public UploadDataV4Response UploadDataV4WithOptions(UploadDataV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                body["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                body["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDataV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDataV4Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UploadDataV4</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadDataV4Response
        /// </returns>
        public async Task<UploadDataV4Response> UploadDataV4WithOptionsAsync(UploadDataV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                body["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                body["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDataV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDataV4Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UploadDataV4</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataV4Request
        /// </param>
        /// 
        /// <returns>
        /// UploadDataV4Response
        /// </returns>
        public UploadDataV4Response UploadDataV4(UploadDataV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDataV4WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>UploadDataV4</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadDataV4Request
        /// </param>
        /// 
        /// <returns>
        /// UploadDataV4Response
        /// </returns>
        public async Task<UploadDataV4Response> UploadDataV4Async(UploadDataV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDataV4WithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UploadRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadRuleResponse
        /// </returns>
        public UploadRuleResponse UploadRuleWithOptions(UploadRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadRuleResponse
        /// </returns>
        public async Task<UploadRuleResponse> UploadRuleWithOptionsAsync(UploadRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadRule",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UploadRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadRuleResponse
        /// </returns>
        public UploadRuleResponse UploadRule(UploadRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadRuleWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UploadRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadRuleResponse
        /// </returns>
        public async Task<UploadRuleResponse> UploadRuleAsync(UploadRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadRuleWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// VerifyFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyFileResponse
        /// </returns>
        public VerifyFileResponse VerifyFileWithOptions(VerifyFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyFile",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyFileResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// VerifyFileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyFileResponse
        /// </returns>
        public async Task<VerifyFileResponse> VerifyFileWithOptionsAsync(VerifyFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyFile",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// VerifyFileRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyFileResponse
        /// </returns>
        public VerifyFileResponse VerifyFile(VerifyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyFileWithOptions(request, runtime);
        }

        /// <param name="request">
        /// VerifyFileRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyFileResponse
        /// </returns>
        public async Task<VerifyFileResponse> VerifyFileAsync(VerifyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyFileWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// VerifySentenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifySentenceResponse
        /// </returns>
        public VerifySentenceResponse VerifySentenceWithOptions(VerifySentenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifySentence",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifySentenceResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// VerifySentenceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifySentenceResponse
        /// </returns>
        public async Task<VerifySentenceResponse> VerifySentenceWithOptionsAsync(VerifySentenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifySentence",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifySentenceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// VerifySentenceRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifySentenceResponse
        /// </returns>
        public VerifySentenceResponse VerifySentence(VerifySentenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifySentenceWithOptions(request, runtime);
        }

        /// <param name="request">
        /// VerifySentenceRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifySentenceResponse
        /// </returns>
        public async Task<VerifySentenceResponse> VerifySentenceAsync(VerifySentenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifySentenceWithOptionsAsync(request, runtime);
        }

    }
}
