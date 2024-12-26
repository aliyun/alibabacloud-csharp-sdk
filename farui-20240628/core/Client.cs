// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.FaRui20240628.Models;

namespace AlibabaCloud.SDK.FaRui20240628
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("farui", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>上传合同文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTextFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTextFileResponse
        /// </returns>
        public CreateTextFileResponse CreateTextFileWithOptions(string WorkspaceId, CreateTextFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                body["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextFileName))
            {
                body["TextFileName"] = request.TextFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextFileUrl))
            {
                body["TextFileUrl"] = request.TextFileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTextFile",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/data/textFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTextFileResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传合同文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTextFileRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTextFileResponse
        /// </returns>
        public async Task<CreateTextFileResponse> CreateTextFileWithOptionsAsync(string WorkspaceId, CreateTextFileRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                body["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextFileName))
            {
                body["TextFileName"] = request.TextFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextFileUrl))
            {
                body["TextFileUrl"] = request.TextFileUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTextFile",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(WorkspaceId) + "/data/textFile",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTextFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传合同文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTextFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTextFileResponse
        /// </returns>
        public CreateTextFileResponse CreateTextFile(string WorkspaceId, CreateTextFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTextFileWithOptions(WorkspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>上传合同文件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTextFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTextFileResponse
        /// </returns>
        public async Task<CreateTextFileResponse> CreateTextFileAsync(string WorkspaceId, CreateTextFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTextFileWithOptionsAsync(WorkspaceId, request, headers, runtime);
        }

        public CreateTextFileResponse CreateTextFileAdvance(string WorkspaceId, CreateTextFileAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "FaRui",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            CreateTextFileRequest createTextFileReq = new CreateTextFileRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, createTextFileReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextFileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.TextFileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                createTextFileReq.TextFileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            CreateTextFileResponse createTextFileResp = CreateTextFileWithOptions(WorkspaceId, createTextFileReq, headers, runtime);
            return createTextFileResp;
        }

        public async Task<CreateTextFileResponse> CreateTextFileAdvanceAsync(string WorkspaceId, CreateTextFileAdvanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.Empty(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.OpenApiClient.Models.Config authConfig = new AlibabaCloud.OpenApiClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "FaRui",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            CreateTextFileRequest createTextFileReq = new CreateTextFileRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, createTextFileReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TextFileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.TextFileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.Body.AccessKeyId,
                    Policy = authResponse.Body.EncodedPolicy,
                    Signature = authResponse.Body.Signature,
                    Key = authResponse.Body.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Body.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                createTextFileReq.TextFileUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            CreateTextFileResponse createTextFileResp = await CreateTextFileWithOptionsAsync(WorkspaceId, createTextFileReq, headers, runtime);
            return createTextFileResp;
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunContractResultGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunContractResultGenerationResponse
        /// </returns>
        public RunContractResultGenerationResponse RunContractResultGenerationWithOptions(string workspaceId, RunContractResultGenerationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunContractResultGenerationShrinkRequest request = new RunContractResultGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Assistant))
            {
                request.AssistantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Assistant, "assistant", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantShrink))
            {
                body["assistant"] = request.AssistantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunContractResultGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/contract/result/genarate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunContractResultGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunContractResultGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunContractResultGenerationResponse
        /// </returns>
        public async Task<RunContractResultGenerationResponse> RunContractResultGenerationWithOptionsAsync(string workspaceId, RunContractResultGenerationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunContractResultGenerationShrinkRequest request = new RunContractResultGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Assistant))
            {
                request.AssistantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Assistant, "assistant", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantShrink))
            {
                body["assistant"] = request.AssistantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunContractResultGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/contract/result/genarate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunContractResultGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContractResultGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunContractResultGenerationResponse
        /// </returns>
        public RunContractResultGenerationResponse RunContractResultGeneration(string workspaceId, RunContractResultGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunContractResultGenerationWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContractResultGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunContractResultGenerationResponse
        /// </returns>
        public async Task<RunContractResultGenerationResponse> RunContractResultGenerationAsync(string workspaceId, RunContractResultGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunContractResultGenerationWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunContractRuleGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunContractRuleGenerationResponse
        /// </returns>
        public RunContractRuleGenerationResponse RunContractRuleGenerationWithOptions(string workspaceId, RunContractRuleGenerationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunContractRuleGenerationShrinkRequest request = new RunContractRuleGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Assistant))
            {
                request.AssistantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Assistant, "assistant", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantShrink))
            {
                body["assistant"] = request.AssistantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunContractRuleGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/contract/rule/genarate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunContractRuleGenerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查规则</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunContractRuleGenerationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunContractRuleGenerationResponse
        /// </returns>
        public async Task<RunContractRuleGenerationResponse> RunContractRuleGenerationWithOptionsAsync(string workspaceId, RunContractRuleGenerationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunContractRuleGenerationShrinkRequest request = new RunContractRuleGenerationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Assistant))
            {
                request.AssistantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Assistant, "assistant", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantShrink))
            {
                body["assistant"] = request.AssistantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunContractRuleGeneration",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/contract/rule/genarate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunContractRuleGenerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContractRuleGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunContractRuleGenerationResponse
        /// </returns>
        public RunContractRuleGenerationResponse RunContractRuleGeneration(string workspaceId, RunContractRuleGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunContractRuleGenerationWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成合同审查规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunContractRuleGenerationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunContractRuleGenerationResponse
        /// </returns>
        public async Task<RunContractRuleGenerationResponse> RunContractRuleGenerationAsync(string workspaceId, RunContractRuleGenerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunContractRuleGenerationWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法律咨询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunLegalAdviceConsultationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunLegalAdviceConsultationResponse
        /// </returns>
        public RunLegalAdviceConsultationResponse RunLegalAdviceConsultationWithOptions(string workspaceId, RunLegalAdviceConsultationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunLegalAdviceConsultationShrinkRequest request = new RunLegalAdviceConsultationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Assistant))
            {
                request.AssistantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Assistant, "assistant", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Thread))
            {
                request.ThreadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Thread, "thread", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantShrink))
            {
                body["assistant"] = request.AssistantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadShrink))
            {
                body["thread"] = request.ThreadShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunLegalAdviceConsultation",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/legalAdvice/consult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunLegalAdviceConsultationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法律咨询</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunLegalAdviceConsultationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunLegalAdviceConsultationResponse
        /// </returns>
        public async Task<RunLegalAdviceConsultationResponse> RunLegalAdviceConsultationWithOptionsAsync(string workspaceId, RunLegalAdviceConsultationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunLegalAdviceConsultationShrinkRequest request = new RunLegalAdviceConsultationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Assistant))
            {
                request.AssistantShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Assistant, "assistant", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Thread))
            {
                request.ThreadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Thread, "thread", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssistantShrink))
            {
                body["assistant"] = request.AssistantShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stream))
            {
                body["stream"] = request.Stream;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadShrink))
            {
                body["thread"] = request.ThreadShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunLegalAdviceConsultation",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/legalAdvice/consult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunLegalAdviceConsultationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法律咨询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunLegalAdviceConsultationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunLegalAdviceConsultationResponse
        /// </returns>
        public RunLegalAdviceConsultationResponse RunLegalAdviceConsultation(string workspaceId, RunLegalAdviceConsultationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunLegalAdviceConsultationWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法律咨询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunLegalAdviceConsultationRequest
        /// </param>
        /// 
        /// <returns>
        /// RunLegalAdviceConsultationResponse
        /// </returns>
        public async Task<RunLegalAdviceConsultationResponse> RunLegalAdviceConsultationAsync(string workspaceId, RunLegalAdviceConsultationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunLegalAdviceConsultationWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>案例检索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunSearchCaseFullTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSearchCaseFullTextResponse
        /// </returns>
        public RunSearchCaseFullTextResponse RunSearchCaseFullTextWithOptions(string workspaceId, RunSearchCaseFullTextRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSearchCaseFullTextShrinkRequest request = new RunSearchCaseFullTextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "filterCondition", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PageParam))
            {
                request.PageParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PageParam, "pageParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryKeywords))
            {
                request.QueryKeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryKeywords, "queryKeywords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SortKeyAndDirection))
            {
                request.SortKeyAndDirectionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SortKeyAndDirection, "sortKeyAndDirection", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Thread))
            {
                request.ThreadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Thread, "thread", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["filterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageParamShrink))
            {
                body["pageParam"] = request.PageParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywordsShrink))
            {
                body["queryKeywords"] = request.QueryKeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKeyAndDirectionShrink))
            {
                body["sortKeyAndDirection"] = request.SortKeyAndDirectionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadShrink))
            {
                body["thread"] = request.ThreadShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSearchCaseFullText",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/search/case/fulltext",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSearchCaseFullTextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>案例检索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunSearchCaseFullTextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSearchCaseFullTextResponse
        /// </returns>
        public async Task<RunSearchCaseFullTextResponse> RunSearchCaseFullTextWithOptionsAsync(string workspaceId, RunSearchCaseFullTextRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSearchCaseFullTextShrinkRequest request = new RunSearchCaseFullTextShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "filterCondition", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PageParam))
            {
                request.PageParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PageParam, "pageParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryKeywords))
            {
                request.QueryKeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryKeywords, "queryKeywords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SortKeyAndDirection))
            {
                request.SortKeyAndDirectionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SortKeyAndDirection, "sortKeyAndDirection", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Thread))
            {
                request.ThreadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Thread, "thread", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["filterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageParamShrink))
            {
                body["pageParam"] = request.PageParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywordsShrink))
            {
                body["queryKeywords"] = request.QueryKeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortKeyAndDirectionShrink))
            {
                body["sortKeyAndDirection"] = request.SortKeyAndDirectionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadShrink))
            {
                body["thread"] = request.ThreadShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSearchCaseFullText",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/search/case/fulltext",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSearchCaseFullTextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>案例检索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSearchCaseFullTextRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSearchCaseFullTextResponse
        /// </returns>
        public RunSearchCaseFullTextResponse RunSearchCaseFullText(string workspaceId, RunSearchCaseFullTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunSearchCaseFullTextWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>案例检索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSearchCaseFullTextRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSearchCaseFullTextResponse
        /// </returns>
        public async Task<RunSearchCaseFullTextResponse> RunSearchCaseFullTextAsync(string workspaceId, RunSearchCaseFullTextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunSearchCaseFullTextWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法规搜索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunSearchLawQueryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSearchLawQueryResponse
        /// </returns>
        public RunSearchLawQueryResponse RunSearchLawQueryWithOptions(string workspaceId, RunSearchLawQueryRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSearchLawQueryShrinkRequest request = new RunSearchLawQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "filterCondition", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PageParam))
            {
                request.PageParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PageParam, "pageParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryKeywords))
            {
                request.QueryKeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryKeywords, "queryKeywords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Thread))
            {
                request.ThreadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Thread, "thread", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["filterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageParamShrink))
            {
                body["pageParam"] = request.PageParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywordsShrink))
            {
                body["queryKeywords"] = request.QueryKeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadShrink))
            {
                body["thread"] = request.ThreadShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSearchLawQuery",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/search/law/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSearchLawQueryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法规搜索</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// RunSearchLawQueryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunSearchLawQueryResponse
        /// </returns>
        public async Task<RunSearchLawQueryResponse> RunSearchLawQueryWithOptionsAsync(string workspaceId, RunSearchLawQueryRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunSearchLawQueryShrinkRequest request = new RunSearchLawQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FilterCondition))
            {
                request.FilterConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FilterCondition, "filterCondition", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PageParam))
            {
                request.PageParamShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PageParam, "pageParam", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueryKeywords))
            {
                request.QueryKeywordsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueryKeywords, "queryKeywords", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Thread))
            {
                request.ThreadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Thread, "thread", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConditionShrink))
            {
                body["filterCondition"] = request.FilterConditionShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageParamShrink))
            {
                body["pageParam"] = request.PageParamShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryKeywordsShrink))
            {
                body["queryKeywords"] = request.QueryKeywordsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThreadShrink))
            {
                body["thread"] = request.ThreadShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunSearchLawQuery",
                Version = "2024-06-28",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/farui/search/law/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunSearchLawQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法规搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSearchLawQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSearchLawQueryResponse
        /// </returns>
        public RunSearchLawQueryResponse RunSearchLawQuery(string workspaceId, RunSearchLawQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunSearchLawQueryWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>法规搜索</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunSearchLawQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// RunSearchLawQueryResponse
        /// </returns>
        public async Task<RunSearchLawQueryResponse> RunSearchLawQueryAsync(string workspaceId, RunSearchLawQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunSearchLawQueryWithOptionsAsync(workspaceId, request, headers, runtime);
        }

    }
}
