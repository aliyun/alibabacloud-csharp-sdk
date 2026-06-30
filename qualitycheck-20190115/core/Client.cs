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
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "qualitycheck.cn-hangzhou.aliyuncs.com"},
            };
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a business category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a business category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a business category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds a business category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Add a rule category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Add a rule category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Add a rule category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Add a rule category.</para>
        /// </summary>
        /// 
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
        /// <para>This operation creates a rule on the Quality Inspection Rule Configuration page. For Apsara Stack, the URL is ip:port/api/client/UpdateRuleById.json.</para>
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
        /// <para>This operation creates a rule on the Quality Inspection Rule Configuration page. For Apsara Stack, the URL is ip:port/api/client/UpdateRuleById.json.</para>
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
        /// <para>This operation creates a rule on the Quality Inspection Rule Configuration page. For Apsara Stack, the URL is ip:port/api/client/UpdateRuleById.json.</para>
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
        /// <para>This operation creates a rule on the Quality Inspection Rule Configuration page. For Apsara Stack, the URL is ip:port/api/client/UpdateRuleById.json.</para>
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
        /// <para>Performs tag categorization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeLabelResponse
        /// </returns>
        public AnalyzeLabelResponse AnalyzeLabelWithOptions(AnalyzeLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AnalyzeLabel",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalyzeLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs tag categorization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeLabelResponse
        /// </returns>
        public async Task<AnalyzeLabelResponse> AnalyzeLabelWithOptionsAsync(AnalyzeLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "AnalyzeLabel",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AnalyzeLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs tag categorization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeLabelResponse
        /// </returns>
        public AnalyzeLabelResponse AnalyzeLabel(AnalyzeLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AnalyzeLabelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs tag categorization.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AnalyzeLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// AnalyzeLabelResponse
        /// </returns>
        public async Task<AnalyzeLabelResponse> AnalyzeLabelAsync(AnalyzeLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AnalyzeLabelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Apply for the token required for real-time speech processing.</para>
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
        /// <para>Apply for the token required for real-time speech processing.</para>
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
        /// <para>Apply for the token required for real-time speech processing.</para>
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
        /// <para>Apply for the token required for real-time speech processing.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually assign quality reviewers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can manually assign files that have completed quality inspection to reviewers. Assignments can be made one file at a time or in batches:
        /// Single-file assignment: Assign a specific file to a specified reviewer.
        /// Batch assignment: Assign multiple filtered files to one or more reviewers. You can specify how many files each reviewer receives, or let the system distribute the files evenly among reviewers.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually assign quality reviewers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can manually assign files that have completed quality inspection to reviewers. Assignments can be made one file at a time or in batches:
        /// Single-file assignment: Assign a specific file to a specified reviewer.
        /// Batch assignment: Assign multiple filtered files to one or more reviewers. You can specify how many files each reviewer receives, or let the system distribute the files evenly among reviewers.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually assign quality reviewers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can manually assign files that have completed quality inspection to reviewers. Assignments can be made one file at a time or in batches:
        /// Single-file assignment: Assign a specific file to a specified reviewer.
        /// Batch assignment: Assign multiple filtered files to one or more reviewers. You can specify how many files each reviewer receives, or let the system distribute the files evenly among reviewers.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually assign quality reviewers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can manually assign files that have completed quality inspection to reviewers. Assignments can be made one file at a time or in batches:
        /// Single-file assignment: Assign a specific file to a specified reviewer.
        /// Batch assignment: Assign multiple filtered files to one or more reviewers. You can specify how many files each reviewer receives, or let the system distribute the files evenly among reviewers.</para>
        /// </description>
        /// 
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
        /// <para>Frontend location: Quality Check Plan Management &gt; Task Results &gt; Session Groups &gt; Batch Assign. Apsara Stack URL: ip:port/api/job/AssignReviewerBySessionGroup.json.</para>
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
        /// <para>Frontend location: Quality Check Plan Management &gt; Task Results &gt; Session Groups &gt; Batch Assign. Apsara Stack URL: ip:port/api/job/AssignReviewerBySessionGroup.json.</para>
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
        /// <para>Frontend location: Quality Check Plan Management &gt; Task Results &gt; Session Groups &gt; Batch Assign. Apsara Stack URL: ip:port/api/job/AssignReviewerBySessionGroup.json.</para>
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
        /// <para>Frontend location: Quality Check Plan Management &gt; Task Results &gt; Session Groups &gt; Batch Assign. Apsara Stack URL: ip:port/api/job/AssignReviewerBySessionGroup.json.</para>
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
        /// <para>This operation implements the Batch Review feature, which is available in the frontend under Task Management &gt; Task Result.
        /// For private cloud deployments, use the URL: ip:port/api/qcsBatchSubmitReviewInfo.json.
        /// You can use this operation to perform a batch review on all filtered data.
        /// Note: This operation updates a large volume of data. The changes may take some time to appear.</para>
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
        /// <para>This operation implements the Batch Review feature, which is available in the frontend under Task Management &gt; Task Result.
        /// For private cloud deployments, use the URL: ip:port/api/qcsBatchSubmitReviewInfo.json.
        /// You can use this operation to perform a batch review on all filtered data.
        /// Note: This operation updates a large volume of data. The changes may take some time to appear.</para>
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
        /// <para>This operation implements the Batch Review feature, which is available in the frontend under Task Management &gt; Task Result.
        /// For private cloud deployments, use the URL: ip:port/api/qcsBatchSubmitReviewInfo.json.
        /// You can use this operation to perform a batch review on all filtered data.
        /// Note: This operation updates a large volume of data. The changes may take some time to appear.</para>
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
        /// <para>This operation implements the Batch Review feature, which is available in the frontend under Task Management &gt; Task Result.
        /// For private cloud deployments, use the URL: ip:port/api/qcsBatchSubmitReviewInfo.json.
        /// You can use this operation to perform a batch review on all filtered data.
        /// Note: This operation updates a large volume of data. The changes may take some time to appear.</para>
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
        /// <para>Creates an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public CreateAgentResponse CreateAgentWithOptions(CreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateAgent",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public async Task<CreateAgentResponse> CreateAgentWithOptionsAsync(CreateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateAgent",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public CreateAgentResponse CreateAgent(CreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentResponse
        /// </returns>
        public async Task<CreateAgentResponse> CreateAgentAsync(CreateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Agent batch task for conversation analysis. The application call supports HTTP calls to complete the customer response.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentTaskResponse
        /// </returns>
        public CreateAgentTaskResponse CreateAgentTaskWithOptions(CreateAgentTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateAgentTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Agent batch task for conversation analysis. The application call supports HTTP calls to complete the customer response.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentTaskResponse
        /// </returns>
        public async Task<CreateAgentTaskResponse> CreateAgentTaskWithOptionsAsync(CreateAgentTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateAgentTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAgentTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Agent batch task for conversation analysis. The application call supports HTTP calls to complete the customer response.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentTaskResponse
        /// </returns>
        public CreateAgentTaskResponse CreateAgentTask(CreateAgentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAgentTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an Agent batch task for conversation analysis. The application call supports HTTP calls to complete the customer response.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAgentTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAgentTaskResponse
        /// </returns>
        public async Task<CreateAgentTaskResponse> CreateAgentTaskAsync(CreateAgentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAgentTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads a set of speech hotwords to the server and obtains the hotword ID in the response.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Hotwords help improve recognition accuracy for specific terms, such as names, place names, or technical terms. <a href="https://help.aliyun.com/document_detail/213249.html">Learn more</a>.</para>
        /// </remarks>
        /// </description>
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
        /// <para>Uploads a set of speech hotwords to the server and obtains the hotword ID in the response.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Hotwords help improve recognition accuracy for specific terms, such as names, place names, or technical terms. <a href="https://help.aliyun.com/document_detail/213249.html">Learn more</a>.</para>
        /// </remarks>
        /// </description>
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
        /// <para>Uploads a set of speech hotwords to the server and obtains the hotword ID in the response.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Hotwords help improve recognition accuracy for specific terms, such as names, place names, or technical terms. <a href="https://help.aliyun.com/document_detail/213249.html">Learn more</a>.</para>
        /// </remarks>
        /// </description>
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
        /// <para>Uploads a set of speech hotwords to the server and obtains the hotword ID in the response.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Hotwords help improve recognition accuracy for specific terms, such as names, place names, or technical terms. <a href="https://help.aliyun.com/document_detail/213249.html">Learn more</a>.</para>
        /// </remarks>
        /// </description>
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
        /// <para>UI path: Quality Check Plan Management &gt; Add or Edit Quality Check Dimension &gt; Add Quality Check Dimension. Apsara Stack API endpoint: ip:port/api/qcs/CreateCheckTypeToScheme.json.</para>
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
        /// <para>UI path: Quality Check Plan Management &gt; Add or Edit Quality Check Dimension &gt; Add Quality Check Dimension. Apsara Stack API endpoint: ip:port/api/qcs/CreateCheckTypeToScheme.json.</para>
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
        /// <para>UI path: Quality Check Plan Management &gt; Add or Edit Quality Check Dimension &gt; Add Quality Check Dimension. Apsara Stack API endpoint: ip:port/api/qcs/CreateCheckTypeToScheme.json.</para>
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
        /// <para>UI path: Quality Check Plan Management &gt; Add or Edit Quality Check Dimension &gt; Add Quality Check Dimension. Apsara Stack API endpoint: ip:port/api/qcs/CreateCheckTypeToScheme.json.</para>
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
        /// <para>Creates a label mining task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMiningTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMiningTaskResponse
        /// </returns>
        public CreateMiningTaskResponse CreateMiningTaskWithOptions(CreateMiningTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMiningTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMiningTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a label mining task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMiningTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMiningTaskResponse
        /// </returns>
        public async Task<CreateMiningTaskResponse> CreateMiningTaskWithOptionsAsync(CreateMiningTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackUrl))
            {
                body["CallbackUrl"] = request.CallbackUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilePath))
            {
                body["FilePath"] = request.FilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Param))
            {
                body["Param"] = request.Param;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMiningTask",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMiningTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a label mining task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMiningTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMiningTaskResponse
        /// </returns>
        public CreateMiningTaskResponse CreateMiningTask(CreateMiningTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMiningTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a label mining task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMiningTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMiningTaskResponse
        /// </returns>
        public async Task<CreateMiningTaskResponse> CreateMiningTaskAsync(CreateMiningTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMiningTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can access this operation from the Quality Check Plan Management page in the console. The Apsara Stack endpoint is ip:port/api/qcs/CreateQualityCheckScheme.json.</para>
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
        /// <para>You can access this operation from the Quality Check Plan Management page in the console. The Apsara Stack endpoint is ip:port/api/qcs/CreateQualityCheckScheme.json.</para>
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
        /// <para>You can access this operation from the Quality Check Plan Management page in the console. The Apsara Stack endpoint is ip:port/api/qcs/CreateQualityCheckScheme.json.</para>
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
        /// <para>You can access this operation from the Quality Check Plan Management page in the console. The Apsara Stack endpoint is ip:port/api/qcs/CreateQualityCheckScheme.json.</para>
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
        /// <para>Corresponding frontend feature location: Plan Management &gt; Create Quality Inspection Job. Apsara Stack URL: ip:port/api/task/CreateSchemeTaskConfig.json.</para>
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
        /// <para>Corresponding frontend feature location: Plan Management &gt; Create Quality Inspection Job. Apsara Stack URL: ip:port/api/task/CreateSchemeTaskConfig.json.</para>
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
        /// <para>Corresponding frontend feature location: Plan Management &gt; Create Quality Inspection Job. Apsara Stack URL: ip:port/api/task/CreateSchemeTaskConfig.json.</para>
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
        /// <para>Corresponding frontend feature location: Plan Management &gt; Create Quality Inspection Job. Apsara Stack URL: ip:port/api/task/CreateSchemeTaskConfig.json.</para>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a configuration.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a configuration.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a configuration.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a configuration.</para>
        /// </summary>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTagResponse
        /// </returns>
        public CreateTagResponse CreateTagWithOptions(CreateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateTag",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTagResponse
        /// </returns>
        public async Task<CreateTagResponse> CreateTagWithOptionsAsync(CreateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateTag",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTagRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTagResponse
        /// </returns>
        public CreateTagResponse CreateTag(CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTagRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTagResponse
        /// </returns>
        public async Task<CreateTagResponse> CreateTagAsync(CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an automatic allocation rule for quality review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an automatic allocation rule for quality review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an automatic allocation rule for quality review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an automatic allocation rule for quality review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a user</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Alibaba Cloud uses Resource Access Management (RAM) for unified account management. Before you create a user in Smart Conversation Analysis, first create the user in <a href="https://ram.console.aliyun.com">RAM</a>. Then, obtain the user’s UID, username, and display name. Finally, add the RAM user to Smart Conversation Analysis to grant them access to the Smart Conversation Analysis service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateUser",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a user</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Alibaba Cloud uses Resource Access Management (RAM) for unified account management. Before you create a user in Smart Conversation Analysis, first create the user in <a href="https://ram.console.aliyun.com">RAM</a>. Then, obtain the user’s UID, username, and display name. Finally, add the RAM user to Smart Conversation Analysis to grant them access to the Smart Conversation Analysis service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateUser",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a user</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Alibaba Cloud uses Resource Access Management (RAM) for unified account management. Before you create a user in Smart Conversation Analysis, first create the user in <a href="https://ram.console.aliyun.com">RAM</a>. Then, obtain the user’s UID, username, and display name. Finally, add the RAM user to Smart Conversation Analysis to grant them access to the Smart Conversation Analysis service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a user</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Alibaba Cloud uses Resource Access Management (RAM) for unified account management. Before you create a user in Smart Conversation Analysis, first create the user in <a href="https://ram.console.aliyun.com">RAM</a>. Then, obtain the user’s UID, username, and display name. Finally, add the RAM user to Smart Conversation Analysis to grant them access to the Smart Conversation Analysis service.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserResponse
        /// </returns>
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a warning configuration.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a warning configuration.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a warning configuration.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a warning configuration.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a rule category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a rule category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a rule category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a rule category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public DeleteAgentResponse DeleteAgentWithOptions(DeleteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAgent",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public async Task<DeleteAgentResponse> DeleteAgentWithOptionsAsync(DeleteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAgent",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public DeleteAgentResponse DeleteAgent(DeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAgentResponse
        /// </returns>
        public async Task<DeleteAgentResponse> DeleteAgentAsync(DeleteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a hotword group.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a hotword group.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a hotword group.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a hotword group.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a business category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a business category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a business category.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a business category.</para>
        /// </summary>
        /// 
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
        /// <para>Deletes a dimension from a quality inspection scheme.</para>
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
        /// <para>Deletes a dimension from a quality inspection scheme.</para>
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
        /// <para>Deletes a dimension from a quality inspection scheme.</para>
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
        /// <para>Deletes a dimension from a quality inspection scheme.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a language model.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a language model.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a language model.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a language model.</para>
        /// </summary>
        /// 
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dataset.</para>
        /// </summary>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a speech recognition quality check task.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a speech recognition quality check task.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a speech recognition quality check task.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a speech recognition quality check task.</para>
        /// </summary>
        /// 
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
        /// <para>You can delete a quality check plan from the Quality Check Plan Management page by clicking the Delete button on the right side of the plan. The Apsara Stack API endpoint is ip:port/api/qcs/DeleteQualityCheckScheme.json.</para>
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
        /// <para>You can delete a quality check plan from the Quality Check Plan Management page by clicking the Delete button on the right side of the plan. The Apsara Stack API endpoint is ip:port/api/qcs/DeleteQualityCheckScheme.json.</para>
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
        /// <para>You can delete a quality check plan from the Quality Check Plan Management page by clicking the Delete button on the right side of the plan. The Apsara Stack API endpoint is ip:port/api/qcs/DeleteQualityCheckScheme.json.</para>
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
        /// <para>You can delete a quality check plan from the Quality Check Plan Management page by clicking the Delete button on the right side of the plan. The Apsara Stack API endpoint is ip:port/api/qcs/DeleteQualityCheckScheme.json.</para>
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
        /// <para>This operation deletes a quality check rule. You can access it from the Quality Check Rule Configuration page in the Apsara Stack console. The API endpoint is ip:port/api/client/DeleteRule.json.</para>
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
        /// <para>This operation deletes a quality check rule. You can access it from the Quality Check Rule Configuration page in the Apsara Stack console. The API endpoint is ip:port/api/client/DeleteRule.json.</para>
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
        /// <para>This operation deletes a quality check rule. You can access it from the Quality Check Rule Configuration page in the Apsara Stack console. The API endpoint is ip:port/api/client/DeleteRule.json.</para>
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
        /// <para>This operation deletes a quality check rule. You can access it from the Quality Check Rule Configuration page in the Apsara Stack console. The API endpoint is ip:port/api/client/DeleteRule.json.</para>
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
        /// <para>Frontend feature location: Quality Inspection Rule Configuration — Delete. Apsara Stack URL: ip:port/api/client/DeleteRule.json.</para>
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
        /// <para>Frontend feature location: Quality Inspection Rule Configuration — Delete. Apsara Stack URL: ip:port/api/client/DeleteRule.json.</para>
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
        /// <para>Frontend feature location: Quality Inspection Rule Configuration — Delete. Apsara Stack URL: ip:port/api/client/DeleteRule.json.</para>
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
        /// <para>Frontend feature location: Quality Inspection Rule Configuration — Delete. Apsara Stack URL: ip:port/api/client/DeleteRule.json.</para>
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
        /// <para>This feature is not available on the frontend. The Apsara Stack API endpoint is ip:port/api/task/DeleteSchemeTaskConfig.json.</para>
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
        /// <para>This feature is not available on the frontend. The Apsara Stack API endpoint is ip:port/api/task/DeleteSchemeTaskConfig.json.</para>
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
        /// <para>This feature is not available on the frontend. The Apsara Stack API endpoint is ip:port/api/task/DeleteSchemeTaskConfig.json.</para>
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
        /// <para>This feature is not available on the frontend. The Apsara Stack API endpoint is ip:port/api/task/DeleteSchemeTaskConfig.json.</para>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a configuration.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a configuration.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a configuration.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a configuration.</para>
        /// </summary>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTagResponse
        /// </returns>
        public DeleteTagResponse DeleteTagWithOptions(DeleteTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteTag",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTagResponse
        /// </returns>
        public async Task<DeleteTagResponse> DeleteTagWithOptionsAsync(DeleteTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteTag",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTagRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTagResponse
        /// </returns>
        public DeleteTagResponse DeleteTag(DeleteTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteTagRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteTagResponse
        /// </returns>
        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an automatic allocation rule for review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an automatic allocation rule for review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an automatic allocation rule for review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an automatic allocation rule for review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a warning configuration.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a warning configuration.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a warning configuration.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a warning configuration.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAgentResponse
        /// </returns>
        public ExecuteAgentResponse ExecuteAgentWithOptions(ExecuteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["Stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteAgent",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAgentResponse
        /// </returns>
        public async Task<ExecuteAgentResponse> ExecuteAgentWithOptionsAsync(ExecuteAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["Stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteAgent",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAgentResponse
        /// </returns>
        public ExecuteAgentResponse ExecuteAgent(ExecuteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteAgentResponse
        /// </returns>
        public async Task<ExecuteAgentResponse> ExecuteAgentAsync(ExecuteAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates labels.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateLabelResponse
        /// </returns>
        public GenerateLabelResponse GenerateLabelWithOptions(GenerateLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GenerateLabel",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates labels.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateLabelResponse
        /// </returns>
        public async Task<GenerateLabelResponse> GenerateLabelWithOptionsAsync(GenerateLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GenerateLabel",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates labels.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateLabelResponse
        /// </returns>
        public GenerateLabelResponse GenerateLabel(GenerateLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateLabelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates labels.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateLabelResponse
        /// </returns>
        public async Task<GenerateLabelResponse> GenerateLabelAsync(GenerateLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateLabelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public GetAgentResponse GetAgentWithOptions(GetAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAgent",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public async Task<GetAgentResponse> GetAgentWithOptionsAsync(GetAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAgent",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public GetAgentResponse GetAgent(GetAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentResponse
        /// </returns>
        public async Task<GetAgentResponse> GetAgentAsync(GetAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the task result of an agent node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentTaskResultResponse
        /// </returns>
        public GetAgentTaskResultResponse GetAgentTaskResultWithOptions(GetAgentTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAgentTaskResult",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the task result of an agent node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAgentTaskResultResponse
        /// </returns>
        public async Task<GetAgentTaskResultResponse> GetAgentTaskResultWithOptionsAsync(GetAgentTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAgentTaskResult",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAgentTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the task result of an agent node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentTaskResultResponse
        /// </returns>
        public GetAgentTaskResultResponse GetAgentTaskResult(GetAgentTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the task result of an agent node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAgentTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAgentTaskResultResponse
        /// </returns>
        public async Task<GetAgentTaskResultResponse> GetAgentTaskResultAsync(GetAgentTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details for a specified hotword group.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details for a specified hotword group.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details for a specified hotword group.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves details for a specified hotword group.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the list of applicable businesses.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the list of applicable businesses.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the list of applicable businesses.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the list of applicable businesses.</para>
        /// </summary>
        /// 
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
        /// <para>Retrieves a list of language models.</para>
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
        /// <para>Retrieves a list of language models.</para>
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
        /// <para>Retrieves a list of language models.</para>
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
        /// <para>Retrieves a list of language models.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of tag categorization analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLabelAnalysisResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLabelAnalysisResultResponse
        /// </returns>
        public GetLabelAnalysisResultResponse GetLabelAnalysisResultWithOptions(GetLabelAnalysisResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetLabelAnalysisResult",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLabelAnalysisResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of tag categorization analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLabelAnalysisResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLabelAnalysisResultResponse
        /// </returns>
        public async Task<GetLabelAnalysisResultResponse> GetLabelAnalysisResultWithOptionsAsync(GetLabelAnalysisResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetLabelAnalysisResult",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLabelAnalysisResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of tag categorization analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLabelAnalysisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLabelAnalysisResultResponse
        /// </returns>
        public GetLabelAnalysisResultResponse GetLabelAnalysisResult(GetLabelAnalysisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLabelAnalysisResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the results of tag categorization analysis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLabelAnalysisResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLabelAnalysisResultResponse
        /// </returns>
        public async Task<GetLabelAnalysisResultResponse> GetLabelAnalysisResultAsync(GetLabelAnalysisResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLabelAnalysisResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of a label generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLabelGeneratedResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLabelGeneratedResultResponse
        /// </returns>
        public GetLabelGeneratedResultResponse GetLabelGeneratedResultWithOptions(GetLabelGeneratedResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetLabelGeneratedResult",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLabelGeneratedResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of a label generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLabelGeneratedResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetLabelGeneratedResultResponse
        /// </returns>
        public async Task<GetLabelGeneratedResultResponse> GetLabelGeneratedResultWithOptionsAsync(GetLabelGeneratedResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetLabelGeneratedResult",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLabelGeneratedResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of a label generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLabelGeneratedResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLabelGeneratedResultResponse
        /// </returns>
        public GetLabelGeneratedResultResponse GetLabelGeneratedResult(GetLabelGeneratedResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLabelGeneratedResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of a label generation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetLabelGeneratedResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetLabelGeneratedResultResponse
        /// </returns>
        public async Task<GetLabelGeneratedResultResponse> GetLabelGeneratedResultAsync(GetLabelGeneratedResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLabelGeneratedResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the result of a tag mining task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMiningTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMiningTaskResultResponse
        /// </returns>
        public GetMiningTaskResultResponse GetMiningTaskResultWithOptions(GetMiningTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
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
                Action = "GetMiningTaskResult",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMiningTaskResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the result of a tag mining task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMiningTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMiningTaskResultResponse
        /// </returns>
        public async Task<GetMiningTaskResultResponse> GetMiningTaskResultWithOptionsAsync(GetMiningTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
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
                Action = "GetMiningTaskResult",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMiningTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the result of a tag mining task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMiningTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMiningTaskResultResponse
        /// </returns>
        public GetMiningTaskResultResponse GetMiningTaskResult(GetMiningTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMiningTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the result of a tag mining task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMiningTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMiningTaskResultResponse
        /// </returns>
        public async Task<GetMiningTaskResultResponse> GetMiningTaskResultAsync(GetMiningTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMiningTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the next file details for manual verification.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the next file details for manual verification.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the next file details for manual verification.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the next file details for manual verification.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a (speech recognition) detection task.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a (speech recognition) detection task.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a (speech recognition) detection task.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a (speech recognition) detection task.</para>
        /// </summary>
        /// 
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
        /// <para>This operation implements the query feature in quality check plan management on the frontend. The Apsara Stack URL is ip:port/api/qcs/GetQualityCheckScheme.json.</para>
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
        /// <para>This operation implements the query feature in quality check plan management on the frontend. The Apsara Stack URL is ip:port/api/qcs/GetQualityCheckScheme.json.</para>
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
        /// <para>This operation implements the query feature in quality check plan management on the frontend. The Apsara Stack URL is ip:port/api/qcs/GetQualityCheckScheme.json.</para>
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
        /// <para>This operation implements the query feature in quality check plan management on the frontend. The Apsara Stack URL is ip:port/api/qcs/GetQualityCheckScheme.json.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query quality inspection results. Some fields require the requiredFields parameter to be explicitly specified in the request. Set the service endpoint (Region) to Hangzhou (cn-hangzhou).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query data uploaded using <a href="https://help.aliyun.com/document_detail/139399.html">UploadAudioData</a> or <a href="https://help.aliyun.com/document_detail/111394.html">UploadData</a>. You can also query data from dataset-based quality inspection tasks created with <a href="https://help.aliyun.com/document_detail/158890.html">SubmitQualityCheckTask</a>. You can search by task ID (taskId) or by time range.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query quality inspection results. Some fields require the requiredFields parameter to be explicitly specified in the request. Set the service endpoint (Region) to Hangzhou (cn-hangzhou).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query data uploaded using <a href="https://help.aliyun.com/document_detail/139399.html">UploadAudioData</a> or <a href="https://help.aliyun.com/document_detail/111394.html">UploadData</a>. You can also query data from dataset-based quality inspection tasks created with <a href="https://help.aliyun.com/document_detail/158890.html">SubmitQualityCheckTask</a>. You can search by task ID (taskId) or by time range.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query quality inspection results. Some fields require the requiredFields parameter to be explicitly specified in the request. Set the service endpoint (Region) to Hangzhou (cn-hangzhou).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query data uploaded using <a href="https://help.aliyun.com/document_detail/139399.html">UploadAudioData</a> or <a href="https://help.aliyun.com/document_detail/111394.html">UploadData</a>. You can also query data from dataset-based quality inspection tasks created with <a href="https://help.aliyun.com/document_detail/158890.html">SubmitQualityCheckTask</a>. You can search by task ID (taskId) or by time range.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query quality inspection results. Some fields require the requiredFields parameter to be explicitly specified in the request. Set the service endpoint (Region) to Hangzhou (cn-hangzhou).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query data uploaded using <a href="https://help.aliyun.com/document_detail/139399.html">UploadAudioData</a> or <a href="https://help.aliyun.com/document_detail/111394.html">UploadData</a>. You can also query data from dataset-based quality inspection tasks created with <a href="https://help.aliyun.com/document_detail/158890.html">SubmitQualityCheckTask</a>. You can search by task ID (taskId) or by time range.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the quality inspection results for a specified file. The response includes the transcript, audio URL, and details of detected rule hits. You can use this information to review the file by listening to the audio, reading the transcript, and locating where rules were triggered.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the quality inspection results for a specified file. The response includes the transcript, audio URL, and details of detected rule hits. You can use this information to review the file by listening to the audio, reading the transcript, and locating where rules were triggered.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the quality inspection results for a specified file. The response includes the transcript, audio URL, and details of detected rule hits. You can use this information to review the file by listening to the audio, reading the transcript, and locating where rules were triggered.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the quality inspection results for a specified file. The response includes the transcript, audio URL, and details of detected rule hits. You can use this information to review the file by listening to the audio, reading the transcript, and locating where rules were triggered.</para>
        /// </summary>
        /// 
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves basic information about rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation returns basic rule information such as the <b>id</b> and <b>name</b>. You can use this information with <a href="https://help.aliyun.com/document_detail/142310.html">GetRuleDetails</a>.</para>
        /// </remarks>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves basic information about rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation returns basic rule information such as the <b>id</b> and <b>name</b>. You can use this information with <a href="https://help.aliyun.com/document_detail/142310.html">GetRuleDetails</a>.</para>
        /// </remarks>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves basic information about rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation returns basic rule information such as the <b>id</b> and <b>name</b>. You can use this information with <a href="https://help.aliyun.com/document_detail/142310.html">GetRuleDetails</a>.</para>
        /// </remarks>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves basic information about rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation returns basic rule information such as the <b>id</b> and <b>name</b>. You can use this information with <a href="https://help.aliyun.com/document_detail/142310.html">GetRuleDetails</a>.</para>
        /// </remarks>
        /// </description>
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
        /// <para>Retrieves the details of a specific quality inspection rule. It corresponds to the <b>Edit</b> action on the <b>Quality Inspection Rule Configuration</b> page. The URL for this operation in a private cloud is <c>ip:port/api/client/GetRuleById.json</c>.</para>
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
        /// <para>Retrieves the details of a specific quality inspection rule. It corresponds to the <b>Edit</b> action on the <b>Quality Inspection Rule Configuration</b> page. The URL for this operation in a private cloud is <c>ip:port/api/client/GetRuleById.json</c>.</para>
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
        /// <para>Retrieves the details of a specific quality inspection rule. It corresponds to the <b>Edit</b> action on the <b>Quality Inspection Rule Configuration</b> page. The URL for this operation in a private cloud is <c>ip:port/api/client/GetRuleById.json</c>.</para>
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
        /// <para>Retrieves the details of a specific quality inspection rule. It corresponds to the <b>Edit</b> action on the <b>Quality Inspection Rule Configuration</b> page. The URL for this operation in a private cloud is <c>ip:port/api/client/GetRuleById.json</c>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of rule types.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of rule types.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of rule types.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of rule types.</para>
        /// </summary>
        /// 
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the detailed information of a rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation is used in conjunction with <a href="https://help.aliyun.com/document_detail/142333.html">Get basic rule information</a>. First, call the GetRule operation to obtain the rule ID. Then, use the rule ID as a parameter to call the <b>GetRuleDetail</b> operation.</para>
        /// </remarks>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the detailed information of a rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation is used in conjunction with <a href="https://help.aliyun.com/document_detail/142333.html">Get basic rule information</a>. First, call the GetRule operation to obtain the rule ID. Then, use the rule ID as a parameter to call the <b>GetRuleDetail</b> operation.</para>
        /// </remarks>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the detailed information of a rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation is used in conjunction with <a href="https://help.aliyun.com/document_detail/142333.html">Get basic rule information</a>. First, call the GetRule operation to obtain the rule ID. Then, use the rule ID as a parameter to call the <b>GetRuleDetail</b> operation.</para>
        /// </remarks>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the detailed information of a rule.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>This operation is used in conjunction with <a href="https://help.aliyun.com/document_detail/142333.html">Get basic rule information</a>. First, call the GetRule operation to obtain the rule ID. Then, use the rule ID as a parameter to call the <b>GetRuleDetail</b> operation.</para>
        /// </remarks>
        /// </description>
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
        /// <para>This API is located in the frontend at Quality Check Rule Configuration &gt; Query. The Apsara Stack URL is ip:port/api/client/GetRuleById.json.</para>
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
        /// <para>This API is located in the frontend at Quality Check Rule Configuration &gt; Query. The Apsara Stack URL is ip:port/api/client/GetRuleById.json.</para>
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
        /// <para>This API is located in the frontend at Quality Check Rule Configuration &gt; Query. The Apsara Stack URL is ip:port/api/client/GetRuleById.json.</para>
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
        /// <para>This API is located in the frontend at Quality Check Rule Configuration &gt; Query. The Apsara Stack URL is ip:port/api/client/GetRuleById.json.</para>
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
        /// <para>Corresponds to the frontend feature location: Quality Inspection Rule Configuration &gt; List. Apsara Stack URL: ip:port/api/rule/GetRulesCountList.json.</para>
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
        /// <para>Corresponds to the frontend feature location: Quality Inspection Rule Configuration &gt; List. Apsara Stack URL: ip:port/api/rule/GetRulesCountList.json.</para>
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
        /// <para>Corresponds to the frontend feature location: Quality Inspection Rule Configuration &gt; List. Apsara Stack URL: ip:port/api/rule/GetRulesCountList.json.</para>
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
        /// <para>Corresponds to the frontend feature location: Quality Inspection Rule Configuration &gt; List. Apsara Stack URL: ip:port/api/rule/GetRulesCountList.json.</para>
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
        /// <para>Obtain the configuration details of a quality inspection task.</para>
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
        /// <para>Obtain the configuration details of a quality inspection task.</para>
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
        /// <para>Obtain the configuration details of a quality inspection task.</para>
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
        /// <para>Obtain the configuration details of a quality inspection task.</para>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about all scoring items.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about all scoring items.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about all scoring items.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves information about all scoring items.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the configuration that is specified by its ID.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the configuration that is specified by its ID.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the configuration that is specified by its ID.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the configuration that is specified by its ID.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can obtain the real-time quality inspection result of the hotline.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can obtain the real-time quality inspection result of the hotline.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can obtain the real-time quality inspection result of the hotline.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can obtain the real-time quality inspection result of the hotline.</para>
        /// </summary>
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
        /// <para>Queries the details of a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTagResponse
        /// </returns>
        public GetTagResponse GetTagWithOptions(GetTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTag",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTagResponse
        /// </returns>
        public async Task<GetTagResponse> GetTagWithOptionsAsync(GetTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetTag",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTagRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTagResponse
        /// </returns>
        public GetTagResponse GetTag(GetTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTagRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTagResponse
        /// </returns>
        public async Task<GetTagResponse> GetTagAsync(GetTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTagWithOptionsAsync(request, runtime);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handles a complaint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only quality checkers or administrators can call this operation.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handles a complaint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only quality checkers or administrators can call this operation.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handles a complaint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only quality checkers or administrators can call this operation.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Handles a complaint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only quality checkers or administrators can call this operation.</para>
        /// </description>
        /// 
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete rules.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete rules.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete rules.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete rules.</para>
        /// </summary>
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
        /// <para>Retrieves a list of vocabulary groups without their specific content.</para>
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
        /// <para>Retrieves a list of vocabulary groups without their specific content.</para>
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
        /// <para>Retrieves a list of vocabulary groups without their specific content.</para>
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
        /// <para>Retrieves a list of vocabulary groups without their specific content.</para>
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
        /// <para>This feature is located in the Dataset management section of the frontend. The Apsara Stack URL is ip:port/api/dataset/ListDataSet.json.</para>
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
        /// <para>This feature is located in the Dataset management section of the frontend. The Apsara Stack URL is ip:port/api/dataset/ListDataSet.json.</para>
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
        /// <para>This feature is located in the Dataset management section of the frontend. The Apsara Stack URL is ip:port/api/dataset/ListDataSet.json.</para>
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
        /// <para>This feature is located in the Dataset management section of the frontend. The Apsara Stack URL is ip:port/api/dataset/ListDataSet.json.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the list of speech recognition precision tasks. Set the service endpoint to Hangzhou (cn-hangzhou).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the list of speech recognition precision tasks. Set the service endpoint to Hangzhou (cn-hangzhou).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the list of speech recognition precision tasks. Set the service endpoint to Hangzhou (cn-hangzhou).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the list of speech recognition precision tasks. Set the service endpoint to Hangzhou (cn-hangzhou).</para>
        /// </summary>
        /// 
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
        /// <para>Retrieves a list of quality check schemes.</para>
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
        /// <para>Retrieves a list of quality check schemes.</para>
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
        /// <para>Retrieves a list of quality check schemes.</para>
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
        /// <para>Retrieves a list of quality check schemes.</para>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists rules.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists rules.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists rules.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists rules.</para>
        /// </summary>
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
        /// <para>Frontend location: Quality inspection rule configuration — List. Apsara Stack URL: ip:port/api/rule/GetRulesCountList.json.</para>
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
        /// <para>Frontend location: Quality inspection rule configuration — List. Apsara Stack URL: ip:port/api/rule/GetRulesCountList.json.</para>
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
        /// <para>Frontend location: Quality inspection rule configuration — List. Apsara Stack URL: ip:port/api/rule/GetRulesCountList.json.</para>
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
        /// <para>Frontend location: Quality inspection rule configuration — List. Apsara Stack URL: ip:port/api/rule/GetRulesCountList.json.</para>
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
        /// <para>This operation is used for the Task Management feature on the frontend. The Apsara Stack URL is ip:port/api/task/ListSchemeTaskInfo.json.</para>
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
        /// <para>This operation is used for the Task Management feature on the frontend. The Apsara Stack URL is ip:port/api/task/ListSchemeTaskInfo.json.</para>
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
        /// <para>This operation is used for the Task Management feature on the frontend. The Apsara Stack URL is ip:port/api/task/ListSchemeTaskInfo.json.</para>
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
        /// <para>This operation is used for the Task Management feature on the frontend. The Apsara Stack URL is ip:port/api/task/ListSchemeTaskInfo.json.</para>
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
        /// <para>This API corresponds to the frontend location: Task Management &gt; View Results &gt; Task Result &gt; Session Group Results tab. The Apsara Stack URL is: ip:port/api/session/group/ListSessionGroup.json. It aggregates multi-turn sessions by their session group ID for unified management. You must pass the <c>sessionGroupId</c> field. For more information, see the UploadData and UploadAudioData API documentation.</para>
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
        /// <para>This API corresponds to the frontend location: Task Management &gt; View Results &gt; Task Result &gt; Session Group Results tab. The Apsara Stack URL is: ip:port/api/session/group/ListSessionGroup.json. It aggregates multi-turn sessions by their session group ID for unified management. You must pass the <c>sessionGroupId</c> field. For more information, see the UploadData and UploadAudioData API documentation.</para>
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
        /// <para>This API corresponds to the frontend location: Task Management &gt; View Results &gt; Task Result &gt; Session Group Results tab. The Apsara Stack URL is: ip:port/api/session/group/ListSessionGroup.json. It aggregates multi-turn sessions by their session group ID for unified management. You must pass the <c>sessionGroupId</c> field. For more information, see the UploadData and UploadAudioData API documentation.</para>
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
        /// <para>This API corresponds to the frontend location: Task Management &gt; View Results &gt; Task Result &gt; Session Group Results tab. The Apsara Stack URL is: ip:port/api/session/group/ListSessionGroup.json. It aggregates multi-turn sessions by their session group ID for unified management. You must pass the <c>sessionGroupId</c> field. For more information, see the UploadData and UploadAudioData API documentation.</para>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call ListSkillGroupConfig to obtain the configuration list.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call ListSkillGroupConfig to obtain the configuration list.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call ListSkillGroupConfig to obtain the configuration list.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call ListSkillGroupConfig to obtain the configuration list.</para>
        /// </summary>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of label nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResponse
        /// </returns>
        public ListTagResponse ListTagWithOptions(ListTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListTag",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of label nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResponse
        /// </returns>
        public async Task<ListTagResponse> ListTagWithOptionsAsync(ListTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListTag",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of label nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResponse
        /// </returns>
        public ListTagResponse ListTag(ListTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of label nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResponse
        /// </returns>
        public async Task<ListTagResponse> ListTagAsync(ListTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists automatic allocation rules for review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists automatic allocation rules for review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists automatic allocation rules for review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists automatic allocation rules for review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of users. Set the service endpoint to China (Hangzhou) (cn-hangzhou).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of users. Set the service endpoint to China (Hangzhou) (cn-hangzhou).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of users. Set the service endpoint to China (Hangzhou) (cn-hangzhou).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of users. Set the service endpoint to China (Hangzhou) (cn-hangzhou).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists warning configurations.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists warning configurations.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists warning configurations.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists warning configurations.</para>
        /// </summary>
        /// 
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
        /// <para>Frontend location: Task Management &gt; Task Results &gt; Batch Revoke. Apsara Stack URL: ip:port/api/job/RevertAssignedSession.json.</para>
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
        /// <para>Frontend location: Task Management &gt; Task Results &gt; Batch Revoke. Apsara Stack URL: ip:port/api/job/RevertAssignedSession.json.</para>
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
        /// <para>Frontend location: Task Management &gt; Task Results &gt; Batch Revoke. Apsara Stack URL: ip:port/api/job/RevertAssignedSession.json.</para>
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
        /// <para>Frontend location: Task Management &gt; Task Results &gt; Batch Revoke. Apsara Stack URL: ip:port/api/job/RevertAssignedSession.json.</para>
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
        /// <para>You can use this feature in the frontend console under Plan Management &gt; Task Result &gt; Session Group &gt; Batch Revoke. The Apsara Stack URL for this operation is <c>ip:port/api/job/RevertAssignedSessionGroup.json</c>.</para>
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
        /// <para>You can use this feature in the frontend console under Plan Management &gt; Task Result &gt; Session Group &gt; Batch Revoke. The Apsara Stack URL for this operation is <c>ip:port/api/job/RevertAssignedSessionGroup.json</c>.</para>
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
        /// <para>You can use this feature in the frontend console under Plan Management &gt; Task Result &gt; Session Group &gt; Batch Revoke. The Apsara Stack URL for this operation is <c>ip:port/api/job/RevertAssignedSessionGroup.json</c>.</para>
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
        /// <para>You can use this feature in the frontend console under Plan Management &gt; Task Result &gt; Session Group &gt; Batch Revoke. The Apsara Stack URL for this operation is <c>ip:port/api/job/RevertAssignedSessionGroup.json</c>.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation calls a large model using the message protocol to generate a response. You can make calls using standard HTTP for a complete response or use Server-Sent Events (SSE) for a streaming response.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunCompletionMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCompletionMessageResponse
        /// </returns>
        public RunCompletionMessageResponse RunCompletionMessageWithOptions(RunCompletionMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunCompletionMessageShrinkRequest request = new RunCompletionMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Messages))
            {
                request.MessagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Messages, "Messages", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessagesShrink))
            {
                body["Messages"] = request.MessagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                body["ModelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["Stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCompletionMessage",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCompletionMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation calls a large model using the message protocol to generate a response. You can make calls using standard HTTP for a complete response or use Server-Sent Events (SSE) for a streaming response.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunCompletionMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCompletionMessageResponse
        /// </returns>
        public async Task<RunCompletionMessageResponse> RunCompletionMessageWithOptionsAsync(RunCompletionMessageRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunCompletionMessageShrinkRequest request = new RunCompletionMessageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Messages))
            {
                request.MessagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Messages, "Messages", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessagesShrink))
            {
                body["Messages"] = request.MessagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelCode))
            {
                body["ModelCode"] = request.ModelCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["Stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCompletionMessage",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCompletionMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation calls a large model using the message protocol to generate a response. You can make calls using standard HTTP for a complete response or use Server-Sent Events (SSE) for a streaming response.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCompletionMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCompletionMessageResponse
        /// </returns>
        public RunCompletionMessageResponse RunCompletionMessage(RunCompletionMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCompletionMessageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation calls a large model using the message protocol to generate a response. You can make calls using standard HTTP for a complete response or use Server-Sent Events (SSE) for a streaming response.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCompletionMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCompletionMessageResponse
        /// </returns>
        public async Task<RunCompletionMessageResponse> RunCompletionMessageAsync(RunCompletionMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCompletionMessageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI SaveConfigDataSet is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves the speaker role configuration for a dataset.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves the speaker role configuration for a dataset.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves the speaker role configuration for a dataset.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves the speaker role configuration for a dataset.</para>
        /// </summary>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a complaint.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a complaint.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a complaint.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a complaint.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a speech recognition evaluation task. The service endpoint is China East 1 (Hangzhou) (cn-hangzhou).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a speech recognition evaluation task. The service endpoint is China East 1 (Hangzhou) (cn-hangzhou).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a speech recognition evaluation task. The service endpoint is China East 1 (Hangzhou) (cn-hangzhou).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a speech recognition evaluation task. The service endpoint is China East 1 (Hangzhou) (cn-hangzhou).</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a new dataset quality check task.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a new dataset quality check task.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a new dataset quality check task.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a new dataset quality check task.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Save review results. This is only supported by the legacy Smart Conversation Analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can manually review files after quality inspection. After completing the review, call this API to save the review results. This involves manually reviewing rules identified by the system as hits to determine if they are true hits or false positives. Refer to the file review feature on the console page. For more information, see <a href="https://help.aliyun.com/document_detail/139653.html#h2-u6587u4EF6u590Du68385">File Review</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Save review results. This is only supported by the legacy Smart Conversation Analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can manually review files after quality inspection. After completing the review, call this API to save the review results. This involves manually reviewing rules identified by the system as hits to determine if they are true hits or false positives. Refer to the file review feature on the console page. For more information, see <a href="https://help.aliyun.com/document_detail/139653.html#h2-u6587u4EF6u590Du68385">File Review</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Save review results. This is only supported by the legacy Smart Conversation Analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can manually review files after quality inspection. After completing the review, call this API to save the review results. This involves manually reviewing rules identified by the system as hits to determine if they are true hits or false positives. Refer to the file review feature on the console page. For more information, see <a href="https://help.aliyun.com/document_detail/139653.html#h2-u6587u4EF6u590Du68385">File Review</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Save review results. This is only supported by the legacy Smart Conversation Analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can manually review files after quality inspection. After completing the review, call this API to save the review results. This involves manually reviewing rules identified by the system as hits to determine if they are true hits or false positives. Refer to the file review feature on the console page. For more information, see <a href="https://help.aliyun.com/document_detail/139653.html#h2-u6587u4EF6u590Du68385">File Review</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Review quality inspection results</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitReviewInfoV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitReviewInfoV4Response
        /// </returns>
        public SubmitReviewInfoV4Response SubmitReviewInfoV4WithOptions(SubmitReviewInfoV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SubmitReviewInfoV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitReviewInfoV4Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Review quality inspection results</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitReviewInfoV4Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitReviewInfoV4Response
        /// </returns>
        public async Task<SubmitReviewInfoV4Response> SubmitReviewInfoV4WithOptionsAsync(SubmitReviewInfoV4Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SubmitReviewInfoV4",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitReviewInfoV4Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Review quality inspection results</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitReviewInfoV4Request
        /// </param>
        /// 
        /// <returns>
        /// SubmitReviewInfoV4Response
        /// </returns>
        public SubmitReviewInfoV4Response SubmitReviewInfoV4(SubmitReviewInfoV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitReviewInfoV4WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Review quality inspection results</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitReviewInfoV4Request
        /// </param>
        /// 
        /// <returns>
        /// SubmitReviewInfoV4Response
        /// </returns>
        public async Task<SubmitReviewInfoV4Response> SubmitReviewInfoV4Async(SubmitReviewInfoV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitReviewInfoV4WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Perform real-time quality inspection for hotlines.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Real-time hotline quality inspection transcribes spoken dialogue into text during a call. It sends the text to the Smart Conversation Analysis system for real-time quality inspection to detect potential issues or risks. You can display the dialogue text and inspection results in real time on the customer service representative\&quot;s workbench (a third-party system). This differs from offline quality inspection, which uses UploadAudioData for inspection or dataset inspection. For details, see the developer guide. Offline quality inspection occurs after the call ends and the recording file is generated.
        /// <b>Usage Flow</b>
        /// You can implement real-time transcription of audio streams to text during calls, or use Alibaba Cloud Call Center (CC) directly. CC integrates deeply with Smart Conversation Analysis, enabling real-time quality inspection during calls without API integration.
        /// If you implement audio-to-text conversion yourself, invoke the SyncQualityCheck API for real-time quality inspection after a speaker finishes a sentence and generates dialogue text. This returns the inspection result for that sentence synchronously.
        /// You should include skill group information when uploading data. Then, you can use the Call Center Quality Inspection - Configuration Management feature to configure different quality inspection rules for calls from different skill groups.
        /// After the call ends, you can store the recording file on a storage server accessible over the public network. You can invoke the recording information maintenance API: UpdateSyncQualityCheckData. You can submit the recording name, recording file URL, and other details to the Smart Conversation Analysis service. This lets quality inspectors play back the recording during review.
        /// After the call ends, you can view the quality inspection results in Call Center Quality Inspection - Result Display - Real-time Quality Inspection Results. You can also invoke the real-time quality inspection result query API: GetSyncResult to retrieve the results. You can use Score Dashboard - Real-time Dashboard to view data charts for customer service representatives, skill groups, and scoring items.
        /// <b>Full-Text Quality Inspection</b>
        /// Quality inspection rules include dozens of operators. Some operators require dialogue context (multi-turn conversations between customer service representatives and customers) for analysis. However, real-time quality inspection occurs during a call and typically uses text from only one sentence spoken by a single speaker. Some operators are not suitable for real-time quality inspection. Therefore, quality inspection rules are divided into real-time quality inspection rules and full-text quality inspection rules:
        /// <b>Real-time quality inspection rules</b>: Rules used for real-time quality inspection. They support a limited number of operator types. They do not support specifying the detection range for operators.
        /// <b>Full-text quality inspection rules</b>: Rules used for offline quality inspection. They support all operator types. They support custom detection ranges for operators.
        /// For calls that underwent real-time quality inspection, you can apply full-text quality inspection rules to the complete dialogue text after the call ends. To enable full-text quality inspection after real-time inspection, see the full-text quality inspection description in Call Center Quality Inspection - Configuration Management.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Perform real-time quality inspection for hotlines.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Real-time hotline quality inspection transcribes spoken dialogue into text during a call. It sends the text to the Smart Conversation Analysis system for real-time quality inspection to detect potential issues or risks. You can display the dialogue text and inspection results in real time on the customer service representative\&quot;s workbench (a third-party system). This differs from offline quality inspection, which uses UploadAudioData for inspection or dataset inspection. For details, see the developer guide. Offline quality inspection occurs after the call ends and the recording file is generated.
        /// <b>Usage Flow</b>
        /// You can implement real-time transcription of audio streams to text during calls, or use Alibaba Cloud Call Center (CC) directly. CC integrates deeply with Smart Conversation Analysis, enabling real-time quality inspection during calls without API integration.
        /// If you implement audio-to-text conversion yourself, invoke the SyncQualityCheck API for real-time quality inspection after a speaker finishes a sentence and generates dialogue text. This returns the inspection result for that sentence synchronously.
        /// You should include skill group information when uploading data. Then, you can use the Call Center Quality Inspection - Configuration Management feature to configure different quality inspection rules for calls from different skill groups.
        /// After the call ends, you can store the recording file on a storage server accessible over the public network. You can invoke the recording information maintenance API: UpdateSyncQualityCheckData. You can submit the recording name, recording file URL, and other details to the Smart Conversation Analysis service. This lets quality inspectors play back the recording during review.
        /// After the call ends, you can view the quality inspection results in Call Center Quality Inspection - Result Display - Real-time Quality Inspection Results. You can also invoke the real-time quality inspection result query API: GetSyncResult to retrieve the results. You can use Score Dashboard - Real-time Dashboard to view data charts for customer service representatives, skill groups, and scoring items.
        /// <b>Full-Text Quality Inspection</b>
        /// Quality inspection rules include dozens of operators. Some operators require dialogue context (multi-turn conversations between customer service representatives and customers) for analysis. However, real-time quality inspection occurs during a call and typically uses text from only one sentence spoken by a single speaker. Some operators are not suitable for real-time quality inspection. Therefore, quality inspection rules are divided into real-time quality inspection rules and full-text quality inspection rules:
        /// <b>Real-time quality inspection rules</b>: Rules used for real-time quality inspection. They support a limited number of operator types. They do not support specifying the detection range for operators.
        /// <b>Full-text quality inspection rules</b>: Rules used for offline quality inspection. They support all operator types. They support custom detection ranges for operators.
        /// For calls that underwent real-time quality inspection, you can apply full-text quality inspection rules to the complete dialogue text after the call ends. To enable full-text quality inspection after real-time inspection, see the full-text quality inspection description in Call Center Quality Inspection - Configuration Management.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Perform real-time quality inspection for hotlines.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Real-time hotline quality inspection transcribes spoken dialogue into text during a call. It sends the text to the Smart Conversation Analysis system for real-time quality inspection to detect potential issues or risks. You can display the dialogue text and inspection results in real time on the customer service representative\&quot;s workbench (a third-party system). This differs from offline quality inspection, which uses UploadAudioData for inspection or dataset inspection. For details, see the developer guide. Offline quality inspection occurs after the call ends and the recording file is generated.
        /// <b>Usage Flow</b>
        /// You can implement real-time transcription of audio streams to text during calls, or use Alibaba Cloud Call Center (CC) directly. CC integrates deeply with Smart Conversation Analysis, enabling real-time quality inspection during calls without API integration.
        /// If you implement audio-to-text conversion yourself, invoke the SyncQualityCheck API for real-time quality inspection after a speaker finishes a sentence and generates dialogue text. This returns the inspection result for that sentence synchronously.
        /// You should include skill group information when uploading data. Then, you can use the Call Center Quality Inspection - Configuration Management feature to configure different quality inspection rules for calls from different skill groups.
        /// After the call ends, you can store the recording file on a storage server accessible over the public network. You can invoke the recording information maintenance API: UpdateSyncQualityCheckData. You can submit the recording name, recording file URL, and other details to the Smart Conversation Analysis service. This lets quality inspectors play back the recording during review.
        /// After the call ends, you can view the quality inspection results in Call Center Quality Inspection - Result Display - Real-time Quality Inspection Results. You can also invoke the real-time quality inspection result query API: GetSyncResult to retrieve the results. You can use Score Dashboard - Real-time Dashboard to view data charts for customer service representatives, skill groups, and scoring items.
        /// <b>Full-Text Quality Inspection</b>
        /// Quality inspection rules include dozens of operators. Some operators require dialogue context (multi-turn conversations between customer service representatives and customers) for analysis. However, real-time quality inspection occurs during a call and typically uses text from only one sentence spoken by a single speaker. Some operators are not suitable for real-time quality inspection. Therefore, quality inspection rules are divided into real-time quality inspection rules and full-text quality inspection rules:
        /// <b>Real-time quality inspection rules</b>: Rules used for real-time quality inspection. They support a limited number of operator types. They do not support specifying the detection range for operators.
        /// <b>Full-text quality inspection rules</b>: Rules used for offline quality inspection. They support all operator types. They support custom detection ranges for operators.
        /// For calls that underwent real-time quality inspection, you can apply full-text quality inspection rules to the complete dialogue text after the call ends. To enable full-text quality inspection after real-time inspection, see the full-text quality inspection description in Call Center Quality Inspection - Configuration Management.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Perform real-time quality inspection for hotlines.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Real-time hotline quality inspection transcribes spoken dialogue into text during a call. It sends the text to the Smart Conversation Analysis system for real-time quality inspection to detect potential issues or risks. You can display the dialogue text and inspection results in real time on the customer service representative\&quot;s workbench (a third-party system). This differs from offline quality inspection, which uses UploadAudioData for inspection or dataset inspection. For details, see the developer guide. Offline quality inspection occurs after the call ends and the recording file is generated.
        /// <b>Usage Flow</b>
        /// You can implement real-time transcription of audio streams to text during calls, or use Alibaba Cloud Call Center (CC) directly. CC integrates deeply with Smart Conversation Analysis, enabling real-time quality inspection during calls without API integration.
        /// If you implement audio-to-text conversion yourself, invoke the SyncQualityCheck API for real-time quality inspection after a speaker finishes a sentence and generates dialogue text. This returns the inspection result for that sentence synchronously.
        /// You should include skill group information when uploading data. Then, you can use the Call Center Quality Inspection - Configuration Management feature to configure different quality inspection rules for calls from different skill groups.
        /// After the call ends, you can store the recording file on a storage server accessible over the public network. You can invoke the recording information maintenance API: UpdateSyncQualityCheckData. You can submit the recording name, recording file URL, and other details to the Smart Conversation Analysis service. This lets quality inspectors play back the recording during review.
        /// After the call ends, you can view the quality inspection results in Call Center Quality Inspection - Result Display - Real-time Quality Inspection Results. You can also invoke the real-time quality inspection result query API: GetSyncResult to retrieve the results. You can use Score Dashboard - Real-time Dashboard to view data charts for customer service representatives, skill groups, and scoring items.
        /// <b>Full-Text Quality Inspection</b>
        /// Quality inspection rules include dozens of operators. Some operators require dialogue context (multi-turn conversations between customer service representatives and customers) for analysis. However, real-time quality inspection occurs during a call and typically uses text from only one sentence spoken by a single speaker. Some operators are not suitable for real-time quality inspection. Therefore, quality inspection rules are divided into real-time quality inspection rules and full-text quality inspection rules:
        /// <b>Real-time quality inspection rules</b>: Rules used for real-time quality inspection. They support a limited number of operator types. They do not support specifying the detection range for operators.
        /// <b>Full-text quality inspection rules</b>: Rules used for offline quality inspection. They support all operator types. They support custom detection ranges for operators.
        /// For calls that underwent real-time quality inspection, you can apply full-text quality inspection rules to the complete dialogue text after the call ends. To enable full-text quality inspection after real-time inspection, see the full-text quality inspection description in Call Center Quality Inspection - Configuration Management.</para>
        /// </description>
        /// 
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
        /// <para>Frontend location: Quality Check Rule Configuration &gt; Test. Apsara Stack URL: http://<ip>:<port>/api/client/TestRule.json.</para>
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
        /// <para>Frontend location: Quality Check Rule Configuration &gt; Test. Apsara Stack URL: http://<ip>:<port>/api/client/TestRule.json.</para>
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
        /// <para>Frontend location: Quality Check Rule Configuration &gt; Test. Apsara Stack URL: http://<ip>:<port>/api/client/TestRule.json.</para>
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
        /// <para>Frontend location: Quality Check Rule Configuration &gt; Test. Apsara Stack URL: http://<ip>:<port>/api/client/TestRule.json.</para>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public UpdateAgentResponse UpdateAgentWithOptions(UpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateAgent",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public async Task<UpdateAgentResponse> UpdateAgentWithOptionsAsync(UpdateAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateAgent",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public UpdateAgentResponse UpdateAgent(UpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgentResponse
        /// </returns>
        public async Task<UpdateAgentResponse> UpdateAgentAsync(UpdateAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the hotword vocabulary.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the hotword vocabulary.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the hotword vocabulary.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the hotword vocabulary.</para>
        /// </summary>
        /// 
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
        /// <para>You can access this operation from the frontend by navigating to Plan Management &gt; Create Quality Inspection Task or Edit &gt; Edit icon next to the quality inspection dimension name. The Apsara Stack endpoint is ip:port/api/qcs/UpdateCheckTypeToScheme.json.</para>
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
        /// <para>You can access this operation from the frontend by navigating to Plan Management &gt; Create Quality Inspection Task or Edit &gt; Edit icon next to the quality inspection dimension name. The Apsara Stack endpoint is ip:port/api/qcs/UpdateCheckTypeToScheme.json.</para>
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
        /// <para>You can access this operation from the frontend by navigating to Plan Management &gt; Create Quality Inspection Task or Edit &gt; Edit icon next to the quality inspection dimension name. The Apsara Stack endpoint is ip:port/api/qcs/UpdateCheckTypeToScheme.json.</para>
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
        /// <para>You can access this operation from the frontend by navigating to Plan Management &gt; Create Quality Inspection Task or Edit &gt; Edit icon next to the quality inspection dimension name. The Apsara Stack endpoint is ip:port/api/qcs/UpdateCheckTypeToScheme.json.</para>
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
        /// <para>Update session recording data (third-party business fields) to facilitate statistics and queries across more business dimensions.</para>
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
        /// <para>Update session recording data (third-party business fields) to facilitate statistics and queries across more business dimensions.</para>
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
        /// <para>Update session recording data (third-party business fields) to facilitate statistics and queries across more business dimensions.</para>
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
        /// <para>Update session recording data (third-party business fields) to facilitate statistics and queries across more business dimensions.</para>
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
        /// <para>Updates a quality check scheme.</para>
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
        /// <para>Updates a quality check scheme.</para>
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
        /// <para>Updates a quality check scheme.</para>
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
        /// <para>Updates a quality check scheme.</para>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update rule information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Update an existing rule. You can modify its conditions and operators as needed. The rule ID (rid) remains unchanged, but condition IDs and operator IDs may change.</para>
        /// </remarks>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update rule information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Update an existing rule. You can modify its conditions and operators as needed. The rule ID (rid) remains unchanged, but condition IDs and operator IDs may change.</para>
        /// </remarks>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update rule information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Update an existing rule. You can modify its conditions and operators as needed. The rule ID (rid) remains unchanged, but condition IDs and operator IDs may change.</para>
        /// </remarks>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update rule information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Update an existing rule. You can modify its conditions and operators as needed. The rule ID (rid) remains unchanged, but condition IDs and operator IDs may change.</para>
        /// </remarks>
        /// </description>
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
        /// <para>This API maps to the frontend function location: Quality Inspection Rule Configuration - Create &amp; Update. The Apsara Stack URL is: ip:port/api/client/UpdateRuleById.json.</para>
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
        /// <para>This API maps to the frontend function location: Quality Inspection Rule Configuration - Create &amp; Update. The Apsara Stack URL is: ip:port/api/client/UpdateRuleById.json.</para>
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
        /// <para>This API maps to the frontend function location: Quality Inspection Rule Configuration - Create &amp; Update. The Apsara Stack URL is: ip:port/api/client/UpdateRuleById.json.</para>
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
        /// <para>This API maps to the frontend function location: Quality Inspection Rule Configuration - Create &amp; Update. The Apsara Stack URL is: ip:port/api/client/UpdateRuleById.json.</para>
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
        /// <para>Frontend location: Quality Check Plan Management &gt; Create or edit a quality check task &gt; Associate quality check rules. Apsara Stack URL: ip:port/api/qcs/UpdateRuleToScheme.json.</para>
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
        /// <para>Frontend location: Quality Check Plan Management &gt; Create or edit a quality check task &gt; Associate quality check rules. Apsara Stack URL: ip:port/api/qcs/UpdateRuleToScheme.json.</para>
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
        /// <para>Frontend location: Quality Check Plan Management &gt; Create or edit a quality check task &gt; Associate quality check rules. Apsara Stack URL: ip:port/api/qcs/UpdateRuleToScheme.json.</para>
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
        /// <para>Frontend location: Quality Check Plan Management &gt; Create or edit a quality check task &gt; Associate quality check rules. Apsara Stack URL: ip:port/api/qcs/UpdateRuleToScheme.json.</para>
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
        /// <para>Corresponding frontend feature location: Rule Configuration - Update. Apsara Stack URL: ip:port/api/client/UpdateRuleById.json.</para>
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
        /// <para>Corresponding frontend feature location: Rule Configuration - Update. Apsara Stack URL: ip:port/api/client/UpdateRuleById.json.</para>
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
        /// <para>Corresponding frontend feature location: Rule Configuration - Update. Apsara Stack URL: ip:port/api/client/UpdateRuleById.json.</para>
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
        /// <para>Corresponding frontend feature location: Rule Configuration - Update. Apsara Stack URL: ip:port/api/client/UpdateRuleById.json.</para>
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
        /// <para>Frontend path: Task Management &gt; Edit any data on the right. Apsara Stack URL: ip:port/api/task/UpdateSchemeTaskConfig.json.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates quality inspection task information.</para>
        /// </description>
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
        /// <para>Frontend path: Task Management &gt; Edit any data on the right. Apsara Stack URL: ip:port/api/task/UpdateSchemeTaskConfig.json.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates quality inspection task information.</para>
        /// </description>
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
        /// <para>Frontend path: Task Management &gt; Edit any data on the right. Apsara Stack URL: ip:port/api/task/UpdateSchemeTaskConfig.json.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates quality inspection task information.</para>
        /// </description>
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
        /// <para>Frontend path: Task Management &gt; Edit any data on the right. Apsara Stack URL: ip:port/api/task/UpdateSchemeTaskConfig.json.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates quality inspection task information.</para>
        /// </description>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call UpdateSkillGroupConfig to update a configuration.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call UpdateSkillGroupConfig to update a configuration.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call UpdateSkillGroupConfig to update a configuration.</para>
        /// </summary>
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
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call UpdateSkillGroupConfig to update a configuration.</para>
        /// </summary>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Maintain the recording information after real-time quality inspection is completed, which is used to play back the recording during review. After the recording information is maintained, the task status will change to Succeeded.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Maintain the recording information after real-time quality inspection is completed, which is used to play back the recording during review. After the recording information is maintained, the task status will change to Succeeded.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Maintain the recording information after real-time quality inspection is completed, which is used to play back the recording during review. After the recording information is maintained, the task status will change to Succeeded.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Maintain the recording information after real-time quality inspection is completed, which is used to play back the recording during review. After the recording information is maintained, the task status will change to Succeeded.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTagResponse
        /// </returns>
        public UpdateTagResponse UpdateTagWithOptions(UpdateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateTag",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTagResponse
        /// </returns>
        public async Task<UpdateTagResponse> UpdateTagWithOptionsAsync(UpdateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateTag",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTagRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTagResponse
        /// </returns>
        public UpdateTagResponse UpdateTag(UpdateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a label node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTagRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTagResponse
        /// </returns>
        public async Task<UpdateTagResponse> UpdateTagAsync(UpdateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the automatic allocation rule for quality review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the automatic allocation rule for quality review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the automatic allocation rule for quality review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the automatic allocation rule for quality review tasks.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update users by modifying their roles in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you update users, you can modify only their roles. You cannot modify other account information because all Alibaba Cloud products use a unified account management system. Smart Conversation Analysis uses these accounts. To modify account information, go to <a href="https://ram.console.aliyun.com/">Resource Access Management (RAM)</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update users by modifying their roles in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you update users, you can modify only their roles. You cannot modify other account information because all Alibaba Cloud products use a unified account management system. Smart Conversation Analysis uses these accounts. To modify account information, go to <a href="https://ram.console.aliyun.com/">Resource Access Management (RAM)</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update users by modifying their roles in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you update users, you can modify only their roles. You cannot modify other account information because all Alibaba Cloud products use a unified account management system. Smart Conversation Analysis uses these accounts. To modify account information, go to <a href="https://ram.console.aliyun.com/">Resource Access Management (RAM)</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update users by modifying their roles in batches.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you update users, you can modify only their roles. You cannot modify other account information because all Alibaba Cloud products use a unified account management system. Smart Conversation Analysis uses these accounts. To modify account information, go to <a href="https://ram.console.aliyun.com/">Resource Access Management (RAM)</a>.</para>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the warning configuration.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the warning configuration.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the warning configuration.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the warning configuration.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads offline audio data—such as recorded call session files—for quality inspection. This operation supports two call center agent scenarios.
        /// Scenario 1: Native integration with Alibaba Cloud Call Center (CC). No development is required. You can push call data to Smart Conversation Analysis (SCA) with a single click.
        /// Scenario 2: Integration with your own call center system. Each time a recording is generated, the call center pushes it to SCA for analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Process description</h3>
        /// <para>The process is as follows: An API call uploads the audio file for quality inspection → The audio file is converted to text → The transcribed text is separated by speaker role (agent and customer), based on the specified channel separation method → The role-separated text is analyzed using quality inspection rules → Quality inspection completes.</para>
        /// <h3>Task execution efficiency</h3>
        /// <para>Task execution speed depends on how quickly the audio file is transcribed. A 5-minute audio file is typically transcribed in about 2 minutes. However, if the transcription service queue is long, a waiting period occurs. Transcription usually completes within 6 hours, except when large volumes of data are uploaded simultaneously—more than 500 hours of audio within 30 minutes. After transcription, quality inspection analysis completes in milliseconds.</para>
        /// <h3>Audio file URL requirements</h3>
        /// <list type="bullet">
        /// <item><description>Supports single-channel or dual-channel audio files in WAV or MP3 format. File size must be less than 512 MB.</description></item>
        /// <item><description>The URL must be accessible over HTTP. Local files are not supported. The audio file must have public access permissions.</description></item>
        /// <item><description>The URL must use a domain name, not an IP address. The URL cannot contain spaces or Chinese characters.</description></item>
        /// <item><description>After transcription, the system deletes the downloaded audio file. No copy of the recording is retained.</description></item>
        /// <item><description>If your audio URL has an expiration period—such as a presigned URL for an audio file stored in Alibaba Cloud Object Storage Service (OSS)—set the validity period to at least 12 hours. Ideally, set it to 24 hours. Because transcription may involve queuing, the audio file is downloaded only when transcription begins. A longer validity period prevents the URL from expiring before download starts.</description></item>
        /// <item><description>After quality inspection completes, the provided URL is used for playback when you review the file in the console. Ensure the URL remains valid long-term. Otherwise, audio playback fails.</description></item>
        /// </list>
        /// <h3>Role separation</h3>
        /// <para>After transcription, the system automatically separates the text into two speaker roles but cannot determine which role corresponds to the agent and which to the customer. You must define rules for role separation. Role separation accuracy is critical because many quality inspection rules apply to a specific role—for example, checking only agent or only customer utterances. Incorrect role separation significantly reduces quality inspection accuracy.
        /// Audio files are typically either single-channel (mono) or dual-channel (stereo):</para>
        /// <list type="bullet">
        /// <item><description>Single-channel recording: The voices of the agent and customer are mixed on one channel. After transcription, the system uses a built-in algorithm to separate dialogue into two roles. You can provide a list of keywords commonly spoken by agents. The system analyzes the transcribed text sentence by sentence. When a sentence contains a keyword, that speaker is identified as the agent, and the other speaker is identified as the customer. For more information, see the recognizeRoleDataSetId and serviceChannelKeywords request parameters. Because conversations can be unpredictable—for example, speakers may talk over each other—role separation for single-channel recordings cannot achieve 100% accuracy. We strongly recommend saving recordings as dual-channel audio.</description></item>
        /// <item><description>Dual-channel recording: The voices of the agent and customer are stored on separate channels. Even if speakers talk over each other, transcription accurately distinguishes between them. Specify the agent and customer channels using the serviceChannel and clientChannel request parameters.</description></item>
        /// </list>
        /// <h3>Retrieve quality inspection results</h3>
        /// <para>Because audio analysis is asynchronous, you must retrieve results asynchronously. You can retrieve results in one of the following three ways:</para>
        /// <list type="bullet">
        /// <item><description>Message notification: For more information, see <a href="https://help.aliyun.com/document_detail/213237.html">Message Queue</a>. After you receive a message, call the GetResult operation to retrieve detailed results. (Recommended)</description></item>
        /// <item><description>Callback: Specify a callbackUrl in the request parameters. The system initiates a callback after the task completes. After you receive the callback, call the GetResult operation to retrieve detailed results.</description></item>
        /// <item><description>Polling: The operation returns a task ID (taskId). Use the taskId to poll the getResult operation and retrieve the result asynchronously. Check the <c>status</c> parameter in the response to determine whether the task is complete. We recommend a polling interval of 30 seconds or longer because analysis typically completes within a few minutes. (Not recommended)</description></item>
        /// </list>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads offline audio data—such as recorded call session files—for quality inspection. This operation supports two call center agent scenarios.
        /// Scenario 1: Native integration with Alibaba Cloud Call Center (CC). No development is required. You can push call data to Smart Conversation Analysis (SCA) with a single click.
        /// Scenario 2: Integration with your own call center system. Each time a recording is generated, the call center pushes it to SCA for analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Process description</h3>
        /// <para>The process is as follows: An API call uploads the audio file for quality inspection → The audio file is converted to text → The transcribed text is separated by speaker role (agent and customer), based on the specified channel separation method → The role-separated text is analyzed using quality inspection rules → Quality inspection completes.</para>
        /// <h3>Task execution efficiency</h3>
        /// <para>Task execution speed depends on how quickly the audio file is transcribed. A 5-minute audio file is typically transcribed in about 2 minutes. However, if the transcription service queue is long, a waiting period occurs. Transcription usually completes within 6 hours, except when large volumes of data are uploaded simultaneously—more than 500 hours of audio within 30 minutes. After transcription, quality inspection analysis completes in milliseconds.</para>
        /// <h3>Audio file URL requirements</h3>
        /// <list type="bullet">
        /// <item><description>Supports single-channel or dual-channel audio files in WAV or MP3 format. File size must be less than 512 MB.</description></item>
        /// <item><description>The URL must be accessible over HTTP. Local files are not supported. The audio file must have public access permissions.</description></item>
        /// <item><description>The URL must use a domain name, not an IP address. The URL cannot contain spaces or Chinese characters.</description></item>
        /// <item><description>After transcription, the system deletes the downloaded audio file. No copy of the recording is retained.</description></item>
        /// <item><description>If your audio URL has an expiration period—such as a presigned URL for an audio file stored in Alibaba Cloud Object Storage Service (OSS)—set the validity period to at least 12 hours. Ideally, set it to 24 hours. Because transcription may involve queuing, the audio file is downloaded only when transcription begins. A longer validity period prevents the URL from expiring before download starts.</description></item>
        /// <item><description>After quality inspection completes, the provided URL is used for playback when you review the file in the console. Ensure the URL remains valid long-term. Otherwise, audio playback fails.</description></item>
        /// </list>
        /// <h3>Role separation</h3>
        /// <para>After transcription, the system automatically separates the text into two speaker roles but cannot determine which role corresponds to the agent and which to the customer. You must define rules for role separation. Role separation accuracy is critical because many quality inspection rules apply to a specific role—for example, checking only agent or only customer utterances. Incorrect role separation significantly reduces quality inspection accuracy.
        /// Audio files are typically either single-channel (mono) or dual-channel (stereo):</para>
        /// <list type="bullet">
        /// <item><description>Single-channel recording: The voices of the agent and customer are mixed on one channel. After transcription, the system uses a built-in algorithm to separate dialogue into two roles. You can provide a list of keywords commonly spoken by agents. The system analyzes the transcribed text sentence by sentence. When a sentence contains a keyword, that speaker is identified as the agent, and the other speaker is identified as the customer. For more information, see the recognizeRoleDataSetId and serviceChannelKeywords request parameters. Because conversations can be unpredictable—for example, speakers may talk over each other—role separation for single-channel recordings cannot achieve 100% accuracy. We strongly recommend saving recordings as dual-channel audio.</description></item>
        /// <item><description>Dual-channel recording: The voices of the agent and customer are stored on separate channels. Even if speakers talk over each other, transcription accurately distinguishes between them. Specify the agent and customer channels using the serviceChannel and clientChannel request parameters.</description></item>
        /// </list>
        /// <h3>Retrieve quality inspection results</h3>
        /// <para>Because audio analysis is asynchronous, you must retrieve results asynchronously. You can retrieve results in one of the following three ways:</para>
        /// <list type="bullet">
        /// <item><description>Message notification: For more information, see <a href="https://help.aliyun.com/document_detail/213237.html">Message Queue</a>. After you receive a message, call the GetResult operation to retrieve detailed results. (Recommended)</description></item>
        /// <item><description>Callback: Specify a callbackUrl in the request parameters. The system initiates a callback after the task completes. After you receive the callback, call the GetResult operation to retrieve detailed results.</description></item>
        /// <item><description>Polling: The operation returns a task ID (taskId). Use the taskId to poll the getResult operation and retrieve the result asynchronously. Check the <c>status</c> parameter in the response to determine whether the task is complete. We recommend a polling interval of 30 seconds or longer because analysis typically completes within a few minutes. (Not recommended)</description></item>
        /// </list>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads offline audio data—such as recorded call session files—for quality inspection. This operation supports two call center agent scenarios.
        /// Scenario 1: Native integration with Alibaba Cloud Call Center (CC). No development is required. You can push call data to Smart Conversation Analysis (SCA) with a single click.
        /// Scenario 2: Integration with your own call center system. Each time a recording is generated, the call center pushes it to SCA for analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Process description</h3>
        /// <para>The process is as follows: An API call uploads the audio file for quality inspection → The audio file is converted to text → The transcribed text is separated by speaker role (agent and customer), based on the specified channel separation method → The role-separated text is analyzed using quality inspection rules → Quality inspection completes.</para>
        /// <h3>Task execution efficiency</h3>
        /// <para>Task execution speed depends on how quickly the audio file is transcribed. A 5-minute audio file is typically transcribed in about 2 minutes. However, if the transcription service queue is long, a waiting period occurs. Transcription usually completes within 6 hours, except when large volumes of data are uploaded simultaneously—more than 500 hours of audio within 30 minutes. After transcription, quality inspection analysis completes in milliseconds.</para>
        /// <h3>Audio file URL requirements</h3>
        /// <list type="bullet">
        /// <item><description>Supports single-channel or dual-channel audio files in WAV or MP3 format. File size must be less than 512 MB.</description></item>
        /// <item><description>The URL must be accessible over HTTP. Local files are not supported. The audio file must have public access permissions.</description></item>
        /// <item><description>The URL must use a domain name, not an IP address. The URL cannot contain spaces or Chinese characters.</description></item>
        /// <item><description>After transcription, the system deletes the downloaded audio file. No copy of the recording is retained.</description></item>
        /// <item><description>If your audio URL has an expiration period—such as a presigned URL for an audio file stored in Alibaba Cloud Object Storage Service (OSS)—set the validity period to at least 12 hours. Ideally, set it to 24 hours. Because transcription may involve queuing, the audio file is downloaded only when transcription begins. A longer validity period prevents the URL from expiring before download starts.</description></item>
        /// <item><description>After quality inspection completes, the provided URL is used for playback when you review the file in the console. Ensure the URL remains valid long-term. Otherwise, audio playback fails.</description></item>
        /// </list>
        /// <h3>Role separation</h3>
        /// <para>After transcription, the system automatically separates the text into two speaker roles but cannot determine which role corresponds to the agent and which to the customer. You must define rules for role separation. Role separation accuracy is critical because many quality inspection rules apply to a specific role—for example, checking only agent or only customer utterances. Incorrect role separation significantly reduces quality inspection accuracy.
        /// Audio files are typically either single-channel (mono) or dual-channel (stereo):</para>
        /// <list type="bullet">
        /// <item><description>Single-channel recording: The voices of the agent and customer are mixed on one channel. After transcription, the system uses a built-in algorithm to separate dialogue into two roles. You can provide a list of keywords commonly spoken by agents. The system analyzes the transcribed text sentence by sentence. When a sentence contains a keyword, that speaker is identified as the agent, and the other speaker is identified as the customer. For more information, see the recognizeRoleDataSetId and serviceChannelKeywords request parameters. Because conversations can be unpredictable—for example, speakers may talk over each other—role separation for single-channel recordings cannot achieve 100% accuracy. We strongly recommend saving recordings as dual-channel audio.</description></item>
        /// <item><description>Dual-channel recording: The voices of the agent and customer are stored on separate channels. Even if speakers talk over each other, transcription accurately distinguishes between them. Specify the agent and customer channels using the serviceChannel and clientChannel request parameters.</description></item>
        /// </list>
        /// <h3>Retrieve quality inspection results</h3>
        /// <para>Because audio analysis is asynchronous, you must retrieve results asynchronously. You can retrieve results in one of the following three ways:</para>
        /// <list type="bullet">
        /// <item><description>Message notification: For more information, see <a href="https://help.aliyun.com/document_detail/213237.html">Message Queue</a>. After you receive a message, call the GetResult operation to retrieve detailed results. (Recommended)</description></item>
        /// <item><description>Callback: Specify a callbackUrl in the request parameters. The system initiates a callback after the task completes. After you receive the callback, call the GetResult operation to retrieve detailed results.</description></item>
        /// <item><description>Polling: The operation returns a task ID (taskId). Use the taskId to poll the getResult operation and retrieve the result asynchronously. Check the <c>status</c> parameter in the response to determine whether the task is complete. We recommend a polling interval of 30 seconds or longer because analysis typically completes within a few minutes. (Not recommended)</description></item>
        /// </list>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uploads offline audio data—such as recorded call session files—for quality inspection. This operation supports two call center agent scenarios.
        /// Scenario 1: Native integration with Alibaba Cloud Call Center (CC). No development is required. You can push call data to Smart Conversation Analysis (SCA) with a single click.
        /// Scenario 2: Integration with your own call center system. Each time a recording is generated, the call center pushes it to SCA for analysis.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Process description</h3>
        /// <para>The process is as follows: An API call uploads the audio file for quality inspection → The audio file is converted to text → The transcribed text is separated by speaker role (agent and customer), based on the specified channel separation method → The role-separated text is analyzed using quality inspection rules → Quality inspection completes.</para>
        /// <h3>Task execution efficiency</h3>
        /// <para>Task execution speed depends on how quickly the audio file is transcribed. A 5-minute audio file is typically transcribed in about 2 minutes. However, if the transcription service queue is long, a waiting period occurs. Transcription usually completes within 6 hours, except when large volumes of data are uploaded simultaneously—more than 500 hours of audio within 30 minutes. After transcription, quality inspection analysis completes in milliseconds.</para>
        /// <h3>Audio file URL requirements</h3>
        /// <list type="bullet">
        /// <item><description>Supports single-channel or dual-channel audio files in WAV or MP3 format. File size must be less than 512 MB.</description></item>
        /// <item><description>The URL must be accessible over HTTP. Local files are not supported. The audio file must have public access permissions.</description></item>
        /// <item><description>The URL must use a domain name, not an IP address. The URL cannot contain spaces or Chinese characters.</description></item>
        /// <item><description>After transcription, the system deletes the downloaded audio file. No copy of the recording is retained.</description></item>
        /// <item><description>If your audio URL has an expiration period—such as a presigned URL for an audio file stored in Alibaba Cloud Object Storage Service (OSS)—set the validity period to at least 12 hours. Ideally, set it to 24 hours. Because transcription may involve queuing, the audio file is downloaded only when transcription begins. A longer validity period prevents the URL from expiring before download starts.</description></item>
        /// <item><description>After quality inspection completes, the provided URL is used for playback when you review the file in the console. Ensure the URL remains valid long-term. Otherwise, audio playback fails.</description></item>
        /// </list>
        /// <h3>Role separation</h3>
        /// <para>After transcription, the system automatically separates the text into two speaker roles but cannot determine which role corresponds to the agent and which to the customer. You must define rules for role separation. Role separation accuracy is critical because many quality inspection rules apply to a specific role—for example, checking only agent or only customer utterances. Incorrect role separation significantly reduces quality inspection accuracy.
        /// Audio files are typically either single-channel (mono) or dual-channel (stereo):</para>
        /// <list type="bullet">
        /// <item><description>Single-channel recording: The voices of the agent and customer are mixed on one channel. After transcription, the system uses a built-in algorithm to separate dialogue into two roles. You can provide a list of keywords commonly spoken by agents. The system analyzes the transcribed text sentence by sentence. When a sentence contains a keyword, that speaker is identified as the agent, and the other speaker is identified as the customer. For more information, see the recognizeRoleDataSetId and serviceChannelKeywords request parameters. Because conversations can be unpredictable—for example, speakers may talk over each other—role separation for single-channel recordings cannot achieve 100% accuracy. We strongly recommend saving recordings as dual-channel audio.</description></item>
        /// <item><description>Dual-channel recording: The voices of the agent and customer are stored on separate channels. Even if speakers talk over each other, transcription accurately distinguishes between them. Specify the agent and customer channels using the serviceChannel and clientChannel request parameters.</description></item>
        /// </list>
        /// <h3>Retrieve quality inspection results</h3>
        /// <para>Because audio analysis is asynchronous, you must retrieve results asynchronously. You can retrieve results in one of the following three ways:</para>
        /// <list type="bullet">
        /// <item><description>Message notification: For more information, see <a href="https://help.aliyun.com/document_detail/213237.html">Message Queue</a>. After you receive a message, call the GetResult operation to retrieve detailed results. (Recommended)</description></item>
        /// <item><description>Callback: Specify a callbackUrl in the request parameters. The system initiates a callback after the task completes. After you receive the callback, call the GetResult operation to retrieve detailed results.</description></item>
        /// <item><description>Polling: The operation returns a task ID (taskId). Use the taskId to poll the getResult operation and retrieve the result asynchronously. Check the <c>status</c> parameter in the response to determine whether the task is complete. We recommend a polling interval of 30 seconds or longer because analysis typically completes within a few minutes. (Not recommended)</description></item>
        /// </list>
        /// </description>
        /// 
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
        /// <para>Upload offline plain text quality inspection data (plain text sessions). This applies to online agent scenarios. Use the UploadDataV4 API. Differences between UploadDataV4 and UploadData include the following: UploadDataV4 supports only POST requests, and it supports longer JsonStr values.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call UploadData.json to upload text-based quality inspection data. Text typically originates from online customer service interactions or tickets. The API returns a task ID. You can retrieve results in one of three ways:</para>
        /// <list type="bullet">
        /// <item><description>Message notification: For details, see <a href="https://help.aliyun.com/document_detail/213237.html">message queues</a>. After you receive a message, call the GetResult API to retrieve detailed results. (Recommended)</description></item>
        /// <item><description>Callback: Specify a callback URL in your request parameters. After the task completes, the system sends a callback to that URL. Then call the GetResult API to retrieve detailed results.</description></item>
        /// <item><description>Polling: Use the returned task ID to poll the GetResult API asynchronously. Check whether the status field in the response indicates completion. (Not recommended)</description></item>
        /// </list>
        /// </description>
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
        /// <para>Upload offline plain text quality inspection data (plain text sessions). This applies to online agent scenarios. Use the UploadDataV4 API. Differences between UploadDataV4 and UploadData include the following: UploadDataV4 supports only POST requests, and it supports longer JsonStr values.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call UploadData.json to upload text-based quality inspection data. Text typically originates from online customer service interactions or tickets. The API returns a task ID. You can retrieve results in one of three ways:</para>
        /// <list type="bullet">
        /// <item><description>Message notification: For details, see <a href="https://help.aliyun.com/document_detail/213237.html">message queues</a>. After you receive a message, call the GetResult API to retrieve detailed results. (Recommended)</description></item>
        /// <item><description>Callback: Specify a callback URL in your request parameters. After the task completes, the system sends a callback to that URL. Then call the GetResult API to retrieve detailed results.</description></item>
        /// <item><description>Polling: Use the returned task ID to poll the GetResult API asynchronously. Check whether the status field in the response indicates completion. (Not recommended)</description></item>
        /// </list>
        /// </description>
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
        /// <para>Upload offline plain text quality inspection data (plain text sessions). This applies to online agent scenarios. Use the UploadDataV4 API. Differences between UploadDataV4 and UploadData include the following: UploadDataV4 supports only POST requests, and it supports longer JsonStr values.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call UploadData.json to upload text-based quality inspection data. Text typically originates from online customer service interactions or tickets. The API returns a task ID. You can retrieve results in one of three ways:</para>
        /// <list type="bullet">
        /// <item><description>Message notification: For details, see <a href="https://help.aliyun.com/document_detail/213237.html">message queues</a>. After you receive a message, call the GetResult API to retrieve detailed results. (Recommended)</description></item>
        /// <item><description>Callback: Specify a callback URL in your request parameters. After the task completes, the system sends a callback to that URL. Then call the GetResult API to retrieve detailed results.</description></item>
        /// <item><description>Polling: Use the returned task ID to poll the GetResult API asynchronously. Check whether the status field in the response indicates completion. (Not recommended)</description></item>
        /// </list>
        /// </description>
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
        /// <para>Upload offline plain text quality inspection data (plain text sessions). This applies to online agent scenarios. Use the UploadDataV4 API. Differences between UploadDataV4 and UploadData include the following: UploadDataV4 supports only POST requests, and it supports longer JsonStr values.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call UploadData.json to upload text-based quality inspection data. Text typically originates from online customer service interactions or tickets. The API returns a task ID. You can retrieve results in one of three ways:</para>
        /// <list type="bullet">
        /// <item><description>Message notification: For details, see <a href="https://help.aliyun.com/document_detail/213237.html">message queues</a>. After you receive a message, call the GetResult API to retrieve detailed results. (Recommended)</description></item>
        /// <item><description>Callback: Specify a callback URL in your request parameters. After the task completes, the system sends a callback to that URL. Then call the GetResult API to retrieve detailed results.</description></item>
        /// <item><description>Polling: Use the returned task ID to poll the GetResult API asynchronously. Check whether the status field in the response indicates completion. (Not recommended)</description></item>
        /// </list>
        /// </description>
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
        /// <para>Real-time text quality check</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API pushes text data to SCA for real-time quality inspection based on specified rules and synchronously returns the analysis results. Unlike post-call quality inspection, which requires uploading the full transcript after a dialogue ends, real-time quality inspection offers lower latency by analyzing text immediately after a speaker completes one or more utterances.</para>
        /// <list type="bullet">
        /// <item><description>If you push a single utterance from one speaker, some rule operators may fail because the required dialogue context is missing. Examples include the context repetition check, speech interruption check, and call mute check.</description></item>
        /// <item><description>SCA returns analysis results synchronously and does not save call records, so you cannot query the results later via an API.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Real-time text quality check</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API pushes text data to SCA for real-time quality inspection based on specified rules and synchronously returns the analysis results. Unlike post-call quality inspection, which requires uploading the full transcript after a dialogue ends, real-time quality inspection offers lower latency by analyzing text immediately after a speaker completes one or more utterances.</para>
        /// <list type="bullet">
        /// <item><description>If you push a single utterance from one speaker, some rule operators may fail because the required dialogue context is missing. Examples include the context repetition check, speech interruption check, and call mute check.</description></item>
        /// <item><description>SCA returns analysis results synchronously and does not save call records, so you cannot query the results later via an API.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Real-time text quality check</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API pushes text data to SCA for real-time quality inspection based on specified rules and synchronously returns the analysis results. Unlike post-call quality inspection, which requires uploading the full transcript after a dialogue ends, real-time quality inspection offers lower latency by analyzing text immediately after a speaker completes one or more utterances.</para>
        /// <list type="bullet">
        /// <item><description>If you push a single utterance from one speaker, some rule operators may fail because the required dialogue context is missing. Examples include the context repetition check, speech interruption check, and call mute check.</description></item>
        /// <item><description>SCA returns analysis results synchronously and does not save call records, so you cannot query the results later via an API.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Real-time text quality check</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API pushes text data to SCA for real-time quality inspection based on specified rules and synchronously returns the analysis results. Unlike post-call quality inspection, which requires uploading the full transcript after a dialogue ends, real-time quality inspection offers lower latency by analyzing text immediately after a speaker completes one or more utterances.</para>
        /// <list type="bullet">
        /// <item><description>If you push a single utterance from one speaker, some rule operators may fail because the required dialogue context is missing. Examples include the context repetition check, speech interruption check, and call mute check.</description></item>
        /// <item><description>SCA returns analysis results synchronously and does not save call records, so you cannot query the results later via an API.</description></item>
        /// </list>
        /// </description>
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                body["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                body["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
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
        /// <para>Uploads offline plain text conversation data for quality inspection in online agent scenarios. We recommend that you use the UploadDataV4 API. Compared to the UploadData API, UploadDataV4 supports only POST requests and allows a longer JsonStr.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UploadData.json operation to upload text data for quality inspection. The text usually comes from sources such as online customer service and tickets. The API returns a task ID. You can retrieve the results in one of the following three ways:</para>
        /// <list type="bullet">
        /// <item><description>Message notifications: After you receive a notification, call the GetResult API to obtain the detailed results. For more information, see <a href="https://help.aliyun.com/document_detail/213237.html">Message Queue</a>. (Recommended)</description></item>
        /// <item><description>Callbacks: Specify a callbackUrl in the request parameters. The system automatically initiates a callback after the task is complete. After you receive the callback, call the GetResult API to retrieve the detailed results.</description></item>
        /// <item><description>Polling: Use the task ID returned by this API to poll the GetResult API and asynchronously retrieve the results. Check the status in the response to determine whether the task is complete. (Not recommended)</description></item>
        /// </list>
        /// </description>
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
        /// <para>Uploads offline plain text conversation data for quality inspection in online agent scenarios. We recommend that you use the UploadDataV4 API. Compared to the UploadData API, UploadDataV4 supports only POST requests and allows a longer JsonStr.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UploadData.json operation to upload text data for quality inspection. The text usually comes from sources such as online customer service and tickets. The API returns a task ID. You can retrieve the results in one of the following three ways:</para>
        /// <list type="bullet">
        /// <item><description>Message notifications: After you receive a notification, call the GetResult API to obtain the detailed results. For more information, see <a href="https://help.aliyun.com/document_detail/213237.html">Message Queue</a>. (Recommended)</description></item>
        /// <item><description>Callbacks: Specify a callbackUrl in the request parameters. The system automatically initiates a callback after the task is complete. After you receive the callback, call the GetResult API to retrieve the detailed results.</description></item>
        /// <item><description>Polling: Use the task ID returned by this API to poll the GetResult API and asynchronously retrieve the results. Check the status in the response to determine whether the task is complete. (Not recommended)</description></item>
        /// </list>
        /// </description>
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
        /// <para>Uploads offline plain text conversation data for quality inspection in online agent scenarios. We recommend that you use the UploadDataV4 API. Compared to the UploadData API, UploadDataV4 supports only POST requests and allows a longer JsonStr.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UploadData.json operation to upload text data for quality inspection. The text usually comes from sources such as online customer service and tickets. The API returns a task ID. You can retrieve the results in one of the following three ways:</para>
        /// <list type="bullet">
        /// <item><description>Message notifications: After you receive a notification, call the GetResult API to obtain the detailed results. For more information, see <a href="https://help.aliyun.com/document_detail/213237.html">Message Queue</a>. (Recommended)</description></item>
        /// <item><description>Callbacks: Specify a callbackUrl in the request parameters. The system automatically initiates a callback after the task is complete. After you receive the callback, call the GetResult API to retrieve the detailed results.</description></item>
        /// <item><description>Polling: Use the task ID returned by this API to poll the GetResult API and asynchronously retrieve the results. Check the status in the response to determine whether the task is complete. (Not recommended)</description></item>
        /// </list>
        /// </description>
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
        /// <para>Uploads offline plain text conversation data for quality inspection in online agent scenarios. We recommend that you use the UploadDataV4 API. Compared to the UploadData API, UploadDataV4 supports only POST requests and allows a longer JsonStr.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UploadData.json operation to upload text data for quality inspection. The text usually comes from sources such as online customer service and tickets. The API returns a task ID. You can retrieve the results in one of the following three ways:</para>
        /// <list type="bullet">
        /// <item><description>Message notifications: After you receive a notification, call the GetResult API to obtain the detailed results. For more information, see <a href="https://help.aliyun.com/document_detail/213237.html">Message Queue</a>. (Recommended)</description></item>
        /// <item><description>Callbacks: Specify a callbackUrl in the request parameters. The system automatically initiates a callback after the task is complete. After you receive the callback, call the GetResult API to retrieve the detailed results.</description></item>
        /// <item><description>Polling: Use the task ID returned by this API to poll the GetResult API and asynchronously retrieve the results. Check the status in the response to determine whether the task is complete. (Not recommended)</description></item>
        /// </list>
        /// </description>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a rule. You can use this operation to provide your own rule editing interface.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/213225.html">Rule configuration</a>.</para>
        /// </remarks>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a rule. You can use this operation to provide your own rule editing interface.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/213225.html">Rule configuration</a>.</para>
        /// </remarks>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a rule. You can use this operation to provide your own rule editing interface.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/213225.html">Rule configuration</a>.</para>
        /// </remarks>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a rule. You can use this operation to provide your own rule editing interface.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/213225.html">Rule configuration</a>.</para>
        /// </remarks>
        /// </description>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves the verification result of a single file.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves the verification result of a single file.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves the verification result of a single file.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Saves the verification result of a single file.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Save the verification result for a single sentence.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Save the verification result for a single sentence.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Save the verification result for a single sentence.</para>
        /// </summary>
        /// 
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Save the verification result for a single sentence.</para>
        /// </summary>
        /// 
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
