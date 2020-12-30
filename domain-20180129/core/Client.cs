// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Domain20180129.Models;

namespace AlibabaCloud.SDK.Domain20180129
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("domain", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AcknowledgeTaskResultResponse>(DoRPCRequest("AcknowledgeTaskResult", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AcknowledgeTaskResultResponse> AcknowledgeTaskResultWithOptionsAsync(AcknowledgeTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AcknowledgeTaskResultResponse>(await DoRPCRequestAsync("AcknowledgeTaskResult", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchFuzzyMatchDomainSensitiveWordResponse>(DoRPCRequest("BatchFuzzyMatchDomainSensitiveWord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchFuzzyMatchDomainSensitiveWordResponse> BatchFuzzyMatchDomainSensitiveWordWithOptionsAsync(BatchFuzzyMatchDomainSensitiveWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchFuzzyMatchDomainSensitiveWordResponse>(await DoRPCRequestAsync("BatchFuzzyMatchDomainSensitiveWord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelDomainVerificationResponse>(DoRPCRequest("CancelDomainVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelDomainVerificationResponse> CancelDomainVerificationWithOptionsAsync(CancelDomainVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelDomainVerificationResponse>(await DoRPCRequestAsync("CancelDomainVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CancelOperationAuditResponse CancelOperationAuditWithOptions(CancelOperationAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelOperationAuditResponse>(DoRPCRequest("CancelOperationAudit", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelOperationAuditResponse> CancelOperationAuditWithOptionsAsync(CancelOperationAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelOperationAuditResponse>(await DoRPCRequestAsync("CancelOperationAudit", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelOperationAuditResponse CancelOperationAudit(CancelOperationAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOperationAuditWithOptions(request, runtime);
        }

        public async Task<CancelOperationAuditResponse> CancelOperationAuditAsync(CancelOperationAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOperationAuditWithOptionsAsync(request, runtime);
        }

        public CancelQualificationVerificationResponse CancelQualificationVerificationWithOptions(CancelQualificationVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelQualificationVerificationResponse>(DoRPCRequest("CancelQualificationVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelQualificationVerificationResponse> CancelQualificationVerificationWithOptionsAsync(CancelQualificationVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelQualificationVerificationResponse>(await DoRPCRequestAsync("CancelQualificationVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelQualificationVerificationResponse CancelQualificationVerification(CancelQualificationVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelQualificationVerificationWithOptions(request, runtime);
        }

        public async Task<CancelQualificationVerificationResponse> CancelQualificationVerificationAsync(CancelQualificationVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelQualificationVerificationWithOptionsAsync(request, runtime);
        }

        public CancelTaskResponse CancelTaskWithOptions(CancelTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelTaskResponse>(DoRPCRequest("CancelTask", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelTaskResponse> CancelTaskWithOptionsAsync(CancelTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelTaskResponse>(await DoRPCRequestAsync("CancelTask", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDomainResponse>(DoRPCRequest("CheckDomain", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckDomainResponse> CheckDomainWithOptionsAsync(CheckDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDomainResponse>(await DoRPCRequestAsync("CheckDomain", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDomainSunriseClaimResponse>(DoRPCRequest("CheckDomainSunriseClaim", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckDomainSunriseClaimResponse> CheckDomainSunriseClaimWithOptionsAsync(CheckDomainSunriseClaimRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDomainSunriseClaimResponse>(await DoRPCRequestAsync("CheckDomainSunriseClaim", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CheckMaxYearOfServerLockResponse CheckMaxYearOfServerLockWithOptions(CheckMaxYearOfServerLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckMaxYearOfServerLockResponse>(DoRPCRequest("CheckMaxYearOfServerLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckMaxYearOfServerLockResponse> CheckMaxYearOfServerLockWithOptionsAsync(CheckMaxYearOfServerLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckMaxYearOfServerLockResponse>(await DoRPCRequestAsync("CheckMaxYearOfServerLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckMaxYearOfServerLockResponse CheckMaxYearOfServerLock(CheckMaxYearOfServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMaxYearOfServerLockWithOptions(request, runtime);
        }

        public async Task<CheckMaxYearOfServerLockResponse> CheckMaxYearOfServerLockAsync(CheckMaxYearOfServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMaxYearOfServerLockWithOptionsAsync(request, runtime);
        }

        public CheckProcessingServerLockApplyResponse CheckProcessingServerLockApplyWithOptions(CheckProcessingServerLockApplyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckProcessingServerLockApplyResponse>(DoRPCRequest("CheckProcessingServerLockApply", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckProcessingServerLockApplyResponse> CheckProcessingServerLockApplyWithOptionsAsync(CheckProcessingServerLockApplyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckProcessingServerLockApplyResponse>(await DoRPCRequestAsync("CheckProcessingServerLockApply", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckProcessingServerLockApplyResponse CheckProcessingServerLockApply(CheckProcessingServerLockApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckProcessingServerLockApplyWithOptions(request, runtime);
        }

        public async Task<CheckProcessingServerLockApplyResponse> CheckProcessingServerLockApplyAsync(CheckProcessingServerLockApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckProcessingServerLockApplyWithOptionsAsync(request, runtime);
        }

        public CheckTransferInFeasibilityResponse CheckTransferInFeasibilityWithOptions(CheckTransferInFeasibilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckTransferInFeasibilityResponse>(DoRPCRequest("CheckTransferInFeasibility", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckTransferInFeasibilityResponse> CheckTransferInFeasibilityWithOptionsAsync(CheckTransferInFeasibilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckTransferInFeasibilityResponse>(await DoRPCRequestAsync("CheckTransferInFeasibility", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfirmTransferInEmailResponse>(DoRPCRequest("ConfirmTransferInEmail", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfirmTransferInEmailResponse> ConfirmTransferInEmailWithOptionsAsync(ConfirmTransferInEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfirmTransferInEmailResponse>(await DoRPCRequestAsync("ConfirmTransferInEmail", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteDomainGroupResponse DeleteDomainGroupWithOptions(DeleteDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainGroupResponse>(DoRPCRequest("DeleteDomainGroup", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDomainGroupResponse> DeleteDomainGroupWithOptionsAsync(DeleteDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainGroupResponse>(await DoRPCRequestAsync("DeleteDomainGroup", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDomainGroupResponse DeleteDomainGroup(DeleteDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainGroupWithOptions(request, runtime);
        }

        public async Task<DeleteDomainGroupResponse> DeleteDomainGroupAsync(DeleteDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainGroupWithOptionsAsync(request, runtime);
        }

        public DeleteEmailVerificationResponse DeleteEmailVerificationWithOptions(DeleteEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEmailVerificationResponse>(DoRPCRequest("DeleteEmailVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEmailVerificationResponse> DeleteEmailVerificationWithOptionsAsync(DeleteEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEmailVerificationResponse>(await DoRPCRequestAsync("DeleteEmailVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRegistrantProfileResponse>(DoRPCRequest("DeleteRegistrantProfile", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRegistrantProfileResponse> DeleteRegistrantProfileWithOptionsAsync(DeleteRegistrantProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRegistrantProfileResponse>(await DoRPCRequestAsync("DeleteRegistrantProfile", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EmailVerifiedResponse>(DoRPCRequest("EmailVerified", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EmailVerifiedResponse> EmailVerifiedWithOptionsAsync(EmailVerifiedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EmailVerifiedResponse>(await DoRPCRequestAsync("EmailVerified", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FuzzyMatchDomainSensitiveWordResponse>(DoRPCRequest("FuzzyMatchDomainSensitiveWord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FuzzyMatchDomainSensitiveWordResponse> FuzzyMatchDomainSensitiveWordWithOptionsAsync(FuzzyMatchDomainSensitiveWordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FuzzyMatchDomainSensitiveWordResponse>(await DoRPCRequestAsync("FuzzyMatchDomainSensitiveWord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public GetOperationOssUploadPolicyResponse GetOperationOssUploadPolicyWithOptions(GetOperationOssUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOperationOssUploadPolicyResponse>(DoRPCRequest("GetOperationOssUploadPolicy", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOperationOssUploadPolicyResponse> GetOperationOssUploadPolicyWithOptionsAsync(GetOperationOssUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOperationOssUploadPolicyResponse>(await DoRPCRequestAsync("GetOperationOssUploadPolicy", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOperationOssUploadPolicyResponse GetOperationOssUploadPolicy(GetOperationOssUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOperationOssUploadPolicyWithOptions(request, runtime);
        }

        public async Task<GetOperationOssUploadPolicyResponse> GetOperationOssUploadPolicyAsync(GetOperationOssUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOperationOssUploadPolicyWithOptionsAsync(request, runtime);
        }

        public GetQualificationUploadPolicyResponse GetQualificationUploadPolicyWithOptions(GetQualificationUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualificationUploadPolicyResponse>(DoRPCRequest("GetQualificationUploadPolicy", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQualificationUploadPolicyResponse> GetQualificationUploadPolicyWithOptionsAsync(GetQualificationUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQualificationUploadPolicyResponse>(await DoRPCRequestAsync("GetQualificationUploadPolicy", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQualificationUploadPolicyResponse GetQualificationUploadPolicy(GetQualificationUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualificationUploadPolicyWithOptions(request, runtime);
        }

        public async Task<GetQualificationUploadPolicyResponse> GetQualificationUploadPolicyAsync(GetQualificationUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualificationUploadPolicyWithOptionsAsync(request, runtime);
        }

        public ListEmailVerificationResponse ListEmailVerificationWithOptions(ListEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEmailVerificationResponse>(DoRPCRequest("ListEmailVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListEmailVerificationResponse> ListEmailVerificationWithOptionsAsync(ListEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEmailVerificationResponse>(await DoRPCRequestAsync("ListEmailVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListServerLockResponse ListServerLockWithOptions(ListServerLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServerLockResponse>(DoRPCRequest("ListServerLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListServerLockResponse> ListServerLockWithOptionsAsync(ListServerLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServerLockResponse>(await DoRPCRequestAsync("ListServerLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListServerLockResponse ListServerLock(ListServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServerLockWithOptions(request, runtime);
        }

        public async Task<ListServerLockResponse> ListServerLockAsync(ListServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServerLockWithOptionsAsync(request, runtime);
        }

        public LookupTmchNoticeResponse LookupTmchNoticeWithOptions(LookupTmchNoticeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LookupTmchNoticeResponse>(DoRPCRequest("LookupTmchNotice", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LookupTmchNoticeResponse> LookupTmchNoticeWithOptionsAsync(LookupTmchNoticeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LookupTmchNoticeResponse>(await DoRPCRequestAsync("LookupTmchNotice", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PollTaskResultResponse>(DoRPCRequest("PollTaskResult", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PollTaskResultResponse> PollTaskResultWithOptionsAsync(PollTaskResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PollTaskResultResponse>(await DoRPCRequestAsync("PollTaskResult", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryAdvancedDomainListResponse QueryAdvancedDomainListWithOptions(QueryAdvancedDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAdvancedDomainListResponse>(DoRPCRequest("QueryAdvancedDomainList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAdvancedDomainListResponse> QueryAdvancedDomainListWithOptionsAsync(QueryAdvancedDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAdvancedDomainListResponse>(await DoRPCRequestAsync("QueryAdvancedDomainList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAdvancedDomainListResponse QueryAdvancedDomainList(QueryAdvancedDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAdvancedDomainListWithOptions(request, runtime);
        }

        public async Task<QueryAdvancedDomainListResponse> QueryAdvancedDomainListAsync(QueryAdvancedDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAdvancedDomainListWithOptionsAsync(request, runtime);
        }

        public QueryArtExtensionResponse QueryArtExtensionWithOptions(QueryArtExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryArtExtensionResponse>(DoRPCRequest("QueryArtExtension", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryArtExtensionResponse> QueryArtExtensionWithOptionsAsync(QueryArtExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryArtExtensionResponse>(await DoRPCRequestAsync("QueryArtExtension", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryChangeLogListResponse>(DoRPCRequest("QueryChangeLogList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryChangeLogListResponse> QueryChangeLogListWithOptionsAsync(QueryChangeLogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryChangeLogListResponse>(await DoRPCRequestAsync("QueryChangeLogList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryContactInfoResponse>(DoRPCRequest("QueryContactInfo", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryContactInfoResponse> QueryContactInfoWithOptionsAsync(QueryContactInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryContactInfoResponse>(await DoRPCRequestAsync("QueryContactInfo", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryDnsHostResponse QueryDnsHostWithOptions(QueryDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDnsHostResponse>(DoRPCRequest("QueryDnsHost", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDnsHostResponse> QueryDnsHostWithOptionsAsync(QueryDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDnsHostResponse>(await DoRPCRequestAsync("QueryDnsHost", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryDomainAdminDivisionResponse QueryDomainAdminDivisionWithOptions(QueryDomainAdminDivisionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainAdminDivisionResponse>(DoRPCRequest("QueryDomainAdminDivision", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDomainAdminDivisionResponse> QueryDomainAdminDivisionWithOptionsAsync(QueryDomainAdminDivisionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainAdminDivisionResponse>(await DoRPCRequestAsync("QueryDomainAdminDivision", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDomainAdminDivisionResponse QueryDomainAdminDivision(QueryDomainAdminDivisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainAdminDivisionWithOptions(request, runtime);
        }

        public async Task<QueryDomainAdminDivisionResponse> QueryDomainAdminDivisionAsync(QueryDomainAdminDivisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainAdminDivisionWithOptionsAsync(request, runtime);
        }

        public QueryDomainByDomainNameResponse QueryDomainByDomainNameWithOptions(QueryDomainByDomainNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainByDomainNameResponse>(DoRPCRequest("QueryDomainByDomainName", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDomainByDomainNameResponse> QueryDomainByDomainNameWithOptionsAsync(QueryDomainByDomainNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainByDomainNameResponse>(await DoRPCRequestAsync("QueryDomainByDomainName", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainByInstanceIdResponse>(DoRPCRequest("QueryDomainByInstanceId", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDomainByInstanceIdResponse> QueryDomainByInstanceIdWithOptionsAsync(QueryDomainByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainByInstanceIdResponse>(await DoRPCRequestAsync("QueryDomainByInstanceId", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryDomainGroupListResponse QueryDomainGroupListWithOptions(QueryDomainGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainGroupListResponse>(DoRPCRequest("QueryDomainGroupList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDomainGroupListResponse> QueryDomainGroupListWithOptionsAsync(QueryDomainGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainGroupListResponse>(await DoRPCRequestAsync("QueryDomainGroupList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDomainGroupListResponse QueryDomainGroupList(QueryDomainGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainGroupListWithOptions(request, runtime);
        }

        public async Task<QueryDomainGroupListResponse> QueryDomainGroupListAsync(QueryDomainGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainGroupListWithOptionsAsync(request, runtime);
        }

        public QueryDomainListResponse QueryDomainListWithOptions(QueryDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainListResponse>(DoRPCRequest("QueryDomainList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDomainListResponse> QueryDomainListWithOptionsAsync(QueryDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainListResponse>(await DoRPCRequestAsync("QueryDomainList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainRealNameVerificationInfoResponse>(DoRPCRequest("QueryDomainRealNameVerificationInfo", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDomainRealNameVerificationInfoResponse> QueryDomainRealNameVerificationInfoWithOptionsAsync(QueryDomainRealNameVerificationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainRealNameVerificationInfoResponse>(await DoRPCRequestAsync("QueryDomainRealNameVerificationInfo", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryDomainSuffixResponse QueryDomainSuffixWithOptions(QueryDomainSuffixRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainSuffixResponse>(DoRPCRequest("QueryDomainSuffix", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDomainSuffixResponse> QueryDomainSuffixWithOptionsAsync(QueryDomainSuffixRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDomainSuffixResponse>(await DoRPCRequestAsync("QueryDomainSuffix", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDomainSuffixResponse QueryDomainSuffix(QueryDomainSuffixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainSuffixWithOptions(request, runtime);
        }

        public async Task<QueryDomainSuffixResponse> QueryDomainSuffixAsync(QueryDomainSuffixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainSuffixWithOptionsAsync(request, runtime);
        }

        public QueryDSRecordResponse QueryDSRecordWithOptions(QueryDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDSRecordResponse>(DoRPCRequest("QueryDSRecord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDSRecordResponse> QueryDSRecordWithOptionsAsync(QueryDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDSRecordResponse>(await DoRPCRequestAsync("QueryDSRecord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryEmailVerificationResponse QueryEmailVerificationWithOptions(QueryEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEmailVerificationResponse>(DoRPCRequest("QueryEmailVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryEmailVerificationResponse> QueryEmailVerificationWithOptionsAsync(QueryEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEmailVerificationResponse>(await DoRPCRequestAsync("QueryEmailVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryEmailVerificationResponse QueryEmailVerification(QueryEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEmailVerificationWithOptions(request, runtime);
        }

        public async Task<QueryEmailVerificationResponse> QueryEmailVerificationAsync(QueryEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEmailVerificationWithOptionsAsync(request, runtime);
        }

        public QueryEnsAssociationResponse QueryEnsAssociationWithOptions(QueryEnsAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEnsAssociationResponse>(DoRPCRequest("QueryEnsAssociation", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryEnsAssociationResponse> QueryEnsAssociationWithOptionsAsync(QueryEnsAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEnsAssociationResponse>(await DoRPCRequestAsync("QueryEnsAssociation", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryFailingReasonListForQualificationResponse QueryFailingReasonListForQualificationWithOptions(QueryFailingReasonListForQualificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFailingReasonListForQualificationResponse>(DoRPCRequest("QueryFailingReasonListForQualification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFailingReasonListForQualificationResponse> QueryFailingReasonListForQualificationWithOptionsAsync(QueryFailingReasonListForQualificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFailingReasonListForQualificationResponse>(await DoRPCRequestAsync("QueryFailingReasonListForQualification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryFailingReasonListForQualificationResponse QueryFailingReasonListForQualification(QueryFailingReasonListForQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFailingReasonListForQualificationWithOptions(request, runtime);
        }

        public async Task<QueryFailingReasonListForQualificationResponse> QueryFailingReasonListForQualificationAsync(QueryFailingReasonListForQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFailingReasonListForQualificationWithOptionsAsync(request, runtime);
        }

        public QueryFailReasonForDomainRealNameVerificationResponse QueryFailReasonForDomainRealNameVerificationWithOptions(QueryFailReasonForDomainRealNameVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFailReasonForDomainRealNameVerificationResponse>(DoRPCRequest("QueryFailReasonForDomainRealNameVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFailReasonForDomainRealNameVerificationResponse> QueryFailReasonForDomainRealNameVerificationWithOptionsAsync(QueryFailReasonForDomainRealNameVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFailReasonForDomainRealNameVerificationResponse>(await DoRPCRequestAsync("QueryFailReasonForDomainRealNameVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFailReasonForRegistrantProfileRealNameVerificationResponse>(DoRPCRequest("QueryFailReasonForRegistrantProfileRealNameVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryFailReasonForRegistrantProfileRealNameVerificationResponse> QueryFailReasonForRegistrantProfileRealNameVerificationWithOptionsAsync(QueryFailReasonForRegistrantProfileRealNameVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryFailReasonForRegistrantProfileRealNameVerificationResponse>(await DoRPCRequestAsync("QueryFailReasonForRegistrantProfileRealNameVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryLocalEnsAssociationResponse>(DoRPCRequest("QueryLocalEnsAssociation", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryLocalEnsAssociationResponse> QueryLocalEnsAssociationWithOptionsAsync(QueryLocalEnsAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryLocalEnsAssociationResponse>(await DoRPCRequestAsync("QueryLocalEnsAssociation", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryOperationAuditInfoDetailResponse QueryOperationAuditInfoDetailWithOptions(QueryOperationAuditInfoDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOperationAuditInfoDetailResponse>(DoRPCRequest("QueryOperationAuditInfoDetail", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryOperationAuditInfoDetailResponse> QueryOperationAuditInfoDetailWithOptionsAsync(QueryOperationAuditInfoDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOperationAuditInfoDetailResponse>(await DoRPCRequestAsync("QueryOperationAuditInfoDetail", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryOperationAuditInfoDetailResponse QueryOperationAuditInfoDetail(QueryOperationAuditInfoDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOperationAuditInfoDetailWithOptions(request, runtime);
        }

        public async Task<QueryOperationAuditInfoDetailResponse> QueryOperationAuditInfoDetailAsync(QueryOperationAuditInfoDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOperationAuditInfoDetailWithOptionsAsync(request, runtime);
        }

        public QueryOperationAuditInfoListResponse QueryOperationAuditInfoListWithOptions(QueryOperationAuditInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOperationAuditInfoListResponse>(DoRPCRequest("QueryOperationAuditInfoList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryOperationAuditInfoListResponse> QueryOperationAuditInfoListWithOptionsAsync(QueryOperationAuditInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryOperationAuditInfoListResponse>(await DoRPCRequestAsync("QueryOperationAuditInfoList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryOperationAuditInfoListResponse QueryOperationAuditInfoList(QueryOperationAuditInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOperationAuditInfoListWithOptions(request, runtime);
        }

        public async Task<QueryOperationAuditInfoListResponse> QueryOperationAuditInfoListAsync(QueryOperationAuditInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOperationAuditInfoListWithOptionsAsync(request, runtime);
        }

        public QueryQualificationDetailResponse QueryQualificationDetailWithOptions(QueryQualificationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryQualificationDetailResponse>(DoRPCRequest("QueryQualificationDetail", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryQualificationDetailResponse> QueryQualificationDetailWithOptionsAsync(QueryQualificationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryQualificationDetailResponse>(await DoRPCRequestAsync("QueryQualificationDetail", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryQualificationDetailResponse QueryQualificationDetail(QueryQualificationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryQualificationDetailWithOptions(request, runtime);
        }

        public async Task<QueryQualificationDetailResponse> QueryQualificationDetailAsync(QueryQualificationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryQualificationDetailWithOptionsAsync(request, runtime);
        }

        public QueryRegistrantProfileRealNameVerificationInfoResponse QueryRegistrantProfileRealNameVerificationInfoWithOptions(QueryRegistrantProfileRealNameVerificationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRegistrantProfileRealNameVerificationInfoResponse>(DoRPCRequest("QueryRegistrantProfileRealNameVerificationInfo", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRegistrantProfileRealNameVerificationInfoResponse> QueryRegistrantProfileRealNameVerificationInfoWithOptionsAsync(QueryRegistrantProfileRealNameVerificationInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRegistrantProfileRealNameVerificationInfoResponse>(await DoRPCRequestAsync("QueryRegistrantProfileRealNameVerificationInfo", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRegistrantProfilesResponse>(DoRPCRequest("QueryRegistrantProfiles", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRegistrantProfilesResponse> QueryRegistrantProfilesWithOptionsAsync(QueryRegistrantProfilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRegistrantProfilesResponse>(await DoRPCRequestAsync("QueryRegistrantProfiles", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryServerLockResponse QueryServerLockWithOptions(QueryServerLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryServerLockResponse>(DoRPCRequest("QueryServerLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryServerLockResponse> QueryServerLockWithOptionsAsync(QueryServerLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryServerLockResponse>(await DoRPCRequestAsync("QueryServerLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryServerLockResponse QueryServerLock(QueryServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryServerLockWithOptions(request, runtime);
        }

        public async Task<QueryServerLockResponse> QueryServerLockAsync(QueryServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryServerLockWithOptionsAsync(request, runtime);
        }

        public QueryTaskDetailHistoryResponse QueryTaskDetailHistoryWithOptions(QueryTaskDetailHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTaskDetailHistoryResponse>(DoRPCRequest("QueryTaskDetailHistory", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTaskDetailHistoryResponse> QueryTaskDetailHistoryWithOptionsAsync(QueryTaskDetailHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTaskDetailHistoryResponse>(await DoRPCRequestAsync("QueryTaskDetailHistory", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTaskDetailListResponse>(DoRPCRequest("QueryTaskDetailList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTaskDetailListResponse> QueryTaskDetailListWithOptionsAsync(QueryTaskDetailListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTaskDetailListResponse>(await DoRPCRequestAsync("QueryTaskDetailList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTaskInfoHistoryResponse>(DoRPCRequest("QueryTaskInfoHistory", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTaskInfoHistoryResponse> QueryTaskInfoHistoryWithOptionsAsync(QueryTaskInfoHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTaskInfoHistoryResponse>(await DoRPCRequestAsync("QueryTaskInfoHistory", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTaskListResponse>(DoRPCRequest("QueryTaskList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTaskListResponse> QueryTaskListWithOptionsAsync(QueryTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTaskListResponse>(await DoRPCRequestAsync("QueryTaskList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTransferInByInstanceIdResponse>(DoRPCRequest("QueryTransferInByInstanceId", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTransferInByInstanceIdResponse> QueryTransferInByInstanceIdWithOptionsAsync(QueryTransferInByInstanceIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTransferInByInstanceIdResponse>(await DoRPCRequestAsync("QueryTransferInByInstanceId", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTransferInListResponse>(DoRPCRequest("QueryTransferInList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTransferInListResponse> QueryTransferInListWithOptionsAsync(QueryTransferInListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTransferInListResponse>(await DoRPCRequestAsync("QueryTransferInList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTransferOutInfoResponse>(DoRPCRequest("QueryTransferOutInfo", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTransferOutInfoResponse> QueryTransferOutInfoWithOptionsAsync(QueryTransferOutInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTransferOutInfoResponse>(await DoRPCRequestAsync("QueryTransferOutInfo", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegistrantProfileRealNameVerificationResponse>(DoRPCRequest("RegistrantProfileRealNameVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegistrantProfileRealNameVerificationResponse> RegistrantProfileRealNameVerificationWithOptionsAsync(RegistrantProfileRealNameVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegistrantProfileRealNameVerificationResponse>(await DoRPCRequestAsync("RegistrantProfileRealNameVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResendEmailVerificationResponse>(DoRPCRequest("ResendEmailVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResendEmailVerificationResponse> ResendEmailVerificationWithOptionsAsync(ResendEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResendEmailVerificationResponse>(await DoRPCRequestAsync("ResendEmailVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ResetQualificationVerificationResponse ResetQualificationVerificationWithOptions(ResetQualificationVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetQualificationVerificationResponse>(DoRPCRequest("ResetQualificationVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetQualificationVerificationResponse> ResetQualificationVerificationWithOptionsAsync(ResetQualificationVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetQualificationVerificationResponse>(await DoRPCRequestAsync("ResetQualificationVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetQualificationVerificationResponse ResetQualificationVerification(ResetQualificationVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetQualificationVerificationWithOptions(request, runtime);
        }

        public async Task<ResetQualificationVerificationResponse> ResetQualificationVerificationAsync(ResetQualificationVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetQualificationVerificationWithOptionsAsync(request, runtime);
        }

        public SaveBatchDomainRemarkResponse SaveBatchDomainRemarkWithOptions(SaveBatchDomainRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchDomainRemarkResponse>(DoRPCRequest("SaveBatchDomainRemark", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveBatchDomainRemarkResponse> SaveBatchDomainRemarkWithOptionsAsync(SaveBatchDomainRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchDomainRemarkResponse>(await DoRPCRequestAsync("SaveBatchDomainRemark", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveBatchDomainRemarkResponse SaveBatchDomainRemark(SaveBatchDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchDomainRemarkWithOptions(request, runtime);
        }

        public async Task<SaveBatchDomainRemarkResponse> SaveBatchDomainRemarkAsync(SaveBatchDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchDomainRemarkWithOptionsAsync(request, runtime);
        }

        public SaveBatchTaskForCreatingOrderActivateResponse SaveBatchTaskForCreatingOrderActivateWithOptions(SaveBatchTaskForCreatingOrderActivateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderActivateResponse>(DoRPCRequest("SaveBatchTaskForCreatingOrderActivate", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveBatchTaskForCreatingOrderActivateResponse> SaveBatchTaskForCreatingOrderActivateWithOptionsAsync(SaveBatchTaskForCreatingOrderActivateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderActivateResponse>(await DoRPCRequestAsync("SaveBatchTaskForCreatingOrderActivate", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderRedeemResponse>(DoRPCRequest("SaveBatchTaskForCreatingOrderRedeem", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveBatchTaskForCreatingOrderRedeemResponse> SaveBatchTaskForCreatingOrderRedeemWithOptionsAsync(SaveBatchTaskForCreatingOrderRedeemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderRedeemResponse>(await DoRPCRequestAsync("SaveBatchTaskForCreatingOrderRedeem", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderRenewResponse>(DoRPCRequest("SaveBatchTaskForCreatingOrderRenew", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveBatchTaskForCreatingOrderRenewResponse> SaveBatchTaskForCreatingOrderRenewWithOptionsAsync(SaveBatchTaskForCreatingOrderRenewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderRenewResponse>(await DoRPCRequestAsync("SaveBatchTaskForCreatingOrderRenew", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderTransferResponse>(DoRPCRequest("SaveBatchTaskForCreatingOrderTransfer", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveBatchTaskForCreatingOrderTransferResponse> SaveBatchTaskForCreatingOrderTransferWithOptionsAsync(SaveBatchTaskForCreatingOrderTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForCreatingOrderTransferResponse>(await DoRPCRequestAsync("SaveBatchTaskForCreatingOrderTransfer", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForDomainNameProxyServiceResponse>(DoRPCRequest("SaveBatchTaskForDomainNameProxyService", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveBatchTaskForDomainNameProxyServiceResponse> SaveBatchTaskForDomainNameProxyServiceWithOptionsAsync(SaveBatchTaskForDomainNameProxyServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForDomainNameProxyServiceResponse>(await DoRPCRequestAsync("SaveBatchTaskForDomainNameProxyService", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForModifyingDomainDnsResponse>(DoRPCRequest("SaveBatchTaskForModifyingDomainDns", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveBatchTaskForModifyingDomainDnsResponse> SaveBatchTaskForModifyingDomainDnsWithOptionsAsync(SaveBatchTaskForModifyingDomainDnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForModifyingDomainDnsResponse>(await DoRPCRequestAsync("SaveBatchTaskForModifyingDomainDns", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveBatchTaskForTransferProhibitionLockResponse SaveBatchTaskForTransferProhibitionLockWithOptions(SaveBatchTaskForTransferProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForTransferProhibitionLockResponse>(DoRPCRequest("SaveBatchTaskForTransferProhibitionLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveBatchTaskForTransferProhibitionLockResponse> SaveBatchTaskForTransferProhibitionLockWithOptionsAsync(SaveBatchTaskForTransferProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForTransferProhibitionLockResponse>(await DoRPCRequestAsync("SaveBatchTaskForTransferProhibitionLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdateProhibitionLockResponse>(DoRPCRequest("SaveBatchTaskForUpdateProhibitionLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveBatchTaskForUpdateProhibitionLockResponse> SaveBatchTaskForUpdateProhibitionLockWithOptionsAsync(SaveBatchTaskForUpdateProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdateProhibitionLockResponse>(await DoRPCRequestAsync("SaveBatchTaskForUpdateProhibitionLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveBatchTaskForUpdatingContactInfoByNewContactResponse SaveBatchTaskForUpdatingContactInfoByNewContactWithOptions(SaveBatchTaskForUpdatingContactInfoByNewContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdatingContactInfoByNewContactResponse>(DoRPCRequest("SaveBatchTaskForUpdatingContactInfoByNewContact", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveBatchTaskForUpdatingContactInfoByNewContactResponse> SaveBatchTaskForUpdatingContactInfoByNewContactWithOptionsAsync(SaveBatchTaskForUpdatingContactInfoByNewContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdatingContactInfoByNewContactResponse>(await DoRPCRequestAsync("SaveBatchTaskForUpdatingContactInfoByNewContact", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdWithOptions(SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse>(DoRPCRequest("SaveBatchTaskForUpdatingContactInfoByRegistrantProfileId", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse> SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdWithOptionsAsync(SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse>(await DoRPCRequestAsync("SaveBatchTaskForUpdatingContactInfoByRegistrantProfileId", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse SaveBatchTaskForUpdatingContactInfoByRegistrantProfileId(SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdWithOptions(request, runtime);
        }

        public async Task<SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse> SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdAsync(SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdWithOptionsAsync(request, runtime);
        }

        public SaveDomainGroupResponse SaveDomainGroupWithOptions(SaveDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveDomainGroupResponse>(DoRPCRequest("SaveDomainGroup", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveDomainGroupResponse> SaveDomainGroupWithOptionsAsync(SaveDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveDomainGroupResponse>(await DoRPCRequestAsync("SaveDomainGroup", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveDomainGroupResponse SaveDomainGroup(SaveDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveDomainGroupWithOptions(request, runtime);
        }

        public async Task<SaveDomainGroupResponse> SaveDomainGroupAsync(SaveDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveDomainGroupWithOptionsAsync(request, runtime);
        }

        public SaveRegistrantProfileResponse SaveRegistrantProfileWithOptions(SaveRegistrantProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveRegistrantProfileResponse>(DoRPCRequest("SaveRegistrantProfile", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveRegistrantProfileResponse> SaveRegistrantProfileWithOptionsAsync(SaveRegistrantProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveRegistrantProfileResponse>(await DoRPCRequestAsync("SaveRegistrantProfile", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForAddingDSRecordResponse>(DoRPCRequest("SaveSingleTaskForAddingDSRecord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForAddingDSRecordResponse> SaveSingleTaskForAddingDSRecordWithOptionsAsync(SaveSingleTaskForAddingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForAddingDSRecordResponse>(await DoRPCRequestAsync("SaveSingleTaskForAddingDSRecord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForApprovingTransferOutResponse>(DoRPCRequest("SaveSingleTaskForApprovingTransferOut", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForApprovingTransferOutResponse> SaveSingleTaskForApprovingTransferOutWithOptionsAsync(SaveSingleTaskForApprovingTransferOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForApprovingTransferOutResponse>(await DoRPCRequestAsync("SaveSingleTaskForApprovingTransferOut", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForAssociatingEnsResponse>(DoRPCRequest("SaveSingleTaskForAssociatingEns", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForAssociatingEnsResponse> SaveSingleTaskForAssociatingEnsWithOptionsAsync(SaveSingleTaskForAssociatingEnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForAssociatingEnsResponse>(await DoRPCRequestAsync("SaveSingleTaskForAssociatingEns", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCancelingTransferInResponse>(DoRPCRequest("SaveSingleTaskForCancelingTransferIn", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForCancelingTransferInResponse> SaveSingleTaskForCancelingTransferInWithOptionsAsync(SaveSingleTaskForCancelingTransferInRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCancelingTransferInResponse>(await DoRPCRequestAsync("SaveSingleTaskForCancelingTransferIn", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCancelingTransferOutResponse>(DoRPCRequest("SaveSingleTaskForCancelingTransferOut", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForCancelingTransferOutResponse> SaveSingleTaskForCancelingTransferOutWithOptionsAsync(SaveSingleTaskForCancelingTransferOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCancelingTransferOutResponse>(await DoRPCRequestAsync("SaveSingleTaskForCancelingTransferOut", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingDnsHostResponse>(DoRPCRequest("SaveSingleTaskForCreatingDnsHost", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForCreatingDnsHostResponse> SaveSingleTaskForCreatingDnsHostWithOptionsAsync(SaveSingleTaskForCreatingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingDnsHostResponse>(await DoRPCRequestAsync("SaveSingleTaskForCreatingDnsHost", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderActivateResponse>(DoRPCRequest("SaveSingleTaskForCreatingOrderActivate", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForCreatingOrderActivateResponse> SaveSingleTaskForCreatingOrderActivateWithOptionsAsync(SaveSingleTaskForCreatingOrderActivateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderActivateResponse>(await DoRPCRequestAsync("SaveSingleTaskForCreatingOrderActivate", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderRedeemResponse>(DoRPCRequest("SaveSingleTaskForCreatingOrderRedeem", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForCreatingOrderRedeemResponse> SaveSingleTaskForCreatingOrderRedeemWithOptionsAsync(SaveSingleTaskForCreatingOrderRedeemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderRedeemResponse>(await DoRPCRequestAsync("SaveSingleTaskForCreatingOrderRedeem", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderRenewResponse>(DoRPCRequest("SaveSingleTaskForCreatingOrderRenew", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForCreatingOrderRenewResponse> SaveSingleTaskForCreatingOrderRenewWithOptionsAsync(SaveSingleTaskForCreatingOrderRenewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderRenewResponse>(await DoRPCRequestAsync("SaveSingleTaskForCreatingOrderRenew", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderTransferResponse>(DoRPCRequest("SaveSingleTaskForCreatingOrderTransfer", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForCreatingOrderTransferResponse> SaveSingleTaskForCreatingOrderTransferWithOptionsAsync(SaveSingleTaskForCreatingOrderTransferRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForCreatingOrderTransferResponse>(await DoRPCRequestAsync("SaveSingleTaskForCreatingOrderTransfer", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveSingleTaskForDeletingDnsHostResponse SaveSingleTaskForDeletingDnsHostWithOptions(SaveSingleTaskForDeletingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForDeletingDnsHostResponse>(DoRPCRequest("SaveSingleTaskForDeletingDnsHost", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForDeletingDnsHostResponse> SaveSingleTaskForDeletingDnsHostWithOptionsAsync(SaveSingleTaskForDeletingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForDeletingDnsHostResponse>(await DoRPCRequestAsync("SaveSingleTaskForDeletingDnsHost", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveSingleTaskForDeletingDSRecordResponse SaveSingleTaskForDeletingDSRecordWithOptions(SaveSingleTaskForDeletingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForDeletingDSRecordResponse>(DoRPCRequest("SaveSingleTaskForDeletingDSRecord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForDeletingDSRecordResponse> SaveSingleTaskForDeletingDSRecordWithOptionsAsync(SaveSingleTaskForDeletingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForDeletingDSRecordResponse>(await DoRPCRequestAsync("SaveSingleTaskForDeletingDSRecord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveSingleTaskForDisassociatingEnsResponse SaveSingleTaskForDisassociatingEnsWithOptions(SaveSingleTaskForDisassociatingEnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForDisassociatingEnsResponse>(DoRPCRequest("SaveSingleTaskForDisassociatingEns", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForDisassociatingEnsResponse> SaveSingleTaskForDisassociatingEnsWithOptionsAsync(SaveSingleTaskForDisassociatingEnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForDisassociatingEnsResponse>(await DoRPCRequestAsync("SaveSingleTaskForDisassociatingEns", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForDomainNameProxyServiceResponse>(DoRPCRequest("SaveSingleTaskForDomainNameProxyService", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForDomainNameProxyServiceResponse> SaveSingleTaskForDomainNameProxyServiceWithOptionsAsync(SaveSingleTaskForDomainNameProxyServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForDomainNameProxyServiceResponse>(await DoRPCRequestAsync("SaveSingleTaskForDomainNameProxyService", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveSingleTaskForModifyingDnsHostResponse SaveSingleTaskForModifyingDnsHostWithOptions(SaveSingleTaskForModifyingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForModifyingDnsHostResponse>(DoRPCRequest("SaveSingleTaskForModifyingDnsHost", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForModifyingDnsHostResponse> SaveSingleTaskForModifyingDnsHostWithOptionsAsync(SaveSingleTaskForModifyingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForModifyingDnsHostResponse>(await DoRPCRequestAsync("SaveSingleTaskForModifyingDnsHost", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveSingleTaskForModifyingDSRecordResponse SaveSingleTaskForModifyingDSRecordWithOptions(SaveSingleTaskForModifyingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForModifyingDSRecordResponse>(DoRPCRequest("SaveSingleTaskForModifyingDSRecord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForModifyingDSRecordResponse> SaveSingleTaskForModifyingDSRecordWithOptionsAsync(SaveSingleTaskForModifyingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForModifyingDSRecordResponse>(await DoRPCRequestAsync("SaveSingleTaskForModifyingDSRecord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveSingleTaskForQueryingTransferAuthorizationCodeResponse SaveSingleTaskForQueryingTransferAuthorizationCodeWithOptions(SaveSingleTaskForQueryingTransferAuthorizationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForQueryingTransferAuthorizationCodeResponse>(DoRPCRequest("SaveSingleTaskForQueryingTransferAuthorizationCode", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForQueryingTransferAuthorizationCodeResponse> SaveSingleTaskForQueryingTransferAuthorizationCodeWithOptionsAsync(SaveSingleTaskForQueryingTransferAuthorizationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForQueryingTransferAuthorizationCodeResponse>(await DoRPCRequestAsync("SaveSingleTaskForQueryingTransferAuthorizationCode", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForSaveArtExtensionResponse>(DoRPCRequest("SaveSingleTaskForSaveArtExtension", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForSaveArtExtensionResponse> SaveSingleTaskForSaveArtExtensionWithOptionsAsync(SaveSingleTaskForSaveArtExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForSaveArtExtensionResponse>(await DoRPCRequestAsync("SaveSingleTaskForSaveArtExtension", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveSingleTaskForSynchronizingDnsHostResponse SaveSingleTaskForSynchronizingDnsHostWithOptions(SaveSingleTaskForSynchronizingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForSynchronizingDnsHostResponse>(DoRPCRequest("SaveSingleTaskForSynchronizingDnsHost", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForSynchronizingDnsHostResponse> SaveSingleTaskForSynchronizingDnsHostWithOptionsAsync(SaveSingleTaskForSynchronizingDnsHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForSynchronizingDnsHostResponse>(await DoRPCRequestAsync("SaveSingleTaskForSynchronizingDnsHost", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveSingleTaskForSynchronizingDSRecordResponse SaveSingleTaskForSynchronizingDSRecordWithOptions(SaveSingleTaskForSynchronizingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForSynchronizingDSRecordResponse>(DoRPCRequest("SaveSingleTaskForSynchronizingDSRecord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForSynchronizingDSRecordResponse> SaveSingleTaskForSynchronizingDSRecordWithOptionsAsync(SaveSingleTaskForSynchronizingDSRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForSynchronizingDSRecordResponse>(await DoRPCRequestAsync("SaveSingleTaskForSynchronizingDSRecord", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SaveSingleTaskForTransferProhibitionLockResponse SaveSingleTaskForTransferProhibitionLockWithOptions(SaveSingleTaskForTransferProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForTransferProhibitionLockResponse>(DoRPCRequest("SaveSingleTaskForTransferProhibitionLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForTransferProhibitionLockResponse> SaveSingleTaskForTransferProhibitionLockWithOptionsAsync(SaveSingleTaskForTransferProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForTransferProhibitionLockResponse>(await DoRPCRequestAsync("SaveSingleTaskForTransferProhibitionLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForUpdateProhibitionLockResponse>(DoRPCRequest("SaveSingleTaskForUpdateProhibitionLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForUpdateProhibitionLockResponse> SaveSingleTaskForUpdateProhibitionLockWithOptionsAsync(SaveSingleTaskForUpdateProhibitionLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForUpdateProhibitionLockResponse>(await DoRPCRequestAsync("SaveSingleTaskForUpdateProhibitionLock", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForUpdatingContactInfoResponse>(DoRPCRequest("SaveSingleTaskForUpdatingContactInfo", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveSingleTaskForUpdatingContactInfoResponse> SaveSingleTaskForUpdatingContactInfoWithOptionsAsync(SaveSingleTaskForUpdatingContactInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveSingleTaskForUpdatingContactInfoResponse>(await DoRPCRequestAsync("SaveSingleTaskForUpdatingContactInfo", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainDeleteResponse>(DoRPCRequest("SaveTaskForSubmittingDomainDelete", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveTaskForSubmittingDomainDeleteResponse> SaveTaskForSubmittingDomainDeleteWithOptionsAsync(SaveTaskForSubmittingDomainDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainDeleteResponse>(await DoRPCRequestAsync("SaveTaskForSubmittingDomainDelete", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse>(DoRPCRequest("SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredential", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse> SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialWithOptionsAsync(SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse>(await DoRPCRequestAsync("SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredential", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse>(DoRPCRequest("SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileID", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse> SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDWithOptionsAsync(SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse>(await DoRPCRequestAsync("SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileID", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse>(DoRPCRequest("SaveTaskForUpdatingRegistrantInfoByIdentityCredential", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse> SaveTaskForUpdatingRegistrantInfoByIdentityCredentialWithOptionsAsync(SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse>(await DoRPCRequestAsync("SaveTaskForUpdatingRegistrantInfoByIdentityCredential", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse>(DoRPCRequest("SaveTaskForUpdatingRegistrantInfoByRegistrantProfileID", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse> SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDWithOptionsAsync(SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse>(await DoRPCRequestAsync("SaveTaskForUpdatingRegistrantInfoByRegistrantProfileID", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ScrollDomainListResponse ScrollDomainListWithOptions(ScrollDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ScrollDomainListResponse>(DoRPCRequest("ScrollDomainList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ScrollDomainListResponse> ScrollDomainListWithOptionsAsync(ScrollDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ScrollDomainListResponse>(await DoRPCRequestAsync("ScrollDomainList", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ScrollDomainListResponse ScrollDomainList(ScrollDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScrollDomainListWithOptions(request, runtime);
        }

        public async Task<ScrollDomainListResponse> ScrollDomainListAsync(ScrollDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScrollDomainListWithOptionsAsync(request, runtime);
        }

        public SubmitEmailVerificationResponse SubmitEmailVerificationWithOptions(SubmitEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitEmailVerificationResponse>(DoRPCRequest("SubmitEmailVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitEmailVerificationResponse> SubmitEmailVerificationWithOptionsAsync(SubmitEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitEmailVerificationResponse>(await DoRPCRequestAsync("SubmitEmailVerification", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SubmitOperationAuditInfoResponse SubmitOperationAuditInfoWithOptions(SubmitOperationAuditInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitOperationAuditInfoResponse>(DoRPCRequest("SubmitOperationAuditInfo", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitOperationAuditInfoResponse> SubmitOperationAuditInfoWithOptionsAsync(SubmitOperationAuditInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitOperationAuditInfoResponse>(await DoRPCRequestAsync("SubmitOperationAuditInfo", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitOperationAuditInfoResponse SubmitOperationAuditInfo(SubmitOperationAuditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitOperationAuditInfoWithOptions(request, runtime);
        }

        public async Task<SubmitOperationAuditInfoResponse> SubmitOperationAuditInfoAsync(SubmitOperationAuditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitOperationAuditInfoWithOptionsAsync(request, runtime);
        }

        public SubmitOperationCredentialsResponse SubmitOperationCredentialsWithOptions(SubmitOperationCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitOperationCredentialsResponse>(DoRPCRequest("SubmitOperationCredentials", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitOperationCredentialsResponse> SubmitOperationCredentialsWithOptionsAsync(SubmitOperationCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitOperationCredentialsResponse>(await DoRPCRequestAsync("SubmitOperationCredentials", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitOperationCredentialsResponse SubmitOperationCredentials(SubmitOperationCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitOperationCredentialsWithOptions(request, runtime);
        }

        public async Task<SubmitOperationCredentialsResponse> SubmitOperationCredentialsAsync(SubmitOperationCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitOperationCredentialsWithOptionsAsync(request, runtime);
        }

        public TransferInCheckMailTokenResponse TransferInCheckMailTokenWithOptions(TransferInCheckMailTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferInCheckMailTokenResponse>(DoRPCRequest("TransferInCheckMailToken", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransferInCheckMailTokenResponse> TransferInCheckMailTokenWithOptionsAsync(TransferInCheckMailTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferInCheckMailTokenResponse>(await DoRPCRequestAsync("TransferInCheckMailToken", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferInReenterTransferAuthorizationCodeResponse>(DoRPCRequest("TransferInReenterTransferAuthorizationCode", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransferInReenterTransferAuthorizationCodeResponse> TransferInReenterTransferAuthorizationCodeWithOptionsAsync(TransferInReenterTransferAuthorizationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferInReenterTransferAuthorizationCodeResponse>(await DoRPCRequestAsync("TransferInReenterTransferAuthorizationCode", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferInRefetchWhoisEmailResponse>(DoRPCRequest("TransferInRefetchWhoisEmail", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransferInRefetchWhoisEmailResponse> TransferInRefetchWhoisEmailWithOptionsAsync(TransferInRefetchWhoisEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferInRefetchWhoisEmailResponse>(await DoRPCRequestAsync("TransferInRefetchWhoisEmail", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferInResendMailTokenResponse>(DoRPCRequest("TransferInResendMailToken", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransferInResendMailTokenResponse> TransferInResendMailTokenWithOptionsAsync(TransferInResendMailTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferInResendMailTokenResponse>(await DoRPCRequestAsync("TransferInResendMailToken", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateDomainToDomainGroupResponse UpdateDomainToDomainGroupWithOptions(UpdateDomainToDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDomainToDomainGroupResponse>(DoRPCRequest("UpdateDomainToDomainGroup", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDomainToDomainGroupResponse> UpdateDomainToDomainGroupWithOptionsAsync(UpdateDomainToDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDomainToDomainGroupResponse>(await DoRPCRequestAsync("UpdateDomainToDomainGroup", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDomainToDomainGroupResponse UpdateDomainToDomainGroup(UpdateDomainToDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDomainToDomainGroupWithOptions(request, runtime);
        }

        public async Task<UpdateDomainToDomainGroupResponse> UpdateDomainToDomainGroupAsync(UpdateDomainToDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDomainToDomainGroupWithOptionsAsync(request, runtime);
        }

        public VerifyContactFieldResponse VerifyContactFieldWithOptions(VerifyContactFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyContactFieldResponse>(DoRPCRequest("VerifyContactField", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyContactFieldResponse> VerifyContactFieldWithOptionsAsync(VerifyContactFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyContactFieldResponse>(await DoRPCRequestAsync("VerifyContactField", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyEmailResponse>(DoRPCRequest("VerifyEmail", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyEmailResponse> VerifyEmailWithOptionsAsync(VerifyEmailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyEmailResponse>(await DoRPCRequestAsync("VerifyEmail", "2018-01-29", "HTTPS", "POST", "AK", "json", req, runtime));
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
