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

        /**
         * @param request AddBusinessCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddBusinessCategoryResponse
         */
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

        /**
         * @param request AddBusinessCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddBusinessCategoryResponse
         */
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

        /**
         * @param request AddBusinessCategoryRequest
         * @return AddBusinessCategoryResponse
         */
        public AddBusinessCategoryResponse AddBusinessCategory(AddBusinessCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBusinessCategoryWithOptions(request, runtime);
        }

        /**
         * @param request AddBusinessCategoryRequest
         * @return AddBusinessCategoryResponse
         */
        public async Task<AddBusinessCategoryResponse> AddBusinessCategoryAsync(AddBusinessCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBusinessCategoryWithOptionsAsync(request, runtime);
        }

        /**
         * @param request AddRuleCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddRuleCategoryResponse
         */
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

        /**
         * @param request AddRuleCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddRuleCategoryResponse
         */
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

        /**
         * @param request AddRuleCategoryRequest
         * @return AddRuleCategoryResponse
         */
        public AddRuleCategoryResponse AddRuleCategory(AddRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRuleCategoryWithOptions(request, runtime);
        }

        /**
         * @param request AddRuleCategoryRequest
         * @return AddRuleCategoryResponse
         */
        public async Task<AddRuleCategoryResponse> AddRuleCategoryAsync(AddRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRuleCategoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary V4创建规则
         *
         * @param request AddRuleV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddRuleV4Response
         */
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

        /**
         * @summary V4创建规则
         *
         * @param request AddRuleV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddRuleV4Response
         */
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

        /**
         * @summary V4创建规则
         *
         * @param request AddRuleV4Request
         * @return AddRuleV4Response
         */
        public AddRuleV4Response AddRuleV4(AddRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRuleV4WithOptions(request, runtime);
        }

        /**
         * @summary V4创建规则
         *
         * @param request AddRuleV4Request
         * @return AddRuleV4Response
         */
        public async Task<AddRuleV4Response> AddRuleV4Async(AddRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRuleV4WithOptionsAsync(request, runtime);
        }

        /**
         * @param request AssignReviewerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AssignReviewerResponse
         */
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

        /**
         * @param request AssignReviewerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AssignReviewerResponse
         */
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

        /**
         * @param request AssignReviewerRequest
         * @return AssignReviewerResponse
         */
        public AssignReviewerResponse AssignReviewer(AssignReviewerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignReviewerWithOptions(request, runtime);
        }

        /**
         * @param request AssignReviewerRequest
         * @return AssignReviewerResponse
         */
        public async Task<AssignReviewerResponse> AssignReviewerAsync(AssignReviewerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignReviewerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 会话组批量分配
         *
         * @param request AssignReviewerBySessionGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AssignReviewerBySessionGroupResponse
         */
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

        /**
         * @summary 会话组批量分配
         *
         * @param request AssignReviewerBySessionGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AssignReviewerBySessionGroupResponse
         */
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

        /**
         * @summary 会话组批量分配
         *
         * @param request AssignReviewerBySessionGroupRequest
         * @return AssignReviewerBySessionGroupResponse
         */
        public AssignReviewerBySessionGroupResponse AssignReviewerBySessionGroup(AssignReviewerBySessionGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignReviewerBySessionGroupWithOptions(request, runtime);
        }

        /**
         * @summary 会话组批量分配
         *
         * @param request AssignReviewerBySessionGroupRequest
         * @return AssignReviewerBySessionGroupResponse
         */
        public async Task<AssignReviewerBySessionGroupResponse> AssignReviewerBySessionGroupAsync(AssignReviewerBySessionGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignReviewerBySessionGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量复核
         *
         * @param request BatchSubmitReviewInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSubmitReviewInfoResponse
         */
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

        /**
         * @summary 批量复核
         *
         * @param request BatchSubmitReviewInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSubmitReviewInfoResponse
         */
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

        /**
         * @summary 批量复核
         *
         * @param request BatchSubmitReviewInfoRequest
         * @return BatchSubmitReviewInfoResponse
         */
        public BatchSubmitReviewInfoResponse BatchSubmitReviewInfo(BatchSubmitReviewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSubmitReviewInfoWithOptions(request, runtime);
        }

        /**
         * @summary 批量复核
         *
         * @param request BatchSubmitReviewInfoRequest
         * @return BatchSubmitReviewInfoResponse
         */
        public async Task<BatchSubmitReviewInfoResponse> BatchSubmitReviewInfoAsync(BatchSubmitReviewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSubmitReviewInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateAsrVocabRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAsrVocabResponse
         */
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

        /**
         * @param request CreateAsrVocabRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAsrVocabResponse
         */
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

        /**
         * @param request CreateAsrVocabRequest
         * @return CreateAsrVocabResponse
         */
        public CreateAsrVocabResponse CreateAsrVocab(CreateAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAsrVocabWithOptions(request, runtime);
        }

        /**
         * @param request CreateAsrVocabRequest
         * @return CreateAsrVocabResponse
         */
        public async Task<CreateAsrVocabResponse> CreateAsrVocabAsync(CreateAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAsrVocabWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建质检方案中的质检维度
         *
         * @param request CreateCheckTypeToSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCheckTypeToSchemeResponse
         */
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

        /**
         * @summary 创建质检方案中的质检维度
         *
         * @param request CreateCheckTypeToSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateCheckTypeToSchemeResponse
         */
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

        /**
         * @summary 创建质检方案中的质检维度
         *
         * @param request CreateCheckTypeToSchemeRequest
         * @return CreateCheckTypeToSchemeResponse
         */
        public CreateCheckTypeToSchemeResponse CreateCheckTypeToScheme(CreateCheckTypeToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCheckTypeToSchemeWithOptions(request, runtime);
        }

        /**
         * @summary 创建质检方案中的质检维度
         *
         * @param request CreateCheckTypeToSchemeRequest
         * @return CreateCheckTypeToSchemeResponse
         */
        public async Task<CreateCheckTypeToSchemeResponse> CreateCheckTypeToSchemeAsync(CreateCheckTypeToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCheckTypeToSchemeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 新增质检方案
         *
         * @param request CreateQualityCheckSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQualityCheckSchemeResponse
         */
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

        /**
         * @summary 新增质检方案
         *
         * @param request CreateQualityCheckSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQualityCheckSchemeResponse
         */
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

        /**
         * @summary 新增质检方案
         *
         * @param request CreateQualityCheckSchemeRequest
         * @return CreateQualityCheckSchemeResponse
         */
        public CreateQualityCheckSchemeResponse CreateQualityCheckScheme(CreateQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityCheckSchemeWithOptions(request, runtime);
        }

        /**
         * @summary 新增质检方案
         *
         * @param request CreateQualityCheckSchemeRequest
         * @return CreateQualityCheckSchemeResponse
         */
        public async Task<CreateQualityCheckSchemeResponse> CreateQualityCheckSchemeAsync(CreateQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityCheckSchemeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 新建质检任务
         *
         * @param request CreateSchemeTaskConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSchemeTaskConfigResponse
         */
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

        /**
         * @summary 新建质检任务
         *
         * @param request CreateSchemeTaskConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSchemeTaskConfigResponse
         */
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

        /**
         * @summary 新建质检任务
         *
         * @param request CreateSchemeTaskConfigRequest
         * @return CreateSchemeTaskConfigResponse
         */
        public CreateSchemeTaskConfigResponse CreateSchemeTaskConfig(CreateSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSchemeTaskConfigWithOptions(request, runtime);
        }

        /**
         * @summary 新建质检任务
         *
         * @param request CreateSchemeTaskConfigRequest
         * @return CreateSchemeTaskConfigResponse
         */
        public async Task<CreateSchemeTaskConfigResponse> CreateSchemeTaskConfigAsync(CreateSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSchemeTaskConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateSkillGroupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSkillGroupConfigResponse
         */
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

        /**
         * @param request CreateSkillGroupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSkillGroupConfigResponse
         */
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

        /**
         * @param request CreateSkillGroupConfigRequest
         * @return CreateSkillGroupConfigResponse
         */
        public CreateSkillGroupConfigResponse CreateSkillGroupConfig(CreateSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSkillGroupConfigWithOptions(request, runtime);
        }

        /**
         * @param request CreateSkillGroupConfigRequest
         * @return CreateSkillGroupConfigResponse
         */
        public async Task<CreateSkillGroupConfigResponse> CreateSkillGroupConfigAsync(CreateSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSkillGroupConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateTaskAssignRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskAssignRuleResponse
         */
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

        /**
         * @param request CreateTaskAssignRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTaskAssignRuleResponse
         */
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

        /**
         * @param request CreateTaskAssignRuleRequest
         * @return CreateTaskAssignRuleResponse
         */
        public CreateTaskAssignRuleResponse CreateTaskAssignRule(CreateTaskAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTaskAssignRuleWithOptions(request, runtime);
        }

        /**
         * @param request CreateTaskAssignRuleRequest
         * @return CreateTaskAssignRuleResponse
         */
        public async Task<CreateTaskAssignRuleResponse> CreateTaskAssignRuleAsync(CreateTaskAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTaskAssignRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI CreateUser is deprecated
         *
         * @param request CreateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserResponse
         */
        // Deprecated
        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @deprecated OpenAPI CreateUser is deprecated
         *
         * @param request CreateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserResponse
         */
        // Deprecated
        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
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

        /**
         * @deprecated OpenAPI CreateUser is deprecated
         *
         * @param request CreateUserRequest
         * @return CreateUserResponse
         */
        // Deprecated
        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI CreateUser is deprecated
         *
         * @param request CreateUserRequest
         * @return CreateUserResponse
         */
        // Deprecated
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CreateWarningConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWarningConfigResponse
         */
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

        /**
         * @param request CreateWarningConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWarningConfigResponse
         */
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

        /**
         * @param request CreateWarningConfigRequest
         * @return CreateWarningConfigResponse
         */
        public CreateWarningConfigResponse CreateWarningConfig(CreateWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWarningConfigWithOptions(request, runtime);
        }

        /**
         * @param request CreateWarningConfigRequest
         * @return CreateWarningConfigResponse
         */
        public async Task<CreateWarningConfigResponse> CreateWarningConfigAsync(CreateWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWarningConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary  预警策略-新增
         *
         * @param request CreateWarningStrategyConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWarningStrategyConfigResponse
         */
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

        /**
         * @summary  预警策略-新增
         *
         * @param request CreateWarningStrategyConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWarningStrategyConfigResponse
         */
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

        /**
         * @summary  预警策略-新增
         *
         * @param request CreateWarningStrategyConfigRequest
         * @return CreateWarningStrategyConfigResponse
         */
        public CreateWarningStrategyConfigResponse CreateWarningStrategyConfig(CreateWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWarningStrategyConfigWithOptions(request, runtime);
        }

        /**
         * @summary  预警策略-新增
         *
         * @param request CreateWarningStrategyConfigRequest
         * @return CreateWarningStrategyConfigResponse
         */
        public async Task<CreateWarningStrategyConfigResponse> CreateWarningStrategyConfigAsync(CreateWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWarningStrategyConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DelRuleCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DelRuleCategoryResponse
         */
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

        /**
         * @param request DelRuleCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DelRuleCategoryResponse
         */
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

        /**
         * @param request DelRuleCategoryRequest
         * @return DelRuleCategoryResponse
         */
        public DelRuleCategoryResponse DelRuleCategory(DelRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DelRuleCategoryWithOptions(request, runtime);
        }

        /**
         * @param request DelRuleCategoryRequest
         * @return DelRuleCategoryResponse
         */
        public async Task<DelRuleCategoryResponse> DelRuleCategoryAsync(DelRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DelRuleCategoryWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteAsrVocabRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAsrVocabResponse
         */
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

        /**
         * @param request DeleteAsrVocabRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAsrVocabResponse
         */
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

        /**
         * @param request DeleteAsrVocabRequest
         * @return DeleteAsrVocabResponse
         */
        public DeleteAsrVocabResponse DeleteAsrVocab(DeleteAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAsrVocabWithOptions(request, runtime);
        }

        /**
         * @param request DeleteAsrVocabRequest
         * @return DeleteAsrVocabResponse
         */
        public async Task<DeleteAsrVocabResponse> DeleteAsrVocabAsync(DeleteAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAsrVocabWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteBusinessCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteBusinessCategoryResponse
         */
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

        /**
         * @param request DeleteBusinessCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteBusinessCategoryResponse
         */
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

        /**
         * @param request DeleteBusinessCategoryRequest
         * @return DeleteBusinessCategoryResponse
         */
        public DeleteBusinessCategoryResponse DeleteBusinessCategory(DeleteBusinessCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBusinessCategoryWithOptions(request, runtime);
        }

        /**
         * @param request DeleteBusinessCategoryRequest
         * @return DeleteBusinessCategoryResponse
         */
        public async Task<DeleteBusinessCategoryResponse> DeleteBusinessCategoryAsync(DeleteBusinessCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBusinessCategoryWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteCustomizationConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomizationConfigResponse
         */
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

        /**
         * @param request DeleteCustomizationConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCustomizationConfigResponse
         */
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

        /**
         * @param request DeleteCustomizationConfigRequest
         * @return DeleteCustomizationConfigResponse
         */
        public DeleteCustomizationConfigResponse DeleteCustomizationConfig(DeleteCustomizationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomizationConfigWithOptions(request, runtime);
        }

        /**
         * @param request DeleteCustomizationConfigRequest
         * @return DeleteCustomizationConfigResponse
         */
        public async Task<DeleteCustomizationConfigResponse> DeleteCustomizationConfigAsync(DeleteCustomizationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomizationConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteDataSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataSetResponse
         */
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

        /**
         * @param request DeleteDataSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataSetResponse
         */
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

        /**
         * @param request DeleteDataSetRequest
         * @return DeleteDataSetResponse
         */
        public DeleteDataSetResponse DeleteDataSet(DeleteDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSetWithOptions(request, runtime);
        }

        /**
         * @param request DeleteDataSetRequest
         * @return DeleteDataSetResponse
         */
        public async Task<DeleteDataSetResponse> DeleteDataSetAsync(DeleteDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSetWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeletePrecisionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePrecisionTaskResponse
         */
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

        /**
         * @param request DeletePrecisionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePrecisionTaskResponse
         */
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

        /**
         * @param request DeletePrecisionTaskRequest
         * @return DeletePrecisionTaskResponse
         */
        public DeletePrecisionTaskResponse DeletePrecisionTask(DeletePrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePrecisionTaskWithOptions(request, runtime);
        }

        /**
         * @param request DeletePrecisionTaskRequest
         * @return DeletePrecisionTaskResponse
         */
        public async Task<DeletePrecisionTaskResponse> DeletePrecisionTaskAsync(DeletePrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePrecisionTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除质检方案
         *
         * @param request DeleteQualityCheckSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteQualityCheckSchemeResponse
         */
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

        /**
         * @summary 删除质检方案
         *
         * @param request DeleteQualityCheckSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteQualityCheckSchemeResponse
         */
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

        /**
         * @summary 删除质检方案
         *
         * @param request DeleteQualityCheckSchemeRequest
         * @return DeleteQualityCheckSchemeResponse
         */
        public DeleteQualityCheckSchemeResponse DeleteQualityCheckScheme(DeleteQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityCheckSchemeWithOptions(request, runtime);
        }

        /**
         * @summary 删除质检方案
         *
         * @param request DeleteQualityCheckSchemeRequest
         * @return DeleteQualityCheckSchemeResponse
         */
        public async Task<DeleteQualityCheckSchemeResponse> DeleteQualityCheckSchemeAsync(DeleteQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityCheckSchemeWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
         *
         * @summary 删除规则
         *
         * @param request DeleteRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRuleResponse
         */
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

        /**
         * @deprecated OpenAPI DeleteRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
         *
         * @summary 删除规则
         *
         * @param request DeleteRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRuleResponse
         */
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

        /**
         * @deprecated OpenAPI DeleteRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
         *
         * @summary 删除规则
         *
         * @param request DeleteRuleRequest
         * @return DeleteRuleResponse
         */
        // Deprecated
        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
         *
         * @summary 删除规则
         *
         * @param request DeleteRuleRequest
         * @return DeleteRuleResponse
         */
        // Deprecated
        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary V4删除规则
         *
         * @param request DeleteRuleV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRuleV4Response
         */
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

        /**
         * @summary V4删除规则
         *
         * @param request DeleteRuleV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRuleV4Response
         */
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

        /**
         * @summary V4删除规则
         *
         * @param request DeleteRuleV4Request
         * @return DeleteRuleV4Response
         */
        public DeleteRuleV4Response DeleteRuleV4(DeleteRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleV4WithOptions(request, runtime);
        }

        /**
         * @summary V4删除规则
         *
         * @param request DeleteRuleV4Request
         * @return DeleteRuleV4Response
         */
        public async Task<DeleteRuleV4Response> DeleteRuleV4Async(DeleteRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleV4WithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除质检任务
         *
         * @param request DeleteSchemeTaskConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSchemeTaskConfigResponse
         */
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

        /**
         * @summary 删除质检任务
         *
         * @param request DeleteSchemeTaskConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSchemeTaskConfigResponse
         */
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

        /**
         * @summary 删除质检任务
         *
         * @param request DeleteSchemeTaskConfigRequest
         * @return DeleteSchemeTaskConfigResponse
         */
        public DeleteSchemeTaskConfigResponse DeleteSchemeTaskConfig(DeleteSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSchemeTaskConfigWithOptions(request, runtime);
        }

        /**
         * @summary 删除质检任务
         *
         * @param request DeleteSchemeTaskConfigRequest
         * @return DeleteSchemeTaskConfigResponse
         */
        public async Task<DeleteSchemeTaskConfigResponse> DeleteSchemeTaskConfigAsync(DeleteSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSchemeTaskConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteScoreForApi is deprecated
         *
         * @param request DeleteScoreForApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScoreForApiResponse
         */
        // Deprecated
        public DeleteScoreForApiResponse DeleteScoreForApiWithOptions(DeleteScoreForApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScoreForApi",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScoreForApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteScoreForApi is deprecated
         *
         * @param request DeleteScoreForApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScoreForApiResponse
         */
        // Deprecated
        public async Task<DeleteScoreForApiResponse> DeleteScoreForApiWithOptionsAsync(DeleteScoreForApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScoreForApi",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScoreForApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteScoreForApi is deprecated
         *
         * @param request DeleteScoreForApiRequest
         * @return DeleteScoreForApiResponse
         */
        // Deprecated
        public DeleteScoreForApiResponse DeleteScoreForApi(DeleteScoreForApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScoreForApiWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteScoreForApi is deprecated
         *
         * @param request DeleteScoreForApiRequest
         * @return DeleteScoreForApiResponse
         */
        // Deprecated
        public async Task<DeleteScoreForApiResponse> DeleteScoreForApiAsync(DeleteScoreForApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScoreForApiWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteSkillGroupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSkillGroupConfigResponse
         */
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

        /**
         * @param request DeleteSkillGroupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSkillGroupConfigResponse
         */
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

        /**
         * @param request DeleteSkillGroupConfigRequest
         * @return DeleteSkillGroupConfigResponse
         */
        public DeleteSkillGroupConfigResponse DeleteSkillGroupConfig(DeleteSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSkillGroupConfigWithOptions(request, runtime);
        }

        /**
         * @param request DeleteSkillGroupConfigRequest
         * @return DeleteSkillGroupConfigResponse
         */
        public async Task<DeleteSkillGroupConfigResponse> DeleteSkillGroupConfigAsync(DeleteSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSkillGroupConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteSubScoreForApi is deprecated
         *
         * @param request DeleteSubScoreForApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSubScoreForApiResponse
         */
        // Deprecated
        public DeleteSubScoreForApiResponse DeleteSubScoreForApiWithOptions(DeleteSubScoreForApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubScoreForApi",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubScoreForApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteSubScoreForApi is deprecated
         *
         * @param request DeleteSubScoreForApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSubScoreForApiResponse
         */
        // Deprecated
        public async Task<DeleteSubScoreForApiResponse> DeleteSubScoreForApiWithOptionsAsync(DeleteSubScoreForApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSubScoreForApi",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSubScoreForApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DeleteSubScoreForApi is deprecated
         *
         * @param request DeleteSubScoreForApiRequest
         * @return DeleteSubScoreForApiResponse
         */
        // Deprecated
        public DeleteSubScoreForApiResponse DeleteSubScoreForApi(DeleteSubScoreForApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSubScoreForApiWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI DeleteSubScoreForApi is deprecated
         *
         * @param request DeleteSubScoreForApiRequest
         * @return DeleteSubScoreForApiResponse
         */
        // Deprecated
        public async Task<DeleteSubScoreForApiResponse> DeleteSubScoreForApiAsync(DeleteSubScoreForApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSubScoreForApiWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteTaskAssignRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTaskAssignRuleResponse
         */
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

        /**
         * @param request DeleteTaskAssignRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTaskAssignRuleResponse
         */
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

        /**
         * @param request DeleteTaskAssignRuleRequest
         * @return DeleteTaskAssignRuleResponse
         */
        public DeleteTaskAssignRuleResponse DeleteTaskAssignRule(DeleteTaskAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTaskAssignRuleWithOptions(request, runtime);
        }

        /**
         * @param request DeleteTaskAssignRuleRequest
         * @return DeleteTaskAssignRuleResponse
         */
        public async Task<DeleteTaskAssignRuleResponse> DeleteTaskAssignRuleAsync(DeleteTaskAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTaskAssignRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteWarningConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWarningConfigResponse
         */
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

        /**
         * @param request DeleteWarningConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWarningConfigResponse
         */
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

        /**
         * @param request DeleteWarningConfigRequest
         * @return DeleteWarningConfigResponse
         */
        public DeleteWarningConfigResponse DeleteWarningConfig(DeleteWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWarningConfigWithOptions(request, runtime);
        }

        /**
         * @param request DeleteWarningConfigRequest
         * @return DeleteWarningConfigResponse
         */
        public async Task<DeleteWarningConfigResponse> DeleteWarningConfigAsync(DeleteWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWarningConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary  预警策略-删除
         *
         * @param request DeleteWarningStrategyConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWarningStrategyConfigResponse
         */
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

        /**
         * @summary  预警策略-删除
         *
         * @param request DeleteWarningStrategyConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWarningStrategyConfigResponse
         */
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

        /**
         * @summary  预警策略-删除
         *
         * @param request DeleteWarningStrategyConfigRequest
         * @return DeleteWarningStrategyConfigResponse
         */
        public DeleteWarningStrategyConfigResponse DeleteWarningStrategyConfig(DeleteWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWarningStrategyConfigWithOptions(request, runtime);
        }

        /**
         * @summary  预警策略-删除
         *
         * @param request DeleteWarningStrategyConfigRequest
         * @return DeleteWarningStrategyConfigResponse
         */
        public async Task<DeleteWarningStrategyConfigResponse> DeleteWarningStrategyConfigAsync(DeleteWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWarningStrategyConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetAsrVocabRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAsrVocabResponse
         */
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

        /**
         * @param request GetAsrVocabRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAsrVocabResponse
         */
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

        /**
         * @param request GetAsrVocabRequest
         * @return GetAsrVocabResponse
         */
        public GetAsrVocabResponse GetAsrVocab(GetAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsrVocabWithOptions(request, runtime);
        }

        /**
         * @param request GetAsrVocabRequest
         * @return GetAsrVocabResponse
         */
        public async Task<GetAsrVocabResponse> GetAsrVocabAsync(GetAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsrVocabWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetBusinessCategoryListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBusinessCategoryListResponse
         */
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

        /**
         * @param request GetBusinessCategoryListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetBusinessCategoryListResponse
         */
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

        /**
         * @param request GetBusinessCategoryListRequest
         * @return GetBusinessCategoryListResponse
         */
        public GetBusinessCategoryListResponse GetBusinessCategoryList(GetBusinessCategoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBusinessCategoryListWithOptions(request, runtime);
        }

        /**
         * @param request GetBusinessCategoryListRequest
         * @return GetBusinessCategoryListResponse
         */
        public async Task<GetBusinessCategoryListResponse> GetBusinessCategoryListAsync(GetBusinessCategoryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBusinessCategoryListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary GetCustomizationConfigList HSF_HTTP
         *
         * @param request GetCustomizationConfigListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomizationConfigListResponse
         */
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

        /**
         * @summary GetCustomizationConfigList HSF_HTTP
         *
         * @param request GetCustomizationConfigListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCustomizationConfigListResponse
         */
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

        /**
         * @summary GetCustomizationConfigList HSF_HTTP
         *
         * @param request GetCustomizationConfigListRequest
         * @return GetCustomizationConfigListResponse
         */
        public GetCustomizationConfigListResponse GetCustomizationConfigList(GetCustomizationConfigListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomizationConfigListWithOptions(request, runtime);
        }

        /**
         * @summary GetCustomizationConfigList HSF_HTTP
         *
         * @param request GetCustomizationConfigListRequest
         * @return GetCustomizationConfigListResponse
         */
        public async Task<GetCustomizationConfigListResponse> GetCustomizationConfigListAsync(GetCustomizationConfigListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomizationConfigListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetNextResultToVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNextResultToVerifyResponse
         */
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

        /**
         * @param request GetNextResultToVerifyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNextResultToVerifyResponse
         */
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

        /**
         * @param request GetNextResultToVerifyRequest
         * @return GetNextResultToVerifyResponse
         */
        public GetNextResultToVerifyResponse GetNextResultToVerify(GetNextResultToVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNextResultToVerifyWithOptions(request, runtime);
        }

        /**
         * @param request GetNextResultToVerifyRequest
         * @return GetNextResultToVerifyResponse
         */
        public async Task<GetNextResultToVerifyResponse> GetNextResultToVerifyAsync(GetNextResultToVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNextResultToVerifyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetPrecisionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPrecisionTaskResponse
         */
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

        /**
         * @param request GetPrecisionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPrecisionTaskResponse
         */
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

        /**
         * @param request GetPrecisionTaskRequest
         * @return GetPrecisionTaskResponse
         */
        public GetPrecisionTaskResponse GetPrecisionTask(GetPrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPrecisionTaskWithOptions(request, runtime);
        }

        /**
         * @param request GetPrecisionTaskRequest
         * @return GetPrecisionTaskResponse
         */
        public async Task<GetPrecisionTaskResponse> GetPrecisionTaskAsync(GetPrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPrecisionTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取质检方案
         *
         * @param request GetQualityCheckSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQualityCheckSchemeResponse
         */
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

        /**
         * @summary 获取质检方案
         *
         * @param request GetQualityCheckSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQualityCheckSchemeResponse
         */
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

        /**
         * @summary 获取质检方案
         *
         * @param request GetQualityCheckSchemeRequest
         * @return GetQualityCheckSchemeResponse
         */
        public GetQualityCheckSchemeResponse GetQualityCheckScheme(GetQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityCheckSchemeWithOptions(request, runtime);
        }

        /**
         * @summary 获取质检方案
         *
         * @param request GetQualityCheckSchemeRequest
         * @return GetQualityCheckSchemeResponse
         */
        public async Task<GetQualityCheckSchemeResponse> GetQualityCheckSchemeAsync(GetQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityCheckSchemeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResultResponse
         */
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

        /**
         * @param request GetResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResultResponse
         */
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

        /**
         * @param request GetResultRequest
         * @return GetResultResponse
         */
        public GetResultResponse GetResult(GetResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResultWithOptions(request, runtime);
        }

        /**
         * @param request GetResultRequest
         * @return GetResultResponse
         */
        public async Task<GetResultResponse> GetResultAsync(GetResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResultWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetResultToReviewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResultToReviewResponse
         */
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

        /**
         * @param request GetResultToReviewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetResultToReviewResponse
         */
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

        /**
         * @param request GetResultToReviewRequest
         * @return GetResultToReviewResponse
         */
        public GetResultToReviewResponse GetResultToReview(GetResultToReviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResultToReviewWithOptions(request, runtime);
        }

        /**
         * @param request GetResultToReviewRequest
         * @return GetResultToReviewResponse
         */
        public async Task<GetResultToReviewResponse> GetResultToReviewAsync(GetResultToReviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResultToReviewWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetRule is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
         *
         * @param request GetRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRuleResponse
         */
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

        /**
         * @deprecated OpenAPI GetRule is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
         *
         * @param request GetRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRuleResponse
         */
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

        /**
         * @deprecated OpenAPI GetRule is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
         *
         * @param request GetRuleRequest
         * @return GetRuleResponse
         */
        // Deprecated
        public GetRuleResponse GetRule(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetRule is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
         *
         * @param request GetRuleRequest
         * @return GetRuleResponse
         */
        // Deprecated
        public async Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetRuleById is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
         *
         * @summary 获取规则
         *
         * @param request GetRuleByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRuleByIdResponse
         */
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

        /**
         * @deprecated OpenAPI GetRuleById is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
         *
         * @summary 获取规则
         *
         * @param request GetRuleByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRuleByIdResponse
         */
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

        /**
         * @deprecated OpenAPI GetRuleById is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
         *
         * @summary 获取规则
         *
         * @param request GetRuleByIdRequest
         * @return GetRuleByIdResponse
         */
        // Deprecated
        public GetRuleByIdResponse GetRuleById(GetRuleByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleByIdWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetRuleById is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
         *
         * @summary 获取规则
         *
         * @param request GetRuleByIdRequest
         * @return GetRuleByIdResponse
         */
        // Deprecated
        public async Task<GetRuleByIdResponse> GetRuleByIdAsync(GetRuleByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleByIdWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetRuleCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRuleCategoryResponse
         */
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

        /**
         * @param request GetRuleCategoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRuleCategoryResponse
         */
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

        /**
         * @param request GetRuleCategoryRequest
         * @return GetRuleCategoryResponse
         */
        public GetRuleCategoryResponse GetRuleCategory(GetRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleCategoryWithOptions(request, runtime);
        }

        /**
         * @param request GetRuleCategoryRequest
         * @return GetRuleCategoryResponse
         */
        public async Task<GetRuleCategoryResponse> GetRuleCategoryAsync(GetRuleCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleCategoryWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetRuleDetail is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
         *
         * @param request GetRuleDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRuleDetailResponse
         */
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

        /**
         * @deprecated OpenAPI GetRuleDetail is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
         *
         * @param request GetRuleDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRuleDetailResponse
         */
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

        /**
         * @deprecated OpenAPI GetRuleDetail is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
         *
         * @param request GetRuleDetailRequest
         * @return GetRuleDetailResponse
         */
        // Deprecated
        public GetRuleDetailResponse GetRuleDetail(GetRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleDetailWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetRuleDetail is deprecated, please use Qualitycheck::2019-01-15::GetRuleV4 instead.
         *
         * @param request GetRuleDetailRequest
         * @return GetRuleDetailResponse
         */
        // Deprecated
        public async Task<GetRuleDetailResponse> GetRuleDetailAsync(GetRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary V4获取规则
         *
         * @param request GetRuleV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRuleV4Response
         */
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

        /**
         * @summary V4获取规则
         *
         * @param request GetRuleV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRuleV4Response
         */
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

        /**
         * @summary V4获取规则
         *
         * @param request GetRuleV4Request
         * @return GetRuleV4Response
         */
        public GetRuleV4Response GetRuleV4(GetRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleV4WithOptions(request, runtime);
        }

        /**
         * @summary V4获取规则
         *
         * @param request GetRuleV4Request
         * @return GetRuleV4Response
         */
        public async Task<GetRuleV4Response> GetRuleV4Async(GetRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleV4WithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获得规则列表
         *
         * @param request GetRulesCountListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRulesCountListResponse
         */
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

        /**
         * @summary 获得规则列表
         *
         * @param request GetRulesCountListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRulesCountListResponse
         */
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

        /**
         * @summary 获得规则列表
         *
         * @param request GetRulesCountListRequest
         * @return GetRulesCountListResponse
         */
        public GetRulesCountListResponse GetRulesCountList(GetRulesCountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRulesCountListWithOptions(request, runtime);
        }

        /**
         * @summary 获得规则列表
         *
         * @param request GetRulesCountListRequest
         * @return GetRulesCountListResponse
         */
        public async Task<GetRulesCountListResponse> GetRulesCountListAsync(GetRulesCountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRulesCountListWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetScoreInfo is deprecated
         *
         * @param request GetScoreInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetScoreInfoResponse
         */
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

        /**
         * @deprecated OpenAPI GetScoreInfo is deprecated
         *
         * @param request GetScoreInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetScoreInfoResponse
         */
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

        /**
         * @deprecated OpenAPI GetScoreInfo is deprecated
         *
         * @param request GetScoreInfoRequest
         * @return GetScoreInfoResponse
         */
        // Deprecated
        public GetScoreInfoResponse GetScoreInfo(GetScoreInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetScoreInfoWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetScoreInfo is deprecated
         *
         * @param request GetScoreInfoRequest
         * @return GetScoreInfoResponse
         */
        // Deprecated
        public async Task<GetScoreInfoResponse> GetScoreInfoAsync(GetScoreInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetScoreInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetSkillGroupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSkillGroupConfigResponse
         */
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

        /**
         * @param request GetSkillGroupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSkillGroupConfigResponse
         */
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

        /**
         * @param request GetSkillGroupConfigRequest
         * @return GetSkillGroupConfigResponse
         */
        public GetSkillGroupConfigResponse GetSkillGroupConfig(GetSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillGroupConfigWithOptions(request, runtime);
        }

        /**
         * @param request GetSkillGroupConfigRequest
         * @return GetSkillGroupConfigResponse
         */
        public async Task<GetSkillGroupConfigResponse> GetSkillGroupConfigAsync(GetSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillGroupConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetSyncResult is deprecated, please use Qualitycheck::2019-01-15::GetResult instead.
         *
         * @param request GetSyncResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSyncResultResponse
         */
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

        /**
         * @deprecated OpenAPI GetSyncResult is deprecated, please use Qualitycheck::2019-01-15::GetResult instead.
         *
         * @param request GetSyncResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSyncResultResponse
         */
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

        /**
         * @deprecated OpenAPI GetSyncResult is deprecated, please use Qualitycheck::2019-01-15::GetResult instead.
         *
         * @param request GetSyncResultRequest
         * @return GetSyncResultResponse
         */
        // Deprecated
        public GetSyncResultResponse GetSyncResult(GetSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSyncResultWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI GetSyncResult is deprecated, please use Qualitycheck::2019-01-15::GetResult instead.
         *
         * @param request GetSyncResultRequest
         * @return GetSyncResultResponse
         */
        // Deprecated
        public async Task<GetSyncResultResponse> GetSyncResultAsync(GetSyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSyncResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 预警策略-详情
         *
         * @param request GetWarningStrategyConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWarningStrategyConfigResponse
         */
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

        /**
         * @summary 预警策略-详情
         *
         * @param request GetWarningStrategyConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWarningStrategyConfigResponse
         */
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

        /**
         * @summary 预警策略-详情
         *
         * @param request GetWarningStrategyConfigRequest
         * @return GetWarningStrategyConfigResponse
         */
        public GetWarningStrategyConfigResponse GetWarningStrategyConfig(GetWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWarningStrategyConfigWithOptions(request, runtime);
        }

        /**
         * @summary 预警策略-详情
         *
         * @param request GetWarningStrategyConfigRequest
         * @return GetWarningStrategyConfigResponse
         */
        public async Task<GetWarningStrategyConfigResponse> GetWarningStrategyConfigAsync(GetWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWarningStrategyConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request HandleComplaintRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return HandleComplaintResponse
         */
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

        /**
         * @param request HandleComplaintRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return HandleComplaintResponse
         */
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

        /**
         * @param request HandleComplaintRequest
         * @return HandleComplaintResponse
         */
        public HandleComplaintResponse HandleComplaint(HandleComplaintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HandleComplaintWithOptions(request, runtime);
        }

        /**
         * @param request HandleComplaintRequest
         * @return HandleComplaintResponse
         */
        public async Task<HandleComplaintResponse> HandleComplaintAsync(HandleComplaintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HandleComplaintWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI InsertScoreForApi is deprecated
         *
         * @param request InsertScoreForApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertScoreForApiResponse
         */
        // Deprecated
        public InsertScoreForApiResponse InsertScoreForApiWithOptions(InsertScoreForApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertScoreForApi",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertScoreForApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI InsertScoreForApi is deprecated
         *
         * @param request InsertScoreForApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertScoreForApiResponse
         */
        // Deprecated
        public async Task<InsertScoreForApiResponse> InsertScoreForApiWithOptionsAsync(InsertScoreForApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertScoreForApi",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertScoreForApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI InsertScoreForApi is deprecated
         *
         * @param request InsertScoreForApiRequest
         * @return InsertScoreForApiResponse
         */
        // Deprecated
        public InsertScoreForApiResponse InsertScoreForApi(InsertScoreForApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertScoreForApiWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI InsertScoreForApi is deprecated
         *
         * @param request InsertScoreForApiRequest
         * @return InsertScoreForApiResponse
         */
        // Deprecated
        public async Task<InsertScoreForApiResponse> InsertScoreForApiAsync(InsertScoreForApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertScoreForApiWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI InsertSubScoreForApi is deprecated
         *
         * @param request InsertSubScoreForApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertSubScoreForApiResponse
         */
        // Deprecated
        public InsertSubScoreForApiResponse InsertSubScoreForApiWithOptions(InsertSubScoreForApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertSubScoreForApi",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertSubScoreForApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI InsertSubScoreForApi is deprecated
         *
         * @param request InsertSubScoreForApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InsertSubScoreForApiResponse
         */
        // Deprecated
        public async Task<InsertSubScoreForApiResponse> InsertSubScoreForApiWithOptionsAsync(InsertSubScoreForApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InsertSubScoreForApi",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InsertSubScoreForApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI InsertSubScoreForApi is deprecated
         *
         * @param request InsertSubScoreForApiRequest
         * @return InsertSubScoreForApiResponse
         */
        // Deprecated
        public InsertSubScoreForApiResponse InsertSubScoreForApi(InsertSubScoreForApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InsertSubScoreForApiWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI InsertSubScoreForApi is deprecated
         *
         * @param request InsertSubScoreForApiRequest
         * @return InsertSubScoreForApiResponse
         */
        // Deprecated
        public async Task<InsertSubScoreForApiResponse> InsertSubScoreForApiAsync(InsertSubScoreForApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InsertSubScoreForApiWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI InvalidRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
         *
         * @param request InvalidRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InvalidRuleResponse
         */
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

        /**
         * @deprecated OpenAPI InvalidRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
         *
         * @param request InvalidRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InvalidRuleResponse
         */
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

        /**
         * @deprecated OpenAPI InvalidRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
         *
         * @param request InvalidRuleRequest
         * @return InvalidRuleResponse
         */
        // Deprecated
        public InvalidRuleResponse InvalidRule(InvalidRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvalidRuleWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI InvalidRule is deprecated, please use Qualitycheck::2019-01-15::DeleteRuleV4 instead.
         *
         * @param request InvalidRuleRequest
         * @return InvalidRuleResponse
         */
        // Deprecated
        public async Task<InvalidRuleResponse> InvalidRuleAsync(InvalidRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvalidRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListAsrVocabRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAsrVocabResponse
         */
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

        /**
         * @param request ListAsrVocabRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAsrVocabResponse
         */
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

        /**
         * @param request ListAsrVocabRequest
         * @return ListAsrVocabResponse
         */
        public ListAsrVocabResponse ListAsrVocab(ListAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAsrVocabWithOptions(request, runtime);
        }

        /**
         * @param request ListAsrVocabRequest
         * @return ListAsrVocabResponse
         */
        public async Task<ListAsrVocabResponse> ListAsrVocabAsync(ListAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAsrVocabWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取数据集列表
         *
         * @param request ListDataSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataSetResponse
         */
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

        /**
         * @summary 获取数据集列表
         *
         * @param request ListDataSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataSetResponse
         */
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

        /**
         * @summary 获取数据集列表
         *
         * @param request ListDataSetRequest
         * @return ListDataSetResponse
         */
        public ListDataSetResponse ListDataSet(ListDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSetWithOptions(request, runtime);
        }

        /**
         * @summary 获取数据集列表
         *
         * @param request ListDataSetRequest
         * @return ListDataSetResponse
         */
        public async Task<ListDataSetResponse> ListDataSetAsync(ListDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSetWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListPrecisionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPrecisionTaskResponse
         */
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

        /**
         * @param request ListPrecisionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPrecisionTaskResponse
         */
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

        /**
         * @param request ListPrecisionTaskRequest
         * @return ListPrecisionTaskResponse
         */
        public ListPrecisionTaskResponse ListPrecisionTask(ListPrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrecisionTaskWithOptions(request, runtime);
        }

        /**
         * @param request ListPrecisionTaskRequest
         * @return ListPrecisionTaskResponse
         */
        public async Task<ListPrecisionTaskResponse> ListPrecisionTaskAsync(ListPrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrecisionTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 质检方案列表
         *
         * @param request ListQualityCheckSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQualityCheckSchemeResponse
         */
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

        /**
         * @summary 质检方案列表
         *
         * @param request ListQualityCheckSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQualityCheckSchemeResponse
         */
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

        /**
         * @summary 质检方案列表
         *
         * @param request ListQualityCheckSchemeRequest
         * @return ListQualityCheckSchemeResponse
         */
        public ListQualityCheckSchemeResponse ListQualityCheckScheme(ListQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQualityCheckSchemeWithOptions(request, runtime);
        }

        /**
         * @summary 质检方案列表
         *
         * @param request ListQualityCheckSchemeRequest
         * @return ListQualityCheckSchemeResponse
         */
        public async Task<ListQualityCheckSchemeResponse> ListQualityCheckSchemeAsync(ListQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQualityCheckSchemeWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI ListRules is deprecated, please use Qualitycheck::2019-01-15::ListRulesV4 instead.
         *
         * @param request ListRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRulesResponse
         */
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

        /**
         * @deprecated OpenAPI ListRules is deprecated, please use Qualitycheck::2019-01-15::ListRulesV4 instead.
         *
         * @param request ListRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRulesResponse
         */
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

        /**
         * @deprecated OpenAPI ListRules is deprecated, please use Qualitycheck::2019-01-15::ListRulesV4 instead.
         *
         * @param request ListRulesRequest
         * @return ListRulesResponse
         */
        // Deprecated
        public ListRulesResponse ListRules(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRulesWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI ListRules is deprecated, please use Qualitycheck::2019-01-15::ListRulesV4 instead.
         *
         * @param request ListRulesRequest
         * @return ListRulesResponse
         */
        // Deprecated
        public async Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary V4获得规则列表
         *
         * @param request ListRulesV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRulesV4Response
         */
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

        /**
         * @summary V4获得规则列表
         *
         * @param request ListRulesV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRulesV4Response
         */
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

        /**
         * @summary V4获得规则列表
         *
         * @param request ListRulesV4Request
         * @return ListRulesV4Response
         */
        public ListRulesV4Response ListRulesV4(ListRulesV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRulesV4WithOptions(request, runtime);
        }

        /**
         * @summary V4获得规则列表
         *
         * @param request ListRulesV4Request
         * @return ListRulesV4Response
         */
        public async Task<ListRulesV4Response> ListRulesV4Async(ListRulesV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRulesV4WithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取质检任务列表
         *
         * @param request ListSchemeTaskConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSchemeTaskConfigResponse
         */
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

        /**
         * @summary 获取质检任务列表
         *
         * @param request ListSchemeTaskConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSchemeTaskConfigResponse
         */
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

        /**
         * @summary 获取质检任务列表
         *
         * @param request ListSchemeTaskConfigRequest
         * @return ListSchemeTaskConfigResponse
         */
        public ListSchemeTaskConfigResponse ListSchemeTaskConfig(ListSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSchemeTaskConfigWithOptions(request, runtime);
        }

        /**
         * @summary 获取质检任务列表
         *
         * @param request ListSchemeTaskConfigRequest
         * @return ListSchemeTaskConfigResponse
         */
        public async Task<ListSchemeTaskConfigResponse> ListSchemeTaskConfigAsync(ListSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSchemeTaskConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取会话组列表
         *
         * @param request ListSessionGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSessionGroupResponse
         */
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

        /**
         * @summary 获取会话组列表
         *
         * @param request ListSessionGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSessionGroupResponse
         */
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

        /**
         * @summary 获取会话组列表
         *
         * @param request ListSessionGroupRequest
         * @return ListSessionGroupResponse
         */
        public ListSessionGroupResponse ListSessionGroup(ListSessionGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSessionGroupWithOptions(request, runtime);
        }

        /**
         * @summary 获取会话组列表
         *
         * @param request ListSessionGroupRequest
         * @return ListSessionGroupResponse
         */
        public async Task<ListSessionGroupResponse> ListSessionGroupAsync(ListSessionGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSessionGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListSkillGroupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSkillGroupConfigResponse
         */
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

        /**
         * @param request ListSkillGroupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSkillGroupConfigResponse
         */
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

        /**
         * @param request ListSkillGroupConfigRequest
         * @return ListSkillGroupConfigResponse
         */
        public ListSkillGroupConfigResponse ListSkillGroupConfig(ListSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillGroupConfigWithOptions(request, runtime);
        }

        /**
         * @param request ListSkillGroupConfigRequest
         * @return ListSkillGroupConfigResponse
         */
        public async Task<ListSkillGroupConfigResponse> ListSkillGroupConfigAsync(ListSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillGroupConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListTaskAssignRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTaskAssignRulesResponse
         */
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

        /**
         * @param request ListTaskAssignRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTaskAssignRulesResponse
         */
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

        /**
         * @param request ListTaskAssignRulesRequest
         * @return ListTaskAssignRulesResponse
         */
        public ListTaskAssignRulesResponse ListTaskAssignRules(ListTaskAssignRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTaskAssignRulesWithOptions(request, runtime);
        }

        /**
         * @param request ListTaskAssignRulesRequest
         * @return ListTaskAssignRulesResponse
         */
        public async Task<ListTaskAssignRulesResponse> ListTaskAssignRulesAsync(ListTaskAssignRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTaskAssignRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
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

        /**
         * @param request ListUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
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

        /**
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        /**
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListWarningConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWarningConfigResponse
         */
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

        /**
         * @param request ListWarningConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWarningConfigResponse
         */
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

        /**
         * @param request ListWarningConfigRequest
         * @return ListWarningConfigResponse
         */
        public ListWarningConfigResponse ListWarningConfig(ListWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWarningConfigWithOptions(request, runtime);
        }

        /**
         * @param request ListWarningConfigRequest
         * @return ListWarningConfigResponse
         */
        public async Task<ListWarningConfigResponse> ListWarningConfigAsync(ListWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWarningConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary  预警策略-列表
         *
         * @param request ListWarningStrategyConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWarningStrategyConfigResponse
         */
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

        /**
         * @summary  预警策略-列表
         *
         * @param request ListWarningStrategyConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWarningStrategyConfigResponse
         */
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

        /**
         * @summary  预警策略-列表
         *
         * @param request ListWarningStrategyConfigRequest
         * @return ListWarningStrategyConfigResponse
         */
        public ListWarningStrategyConfigResponse ListWarningStrategyConfig(ListWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWarningStrategyConfigWithOptions(request, runtime);
        }

        /**
         * @summary  预警策略-列表
         *
         * @param request ListWarningStrategyConfigRequest
         * @return ListWarningStrategyConfigResponse
         */
        public async Task<ListWarningStrategyConfigResponse> ListWarningStrategyConfigAsync(ListWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWarningStrategyConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量回收
         *
         * @param request RevertAssignedSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevertAssignedSessionResponse
         */
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

        /**
         * @summary 批量回收
         *
         * @param request RevertAssignedSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevertAssignedSessionResponse
         */
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

        /**
         * @summary 批量回收
         *
         * @param request RevertAssignedSessionRequest
         * @return RevertAssignedSessionResponse
         */
        public RevertAssignedSessionResponse RevertAssignedSession(RevertAssignedSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevertAssignedSessionWithOptions(request, runtime);
        }

        /**
         * @summary 批量回收
         *
         * @param request RevertAssignedSessionRequest
         * @return RevertAssignedSessionResponse
         */
        public async Task<RevertAssignedSessionResponse> RevertAssignedSessionAsync(RevertAssignedSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevertAssignedSessionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 会话组批量回收
         *
         * @param request RevertAssignedSessionGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevertAssignedSessionGroupResponse
         */
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

        /**
         * @summary 会话组批量回收
         *
         * @param request RevertAssignedSessionGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevertAssignedSessionGroupResponse
         */
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

        /**
         * @summary 会话组批量回收
         *
         * @param request RevertAssignedSessionGroupRequest
         * @return RevertAssignedSessionGroupResponse
         */
        public RevertAssignedSessionGroupResponse RevertAssignedSessionGroup(RevertAssignedSessionGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevertAssignedSessionGroupWithOptions(request, runtime);
        }

        /**
         * @summary 会话组批量回收
         *
         * @param request RevertAssignedSessionGroupRequest
         * @return RevertAssignedSessionGroupResponse
         */
        public async Task<RevertAssignedSessionGroupResponse> RevertAssignedSessionGroupAsync(RevertAssignedSessionGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevertAssignedSessionGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SaveConfigDataSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveConfigDataSetResponse
         */
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

        /**
         * @param request SaveConfigDataSetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveConfigDataSetResponse
         */
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

        /**
         * @param request SaveConfigDataSetRequest
         * @return SaveConfigDataSetResponse
         */
        public SaveConfigDataSetResponse SaveConfigDataSet(SaveConfigDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveConfigDataSetWithOptions(request, runtime);
        }

        /**
         * @param request SaveConfigDataSetRequest
         * @return SaveConfigDataSetResponse
         */
        public async Task<SaveConfigDataSetResponse> SaveConfigDataSetAsync(SaveConfigDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveConfigDataSetWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SubmitComplaintRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitComplaintResponse
         */
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

        /**
         * @param request SubmitComplaintRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitComplaintResponse
         */
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

        /**
         * @param request SubmitComplaintRequest
         * @return SubmitComplaintResponse
         */
        public SubmitComplaintResponse SubmitComplaint(SubmitComplaintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitComplaintWithOptions(request, runtime);
        }

        /**
         * @param request SubmitComplaintRequest
         * @return SubmitComplaintResponse
         */
        public async Task<SubmitComplaintResponse> SubmitComplaintAsync(SubmitComplaintRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitComplaintWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SubmitPrecisionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitPrecisionTaskResponse
         */
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

        /**
         * @param request SubmitPrecisionTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitPrecisionTaskResponse
         */
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

        /**
         * @param request SubmitPrecisionTaskRequest
         * @return SubmitPrecisionTaskResponse
         */
        public SubmitPrecisionTaskResponse SubmitPrecisionTask(SubmitPrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitPrecisionTaskWithOptions(request, runtime);
        }

        /**
         * @param request SubmitPrecisionTaskRequest
         * @return SubmitPrecisionTaskResponse
         */
        public async Task<SubmitPrecisionTaskResponse> SubmitPrecisionTaskAsync(SubmitPrecisionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitPrecisionTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SubmitQualityCheckTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitQualityCheckTaskResponse
         */
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

        /**
         * @param request SubmitQualityCheckTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitQualityCheckTaskResponse
         */
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

        /**
         * @param request SubmitQualityCheckTaskRequest
         * @return SubmitQualityCheckTaskResponse
         */
        public SubmitQualityCheckTaskResponse SubmitQualityCheckTask(SubmitQualityCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitQualityCheckTaskWithOptions(request, runtime);
        }

        /**
         * @param request SubmitQualityCheckTaskRequest
         * @return SubmitQualityCheckTaskResponse
         */
        public async Task<SubmitQualityCheckTaskResponse> SubmitQualityCheckTaskAsync(SubmitQualityCheckTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitQualityCheckTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SubmitReviewInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitReviewInfoResponse
         */
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

        /**
         * @param request SubmitReviewInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitReviewInfoResponse
         */
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

        /**
         * @param request SubmitReviewInfoRequest
         * @return SubmitReviewInfoResponse
         */
        public SubmitReviewInfoResponse SubmitReviewInfo(SubmitReviewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitReviewInfoWithOptions(request, runtime);
        }

        /**
         * @param request SubmitReviewInfoRequest
         * @return SubmitReviewInfoResponse
         */
        public async Task<SubmitReviewInfoResponse> SubmitReviewInfoAsync(SubmitReviewInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitReviewInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SyncQualityCheckRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncQualityCheckResponse
         */
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

        /**
         * @param request SyncQualityCheckRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncQualityCheckResponse
         */
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

        /**
         * @param request SyncQualityCheckRequest
         * @return SyncQualityCheckResponse
         */
        public SyncQualityCheckResponse SyncQualityCheck(SyncQualityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncQualityCheckWithOptions(request, runtime);
        }

        /**
         * @param request SyncQualityCheckRequest
         * @return SyncQualityCheckResponse
         */
        public async Task<SyncQualityCheckResponse> SyncQualityCheckAsync(SyncQualityCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncQualityCheckWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 测试规则
         *
         * @param request TestRuleV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return TestRuleV4Response
         */
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

        /**
         * @summary 测试规则
         *
         * @param request TestRuleV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return TestRuleV4Response
         */
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

        /**
         * @summary 测试规则
         *
         * @param request TestRuleV4Request
         * @return TestRuleV4Response
         */
        public TestRuleV4Response TestRuleV4(TestRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestRuleV4WithOptions(request, runtime);
        }

        /**
         * @summary 测试规则
         *
         * @param request TestRuleV4Request
         * @return TestRuleV4Response
         */
        public async Task<TestRuleV4Response> TestRuleV4Async(TestRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestRuleV4WithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateAsrVocabRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAsrVocabResponse
         */
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

        /**
         * @param request UpdateAsrVocabRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAsrVocabResponse
         */
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

        /**
         * @param request UpdateAsrVocabRequest
         * @return UpdateAsrVocabResponse
         */
        public UpdateAsrVocabResponse UpdateAsrVocab(UpdateAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAsrVocabWithOptions(request, runtime);
        }

        /**
         * @param request UpdateAsrVocabRequest
         * @return UpdateAsrVocabResponse
         */
        public async Task<UpdateAsrVocabResponse> UpdateAsrVocabAsync(UpdateAsrVocabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAsrVocabWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新质检方案中的质检维度
         *
         * @param request UpdateCheckTypeToSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCheckTypeToSchemeResponse
         */
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

        /**
         * @summary 更新质检方案中的质检维度
         *
         * @param request UpdateCheckTypeToSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCheckTypeToSchemeResponse
         */
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

        /**
         * @summary 更新质检方案中的质检维度
         *
         * @param request UpdateCheckTypeToSchemeRequest
         * @return UpdateCheckTypeToSchemeResponse
         */
        public UpdateCheckTypeToSchemeResponse UpdateCheckTypeToScheme(UpdateCheckTypeToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCheckTypeToSchemeWithOptions(request, runtime);
        }

        /**
         * @summary 更新质检方案中的质检维度
         *
         * @param request UpdateCheckTypeToSchemeRequest
         * @return UpdateCheckTypeToSchemeResponse
         */
        public async Task<UpdateCheckTypeToSchemeResponse> UpdateCheckTypeToSchemeAsync(UpdateCheckTypeToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCheckTypeToSchemeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新会话随录数据
         *
         * @param request UpdateQualityCheckDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateQualityCheckDataResponse
         */
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

        /**
         * @summary 更新会话随录数据
         *
         * @param request UpdateQualityCheckDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateQualityCheckDataResponse
         */
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

        /**
         * @summary 更新会话随录数据
         *
         * @param request UpdateQualityCheckDataRequest
         * @return UpdateQualityCheckDataResponse
         */
        public UpdateQualityCheckDataResponse UpdateQualityCheckData(UpdateQualityCheckDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQualityCheckDataWithOptions(request, runtime);
        }

        /**
         * @summary 更新会话随录数据
         *
         * @param request UpdateQualityCheckDataRequest
         * @return UpdateQualityCheckDataResponse
         */
        public async Task<UpdateQualityCheckDataResponse> UpdateQualityCheckDataAsync(UpdateQualityCheckDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQualityCheckDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新质检方案
         *
         * @param request UpdateQualityCheckSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateQualityCheckSchemeResponse
         */
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

        /**
         * @summary 更新质检方案
         *
         * @param request UpdateQualityCheckSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateQualityCheckSchemeResponse
         */
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

        /**
         * @summary 更新质检方案
         *
         * @param request UpdateQualityCheckSchemeRequest
         * @return UpdateQualityCheckSchemeResponse
         */
        public UpdateQualityCheckSchemeResponse UpdateQualityCheckScheme(UpdateQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQualityCheckSchemeWithOptions(request, runtime);
        }

        /**
         * @summary 更新质检方案
         *
         * @param request UpdateQualityCheckSchemeRequest
         * @return UpdateQualityCheckSchemeResponse
         */
        public async Task<UpdateQualityCheckSchemeResponse> UpdateQualityCheckSchemeAsync(UpdateQualityCheckSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQualityCheckSchemeWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI UpdateRule is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
         *
         * @param request UpdateRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRuleResponse
         */
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

        /**
         * @deprecated OpenAPI UpdateRule is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
         *
         * @param request UpdateRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRuleResponse
         */
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

        /**
         * @deprecated OpenAPI UpdateRule is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
         *
         * @param request UpdateRuleRequest
         * @return UpdateRuleResponse
         */
        // Deprecated
        public UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI UpdateRule is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
         *
         * @param request UpdateRuleRequest
         * @return UpdateRuleResponse
         */
        // Deprecated
        public async Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI UpdateRuleById is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
         *
         * @summary 更新规则
         *
         * @param request UpdateRuleByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRuleByIdResponse
         */
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

        /**
         * @deprecated OpenAPI UpdateRuleById is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
         *
         * @summary 更新规则
         *
         * @param request UpdateRuleByIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRuleByIdResponse
         */
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

        /**
         * @deprecated OpenAPI UpdateRuleById is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
         *
         * @summary 更新规则
         *
         * @param request UpdateRuleByIdRequest
         * @return UpdateRuleByIdResponse
         */
        // Deprecated
        public UpdateRuleByIdResponse UpdateRuleById(UpdateRuleByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleByIdWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI UpdateRuleById is deprecated, please use Qualitycheck::2019-01-15::UpdateRuleV4 instead.
         *
         * @summary 更新规则
         *
         * @param request UpdateRuleByIdRequest
         * @return UpdateRuleByIdResponse
         */
        // Deprecated
        public async Task<UpdateRuleByIdResponse> UpdateRuleByIdAsync(UpdateRuleByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleByIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新质检方案的规则
         *
         * @param request UpdateRuleToSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRuleToSchemeResponse
         */
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

        /**
         * @summary 更新质检方案的规则
         *
         * @param request UpdateRuleToSchemeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRuleToSchemeResponse
         */
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

        /**
         * @summary 更新质检方案的规则
         *
         * @param request UpdateRuleToSchemeRequest
         * @return UpdateRuleToSchemeResponse
         */
        public UpdateRuleToSchemeResponse UpdateRuleToScheme(UpdateRuleToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleToSchemeWithOptions(request, runtime);
        }

        /**
         * @summary 更新质检方案的规则
         *
         * @param request UpdateRuleToSchemeRequest
         * @return UpdateRuleToSchemeResponse
         */
        public async Task<UpdateRuleToSchemeResponse> UpdateRuleToSchemeAsync(UpdateRuleToSchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleToSchemeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary V4更新规则
         *
         * @param request UpdateRuleV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRuleV4Response
         */
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

        /**
         * @summary V4更新规则
         *
         * @param request UpdateRuleV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRuleV4Response
         */
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

        /**
         * @summary V4更新规则
         *
         * @param request UpdateRuleV4Request
         * @return UpdateRuleV4Response
         */
        public UpdateRuleV4Response UpdateRuleV4(UpdateRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleV4WithOptions(request, runtime);
        }

        /**
         * @summary V4更新规则
         *
         * @param request UpdateRuleV4Request
         * @return UpdateRuleV4Response
         */
        public async Task<UpdateRuleV4Response> UpdateRuleV4Async(UpdateRuleV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleV4WithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建质检任务
         *
         * @param request UpdateSchemeTaskConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSchemeTaskConfigResponse
         */
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

        /**
         * @summary 创建质检任务
         *
         * @param request UpdateSchemeTaskConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSchemeTaskConfigResponse
         */
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

        /**
         * @summary 创建质检任务
         *
         * @param request UpdateSchemeTaskConfigRequest
         * @return UpdateSchemeTaskConfigResponse
         */
        public UpdateSchemeTaskConfigResponse UpdateSchemeTaskConfig(UpdateSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSchemeTaskConfigWithOptions(request, runtime);
        }

        /**
         * @summary 创建质检任务
         *
         * @param request UpdateSchemeTaskConfigRequest
         * @return UpdateSchemeTaskConfigResponse
         */
        public async Task<UpdateSchemeTaskConfigResponse> UpdateSchemeTaskConfigAsync(UpdateSchemeTaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSchemeTaskConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI UpdateScoreForApi is deprecated
         *
         * @param request UpdateScoreForApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateScoreForApiResponse
         */
        // Deprecated
        public UpdateScoreForApiResponse UpdateScoreForApiWithOptions(UpdateScoreForApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScoreForApi",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScoreForApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI UpdateScoreForApi is deprecated
         *
         * @param request UpdateScoreForApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateScoreForApiResponse
         */
        // Deprecated
        public async Task<UpdateScoreForApiResponse> UpdateScoreForApiWithOptionsAsync(UpdateScoreForApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScoreForApi",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateScoreForApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI UpdateScoreForApi is deprecated
         *
         * @param request UpdateScoreForApiRequest
         * @return UpdateScoreForApiResponse
         */
        // Deprecated
        public UpdateScoreForApiResponse UpdateScoreForApi(UpdateScoreForApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateScoreForApiWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI UpdateScoreForApi is deprecated
         *
         * @param request UpdateScoreForApiRequest
         * @return UpdateScoreForApiResponse
         */
        // Deprecated
        public async Task<UpdateScoreForApiResponse> UpdateScoreForApiAsync(UpdateScoreForApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateScoreForApiWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateSkillGroupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSkillGroupConfigResponse
         */
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

        /**
         * @param request UpdateSkillGroupConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSkillGroupConfigResponse
         */
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

        /**
         * @param request UpdateSkillGroupConfigRequest
         * @return UpdateSkillGroupConfigResponse
         */
        public UpdateSkillGroupConfigResponse UpdateSkillGroupConfig(UpdateSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSkillGroupConfigWithOptions(request, runtime);
        }

        /**
         * @param request UpdateSkillGroupConfigRequest
         * @return UpdateSkillGroupConfigResponse
         */
        public async Task<UpdateSkillGroupConfigResponse> UpdateSkillGroupConfigAsync(UpdateSkillGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSkillGroupConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI UpdateSubScoreForApi is deprecated
         *
         * @param request UpdateSubScoreForApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSubScoreForApiResponse
         */
        // Deprecated
        public UpdateSubScoreForApiResponse UpdateSubScoreForApiWithOptions(UpdateSubScoreForApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSubScoreForApi",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubScoreForApiResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI UpdateSubScoreForApi is deprecated
         *
         * @param request UpdateSubScoreForApiRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSubScoreForApiResponse
         */
        // Deprecated
        public async Task<UpdateSubScoreForApiResponse> UpdateSubScoreForApiWithOptionsAsync(UpdateSubScoreForApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseMeAgentId))
            {
                query["BaseMeAgentId"] = request.BaseMeAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JsonStr))
            {
                query["JsonStr"] = request.JsonStr;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSubScoreForApi",
                Version = "2019-01-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSubScoreForApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI UpdateSubScoreForApi is deprecated
         *
         * @param request UpdateSubScoreForApiRequest
         * @return UpdateSubScoreForApiResponse
         */
        // Deprecated
        public UpdateSubScoreForApiResponse UpdateSubScoreForApi(UpdateSubScoreForApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSubScoreForApiWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI UpdateSubScoreForApi is deprecated
         *
         * @param request UpdateSubScoreForApiRequest
         * @return UpdateSubScoreForApiResponse
         */
        // Deprecated
        public async Task<UpdateSubScoreForApiResponse> UpdateSubScoreForApiAsync(UpdateSubScoreForApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSubScoreForApiWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateSyncQualityCheckDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSyncQualityCheckDataResponse
         */
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

        /**
         * @param request UpdateSyncQualityCheckDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSyncQualityCheckDataResponse
         */
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

        /**
         * @param request UpdateSyncQualityCheckDataRequest
         * @return UpdateSyncQualityCheckDataResponse
         */
        public UpdateSyncQualityCheckDataResponse UpdateSyncQualityCheckData(UpdateSyncQualityCheckDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSyncQualityCheckDataWithOptions(request, runtime);
        }

        /**
         * @param request UpdateSyncQualityCheckDataRequest
         * @return UpdateSyncQualityCheckDataResponse
         */
        public async Task<UpdateSyncQualityCheckDataResponse> UpdateSyncQualityCheckDataAsync(UpdateSyncQualityCheckDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSyncQualityCheckDataWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateTaskAssignRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskAssignRuleResponse
         */
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

        /**
         * @param request UpdateTaskAssignRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTaskAssignRuleResponse
         */
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

        /**
         * @param request UpdateTaskAssignRuleRequest
         * @return UpdateTaskAssignRuleResponse
         */
        public UpdateTaskAssignRuleResponse UpdateTaskAssignRule(UpdateTaskAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTaskAssignRuleWithOptions(request, runtime);
        }

        /**
         * @param request UpdateTaskAssignRuleRequest
         * @return UpdateTaskAssignRuleResponse
         */
        public async Task<UpdateTaskAssignRuleResponse> UpdateTaskAssignRuleAsync(UpdateTaskAssignRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTaskAssignRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
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

        /**
         * @param request UpdateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
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

        /**
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        /**
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateWarningConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWarningConfigResponse
         */
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

        /**
         * @param request UpdateWarningConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWarningConfigResponse
         */
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

        /**
         * @param request UpdateWarningConfigRequest
         * @return UpdateWarningConfigResponse
         */
        public UpdateWarningConfigResponse UpdateWarningConfig(UpdateWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWarningConfigWithOptions(request, runtime);
        }

        /**
         * @param request UpdateWarningConfigRequest
         * @return UpdateWarningConfigResponse
         */
        public async Task<UpdateWarningConfigResponse> UpdateWarningConfigAsync(UpdateWarningConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWarningConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary  预警策略-更新
         *
         * @param request UpdateWarningStrategyConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWarningStrategyConfigResponse
         */
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

        /**
         * @summary  预警策略-更新
         *
         * @param request UpdateWarningStrategyConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWarningStrategyConfigResponse
         */
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

        /**
         * @summary  预警策略-更新
         *
         * @param request UpdateWarningStrategyConfigRequest
         * @return UpdateWarningStrategyConfigResponse
         */
        public UpdateWarningStrategyConfigResponse UpdateWarningStrategyConfig(UpdateWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWarningStrategyConfigWithOptions(request, runtime);
        }

        /**
         * @summary  预警策略-更新
         *
         * @param request UpdateWarningStrategyConfigRequest
         * @return UpdateWarningStrategyConfigResponse
         */
        public async Task<UpdateWarningStrategyConfigResponse> UpdateWarningStrategyConfigAsync(UpdateWarningStrategyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWarningStrategyConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UploadAudioDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadAudioDataResponse
         */
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

        /**
         * @param request UploadAudioDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadAudioDataResponse
         */
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

        /**
         * @param request UploadAudioDataRequest
         * @return UploadAudioDataResponse
         */
        public UploadAudioDataResponse UploadAudioData(UploadAudioDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadAudioDataWithOptions(request, runtime);
        }

        /**
         * @param request UploadAudioDataRequest
         * @return UploadAudioDataResponse
         */
        public async Task<UploadAudioDataResponse> UploadAudioDataAsync(UploadAudioDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadAudioDataWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI UploadData is deprecated, please use Qualitycheck::2019-01-15::UploadDataV4 instead.
         *
         * @summary 推荐使用UploadDataV4接口,支持更长的JsonStr,但仅支持POST方法.
         *
         * @param request UploadDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadDataResponse
         */
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

        /**
         * @deprecated OpenAPI UploadData is deprecated, please use Qualitycheck::2019-01-15::UploadDataV4 instead.
         *
         * @summary 推荐使用UploadDataV4接口,支持更长的JsonStr,但仅支持POST方法.
         *
         * @param request UploadDataRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadDataResponse
         */
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

        /**
         * @deprecated OpenAPI UploadData is deprecated, please use Qualitycheck::2019-01-15::UploadDataV4 instead.
         *
         * @summary 推荐使用UploadDataV4接口,支持更长的JsonStr,但仅支持POST方法.
         *
         * @param request UploadDataRequest
         * @return UploadDataResponse
         */
        // Deprecated
        public UploadDataResponse UploadData(UploadDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDataWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI UploadData is deprecated, please use Qualitycheck::2019-01-15::UploadDataV4 instead.
         *
         * @summary 推荐使用UploadDataV4接口,支持更长的JsonStr,但仅支持POST方法.
         *
         * @param request UploadDataRequest
         * @return UploadDataResponse
         */
        // Deprecated
        public async Task<UploadDataResponse> UploadDataAsync(UploadDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDataWithOptionsAsync(request, runtime);
        }

        /**
         * @summary http_hsf
         *
         * @param request UploadDataSyncRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadDataSyncResponse
         */
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

        /**
         * @summary http_hsf
         *
         * @param request UploadDataSyncRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadDataSyncResponse
         */
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

        /**
         * @summary http_hsf
         *
         * @param request UploadDataSyncRequest
         * @return UploadDataSyncResponse
         */
        public UploadDataSyncResponse UploadDataSync(UploadDataSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDataSyncWithOptions(request, runtime);
        }

        /**
         * @summary http_hsf
         *
         * @param request UploadDataSyncRequest
         * @return UploadDataSyncResponse
         */
        public async Task<UploadDataSyncResponse> UploadDataSyncAsync(UploadDataSyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDataSyncWithOptionsAsync(request, runtime);
        }

        /**
         * @summary UploadDataV4
         *
         * @param request UploadDataV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadDataV4Response
         */
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

        /**
         * @summary UploadDataV4
         *
         * @param request UploadDataV4Request
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadDataV4Response
         */
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

        /**
         * @summary UploadDataV4
         *
         * @param request UploadDataV4Request
         * @return UploadDataV4Response
         */
        public UploadDataV4Response UploadDataV4(UploadDataV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadDataV4WithOptions(request, runtime);
        }

        /**
         * @summary UploadDataV4
         *
         * @param request UploadDataV4Request
         * @return UploadDataV4Response
         */
        public async Task<UploadDataV4Response> UploadDataV4Async(UploadDataV4Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadDataV4WithOptionsAsync(request, runtime);
        }

        /**
         * @param request UploadRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadRuleResponse
         */
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

        /**
         * @param request UploadRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadRuleResponse
         */
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

        /**
         * @param request UploadRuleRequest
         * @return UploadRuleResponse
         */
        public UploadRuleResponse UploadRule(UploadRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadRuleWithOptions(request, runtime);
        }

        /**
         * @param request UploadRuleRequest
         * @return UploadRuleResponse
         */
        public async Task<UploadRuleResponse> UploadRuleAsync(UploadRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @param request VerifyFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyFileResponse
         */
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

        /**
         * @param request VerifyFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyFileResponse
         */
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

        /**
         * @param request VerifyFileRequest
         * @return VerifyFileResponse
         */
        public VerifyFileResponse VerifyFile(VerifyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyFileWithOptions(request, runtime);
        }

        /**
         * @param request VerifyFileRequest
         * @return VerifyFileResponse
         */
        public async Task<VerifyFileResponse> VerifyFileAsync(VerifyFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyFileWithOptionsAsync(request, runtime);
        }

        /**
         * @param request VerifySentenceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifySentenceResponse
         */
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

        /**
         * @param request VerifySentenceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifySentenceResponse
         */
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

        /**
         * @param request VerifySentenceRequest
         * @return VerifySentenceResponse
         */
        public VerifySentenceResponse VerifySentence(VerifySentenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifySentenceWithOptions(request, runtime);
        }

        /**
         * @param request VerifySentenceRequest
         * @return VerifySentenceResponse
         */
        public async Task<VerifySentenceResponse> VerifySentenceAsync(VerifySentenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifySentenceWithOptionsAsync(request, runtime);
        }

    }
}
