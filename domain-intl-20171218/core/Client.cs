// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Domain_intl20171218.Models;

namespace AlibabaCloud.SDK.Domain_intl20171218
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("domain-intl", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AcknowledgeTaskResultResponse AcknowledgeTaskResultWithOptions(AcknowledgeTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDetailNo))
            {
                query["TaskDetailNo"] = request.TaskDetailNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcknowledgeTaskResult",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcknowledgeTaskResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AcknowledgeTaskResultResponse> AcknowledgeTaskResultWithOptionsAsync(AcknowledgeTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDetailNo))
            {
                query["TaskDetailNo"] = request.TaskDetailNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcknowledgeTaskResult",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcknowledgeTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AcknowledgeTaskResultResponse AcknowledgeTaskResult(AcknowledgeTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcknowledgeTaskResultWithOptions(request, runtime);
        }

        public async Task<AcknowledgeTaskResultResponse> AcknowledgeTaskResultAsync(AcknowledgeTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcknowledgeTaskResultWithOptionsAsync(request, runtime);
        }

        public BatchFuzzyMatchDomainSensitiveWordResponse BatchFuzzyMatchDomainSensitiveWordWithOptions(BatchFuzzyMatchDomainSensitiveWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchFuzzyMatchDomainSensitiveWord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchFuzzyMatchDomainSensitiveWordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchFuzzyMatchDomainSensitiveWordResponse> BatchFuzzyMatchDomainSensitiveWordWithOptionsAsync(BatchFuzzyMatchDomainSensitiveWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchFuzzyMatchDomainSensitiveWord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchFuzzyMatchDomainSensitiveWordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchFuzzyMatchDomainSensitiveWordResponse BatchFuzzyMatchDomainSensitiveWord(BatchFuzzyMatchDomainSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchFuzzyMatchDomainSensitiveWordWithOptions(request, runtime);
        }

        public async Task<BatchFuzzyMatchDomainSensitiveWordResponse> BatchFuzzyMatchDomainSensitiveWordAsync(BatchFuzzyMatchDomainSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchFuzzyMatchDomainSensitiveWordWithOptionsAsync(request, runtime);
        }

        public CancelDomainVerificationResponse CancelDomainVerificationWithOptions(CancelDomainVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDomainVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDomainVerificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelDomainVerificationResponse> CancelDomainVerificationWithOptionsAsync(CancelDomainVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDomainVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDomainVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelDomainVerificationResponse CancelDomainVerification(CancelDomainVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDomainVerificationWithOptions(request, runtime);
        }

        public async Task<CancelDomainVerificationResponse> CancelDomainVerificationAsync(CancelDomainVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDomainVerificationWithOptionsAsync(request, runtime);
        }

        public CancelTaskResponse CancelTaskWithOptions(CancelTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskNo))
            {
                query["TaskNo"] = request.TaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTask",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelTaskResponse> CancelTaskWithOptionsAsync(CancelTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskNo))
            {
                query["TaskNo"] = request.TaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTask",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelTaskResponse CancelTask(CancelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelTaskWithOptions(request, runtime);
        }

        public async Task<CancelTaskResponse> CancelTaskAsync(CancelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelTaskWithOptionsAsync(request, runtime);
        }

        public CheckDomainResponse CheckDomainWithOptions(CheckDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeeCommand))
            {
                query["FeeCommand"] = request.FeeCommand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeeCurrency))
            {
                query["FeeCurrency"] = request.FeeCurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeePeriod))
            {
                query["FeePeriod"] = request.FeePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDomain",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckDomainResponse> CheckDomainWithOptionsAsync(CheckDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeeCommand))
            {
                query["FeeCommand"] = request.FeeCommand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeeCurrency))
            {
                query["FeeCurrency"] = request.FeeCurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeePeriod))
            {
                query["FeePeriod"] = request.FeePeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDomain",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckDomainResponse CheckDomain(CheckDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDomainWithOptions(request, runtime);
        }

        public async Task<CheckDomainResponse> CheckDomainAsync(CheckDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDomainWithOptionsAsync(request, runtime);
        }

        public CheckDomainSunriseClaimResponse CheckDomainSunriseClaimWithOptions(CheckDomainSunriseClaimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDomainSunriseClaim",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDomainSunriseClaimResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckDomainSunriseClaimResponse> CheckDomainSunriseClaimWithOptionsAsync(CheckDomainSunriseClaimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDomainSunriseClaim",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDomainSunriseClaimResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckDomainSunriseClaimResponse CheckDomainSunriseClaim(CheckDomainSunriseClaimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDomainSunriseClaimWithOptions(request, runtime);
        }

        public async Task<CheckDomainSunriseClaimResponse> CheckDomainSunriseClaimAsync(CheckDomainSunriseClaimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDomainSunriseClaimWithOptionsAsync(request, runtime);
        }

        public CheckTransferInFeasibilityResponse CheckTransferInFeasibilityWithOptions(CheckTransferInFeasibilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferAuthorizationCode))
            {
                query["TransferAuthorizationCode"] = request.TransferAuthorizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckTransferInFeasibility",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckTransferInFeasibilityResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckTransferInFeasibilityResponse> CheckTransferInFeasibilityWithOptionsAsync(CheckTransferInFeasibilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferAuthorizationCode))
            {
                query["TransferAuthorizationCode"] = request.TransferAuthorizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckTransferInFeasibility",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckTransferInFeasibilityResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckTransferInFeasibilityResponse CheckTransferInFeasibility(CheckTransferInFeasibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckTransferInFeasibilityWithOptions(request, runtime);
        }

        public async Task<CheckTransferInFeasibilityResponse> CheckTransferInFeasibilityAsync(CheckTransferInFeasibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckTransferInFeasibilityWithOptionsAsync(request, runtime);
        }

        public ConfirmTransferInEmailResponse ConfirmTransferInEmailWithOptions(ConfirmTransferInEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmTransferInEmail",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmTransferInEmailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfirmTransferInEmailResponse> ConfirmTransferInEmailWithOptionsAsync(ConfirmTransferInEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmTransferInEmail",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmTransferInEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfirmTransferInEmailResponse ConfirmTransferInEmail(ConfirmTransferInEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmTransferInEmailWithOptions(request, runtime);
        }

        public async Task<ConfirmTransferInEmailResponse> ConfirmTransferInEmailAsync(ConfirmTransferInEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmTransferInEmailWithOptionsAsync(request, runtime);
        }

        public DeleteEmailVerificationResponse DeleteEmailVerificationWithOptions(DeleteEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEmailVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEmailVerificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEmailVerificationResponse> DeleteEmailVerificationWithOptionsAsync(DeleteEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEmailVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEmailVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEmailVerificationResponse DeleteEmailVerification(DeleteEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEmailVerificationWithOptions(request, runtime);
        }

        public async Task<DeleteEmailVerificationResponse> DeleteEmailVerificationAsync(DeleteEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEmailVerificationWithOptionsAsync(request, runtime);
        }

        public DeleteRegistrantProfileResponse DeleteRegistrantProfileWithOptions(DeleteRegistrantProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRegistrantProfile",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRegistrantProfileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRegistrantProfileResponse> DeleteRegistrantProfileWithOptionsAsync(DeleteRegistrantProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRegistrantProfile",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRegistrantProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRegistrantProfileResponse DeleteRegistrantProfile(DeleteRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRegistrantProfileWithOptions(request, runtime);
        }

        public async Task<DeleteRegistrantProfileResponse> DeleteRegistrantProfileAsync(DeleteRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRegistrantProfileWithOptionsAsync(request, runtime);
        }

        public EmailVerifiedResponse EmailVerifiedWithOptions(EmailVerifiedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EmailVerified",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EmailVerifiedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EmailVerifiedResponse> EmailVerifiedWithOptionsAsync(EmailVerifiedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EmailVerified",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EmailVerifiedResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EmailVerifiedResponse EmailVerified(EmailVerifiedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EmailVerifiedWithOptions(request, runtime);
        }

        public async Task<EmailVerifiedResponse> EmailVerifiedAsync(EmailVerifiedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EmailVerifiedWithOptionsAsync(request, runtime);
        }

        public FuzzyMatchDomainSensitiveWordResponse FuzzyMatchDomainSensitiveWordWithOptions(FuzzyMatchDomainSensitiveWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FuzzyMatchDomainSensitiveWord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FuzzyMatchDomainSensitiveWordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<FuzzyMatchDomainSensitiveWordResponse> FuzzyMatchDomainSensitiveWordWithOptionsAsync(FuzzyMatchDomainSensitiveWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FuzzyMatchDomainSensitiveWord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FuzzyMatchDomainSensitiveWordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public FuzzyMatchDomainSensitiveWordResponse FuzzyMatchDomainSensitiveWord(FuzzyMatchDomainSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FuzzyMatchDomainSensitiveWordWithOptions(request, runtime);
        }

        public async Task<FuzzyMatchDomainSensitiveWordResponse> FuzzyMatchDomainSensitiveWordAsync(FuzzyMatchDomainSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FuzzyMatchDomainSensitiveWordWithOptionsAsync(request, runtime);
        }

        public ListEmailVerificationResponse ListEmailVerificationWithOptions(ListEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginCreateTime))
            {
                query["BeginCreateTime"] = request.BeginCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationStatus))
            {
                query["VerificationStatus"] = request.VerificationStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEmailVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmailVerificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEmailVerificationResponse> ListEmailVerificationWithOptionsAsync(ListEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginCreateTime))
            {
                query["BeginCreateTime"] = request.BeginCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerificationStatus))
            {
                query["VerificationStatus"] = request.VerificationStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEmailVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmailVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListEmailVerificationResponse ListEmailVerification(ListEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEmailVerificationWithOptions(request, runtime);
        }

        public async Task<ListEmailVerificationResponse> ListEmailVerificationAsync(ListEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEmailVerificationWithOptionsAsync(request, runtime);
        }

        public LookupTmchNoticeResponse LookupTmchNoticeWithOptions(LookupTmchNoticeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClaimKey))
            {
                query["ClaimKey"] = request.ClaimKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LookupTmchNotice",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LookupTmchNoticeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<LookupTmchNoticeResponse> LookupTmchNoticeWithOptionsAsync(LookupTmchNoticeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClaimKey))
            {
                query["ClaimKey"] = request.ClaimKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LookupTmchNotice",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LookupTmchNoticeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public LookupTmchNoticeResponse LookupTmchNotice(LookupTmchNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LookupTmchNoticeWithOptions(request, runtime);
        }

        public async Task<LookupTmchNoticeResponse> LookupTmchNoticeAsync(LookupTmchNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LookupTmchNoticeWithOptionsAsync(request, runtime);
        }

        public PollTaskResultResponse PollTaskResultWithOptions(PollTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskNo))
            {
                query["TaskNo"] = request.TaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskResultStatus))
            {
                query["TaskResultStatus"] = request.TaskResultStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PollTaskResult",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PollTaskResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PollTaskResultResponse> PollTaskResultWithOptionsAsync(PollTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskNo))
            {
                query["TaskNo"] = request.TaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskResultStatus))
            {
                query["TaskResultStatus"] = request.TaskResultStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PollTaskResult",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PollTaskResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PollTaskResultResponse PollTaskResult(PollTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PollTaskResultWithOptions(request, runtime);
        }

        public async Task<PollTaskResultResponse> PollTaskResultAsync(PollTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PollTaskResultWithOptionsAsync(request, runtime);
        }

        public QueryArtExtensionResponse QueryArtExtensionWithOptions(QueryArtExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryArtExtension",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryArtExtensionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryArtExtensionResponse> QueryArtExtensionWithOptionsAsync(QueryArtExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryArtExtension",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryArtExtensionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryArtExtensionResponse QueryArtExtension(QueryArtExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryArtExtensionWithOptions(request, runtime);
        }

        public async Task<QueryArtExtensionResponse> QueryArtExtensionAsync(QueryArtExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryArtExtensionWithOptionsAsync(request, runtime);
        }

        public QueryChangeLogListResponse QueryChangeLogListWithOptions(QueryChangeLogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChangeLogList",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChangeLogListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryChangeLogListResponse> QueryChangeLogListWithOptionsAsync(QueryChangeLogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryChangeLogList",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryChangeLogListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryChangeLogListResponse QueryChangeLogList(QueryChangeLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryChangeLogListWithOptions(request, runtime);
        }

        public async Task<QueryChangeLogListResponse> QueryChangeLogListAsync(QueryChangeLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryChangeLogListWithOptionsAsync(request, runtime);
        }

        public QueryContactInfoResponse QueryContactInfoWithOptions(QueryContactInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryContactInfo",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContactInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryContactInfoResponse> QueryContactInfoWithOptionsAsync(QueryContactInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryContactInfo",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContactInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryContactInfoResponse QueryContactInfo(QueryContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryContactInfoWithOptions(request, runtime);
        }

        public async Task<QueryContactInfoResponse> QueryContactInfoAsync(QueryContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryContactInfoWithOptionsAsync(request, runtime);
        }

        public QueryDSRecordResponse QueryDSRecordWithOptions(QueryDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDSRecord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDSRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDSRecordResponse> QueryDSRecordWithOptionsAsync(QueryDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDSRecord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDSRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDSRecordResponse QueryDSRecord(QueryDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDSRecordWithOptions(request, runtime);
        }

        public async Task<QueryDSRecordResponse> QueryDSRecordAsync(QueryDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDSRecordWithOptionsAsync(request, runtime);
        }

        public QueryDnsHostResponse QueryDnsHostWithOptions(QueryDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDnsHost",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDnsHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDnsHostResponse> QueryDnsHostWithOptionsAsync(QueryDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDnsHost",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDnsHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDnsHostResponse QueryDnsHost(QueryDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDnsHostWithOptions(request, runtime);
        }

        public async Task<QueryDnsHostResponse> QueryDnsHostAsync(QueryDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDnsHostWithOptionsAsync(request, runtime);
        }

        public QueryDomainByDomainNameResponse QueryDomainByDomainNameWithOptions(QueryDomainByDomainNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainByDomainName",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainByDomainNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDomainByDomainNameResponse> QueryDomainByDomainNameWithOptionsAsync(QueryDomainByDomainNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainByDomainName",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainByDomainNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDomainByDomainNameResponse QueryDomainByDomainName(QueryDomainByDomainNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainByDomainNameWithOptions(request, runtime);
        }

        public async Task<QueryDomainByDomainNameResponse> QueryDomainByDomainNameAsync(QueryDomainByDomainNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainByDomainNameWithOptionsAsync(request, runtime);
        }

        public QueryDomainByInstanceIdResponse QueryDomainByInstanceIdWithOptions(QueryDomainByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainByInstanceId",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainByInstanceIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDomainByInstanceIdResponse> QueryDomainByInstanceIdWithOptionsAsync(QueryDomainByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainByInstanceId",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainByInstanceIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDomainByInstanceIdResponse QueryDomainByInstanceId(QueryDomainByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainByInstanceIdWithOptions(request, runtime);
        }

        public async Task<QueryDomainByInstanceIdResponse> QueryDomainByInstanceIdAsync(QueryDomainByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainByInstanceIdWithOptionsAsync(request, runtime);
        }

        public QueryDomainListResponse QueryDomainListWithOptions(QueryDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndExpirationDate))
            {
                query["EndExpirationDate"] = request.EndExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndRegistrationDate))
            {
                query["EndRegistrationDate"] = request.EndRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByType))
            {
                query["OrderByType"] = request.OrderByType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderKeyType))
            {
                query["OrderKeyType"] = request.OrderKeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDomainType))
            {
                query["ProductDomainType"] = request.ProductDomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartExpirationDate))
            {
                query["StartExpirationDate"] = request.StartExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRegistrationDate))
            {
                query["StartRegistrationDate"] = request.StartRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainList",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDomainListResponse> QueryDomainListWithOptionsAsync(QueryDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndExpirationDate))
            {
                query["EndExpirationDate"] = request.EndExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndRegistrationDate))
            {
                query["EndRegistrationDate"] = request.EndRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByType))
            {
                query["OrderByType"] = request.OrderByType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderKeyType))
            {
                query["OrderKeyType"] = request.OrderKeyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDomainType))
            {
                query["ProductDomainType"] = request.ProductDomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["QueryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartExpirationDate))
            {
                query["StartExpirationDate"] = request.StartExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRegistrationDate))
            {
                query["StartRegistrationDate"] = request.StartRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainList",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDomainListResponse QueryDomainList(QueryDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainListWithOptions(request, runtime);
        }

        public async Task<QueryDomainListResponse> QueryDomainListAsync(QueryDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainListWithOptionsAsync(request, runtime);
        }

        public QueryDomainRealNameVerificationInfoResponse QueryDomainRealNameVerificationInfoWithOptions(QueryDomainRealNameVerificationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchImage))
            {
                query["FetchImage"] = request.FetchImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainRealNameVerificationInfo",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainRealNameVerificationInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryDomainRealNameVerificationInfoResponse> QueryDomainRealNameVerificationInfoWithOptionsAsync(QueryDomainRealNameVerificationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchImage))
            {
                query["FetchImage"] = request.FetchImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainRealNameVerificationInfo",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainRealNameVerificationInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryDomainRealNameVerificationInfoResponse QueryDomainRealNameVerificationInfo(QueryDomainRealNameVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainRealNameVerificationInfoWithOptions(request, runtime);
        }

        public async Task<QueryDomainRealNameVerificationInfoResponse> QueryDomainRealNameVerificationInfoAsync(QueryDomainRealNameVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainRealNameVerificationInfoWithOptionsAsync(request, runtime);
        }

        public QueryEnsAssociationResponse QueryEnsAssociationWithOptions(QueryEnsAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEnsAssociation",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnsAssociationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryEnsAssociationResponse> QueryEnsAssociationWithOptionsAsync(QueryEnsAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEnsAssociation",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEnsAssociationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryEnsAssociationResponse QueryEnsAssociation(QueryEnsAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEnsAssociationWithOptions(request, runtime);
        }

        public async Task<QueryEnsAssociationResponse> QueryEnsAssociationAsync(QueryEnsAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEnsAssociationWithOptionsAsync(request, runtime);
        }

        public QueryFailReasonForDomainRealNameVerificationResponse QueryFailReasonForDomainRealNameVerificationWithOptions(QueryFailReasonForDomainRealNameVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealNameVerificationAction))
            {
                query["RealNameVerificationAction"] = request.RealNameVerificationAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFailReasonForDomainRealNameVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFailReasonForDomainRealNameVerificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFailReasonForDomainRealNameVerificationResponse> QueryFailReasonForDomainRealNameVerificationWithOptionsAsync(QueryFailReasonForDomainRealNameVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealNameVerificationAction))
            {
                query["RealNameVerificationAction"] = request.RealNameVerificationAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFailReasonForDomainRealNameVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFailReasonForDomainRealNameVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFailReasonForDomainRealNameVerificationResponse QueryFailReasonForDomainRealNameVerification(QueryFailReasonForDomainRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFailReasonForDomainRealNameVerificationWithOptions(request, runtime);
        }

        public async Task<QueryFailReasonForDomainRealNameVerificationResponse> QueryFailReasonForDomainRealNameVerificationAsync(QueryFailReasonForDomainRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFailReasonForDomainRealNameVerificationWithOptionsAsync(request, runtime);
        }

        public QueryFailReasonForRegistrantProfileRealNameVerificationResponse QueryFailReasonForRegistrantProfileRealNameVerificationWithOptions(QueryFailReasonForRegistrantProfileRealNameVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileID))
            {
                query["RegistrantProfileID"] = request.RegistrantProfileID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFailReasonForRegistrantProfileRealNameVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFailReasonForRegistrantProfileRealNameVerificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryFailReasonForRegistrantProfileRealNameVerificationResponse> QueryFailReasonForRegistrantProfileRealNameVerificationWithOptionsAsync(QueryFailReasonForRegistrantProfileRealNameVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileID))
            {
                query["RegistrantProfileID"] = request.RegistrantProfileID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryFailReasonForRegistrantProfileRealNameVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFailReasonForRegistrantProfileRealNameVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryFailReasonForRegistrantProfileRealNameVerificationResponse QueryFailReasonForRegistrantProfileRealNameVerification(QueryFailReasonForRegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFailReasonForRegistrantProfileRealNameVerificationWithOptions(request, runtime);
        }

        public async Task<QueryFailReasonForRegistrantProfileRealNameVerificationResponse> QueryFailReasonForRegistrantProfileRealNameVerificationAsync(QueryFailReasonForRegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFailReasonForRegistrantProfileRealNameVerificationWithOptionsAsync(request, runtime);
        }

        public QueryLocalEnsAssociationResponse QueryLocalEnsAssociationWithOptions(QueryLocalEnsAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLocalEnsAssociation",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLocalEnsAssociationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryLocalEnsAssociationResponse> QueryLocalEnsAssociationWithOptionsAsync(QueryLocalEnsAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryLocalEnsAssociation",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryLocalEnsAssociationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryLocalEnsAssociationResponse QueryLocalEnsAssociation(QueryLocalEnsAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLocalEnsAssociationWithOptions(request, runtime);
        }

        public async Task<QueryLocalEnsAssociationResponse> QueryLocalEnsAssociationAsync(QueryLocalEnsAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLocalEnsAssociationWithOptionsAsync(request, runtime);
        }

        public QueryRegistrantProfileRealNameVerificationInfoResponse QueryRegistrantProfileRealNameVerificationInfoWithOptions(QueryRegistrantProfileRealNameVerificationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchImage))
            {
                query["FetchImage"] = request.FetchImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRegistrantProfileRealNameVerificationInfo",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRegistrantProfileRealNameVerificationInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRegistrantProfileRealNameVerificationInfoResponse> QueryRegistrantProfileRealNameVerificationInfoWithOptionsAsync(QueryRegistrantProfileRealNameVerificationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchImage))
            {
                query["FetchImage"] = request.FetchImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRegistrantProfileRealNameVerificationInfo",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRegistrantProfileRealNameVerificationInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRegistrantProfileRealNameVerificationInfoResponse QueryRegistrantProfileRealNameVerificationInfo(QueryRegistrantProfileRealNameVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRegistrantProfileRealNameVerificationInfoWithOptions(request, runtime);
        }

        public async Task<QueryRegistrantProfileRealNameVerificationInfoResponse> QueryRegistrantProfileRealNameVerificationInfoAsync(QueryRegistrantProfileRealNameVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRegistrantProfileRealNameVerificationInfoWithOptionsAsync(request, runtime);
        }

        public QueryRegistrantProfilesResponse QueryRegistrantProfilesWithOptions(QueryRegistrantProfilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRegistrantProfile))
            {
                query["DefaultRegistrantProfile"] = request.DefaultRegistrantProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealNameStatus))
            {
                query["RealNameStatus"] = request.RealNameStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantOrganization))
            {
                query["RegistrantOrganization"] = request.RegistrantOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileType))
            {
                query["RegistrantProfileType"] = request.RegistrantProfileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantType))
            {
                query["RegistrantType"] = request.RegistrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRegistrantProfiles",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRegistrantProfilesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryRegistrantProfilesResponse> QueryRegistrantProfilesWithOptionsAsync(QueryRegistrantProfilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRegistrantProfile))
            {
                query["DefaultRegistrantProfile"] = request.DefaultRegistrantProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealNameStatus))
            {
                query["RealNameStatus"] = request.RealNameStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantOrganization))
            {
                query["RegistrantOrganization"] = request.RegistrantOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileType))
            {
                query["RegistrantProfileType"] = request.RegistrantProfileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantType))
            {
                query["RegistrantType"] = request.RegistrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRegistrantProfiles",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRegistrantProfilesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryRegistrantProfilesResponse QueryRegistrantProfiles(QueryRegistrantProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRegistrantProfilesWithOptions(request, runtime);
        }

        public async Task<QueryRegistrantProfilesResponse> QueryRegistrantProfilesAsync(QueryRegistrantProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRegistrantProfilesWithOptionsAsync(request, runtime);
        }

        public QueryTaskDetailHistoryResponse QueryTaskDetailHistoryWithOptions(QueryTaskDetailHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNameCursor))
            {
                query["DomainNameCursor"] = request.DomainNameCursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDetailNoCursor))
            {
                query["TaskDetailNoCursor"] = request.TaskDetailNoCursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskNo))
            {
                query["TaskNo"] = request.TaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskDetailHistory",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskDetailHistoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTaskDetailHistoryResponse> QueryTaskDetailHistoryWithOptionsAsync(QueryTaskDetailHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNameCursor))
            {
                query["DomainNameCursor"] = request.DomainNameCursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDetailNoCursor))
            {
                query["TaskDetailNoCursor"] = request.TaskDetailNoCursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskNo))
            {
                query["TaskNo"] = request.TaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskDetailHistory",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskDetailHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTaskDetailHistoryResponse QueryTaskDetailHistory(QueryTaskDetailHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskDetailHistoryWithOptions(request, runtime);
        }

        public async Task<QueryTaskDetailHistoryResponse> QueryTaskDetailHistoryAsync(QueryTaskDetailHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskDetailHistoryWithOptionsAsync(request, runtime);
        }

        public QueryTaskDetailListResponse QueryTaskDetailListWithOptions(QueryTaskDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskNo))
            {
                query["TaskNo"] = request.TaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskDetailList",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskDetailListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTaskDetailListResponse> QueryTaskDetailListWithOptionsAsync(QueryTaskDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskNo))
            {
                query["TaskNo"] = request.TaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskDetailList",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskDetailListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTaskDetailListResponse QueryTaskDetailList(QueryTaskDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskDetailListWithOptions(request, runtime);
        }

        public async Task<QueryTaskDetailListResponse> QueryTaskDetailListAsync(QueryTaskDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskDetailListWithOptionsAsync(request, runtime);
        }

        public QueryTaskInfoHistoryResponse QueryTaskInfoHistoryWithOptions(QueryTaskInfoHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginCreateTime))
            {
                query["BeginCreateTime"] = request.BeginCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeCursor))
            {
                query["CreateTimeCursor"] = request.CreateTimeCursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskNoCursor))
            {
                query["TaskNoCursor"] = request.TaskNoCursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskInfoHistory",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskInfoHistoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTaskInfoHistoryResponse> QueryTaskInfoHistoryWithOptionsAsync(QueryTaskInfoHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginCreateTime))
            {
                query["BeginCreateTime"] = request.BeginCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimeCursor))
            {
                query["CreateTimeCursor"] = request.CreateTimeCursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskNoCursor))
            {
                query["TaskNoCursor"] = request.TaskNoCursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskInfoHistory",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskInfoHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTaskInfoHistoryResponse QueryTaskInfoHistory(QueryTaskInfoHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskInfoHistoryWithOptions(request, runtime);
        }

        public async Task<QueryTaskInfoHistoryResponse> QueryTaskInfoHistoryAsync(QueryTaskInfoHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskInfoHistoryWithOptionsAsync(request, runtime);
        }

        public QueryTaskListResponse QueryTaskListWithOptions(QueryTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginCreateTime))
            {
                query["BeginCreateTime"] = request.BeginCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskList",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTaskListResponse> QueryTaskListWithOptionsAsync(QueryTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginCreateTime))
            {
                query["BeginCreateTime"] = request.BeginCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCreateTime))
            {
                query["EndCreateTime"] = request.EndCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTaskList",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTaskListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTaskListResponse QueryTaskList(QueryTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskListWithOptions(request, runtime);
        }

        public async Task<QueryTaskListResponse> QueryTaskListAsync(QueryTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskListWithOptionsAsync(request, runtime);
        }

        public QueryTransferInByInstanceIdResponse QueryTransferInByInstanceIdWithOptions(QueryTransferInByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTransferInByInstanceId",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTransferInByInstanceIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTransferInByInstanceIdResponse> QueryTransferInByInstanceIdWithOptionsAsync(QueryTransferInByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTransferInByInstanceId",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTransferInByInstanceIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTransferInByInstanceIdResponse QueryTransferInByInstanceId(QueryTransferInByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTransferInByInstanceIdWithOptions(request, runtime);
        }

        public async Task<QueryTransferInByInstanceIdResponse> QueryTransferInByInstanceIdAsync(QueryTransferInByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTransferInByInstanceIdWithOptionsAsync(request, runtime);
        }

        public QueryTransferInListResponse QueryTransferInListWithOptions(QueryTransferInListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimpleTransferInStatus))
            {
                query["SimpleTransferInStatus"] = request.SimpleTransferInStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmissionEndDate))
            {
                query["SubmissionEndDate"] = request.SubmissionEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmissionStartDate))
            {
                query["SubmissionStartDate"] = request.SubmissionStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTransferInList",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTransferInListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTransferInListResponse> QueryTransferInListWithOptionsAsync(QueryTransferInListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SimpleTransferInStatus))
            {
                query["SimpleTransferInStatus"] = request.SimpleTransferInStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmissionEndDate))
            {
                query["SubmissionEndDate"] = request.SubmissionEndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmissionStartDate))
            {
                query["SubmissionStartDate"] = request.SubmissionStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTransferInList",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTransferInListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTransferInListResponse QueryTransferInList(QueryTransferInListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTransferInListWithOptions(request, runtime);
        }

        public async Task<QueryTransferInListResponse> QueryTransferInListAsync(QueryTransferInListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTransferInListWithOptionsAsync(request, runtime);
        }

        public QueryTransferOutInfoResponse QueryTransferOutInfoWithOptions(QueryTransferOutInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTransferOutInfo",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTransferOutInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryTransferOutInfoResponse> QueryTransferOutInfoWithOptionsAsync(QueryTransferOutInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTransferOutInfo",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTransferOutInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryTransferOutInfoResponse QueryTransferOutInfo(QueryTransferOutInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTransferOutInfoWithOptions(request, runtime);
        }

        public async Task<QueryTransferOutInfoResponse> QueryTransferOutInfoAsync(QueryTransferOutInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTransferOutInfoWithOptionsAsync(request, runtime);
        }

        public RegistrantProfileRealNameVerificationResponse RegistrantProfileRealNameVerificationWithOptions(RegistrantProfileRealNameVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredentialNo))
            {
                query["IdentityCredentialNo"] = request.IdentityCredentialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredentialType))
            {
                query["IdentityCredentialType"] = request.IdentityCredentialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileID))
            {
                query["RegistrantProfileID"] = request.RegistrantProfileID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredential))
            {
                body["IdentityCredential"] = request.IdentityCredential;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegistrantProfileRealNameVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegistrantProfileRealNameVerificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegistrantProfileRealNameVerificationResponse> RegistrantProfileRealNameVerificationWithOptionsAsync(RegistrantProfileRealNameVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredentialNo))
            {
                query["IdentityCredentialNo"] = request.IdentityCredentialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredentialType))
            {
                query["IdentityCredentialType"] = request.IdentityCredentialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileID))
            {
                query["RegistrantProfileID"] = request.RegistrantProfileID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredential))
            {
                body["IdentityCredential"] = request.IdentityCredential;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegistrantProfileRealNameVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegistrantProfileRealNameVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegistrantProfileRealNameVerificationResponse RegistrantProfileRealNameVerification(RegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegistrantProfileRealNameVerificationWithOptions(request, runtime);
        }

        public async Task<RegistrantProfileRealNameVerificationResponse> RegistrantProfileRealNameVerificationAsync(RegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegistrantProfileRealNameVerificationWithOptionsAsync(request, runtime);
        }

        public ResendEmailVerificationResponse ResendEmailVerificationWithOptions(ResendEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResendEmailVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResendEmailVerificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResendEmailVerificationResponse> ResendEmailVerificationWithOptionsAsync(ResendEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResendEmailVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResendEmailVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResendEmailVerificationResponse ResendEmailVerification(ResendEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResendEmailVerificationWithOptions(request, runtime);
        }

        public async Task<ResendEmailVerificationResponse> ResendEmailVerificationAsync(ResendEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResendEmailVerificationWithOptionsAsync(request, runtime);
        }

        public SaveBatchTaskForCreatingOrderActivateResponse SaveBatchTaskForCreatingOrderActivateWithOptions(SaveBatchTaskForCreatingOrderActivateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderActivateParam))
            {
                query["OrderActivateParam"] = request.OrderActivateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForCreatingOrderActivate",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderActivateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveBatchTaskForCreatingOrderActivateResponse> SaveBatchTaskForCreatingOrderActivateWithOptionsAsync(SaveBatchTaskForCreatingOrderActivateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderActivateParam))
            {
                query["OrderActivateParam"] = request.OrderActivateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForCreatingOrderActivate",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderActivateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveBatchTaskForCreatingOrderActivateResponse SaveBatchTaskForCreatingOrderActivate(SaveBatchTaskForCreatingOrderActivateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForCreatingOrderActivateWithOptions(request, runtime);
        }

        public async Task<SaveBatchTaskForCreatingOrderActivateResponse> SaveBatchTaskForCreatingOrderActivateAsync(SaveBatchTaskForCreatingOrderActivateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForCreatingOrderActivateWithOptionsAsync(request, runtime);
        }

        public SaveBatchTaskForCreatingOrderRedeemResponse SaveBatchTaskForCreatingOrderRedeemWithOptions(SaveBatchTaskForCreatingOrderRedeemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderRedeemParam))
            {
                query["OrderRedeemParam"] = request.OrderRedeemParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForCreatingOrderRedeem",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderRedeemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveBatchTaskForCreatingOrderRedeemResponse> SaveBatchTaskForCreatingOrderRedeemWithOptionsAsync(SaveBatchTaskForCreatingOrderRedeemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderRedeemParam))
            {
                query["OrderRedeemParam"] = request.OrderRedeemParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForCreatingOrderRedeem",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderRedeemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveBatchTaskForCreatingOrderRedeemResponse SaveBatchTaskForCreatingOrderRedeem(SaveBatchTaskForCreatingOrderRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForCreatingOrderRedeemWithOptions(request, runtime);
        }

        public async Task<SaveBatchTaskForCreatingOrderRedeemResponse> SaveBatchTaskForCreatingOrderRedeemAsync(SaveBatchTaskForCreatingOrderRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForCreatingOrderRedeemWithOptionsAsync(request, runtime);
        }

        public SaveBatchTaskForCreatingOrderRenewResponse SaveBatchTaskForCreatingOrderRenewWithOptions(SaveBatchTaskForCreatingOrderRenewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderRenewParam))
            {
                query["OrderRenewParam"] = request.OrderRenewParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForCreatingOrderRenew",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderRenewResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveBatchTaskForCreatingOrderRenewResponse> SaveBatchTaskForCreatingOrderRenewWithOptionsAsync(SaveBatchTaskForCreatingOrderRenewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderRenewParam))
            {
                query["OrderRenewParam"] = request.OrderRenewParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForCreatingOrderRenew",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderRenewResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveBatchTaskForCreatingOrderRenewResponse SaveBatchTaskForCreatingOrderRenew(SaveBatchTaskForCreatingOrderRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForCreatingOrderRenewWithOptions(request, runtime);
        }

        public async Task<SaveBatchTaskForCreatingOrderRenewResponse> SaveBatchTaskForCreatingOrderRenewAsync(SaveBatchTaskForCreatingOrderRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForCreatingOrderRenewWithOptionsAsync(request, runtime);
        }

        public SaveBatchTaskForCreatingOrderTransferResponse SaveBatchTaskForCreatingOrderTransferWithOptions(SaveBatchTaskForCreatingOrderTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderTransferParam))
            {
                query["OrderTransferParam"] = request.OrderTransferParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForCreatingOrderTransfer",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderTransferResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveBatchTaskForCreatingOrderTransferResponse> SaveBatchTaskForCreatingOrderTransferWithOptionsAsync(SaveBatchTaskForCreatingOrderTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderTransferParam))
            {
                query["OrderTransferParam"] = request.OrderTransferParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForCreatingOrderTransfer",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderTransferResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveBatchTaskForCreatingOrderTransferResponse SaveBatchTaskForCreatingOrderTransfer(SaveBatchTaskForCreatingOrderTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForCreatingOrderTransferWithOptions(request, runtime);
        }

        public async Task<SaveBatchTaskForCreatingOrderTransferResponse> SaveBatchTaskForCreatingOrderTransferAsync(SaveBatchTaskForCreatingOrderTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForCreatingOrderTransferWithOptionsAsync(request, runtime);
        }

        public SaveBatchTaskForDomainNameProxyServiceResponse SaveBatchTaskForDomainNameProxyServiceWithOptions(SaveBatchTaskForDomainNameProxyServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForDomainNameProxyService",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForDomainNameProxyServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveBatchTaskForDomainNameProxyServiceResponse> SaveBatchTaskForDomainNameProxyServiceWithOptionsAsync(SaveBatchTaskForDomainNameProxyServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForDomainNameProxyService",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForDomainNameProxyServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveBatchTaskForDomainNameProxyServiceResponse SaveBatchTaskForDomainNameProxyService(SaveBatchTaskForDomainNameProxyServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForDomainNameProxyServiceWithOptions(request, runtime);
        }

        public async Task<SaveBatchTaskForDomainNameProxyServiceResponse> SaveBatchTaskForDomainNameProxyServiceAsync(SaveBatchTaskForDomainNameProxyServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForDomainNameProxyServiceWithOptionsAsync(request, runtime);
        }

        public SaveBatchTaskForModifyingDomainDnsResponse SaveBatchTaskForModifyingDomainDnsWithOptions(SaveBatchTaskForModifyingDomainDnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunDns))
            {
                query["AliyunDns"] = request.AliyunDns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNameServer))
            {
                query["DomainNameServer"] = request.DomainNameServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForModifyingDomainDns",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForModifyingDomainDnsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveBatchTaskForModifyingDomainDnsResponse> SaveBatchTaskForModifyingDomainDnsWithOptionsAsync(SaveBatchTaskForModifyingDomainDnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunDns))
            {
                query["AliyunDns"] = request.AliyunDns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNameServer))
            {
                query["DomainNameServer"] = request.DomainNameServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForModifyingDomainDns",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForModifyingDomainDnsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveBatchTaskForModifyingDomainDnsResponse SaveBatchTaskForModifyingDomainDns(SaveBatchTaskForModifyingDomainDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForModifyingDomainDnsWithOptions(request, runtime);
        }

        public async Task<SaveBatchTaskForModifyingDomainDnsResponse> SaveBatchTaskForModifyingDomainDnsAsync(SaveBatchTaskForModifyingDomainDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForModifyingDomainDnsWithOptionsAsync(request, runtime);
        }

        public SaveBatchTaskForReserveDropListDomainResponse SaveBatchTaskForReserveDropListDomainWithOptions(SaveBatchTaskForReserveDropListDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domains))
            {
                query["Domains"] = request.Domains;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForReserveDropListDomain",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForReserveDropListDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveBatchTaskForReserveDropListDomainResponse> SaveBatchTaskForReserveDropListDomainWithOptionsAsync(SaveBatchTaskForReserveDropListDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domains))
            {
                query["Domains"] = request.Domains;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForReserveDropListDomain",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForReserveDropListDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveBatchTaskForReserveDropListDomainResponse SaveBatchTaskForReserveDropListDomain(SaveBatchTaskForReserveDropListDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForReserveDropListDomainWithOptions(request, runtime);
        }

        public async Task<SaveBatchTaskForReserveDropListDomainResponse> SaveBatchTaskForReserveDropListDomainAsync(SaveBatchTaskForReserveDropListDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForReserveDropListDomainWithOptionsAsync(request, runtime);
        }

        public SaveBatchTaskForTransferProhibitionLockResponse SaveBatchTaskForTransferProhibitionLockWithOptions(SaveBatchTaskForTransferProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForTransferProhibitionLock",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForTransferProhibitionLockResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveBatchTaskForTransferProhibitionLockResponse> SaveBatchTaskForTransferProhibitionLockWithOptionsAsync(SaveBatchTaskForTransferProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForTransferProhibitionLock",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForTransferProhibitionLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveBatchTaskForTransferProhibitionLockResponse SaveBatchTaskForTransferProhibitionLock(SaveBatchTaskForTransferProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForTransferProhibitionLockWithOptions(request, runtime);
        }

        public async Task<SaveBatchTaskForTransferProhibitionLockResponse> SaveBatchTaskForTransferProhibitionLockAsync(SaveBatchTaskForTransferProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForTransferProhibitionLockWithOptionsAsync(request, runtime);
        }

        public SaveBatchTaskForUpdateProhibitionLockResponse SaveBatchTaskForUpdateProhibitionLockWithOptions(SaveBatchTaskForUpdateProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForUpdateProhibitionLock",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdateProhibitionLockResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveBatchTaskForUpdateProhibitionLockResponse> SaveBatchTaskForUpdateProhibitionLockWithOptionsAsync(SaveBatchTaskForUpdateProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForUpdateProhibitionLock",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdateProhibitionLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveBatchTaskForUpdateProhibitionLockResponse SaveBatchTaskForUpdateProhibitionLock(SaveBatchTaskForUpdateProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForUpdateProhibitionLockWithOptions(request, runtime);
        }

        public async Task<SaveBatchTaskForUpdateProhibitionLockResponse> SaveBatchTaskForUpdateProhibitionLockAsync(SaveBatchTaskForUpdateProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForUpdateProhibitionLockWithOptionsAsync(request, runtime);
        }

        public SaveBatchTaskForUpdatingContactInfoResponse SaveBatchTaskForUpdatingContactInfoWithOptions(SaveBatchTaskForUpdatingContactInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddTransferLock))
            {
                query["AddTransferLock"] = request.AddTransferLock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForUpdatingContactInfo",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdatingContactInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveBatchTaskForUpdatingContactInfoResponse> SaveBatchTaskForUpdatingContactInfoWithOptionsAsync(SaveBatchTaskForUpdatingContactInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddTransferLock))
            {
                query["AddTransferLock"] = request.AddTransferLock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForUpdatingContactInfo",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdatingContactInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveBatchTaskForUpdatingContactInfoResponse SaveBatchTaskForUpdatingContactInfo(SaveBatchTaskForUpdatingContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForUpdatingContactInfoWithOptions(request, runtime);
        }

        public async Task<SaveBatchTaskForUpdatingContactInfoResponse> SaveBatchTaskForUpdatingContactInfoAsync(SaveBatchTaskForUpdatingContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForUpdatingContactInfoWithOptionsAsync(request, runtime);
        }

        public SaveBatchTaskForUpdatingContactInfoByNewContactResponse SaveBatchTaskForUpdatingContactInfoByNewContactWithOptions(SaveBatchTaskForUpdatingContactInfoByNewContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostalCode))
            {
                query["PostalCode"] = request.PostalCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantName))
            {
                query["RegistrantName"] = request.RegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantOrganization))
            {
                query["RegistrantOrganization"] = request.RegistrantOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelArea))
            {
                query["TelArea"] = request.TelArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelExt))
            {
                query["TelExt"] = request.TelExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferOutProhibited))
            {
                query["TransferOutProhibited"] = request.TransferOutProhibited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForUpdatingContactInfoByNewContact",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdatingContactInfoByNewContactResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveBatchTaskForUpdatingContactInfoByNewContactResponse> SaveBatchTaskForUpdatingContactInfoByNewContactWithOptionsAsync(SaveBatchTaskForUpdatingContactInfoByNewContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostalCode))
            {
                query["PostalCode"] = request.PostalCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantName))
            {
                query["RegistrantName"] = request.RegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantOrganization))
            {
                query["RegistrantOrganization"] = request.RegistrantOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelArea))
            {
                query["TelArea"] = request.TelArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelExt))
            {
                query["TelExt"] = request.TelExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferOutProhibited))
            {
                query["TransferOutProhibited"] = request.TransferOutProhibited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForUpdatingContactInfoByNewContact",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdatingContactInfoByNewContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveBatchTaskForUpdatingContactInfoByNewContactResponse SaveBatchTaskForUpdatingContactInfoByNewContact(SaveBatchTaskForUpdatingContactInfoByNewContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForUpdatingContactInfoByNewContactWithOptions(request, runtime);
        }

        public async Task<SaveBatchTaskForUpdatingContactInfoByNewContactResponse> SaveBatchTaskForUpdatingContactInfoByNewContactAsync(SaveBatchTaskForUpdatingContactInfoByNewContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForUpdatingContactInfoByNewContactWithOptionsAsync(request, runtime);
        }

        public SaveRegistrantProfileResponse SaveRegistrantProfileWithOptions(SaveRegistrantProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRegistrantProfile))
            {
                query["DefaultRegistrantProfile"] = request.DefaultRegistrantProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostalCode))
            {
                query["PostalCode"] = request.PostalCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantName))
            {
                query["RegistrantName"] = request.RegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantOrganization))
            {
                query["RegistrantOrganization"] = request.RegistrantOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileType))
            {
                query["RegistrantProfileType"] = request.RegistrantProfileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantType))
            {
                query["RegistrantType"] = request.RegistrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelArea))
            {
                query["TelArea"] = request.TelArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelExt))
            {
                query["TelExt"] = request.TelExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveRegistrantProfile",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveRegistrantProfileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveRegistrantProfileResponse> SaveRegistrantProfileWithOptionsAsync(SaveRegistrantProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRegistrantProfile))
            {
                query["DefaultRegistrantProfile"] = request.DefaultRegistrantProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostalCode))
            {
                query["PostalCode"] = request.PostalCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantName))
            {
                query["RegistrantName"] = request.RegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantOrganization))
            {
                query["RegistrantOrganization"] = request.RegistrantOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileType))
            {
                query["RegistrantProfileType"] = request.RegistrantProfileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantType))
            {
                query["RegistrantType"] = request.RegistrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelArea))
            {
                query["TelArea"] = request.TelArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelExt))
            {
                query["TelExt"] = request.TelExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveRegistrantProfile",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveRegistrantProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveRegistrantProfileResponse SaveRegistrantProfile(SaveRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveRegistrantProfileWithOptions(request, runtime);
        }

        public async Task<SaveRegistrantProfileResponse> SaveRegistrantProfileAsync(SaveRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveRegistrantProfileWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForAddingDSRecordResponse SaveSingleTaskForAddingDSRecordWithOptions(SaveSingleTaskForAddingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigestType))
            {
                query["DigestType"] = request.DigestType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyTag))
            {
                query["KeyTag"] = request.KeyTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForAddingDSRecord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForAddingDSRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForAddingDSRecordResponse> SaveSingleTaskForAddingDSRecordWithOptionsAsync(SaveSingleTaskForAddingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigestType))
            {
                query["DigestType"] = request.DigestType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyTag))
            {
                query["KeyTag"] = request.KeyTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForAddingDSRecord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForAddingDSRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForAddingDSRecordResponse SaveSingleTaskForAddingDSRecord(SaveSingleTaskForAddingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForAddingDSRecordWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForAddingDSRecordResponse> SaveSingleTaskForAddingDSRecordAsync(SaveSingleTaskForAddingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForAddingDSRecordWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForApprovingTransferOutResponse SaveSingleTaskForApprovingTransferOutWithOptions(SaveSingleTaskForApprovingTransferOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForApprovingTransferOut",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForApprovingTransferOutResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForApprovingTransferOutResponse> SaveSingleTaskForApprovingTransferOutWithOptionsAsync(SaveSingleTaskForApprovingTransferOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForApprovingTransferOut",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForApprovingTransferOutResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForApprovingTransferOutResponse SaveSingleTaskForApprovingTransferOut(SaveSingleTaskForApprovingTransferOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForApprovingTransferOutWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForApprovingTransferOutResponse> SaveSingleTaskForApprovingTransferOutAsync(SaveSingleTaskForApprovingTransferOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForApprovingTransferOutWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForAssociatingEnsResponse SaveSingleTaskForAssociatingEnsWithOptions(SaveSingleTaskForAssociatingEnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForAssociatingEns",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForAssociatingEnsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForAssociatingEnsResponse> SaveSingleTaskForAssociatingEnsWithOptionsAsync(SaveSingleTaskForAssociatingEnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForAssociatingEns",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForAssociatingEnsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForAssociatingEnsResponse SaveSingleTaskForAssociatingEns(SaveSingleTaskForAssociatingEnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForAssociatingEnsWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForAssociatingEnsResponse> SaveSingleTaskForAssociatingEnsAsync(SaveSingleTaskForAssociatingEnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForAssociatingEnsWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForCancelingTransferInResponse SaveSingleTaskForCancelingTransferInWithOptions(SaveSingleTaskForCancelingTransferInRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCancelingTransferIn",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCancelingTransferInResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForCancelingTransferInResponse> SaveSingleTaskForCancelingTransferInWithOptionsAsync(SaveSingleTaskForCancelingTransferInRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCancelingTransferIn",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCancelingTransferInResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForCancelingTransferInResponse SaveSingleTaskForCancelingTransferIn(SaveSingleTaskForCancelingTransferInRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCancelingTransferInWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForCancelingTransferInResponse> SaveSingleTaskForCancelingTransferInAsync(SaveSingleTaskForCancelingTransferInRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCancelingTransferInWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForCancelingTransferOutResponse SaveSingleTaskForCancelingTransferOutWithOptions(SaveSingleTaskForCancelingTransferOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCancelingTransferOut",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCancelingTransferOutResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForCancelingTransferOutResponse> SaveSingleTaskForCancelingTransferOutWithOptionsAsync(SaveSingleTaskForCancelingTransferOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCancelingTransferOut",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCancelingTransferOutResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForCancelingTransferOutResponse SaveSingleTaskForCancelingTransferOut(SaveSingleTaskForCancelingTransferOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCancelingTransferOutWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForCancelingTransferOutResponse> SaveSingleTaskForCancelingTransferOutAsync(SaveSingleTaskForCancelingTransferOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCancelingTransferOutWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForCreatingDnsHostResponse SaveSingleTaskForCreatingDnsHostWithOptions(SaveSingleTaskForCreatingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsName))
            {
                query["DnsName"] = request.DnsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCreatingDnsHost",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingDnsHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForCreatingDnsHostResponse> SaveSingleTaskForCreatingDnsHostWithOptionsAsync(SaveSingleTaskForCreatingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsName))
            {
                query["DnsName"] = request.DnsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCreatingDnsHost",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingDnsHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForCreatingDnsHostResponse SaveSingleTaskForCreatingDnsHost(SaveSingleTaskForCreatingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingDnsHostWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForCreatingDnsHostResponse> SaveSingleTaskForCreatingDnsHostAsync(SaveSingleTaskForCreatingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingDnsHostWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForCreatingOrderActivateResponse SaveSingleTaskForCreatingOrderActivateWithOptions(SaveSingleTaskForCreatingOrderActivateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunDns))
            {
                query["AliyunDns"] = request.AliyunDns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dns1))
            {
                query["Dns1"] = request.Dns1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dns2))
            {
                query["Dns2"] = request.Dns2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDomainProxy))
            {
                query["EnableDomainProxy"] = request.EnableDomainProxy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitPremiumActivation))
            {
                query["PermitPremiumActivation"] = request.PermitPremiumActivation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostalCode))
            {
                query["PostalCode"] = request.PostalCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantName))
            {
                query["RegistrantName"] = request.RegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantOrganization))
            {
                query["RegistrantOrganization"] = request.RegistrantOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantType))
            {
                query["RegistrantType"] = request.RegistrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDuration))
            {
                query["SubscriptionDuration"] = request.SubscriptionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelArea))
            {
                query["TelArea"] = request.TelArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelExt))
            {
                query["TelExt"] = request.TelExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkDomainActivation))
            {
                query["TrademarkDomainActivation"] = request.TrademarkDomainActivation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCreatingOrderActivate",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderActivateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForCreatingOrderActivateResponse> SaveSingleTaskForCreatingOrderActivateWithOptionsAsync(SaveSingleTaskForCreatingOrderActivateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunDns))
            {
                query["AliyunDns"] = request.AliyunDns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dns1))
            {
                query["Dns1"] = request.Dns1;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dns2))
            {
                query["Dns2"] = request.Dns2;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableDomainProxy))
            {
                query["EnableDomainProxy"] = request.EnableDomainProxy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitPremiumActivation))
            {
                query["PermitPremiumActivation"] = request.PermitPremiumActivation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostalCode))
            {
                query["PostalCode"] = request.PostalCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantName))
            {
                query["RegistrantName"] = request.RegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantOrganization))
            {
                query["RegistrantOrganization"] = request.RegistrantOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantType))
            {
                query["RegistrantType"] = request.RegistrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDuration))
            {
                query["SubscriptionDuration"] = request.SubscriptionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelArea))
            {
                query["TelArea"] = request.TelArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelExt))
            {
                query["TelExt"] = request.TelExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrademarkDomainActivation))
            {
                query["TrademarkDomainActivation"] = request.TrademarkDomainActivation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCreatingOrderActivate",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderActivateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForCreatingOrderActivateResponse SaveSingleTaskForCreatingOrderActivate(SaveSingleTaskForCreatingOrderActivateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingOrderActivateWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForCreatingOrderActivateResponse> SaveSingleTaskForCreatingOrderActivateAsync(SaveSingleTaskForCreatingOrderActivateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingOrderActivateWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForCreatingOrderRedeemResponse SaveSingleTaskForCreatingOrderRedeemWithOptions(SaveSingleTaskForCreatingOrderRedeemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentExpirationDate))
            {
                query["CurrentExpirationDate"] = request.CurrentExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCreatingOrderRedeem",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderRedeemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForCreatingOrderRedeemResponse> SaveSingleTaskForCreatingOrderRedeemWithOptionsAsync(SaveSingleTaskForCreatingOrderRedeemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentExpirationDate))
            {
                query["CurrentExpirationDate"] = request.CurrentExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCreatingOrderRedeem",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderRedeemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForCreatingOrderRedeemResponse SaveSingleTaskForCreatingOrderRedeem(SaveSingleTaskForCreatingOrderRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingOrderRedeemWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForCreatingOrderRedeemResponse> SaveSingleTaskForCreatingOrderRedeemAsync(SaveSingleTaskForCreatingOrderRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingOrderRedeemWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForCreatingOrderRenewResponse SaveSingleTaskForCreatingOrderRenewWithOptions(SaveSingleTaskForCreatingOrderRenewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentExpirationDate))
            {
                query["CurrentExpirationDate"] = request.CurrentExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDuration))
            {
                query["SubscriptionDuration"] = request.SubscriptionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCreatingOrderRenew",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderRenewResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForCreatingOrderRenewResponse> SaveSingleTaskForCreatingOrderRenewWithOptionsAsync(SaveSingleTaskForCreatingOrderRenewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentExpirationDate))
            {
                query["CurrentExpirationDate"] = request.CurrentExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionDuration))
            {
                query["SubscriptionDuration"] = request.SubscriptionDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCreatingOrderRenew",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderRenewResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForCreatingOrderRenewResponse SaveSingleTaskForCreatingOrderRenew(SaveSingleTaskForCreatingOrderRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingOrderRenewWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForCreatingOrderRenewResponse> SaveSingleTaskForCreatingOrderRenewAsync(SaveSingleTaskForCreatingOrderRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingOrderRenewWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForCreatingOrderTransferResponse SaveSingleTaskForCreatingOrderTransferWithOptions(SaveSingleTaskForCreatingOrderTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationCode))
            {
                query["AuthorizationCode"] = request.AuthorizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitPremiumTransfer))
            {
                query["PermitPremiumTransfer"] = request.PermitPremiumTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCreatingOrderTransfer",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderTransferResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForCreatingOrderTransferResponse> SaveSingleTaskForCreatingOrderTransferWithOptionsAsync(SaveSingleTaskForCreatingOrderTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationCode))
            {
                query["AuthorizationCode"] = request.AuthorizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CouponNo))
            {
                query["CouponNo"] = request.CouponNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermitPremiumTransfer))
            {
                query["PermitPremiumTransfer"] = request.PermitPremiumTransfer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionNo))
            {
                query["PromotionNo"] = request.PromotionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCoupon))
            {
                query["UseCoupon"] = request.UseCoupon;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsePromotion))
            {
                query["UsePromotion"] = request.UsePromotion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCreatingOrderTransfer",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderTransferResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForCreatingOrderTransferResponse SaveSingleTaskForCreatingOrderTransfer(SaveSingleTaskForCreatingOrderTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingOrderTransferWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForCreatingOrderTransferResponse> SaveSingleTaskForCreatingOrderTransferAsync(SaveSingleTaskForCreatingOrderTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingOrderTransferWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForDeletingDSRecordResponse SaveSingleTaskForDeletingDSRecordWithOptions(SaveSingleTaskForDeletingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyTag))
            {
                query["KeyTag"] = request.KeyTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForDeletingDSRecord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForDeletingDSRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForDeletingDSRecordResponse> SaveSingleTaskForDeletingDSRecordWithOptionsAsync(SaveSingleTaskForDeletingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyTag))
            {
                query["KeyTag"] = request.KeyTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForDeletingDSRecord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForDeletingDSRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForDeletingDSRecordResponse SaveSingleTaskForDeletingDSRecord(SaveSingleTaskForDeletingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForDeletingDSRecordWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForDeletingDSRecordResponse> SaveSingleTaskForDeletingDSRecordAsync(SaveSingleTaskForDeletingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForDeletingDSRecordWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForDeletingDnsHostResponse SaveSingleTaskForDeletingDnsHostWithOptions(SaveSingleTaskForDeletingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsName))
            {
                query["DnsName"] = request.DnsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForDeletingDnsHost",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForDeletingDnsHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForDeletingDnsHostResponse> SaveSingleTaskForDeletingDnsHostWithOptionsAsync(SaveSingleTaskForDeletingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsName))
            {
                query["DnsName"] = request.DnsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForDeletingDnsHost",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForDeletingDnsHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForDeletingDnsHostResponse SaveSingleTaskForDeletingDnsHost(SaveSingleTaskForDeletingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForDeletingDnsHostWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForDeletingDnsHostResponse> SaveSingleTaskForDeletingDnsHostAsync(SaveSingleTaskForDeletingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForDeletingDnsHostWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForDisassociatingEnsResponse SaveSingleTaskForDisassociatingEnsWithOptions(SaveSingleTaskForDisassociatingEnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForDisassociatingEns",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForDisassociatingEnsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForDisassociatingEnsResponse> SaveSingleTaskForDisassociatingEnsWithOptionsAsync(SaveSingleTaskForDisassociatingEnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForDisassociatingEns",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForDisassociatingEnsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForDisassociatingEnsResponse SaveSingleTaskForDisassociatingEns(SaveSingleTaskForDisassociatingEnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForDisassociatingEnsWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForDisassociatingEnsResponse> SaveSingleTaskForDisassociatingEnsAsync(SaveSingleTaskForDisassociatingEnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForDisassociatingEnsWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForDomainNameProxyServiceResponse SaveSingleTaskForDomainNameProxyServiceWithOptions(SaveSingleTaskForDomainNameProxyServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForDomainNameProxyService",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForDomainNameProxyServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForDomainNameProxyServiceResponse> SaveSingleTaskForDomainNameProxyServiceWithOptionsAsync(SaveSingleTaskForDomainNameProxyServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForDomainNameProxyService",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForDomainNameProxyServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForDomainNameProxyServiceResponse SaveSingleTaskForDomainNameProxyService(SaveSingleTaskForDomainNameProxyServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForDomainNameProxyServiceWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForDomainNameProxyServiceResponse> SaveSingleTaskForDomainNameProxyServiceAsync(SaveSingleTaskForDomainNameProxyServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForDomainNameProxyServiceWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForModifyingDSRecordResponse SaveSingleTaskForModifyingDSRecordWithOptions(SaveSingleTaskForModifyingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigestType))
            {
                query["DigestType"] = request.DigestType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyTag))
            {
                query["KeyTag"] = request.KeyTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForModifyingDSRecord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForModifyingDSRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForModifyingDSRecordResponse> SaveSingleTaskForModifyingDSRecordWithOptionsAsync(SaveSingleTaskForModifyingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Algorithm))
            {
                query["Algorithm"] = request.Algorithm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Digest))
            {
                query["Digest"] = request.Digest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DigestType))
            {
                query["DigestType"] = request.DigestType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyTag))
            {
                query["KeyTag"] = request.KeyTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForModifyingDSRecord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForModifyingDSRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForModifyingDSRecordResponse SaveSingleTaskForModifyingDSRecord(SaveSingleTaskForModifyingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForModifyingDSRecordWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForModifyingDSRecordResponse> SaveSingleTaskForModifyingDSRecordAsync(SaveSingleTaskForModifyingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForModifyingDSRecordWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForModifyingDnsHostResponse SaveSingleTaskForModifyingDnsHostWithOptions(SaveSingleTaskForModifyingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsName))
            {
                query["DnsName"] = request.DnsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForModifyingDnsHost",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForModifyingDnsHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForModifyingDnsHostResponse> SaveSingleTaskForModifyingDnsHostWithOptionsAsync(SaveSingleTaskForModifyingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsName))
            {
                query["DnsName"] = request.DnsName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForModifyingDnsHost",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForModifyingDnsHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForModifyingDnsHostResponse SaveSingleTaskForModifyingDnsHost(SaveSingleTaskForModifyingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForModifyingDnsHostWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForModifyingDnsHostResponse> SaveSingleTaskForModifyingDnsHostAsync(SaveSingleTaskForModifyingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForModifyingDnsHostWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForQueryingTransferAuthorizationCodeResponse SaveSingleTaskForQueryingTransferAuthorizationCodeWithOptions(SaveSingleTaskForQueryingTransferAuthorizationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForQueryingTransferAuthorizationCode",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForQueryingTransferAuthorizationCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForQueryingTransferAuthorizationCodeResponse> SaveSingleTaskForQueryingTransferAuthorizationCodeWithOptionsAsync(SaveSingleTaskForQueryingTransferAuthorizationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForQueryingTransferAuthorizationCode",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForQueryingTransferAuthorizationCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForQueryingTransferAuthorizationCodeResponse SaveSingleTaskForQueryingTransferAuthorizationCode(SaveSingleTaskForQueryingTransferAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForQueryingTransferAuthorizationCodeWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForQueryingTransferAuthorizationCodeResponse> SaveSingleTaskForQueryingTransferAuthorizationCodeAsync(SaveSingleTaskForQueryingTransferAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForQueryingTransferAuthorizationCodeWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForSaveArtExtensionResponse SaveSingleTaskForSaveArtExtensionWithOptions(SaveSingleTaskForSaveArtExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateOrPeriod))
            {
                query["DateOrPeriod"] = request.DateOrPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Features))
            {
                query["Features"] = request.Features;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InscriptionsAndMarkings))
            {
                query["InscriptionsAndMarkings"] = request.InscriptionsAndMarkings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Maker))
            {
                query["Maker"] = request.Maker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialsAndTechniques))
            {
                query["MaterialsAndTechniques"] = request.MaterialsAndTechniques;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reference))
            {
                query["Reference"] = request.Reference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForSaveArtExtension",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForSaveArtExtensionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForSaveArtExtensionResponse> SaveSingleTaskForSaveArtExtensionWithOptionsAsync(SaveSingleTaskForSaveArtExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateOrPeriod))
            {
                query["DateOrPeriod"] = request.DateOrPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dimensions))
            {
                query["Dimensions"] = request.Dimensions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Features))
            {
                query["Features"] = request.Features;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InscriptionsAndMarkings))
            {
                query["InscriptionsAndMarkings"] = request.InscriptionsAndMarkings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Maker))
            {
                query["Maker"] = request.Maker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialsAndTechniques))
            {
                query["MaterialsAndTechniques"] = request.MaterialsAndTechniques;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["ObjectType"] = request.ObjectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reference))
            {
                query["Reference"] = request.Reference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subject))
            {
                query["Subject"] = request.Subject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForSaveArtExtension",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForSaveArtExtensionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForSaveArtExtensionResponse SaveSingleTaskForSaveArtExtension(SaveSingleTaskForSaveArtExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForSaveArtExtensionWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForSaveArtExtensionResponse> SaveSingleTaskForSaveArtExtensionAsync(SaveSingleTaskForSaveArtExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForSaveArtExtensionWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForSynchronizingDSRecordResponse SaveSingleTaskForSynchronizingDSRecordWithOptions(SaveSingleTaskForSynchronizingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForSynchronizingDSRecord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForSynchronizingDSRecordResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForSynchronizingDSRecordResponse> SaveSingleTaskForSynchronizingDSRecordWithOptionsAsync(SaveSingleTaskForSynchronizingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForSynchronizingDSRecord",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForSynchronizingDSRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForSynchronizingDSRecordResponse SaveSingleTaskForSynchronizingDSRecord(SaveSingleTaskForSynchronizingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForSynchronizingDSRecordWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForSynchronizingDSRecordResponse> SaveSingleTaskForSynchronizingDSRecordAsync(SaveSingleTaskForSynchronizingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForSynchronizingDSRecordWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForSynchronizingDnsHostResponse SaveSingleTaskForSynchronizingDnsHostWithOptions(SaveSingleTaskForSynchronizingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForSynchronizingDnsHost",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForSynchronizingDnsHostResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForSynchronizingDnsHostResponse> SaveSingleTaskForSynchronizingDnsHostWithOptionsAsync(SaveSingleTaskForSynchronizingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForSynchronizingDnsHost",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForSynchronizingDnsHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForSynchronizingDnsHostResponse SaveSingleTaskForSynchronizingDnsHost(SaveSingleTaskForSynchronizingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForSynchronizingDnsHostWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForSynchronizingDnsHostResponse> SaveSingleTaskForSynchronizingDnsHostAsync(SaveSingleTaskForSynchronizingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForSynchronizingDnsHostWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForTransferProhibitionLockResponse SaveSingleTaskForTransferProhibitionLockWithOptions(SaveSingleTaskForTransferProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForTransferProhibitionLock",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForTransferProhibitionLockResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForTransferProhibitionLockResponse> SaveSingleTaskForTransferProhibitionLockWithOptionsAsync(SaveSingleTaskForTransferProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForTransferProhibitionLock",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForTransferProhibitionLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForTransferProhibitionLockResponse SaveSingleTaskForTransferProhibitionLock(SaveSingleTaskForTransferProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForTransferProhibitionLockWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForTransferProhibitionLockResponse> SaveSingleTaskForTransferProhibitionLockAsync(SaveSingleTaskForTransferProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForTransferProhibitionLockWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForUpdateProhibitionLockResponse SaveSingleTaskForUpdateProhibitionLockWithOptions(SaveSingleTaskForUpdateProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForUpdateProhibitionLock",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForUpdateProhibitionLockResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForUpdateProhibitionLockResponse> SaveSingleTaskForUpdateProhibitionLockWithOptionsAsync(SaveSingleTaskForUpdateProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForUpdateProhibitionLock",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForUpdateProhibitionLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForUpdateProhibitionLockResponse SaveSingleTaskForUpdateProhibitionLock(SaveSingleTaskForUpdateProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForUpdateProhibitionLockWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForUpdateProhibitionLockResponse> SaveSingleTaskForUpdateProhibitionLockAsync(SaveSingleTaskForUpdateProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForUpdateProhibitionLockWithOptionsAsync(request, runtime);
        }

        public SaveSingleTaskForUpdatingContactInfoResponse SaveSingleTaskForUpdatingContactInfoWithOptions(SaveSingleTaskForUpdatingContactInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddTransferLock))
            {
                query["AddTransferLock"] = request.AddTransferLock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForUpdatingContactInfo",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForUpdatingContactInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveSingleTaskForUpdatingContactInfoResponse> SaveSingleTaskForUpdatingContactInfoWithOptionsAsync(SaveSingleTaskForUpdatingContactInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddTransferLock))
            {
                query["AddTransferLock"] = request.AddTransferLock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactType))
            {
                query["ContactType"] = request.ContactType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForUpdatingContactInfo",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForUpdatingContactInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveSingleTaskForUpdatingContactInfoResponse SaveSingleTaskForUpdatingContactInfo(SaveSingleTaskForUpdatingContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForUpdatingContactInfoWithOptions(request, runtime);
        }

        public async Task<SaveSingleTaskForUpdatingContactInfoResponse> SaveSingleTaskForUpdatingContactInfoAsync(SaveSingleTaskForUpdatingContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForUpdatingContactInfoWithOptionsAsync(request, runtime);
        }

        public SaveTaskForSubmittingDomainDeleteResponse SaveTaskForSubmittingDomainDeleteWithOptions(SaveTaskForSubmittingDomainDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForSubmittingDomainDelete",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainDeleteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveTaskForSubmittingDomainDeleteResponse> SaveTaskForSubmittingDomainDeleteWithOptionsAsync(SaveTaskForSubmittingDomainDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForSubmittingDomainDelete",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveTaskForSubmittingDomainDeleteResponse SaveTaskForSubmittingDomainDelete(SaveTaskForSubmittingDomainDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForSubmittingDomainDeleteWithOptions(request, runtime);
        }

        public async Task<SaveTaskForSubmittingDomainDeleteResponse> SaveTaskForSubmittingDomainDeleteAsync(SaveTaskForSubmittingDomainDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForSubmittingDomainDeleteWithOptionsAsync(request, runtime);
        }

        public SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialWithOptions(SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredentialNo))
            {
                query["IdentityCredentialNo"] = request.IdentityCredentialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredentialType))
            {
                query["IdentityCredentialType"] = request.IdentityCredentialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredential))
            {
                body["IdentityCredential"] = request.IdentityCredential;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredential",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse> SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialWithOptionsAsync(SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredentialNo))
            {
                query["IdentityCredentialNo"] = request.IdentityCredentialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredentialType))
            {
                query["IdentityCredentialType"] = request.IdentityCredentialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredential))
            {
                body["IdentityCredential"] = request.IdentityCredential;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredential",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredential(SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialWithOptions(request, runtime);
        }

        public async Task<SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse> SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialAsync(SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialWithOptionsAsync(request, runtime);
        }

        public SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDWithOptions(SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileID",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse> SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDWithOptionsAsync(SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileID",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileID(SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDWithOptions(request, runtime);
        }

        public async Task<SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse> SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDAsync(SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDWithOptionsAsync(request, runtime);
        }

        public SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse SaveTaskForUpdatingRegistrantInfoByIdentityCredentialWithOptions(SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredentialNo))
            {
                query["IdentityCredentialNo"] = request.IdentityCredentialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredentialType))
            {
                query["IdentityCredentialType"] = request.IdentityCredentialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostalCode))
            {
                query["PostalCode"] = request.PostalCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantName))
            {
                query["RegistrantName"] = request.RegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantOrganization))
            {
                query["RegistrantOrganization"] = request.RegistrantOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantType))
            {
                query["RegistrantType"] = request.RegistrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelArea))
            {
                query["TelArea"] = request.TelArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelExt))
            {
                query["TelExt"] = request.TelExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferOutProhibited))
            {
                query["TransferOutProhibited"] = request.TransferOutProhibited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredential))
            {
                body["IdentityCredential"] = request.IdentityCredential;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForUpdatingRegistrantInfoByIdentityCredential",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse> SaveTaskForUpdatingRegistrantInfoByIdentityCredentialWithOptionsAsync(SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredentialNo))
            {
                query["IdentityCredentialNo"] = request.IdentityCredentialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredentialType))
            {
                query["IdentityCredentialType"] = request.IdentityCredentialType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostalCode))
            {
                query["PostalCode"] = request.PostalCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantName))
            {
                query["RegistrantName"] = request.RegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantOrganization))
            {
                query["RegistrantOrganization"] = request.RegistrantOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantType))
            {
                query["RegistrantType"] = request.RegistrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelArea))
            {
                query["TelArea"] = request.TelArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelExt))
            {
                query["TelExt"] = request.TelExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferOutProhibited))
            {
                query["TransferOutProhibited"] = request.TransferOutProhibited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredential))
            {
                body["IdentityCredential"] = request.IdentityCredential;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForUpdatingRegistrantInfoByIdentityCredential",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse SaveTaskForUpdatingRegistrantInfoByIdentityCredential(SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForUpdatingRegistrantInfoByIdentityCredentialWithOptions(request, runtime);
        }

        public async Task<SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse> SaveTaskForUpdatingRegistrantInfoByIdentityCredentialAsync(SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForUpdatingRegistrantInfoByIdentityCredentialWithOptionsAsync(request, runtime);
        }

        public SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDWithOptions(SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferOutProhibited))
            {
                query["TransferOutProhibited"] = request.TransferOutProhibited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForUpdatingRegistrantInfoByRegistrantProfileID",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse> SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDWithOptionsAsync(SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileId))
            {
                query["RegistrantProfileId"] = request.RegistrantProfileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferOutProhibited))
            {
                query["TransferOutProhibited"] = request.TransferOutProhibited;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveTaskForUpdatingRegistrantInfoByRegistrantProfileID",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse SaveTaskForUpdatingRegistrantInfoByRegistrantProfileID(SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDWithOptions(request, runtime);
        }

        public async Task<SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse> SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDAsync(SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDWithOptionsAsync(request, runtime);
        }

        public SubmitEmailVerificationResponse SubmitEmailVerificationWithOptions(SubmitEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendIfExist))
            {
                query["SendIfExist"] = request.SendIfExist;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitEmailVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitEmailVerificationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitEmailVerificationResponse> SubmitEmailVerificationWithOptionsAsync(SubmitEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendIfExist))
            {
                query["SendIfExist"] = request.SendIfExist;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitEmailVerification",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitEmailVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitEmailVerificationResponse SubmitEmailVerification(SubmitEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitEmailVerificationWithOptions(request, runtime);
        }

        public async Task<SubmitEmailVerificationResponse> SubmitEmailVerificationAsync(SubmitEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitEmailVerificationWithOptionsAsync(request, runtime);
        }

        public TransferInCheckMailTokenResponse TransferInCheckMailTokenWithOptions(TransferInCheckMailTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferInCheckMailToken",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferInCheckMailTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransferInCheckMailTokenResponse> TransferInCheckMailTokenWithOptionsAsync(TransferInCheckMailTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferInCheckMailToken",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferInCheckMailTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransferInCheckMailTokenResponse TransferInCheckMailToken(TransferInCheckMailTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInCheckMailTokenWithOptions(request, runtime);
        }

        public async Task<TransferInCheckMailTokenResponse> TransferInCheckMailTokenAsync(TransferInCheckMailTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInCheckMailTokenWithOptionsAsync(request, runtime);
        }

        public TransferInReenterTransferAuthorizationCodeResponse TransferInReenterTransferAuthorizationCodeWithOptions(TransferInReenterTransferAuthorizationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferAuthorizationCode))
            {
                query["TransferAuthorizationCode"] = request.TransferAuthorizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferInReenterTransferAuthorizationCode",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferInReenterTransferAuthorizationCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransferInReenterTransferAuthorizationCodeResponse> TransferInReenterTransferAuthorizationCodeWithOptionsAsync(TransferInReenterTransferAuthorizationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferAuthorizationCode))
            {
                query["TransferAuthorizationCode"] = request.TransferAuthorizationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferInReenterTransferAuthorizationCode",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferInReenterTransferAuthorizationCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransferInReenterTransferAuthorizationCodeResponse TransferInReenterTransferAuthorizationCode(TransferInReenterTransferAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInReenterTransferAuthorizationCodeWithOptions(request, runtime);
        }

        public async Task<TransferInReenterTransferAuthorizationCodeResponse> TransferInReenterTransferAuthorizationCodeAsync(TransferInReenterTransferAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInReenterTransferAuthorizationCodeWithOptionsAsync(request, runtime);
        }

        public TransferInRefetchWhoisEmailResponse TransferInRefetchWhoisEmailWithOptions(TransferInRefetchWhoisEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferInRefetchWhoisEmail",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferInRefetchWhoisEmailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransferInRefetchWhoisEmailResponse> TransferInRefetchWhoisEmailWithOptionsAsync(TransferInRefetchWhoisEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferInRefetchWhoisEmail",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferInRefetchWhoisEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransferInRefetchWhoisEmailResponse TransferInRefetchWhoisEmail(TransferInRefetchWhoisEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInRefetchWhoisEmailWithOptions(request, runtime);
        }

        public async Task<TransferInRefetchWhoisEmailResponse> TransferInRefetchWhoisEmailAsync(TransferInRefetchWhoisEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInRefetchWhoisEmailWithOptionsAsync(request, runtime);
        }

        public TransferInResendMailTokenResponse TransferInResendMailTokenWithOptions(TransferInResendMailTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferInResendMailToken",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferInResendMailTokenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TransferInResendMailTokenResponse> TransferInResendMailTokenWithOptionsAsync(TransferInResendMailTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TransferInResendMailToken",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TransferInResendMailTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TransferInResendMailTokenResponse TransferInResendMailToken(TransferInResendMailTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInResendMailTokenWithOptions(request, runtime);
        }

        public async Task<TransferInResendMailTokenResponse> TransferInResendMailTokenAsync(TransferInResendMailTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInResendMailTokenWithOptionsAsync(request, runtime);
        }

        public VerifyContactFieldResponse VerifyContactFieldWithOptions(VerifyContactFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostalCode))
            {
                query["PostalCode"] = request.PostalCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantName))
            {
                query["RegistrantName"] = request.RegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantOrganization))
            {
                query["RegistrantOrganization"] = request.RegistrantOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantType))
            {
                query["RegistrantType"] = request.RegistrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelArea))
            {
                query["TelArea"] = request.TelArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelExt))
            {
                query["TelExt"] = request.TelExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyContactField",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyContactFieldResponse>(CallApi(params_, req, runtime));
        }

        public async Task<VerifyContactFieldResponse> VerifyContactFieldWithOptionsAsync(VerifyContactFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                query["Address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.City))
            {
                query["City"] = request.City;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                query["Country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostalCode))
            {
                query["PostalCode"] = request.PostalCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantName))
            {
                query["RegistrantName"] = request.RegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantOrganization))
            {
                query["RegistrantOrganization"] = request.RegistrantOrganization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantType))
            {
                query["RegistrantType"] = request.RegistrantType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelArea))
            {
                query["TelArea"] = request.TelArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelExt))
            {
                query["TelExt"] = request.TelExt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                query["Telephone"] = request.Telephone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyContactField",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyContactFieldResponse>(await CallApiAsync(params_, req, runtime));
        }

        public VerifyContactFieldResponse VerifyContactField(VerifyContactFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyContactFieldWithOptions(request, runtime);
        }

        public async Task<VerifyContactFieldResponse> VerifyContactFieldAsync(VerifyContactFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyContactFieldWithOptionsAsync(request, runtime);
        }

        public VerifyEmailResponse VerifyEmailWithOptions(VerifyEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyEmail",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyEmailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<VerifyEmailResponse> VerifyEmailWithOptionsAsync(VerifyEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyEmail",
                Version = "2017-12-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyEmailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public VerifyEmailResponse VerifyEmail(VerifyEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyEmailWithOptions(request, runtime);
        }

        public async Task<VerifyEmailResponse> VerifyEmailAsync(VerifyEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyEmailWithOptionsAsync(request, runtime);
        }

    }
}
