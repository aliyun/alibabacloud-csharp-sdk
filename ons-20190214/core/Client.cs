// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ons20190214.Models;

namespace AlibabaCloud.SDK.Ons20190214
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "ons.ap-northeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "ons.aliyuncs.com"},
                {"cn-beijing-finance-pop", "ons.aliyuncs.com"},
                {"cn-beijing-gov-1", "ons.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "ons.aliyuncs.com"},
                {"cn-edge-1", "ons.aliyuncs.com"},
                {"cn-fujian", "ons.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "ons.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "ons.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "ons.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "ons.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "ons.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "ons.aliyuncs.com"},
                {"cn-hangzhou-test-306", "ons.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "ons.aliyuncs.com"},
                {"cn-qingdao-nebula", "ons.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "ons.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "ons.aliyuncs.com"},
                {"cn-shanghai-inner", "ons.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "ons.aliyuncs.com"},
                {"cn-shenzhen-inner", "ons.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "ons.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "ons.aliyuncs.com"},
                {"cn-wuhan", "ons.aliyuncs.com"},
                {"cn-yushanfang", "ons.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "ons.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "ons.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "ons.aliyuncs.com"},
                {"eu-west-1-oxs", "ons.ap-northeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "ons.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ons", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        public OnsConsumerAccumulateResponse OnsConsumerAccumulateWithOptions(OnsConsumerAccumulateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsConsumerAccumulateResponse>(DoRPCRequest("OnsConsumerAccumulate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsConsumerAccumulateResponse> OnsConsumerAccumulateWithOptionsAsync(OnsConsumerAccumulateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsConsumerAccumulateResponse>(await DoRPCRequestAsync("OnsConsumerAccumulate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsConsumerAccumulateResponse OnsConsumerAccumulate(OnsConsumerAccumulateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsConsumerAccumulateWithOptions(request, runtime);
        }

        public async Task<OnsConsumerAccumulateResponse> OnsConsumerAccumulateAsync(OnsConsumerAccumulateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsConsumerAccumulateWithOptionsAsync(request, runtime);
        }

        public OnsConsumerGetConnectionResponse OnsConsumerGetConnectionWithOptions(OnsConsumerGetConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsConsumerGetConnectionResponse>(DoRPCRequest("OnsConsumerGetConnection", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsConsumerGetConnectionResponse> OnsConsumerGetConnectionWithOptionsAsync(OnsConsumerGetConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsConsumerGetConnectionResponse>(await DoRPCRequestAsync("OnsConsumerGetConnection", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsConsumerGetConnectionResponse OnsConsumerGetConnection(OnsConsumerGetConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsConsumerGetConnectionWithOptions(request, runtime);
        }

        public async Task<OnsConsumerGetConnectionResponse> OnsConsumerGetConnectionAsync(OnsConsumerGetConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsConsumerGetConnectionWithOptionsAsync(request, runtime);
        }

        public OnsConsumerResetOffsetResponse OnsConsumerResetOffsetWithOptions(OnsConsumerResetOffsetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsConsumerResetOffsetResponse>(DoRPCRequest("OnsConsumerResetOffset", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsConsumerResetOffsetResponse> OnsConsumerResetOffsetWithOptionsAsync(OnsConsumerResetOffsetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsConsumerResetOffsetResponse>(await DoRPCRequestAsync("OnsConsumerResetOffset", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsConsumerResetOffsetResponse OnsConsumerResetOffset(OnsConsumerResetOffsetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsConsumerResetOffsetWithOptions(request, runtime);
        }

        public async Task<OnsConsumerResetOffsetResponse> OnsConsumerResetOffsetAsync(OnsConsumerResetOffsetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsConsumerResetOffsetWithOptionsAsync(request, runtime);
        }

        public OnsConsumerStatusResponse OnsConsumerStatusWithOptions(OnsConsumerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsConsumerStatusResponse>(DoRPCRequest("OnsConsumerStatus", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsConsumerStatusResponse> OnsConsumerStatusWithOptionsAsync(OnsConsumerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsConsumerStatusResponse>(await DoRPCRequestAsync("OnsConsumerStatus", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsConsumerStatusResponse OnsConsumerStatus(OnsConsumerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsConsumerStatusWithOptions(request, runtime);
        }

        public async Task<OnsConsumerStatusResponse> OnsConsumerStatusAsync(OnsConsumerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsConsumerStatusWithOptionsAsync(request, runtime);
        }

        public OnsConsumerTimeSpanResponse OnsConsumerTimeSpanWithOptions(OnsConsumerTimeSpanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsConsumerTimeSpanResponse>(DoRPCRequest("OnsConsumerTimeSpan", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsConsumerTimeSpanResponse> OnsConsumerTimeSpanWithOptionsAsync(OnsConsumerTimeSpanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsConsumerTimeSpanResponse>(await DoRPCRequestAsync("OnsConsumerTimeSpan", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsConsumerTimeSpanResponse OnsConsumerTimeSpan(OnsConsumerTimeSpanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsConsumerTimeSpanWithOptions(request, runtime);
        }

        public async Task<OnsConsumerTimeSpanResponse> OnsConsumerTimeSpanAsync(OnsConsumerTimeSpanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsConsumerTimeSpanWithOptionsAsync(request, runtime);
        }

        public OnsDLQMessageGetByIdResponse OnsDLQMessageGetByIdWithOptions(OnsDLQMessageGetByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsDLQMessageGetByIdResponse>(DoRPCRequest("OnsDLQMessageGetById", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsDLQMessageGetByIdResponse> OnsDLQMessageGetByIdWithOptionsAsync(OnsDLQMessageGetByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsDLQMessageGetByIdResponse>(await DoRPCRequestAsync("OnsDLQMessageGetById", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsDLQMessageGetByIdResponse OnsDLQMessageGetById(OnsDLQMessageGetByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsDLQMessageGetByIdWithOptions(request, runtime);
        }

        public async Task<OnsDLQMessageGetByIdResponse> OnsDLQMessageGetByIdAsync(OnsDLQMessageGetByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsDLQMessageGetByIdWithOptionsAsync(request, runtime);
        }

        public OnsDLQMessagePageQueryByGroupIdResponse OnsDLQMessagePageQueryByGroupIdWithOptions(OnsDLQMessagePageQueryByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsDLQMessagePageQueryByGroupIdResponse>(DoRPCRequest("OnsDLQMessagePageQueryByGroupId", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsDLQMessagePageQueryByGroupIdResponse> OnsDLQMessagePageQueryByGroupIdWithOptionsAsync(OnsDLQMessagePageQueryByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsDLQMessagePageQueryByGroupIdResponse>(await DoRPCRequestAsync("OnsDLQMessagePageQueryByGroupId", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsDLQMessagePageQueryByGroupIdResponse OnsDLQMessagePageQueryByGroupId(OnsDLQMessagePageQueryByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsDLQMessagePageQueryByGroupIdWithOptions(request, runtime);
        }

        public async Task<OnsDLQMessagePageQueryByGroupIdResponse> OnsDLQMessagePageQueryByGroupIdAsync(OnsDLQMessagePageQueryByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsDLQMessagePageQueryByGroupIdWithOptionsAsync(request, runtime);
        }

        public OnsDLQMessageResendByIdResponse OnsDLQMessageResendByIdWithOptions(OnsDLQMessageResendByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsDLQMessageResendByIdResponse>(DoRPCRequest("OnsDLQMessageResendById", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsDLQMessageResendByIdResponse> OnsDLQMessageResendByIdWithOptionsAsync(OnsDLQMessageResendByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsDLQMessageResendByIdResponse>(await DoRPCRequestAsync("OnsDLQMessageResendById", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsDLQMessageResendByIdResponse OnsDLQMessageResendById(OnsDLQMessageResendByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsDLQMessageResendByIdWithOptions(request, runtime);
        }

        public async Task<OnsDLQMessageResendByIdResponse> OnsDLQMessageResendByIdAsync(OnsDLQMessageResendByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsDLQMessageResendByIdWithOptionsAsync(request, runtime);
        }

        public OnsGroupConsumerUpdateResponse OnsGroupConsumerUpdateWithOptions(OnsGroupConsumerUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsGroupConsumerUpdateResponse>(DoRPCRequest("OnsGroupConsumerUpdate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsGroupConsumerUpdateResponse> OnsGroupConsumerUpdateWithOptionsAsync(OnsGroupConsumerUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsGroupConsumerUpdateResponse>(await DoRPCRequestAsync("OnsGroupConsumerUpdate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsGroupConsumerUpdateResponse OnsGroupConsumerUpdate(OnsGroupConsumerUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsGroupConsumerUpdateWithOptions(request, runtime);
        }

        public async Task<OnsGroupConsumerUpdateResponse> OnsGroupConsumerUpdateAsync(OnsGroupConsumerUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsGroupConsumerUpdateWithOptionsAsync(request, runtime);
        }

        public OnsGroupCreateResponse OnsGroupCreateWithOptions(OnsGroupCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsGroupCreateResponse>(DoRPCRequest("OnsGroupCreate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsGroupCreateResponse> OnsGroupCreateWithOptionsAsync(OnsGroupCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsGroupCreateResponse>(await DoRPCRequestAsync("OnsGroupCreate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsGroupCreateResponse OnsGroupCreate(OnsGroupCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsGroupCreateWithOptions(request, runtime);
        }

        public async Task<OnsGroupCreateResponse> OnsGroupCreateAsync(OnsGroupCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsGroupCreateWithOptionsAsync(request, runtime);
        }

        public OnsGroupDeleteResponse OnsGroupDeleteWithOptions(OnsGroupDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsGroupDeleteResponse>(DoRPCRequest("OnsGroupDelete", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsGroupDeleteResponse> OnsGroupDeleteWithOptionsAsync(OnsGroupDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsGroupDeleteResponse>(await DoRPCRequestAsync("OnsGroupDelete", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsGroupDeleteResponse OnsGroupDelete(OnsGroupDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsGroupDeleteWithOptions(request, runtime);
        }

        public async Task<OnsGroupDeleteResponse> OnsGroupDeleteAsync(OnsGroupDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsGroupDeleteWithOptionsAsync(request, runtime);
        }

        public OnsGroupListResponse OnsGroupListWithOptions(OnsGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsGroupListResponse>(DoRPCRequest("OnsGroupList", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsGroupListResponse> OnsGroupListWithOptionsAsync(OnsGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsGroupListResponse>(await DoRPCRequestAsync("OnsGroupList", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsGroupListResponse OnsGroupList(OnsGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsGroupListWithOptions(request, runtime);
        }

        public async Task<OnsGroupListResponse> OnsGroupListAsync(OnsGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsGroupListWithOptionsAsync(request, runtime);
        }

        public OnsGroupSubDetailResponse OnsGroupSubDetailWithOptions(OnsGroupSubDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsGroupSubDetailResponse>(DoRPCRequest("OnsGroupSubDetail", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsGroupSubDetailResponse> OnsGroupSubDetailWithOptionsAsync(OnsGroupSubDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsGroupSubDetailResponse>(await DoRPCRequestAsync("OnsGroupSubDetail", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsGroupSubDetailResponse OnsGroupSubDetail(OnsGroupSubDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsGroupSubDetailWithOptions(request, runtime);
        }

        public async Task<OnsGroupSubDetailResponse> OnsGroupSubDetailAsync(OnsGroupSubDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsGroupSubDetailWithOptionsAsync(request, runtime);
        }

        public OnsInstanceBaseInfoResponse OnsInstanceBaseInfoWithOptions(OnsInstanceBaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsInstanceBaseInfoResponse>(DoRPCRequest("OnsInstanceBaseInfo", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsInstanceBaseInfoResponse> OnsInstanceBaseInfoWithOptionsAsync(OnsInstanceBaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsInstanceBaseInfoResponse>(await DoRPCRequestAsync("OnsInstanceBaseInfo", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsInstanceBaseInfoResponse OnsInstanceBaseInfo(OnsInstanceBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsInstanceBaseInfoWithOptions(request, runtime);
        }

        public async Task<OnsInstanceBaseInfoResponse> OnsInstanceBaseInfoAsync(OnsInstanceBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsInstanceBaseInfoWithOptionsAsync(request, runtime);
        }

        public OnsInstanceCreateResponse OnsInstanceCreateWithOptions(OnsInstanceCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsInstanceCreateResponse>(DoRPCRequest("OnsInstanceCreate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsInstanceCreateResponse> OnsInstanceCreateWithOptionsAsync(OnsInstanceCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsInstanceCreateResponse>(await DoRPCRequestAsync("OnsInstanceCreate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsInstanceCreateResponse OnsInstanceCreate(OnsInstanceCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsInstanceCreateWithOptions(request, runtime);
        }

        public async Task<OnsInstanceCreateResponse> OnsInstanceCreateAsync(OnsInstanceCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsInstanceCreateWithOptionsAsync(request, runtime);
        }

        public OnsInstanceDeleteResponse OnsInstanceDeleteWithOptions(OnsInstanceDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsInstanceDeleteResponse>(DoRPCRequest("OnsInstanceDelete", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsInstanceDeleteResponse> OnsInstanceDeleteWithOptionsAsync(OnsInstanceDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsInstanceDeleteResponse>(await DoRPCRequestAsync("OnsInstanceDelete", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsInstanceDeleteResponse OnsInstanceDelete(OnsInstanceDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsInstanceDeleteWithOptions(request, runtime);
        }

        public async Task<OnsInstanceDeleteResponse> OnsInstanceDeleteAsync(OnsInstanceDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsInstanceDeleteWithOptionsAsync(request, runtime);
        }

        public OnsInstanceInServiceListResponse OnsInstanceInServiceListWithOptions(OnsInstanceInServiceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsInstanceInServiceListResponse>(DoRPCRequest("OnsInstanceInServiceList", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsInstanceInServiceListResponse> OnsInstanceInServiceListWithOptionsAsync(OnsInstanceInServiceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsInstanceInServiceListResponse>(await DoRPCRequestAsync("OnsInstanceInServiceList", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsInstanceInServiceListResponse OnsInstanceInServiceList(OnsInstanceInServiceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsInstanceInServiceListWithOptions(request, runtime);
        }

        public async Task<OnsInstanceInServiceListResponse> OnsInstanceInServiceListAsync(OnsInstanceInServiceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsInstanceInServiceListWithOptionsAsync(request, runtime);
        }

        public OnsInstanceUpdateResponse OnsInstanceUpdateWithOptions(OnsInstanceUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsInstanceUpdateResponse>(DoRPCRequest("OnsInstanceUpdate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsInstanceUpdateResponse> OnsInstanceUpdateWithOptionsAsync(OnsInstanceUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsInstanceUpdateResponse>(await DoRPCRequestAsync("OnsInstanceUpdate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsInstanceUpdateResponse OnsInstanceUpdate(OnsInstanceUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsInstanceUpdateWithOptions(request, runtime);
        }

        public async Task<OnsInstanceUpdateResponse> OnsInstanceUpdateAsync(OnsInstanceUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsInstanceUpdateWithOptionsAsync(request, runtime);
        }

        public OnsMessageGetByKeyResponse OnsMessageGetByKeyWithOptions(OnsMessageGetByKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMessageGetByKeyResponse>(DoRPCRequest("OnsMessageGetByKey", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMessageGetByKeyResponse> OnsMessageGetByKeyWithOptionsAsync(OnsMessageGetByKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMessageGetByKeyResponse>(await DoRPCRequestAsync("OnsMessageGetByKey", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMessageGetByKeyResponse OnsMessageGetByKey(OnsMessageGetByKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMessageGetByKeyWithOptions(request, runtime);
        }

        public async Task<OnsMessageGetByKeyResponse> OnsMessageGetByKeyAsync(OnsMessageGetByKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMessageGetByKeyWithOptionsAsync(request, runtime);
        }

        public OnsMessageGetByMsgIdResponse OnsMessageGetByMsgIdWithOptions(OnsMessageGetByMsgIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMessageGetByMsgIdResponse>(DoRPCRequest("OnsMessageGetByMsgId", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMessageGetByMsgIdResponse> OnsMessageGetByMsgIdWithOptionsAsync(OnsMessageGetByMsgIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMessageGetByMsgIdResponse>(await DoRPCRequestAsync("OnsMessageGetByMsgId", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMessageGetByMsgIdResponse OnsMessageGetByMsgId(OnsMessageGetByMsgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMessageGetByMsgIdWithOptions(request, runtime);
        }

        public async Task<OnsMessageGetByMsgIdResponse> OnsMessageGetByMsgIdAsync(OnsMessageGetByMsgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMessageGetByMsgIdWithOptionsAsync(request, runtime);
        }

        public OnsMessagePageQueryByTopicResponse OnsMessagePageQueryByTopicWithOptions(OnsMessagePageQueryByTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMessagePageQueryByTopicResponse>(DoRPCRequest("OnsMessagePageQueryByTopic", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMessagePageQueryByTopicResponse> OnsMessagePageQueryByTopicWithOptionsAsync(OnsMessagePageQueryByTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMessagePageQueryByTopicResponse>(await DoRPCRequestAsync("OnsMessagePageQueryByTopic", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMessagePageQueryByTopicResponse OnsMessagePageQueryByTopic(OnsMessagePageQueryByTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMessagePageQueryByTopicWithOptions(request, runtime);
        }

        public async Task<OnsMessagePageQueryByTopicResponse> OnsMessagePageQueryByTopicAsync(OnsMessagePageQueryByTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMessagePageQueryByTopicWithOptionsAsync(request, runtime);
        }

        public OnsMessagePushResponse OnsMessagePushWithOptions(OnsMessagePushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMessagePushResponse>(DoRPCRequest("OnsMessagePush", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMessagePushResponse> OnsMessagePushWithOptionsAsync(OnsMessagePushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMessagePushResponse>(await DoRPCRequestAsync("OnsMessagePush", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMessagePushResponse OnsMessagePush(OnsMessagePushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMessagePushWithOptions(request, runtime);
        }

        public async Task<OnsMessagePushResponse> OnsMessagePushAsync(OnsMessagePushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMessagePushWithOptionsAsync(request, runtime);
        }

        public OnsMessageSendResponse OnsMessageSendWithOptions(OnsMessageSendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMessageSendResponse>(DoRPCRequest("OnsMessageSend", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMessageSendResponse> OnsMessageSendWithOptionsAsync(OnsMessageSendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMessageSendResponse>(await DoRPCRequestAsync("OnsMessageSend", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMessageSendResponse OnsMessageSend(OnsMessageSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMessageSendWithOptions(request, runtime);
        }

        public async Task<OnsMessageSendResponse> OnsMessageSendAsync(OnsMessageSendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMessageSendWithOptionsAsync(request, runtime);
        }

        public OnsMessageTraceResponse OnsMessageTraceWithOptions(OnsMessageTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMessageTraceResponse>(DoRPCRequest("OnsMessageTrace", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMessageTraceResponse> OnsMessageTraceWithOptionsAsync(OnsMessageTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMessageTraceResponse>(await DoRPCRequestAsync("OnsMessageTrace", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMessageTraceResponse OnsMessageTrace(OnsMessageTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMessageTraceWithOptions(request, runtime);
        }

        public async Task<OnsMessageTraceResponse> OnsMessageTraceAsync(OnsMessageTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMessageTraceWithOptionsAsync(request, runtime);
        }

        public OnsMqttGroupIdCreateResponse OnsMqttGroupIdCreateWithOptions(OnsMqttGroupIdCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttGroupIdCreateResponse>(DoRPCRequest("OnsMqttGroupIdCreate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMqttGroupIdCreateResponse> OnsMqttGroupIdCreateWithOptionsAsync(OnsMqttGroupIdCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttGroupIdCreateResponse>(await DoRPCRequestAsync("OnsMqttGroupIdCreate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMqttGroupIdCreateResponse OnsMqttGroupIdCreate(OnsMqttGroupIdCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMqttGroupIdCreateWithOptions(request, runtime);
        }

        public async Task<OnsMqttGroupIdCreateResponse> OnsMqttGroupIdCreateAsync(OnsMqttGroupIdCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMqttGroupIdCreateWithOptionsAsync(request, runtime);
        }

        public OnsMqttGroupIdDeleteResponse OnsMqttGroupIdDeleteWithOptions(OnsMqttGroupIdDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttGroupIdDeleteResponse>(DoRPCRequest("OnsMqttGroupIdDelete", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMqttGroupIdDeleteResponse> OnsMqttGroupIdDeleteWithOptionsAsync(OnsMqttGroupIdDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttGroupIdDeleteResponse>(await DoRPCRequestAsync("OnsMqttGroupIdDelete", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMqttGroupIdDeleteResponse OnsMqttGroupIdDelete(OnsMqttGroupIdDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMqttGroupIdDeleteWithOptions(request, runtime);
        }

        public async Task<OnsMqttGroupIdDeleteResponse> OnsMqttGroupIdDeleteAsync(OnsMqttGroupIdDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMqttGroupIdDeleteWithOptionsAsync(request, runtime);
        }

        public OnsMqttGroupIdListResponse OnsMqttGroupIdListWithOptions(OnsMqttGroupIdListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttGroupIdListResponse>(DoRPCRequest("OnsMqttGroupIdList", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMqttGroupIdListResponse> OnsMqttGroupIdListWithOptionsAsync(OnsMqttGroupIdListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttGroupIdListResponse>(await DoRPCRequestAsync("OnsMqttGroupIdList", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMqttGroupIdListResponse OnsMqttGroupIdList(OnsMqttGroupIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMqttGroupIdListWithOptions(request, runtime);
        }

        public async Task<OnsMqttGroupIdListResponse> OnsMqttGroupIdListAsync(OnsMqttGroupIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMqttGroupIdListWithOptionsAsync(request, runtime);
        }

        public OnsMqttQueryClientByClientIdResponse OnsMqttQueryClientByClientIdWithOptions(OnsMqttQueryClientByClientIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttQueryClientByClientIdResponse>(DoRPCRequest("OnsMqttQueryClientByClientId", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMqttQueryClientByClientIdResponse> OnsMqttQueryClientByClientIdWithOptionsAsync(OnsMqttQueryClientByClientIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttQueryClientByClientIdResponse>(await DoRPCRequestAsync("OnsMqttQueryClientByClientId", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMqttQueryClientByClientIdResponse OnsMqttQueryClientByClientId(OnsMqttQueryClientByClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMqttQueryClientByClientIdWithOptions(request, runtime);
        }

        public async Task<OnsMqttQueryClientByClientIdResponse> OnsMqttQueryClientByClientIdAsync(OnsMqttQueryClientByClientIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMqttQueryClientByClientIdWithOptionsAsync(request, runtime);
        }

        public OnsMqttQueryClientByGroupIdResponse OnsMqttQueryClientByGroupIdWithOptions(OnsMqttQueryClientByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttQueryClientByGroupIdResponse>(DoRPCRequest("OnsMqttQueryClientByGroupId", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMqttQueryClientByGroupIdResponse> OnsMqttQueryClientByGroupIdWithOptionsAsync(OnsMqttQueryClientByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttQueryClientByGroupIdResponse>(await DoRPCRequestAsync("OnsMqttQueryClientByGroupId", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMqttQueryClientByGroupIdResponse OnsMqttQueryClientByGroupId(OnsMqttQueryClientByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMqttQueryClientByGroupIdWithOptions(request, runtime);
        }

        public async Task<OnsMqttQueryClientByGroupIdResponse> OnsMqttQueryClientByGroupIdAsync(OnsMqttQueryClientByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMqttQueryClientByGroupIdWithOptionsAsync(request, runtime);
        }

        public OnsMqttQueryClientByTopicResponse OnsMqttQueryClientByTopicWithOptions(OnsMqttQueryClientByTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttQueryClientByTopicResponse>(DoRPCRequest("OnsMqttQueryClientByTopic", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMqttQueryClientByTopicResponse> OnsMqttQueryClientByTopicWithOptionsAsync(OnsMqttQueryClientByTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttQueryClientByTopicResponse>(await DoRPCRequestAsync("OnsMqttQueryClientByTopic", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMqttQueryClientByTopicResponse OnsMqttQueryClientByTopic(OnsMqttQueryClientByTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMqttQueryClientByTopicWithOptions(request, runtime);
        }

        public async Task<OnsMqttQueryClientByTopicResponse> OnsMqttQueryClientByTopicAsync(OnsMqttQueryClientByTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMqttQueryClientByTopicWithOptionsAsync(request, runtime);
        }

        public OnsMqttQueryHistoryOnlineResponse OnsMqttQueryHistoryOnlineWithOptions(OnsMqttQueryHistoryOnlineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttQueryHistoryOnlineResponse>(DoRPCRequest("OnsMqttQueryHistoryOnline", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMqttQueryHistoryOnlineResponse> OnsMqttQueryHistoryOnlineWithOptionsAsync(OnsMqttQueryHistoryOnlineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttQueryHistoryOnlineResponse>(await DoRPCRequestAsync("OnsMqttQueryHistoryOnline", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMqttQueryHistoryOnlineResponse OnsMqttQueryHistoryOnline(OnsMqttQueryHistoryOnlineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMqttQueryHistoryOnlineWithOptions(request, runtime);
        }

        public async Task<OnsMqttQueryHistoryOnlineResponse> OnsMqttQueryHistoryOnlineAsync(OnsMqttQueryHistoryOnlineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMqttQueryHistoryOnlineWithOptionsAsync(request, runtime);
        }

        public OnsMqttQueryMsgTransTrendResponse OnsMqttQueryMsgTransTrendWithOptions(OnsMqttQueryMsgTransTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttQueryMsgTransTrendResponse>(DoRPCRequest("OnsMqttQueryMsgTransTrend", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsMqttQueryMsgTransTrendResponse> OnsMqttQueryMsgTransTrendWithOptionsAsync(OnsMqttQueryMsgTransTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsMqttQueryMsgTransTrendResponse>(await DoRPCRequestAsync("OnsMqttQueryMsgTransTrend", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsMqttQueryMsgTransTrendResponse OnsMqttQueryMsgTransTrend(OnsMqttQueryMsgTransTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMqttQueryMsgTransTrendWithOptions(request, runtime);
        }

        public async Task<OnsMqttQueryMsgTransTrendResponse> OnsMqttQueryMsgTransTrendAsync(OnsMqttQueryMsgTransTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMqttQueryMsgTransTrendWithOptionsAsync(request, runtime);
        }

        public OnsRegionListResponse OnsRegionListWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<OnsRegionListResponse>(DoRPCRequest("OnsRegionList", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsRegionListResponse> OnsRegionListWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<OnsRegionListResponse>(await DoRPCRequestAsync("OnsRegionList", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsRegionListResponse OnsRegionList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsRegionListWithOptions(runtime);
        }

        public async Task<OnsRegionListResponse> OnsRegionListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsRegionListWithOptionsAsync(runtime);
        }

        public OnsTopicCreateResponse OnsTopicCreateWithOptions(OnsTopicCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTopicCreateResponse>(DoRPCRequest("OnsTopicCreate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsTopicCreateResponse> OnsTopicCreateWithOptionsAsync(OnsTopicCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTopicCreateResponse>(await DoRPCRequestAsync("OnsTopicCreate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsTopicCreateResponse OnsTopicCreate(OnsTopicCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTopicCreateWithOptions(request, runtime);
        }

        public async Task<OnsTopicCreateResponse> OnsTopicCreateAsync(OnsTopicCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTopicCreateWithOptionsAsync(request, runtime);
        }

        public OnsTopicDeleteResponse OnsTopicDeleteWithOptions(OnsTopicDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTopicDeleteResponse>(DoRPCRequest("OnsTopicDelete", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsTopicDeleteResponse> OnsTopicDeleteWithOptionsAsync(OnsTopicDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTopicDeleteResponse>(await DoRPCRequestAsync("OnsTopicDelete", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsTopicDeleteResponse OnsTopicDelete(OnsTopicDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTopicDeleteWithOptions(request, runtime);
        }

        public async Task<OnsTopicDeleteResponse> OnsTopicDeleteAsync(OnsTopicDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTopicDeleteWithOptionsAsync(request, runtime);
        }

        public OnsTopicListResponse OnsTopicListWithOptions(OnsTopicListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTopicListResponse>(DoRPCRequest("OnsTopicList", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsTopicListResponse> OnsTopicListWithOptionsAsync(OnsTopicListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTopicListResponse>(await DoRPCRequestAsync("OnsTopicList", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsTopicListResponse OnsTopicList(OnsTopicListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTopicListWithOptions(request, runtime);
        }

        public async Task<OnsTopicListResponse> OnsTopicListAsync(OnsTopicListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTopicListWithOptionsAsync(request, runtime);
        }

        public OnsTopicStatusResponse OnsTopicStatusWithOptions(OnsTopicStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTopicStatusResponse>(DoRPCRequest("OnsTopicStatus", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsTopicStatusResponse> OnsTopicStatusWithOptionsAsync(OnsTopicStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTopicStatusResponse>(await DoRPCRequestAsync("OnsTopicStatus", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsTopicStatusResponse OnsTopicStatus(OnsTopicStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTopicStatusWithOptions(request, runtime);
        }

        public async Task<OnsTopicStatusResponse> OnsTopicStatusAsync(OnsTopicStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTopicStatusWithOptionsAsync(request, runtime);
        }

        public OnsTopicSubDetailResponse OnsTopicSubDetailWithOptions(OnsTopicSubDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTopicSubDetailResponse>(DoRPCRequest("OnsTopicSubDetail", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsTopicSubDetailResponse> OnsTopicSubDetailWithOptionsAsync(OnsTopicSubDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTopicSubDetailResponse>(await DoRPCRequestAsync("OnsTopicSubDetail", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsTopicSubDetailResponse OnsTopicSubDetail(OnsTopicSubDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTopicSubDetailWithOptions(request, runtime);
        }

        public async Task<OnsTopicSubDetailResponse> OnsTopicSubDetailAsync(OnsTopicSubDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTopicSubDetailWithOptionsAsync(request, runtime);
        }

        public OnsTopicUpdateResponse OnsTopicUpdateWithOptions(OnsTopicUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTopicUpdateResponse>(DoRPCRequest("OnsTopicUpdate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsTopicUpdateResponse> OnsTopicUpdateWithOptionsAsync(OnsTopicUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTopicUpdateResponse>(await DoRPCRequestAsync("OnsTopicUpdate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsTopicUpdateResponse OnsTopicUpdate(OnsTopicUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTopicUpdateWithOptions(request, runtime);
        }

        public async Task<OnsTopicUpdateResponse> OnsTopicUpdateAsync(OnsTopicUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTopicUpdateWithOptionsAsync(request, runtime);
        }

        public OnsTraceGetResultResponse OnsTraceGetResultWithOptions(OnsTraceGetResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTraceGetResultResponse>(DoRPCRequest("OnsTraceGetResult", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsTraceGetResultResponse> OnsTraceGetResultWithOptionsAsync(OnsTraceGetResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTraceGetResultResponse>(await DoRPCRequestAsync("OnsTraceGetResult", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsTraceGetResultResponse OnsTraceGetResult(OnsTraceGetResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTraceGetResultWithOptions(request, runtime);
        }

        public async Task<OnsTraceGetResultResponse> OnsTraceGetResultAsync(OnsTraceGetResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTraceGetResultWithOptionsAsync(request, runtime);
        }

        public OnsTraceQueryByMsgIdResponse OnsTraceQueryByMsgIdWithOptions(OnsTraceQueryByMsgIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTraceQueryByMsgIdResponse>(DoRPCRequest("OnsTraceQueryByMsgId", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsTraceQueryByMsgIdResponse> OnsTraceQueryByMsgIdWithOptionsAsync(OnsTraceQueryByMsgIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTraceQueryByMsgIdResponse>(await DoRPCRequestAsync("OnsTraceQueryByMsgId", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsTraceQueryByMsgIdResponse OnsTraceQueryByMsgId(OnsTraceQueryByMsgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTraceQueryByMsgIdWithOptions(request, runtime);
        }

        public async Task<OnsTraceQueryByMsgIdResponse> OnsTraceQueryByMsgIdAsync(OnsTraceQueryByMsgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTraceQueryByMsgIdWithOptionsAsync(request, runtime);
        }

        public OnsTraceQueryByMsgKeyResponse OnsTraceQueryByMsgKeyWithOptions(OnsTraceQueryByMsgKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTraceQueryByMsgKeyResponse>(DoRPCRequest("OnsTraceQueryByMsgKey", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsTraceQueryByMsgKeyResponse> OnsTraceQueryByMsgKeyWithOptionsAsync(OnsTraceQueryByMsgKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTraceQueryByMsgKeyResponse>(await DoRPCRequestAsync("OnsTraceQueryByMsgKey", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsTraceQueryByMsgKeyResponse OnsTraceQueryByMsgKey(OnsTraceQueryByMsgKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTraceQueryByMsgKeyWithOptions(request, runtime);
        }

        public async Task<OnsTraceQueryByMsgKeyResponse> OnsTraceQueryByMsgKeyAsync(OnsTraceQueryByMsgKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTraceQueryByMsgKeyWithOptionsAsync(request, runtime);
        }

        public OnsTrendGroupOutputTpsResponse OnsTrendGroupOutputTpsWithOptions(OnsTrendGroupOutputTpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTrendGroupOutputTpsResponse>(DoRPCRequest("OnsTrendGroupOutputTps", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsTrendGroupOutputTpsResponse> OnsTrendGroupOutputTpsWithOptionsAsync(OnsTrendGroupOutputTpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTrendGroupOutputTpsResponse>(await DoRPCRequestAsync("OnsTrendGroupOutputTps", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsTrendGroupOutputTpsResponse OnsTrendGroupOutputTps(OnsTrendGroupOutputTpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTrendGroupOutputTpsWithOptions(request, runtime);
        }

        public async Task<OnsTrendGroupOutputTpsResponse> OnsTrendGroupOutputTpsAsync(OnsTrendGroupOutputTpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTrendGroupOutputTpsWithOptionsAsync(request, runtime);
        }

        public OnsTrendTopicInputTpsResponse OnsTrendTopicInputTpsWithOptions(OnsTrendTopicInputTpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTrendTopicInputTpsResponse>(DoRPCRequest("OnsTrendTopicInputTps", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsTrendTopicInputTpsResponse> OnsTrendTopicInputTpsWithOptionsAsync(OnsTrendTopicInputTpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsTrendTopicInputTpsResponse>(await DoRPCRequestAsync("OnsTrendTopicInputTps", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsTrendTopicInputTpsResponse OnsTrendTopicInputTps(OnsTrendTopicInputTpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTrendTopicInputTpsWithOptions(request, runtime);
        }

        public async Task<OnsTrendTopicInputTpsResponse> OnsTrendTopicInputTpsAsync(OnsTrendTopicInputTpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTrendTopicInputTpsWithOptionsAsync(request, runtime);
        }

        public OnsWarnCreateResponse OnsWarnCreateWithOptions(OnsWarnCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsWarnCreateResponse>(DoRPCRequest("OnsWarnCreate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsWarnCreateResponse> OnsWarnCreateWithOptionsAsync(OnsWarnCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsWarnCreateResponse>(await DoRPCRequestAsync("OnsWarnCreate", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsWarnCreateResponse OnsWarnCreate(OnsWarnCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsWarnCreateWithOptions(request, runtime);
        }

        public async Task<OnsWarnCreateResponse> OnsWarnCreateAsync(OnsWarnCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsWarnCreateWithOptionsAsync(request, runtime);
        }

        public OnsWarnDeleteResponse OnsWarnDeleteWithOptions(OnsWarnDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsWarnDeleteResponse>(DoRPCRequest("OnsWarnDelete", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OnsWarnDeleteResponse> OnsWarnDeleteWithOptionsAsync(OnsWarnDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OnsWarnDeleteResponse>(await DoRPCRequestAsync("OnsWarnDelete", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OnsWarnDeleteResponse OnsWarnDelete(OnsWarnDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsWarnDeleteWithOptions(request, runtime);
        }

        public async Task<OnsWarnDeleteResponse> OnsWarnDeleteAsync(OnsWarnDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsWarnDeleteWithOptionsAsync(request, runtime);
        }

        public OpenOnsServiceResponse OpenOnsServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<OpenOnsServiceResponse>(DoRPCRequest("OpenOnsService", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenOnsServiceResponse> OpenOnsServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<OpenOnsServiceResponse>(await DoRPCRequestAsync("OpenOnsService", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenOnsServiceResponse OpenOnsService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenOnsServiceWithOptions(runtime);
        }

        public async Task<OpenOnsServiceResponse> OpenOnsServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenOnsServiceWithOptionsAsync(runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2019-02-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

    }
}
