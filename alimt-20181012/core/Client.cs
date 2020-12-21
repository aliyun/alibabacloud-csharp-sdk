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
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
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


        public OpenAlimtServiceResponse OpenAlimtService(OpenAlimtServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<OpenAlimtServiceResponse>(DoRequest("OpenAlimtService", "HTTPS", "POST", "2018-10-12", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<OpenAlimtServiceResponse> OpenAlimtServiceAsync(OpenAlimtServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<OpenAlimtServiceResponse>(await DoRequestAsync("OpenAlimtService", "HTTPS", "POST", "2018-10-12", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public OpenAlimtServiceResponse OpenAlimtServiceSimply(OpenAlimtServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenAlimtService(request, runtime);
        }

        public async Task<OpenAlimtServiceResponse> OpenAlimtServiceSimplyAsync(OpenAlimtServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenAlimtServiceAsync(request, runtime);
        }

        public CreateImageTranslateTaskResponse CreateImageTranslateTask(CreateImageTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateImageTranslateTaskResponse>(DoRequest("CreateImageTranslateTask", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateImageTranslateTaskResponse> CreateImageTranslateTaskAsync(CreateImageTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateImageTranslateTaskResponse>(await DoRequestAsync("CreateImageTranslateTask", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public CreateImageTranslateTaskResponse CreateImageTranslateTaskSimply(CreateImageTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageTranslateTask(request, runtime);
        }

        public async Task<CreateImageTranslateTaskResponse> CreateImageTranslateTaskSimplyAsync(CreateImageTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageTranslateTaskAsync(request, runtime);
        }

        public GetImageTranslateTaskResponse GetImageTranslateTask(GetImageTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetImageTranslateTaskResponse>(DoRequest("GetImageTranslateTask", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetImageTranslateTaskResponse> GetImageTranslateTaskAsync(GetImageTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetImageTranslateTaskResponse>(await DoRequestAsync("GetImageTranslateTask", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public GetImageTranslateTaskResponse GetImageTranslateTaskSimply(GetImageTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageTranslateTask(request, runtime);
        }

        public async Task<GetImageTranslateTaskResponse> GetImageTranslateTaskSimplyAsync(GetImageTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageTranslateTaskAsync(request, runtime);
        }

        public GetTitleIntelligenceResponse GetTitleIntelligence(GetTitleIntelligenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTitleIntelligenceResponse>(DoRequest("GetTitleIntelligence", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetTitleIntelligenceResponse> GetTitleIntelligenceAsync(GetTitleIntelligenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTitleIntelligenceResponse>(await DoRequestAsync("GetTitleIntelligence", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public GetTitleIntelligenceResponse GetTitleIntelligenceSimply(GetTitleIntelligenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTitleIntelligence(request, runtime);
        }

        public async Task<GetTitleIntelligenceResponse> GetTitleIntelligenceSimplyAsync(GetTitleIntelligenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTitleIntelligenceAsync(request, runtime);
        }

        public GetTitleGenerateResponse GetTitleGenerate(GetTitleGenerateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTitleGenerateResponse>(DoRequest("GetTitleGenerate", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetTitleGenerateResponse> GetTitleGenerateAsync(GetTitleGenerateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTitleGenerateResponse>(await DoRequestAsync("GetTitleGenerate", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public GetTitleGenerateResponse GetTitleGenerateSimply(GetTitleGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTitleGenerate(request, runtime);
        }

        public async Task<GetTitleGenerateResponse> GetTitleGenerateSimplyAsync(GetTitleGenerateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTitleGenerateAsync(request, runtime);
        }

        public GetTitleDiagnoseResponse GetTitleDiagnose(GetTitleDiagnoseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTitleDiagnoseResponse>(DoRequest("GetTitleDiagnose", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetTitleDiagnoseResponse> GetTitleDiagnoseAsync(GetTitleDiagnoseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTitleDiagnoseResponse>(await DoRequestAsync("GetTitleDiagnose", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public GetTitleDiagnoseResponse GetTitleDiagnoseSimply(GetTitleDiagnoseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTitleDiagnose(request, runtime);
        }

        public async Task<GetTitleDiagnoseResponse> GetTitleDiagnoseSimplyAsync(GetTitleDiagnoseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTitleDiagnoseAsync(request, runtime);
        }

        public GetImageDiagnoseResponse GetImageDiagnose(GetImageDiagnoseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetImageDiagnoseResponse>(DoRequest("GetImageDiagnose", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetImageDiagnoseResponse> GetImageDiagnoseAsync(GetImageDiagnoseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetImageDiagnoseResponse>(await DoRequestAsync("GetImageDiagnose", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public GetImageDiagnoseResponse GetImageDiagnoseSimply(GetImageDiagnoseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageDiagnose(request, runtime);
        }

        public async Task<GetImageDiagnoseResponse> GetImageDiagnoseSimplyAsync(GetImageDiagnoseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageDiagnoseAsync(request, runtime);
        }

        public GetImageTranslateResponse GetImageTranslate(GetImageTranslateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetImageTranslateResponse>(DoRequest("GetImageTranslate", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetImageTranslateResponse> GetImageTranslateAsync(GetImageTranslateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetImageTranslateResponse>(await DoRequestAsync("GetImageTranslate", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public GetImageTranslateResponse GetImageTranslateSimply(GetImageTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImageTranslate(request, runtime);
        }

        public async Task<GetImageTranslateResponse> GetImageTranslateSimplyAsync(GetImageTranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImageTranslateAsync(request, runtime);
        }

        public GetDetectLanguageResponse GetDetectLanguage(GetDetectLanguageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDetectLanguageResponse>(DoRequest("GetDetectLanguage", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDetectLanguageResponse> GetDetectLanguageAsync(GetDetectLanguageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDetectLanguageResponse>(await DoRequestAsync("GetDetectLanguage", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public GetDetectLanguageResponse GetDetectLanguageSimply(GetDetectLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDetectLanguage(request, runtime);
        }

        public async Task<GetDetectLanguageResponse> GetDetectLanguageSimplyAsync(GetDetectLanguageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDetectLanguageAsync(request, runtime);
        }

        public TranslateCertificateResponse TranslateCertificate(TranslateCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TranslateCertificateResponse>(DoRequest("TranslateCertificate", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TranslateCertificateResponse> TranslateCertificateAsync(TranslateCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TranslateCertificateResponse>(await DoRequestAsync("TranslateCertificate", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public TranslateCertificateResponse TranslateCertificateSimply(TranslateCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TranslateCertificate(request, runtime);
        }

        public async Task<TranslateCertificateResponse> TranslateCertificateSimplyAsync(TranslateCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TranslateCertificateAsync(request, runtime);
        }

        public TranslateCertificateResponse TranslateCertificateAdvance(TranslateCertificateAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = "openplatform.aliyuncs.com",
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
            AlibabaCloud.Commons.Common.Convert(runtime, ossRuntime);
            TranslateCertificateRequest translateCertificateReq = new TranslateCertificateRequest();
            AlibabaCloud.Commons.Common.Convert(request, translateCertificateReq);
            authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
            ossConfig.AccessKeyId = authResponse.AccessKeyId;
            ossConfig.Endpoint = AlibabaCloud.Commons.Common.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
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
            TranslateCertificateResponse translateCertificateResp = TranslateCertificate(translateCertificateReq, runtime);
            return translateCertificateResp;
        }

        public async Task<TranslateCertificateResponse> TranslateCertificateAdvanceAsync(TranslateCertificateAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = "openplatform.aliyuncs.com",
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
            AlibabaCloud.Commons.Common.Convert(runtime, ossRuntime);
            TranslateCertificateRequest translateCertificateReq = new TranslateCertificateRequest();
            AlibabaCloud.Commons.Common.Convert(request, translateCertificateReq);
            authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
            ossConfig.AccessKeyId = authResponse.AccessKeyId;
            ossConfig.Endpoint = AlibabaCloud.Commons.Common.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
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
            TranslateCertificateResponse translateCertificateResp = await TranslateCertificateAsync(translateCertificateReq, runtime);
            return translateCertificateResp;
        }

        public TranslateResponse Translate(TranslateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TranslateResponse>(DoRequest("Translate", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TranslateResponse> TranslateAsync(TranslateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TranslateResponse>(await DoRequestAsync("Translate", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public TranslateResponse TranslateSimply(TranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return Translate(request, runtime);
        }

        public async Task<TranslateResponse> TranslateSimplyAsync(TranslateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TranslateAsync(request, runtime);
        }

        public CreateDocTranslateTaskResponse CreateDocTranslateTask(CreateDocTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDocTranslateTaskResponse>(DoRequest("CreateDocTranslateTask", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDocTranslateTaskResponse> CreateDocTranslateTaskAsync(CreateDocTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDocTranslateTaskResponse>(await DoRequestAsync("CreateDocTranslateTask", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public CreateDocTranslateTaskResponse CreateDocTranslateTaskSimply(CreateDocTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDocTranslateTask(request, runtime);
        }

        public async Task<CreateDocTranslateTaskResponse> CreateDocTranslateTaskSimplyAsync(CreateDocTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDocTranslateTaskAsync(request, runtime);
        }

        public CreateDocTranslateTaskResponse CreateDocTranslateTaskAdvance(CreateDocTranslateTaskAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = "openplatform.aliyuncs.com",
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
            AlibabaCloud.Commons.Common.Convert(runtime, ossRuntime);
            CreateDocTranslateTaskRequest createDocTranslateTaskReq = new CreateDocTranslateTaskRequest();
            AlibabaCloud.Commons.Common.Convert(request, createDocTranslateTaskReq);
            authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
            ossConfig.AccessKeyId = authResponse.AccessKeyId;
            ossConfig.Endpoint = AlibabaCloud.Commons.Common.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
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
            CreateDocTranslateTaskResponse createDocTranslateTaskResp = CreateDocTranslateTask(createDocTranslateTaskReq, runtime);
            return createDocTranslateTaskResp;
        }

        public async Task<CreateDocTranslateTaskResponse> CreateDocTranslateTaskAdvanceAsync(CreateDocTranslateTaskAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = "openplatform.aliyuncs.com",
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
            AlibabaCloud.Commons.Common.Convert(runtime, ossRuntime);
            CreateDocTranslateTaskRequest createDocTranslateTaskReq = new CreateDocTranslateTaskRequest();
            AlibabaCloud.Commons.Common.Convert(request, createDocTranslateTaskReq);
            authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
            ossConfig.AccessKeyId = authResponse.AccessKeyId;
            ossConfig.Endpoint = AlibabaCloud.Commons.Common.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
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
            CreateDocTranslateTaskResponse createDocTranslateTaskResp = await CreateDocTranslateTaskAsync(createDocTranslateTaskReq, runtime);
            return createDocTranslateTaskResp;
        }

        public GetDocTranslateTaskResponse GetDocTranslateTask(GetDocTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDocTranslateTaskResponse>(DoRequest("GetDocTranslateTask", "HTTPS", "GET", "2018-10-12", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetDocTranslateTaskResponse> GetDocTranslateTaskAsync(GetDocTranslateTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDocTranslateTaskResponse>(await DoRequestAsync("GetDocTranslateTask", "HTTPS", "GET", "2018-10-12", "AK", request.ToMap(), null, runtime));
        }

        public GetDocTranslateTaskResponse GetDocTranslateTaskSimply(GetDocTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDocTranslateTask(request, runtime);
        }

        public async Task<GetDocTranslateTaskResponse> GetDocTranslateTaskSimplyAsync(GetDocTranslateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDocTranslateTaskAsync(request, runtime);
        }

        public TranslateGeneralResponse TranslateGeneral(TranslateGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TranslateGeneralResponse>(DoRequest("TranslateGeneral", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TranslateGeneralResponse> TranslateGeneralAsync(TranslateGeneralRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TranslateGeneralResponse>(await DoRequestAsync("TranslateGeneral", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public TranslateGeneralResponse TranslateGeneralSimply(TranslateGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TranslateGeneral(request, runtime);
        }

        public async Task<TranslateGeneralResponse> TranslateGeneralSimplyAsync(TranslateGeneralRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TranslateGeneralAsync(request, runtime);
        }

        public TranslateECommerceResponse TranslateECommerce(TranslateECommerceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TranslateECommerceResponse>(DoRequest("TranslateECommerce", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TranslateECommerceResponse> TranslateECommerceAsync(TranslateECommerceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TranslateECommerceResponse>(await DoRequestAsync("TranslateECommerce", "HTTPS", "POST", "2018-10-12", "AK", null, request.ToMap(), runtime));
        }

        public TranslateECommerceResponse TranslateECommerceSimply(TranslateECommerceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TranslateECommerce(request, runtime);
        }

        public async Task<TranslateECommerceResponse> TranslateECommerceSimplyAsync(TranslateECommerceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TranslateECommerceAsync(request, runtime);
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

    }
}
