// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dypnsapi20170525.Models;

namespace AlibabaCloud.SDK.Dypnsapi20170525
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dypnsapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GetAuthorizationUrlResponse GetAuthorizationUrlWithOptions(GetAuthorizationUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAuthorizationUrlResponse>(DoRPCRequest("GetAuthorizationUrl", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAuthorizationUrlResponse> GetAuthorizationUrlWithOptionsAsync(GetAuthorizationUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAuthorizationUrlResponse>(await DoRPCRequestAsync("GetAuthorizationUrl", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAuthorizationUrlResponse GetAuthorizationUrl(GetAuthorizationUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAuthorizationUrlWithOptions(request, runtime);
        }

        public async Task<GetAuthorizationUrlResponse> GetAuthorizationUrlAsync(GetAuthorizationUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAuthorizationUrlWithOptionsAsync(request, runtime);
        }

        public GetSmsAuthTokensResponse GetSmsAuthTokensWithOptions(GetSmsAuthTokensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSmsAuthTokensResponse>(DoRPCRequest("GetSmsAuthTokens", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSmsAuthTokensResponse> GetSmsAuthTokensWithOptionsAsync(GetSmsAuthTokensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSmsAuthTokensResponse>(await DoRPCRequestAsync("GetSmsAuthTokens", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSmsAuthTokensResponse GetSmsAuthTokens(GetSmsAuthTokensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmsAuthTokensWithOptions(request, runtime);
        }

        public async Task<GetSmsAuthTokensResponse> GetSmsAuthTokensAsync(GetSmsAuthTokensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmsAuthTokensWithOptionsAsync(request, runtime);
        }

        public CreateVerifySchemeResponse CreateVerifySchemeWithOptions(CreateVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVerifySchemeResponse>(DoRPCRequest("CreateVerifyScheme", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVerifySchemeResponse> CreateVerifySchemeWithOptionsAsync(CreateVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVerifySchemeResponse>(await DoRPCRequestAsync("CreateVerifyScheme", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVerifySchemeResponse CreateVerifyScheme(CreateVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVerifySchemeWithOptions(request, runtime);
        }

        public async Task<CreateVerifySchemeResponse> CreateVerifySchemeAsync(CreateVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVerifySchemeWithOptionsAsync(request, runtime);
        }

        public GetSmsCodeResponse GetSmsCodeWithOptions(GetSmsCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSmsCodeResponse>(DoRPCRequest("GetSmsCode", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSmsCodeResponse> GetSmsCodeWithOptionsAsync(GetSmsCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSmsCodeResponse>(await DoRPCRequestAsync("GetSmsCode", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSmsCodeResponse GetSmsCode(GetSmsCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmsCodeWithOptions(request, runtime);
        }

        public async Task<GetSmsCodeResponse> GetSmsCodeAsync(GetSmsCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmsCodeWithOptionsAsync(request, runtime);
        }

        public VerifySmsCodeResponse VerifySmsCodeWithOptions(VerifySmsCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifySmsCodeResponse>(DoRPCRequest("VerifySmsCode", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifySmsCodeResponse> VerifySmsCodeWithOptionsAsync(VerifySmsCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifySmsCodeResponse>(await DoRPCRequestAsync("VerifySmsCode", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifySmsCodeResponse VerifySmsCode(VerifySmsCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifySmsCodeWithOptions(request, runtime);
        }

        public async Task<VerifySmsCodeResponse> VerifySmsCodeAsync(VerifySmsCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifySmsCodeWithOptionsAsync(request, runtime);
        }

        public DeleteVerifySchemeResponse DeleteVerifySchemeWithOptions(DeleteVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVerifySchemeResponse>(DoRPCRequest("DeleteVerifyScheme", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVerifySchemeResponse> DeleteVerifySchemeWithOptionsAsync(DeleteVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVerifySchemeResponse>(await DoRPCRequestAsync("DeleteVerifyScheme", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVerifySchemeResponse DeleteVerifyScheme(DeleteVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVerifySchemeWithOptions(request, runtime);
        }

        public async Task<DeleteVerifySchemeResponse> DeleteVerifySchemeAsync(DeleteVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVerifySchemeWithOptionsAsync(request, runtime);
        }

        public VerifyPhoneWithTokenResponse VerifyPhoneWithTokenWithOptions(VerifyPhoneWithTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyPhoneWithTokenResponse>(DoRPCRequest("VerifyPhoneWithToken", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyPhoneWithTokenResponse> VerifyPhoneWithTokenWithOptionsAsync(VerifyPhoneWithTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyPhoneWithTokenResponse>(await DoRPCRequestAsync("VerifyPhoneWithToken", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyPhoneWithTokenResponse VerifyPhoneWithToken(VerifyPhoneWithTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyPhoneWithTokenWithOptions(request, runtime);
        }

        public async Task<VerifyPhoneWithTokenResponse> VerifyPhoneWithTokenAsync(VerifyPhoneWithTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyPhoneWithTokenWithOptionsAsync(request, runtime);
        }

        public GetMobileResponse GetMobileWithOptions(GetMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMobileResponse>(DoRPCRequest("GetMobile", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMobileResponse> GetMobileWithOptionsAsync(GetMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMobileResponse>(await DoRPCRequestAsync("GetMobile", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMobileResponse GetMobile(GetMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMobileWithOptions(request, runtime);
        }

        public async Task<GetMobileResponse> GetMobileAsync(GetMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMobileWithOptionsAsync(request, runtime);
        }

        public TwiceTelVerifyResponse TwiceTelVerifyWithOptions(TwiceTelVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TwiceTelVerifyResponse>(DoRPCRequest("TwiceTelVerify", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TwiceTelVerifyResponse> TwiceTelVerifyWithOptionsAsync(TwiceTelVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TwiceTelVerifyResponse>(await DoRPCRequestAsync("TwiceTelVerify", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TwiceTelVerifyResponse TwiceTelVerify(TwiceTelVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TwiceTelVerifyWithOptions(request, runtime);
        }

        public async Task<TwiceTelVerifyResponse> TwiceTelVerifyAsync(TwiceTelVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TwiceTelVerifyWithOptionsAsync(request, runtime);
        }

        public GetCertifyResultResponse GetCertifyResultWithOptions(GetCertifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCertifyResultResponse>(DoRPCRequest("GetCertifyResult", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCertifyResultResponse> GetCertifyResultWithOptionsAsync(GetCertifyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCertifyResultResponse>(await DoRPCRequestAsync("GetCertifyResult", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCertifyResultResponse GetCertifyResult(GetCertifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCertifyResultWithOptions(request, runtime);
        }

        public async Task<GetCertifyResultResponse> GetCertifyResultAsync(GetCertifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCertifyResultWithOptionsAsync(request, runtime);
        }

        public DescribeVerifySchemeResponse DescribeVerifySchemeWithOptions(DescribeVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifySchemeResponse>(DoRPCRequest("DescribeVerifyScheme", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVerifySchemeResponse> DescribeVerifySchemeWithOptionsAsync(DescribeVerifySchemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVerifySchemeResponse>(await DoRPCRequestAsync("DescribeVerifyScheme", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVerifySchemeResponse DescribeVerifyScheme(DescribeVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVerifySchemeWithOptions(request, runtime);
        }

        public async Task<DescribeVerifySchemeResponse> DescribeVerifySchemeAsync(DescribeVerifySchemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVerifySchemeWithOptionsAsync(request, runtime);
        }

        public GetAuthTokenResponse GetAuthTokenWithOptions(GetAuthTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAuthTokenResponse>(DoRPCRequest("GetAuthToken", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAuthTokenResponse> GetAuthTokenWithOptionsAsync(GetAuthTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAuthTokenResponse>(await DoRPCRequestAsync("GetAuthToken", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAuthTokenResponse GetAuthToken(GetAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAuthTokenWithOptions(request, runtime);
        }

        public async Task<GetAuthTokenResponse> GetAuthTokenAsync(GetAuthTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAuthTokenWithOptionsAsync(request, runtime);
        }

        public VerifyMobileResponse VerifyMobileWithOptions(VerifyMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyMobileResponse>(DoRPCRequest("VerifyMobile", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyMobileResponse> VerifyMobileWithOptionsAsync(VerifyMobileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyMobileResponse>(await DoRPCRequestAsync("VerifyMobile", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyMobileResponse VerifyMobile(VerifyMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyMobileWithOptions(request, runtime);
        }

        public async Task<VerifyMobileResponse> VerifyMobileAsync(VerifyMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyMobileWithOptionsAsync(request, runtime);
        }

        public CheckServiceLinkedRoleForDeletingResponse CheckServiceLinkedRoleForDeletingWithOptions(CheckServiceLinkedRoleForDeletingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleForDeletingResponse>(DoRPCRequest("CheckServiceLinkedRoleForDeleting", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckServiceLinkedRoleForDeletingResponse> CheckServiceLinkedRoleForDeletingWithOptionsAsync(CheckServiceLinkedRoleForDeletingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleForDeletingResponse>(await DoRPCRequestAsync("CheckServiceLinkedRoleForDeleting", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckServiceLinkedRoleForDeletingResponse CheckServiceLinkedRoleForDeleting(CheckServiceLinkedRoleForDeletingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckServiceLinkedRoleForDeletingWithOptions(request, runtime);
        }

        public async Task<CheckServiceLinkedRoleForDeletingResponse> CheckServiceLinkedRoleForDeletingAsync(CheckServiceLinkedRoleForDeletingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckServiceLinkedRoleForDeletingWithOptionsAsync(request, runtime);
        }

    }
}
