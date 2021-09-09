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


        public DescribeWhitelistSettingResponse DescribeWhitelistSetting(DescribeWhitelistSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeWhitelistSettingResponse>(DoRequest("DescribeWhitelistSetting", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeWhitelistSettingResponse> DescribeWhitelistSettingAsync(DescribeWhitelistSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeWhitelistSettingResponse>(await DoRequestAsync("DescribeWhitelistSetting", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeWhitelistSettingResponse DescribeWhitelistSettingSimply(DescribeWhitelistSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWhitelistSetting(request, runtime);
        }

        public async Task<DescribeWhitelistSettingResponse> DescribeWhitelistSettingSimplyAsync(DescribeWhitelistSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWhitelistSettingAsync(request, runtime);
        }

        public DeleteWhitelistSettingResponse DeleteWhitelistSetting(DeleteWhitelistSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteWhitelistSettingResponse>(DoRequest("DeleteWhitelistSetting", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteWhitelistSettingResponse> DeleteWhitelistSettingAsync(DeleteWhitelistSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteWhitelistSettingResponse>(await DoRequestAsync("DeleteWhitelistSetting", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DeleteWhitelistSettingResponse DeleteWhitelistSettingSimply(DeleteWhitelistSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWhitelistSetting(request, runtime);
        }

        public async Task<DeleteWhitelistSettingResponse> DeleteWhitelistSettingSimplyAsync(DeleteWhitelistSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWhitelistSettingAsync(request, runtime);
        }

        public CreateWhitelistSettingResponse CreateWhitelistSetting(CreateWhitelistSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateWhitelistSettingResponse>(DoRequest("CreateWhitelistSetting", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateWhitelistSettingResponse> CreateWhitelistSettingAsync(CreateWhitelistSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateWhitelistSettingResponse>(await DoRequestAsync("CreateWhitelistSetting", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public CreateWhitelistSettingResponse CreateWhitelistSettingSimply(CreateWhitelistSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWhitelistSetting(request, runtime);
        }

        public async Task<CreateWhitelistSettingResponse> CreateWhitelistSettingSimplyAsync(CreateWhitelistSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWhitelistSettingAsync(request, runtime);
        }

        public DescribeWhitelistResponse DescribeWhitelist(DescribeWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeWhitelistResponse>(DoRequest("DescribeWhitelist", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeWhitelistResponse> DescribeWhitelistAsync(DescribeWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeWhitelistResponse>(await DoRequestAsync("DescribeWhitelist", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeWhitelistResponse DescribeWhitelistSimply(DescribeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWhitelist(request, runtime);
        }

        public async Task<DescribeWhitelistResponse> DescribeWhitelistSimplyAsync(DescribeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWhitelistAsync(request, runtime);
        }

        public DeleteWhitelistResponse DeleteWhitelist(DeleteWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteWhitelistResponse>(DoRequest("DeleteWhitelist", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteWhitelistResponse> DeleteWhitelistAsync(DeleteWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteWhitelistResponse>(await DoRequestAsync("DeleteWhitelist", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DeleteWhitelistResponse DeleteWhitelistSimply(DeleteWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWhitelist(request, runtime);
        }

        public async Task<DeleteWhitelistResponse> DeleteWhitelistSimplyAsync(DeleteWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWhitelistAsync(request, runtime);
        }

        public CreateWhitelistResponse CreateWhitelist(CreateWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateWhitelistResponse>(DoRequest("CreateWhitelist", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateWhitelistResponse> CreateWhitelistAsync(CreateWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateWhitelistResponse>(await DoRequestAsync("CreateWhitelist", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public CreateWhitelistResponse CreateWhitelistSimply(CreateWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWhitelist(request, runtime);
        }

        public async Task<CreateWhitelistResponse> CreateWhitelistSimplyAsync(CreateWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWhitelistAsync(request, runtime);
        }

        public DescribeFaceConfigResponse DescribeFaceConfig(DescribeFaceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeFaceConfigResponse>(DoRequest("DescribeFaceConfig", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeFaceConfigResponse> DescribeFaceConfigAsync(DescribeFaceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeFaceConfigResponse>(await DoRequestAsync("DescribeFaceConfig", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeFaceConfigResponse DescribeFaceConfigSimply(DescribeFaceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaceConfig(request, runtime);
        }

        public async Task<DescribeFaceConfigResponse> DescribeFaceConfigSimplyAsync(DescribeFaceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaceConfigAsync(request, runtime);
        }

        public UpdateFaceConfigResponse UpdateFaceConfig(UpdateFaceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateFaceConfigResponse>(DoRequest("UpdateFaceConfig", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateFaceConfigResponse> UpdateFaceConfigAsync(UpdateFaceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateFaceConfigResponse>(await DoRequestAsync("UpdateFaceConfig", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public UpdateFaceConfigResponse UpdateFaceConfigSimply(UpdateFaceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFaceConfig(request, runtime);
        }

        public async Task<UpdateFaceConfigResponse> UpdateFaceConfigSimplyAsync(UpdateFaceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFaceConfigAsync(request, runtime);
        }

        public CreateFaceConfigResponse CreateFaceConfig(CreateFaceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateFaceConfigResponse>(DoRequest("CreateFaceConfig", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateFaceConfigResponse> CreateFaceConfigAsync(CreateFaceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateFaceConfigResponse>(await DoRequestAsync("CreateFaceConfig", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public CreateFaceConfigResponse CreateFaceConfigSimply(CreateFaceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFaceConfig(request, runtime);
        }

        public async Task<CreateFaceConfigResponse> CreateFaceConfigSimplyAsync(CreateFaceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFaceConfigAsync(request, runtime);
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

        public DescribeSdkUrlResponse DescribeSdkUrl(DescribeSdkUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSdkUrlResponse>(DoRequest("DescribeSdkUrl", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeSdkUrlResponse> DescribeSdkUrlAsync(DescribeSdkUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeSdkUrlResponse>(await DoRequestAsync("DescribeSdkUrl", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeSdkUrlResponse DescribeSdkUrlSimply(DescribeSdkUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSdkUrl(request, runtime);
        }

        public async Task<DescribeSdkUrlResponse> DescribeSdkUrlSimplyAsync(DescribeSdkUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSdkUrlAsync(request, runtime);
        }

        public DescribeUpdatePackageResultResponse DescribeUpdatePackageResult(DescribeUpdatePackageResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUpdatePackageResultResponse>(DoRequest("DescribeUpdatePackageResult", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeUpdatePackageResultResponse> DescribeUpdatePackageResultAsync(DescribeUpdatePackageResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUpdatePackageResultResponse>(await DoRequestAsync("DescribeUpdatePackageResult", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeUpdatePackageResultResponse DescribeUpdatePackageResultSimply(DescribeUpdatePackageResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUpdatePackageResult(request, runtime);
        }

        public async Task<DescribeUpdatePackageResultResponse> DescribeUpdatePackageResultSimplyAsync(DescribeUpdatePackageResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUpdatePackageResultAsync(request, runtime);
        }

        public UpdateAppPackageResponse UpdateAppPackage(UpdateAppPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateAppPackageResponse>(DoRequest("UpdateAppPackage", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateAppPackageResponse> UpdateAppPackageAsync(UpdateAppPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateAppPackageResponse>(await DoRequestAsync("UpdateAppPackage", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public UpdateAppPackageResponse UpdateAppPackageSimply(UpdateAppPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppPackage(request, runtime);
        }

        public async Task<UpdateAppPackageResponse> UpdateAppPackageSimplyAsync(UpdateAppPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppPackageAsync(request, runtime);
        }

        public DescribeAppInfoResponse DescribeAppInfo(DescribeAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeAppInfoResponse>(DoRequest("DescribeAppInfo", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeAppInfoResponse> DescribeAppInfoAsync(DescribeAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeAppInfoResponse>(await DoRequestAsync("DescribeAppInfo", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeAppInfoResponse DescribeAppInfoSimply(DescribeAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppInfo(request, runtime);
        }

        public async Task<DescribeAppInfoResponse> DescribeAppInfoSimplyAsync(DescribeAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppInfoAsync(request, runtime);
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

        public InitDeviceResponse InitDevice(InitDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InitDeviceResponse>(DoRequest("InitDevice", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InitDeviceResponse> InitDeviceAsync(InitDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InitDeviceResponse>(await DoRequestAsync("InitDevice", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public InitDeviceResponse InitDeviceSimply(InitDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitDevice(request, runtime);
        }

        public async Task<InitDeviceResponse> InitDeviceSimplyAsync(InitDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitDeviceAsync(request, runtime);
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

        public VerifyDeviceResponse VerifyDevice(VerifyDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<VerifyDeviceResponse>(DoRequest("VerifyDevice", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<VerifyDeviceResponse> VerifyDeviceAsync(VerifyDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<VerifyDeviceResponse>(await DoRequestAsync("VerifyDevice", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public VerifyDeviceResponse VerifyDeviceSimply(VerifyDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyDevice(request, runtime);
        }

        public async Task<VerifyDeviceResponse> VerifyDeviceSimplyAsync(VerifyDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyDeviceAsync(request, runtime);
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

        public CreateVerifySDKResponse CreateVerifySDK(CreateVerifySDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateVerifySDKResponse>(DoRequest("CreateVerifySDK", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateVerifySDKResponse> CreateVerifySDKAsync(CreateVerifySDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateVerifySDKResponse>(await DoRequestAsync("CreateVerifySDK", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public CreateVerifySDKResponse CreateVerifySDKSimply(CreateVerifySDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVerifySDK(request, runtime);
        }

        public async Task<CreateVerifySDKResponse> CreateVerifySDKSimplyAsync(CreateVerifySDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVerifySDKAsync(request, runtime);
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

        public DescribeFaceUsageResponse DescribeFaceUsage(DescribeFaceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeFaceUsageResponse>(DoRequest("DescribeFaceUsage", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeFaceUsageResponse> DescribeFaceUsageAsync(DescribeFaceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeFaceUsageResponse>(await DoRequestAsync("DescribeFaceUsage", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeFaceUsageResponse DescribeFaceUsageSimply(DescribeFaceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaceUsage(request, runtime);
        }

        public async Task<DescribeFaceUsageResponse> DescribeFaceUsageSimplyAsync(DescribeFaceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaceUsageAsync(request, runtime);
        }

        public DescribeVerifyRecordsResponse DescribeVerifyRecords(DescribeVerifyRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVerifyRecordsResponse>(DoRequest("DescribeVerifyRecords", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeVerifyRecordsResponse> DescribeVerifyRecordsAsync(DescribeVerifyRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVerifyRecordsResponse>(await DoRequestAsync("DescribeVerifyRecords", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeVerifyRecordsResponse DescribeVerifyRecordsSimply(DescribeVerifyRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyRecords(request, runtime);
        }

        public async Task<DescribeVerifyRecordsResponse> DescribeVerifyRecordsSimplyAsync(DescribeVerifyRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyRecordsAsync(request, runtime);
        }

        public UpdateVerifySettingResponse UpdateVerifySetting(UpdateVerifySettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateVerifySettingResponse>(DoRequest("UpdateVerifySetting", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateVerifySettingResponse> UpdateVerifySettingAsync(UpdateVerifySettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateVerifySettingResponse>(await DoRequestAsync("UpdateVerifySetting", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public UpdateVerifySettingResponse UpdateVerifySettingSimply(UpdateVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVerifySetting(request, runtime);
        }

        public async Task<UpdateVerifySettingResponse> UpdateVerifySettingSimplyAsync(UpdateVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVerifySettingAsync(request, runtime);
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

        public DescribeVerifySettingResponse DescribeVerifySetting(DescribeVerifySettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVerifySettingResponse>(DoRequest("DescribeVerifySetting", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeVerifySettingResponse> DescribeVerifySettingAsync(DescribeVerifySettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVerifySettingResponse>(await DoRequestAsync("DescribeVerifySetting", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeVerifySettingResponse DescribeVerifySettingSimply(DescribeVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifySetting(request, runtime);
        }

        public async Task<DescribeVerifySettingResponse> DescribeVerifySettingSimplyAsync(DescribeVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifySettingAsync(request, runtime);
        }

        public DescribeVerifyUsageResponse DescribeVerifyUsage(DescribeVerifyUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVerifyUsageResponse>(DoRequest("DescribeVerifyUsage", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeVerifyUsageResponse> DescribeVerifyUsageAsync(DescribeVerifyUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeVerifyUsageResponse>(await DoRequestAsync("DescribeVerifyUsage", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeVerifyUsageResponse DescribeVerifyUsageSimply(DescribeVerifyUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyUsage(request, runtime);
        }

        public async Task<DescribeVerifyUsageResponse> DescribeVerifyUsageSimplyAsync(DescribeVerifyUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyUsageAsync(request, runtime);
        }

        public DescribeUserStatusResponse DescribeUserStatus(DescribeUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUserStatusResponse>(DoRequest("DescribeUserStatus", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeUserStatusResponse> DescribeUserStatusAsync(DescribeUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUserStatusResponse>(await DoRequestAsync("DescribeUserStatus", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeUserStatusResponse DescribeUserStatusSimply(DescribeUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserStatus(request, runtime);
        }

        public async Task<DescribeUserStatusResponse> DescribeUserStatusSimplyAsync(DescribeUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserStatusAsync(request, runtime);
        }

        public DescribeUploadInfoResponse DescribeUploadInfo(DescribeUploadInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUploadInfoResponse>(DoRequest("DescribeUploadInfo", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeUploadInfoResponse> DescribeUploadInfoAsync(DescribeUploadInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUploadInfoResponse>(await DoRequestAsync("DescribeUploadInfo", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeUploadInfoResponse DescribeUploadInfoSimply(DescribeUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUploadInfo(request, runtime);
        }

        public async Task<DescribeUploadInfoResponse> DescribeUploadInfoSimplyAsync(DescribeUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUploadInfoAsync(request, runtime);
        }

        public DescribeRPSDKResponse DescribeRPSDK(DescribeRPSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRPSDKResponse>(DoRequest("DescribeRPSDK", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeRPSDKResponse> DescribeRPSDKAsync(DescribeRPSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRPSDKResponse>(await DoRequestAsync("DescribeRPSDK", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public DescribeRPSDKResponse DescribeRPSDKSimply(DescribeRPSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRPSDK(request, runtime);
        }

        public async Task<DescribeRPSDKResponse> DescribeRPSDKSimplyAsync(DescribeRPSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRPSDKAsync(request, runtime);
        }

        public CreateRPSDKResponse CreateRPSDK(CreateRPSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRPSDKResponse>(DoRequest("CreateRPSDK", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateRPSDKResponse> CreateRPSDKAsync(CreateRPSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRPSDKResponse>(await DoRequestAsync("CreateRPSDK", "HTTPS", "POST", "2019-03-07", "AK", null, request.ToMap(), runtime));
        }

        public CreateRPSDKResponse CreateRPSDKSimply(CreateRPSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRPSDK(request, runtime);
        }

        public async Task<CreateRPSDKResponse> CreateRPSDKSimplyAsync(CreateRPSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRPSDKAsync(request, runtime);
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
