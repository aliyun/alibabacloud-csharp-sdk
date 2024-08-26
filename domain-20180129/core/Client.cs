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

        /**
         * @summary 确认任务结果
         *
         * @param request AcknowledgeTaskResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AcknowledgeTaskResultResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 确认任务结果
         *
         * @param request AcknowledgeTaskResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AcknowledgeTaskResultResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 确认任务结果
         *
         * @param request AcknowledgeTaskResultRequest
         * @return AcknowledgeTaskResultResponse
         */
        public AcknowledgeTaskResultResponse AcknowledgeTaskResult(AcknowledgeTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcknowledgeTaskResultWithOptions(request, runtime);
        }

        /**
         * @summary 确认任务结果
         *
         * @param request AcknowledgeTaskResultRequest
         * @return AcknowledgeTaskResultResponse
         */
        public async Task<AcknowledgeTaskResultResponse> AcknowledgeTaskResultAsync(AcknowledgeTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcknowledgeTaskResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 通过关键字进行批量模糊匹配
         *
         * @param request BatchFuzzyMatchDomainSensitiveWordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchFuzzyMatchDomainSensitiveWordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 通过关键字进行批量模糊匹配
         *
         * @param request BatchFuzzyMatchDomainSensitiveWordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchFuzzyMatchDomainSensitiveWordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 通过关键字进行批量模糊匹配
         *
         * @param request BatchFuzzyMatchDomainSensitiveWordRequest
         * @return BatchFuzzyMatchDomainSensitiveWordResponse
         */
        public BatchFuzzyMatchDomainSensitiveWordResponse BatchFuzzyMatchDomainSensitiveWord(BatchFuzzyMatchDomainSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchFuzzyMatchDomainSensitiveWordWithOptions(request, runtime);
        }

        /**
         * @summary 通过关键字进行批量模糊匹配
         *
         * @param request BatchFuzzyMatchDomainSensitiveWordRequest
         * @return BatchFuzzyMatchDomainSensitiveWordResponse
         */
        public async Task<BatchFuzzyMatchDomainSensitiveWordResponse> BatchFuzzyMatchDomainSensitiveWordAsync(BatchFuzzyMatchDomainSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchFuzzyMatchDomainSensitiveWordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Cancels real-name verification for a domain name.
         *
         * @param request CancelDomainVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelDomainVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary Cancels real-name verification for a domain name.
         *
         * @param request CancelDomainVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelDomainVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary Cancels real-name verification for a domain name.
         *
         * @param request CancelDomainVerificationRequest
         * @return CancelDomainVerificationResponse
         */
        public CancelDomainVerificationResponse CancelDomainVerification(CancelDomainVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDomainVerificationWithOptions(request, runtime);
        }

        /**
         * @summary Cancels real-name verification for a domain name.
         *
         * @param request CancelDomainVerificationRequest
         * @return CancelDomainVerificationResponse
         */
        public async Task<CancelDomainVerificationResponse> CancelDomainVerificationAsync(CancelDomainVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDomainVerificationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 取消审核
         *
         * @param request CancelOperationAuditRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelOperationAuditResponse
         */
        public CancelOperationAuditResponse CancelOperationAuditWithOptions(CancelOperationAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditRecordId))
            {
                query["AuditRecordId"] = request.AuditRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOperationAudit",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOperationAuditResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 取消审核
         *
         * @param request CancelOperationAuditRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelOperationAuditResponse
         */
        public async Task<CancelOperationAuditResponse> CancelOperationAuditWithOptionsAsync(CancelOperationAuditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditRecordId))
            {
                query["AuditRecordId"] = request.AuditRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOperationAudit",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOperationAuditResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 取消审核
         *
         * @param request CancelOperationAuditRequest
         * @return CancelOperationAuditResponse
         */
        public CancelOperationAuditResponse CancelOperationAudit(CancelOperationAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOperationAuditWithOptions(request, runtime);
        }

        /**
         * @summary 取消审核
         *
         * @param request CancelOperationAuditRequest
         * @return CancelOperationAuditResponse
         */
        public async Task<CancelOperationAuditResponse> CancelOperationAuditAsync(CancelOperationAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOperationAuditWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CancelQualificationVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelQualificationVerificationResponse
         */
        public CancelQualificationVerificationResponse CancelQualificationVerificationWithOptions(CancelQualificationVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationType))
            {
                query["QualificationType"] = request.QualificationType;
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
                Action = "CancelQualificationVerification",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelQualificationVerificationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CancelQualificationVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelQualificationVerificationResponse
         */
        public async Task<CancelQualificationVerificationResponse> CancelQualificationVerificationWithOptionsAsync(CancelQualificationVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationType))
            {
                query["QualificationType"] = request.QualificationType;
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
                Action = "CancelQualificationVerification",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelQualificationVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CancelQualificationVerificationRequest
         * @return CancelQualificationVerificationResponse
         */
        public CancelQualificationVerificationResponse CancelQualificationVerification(CancelQualificationVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelQualificationVerificationWithOptions(request, runtime);
        }

        /**
         * @param request CancelQualificationVerificationRequest
         * @return CancelQualificationVerificationResponse
         */
        public async Task<CancelQualificationVerificationResponse> CancelQualificationVerificationAsync(CancelQualificationVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelQualificationVerificationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CancelTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelTaskResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request CancelTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelTaskResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request CancelTaskRequest
         * @return CancelTaskResponse
         */
        public CancelTaskResponse CancelTask(CancelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelTaskWithOptions(request, runtime);
        }

        /**
         * @param request CancelTaskRequest
         * @return CancelTaskResponse
         */
        public async Task<CancelTaskResponse> CancelTaskAsync(CancelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改实例所在资源组
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
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
                Action = "ChangeResourceGroup",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改实例所在资源组
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
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
                Action = "ChangeResourceGroup",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改实例所在资源组
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary 修改实例所在资源组
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CheckDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckDomainResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDomain",
                Version = "2018-01-29",
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

        /**
         * @param request CheckDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckDomainResponse
         */
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDomain",
                Version = "2018-01-29",
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

        /**
         * @param request CheckDomainRequest
         * @return CheckDomainResponse
         */
        public CheckDomainResponse CheckDomain(CheckDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDomainWithOptions(request, runtime);
        }

        /**
         * @param request CheckDomainRequest
         * @return CheckDomainResponse
         */
        public async Task<CheckDomainResponse> CheckDomainAsync(CheckDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CheckDomainSunriseClaimRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckDomainSunriseClaimResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request CheckDomainSunriseClaimRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckDomainSunriseClaimResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request CheckDomainSunriseClaimRequest
         * @return CheckDomainSunriseClaimResponse
         */
        public CheckDomainSunriseClaimResponse CheckDomainSunriseClaim(CheckDomainSunriseClaimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDomainSunriseClaimWithOptions(request, runtime);
        }

        /**
         * @param request CheckDomainSunriseClaimRequest
         * @return CheckDomainSunriseClaimResponse
         */
        public async Task<CheckDomainSunriseClaimResponse> CheckDomainSunriseClaimAsync(CheckDomainSunriseClaimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDomainSunriseClaimWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CheckMaxYearOfServerLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckMaxYearOfServerLockResponse
         */
        public CheckMaxYearOfServerLockResponse CheckMaxYearOfServerLockWithOptions(CheckMaxYearOfServerLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckAction))
            {
                query["CheckAction"] = request.CheckAction;
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
                Action = "CheckMaxYearOfServerLock",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckMaxYearOfServerLockResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CheckMaxYearOfServerLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckMaxYearOfServerLockResponse
         */
        public async Task<CheckMaxYearOfServerLockResponse> CheckMaxYearOfServerLockWithOptionsAsync(CheckMaxYearOfServerLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckAction))
            {
                query["CheckAction"] = request.CheckAction;
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
                Action = "CheckMaxYearOfServerLock",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckMaxYearOfServerLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CheckMaxYearOfServerLockRequest
         * @return CheckMaxYearOfServerLockResponse
         */
        public CheckMaxYearOfServerLockResponse CheckMaxYearOfServerLock(CheckMaxYearOfServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMaxYearOfServerLockWithOptions(request, runtime);
        }

        /**
         * @param request CheckMaxYearOfServerLockRequest
         * @return CheckMaxYearOfServerLockResponse
         */
        public async Task<CheckMaxYearOfServerLockResponse> CheckMaxYearOfServerLockAsync(CheckMaxYearOfServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMaxYearOfServerLockWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CheckProcessingServerLockApplyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckProcessingServerLockApplyResponse
         */
        public CheckProcessingServerLockApplyResponse CheckProcessingServerLockApplyWithOptions(CheckProcessingServerLockApplyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "CheckProcessingServerLockApply",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckProcessingServerLockApplyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CheckProcessingServerLockApplyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckProcessingServerLockApplyResponse
         */
        public async Task<CheckProcessingServerLockApplyResponse> CheckProcessingServerLockApplyWithOptionsAsync(CheckProcessingServerLockApplyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
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
                Action = "CheckProcessingServerLockApply",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckProcessingServerLockApplyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CheckProcessingServerLockApplyRequest
         * @return CheckProcessingServerLockApplyResponse
         */
        public CheckProcessingServerLockApplyResponse CheckProcessingServerLockApply(CheckProcessingServerLockApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckProcessingServerLockApplyWithOptions(request, runtime);
        }

        /**
         * @param request CheckProcessingServerLockApplyRequest
         * @return CheckProcessingServerLockApplyResponse
         */
        public async Task<CheckProcessingServerLockApplyResponse> CheckProcessingServerLockApplyAsync(CheckProcessingServerLockApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckProcessingServerLockApplyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request CheckTransferInFeasibilityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckTransferInFeasibilityResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request CheckTransferInFeasibilityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckTransferInFeasibilityResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request CheckTransferInFeasibilityRequest
         * @return CheckTransferInFeasibilityResponse
         */
        public CheckTransferInFeasibilityResponse CheckTransferInFeasibility(CheckTransferInFeasibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckTransferInFeasibilityWithOptions(request, runtime);
        }

        /**
         * @param request CheckTransferInFeasibilityRequest
         * @return CheckTransferInFeasibilityResponse
         */
        public async Task<CheckTransferInFeasibilityResponse> CheckTransferInFeasibilityAsync(CheckTransferInFeasibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckTransferInFeasibilityWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ConfirmTransferInEmailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmTransferInEmailResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request ConfirmTransferInEmailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmTransferInEmailResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request ConfirmTransferInEmailRequest
         * @return ConfirmTransferInEmailResponse
         */
        public ConfirmTransferInEmailResponse ConfirmTransferInEmail(ConfirmTransferInEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmTransferInEmailWithOptions(request, runtime);
        }

        /**
         * @param request ConfirmTransferInEmailRequest
         * @return ConfirmTransferInEmailResponse
         */
        public async Task<ConfirmTransferInEmailResponse> ConfirmTransferInEmailAsync(ConfirmTransferInEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmTransferInEmailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量删除联系人模板
         *
         * @param request DeleteContactTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteContactTemplatesResponse
         */
        public DeleteContactTemplatesResponse DeleteContactTemplatesWithOptions(DeleteContactTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileIds))
            {
                query["RegistrantProfileIds"] = request.RegistrantProfileIds;
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
                Action = "DeleteContactTemplates",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量删除联系人模板
         *
         * @param request DeleteContactTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteContactTemplatesResponse
         */
        public async Task<DeleteContactTemplatesResponse> DeleteContactTemplatesWithOptionsAsync(DeleteContactTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrantProfileIds))
            {
                query["RegistrantProfileIds"] = request.RegistrantProfileIds;
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
                Action = "DeleteContactTemplates",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContactTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量删除联系人模板
         *
         * @param request DeleteContactTemplatesRequest
         * @return DeleteContactTemplatesResponse
         */
        public DeleteContactTemplatesResponse DeleteContactTemplates(DeleteContactTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContactTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary 批量删除联系人模板
         *
         * @param request DeleteContactTemplatesRequest
         * @return DeleteContactTemplatesResponse
         */
        public async Task<DeleteContactTemplatesResponse> DeleteContactTemplatesAsync(DeleteContactTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContactTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除域名分组
         *
         * @param request DeleteDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainGroupResponse
         */
        public DeleteDomainGroupResponse DeleteDomainGroupWithOptions(DeleteDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupId))
            {
                query["DomainGroupId"] = request.DomainGroupId;
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
                Action = "DeleteDomainGroup",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除域名分组
         *
         * @param request DeleteDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDomainGroupResponse
         */
        public async Task<DeleteDomainGroupResponse> DeleteDomainGroupWithOptionsAsync(DeleteDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupId))
            {
                query["DomainGroupId"] = request.DomainGroupId;
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
                Action = "DeleteDomainGroup",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDomainGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除域名分组
         *
         * @param request DeleteDomainGroupRequest
         * @return DeleteDomainGroupResponse
         */
        public DeleteDomainGroupResponse DeleteDomainGroup(DeleteDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainGroupWithOptions(request, runtime);
        }

        /**
         * @summary 删除域名分组
         *
         * @param request DeleteDomainGroupRequest
         * @return DeleteDomainGroupResponse
         */
        public async Task<DeleteDomainGroupResponse> DeleteDomainGroupAsync(DeleteDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除邮箱验证
         *
         * @param request DeleteEmailVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEmailVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 删除邮箱验证
         *
         * @param request DeleteEmailVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEmailVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 删除邮箱验证
         *
         * @param request DeleteEmailVerificationRequest
         * @return DeleteEmailVerificationResponse
         */
        public DeleteEmailVerificationResponse DeleteEmailVerification(DeleteEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEmailVerificationWithOptions(request, runtime);
        }

        /**
         * @summary 删除邮箱验证
         *
         * @param request DeleteEmailVerificationRequest
         * @return DeleteEmailVerificationResponse
         */
        public async Task<DeleteEmailVerificationResponse> DeleteEmailVerificationAsync(DeleteEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEmailVerificationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除联系人模板
         *
         * @param request DeleteRegistrantProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRegistrantProfileResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 删除联系人模板
         *
         * @param request DeleteRegistrantProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRegistrantProfileResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 删除联系人模板
         *
         * @param request DeleteRegistrantProfileRequest
         * @return DeleteRegistrantProfileResponse
         */
        public DeleteRegistrantProfileResponse DeleteRegistrantProfile(DeleteRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRegistrantProfileWithOptions(request, runtime);
        }

        /**
         * @summary 删除联系人模板
         *
         * @param request DeleteRegistrantProfileRequest
         * @return DeleteRegistrantProfileResponse
         */
        public async Task<DeleteRegistrantProfileResponse> DeleteRegistrantProfileAsync(DeleteRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRegistrantProfileWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 取消域名特殊业务流程
         *
         * @param request DomainSpecialBizCancelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DomainSpecialBizCancelResponse
         */
        public DomainSpecialBizCancelResponse DomainSpecialBizCancelWithOptions(DomainSpecialBizCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DomainSpecialBizCancel",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DomainSpecialBizCancelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 取消域名特殊业务流程
         *
         * @param request DomainSpecialBizCancelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DomainSpecialBizCancelResponse
         */
        public async Task<DomainSpecialBizCancelResponse> DomainSpecialBizCancelWithOptionsAsync(DomainSpecialBizCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DomainSpecialBizCancel",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DomainSpecialBizCancelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 取消域名特殊业务流程
         *
         * @param request DomainSpecialBizCancelRequest
         * @return DomainSpecialBizCancelResponse
         */
        public DomainSpecialBizCancelResponse DomainSpecialBizCancel(DomainSpecialBizCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DomainSpecialBizCancelWithOptions(request, runtime);
        }

        /**
         * @summary 取消域名特殊业务流程
         *
         * @param request DomainSpecialBizCancelRequest
         * @return DomainSpecialBizCancelResponse
         */
        public async Task<DomainSpecialBizCancelResponse> DomainSpecialBizCancelAsync(DomainSpecialBizCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DomainSpecialBizCancelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 邮箱验证通过
         *
         * @param request EmailVerifiedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EmailVerifiedResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 邮箱验证通过
         *
         * @param request EmailVerifiedRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EmailVerifiedResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 邮箱验证通过
         *
         * @param request EmailVerifiedRequest
         * @return EmailVerifiedResponse
         */
        public EmailVerifiedResponse EmailVerified(EmailVerifiedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EmailVerifiedWithOptions(request, runtime);
        }

        /**
         * @summary 邮箱验证通过
         *
         * @param request EmailVerifiedRequest
         * @return EmailVerifiedResponse
         */
        public async Task<EmailVerifiedResponse> EmailVerifiedAsync(EmailVerifiedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EmailVerifiedWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 通过关键字进行模糊匹配
         *
         * @param request FuzzyMatchDomainSensitiveWordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FuzzyMatchDomainSensitiveWordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 通过关键字进行模糊匹配
         *
         * @param request FuzzyMatchDomainSensitiveWordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FuzzyMatchDomainSensitiveWordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 通过关键字进行模糊匹配
         *
         * @param request FuzzyMatchDomainSensitiveWordRequest
         * @return FuzzyMatchDomainSensitiveWordResponse
         */
        public FuzzyMatchDomainSensitiveWordResponse FuzzyMatchDomainSensitiveWord(FuzzyMatchDomainSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FuzzyMatchDomainSensitiveWordWithOptions(request, runtime);
        }

        /**
         * @summary 通过关键字进行模糊匹配
         *
         * @param request FuzzyMatchDomainSensitiveWordRequest
         * @return FuzzyMatchDomainSensitiveWordResponse
         */
        public async Task<FuzzyMatchDomainSensitiveWordResponse> FuzzyMatchDomainSensitiveWordAsync(FuzzyMatchDomainSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FuzzyMatchDomainSensitiveWordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetOperationOssUploadPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOperationOssUploadPolicyResponse
         */
        public GetOperationOssUploadPolicyResponse GetOperationOssUploadPolicyWithOptions(GetOperationOssUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditType))
            {
                query["AuditType"] = request.AuditType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOperationOssUploadPolicy",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOperationOssUploadPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetOperationOssUploadPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOperationOssUploadPolicyResponse
         */
        public async Task<GetOperationOssUploadPolicyResponse> GetOperationOssUploadPolicyWithOptionsAsync(GetOperationOssUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditType))
            {
                query["AuditType"] = request.AuditType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOperationOssUploadPolicy",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOperationOssUploadPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetOperationOssUploadPolicyRequest
         * @return GetOperationOssUploadPolicyResponse
         */
        public GetOperationOssUploadPolicyResponse GetOperationOssUploadPolicy(GetOperationOssUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOperationOssUploadPolicyWithOptions(request, runtime);
        }

        /**
         * @param request GetOperationOssUploadPolicyRequest
         * @return GetOperationOssUploadPolicyResponse
         */
        public async Task<GetOperationOssUploadPolicyResponse> GetOperationOssUploadPolicyAsync(GetOperationOssUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOperationOssUploadPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetQualificationUploadPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQualificationUploadPolicyResponse
         */
        public GetQualificationUploadPolicyResponse GetQualificationUploadPolicyWithOptions(GetQualificationUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetQualificationUploadPolicy",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualificationUploadPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetQualificationUploadPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQualificationUploadPolicyResponse
         */
        public async Task<GetQualificationUploadPolicyResponse> GetQualificationUploadPolicyWithOptionsAsync(GetQualificationUploadPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetQualificationUploadPolicy",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQualificationUploadPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetQualificationUploadPolicyRequest
         * @return GetQualificationUploadPolicyResponse
         */
        public GetQualificationUploadPolicyResponse GetQualificationUploadPolicy(GetQualificationUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualificationUploadPolicyWithOptions(request, runtime);
        }

        /**
         * @param request GetQualificationUploadPolicyRequest
         * @return GetQualificationUploadPolicyResponse
         */
        public async Task<GetQualificationUploadPolicyResponse> GetQualificationUploadPolicyAsync(GetQualificationUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualificationUploadPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListEmailVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEmailVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request ListEmailVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEmailVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request ListEmailVerificationRequest
         * @return ListEmailVerificationResponse
         */
        public ListEmailVerificationResponse ListEmailVerification(ListEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEmailVerificationWithOptions(request, runtime);
        }

        /**
         * @param request ListEmailVerificationRequest
         * @return ListEmailVerificationResponse
         */
        public async Task<ListEmailVerificationResponse> ListEmailVerificationAsync(ListEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEmailVerificationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries information about domain names for which registry locks are enabled.
         *
         * @param request ListServerLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServerLockResponse
         */
        public ListServerLockResponse ListServerLockWithOptions(ListServerLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginStartDate))
            {
                query["BeginStartDate"] = request.BeginStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndExpireDate))
            {
                query["EndExpireDate"] = request.EndExpireDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndStartDate))
            {
                query["EndStartDate"] = request.EndStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockProductId))
            {
                query["LockProductId"] = request.LockProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByType))
            {
                query["OrderByType"] = request.OrderByType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerLockStatus))
            {
                query["ServerLockStatus"] = request.ServerLockStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartExpireDate))
            {
                query["StartExpireDate"] = request.StartExpireDate;
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
                Action = "ListServerLock",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServerLockResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries information about domain names for which registry locks are enabled.
         *
         * @param request ListServerLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServerLockResponse
         */
        public async Task<ListServerLockResponse> ListServerLockWithOptionsAsync(ListServerLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginStartDate))
            {
                query["BeginStartDate"] = request.BeginStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndExpireDate))
            {
                query["EndExpireDate"] = request.EndExpireDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndStartDate))
            {
                query["EndStartDate"] = request.EndStartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LockProductId))
            {
                query["LockProductId"] = request.LockProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderByType))
            {
                query["OrderByType"] = request.OrderByType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerLockStatus))
            {
                query["ServerLockStatus"] = request.ServerLockStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartExpireDate))
            {
                query["StartExpireDate"] = request.StartExpireDate;
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
                Action = "ListServerLock",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServerLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries information about domain names for which registry locks are enabled.
         *
         * @param request ListServerLockRequest
         * @return ListServerLockResponse
         */
        public ListServerLockResponse ListServerLock(ListServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServerLockWithOptions(request, runtime);
        }

        /**
         * @summary Queries information about domain names for which registry locks are enabled.
         *
         * @param request ListServerLockRequest
         * @return ListServerLockResponse
         */
        public async Task<ListServerLockResponse> ListServerLockAsync(ListServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServerLockWithOptionsAsync(request, runtime);
        }

        /**
         * @param request LookupTmchNoticeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LookupTmchNoticeResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request LookupTmchNoticeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LookupTmchNoticeResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request LookupTmchNoticeRequest
         * @return LookupTmchNoticeResponse
         */
        public LookupTmchNoticeResponse LookupTmchNotice(LookupTmchNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LookupTmchNoticeWithOptions(request, runtime);
        }

        /**
         * @param request LookupTmchNoticeRequest
         * @return LookupTmchNoticeResponse
         */
        public async Task<LookupTmchNoticeResponse> LookupTmchNoticeAsync(LookupTmchNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LookupTmchNoticeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request PollTaskResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PollTaskResultResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request PollTaskResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PollTaskResultResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request PollTaskResultRequest
         * @return PollTaskResultResponse
         */
        public PollTaskResultResponse PollTaskResult(PollTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PollTaskResultWithOptions(request, runtime);
        }

        /**
         * @param request PollTaskResultRequest
         * @return PollTaskResultResponse
         */
        public async Task<PollTaskResultResponse> PollTaskResultAsync(PollTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PollTaskResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 搜索域名列表
         *
         * @param request QueryAdvancedDomainListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAdvancedDomainListResponse
         */
        public QueryAdvancedDomainListResponse QueryAdvancedDomainListWithOptions(QueryAdvancedDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupId))
            {
                query["DomainGroupId"] = request.DomainGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNameSort))
            {
                query["DomainNameSort"] = request.DomainNameSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainStatus))
            {
                query["DomainStatus"] = request.DomainStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndExpirationDate))
            {
                query["EndExpirationDate"] = request.EndExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndLength))
            {
                query["EndLength"] = request.EndLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndRegistrationDate))
            {
                query["EndRegistrationDate"] = request.EndRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Excluded))
            {
                query["Excluded"] = request.Excluded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedPrefix))
            {
                query["ExcludedPrefix"] = request.ExcludedPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedSuffix))
            {
                query["ExcludedSuffix"] = request.ExcludedSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationDateSort))
            {
                query["ExpirationDateSort"] = request.ExpirationDateSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Form))
            {
                query["Form"] = request.Form;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPremiumDomain))
            {
                query["IsPremiumDomain"] = request.IsPremiumDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWordPrefix))
            {
                query["KeyWordPrefix"] = request.KeyWordPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWordSuffix))
            {
                query["KeyWordSuffix"] = request.KeyWordSuffix;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDomainType))
            {
                query["ProductDomainType"] = request.ProductDomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDomainTypeSort))
            {
                query["ProductDomainTypeSort"] = request.ProductDomainTypeSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationDateSort))
            {
                query["RegistrationDateSort"] = request.RegistrationDateSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartExpirationDate))
            {
                query["StartExpirationDate"] = request.StartExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartLength))
            {
                query["StartLength"] = request.StartLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRegistrationDate))
            {
                query["StartRegistrationDate"] = request.StartRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Suffixs))
            {
                query["Suffixs"] = request.Suffixs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeType))
            {
                query["TradeType"] = request.TradeType;
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
                Action = "QueryAdvancedDomainList",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAdvancedDomainListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 搜索域名列表
         *
         * @param request QueryAdvancedDomainListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAdvancedDomainListResponse
         */
        public async Task<QueryAdvancedDomainListResponse> QueryAdvancedDomainListWithOptionsAsync(QueryAdvancedDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupId))
            {
                query["DomainGroupId"] = request.DomainGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNameSort))
            {
                query["DomainNameSort"] = request.DomainNameSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainStatus))
            {
                query["DomainStatus"] = request.DomainStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndExpirationDate))
            {
                query["EndExpirationDate"] = request.EndExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndLength))
            {
                query["EndLength"] = request.EndLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndRegistrationDate))
            {
                query["EndRegistrationDate"] = request.EndRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Excluded))
            {
                query["Excluded"] = request.Excluded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedPrefix))
            {
                query["ExcludedPrefix"] = request.ExcludedPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedSuffix))
            {
                query["ExcludedSuffix"] = request.ExcludedSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationDateSort))
            {
                query["ExpirationDateSort"] = request.ExpirationDateSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Form))
            {
                query["Form"] = request.Form;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPremiumDomain))
            {
                query["IsPremiumDomain"] = request.IsPremiumDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWordPrefix))
            {
                query["KeyWordPrefix"] = request.KeyWordPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWordSuffix))
            {
                query["KeyWordSuffix"] = request.KeyWordSuffix;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDomainType))
            {
                query["ProductDomainType"] = request.ProductDomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDomainTypeSort))
            {
                query["ProductDomainTypeSort"] = request.ProductDomainTypeSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistrationDateSort))
            {
                query["RegistrationDateSort"] = request.RegistrationDateSort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartExpirationDate))
            {
                query["StartExpirationDate"] = request.StartExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartLength))
            {
                query["StartLength"] = request.StartLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRegistrationDate))
            {
                query["StartRegistrationDate"] = request.StartRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Suffixs))
            {
                query["Suffixs"] = request.Suffixs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeType))
            {
                query["TradeType"] = request.TradeType;
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
                Action = "QueryAdvancedDomainList",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAdvancedDomainListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 搜索域名列表
         *
         * @param request QueryAdvancedDomainListRequest
         * @return QueryAdvancedDomainListResponse
         */
        public QueryAdvancedDomainListResponse QueryAdvancedDomainList(QueryAdvancedDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAdvancedDomainListWithOptions(request, runtime);
        }

        /**
         * @summary 搜索域名列表
         *
         * @param request QueryAdvancedDomainListRequest
         * @return QueryAdvancedDomainListResponse
         */
        public async Task<QueryAdvancedDomainListResponse> QueryAdvancedDomainListAsync(QueryAdvancedDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAdvancedDomainListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryArtExtensionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryArtExtensionResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryArtExtensionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryArtExtensionResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryArtExtensionRequest
         * @return QueryArtExtensionResponse
         */
        public QueryArtExtensionResponse QueryArtExtension(QueryArtExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryArtExtensionWithOptions(request, runtime);
        }

        /**
         * @param request QueryArtExtensionRequest
         * @return QueryArtExtensionResponse
         */
        public async Task<QueryArtExtensionResponse> QueryArtExtensionAsync(QueryArtExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryArtExtensionWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryChangeLogListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryChangeLogListResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryChangeLogListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryChangeLogListResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryChangeLogListRequest
         * @return QueryChangeLogListResponse
         */
        public QueryChangeLogListResponse QueryChangeLogList(QueryChangeLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryChangeLogListWithOptions(request, runtime);
        }

        /**
         * @param request QueryChangeLogListRequest
         * @return QueryChangeLogListResponse
         */
        public async Task<QueryChangeLogListResponse> QueryChangeLogListAsync(QueryChangeLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryChangeLogListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryContactInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryContactInfoResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryContactInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryContactInfoResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryContactInfoRequest
         * @return QueryContactInfoResponse
         */
        public QueryContactInfoResponse QueryContactInfo(QueryContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryContactInfoWithOptions(request, runtime);
        }

        /**
         * @param request QueryContactInfoRequest
         * @return QueryContactInfoResponse
         */
        public async Task<QueryContactInfoResponse> QueryContactInfoAsync(QueryContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryContactInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryDSRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDSRecordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryDSRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDSRecordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryDSRecordRequest
         * @return QueryDSRecordResponse
         */
        public QueryDSRecordResponse QueryDSRecord(QueryDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDSRecordWithOptions(request, runtime);
        }

        /**
         * @param request QueryDSRecordRequest
         * @return QueryDSRecordResponse
         */
        public async Task<QueryDSRecordResponse> QueryDSRecordAsync(QueryDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDSRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryDnsHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDnsHostResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryDnsHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDnsHostResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryDnsHostRequest
         * @return QueryDnsHostResponse
         */
        public QueryDnsHostResponse QueryDnsHost(QueryDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDnsHostWithOptions(request, runtime);
        }

        /**
         * @param request QueryDnsHostRequest
         * @return QueryDnsHostResponse
         */
        public async Task<QueryDnsHostResponse> QueryDnsHostAsync(QueryDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDnsHostWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryDomainAdminDivisionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainAdminDivisionResponse
         */
        public QueryDomainAdminDivisionResponse QueryDomainAdminDivisionWithOptions(QueryDomainAdminDivisionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryDomainAdminDivision",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainAdminDivisionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryDomainAdminDivisionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainAdminDivisionResponse
         */
        public async Task<QueryDomainAdminDivisionResponse> QueryDomainAdminDivisionWithOptionsAsync(QueryDomainAdminDivisionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryDomainAdminDivision",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainAdminDivisionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryDomainAdminDivisionRequest
         * @return QueryDomainAdminDivisionResponse
         */
        public QueryDomainAdminDivisionResponse QueryDomainAdminDivision(QueryDomainAdminDivisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainAdminDivisionWithOptions(request, runtime);
        }

        /**
         * @param request QueryDomainAdminDivisionRequest
         * @return QueryDomainAdminDivisionResponse
         */
        public async Task<QueryDomainAdminDivisionResponse> QueryDomainAdminDivisionAsync(QueryDomainAdminDivisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainAdminDivisionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a domain name.
         *
         * @param request QueryDomainByDomainNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainByDomainNameResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary Queries the information about a domain name.
         *
         * @param request QueryDomainByDomainNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainByDomainNameResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary Queries the information about a domain name.
         *
         * @param request QueryDomainByDomainNameRequest
         * @return QueryDomainByDomainNameResponse
         */
        public QueryDomainByDomainNameResponse QueryDomainByDomainName(QueryDomainByDomainNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainByDomainNameWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a domain name.
         *
         * @param request QueryDomainByDomainNameRequest
         * @return QueryDomainByDomainNameResponse
         */
        public async Task<QueryDomainByDomainNameResponse> QueryDomainByDomainNameAsync(QueryDomainByDomainNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainByDomainNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据实例id查询域名信息
         *
         * @param request QueryDomainByInstanceIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainByInstanceIdResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 根据实例id查询域名信息
         *
         * @param request QueryDomainByInstanceIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainByInstanceIdResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 根据实例id查询域名信息
         *
         * @param request QueryDomainByInstanceIdRequest
         * @return QueryDomainByInstanceIdResponse
         */
        public QueryDomainByInstanceIdResponse QueryDomainByInstanceId(QueryDomainByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainByInstanceIdWithOptions(request, runtime);
        }

        /**
         * @summary 根据实例id查询域名信息
         *
         * @param request QueryDomainByInstanceIdRequest
         * @return QueryDomainByInstanceIdResponse
         */
        public async Task<QueryDomainByInstanceIdResponse> QueryDomainByInstanceIdAsync(QueryDomainByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainByInstanceIdWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryDomainGroupListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainGroupListResponse
         */
        public QueryDomainGroupListResponse QueryDomainGroupListWithOptions(QueryDomainGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupName))
            {
                query["DomainGroupName"] = request.DomainGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDeletingGroup))
            {
                query["ShowDeletingGroup"] = request.ShowDeletingGroup;
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
                Action = "QueryDomainGroupList",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainGroupListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryDomainGroupListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainGroupListResponse
         */
        public async Task<QueryDomainGroupListResponse> QueryDomainGroupListWithOptionsAsync(QueryDomainGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupName))
            {
                query["DomainGroupName"] = request.DomainGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShowDeletingGroup))
            {
                query["ShowDeletingGroup"] = request.ShowDeletingGroup;
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
                Action = "QueryDomainGroupList",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainGroupListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryDomainGroupListRequest
         * @return QueryDomainGroupListResponse
         */
        public QueryDomainGroupListResponse QueryDomainGroupList(QueryDomainGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainGroupListWithOptions(request, runtime);
        }

        /**
         * @param request QueryDomainGroupListRequest
         * @return QueryDomainGroupListResponse
         */
        public async Task<QueryDomainGroupListResponse> QueryDomainGroupListAsync(QueryDomainGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainGroupListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of domain names within your Alibaba Cloud account by page.
         *
         * @param request QueryDomainListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainListResponse
         */
        public QueryDomainListResponse QueryDomainListWithOptions(QueryDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ccompany))
            {
                query["Ccompany"] = request.Ccompany;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupId))
            {
                query["DomainGroupId"] = request.DomainGroupId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartExpirationDate))
            {
                query["StartExpirationDate"] = request.StartExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRegistrationDate))
            {
                query["StartRegistrationDate"] = request.StartRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Version = "2018-01-29",
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

        /**
         * @summary Queries a list of domain names within your Alibaba Cloud account by page.
         *
         * @param request QueryDomainListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainListResponse
         */
        public async Task<QueryDomainListResponse> QueryDomainListWithOptionsAsync(QueryDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ccompany))
            {
                query["Ccompany"] = request.Ccompany;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupId))
            {
                query["DomainGroupId"] = request.DomainGroupId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartExpirationDate))
            {
                query["StartExpirationDate"] = request.StartExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRegistrationDate))
            {
                query["StartRegistrationDate"] = request.StartRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Version = "2018-01-29",
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

        /**
         * @summary Queries a list of domain names within your Alibaba Cloud account by page.
         *
         * @param request QueryDomainListRequest
         * @return QueryDomainListResponse
         */
        public QueryDomainListResponse QueryDomainList(QueryDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainListWithOptions(request, runtime);
        }

        /**
         * @summary Queries a list of domain names within your Alibaba Cloud account by page.
         *
         * @param request QueryDomainListRequest
         * @return QueryDomainListResponse
         */
        public async Task<QueryDomainListResponse> QueryDomainListAsync(QueryDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryDomainRealNameVerificationInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainRealNameVerificationInfoResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryDomainRealNameVerificationInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainRealNameVerificationInfoResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryDomainRealNameVerificationInfoRequest
         * @return QueryDomainRealNameVerificationInfoResponse
         */
        public QueryDomainRealNameVerificationInfoResponse QueryDomainRealNameVerificationInfo(QueryDomainRealNameVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainRealNameVerificationInfoWithOptions(request, runtime);
        }

        /**
         * @param request QueryDomainRealNameVerificationInfoRequest
         * @return QueryDomainRealNameVerificationInfoResponse
         */
        public async Task<QueryDomainRealNameVerificationInfoResponse> QueryDomainRealNameVerificationInfoAsync(QueryDomainRealNameVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainRealNameVerificationInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询域名特殊业务详情
         *
         * @param request QueryDomainSpecialBizDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainSpecialBizDetailResponse
         */
        public QueryDomainSpecialBizDetailResponse QueryDomainSpecialBizDetailWithOptions(QueryDomainSpecialBizDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainSpecialBizDetail",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainSpecialBizDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询域名特殊业务详情
         *
         * @param request QueryDomainSpecialBizDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainSpecialBizDetailResponse
         */
        public async Task<QueryDomainSpecialBizDetailResponse> QueryDomainSpecialBizDetailWithOptionsAsync(QueryDomainSpecialBizDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainSpecialBizDetail",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainSpecialBizDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询域名特殊业务详情
         *
         * @param request QueryDomainSpecialBizDetailRequest
         * @return QueryDomainSpecialBizDetailResponse
         */
        public QueryDomainSpecialBizDetailResponse QueryDomainSpecialBizDetail(QueryDomainSpecialBizDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainSpecialBizDetailWithOptions(request, runtime);
        }

        /**
         * @summary 查询域名特殊业务详情
         *
         * @param request QueryDomainSpecialBizDetailRequest
         * @return QueryDomainSpecialBizDetailResponse
         */
        public async Task<QueryDomainSpecialBizDetailResponse> QueryDomainSpecialBizDetailAsync(QueryDomainSpecialBizDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainSpecialBizDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 通过域名查询域名特殊业务详情
         *
         * @param request QueryDomainSpecialBizInfoByDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainSpecialBizInfoByDomainResponse
         */
        public QueryDomainSpecialBizInfoByDomainResponse QueryDomainSpecialBizInfoByDomainWithOptions(QueryDomainSpecialBizInfoByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainSpecialBizInfoByDomain",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainSpecialBizInfoByDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 通过域名查询域名特殊业务详情
         *
         * @param request QueryDomainSpecialBizInfoByDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainSpecialBizInfoByDomainResponse
         */
        public async Task<QueryDomainSpecialBizInfoByDomainResponse> QueryDomainSpecialBizInfoByDomainWithOptionsAsync(QueryDomainSpecialBizInfoByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                body["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainSpecialBizInfoByDomain",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainSpecialBizInfoByDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 通过域名查询域名特殊业务详情
         *
         * @param request QueryDomainSpecialBizInfoByDomainRequest
         * @return QueryDomainSpecialBizInfoByDomainResponse
         */
        public QueryDomainSpecialBizInfoByDomainResponse QueryDomainSpecialBizInfoByDomain(QueryDomainSpecialBizInfoByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainSpecialBizInfoByDomainWithOptions(request, runtime);
        }

        /**
         * @summary 通过域名查询域名特殊业务详情
         *
         * @param request QueryDomainSpecialBizInfoByDomainRequest
         * @return QueryDomainSpecialBizInfoByDomainResponse
         */
        public async Task<QueryDomainSpecialBizInfoByDomainResponse> QueryDomainSpecialBizInfoByDomainAsync(QueryDomainSpecialBizInfoByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainSpecialBizInfoByDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryDomainSuffixRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainSuffixResponse
         */
        public QueryDomainSuffixResponse QueryDomainSuffixWithOptions(QueryDomainSuffixRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryDomainSuffix",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainSuffixResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryDomainSuffixRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryDomainSuffixResponse
         */
        public async Task<QueryDomainSuffixResponse> QueryDomainSuffixWithOptionsAsync(QueryDomainSuffixRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "QueryDomainSuffix",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainSuffixResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryDomainSuffixRequest
         * @return QueryDomainSuffixResponse
         */
        public QueryDomainSuffixResponse QueryDomainSuffix(QueryDomainSuffixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainSuffixWithOptions(request, runtime);
        }

        /**
         * @param request QueryDomainSuffixRequest
         * @return QueryDomainSuffixResponse
         */
        public async Task<QueryDomainSuffixResponse> QueryDomainSuffixAsync(QueryDomainSuffixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainSuffixWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询邮箱验证状态
         *
         * @param request QueryEmailVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEmailVerificationResponse
         */
        public QueryEmailVerificationResponse QueryEmailVerificationWithOptions(QueryEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryEmailVerification",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEmailVerificationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询邮箱验证状态
         *
         * @param request QueryEmailVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEmailVerificationResponse
         */
        public async Task<QueryEmailVerificationResponse> QueryEmailVerificationWithOptionsAsync(QueryEmailVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryEmailVerification",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEmailVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询邮箱验证状态
         *
         * @param request QueryEmailVerificationRequest
         * @return QueryEmailVerificationResponse
         */
        public QueryEmailVerificationResponse QueryEmailVerification(QueryEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEmailVerificationWithOptions(request, runtime);
        }

        /**
         * @summary 查询邮箱验证状态
         *
         * @param request QueryEmailVerificationRequest
         * @return QueryEmailVerificationResponse
         */
        public async Task<QueryEmailVerificationResponse> QueryEmailVerificationAsync(QueryEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEmailVerificationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryEnsAssociationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEnsAssociationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryEnsAssociationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryEnsAssociationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryEnsAssociationRequest
         * @return QueryEnsAssociationResponse
         */
        public QueryEnsAssociationResponse QueryEnsAssociation(QueryEnsAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEnsAssociationWithOptions(request, runtime);
        }

        /**
         * @param request QueryEnsAssociationRequest
         * @return QueryEnsAssociationResponse
         */
        public async Task<QueryEnsAssociationResponse> QueryEnsAssociationAsync(QueryEnsAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEnsAssociationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryFailReasonForDomainRealNameVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFailReasonForDomainRealNameVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryFailReasonForDomainRealNameVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFailReasonForDomainRealNameVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryFailReasonForDomainRealNameVerificationRequest
         * @return QueryFailReasonForDomainRealNameVerificationResponse
         */
        public QueryFailReasonForDomainRealNameVerificationResponse QueryFailReasonForDomainRealNameVerification(QueryFailReasonForDomainRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFailReasonForDomainRealNameVerificationWithOptions(request, runtime);
        }

        /**
         * @param request QueryFailReasonForDomainRealNameVerificationRequest
         * @return QueryFailReasonForDomainRealNameVerificationResponse
         */
        public async Task<QueryFailReasonForDomainRealNameVerificationResponse> QueryFailReasonForDomainRealNameVerificationAsync(QueryFailReasonForDomainRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFailReasonForDomainRealNameVerificationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryFailReasonForRegistrantProfileRealNameVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFailReasonForRegistrantProfileRealNameVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryFailReasonForRegistrantProfileRealNameVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFailReasonForRegistrantProfileRealNameVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryFailReasonForRegistrantProfileRealNameVerificationRequest
         * @return QueryFailReasonForRegistrantProfileRealNameVerificationResponse
         */
        public QueryFailReasonForRegistrantProfileRealNameVerificationResponse QueryFailReasonForRegistrantProfileRealNameVerification(QueryFailReasonForRegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFailReasonForRegistrantProfileRealNameVerificationWithOptions(request, runtime);
        }

        /**
         * @param request QueryFailReasonForRegistrantProfileRealNameVerificationRequest
         * @return QueryFailReasonForRegistrantProfileRealNameVerificationResponse
         */
        public async Task<QueryFailReasonForRegistrantProfileRealNameVerificationResponse> QueryFailReasonForRegistrantProfileRealNameVerificationAsync(QueryFailReasonForRegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFailReasonForRegistrantProfileRealNameVerificationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryFailingReasonListForQualificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFailingReasonListForQualificationResponse
         */
        public QueryFailingReasonListForQualificationResponse QueryFailingReasonListForQualificationWithOptions(QueryFailingReasonListForQualificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationType))
            {
                query["QualificationType"] = request.QualificationType;
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
                Action = "QueryFailingReasonListForQualification",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFailingReasonListForQualificationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryFailingReasonListForQualificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryFailingReasonListForQualificationResponse
         */
        public async Task<QueryFailingReasonListForQualificationResponse> QueryFailingReasonListForQualificationWithOptionsAsync(QueryFailingReasonListForQualificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationType))
            {
                query["QualificationType"] = request.QualificationType;
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
                Action = "QueryFailingReasonListForQualification",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryFailingReasonListForQualificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryFailingReasonListForQualificationRequest
         * @return QueryFailingReasonListForQualificationResponse
         */
        public QueryFailingReasonListForQualificationResponse QueryFailingReasonListForQualification(QueryFailingReasonListForQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFailingReasonListForQualificationWithOptions(request, runtime);
        }

        /**
         * @param request QueryFailingReasonListForQualificationRequest
         * @return QueryFailingReasonListForQualificationResponse
         */
        public async Task<QueryFailingReasonListForQualificationResponse> QueryFailingReasonListForQualificationAsync(QueryFailingReasonListForQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFailingReasonListForQualificationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryLocalEnsAssociationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryLocalEnsAssociationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryLocalEnsAssociationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryLocalEnsAssociationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryLocalEnsAssociationRequest
         * @return QueryLocalEnsAssociationResponse
         */
        public QueryLocalEnsAssociationResponse QueryLocalEnsAssociation(QueryLocalEnsAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLocalEnsAssociationWithOptions(request, runtime);
        }

        /**
         * @param request QueryLocalEnsAssociationRequest
         * @return QueryLocalEnsAssociationResponse
         */
        public async Task<QueryLocalEnsAssociationResponse> QueryLocalEnsAssociationAsync(QueryLocalEnsAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLocalEnsAssociationWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryOperationAuditInfoDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOperationAuditInfoDetailResponse
         */
        public QueryOperationAuditInfoDetailResponse QueryOperationAuditInfoDetailWithOptions(QueryOperationAuditInfoDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditRecordId))
            {
                query["AuditRecordId"] = request.AuditRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOperationAuditInfoDetail",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOperationAuditInfoDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryOperationAuditInfoDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOperationAuditInfoDetailResponse
         */
        public async Task<QueryOperationAuditInfoDetailResponse> QueryOperationAuditInfoDetailWithOptionsAsync(QueryOperationAuditInfoDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditRecordId))
            {
                query["AuditRecordId"] = request.AuditRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOperationAuditInfoDetail",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOperationAuditInfoDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryOperationAuditInfoDetailRequest
         * @return QueryOperationAuditInfoDetailResponse
         */
        public QueryOperationAuditInfoDetailResponse QueryOperationAuditInfoDetail(QueryOperationAuditInfoDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOperationAuditInfoDetailWithOptions(request, runtime);
        }

        /**
         * @param request QueryOperationAuditInfoDetailRequest
         * @return QueryOperationAuditInfoDetailResponse
         */
        public async Task<QueryOperationAuditInfoDetailResponse> QueryOperationAuditInfoDetailAsync(QueryOperationAuditInfoDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOperationAuditInfoDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryOperationAuditInfoListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOperationAuditInfoListResponse
         */
        public QueryOperationAuditInfoListResponse QueryOperationAuditInfoListWithOptions(QueryOperationAuditInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditType))
            {
                query["AuditType"] = request.AuditType;
            }
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOperationAuditInfoList",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOperationAuditInfoListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryOperationAuditInfoListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryOperationAuditInfoListResponse
         */
        public async Task<QueryOperationAuditInfoListResponse> QueryOperationAuditInfoListWithOptionsAsync(QueryOperationAuditInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditStatus))
            {
                query["AuditStatus"] = request.AuditStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditType))
            {
                query["AuditType"] = request.AuditType;
            }
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOperationAuditInfoList",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOperationAuditInfoListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryOperationAuditInfoListRequest
         * @return QueryOperationAuditInfoListResponse
         */
        public QueryOperationAuditInfoListResponse QueryOperationAuditInfoList(QueryOperationAuditInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOperationAuditInfoListWithOptions(request, runtime);
        }

        /**
         * @param request QueryOperationAuditInfoListRequest
         * @return QueryOperationAuditInfoListResponse
         */
        public async Task<QueryOperationAuditInfoListResponse> QueryOperationAuditInfoListAsync(QueryOperationAuditInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOperationAuditInfoListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryQualificationDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryQualificationDetailResponse
         */
        public QueryQualificationDetailResponse QueryQualificationDetailWithOptions(QueryQualificationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationType))
            {
                query["QualificationType"] = request.QualificationType;
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
                Action = "QueryQualificationDetail",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryQualificationDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryQualificationDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryQualificationDetailResponse
         */
        public async Task<QueryQualificationDetailResponse> QueryQualificationDetailWithOptionsAsync(QueryQualificationDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationType))
            {
                query["QualificationType"] = request.QualificationType;
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
                Action = "QueryQualificationDetail",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryQualificationDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryQualificationDetailRequest
         * @return QueryQualificationDetailResponse
         */
        public QueryQualificationDetailResponse QueryQualificationDetail(QueryQualificationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryQualificationDetailWithOptions(request, runtime);
        }

        /**
         * @param request QueryQualificationDetailRequest
         * @return QueryQualificationDetailResponse
         */
        public async Task<QueryQualificationDetailResponse> QueryQualificationDetailAsync(QueryQualificationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryQualificationDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryRegistrantProfileRealNameVerificationInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRegistrantProfileRealNameVerificationInfoResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryRegistrantProfileRealNameVerificationInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRegistrantProfileRealNameVerificationInfoResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryRegistrantProfileRealNameVerificationInfoRequest
         * @return QueryRegistrantProfileRealNameVerificationInfoResponse
         */
        public QueryRegistrantProfileRealNameVerificationInfoResponse QueryRegistrantProfileRealNameVerificationInfo(QueryRegistrantProfileRealNameVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRegistrantProfileRealNameVerificationInfoWithOptions(request, runtime);
        }

        /**
         * @param request QueryRegistrantProfileRealNameVerificationInfoRequest
         * @return QueryRegistrantProfileRealNameVerificationInfoResponse
         */
        public async Task<QueryRegistrantProfileRealNameVerificationInfoResponse> QueryRegistrantProfileRealNameVerificationInfoAsync(QueryRegistrantProfileRealNameVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRegistrantProfileRealNameVerificationInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryRegistrantProfilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRegistrantProfilesResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRegistrantProfiles",
                Version = "2018-01-29",
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

        /**
         * @param request QueryRegistrantProfilesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRegistrantProfilesResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryRegistrantProfiles",
                Version = "2018-01-29",
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

        /**
         * @param request QueryRegistrantProfilesRequest
         * @return QueryRegistrantProfilesResponse
         */
        public QueryRegistrantProfilesResponse QueryRegistrantProfiles(QueryRegistrantProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRegistrantProfilesWithOptions(request, runtime);
        }

        /**
         * @param request QueryRegistrantProfilesRequest
         * @return QueryRegistrantProfilesResponse
         */
        public async Task<QueryRegistrantProfilesResponse> QueryRegistrantProfilesAsync(QueryRegistrantProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRegistrantProfilesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryServerLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryServerLockResponse
         */
        public QueryServerLockResponse QueryServerLockWithOptions(QueryServerLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryServerLock",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryServerLockResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request QueryServerLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryServerLockResponse
         */
        public async Task<QueryServerLockResponse> QueryServerLockWithOptionsAsync(QueryServerLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryServerLock",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryServerLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request QueryServerLockRequest
         * @return QueryServerLockResponse
         */
        public QueryServerLockResponse QueryServerLock(QueryServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryServerLockWithOptions(request, runtime);
        }

        /**
         * @param request QueryServerLockRequest
         * @return QueryServerLockResponse
         */
        public async Task<QueryServerLockResponse> QueryServerLockAsync(QueryServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryServerLockWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryTaskDetailHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTaskDetailHistoryResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTaskDetailHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTaskDetailHistoryResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTaskDetailHistoryRequest
         * @return QueryTaskDetailHistoryResponse
         */
        public QueryTaskDetailHistoryResponse QueryTaskDetailHistory(QueryTaskDetailHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskDetailHistoryWithOptions(request, runtime);
        }

        /**
         * @param request QueryTaskDetailHistoryRequest
         * @return QueryTaskDetailHistoryResponse
         */
        public async Task<QueryTaskDetailHistoryResponse> QueryTaskDetailHistoryAsync(QueryTaskDetailHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskDetailHistoryWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryTaskDetailListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTaskDetailListResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTaskDetailListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTaskDetailListResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTaskDetailListRequest
         * @return QueryTaskDetailListResponse
         */
        public QueryTaskDetailListResponse QueryTaskDetailList(QueryTaskDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskDetailListWithOptions(request, runtime);
        }

        /**
         * @param request QueryTaskDetailListRequest
         * @return QueryTaskDetailListResponse
         */
        public async Task<QueryTaskDetailListResponse> QueryTaskDetailListAsync(QueryTaskDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskDetailListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryTaskInfoHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTaskInfoHistoryResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTaskInfoHistoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTaskInfoHistoryResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTaskInfoHistoryRequest
         * @return QueryTaskInfoHistoryResponse
         */
        public QueryTaskInfoHistoryResponse QueryTaskInfoHistory(QueryTaskInfoHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskInfoHistoryWithOptions(request, runtime);
        }

        /**
         * @param request QueryTaskInfoHistoryRequest
         * @return QueryTaskInfoHistoryResponse
         */
        public async Task<QueryTaskInfoHistoryResponse> QueryTaskInfoHistoryAsync(QueryTaskInfoHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskInfoHistoryWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryTaskListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTaskListResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTaskListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTaskListResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTaskListRequest
         * @return QueryTaskListResponse
         */
        public QueryTaskListResponse QueryTaskList(QueryTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskListWithOptions(request, runtime);
        }

        /**
         * @param request QueryTaskListRequest
         * @return QueryTaskListResponse
         */
        public async Task<QueryTaskListResponse> QueryTaskListAsync(QueryTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryTransferInByInstanceIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTransferInByInstanceIdResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTransferInByInstanceIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTransferInByInstanceIdResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTransferInByInstanceIdRequest
         * @return QueryTransferInByInstanceIdResponse
         */
        public QueryTransferInByInstanceIdResponse QueryTransferInByInstanceId(QueryTransferInByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTransferInByInstanceIdWithOptions(request, runtime);
        }

        /**
         * @param request QueryTransferInByInstanceIdRequest
         * @return QueryTransferInByInstanceIdResponse
         */
        public async Task<QueryTransferInByInstanceIdResponse> QueryTransferInByInstanceIdAsync(QueryTransferInByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTransferInByInstanceIdWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryTransferInListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTransferInListResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTransferInListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTransferInListResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTransferInListRequest
         * @return QueryTransferInListResponse
         */
        public QueryTransferInListResponse QueryTransferInList(QueryTransferInListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTransferInListWithOptions(request, runtime);
        }

        /**
         * @param request QueryTransferInListRequest
         * @return QueryTransferInListResponse
         */
        public async Task<QueryTransferInListResponse> QueryTransferInListAsync(QueryTransferInListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTransferInListWithOptionsAsync(request, runtime);
        }

        /**
         * @param request QueryTransferOutInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTransferOutInfoResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTransferOutInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTransferOutInfoResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request QueryTransferOutInfoRequest
         * @return QueryTransferOutInfoResponse
         */
        public QueryTransferOutInfoResponse QueryTransferOutInfo(QueryTransferOutInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTransferOutInfoWithOptions(request, runtime);
        }

        /**
         * @param request QueryTransferOutInfoRequest
         * @return QueryTransferOutInfoResponse
         */
        public async Task<QueryTransferOutInfoResponse> QueryTransferOutInfoAsync(QueryTransferOutInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTransferOutInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存联系人模板实名资料
         *
         * @param request RegistrantProfileRealNameVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegistrantProfileRealNameVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存联系人模板实名资料
         *
         * @param request RegistrantProfileRealNameVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RegistrantProfileRealNameVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存联系人模板实名资料
         *
         * @param request RegistrantProfileRealNameVerificationRequest
         * @return RegistrantProfileRealNameVerificationResponse
         */
        public RegistrantProfileRealNameVerificationResponse RegistrantProfileRealNameVerification(RegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegistrantProfileRealNameVerificationWithOptions(request, runtime);
        }

        /**
         * @summary 保存联系人模板实名资料
         *
         * @param request RegistrantProfileRealNameVerificationRequest
         * @return RegistrantProfileRealNameVerificationResponse
         */
        public async Task<RegistrantProfileRealNameVerificationResponse> RegistrantProfileRealNameVerificationAsync(RegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegistrantProfileRealNameVerificationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 重新发送验证邮件
         *
         * @param request ResendEmailVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResendEmailVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 重新发送验证邮件
         *
         * @param request ResendEmailVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResendEmailVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 重新发送验证邮件
         *
         * @param request ResendEmailVerificationRequest
         * @return ResendEmailVerificationResponse
         */
        public ResendEmailVerificationResponse ResendEmailVerification(ResendEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResendEmailVerificationWithOptions(request, runtime);
        }

        /**
         * @summary 重新发送验证邮件
         *
         * @param request ResendEmailVerificationRequest
         * @return ResendEmailVerificationResponse
         */
        public async Task<ResendEmailVerificationResponse> ResendEmailVerificationAsync(ResendEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResendEmailVerificationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 重置资质审核状态
         *
         * @param request ResetQualificationVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetQualificationVerificationResponse
         */
        public ResetQualificationVerificationResponse ResetQualificationVerificationWithOptions(ResetQualificationVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ResetQualificationVerification",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetQualificationVerificationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 重置资质审核状态
         *
         * @param request ResetQualificationVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetQualificationVerificationResponse
         */
        public async Task<ResetQualificationVerificationResponse> ResetQualificationVerificationWithOptionsAsync(ResetQualificationVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ResetQualificationVerification",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetQualificationVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 重置资质审核状态
         *
         * @param request ResetQualificationVerificationRequest
         * @return ResetQualificationVerificationResponse
         */
        public ResetQualificationVerificationResponse ResetQualificationVerification(ResetQualificationVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetQualificationVerificationWithOptions(request, runtime);
        }

        /**
         * @summary 重置资质审核状态
         *
         * @param request ResetQualificationVerificationRequest
         * @return ResetQualificationVerificationResponse
         */
        public async Task<ResetQualificationVerificationResponse> ResetQualificationVerificationAsync(ResetQualificationVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetQualificationVerificationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量保存域名备注信息
         *
         * @param request SaveBatchDomainRemarkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchDomainRemarkResponse
         */
        public SaveBatchDomainRemarkResponse SaveBatchDomainRemarkWithOptions(SaveBatchDomainRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "SaveBatchDomainRemark",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchDomainRemarkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量保存域名备注信息
         *
         * @param request SaveBatchDomainRemarkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchDomainRemarkResponse
         */
        public async Task<SaveBatchDomainRemarkResponse> SaveBatchDomainRemarkWithOptionsAsync(SaveBatchDomainRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "SaveBatchDomainRemark",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchDomainRemarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量保存域名备注信息
         *
         * @param request SaveBatchDomainRemarkRequest
         * @return SaveBatchDomainRemarkResponse
         */
        public SaveBatchDomainRemarkResponse SaveBatchDomainRemark(SaveBatchDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchDomainRemarkWithOptions(request, runtime);
        }

        /**
         * @summary 批量保存域名备注信息
         *
         * @param request SaveBatchDomainRemarkRequest
         * @return SaveBatchDomainRemarkResponse
         */
        public async Task<SaveBatchDomainRemarkResponse> SaveBatchDomainRemarkAsync(SaveBatchDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchDomainRemarkWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量申请域名快速转出
         *
         * @param request SaveBatchTaskForApplyQuickTransferOutOpenlyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForApplyQuickTransferOutOpenlyResponse
         */
        public SaveBatchTaskForApplyQuickTransferOutOpenlyResponse SaveBatchTaskForApplyQuickTransferOutOpenlyWithOptions(SaveBatchTaskForApplyQuickTransferOutOpenlyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
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
                Action = "SaveBatchTaskForApplyQuickTransferOutOpenly",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForApplyQuickTransferOutOpenlyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量申请域名快速转出
         *
         * @param request SaveBatchTaskForApplyQuickTransferOutOpenlyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForApplyQuickTransferOutOpenlyResponse
         */
        public async Task<SaveBatchTaskForApplyQuickTransferOutOpenlyResponse> SaveBatchTaskForApplyQuickTransferOutOpenlyWithOptionsAsync(SaveBatchTaskForApplyQuickTransferOutOpenlyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNames))
            {
                query["DomainNames"] = request.DomainNames;
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
                Action = "SaveBatchTaskForApplyQuickTransferOutOpenly",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForApplyQuickTransferOutOpenlyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量申请域名快速转出
         *
         * @param request SaveBatchTaskForApplyQuickTransferOutOpenlyRequest
         * @return SaveBatchTaskForApplyQuickTransferOutOpenlyResponse
         */
        public SaveBatchTaskForApplyQuickTransferOutOpenlyResponse SaveBatchTaskForApplyQuickTransferOutOpenly(SaveBatchTaskForApplyQuickTransferOutOpenlyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForApplyQuickTransferOutOpenlyWithOptions(request, runtime);
        }

        /**
         * @summary 批量申请域名快速转出
         *
         * @param request SaveBatchTaskForApplyQuickTransferOutOpenlyRequest
         * @return SaveBatchTaskForApplyQuickTransferOutOpenlyResponse
         */
        public async Task<SaveBatchTaskForApplyQuickTransferOutOpenlyResponse> SaveBatchTaskForApplyQuickTransferOutOpenlyAsync(SaveBatchTaskForApplyQuickTransferOutOpenlyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForApplyQuickTransferOutOpenlyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存批量任务-注册订单
         *
         * @param request SaveBatchTaskForCreatingOrderActivateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForCreatingOrderActivateResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存批量任务-注册订单
         *
         * @param request SaveBatchTaskForCreatingOrderActivateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForCreatingOrderActivateResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存批量任务-注册订单
         *
         * @param request SaveBatchTaskForCreatingOrderActivateRequest
         * @return SaveBatchTaskForCreatingOrderActivateResponse
         */
        public SaveBatchTaskForCreatingOrderActivateResponse SaveBatchTaskForCreatingOrderActivate(SaveBatchTaskForCreatingOrderActivateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForCreatingOrderActivateWithOptions(request, runtime);
        }

        /**
         * @summary 保存批量任务-注册订单
         *
         * @param request SaveBatchTaskForCreatingOrderActivateRequest
         * @return SaveBatchTaskForCreatingOrderActivateResponse
         */
        public async Task<SaveBatchTaskForCreatingOrderActivateResponse> SaveBatchTaskForCreatingOrderActivateAsync(SaveBatchTaskForCreatingOrderActivateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForCreatingOrderActivateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SaveBatchTaskForCreatingOrderRedeemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForCreatingOrderRedeemResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveBatchTaskForCreatingOrderRedeemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForCreatingOrderRedeemResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveBatchTaskForCreatingOrderRedeemRequest
         * @return SaveBatchTaskForCreatingOrderRedeemResponse
         */
        public SaveBatchTaskForCreatingOrderRedeemResponse SaveBatchTaskForCreatingOrderRedeem(SaveBatchTaskForCreatingOrderRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForCreatingOrderRedeemWithOptions(request, runtime);
        }

        /**
         * @param request SaveBatchTaskForCreatingOrderRedeemRequest
         * @return SaveBatchTaskForCreatingOrderRedeemResponse
         */
        public async Task<SaveBatchTaskForCreatingOrderRedeemResponse> SaveBatchTaskForCreatingOrderRedeemAsync(SaveBatchTaskForCreatingOrderRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForCreatingOrderRedeemWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存批量任务-续费订单
         *
         * @param request SaveBatchTaskForCreatingOrderRenewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForCreatingOrderRenewResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存批量任务-续费订单
         *
         * @param request SaveBatchTaskForCreatingOrderRenewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForCreatingOrderRenewResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存批量任务-续费订单
         *
         * @param request SaveBatchTaskForCreatingOrderRenewRequest
         * @return SaveBatchTaskForCreatingOrderRenewResponse
         */
        public SaveBatchTaskForCreatingOrderRenewResponse SaveBatchTaskForCreatingOrderRenew(SaveBatchTaskForCreatingOrderRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForCreatingOrderRenewWithOptions(request, runtime);
        }

        /**
         * @summary 保存批量任务-续费订单
         *
         * @param request SaveBatchTaskForCreatingOrderRenewRequest
         * @return SaveBatchTaskForCreatingOrderRenewResponse
         */
        public async Task<SaveBatchTaskForCreatingOrderRenewResponse> SaveBatchTaskForCreatingOrderRenewAsync(SaveBatchTaskForCreatingOrderRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForCreatingOrderRenewWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SaveBatchTaskForCreatingOrderTransferRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForCreatingOrderTransferResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveBatchTaskForCreatingOrderTransferRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForCreatingOrderTransferResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveBatchTaskForCreatingOrderTransferRequest
         * @return SaveBatchTaskForCreatingOrderTransferResponse
         */
        public SaveBatchTaskForCreatingOrderTransferResponse SaveBatchTaskForCreatingOrderTransfer(SaveBatchTaskForCreatingOrderTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForCreatingOrderTransferWithOptions(request, runtime);
        }

        /**
         * @param request SaveBatchTaskForCreatingOrderTransferRequest
         * @return SaveBatchTaskForCreatingOrderTransferResponse
         */
        public async Task<SaveBatchTaskForCreatingOrderTransferResponse> SaveBatchTaskForCreatingOrderTransferAsync(SaveBatchTaskForCreatingOrderTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForCreatingOrderTransferWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存批量任务-开启/关闭whois隐私保护锁
         *
         * @param request SaveBatchTaskForDomainNameProxyServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForDomainNameProxyServiceResponse
         */
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
                Action = "SaveBatchTaskForDomainNameProxyService",
                Version = "2018-01-29",
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

        /**
         * @summary 保存批量任务-开启/关闭whois隐私保护锁
         *
         * @param request SaveBatchTaskForDomainNameProxyServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForDomainNameProxyServiceResponse
         */
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
                Action = "SaveBatchTaskForDomainNameProxyService",
                Version = "2018-01-29",
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

        /**
         * @summary 保存批量任务-开启/关闭whois隐私保护锁
         *
         * @param request SaveBatchTaskForDomainNameProxyServiceRequest
         * @return SaveBatchTaskForDomainNameProxyServiceResponse
         */
        public SaveBatchTaskForDomainNameProxyServiceResponse SaveBatchTaskForDomainNameProxyService(SaveBatchTaskForDomainNameProxyServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForDomainNameProxyServiceWithOptions(request, runtime);
        }

        /**
         * @summary 保存批量任务-开启/关闭whois隐私保护锁
         *
         * @param request SaveBatchTaskForDomainNameProxyServiceRequest
         * @return SaveBatchTaskForDomainNameProxyServiceResponse
         */
        public async Task<SaveBatchTaskForDomainNameProxyServiceResponse> SaveBatchTaskForDomainNameProxyServiceAsync(SaveBatchTaskForDomainNameProxyServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForDomainNameProxyServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交批量生成证书的任务
         *
         * @param tmpReq SaveBatchTaskForGenerateDomainCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForGenerateDomainCertificateResponse
         */
        public SaveBatchTaskForGenerateDomainCertificateResponse SaveBatchTaskForGenerateDomainCertificateWithOptions(SaveBatchTaskForGenerateDomainCertificateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveBatchTaskForGenerateDomainCertificateShrinkRequest request = new SaveBatchTaskForGenerateDomainCertificateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DomainNames))
            {
                request.DomainNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DomainNames, "DomainNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNamesShrink))
            {
                query["DomainNames"] = request.DomainNamesShrink;
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
                Action = "SaveBatchTaskForGenerateDomainCertificate",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForGenerateDomainCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交批量生成证书的任务
         *
         * @param tmpReq SaveBatchTaskForGenerateDomainCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForGenerateDomainCertificateResponse
         */
        public async Task<SaveBatchTaskForGenerateDomainCertificateResponse> SaveBatchTaskForGenerateDomainCertificateWithOptionsAsync(SaveBatchTaskForGenerateDomainCertificateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SaveBatchTaskForGenerateDomainCertificateShrinkRequest request = new SaveBatchTaskForGenerateDomainCertificateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DomainNames))
            {
                request.DomainNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DomainNames, "DomainNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNamesShrink))
            {
                query["DomainNames"] = request.DomainNamesShrink;
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
                Action = "SaveBatchTaskForGenerateDomainCertificate",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForGenerateDomainCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交批量生成证书的任务
         *
         * @param request SaveBatchTaskForGenerateDomainCertificateRequest
         * @return SaveBatchTaskForGenerateDomainCertificateResponse
         */
        public SaveBatchTaskForGenerateDomainCertificateResponse SaveBatchTaskForGenerateDomainCertificate(SaveBatchTaskForGenerateDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForGenerateDomainCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 提交批量生成证书的任务
         *
         * @param request SaveBatchTaskForGenerateDomainCertificateRequest
         * @return SaveBatchTaskForGenerateDomainCertificateResponse
         */
        public async Task<SaveBatchTaskForGenerateDomainCertificateResponse> SaveBatchTaskForGenerateDomainCertificateAsync(SaveBatchTaskForGenerateDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForGenerateDomainCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量修改dns
         *
         * @param request SaveBatchTaskForModifyingDomainDnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForModifyingDomainDnsResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 批量修改dns
         *
         * @param request SaveBatchTaskForModifyingDomainDnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForModifyingDomainDnsResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 批量修改dns
         *
         * @param request SaveBatchTaskForModifyingDomainDnsRequest
         * @return SaveBatchTaskForModifyingDomainDnsResponse
         */
        public SaveBatchTaskForModifyingDomainDnsResponse SaveBatchTaskForModifyingDomainDns(SaveBatchTaskForModifyingDomainDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForModifyingDomainDnsWithOptions(request, runtime);
        }

        /**
         * @summary 批量修改dns
         *
         * @param request SaveBatchTaskForModifyingDomainDnsRequest
         * @return SaveBatchTaskForModifyingDomainDnsResponse
         */
        public async Task<SaveBatchTaskForModifyingDomainDnsResponse> SaveBatchTaskForModifyingDomainDnsAsync(SaveBatchTaskForModifyingDomainDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForModifyingDomainDnsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SaveBatchTaskForReserveDropListDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForReserveDropListDomainResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveBatchTaskForReserveDropListDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForReserveDropListDomainResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveBatchTaskForReserveDropListDomainRequest
         * @return SaveBatchTaskForReserveDropListDomainResponse
         */
        public SaveBatchTaskForReserveDropListDomainResponse SaveBatchTaskForReserveDropListDomain(SaveBatchTaskForReserveDropListDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForReserveDropListDomainWithOptions(request, runtime);
        }

        /**
         * @param request SaveBatchTaskForReserveDropListDomainRequest
         * @return SaveBatchTaskForReserveDropListDomainResponse
         */
        public async Task<SaveBatchTaskForReserveDropListDomainResponse> SaveBatchTaskForReserveDropListDomainAsync(SaveBatchTaskForReserveDropListDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForReserveDropListDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存批量任务-开启/关闭禁止转移锁
         *
         * @param request SaveBatchTaskForTransferProhibitionLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForTransferProhibitionLockResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存批量任务-开启/关闭禁止转移锁
         *
         * @param request SaveBatchTaskForTransferProhibitionLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForTransferProhibitionLockResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存批量任务-开启/关闭禁止转移锁
         *
         * @param request SaveBatchTaskForTransferProhibitionLockRequest
         * @return SaveBatchTaskForTransferProhibitionLockResponse
         */
        public SaveBatchTaskForTransferProhibitionLockResponse SaveBatchTaskForTransferProhibitionLock(SaveBatchTaskForTransferProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForTransferProhibitionLockWithOptions(request, runtime);
        }

        /**
         * @summary 保存批量任务-开启/关闭禁止转移锁
         *
         * @param request SaveBatchTaskForTransferProhibitionLockRequest
         * @return SaveBatchTaskForTransferProhibitionLockResponse
         */
        public async Task<SaveBatchTaskForTransferProhibitionLockResponse> SaveBatchTaskForTransferProhibitionLockAsync(SaveBatchTaskForTransferProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForTransferProhibitionLockWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SaveBatchTaskForUpdateProhibitionLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForUpdateProhibitionLockResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveBatchTaskForUpdateProhibitionLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForUpdateProhibitionLockResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveBatchTaskForUpdateProhibitionLockRequest
         * @return SaveBatchTaskForUpdateProhibitionLockResponse
         */
        public SaveBatchTaskForUpdateProhibitionLockResponse SaveBatchTaskForUpdateProhibitionLock(SaveBatchTaskForUpdateProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForUpdateProhibitionLockWithOptions(request, runtime);
        }

        /**
         * @param request SaveBatchTaskForUpdateProhibitionLockRequest
         * @return SaveBatchTaskForUpdateProhibitionLockResponse
         */
        public async Task<SaveBatchTaskForUpdateProhibitionLockResponse> SaveBatchTaskForUpdateProhibitionLockAsync(SaveBatchTaskForUpdateProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForUpdateProhibitionLockWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 使用联系人信息修改联系人的批量任务
         *
         * @param request SaveBatchTaskForUpdatingContactInfoByNewContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForUpdatingContactInfoByNewContactResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhAddress))
            {
                query["ZhAddress"] = request.ZhAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhCity))
            {
                query["ZhCity"] = request.ZhCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhProvince))
            {
                query["ZhProvince"] = request.ZhProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantName))
            {
                query["ZhRegistrantName"] = request.ZhRegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForUpdatingContactInfoByNewContact",
                Version = "2018-01-29",
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

        /**
         * @summary 使用联系人信息修改联系人的批量任务
         *
         * @param request SaveBatchTaskForUpdatingContactInfoByNewContactRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForUpdatingContactInfoByNewContactResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhAddress))
            {
                query["ZhAddress"] = request.ZhAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhCity))
            {
                query["ZhCity"] = request.ZhCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhProvince))
            {
                query["ZhProvince"] = request.ZhProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantName))
            {
                query["ZhRegistrantName"] = request.ZhRegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForUpdatingContactInfoByNewContact",
                Version = "2018-01-29",
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

        /**
         * @summary 使用联系人信息修改联系人的批量任务
         *
         * @param request SaveBatchTaskForUpdatingContactInfoByNewContactRequest
         * @return SaveBatchTaskForUpdatingContactInfoByNewContactResponse
         */
        public SaveBatchTaskForUpdatingContactInfoByNewContactResponse SaveBatchTaskForUpdatingContactInfoByNewContact(SaveBatchTaskForUpdatingContactInfoByNewContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForUpdatingContactInfoByNewContactWithOptions(request, runtime);
        }

        /**
         * @summary 使用联系人信息修改联系人的批量任务
         *
         * @param request SaveBatchTaskForUpdatingContactInfoByNewContactRequest
         * @return SaveBatchTaskForUpdatingContactInfoByNewContactResponse
         */
        public async Task<SaveBatchTaskForUpdatingContactInfoByNewContactResponse> SaveBatchTaskForUpdatingContactInfoByNewContactAsync(SaveBatchTaskForUpdatingContactInfoByNewContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForUpdatingContactInfoByNewContactWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 使用模板修改联系人的批量任务
         *
         * @param request SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse
         */
        public SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdWithOptions(SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SaveBatchTaskForUpdatingContactInfoByRegistrantProfileId",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 使用模板修改联系人的批量任务
         *
         * @param request SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse
         */
        public async Task<SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse> SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdWithOptionsAsync(SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SaveBatchTaskForUpdatingContactInfoByRegistrantProfileId",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 使用模板修改联系人的批量任务
         *
         * @param request SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest
         * @return SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse
         */
        public SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse SaveBatchTaskForUpdatingContactInfoByRegistrantProfileId(SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdWithOptions(request, runtime);
        }

        /**
         * @summary 使用模板修改联系人的批量任务
         *
         * @param request SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest
         * @return SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse
         */
        public async Task<SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse> SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdAsync(SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建/更新域名分组
         *
         * @param request SaveDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveDomainGroupResponse
         */
        public SaveDomainGroupResponse SaveDomainGroupWithOptions(SaveDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupId))
            {
                query["DomainGroupId"] = request.DomainGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupName))
            {
                query["DomainGroupName"] = request.DomainGroupName;
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
                Action = "SaveDomainGroup",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveDomainGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建/更新域名分组
         *
         * @param request SaveDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveDomainGroupResponse
         */
        public async Task<SaveDomainGroupResponse> SaveDomainGroupWithOptionsAsync(SaveDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupId))
            {
                query["DomainGroupId"] = request.DomainGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupName))
            {
                query["DomainGroupName"] = request.DomainGroupName;
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
                Action = "SaveDomainGroup",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveDomainGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建/更新域名分组
         *
         * @param request SaveDomainGroupRequest
         * @return SaveDomainGroupResponse
         */
        public SaveDomainGroupResponse SaveDomainGroup(SaveDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveDomainGroupWithOptions(request, runtime);
        }

        /**
         * @summary 创建/更新域名分组
         *
         * @param request SaveDomainGroupRequest
         * @return SaveDomainGroupResponse
         */
        public async Task<SaveDomainGroupResponse> SaveDomainGroupAsync(SaveDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveDomainGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存联系人模板
         *
         * @param request SaveRegistrantProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveRegistrantProfileResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhAddress))
            {
                query["ZhAddress"] = request.ZhAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhCity))
            {
                query["ZhCity"] = request.ZhCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhProvince))
            {
                query["ZhProvince"] = request.ZhProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantName))
            {
                query["ZhRegistrantName"] = request.ZhRegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveRegistrantProfile",
                Version = "2018-01-29",
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

        /**
         * @summary 保存联系人模板
         *
         * @param request SaveRegistrantProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveRegistrantProfileResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhAddress))
            {
                query["ZhAddress"] = request.ZhAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhCity))
            {
                query["ZhCity"] = request.ZhCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhProvince))
            {
                query["ZhProvince"] = request.ZhProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantName))
            {
                query["ZhRegistrantName"] = request.ZhRegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveRegistrantProfile",
                Version = "2018-01-29",
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

        /**
         * @summary 保存联系人模板
         *
         * @param request SaveRegistrantProfileRequest
         * @return SaveRegistrantProfileResponse
         */
        public SaveRegistrantProfileResponse SaveRegistrantProfile(SaveRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveRegistrantProfileWithOptions(request, runtime);
        }

        /**
         * @summary 保存联系人模板
         *
         * @param request SaveRegistrantProfileRequest
         * @return SaveRegistrantProfileResponse
         */
        public async Task<SaveRegistrantProfileResponse> SaveRegistrantProfileAsync(SaveRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveRegistrantProfileWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存联系人模板和凭据
         *
         * @param request SaveRegistrantProfileRealNameVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveRegistrantProfileRealNameVerificationResponse
         */
        public SaveRegistrantProfileRealNameVerificationResponse SaveRegistrantProfileRealNameVerificationWithOptions(SaveRegistrantProfileRealNameVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredential))
            {
                query["IdentityCredential"] = request.IdentityCredential;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhAddress))
            {
                query["ZhAddress"] = request.ZhAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhCity))
            {
                query["ZhCity"] = request.ZhCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhProvince))
            {
                query["ZhProvince"] = request.ZhProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantName))
            {
                query["ZhRegistrantName"] = request.ZhRegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveRegistrantProfileRealNameVerification",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveRegistrantProfileRealNameVerificationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 保存联系人模板和凭据
         *
         * @param request SaveRegistrantProfileRealNameVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveRegistrantProfileRealNameVerificationResponse
         */
        public async Task<SaveRegistrantProfileRealNameVerificationResponse> SaveRegistrantProfileRealNameVerificationWithOptionsAsync(SaveRegistrantProfileRealNameVerificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentityCredential))
            {
                query["IdentityCredential"] = request.IdentityCredential;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhAddress))
            {
                query["ZhAddress"] = request.ZhAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhCity))
            {
                query["ZhCity"] = request.ZhCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhProvince))
            {
                query["ZhProvince"] = request.ZhProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantName))
            {
                query["ZhRegistrantName"] = request.ZhRegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveRegistrantProfileRealNameVerification",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveRegistrantProfileRealNameVerificationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 保存联系人模板和凭据
         *
         * @param request SaveRegistrantProfileRealNameVerificationRequest
         * @return SaveRegistrantProfileRealNameVerificationResponse
         */
        public SaveRegistrantProfileRealNameVerificationResponse SaveRegistrantProfileRealNameVerification(SaveRegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveRegistrantProfileRealNameVerificationWithOptions(request, runtime);
        }

        /**
         * @summary 保存联系人模板和凭据
         *
         * @param request SaveRegistrantProfileRealNameVerificationRequest
         * @return SaveRegistrantProfileRealNameVerificationResponse
         */
        public async Task<SaveRegistrantProfileRealNameVerificationResponse> SaveRegistrantProfileRealNameVerificationAsync(SaveRegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveRegistrantProfileRealNameVerificationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 添加dnsSec记录
         *
         * @param request SaveSingleTaskForAddingDSRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForAddingDSRecordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 添加dnsSec记录
         *
         * @param request SaveSingleTaskForAddingDSRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForAddingDSRecordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 添加dnsSec记录
         *
         * @param request SaveSingleTaskForAddingDSRecordRequest
         * @return SaveSingleTaskForAddingDSRecordResponse
         */
        public SaveSingleTaskForAddingDSRecordResponse SaveSingleTaskForAddingDSRecord(SaveSingleTaskForAddingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForAddingDSRecordWithOptions(request, runtime);
        }

        /**
         * @summary 添加dnsSec记录
         *
         * @param request SaveSingleTaskForAddingDSRecordRequest
         * @return SaveSingleTaskForAddingDSRecordResponse
         */
        public async Task<SaveSingleTaskForAddingDSRecordResponse> SaveSingleTaskForAddingDSRecordAsync(SaveSingleTaskForAddingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForAddingDSRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 申请域名快速转出
         *
         * @param request SaveSingleTaskForApplyQuickTransferOutOpenlyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForApplyQuickTransferOutOpenlyResponse
         */
        public SaveSingleTaskForApplyQuickTransferOutOpenlyResponse SaveSingleTaskForApplyQuickTransferOutOpenlyWithOptions(SaveSingleTaskForApplyQuickTransferOutOpenlyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SaveSingleTaskForApplyQuickTransferOutOpenly",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForApplyQuickTransferOutOpenlyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 申请域名快速转出
         *
         * @param request SaveSingleTaskForApplyQuickTransferOutOpenlyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForApplyQuickTransferOutOpenlyResponse
         */
        public async Task<SaveSingleTaskForApplyQuickTransferOutOpenlyResponse> SaveSingleTaskForApplyQuickTransferOutOpenlyWithOptionsAsync(SaveSingleTaskForApplyQuickTransferOutOpenlyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SaveSingleTaskForApplyQuickTransferOutOpenly",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForApplyQuickTransferOutOpenlyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 申请域名快速转出
         *
         * @param request SaveSingleTaskForApplyQuickTransferOutOpenlyRequest
         * @return SaveSingleTaskForApplyQuickTransferOutOpenlyResponse
         */
        public SaveSingleTaskForApplyQuickTransferOutOpenlyResponse SaveSingleTaskForApplyQuickTransferOutOpenly(SaveSingleTaskForApplyQuickTransferOutOpenlyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForApplyQuickTransferOutOpenlyWithOptions(request, runtime);
        }

        /**
         * @summary 申请域名快速转出
         *
         * @param request SaveSingleTaskForApplyQuickTransferOutOpenlyRequest
         * @return SaveSingleTaskForApplyQuickTransferOutOpenlyResponse
         */
        public async Task<SaveSingleTaskForApplyQuickTransferOutOpenlyResponse> SaveSingleTaskForApplyQuickTransferOutOpenlyAsync(SaveSingleTaskForApplyQuickTransferOutOpenlyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForApplyQuickTransferOutOpenlyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 确认转出
         *
         * @param request SaveSingleTaskForApprovingTransferOutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForApprovingTransferOutResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 确认转出
         *
         * @param request SaveSingleTaskForApprovingTransferOutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForApprovingTransferOutResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 确认转出
         *
         * @param request SaveSingleTaskForApprovingTransferOutRequest
         * @return SaveSingleTaskForApprovingTransferOutResponse
         */
        public SaveSingleTaskForApprovingTransferOutResponse SaveSingleTaskForApprovingTransferOut(SaveSingleTaskForApprovingTransferOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForApprovingTransferOutWithOptions(request, runtime);
        }

        /**
         * @summary 确认转出
         *
         * @param request SaveSingleTaskForApprovingTransferOutRequest
         * @return SaveSingleTaskForApprovingTransferOutResponse
         */
        public async Task<SaveSingleTaskForApprovingTransferOutResponse> SaveSingleTaskForApprovingTransferOutAsync(SaveSingleTaskForApprovingTransferOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForApprovingTransferOutWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SaveSingleTaskForAssociatingEnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForAssociatingEnsResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveSingleTaskForAssociatingEnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForAssociatingEnsResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveSingleTaskForAssociatingEnsRequest
         * @return SaveSingleTaskForAssociatingEnsResponse
         */
        public SaveSingleTaskForAssociatingEnsResponse SaveSingleTaskForAssociatingEns(SaveSingleTaskForAssociatingEnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForAssociatingEnsWithOptions(request, runtime);
        }

        /**
         * @param request SaveSingleTaskForAssociatingEnsRequest
         * @return SaveSingleTaskForAssociatingEnsResponse
         */
        public async Task<SaveSingleTaskForAssociatingEnsResponse> SaveSingleTaskForAssociatingEnsAsync(SaveSingleTaskForAssociatingEnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForAssociatingEnsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SaveSingleTaskForCancelingTransferInRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCancelingTransferInResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveSingleTaskForCancelingTransferInRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCancelingTransferInResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveSingleTaskForCancelingTransferInRequest
         * @return SaveSingleTaskForCancelingTransferInResponse
         */
        public SaveSingleTaskForCancelingTransferInResponse SaveSingleTaskForCancelingTransferIn(SaveSingleTaskForCancelingTransferInRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCancelingTransferInWithOptions(request, runtime);
        }

        /**
         * @param request SaveSingleTaskForCancelingTransferInRequest
         * @return SaveSingleTaskForCancelingTransferInResponse
         */
        public async Task<SaveSingleTaskForCancelingTransferInResponse> SaveSingleTaskForCancelingTransferInAsync(SaveSingleTaskForCancelingTransferInRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCancelingTransferInWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 取消转出
         *
         * @param request SaveSingleTaskForCancelingTransferOutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCancelingTransferOutResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 取消转出
         *
         * @param request SaveSingleTaskForCancelingTransferOutRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCancelingTransferOutResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 取消转出
         *
         * @param request SaveSingleTaskForCancelingTransferOutRequest
         * @return SaveSingleTaskForCancelingTransferOutResponse
         */
        public SaveSingleTaskForCancelingTransferOutResponse SaveSingleTaskForCancelingTransferOut(SaveSingleTaskForCancelingTransferOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCancelingTransferOutWithOptions(request, runtime);
        }

        /**
         * @summary 取消转出
         *
         * @param request SaveSingleTaskForCancelingTransferOutRequest
         * @return SaveSingleTaskForCancelingTransferOutResponse
         */
        public async Task<SaveSingleTaskForCancelingTransferOutResponse> SaveSingleTaskForCancelingTransferOutAsync(SaveSingleTaskForCancelingTransferOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCancelingTransferOutWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存创建dns服务器的任务请求
         *
         * @param request SaveSingleTaskForCreatingDnsHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCreatingDnsHostResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存创建dns服务器的任务请求
         *
         * @param request SaveSingleTaskForCreatingDnsHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCreatingDnsHostResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存创建dns服务器的任务请求
         *
         * @param request SaveSingleTaskForCreatingDnsHostRequest
         * @return SaveSingleTaskForCreatingDnsHostResponse
         */
        public SaveSingleTaskForCreatingDnsHostResponse SaveSingleTaskForCreatingDnsHost(SaveSingleTaskForCreatingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingDnsHostWithOptions(request, runtime);
        }

        /**
         * @summary 保存创建dns服务器的任务请求
         *
         * @param request SaveSingleTaskForCreatingDnsHostRequest
         * @return SaveSingleTaskForCreatingDnsHostResponse
         */
        public async Task<SaveSingleTaskForCreatingDnsHostResponse> SaveSingleTaskForCreatingDnsHostAsync(SaveSingleTaskForCreatingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingDnsHostWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存单个任务-注册订单
         *
         * @param request SaveSingleTaskForCreatingOrderActivateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCreatingOrderActivateResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhAddress))
            {
                query["ZhAddress"] = request.ZhAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhCity))
            {
                query["ZhCity"] = request.ZhCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhProvince))
            {
                query["ZhProvince"] = request.ZhProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantName))
            {
                query["ZhRegistrantName"] = request.ZhRegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCreatingOrderActivate",
                Version = "2018-01-29",
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

        /**
         * @summary 保存单个任务-注册订单
         *
         * @param request SaveSingleTaskForCreatingOrderActivateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCreatingOrderActivateResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhAddress))
            {
                query["ZhAddress"] = request.ZhAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhCity))
            {
                query["ZhCity"] = request.ZhCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhProvince))
            {
                query["ZhProvince"] = request.ZhProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantName))
            {
                query["ZhRegistrantName"] = request.ZhRegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForCreatingOrderActivate",
                Version = "2018-01-29",
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

        /**
         * @summary 保存单个任务-注册订单
         *
         * @param request SaveSingleTaskForCreatingOrderActivateRequest
         * @return SaveSingleTaskForCreatingOrderActivateResponse
         */
        public SaveSingleTaskForCreatingOrderActivateResponse SaveSingleTaskForCreatingOrderActivate(SaveSingleTaskForCreatingOrderActivateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingOrderActivateWithOptions(request, runtime);
        }

        /**
         * @summary 保存单个任务-注册订单
         *
         * @param request SaveSingleTaskForCreatingOrderActivateRequest
         * @return SaveSingleTaskForCreatingOrderActivateResponse
         */
        public async Task<SaveSingleTaskForCreatingOrderActivateResponse> SaveSingleTaskForCreatingOrderActivateAsync(SaveSingleTaskForCreatingOrderActivateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingOrderActivateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SaveSingleTaskForCreatingOrderRedeemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCreatingOrderRedeemResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveSingleTaskForCreatingOrderRedeemRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCreatingOrderRedeemResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveSingleTaskForCreatingOrderRedeemRequest
         * @return SaveSingleTaskForCreatingOrderRedeemResponse
         */
        public SaveSingleTaskForCreatingOrderRedeemResponse SaveSingleTaskForCreatingOrderRedeem(SaveSingleTaskForCreatingOrderRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingOrderRedeemWithOptions(request, runtime);
        }

        /**
         * @param request SaveSingleTaskForCreatingOrderRedeemRequest
         * @return SaveSingleTaskForCreatingOrderRedeemResponse
         */
        public async Task<SaveSingleTaskForCreatingOrderRedeemResponse> SaveSingleTaskForCreatingOrderRedeemAsync(SaveSingleTaskForCreatingOrderRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingOrderRedeemWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存单个任务-续费订单
         *
         * @param request SaveSingleTaskForCreatingOrderRenewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCreatingOrderRenewResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存单个任务-续费订单
         *
         * @param request SaveSingleTaskForCreatingOrderRenewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCreatingOrderRenewResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存单个任务-续费订单
         *
         * @param request SaveSingleTaskForCreatingOrderRenewRequest
         * @return SaveSingleTaskForCreatingOrderRenewResponse
         */
        public SaveSingleTaskForCreatingOrderRenewResponse SaveSingleTaskForCreatingOrderRenew(SaveSingleTaskForCreatingOrderRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingOrderRenewWithOptions(request, runtime);
        }

        /**
         * @summary 保存单个任务-续费订单
         *
         * @param request SaveSingleTaskForCreatingOrderRenewRequest
         * @return SaveSingleTaskForCreatingOrderRenewResponse
         */
        public async Task<SaveSingleTaskForCreatingOrderRenewResponse> SaveSingleTaskForCreatingOrderRenewAsync(SaveSingleTaskForCreatingOrderRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingOrderRenewWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SaveSingleTaskForCreatingOrderTransferRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCreatingOrderTransferResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveSingleTaskForCreatingOrderTransferRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForCreatingOrderTransferResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveSingleTaskForCreatingOrderTransferRequest
         * @return SaveSingleTaskForCreatingOrderTransferResponse
         */
        public SaveSingleTaskForCreatingOrderTransferResponse SaveSingleTaskForCreatingOrderTransfer(SaveSingleTaskForCreatingOrderTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingOrderTransferWithOptions(request, runtime);
        }

        /**
         * @param request SaveSingleTaskForCreatingOrderTransferRequest
         * @return SaveSingleTaskForCreatingOrderTransferResponse
         */
        public async Task<SaveSingleTaskForCreatingOrderTransferResponse> SaveSingleTaskForCreatingOrderTransferAsync(SaveSingleTaskForCreatingOrderTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingOrderTransferWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除dnsSec记录
         *
         * @param request SaveSingleTaskForDeletingDSRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForDeletingDSRecordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 删除dnsSec记录
         *
         * @param request SaveSingleTaskForDeletingDSRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForDeletingDSRecordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 删除dnsSec记录
         *
         * @param request SaveSingleTaskForDeletingDSRecordRequest
         * @return SaveSingleTaskForDeletingDSRecordResponse
         */
        public SaveSingleTaskForDeletingDSRecordResponse SaveSingleTaskForDeletingDSRecord(SaveSingleTaskForDeletingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForDeletingDSRecordWithOptions(request, runtime);
        }

        /**
         * @summary 删除dnsSec记录
         *
         * @param request SaveSingleTaskForDeletingDSRecordRequest
         * @return SaveSingleTaskForDeletingDSRecordResponse
         */
        public async Task<SaveSingleTaskForDeletingDSRecordResponse> SaveSingleTaskForDeletingDSRecordAsync(SaveSingleTaskForDeletingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForDeletingDSRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除DNS HOST任务
         *
         * @param request SaveSingleTaskForDeletingDnsHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForDeletingDnsHostResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 删除DNS HOST任务
         *
         * @param request SaveSingleTaskForDeletingDnsHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForDeletingDnsHostResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 删除DNS HOST任务
         *
         * @param request SaveSingleTaskForDeletingDnsHostRequest
         * @return SaveSingleTaskForDeletingDnsHostResponse
         */
        public SaveSingleTaskForDeletingDnsHostResponse SaveSingleTaskForDeletingDnsHost(SaveSingleTaskForDeletingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForDeletingDnsHostWithOptions(request, runtime);
        }

        /**
         * @summary 删除DNS HOST任务
         *
         * @param request SaveSingleTaskForDeletingDnsHostRequest
         * @return SaveSingleTaskForDeletingDnsHostResponse
         */
        public async Task<SaveSingleTaskForDeletingDnsHostResponse> SaveSingleTaskForDeletingDnsHostAsync(SaveSingleTaskForDeletingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForDeletingDnsHostWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SaveSingleTaskForDisassociatingEnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForDisassociatingEnsResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveSingleTaskForDisassociatingEnsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForDisassociatingEnsResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request SaveSingleTaskForDisassociatingEnsRequest
         * @return SaveSingleTaskForDisassociatingEnsResponse
         */
        public SaveSingleTaskForDisassociatingEnsResponse SaveSingleTaskForDisassociatingEns(SaveSingleTaskForDisassociatingEnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForDisassociatingEnsWithOptions(request, runtime);
        }

        /**
         * @param request SaveSingleTaskForDisassociatingEnsRequest
         * @return SaveSingleTaskForDisassociatingEnsResponse
         */
        public async Task<SaveSingleTaskForDisassociatingEnsResponse> SaveSingleTaskForDisassociatingEnsAsync(SaveSingleTaskForDisassociatingEnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForDisassociatingEnsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存单个任务-开启/关闭whois隐私保护锁
         *
         * @param request SaveSingleTaskForDomainNameProxyServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForDomainNameProxyServiceResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存单个任务-开启/关闭whois隐私保护锁
         *
         * @param request SaveSingleTaskForDomainNameProxyServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForDomainNameProxyServiceResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存单个任务-开启/关闭whois隐私保护锁
         *
         * @param request SaveSingleTaskForDomainNameProxyServiceRequest
         * @return SaveSingleTaskForDomainNameProxyServiceResponse
         */
        public SaveSingleTaskForDomainNameProxyServiceResponse SaveSingleTaskForDomainNameProxyService(SaveSingleTaskForDomainNameProxyServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForDomainNameProxyServiceWithOptions(request, runtime);
        }

        /**
         * @summary 保存单个任务-开启/关闭whois隐私保护锁
         *
         * @param request SaveSingleTaskForDomainNameProxyServiceRequest
         * @return SaveSingleTaskForDomainNameProxyServiceResponse
         */
        public async Task<SaveSingleTaskForDomainNameProxyServiceResponse> SaveSingleTaskForDomainNameProxyServiceAsync(SaveSingleTaskForDomainNameProxyServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForDomainNameProxyServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交生成域名证书任务
         *
         * @param request SaveSingleTaskForGenerateDomainCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForGenerateDomainCertificateResponse
         */
        public SaveSingleTaskForGenerateDomainCertificateResponse SaveSingleTaskForGenerateDomainCertificateWithOptions(SaveSingleTaskForGenerateDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SaveSingleTaskForGenerateDomainCertificate",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForGenerateDomainCertificateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交生成域名证书任务
         *
         * @param request SaveSingleTaskForGenerateDomainCertificateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForGenerateDomainCertificateResponse
         */
        public async Task<SaveSingleTaskForGenerateDomainCertificateResponse> SaveSingleTaskForGenerateDomainCertificateWithOptionsAsync(SaveSingleTaskForGenerateDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SaveSingleTaskForGenerateDomainCertificate",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForGenerateDomainCertificateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交生成域名证书任务
         *
         * @param request SaveSingleTaskForGenerateDomainCertificateRequest
         * @return SaveSingleTaskForGenerateDomainCertificateResponse
         */
        public SaveSingleTaskForGenerateDomainCertificateResponse SaveSingleTaskForGenerateDomainCertificate(SaveSingleTaskForGenerateDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForGenerateDomainCertificateWithOptions(request, runtime);
        }

        /**
         * @summary 提交生成域名证书任务
         *
         * @param request SaveSingleTaskForGenerateDomainCertificateRequest
         * @return SaveSingleTaskForGenerateDomainCertificateResponse
         */
        public async Task<SaveSingleTaskForGenerateDomainCertificateResponse> SaveSingleTaskForGenerateDomainCertificateAsync(SaveSingleTaskForGenerateDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForGenerateDomainCertificateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改DnsSec记录
         *
         * @param request SaveSingleTaskForModifyingDSRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForModifyingDSRecordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 修改DnsSec记录
         *
         * @param request SaveSingleTaskForModifyingDSRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForModifyingDSRecordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 修改DnsSec记录
         *
         * @param request SaveSingleTaskForModifyingDSRecordRequest
         * @return SaveSingleTaskForModifyingDSRecordResponse
         */
        public SaveSingleTaskForModifyingDSRecordResponse SaveSingleTaskForModifyingDSRecord(SaveSingleTaskForModifyingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForModifyingDSRecordWithOptions(request, runtime);
        }

        /**
         * @summary 修改DnsSec记录
         *
         * @param request SaveSingleTaskForModifyingDSRecordRequest
         * @return SaveSingleTaskForModifyingDSRecordResponse
         */
        public async Task<SaveSingleTaskForModifyingDSRecordResponse> SaveSingleTaskForModifyingDSRecordAsync(SaveSingleTaskForModifyingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForModifyingDSRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存修改dns服务器的任务请求
         *
         * @param request SaveSingleTaskForModifyingDnsHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForModifyingDnsHostResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存修改dns服务器的任务请求
         *
         * @param request SaveSingleTaskForModifyingDnsHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForModifyingDnsHostResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存修改dns服务器的任务请求
         *
         * @param request SaveSingleTaskForModifyingDnsHostRequest
         * @return SaveSingleTaskForModifyingDnsHostResponse
         */
        public SaveSingleTaskForModifyingDnsHostResponse SaveSingleTaskForModifyingDnsHost(SaveSingleTaskForModifyingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForModifyingDnsHostWithOptions(request, runtime);
        }

        /**
         * @summary 保存修改dns服务器的任务请求
         *
         * @param request SaveSingleTaskForModifyingDnsHostRequest
         * @return SaveSingleTaskForModifyingDnsHostResponse
         */
        public async Task<SaveSingleTaskForModifyingDnsHostResponse> SaveSingleTaskForModifyingDnsHostAsync(SaveSingleTaskForModifyingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForModifyingDnsHostWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 发送转移码
         *
         * @param request SaveSingleTaskForQueryingTransferAuthorizationCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForQueryingTransferAuthorizationCodeResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 发送转移码
         *
         * @param request SaveSingleTaskForQueryingTransferAuthorizationCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForQueryingTransferAuthorizationCodeResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 发送转移码
         *
         * @param request SaveSingleTaskForQueryingTransferAuthorizationCodeRequest
         * @return SaveSingleTaskForQueryingTransferAuthorizationCodeResponse
         */
        public SaveSingleTaskForQueryingTransferAuthorizationCodeResponse SaveSingleTaskForQueryingTransferAuthorizationCode(SaveSingleTaskForQueryingTransferAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForQueryingTransferAuthorizationCodeWithOptions(request, runtime);
        }

        /**
         * @summary 发送转移码
         *
         * @param request SaveSingleTaskForQueryingTransferAuthorizationCodeRequest
         * @return SaveSingleTaskForQueryingTransferAuthorizationCodeResponse
         */
        public async Task<SaveSingleTaskForQueryingTransferAuthorizationCodeResponse> SaveSingleTaskForQueryingTransferAuthorizationCodeAsync(SaveSingleTaskForQueryingTransferAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForQueryingTransferAuthorizationCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 单笔抢注批量接口
         *
         * @param request SaveSingleTaskForReserveDropListDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForReserveDropListDomainResponse
         */
        public SaveSingleTaskForReserveDropListDomainResponse SaveSingleTaskForReserveDropListDomainWithOptions(SaveSingleTaskForReserveDropListDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForReserveDropListDomain",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForReserveDropListDomainResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 单笔抢注批量接口
         *
         * @param request SaveSingleTaskForReserveDropListDomainRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForReserveDropListDomainResponse
         */
        public async Task<SaveSingleTaskForReserveDropListDomainResponse> SaveSingleTaskForReserveDropListDomainWithOptionsAsync(SaveSingleTaskForReserveDropListDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTemplateId))
            {
                query["ContactTemplateId"] = request.ContactTemplateId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveSingleTaskForReserveDropListDomain",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForReserveDropListDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 单笔抢注批量接口
         *
         * @param request SaveSingleTaskForReserveDropListDomainRequest
         * @return SaveSingleTaskForReserveDropListDomainResponse
         */
        public SaveSingleTaskForReserveDropListDomainResponse SaveSingleTaskForReserveDropListDomain(SaveSingleTaskForReserveDropListDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForReserveDropListDomainWithOptions(request, runtime);
        }

        /**
         * @summary 单笔抢注批量接口
         *
         * @param request SaveSingleTaskForReserveDropListDomainRequest
         * @return SaveSingleTaskForReserveDropListDomainResponse
         */
        public async Task<SaveSingleTaskForReserveDropListDomainResponse> SaveSingleTaskForReserveDropListDomainAsync(SaveSingleTaskForReserveDropListDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForReserveDropListDomainWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存art扩展信息任务
         *
         * @param request SaveSingleTaskForSaveArtExtensionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForSaveArtExtensionResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存art扩展信息任务
         *
         * @param request SaveSingleTaskForSaveArtExtensionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForSaveArtExtensionResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存art扩展信息任务
         *
         * @param request SaveSingleTaskForSaveArtExtensionRequest
         * @return SaveSingleTaskForSaveArtExtensionResponse
         */
        public SaveSingleTaskForSaveArtExtensionResponse SaveSingleTaskForSaveArtExtension(SaveSingleTaskForSaveArtExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForSaveArtExtensionWithOptions(request, runtime);
        }

        /**
         * @summary 保存art扩展信息任务
         *
         * @param request SaveSingleTaskForSaveArtExtensionRequest
         * @return SaveSingleTaskForSaveArtExtensionResponse
         */
        public async Task<SaveSingleTaskForSaveArtExtensionResponse> SaveSingleTaskForSaveArtExtensionAsync(SaveSingleTaskForSaveArtExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForSaveArtExtensionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 同步DnsSec记录
         *
         * @param request SaveSingleTaskForSynchronizingDSRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForSynchronizingDSRecordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 同步DnsSec记录
         *
         * @param request SaveSingleTaskForSynchronizingDSRecordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForSynchronizingDSRecordResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 同步DnsSec记录
         *
         * @param request SaveSingleTaskForSynchronizingDSRecordRequest
         * @return SaveSingleTaskForSynchronizingDSRecordResponse
         */
        public SaveSingleTaskForSynchronizingDSRecordResponse SaveSingleTaskForSynchronizingDSRecord(SaveSingleTaskForSynchronizingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForSynchronizingDSRecordWithOptions(request, runtime);
        }

        /**
         * @summary 同步DnsSec记录
         *
         * @param request SaveSingleTaskForSynchronizingDSRecordRequest
         * @return SaveSingleTaskForSynchronizingDSRecordResponse
         */
        public async Task<SaveSingleTaskForSynchronizingDSRecordResponse> SaveSingleTaskForSynchronizingDSRecordAsync(SaveSingleTaskForSynchronizingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForSynchronizingDSRecordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存同步dns服务器的任务请求
         *
         * @param request SaveSingleTaskForSynchronizingDnsHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForSynchronizingDnsHostResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存同步dns服务器的任务请求
         *
         * @param request SaveSingleTaskForSynchronizingDnsHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForSynchronizingDnsHostResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存同步dns服务器的任务请求
         *
         * @param request SaveSingleTaskForSynchronizingDnsHostRequest
         * @return SaveSingleTaskForSynchronizingDnsHostResponse
         */
        public SaveSingleTaskForSynchronizingDnsHostResponse SaveSingleTaskForSynchronizingDnsHost(SaveSingleTaskForSynchronizingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForSynchronizingDnsHostWithOptions(request, runtime);
        }

        /**
         * @summary 保存同步dns服务器的任务请求
         *
         * @param request SaveSingleTaskForSynchronizingDnsHostRequest
         * @return SaveSingleTaskForSynchronizingDnsHostResponse
         */
        public async Task<SaveSingleTaskForSynchronizingDnsHostResponse> SaveSingleTaskForSynchronizingDnsHostAsync(SaveSingleTaskForSynchronizingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForSynchronizingDnsHostWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存单个任务-开启/关闭禁止转移锁
         *
         * @param request SaveSingleTaskForTransferProhibitionLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForTransferProhibitionLockResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存单个任务-开启/关闭禁止转移锁
         *
         * @param request SaveSingleTaskForTransferProhibitionLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForTransferProhibitionLockResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存单个任务-开启/关闭禁止转移锁
         *
         * @param request SaveSingleTaskForTransferProhibitionLockRequest
         * @return SaveSingleTaskForTransferProhibitionLockResponse
         */
        public SaveSingleTaskForTransferProhibitionLockResponse SaveSingleTaskForTransferProhibitionLock(SaveSingleTaskForTransferProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForTransferProhibitionLockWithOptions(request, runtime);
        }

        /**
         * @summary 保存单个任务-开启/关闭禁止转移锁
         *
         * @param request SaveSingleTaskForTransferProhibitionLockRequest
         * @return SaveSingleTaskForTransferProhibitionLockResponse
         */
        public async Task<SaveSingleTaskForTransferProhibitionLockResponse> SaveSingleTaskForTransferProhibitionLockAsync(SaveSingleTaskForTransferProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForTransferProhibitionLockWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存单个任务-开启/关闭信息安全锁
         *
         * @param request SaveSingleTaskForUpdateProhibitionLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForUpdateProhibitionLockResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存单个任务-开启/关闭信息安全锁
         *
         * @param request SaveSingleTaskForUpdateProhibitionLockRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForUpdateProhibitionLockResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存单个任务-开启/关闭信息安全锁
         *
         * @param request SaveSingleTaskForUpdateProhibitionLockRequest
         * @return SaveSingleTaskForUpdateProhibitionLockResponse
         */
        public SaveSingleTaskForUpdateProhibitionLockResponse SaveSingleTaskForUpdateProhibitionLock(SaveSingleTaskForUpdateProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForUpdateProhibitionLockWithOptions(request, runtime);
        }

        /**
         * @summary 保存单个任务-开启/关闭信息安全锁
         *
         * @param request SaveSingleTaskForUpdateProhibitionLockRequest
         * @return SaveSingleTaskForUpdateProhibitionLockResponse
         */
        public async Task<SaveSingleTaskForUpdateProhibitionLockResponse> SaveSingleTaskForUpdateProhibitionLockAsync(SaveSingleTaskForUpdateProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForUpdateProhibitionLockWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存修改联系人的任务
         *
         * @param request SaveSingleTaskForUpdatingContactInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForUpdatingContactInfoResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存修改联系人的任务
         *
         * @param request SaveSingleTaskForUpdatingContactInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveSingleTaskForUpdatingContactInfoResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存修改联系人的任务
         *
         * @param request SaveSingleTaskForUpdatingContactInfoRequest
         * @return SaveSingleTaskForUpdatingContactInfoResponse
         */
        public SaveSingleTaskForUpdatingContactInfoResponse SaveSingleTaskForUpdatingContactInfo(SaveSingleTaskForUpdatingContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForUpdatingContactInfoWithOptions(request, runtime);
        }

        /**
         * @summary 保存修改联系人的任务
         *
         * @param request SaveSingleTaskForUpdatingContactInfoRequest
         * @return SaveSingleTaskForUpdatingContactInfoResponse
         */
        public async Task<SaveSingleTaskForUpdatingContactInfoResponse> SaveSingleTaskForUpdatingContactInfoAsync(SaveSingleTaskForUpdatingContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForUpdatingContactInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 保存删除域名的任务
         *
         * @param request SaveTaskForSubmittingDomainDeleteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveTaskForSubmittingDomainDeleteResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存删除域名的任务
         *
         * @param request SaveTaskForSubmittingDomainDeleteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveTaskForSubmittingDomainDeleteResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 保存删除域名的任务
         *
         * @param request SaveTaskForSubmittingDomainDeleteRequest
         * @return SaveTaskForSubmittingDomainDeleteResponse
         */
        public SaveTaskForSubmittingDomainDeleteResponse SaveTaskForSubmittingDomainDelete(SaveTaskForSubmittingDomainDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForSubmittingDomainDeleteWithOptions(request, runtime);
        }

        /**
         * @summary 保存删除域名的任务
         *
         * @param request SaveTaskForSubmittingDomainDeleteRequest
         * @return SaveTaskForSubmittingDomainDeleteResponse
         */
        public async Task<SaveTaskForSubmittingDomainDeleteResponse> SaveTaskForSubmittingDomainDeleteAsync(SaveTaskForSubmittingDomainDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForSubmittingDomainDeleteWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量提交域名资料
         *
         * @param request SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 批量提交域名资料
         *
         * @param request SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 批量提交域名资料
         *
         * @param request SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest
         * @return SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse
         */
        public SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredential(SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialWithOptions(request, runtime);
        }

        /**
         * @summary 批量提交域名资料
         *
         * @param request SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest
         * @return SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse
         */
        public async Task<SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse> SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialAsync(SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据模板保存域名的实名认证信息
         *
         * @param request SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 根据模板保存域名的实名认证信息
         *
         * @param request SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 根据模板保存域名的实名认证信息
         *
         * @param request SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest
         * @return SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse
         */
        public SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileID(SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDWithOptions(request, runtime);
        }

        /**
         * @summary 根据模板保存域名的实名认证信息
         *
         * @param request SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest
         * @return SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse
         */
        public async Task<SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse> SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDAsync(SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据联系人信息批量修改注册联系人信息
         *
         * @param request SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhAddress))
            {
                query["ZhAddress"] = request.ZhAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhCity))
            {
                query["ZhCity"] = request.ZhCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhProvince))
            {
                query["ZhProvince"] = request.ZhProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantName))
            {
                query["ZhRegistrantName"] = request.ZhRegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
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
                Version = "2018-01-29",
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

        /**
         * @summary 根据联系人信息批量修改注册联系人信息
         *
         * @param request SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhAddress))
            {
                query["ZhAddress"] = request.ZhAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhCity))
            {
                query["ZhCity"] = request.ZhCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhProvince))
            {
                query["ZhProvince"] = request.ZhProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantName))
            {
                query["ZhRegistrantName"] = request.ZhRegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
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
                Version = "2018-01-29",
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

        /**
         * @summary 根据联系人信息批量修改注册联系人信息
         *
         * @param request SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest
         * @return SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse
         */
        public SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse SaveTaskForUpdatingRegistrantInfoByIdentityCredential(SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForUpdatingRegistrantInfoByIdentityCredentialWithOptions(request, runtime);
        }

        /**
         * @summary 根据联系人信息批量修改注册联系人信息
         *
         * @param request SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest
         * @return SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse
         */
        public async Task<SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse> SaveTaskForUpdatingRegistrantInfoByIdentityCredentialAsync(SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForUpdatingRegistrantInfoByIdentityCredentialWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据模板批量修改注册联系人
         *
         * @param request SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 根据模板批量修改注册联系人
         *
         * @param request SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 根据模板批量修改注册联系人
         *
         * @param request SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest
         * @return SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse
         */
        public SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse SaveTaskForUpdatingRegistrantInfoByRegistrantProfileID(SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDWithOptions(request, runtime);
        }

        /**
         * @summary 根据模板批量修改注册联系人
         *
         * @param request SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest
         * @return SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse
         */
        public async Task<SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse> SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDAsync(SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Traverses domain names.
         *
         * @description If you have a large number of domain names, a slow response may occur when you call an API operation to query domain names. In this case, you can call this operation to query domain names more quickly. When you call this operation for the first time, specify the request parameters except ScrollId. A scroll ID is returned without other data. In the second request, use the scroll ID obtained from the previous response. In subsequent requests, the newly specified request parameters do not take effect, and the request parameters that are specified in the first request prevail.
         *
         * @param request ScrollDomainListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScrollDomainListResponse
         */
        public ScrollDomainListResponse ScrollDomainListWithOptions(ScrollDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupId))
            {
                query["DomainGroupId"] = request.DomainGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainStatus))
            {
                query["DomainStatus"] = request.DomainStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndExpirationDate))
            {
                query["EndExpirationDate"] = request.EndExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndLength))
            {
                query["EndLength"] = request.EndLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndRegistrationDate))
            {
                query["EndRegistrationDate"] = request.EndRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Excluded))
            {
                query["Excluded"] = request.Excluded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedPrefix))
            {
                query["ExcludedPrefix"] = request.ExcludedPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedSuffix))
            {
                query["ExcludedSuffix"] = request.ExcludedSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Form))
            {
                query["Form"] = request.Form;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWordPrefix))
            {
                query["KeyWordPrefix"] = request.KeyWordPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWordSuffix))
            {
                query["KeyWordSuffix"] = request.KeyWordSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDomainType))
            {
                query["ProductDomainType"] = request.ProductDomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScrollId))
            {
                query["ScrollId"] = request.ScrollId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartExpirationDate))
            {
                query["StartExpirationDate"] = request.StartExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartLength))
            {
                query["StartLength"] = request.StartLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRegistrationDate))
            {
                query["StartRegistrationDate"] = request.StartRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Suffixs))
            {
                query["Suffixs"] = request.Suffixs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeType))
            {
                query["TradeType"] = request.TradeType;
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
                Action = "ScrollDomainList",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScrollDomainListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Traverses domain names.
         *
         * @description If you have a large number of domain names, a slow response may occur when you call an API operation to query domain names. In this case, you can call this operation to query domain names more quickly. When you call this operation for the first time, specify the request parameters except ScrollId. A scroll ID is returned without other data. In the second request, use the scroll ID obtained from the previous response. In subsequent requests, the newly specified request parameters do not take effect, and the request parameters that are specified in the first request prevail.
         *
         * @param request ScrollDomainListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScrollDomainListResponse
         */
        public async Task<ScrollDomainListResponse> ScrollDomainListWithOptionsAsync(ScrollDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupId))
            {
                query["DomainGroupId"] = request.DomainGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainStatus))
            {
                query["DomainStatus"] = request.DomainStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndExpirationDate))
            {
                query["EndExpirationDate"] = request.EndExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndLength))
            {
                query["EndLength"] = request.EndLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndRegistrationDate))
            {
                query["EndRegistrationDate"] = request.EndRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Excluded))
            {
                query["Excluded"] = request.Excluded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedPrefix))
            {
                query["ExcludedPrefix"] = request.ExcludedPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludedSuffix))
            {
                query["ExcludedSuffix"] = request.ExcludedSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Form))
            {
                query["Form"] = request.Form;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["KeyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWordPrefix))
            {
                query["KeyWordPrefix"] = request.KeyWordPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWordSuffix))
            {
                query["KeyWordSuffix"] = request.KeyWordSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductDomainType))
            {
                query["ProductDomainType"] = request.ProductDomainType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScrollId))
            {
                query["ScrollId"] = request.ScrollId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartExpirationDate))
            {
                query["StartExpirationDate"] = request.StartExpirationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartLength))
            {
                query["StartLength"] = request.StartLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRegistrationDate))
            {
                query["StartRegistrationDate"] = request.StartRegistrationDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Suffixs))
            {
                query["Suffixs"] = request.Suffixs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeType))
            {
                query["TradeType"] = request.TradeType;
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
                Action = "ScrollDomainList",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScrollDomainListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Traverses domain names.
         *
         * @description If you have a large number of domain names, a slow response may occur when you call an API operation to query domain names. In this case, you can call this operation to query domain names more quickly. When you call this operation for the first time, specify the request parameters except ScrollId. A scroll ID is returned without other data. In the second request, use the scroll ID obtained from the previous response. In subsequent requests, the newly specified request parameters do not take effect, and the request parameters that are specified in the first request prevail.
         *
         * @param request ScrollDomainListRequest
         * @return ScrollDomainListResponse
         */
        public ScrollDomainListResponse ScrollDomainList(ScrollDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScrollDomainListWithOptions(request, runtime);
        }

        /**
         * @summary Traverses domain names.
         *
         * @description If you have a large number of domain names, a slow response may occur when you call an API operation to query domain names. In this case, you can call this operation to query domain names more quickly. When you call this operation for the first time, specify the request parameters except ScrollId. A scroll ID is returned without other data. In the second request, use the scroll ID obtained from the previous response. In subsequent requests, the newly specified request parameters do not take effect, and the request parameters that are specified in the first request prevail.
         *
         * @param request ScrollDomainListRequest
         * @return ScrollDomainListResponse
         */
        public async Task<ScrollDomainListResponse> ScrollDomainListAsync(ScrollDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScrollDomainListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设置默认模板
         *
         * @param request SetDefaultRegistrantProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDefaultRegistrantProfileResponse
         */
        public SetDefaultRegistrantProfileResponse SetDefaultRegistrantProfileWithOptions(SetDefaultRegistrantProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "SetDefaultRegistrantProfile",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultRegistrantProfileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设置默认模板
         *
         * @param request SetDefaultRegistrantProfileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetDefaultRegistrantProfileResponse
         */
        public async Task<SetDefaultRegistrantProfileResponse> SetDefaultRegistrantProfileWithOptionsAsync(SetDefaultRegistrantProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "SetDefaultRegistrantProfile",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetDefaultRegistrantProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设置默认模板
         *
         * @param request SetDefaultRegistrantProfileRequest
         * @return SetDefaultRegistrantProfileResponse
         */
        public SetDefaultRegistrantProfileResponse SetDefaultRegistrantProfile(SetDefaultRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultRegistrantProfileWithOptions(request, runtime);
        }

        /**
         * @summary 设置默认模板
         *
         * @param request SetDefaultRegistrantProfileRequest
         * @return SetDefaultRegistrantProfileResponse
         */
        public async Task<SetDefaultRegistrantProfileResponse> SetDefaultRegistrantProfileAsync(SetDefaultRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultRegistrantProfileWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 域名设置自动续费
         *
         * @param request SetupDomainAutoRenewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetupDomainAutoRenewResponse
         */
        public SetupDomainAutoRenewResponse SetupDomainAutoRenewWithOptions(SetupDomainAutoRenewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["Operation"] = request.Operation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetupDomainAutoRenew",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetupDomainAutoRenewResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 域名设置自动续费
         *
         * @param request SetupDomainAutoRenewRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetupDomainAutoRenewResponse
         */
        public async Task<SetupDomainAutoRenewResponse> SetupDomainAutoRenewWithOptionsAsync(SetupDomainAutoRenewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["Operation"] = request.Operation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetupDomainAutoRenew",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetupDomainAutoRenewResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 域名设置自动续费
         *
         * @param request SetupDomainAutoRenewRequest
         * @return SetupDomainAutoRenewResponse
         */
        public SetupDomainAutoRenewResponse SetupDomainAutoRenew(SetupDomainAutoRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupDomainAutoRenewWithOptions(request, runtime);
        }

        /**
         * @summary 域名设置自动续费
         *
         * @param request SetupDomainAutoRenewRequest
         * @return SetupDomainAutoRenewResponse
         */
        public async Task<SetupDomainAutoRenewResponse> SetupDomainAutoRenewAsync(SetupDomainAutoRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupDomainAutoRenewWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 域名特殊业务提交资料
         *
         * @param request SubmitDomainSpecialBizCredentialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDomainSpecialBizCredentialsResponse
         */
        public SubmitDomainSpecialBizCredentialsResponse SubmitDomainSpecialBizCredentialsWithOptions(SubmitDomainSpecialBizCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credentials))
            {
                body["Credentials"] = request.Credentials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["Extend"] = request.Extend;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDomainSpecialBizCredentials",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDomainSpecialBizCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 域名特殊业务提交资料
         *
         * @param request SubmitDomainSpecialBizCredentialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDomainSpecialBizCredentialsResponse
         */
        public async Task<SubmitDomainSpecialBizCredentialsResponse> SubmitDomainSpecialBizCredentialsWithOptionsAsync(SubmitDomainSpecialBizCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credentials))
            {
                body["Credentials"] = request.Credentials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["Extend"] = request.Extend;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDomainSpecialBizCredentials",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDomainSpecialBizCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 域名特殊业务提交资料
         *
         * @param request SubmitDomainSpecialBizCredentialsRequest
         * @return SubmitDomainSpecialBizCredentialsResponse
         */
        public SubmitDomainSpecialBizCredentialsResponse SubmitDomainSpecialBizCredentials(SubmitDomainSpecialBizCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDomainSpecialBizCredentialsWithOptions(request, runtime);
        }

        /**
         * @summary 域名特殊业务提交资料
         *
         * @param request SubmitDomainSpecialBizCredentialsRequest
         * @return SubmitDomainSpecialBizCredentialsResponse
         */
        public async Task<SubmitDomainSpecialBizCredentialsResponse> SubmitDomainSpecialBizCredentialsAsync(SubmitDomainSpecialBizCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDomainSpecialBizCredentialsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交邮箱验证
         *
         * @param request SubmitEmailVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitEmailVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 提交邮箱验证
         *
         * @param request SubmitEmailVerificationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitEmailVerificationResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 提交邮箱验证
         *
         * @param request SubmitEmailVerificationRequest
         * @return SubmitEmailVerificationResponse
         */
        public SubmitEmailVerificationResponse SubmitEmailVerification(SubmitEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitEmailVerificationWithOptions(request, runtime);
        }

        /**
         * @summary 提交邮箱验证
         *
         * @param request SubmitEmailVerificationRequest
         * @return SubmitEmailVerificationResponse
         */
        public async Task<SubmitEmailVerificationResponse> SubmitEmailVerificationAsync(SubmitEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitEmailVerificationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交申请信息
         *
         * @param request SubmitOperationAuditInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitOperationAuditInfoResponse
         */
        public SubmitOperationAuditInfoResponse SubmitOperationAuditInfoWithOptions(SubmitOperationAuditInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditInfo))
            {
                query["AuditInfo"] = request.AuditInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditType))
            {
                query["AuditType"] = request.AuditType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitOperationAuditInfo",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitOperationAuditInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交申请信息
         *
         * @param request SubmitOperationAuditInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitOperationAuditInfoResponse
         */
        public async Task<SubmitOperationAuditInfoResponse> SubmitOperationAuditInfoWithOptionsAsync(SubmitOperationAuditInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditInfo))
            {
                query["AuditInfo"] = request.AuditInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditType))
            {
                query["AuditType"] = request.AuditType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitOperationAuditInfo",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitOperationAuditInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交申请信息
         *
         * @param request SubmitOperationAuditInfoRequest
         * @return SubmitOperationAuditInfoResponse
         */
        public SubmitOperationAuditInfoResponse SubmitOperationAuditInfo(SubmitOperationAuditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitOperationAuditInfoWithOptions(request, runtime);
        }

        /**
         * @summary 提交申请信息
         *
         * @param request SubmitOperationAuditInfoRequest
         * @return SubmitOperationAuditInfoResponse
         */
        public async Task<SubmitOperationAuditInfoResponse> SubmitOperationAuditInfoAsync(SubmitOperationAuditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitOperationAuditInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 提交证件资料
         *
         * @param request SubmitOperationCredentialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitOperationCredentialsResponse
         */
        public SubmitOperationCredentialsResponse SubmitOperationCredentialsWithOptions(SubmitOperationCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditRecordId))
            {
                query["AuditRecordId"] = request.AuditRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditType))
            {
                query["AuditType"] = request.AuditType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credentials))
            {
                query["Credentials"] = request.Credentials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegType))
            {
                query["RegType"] = request.RegType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitOperationCredentials",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitOperationCredentialsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 提交证件资料
         *
         * @param request SubmitOperationCredentialsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitOperationCredentialsResponse
         */
        public async Task<SubmitOperationCredentialsResponse> SubmitOperationCredentialsWithOptionsAsync(SubmitOperationCredentialsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditRecordId))
            {
                query["AuditRecordId"] = request.AuditRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditType))
            {
                query["AuditType"] = request.AuditType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Credentials))
            {
                query["Credentials"] = request.Credentials;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegType))
            {
                query["RegType"] = request.RegType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitOperationCredentials",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitOperationCredentialsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 提交证件资料
         *
         * @param request SubmitOperationCredentialsRequest
         * @return SubmitOperationCredentialsResponse
         */
        public SubmitOperationCredentialsResponse SubmitOperationCredentials(SubmitOperationCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitOperationCredentialsWithOptions(request, runtime);
        }

        /**
         * @summary 提交证件资料
         *
         * @param request SubmitOperationCredentialsRequest
         * @return SubmitOperationCredentialsResponse
         */
        public async Task<SubmitOperationCredentialsResponse> SubmitOperationCredentialsAsync(SubmitOperationCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitOperationCredentialsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request TransferInCheckMailTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferInCheckMailTokenResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request TransferInCheckMailTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferInCheckMailTokenResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request TransferInCheckMailTokenRequest
         * @return TransferInCheckMailTokenResponse
         */
        public TransferInCheckMailTokenResponse TransferInCheckMailToken(TransferInCheckMailTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInCheckMailTokenWithOptions(request, runtime);
        }

        /**
         * @param request TransferInCheckMailTokenRequest
         * @return TransferInCheckMailTokenResponse
         */
        public async Task<TransferInCheckMailTokenResponse> TransferInCheckMailTokenAsync(TransferInCheckMailTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInCheckMailTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @param request TransferInReenterTransferAuthorizationCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferInReenterTransferAuthorizationCodeResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request TransferInReenterTransferAuthorizationCodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferInReenterTransferAuthorizationCodeResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request TransferInReenterTransferAuthorizationCodeRequest
         * @return TransferInReenterTransferAuthorizationCodeResponse
         */
        public TransferInReenterTransferAuthorizationCodeResponse TransferInReenterTransferAuthorizationCode(TransferInReenterTransferAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInReenterTransferAuthorizationCodeWithOptions(request, runtime);
        }

        /**
         * @param request TransferInReenterTransferAuthorizationCodeRequest
         * @return TransferInReenterTransferAuthorizationCodeResponse
         */
        public async Task<TransferInReenterTransferAuthorizationCodeResponse> TransferInReenterTransferAuthorizationCodeAsync(TransferInReenterTransferAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInReenterTransferAuthorizationCodeWithOptionsAsync(request, runtime);
        }

        /**
         * @param request TransferInRefetchWhoisEmailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferInRefetchWhoisEmailResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request TransferInRefetchWhoisEmailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferInRefetchWhoisEmailResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request TransferInRefetchWhoisEmailRequest
         * @return TransferInRefetchWhoisEmailResponse
         */
        public TransferInRefetchWhoisEmailResponse TransferInRefetchWhoisEmail(TransferInRefetchWhoisEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInRefetchWhoisEmailWithOptions(request, runtime);
        }

        /**
         * @param request TransferInRefetchWhoisEmailRequest
         * @return TransferInRefetchWhoisEmailResponse
         */
        public async Task<TransferInRefetchWhoisEmailResponse> TransferInRefetchWhoisEmailAsync(TransferInRefetchWhoisEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInRefetchWhoisEmailWithOptionsAsync(request, runtime);
        }

        /**
         * @param request TransferInResendMailTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferInResendMailTokenResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request TransferInResendMailTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TransferInResendMailTokenResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @param request TransferInResendMailTokenRequest
         * @return TransferInResendMailTokenResponse
         */
        public TransferInResendMailTokenResponse TransferInResendMailToken(TransferInResendMailTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInResendMailTokenWithOptions(request, runtime);
        }

        /**
         * @param request TransferInResendMailTokenRequest
         * @return TransferInResendMailTokenResponse
         */
        public async Task<TransferInResendMailTokenResponse> TransferInResendMailTokenAsync(TransferInResendMailTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInResendMailTokenWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 向分组设置域名
         *
         * @param request UpdateDomainToDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainToDomainGroupResponse
         */
        public UpdateDomainToDomainGroupResponse UpdateDomainToDomainGroupWithOptions(UpdateDomainToDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["DataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupId))
            {
                query["DomainGroupId"] = request.DomainGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replace))
            {
                query["Replace"] = request.Replace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileToUpload))
            {
                body["FileToUpload"] = request.FileToUpload;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomainToDomainGroup",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainToDomainGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 向分组设置域名
         *
         * @param request UpdateDomainToDomainGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDomainToDomainGroupResponse
         */
        public async Task<UpdateDomainToDomainGroupResponse> UpdateDomainToDomainGroupWithOptionsAsync(UpdateDomainToDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["DataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainGroupId))
            {
                query["DomainGroupId"] = request.DomainGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replace))
            {
                query["Replace"] = request.Replace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileToUpload))
            {
                body["FileToUpload"] = request.FileToUpload;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDomainToDomainGroup",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDomainToDomainGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 向分组设置域名
         *
         * @param request UpdateDomainToDomainGroupRequest
         * @return UpdateDomainToDomainGroupResponse
         */
        public UpdateDomainToDomainGroupResponse UpdateDomainToDomainGroup(UpdateDomainToDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDomainToDomainGroupWithOptions(request, runtime);
        }

        /**
         * @summary 向分组设置域名
         *
         * @param request UpdateDomainToDomainGroupRequest
         * @return UpdateDomainToDomainGroupResponse
         */
        public async Task<UpdateDomainToDomainGroupResponse> UpdateDomainToDomainGroupAsync(UpdateDomainToDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDomainToDomainGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 校验联系人信息
         *
         * @param request VerifyContactFieldRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyContactFieldResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhAddress))
            {
                query["ZhAddress"] = request.ZhAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhCity))
            {
                query["ZhCity"] = request.ZhCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhProvince))
            {
                query["ZhProvince"] = request.ZhProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantName))
            {
                query["ZhRegistrantName"] = request.ZhRegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyContactField",
                Version = "2018-01-29",
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

        /**
         * @summary 校验联系人信息
         *
         * @param request VerifyContactFieldRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyContactFieldResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhAddress))
            {
                query["ZhAddress"] = request.ZhAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhCity))
            {
                query["ZhCity"] = request.ZhCity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhProvince))
            {
                query["ZhProvince"] = request.ZhProvince;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantName))
            {
                query["ZhRegistrantName"] = request.ZhRegistrantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZhRegistrantOrganization))
            {
                query["ZhRegistrantOrganization"] = request.ZhRegistrantOrganization;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyContactField",
                Version = "2018-01-29",
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

        /**
         * @summary 校验联系人信息
         *
         * @param request VerifyContactFieldRequest
         * @return VerifyContactFieldResponse
         */
        public VerifyContactFieldResponse VerifyContactField(VerifyContactFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyContactFieldWithOptions(request, runtime);
        }

        /**
         * @summary 校验联系人信息
         *
         * @param request VerifyContactFieldRequest
         * @return VerifyContactFieldResponse
         */
        public async Task<VerifyContactFieldResponse> VerifyContactFieldAsync(VerifyContactFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyContactFieldWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 验证邮箱Token
         *
         * @param request VerifyEmailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyEmailResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 验证邮箱Token
         *
         * @param request VerifyEmailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyEmailResponse
         */
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
                Version = "2018-01-29",
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

        /**
         * @summary 验证邮箱Token
         *
         * @param request VerifyEmailRequest
         * @return VerifyEmailResponse
         */
        public VerifyEmailResponse VerifyEmail(VerifyEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyEmailWithOptions(request, runtime);
        }

        /**
         * @summary 验证邮箱Token
         *
         * @param request VerifyEmailRequest
         * @return VerifyEmailResponse
         */
        public async Task<VerifyEmailResponse> VerifyEmailAsync(VerifyEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyEmailWithOptionsAsync(request, runtime);
        }

    }
}
