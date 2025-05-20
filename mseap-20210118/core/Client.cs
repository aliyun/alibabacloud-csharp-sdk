// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Mseap20210118.Models;

namespace AlibabaCloud.SDK.Mseap20210118
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("mseap", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// ActivateLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateLicenseResponse
        /// </returns>
        public ActivateLicenseResponse ActivateLicenseWithOptions(ActivateLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseCode))
            {
                query["LicenseCode"] = request.LicenseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseNo))
            {
                query["LicenseNo"] = request.LicenseNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicensePublisher))
            {
                query["LicensePublisher"] = request.LicensePublisher;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateLicense",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateLicenseResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ActivateLicenseRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateLicenseResponse
        /// </returns>
        public async Task<ActivateLicenseResponse> ActivateLicenseWithOptionsAsync(ActivateLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseCode))
            {
                query["LicenseCode"] = request.LicenseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicenseNo))
            {
                query["LicenseNo"] = request.LicenseNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LicensePublisher))
            {
                query["LicensePublisher"] = request.LicensePublisher;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateLicense",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ActivateLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateLicenseResponse
        /// </returns>
        public ActivateLicenseResponse ActivateLicense(ActivateLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateLicenseWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ActivateLicenseRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateLicenseResponse
        /// </returns>
        public async Task<ActivateLicenseResponse> ActivateLicenseAsync(ActivateLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateLicenseWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CallbackTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CallbackTaskResponse
        /// </returns>
        public CallbackTaskResponse CallbackTaskWithOptions(CallbackTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["BizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                query["OutTaskId"] = request.OutTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalKey))
            {
                query["PrincipalKey"] = request.PrincipalKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskData))
            {
                query["TaskData"] = request.TaskData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CallbackTask",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CallbackTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CallbackTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CallbackTaskResponse
        /// </returns>
        public async Task<CallbackTaskResponse> CallbackTaskWithOptionsAsync(CallbackTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["BizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTaskId))
            {
                query["OutTaskId"] = request.OutTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalKey))
            {
                query["PrincipalKey"] = request.PrincipalKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskData))
            {
                query["TaskData"] = request.TaskData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CallbackTask",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CallbackTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CallbackTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CallbackTaskResponse
        /// </returns>
        public CallbackTaskResponse CallbackTask(CallbackTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CallbackTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CallbackTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CallbackTaskResponse
        /// </returns>
        public async Task<CallbackTaskResponse> CallbackTaskAsync(CallbackTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CallbackTaskWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DescribeAgreementStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAgreementStatusResponse
        /// </returns>
        public DescribeAgreementStatusResponse DescribeAgreementStatusWithOptions(DescribeAgreementStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementCode))
            {
                query["AgreementCode"] = request.AgreementCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAgreementStatus",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAgreementStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeAgreementStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAgreementStatusResponse
        /// </returns>
        public async Task<DescribeAgreementStatusResponse> DescribeAgreementStatusWithOptionsAsync(DescribeAgreementStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementCode))
            {
                query["AgreementCode"] = request.AgreementCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAgreementStatus",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAgreementStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeAgreementStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAgreementStatusResponse
        /// </returns>
        public DescribeAgreementStatusResponse DescribeAgreementStatus(DescribeAgreementStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAgreementStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DescribeAgreementStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAgreementStatusResponse
        /// </returns>
        public async Task<DescribeAgreementStatusResponse> DescribeAgreementStatusAsync(DescribeAgreementStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAgreementStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴生成上传文件策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUploadFilePolicyForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadFilePolicyForPartnerResponse
        /// </returns>
        public GenerateUploadFilePolicyForPartnerResponse GenerateUploadFilePolicyForPartnerWithOptions(GenerateUploadFilePolicyForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GenerateUploadFilePolicyForPartner",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadFilePolicyForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴生成上传文件策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUploadFilePolicyForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadFilePolicyForPartnerResponse
        /// </returns>
        public async Task<GenerateUploadFilePolicyForPartnerResponse> GenerateUploadFilePolicyForPartnerWithOptionsAsync(GenerateUploadFilePolicyForPartnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GenerateUploadFilePolicyForPartner",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateUploadFilePolicyForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴生成上传文件策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUploadFilePolicyForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadFilePolicyForPartnerResponse
        /// </returns>
        public GenerateUploadFilePolicyForPartnerResponse GenerateUploadFilePolicyForPartner(GenerateUploadFilePolicyForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateUploadFilePolicyForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴生成上传文件策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateUploadFilePolicyForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateUploadFilePolicyForPartnerResponse
        /// </returns>
        public async Task<GenerateUploadFilePolicyForPartnerResponse> GenerateUploadFilePolicyForPartnerAsync(GenerateUploadFilePolicyForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateUploadFilePolicyForPartnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取node节点通过流程id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeByFlowIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeByFlowIdResponse
        /// </returns>
        public GetNodeByFlowIdResponse GetNodeByFlowIdWithOptions(GetNodeByFlowIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeByFlowId",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeByFlowIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取node节点通过流程id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeByFlowIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeByFlowIdResponse
        /// </returns>
        public async Task<GetNodeByFlowIdResponse> GetNodeByFlowIdWithOptionsAsync(GetNodeByFlowIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowId))
            {
                query["FlowId"] = request.FlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeByFlowId",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeByFlowIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取node节点通过流程id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeByFlowIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeByFlowIdResponse
        /// </returns>
        public GetNodeByFlowIdResponse GetNodeByFlowId(GetNodeByFlowIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeByFlowIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取node节点通过流程id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeByFlowIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeByFlowIdResponse
        /// </returns>
        public async Task<GetNodeByFlowIdResponse> GetNodeByFlowIdAsync(GetNodeByFlowIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeByFlowIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取node节点通过模版id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeByTemplateIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeByTemplateIdResponse
        /// </returns>
        public GetNodeByTemplateIdResponse GetNodeByTemplateIdWithOptions(GetNodeByTemplateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeByTemplateId",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeByTemplateIdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取node节点通过模版id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeByTemplateIdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetNodeByTemplateIdResponse
        /// </returns>
        public async Task<GetNodeByTemplateIdResponse> GetNodeByTemplateIdWithOptionsAsync(GetNodeByTemplateIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeByTemplateId",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeByTemplateIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取node节点通过模版id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeByTemplateIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeByTemplateIdResponse
        /// </returns>
        public GetNodeByTemplateIdResponse GetNodeByTemplateId(GetNodeByTemplateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeByTemplateIdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取node节点通过模版id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetNodeByTemplateIdRequest
        /// </param>
        /// 
        /// <returns>
        /// GetNodeByTemplateIdResponse
        /// </returns>
        public async Task<GetNodeByTemplateIdResponse> GetNodeByTemplateIdAsync(GetNodeByTemplateIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeByTemplateIdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取代理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProxyByTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProxyByTypeResponse
        /// </returns>
        public GetProxyByTypeResponse GetProxyByTypeWithOptions(GetProxyByTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProxyByType",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProxyByTypeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取代理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProxyByTypeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProxyByTypeResponse
        /// </returns>
        public async Task<GetProxyByTypeResponse> GetProxyByTypeWithOptionsAsync(GetProxyByTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProxyByType",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProxyByTypeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取代理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProxyByTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProxyByTypeResponse
        /// </returns>
        public GetProxyByTypeResponse GetProxyByType(GetProxyByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProxyByTypeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取代理</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProxyByTypeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProxyByTypeResponse
        /// </returns>
        public async Task<GetProxyByTypeResponse> GetProxyByTypeAsync(GetProxyByTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProxyByTypeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取redis值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRedisValueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRedisValueResponse
        /// </returns>
        public GetRedisValueResponse GetRedisValueWithOptions(GetRedisValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRedisValue",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRedisValueResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取redis值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRedisValueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRedisValueResponse
        /// </returns>
        public async Task<GetRedisValueResponse> GetRedisValueWithOptionsAsync(GetRedisValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRedisValue",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRedisValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取redis值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRedisValueRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRedisValueResponse
        /// </returns>
        public GetRedisValueResponse GetRedisValue(GetRedisValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRedisValueWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取redis值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRedisValueRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRedisValueResponse
        /// </returns>
        public async Task<GetRedisValueResponse> GetRedisValueAsync(GetRedisValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRedisValueWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取变量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVariableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVariableResponse
        /// </returns>
        public GetVariableResponse GetVariableWithOptions(GetVariableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVariable",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVariableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取变量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVariableRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVariableResponse
        /// </returns>
        public async Task<GetVariableResponse> GetVariableWithOptionsAsync(GetVariableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVariable",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVariableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取变量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVariableRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVariableResponse
        /// </returns>
        public GetVariableResponse GetVariable(GetVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVariableWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取变量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVariableRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVariableResponse
        /// </returns>
        public async Task<GetVariableResponse> GetVariableAsync(GetVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVariableWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>识别验证码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IdentifyCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IdentifyCodeResponse
        /// </returns>
        public IdentifyCodeResponse IdentifyCodeWithOptions(IdentifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IdentifyCode",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IdentifyCodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>识别验证码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IdentifyCodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// IdentifyCodeResponse
        /// </returns>
        public async Task<IdentifyCodeResponse> IdentifyCodeWithOptionsAsync(IdentifyCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                query["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Label))
            {
                query["Label"] = request.Label;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IdentifyCode",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IdentifyCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>识别验证码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IdentifyCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// IdentifyCodeResponse
        /// </returns>
        public IdentifyCodeResponse IdentifyCode(IdentifyCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IdentifyCodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>识别验证码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// IdentifyCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// IdentifyCodeResponse
        /// </returns>
        public async Task<IdentifyCodeResponse> IdentifyCodeAsync(IdentifyCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IdentifyCodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取协议变更识别模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullRpaModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PullRpaModelResponse
        /// </returns>
        public PullRpaModelResponse PullRpaModelWithOptions(PullRpaModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PullRpaModel",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullRpaModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取协议变更识别模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullRpaModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PullRpaModelResponse
        /// </returns>
        public async Task<PullRpaModelResponse> PullRpaModelWithOptionsAsync(PullRpaModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PullRpaModel",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullRpaModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取协议变更识别模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullRpaModelRequest
        /// </param>
        /// 
        /// <returns>
        /// PullRpaModelResponse
        /// </returns>
        public PullRpaModelResponse PullRpaModel(PullRpaModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PullRpaModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取协议变更识别模型</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullRpaModelRequest
        /// </param>
        /// 
        /// <returns>
        /// PullRpaModelResponse
        /// </returns>
        public async Task<PullRpaModelResponse> PullRpaModelAsync(PullRpaModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PullRpaModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RPA拉取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PullTaskResponse
        /// </returns>
        public PullTaskResponse PullTaskWithOptions(PullTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["BizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalKey))
            {
                query["PrincipalKey"] = request.PrincipalKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PullTask",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RPA拉取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PullTaskResponse
        /// </returns>
        public async Task<PullTaskResponse> PullTaskWithOptionsAsync(PullTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["BizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrincipalKey))
            {
                query["PrincipalKey"] = request.PrincipalKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerSecurityTransport))
            {
                query["UserCallerSecurityTransport"] = request.UserCallerSecurityTransport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PullTask",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RPA拉取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// PullTaskResponse
        /// </returns>
        public PullTaskResponse PullTask(PullTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PullTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RPA拉取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PullTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// PullTaskResponse
        /// </returns>
        public async Task<PullTaskResponse> PullTaskAsync(PullTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PullTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送RPA运行时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushRpaTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushRpaTaskResponse
        /// </returns>
        public PushRpaTaskResponse PushRpaTaskWithOptions(PushRpaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                query["Request"] = request.Request;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushRpaTask",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushRpaTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送RPA运行时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushRpaTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushRpaTaskResponse
        /// </returns>
        public async Task<PushRpaTaskResponse> PushRpaTaskWithOptionsAsync(PushRpaTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Request))
            {
                query["Request"] = request.Request;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushRpaTask",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushRpaTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送RPA运行时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushRpaTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// PushRpaTaskResponse
        /// </returns>
        public PushRpaTaskResponse PushRpaTask(PushRpaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushRpaTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送RPA运行时任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushRpaTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// PushRpaTaskResponse
        /// </returns>
        public async Task<PushRpaTaskResponse> PushRpaTaskAsync(PushRpaTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushRpaTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送运行时任务明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushRpaTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushRpaTaskDetailResponse
        /// </returns>
        public PushRpaTaskDetailResponse PushRpaTaskDetailWithOptions(PushRpaTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputData))
            {
                query["InputData"] = request.InputData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputHtml))
            {
                query["InputHtml"] = request.InputHtml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputScreenshot))
            {
                query["InputScreenshot"] = request.InputScreenshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelDetailId))
            {
                query["ModelDetailId"] = request.ModelDetailId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputData))
            {
                query["OutputData"] = request.OutputData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputHtml))
            {
                query["OutputHtml"] = request.OutputHtml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputScreenshot))
            {
                query["OutputScreenshot"] = request.OutputScreenshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDetailId))
            {
                query["TaskDetailId"] = request.TaskDetailId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushRpaTaskDetail",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushRpaTaskDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送运行时任务明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushRpaTaskDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushRpaTaskDetailResponse
        /// </returns>
        public async Task<PushRpaTaskDetailResponse> PushRpaTaskDetailWithOptionsAsync(PushRpaTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputData))
            {
                query["InputData"] = request.InputData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputHtml))
            {
                query["InputHtml"] = request.InputHtml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputScreenshot))
            {
                query["InputScreenshot"] = request.InputScreenshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelDetailId))
            {
                query["ModelDetailId"] = request.ModelDetailId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputData))
            {
                query["OutputData"] = request.OutputData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputHtml))
            {
                query["OutputHtml"] = request.OutputHtml;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputScreenshot))
            {
                query["OutputScreenshot"] = request.OutputScreenshot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskDetailId))
            {
                query["TaskDetailId"] = request.TaskDetailId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushRpaTaskDetail",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushRpaTaskDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送运行时任务明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushRpaTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// PushRpaTaskDetailResponse
        /// </returns>
        public PushRpaTaskDetailResponse PushRpaTaskDetail(PushRpaTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushRpaTaskDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>推送运行时任务明细</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushRpaTaskDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// PushRpaTaskDetailResponse
        /// </returns>
        public async Task<PushRpaTaskDetailResponse> PushRpaTaskDetailAsync(PushRpaTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushRpaTaskDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴发送消息通知</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SendNotificationForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendNotificationForPartnerResponse
        /// </returns>
        public SendNotificationForPartnerResponse SendNotificationForPartnerWithOptions(SendNotificationForPartnerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendNotificationForPartnerShrinkRequest request = new SendNotificationForPartnerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParamMap))
            {
                request.ParamMapShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParamMap, "ParamMap", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SmartSubChannels))
            {
                request.SmartSubChannelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SmartSubChannels, "SmartSubChannels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                query["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifycationEventType))
            {
                query["NotifycationEventType"] = request.NotifycationEventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamMapShrink))
            {
                query["ParamMap"] = request.ParamMapShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendTarget))
            {
                query["SendTarget"] = request.SendTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmartSubChannelsShrink))
            {
                query["SmartSubChannels"] = request.SmartSubChannelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrackId))
            {
                query["TrackId"] = request.TrackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendNotificationForPartner",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendNotificationForPartnerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴发送消息通知</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SendNotificationForPartnerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendNotificationForPartnerResponse
        /// </returns>
        public async Task<SendNotificationForPartnerResponse> SendNotificationForPartnerWithOptionsAsync(SendNotificationForPartnerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendNotificationForPartnerShrinkRequest request = new SendNotificationForPartnerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ParamMap))
            {
                request.ParamMapShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ParamMap, "ParamMap", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SmartSubChannels))
            {
                request.SmartSubChannelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SmartSubChannels, "SmartSubChannels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                query["ChannelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyType))
            {
                query["NotifyType"] = request.NotifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifycationEventType))
            {
                query["NotifycationEventType"] = request.NotifycationEventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamMapShrink))
            {
                query["ParamMap"] = request.ParamMapShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendTarget))
            {
                query["SendTarget"] = request.SendTarget;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmartSubChannelsShrink))
            {
                query["SmartSubChannels"] = request.SmartSubChannelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrackId))
            {
                query["TrackId"] = request.TrackId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendNotificationForPartner",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendNotificationForPartnerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴发送消息通知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendNotificationForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// SendNotificationForPartnerResponse
        /// </returns>
        public SendNotificationForPartnerResponse SendNotificationForPartner(SendNotificationForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendNotificationForPartnerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作伙伴发送消息通知</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendNotificationForPartnerRequest
        /// </param>
        /// 
        /// <returns>
        /// SendNotificationForPartnerResponse
        /// </returns>
        public async Task<SendNotificationForPartnerResponse> SendNotificationForPartnerAsync(SendNotificationForPartnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendNotificationForPartnerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>redis设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRedisValueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRedisValueResponse
        /// </returns>
        public SetRedisValueResponse SetRedisValueWithOptions(SetRedisValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRedisValue",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRedisValueResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>redis设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRedisValueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SetRedisValueResponse
        /// </returns>
        public async Task<SetRedisValueResponse> SetRedisValueWithOptionsAsync(SetRedisValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliyunKp))
            {
                query["AliyunKp"] = request.AliyunKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiType))
            {
                query["ApiType"] = request.ApiType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bid))
            {
                query["Bid"] = request.Bid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginalRequest))
            {
                query["OriginalRequest"] = request.OriginalRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                query["RequestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserAccessKeyId))
            {
                query["UserAccessKeyId"] = request.UserAccessKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserBid))
            {
                query["UserBid"] = request.UserBid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerParentId))
            {
                query["UserCallerParentId"] = request.UserCallerParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCallerType))
            {
                query["UserCallerType"] = request.UserCallerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserClientIp))
            {
                query["UserClientIp"] = request.UserClientIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserKp))
            {
                query["UserKp"] = request.UserKp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMfaPresent))
            {
                query["UserMfaPresent"] = request.UserMfaPresent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserSecurityToken))
            {
                query["UserSecurityToken"] = request.UserSecurityToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetRedisValue",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetRedisValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>redis设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRedisValueRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRedisValueResponse
        /// </returns>
        public SetRedisValueResponse SetRedisValue(SetRedisValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetRedisValueWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>redis设置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SetRedisValueRequest
        /// </param>
        /// 
        /// <returns>
        /// SetRedisValueResponse
        /// </returns>
        public async Task<SetRedisValueResponse> SetRedisValueAsync(SetRedisValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetRedisValueWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateAgreementStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgreementStatusResponse
        /// </returns>
        public UpdateAgreementStatusResponse UpdateAgreementStatusWithOptions(UpdateAgreementStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementCode))
            {
                query["AgreementCode"] = request.AgreementCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgreementStatus",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgreementStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAgreementStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgreementStatusResponse
        /// </returns>
        public async Task<UpdateAgreementStatusResponse> UpdateAgreementStatusWithOptionsAsync(UpdateAgreementStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementCode))
            {
                query["AgreementCode"] = request.AgreementCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAgreementStatus",
                Version = "2021-01-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAgreementStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateAgreementStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgreementStatusResponse
        /// </returns>
        public UpdateAgreementStatusResponse UpdateAgreementStatus(UpdateAgreementStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAgreementStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateAgreementStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAgreementStatusResponse
        /// </returns>
        public async Task<UpdateAgreementStatusResponse> UpdateAgreementStatusAsync(UpdateAgreementStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAgreementStatusWithOptionsAsync(request, runtime);
        }

    }
}
