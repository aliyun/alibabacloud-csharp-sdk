// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dyplsapi20170525.Models;

namespace AlibabaCloud.SDK.Dyplsapi20170525
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dyplsapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddAxnTrackNoResponse AddAxnTrackNoWithOptions(AddAxnTrackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAxnTrackNoResponse>(DoRPCRequest("AddAxnTrackNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddAxnTrackNoResponse> AddAxnTrackNoWithOptionsAsync(AddAxnTrackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAxnTrackNoResponse>(await DoRPCRequestAsync("AddAxnTrackNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddAxnTrackNoResponse AddAxnTrackNo(AddAxnTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAxnTrackNoWithOptions(request, runtime);
        }

        public async Task<AddAxnTrackNoResponse> AddAxnTrackNoAsync(AddAxnTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAxnTrackNoWithOptionsAsync(request, runtime);
        }

        public AddSecretBlacklistResponse AddSecretBlacklistWithOptions(AddSecretBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSecretBlacklistResponse>(DoRPCRequest("AddSecretBlacklist", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddSecretBlacklistResponse> AddSecretBlacklistWithOptionsAsync(AddSecretBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSecretBlacklistResponse>(await DoRPCRequestAsync("AddSecretBlacklist", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddSecretBlacklistResponse AddSecretBlacklist(AddSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSecretBlacklistWithOptions(request, runtime);
        }

        public async Task<AddSecretBlacklistResponse> AddSecretBlacklistAsync(AddSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSecretBlacklistWithOptionsAsync(request, runtime);
        }

        public BindAxbResponse BindAxbWithOptions(BindAxbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindAxbResponse>(DoRPCRequest("BindAxb", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindAxbResponse> BindAxbWithOptionsAsync(BindAxbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindAxbResponse>(await DoRPCRequestAsync("BindAxb", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindAxbResponse BindAxb(BindAxbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxbWithOptions(request, runtime);
        }

        public async Task<BindAxbResponse> BindAxbAsync(BindAxbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxbWithOptionsAsync(request, runtime);
        }

        public BindAxgResponse BindAxgWithOptions(BindAxgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindAxgResponse>(DoRPCRequest("BindAxg", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindAxgResponse> BindAxgWithOptionsAsync(BindAxgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindAxgResponse>(await DoRPCRequestAsync("BindAxg", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindAxgResponse BindAxg(BindAxgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxgWithOptions(request, runtime);
        }

        public async Task<BindAxgResponse> BindAxgAsync(BindAxgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxgWithOptionsAsync(request, runtime);
        }

        public BindAxnResponse BindAxnWithOptions(BindAxnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindAxnResponse>(DoRPCRequest("BindAxn", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindAxnResponse> BindAxnWithOptionsAsync(BindAxnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindAxnResponse>(await DoRPCRequestAsync("BindAxn", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindAxnResponse BindAxn(BindAxnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxnWithOptions(request, runtime);
        }

        public async Task<BindAxnResponse> BindAxnAsync(BindAxnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxnWithOptionsAsync(request, runtime);
        }

        public BindAxnExtensionResponse BindAxnExtensionWithOptions(BindAxnExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindAxnExtensionResponse>(DoRPCRequest("BindAxnExtension", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindAxnExtensionResponse> BindAxnExtensionWithOptionsAsync(BindAxnExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindAxnExtensionResponse>(await DoRPCRequestAsync("BindAxnExtension", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindAxnExtensionResponse BindAxnExtension(BindAxnExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAxnExtensionWithOptions(request, runtime);
        }

        public async Task<BindAxnExtensionResponse> BindAxnExtensionAsync(BindAxnExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAxnExtensionWithOptionsAsync(request, runtime);
        }

        public BuySecretNoResponse BuySecretNoWithOptions(BuySecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BuySecretNoResponse>(DoRPCRequest("BuySecretNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BuySecretNoResponse> BuySecretNoWithOptionsAsync(BuySecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BuySecretNoResponse>(await DoRPCRequestAsync("BuySecretNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BuySecretNoResponse BuySecretNo(BuySecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BuySecretNoWithOptions(request, runtime);
        }

        public async Task<BuySecretNoResponse> BuySecretNoAsync(BuySecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BuySecretNoWithOptionsAsync(request, runtime);
        }

        public CreateAxgGroupResponse CreateAxgGroupWithOptions(CreateAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAxgGroupResponse>(DoRPCRequest("CreateAxgGroup", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAxgGroupResponse> CreateAxgGroupWithOptionsAsync(CreateAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAxgGroupResponse>(await DoRPCRequestAsync("CreateAxgGroup", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAxgGroupResponse CreateAxgGroup(CreateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAxgGroupWithOptions(request, runtime);
        }

        public async Task<CreateAxgGroupResponse> CreateAxgGroupAsync(CreateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAxgGroupWithOptionsAsync(request, runtime);
        }

        public CreateSubscriptionResponse CreateSubscriptionWithOptions(CreateSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSubscriptionResponse>(DoRPCRequest("CreateSubscription", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSubscriptionResponse> CreateSubscriptionWithOptionsAsync(CreateSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSubscriptionResponse>(await DoRPCRequestAsync("CreateSubscription", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubscriptionWithOptions(request, runtime);
        }

        public async Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubscriptionWithOptionsAsync(request, runtime);
        }

        public DeleteSecretBlacklistResponse DeleteSecretBlacklistWithOptions(DeleteSecretBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSecretBlacklistResponse>(DoRPCRequest("DeleteSecretBlacklist", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSecretBlacklistResponse> DeleteSecretBlacklistWithOptionsAsync(DeleteSecretBlacklistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSecretBlacklistResponse>(await DoRPCRequestAsync("DeleteSecretBlacklist", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSecretBlacklistResponse DeleteSecretBlacklist(DeleteSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecretBlacklistWithOptions(request, runtime);
        }

        public async Task<DeleteSecretBlacklistResponse> DeleteSecretBlacklistAsync(DeleteSecretBlacklistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecretBlacklistWithOptionsAsync(request, runtime);
        }

        public GetFaceVerifyResponse GetFaceVerifyWithOptions(GetFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFaceVerifyResponse>(DoRPCRequest("GetFaceVerify", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetFaceVerifyResponse> GetFaceVerifyWithOptionsAsync(GetFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFaceVerifyResponse>(await DoRPCRequestAsync("GetFaceVerify", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetFaceVerifyResponse GetFaceVerify(GetFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFaceVerifyWithOptions(request, runtime);
        }

        public async Task<GetFaceVerifyResponse> GetFaceVerifyAsync(GetFaceVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFaceVerifyWithOptionsAsync(request, runtime);
        }

        public GetSecretAsrDetailResponse GetSecretAsrDetailWithOptions(GetSecretAsrDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSecretAsrDetailResponse>(DoRPCRequest("GetSecretAsrDetail", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSecretAsrDetailResponse> GetSecretAsrDetailWithOptionsAsync(GetSecretAsrDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSecretAsrDetailResponse>(await DoRPCRequestAsync("GetSecretAsrDetail", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSecretAsrDetailResponse GetSecretAsrDetail(GetSecretAsrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSecretAsrDetailWithOptions(request, runtime);
        }

        public async Task<GetSecretAsrDetailResponse> GetSecretAsrDetailAsync(GetSecretAsrDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSecretAsrDetailWithOptionsAsync(request, runtime);
        }

        public GetSubscriptionDetailResponse GetSubscriptionDetailWithOptions(GetSubscriptionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSubscriptionDetailResponse>(DoRPCRequest("GetSubscriptionDetail", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSubscriptionDetailResponse> GetSubscriptionDetailWithOptionsAsync(GetSubscriptionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSubscriptionDetailResponse>(await DoRPCRequestAsync("GetSubscriptionDetail", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSubscriptionDetailResponse GetSubscriptionDetail(GetSubscriptionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubscriptionDetailWithOptions(request, runtime);
        }

        public async Task<GetSubscriptionDetailResponse> GetSubscriptionDetailAsync(GetSubscriptionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubscriptionDetailWithOptionsAsync(request, runtime);
        }

        public GetTotalPublicUrlResponse GetTotalPublicUrlWithOptions(GetTotalPublicUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTotalPublicUrlResponse>(DoRPCRequest("GetTotalPublicUrl", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTotalPublicUrlResponse> GetTotalPublicUrlWithOptionsAsync(GetTotalPublicUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTotalPublicUrlResponse>(await DoRPCRequestAsync("GetTotalPublicUrl", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTotalPublicUrlResponse GetTotalPublicUrl(GetTotalPublicUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTotalPublicUrlWithOptions(request, runtime);
        }

        public async Task<GetTotalPublicUrlResponse> GetTotalPublicUrlAsync(GetTotalPublicUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTotalPublicUrlWithOptionsAsync(request, runtime);
        }

        public InitFaceVerifyResponse InitFaceVerifyWithOptions(InitFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitFaceVerifyResponse>(DoRPCRequest("InitFaceVerify", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InitFaceVerifyResponse> InitFaceVerifyWithOptionsAsync(InitFaceVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitFaceVerifyResponse>(await DoRPCRequestAsync("InitFaceVerify", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public LockSecretNoResponse LockSecretNoWithOptions(LockSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LockSecretNoResponse>(DoRPCRequest("LockSecretNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LockSecretNoResponse> LockSecretNoWithOptionsAsync(LockSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LockSecretNoResponse>(await DoRPCRequestAsync("LockSecretNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LockSecretNoResponse LockSecretNo(LockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LockSecretNoWithOptions(request, runtime);
        }

        public async Task<LockSecretNoResponse> LockSecretNoAsync(LockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LockSecretNoWithOptionsAsync(request, runtime);
        }

        public OperateAxgGroupResponse OperateAxgGroupWithOptions(OperateAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OperateAxgGroupResponse>(DoRPCRequest("OperateAxgGroup", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OperateAxgGroupResponse> OperateAxgGroupWithOptionsAsync(OperateAxgGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OperateAxgGroupResponse>(await DoRPCRequestAsync("OperateAxgGroup", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OperateAxgGroupResponse OperateAxgGroup(OperateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateAxgGroupWithOptions(request, runtime);
        }

        public async Task<OperateAxgGroupResponse> OperateAxgGroupAsync(OperateAxgGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateAxgGroupWithOptionsAsync(request, runtime);
        }

        public OperateBlackNoResponse OperateBlackNoWithOptions(OperateBlackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OperateBlackNoResponse>(DoRPCRequest("OperateBlackNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OperateBlackNoResponse> OperateBlackNoWithOptionsAsync(OperateBlackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OperateBlackNoResponse>(await DoRPCRequestAsync("OperateBlackNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OperateBlackNoResponse OperateBlackNo(OperateBlackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateBlackNoWithOptions(request, runtime);
        }

        public async Task<OperateBlackNoResponse> OperateBlackNoAsync(OperateBlackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateBlackNoWithOptionsAsync(request, runtime);
        }

        public QueryCallStatusResponse QueryCallStatusWithOptions(QueryCallStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCallStatusResponse>(DoRPCRequest("QueryCallStatus", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCallStatusResponse> QueryCallStatusWithOptionsAsync(QueryCallStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCallStatusResponse>(await DoRPCRequestAsync("QueryCallStatus", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCallStatusResponse QueryCallStatus(QueryCallStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCallStatusWithOptions(request, runtime);
        }

        public async Task<QueryCallStatusResponse> QueryCallStatusAsync(QueryCallStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCallStatusWithOptionsAsync(request, runtime);
        }

        public QueryPhoneNoAByTrackNoResponse QueryPhoneNoAByTrackNoWithOptions(QueryPhoneNoAByTrackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPhoneNoAByTrackNoResponse>(DoRPCRequest("QueryPhoneNoAByTrackNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPhoneNoAByTrackNoResponse> QueryPhoneNoAByTrackNoWithOptionsAsync(QueryPhoneNoAByTrackNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPhoneNoAByTrackNoResponse>(await DoRPCRequestAsync("QueryPhoneNoAByTrackNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPhoneNoAByTrackNoResponse QueryPhoneNoAByTrackNo(QueryPhoneNoAByTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPhoneNoAByTrackNoWithOptions(request, runtime);
        }

        public async Task<QueryPhoneNoAByTrackNoResponse> QueryPhoneNoAByTrackNoAsync(QueryPhoneNoAByTrackNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPhoneNoAByTrackNoWithOptionsAsync(request, runtime);
        }

        public QueryRecordFileDownloadUrlResponse QueryRecordFileDownloadUrlWithOptions(QueryRecordFileDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordFileDownloadUrlResponse>(DoRPCRequest("QueryRecordFileDownloadUrl", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRecordFileDownloadUrlResponse> QueryRecordFileDownloadUrlWithOptionsAsync(QueryRecordFileDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRecordFileDownloadUrlResponse>(await DoRPCRequestAsync("QueryRecordFileDownloadUrl", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryRecordFileDownloadUrlResponse QueryRecordFileDownloadUrl(QueryRecordFileDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRecordFileDownloadUrlWithOptions(request, runtime);
        }

        public async Task<QueryRecordFileDownloadUrlResponse> QueryRecordFileDownloadUrlAsync(QueryRecordFileDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRecordFileDownloadUrlWithOptionsAsync(request, runtime);
        }

        public QuerySecretNoRemainResponse QuerySecretNoRemainWithOptions(QuerySecretNoRemainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySecretNoRemainResponse>(DoRPCRequest("QuerySecretNoRemain", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySecretNoRemainResponse> QuerySecretNoRemainWithOptionsAsync(QuerySecretNoRemainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySecretNoRemainResponse>(await DoRPCRequestAsync("QuerySecretNoRemain", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySecretNoRemainResponse QuerySecretNoRemain(QuerySecretNoRemainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySecretNoRemainWithOptions(request, runtime);
        }

        public async Task<QuerySecretNoRemainResponse> QuerySecretNoRemainAsync(QuerySecretNoRemainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySecretNoRemainWithOptionsAsync(request, runtime);
        }

        public QuerySubscriptionDetailResponse QuerySubscriptionDetailWithOptions(QuerySubscriptionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySubscriptionDetailResponse>(DoRPCRequest("QuerySubscriptionDetail", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySubscriptionDetailResponse> QuerySubscriptionDetailWithOptionsAsync(QuerySubscriptionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySubscriptionDetailResponse>(await DoRPCRequestAsync("QuerySubscriptionDetail", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySubscriptionDetailResponse QuerySubscriptionDetail(QuerySubscriptionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySubscriptionDetailWithOptions(request, runtime);
        }

        public async Task<QuerySubscriptionDetailResponse> QuerySubscriptionDetailAsync(QuerySubscriptionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySubscriptionDetailWithOptionsAsync(request, runtime);
        }

        public QuerySubsIdResponse QuerySubsIdWithOptions(QuerySubsIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySubsIdResponse>(DoRPCRequest("QuerySubsId", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QuerySubsIdResponse> QuerySubsIdWithOptionsAsync(QuerySubsIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QuerySubsIdResponse>(await DoRPCRequestAsync("QuerySubsId", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QuerySubsIdResponse QuerySubsId(QuerySubsIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySubsIdWithOptions(request, runtime);
        }

        public async Task<QuerySubsIdResponse> QuerySubsIdAsync(QuerySubsIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySubsIdWithOptionsAsync(request, runtime);
        }

        public ReleaseSecretNoResponse ReleaseSecretNoWithOptions(ReleaseSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseSecretNoResponse>(DoRPCRequest("ReleaseSecretNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseSecretNoResponse> ReleaseSecretNoWithOptionsAsync(ReleaseSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseSecretNoResponse>(await DoRPCRequestAsync("ReleaseSecretNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseSecretNoResponse ReleaseSecretNo(ReleaseSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseSecretNoWithOptions(request, runtime);
        }

        public async Task<ReleaseSecretNoResponse> ReleaseSecretNoAsync(ReleaseSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseSecretNoWithOptionsAsync(request, runtime);
        }

        public UnbindSubscriptionResponse UnbindSubscriptionWithOptions(UnbindSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindSubscriptionResponse>(DoRPCRequest("UnbindSubscription", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindSubscriptionResponse> UnbindSubscriptionWithOptionsAsync(UnbindSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindSubscriptionResponse>(await DoRPCRequestAsync("UnbindSubscription", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindSubscriptionResponse UnbindSubscription(UnbindSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindSubscriptionWithOptions(request, runtime);
        }

        public async Task<UnbindSubscriptionResponse> UnbindSubscriptionAsync(UnbindSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindSubscriptionWithOptionsAsync(request, runtime);
        }

        public UnlockSecretNoResponse UnlockSecretNoWithOptions(UnlockSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnlockSecretNoResponse>(DoRPCRequest("UnlockSecretNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnlockSecretNoResponse> UnlockSecretNoWithOptionsAsync(UnlockSecretNoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnlockSecretNoResponse>(await DoRPCRequestAsync("UnlockSecretNo", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnlockSecretNoResponse UnlockSecretNo(UnlockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockSecretNoWithOptions(request, runtime);
        }

        public async Task<UnlockSecretNoResponse> UnlockSecretNoAsync(UnlockSecretNoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockSecretNoWithOptionsAsync(request, runtime);
        }

        public UpdateDefaultBResponse UpdateDefaultBWithOptions(UpdateDefaultBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDefaultBResponse>(DoRPCRequest("UpdateDefaultB", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDefaultBResponse> UpdateDefaultBWithOptionsAsync(UpdateDefaultBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDefaultBResponse>(await DoRPCRequestAsync("UpdateDefaultB", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDefaultBResponse UpdateDefaultB(UpdateDefaultBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDefaultBWithOptions(request, runtime);
        }

        public async Task<UpdateDefaultBResponse> UpdateDefaultBAsync(UpdateDefaultBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDefaultBWithOptionsAsync(request, runtime);
        }

        public UpdatePhoneNumberResponse UpdatePhoneNumberWithOptions(UpdatePhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePhoneNumberResponse>(DoRPCRequest("UpdatePhoneNumber", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdatePhoneNumberResponse> UpdatePhoneNumberWithOptionsAsync(UpdatePhoneNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePhoneNumberResponse>(await DoRPCRequestAsync("UpdatePhoneNumber", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdatePhoneNumberResponse UpdatePhoneNumber(UpdatePhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePhoneNumberWithOptions(request, runtime);
        }

        public async Task<UpdatePhoneNumberResponse> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePhoneNumberWithOptionsAsync(request, runtime);
        }

        public UpdatePhoneSwitchResponse UpdatePhoneSwitchWithOptions(UpdatePhoneSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePhoneSwitchResponse>(DoRPCRequest("UpdatePhoneSwitch", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdatePhoneSwitchResponse> UpdatePhoneSwitchWithOptionsAsync(UpdatePhoneSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePhoneSwitchResponse>(await DoRPCRequestAsync("UpdatePhoneSwitch", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdatePhoneSwitchResponse UpdatePhoneSwitch(UpdatePhoneSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePhoneSwitchWithOptions(request, runtime);
        }

        public async Task<UpdatePhoneSwitchResponse> UpdatePhoneSwitchAsync(UpdatePhoneSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePhoneSwitchWithOptionsAsync(request, runtime);
        }

        public UpdateSubscriptionResponse UpdateSubscriptionWithOptions(UpdateSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(DoRPCRequest("UpdateSubscription", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionWithOptionsAsync(UpdateSubscriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSubscriptionResponse>(await DoRPCRequestAsync("UpdateSubscription", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSubscriptionWithOptions(request, runtime);
        }

        public async Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSubscriptionWithOptionsAsync(request, runtime);
        }

    }
}
