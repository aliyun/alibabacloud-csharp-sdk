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
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudauth", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public VerifyMaterialResponse VerifyMaterialWithOptions(VerifyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyMaterialResponse>(DoRPCRequest("VerifyMaterial", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyMaterialResponse> VerifyMaterialWithOptionsAsync(VerifyMaterialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyMaterialResponse>(await DoRPCRequestAsync("VerifyMaterial", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyMaterialResponse VerifyMaterial(VerifyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyMaterialWithOptions(request, runtime);
        }

        public async Task<VerifyMaterialResponse> VerifyMaterialAsync(VerifyMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyMaterialWithOptionsAsync(request, runtime);
        }

        public DescribeWhitelistResponse DescribeWhitelistWithOptions(DescribeWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWhitelistResponse>(DoRPCRequest("DescribeWhitelist", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWhitelistResponse> DescribeWhitelistWithOptionsAsync(DescribeWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWhitelistResponse>(await DoRPCRequestAsync("DescribeWhitelist", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWhitelistResponse DescribeWhitelist(DescribeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWhitelistWithOptions(request, runtime);
        }

        public async Task<DescribeWhitelistResponse> DescribeWhitelistAsync(DescribeWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWhitelistWithOptionsAsync(request, runtime);
        }

        public UpdateAppPackageResponse UpdateAppPackageWithOptions(UpdateAppPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppPackageResponse>(DoRPCRequest("UpdateAppPackage", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAppPackageResponse> UpdateAppPackageWithOptionsAsync(UpdateAppPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppPackageResponse>(await DoRPCRequestAsync("UpdateAppPackage", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAppPackageResponse UpdateAppPackage(UpdateAppPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppPackageWithOptions(request, runtime);
        }

        public async Task<UpdateAppPackageResponse> UpdateAppPackageAsync(UpdateAppPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppPackageWithOptionsAsync(request, runtime);
        }

        public DescribeVerifyTokenResponse DescribeVerifyTokenWithOptions(DescribeVerifyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifyTokenResponse>(DoRPCRequest("DescribeVerifyToken", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVerifyTokenResponse> DescribeVerifyTokenWithOptionsAsync(DescribeVerifyTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifyTokenResponse>(await DoRPCRequestAsync("DescribeVerifyToken", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVerifyTokenResponse DescribeVerifyToken(DescribeVerifyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyTokenWithOptions(request, runtime);
        }

        public async Task<DescribeVerifyTokenResponse> DescribeVerifyTokenAsync(DescribeVerifyTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyTokenWithOptionsAsync(request, runtime);
        }

        public DescribeRPSDKResponse DescribeRPSDKWithOptions(DescribeRPSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRPSDKResponse>(DoRPCRequest("DescribeRPSDK", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRPSDKResponse> DescribeRPSDKWithOptionsAsync(DescribeRPSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRPSDKResponse>(await DoRPCRequestAsync("DescribeRPSDK", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRPSDKResponse DescribeRPSDK(DescribeRPSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRPSDKWithOptions(request, runtime);
        }

        public async Task<DescribeRPSDKResponse> DescribeRPSDKAsync(DescribeRPSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRPSDKWithOptionsAsync(request, runtime);
        }

        public DescribeFaceUsageResponse DescribeFaceUsageWithOptions(DescribeFaceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFaceUsageResponse>(DoRPCRequest("DescribeFaceUsage", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFaceUsageResponse> DescribeFaceUsageWithOptionsAsync(DescribeFaceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFaceUsageResponse>(await DoRPCRequestAsync("DescribeFaceUsage", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFaceUsageResponse DescribeFaceUsage(DescribeFaceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaceUsageWithOptions(request, runtime);
        }

        public async Task<DescribeFaceUsageResponse> DescribeFaceUsageAsync(DescribeFaceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaceUsageWithOptionsAsync(request, runtime);
        }

        public DescribeVerifyUsageResponse DescribeVerifyUsageWithOptions(DescribeVerifyUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifyUsageResponse>(DoRPCRequest("DescribeVerifyUsage", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVerifyUsageResponse> DescribeVerifyUsageWithOptionsAsync(DescribeVerifyUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifyUsageResponse>(await DoRPCRequestAsync("DescribeVerifyUsage", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVerifyUsageResponse DescribeVerifyUsage(DescribeVerifyUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyUsageWithOptions(request, runtime);
        }

        public async Task<DescribeVerifyUsageResponse> DescribeVerifyUsageAsync(DescribeVerifyUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyUsageWithOptionsAsync(request, runtime);
        }

        public DescribeUpdatePackageResultResponse DescribeUpdatePackageResultWithOptions(DescribeUpdatePackageResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUpdatePackageResultResponse>(DoRPCRequest("DescribeUpdatePackageResult", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUpdatePackageResultResponse> DescribeUpdatePackageResultWithOptionsAsync(DescribeUpdatePackageResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUpdatePackageResultResponse>(await DoRPCRequestAsync("DescribeUpdatePackageResult", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUpdatePackageResultResponse DescribeUpdatePackageResult(DescribeUpdatePackageResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUpdatePackageResultWithOptions(request, runtime);
        }

        public async Task<DescribeUpdatePackageResultResponse> DescribeUpdatePackageResultAsync(DescribeUpdatePackageResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUpdatePackageResultWithOptionsAsync(request, runtime);
        }

        public CreateWhitelistResponse CreateWhitelistWithOptions(CreateWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWhitelistResponse>(DoRPCRequest("CreateWhitelist", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateWhitelistResponse> CreateWhitelistWithOptionsAsync(CreateWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWhitelistResponse>(await DoRPCRequestAsync("CreateWhitelist", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateWhitelistResponse CreateWhitelist(CreateWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWhitelistWithOptions(request, runtime);
        }

        public async Task<CreateWhitelistResponse> CreateWhitelistAsync(CreateWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWhitelistWithOptionsAsync(request, runtime);
        }

        public DeleteWhitelistResponse DeleteWhitelistWithOptions(DeleteWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWhitelistResponse>(DoRPCRequest("DeleteWhitelist", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteWhitelistResponse> DeleteWhitelistWithOptionsAsync(DeleteWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWhitelistResponse>(await DoRPCRequestAsync("DeleteWhitelist", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteWhitelistResponse DeleteWhitelist(DeleteWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWhitelistWithOptions(request, runtime);
        }

        public async Task<DeleteWhitelistResponse> DeleteWhitelistAsync(DeleteWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWhitelistWithOptionsAsync(request, runtime);
        }

        public CreateAuthKeyResponse CreateAuthKeyWithOptions(CreateAuthKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAuthKeyResponse>(DoRPCRequest("CreateAuthKey", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAuthKeyResponse> CreateAuthKeyWithOptionsAsync(CreateAuthKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAuthKeyResponse>(await DoRPCRequestAsync("CreateAuthKey", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAuthKeyResponse CreateAuthKey(CreateAuthKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAuthKeyWithOptions(request, runtime);
        }

        public async Task<CreateAuthKeyResponse> CreateAuthKeyAsync(CreateAuthKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAuthKeyWithOptionsAsync(request, runtime);
        }

        public DescribeUploadInfoResponse DescribeUploadInfoWithOptions(DescribeUploadInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUploadInfoResponse>(DoRPCRequest("DescribeUploadInfo", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUploadInfoResponse> DescribeUploadInfoWithOptionsAsync(DescribeUploadInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUploadInfoResponse>(await DoRPCRequestAsync("DescribeUploadInfo", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUploadInfoResponse DescribeUploadInfo(DescribeUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUploadInfoWithOptions(request, runtime);
        }

        public async Task<DescribeUploadInfoResponse> DescribeUploadInfoAsync(DescribeUploadInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUploadInfoWithOptionsAsync(request, runtime);
        }

        public DescribeVerifySettingResponse DescribeVerifySettingWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeVerifySettingResponse>(DoRPCRequest("DescribeVerifySetting", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVerifySettingResponse> DescribeVerifySettingWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeVerifySettingResponse>(await DoRPCRequestAsync("DescribeVerifySetting", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVerifySettingResponse DescribeVerifySetting()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifySettingWithOptions(runtime);
        }

        public async Task<DescribeVerifySettingResponse> DescribeVerifySettingAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifySettingWithOptionsAsync(runtime);
        }

        public DescribeVerifyRecordsResponse DescribeVerifyRecordsWithOptions(DescribeVerifyRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifyRecordsResponse>(DoRPCRequest("DescribeVerifyRecords", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVerifyRecordsResponse> DescribeVerifyRecordsWithOptionsAsync(DescribeVerifyRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifyRecordsResponse>(await DoRPCRequestAsync("DescribeVerifyRecords", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVerifyRecordsResponse DescribeVerifyRecords(DescribeVerifyRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeVerifyRecordsResponse> DescribeVerifyRecordsAsync(DescribeVerifyRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeWhitelistSettingResponse DescribeWhitelistSettingWithOptions(DescribeWhitelistSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWhitelistSettingResponse>(DoRPCRequest("DescribeWhitelistSetting", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWhitelistSettingResponse> DescribeWhitelistSettingWithOptionsAsync(DescribeWhitelistSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWhitelistSettingResponse>(await DoRPCRequestAsync("DescribeWhitelistSetting", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWhitelistSettingResponse DescribeWhitelistSetting(DescribeWhitelistSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWhitelistSettingWithOptions(request, runtime);
        }

        public async Task<DescribeWhitelistSettingResponse> DescribeWhitelistSettingAsync(DescribeWhitelistSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWhitelistSettingWithOptionsAsync(request, runtime);
        }

        public CreateRPSDKResponse CreateRPSDKWithOptions(CreateRPSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRPSDKResponse>(DoRPCRequest("CreateRPSDK", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRPSDKResponse> CreateRPSDKWithOptionsAsync(CreateRPSDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRPSDKResponse>(await DoRPCRequestAsync("CreateRPSDK", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRPSDKResponse CreateRPSDK(CreateRPSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRPSDKWithOptions(request, runtime);
        }

        public async Task<CreateRPSDKResponse> CreateRPSDKAsync(CreateRPSDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRPSDKWithOptionsAsync(request, runtime);
        }

        public UpdateFaceConfigResponse UpdateFaceConfigWithOptions(UpdateFaceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFaceConfigResponse>(DoRPCRequest("UpdateFaceConfig", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateFaceConfigResponse> UpdateFaceConfigWithOptionsAsync(UpdateFaceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateFaceConfigResponse>(await DoRPCRequestAsync("UpdateFaceConfig", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateFaceConfigResponse UpdateFaceConfig(UpdateFaceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFaceConfigWithOptions(request, runtime);
        }

        public async Task<UpdateFaceConfigResponse> UpdateFaceConfigAsync(UpdateFaceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFaceConfigWithOptionsAsync(request, runtime);
        }

        public DescribeFaceConfigResponse DescribeFaceConfigWithOptions(DescribeFaceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFaceConfigResponse>(DoRPCRequest("DescribeFaceConfig", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFaceConfigResponse> DescribeFaceConfigWithOptionsAsync(DescribeFaceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFaceConfigResponse>(await DoRPCRequestAsync("DescribeFaceConfig", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFaceConfigResponse DescribeFaceConfig(DescribeFaceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaceConfigWithOptions(request, runtime);
        }

        public async Task<DescribeFaceConfigResponse> DescribeFaceConfigAsync(DescribeFaceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaceConfigWithOptionsAsync(request, runtime);
        }

        public LivenessFaceVerifyResponse LivenessFaceVerifyWithOptions(LivenessFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LivenessFaceVerifyResponse>(DoRPCRequest("LivenessFaceVerify", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LivenessFaceVerifyResponse> LivenessFaceVerifyWithOptionsAsync(LivenessFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LivenessFaceVerifyResponse>(await DoRPCRequestAsync("LivenessFaceVerify", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LivenessFaceVerifyResponse LivenessFaceVerify(LivenessFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LivenessFaceVerifyWithOptions(request, runtime);
        }

        public async Task<LivenessFaceVerifyResponse> LivenessFaceVerifyAsync(LivenessFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LivenessFaceVerifyWithOptionsAsync(request, runtime);
        }

        public DescribeAppInfoResponse DescribeAppInfoWithOptions(DescribeAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppInfoResponse>(DoRPCRequest("DescribeAppInfo", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAppInfoResponse> DescribeAppInfoWithOptionsAsync(DescribeAppInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppInfoResponse>(await DoRPCRequestAsync("DescribeAppInfo", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAppInfoResponse DescribeAppInfo(DescribeAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppInfoWithOptions(request, runtime);
        }

        public async Task<DescribeAppInfoResponse> DescribeAppInfoAsync(DescribeAppInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppInfoWithOptionsAsync(request, runtime);
        }

        public ModifyDeviceInfoResponse ModifyDeviceInfoWithOptions(ModifyDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeviceInfoResponse>(DoRPCRequest("ModifyDeviceInfo", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDeviceInfoResponse> ModifyDeviceInfoWithOptionsAsync(ModifyDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeviceInfoResponse>(await DoRPCRequestAsync("ModifyDeviceInfo", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDeviceInfoResponse ModifyDeviceInfo(ModifyDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDeviceInfoWithOptions(request, runtime);
        }

        public async Task<ModifyDeviceInfoResponse> ModifyDeviceInfoAsync(ModifyDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDeviceInfoWithOptionsAsync(request, runtime);
        }

        public ContrastFaceVerifyResponse ContrastFaceVerifyWithOptions(ContrastFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ContrastFaceVerifyResponse>(DoRPCRequest("ContrastFaceVerify", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ContrastFaceVerifyResponse> ContrastFaceVerifyWithOptionsAsync(ContrastFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ContrastFaceVerifyResponse>(await DoRPCRequestAsync("ContrastFaceVerify", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ContrastFaceVerifyResponse ContrastFaceVerify(ContrastFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContrastFaceVerifyWithOptions(request, runtime);
        }

        public async Task<ContrastFaceVerifyResponse> ContrastFaceVerifyAsync(ContrastFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContrastFaceVerifyWithOptionsAsync(request, runtime);
        }

        public ContrastFaceVerifyResponse ContrastFaceVerifyAdvance(ContrastFaceVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ContrastFaceVerifyRequest contrastFaceVerifyReq = new ContrastFaceVerifyRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, contrastFaceVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastFileObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
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
            ContrastFaceVerifyResponse contrastFaceVerifyResp = ContrastFaceVerifyWithOptions(contrastFaceVerifyReq, runtime);
            return contrastFaceVerifyResp;
        }

        public async Task<ContrastFaceVerifyResponse> ContrastFaceVerifyAdvanceAsync(ContrastFaceVerifyAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiUtil.Client.Convert(runtime, ossRuntime);
            ContrastFaceVerifyRequest contrastFaceVerifyReq = new ContrastFaceVerifyRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(request, contrastFaceVerifyReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaceContrastFileObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.OpenApiUtil.Client.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
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
            ContrastFaceVerifyResponse contrastFaceVerifyResp = await ContrastFaceVerifyWithOptionsAsync(contrastFaceVerifyReq, runtime);
            return contrastFaceVerifyResp;
        }

        public VerifyDeviceResponse VerifyDeviceWithOptions(VerifyDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyDeviceResponse>(DoRPCRequest("VerifyDevice", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyDeviceResponse> VerifyDeviceWithOptionsAsync(VerifyDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyDeviceResponse>(await DoRPCRequestAsync("VerifyDevice", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyDeviceResponse VerifyDevice(VerifyDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyDeviceWithOptions(request, runtime);
        }

        public async Task<VerifyDeviceResponse> VerifyDeviceAsync(VerifyDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyDeviceWithOptionsAsync(request, runtime);
        }

        public CompareFaceVerifyResponse CompareFaceVerifyWithOptions(CompareFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompareFaceVerifyResponse>(DoRPCRequest("CompareFaceVerify", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CompareFaceVerifyResponse> CompareFaceVerifyWithOptionsAsync(CompareFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompareFaceVerifyResponse>(await DoRPCRequestAsync("CompareFaceVerify", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CompareFaceVerifyResponse CompareFaceVerify(CompareFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompareFaceVerifyWithOptions(request, runtime);
        }

        public async Task<CompareFaceVerifyResponse> CompareFaceVerifyAsync(CompareFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompareFaceVerifyWithOptionsAsync(request, runtime);
        }

        public DescribeVerifySDKResponse DescribeVerifySDKWithOptions(DescribeVerifySDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifySDKResponse>(DoRPCRequest("DescribeVerifySDK", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVerifySDKResponse> DescribeVerifySDKWithOptionsAsync(DescribeVerifySDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifySDKResponse>(await DoRPCRequestAsync("DescribeVerifySDK", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVerifySDKResponse DescribeVerifySDK(DescribeVerifySDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifySDKWithOptions(request, runtime);
        }

        public async Task<DescribeVerifySDKResponse> DescribeVerifySDKAsync(DescribeVerifySDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifySDKWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceInfoResponse DescribeDeviceInfoWithOptions(DescribeDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceInfoResponse>(DoRPCRequest("DescribeDeviceInfo", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceInfoResponse> DescribeDeviceInfoWithOptionsAsync(DescribeDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceInfoResponse>(await DoRPCRequestAsync("DescribeDeviceInfo", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeviceInfoResponse DescribeDeviceInfo(DescribeDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceInfoResponse> DescribeDeviceInfoAsync(DescribeDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceInfoWithOptionsAsync(request, runtime);
        }

        public DescribeFaceVerifyResponse DescribeFaceVerifyWithOptions(DescribeFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFaceVerifyResponse>(DoRPCRequest("DescribeFaceVerify", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFaceVerifyResponse> DescribeFaceVerifyWithOptionsAsync(DescribeFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFaceVerifyResponse>(await DoRPCRequestAsync("DescribeFaceVerify", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFaceVerifyResponse DescribeFaceVerify(DescribeFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFaceVerifyWithOptions(request, runtime);
        }

        public async Task<DescribeFaceVerifyResponse> DescribeFaceVerifyAsync(DescribeFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFaceVerifyWithOptionsAsync(request, runtime);
        }

        public DescribeOssUploadTokenResponse DescribeOssUploadTokenWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeOssUploadTokenResponse>(DoRPCRequest("DescribeOssUploadToken", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOssUploadTokenResponse> DescribeOssUploadTokenWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeOssUploadTokenResponse>(await DoRPCRequestAsync("DescribeOssUploadToken", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeOssUploadTokenResponse DescribeOssUploadToken()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOssUploadTokenWithOptions(runtime);
        }

        public async Task<DescribeOssUploadTokenResponse> DescribeOssUploadTokenAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOssUploadTokenWithOptionsAsync(runtime);
        }

        public DetectFaceAttributesResponse DetectFaceAttributesWithOptions(DetectFaceAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectFaceAttributesResponse>(DoRPCRequest("DetectFaceAttributes", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetectFaceAttributesResponse> DetectFaceAttributesWithOptionsAsync(DetectFaceAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectFaceAttributesResponse>(await DoRPCRequestAsync("DetectFaceAttributes", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetectFaceAttributesResponse DetectFaceAttributes(DetectFaceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectFaceAttributesWithOptions(request, runtime);
        }

        public async Task<DetectFaceAttributesResponse> DetectFaceAttributesAsync(DetectFaceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectFaceAttributesWithOptionsAsync(request, runtime);
        }

        public DescribeSdkUrlResponse DescribeSdkUrlWithOptions(DescribeSdkUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSdkUrlResponse>(DoRPCRequest("DescribeSdkUrl", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSdkUrlResponse> DescribeSdkUrlWithOptionsAsync(DescribeSdkUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSdkUrlResponse>(await DoRPCRequestAsync("DescribeSdkUrl", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSdkUrlResponse DescribeSdkUrl(DescribeSdkUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSdkUrlWithOptions(request, runtime);
        }

        public async Task<DescribeSdkUrlResponse> DescribeSdkUrlAsync(DescribeSdkUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSdkUrlWithOptionsAsync(request, runtime);
        }

        public DeleteWhitelistSettingResponse DeleteWhitelistSettingWithOptions(DeleteWhitelistSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWhitelistSettingResponse>(DoRPCRequest("DeleteWhitelistSetting", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteWhitelistSettingResponse> DeleteWhitelistSettingWithOptionsAsync(DeleteWhitelistSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteWhitelistSettingResponse>(await DoRPCRequestAsync("DeleteWhitelistSetting", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteWhitelistSettingResponse DeleteWhitelistSetting(DeleteWhitelistSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWhitelistSettingWithOptions(request, runtime);
        }

        public async Task<DeleteWhitelistSettingResponse> DeleteWhitelistSettingAsync(DeleteWhitelistSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWhitelistSettingWithOptionsAsync(request, runtime);
        }

        public UpdateVerifySettingResponse UpdateVerifySettingWithOptions(UpdateVerifySettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateVerifySettingResponse>(DoRPCRequest("UpdateVerifySetting", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateVerifySettingResponse> UpdateVerifySettingWithOptionsAsync(UpdateVerifySettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateVerifySettingResponse>(await DoRPCRequestAsync("UpdateVerifySetting", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateVerifySettingResponse UpdateVerifySetting(UpdateVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVerifySettingWithOptions(request, runtime);
        }

        public async Task<UpdateVerifySettingResponse> UpdateVerifySettingAsync(UpdateVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVerifySettingWithOptionsAsync(request, runtime);
        }

        public DescribeVerifyResultResponse DescribeVerifyResultWithOptions(DescribeVerifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifyResultResponse>(DoRPCRequest("DescribeVerifyResult", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVerifyResultResponse> DescribeVerifyResultWithOptionsAsync(DescribeVerifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifyResultResponse>(await DoRPCRequestAsync("DescribeVerifyResult", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVerifyResultResponse DescribeVerifyResult(DescribeVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifyResultWithOptions(request, runtime);
        }

        public async Task<DescribeVerifyResultResponse> DescribeVerifyResultAsync(DescribeVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifyResultWithOptionsAsync(request, runtime);
        }

        public CompareFacesResponse CompareFacesWithOptions(CompareFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompareFacesResponse>(DoRPCRequest("CompareFaces", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CompareFacesResponse> CompareFacesWithOptionsAsync(CompareFacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompareFacesResponse>(await DoRPCRequestAsync("CompareFaces", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CompareFacesResponse CompareFaces(CompareFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompareFacesWithOptions(request, runtime);
        }

        public async Task<CompareFacesResponse> CompareFacesAsync(CompareFacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompareFacesWithOptionsAsync(request, runtime);
        }

        public CreateFaceConfigResponse CreateFaceConfigWithOptions(CreateFaceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFaceConfigResponse>(DoRPCRequest("CreateFaceConfig", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFaceConfigResponse> CreateFaceConfigWithOptionsAsync(CreateFaceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFaceConfigResponse>(await DoRPCRequestAsync("CreateFaceConfig", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFaceConfigResponse CreateFaceConfig(CreateFaceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFaceConfigWithOptions(request, runtime);
        }

        public async Task<CreateFaceConfigResponse> CreateFaceConfigAsync(CreateFaceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFaceConfigWithOptionsAsync(request, runtime);
        }

        public CreateVerifySDKResponse CreateVerifySDKWithOptions(CreateVerifySDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVerifySDKResponse>(DoRPCRequest("CreateVerifySDK", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVerifySDKResponse> CreateVerifySDKWithOptionsAsync(CreateVerifySDKRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVerifySDKResponse>(await DoRPCRequestAsync("CreateVerifySDK", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVerifySDKResponse CreateVerifySDK(CreateVerifySDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVerifySDKWithOptions(request, runtime);
        }

        public async Task<CreateVerifySDKResponse> CreateVerifySDKAsync(CreateVerifySDKRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVerifySDKWithOptionsAsync(request, runtime);
        }

        public InitDeviceResponse InitDeviceWithOptions(InitDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitDeviceResponse>(DoRPCRequest("InitDevice", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InitDeviceResponse> InitDeviceWithOptionsAsync(InitDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitDeviceResponse>(await DoRPCRequestAsync("InitDevice", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InitDeviceResponse InitDevice(InitDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitDeviceWithOptions(request, runtime);
        }

        public async Task<InitDeviceResponse> InitDeviceAsync(InitDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitDeviceWithOptionsAsync(request, runtime);
        }

        public CreateWhitelistSettingResponse CreateWhitelistSettingWithOptions(CreateWhitelistSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWhitelistSettingResponse>(DoRPCRequest("CreateWhitelistSetting", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateWhitelistSettingResponse> CreateWhitelistSettingWithOptionsAsync(CreateWhitelistSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWhitelistSettingResponse>(await DoRPCRequestAsync("CreateWhitelistSetting", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateWhitelistSettingResponse CreateWhitelistSetting(CreateWhitelistSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWhitelistSettingWithOptions(request, runtime);
        }

        public async Task<CreateWhitelistSettingResponse> CreateWhitelistSettingAsync(CreateWhitelistSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWhitelistSettingWithOptionsAsync(request, runtime);
        }

        public DescribeUserStatusResponse DescribeUserStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeUserStatusResponse>(DoRPCRequest("DescribeUserStatus", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserStatusResponse> DescribeUserStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeUserStatusResponse>(await DoRPCRequestAsync("DescribeUserStatus", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserStatusResponse DescribeUserStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserStatusWithOptions(runtime);
        }

        public async Task<DescribeUserStatusResponse> DescribeUserStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserStatusWithOptionsAsync(runtime);
        }

        public CreateVerifySettingResponse CreateVerifySettingWithOptions(CreateVerifySettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVerifySettingResponse>(DoRPCRequest("CreateVerifySetting", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVerifySettingResponse> CreateVerifySettingWithOptionsAsync(CreateVerifySettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVerifySettingResponse>(await DoRPCRequestAsync("CreateVerifySetting", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVerifySettingResponse CreateVerifySetting(CreateVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVerifySettingWithOptions(request, runtime);
        }

        public async Task<CreateVerifySettingResponse> CreateVerifySettingAsync(CreateVerifySettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVerifySettingWithOptionsAsync(request, runtime);
        }

        public InitFaceVerifyResponse InitFaceVerifyWithOptions(InitFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitFaceVerifyResponse>(DoRPCRequest("InitFaceVerify", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InitFaceVerifyResponse> InitFaceVerifyWithOptionsAsync(InitFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitFaceVerifyResponse>(await DoRPCRequestAsync("InitFaceVerify", "2019-03-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InitFaceVerifyResponse InitFaceVerify(InitFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitFaceVerifyWithOptions(request, runtime);
        }

        public async Task<InitFaceVerifyResponse> InitFaceVerifyAsync(InitFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitFaceVerifyWithOptionsAsync(request, runtime);
        }

    }
}
