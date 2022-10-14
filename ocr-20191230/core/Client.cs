// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ocr20191230.Models;

namespace AlibabaCloud.SDK.Ocr20191230
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ocr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DetectCardScreenshotResponse DetectCardScreenshotWithOptions(DetectCardScreenshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectCardScreenshot",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectCardScreenshotResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetectCardScreenshotResponse> DetectCardScreenshotWithOptionsAsync(DetectCardScreenshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetectCardScreenshot",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetectCardScreenshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetectCardScreenshotResponse DetectCardScreenshot(DetectCardScreenshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectCardScreenshotWithOptions(request, runtime);
        }

        public async Task<DetectCardScreenshotResponse> DetectCardScreenshotAsync(DetectCardScreenshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectCardScreenshotWithOptionsAsync(request, runtime);
        }

        public DetectCardScreenshotResponse DetectCardScreenshotAdvance(DetectCardScreenshotAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            DetectCardScreenshotRequest detectCardScreenshotReq = new DetectCardScreenshotRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectCardScreenshotReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                detectCardScreenshotReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            DetectCardScreenshotResponse detectCardScreenshotResp = DetectCardScreenshotWithOptions(detectCardScreenshotReq, runtime);
            return detectCardScreenshotResp;
        }

        public async Task<DetectCardScreenshotResponse> DetectCardScreenshotAdvanceAsync(DetectCardScreenshotAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            DetectCardScreenshotRequest detectCardScreenshotReq = new DetectCardScreenshotRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, detectCardScreenshotReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                detectCardScreenshotReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            DetectCardScreenshotResponse detectCardScreenshotResp = await DetectCardScreenshotWithOptionsAsync(detectCardScreenshotReq, runtime);
            return detectCardScreenshotResp;
        }

        public GetAsyncJobResultResponse GetAsyncJobResultWithOptions(GetAsyncJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncJobResult",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncJobResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAsyncJobResultResponse> GetAsyncJobResultWithOptionsAsync(GetAsyncJobResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                body["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAsyncJobResult",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAsyncJobResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAsyncJobResultResponse GetAsyncJobResult(GetAsyncJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAsyncJobResultWithOptions(request, runtime);
        }

        public async Task<GetAsyncJobResultResponse> GetAsyncJobResultAsync(GetAsyncJobResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAsyncJobResultWithOptionsAsync(request, runtime);
        }

        public RecognizeAccountPageResponse RecognizeAccountPageWithOptions(RecognizeAccountPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAccountPage",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAccountPageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeAccountPageResponse> RecognizeAccountPageWithOptionsAsync(RecognizeAccountPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeAccountPage",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeAccountPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeAccountPageResponse RecognizeAccountPage(RecognizeAccountPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeAccountPageWithOptions(request, runtime);
        }

        public async Task<RecognizeAccountPageResponse> RecognizeAccountPageAsync(RecognizeAccountPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeAccountPageWithOptionsAsync(request, runtime);
        }

        public RecognizeAccountPageResponse RecognizeAccountPageAdvance(RecognizeAccountPageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeAccountPageRequest recognizeAccountPageReq = new RecognizeAccountPageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeAccountPageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeAccountPageReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeAccountPageResponse recognizeAccountPageResp = RecognizeAccountPageWithOptions(recognizeAccountPageReq, runtime);
            return recognizeAccountPageResp;
        }

        public async Task<RecognizeAccountPageResponse> RecognizeAccountPageAdvanceAsync(RecognizeAccountPageAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeAccountPageRequest recognizeAccountPageReq = new RecognizeAccountPageRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeAccountPageReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeAccountPageReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeAccountPageResponse recognizeAccountPageResp = await RecognizeAccountPageWithOptionsAsync(recognizeAccountPageReq, runtime);
            return recognizeAccountPageResp;
        }

        public RecognizeBankCardResponse RecognizeBankCardWithOptions(RecognizeBankCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeBankCardResponse> RecognizeBankCardWithOptionsAsync(RecognizeBankCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBankCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBankCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeBankCardResponse RecognizeBankCard(RecognizeBankCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBankCardWithOptions(request, runtime);
        }

        public async Task<RecognizeBankCardResponse> RecognizeBankCardAsync(RecognizeBankCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBankCardWithOptionsAsync(request, runtime);
        }

        public RecognizeBankCardResponse RecognizeBankCardAdvance(RecognizeBankCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeBankCardRequest recognizeBankCardReq = new RecognizeBankCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeBankCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeBankCardReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeBankCardResponse recognizeBankCardResp = RecognizeBankCardWithOptions(recognizeBankCardReq, runtime);
            return recognizeBankCardResp;
        }

        public async Task<RecognizeBankCardResponse> RecognizeBankCardAdvanceAsync(RecognizeBankCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeBankCardRequest recognizeBankCardReq = new RecognizeBankCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeBankCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeBankCardReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeBankCardResponse recognizeBankCardResp = await RecognizeBankCardWithOptionsAsync(recognizeBankCardReq, runtime);
            return recognizeBankCardResp;
        }

        public RecognizeBusinessCardResponse RecognizeBusinessCardWithOptions(RecognizeBusinessCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBusinessCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBusinessCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeBusinessCardResponse> RecognizeBusinessCardWithOptionsAsync(RecognizeBusinessCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBusinessCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBusinessCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeBusinessCardResponse RecognizeBusinessCard(RecognizeBusinessCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBusinessCardWithOptions(request, runtime);
        }

        public async Task<RecognizeBusinessCardResponse> RecognizeBusinessCardAsync(RecognizeBusinessCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBusinessCardWithOptionsAsync(request, runtime);
        }

        public RecognizeBusinessCardResponse RecognizeBusinessCardAdvance(RecognizeBusinessCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeBusinessCardRequest recognizeBusinessCardReq = new RecognizeBusinessCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeBusinessCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeBusinessCardReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeBusinessCardResponse recognizeBusinessCardResp = RecognizeBusinessCardWithOptions(recognizeBusinessCardReq, runtime);
            return recognizeBusinessCardResp;
        }

        public async Task<RecognizeBusinessCardResponse> RecognizeBusinessCardAdvanceAsync(RecognizeBusinessCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeBusinessCardRequest recognizeBusinessCardReq = new RecognizeBusinessCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeBusinessCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeBusinessCardReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeBusinessCardResponse recognizeBusinessCardResp = await RecognizeBusinessCardWithOptionsAsync(recognizeBusinessCardReq, runtime);
            return recognizeBusinessCardResp;
        }

        public RecognizeBusinessLicenseResponse RecognizeBusinessLicenseWithOptions(RecognizeBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBusinessLicense",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBusinessLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeBusinessLicenseResponse> RecognizeBusinessLicenseWithOptionsAsync(RecognizeBusinessLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeBusinessLicense",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeBusinessLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeBusinessLicenseResponse RecognizeBusinessLicense(RecognizeBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeBusinessLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeBusinessLicenseResponse> RecognizeBusinessLicenseAsync(RecognizeBusinessLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeBusinessLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeBusinessLicenseResponse RecognizeBusinessLicenseAdvance(RecognizeBusinessLicenseAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeBusinessLicenseRequest recognizeBusinessLicenseReq = new RecognizeBusinessLicenseRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeBusinessLicenseReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeBusinessLicenseReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeBusinessLicenseResponse recognizeBusinessLicenseResp = RecognizeBusinessLicenseWithOptions(recognizeBusinessLicenseReq, runtime);
            return recognizeBusinessLicenseResp;
        }

        public async Task<RecognizeBusinessLicenseResponse> RecognizeBusinessLicenseAdvanceAsync(RecognizeBusinessLicenseAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeBusinessLicenseRequest recognizeBusinessLicenseReq = new RecognizeBusinessLicenseRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeBusinessLicenseReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeBusinessLicenseReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeBusinessLicenseResponse recognizeBusinessLicenseResp = await RecognizeBusinessLicenseWithOptionsAsync(recognizeBusinessLicenseReq, runtime);
            return recognizeBusinessLicenseResp;
        }

        public RecognizeCharacterResponse RecognizeCharacterWithOptions(RecognizeCharacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHeight))
            {
                body["MinHeight"] = request.MinHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputProbability))
            {
                body["OutputProbability"] = request.OutputProbability;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCharacter",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCharacterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeCharacterResponse> RecognizeCharacterWithOptionsAsync(RecognizeCharacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinHeight))
            {
                body["MinHeight"] = request.MinHeight;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputProbability))
            {
                body["OutputProbability"] = request.OutputProbability;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeCharacter",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeCharacterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeCharacterResponse RecognizeCharacter(RecognizeCharacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeCharacterWithOptions(request, runtime);
        }

        public async Task<RecognizeCharacterResponse> RecognizeCharacterAsync(RecognizeCharacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeCharacterWithOptionsAsync(request, runtime);
        }

        public RecognizeCharacterResponse RecognizeCharacterAdvance(RecognizeCharacterAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeCharacterRequest recognizeCharacterReq = new RecognizeCharacterRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeCharacterReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeCharacterReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeCharacterResponse recognizeCharacterResp = RecognizeCharacterWithOptions(recognizeCharacterReq, runtime);
            return recognizeCharacterResp;
        }

        public async Task<RecognizeCharacterResponse> RecognizeCharacterAdvanceAsync(RecognizeCharacterAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeCharacterRequest recognizeCharacterReq = new RecognizeCharacterRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeCharacterReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeCharacterReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeCharacterResponse recognizeCharacterResp = await RecognizeCharacterWithOptionsAsync(recognizeCharacterReq, runtime);
            return recognizeCharacterResp;
        }

        public RecognizeChinapassportResponse RecognizeChinapassportWithOptions(RecognizeChinapassportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeChinapassport",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeChinapassportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeChinapassportResponse> RecognizeChinapassportWithOptionsAsync(RecognizeChinapassportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeChinapassport",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeChinapassportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeChinapassportResponse RecognizeChinapassport(RecognizeChinapassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeChinapassportWithOptions(request, runtime);
        }

        public async Task<RecognizeChinapassportResponse> RecognizeChinapassportAsync(RecognizeChinapassportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeChinapassportWithOptionsAsync(request, runtime);
        }

        public RecognizeChinapassportResponse RecognizeChinapassportAdvance(RecognizeChinapassportAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeChinapassportRequest recognizeChinapassportReq = new RecognizeChinapassportRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeChinapassportReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeChinapassportReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeChinapassportResponse recognizeChinapassportResp = RecognizeChinapassportWithOptions(recognizeChinapassportReq, runtime);
            return recognizeChinapassportResp;
        }

        public async Task<RecognizeChinapassportResponse> RecognizeChinapassportAdvanceAsync(RecognizeChinapassportAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeChinapassportRequest recognizeChinapassportReq = new RecognizeChinapassportRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeChinapassportReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeChinapassportReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeChinapassportResponse recognizeChinapassportResp = await RecognizeChinapassportWithOptionsAsync(recognizeChinapassportReq, runtime);
            return recognizeChinapassportResp;
        }

        public RecognizeDriverLicenseResponse RecognizeDriverLicenseWithOptions(RecognizeDriverLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                body["Side"] = request.Side;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeDriverLicense",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeDriverLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeDriverLicenseResponse> RecognizeDriverLicenseWithOptionsAsync(RecognizeDriverLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                body["Side"] = request.Side;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeDriverLicense",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeDriverLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeDriverLicenseResponse RecognizeDriverLicense(RecognizeDriverLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeDriverLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeDriverLicenseResponse> RecognizeDriverLicenseAsync(RecognizeDriverLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeDriverLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeDriverLicenseResponse RecognizeDriverLicenseAdvance(RecognizeDriverLicenseAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeDriverLicenseRequest recognizeDriverLicenseReq = new RecognizeDriverLicenseRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeDriverLicenseReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeDriverLicenseReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeDriverLicenseResponse recognizeDriverLicenseResp = RecognizeDriverLicenseWithOptions(recognizeDriverLicenseReq, runtime);
            return recognizeDriverLicenseResp;
        }

        public async Task<RecognizeDriverLicenseResponse> RecognizeDriverLicenseAdvanceAsync(RecognizeDriverLicenseAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeDriverLicenseRequest recognizeDriverLicenseReq = new RecognizeDriverLicenseRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeDriverLicenseReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeDriverLicenseReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeDriverLicenseResponse recognizeDriverLicenseResp = await RecognizeDriverLicenseWithOptionsAsync(recognizeDriverLicenseReq, runtime);
            return recognizeDriverLicenseResp;
        }

        public RecognizeDrivingLicenseResponse RecognizeDrivingLicenseWithOptions(RecognizeDrivingLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                body["Side"] = request.Side;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeDrivingLicense",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeDrivingLicenseResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeDrivingLicenseResponse> RecognizeDrivingLicenseWithOptionsAsync(RecognizeDrivingLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                body["Side"] = request.Side;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeDrivingLicense",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeDrivingLicenseResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeDrivingLicenseResponse RecognizeDrivingLicense(RecognizeDrivingLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeDrivingLicenseWithOptions(request, runtime);
        }

        public async Task<RecognizeDrivingLicenseResponse> RecognizeDrivingLicenseAsync(RecognizeDrivingLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeDrivingLicenseWithOptionsAsync(request, runtime);
        }

        public RecognizeDrivingLicenseResponse RecognizeDrivingLicenseAdvance(RecognizeDrivingLicenseAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeDrivingLicenseRequest recognizeDrivingLicenseReq = new RecognizeDrivingLicenseRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeDrivingLicenseReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeDrivingLicenseReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeDrivingLicenseResponse recognizeDrivingLicenseResp = RecognizeDrivingLicenseWithOptions(recognizeDrivingLicenseReq, runtime);
            return recognizeDrivingLicenseResp;
        }

        public async Task<RecognizeDrivingLicenseResponse> RecognizeDrivingLicenseAdvanceAsync(RecognizeDrivingLicenseAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeDrivingLicenseRequest recognizeDrivingLicenseReq = new RecognizeDrivingLicenseRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeDrivingLicenseReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeDrivingLicenseReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeDrivingLicenseResponse recognizeDrivingLicenseResp = await RecognizeDrivingLicenseWithOptionsAsync(recognizeDrivingLicenseReq, runtime);
            return recognizeDrivingLicenseResp;
        }

        public RecognizeIdentityCardResponse RecognizeIdentityCardWithOptions(RecognizeIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                body["Side"] = request.Side;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeIdentityCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeIdentityCardResponse> RecognizeIdentityCardWithOptionsAsync(RecognizeIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Side))
            {
                body["Side"] = request.Side;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeIdentityCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeIdentityCardResponse RecognizeIdentityCard(RecognizeIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeIdentityCardWithOptions(request, runtime);
        }

        public async Task<RecognizeIdentityCardResponse> RecognizeIdentityCardAsync(RecognizeIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeIdentityCardWithOptionsAsync(request, runtime);
        }

        public RecognizeIdentityCardResponse RecognizeIdentityCardAdvance(RecognizeIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeIdentityCardRequest recognizeIdentityCardReq = new RecognizeIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeIdentityCardReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeIdentityCardResponse recognizeIdentityCardResp = RecognizeIdentityCardWithOptions(recognizeIdentityCardReq, runtime);
            return recognizeIdentityCardResp;
        }

        public async Task<RecognizeIdentityCardResponse> RecognizeIdentityCardAdvanceAsync(RecognizeIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeIdentityCardRequest recognizeIdentityCardReq = new RecognizeIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeIdentityCardReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeIdentityCardResponse recognizeIdentityCardResp = await RecognizeIdentityCardWithOptionsAsync(recognizeIdentityCardReq, runtime);
            return recognizeIdentityCardResp;
        }

        public RecognizeIndonesiaIdentityCardResponse RecognizeIndonesiaIdentityCardWithOptions(RecognizeIndonesiaIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeIndonesiaIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeIndonesiaIdentityCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeIndonesiaIdentityCardResponse> RecognizeIndonesiaIdentityCardWithOptionsAsync(RecognizeIndonesiaIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeIndonesiaIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeIndonesiaIdentityCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeIndonesiaIdentityCardResponse RecognizeIndonesiaIdentityCard(RecognizeIndonesiaIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeIndonesiaIdentityCardWithOptions(request, runtime);
        }

        public async Task<RecognizeIndonesiaIdentityCardResponse> RecognizeIndonesiaIdentityCardAsync(RecognizeIndonesiaIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeIndonesiaIdentityCardWithOptionsAsync(request, runtime);
        }

        public RecognizeIndonesiaIdentityCardResponse RecognizeIndonesiaIdentityCardAdvance(RecognizeIndonesiaIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeIndonesiaIdentityCardRequest recognizeIndonesiaIdentityCardReq = new RecognizeIndonesiaIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeIndonesiaIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageUrlObject,
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
                recognizeIndonesiaIdentityCardReq.ImageUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeIndonesiaIdentityCardResponse recognizeIndonesiaIdentityCardResp = RecognizeIndonesiaIdentityCardWithOptions(recognizeIndonesiaIdentityCardReq, runtime);
            return recognizeIndonesiaIdentityCardResp;
        }

        public async Task<RecognizeIndonesiaIdentityCardResponse> RecognizeIndonesiaIdentityCardAdvanceAsync(RecognizeIndonesiaIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeIndonesiaIdentityCardRequest recognizeIndonesiaIdentityCardReq = new RecognizeIndonesiaIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeIndonesiaIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageUrlObject,
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
                recognizeIndonesiaIdentityCardReq.ImageUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeIndonesiaIdentityCardResponse recognizeIndonesiaIdentityCardResp = await RecognizeIndonesiaIdentityCardWithOptionsAsync(recognizeIndonesiaIdentityCardReq, runtime);
            return recognizeIndonesiaIdentityCardResp;
        }

        public RecognizeLicensePlateResponse RecognizeLicensePlateWithOptions(RecognizeLicensePlateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeLicensePlate",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeLicensePlateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeLicensePlateResponse> RecognizeLicensePlateWithOptionsAsync(RecognizeLicensePlateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeLicensePlate",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeLicensePlateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeLicensePlateResponse RecognizeLicensePlate(RecognizeLicensePlateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeLicensePlateWithOptions(request, runtime);
        }

        public async Task<RecognizeLicensePlateResponse> RecognizeLicensePlateAsync(RecognizeLicensePlateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeLicensePlateWithOptionsAsync(request, runtime);
        }

        public RecognizeLicensePlateResponse RecognizeLicensePlateAdvance(RecognizeLicensePlateAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeLicensePlateRequest recognizeLicensePlateReq = new RecognizeLicensePlateRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeLicensePlateReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeLicensePlateReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeLicensePlateResponse recognizeLicensePlateResp = RecognizeLicensePlateWithOptions(recognizeLicensePlateReq, runtime);
            return recognizeLicensePlateResp;
        }

        public async Task<RecognizeLicensePlateResponse> RecognizeLicensePlateAdvanceAsync(RecognizeLicensePlateAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeLicensePlateRequest recognizeLicensePlateReq = new RecognizeLicensePlateRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeLicensePlateReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeLicensePlateReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeLicensePlateResponse recognizeLicensePlateResp = await RecognizeLicensePlateWithOptionsAsync(recognizeLicensePlateReq, runtime);
            return recognizeLicensePlateResp;
        }

        public RecognizeMalaysiaIdentityCardResponse RecognizeMalaysiaIdentityCardWithOptions(RecognizeMalaysiaIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMalaysiaIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMalaysiaIdentityCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeMalaysiaIdentityCardResponse> RecognizeMalaysiaIdentityCardWithOptionsAsync(RecognizeMalaysiaIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeMalaysiaIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeMalaysiaIdentityCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeMalaysiaIdentityCardResponse RecognizeMalaysiaIdentityCard(RecognizeMalaysiaIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeMalaysiaIdentityCardWithOptions(request, runtime);
        }

        public async Task<RecognizeMalaysiaIdentityCardResponse> RecognizeMalaysiaIdentityCardAsync(RecognizeMalaysiaIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeMalaysiaIdentityCardWithOptionsAsync(request, runtime);
        }

        public RecognizeMalaysiaIdentityCardResponse RecognizeMalaysiaIdentityCardAdvance(RecognizeMalaysiaIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeMalaysiaIdentityCardRequest recognizeMalaysiaIdentityCardReq = new RecognizeMalaysiaIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeMalaysiaIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageUrlObject,
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
                recognizeMalaysiaIdentityCardReq.ImageUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeMalaysiaIdentityCardResponse recognizeMalaysiaIdentityCardResp = RecognizeMalaysiaIdentityCardWithOptions(recognizeMalaysiaIdentityCardReq, runtime);
            return recognizeMalaysiaIdentityCardResp;
        }

        public async Task<RecognizeMalaysiaIdentityCardResponse> RecognizeMalaysiaIdentityCardAdvanceAsync(RecognizeMalaysiaIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeMalaysiaIdentityCardRequest recognizeMalaysiaIdentityCardReq = new RecognizeMalaysiaIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeMalaysiaIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageUrlObject,
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
                recognizeMalaysiaIdentityCardReq.ImageUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeMalaysiaIdentityCardResponse recognizeMalaysiaIdentityCardResp = await RecognizeMalaysiaIdentityCardWithOptionsAsync(recognizeMalaysiaIdentityCardReq, runtime);
            return recognizeMalaysiaIdentityCardResp;
        }

        public RecognizePassportMRZResponse RecognizePassportMRZWithOptions(RecognizePassportMRZRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePassportMRZ",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePassportMRZResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizePassportMRZResponse> RecognizePassportMRZWithOptionsAsync(RecognizePassportMRZRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePassportMRZ",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePassportMRZResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizePassportMRZResponse RecognizePassportMRZ(RecognizePassportMRZRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePassportMRZWithOptions(request, runtime);
        }

        public async Task<RecognizePassportMRZResponse> RecognizePassportMRZAsync(RecognizePassportMRZRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePassportMRZWithOptionsAsync(request, runtime);
        }

        public RecognizePassportMRZResponse RecognizePassportMRZAdvance(RecognizePassportMRZAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizePassportMRZRequest recognizePassportMRZReq = new RecognizePassportMRZRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizePassportMRZReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizePassportMRZReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizePassportMRZResponse recognizePassportMRZResp = RecognizePassportMRZWithOptions(recognizePassportMRZReq, runtime);
            return recognizePassportMRZResp;
        }

        public async Task<RecognizePassportMRZResponse> RecognizePassportMRZAdvanceAsync(RecognizePassportMRZAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizePassportMRZRequest recognizePassportMRZReq = new RecognizePassportMRZRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizePassportMRZReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizePassportMRZReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizePassportMRZResponse recognizePassportMRZResp = await RecognizePassportMRZWithOptionsAsync(recognizePassportMRZReq, runtime);
            return recognizePassportMRZResp;
        }

        public RecognizePdfResponse RecognizePdfWithOptions(RecognizePdfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURL))
            {
                body["FileURL"] = request.FileURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePdf",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePdfResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizePdfResponse> RecognizePdfWithOptionsAsync(RecognizePdfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURL))
            {
                body["FileURL"] = request.FileURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePdf",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePdfResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizePdfResponse RecognizePdf(RecognizePdfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePdfWithOptions(request, runtime);
        }

        public async Task<RecognizePdfResponse> RecognizePdfAsync(RecognizePdfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePdfWithOptionsAsync(request, runtime);
        }

        public RecognizePdfResponse RecognizePdfAdvance(RecognizePdfAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizePdfRequest recognizePdfReq = new RecognizePdfRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizePdfReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileURLObject,
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
                recognizePdfReq.FileURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizePdfResponse recognizePdfResp = RecognizePdfWithOptions(recognizePdfReq, runtime);
            return recognizePdfResp;
        }

        public async Task<RecognizePdfResponse> RecognizePdfAdvanceAsync(RecognizePdfAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizePdfRequest recognizePdfReq = new RecognizePdfRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizePdfReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileURLObject,
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
                recognizePdfReq.FileURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizePdfResponse recognizePdfResp = await RecognizePdfWithOptionsAsync(recognizePdfReq, runtime);
            return recognizePdfResp;
        }

        public RecognizePoiNameResponse RecognizePoiNameWithOptions(RecognizePoiNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePoiName",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePoiNameResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizePoiNameResponse> RecognizePoiNameWithOptionsAsync(RecognizePoiNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizePoiName",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizePoiNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizePoiNameResponse RecognizePoiName(RecognizePoiNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizePoiNameWithOptions(request, runtime);
        }

        public async Task<RecognizePoiNameResponse> RecognizePoiNameAsync(RecognizePoiNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizePoiNameWithOptionsAsync(request, runtime);
        }

        public RecognizePoiNameResponse RecognizePoiNameAdvance(RecognizePoiNameAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizePoiNameRequest recognizePoiNameReq = new RecognizePoiNameRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizePoiNameReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizePoiNameReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizePoiNameResponse recognizePoiNameResp = RecognizePoiNameWithOptions(recognizePoiNameReq, runtime);
            return recognizePoiNameResp;
        }

        public async Task<RecognizePoiNameResponse> RecognizePoiNameAdvanceAsync(RecognizePoiNameAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizePoiNameRequest recognizePoiNameReq = new RecognizePoiNameRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizePoiNameReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizePoiNameReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizePoiNameResponse recognizePoiNameResp = await RecognizePoiNameWithOptionsAsync(recognizePoiNameReq, runtime);
            return recognizePoiNameResp;
        }

        public RecognizeQrCodeResponse RecognizeQrCodeWithOptions(RecognizeQrCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tasks))
            {
                body["Tasks"] = request.Tasks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeQrCode",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeQrCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeQrCodeResponse> RecognizeQrCodeWithOptionsAsync(RecognizeQrCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tasks))
            {
                body["Tasks"] = request.Tasks;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeQrCode",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeQrCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeQrCodeResponse RecognizeQrCode(RecognizeQrCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeQrCodeWithOptions(request, runtime);
        }

        public async Task<RecognizeQrCodeResponse> RecognizeQrCodeAsync(RecognizeQrCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeQrCodeWithOptionsAsync(request, runtime);
        }

        public RecognizeQuotaInvoiceResponse RecognizeQuotaInvoiceWithOptions(RecognizeQuotaInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeQuotaInvoice",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeQuotaInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeQuotaInvoiceResponse> RecognizeQuotaInvoiceWithOptionsAsync(RecognizeQuotaInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeQuotaInvoice",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeQuotaInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeQuotaInvoiceResponse RecognizeQuotaInvoice(RecognizeQuotaInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeQuotaInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeQuotaInvoiceResponse> RecognizeQuotaInvoiceAsync(RecognizeQuotaInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeQuotaInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizeQuotaInvoiceResponse RecognizeQuotaInvoiceAdvance(RecognizeQuotaInvoiceAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeQuotaInvoiceRequest recognizeQuotaInvoiceReq = new RecognizeQuotaInvoiceRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeQuotaInvoiceReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeQuotaInvoiceReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeQuotaInvoiceResponse recognizeQuotaInvoiceResp = RecognizeQuotaInvoiceWithOptions(recognizeQuotaInvoiceReq, runtime);
            return recognizeQuotaInvoiceResp;
        }

        public async Task<RecognizeQuotaInvoiceResponse> RecognizeQuotaInvoiceAdvanceAsync(RecognizeQuotaInvoiceAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeQuotaInvoiceRequest recognizeQuotaInvoiceReq = new RecognizeQuotaInvoiceRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeQuotaInvoiceReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeQuotaInvoiceReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeQuotaInvoiceResponse recognizeQuotaInvoiceResp = await RecognizeQuotaInvoiceWithOptionsAsync(recognizeQuotaInvoiceReq, runtime);
            return recognizeQuotaInvoiceResp;
        }

        public RecognizeRussiaIdentityCardResponse RecognizeRussiaIdentityCardWithOptions(RecognizeRussiaIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRussiaIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRussiaIdentityCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeRussiaIdentityCardResponse> RecognizeRussiaIdentityCardWithOptionsAsync(RecognizeRussiaIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeRussiaIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeRussiaIdentityCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeRussiaIdentityCardResponse RecognizeRussiaIdentityCard(RecognizeRussiaIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeRussiaIdentityCardWithOptions(request, runtime);
        }

        public async Task<RecognizeRussiaIdentityCardResponse> RecognizeRussiaIdentityCardAsync(RecognizeRussiaIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeRussiaIdentityCardWithOptionsAsync(request, runtime);
        }

        public RecognizeRussiaIdentityCardResponse RecognizeRussiaIdentityCardAdvance(RecognizeRussiaIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeRussiaIdentityCardRequest recognizeRussiaIdentityCardReq = new RecognizeRussiaIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeRussiaIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageUrlObject,
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
                recognizeRussiaIdentityCardReq.ImageUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeRussiaIdentityCardResponse recognizeRussiaIdentityCardResp = RecognizeRussiaIdentityCardWithOptions(recognizeRussiaIdentityCardReq, runtime);
            return recognizeRussiaIdentityCardResp;
        }

        public async Task<RecognizeRussiaIdentityCardResponse> RecognizeRussiaIdentityCardAdvanceAsync(RecognizeRussiaIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeRussiaIdentityCardRequest recognizeRussiaIdentityCardReq = new RecognizeRussiaIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeRussiaIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageUrlObject,
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
                recognizeRussiaIdentityCardReq.ImageUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeRussiaIdentityCardResponse recognizeRussiaIdentityCardResp = await RecognizeRussiaIdentityCardWithOptionsAsync(recognizeRussiaIdentityCardReq, runtime);
            return recognizeRussiaIdentityCardResp;
        }

        public RecognizeStampResponse RecognizeStampWithOptions(RecognizeStampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeStamp",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeStampResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeStampResponse> RecognizeStampWithOptionsAsync(RecognizeStampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeStamp",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeStampResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeStampResponse RecognizeStamp(RecognizeStampRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeStampWithOptions(request, runtime);
        }

        public async Task<RecognizeStampResponse> RecognizeStampAsync(RecognizeStampRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeStampWithOptionsAsync(request, runtime);
        }

        public RecognizeStampResponse RecognizeStampAdvance(RecognizeStampAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeStampRequest recognizeStampReq = new RecognizeStampRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeStampReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeStampReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeStampResponse recognizeStampResp = RecognizeStampWithOptions(recognizeStampReq, runtime);
            return recognizeStampResp;
        }

        public async Task<RecognizeStampResponse> RecognizeStampAdvanceAsync(RecognizeStampAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeStampRequest recognizeStampReq = new RecognizeStampRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeStampReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeStampReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeStampResponse recognizeStampResp = await RecognizeStampWithOptionsAsync(recognizeStampReq, runtime);
            return recognizeStampResp;
        }

        public RecognizeTableResponse RecognizeTableWithOptions(RecognizeTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssureDirection))
            {
                body["AssureDirection"] = request.AssureDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasLine))
            {
                body["HasLine"] = request.HasLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["OutputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDetection))
            {
                body["SkipDetection"] = request.SkipDetection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseFinanceModel))
            {
                body["UseFinanceModel"] = request.UseFinanceModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTable",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeTableResponse> RecognizeTableWithOptionsAsync(RecognizeTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssureDirection))
            {
                body["AssureDirection"] = request.AssureDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasLine))
            {
                body["HasLine"] = request.HasLine;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputFormat))
            {
                body["OutputFormat"] = request.OutputFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipDetection))
            {
                body["SkipDetection"] = request.SkipDetection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseFinanceModel))
            {
                body["UseFinanceModel"] = request.UseFinanceModel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTable",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeTableResponse RecognizeTable(RecognizeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTableWithOptions(request, runtime);
        }

        public async Task<RecognizeTableResponse> RecognizeTableAsync(RecognizeTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTableWithOptionsAsync(request, runtime);
        }

        public RecognizeTableResponse RecognizeTableAdvance(RecognizeTableAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeTableRequest recognizeTableReq = new RecognizeTableRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeTableReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeTableReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeTableResponse recognizeTableResp = RecognizeTableWithOptions(recognizeTableReq, runtime);
            return recognizeTableResp;
        }

        public async Task<RecognizeTableResponse> RecognizeTableAdvanceAsync(RecognizeTableAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeTableRequest recognizeTableReq = new RecognizeTableRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeTableReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeTableReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeTableResponse recognizeTableResp = await RecognizeTableWithOptionsAsync(recognizeTableReq, runtime);
            return recognizeTableResp;
        }

        public RecognizeTakeoutOrderResponse RecognizeTakeoutOrderWithOptions(RecognizeTakeoutOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTakeoutOrder",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTakeoutOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeTakeoutOrderResponse> RecognizeTakeoutOrderWithOptionsAsync(RecognizeTakeoutOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTakeoutOrder",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTakeoutOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeTakeoutOrderResponse RecognizeTakeoutOrder(RecognizeTakeoutOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTakeoutOrderWithOptions(request, runtime);
        }

        public async Task<RecognizeTakeoutOrderResponse> RecognizeTakeoutOrderAsync(RecognizeTakeoutOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTakeoutOrderWithOptionsAsync(request, runtime);
        }

        public RecognizeTakeoutOrderResponse RecognizeTakeoutOrderAdvance(RecognizeTakeoutOrderAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeTakeoutOrderRequest recognizeTakeoutOrderReq = new RecognizeTakeoutOrderRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeTakeoutOrderReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeTakeoutOrderReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeTakeoutOrderResponse recognizeTakeoutOrderResp = RecognizeTakeoutOrderWithOptions(recognizeTakeoutOrderReq, runtime);
            return recognizeTakeoutOrderResp;
        }

        public async Task<RecognizeTakeoutOrderResponse> RecognizeTakeoutOrderAdvanceAsync(RecognizeTakeoutOrderAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeTakeoutOrderRequest recognizeTakeoutOrderReq = new RecognizeTakeoutOrderRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeTakeoutOrderReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeTakeoutOrderReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeTakeoutOrderResponse recognizeTakeoutOrderResp = await RecognizeTakeoutOrderWithOptionsAsync(recognizeTakeoutOrderReq, runtime);
            return recognizeTakeoutOrderResp;
        }

        public RecognizeTaxiInvoiceResponse RecognizeTaxiInvoiceWithOptions(RecognizeTaxiInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTaxiInvoice",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTaxiInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeTaxiInvoiceResponse> RecognizeTaxiInvoiceWithOptionsAsync(RecognizeTaxiInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTaxiInvoice",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTaxiInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeTaxiInvoiceResponse RecognizeTaxiInvoice(RecognizeTaxiInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTaxiInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeTaxiInvoiceResponse> RecognizeTaxiInvoiceAsync(RecognizeTaxiInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTaxiInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizeTaxiInvoiceResponse RecognizeTaxiInvoiceAdvance(RecognizeTaxiInvoiceAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeTaxiInvoiceRequest recognizeTaxiInvoiceReq = new RecognizeTaxiInvoiceRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeTaxiInvoiceReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeTaxiInvoiceReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeTaxiInvoiceResponse recognizeTaxiInvoiceResp = RecognizeTaxiInvoiceWithOptions(recognizeTaxiInvoiceReq, runtime);
            return recognizeTaxiInvoiceResp;
        }

        public async Task<RecognizeTaxiInvoiceResponse> RecognizeTaxiInvoiceAdvanceAsync(RecognizeTaxiInvoiceAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeTaxiInvoiceRequest recognizeTaxiInvoiceReq = new RecognizeTaxiInvoiceRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeTaxiInvoiceReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeTaxiInvoiceReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeTaxiInvoiceResponse recognizeTaxiInvoiceResp = await RecognizeTaxiInvoiceWithOptionsAsync(recognizeTaxiInvoiceReq, runtime);
            return recognizeTaxiInvoiceResp;
        }

        public RecognizeTicketInvoiceResponse RecognizeTicketInvoiceWithOptions(RecognizeTicketInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTicketInvoice",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTicketInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeTicketInvoiceResponse> RecognizeTicketInvoiceWithOptionsAsync(RecognizeTicketInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTicketInvoice",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTicketInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeTicketInvoiceResponse RecognizeTicketInvoice(RecognizeTicketInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTicketInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeTicketInvoiceResponse> RecognizeTicketInvoiceAsync(RecognizeTicketInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTicketInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizeTicketInvoiceResponse RecognizeTicketInvoiceAdvance(RecognizeTicketInvoiceAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeTicketInvoiceRequest recognizeTicketInvoiceReq = new RecognizeTicketInvoiceRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeTicketInvoiceReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeTicketInvoiceReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeTicketInvoiceResponse recognizeTicketInvoiceResp = RecognizeTicketInvoiceWithOptions(recognizeTicketInvoiceReq, runtime);
            return recognizeTicketInvoiceResp;
        }

        public async Task<RecognizeTicketInvoiceResponse> RecognizeTicketInvoiceAdvanceAsync(RecognizeTicketInvoiceAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeTicketInvoiceRequest recognizeTicketInvoiceReq = new RecognizeTicketInvoiceRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeTicketInvoiceReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeTicketInvoiceReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeTicketInvoiceResponse recognizeTicketInvoiceResp = await RecognizeTicketInvoiceWithOptionsAsync(recognizeTicketInvoiceReq, runtime);
            return recognizeTicketInvoiceResp;
        }

        public RecognizeTrainTicketResponse RecognizeTrainTicketWithOptions(RecognizeTrainTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTrainTicket",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTrainTicketResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeTrainTicketResponse> RecognizeTrainTicketWithOptionsAsync(RecognizeTrainTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTrainTicket",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTrainTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeTrainTicketResponse RecognizeTrainTicket(RecognizeTrainTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTrainTicketWithOptions(request, runtime);
        }

        public async Task<RecognizeTrainTicketResponse> RecognizeTrainTicketAsync(RecognizeTrainTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTrainTicketWithOptionsAsync(request, runtime);
        }

        public RecognizeTrainTicketResponse RecognizeTrainTicketAdvance(RecognizeTrainTicketAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeTrainTicketRequest recognizeTrainTicketReq = new RecognizeTrainTicketRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeTrainTicketReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeTrainTicketReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeTrainTicketResponse recognizeTrainTicketResp = RecognizeTrainTicketWithOptions(recognizeTrainTicketReq, runtime);
            return recognizeTrainTicketResp;
        }

        public async Task<RecognizeTrainTicketResponse> RecognizeTrainTicketAdvanceAsync(RecognizeTrainTicketAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeTrainTicketRequest recognizeTrainTicketReq = new RecognizeTrainTicketRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeTrainTicketReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeTrainTicketReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeTrainTicketResponse recognizeTrainTicketResp = await RecognizeTrainTicketWithOptionsAsync(recognizeTrainTicketReq, runtime);
            return recognizeTrainTicketResp;
        }

        public RecognizeTurkeyIdentityCardResponse RecognizeTurkeyIdentityCardWithOptions(RecognizeTurkeyIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTurkeyIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTurkeyIdentityCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeTurkeyIdentityCardResponse> RecognizeTurkeyIdentityCardWithOptionsAsync(RecognizeTurkeyIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeTurkeyIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeTurkeyIdentityCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeTurkeyIdentityCardResponse RecognizeTurkeyIdentityCard(RecognizeTurkeyIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeTurkeyIdentityCardWithOptions(request, runtime);
        }

        public async Task<RecognizeTurkeyIdentityCardResponse> RecognizeTurkeyIdentityCardAsync(RecognizeTurkeyIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeTurkeyIdentityCardWithOptionsAsync(request, runtime);
        }

        public RecognizeTurkeyIdentityCardResponse RecognizeTurkeyIdentityCardAdvance(RecognizeTurkeyIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeTurkeyIdentityCardRequest recognizeTurkeyIdentityCardReq = new RecognizeTurkeyIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeTurkeyIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageUrlObject,
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
                recognizeTurkeyIdentityCardReq.ImageUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeTurkeyIdentityCardResponse recognizeTurkeyIdentityCardResp = RecognizeTurkeyIdentityCardWithOptions(recognizeTurkeyIdentityCardReq, runtime);
            return recognizeTurkeyIdentityCardResp;
        }

        public async Task<RecognizeTurkeyIdentityCardResponse> RecognizeTurkeyIdentityCardAdvanceAsync(RecognizeTurkeyIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeTurkeyIdentityCardRequest recognizeTurkeyIdentityCardReq = new RecognizeTurkeyIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeTurkeyIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageUrlObject,
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
                recognizeTurkeyIdentityCardReq.ImageUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeTurkeyIdentityCardResponse recognizeTurkeyIdentityCardResp = await RecognizeTurkeyIdentityCardWithOptionsAsync(recognizeTurkeyIdentityCardReq, runtime);
            return recognizeTurkeyIdentityCardResp;
        }

        public RecognizeUkraineIdentityCardResponse RecognizeUkraineIdentityCardWithOptions(RecognizeUkraineIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeUkraineIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeUkraineIdentityCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeUkraineIdentityCardResponse> RecognizeUkraineIdentityCardWithOptionsAsync(RecognizeUkraineIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeUkraineIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeUkraineIdentityCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeUkraineIdentityCardResponse RecognizeUkraineIdentityCard(RecognizeUkraineIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeUkraineIdentityCardWithOptions(request, runtime);
        }

        public async Task<RecognizeUkraineIdentityCardResponse> RecognizeUkraineIdentityCardAsync(RecognizeUkraineIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeUkraineIdentityCardWithOptionsAsync(request, runtime);
        }

        public RecognizeUkraineIdentityCardResponse RecognizeUkraineIdentityCardAdvance(RecognizeUkraineIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeUkraineIdentityCardRequest recognizeUkraineIdentityCardReq = new RecognizeUkraineIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeUkraineIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageUrlObject,
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
                recognizeUkraineIdentityCardReq.ImageUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeUkraineIdentityCardResponse recognizeUkraineIdentityCardResp = RecognizeUkraineIdentityCardWithOptions(recognizeUkraineIdentityCardReq, runtime);
            return recognizeUkraineIdentityCardResp;
        }

        public async Task<RecognizeUkraineIdentityCardResponse> RecognizeUkraineIdentityCardAdvanceAsync(RecognizeUkraineIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeUkraineIdentityCardRequest recognizeUkraineIdentityCardReq = new RecognizeUkraineIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeUkraineIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageUrlObject,
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
                recognizeUkraineIdentityCardReq.ImageUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeUkraineIdentityCardResponse recognizeUkraineIdentityCardResp = await RecognizeUkraineIdentityCardWithOptionsAsync(recognizeUkraineIdentityCardReq, runtime);
            return recognizeUkraineIdentityCardResp;
        }

        public RecognizeVATInvoiceResponse RecognizeVATInvoiceWithOptions(RecognizeVATInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURL))
            {
                body["FileURL"] = request.FileURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVATInvoice",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVATInvoiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeVATInvoiceResponse> RecognizeVATInvoiceWithOptionsAsync(RecognizeVATInvoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURL))
            {
                body["FileURL"] = request.FileURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVATInvoice",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVATInvoiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeVATInvoiceResponse RecognizeVATInvoice(RecognizeVATInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVATInvoiceWithOptions(request, runtime);
        }

        public async Task<RecognizeVATInvoiceResponse> RecognizeVATInvoiceAsync(RecognizeVATInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVATInvoiceWithOptionsAsync(request, runtime);
        }

        public RecognizeVATInvoiceResponse RecognizeVATInvoiceAdvance(RecognizeVATInvoiceAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeVATInvoiceRequest recognizeVATInvoiceReq = new RecognizeVATInvoiceRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeVATInvoiceReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileURLObject,
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
                recognizeVATInvoiceReq.FileURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeVATInvoiceResponse recognizeVATInvoiceResp = RecognizeVATInvoiceWithOptions(recognizeVATInvoiceReq, runtime);
            return recognizeVATInvoiceResp;
        }

        public async Task<RecognizeVATInvoiceResponse> RecognizeVATInvoiceAdvanceAsync(RecognizeVATInvoiceAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeVATInvoiceRequest recognizeVATInvoiceReq = new RecognizeVATInvoiceRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeVATInvoiceReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileURLObject,
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
                recognizeVATInvoiceReq.FileURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeVATInvoiceResponse recognizeVATInvoiceResp = await RecognizeVATInvoiceWithOptionsAsync(recognizeVATInvoiceReq, runtime);
            return recognizeVATInvoiceResp;
        }

        public RecognizeVINCodeResponse RecognizeVINCodeWithOptions(RecognizeVINCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                query["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVINCode",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVINCodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeVINCodeResponse> RecognizeVINCodeWithOptionsAsync(RecognizeVINCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                query["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVINCode",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVINCodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeVINCodeResponse RecognizeVINCode(RecognizeVINCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVINCodeWithOptions(request, runtime);
        }

        public async Task<RecognizeVINCodeResponse> RecognizeVINCodeAsync(RecognizeVINCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVINCodeWithOptionsAsync(request, runtime);
        }

        public RecognizeVINCodeResponse RecognizeVINCodeAdvance(RecognizeVINCodeAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeVINCodeRequest recognizeVINCodeReq = new RecognizeVINCodeRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeVINCodeReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeVINCodeReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeVINCodeResponse recognizeVINCodeResp = RecognizeVINCodeWithOptions(recognizeVINCodeReq, runtime);
            return recognizeVINCodeResp;
        }

        public async Task<RecognizeVINCodeResponse> RecognizeVINCodeAdvanceAsync(RecognizeVINCodeAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeVINCodeRequest recognizeVINCodeReq = new RecognizeVINCodeRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeVINCodeReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeVINCodeReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeVINCodeResponse recognizeVINCodeResp = await RecognizeVINCodeWithOptionsAsync(recognizeVINCodeReq, runtime);
            return recognizeVINCodeResp;
        }

        public RecognizeVerificationcodeResponse RecognizeVerificationcodeWithOptions(RecognizeVerificationcodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVerificationcode",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVerificationcodeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeVerificationcodeResponse> RecognizeVerificationcodeWithOptionsAsync(RecognizeVerificationcodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURL))
            {
                body["ImageURL"] = request.ImageURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVerificationcode",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVerificationcodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeVerificationcodeResponse RecognizeVerificationcode(RecognizeVerificationcodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVerificationcodeWithOptions(request, runtime);
        }

        public async Task<RecognizeVerificationcodeResponse> RecognizeVerificationcodeAsync(RecognizeVerificationcodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVerificationcodeWithOptionsAsync(request, runtime);
        }

        public RecognizeVerificationcodeResponse RecognizeVerificationcodeAdvance(RecognizeVerificationcodeAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeVerificationcodeRequest recognizeVerificationcodeReq = new RecognizeVerificationcodeRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeVerificationcodeReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeVerificationcodeReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeVerificationcodeResponse recognizeVerificationcodeResp = RecognizeVerificationcodeWithOptions(recognizeVerificationcodeReq, runtime);
            return recognizeVerificationcodeResp;
        }

        public async Task<RecognizeVerificationcodeResponse> RecognizeVerificationcodeAdvanceAsync(RecognizeVerificationcodeAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeVerificationcodeRequest recognizeVerificationcodeReq = new RecognizeVerificationcodeRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeVerificationcodeReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageURLObject,
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
                recognizeVerificationcodeReq.ImageURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeVerificationcodeResponse recognizeVerificationcodeResp = await RecognizeVerificationcodeWithOptionsAsync(recognizeVerificationcodeReq, runtime);
            return recognizeVerificationcodeResp;
        }

        public RecognizeVideoCastCrewListResponse RecognizeVideoCastCrewListWithOptions(RecognizeVideoCastCrewListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecognizeVideoCastCrewListShrinkRequest request = new RecognizeVideoCastCrewListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "Params", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                body["Params"] = request.ParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterUrl))
            {
                body["RegisterUrl"] = request.RegisterUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrl))
            {
                body["VideoUrl"] = request.VideoUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVideoCastCrewList",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVideoCastCrewListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeVideoCastCrewListResponse> RecognizeVideoCastCrewListWithOptionsAsync(RecognizeVideoCastCrewListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RecognizeVideoCastCrewListShrinkRequest request = new RecognizeVideoCastCrewListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Params))
            {
                request.ParamsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Params, "Params", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParamsShrink))
            {
                body["Params"] = request.ParamsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterUrl))
            {
                body["RegisterUrl"] = request.RegisterUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrl))
            {
                body["VideoUrl"] = request.VideoUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVideoCastCrewList",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVideoCastCrewListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeVideoCastCrewListResponse RecognizeVideoCastCrewList(RecognizeVideoCastCrewListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVideoCastCrewListWithOptions(request, runtime);
        }

        public async Task<RecognizeVideoCastCrewListResponse> RecognizeVideoCastCrewListAsync(RecognizeVideoCastCrewListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVideoCastCrewListWithOptionsAsync(request, runtime);
        }

        public RecognizeVideoCastCrewListResponse RecognizeVideoCastCrewListAdvance(RecognizeVideoCastCrewListAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeVideoCastCrewListRequest recognizeVideoCastCrewListReq = new RecognizeVideoCastCrewListRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeVideoCastCrewListReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.VideoUrlObject,
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
                recognizeVideoCastCrewListReq.VideoUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeVideoCastCrewListResponse recognizeVideoCastCrewListResp = RecognizeVideoCastCrewListWithOptions(recognizeVideoCastCrewListReq, runtime);
            return recognizeVideoCastCrewListResp;
        }

        public async Task<RecognizeVideoCastCrewListResponse> RecognizeVideoCastCrewListAdvanceAsync(RecognizeVideoCastCrewListAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeVideoCastCrewListRequest recognizeVideoCastCrewListReq = new RecognizeVideoCastCrewListRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeVideoCastCrewListReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.VideoUrlObject,
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
                recognizeVideoCastCrewListReq.VideoUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeVideoCastCrewListResponse recognizeVideoCastCrewListResp = await RecognizeVideoCastCrewListWithOptionsAsync(recognizeVideoCastCrewListReq, runtime);
            return recognizeVideoCastCrewListResp;
        }

        public RecognizeVideoCharacterResponse RecognizeVideoCharacterWithOptions(RecognizeVideoCharacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoURL))
            {
                body["VideoURL"] = request.VideoURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVideoCharacter",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVideoCharacterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeVideoCharacterResponse> RecognizeVideoCharacterWithOptionsAsync(RecognizeVideoCharacterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoURL))
            {
                body["VideoURL"] = request.VideoURL;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVideoCharacter",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVideoCharacterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeVideoCharacterResponse RecognizeVideoCharacter(RecognizeVideoCharacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVideoCharacterWithOptions(request, runtime);
        }

        public async Task<RecognizeVideoCharacterResponse> RecognizeVideoCharacterAsync(RecognizeVideoCharacterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVideoCharacterWithOptionsAsync(request, runtime);
        }

        public RecognizeVietnamIdentityCardResponse RecognizeVietnamIdentityCardWithOptions(RecognizeVietnamIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVietnamIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVietnamIdentityCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RecognizeVietnamIdentityCardResponse> RecognizeVietnamIdentityCardWithOptionsAsync(RecognizeVietnamIdentityCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecognizeVietnamIdentityCard",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecognizeVietnamIdentityCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RecognizeVietnamIdentityCardResponse RecognizeVietnamIdentityCard(RecognizeVietnamIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeVietnamIdentityCardWithOptions(request, runtime);
        }

        public async Task<RecognizeVietnamIdentityCardResponse> RecognizeVietnamIdentityCardAsync(RecognizeVietnamIdentityCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeVietnamIdentityCardWithOptionsAsync(request, runtime);
        }

        public RecognizeVietnamIdentityCardResponse RecognizeVietnamIdentityCardAdvance(RecognizeVietnamIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeVietnamIdentityCardRequest recognizeVietnamIdentityCardReq = new RecognizeVietnamIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeVietnamIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageUrlObject,
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
                recognizeVietnamIdentityCardReq.ImageUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeVietnamIdentityCardResponse recognizeVietnamIdentityCardResp = RecognizeVietnamIdentityCardWithOptions(recognizeVietnamIdentityCardReq, runtime);
            return recognizeVietnamIdentityCardResp;
        }

        public async Task<RecognizeVietnamIdentityCardResponse> RecognizeVietnamIdentityCardAdvanceAsync(RecognizeVietnamIdentityCardAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            RecognizeVietnamIdentityCardRequest recognizeVietnamIdentityCardReq = new RecognizeVietnamIdentityCardRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, recognizeVietnamIdentityCardReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrlObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.ImageUrlObject,
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
                recognizeVietnamIdentityCardReq.ImageUrl = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            RecognizeVietnamIdentityCardResponse recognizeVietnamIdentityCardResp = await RecognizeVietnamIdentityCardWithOptionsAsync(recognizeVietnamIdentityCardReq, runtime);
            return recognizeVietnamIdentityCardResp;
        }

        public TrimDocumentResponse TrimDocumentWithOptions(TrimDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURL))
            {
                body["FileURL"] = request.FileURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputType))
            {
                body["OutputType"] = request.OutputType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrimDocument",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrimDocumentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TrimDocumentResponse> TrimDocumentWithOptionsAsync(TrimDocumentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileType))
            {
                body["FileType"] = request.FileType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURL))
            {
                body["FileURL"] = request.FileURL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutputType))
            {
                body["OutputType"] = request.OutputType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TrimDocument",
                Version = "2019-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TrimDocumentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TrimDocumentResponse TrimDocument(TrimDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TrimDocumentWithOptions(request, runtime);
        }

        public async Task<TrimDocumentResponse> TrimDocumentAsync(TrimDocumentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TrimDocumentWithOptionsAsync(request, runtime);
        }

        public TrimDocumentResponse TrimDocumentAdvance(TrimDocumentAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            TrimDocumentRequest trimDocumentReq = new TrimDocumentRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, trimDocumentReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURLObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileURLObject,
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
                trimDocumentReq.FileURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            TrimDocumentResponse trimDocumentResp = TrimDocumentWithOptions(trimDocumentReq, runtime);
            return trimDocumentResp;
        }

        public async Task<TrimDocumentResponse> TrimDocumentAdvanceAsync(TrimDocumentAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            string openPlatformEndpoint = _openPlatformEndpoint;
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
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
                Product = "ocr",
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
            TrimDocumentRequest trimDocumentReq = new TrimDocumentRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, trimDocumentReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileURLObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.Body.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Body.Endpoint, authResponse.Body.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.Body.ObjectKey,
                    Content = request.FileURLObject,
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
                trimDocumentReq.FileURL = "http://" + authResponse.Body.Bucket + "." + authResponse.Body.Endpoint + "/" + authResponse.Body.ObjectKey;
            }
            TrimDocumentResponse trimDocumentResp = await TrimDocumentWithOptionsAsync(trimDocumentReq, runtime);
            return trimDocumentResp;
        }

    }
}
