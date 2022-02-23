// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudauth20190307.Models;

namespace AlibabaCloud.SDK.Cloudauth20190307
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudauth", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public CompareFaceVerifyResponse CompareFaceVerify(CompareFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CompareFaceVerifyResponse>(DoRequest("CompareFaceVerify", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CompareFaceVerifyResponse> CompareFaceVerifyAsync(CompareFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CompareFaceVerifyResponse>(await DoRequestAsync("CompareFaceVerify", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public CompareFaceVerifyResponse CompareFaceVerifySimply(CompareFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompareFaceVerify(request, runtime);
        }

        public async Task<CompareFaceVerifyResponse> CompareFaceVerifySimplyAsync(CompareFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompareFaceVerifyAsync(request, runtime);
        }

        public CompareFacesResponse CompareFaces(CompareFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CompareFacesResponse>(DoRequest("CompareFaces", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CompareFacesResponse> CompareFacesAsync(CompareFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CompareFacesResponse>(await DoRequestAsync("CompareFaces", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public CompareFacesResponse CompareFacesSimply(CompareFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompareFaces(request, runtime);
        }

        public async Task<CompareFacesResponse> CompareFacesSimplyAsync(CompareFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompareFacesAsync(request, runtime);
        }

        public ContrastFaceVerifyResponse ContrastFaceVerify(ContrastFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ContrastFaceVerifyResponse>(DoRequest("ContrastFaceVerify", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ContrastFaceVerifyResponse> ContrastFaceVerifyAsync(ContrastFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ContrastFaceVerifyResponse>(await DoRequestAsync("ContrastFaceVerify", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public ContrastFaceVerifyResponse ContrastFaceVerifySimply(ContrastFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContrastFaceVerify(request, runtime);
        }

        public async Task<ContrastFaceVerifyResponse> ContrastFaceVerifySimplyAsync(ContrastFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContrastFaceVerifyAsync(request, runtime);
        }

        public ContrastFaceVerifyResponse ContrastFaceVerifyAdvance(ContrastFaceVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string openPlatformEndpoint = _openPlatformEndpoint;
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
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
                Product = "Cloudauth",
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
            ContrastFaceVerifyRequest contrastFaceVerifyReq = new ContrastFaceVerifyRequest();
            AlibabaCloud.Commons.Common.Convert(request, contrastFaceVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastFileObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.Commons.Common.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.ObjectKey,
                    Content = request.FaceContrastFileObject,
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
                contrastFaceVerifyReq.FaceContrastFile = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            }
            ContrastFaceVerifyResponse contrastFaceVerifyResp = ContrastFaceVerify(contrastFaceVerifyReq, runtime);
            return contrastFaceVerifyResp;
        }

        public async Task<ContrastFaceVerifyResponse> ContrastFaceVerifyAdvanceAsync(ContrastFaceVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string openPlatformEndpoint = _openPlatformEndpoint;
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
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
                Product = "Cloudauth",
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
            ContrastFaceVerifyRequest contrastFaceVerifyReq = new ContrastFaceVerifyRequest();
            AlibabaCloud.Commons.Common.Convert(request, contrastFaceVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastFileObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.Commons.Common.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.ObjectKey,
                    Content = request.FaceContrastFileObject,
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
                contrastFaceVerifyReq.FaceContrastFile = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            }
            ContrastFaceVerifyResponse contrastFaceVerifyResp = await ContrastFaceVerifyAsync(contrastFaceVerifyReq, runtime);
            return contrastFaceVerifyResp;
        }

        public CreateAuthKeyResponse CreateAuthKey(CreateAuthKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateAuthKeyResponse>(DoRequest("CreateAuthKey", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateAuthKeyResponse> CreateAuthKeyAsync(CreateAuthKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateAuthKeyResponse>(await DoRequestAsync("CreateAuthKey", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public CreateAuthKeyResponse CreateAuthKeySimply(CreateAuthKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAuthKey(request, runtime);
        }

        public async Task<CreateAuthKeyResponse> CreateAuthKeySimplyAsync(CreateAuthKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAuthKeyAsync(request, runtime);
        }

        public CreateVerifySettingResponse CreateVerifySetting(CreateVerifySettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateVerifySettingResponse>(DoRequest("CreateVerifySetting", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateVerifySettingResponse> CreateVerifySettingAsync(CreateVerifySettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateVerifySettingResponse>(await DoRequestAsync("CreateVerifySetting", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public CreateVerifySettingResponse CreateVerifySettingSimply(CreateVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVerifySetting(request, runtime);
        }

        public async Task<CreateVerifySettingResponse> CreateVerifySettingSimplyAsync(CreateVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVerifySettingAsync(request, runtime);
        }

        public DescribeDeviceInfoResponse DescribeDeviceInfo(DescribeDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDeviceInfoResponse>(DoRequest("DescribeDeviceInfo", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeDeviceInfoResponse> DescribeDeviceInfoAsync(DescribeDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDeviceInfoResponse>(await DoRequestAsync("DescribeDeviceInfo", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeDeviceInfoResponse DescribeDeviceInfoSimply(DescribeDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceInfo(request, runtime);
        }

        public async Task<DescribeDeviceInfoResponse> DescribeDeviceInfoSimplyAsync(DescribeDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceInfoAsync(request, runtime);
        }

        public DescribeFaceVerifyResponse DescribeFaceVerify(DescribeFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeFaceVerifyResponse>(DoRequest("DescribeFaceVerify", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeFaceVerifyResponse> DescribeFaceVerifyAsync(DescribeFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeFaceVerifyResponse>(await DoRequestAsync("DescribeFaceVerify", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeFaceVerifyResponse DescribeFaceVerifySimply(DescribeFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaceVerify(request, runtime);
        }

        public async Task<DescribeFaceVerifyResponse> DescribeFaceVerifySimplyAsync(DescribeFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaceVerifyAsync(request, runtime);
        }

        public DescribeOssUploadTokenResponse DescribeOssUploadToken(DescribeOssUploadTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOssUploadTokenResponse>(DoRequest("DescribeOssUploadToken", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeOssUploadTokenResponse> DescribeOssUploadTokenAsync(DescribeOssUploadTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeOssUploadTokenResponse>(await DoRequestAsync("DescribeOssUploadToken", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeOssUploadTokenResponse DescribeOssUploadTokenSimply(DescribeOssUploadTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssUploadToken(request, runtime);
        }

        public async Task<DescribeOssUploadTokenResponse> DescribeOssUploadTokenSimplyAsync(DescribeOssUploadTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssUploadTokenAsync(request, runtime);
        }

        public DescribeVerifyResultResponse DescribeVerifyResult(DescribeVerifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVerifyResultResponse>(DoRequest("DescribeVerifyResult", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeVerifyResultResponse> DescribeVerifyResultAsync(DescribeVerifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVerifyResultResponse>(await DoRequestAsync("DescribeVerifyResult", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeVerifyResultResponse DescribeVerifyResultSimply(DescribeVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyResult(request, runtime);
        }

        public async Task<DescribeVerifyResultResponse> DescribeVerifyResultSimplyAsync(DescribeVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyResultAsync(request, runtime);
        }

        public DescribeVerifySDKResponse DescribeVerifySDK(DescribeVerifySDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVerifySDKResponse>(DoRequest("DescribeVerifySDK", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeVerifySDKResponse> DescribeVerifySDKAsync(DescribeVerifySDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVerifySDKResponse>(await DoRequestAsync("DescribeVerifySDK", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeVerifySDKResponse DescribeVerifySDKSimply(DescribeVerifySDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifySDK(request, runtime);
        }

        public async Task<DescribeVerifySDKResponse> DescribeVerifySDKSimplyAsync(DescribeVerifySDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifySDKAsync(request, runtime);
        }

        public DescribeVerifyTokenResponse DescribeVerifyToken(DescribeVerifyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVerifyTokenResponse>(DoRequest("DescribeVerifyToken", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeVerifyTokenResponse> DescribeVerifyTokenAsync(DescribeVerifyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVerifyTokenResponse>(await DoRequestAsync("DescribeVerifyToken", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeVerifyTokenResponse DescribeVerifyTokenSimply(DescribeVerifyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyToken(request, runtime);
        }

        public async Task<DescribeVerifyTokenResponse> DescribeVerifyTokenSimplyAsync(DescribeVerifyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyTokenAsync(request, runtime);
        }

        public DetectFaceAttributesResponse DetectFaceAttributes(DetectFaceAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DetectFaceAttributesResponse>(DoRequest("DetectFaceAttributes", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DetectFaceAttributesResponse> DetectFaceAttributesAsync(DetectFaceAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DetectFaceAttributesResponse>(await DoRequestAsync("DetectFaceAttributes", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DetectFaceAttributesResponse DetectFaceAttributesSimply(DetectFaceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectFaceAttributes(request, runtime);
        }

        public async Task<DetectFaceAttributesResponse> DetectFaceAttributesSimplyAsync(DetectFaceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectFaceAttributesAsync(request, runtime);
        }

        public InitFaceVerifyResponse InitFaceVerify(InitFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InitFaceVerifyResponse>(DoRequest("InitFaceVerify", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InitFaceVerifyResponse> InitFaceVerifyAsync(InitFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InitFaceVerifyResponse>(await DoRequestAsync("InitFaceVerify", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public InitFaceVerifyResponse InitFaceVerifySimply(InitFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitFaceVerify(request, runtime);
        }

        public async Task<InitFaceVerifyResponse> InitFaceVerifySimplyAsync(InitFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitFaceVerifyAsync(request, runtime);
        }

        public LivenessFaceVerifyResponse LivenessFaceVerify(LivenessFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<LivenessFaceVerifyResponse>(DoRequest("LivenessFaceVerify", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<LivenessFaceVerifyResponse> LivenessFaceVerifyAsync(LivenessFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<LivenessFaceVerifyResponse>(await DoRequestAsync("LivenessFaceVerify", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public LivenessFaceVerifyResponse LivenessFaceVerifySimply(LivenessFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LivenessFaceVerify(request, runtime);
        }

        public async Task<LivenessFaceVerifyResponse> LivenessFaceVerifySimplyAsync(LivenessFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LivenessFaceVerifyAsync(request, runtime);
        }

        public ModifyDeviceInfoResponse ModifyDeviceInfo(ModifyDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyDeviceInfoResponse>(DoRequest("ModifyDeviceInfo", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyDeviceInfoResponse> ModifyDeviceInfoAsync(ModifyDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyDeviceInfoResponse>(await DoRequestAsync("ModifyDeviceInfo", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public ModifyDeviceInfoResponse ModifyDeviceInfoSimply(ModifyDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDeviceInfo(request, runtime);
        }

        public async Task<ModifyDeviceInfoResponse> ModifyDeviceInfoSimplyAsync(ModifyDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDeviceInfoAsync(request, runtime);
        }

        public VerifyMaterialResponse VerifyMaterial(VerifyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<VerifyMaterialResponse>(DoRequest("VerifyMaterial", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<VerifyMaterialResponse> VerifyMaterialAsync(VerifyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<VerifyMaterialResponse>(await DoRequestAsync("VerifyMaterial", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public VerifyMaterialResponse VerifyMaterialSimply(VerifyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyMaterial(request, runtime);
        }

        public async Task<VerifyMaterialResponse> VerifyMaterialSimplyAsync(VerifyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyMaterialAsync(request, runtime);
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
