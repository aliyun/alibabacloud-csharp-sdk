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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AcknowledgeTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcknowledgeTaskResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AcknowledgeTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcknowledgeTaskResultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AcknowledgeTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// AcknowledgeTaskResultResponse
        /// </returns>
        public AcknowledgeTaskResultResponse AcknowledgeTaskResult(AcknowledgeTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcknowledgeTaskResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认任务结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AcknowledgeTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// AcknowledgeTaskResultResponse
        /// </returns>
        public async Task<AcknowledgeTaskResultResponse> AcknowledgeTaskResultAsync(AcknowledgeTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcknowledgeTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键字进行批量模糊匹配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchFuzzyMatchDomainSensitiveWordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchFuzzyMatchDomainSensitiveWordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键字进行批量模糊匹配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchFuzzyMatchDomainSensitiveWordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchFuzzyMatchDomainSensitiveWordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键字进行批量模糊匹配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchFuzzyMatchDomainSensitiveWordRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchFuzzyMatchDomainSensitiveWordResponse
        /// </returns>
        public BatchFuzzyMatchDomainSensitiveWordResponse BatchFuzzyMatchDomainSensitiveWord(BatchFuzzyMatchDomainSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchFuzzyMatchDomainSensitiveWordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键字进行批量模糊匹配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchFuzzyMatchDomainSensitiveWordRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchFuzzyMatchDomainSensitiveWordResponse
        /// </returns>
        public async Task<BatchFuzzyMatchDomainSensitiveWordResponse> BatchFuzzyMatchDomainSensitiveWordAsync(BatchFuzzyMatchDomainSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchFuzzyMatchDomainSensitiveWordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels real-name verification for a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelDomainVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDomainVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels real-name verification for a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelDomainVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDomainVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels real-name verification for a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelDomainVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDomainVerificationResponse
        /// </returns>
        public CancelDomainVerificationResponse CancelDomainVerification(CancelDomainVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelDomainVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels real-name verification for a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelDomainVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDomainVerificationResponse
        /// </returns>
        public async Task<CancelDomainVerificationResponse> CancelDomainVerificationAsync(CancelDomainVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelDomainVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOperationAuditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelOperationAuditResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOperationAuditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelOperationAuditResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOperationAuditRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelOperationAuditResponse
        /// </returns>
        public CancelOperationAuditResponse CancelOperationAudit(CancelOperationAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOperationAuditWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelOperationAuditRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelOperationAuditResponse
        /// </returns>
        public async Task<CancelOperationAuditResponse> CancelOperationAuditAsync(CancelOperationAuditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOperationAuditWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CancelQualificationVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelQualificationVerificationResponse
        /// </returns>
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

        /// <param name="request">
        /// CancelQualificationVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelQualificationVerificationResponse
        /// </returns>
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

        /// <param name="request">
        /// CancelQualificationVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelQualificationVerificationResponse
        /// </returns>
        public CancelQualificationVerificationResponse CancelQualificationVerification(CancelQualificationVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelQualificationVerificationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CancelQualificationVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelQualificationVerificationResponse
        /// </returns>
        public async Task<CancelQualificationVerificationResponse> CancelQualificationVerificationAsync(CancelQualificationVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelQualificationVerificationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CancelTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// CancelTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
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

        /// <param name="request">
        /// CancelTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
        public CancelTaskResponse CancelTask(CancelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelTaskWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CancelTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelTaskResponse
        /// </returns>
        public async Task<CancelTaskResponse> CancelTaskAsync(CancelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例所在资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例所在资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例所在资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改实例所在资源组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CheckDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainResponse
        /// </returns>
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

        /// <param name="request">
        /// CheckDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainResponse
        /// </returns>
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

        /// <param name="request">
        /// CheckDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainResponse
        /// </returns>
        public CheckDomainResponse CheckDomain(CheckDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDomainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CheckDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainResponse
        /// </returns>
        public async Task<CheckDomainResponse> CheckDomainAsync(CheckDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDomainWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CheckDomainSunriseClaimRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainSunriseClaimResponse
        /// </returns>
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

        /// <param name="request">
        /// CheckDomainSunriseClaimRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainSunriseClaimResponse
        /// </returns>
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

        /// <param name="request">
        /// CheckDomainSunriseClaimRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainSunriseClaimResponse
        /// </returns>
        public CheckDomainSunriseClaimResponse CheckDomainSunriseClaim(CheckDomainSunriseClaimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDomainSunriseClaimWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CheckDomainSunriseClaimRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainSunriseClaimResponse
        /// </returns>
        public async Task<CheckDomainSunriseClaimResponse> CheckDomainSunriseClaimAsync(CheckDomainSunriseClaimRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDomainSunriseClaimWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验在售国际一口价域名状态和询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckIntlFixPriceDomainStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckIntlFixPriceDomainStatusResponse
        /// </returns>
        public CheckIntlFixPriceDomainStatusResponse CheckIntlFixPriceDomainStatusWithOptions(CheckIntlFixPriceDomainStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckIntlFixPriceDomainStatus",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckIntlFixPriceDomainStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验在售国际一口价域名状态和询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckIntlFixPriceDomainStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckIntlFixPriceDomainStatusResponse
        /// </returns>
        public async Task<CheckIntlFixPriceDomainStatusResponse> CheckIntlFixPriceDomainStatusWithOptionsAsync(CheckIntlFixPriceDomainStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckIntlFixPriceDomainStatus",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckIntlFixPriceDomainStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验在售国际一口价域名状态和询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckIntlFixPriceDomainStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckIntlFixPriceDomainStatusResponse
        /// </returns>
        public CheckIntlFixPriceDomainStatusResponse CheckIntlFixPriceDomainStatus(CheckIntlFixPriceDomainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckIntlFixPriceDomainStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验在售国际一口价域名状态和询价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckIntlFixPriceDomainStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckIntlFixPriceDomainStatusResponse
        /// </returns>
        public async Task<CheckIntlFixPriceDomainStatusResponse> CheckIntlFixPriceDomainStatusAsync(CheckIntlFixPriceDomainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckIntlFixPriceDomainStatusWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CheckMaxYearOfServerLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckMaxYearOfServerLockResponse
        /// </returns>
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

        /// <param name="request">
        /// CheckMaxYearOfServerLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckMaxYearOfServerLockResponse
        /// </returns>
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

        /// <param name="request">
        /// CheckMaxYearOfServerLockRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckMaxYearOfServerLockResponse
        /// </returns>
        public CheckMaxYearOfServerLockResponse CheckMaxYearOfServerLock(CheckMaxYearOfServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMaxYearOfServerLockWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CheckMaxYearOfServerLockRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckMaxYearOfServerLockResponse
        /// </returns>
        public async Task<CheckMaxYearOfServerLockResponse> CheckMaxYearOfServerLockAsync(CheckMaxYearOfServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMaxYearOfServerLockWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CheckProcessingServerLockApplyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckProcessingServerLockApplyResponse
        /// </returns>
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

        /// <param name="request">
        /// CheckProcessingServerLockApplyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckProcessingServerLockApplyResponse
        /// </returns>
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

        /// <param name="request">
        /// CheckProcessingServerLockApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckProcessingServerLockApplyResponse
        /// </returns>
        public CheckProcessingServerLockApplyResponse CheckProcessingServerLockApply(CheckProcessingServerLockApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckProcessingServerLockApplyWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CheckProcessingServerLockApplyRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckProcessingServerLockApplyResponse
        /// </returns>
        public async Task<CheckProcessingServerLockApplyResponse> CheckProcessingServerLockApplyAsync(CheckProcessingServerLockApplyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckProcessingServerLockApplyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CheckTransferInFeasibilityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckTransferInFeasibilityResponse
        /// </returns>
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

        /// <param name="request">
        /// CheckTransferInFeasibilityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckTransferInFeasibilityResponse
        /// </returns>
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

        /// <param name="request">
        /// CheckTransferInFeasibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckTransferInFeasibilityResponse
        /// </returns>
        public CheckTransferInFeasibilityResponse CheckTransferInFeasibility(CheckTransferInFeasibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckTransferInFeasibilityWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CheckTransferInFeasibilityRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckTransferInFeasibilityResponse
        /// </returns>
        public async Task<CheckTransferInFeasibilityResponse> CheckTransferInFeasibilityAsync(CheckTransferInFeasibilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckTransferInFeasibilityWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ConfirmTransferInEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmTransferInEmailResponse
        /// </returns>
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

        /// <param name="request">
        /// ConfirmTransferInEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmTransferInEmailResponse
        /// </returns>
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

        /// <param name="request">
        /// ConfirmTransferInEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmTransferInEmailResponse
        /// </returns>
        public ConfirmTransferInEmailResponse ConfirmTransferInEmail(ConfirmTransferInEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmTransferInEmailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ConfirmTransferInEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmTransferInEmailResponse
        /// </returns>
        public async Task<ConfirmTransferInEmailResponse> ConfirmTransferInEmailAsync(ConfirmTransferInEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmTransferInEmailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建国际一口价订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIntlFixedPriceDomainOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIntlFixedPriceDomainOrderResponse
        /// </returns>
        public CreateIntlFixedPriceDomainOrderResponse CreateIntlFixedPriceDomainOrderWithOptions(CreateIntlFixedPriceDomainOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedPrice))
            {
                query["ExpectedPrice"] = request.ExpectedPrice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIntlFixedPriceDomainOrder",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntlFixedPriceDomainOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建国际一口价订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIntlFixedPriceDomainOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIntlFixedPriceDomainOrderResponse
        /// </returns>
        public async Task<CreateIntlFixedPriceDomainOrderResponse> CreateIntlFixedPriceDomainOrderWithOptionsAsync(CreateIntlFixedPriceDomainOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedPrice))
            {
                query["ExpectedPrice"] = request.ExpectedPrice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIntlFixedPriceDomainOrder",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIntlFixedPriceDomainOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建国际一口价订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIntlFixedPriceDomainOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIntlFixedPriceDomainOrderResponse
        /// </returns>
        public CreateIntlFixedPriceDomainOrderResponse CreateIntlFixedPriceDomainOrder(CreateIntlFixedPriceDomainOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIntlFixedPriceDomainOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建国际一口价订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIntlFixedPriceDomainOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIntlFixedPriceDomainOrderResponse
        /// </returns>
        public async Task<CreateIntlFixedPriceDomainOrderResponse> CreateIntlFixedPriceDomainOrderAsync(CreateIntlFixedPriceDomainOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIntlFixedPriceDomainOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContactTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactTemplatesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContactTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactTemplatesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContactTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactTemplatesResponse
        /// </returns>
        public DeleteContactTemplatesResponse DeleteContactTemplates(DeleteContactTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContactTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteContactTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContactTemplatesResponse
        /// </returns>
        public async Task<DeleteContactTemplatesResponse> DeleteContactTemplatesAsync(DeleteContactTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContactTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除域名分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDomainGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDomainGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除域名分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDomainGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDomainGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除域名分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDomainGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDomainGroupResponse
        /// </returns>
        public DeleteDomainGroupResponse DeleteDomainGroup(DeleteDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除域名分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDomainGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDomainGroupResponse
        /// </returns>
        public async Task<DeleteDomainGroupResponse> DeleteDomainGroupAsync(DeleteDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除邮箱验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEmailVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEmailVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除邮箱验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEmailVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteEmailVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除邮箱验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEmailVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEmailVerificationResponse
        /// </returns>
        public DeleteEmailVerificationResponse DeleteEmailVerification(DeleteEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEmailVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除邮箱验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteEmailVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteEmailVerificationResponse
        /// </returns>
        public async Task<DeleteEmailVerificationResponse> DeleteEmailVerificationAsync(DeleteEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEmailVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRegistrantProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRegistrantProfileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRegistrantProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRegistrantProfileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRegistrantProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRegistrantProfileResponse
        /// </returns>
        public DeleteRegistrantProfileResponse DeleteRegistrantProfile(DeleteRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRegistrantProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRegistrantProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRegistrantProfileResponse
        /// </returns>
        public async Task<DeleteRegistrantProfileResponse> DeleteRegistrantProfileAsync(DeleteRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRegistrantProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消域名特殊业务流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DomainSpecialBizCancelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DomainSpecialBizCancelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消域名特殊业务流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DomainSpecialBizCancelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DomainSpecialBizCancelResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消域名特殊业务流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DomainSpecialBizCancelRequest
        /// </param>
        /// 
        /// <returns>
        /// DomainSpecialBizCancelResponse
        /// </returns>
        public DomainSpecialBizCancelResponse DomainSpecialBizCancel(DomainSpecialBizCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DomainSpecialBizCancelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消域名特殊业务流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DomainSpecialBizCancelRequest
        /// </param>
        /// 
        /// <returns>
        /// DomainSpecialBizCancelResponse
        /// </returns>
        public async Task<DomainSpecialBizCancelResponse> DomainSpecialBizCancelAsync(DomainSpecialBizCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DomainSpecialBizCancelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>邮箱验证通过</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EmailVerifiedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EmailVerifiedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>邮箱验证通过</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EmailVerifiedRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EmailVerifiedResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>邮箱验证通过</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EmailVerifiedRequest
        /// </param>
        /// 
        /// <returns>
        /// EmailVerifiedResponse
        /// </returns>
        public EmailVerifiedResponse EmailVerified(EmailVerifiedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EmailVerifiedWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>邮箱验证通过</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EmailVerifiedRequest
        /// </param>
        /// 
        /// <returns>
        /// EmailVerifiedResponse
        /// </returns>
        public async Task<EmailVerifiedResponse> EmailVerifiedAsync(EmailVerifiedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EmailVerifiedWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键字进行模糊匹配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FuzzyMatchDomainSensitiveWordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FuzzyMatchDomainSensitiveWordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键字进行模糊匹配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FuzzyMatchDomainSensitiveWordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FuzzyMatchDomainSensitiveWordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键字进行模糊匹配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FuzzyMatchDomainSensitiveWordRequest
        /// </param>
        /// 
        /// <returns>
        /// FuzzyMatchDomainSensitiveWordResponse
        /// </returns>
        public FuzzyMatchDomainSensitiveWordResponse FuzzyMatchDomainSensitiveWord(FuzzyMatchDomainSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FuzzyMatchDomainSensitiveWordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过关键字进行模糊匹配</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FuzzyMatchDomainSensitiveWordRequest
        /// </param>
        /// 
        /// <returns>
        /// FuzzyMatchDomainSensitiveWordResponse
        /// </returns>
        public async Task<FuzzyMatchDomainSensitiveWordResponse> FuzzyMatchDomainSensitiveWordAsync(FuzzyMatchDomainSensitiveWordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FuzzyMatchDomainSensitiveWordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询国际一口价在售域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntlFixPriceDomainListUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIntlFixPriceDomainListUrlResponse
        /// </returns>
        public GetIntlFixPriceDomainListUrlResponse GetIntlFixPriceDomainListUrlWithOptions(GetIntlFixPriceDomainListUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListDate))
            {
                query["ListDate"] = request.ListDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntlFixPriceDomainListUrl",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntlFixPriceDomainListUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询国际一口价在售域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntlFixPriceDomainListUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIntlFixPriceDomainListUrlResponse
        /// </returns>
        public async Task<GetIntlFixPriceDomainListUrlResponse> GetIntlFixPriceDomainListUrlWithOptionsAsync(GetIntlFixPriceDomainListUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListDate))
            {
                query["ListDate"] = request.ListDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntlFixPriceDomainListUrl",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntlFixPriceDomainListUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询国际一口价在售域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntlFixPriceDomainListUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIntlFixPriceDomainListUrlResponse
        /// </returns>
        public GetIntlFixPriceDomainListUrlResponse GetIntlFixPriceDomainListUrl(GetIntlFixPriceDomainListUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIntlFixPriceDomainListUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询国际一口价在售域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIntlFixPriceDomainListUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIntlFixPriceDomainListUrlResponse
        /// </returns>
        public async Task<GetIntlFixPriceDomainListUrlResponse> GetIntlFixPriceDomainListUrlAsync(GetIntlFixPriceDomainListUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIntlFixPriceDomainListUrlWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetOperationOssUploadPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOperationOssUploadPolicyResponse
        /// </returns>
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

        /// <param name="request">
        /// GetOperationOssUploadPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetOperationOssUploadPolicyResponse
        /// </returns>
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

        /// <param name="request">
        /// GetOperationOssUploadPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOperationOssUploadPolicyResponse
        /// </returns>
        public GetOperationOssUploadPolicyResponse GetOperationOssUploadPolicy(GetOperationOssUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOperationOssUploadPolicyWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetOperationOssUploadPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetOperationOssUploadPolicyResponse
        /// </returns>
        public async Task<GetOperationOssUploadPolicyResponse> GetOperationOssUploadPolicyAsync(GetOperationOssUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOperationOssUploadPolicyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetQualificationUploadPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualificationUploadPolicyResponse
        /// </returns>
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

        /// <param name="request">
        /// GetQualificationUploadPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQualificationUploadPolicyResponse
        /// </returns>
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

        /// <param name="request">
        /// GetQualificationUploadPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualificationUploadPolicyResponse
        /// </returns>
        public GetQualificationUploadPolicyResponse GetQualificationUploadPolicy(GetQualificationUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualificationUploadPolicyWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetQualificationUploadPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQualificationUploadPolicyResponse
        /// </returns>
        public async Task<GetQualificationUploadPolicyResponse> GetQualificationUploadPolicyAsync(GetQualificationUploadPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualificationUploadPolicyWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ListEmailVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEmailVerificationResponse
        /// </returns>
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

        /// <param name="request">
        /// ListEmailVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEmailVerificationResponse
        /// </returns>
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

        /// <param name="request">
        /// ListEmailVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEmailVerificationResponse
        /// </returns>
        public ListEmailVerificationResponse ListEmailVerification(ListEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEmailVerificationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ListEmailVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEmailVerificationResponse
        /// </returns>
        public async Task<ListEmailVerificationResponse> ListEmailVerificationAsync(ListEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEmailVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about domain names for which registry locks are enabled.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServerLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServerLockResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about domain names for which registry locks are enabled.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServerLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServerLockResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about domain names for which registry locks are enabled.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServerLockRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServerLockResponse
        /// </returns>
        public ListServerLockResponse ListServerLock(ListServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServerLockWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about domain names for which registry locks are enabled.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServerLockRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServerLockResponse
        /// </returns>
        public async Task<ListServerLockResponse> ListServerLockAsync(ListServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServerLockWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// LookupTmchNoticeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LookupTmchNoticeResponse
        /// </returns>
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

        /// <param name="request">
        /// LookupTmchNoticeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LookupTmchNoticeResponse
        /// </returns>
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

        /// <param name="request">
        /// LookupTmchNoticeRequest
        /// </param>
        /// 
        /// <returns>
        /// LookupTmchNoticeResponse
        /// </returns>
        public LookupTmchNoticeResponse LookupTmchNotice(LookupTmchNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LookupTmchNoticeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// LookupTmchNoticeRequest
        /// </param>
        /// 
        /// <returns>
        /// LookupTmchNoticeResponse
        /// </returns>
        public async Task<LookupTmchNoticeResponse> LookupTmchNoticeAsync(LookupTmchNoticeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LookupTmchNoticeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// PollTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PollTaskResultResponse
        /// </returns>
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

        /// <param name="request">
        /// PollTaskResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PollTaskResultResponse
        /// </returns>
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

        /// <param name="request">
        /// PollTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// PollTaskResultResponse
        /// </returns>
        public PollTaskResultResponse PollTaskResult(PollTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PollTaskResultWithOptions(request, runtime);
        }

        /// <param name="request">
        /// PollTaskResultRequest
        /// </param>
        /// 
        /// <returns>
        /// PollTaskResultResponse
        /// </returns>
        public async Task<PollTaskResultResponse> PollTaskResultAsync(PollTaskResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PollTaskResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAdvancedDomainListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAdvancedDomainListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAdvancedDomainListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAdvancedDomainListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAdvancedDomainListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAdvancedDomainListResponse
        /// </returns>
        public QueryAdvancedDomainListResponse QueryAdvancedDomainList(QueryAdvancedDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAdvancedDomainListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>搜索域名列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAdvancedDomainListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAdvancedDomainListResponse
        /// </returns>
        public async Task<QueryAdvancedDomainListResponse> QueryAdvancedDomainListAsync(QueryAdvancedDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAdvancedDomainListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryArtExtensionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryArtExtensionResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryArtExtensionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryArtExtensionResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryArtExtensionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryArtExtensionResponse
        /// </returns>
        public QueryArtExtensionResponse QueryArtExtension(QueryArtExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryArtExtensionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryArtExtensionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryArtExtensionResponse
        /// </returns>
        public async Task<QueryArtExtensionResponse> QueryArtExtensionAsync(QueryArtExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryArtExtensionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询操作记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChangeLogListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChangeLogListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询操作记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChangeLogListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryChangeLogListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询操作记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChangeLogListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChangeLogListResponse
        /// </returns>
        public QueryChangeLogListResponse QueryChangeLogList(QueryChangeLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryChangeLogListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询操作记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryChangeLogListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryChangeLogListResponse
        /// </returns>
        public async Task<QueryChangeLogListResponse> QueryChangeLogListAsync(QueryChangeLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryChangeLogListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryContactInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContactInfoResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryContactInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContactInfoResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryContactInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContactInfoResponse
        /// </returns>
        public QueryContactInfoResponse QueryContactInfo(QueryContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryContactInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryContactInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContactInfoResponse
        /// </returns>
        public async Task<QueryContactInfoResponse> QueryContactInfoAsync(QueryContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryContactInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryDSRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDSRecordResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryDSRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDSRecordResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryDSRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDSRecordResponse
        /// </returns>
        public QueryDSRecordResponse QueryDSRecord(QueryDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDSRecordWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryDSRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDSRecordResponse
        /// </returns>
        public async Task<QueryDSRecordResponse> QueryDSRecordAsync(QueryDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDSRecordWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryDnsHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDnsHostResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryDnsHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDnsHostResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryDnsHostRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDnsHostResponse
        /// </returns>
        public QueryDnsHostResponse QueryDnsHost(QueryDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDnsHostWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryDnsHostRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDnsHostResponse
        /// </returns>
        public async Task<QueryDnsHostResponse> QueryDnsHostAsync(QueryDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDnsHostWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryDomainAdminDivisionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainAdminDivisionResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryDomainAdminDivisionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainAdminDivisionResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryDomainAdminDivisionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainAdminDivisionResponse
        /// </returns>
        public QueryDomainAdminDivisionResponse QueryDomainAdminDivision(QueryDomainAdminDivisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainAdminDivisionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryDomainAdminDivisionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainAdminDivisionResponse
        /// </returns>
        public async Task<QueryDomainAdminDivisionResponse> QueryDomainAdminDivisionAsync(QueryDomainAdminDivisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainAdminDivisionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainByDomainNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainByDomainNameResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainByDomainNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainByDomainNameResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainByDomainNameRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainByDomainNameResponse
        /// </returns>
        public QueryDomainByDomainNameResponse QueryDomainByDomainName(QueryDomainByDomainNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainByDomainNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a domain name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainByDomainNameRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainByDomainNameResponse
        /// </returns>
        public async Task<QueryDomainByDomainNameResponse> QueryDomainByDomainNameAsync(QueryDomainByDomainNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainByDomainNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据实例id查询域名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainByInstanceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainByInstanceIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据实例id查询域名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainByInstanceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainByInstanceIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据实例id查询域名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainByInstanceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainByInstanceIdResponse
        /// </returns>
        public QueryDomainByInstanceIdResponse QueryDomainByInstanceId(QueryDomainByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainByInstanceIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据实例id查询域名信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainByInstanceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainByInstanceIdResponse
        /// </returns>
        public async Task<QueryDomainByInstanceIdResponse> QueryDomainByInstanceIdAsync(QueryDomainByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainByInstanceIdWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryDomainGroupListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainGroupListResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryDomainGroupListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainGroupListResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryDomainGroupListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainGroupListResponse
        /// </returns>
        public QueryDomainGroupListResponse QueryDomainGroupList(QueryDomainGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainGroupListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryDomainGroupListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainGroupListResponse
        /// </returns>
        public async Task<QueryDomainGroupListResponse> QueryDomainGroupListAsync(QueryDomainGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainGroupListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of domain names within your Alibaba Cloud account by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainListResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Registrar))
            {
                query["Registrar"] = request.Registrar;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of domain names within your Alibaba Cloud account by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainListResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Registrar))
            {
                query["Registrar"] = request.Registrar;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of domain names within your Alibaba Cloud account by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainListResponse
        /// </returns>
        public QueryDomainListResponse QueryDomainList(QueryDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of domain names within your Alibaba Cloud account by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainListResponse
        /// </returns>
        public async Task<QueryDomainListResponse> QueryDomainListAsync(QueryDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryDomainRealNameVerificationInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainRealNameVerificationInfoResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryDomainRealNameVerificationInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainRealNameVerificationInfoResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryDomainRealNameVerificationInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainRealNameVerificationInfoResponse
        /// </returns>
        public QueryDomainRealNameVerificationInfoResponse QueryDomainRealNameVerificationInfo(QueryDomainRealNameVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainRealNameVerificationInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryDomainRealNameVerificationInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainRealNameVerificationInfoResponse
        /// </returns>
        public async Task<QueryDomainRealNameVerificationInfoResponse> QueryDomainRealNameVerificationInfoAsync(QueryDomainRealNameVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainRealNameVerificationInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询域名价格</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryDomainRealTimePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainRealTimePriceResponse
        /// </returns>
        public QueryDomainRealTimePriceResponse QueryDomainRealTimePriceWithOptions(QueryDomainRealTimePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryDomainRealTimePriceShrinkRequest request = new QueryDomainRealTimePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DomainItem))
            {
                request.DomainItemShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DomainItem, "DomainItem", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                query["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainItemShrink))
            {
                query["DomainItem"] = request.DomainItemShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainRealTimePrice",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainRealTimePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询域名价格</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryDomainRealTimePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainRealTimePriceResponse
        /// </returns>
        public async Task<QueryDomainRealTimePriceResponse> QueryDomainRealTimePriceWithOptionsAsync(QueryDomainRealTimePriceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryDomainRealTimePriceShrinkRequest request = new QueryDomainRealTimePriceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DomainItem))
            {
                request.DomainItemShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DomainItem, "DomainItem", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                query["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainItemShrink))
            {
                query["DomainItem"] = request.DomainItemShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainRealTimePrice",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainRealTimePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询域名价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainRealTimePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainRealTimePriceResponse
        /// </returns>
        public QueryDomainRealTimePriceResponse QueryDomainRealTimePrice(QueryDomainRealTimePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainRealTimePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时查询域名价格</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainRealTimePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainRealTimePriceResponse
        /// </returns>
        public async Task<QueryDomainRealTimePriceResponse> QueryDomainRealTimePriceAsync(QueryDomainRealTimePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainRealTimePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名特殊业务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainSpecialBizDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainSpecialBizDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名特殊业务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainSpecialBizDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainSpecialBizDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名特殊业务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainSpecialBizDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainSpecialBizDetailResponse
        /// </returns>
        public QueryDomainSpecialBizDetailResponse QueryDomainSpecialBizDetail(QueryDomainSpecialBizDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainSpecialBizDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询域名特殊业务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainSpecialBizDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainSpecialBizDetailResponse
        /// </returns>
        public async Task<QueryDomainSpecialBizDetailResponse> QueryDomainSpecialBizDetailAsync(QueryDomainSpecialBizDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainSpecialBizDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过域名查询域名特殊业务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainSpecialBizInfoByDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainSpecialBizInfoByDomainResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过域名查询域名特殊业务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainSpecialBizInfoByDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainSpecialBizInfoByDomainResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过域名查询域名特殊业务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainSpecialBizInfoByDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainSpecialBizInfoByDomainResponse
        /// </returns>
        public QueryDomainSpecialBizInfoByDomainResponse QueryDomainSpecialBizInfoByDomain(QueryDomainSpecialBizInfoByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainSpecialBizInfoByDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过域名查询域名特殊业务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryDomainSpecialBizInfoByDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainSpecialBizInfoByDomainResponse
        /// </returns>
        public async Task<QueryDomainSpecialBizInfoByDomainResponse> QueryDomainSpecialBizInfoByDomainAsync(QueryDomainSpecialBizInfoByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainSpecialBizInfoByDomainWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryDomainSuffixRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainSuffixResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryDomainSuffixRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainSuffixResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryDomainSuffixRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainSuffixResponse
        /// </returns>
        public QueryDomainSuffixResponse QueryDomainSuffix(QueryDomainSuffixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainSuffixWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryDomainSuffixRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainSuffixResponse
        /// </returns>
        public async Task<QueryDomainSuffixResponse> QueryDomainSuffixAsync(QueryDomainSuffixRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainSuffixWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询邮箱验证状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEmailVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEmailVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询邮箱验证状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEmailVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEmailVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询邮箱验证状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEmailVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEmailVerificationResponse
        /// </returns>
        public QueryEmailVerificationResponse QueryEmailVerification(QueryEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEmailVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询邮箱验证状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryEmailVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEmailVerificationResponse
        /// </returns>
        public async Task<QueryEmailVerificationResponse> QueryEmailVerificationAsync(QueryEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEmailVerificationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryEnsAssociationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnsAssociationResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryEnsAssociationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryEnsAssociationResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryEnsAssociationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEnsAssociationResponse
        /// </returns>
        public QueryEnsAssociationResponse QueryEnsAssociation(QueryEnsAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEnsAssociationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryEnsAssociationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryEnsAssociationResponse
        /// </returns>
        public async Task<QueryEnsAssociationResponse> QueryEnsAssociationAsync(QueryEnsAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEnsAssociationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryFailReasonForDomainRealNameVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFailReasonForDomainRealNameVerificationResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryFailReasonForDomainRealNameVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFailReasonForDomainRealNameVerificationResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryFailReasonForDomainRealNameVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFailReasonForDomainRealNameVerificationResponse
        /// </returns>
        public QueryFailReasonForDomainRealNameVerificationResponse QueryFailReasonForDomainRealNameVerification(QueryFailReasonForDomainRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFailReasonForDomainRealNameVerificationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryFailReasonForDomainRealNameVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFailReasonForDomainRealNameVerificationResponse
        /// </returns>
        public async Task<QueryFailReasonForDomainRealNameVerificationResponse> QueryFailReasonForDomainRealNameVerificationAsync(QueryFailReasonForDomainRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFailReasonForDomainRealNameVerificationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryFailReasonForRegistrantProfileRealNameVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFailReasonForRegistrantProfileRealNameVerificationResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryFailReasonForRegistrantProfileRealNameVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFailReasonForRegistrantProfileRealNameVerificationResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryFailReasonForRegistrantProfileRealNameVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFailReasonForRegistrantProfileRealNameVerificationResponse
        /// </returns>
        public QueryFailReasonForRegistrantProfileRealNameVerificationResponse QueryFailReasonForRegistrantProfileRealNameVerification(QueryFailReasonForRegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFailReasonForRegistrantProfileRealNameVerificationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryFailReasonForRegistrantProfileRealNameVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFailReasonForRegistrantProfileRealNameVerificationResponse
        /// </returns>
        public async Task<QueryFailReasonForRegistrantProfileRealNameVerificationResponse> QueryFailReasonForRegistrantProfileRealNameVerificationAsync(QueryFailReasonForRegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFailReasonForRegistrantProfileRealNameVerificationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryFailingReasonListForQualificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFailingReasonListForQualificationResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryFailingReasonListForQualificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryFailingReasonListForQualificationResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryFailingReasonListForQualificationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFailingReasonListForQualificationResponse
        /// </returns>
        public QueryFailingReasonListForQualificationResponse QueryFailingReasonListForQualification(QueryFailingReasonListForQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryFailingReasonListForQualificationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryFailingReasonListForQualificationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryFailingReasonListForQualificationResponse
        /// </returns>
        public async Task<QueryFailingReasonListForQualificationResponse> QueryFailingReasonListForQualificationAsync(QueryFailingReasonListForQualificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryFailingReasonListForQualificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询国际一口价订单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryIntlFixedPriceOrderListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIntlFixedPriceOrderListResponse
        /// </returns>
        public QueryIntlFixedPriceOrderListResponse QueryIntlFixedPriceOrderListWithOptions(QueryIntlFixedPriceOrderListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIntlFixedPriceOrderList",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIntlFixedPriceOrderListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询国际一口价订单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryIntlFixedPriceOrderListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryIntlFixedPriceOrderListResponse
        /// </returns>
        public async Task<QueryIntlFixedPriceOrderListResponse> QueryIntlFixedPriceOrderListWithOptionsAsync(QueryIntlFixedPriceOrderListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryIntlFixedPriceOrderList",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryIntlFixedPriceOrderListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询国际一口价订单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryIntlFixedPriceOrderListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryIntlFixedPriceOrderListResponse
        /// </returns>
        public QueryIntlFixedPriceOrderListResponse QueryIntlFixedPriceOrderList(QueryIntlFixedPriceOrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryIntlFixedPriceOrderListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询国际一口价订单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryIntlFixedPriceOrderListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryIntlFixedPriceOrderListResponse
        /// </returns>
        public async Task<QueryIntlFixedPriceOrderListResponse> QueryIntlFixedPriceOrderListAsync(QueryIntlFixedPriceOrderListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryIntlFixedPriceOrderListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryLocalEnsAssociationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLocalEnsAssociationResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryLocalEnsAssociationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryLocalEnsAssociationResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryLocalEnsAssociationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLocalEnsAssociationResponse
        /// </returns>
        public QueryLocalEnsAssociationResponse QueryLocalEnsAssociation(QueryLocalEnsAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLocalEnsAssociationWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryLocalEnsAssociationRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryLocalEnsAssociationResponse
        /// </returns>
        public async Task<QueryLocalEnsAssociationResponse> QueryLocalEnsAssociationAsync(QueryLocalEnsAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLocalEnsAssociationWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryOperationAuditInfoDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOperationAuditInfoDetailResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryOperationAuditInfoDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOperationAuditInfoDetailResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryOperationAuditInfoDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOperationAuditInfoDetailResponse
        /// </returns>
        public QueryOperationAuditInfoDetailResponse QueryOperationAuditInfoDetail(QueryOperationAuditInfoDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOperationAuditInfoDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryOperationAuditInfoDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOperationAuditInfoDetailResponse
        /// </returns>
        public async Task<QueryOperationAuditInfoDetailResponse> QueryOperationAuditInfoDetailAsync(QueryOperationAuditInfoDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOperationAuditInfoDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryOperationAuditInfoListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOperationAuditInfoListResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryOperationAuditInfoListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOperationAuditInfoListResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryOperationAuditInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOperationAuditInfoListResponse
        /// </returns>
        public QueryOperationAuditInfoListResponse QueryOperationAuditInfoList(QueryOperationAuditInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOperationAuditInfoListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryOperationAuditInfoListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOperationAuditInfoListResponse
        /// </returns>
        public async Task<QueryOperationAuditInfoListResponse> QueryOperationAuditInfoListAsync(QueryOperationAuditInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOperationAuditInfoListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryQualificationDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryQualificationDetailResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryQualificationDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryQualificationDetailResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryQualificationDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryQualificationDetailResponse
        /// </returns>
        public QueryQualificationDetailResponse QueryQualificationDetail(QueryQualificationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryQualificationDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryQualificationDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryQualificationDetailResponse
        /// </returns>
        public async Task<QueryQualificationDetailResponse> QueryQualificationDetailAsync(QueryQualificationDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryQualificationDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryRegistrantProfileRealNameVerificationInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRegistrantProfileRealNameVerificationInfoResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryRegistrantProfileRealNameVerificationInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRegistrantProfileRealNameVerificationInfoResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryRegistrantProfileRealNameVerificationInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRegistrantProfileRealNameVerificationInfoResponse
        /// </returns>
        public QueryRegistrantProfileRealNameVerificationInfoResponse QueryRegistrantProfileRealNameVerificationInfo(QueryRegistrantProfileRealNameVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRegistrantProfileRealNameVerificationInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryRegistrantProfileRealNameVerificationInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRegistrantProfileRealNameVerificationInfoResponse
        /// </returns>
        public async Task<QueryRegistrantProfileRealNameVerificationInfoResponse> QueryRegistrantProfileRealNameVerificationInfoAsync(QueryRegistrantProfileRealNameVerificationInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRegistrantProfileRealNameVerificationInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the registrant profiles that belong to your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use optional request parameters to specify specific query criteria to query registrant profiles as required. For example:</para>
        /// <list type="bullet">
        /// <item><description>If you know the ID of the profile that you want to query, you can use the registrant profile ID parameter to query the detailed information about the profile.</description></item>
        /// <item><description>If you do not know the ID of the profile that you want to query, you can use parameters such as the registrant name parameter to query the detailed information about the profile.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRegistrantProfilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRegistrantProfilesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the registrant profiles that belong to your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use optional request parameters to specify specific query criteria to query registrant profiles as required. For example:</para>
        /// <list type="bullet">
        /// <item><description>If you know the ID of the profile that you want to query, you can use the registrant profile ID parameter to query the detailed information about the profile.</description></item>
        /// <item><description>If you do not know the ID of the profile that you want to query, you can use parameters such as the registrant name parameter to query the detailed information about the profile.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRegistrantProfilesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRegistrantProfilesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the registrant profiles that belong to your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use optional request parameters to specify specific query criteria to query registrant profiles as required. For example:</para>
        /// <list type="bullet">
        /// <item><description>If you know the ID of the profile that you want to query, you can use the registrant profile ID parameter to query the detailed information about the profile.</description></item>
        /// <item><description>If you do not know the ID of the profile that you want to query, you can use parameters such as the registrant name parameter to query the detailed information about the profile.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRegistrantProfilesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRegistrantProfilesResponse
        /// </returns>
        public QueryRegistrantProfilesResponse QueryRegistrantProfiles(QueryRegistrantProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRegistrantProfilesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the registrant profiles that belong to your Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can use optional request parameters to specify specific query criteria to query registrant profiles as required. For example:</para>
        /// <list type="bullet">
        /// <item><description>If you know the ID of the profile that you want to query, you can use the registrant profile ID parameter to query the detailed information about the profile.</description></item>
        /// <item><description>If you do not know the ID of the profile that you want to query, you can use parameters such as the registrant name parameter to query the detailed information about the profile.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryRegistrantProfilesRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRegistrantProfilesResponse
        /// </returns>
        public async Task<QueryRegistrantProfilesResponse> QueryRegistrantProfilesAsync(QueryRegistrantProfilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRegistrantProfilesWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryServerLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryServerLockResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryServerLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryServerLockResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryServerLockRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryServerLockResponse
        /// </returns>
        public QueryServerLockResponse QueryServerLock(QueryServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryServerLockWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryServerLockRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryServerLockResponse
        /// </returns>
        public async Task<QueryServerLockResponse> QueryServerLockAsync(QueryServerLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryServerLockWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryTaskDetailHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskDetailHistoryResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryTaskDetailHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskDetailHistoryResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryTaskDetailHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskDetailHistoryResponse
        /// </returns>
        public QueryTaskDetailHistoryResponse QueryTaskDetailHistory(QueryTaskDetailHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskDetailHistoryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryTaskDetailHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskDetailHistoryResponse
        /// </returns>
        public async Task<QueryTaskDetailHistoryResponse> QueryTaskDetailHistoryAsync(QueryTaskDetailHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskDetailHistoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specific domain name task by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskDetailListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskDetailListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specific domain name task by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskDetailListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskDetailListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specific domain name task by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskDetailListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskDetailListResponse
        /// </returns>
        public QueryTaskDetailListResponse QueryTaskDetailList(QueryTaskDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskDetailListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a specific domain name task by page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskDetailListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskDetailListResponse
        /// </returns>
        public async Task<QueryTaskDetailListResponse> QueryTaskDetailListAsync(QueryTaskDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskDetailListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryTaskInfoHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskInfoHistoryResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryTaskInfoHistoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskInfoHistoryResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryTaskInfoHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskInfoHistoryResponse
        /// </returns>
        public QueryTaskInfoHistoryResponse QueryTaskInfoHistory(QueryTaskInfoHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskInfoHistoryWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryTaskInfoHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskInfoHistoryResponse
        /// </returns>
        public async Task<QueryTaskInfoHistoryResponse> QueryTaskInfoHistoryAsync(QueryTaskInfoHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskInfoHistoryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskListResponse
        /// </returns>
        public QueryTaskListResponse QueryTaskList(QueryTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTaskListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTaskListResponse
        /// </returns>
        public async Task<QueryTaskListResponse> QueryTaskListAsync(QueryTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryTransferInByInstanceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTransferInByInstanceIdResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryTransferInByInstanceIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTransferInByInstanceIdResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryTransferInByInstanceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTransferInByInstanceIdResponse
        /// </returns>
        public QueryTransferInByInstanceIdResponse QueryTransferInByInstanceId(QueryTransferInByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTransferInByInstanceIdWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryTransferInByInstanceIdRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTransferInByInstanceIdResponse
        /// </returns>
        public async Task<QueryTransferInByInstanceIdResponse> QueryTransferInByInstanceIdAsync(QueryTransferInByInstanceIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTransferInByInstanceIdWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryTransferInListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTransferInListResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryTransferInListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTransferInListResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryTransferInListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTransferInListResponse
        /// </returns>
        public QueryTransferInListResponse QueryTransferInList(QueryTransferInListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTransferInListWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryTransferInListRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTransferInListResponse
        /// </returns>
        public async Task<QueryTransferInListResponse> QueryTransferInListAsync(QueryTransferInListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTransferInListWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryTransferOutInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTransferOutInfoResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryTransferOutInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTransferOutInfoResponse
        /// </returns>
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

        /// <param name="request">
        /// QueryTransferOutInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTransferOutInfoResponse
        /// </returns>
        public QueryTransferOutInfoResponse QueryTransferOutInfo(QueryTransferOutInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTransferOutInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryTransferOutInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTransferOutInfoResponse
        /// </returns>
        public async Task<QueryTransferOutInfoResponse> QueryTransferOutInfoAsync(QueryTransferOutInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTransferOutInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板实名资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegistrantProfileRealNameVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegistrantProfileRealNameVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板实名资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegistrantProfileRealNameVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegistrantProfileRealNameVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板实名资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegistrantProfileRealNameVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// RegistrantProfileRealNameVerificationResponse
        /// </returns>
        public RegistrantProfileRealNameVerificationResponse RegistrantProfileRealNameVerification(RegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegistrantProfileRealNameVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板实名资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegistrantProfileRealNameVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// RegistrantProfileRealNameVerificationResponse
        /// </returns>
        public async Task<RegistrantProfileRealNameVerificationResponse> RegistrantProfileRealNameVerificationAsync(RegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegistrantProfileRealNameVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新发送验证邮件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResendEmailVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResendEmailVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新发送验证邮件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResendEmailVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResendEmailVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新发送验证邮件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResendEmailVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ResendEmailVerificationResponse
        /// </returns>
        public ResendEmailVerificationResponse ResendEmailVerification(ResendEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResendEmailVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新发送验证邮件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResendEmailVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ResendEmailVerificationResponse
        /// </returns>
        public async Task<ResendEmailVerificationResponse> ResendEmailVerificationAsync(ResendEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResendEmailVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置资质审核状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetQualificationVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetQualificationVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置资质审核状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetQualificationVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetQualificationVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置资质审核状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetQualificationVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetQualificationVerificationResponse
        /// </returns>
        public ResetQualificationVerificationResponse ResetQualificationVerification(ResetQualificationVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetQualificationVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重置资质审核状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResetQualificationVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetQualificationVerificationResponse
        /// </returns>
        public async Task<ResetQualificationVerificationResponse> ResetQualificationVerificationAsync(ResetQualificationVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetQualificationVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量保存域名备注信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchDomainRemarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchDomainRemarkResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量保存域名备注信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchDomainRemarkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchDomainRemarkResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量保存域名备注信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchDomainRemarkRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchDomainRemarkResponse
        /// </returns>
        public SaveBatchDomainRemarkResponse SaveBatchDomainRemark(SaveBatchDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchDomainRemarkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量保存域名备注信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchDomainRemarkRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchDomainRemarkResponse
        /// </returns>
        public async Task<SaveBatchDomainRemarkResponse> SaveBatchDomainRemarkAsync(SaveBatchDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchDomainRemarkWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量申请域名快速转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForApplyQuickTransferOutOpenlyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForApplyQuickTransferOutOpenlyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量申请域名快速转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForApplyQuickTransferOutOpenlyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForApplyQuickTransferOutOpenlyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量申请域名快速转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForApplyQuickTransferOutOpenlyRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForApplyQuickTransferOutOpenlyResponse
        /// </returns>
        public SaveBatchTaskForApplyQuickTransferOutOpenlyResponse SaveBatchTaskForApplyQuickTransferOutOpenly(SaveBatchTaskForApplyQuickTransferOutOpenlyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForApplyQuickTransferOutOpenlyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量申请域名快速转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForApplyQuickTransferOutOpenlyRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForApplyQuickTransferOutOpenlyResponse
        /// </returns>
        public async Task<SaveBatchTaskForApplyQuickTransferOutOpenlyResponse> SaveBatchTaskForApplyQuickTransferOutOpenlyAsync(SaveBatchTaskForApplyQuickTransferOutOpenlyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForApplyQuickTransferOutOpenlyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-注册订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderActivateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderActivateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-注册订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderActivateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderActivateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-注册订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderActivateRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderActivateResponse
        /// </returns>
        public SaveBatchTaskForCreatingOrderActivateResponse SaveBatchTaskForCreatingOrderActivate(SaveBatchTaskForCreatingOrderActivateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForCreatingOrderActivateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-注册订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderActivateRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderActivateResponse
        /// </returns>
        public async Task<SaveBatchTaskForCreatingOrderActivateResponse> SaveBatchTaskForCreatingOrderActivateAsync(SaveBatchTaskForCreatingOrderActivateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForCreatingOrderActivateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderRedeemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderRedeemResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderRedeemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderRedeemResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderRedeemRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderRedeemResponse
        /// </returns>
        public SaveBatchTaskForCreatingOrderRedeemResponse SaveBatchTaskForCreatingOrderRedeem(SaveBatchTaskForCreatingOrderRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForCreatingOrderRedeemWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderRedeemRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderRedeemResponse
        /// </returns>
        public async Task<SaveBatchTaskForCreatingOrderRedeemResponse> SaveBatchTaskForCreatingOrderRedeemAsync(SaveBatchTaskForCreatingOrderRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForCreatingOrderRedeemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-续费订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderRenewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderRenewResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-续费订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderRenewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderRenewResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-续费订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderRenewRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderRenewResponse
        /// </returns>
        public SaveBatchTaskForCreatingOrderRenewResponse SaveBatchTaskForCreatingOrderRenew(SaveBatchTaskForCreatingOrderRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForCreatingOrderRenewWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-续费订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderRenewRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderRenewResponse
        /// </returns>
        public async Task<SaveBatchTaskForCreatingOrderRenewResponse> SaveBatchTaskForCreatingOrderRenewAsync(SaveBatchTaskForCreatingOrderRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForCreatingOrderRenewWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderTransferRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderTransferResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderTransferRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderTransferResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderTransferRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderTransferResponse
        /// </returns>
        public SaveBatchTaskForCreatingOrderTransferResponse SaveBatchTaskForCreatingOrderTransfer(SaveBatchTaskForCreatingOrderTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForCreatingOrderTransferWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveBatchTaskForCreatingOrderTransferRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForCreatingOrderTransferResponse
        /// </returns>
        public async Task<SaveBatchTaskForCreatingOrderTransferResponse> SaveBatchTaskForCreatingOrderTransferAsync(SaveBatchTaskForCreatingOrderTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForCreatingOrderTransferWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-开启/关闭whois隐私保护锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForDomainNameProxyServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForDomainNameProxyServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-开启/关闭whois隐私保护锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForDomainNameProxyServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForDomainNameProxyServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-开启/关闭whois隐私保护锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForDomainNameProxyServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForDomainNameProxyServiceResponse
        /// </returns>
        public SaveBatchTaskForDomainNameProxyServiceResponse SaveBatchTaskForDomainNameProxyService(SaveBatchTaskForDomainNameProxyServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForDomainNameProxyServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-开启/关闭whois隐私保护锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForDomainNameProxyServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForDomainNameProxyServiceResponse
        /// </returns>
        public async Task<SaveBatchTaskForDomainNameProxyServiceResponse> SaveBatchTaskForDomainNameProxyServiceAsync(SaveBatchTaskForDomainNameProxyServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForDomainNameProxyServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交批量生成证书的任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveBatchTaskForGenerateDomainCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForGenerateDomainCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交批量生成证书的任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SaveBatchTaskForGenerateDomainCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForGenerateDomainCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交批量生成证书的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForGenerateDomainCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForGenerateDomainCertificateResponse
        /// </returns>
        public SaveBatchTaskForGenerateDomainCertificateResponse SaveBatchTaskForGenerateDomainCertificate(SaveBatchTaskForGenerateDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForGenerateDomainCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交批量生成证书的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForGenerateDomainCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForGenerateDomainCertificateResponse
        /// </returns>
        public async Task<SaveBatchTaskForGenerateDomainCertificateResponse> SaveBatchTaskForGenerateDomainCertificateAsync(SaveBatchTaskForGenerateDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForGenerateDomainCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改dns</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForModifyingDomainDnsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForModifyingDomainDnsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改dns</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForModifyingDomainDnsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForModifyingDomainDnsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改dns</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForModifyingDomainDnsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForModifyingDomainDnsResponse
        /// </returns>
        public SaveBatchTaskForModifyingDomainDnsResponse SaveBatchTaskForModifyingDomainDns(SaveBatchTaskForModifyingDomainDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForModifyingDomainDnsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改dns</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForModifyingDomainDnsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForModifyingDomainDnsResponse
        /// </returns>
        public async Task<SaveBatchTaskForModifyingDomainDnsResponse> SaveBatchTaskForModifyingDomainDnsAsync(SaveBatchTaskForModifyingDomainDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForModifyingDomainDnsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交批量预定删除抢注域名任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForReserveDropListDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForReserveDropListDomainResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交批量预定删除抢注域名任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForReserveDropListDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForReserveDropListDomainResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交批量预定删除抢注域名任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForReserveDropListDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForReserveDropListDomainResponse
        /// </returns>
        public SaveBatchTaskForReserveDropListDomainResponse SaveBatchTaskForReserveDropListDomain(SaveBatchTaskForReserveDropListDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForReserveDropListDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交批量预定删除抢注域名任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForReserveDropListDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForReserveDropListDomainResponse
        /// </returns>
        public async Task<SaveBatchTaskForReserveDropListDomainResponse> SaveBatchTaskForReserveDropListDomainAsync(SaveBatchTaskForReserveDropListDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForReserveDropListDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于转移码的批量转出任务提交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForTransferOutByAuthorizationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForTransferOutByAuthorizationCodeResponse
        /// </returns>
        public SaveBatchTaskForTransferOutByAuthorizationCodeResponse SaveBatchTaskForTransferOutByAuthorizationCodeWithOptions(SaveBatchTaskForTransferOutByAuthorizationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferOutParamList))
            {
                query["TransferOutParamList"] = request.TransferOutParamList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForTransferOutByAuthorizationCode",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForTransferOutByAuthorizationCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于转移码的批量转出任务提交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForTransferOutByAuthorizationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForTransferOutByAuthorizationCodeResponse
        /// </returns>
        public async Task<SaveBatchTaskForTransferOutByAuthorizationCodeResponse> SaveBatchTaskForTransferOutByAuthorizationCodeWithOptionsAsync(SaveBatchTaskForTransferOutByAuthorizationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransferOutParamList))
            {
                query["TransferOutParamList"] = request.TransferOutParamList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveBatchTaskForTransferOutByAuthorizationCode",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBatchTaskForTransferOutByAuthorizationCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于转移码的批量转出任务提交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForTransferOutByAuthorizationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForTransferOutByAuthorizationCodeResponse
        /// </returns>
        public SaveBatchTaskForTransferOutByAuthorizationCodeResponse SaveBatchTaskForTransferOutByAuthorizationCode(SaveBatchTaskForTransferOutByAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForTransferOutByAuthorizationCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于转移码的批量转出任务提交</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForTransferOutByAuthorizationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForTransferOutByAuthorizationCodeResponse
        /// </returns>
        public async Task<SaveBatchTaskForTransferOutByAuthorizationCodeResponse> SaveBatchTaskForTransferOutByAuthorizationCodeAsync(SaveBatchTaskForTransferOutByAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForTransferOutByAuthorizationCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-开启/关闭禁止转移锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForTransferProhibitionLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForTransferProhibitionLockResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-开启/关闭禁止转移锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForTransferProhibitionLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForTransferProhibitionLockResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-开启/关闭禁止转移锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForTransferProhibitionLockRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForTransferProhibitionLockResponse
        /// </returns>
        public SaveBatchTaskForTransferProhibitionLockResponse SaveBatchTaskForTransferProhibitionLock(SaveBatchTaskForTransferProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForTransferProhibitionLockWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存批量任务-开启/关闭禁止转移锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForTransferProhibitionLockRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForTransferProhibitionLockResponse
        /// </returns>
        public async Task<SaveBatchTaskForTransferProhibitionLockResponse> SaveBatchTaskForTransferProhibitionLockAsync(SaveBatchTaskForTransferProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForTransferProhibitionLockWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveBatchTaskForUpdateProhibitionLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForUpdateProhibitionLockResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveBatchTaskForUpdateProhibitionLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForUpdateProhibitionLockResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveBatchTaskForUpdateProhibitionLockRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForUpdateProhibitionLockResponse
        /// </returns>
        public SaveBatchTaskForUpdateProhibitionLockResponse SaveBatchTaskForUpdateProhibitionLock(SaveBatchTaskForUpdateProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForUpdateProhibitionLockWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveBatchTaskForUpdateProhibitionLockRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForUpdateProhibitionLockResponse
        /// </returns>
        public async Task<SaveBatchTaskForUpdateProhibitionLockResponse> SaveBatchTaskForUpdateProhibitionLockAsync(SaveBatchTaskForUpdateProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForUpdateProhibitionLockWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>使用联系人信息修改联系人的批量任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForUpdatingContactInfoByNewContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForUpdatingContactInfoByNewContactResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>使用联系人信息修改联系人的批量任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForUpdatingContactInfoByNewContactRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForUpdatingContactInfoByNewContactResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>使用联系人信息修改联系人的批量任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForUpdatingContactInfoByNewContactRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForUpdatingContactInfoByNewContactResponse
        /// </returns>
        public SaveBatchTaskForUpdatingContactInfoByNewContactResponse SaveBatchTaskForUpdatingContactInfoByNewContact(SaveBatchTaskForUpdatingContactInfoByNewContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForUpdatingContactInfoByNewContactWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>使用联系人信息修改联系人的批量任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForUpdatingContactInfoByNewContactRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForUpdatingContactInfoByNewContactResponse
        /// </returns>
        public async Task<SaveBatchTaskForUpdatingContactInfoByNewContactResponse> SaveBatchTaskForUpdatingContactInfoByNewContactAsync(SaveBatchTaskForUpdatingContactInfoByNewContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForUpdatingContactInfoByNewContactWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>使用模板修改联系人的批量任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>使用模板修改联系人的批量任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>使用模板修改联系人的批量任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse
        /// </returns>
        public SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse SaveBatchTaskForUpdatingContactInfoByRegistrantProfileId(SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>使用模板修改联系人的批量任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse
        /// </returns>
        public async Task<SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdResponse> SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdAsync(SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveBatchTaskForUpdatingContactInfoByRegistrantProfileIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建/更新域名分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveDomainGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveDomainGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建/更新域名分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveDomainGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveDomainGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建/更新域名分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveDomainGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveDomainGroupResponse
        /// </returns>
        public SaveDomainGroupResponse SaveDomainGroup(SaveDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveDomainGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建/更新域名分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveDomainGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveDomainGroupResponse
        /// </returns>
        public async Task<SaveDomainGroupResponse> SaveDomainGroupAsync(SaveDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveDomainGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveRegistrantProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveRegistrantProfileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveRegistrantProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveRegistrantProfileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveRegistrantProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveRegistrantProfileResponse
        /// </returns>
        public SaveRegistrantProfileResponse SaveRegistrantProfile(SaveRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveRegistrantProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveRegistrantProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveRegistrantProfileResponse
        /// </returns>
        public async Task<SaveRegistrantProfileResponse> SaveRegistrantProfileAsync(SaveRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveRegistrantProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板和凭据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveRegistrantProfileRealNameVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveRegistrantProfileRealNameVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板和凭据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveRegistrantProfileRealNameVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveRegistrantProfileRealNameVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板和凭据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveRegistrantProfileRealNameVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveRegistrantProfileRealNameVerificationResponse
        /// </returns>
        public SaveRegistrantProfileRealNameVerificationResponse SaveRegistrantProfileRealNameVerification(SaveRegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveRegistrantProfileRealNameVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存联系人模板和凭据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveRegistrantProfileRealNameVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveRegistrantProfileRealNameVerificationResponse
        /// </returns>
        public async Task<SaveRegistrantProfileRealNameVerificationResponse> SaveRegistrantProfileRealNameVerificationAsync(SaveRegistrantProfileRealNameVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveRegistrantProfileRealNameVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加dnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForAddingDSRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForAddingDSRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加dnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForAddingDSRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForAddingDSRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加dnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForAddingDSRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForAddingDSRecordResponse
        /// </returns>
        public SaveSingleTaskForAddingDSRecordResponse SaveSingleTaskForAddingDSRecord(SaveSingleTaskForAddingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForAddingDSRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>添加dnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForAddingDSRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForAddingDSRecordResponse
        /// </returns>
        public async Task<SaveSingleTaskForAddingDSRecordResponse> SaveSingleTaskForAddingDSRecordAsync(SaveSingleTaskForAddingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForAddingDSRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请域名快速转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForApplyQuickTransferOutOpenlyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForApplyQuickTransferOutOpenlyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请域名快速转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForApplyQuickTransferOutOpenlyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForApplyQuickTransferOutOpenlyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请域名快速转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForApplyQuickTransferOutOpenlyRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForApplyQuickTransferOutOpenlyResponse
        /// </returns>
        public SaveSingleTaskForApplyQuickTransferOutOpenlyResponse SaveSingleTaskForApplyQuickTransferOutOpenly(SaveSingleTaskForApplyQuickTransferOutOpenlyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForApplyQuickTransferOutOpenlyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>申请域名快速转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForApplyQuickTransferOutOpenlyRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForApplyQuickTransferOutOpenlyResponse
        /// </returns>
        public async Task<SaveSingleTaskForApplyQuickTransferOutOpenlyResponse> SaveSingleTaskForApplyQuickTransferOutOpenlyAsync(SaveSingleTaskForApplyQuickTransferOutOpenlyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForApplyQuickTransferOutOpenlyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForApprovingTransferOutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForApprovingTransferOutResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForApprovingTransferOutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForApprovingTransferOutResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForApprovingTransferOutRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForApprovingTransferOutResponse
        /// </returns>
        public SaveSingleTaskForApprovingTransferOutResponse SaveSingleTaskForApprovingTransferOut(SaveSingleTaskForApprovingTransferOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForApprovingTransferOutWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>确认转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForApprovingTransferOutRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForApprovingTransferOutResponse
        /// </returns>
        public async Task<SaveSingleTaskForApprovingTransferOutResponse> SaveSingleTaskForApprovingTransferOutAsync(SaveSingleTaskForApprovingTransferOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForApprovingTransferOutWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveSingleTaskForAssociatingEnsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForAssociatingEnsResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveSingleTaskForAssociatingEnsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForAssociatingEnsResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveSingleTaskForAssociatingEnsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForAssociatingEnsResponse
        /// </returns>
        public SaveSingleTaskForAssociatingEnsResponse SaveSingleTaskForAssociatingEns(SaveSingleTaskForAssociatingEnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForAssociatingEnsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveSingleTaskForAssociatingEnsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForAssociatingEnsResponse
        /// </returns>
        public async Task<SaveSingleTaskForAssociatingEnsResponse> SaveSingleTaskForAssociatingEnsAsync(SaveSingleTaskForAssociatingEnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForAssociatingEnsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveSingleTaskForCancelingTransferInRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCancelingTransferInResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveSingleTaskForCancelingTransferInRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCancelingTransferInResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveSingleTaskForCancelingTransferInRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCancelingTransferInResponse
        /// </returns>
        public SaveSingleTaskForCancelingTransferInResponse SaveSingleTaskForCancelingTransferIn(SaveSingleTaskForCancelingTransferInRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCancelingTransferInWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveSingleTaskForCancelingTransferInRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCancelingTransferInResponse
        /// </returns>
        public async Task<SaveSingleTaskForCancelingTransferInResponse> SaveSingleTaskForCancelingTransferInAsync(SaveSingleTaskForCancelingTransferInRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCancelingTransferInWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCancelingTransferOutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCancelingTransferOutResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCancelingTransferOutRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCancelingTransferOutResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCancelingTransferOutRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCancelingTransferOutResponse
        /// </returns>
        public SaveSingleTaskForCancelingTransferOutResponse SaveSingleTaskForCancelingTransferOut(SaveSingleTaskForCancelingTransferOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCancelingTransferOutWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消转出</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCancelingTransferOutRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCancelingTransferOutResponse
        /// </returns>
        public async Task<SaveSingleTaskForCancelingTransferOutResponse> SaveSingleTaskForCancelingTransferOutAsync(SaveSingleTaskForCancelingTransferOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCancelingTransferOutWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存创建dns服务器的任务请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCreatingDnsHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingDnsHostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存创建dns服务器的任务请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCreatingDnsHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingDnsHostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存创建dns服务器的任务请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCreatingDnsHostRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingDnsHostResponse
        /// </returns>
        public SaveSingleTaskForCreatingDnsHostResponse SaveSingleTaskForCreatingDnsHost(SaveSingleTaskForCreatingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingDnsHostWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存创建dns服务器的任务请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCreatingDnsHostRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingDnsHostResponse
        /// </returns>
        public async Task<SaveSingleTaskForCreatingDnsHostResponse> SaveSingleTaskForCreatingDnsHostAsync(SaveSingleTaskForCreatingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingDnsHostWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-注册订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderActivateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderActivateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-注册订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderActivateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderActivateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-注册订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderActivateRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderActivateResponse
        /// </returns>
        public SaveSingleTaskForCreatingOrderActivateResponse SaveSingleTaskForCreatingOrderActivate(SaveSingleTaskForCreatingOrderActivateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingOrderActivateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-注册订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderActivateRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderActivateResponse
        /// </returns>
        public async Task<SaveSingleTaskForCreatingOrderActivateResponse> SaveSingleTaskForCreatingOrderActivateAsync(SaveSingleTaskForCreatingOrderActivateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingOrderActivateWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderRedeemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderRedeemResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderRedeemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderRedeemResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderRedeemRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderRedeemResponse
        /// </returns>
        public SaveSingleTaskForCreatingOrderRedeemResponse SaveSingleTaskForCreatingOrderRedeem(SaveSingleTaskForCreatingOrderRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingOrderRedeemWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderRedeemRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderRedeemResponse
        /// </returns>
        public async Task<SaveSingleTaskForCreatingOrderRedeemResponse> SaveSingleTaskForCreatingOrderRedeemAsync(SaveSingleTaskForCreatingOrderRedeemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingOrderRedeemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-续费订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderRenewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderRenewResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-续费订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderRenewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderRenewResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-续费订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderRenewRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderRenewResponse
        /// </returns>
        public SaveSingleTaskForCreatingOrderRenewResponse SaveSingleTaskForCreatingOrderRenew(SaveSingleTaskForCreatingOrderRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingOrderRenewWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-续费订单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderRenewRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderRenewResponse
        /// </returns>
        public async Task<SaveSingleTaskForCreatingOrderRenewResponse> SaveSingleTaskForCreatingOrderRenewAsync(SaveSingleTaskForCreatingOrderRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingOrderRenewWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderTransferRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderTransferResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderTransferRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderTransferResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderTransferRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderTransferResponse
        /// </returns>
        public SaveSingleTaskForCreatingOrderTransferResponse SaveSingleTaskForCreatingOrderTransfer(SaveSingleTaskForCreatingOrderTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForCreatingOrderTransferWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveSingleTaskForCreatingOrderTransferRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForCreatingOrderTransferResponse
        /// </returns>
        public async Task<SaveSingleTaskForCreatingOrderTransferResponse> SaveSingleTaskForCreatingOrderTransferAsync(SaveSingleTaskForCreatingOrderTransferRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForCreatingOrderTransferWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除dnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForDeletingDSRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDeletingDSRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除dnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForDeletingDSRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDeletingDSRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除dnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForDeletingDSRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDeletingDSRecordResponse
        /// </returns>
        public SaveSingleTaskForDeletingDSRecordResponse SaveSingleTaskForDeletingDSRecord(SaveSingleTaskForDeletingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForDeletingDSRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除dnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForDeletingDSRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDeletingDSRecordResponse
        /// </returns>
        public async Task<SaveSingleTaskForDeletingDSRecordResponse> SaveSingleTaskForDeletingDSRecordAsync(SaveSingleTaskForDeletingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForDeletingDSRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除DNS HOST任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForDeletingDnsHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDeletingDnsHostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除DNS HOST任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForDeletingDnsHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDeletingDnsHostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除DNS HOST任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForDeletingDnsHostRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDeletingDnsHostResponse
        /// </returns>
        public SaveSingleTaskForDeletingDnsHostResponse SaveSingleTaskForDeletingDnsHost(SaveSingleTaskForDeletingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForDeletingDnsHostWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除DNS HOST任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForDeletingDnsHostRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDeletingDnsHostResponse
        /// </returns>
        public async Task<SaveSingleTaskForDeletingDnsHostResponse> SaveSingleTaskForDeletingDnsHostAsync(SaveSingleTaskForDeletingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForDeletingDnsHostWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SaveSingleTaskForDisassociatingEnsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDisassociatingEnsResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveSingleTaskForDisassociatingEnsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDisassociatingEnsResponse
        /// </returns>
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

        /// <param name="request">
        /// SaveSingleTaskForDisassociatingEnsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDisassociatingEnsResponse
        /// </returns>
        public SaveSingleTaskForDisassociatingEnsResponse SaveSingleTaskForDisassociatingEns(SaveSingleTaskForDisassociatingEnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForDisassociatingEnsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SaveSingleTaskForDisassociatingEnsRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDisassociatingEnsResponse
        /// </returns>
        public async Task<SaveSingleTaskForDisassociatingEnsResponse> SaveSingleTaskForDisassociatingEnsAsync(SaveSingleTaskForDisassociatingEnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForDisassociatingEnsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-开启/关闭whois隐私保护锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForDomainNameProxyServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDomainNameProxyServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-开启/关闭whois隐私保护锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForDomainNameProxyServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDomainNameProxyServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-开启/关闭whois隐私保护锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForDomainNameProxyServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDomainNameProxyServiceResponse
        /// </returns>
        public SaveSingleTaskForDomainNameProxyServiceResponse SaveSingleTaskForDomainNameProxyService(SaveSingleTaskForDomainNameProxyServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForDomainNameProxyServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-开启/关闭whois隐私保护锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForDomainNameProxyServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForDomainNameProxyServiceResponse
        /// </returns>
        public async Task<SaveSingleTaskForDomainNameProxyServiceResponse> SaveSingleTaskForDomainNameProxyServiceAsync(SaveSingleTaskForDomainNameProxyServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForDomainNameProxyServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交生成域名证书任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForGenerateDomainCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForGenerateDomainCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交生成域名证书任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForGenerateDomainCertificateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForGenerateDomainCertificateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交生成域名证书任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForGenerateDomainCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForGenerateDomainCertificateResponse
        /// </returns>
        public SaveSingleTaskForGenerateDomainCertificateResponse SaveSingleTaskForGenerateDomainCertificate(SaveSingleTaskForGenerateDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForGenerateDomainCertificateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交生成域名证书任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForGenerateDomainCertificateRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForGenerateDomainCertificateResponse
        /// </returns>
        public async Task<SaveSingleTaskForGenerateDomainCertificateResponse> SaveSingleTaskForGenerateDomainCertificateAsync(SaveSingleTaskForGenerateDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForGenerateDomainCertificateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改DnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForModifyingDSRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForModifyingDSRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改DnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForModifyingDSRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForModifyingDSRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改DnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForModifyingDSRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForModifyingDSRecordResponse
        /// </returns>
        public SaveSingleTaskForModifyingDSRecordResponse SaveSingleTaskForModifyingDSRecord(SaveSingleTaskForModifyingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForModifyingDSRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改DnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForModifyingDSRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForModifyingDSRecordResponse
        /// </returns>
        public async Task<SaveSingleTaskForModifyingDSRecordResponse> SaveSingleTaskForModifyingDSRecordAsync(SaveSingleTaskForModifyingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForModifyingDSRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改dns服务器的任务请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForModifyingDnsHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForModifyingDnsHostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改dns服务器的任务请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForModifyingDnsHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForModifyingDnsHostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改dns服务器的任务请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForModifyingDnsHostRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForModifyingDnsHostResponse
        /// </returns>
        public SaveSingleTaskForModifyingDnsHostResponse SaveSingleTaskForModifyingDnsHost(SaveSingleTaskForModifyingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForModifyingDnsHostWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改dns服务器的任务请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForModifyingDnsHostRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForModifyingDnsHostResponse
        /// </returns>
        public async Task<SaveSingleTaskForModifyingDnsHostResponse> SaveSingleTaskForModifyingDnsHostAsync(SaveSingleTaskForModifyingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForModifyingDnsHostWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送转移码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForQueryingTransferAuthorizationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForQueryingTransferAuthorizationCodeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送转移码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForQueryingTransferAuthorizationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForQueryingTransferAuthorizationCodeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送转移码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForQueryingTransferAuthorizationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForQueryingTransferAuthorizationCodeResponse
        /// </returns>
        public SaveSingleTaskForQueryingTransferAuthorizationCodeResponse SaveSingleTaskForQueryingTransferAuthorizationCode(SaveSingleTaskForQueryingTransferAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForQueryingTransferAuthorizationCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送转移码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForQueryingTransferAuthorizationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForQueryingTransferAuthorizationCodeResponse
        /// </returns>
        public async Task<SaveSingleTaskForQueryingTransferAuthorizationCodeResponse> SaveSingleTaskForQueryingTransferAuthorizationCodeAsync(SaveSingleTaskForQueryingTransferAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForQueryingTransferAuthorizationCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>单笔抢注批量接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForReserveDropListDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForReserveDropListDomainResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>单笔抢注批量接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForReserveDropListDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForReserveDropListDomainResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>单笔抢注批量接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForReserveDropListDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForReserveDropListDomainResponse
        /// </returns>
        public SaveSingleTaskForReserveDropListDomainResponse SaveSingleTaskForReserveDropListDomain(SaveSingleTaskForReserveDropListDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForReserveDropListDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>单笔抢注批量接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForReserveDropListDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForReserveDropListDomainResponse
        /// </returns>
        public async Task<SaveSingleTaskForReserveDropListDomainResponse> SaveSingleTaskForReserveDropListDomainAsync(SaveSingleTaskForReserveDropListDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForReserveDropListDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存art扩展信息任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForSaveArtExtensionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForSaveArtExtensionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存art扩展信息任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForSaveArtExtensionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForSaveArtExtensionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存art扩展信息任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForSaveArtExtensionRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForSaveArtExtensionResponse
        /// </returns>
        public SaveSingleTaskForSaveArtExtensionResponse SaveSingleTaskForSaveArtExtension(SaveSingleTaskForSaveArtExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForSaveArtExtensionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存art扩展信息任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForSaveArtExtensionRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForSaveArtExtensionResponse
        /// </returns>
        public async Task<SaveSingleTaskForSaveArtExtensionResponse> SaveSingleTaskForSaveArtExtensionAsync(SaveSingleTaskForSaveArtExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForSaveArtExtensionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步DnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForSynchronizingDSRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForSynchronizingDSRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步DnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForSynchronizingDSRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForSynchronizingDSRecordResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步DnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForSynchronizingDSRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForSynchronizingDSRecordResponse
        /// </returns>
        public SaveSingleTaskForSynchronizingDSRecordResponse SaveSingleTaskForSynchronizingDSRecord(SaveSingleTaskForSynchronizingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForSynchronizingDSRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步DnsSec记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForSynchronizingDSRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForSynchronizingDSRecordResponse
        /// </returns>
        public async Task<SaveSingleTaskForSynchronizingDSRecordResponse> SaveSingleTaskForSynchronizingDSRecordAsync(SaveSingleTaskForSynchronizingDSRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForSynchronizingDSRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存同步dns服务器的任务请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForSynchronizingDnsHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForSynchronizingDnsHostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存同步dns服务器的任务请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForSynchronizingDnsHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForSynchronizingDnsHostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存同步dns服务器的任务请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForSynchronizingDnsHostRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForSynchronizingDnsHostResponse
        /// </returns>
        public SaveSingleTaskForSynchronizingDnsHostResponse SaveSingleTaskForSynchronizingDnsHost(SaveSingleTaskForSynchronizingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForSynchronizingDnsHostWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存同步dns服务器的任务请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForSynchronizingDnsHostRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForSynchronizingDnsHostResponse
        /// </returns>
        public async Task<SaveSingleTaskForSynchronizingDnsHostResponse> SaveSingleTaskForSynchronizingDnsHostAsync(SaveSingleTaskForSynchronizingDnsHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForSynchronizingDnsHostWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submit a single transfer-out task based on the transfer key of domain names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The task ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForTransferOutByAuthorizationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForTransferOutByAuthorizationCodeResponse
        /// </returns>
        public SaveSingleTaskForTransferOutByAuthorizationCodeResponse SaveSingleTaskForTransferOutByAuthorizationCodeWithOptions(SaveSingleTaskForTransferOutByAuthorizationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationCode))
            {
                query["AuthorizationCode"] = request.AuthorizationCode;
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
                Action = "SaveSingleTaskForTransferOutByAuthorizationCode",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForTransferOutByAuthorizationCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submit a single transfer-out task based on the transfer key of domain names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The task ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForTransferOutByAuthorizationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForTransferOutByAuthorizationCodeResponse
        /// </returns>
        public async Task<SaveSingleTaskForTransferOutByAuthorizationCodeResponse> SaveSingleTaskForTransferOutByAuthorizationCodeWithOptionsAsync(SaveSingleTaskForTransferOutByAuthorizationCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationCode))
            {
                query["AuthorizationCode"] = request.AuthorizationCode;
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
                Action = "SaveSingleTaskForTransferOutByAuthorizationCode",
                Version = "2018-01-29",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveSingleTaskForTransferOutByAuthorizationCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submit a single transfer-out task based on the transfer key of domain names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The task ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForTransferOutByAuthorizationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForTransferOutByAuthorizationCodeResponse
        /// </returns>
        public SaveSingleTaskForTransferOutByAuthorizationCodeResponse SaveSingleTaskForTransferOutByAuthorizationCode(SaveSingleTaskForTransferOutByAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForTransferOutByAuthorizationCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submit a single transfer-out task based on the transfer key of domain names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The task ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForTransferOutByAuthorizationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForTransferOutByAuthorizationCodeResponse
        /// </returns>
        public async Task<SaveSingleTaskForTransferOutByAuthorizationCodeResponse> SaveSingleTaskForTransferOutByAuthorizationCodeAsync(SaveSingleTaskForTransferOutByAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForTransferOutByAuthorizationCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-开启/关闭禁止转移锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForTransferProhibitionLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForTransferProhibitionLockResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-开启/关闭禁止转移锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForTransferProhibitionLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForTransferProhibitionLockResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-开启/关闭禁止转移锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForTransferProhibitionLockRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForTransferProhibitionLockResponse
        /// </returns>
        public SaveSingleTaskForTransferProhibitionLockResponse SaveSingleTaskForTransferProhibitionLock(SaveSingleTaskForTransferProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForTransferProhibitionLockWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-开启/关闭禁止转移锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForTransferProhibitionLockRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForTransferProhibitionLockResponse
        /// </returns>
        public async Task<SaveSingleTaskForTransferProhibitionLockResponse> SaveSingleTaskForTransferProhibitionLockAsync(SaveSingleTaskForTransferProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForTransferProhibitionLockWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-开启/关闭信息安全锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForUpdateProhibitionLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForUpdateProhibitionLockResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-开启/关闭信息安全锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForUpdateProhibitionLockRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForUpdateProhibitionLockResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-开启/关闭信息安全锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForUpdateProhibitionLockRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForUpdateProhibitionLockResponse
        /// </returns>
        public SaveSingleTaskForUpdateProhibitionLockResponse SaveSingleTaskForUpdateProhibitionLock(SaveSingleTaskForUpdateProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForUpdateProhibitionLockWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存单个任务-开启/关闭信息安全锁</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForUpdateProhibitionLockRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForUpdateProhibitionLockResponse
        /// </returns>
        public async Task<SaveSingleTaskForUpdateProhibitionLockResponse> SaveSingleTaskForUpdateProhibitionLockAsync(SaveSingleTaskForUpdateProhibitionLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForUpdateProhibitionLockWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改联系人的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForUpdatingContactInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForUpdatingContactInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改联系人的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForUpdatingContactInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForUpdatingContactInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改联系人的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForUpdatingContactInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForUpdatingContactInfoResponse
        /// </returns>
        public SaveSingleTaskForUpdatingContactInfoResponse SaveSingleTaskForUpdatingContactInfo(SaveSingleTaskForUpdatingContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveSingleTaskForUpdatingContactInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存修改联系人的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveSingleTaskForUpdatingContactInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveSingleTaskForUpdatingContactInfoResponse
        /// </returns>
        public async Task<SaveSingleTaskForUpdatingContactInfoResponse> SaveSingleTaskForUpdatingContactInfoAsync(SaveSingleTaskForUpdatingContactInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveSingleTaskForUpdatingContactInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存删除域名的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainDeleteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainDeleteResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存删除域名的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainDeleteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainDeleteResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存删除域名的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainDeleteRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainDeleteResponse
        /// </returns>
        public SaveTaskForSubmittingDomainDeleteResponse SaveTaskForSubmittingDomainDelete(SaveTaskForSubmittingDomainDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForSubmittingDomainDeleteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存删除域名的任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainDeleteRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainDeleteResponse
        /// </returns>
        public async Task<SaveTaskForSubmittingDomainDeleteResponse> SaveTaskForSubmittingDomainDeleteAsync(SaveTaskForSubmittingDomainDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForSubmittingDomainDeleteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量提交域名资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量提交域名资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量提交域名资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse
        /// </returns>
        public SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredential(SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量提交域名资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse
        /// </returns>
        public async Task<SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialResponse> SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialAsync(SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForSubmittingDomainRealNameVerificationByIdentityCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板保存域名的实名认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板保存域名的实名认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板保存域名的实名认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse
        /// </returns>
        public SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileID(SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板保存域名的实名认证信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse
        /// </returns>
        public async Task<SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDResponse> SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDAsync(SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForSubmittingDomainRealNameVerificationByRegistrantProfileIDWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据联系人信息批量修改注册联系人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据联系人信息批量修改注册联系人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据联系人信息批量修改注册联系人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse
        /// </returns>
        public SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse SaveTaskForUpdatingRegistrantInfoByIdentityCredential(SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForUpdatingRegistrantInfoByIdentityCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据联系人信息批量修改注册联系人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse
        /// </returns>
        public async Task<SaveTaskForUpdatingRegistrantInfoByIdentityCredentialResponse> SaveTaskForUpdatingRegistrantInfoByIdentityCredentialAsync(SaveTaskForUpdatingRegistrantInfoByIdentityCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForUpdatingRegistrantInfoByIdentityCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板批量修改注册联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板批量修改注册联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板批量修改注册联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse
        /// </returns>
        public SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse SaveTaskForUpdatingRegistrantInfoByRegistrantProfileID(SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据模板批量修改注册联系人</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse
        /// </returns>
        public async Task<SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDResponse> SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDAsync(SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTaskForUpdatingRegistrantInfoByRegistrantProfileIDWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Traverses domain names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you have a large number of domain names, a slow response may occur when you call an API operation to query domain names. In this case, you can call this operation to query domain names more quickly. When you call this operation for the first time, specify the request parameters except ScrollId. A scroll ID is returned without other data. In the second request, use the scroll ID obtained from the previous response. In subsequent requests, the newly specified request parameters do not take effect, and the request parameters that are specified in the first request prevail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ScrollDomainListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScrollDomainListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Traverses domain names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you have a large number of domain names, a slow response may occur when you call an API operation to query domain names. In this case, you can call this operation to query domain names more quickly. When you call this operation for the first time, specify the request parameters except ScrollId. A scroll ID is returned without other data. In the second request, use the scroll ID obtained from the previous response. In subsequent requests, the newly specified request parameters do not take effect, and the request parameters that are specified in the first request prevail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ScrollDomainListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ScrollDomainListResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Traverses domain names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you have a large number of domain names, a slow response may occur when you call an API operation to query domain names. In this case, you can call this operation to query domain names more quickly. When you call this operation for the first time, specify the request parameters except ScrollId. A scroll ID is returned without other data. In the second request, use the scroll ID obtained from the previous response. In subsequent requests, the newly specified request parameters do not take effect, and the request parameters that are specified in the first request prevail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ScrollDomainListRequest
        /// </param>
        /// 
        /// <returns>
        /// ScrollDomainListResponse
        /// </returns>
        public ScrollDomainListResponse ScrollDomainList(ScrollDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScrollDomainListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Traverses domain names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you have a large number of domain names, a slow response may occur when you call an API operation to query domain names. In this case, you can call this operation to query domain names more quickly. When you call this operation for the first time, specify the request parameters except ScrollId. A scroll ID is returned without other data. In the second request, use the scroll ID obtained from the previous response. In subsequent requests, the newly specified request parameters do not take effect, and the request parameters that are specified in the first request prevail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ScrollDomainListRequest
        /// </param>
        /// 
        /// <returns>
        /// ScrollDomainListResponse
        /// </returns>
        public async Task<ScrollDomainListResponse> ScrollDomainListAsync(ScrollDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScrollDomainListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置默认模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDefaultRegistrantProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDefaultRegistrantProfileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置默认模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDefaultRegistrantProfileRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetDefaultRegistrantProfileResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置默认模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDefaultRegistrantProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDefaultRegistrantProfileResponse
        /// </returns>
        public SetDefaultRegistrantProfileResponse SetDefaultRegistrantProfile(SetDefaultRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDefaultRegistrantProfileWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>设置默认模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetDefaultRegistrantProfileRequest
        /// </param>
        /// 
        /// <returns>
        /// SetDefaultRegistrantProfileResponse
        /// </returns>
        public async Task<SetDefaultRegistrantProfileResponse> SetDefaultRegistrantProfileAsync(SetDefaultRegistrantProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDefaultRegistrantProfileWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名设置自动续费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetupDomainAutoRenewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetupDomainAutoRenewResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名设置自动续费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetupDomainAutoRenewRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetupDomainAutoRenewResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名设置自动续费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetupDomainAutoRenewRequest
        /// </param>
        /// 
        /// <returns>
        /// SetupDomainAutoRenewResponse
        /// </returns>
        public SetupDomainAutoRenewResponse SetupDomainAutoRenew(SetupDomainAutoRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetupDomainAutoRenewWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名设置自动续费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetupDomainAutoRenewRequest
        /// </param>
        /// 
        /// <returns>
        /// SetupDomainAutoRenewResponse
        /// </returns>
        public async Task<SetupDomainAutoRenewResponse> SetupDomainAutoRenewAsync(SetupDomainAutoRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetupDomainAutoRenewWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名特殊业务提交资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDomainSpecialBizCredentialsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitDomainSpecialBizCredentialsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名特殊业务提交资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDomainSpecialBizCredentialsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitDomainSpecialBizCredentialsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名特殊业务提交资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDomainSpecialBizCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitDomainSpecialBizCredentialsResponse
        /// </returns>
        public SubmitDomainSpecialBizCredentialsResponse SubmitDomainSpecialBizCredentials(SubmitDomainSpecialBizCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDomainSpecialBizCredentialsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名特殊业务提交资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitDomainSpecialBizCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitDomainSpecialBizCredentialsResponse
        /// </returns>
        public async Task<SubmitDomainSpecialBizCredentialsResponse> SubmitDomainSpecialBizCredentialsAsync(SubmitDomainSpecialBizCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDomainSpecialBizCredentialsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交邮箱验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitEmailVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitEmailVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交邮箱验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitEmailVerificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitEmailVerificationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交邮箱验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitEmailVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitEmailVerificationResponse
        /// </returns>
        public SubmitEmailVerificationResponse SubmitEmailVerification(SubmitEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitEmailVerificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交邮箱验证</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitEmailVerificationRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitEmailVerificationResponse
        /// </returns>
        public async Task<SubmitEmailVerificationResponse> SubmitEmailVerificationAsync(SubmitEmailVerificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitEmailVerificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交申请信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitOperationAuditInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitOperationAuditInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交申请信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitOperationAuditInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitOperationAuditInfoResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交申请信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitOperationAuditInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitOperationAuditInfoResponse
        /// </returns>
        public SubmitOperationAuditInfoResponse SubmitOperationAuditInfo(SubmitOperationAuditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitOperationAuditInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交申请信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitOperationAuditInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitOperationAuditInfoResponse
        /// </returns>
        public async Task<SubmitOperationAuditInfoResponse> SubmitOperationAuditInfoAsync(SubmitOperationAuditInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitOperationAuditInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交证件资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitOperationCredentialsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitOperationCredentialsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交证件资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitOperationCredentialsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitOperationCredentialsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交证件资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitOperationCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitOperationCredentialsResponse
        /// </returns>
        public SubmitOperationCredentialsResponse SubmitOperationCredentials(SubmitOperationCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitOperationCredentialsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交证件资料</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitOperationCredentialsRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitOperationCredentialsResponse
        /// </returns>
        public async Task<SubmitOperationCredentialsResponse> SubmitOperationCredentialsAsync(SubmitOperationCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitOperationCredentialsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// TransferInCheckMailTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferInCheckMailTokenResponse
        /// </returns>
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

        /// <param name="request">
        /// TransferInCheckMailTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferInCheckMailTokenResponse
        /// </returns>
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

        /// <param name="request">
        /// TransferInCheckMailTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferInCheckMailTokenResponse
        /// </returns>
        public TransferInCheckMailTokenResponse TransferInCheckMailToken(TransferInCheckMailTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInCheckMailTokenWithOptions(request, runtime);
        }

        /// <param name="request">
        /// TransferInCheckMailTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferInCheckMailTokenResponse
        /// </returns>
        public async Task<TransferInCheckMailTokenResponse> TransferInCheckMailTokenAsync(TransferInCheckMailTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInCheckMailTokenWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// TransferInReenterTransferAuthorizationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferInReenterTransferAuthorizationCodeResponse
        /// </returns>
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

        /// <param name="request">
        /// TransferInReenterTransferAuthorizationCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferInReenterTransferAuthorizationCodeResponse
        /// </returns>
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

        /// <param name="request">
        /// TransferInReenterTransferAuthorizationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferInReenterTransferAuthorizationCodeResponse
        /// </returns>
        public TransferInReenterTransferAuthorizationCodeResponse TransferInReenterTransferAuthorizationCode(TransferInReenterTransferAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInReenterTransferAuthorizationCodeWithOptions(request, runtime);
        }

        /// <param name="request">
        /// TransferInReenterTransferAuthorizationCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferInReenterTransferAuthorizationCodeResponse
        /// </returns>
        public async Task<TransferInReenterTransferAuthorizationCodeResponse> TransferInReenterTransferAuthorizationCodeAsync(TransferInReenterTransferAuthorizationCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInReenterTransferAuthorizationCodeWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// TransferInRefetchWhoisEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferInRefetchWhoisEmailResponse
        /// </returns>
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

        /// <param name="request">
        /// TransferInRefetchWhoisEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferInRefetchWhoisEmailResponse
        /// </returns>
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

        /// <param name="request">
        /// TransferInRefetchWhoisEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferInRefetchWhoisEmailResponse
        /// </returns>
        public TransferInRefetchWhoisEmailResponse TransferInRefetchWhoisEmail(TransferInRefetchWhoisEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInRefetchWhoisEmailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// TransferInRefetchWhoisEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferInRefetchWhoisEmailResponse
        /// </returns>
        public async Task<TransferInRefetchWhoisEmailResponse> TransferInRefetchWhoisEmailAsync(TransferInRefetchWhoisEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInRefetchWhoisEmailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// TransferInResendMailTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferInResendMailTokenResponse
        /// </returns>
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

        /// <param name="request">
        /// TransferInResendMailTokenRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TransferInResendMailTokenResponse
        /// </returns>
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

        /// <param name="request">
        /// TransferInResendMailTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferInResendMailTokenResponse
        /// </returns>
        public TransferInResendMailTokenResponse TransferInResendMailToken(TransferInResendMailTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferInResendMailTokenWithOptions(request, runtime);
        }

        /// <param name="request">
        /// TransferInResendMailTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// TransferInResendMailTokenResponse
        /// </returns>
        public async Task<TransferInResendMailTokenResponse> TransferInResendMailTokenAsync(TransferInResendMailTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferInResendMailTokenWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向分组设置域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDomainToDomainGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDomainToDomainGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向分组设置域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDomainToDomainGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDomainToDomainGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向分组设置域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDomainToDomainGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDomainToDomainGroupResponse
        /// </returns>
        public UpdateDomainToDomainGroupResponse UpdateDomainToDomainGroup(UpdateDomainToDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDomainToDomainGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向分组设置域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDomainToDomainGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDomainToDomainGroupResponse
        /// </returns>
        public async Task<UpdateDomainToDomainGroupResponse> UpdateDomainToDomainGroupAsync(UpdateDomainToDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDomainToDomainGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验联系人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyContactFieldRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyContactFieldResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验联系人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyContactFieldRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyContactFieldResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验联系人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyContactFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyContactFieldResponse
        /// </returns>
        public VerifyContactFieldResponse VerifyContactField(VerifyContactFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyContactFieldWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验联系人信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyContactFieldRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyContactFieldResponse
        /// </returns>
        public async Task<VerifyContactFieldResponse> VerifyContactFieldAsync(VerifyContactFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyContactFieldWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证邮箱Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyEmailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证邮箱Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyEmailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyEmailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证邮箱Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyEmailResponse
        /// </returns>
        public VerifyEmailResponse VerifyEmail(VerifyEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyEmailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>验证邮箱Token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VerifyEmailRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyEmailResponse
        /// </returns>
        public async Task<VerifyEmailResponse> VerifyEmailAsync(VerifyEmailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyEmailWithOptionsAsync(request, runtime);
        }

    }
}
