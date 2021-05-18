// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Alimt20181012.Models;

namespace AlibabaCloud.SDK.Alimt20181012
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-hangzhou", "mt.cn-hangzhou.aliyuncs.com"},
                {"ap-northeast-1", "mt.aliyuncs.com"},
                {"ap-northeast-2-pop", "mt.aliyuncs.com"},
                {"ap-south-1", "mt.aliyuncs.com"},
                {"ap-southeast-1", "mt.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "mt.aliyuncs.com"},
                {"ap-southeast-3", "mt.aliyuncs.com"},
                {"ap-southeast-5", "mt.aliyuncs.com"},
                {"cn-beijing", "mt.aliyuncs.com"},
                {"cn-beijing-finance-1", "mt.aliyuncs.com"},
                {"cn-beijing-finance-pop", "mt.aliyuncs.com"},
                {"cn-beijing-gov-1", "mt.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "mt.aliyuncs.com"},
                {"cn-chengdu", "mt.aliyuncs.com"},
                {"cn-edge-1", "mt.aliyuncs.com"},
                {"cn-fujian", "mt.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "mt.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "mt.aliyuncs.com"},
                {"cn-hangzhou-finance", "mt.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "mt.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "mt.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "mt.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "mt.aliyuncs.com"},
                {"cn-hangzhou-test-306", "mt.aliyuncs.com"},
                {"cn-hongkong", "mt.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "mt.aliyuncs.com"},
                {"cn-huhehaote", "mt.aliyuncs.com"},
                {"cn-north-2-gov-1", "mt.aliyuncs.com"},
                {"cn-qingdao", "mt.aliyuncs.com"},
                {"cn-qingdao-nebula", "mt.aliyuncs.com"},
                {"cn-shanghai", "mt.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "mt.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "mt.aliyuncs.com"},
                {"cn-shanghai-finance-1", "mt.aliyuncs.com"},
                {"cn-shanghai-inner", "mt.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "mt.aliyuncs.com"},
                {"cn-shenzhen", "mt.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "mt.aliyuncs.com"},
                {"cn-shenzhen-inner", "mt.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "mt.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "mt.aliyuncs.com"},
                {"cn-wuhan", "mt.aliyuncs.com"},
                {"cn-yushanfang", "mt.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "mt.aliyuncs.com"},
                {"cn-zhangjiakou", "mt.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "mt.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "mt.aliyuncs.com"},
                {"eu-central-1", "mt.aliyuncs.com"},
                {"eu-west-1", "mt.aliyuncs.com"},
                {"eu-west-1-oxs", "mt.aliyuncs.com"},
                {"me-east-1", "mt.aliyuncs.com"},
                {"rus-west-1-pop", "mt.aliyuncs.com"},
                {"us-east-1", "mt.aliyuncs.com"},
                {"us-west-1", "mt.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("alimt", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateDocTranslateTaskResponse CreateDocTranslateTaskWithOptions(CreateDocTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDocTranslateTaskResponse>(DoRPCRequest("CreateDocTranslateTask", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDocTranslateTaskResponse> CreateDocTranslateTaskWithOptionsAsync(CreateDocTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDocTranslateTaskResponse>(await DoRPCRequestAsync("CreateDocTranslateTask", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDocTranslateTaskResponse CreateDocTranslateTask(CreateDocTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDocTranslateTaskWithOptions(request, runtime);
        }

        public async Task<CreateDocTranslateTaskResponse> CreateDocTranslateTaskAsync(CreateDocTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDocTranslateTaskWithOptionsAsync(request, runtime);
        }

        public CreateDocTranslateTaskResponse CreateDocTranslateTaskAdvance(CreateDocTranslateTaskAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "alimt",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            CreateDocTranslateTaskRequest createDocTranslateTaskReq = new CreateDocTranslateTaskRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, createDocTranslateTaskReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.AccessKeyId,
                    Policy = authResponse.EncodedPolicy,
                    Signature = authResponse.Signature,
                    Key = authResponse.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                createDocTranslateTaskReq.FileUrl = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            }
            CreateDocTranslateTaskResponse createDocTranslateTaskResp = CreateDocTranslateTaskWithOptions(createDocTranslateTaskReq, runtime);
            return createDocTranslateTaskResp;
        }

        public async Task<CreateDocTranslateTaskResponse> CreateDocTranslateTaskAdvanceAsync(CreateDocTranslateTaskAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "alimt",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            CreateDocTranslateTaskRequest createDocTranslateTaskReq = new CreateDocTranslateTaskRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, createDocTranslateTaskReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.ObjectKey,
                    Content = request.FileUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.AccessKeyId,
                    Policy = authResponse.EncodedPolicy,
                    Signature = authResponse.Signature,
                    Key = authResponse.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                createDocTranslateTaskReq.FileUrl = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            }
            CreateDocTranslateTaskResponse createDocTranslateTaskResp = await CreateDocTranslateTaskWithOptionsAsync(createDocTranslateTaskReq, runtime);
            return createDocTranslateTaskResp;
        }

        public CreateImageTranslateTaskResponse CreateImageTranslateTaskWithOptions(CreateImageTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageTranslateTaskResponse>(DoRPCRequest("CreateImageTranslateTask", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateImageTranslateTaskResponse> CreateImageTranslateTaskWithOptionsAsync(CreateImageTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageTranslateTaskResponse>(await DoRPCRequestAsync("CreateImageTranslateTask", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateImageTranslateTaskResponse CreateImageTranslateTask(CreateImageTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageTranslateTaskWithOptions(request, runtime);
        }

        public async Task<CreateImageTranslateTaskResponse> CreateImageTranslateTaskAsync(CreateImageTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageTranslateTaskWithOptionsAsync(request, runtime);
        }

        public GetBatchTranslateResponse GetBatchTranslateWithOptions(GetBatchTranslateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBatchTranslateResponse>(DoRPCRequest("GetBatchTranslate", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBatchTranslateResponse> GetBatchTranslateWithOptionsAsync(GetBatchTranslateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBatchTranslateResponse>(await DoRPCRequestAsync("GetBatchTranslate", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBatchTranslateResponse GetBatchTranslate(GetBatchTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBatchTranslateWithOptions(request, runtime);
        }

        public async Task<GetBatchTranslateResponse> GetBatchTranslateAsync(GetBatchTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBatchTranslateWithOptionsAsync(request, runtime);
        }

        public GetDetectLanguageResponse GetDetectLanguageWithOptions(GetDetectLanguageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDetectLanguageResponse>(DoRPCRequest("GetDetectLanguage", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDetectLanguageResponse> GetDetectLanguageWithOptionsAsync(GetDetectLanguageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDetectLanguageResponse>(await DoRPCRequestAsync("GetDetectLanguage", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDetectLanguageResponse GetDetectLanguage(GetDetectLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDetectLanguageWithOptions(request, runtime);
        }

        public async Task<GetDetectLanguageResponse> GetDetectLanguageAsync(GetDetectLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDetectLanguageWithOptionsAsync(request, runtime);
        }

        public GetDocTranslateTaskResponse GetDocTranslateTaskWithOptions(GetDocTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDocTranslateTaskResponse>(DoRPCRequest("GetDocTranslateTask", "2018-10-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetDocTranslateTaskResponse> GetDocTranslateTaskWithOptionsAsync(GetDocTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDocTranslateTaskResponse>(await DoRPCRequestAsync("GetDocTranslateTask", "2018-10-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetDocTranslateTaskResponse GetDocTranslateTask(GetDocTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocTranslateTaskWithOptions(request, runtime);
        }

        public async Task<GetDocTranslateTaskResponse> GetDocTranslateTaskAsync(GetDocTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocTranslateTaskWithOptionsAsync(request, runtime);
        }

        public GetImageDiagnoseResponse GetImageDiagnoseWithOptions(GetImageDiagnoseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImageDiagnoseResponse>(DoRPCRequest("GetImageDiagnose", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetImageDiagnoseResponse> GetImageDiagnoseWithOptionsAsync(GetImageDiagnoseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImageDiagnoseResponse>(await DoRPCRequestAsync("GetImageDiagnose", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetImageDiagnoseResponse GetImageDiagnose(GetImageDiagnoseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageDiagnoseWithOptions(request, runtime);
        }

        public async Task<GetImageDiagnoseResponse> GetImageDiagnoseAsync(GetImageDiagnoseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageDiagnoseWithOptionsAsync(request, runtime);
        }

        public GetImageTranslateResponse GetImageTranslateWithOptions(GetImageTranslateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImageTranslateResponse>(DoRPCRequest("GetImageTranslate", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetImageTranslateResponse> GetImageTranslateWithOptionsAsync(GetImageTranslateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImageTranslateResponse>(await DoRPCRequestAsync("GetImageTranslate", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetImageTranslateResponse GetImageTranslate(GetImageTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageTranslateWithOptions(request, runtime);
        }

        public async Task<GetImageTranslateResponse> GetImageTranslateAsync(GetImageTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageTranslateWithOptionsAsync(request, runtime);
        }

        public GetImageTranslateTaskResponse GetImageTranslateTaskWithOptions(GetImageTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImageTranslateTaskResponse>(DoRPCRequest("GetImageTranslateTask", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetImageTranslateTaskResponse> GetImageTranslateTaskWithOptionsAsync(GetImageTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImageTranslateTaskResponse>(await DoRPCRequestAsync("GetImageTranslateTask", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetImageTranslateTaskResponse GetImageTranslateTask(GetImageTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageTranslateTaskWithOptions(request, runtime);
        }

        public async Task<GetImageTranslateTaskResponse> GetImageTranslateTaskAsync(GetImageTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageTranslateTaskWithOptionsAsync(request, runtime);
        }

        public GetTitleDiagnoseResponse GetTitleDiagnoseWithOptions(GetTitleDiagnoseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTitleDiagnoseResponse>(DoRPCRequest("GetTitleDiagnose", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTitleDiagnoseResponse> GetTitleDiagnoseWithOptionsAsync(GetTitleDiagnoseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTitleDiagnoseResponse>(await DoRPCRequestAsync("GetTitleDiagnose", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTitleDiagnoseResponse GetTitleDiagnose(GetTitleDiagnoseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTitleDiagnoseWithOptions(request, runtime);
        }

        public async Task<GetTitleDiagnoseResponse> GetTitleDiagnoseAsync(GetTitleDiagnoseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTitleDiagnoseWithOptionsAsync(request, runtime);
        }

        public GetTitleGenerateResponse GetTitleGenerateWithOptions(GetTitleGenerateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTitleGenerateResponse>(DoRPCRequest("GetTitleGenerate", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTitleGenerateResponse> GetTitleGenerateWithOptionsAsync(GetTitleGenerateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTitleGenerateResponse>(await DoRPCRequestAsync("GetTitleGenerate", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTitleGenerateResponse GetTitleGenerate(GetTitleGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTitleGenerateWithOptions(request, runtime);
        }

        public async Task<GetTitleGenerateResponse> GetTitleGenerateAsync(GetTitleGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTitleGenerateWithOptionsAsync(request, runtime);
        }

        public GetTitleIntelligenceResponse GetTitleIntelligenceWithOptions(GetTitleIntelligenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTitleIntelligenceResponse>(DoRPCRequest("GetTitleIntelligence", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTitleIntelligenceResponse> GetTitleIntelligenceWithOptionsAsync(GetTitleIntelligenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTitleIntelligenceResponse>(await DoRPCRequestAsync("GetTitleIntelligence", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTitleIntelligenceResponse GetTitleIntelligence(GetTitleIntelligenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTitleIntelligenceWithOptions(request, runtime);
        }

        public async Task<GetTitleIntelligenceResponse> GetTitleIntelligenceAsync(GetTitleIntelligenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTitleIntelligenceWithOptionsAsync(request, runtime);
        }

        public GetTranslateReportResponse GetTranslateReportWithOptions(GetTranslateReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTranslateReportResponse>(DoRPCRequest("GetTranslateReport", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTranslateReportResponse> GetTranslateReportWithOptionsAsync(GetTranslateReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTranslateReportResponse>(await DoRPCRequestAsync("GetTranslateReport", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTranslateReportResponse GetTranslateReport(GetTranslateReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTranslateReportWithOptions(request, runtime);
        }

        public async Task<GetTranslateReportResponse> GetTranslateReportAsync(GetTranslateReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTranslateReportWithOptionsAsync(request, runtime);
        }

        public GetUserResponse GetUserWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetUserResponse>(DoRPCRequest("GetUser", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetUserResponse>(await DoRPCRequestAsync("GetUser", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserResponse GetUser()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserWithOptions(runtime);
        }

        public async Task<GetUserResponse> GetUserAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserWithOptionsAsync(runtime);
        }

        public OpenAlimtServiceResponse OpenAlimtServiceWithOptions(OpenAlimtServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenAlimtServiceResponse>(DoRPCRequest("OpenAlimtService", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenAlimtServiceResponse> OpenAlimtServiceWithOptionsAsync(OpenAlimtServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenAlimtServiceResponse>(await DoRPCRequestAsync("OpenAlimtService", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenAlimtServiceResponse OpenAlimtService(OpenAlimtServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenAlimtServiceWithOptions(request, runtime);
        }

        public async Task<OpenAlimtServiceResponse> OpenAlimtServiceAsync(OpenAlimtServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenAlimtServiceWithOptionsAsync(request, runtime);
        }

        public TranslateResponse TranslateWithOptions(TranslateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TranslateResponse>(DoRPCRequest("Translate", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TranslateResponse> TranslateWithOptionsAsync(TranslateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TranslateResponse>(await DoRPCRequestAsync("Translate", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TranslateResponse Translate(TranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TranslateWithOptions(request, runtime);
        }

        public async Task<TranslateResponse> TranslateAsync(TranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TranslateWithOptionsAsync(request, runtime);
        }

        public TranslateCertificateResponse TranslateCertificateWithOptions(TranslateCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TranslateCertificateResponse>(DoRPCRequest("TranslateCertificate", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TranslateCertificateResponse> TranslateCertificateWithOptionsAsync(TranslateCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TranslateCertificateResponse>(await DoRPCRequestAsync("TranslateCertificate", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TranslateCertificateResponse TranslateCertificate(TranslateCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TranslateCertificateWithOptions(request, runtime);
        }

        public async Task<TranslateCertificateResponse> TranslateCertificateAsync(TranslateCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TranslateCertificateWithOptionsAsync(request, runtime);
        }

        public TranslateCertificateResponse TranslateCertificateAdvance(TranslateCertificateAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "alimt",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            TranslateCertificateRequest translateCertificateReq = new TranslateCertificateRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, translateCertificateReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.ObjectKey,
                    Content = request.ImageUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.AccessKeyId,
                    Policy = authResponse.EncodedPolicy,
                    Signature = authResponse.Signature,
                    Key = authResponse.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Bucket,
                    Header = ossHeader,
                };
                ossClient.PostObject(uploadRequest, ossRuntime);
                translateCertificateReq.ImageUrl = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            }
            TranslateCertificateResponse translateCertificateResp = TranslateCertificateWithOptions(translateCertificateReq, runtime);
            return translateCertificateResp;
        }

        public async Task<TranslateCertificateResponse> TranslateCertificateAdvanceAsync(TranslateCertificateAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "alimt",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            TranslateCertificateRequest translateCertificateReq = new TranslateCertificateRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, translateCertificateReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.ObjectKey,
                    Content = request.ImageUrlObject,
                    ContentType = "",
                };
                ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
                {
                    AccessKeyId = authResponse.AccessKeyId,
                    Policy = authResponse.EncodedPolicy,
                    Signature = authResponse.Signature,
                    Key = authResponse.ObjectKey,
                    File = fileObj,
                    SuccessActionStatus = "201",
                };
                uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
                {
                    BucketName = authResponse.Bucket,
                    Header = ossHeader,
                };
                await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
                translateCertificateReq.ImageUrl = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            }
            TranslateCertificateResponse translateCertificateResp = await TranslateCertificateWithOptionsAsync(translateCertificateReq, runtime);
            return translateCertificateResp;
        }

        public TranslateECommerceResponse TranslateECommerceWithOptions(TranslateECommerceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TranslateECommerceResponse>(DoRPCRequest("TranslateECommerce", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TranslateECommerceResponse> TranslateECommerceWithOptionsAsync(TranslateECommerceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TranslateECommerceResponse>(await DoRPCRequestAsync("TranslateECommerce", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TranslateECommerceResponse TranslateECommerce(TranslateECommerceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TranslateECommerceWithOptions(request, runtime);
        }

        public async Task<TranslateECommerceResponse> TranslateECommerceAsync(TranslateECommerceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TranslateECommerceWithOptionsAsync(request, runtime);
        }

        public TranslateGeneralResponse TranslateGeneralWithOptions(TranslateGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TranslateGeneralResponse>(DoRPCRequest("TranslateGeneral", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TranslateGeneralResponse> TranslateGeneralWithOptionsAsync(TranslateGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TranslateGeneralResponse>(await DoRPCRequestAsync("TranslateGeneral", "2018-10-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TranslateGeneralResponse TranslateGeneral(TranslateGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TranslateGeneralWithOptions(request, runtime);
        }

        public async Task<TranslateGeneralResponse> TranslateGeneralAsync(TranslateGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TranslateGeneralWithOptionsAsync(request, runtime);
        }

    }
}
