// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dcdn20180115.Models;

namespace AlibabaCloud.SDK.Dcdn20180115
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "dcdn.aliyuncs.com"},
                {"ap-northeast-2-pop", "dcdn.aliyuncs.com"},
                {"ap-south-1", "dcdn.aliyuncs.com"},
                {"ap-southeast-1", "dcdn.aliyuncs.com"},
                {"ap-southeast-2", "dcdn.aliyuncs.com"},
                {"ap-southeast-3", "dcdn.aliyuncs.com"},
                {"ap-southeast-5", "dcdn.aliyuncs.com"},
                {"cn-beijing", "dcdn.aliyuncs.com"},
                {"cn-beijing-finance-1", "dcdn.aliyuncs.com"},
                {"cn-beijing-finance-pop", "dcdn.aliyuncs.com"},
                {"cn-beijing-gov-1", "dcdn.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "dcdn.aliyuncs.com"},
                {"cn-chengdu", "dcdn.aliyuncs.com"},
                {"cn-edge-1", "dcdn.aliyuncs.com"},
                {"cn-fujian", "dcdn.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "dcdn.aliyuncs.com"},
                {"cn-hangzhou", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-finance", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "dcdn.aliyuncs.com"},
                {"cn-hangzhou-test-306", "dcdn.aliyuncs.com"},
                {"cn-hongkong", "dcdn.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "dcdn.aliyuncs.com"},
                {"cn-huhehaote", "dcdn.aliyuncs.com"},
                {"cn-north-2-gov-1", "dcdn.aliyuncs.com"},
                {"cn-qingdao", "dcdn.aliyuncs.com"},
                {"cn-qingdao-nebula", "dcdn.aliyuncs.com"},
                {"cn-shanghai", "dcdn.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "dcdn.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "dcdn.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dcdn.aliyuncs.com"},
                {"cn-shanghai-inner", "dcdn.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "dcdn.aliyuncs.com"},
                {"cn-shenzhen", "dcdn.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dcdn.aliyuncs.com"},
                {"cn-shenzhen-inner", "dcdn.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "dcdn.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "dcdn.aliyuncs.com"},
                {"cn-wuhan", "dcdn.aliyuncs.com"},
                {"cn-yushanfang", "dcdn.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "dcdn.aliyuncs.com"},
                {"cn-zhangjiakou", "dcdn.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "dcdn.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "dcdn.aliyuncs.com"},
                {"eu-central-1", "dcdn.aliyuncs.com"},
                {"eu-west-1", "dcdn.aliyuncs.com"},
                {"eu-west-1-oxs", "dcdn.aliyuncs.com"},
                {"me-east-1", "dcdn.aliyuncs.com"},
                {"rus-west-1-pop", "dcdn.aliyuncs.com"},
                {"us-east-1", "dcdn.aliyuncs.com"},
                {"us-west-1", "dcdn.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dcdn", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddDcdnDomainResponse AddDcdnDomainWithOptions(AddDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDcdnDomainResponse>(DoRPCRequest("AddDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDcdnDomainResponse> AddDcdnDomainWithOptionsAsync(AddDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDcdnDomainResponse>(await DoRPCRequestAsync("AddDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDcdnDomainResponse AddDcdnDomain(AddDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDcdnDomainWithOptions(request, runtime);
        }

        public async Task<AddDcdnDomainResponse> AddDcdnDomainAsync(AddDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDcdnDomainWithOptionsAsync(request, runtime);
        }

        public AddDcdnIpaDomainResponse AddDcdnIpaDomainWithOptions(AddDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDcdnIpaDomainResponse>(DoRPCRequest("AddDcdnIpaDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDcdnIpaDomainResponse> AddDcdnIpaDomainWithOptionsAsync(AddDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDcdnIpaDomainResponse>(await DoRPCRequestAsync("AddDcdnIpaDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDcdnIpaDomainResponse AddDcdnIpaDomain(AddDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDcdnIpaDomainWithOptions(request, runtime);
        }

        public async Task<AddDcdnIpaDomainResponse> AddDcdnIpaDomainAsync(AddDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDcdnIpaDomainWithOptionsAsync(request, runtime);
        }

        public BatchAddDcdnDomainResponse BatchAddDcdnDomainWithOptions(BatchAddDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchAddDcdnDomainResponse>(DoRPCRequest("BatchAddDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchAddDcdnDomainResponse> BatchAddDcdnDomainWithOptionsAsync(BatchAddDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchAddDcdnDomainResponse>(await DoRPCRequestAsync("BatchAddDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchAddDcdnDomainResponse BatchAddDcdnDomain(BatchAddDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAddDcdnDomainWithOptions(request, runtime);
        }

        public async Task<BatchAddDcdnDomainResponse> BatchAddDcdnDomainAsync(BatchAddDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAddDcdnDomainWithOptionsAsync(request, runtime);
        }

        public BatchDeleteDcdnDomainConfigsResponse BatchDeleteDcdnDomainConfigsWithOptions(BatchDeleteDcdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeleteDcdnDomainConfigsResponse>(DoRPCRequest("BatchDeleteDcdnDomainConfigs", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchDeleteDcdnDomainConfigsResponse> BatchDeleteDcdnDomainConfigsWithOptionsAsync(BatchDeleteDcdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeleteDcdnDomainConfigsResponse>(await DoRPCRequestAsync("BatchDeleteDcdnDomainConfigs", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchDeleteDcdnDomainConfigsResponse BatchDeleteDcdnDomainConfigs(BatchDeleteDcdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteDcdnDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchDeleteDcdnDomainConfigsResponse> BatchDeleteDcdnDomainConfigsAsync(BatchDeleteDcdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteDcdnDomainConfigsWithOptionsAsync(request, runtime);
        }

        public BatchSetDcdnDomainCertificateResponse BatchSetDcdnDomainCertificateWithOptions(BatchSetDcdnDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetDcdnDomainCertificateResponse>(DoRPCRequest("BatchSetDcdnDomainCertificate", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchSetDcdnDomainCertificateResponse> BatchSetDcdnDomainCertificateWithOptionsAsync(BatchSetDcdnDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetDcdnDomainCertificateResponse>(await DoRPCRequestAsync("BatchSetDcdnDomainCertificate", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchSetDcdnDomainCertificateResponse BatchSetDcdnDomainCertificate(BatchSetDcdnDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetDcdnDomainCertificateWithOptions(request, runtime);
        }

        public async Task<BatchSetDcdnDomainCertificateResponse> BatchSetDcdnDomainCertificateAsync(BatchSetDcdnDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetDcdnDomainCertificateWithOptionsAsync(request, runtime);
        }

        public BatchSetDcdnDomainConfigsResponse BatchSetDcdnDomainConfigsWithOptions(BatchSetDcdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetDcdnDomainConfigsResponse>(DoRPCRequest("BatchSetDcdnDomainConfigs", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchSetDcdnDomainConfigsResponse> BatchSetDcdnDomainConfigsWithOptionsAsync(BatchSetDcdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetDcdnDomainConfigsResponse>(await DoRPCRequestAsync("BatchSetDcdnDomainConfigs", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchSetDcdnDomainConfigsResponse BatchSetDcdnDomainConfigs(BatchSetDcdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetDcdnDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchSetDcdnDomainConfigsResponse> BatchSetDcdnDomainConfigsAsync(BatchSetDcdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetDcdnDomainConfigsWithOptionsAsync(request, runtime);
        }

        public BatchSetDcdnIpaDomainConfigsResponse BatchSetDcdnIpaDomainConfigsWithOptions(BatchSetDcdnIpaDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetDcdnIpaDomainConfigsResponse>(DoRPCRequest("BatchSetDcdnIpaDomainConfigs", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchSetDcdnIpaDomainConfigsResponse> BatchSetDcdnIpaDomainConfigsWithOptionsAsync(BatchSetDcdnIpaDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetDcdnIpaDomainConfigsResponse>(await DoRPCRequestAsync("BatchSetDcdnIpaDomainConfigs", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchSetDcdnIpaDomainConfigsResponse BatchSetDcdnIpaDomainConfigs(BatchSetDcdnIpaDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetDcdnIpaDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchSetDcdnIpaDomainConfigsResponse> BatchSetDcdnIpaDomainConfigsAsync(BatchSetDcdnIpaDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetDcdnIpaDomainConfigsWithOptionsAsync(request, runtime);
        }

        public BatchStartDcdnDomainResponse BatchStartDcdnDomainWithOptions(BatchStartDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStartDcdnDomainResponse>(DoRPCRequest("BatchStartDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchStartDcdnDomainResponse> BatchStartDcdnDomainWithOptionsAsync(BatchStartDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStartDcdnDomainResponse>(await DoRPCRequestAsync("BatchStartDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchStartDcdnDomainResponse BatchStartDcdnDomain(BatchStartDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStartDcdnDomainWithOptions(request, runtime);
        }

        public async Task<BatchStartDcdnDomainResponse> BatchStartDcdnDomainAsync(BatchStartDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStartDcdnDomainWithOptionsAsync(request, runtime);
        }

        public BatchStopDcdnDomainResponse BatchStopDcdnDomainWithOptions(BatchStopDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStopDcdnDomainResponse>(DoRPCRequest("BatchStopDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchStopDcdnDomainResponse> BatchStopDcdnDomainWithOptionsAsync(BatchStopDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchStopDcdnDomainResponse>(await DoRPCRequestAsync("BatchStopDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchStopDcdnDomainResponse BatchStopDcdnDomain(BatchStopDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchStopDcdnDomainWithOptions(request, runtime);
        }

        public async Task<BatchStopDcdnDomainResponse> BatchStopDcdnDomainAsync(BatchStopDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchStopDcdnDomainWithOptionsAsync(request, runtime);
        }

        public CreateDcdnCertificateSigningRequestResponse CreateDcdnCertificateSigningRequestWithOptions(CreateDcdnCertificateSigningRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDcdnCertificateSigningRequestResponse>(DoRPCRequest("CreateDcdnCertificateSigningRequest", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDcdnCertificateSigningRequestResponse> CreateDcdnCertificateSigningRequestWithOptionsAsync(CreateDcdnCertificateSigningRequestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDcdnCertificateSigningRequestResponse>(await DoRPCRequestAsync("CreateDcdnCertificateSigningRequest", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDcdnCertificateSigningRequestResponse CreateDcdnCertificateSigningRequest(CreateDcdnCertificateSigningRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDcdnCertificateSigningRequestWithOptions(request, runtime);
        }

        public async Task<CreateDcdnCertificateSigningRequestResponse> CreateDcdnCertificateSigningRequestAsync(CreateDcdnCertificateSigningRequestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDcdnCertificateSigningRequestWithOptionsAsync(request, runtime);
        }

        public CreateDcdnDomainOfflineLogDeliveryResponse CreateDcdnDomainOfflineLogDeliveryWithOptions(CreateDcdnDomainOfflineLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDcdnDomainOfflineLogDeliveryResponse>(DoRPCRequest("CreateDcdnDomainOfflineLogDelivery", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDcdnDomainOfflineLogDeliveryResponse> CreateDcdnDomainOfflineLogDeliveryWithOptionsAsync(CreateDcdnDomainOfflineLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDcdnDomainOfflineLogDeliveryResponse>(await DoRPCRequestAsync("CreateDcdnDomainOfflineLogDelivery", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDcdnDomainOfflineLogDeliveryResponse CreateDcdnDomainOfflineLogDelivery(CreateDcdnDomainOfflineLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDcdnDomainOfflineLogDeliveryWithOptions(request, runtime);
        }

        public async Task<CreateDcdnDomainOfflineLogDeliveryResponse> CreateDcdnDomainOfflineLogDeliveryAsync(CreateDcdnDomainOfflineLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDcdnDomainOfflineLogDeliveryWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnDomainResponse DeleteDcdnDomainWithOptions(DeleteDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDcdnDomainResponse>(DoRPCRequest("DeleteDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDcdnDomainResponse> DeleteDcdnDomainWithOptionsAsync(DeleteDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDcdnDomainResponse>(await DoRPCRequestAsync("DeleteDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDcdnDomainResponse DeleteDcdnDomain(DeleteDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnDomainWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnDomainResponse> DeleteDcdnDomainAsync(DeleteDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnDomainWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnIpaDomainResponse DeleteDcdnIpaDomainWithOptions(DeleteDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDcdnIpaDomainResponse>(DoRPCRequest("DeleteDcdnIpaDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDcdnIpaDomainResponse> DeleteDcdnIpaDomainWithOptionsAsync(DeleteDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDcdnIpaDomainResponse>(await DoRPCRequestAsync("DeleteDcdnIpaDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDcdnIpaDomainResponse DeleteDcdnIpaDomain(DeleteDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnIpaDomainWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnIpaDomainResponse> DeleteDcdnIpaDomainAsync(DeleteDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnIpaDomainWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnIpaSpecificConfigResponse DeleteDcdnIpaSpecificConfigWithOptions(DeleteDcdnIpaSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDcdnIpaSpecificConfigResponse>(DoRPCRequest("DeleteDcdnIpaSpecificConfig", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDcdnIpaSpecificConfigResponse> DeleteDcdnIpaSpecificConfigWithOptionsAsync(DeleteDcdnIpaSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDcdnIpaSpecificConfigResponse>(await DoRPCRequestAsync("DeleteDcdnIpaSpecificConfig", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDcdnIpaSpecificConfigResponse DeleteDcdnIpaSpecificConfig(DeleteDcdnIpaSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnIpaSpecificConfigWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnIpaSpecificConfigResponse> DeleteDcdnIpaSpecificConfigAsync(DeleteDcdnIpaSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnIpaSpecificConfigWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnSpecificConfigResponse DeleteDcdnSpecificConfigWithOptions(DeleteDcdnSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDcdnSpecificConfigResponse>(DoRPCRequest("DeleteDcdnSpecificConfig", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDcdnSpecificConfigResponse> DeleteDcdnSpecificConfigWithOptionsAsync(DeleteDcdnSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDcdnSpecificConfigResponse>(await DoRPCRequestAsync("DeleteDcdnSpecificConfig", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDcdnSpecificConfigResponse DeleteDcdnSpecificConfig(DeleteDcdnSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnSpecificConfigWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnSpecificConfigResponse> DeleteDcdnSpecificConfigAsync(DeleteDcdnSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnSpecificConfigWithOptionsAsync(request, runtime);
        }

        public DeleteDcdnSpecificStagingConfigResponse DeleteDcdnSpecificStagingConfigWithOptions(DeleteDcdnSpecificStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDcdnSpecificStagingConfigResponse>(DoRPCRequest("DeleteDcdnSpecificStagingConfig", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDcdnSpecificStagingConfigResponse> DeleteDcdnSpecificStagingConfigWithOptionsAsync(DeleteDcdnSpecificStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDcdnSpecificStagingConfigResponse>(await DoRPCRequestAsync("DeleteDcdnSpecificStagingConfig", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDcdnSpecificStagingConfigResponse DeleteDcdnSpecificStagingConfig(DeleteDcdnSpecificStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDcdnSpecificStagingConfigWithOptions(request, runtime);
        }

        public async Task<DeleteDcdnSpecificStagingConfigResponse> DeleteDcdnSpecificStagingConfigAsync(DeleteDcdnSpecificStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDcdnSpecificStagingConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnBgpBpsDataResponse DescribeDcdnBgpBpsDataWithOptions(DescribeDcdnBgpBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnBgpBpsDataResponse>(DoRPCRequest("DescribeDcdnBgpBpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnBgpBpsDataResponse> DescribeDcdnBgpBpsDataWithOptionsAsync(DescribeDcdnBgpBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnBgpBpsDataResponse>(await DoRPCRequestAsync("DescribeDcdnBgpBpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnBgpBpsDataResponse DescribeDcdnBgpBpsData(DescribeDcdnBgpBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnBgpBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnBgpBpsDataResponse> DescribeDcdnBgpBpsDataAsync(DescribeDcdnBgpBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnBgpBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnBgpTrafficDataResponse DescribeDcdnBgpTrafficDataWithOptions(DescribeDcdnBgpTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnBgpTrafficDataResponse>(DoRPCRequest("DescribeDcdnBgpTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnBgpTrafficDataResponse> DescribeDcdnBgpTrafficDataWithOptionsAsync(DescribeDcdnBgpTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnBgpTrafficDataResponse>(await DoRPCRequestAsync("DescribeDcdnBgpTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnBgpTrafficDataResponse DescribeDcdnBgpTrafficData(DescribeDcdnBgpTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnBgpTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnBgpTrafficDataResponse> DescribeDcdnBgpTrafficDataAsync(DescribeDcdnBgpTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnBgpTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnCertificateDetailResponse DescribeDcdnCertificateDetailWithOptions(DescribeDcdnCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnCertificateDetailResponse>(DoRPCRequest("DescribeDcdnCertificateDetail", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnCertificateDetailResponse> DescribeDcdnCertificateDetailWithOptionsAsync(DescribeDcdnCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnCertificateDetailResponse>(await DoRPCRequestAsync("DescribeDcdnCertificateDetail", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnCertificateDetailResponse DescribeDcdnCertificateDetail(DescribeDcdnCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnCertificateDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnCertificateDetailResponse> DescribeDcdnCertificateDetailAsync(DescribeDcdnCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnCertificateDetailWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnCertificateListResponse DescribeDcdnCertificateListWithOptions(DescribeDcdnCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnCertificateListResponse>(DoRPCRequest("DescribeDcdnCertificateList", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnCertificateListResponse> DescribeDcdnCertificateListWithOptionsAsync(DescribeDcdnCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnCertificateListResponse>(await DoRPCRequestAsync("DescribeDcdnCertificateList", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnCertificateListResponse DescribeDcdnCertificateList(DescribeDcdnCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnCertificateListWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnCertificateListResponse> DescribeDcdnCertificateListAsync(DescribeDcdnCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnCertificateListWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnConfigOfVersionResponse DescribeDcdnConfigOfVersionWithOptions(DescribeDcdnConfigOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnConfigOfVersionResponse>(DoRPCRequest("DescribeDcdnConfigOfVersion", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnConfigOfVersionResponse> DescribeDcdnConfigOfVersionWithOptionsAsync(DescribeDcdnConfigOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnConfigOfVersionResponse>(await DoRPCRequestAsync("DescribeDcdnConfigOfVersion", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnConfigOfVersionResponse DescribeDcdnConfigOfVersion(DescribeDcdnConfigOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnConfigOfVersionWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnConfigOfVersionResponse> DescribeDcdnConfigOfVersionAsync(DescribeDcdnConfigOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnConfigOfVersionWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainBpsDataResponse DescribeDcdnDomainBpsDataWithOptions(DescribeDcdnDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainBpsDataResponse>(DoRPCRequest("DescribeDcdnDomainBpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainBpsDataResponse> DescribeDcdnDomainBpsDataWithOptionsAsync(DescribeDcdnDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainBpsDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainBpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainBpsDataResponse DescribeDcdnDomainBpsData(DescribeDcdnDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainBpsDataResponse> DescribeDcdnDomainBpsDataAsync(DescribeDcdnDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainByCertificateResponse DescribeDcdnDomainByCertificateWithOptions(DescribeDcdnDomainByCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainByCertificateResponse>(DoRPCRequest("DescribeDcdnDomainByCertificate", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainByCertificateResponse> DescribeDcdnDomainByCertificateWithOptionsAsync(DescribeDcdnDomainByCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainByCertificateResponse>(await DoRPCRequestAsync("DescribeDcdnDomainByCertificate", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainByCertificateResponse DescribeDcdnDomainByCertificate(DescribeDcdnDomainByCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainByCertificateWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainByCertificateResponse> DescribeDcdnDomainByCertificateAsync(DescribeDcdnDomainByCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainByCertificateWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainCertificateInfoResponse DescribeDcdnDomainCertificateInfoWithOptions(DescribeDcdnDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainCertificateInfoResponse>(DoRPCRequest("DescribeDcdnDomainCertificateInfo", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainCertificateInfoResponse> DescribeDcdnDomainCertificateInfoWithOptionsAsync(DescribeDcdnDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainCertificateInfoResponse>(await DoRPCRequestAsync("DescribeDcdnDomainCertificateInfo", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainCertificateInfoResponse DescribeDcdnDomainCertificateInfo(DescribeDcdnDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainCertificateInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainCertificateInfoResponse> DescribeDcdnDomainCertificateInfoAsync(DescribeDcdnDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainCertificateInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainCnameResponse DescribeDcdnDomainCnameWithOptions(DescribeDcdnDomainCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDcdnDomainCnameResponse>(DoRPCRequest("DescribeDcdnDomainCname", "2018-01-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainCnameResponse> DescribeDcdnDomainCnameWithOptionsAsync(DescribeDcdnDomainCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDcdnDomainCnameResponse>(await DoRPCRequestAsync("DescribeDcdnDomainCname", "2018-01-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainCnameResponse DescribeDcdnDomainCname(DescribeDcdnDomainCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainCnameWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainCnameResponse> DescribeDcdnDomainCnameAsync(DescribeDcdnDomainCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainCnameWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainConfigsResponse DescribeDcdnDomainConfigsWithOptions(DescribeDcdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainConfigsResponse>(DoRPCRequest("DescribeDcdnDomainConfigs", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainConfigsResponse> DescribeDcdnDomainConfigsWithOptionsAsync(DescribeDcdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainConfigsResponse>(await DoRPCRequestAsync("DescribeDcdnDomainConfigs", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainConfigsResponse DescribeDcdnDomainConfigs(DescribeDcdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainConfigsResponse> DescribeDcdnDomainConfigsAsync(DescribeDcdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainDetailResponse DescribeDcdnDomainDetailWithOptions(DescribeDcdnDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainDetailResponse>(DoRPCRequest("DescribeDcdnDomainDetail", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainDetailResponse> DescribeDcdnDomainDetailWithOptionsAsync(DescribeDcdnDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainDetailResponse>(await DoRPCRequestAsync("DescribeDcdnDomainDetail", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainDetailResponse DescribeDcdnDomainDetail(DescribeDcdnDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainDetailResponse> DescribeDcdnDomainDetailAsync(DescribeDcdnDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainDetailWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainHitRateDataResponse DescribeDcdnDomainHitRateDataWithOptions(DescribeDcdnDomainHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainHitRateDataResponse>(DoRPCRequest("DescribeDcdnDomainHitRateData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainHitRateDataResponse> DescribeDcdnDomainHitRateDataWithOptionsAsync(DescribeDcdnDomainHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainHitRateDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainHitRateData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainHitRateDataResponse DescribeDcdnDomainHitRateData(DescribeDcdnDomainHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainHitRateDataResponse> DescribeDcdnDomainHitRateDataAsync(DescribeDcdnDomainHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainHttpCodeDataResponse DescribeDcdnDomainHttpCodeDataWithOptions(DescribeDcdnDomainHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainHttpCodeDataResponse>(DoRPCRequest("DescribeDcdnDomainHttpCodeData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainHttpCodeDataResponse> DescribeDcdnDomainHttpCodeDataWithOptionsAsync(DescribeDcdnDomainHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainHttpCodeDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainHttpCodeData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainHttpCodeDataResponse DescribeDcdnDomainHttpCodeData(DescribeDcdnDomainHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainHttpCodeDataResponse> DescribeDcdnDomainHttpCodeDataAsync(DescribeDcdnDomainHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainIpaBpsDataResponse DescribeDcdnDomainIpaBpsDataWithOptions(DescribeDcdnDomainIpaBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainIpaBpsDataResponse>(DoRPCRequest("DescribeDcdnDomainIpaBpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainIpaBpsDataResponse> DescribeDcdnDomainIpaBpsDataWithOptionsAsync(DescribeDcdnDomainIpaBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainIpaBpsDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainIpaBpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainIpaBpsDataResponse DescribeDcdnDomainIpaBpsData(DescribeDcdnDomainIpaBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainIpaBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainIpaBpsDataResponse> DescribeDcdnDomainIpaBpsDataAsync(DescribeDcdnDomainIpaBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainIpaBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainIpaTrafficDataResponse DescribeDcdnDomainIpaTrafficDataWithOptions(DescribeDcdnDomainIpaTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainIpaTrafficDataResponse>(DoRPCRequest("DescribeDcdnDomainIpaTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainIpaTrafficDataResponse> DescribeDcdnDomainIpaTrafficDataWithOptionsAsync(DescribeDcdnDomainIpaTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainIpaTrafficDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainIpaTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainIpaTrafficDataResponse DescribeDcdnDomainIpaTrafficData(DescribeDcdnDomainIpaTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainIpaTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainIpaTrafficDataResponse> DescribeDcdnDomainIpaTrafficDataAsync(DescribeDcdnDomainIpaTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainIpaTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainIspDataResponse DescribeDcdnDomainIspDataWithOptions(DescribeDcdnDomainIspDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainIspDataResponse>(DoRPCRequest("DescribeDcdnDomainIspData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainIspDataResponse> DescribeDcdnDomainIspDataWithOptionsAsync(DescribeDcdnDomainIspDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainIspDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainIspData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainIspDataResponse DescribeDcdnDomainIspData(DescribeDcdnDomainIspDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainIspDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainIspDataResponse> DescribeDcdnDomainIspDataAsync(DescribeDcdnDomainIspDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainIspDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainLogResponse DescribeDcdnDomainLogWithOptions(DescribeDcdnDomainLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainLogResponse>(DoRPCRequest("DescribeDcdnDomainLog", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainLogResponse> DescribeDcdnDomainLogWithOptionsAsync(DescribeDcdnDomainLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainLogResponse>(await DoRPCRequestAsync("DescribeDcdnDomainLog", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainLogResponse DescribeDcdnDomainLog(DescribeDcdnDomainLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainLogWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainLogResponse> DescribeDcdnDomainLogAsync(DescribeDcdnDomainLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainLogWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainMultiUsageDataResponse DescribeDcdnDomainMultiUsageDataWithOptions(DescribeDcdnDomainMultiUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainMultiUsageDataResponse>(DoRPCRequest("DescribeDcdnDomainMultiUsageData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainMultiUsageDataResponse> DescribeDcdnDomainMultiUsageDataWithOptionsAsync(DescribeDcdnDomainMultiUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainMultiUsageDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainMultiUsageData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainMultiUsageDataResponse DescribeDcdnDomainMultiUsageData(DescribeDcdnDomainMultiUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainMultiUsageDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainMultiUsageDataResponse> DescribeDcdnDomainMultiUsageDataAsync(DescribeDcdnDomainMultiUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainMultiUsageDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainOriginBpsDataResponse DescribeDcdnDomainOriginBpsDataWithOptions(DescribeDcdnDomainOriginBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainOriginBpsDataResponse>(DoRPCRequest("DescribeDcdnDomainOriginBpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainOriginBpsDataResponse> DescribeDcdnDomainOriginBpsDataWithOptionsAsync(DescribeDcdnDomainOriginBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainOriginBpsDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainOriginBpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainOriginBpsDataResponse DescribeDcdnDomainOriginBpsData(DescribeDcdnDomainOriginBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainOriginBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainOriginBpsDataResponse> DescribeDcdnDomainOriginBpsDataAsync(DescribeDcdnDomainOriginBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainOriginBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainOriginTrafficDataResponse DescribeDcdnDomainOriginTrafficDataWithOptions(DescribeDcdnDomainOriginTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainOriginTrafficDataResponse>(DoRPCRequest("DescribeDcdnDomainOriginTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainOriginTrafficDataResponse> DescribeDcdnDomainOriginTrafficDataWithOptionsAsync(DescribeDcdnDomainOriginTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainOriginTrafficDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainOriginTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainOriginTrafficDataResponse DescribeDcdnDomainOriginTrafficData(DescribeDcdnDomainOriginTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainOriginTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainOriginTrafficDataResponse> DescribeDcdnDomainOriginTrafficDataAsync(DescribeDcdnDomainOriginTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainOriginTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainPropertyResponse DescribeDcdnDomainPropertyWithOptions(DescribeDcdnDomainPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainPropertyResponse>(DoRPCRequest("DescribeDcdnDomainProperty", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainPropertyResponse> DescribeDcdnDomainPropertyWithOptionsAsync(DescribeDcdnDomainPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainPropertyResponse>(await DoRPCRequestAsync("DescribeDcdnDomainProperty", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainPropertyResponse DescribeDcdnDomainProperty(DescribeDcdnDomainPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainPropertyWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainPropertyResponse> DescribeDcdnDomainPropertyAsync(DescribeDcdnDomainPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainPropertyWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainPvDataResponse DescribeDcdnDomainPvDataWithOptions(DescribeDcdnDomainPvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainPvDataResponse>(DoRPCRequest("DescribeDcdnDomainPvData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainPvDataResponse> DescribeDcdnDomainPvDataWithOptionsAsync(DescribeDcdnDomainPvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainPvDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainPvData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainPvDataResponse DescribeDcdnDomainPvData(DescribeDcdnDomainPvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainPvDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainPvDataResponse> DescribeDcdnDomainPvDataAsync(DescribeDcdnDomainPvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainPvDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainQpsDataResponse DescribeDcdnDomainQpsDataWithOptions(DescribeDcdnDomainQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainQpsDataResponse>(DoRPCRequest("DescribeDcdnDomainQpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainQpsDataResponse> DescribeDcdnDomainQpsDataWithOptionsAsync(DescribeDcdnDomainQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainQpsDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainQpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainQpsDataResponse DescribeDcdnDomainQpsData(DescribeDcdnDomainQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainQpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainQpsDataResponse> DescribeDcdnDomainQpsDataAsync(DescribeDcdnDomainQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainQpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeBpsDataResponse DescribeDcdnDomainRealTimeBpsDataWithOptions(DescribeDcdnDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeBpsDataResponse>(DoRPCRequest("DescribeDcdnDomainRealTimeBpsData", "2018-01-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeBpsDataResponse> DescribeDcdnDomainRealTimeBpsDataWithOptionsAsync(DescribeDcdnDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeBpsDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainRealTimeBpsData", "2018-01-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainRealTimeBpsDataResponse DescribeDcdnDomainRealTimeBpsData(DescribeDcdnDomainRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeBpsDataResponse> DescribeDcdnDomainRealTimeBpsDataAsync(DescribeDcdnDomainRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeByteHitRateDataResponse DescribeDcdnDomainRealTimeByteHitRateDataWithOptions(DescribeDcdnDomainRealTimeByteHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeByteHitRateDataResponse>(DoRPCRequest("DescribeDcdnDomainRealTimeByteHitRateData", "2018-01-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeByteHitRateDataResponse> DescribeDcdnDomainRealTimeByteHitRateDataWithOptionsAsync(DescribeDcdnDomainRealTimeByteHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeByteHitRateDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainRealTimeByteHitRateData", "2018-01-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainRealTimeByteHitRateDataResponse DescribeDcdnDomainRealTimeByteHitRateData(DescribeDcdnDomainRealTimeByteHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeByteHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeByteHitRateDataResponse> DescribeDcdnDomainRealTimeByteHitRateDataAsync(DescribeDcdnDomainRealTimeByteHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeByteHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeDetailDataResponse DescribeDcdnDomainRealTimeDetailDataWithOptions(DescribeDcdnDomainRealTimeDetailDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeDetailDataResponse>(DoRPCRequest("DescribeDcdnDomainRealTimeDetailData", "2018-01-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeDetailDataResponse> DescribeDcdnDomainRealTimeDetailDataWithOptionsAsync(DescribeDcdnDomainRealTimeDetailDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeDetailDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainRealTimeDetailData", "2018-01-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainRealTimeDetailDataResponse DescribeDcdnDomainRealTimeDetailData(DescribeDcdnDomainRealTimeDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeDetailDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeDetailDataResponse> DescribeDcdnDomainRealTimeDetailDataAsync(DescribeDcdnDomainRealTimeDetailDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeDetailDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeHttpCodeDataResponse DescribeDcdnDomainRealTimeHttpCodeDataWithOptions(DescribeDcdnDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeHttpCodeDataResponse>(DoRPCRequest("DescribeDcdnDomainRealTimeHttpCodeData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeHttpCodeDataResponse> DescribeDcdnDomainRealTimeHttpCodeDataWithOptionsAsync(DescribeDcdnDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeHttpCodeDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainRealTimeHttpCodeData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainRealTimeHttpCodeDataResponse DescribeDcdnDomainRealTimeHttpCodeData(DescribeDcdnDomainRealTimeHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeHttpCodeDataResponse> DescribeDcdnDomainRealTimeHttpCodeDataAsync(DescribeDcdnDomainRealTimeHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeQpsDataResponse DescribeDcdnDomainRealTimeQpsDataWithOptions(DescribeDcdnDomainRealTimeQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeQpsDataResponse>(DoRPCRequest("DescribeDcdnDomainRealTimeQpsData", "2018-01-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeQpsDataResponse> DescribeDcdnDomainRealTimeQpsDataWithOptionsAsync(DescribeDcdnDomainRealTimeQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeQpsDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainRealTimeQpsData", "2018-01-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainRealTimeQpsDataResponse DescribeDcdnDomainRealTimeQpsData(DescribeDcdnDomainRealTimeQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeQpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeQpsDataResponse> DescribeDcdnDomainRealTimeQpsDataAsync(DescribeDcdnDomainRealTimeQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeQpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeReqHitRateDataResponse DescribeDcdnDomainRealTimeReqHitRateDataWithOptions(DescribeDcdnDomainRealTimeReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeReqHitRateDataResponse>(DoRPCRequest("DescribeDcdnDomainRealTimeReqHitRateData", "2018-01-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeReqHitRateDataResponse> DescribeDcdnDomainRealTimeReqHitRateDataWithOptionsAsync(DescribeDcdnDomainRealTimeReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeReqHitRateDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainRealTimeReqHitRateData", "2018-01-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainRealTimeReqHitRateDataResponse DescribeDcdnDomainRealTimeReqHitRateData(DescribeDcdnDomainRealTimeReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeReqHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeReqHitRateDataResponse> DescribeDcdnDomainRealTimeReqHitRateDataAsync(DescribeDcdnDomainRealTimeReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeReqHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeSrcBpsDataResponse DescribeDcdnDomainRealTimeSrcBpsDataWithOptions(DescribeDcdnDomainRealTimeSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeSrcBpsDataResponse>(DoRPCRequest("DescribeDcdnDomainRealTimeSrcBpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeSrcBpsDataResponse> DescribeDcdnDomainRealTimeSrcBpsDataWithOptionsAsync(DescribeDcdnDomainRealTimeSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeSrcBpsDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainRealTimeSrcBpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainRealTimeSrcBpsDataResponse DescribeDcdnDomainRealTimeSrcBpsData(DescribeDcdnDomainRealTimeSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeSrcBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeSrcBpsDataResponse> DescribeDcdnDomainRealTimeSrcBpsDataAsync(DescribeDcdnDomainRealTimeSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeSrcBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse DescribeDcdnDomainRealTimeSrcHttpCodeDataWithOptions(DescribeDcdnDomainRealTimeSrcHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse>(DoRPCRequest("DescribeDcdnDomainRealTimeSrcHttpCodeData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse> DescribeDcdnDomainRealTimeSrcHttpCodeDataWithOptionsAsync(DescribeDcdnDomainRealTimeSrcHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainRealTimeSrcHttpCodeData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse DescribeDcdnDomainRealTimeSrcHttpCodeData(DescribeDcdnDomainRealTimeSrcHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeSrcHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeSrcHttpCodeDataResponse> DescribeDcdnDomainRealTimeSrcHttpCodeDataAsync(DescribeDcdnDomainRealTimeSrcHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeSrcHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeSrcTrafficDataResponse DescribeDcdnDomainRealTimeSrcTrafficDataWithOptions(DescribeDcdnDomainRealTimeSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeSrcTrafficDataResponse>(DoRPCRequest("DescribeDcdnDomainRealTimeSrcTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeSrcTrafficDataResponse> DescribeDcdnDomainRealTimeSrcTrafficDataWithOptionsAsync(DescribeDcdnDomainRealTimeSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeSrcTrafficDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainRealTimeSrcTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainRealTimeSrcTrafficDataResponse DescribeDcdnDomainRealTimeSrcTrafficData(DescribeDcdnDomainRealTimeSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeSrcTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeSrcTrafficDataResponse> DescribeDcdnDomainRealTimeSrcTrafficDataAsync(DescribeDcdnDomainRealTimeSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeSrcTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRealTimeTrafficDataResponse DescribeDcdnDomainRealTimeTrafficDataWithOptions(DescribeDcdnDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeTrafficDataResponse>(DoRPCRequest("DescribeDcdnDomainRealTimeTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainRealTimeTrafficDataResponse> DescribeDcdnDomainRealTimeTrafficDataWithOptionsAsync(DescribeDcdnDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainRealTimeTrafficDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainRealTimeTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainRealTimeTrafficDataResponse DescribeDcdnDomainRealTimeTrafficData(DescribeDcdnDomainRealTimeTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRealTimeTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRealTimeTrafficDataResponse> DescribeDcdnDomainRealTimeTrafficDataAsync(DescribeDcdnDomainRealTimeTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRealTimeTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainRegionDataResponse DescribeDcdnDomainRegionDataWithOptions(DescribeDcdnDomainRegionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainRegionDataResponse>(DoRPCRequest("DescribeDcdnDomainRegionData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainRegionDataResponse> DescribeDcdnDomainRegionDataWithOptionsAsync(DescribeDcdnDomainRegionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainRegionDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainRegionData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainRegionDataResponse DescribeDcdnDomainRegionData(DescribeDcdnDomainRegionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainRegionDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainRegionDataResponse> DescribeDcdnDomainRegionDataAsync(DescribeDcdnDomainRegionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainRegionDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainStagingConfigResponse DescribeDcdnDomainStagingConfigWithOptions(DescribeDcdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainStagingConfigResponse>(DoRPCRequest("DescribeDcdnDomainStagingConfig", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainStagingConfigResponse> DescribeDcdnDomainStagingConfigWithOptionsAsync(DescribeDcdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainStagingConfigResponse>(await DoRPCRequestAsync("DescribeDcdnDomainStagingConfig", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainStagingConfigResponse DescribeDcdnDomainStagingConfig(DescribeDcdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainStagingConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainStagingConfigResponse> DescribeDcdnDomainStagingConfigAsync(DescribeDcdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainStagingConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainTopReferVisitResponse DescribeDcdnDomainTopReferVisitWithOptions(DescribeDcdnDomainTopReferVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainTopReferVisitResponse>(DoRPCRequest("DescribeDcdnDomainTopReferVisit", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainTopReferVisitResponse> DescribeDcdnDomainTopReferVisitWithOptionsAsync(DescribeDcdnDomainTopReferVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainTopReferVisitResponse>(await DoRPCRequestAsync("DescribeDcdnDomainTopReferVisit", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainTopReferVisitResponse DescribeDcdnDomainTopReferVisit(DescribeDcdnDomainTopReferVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainTopReferVisitWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainTopReferVisitResponse> DescribeDcdnDomainTopReferVisitAsync(DescribeDcdnDomainTopReferVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainTopReferVisitWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainTopUrlVisitResponse DescribeDcdnDomainTopUrlVisitWithOptions(DescribeDcdnDomainTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainTopUrlVisitResponse>(DoRPCRequest("DescribeDcdnDomainTopUrlVisit", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainTopUrlVisitResponse> DescribeDcdnDomainTopUrlVisitWithOptionsAsync(DescribeDcdnDomainTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainTopUrlVisitResponse>(await DoRPCRequestAsync("DescribeDcdnDomainTopUrlVisit", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainTopUrlVisitResponse DescribeDcdnDomainTopUrlVisit(DescribeDcdnDomainTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainTopUrlVisitWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainTopUrlVisitResponse> DescribeDcdnDomainTopUrlVisitAsync(DescribeDcdnDomainTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainTopUrlVisitWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainTrafficDataResponse DescribeDcdnDomainTrafficDataWithOptions(DescribeDcdnDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainTrafficDataResponse>(DoRPCRequest("DescribeDcdnDomainTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainTrafficDataResponse> DescribeDcdnDomainTrafficDataWithOptionsAsync(DescribeDcdnDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainTrafficDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainTrafficDataResponse DescribeDcdnDomainTrafficData(DescribeDcdnDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainTrafficDataResponse> DescribeDcdnDomainTrafficDataAsync(DescribeDcdnDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainUvDataResponse DescribeDcdnDomainUvDataWithOptions(DescribeDcdnDomainUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainUvDataResponse>(DoRPCRequest("DescribeDcdnDomainUvData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainUvDataResponse> DescribeDcdnDomainUvDataWithOptionsAsync(DescribeDcdnDomainUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainUvDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainUvData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainUvDataResponse DescribeDcdnDomainUvData(DescribeDcdnDomainUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainUvDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainUvDataResponse> DescribeDcdnDomainUvDataAsync(DescribeDcdnDomainUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainUvDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainWebsocketBpsDataResponse DescribeDcdnDomainWebsocketBpsDataWithOptions(DescribeDcdnDomainWebsocketBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainWebsocketBpsDataResponse>(DoRPCRequest("DescribeDcdnDomainWebsocketBpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainWebsocketBpsDataResponse> DescribeDcdnDomainWebsocketBpsDataWithOptionsAsync(DescribeDcdnDomainWebsocketBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainWebsocketBpsDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainWebsocketBpsData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainWebsocketBpsDataResponse DescribeDcdnDomainWebsocketBpsData(DescribeDcdnDomainWebsocketBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainWebsocketBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainWebsocketBpsDataResponse> DescribeDcdnDomainWebsocketBpsDataAsync(DescribeDcdnDomainWebsocketBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainWebsocketBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainWebsocketHttpCodeDataResponse DescribeDcdnDomainWebsocketHttpCodeDataWithOptions(DescribeDcdnDomainWebsocketHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainWebsocketHttpCodeDataResponse>(DoRPCRequest("DescribeDcdnDomainWebsocketHttpCodeData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainWebsocketHttpCodeDataResponse> DescribeDcdnDomainWebsocketHttpCodeDataWithOptionsAsync(DescribeDcdnDomainWebsocketHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainWebsocketHttpCodeDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainWebsocketHttpCodeData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainWebsocketHttpCodeDataResponse DescribeDcdnDomainWebsocketHttpCodeData(DescribeDcdnDomainWebsocketHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainWebsocketHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainWebsocketHttpCodeDataResponse> DescribeDcdnDomainWebsocketHttpCodeDataAsync(DescribeDcdnDomainWebsocketHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainWebsocketHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnDomainWebsocketTrafficDataResponse DescribeDcdnDomainWebsocketTrafficDataWithOptions(DescribeDcdnDomainWebsocketTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainWebsocketTrafficDataResponse>(DoRPCRequest("DescribeDcdnDomainWebsocketTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnDomainWebsocketTrafficDataResponse> DescribeDcdnDomainWebsocketTrafficDataWithOptionsAsync(DescribeDcdnDomainWebsocketTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnDomainWebsocketTrafficDataResponse>(await DoRPCRequestAsync("DescribeDcdnDomainWebsocketTrafficData", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnDomainWebsocketTrafficDataResponse DescribeDcdnDomainWebsocketTrafficData(DescribeDcdnDomainWebsocketTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnDomainWebsocketTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnDomainWebsocketTrafficDataResponse> DescribeDcdnDomainWebsocketTrafficDataAsync(DescribeDcdnDomainWebsocketTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnDomainWebsocketTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnHttpsDomainListResponse DescribeDcdnHttpsDomainListWithOptions(DescribeDcdnHttpsDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnHttpsDomainListResponse>(DoRPCRequest("DescribeDcdnHttpsDomainList", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnHttpsDomainListResponse> DescribeDcdnHttpsDomainListWithOptionsAsync(DescribeDcdnHttpsDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnHttpsDomainListResponse>(await DoRPCRequestAsync("DescribeDcdnHttpsDomainList", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnHttpsDomainListResponse DescribeDcdnHttpsDomainList(DescribeDcdnHttpsDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnHttpsDomainListWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnHttpsDomainListResponse> DescribeDcdnHttpsDomainListAsync(DescribeDcdnHttpsDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnHttpsDomainListWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnIpaDomainConfigsResponse DescribeDcdnIpaDomainConfigsWithOptions(DescribeDcdnIpaDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnIpaDomainConfigsResponse>(DoRPCRequest("DescribeDcdnIpaDomainConfigs", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnIpaDomainConfigsResponse> DescribeDcdnIpaDomainConfigsWithOptionsAsync(DescribeDcdnIpaDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnIpaDomainConfigsResponse>(await DoRPCRequestAsync("DescribeDcdnIpaDomainConfigs", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnIpaDomainConfigsResponse DescribeDcdnIpaDomainConfigs(DescribeDcdnIpaDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnIpaDomainConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnIpaDomainConfigsResponse> DescribeDcdnIpaDomainConfigsAsync(DescribeDcdnIpaDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnIpaDomainConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnIpaDomainDetailResponse DescribeDcdnIpaDomainDetailWithOptions(DescribeDcdnIpaDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnIpaDomainDetailResponse>(DoRPCRequest("DescribeDcdnIpaDomainDetail", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnIpaDomainDetailResponse> DescribeDcdnIpaDomainDetailWithOptionsAsync(DescribeDcdnIpaDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnIpaDomainDetailResponse>(await DoRPCRequestAsync("DescribeDcdnIpaDomainDetail", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnIpaDomainDetailResponse DescribeDcdnIpaDomainDetail(DescribeDcdnIpaDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnIpaDomainDetailWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnIpaDomainDetailResponse> DescribeDcdnIpaDomainDetailAsync(DescribeDcdnIpaDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnIpaDomainDetailWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnIpaServiceResponse DescribeDcdnIpaServiceWithOptions(DescribeDcdnIpaServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnIpaServiceResponse>(DoRPCRequest("DescribeDcdnIpaService", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnIpaServiceResponse> DescribeDcdnIpaServiceWithOptionsAsync(DescribeDcdnIpaServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnIpaServiceResponse>(await DoRPCRequestAsync("DescribeDcdnIpaService", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnIpaServiceResponse DescribeDcdnIpaService(DescribeDcdnIpaServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnIpaServiceWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnIpaServiceResponse> DescribeDcdnIpaServiceAsync(DescribeDcdnIpaServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnIpaServiceWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnIpaUserDomainsResponse DescribeDcdnIpaUserDomainsWithOptions(DescribeDcdnIpaUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnIpaUserDomainsResponse>(DoRPCRequest("DescribeDcdnIpaUserDomains", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnIpaUserDomainsResponse> DescribeDcdnIpaUserDomainsWithOptionsAsync(DescribeDcdnIpaUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnIpaUserDomainsResponse>(await DoRPCRequestAsync("DescribeDcdnIpaUserDomains", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnIpaUserDomainsResponse DescribeDcdnIpaUserDomains(DescribeDcdnIpaUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnIpaUserDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnIpaUserDomainsResponse> DescribeDcdnIpaUserDomainsAsync(DescribeDcdnIpaUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnIpaUserDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnIpInfoResponse DescribeDcdnIpInfoWithOptions(DescribeDcdnIpInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnIpInfoResponse>(DoRPCRequest("DescribeDcdnIpInfo", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnIpInfoResponse> DescribeDcdnIpInfoWithOptionsAsync(DescribeDcdnIpInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnIpInfoResponse>(await DoRPCRequestAsync("DescribeDcdnIpInfo", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnIpInfoResponse DescribeDcdnIpInfo(DescribeDcdnIpInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnIpInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnIpInfoResponse> DescribeDcdnIpInfoAsync(DescribeDcdnIpInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnIpInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnOfflineLogDeliveryResponse DescribeDcdnOfflineLogDeliveryWithOptions(DescribeDcdnOfflineLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnOfflineLogDeliveryResponse>(DoRPCRequest("DescribeDcdnOfflineLogDelivery", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnOfflineLogDeliveryResponse> DescribeDcdnOfflineLogDeliveryWithOptionsAsync(DescribeDcdnOfflineLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnOfflineLogDeliveryResponse>(await DoRPCRequestAsync("DescribeDcdnOfflineLogDelivery", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnOfflineLogDeliveryResponse DescribeDcdnOfflineLogDelivery(DescribeDcdnOfflineLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnOfflineLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnOfflineLogDeliveryResponse> DescribeDcdnOfflineLogDeliveryAsync(DescribeDcdnOfflineLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnOfflineLogDeliveryWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnOfflineLogDeliveryFieldResponse DescribeDcdnOfflineLogDeliveryFieldWithOptions(DescribeDcdnOfflineLogDeliveryFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnOfflineLogDeliveryFieldResponse>(DoRPCRequest("DescribeDcdnOfflineLogDeliveryField", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnOfflineLogDeliveryFieldResponse> DescribeDcdnOfflineLogDeliveryFieldWithOptionsAsync(DescribeDcdnOfflineLogDeliveryFieldRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnOfflineLogDeliveryFieldResponse>(await DoRPCRequestAsync("DescribeDcdnOfflineLogDeliveryField", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnOfflineLogDeliveryFieldResponse DescribeDcdnOfflineLogDeliveryField(DescribeDcdnOfflineLogDeliveryFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnOfflineLogDeliveryFieldWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnOfflineLogDeliveryFieldResponse> DescribeDcdnOfflineLogDeliveryFieldAsync(DescribeDcdnOfflineLogDeliveryFieldRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnOfflineLogDeliveryFieldWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnOfflineLogDeliveryRegionsResponse DescribeDcdnOfflineLogDeliveryRegionsWithOptions(DescribeDcdnOfflineLogDeliveryRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnOfflineLogDeliveryRegionsResponse>(DoRPCRequest("DescribeDcdnOfflineLogDeliveryRegions", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnOfflineLogDeliveryRegionsResponse> DescribeDcdnOfflineLogDeliveryRegionsWithOptionsAsync(DescribeDcdnOfflineLogDeliveryRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnOfflineLogDeliveryRegionsResponse>(await DoRPCRequestAsync("DescribeDcdnOfflineLogDeliveryRegions", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnOfflineLogDeliveryRegionsResponse DescribeDcdnOfflineLogDeliveryRegions(DescribeDcdnOfflineLogDeliveryRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnOfflineLogDeliveryRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnOfflineLogDeliveryRegionsResponse> DescribeDcdnOfflineLogDeliveryRegionsAsync(DescribeDcdnOfflineLogDeliveryRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnOfflineLogDeliveryRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnOfflineLogDeliveryStatusResponse DescribeDcdnOfflineLogDeliveryStatusWithOptions(DescribeDcdnOfflineLogDeliveryStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnOfflineLogDeliveryStatusResponse>(DoRPCRequest("DescribeDcdnOfflineLogDeliveryStatus", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnOfflineLogDeliveryStatusResponse> DescribeDcdnOfflineLogDeliveryStatusWithOptionsAsync(DescribeDcdnOfflineLogDeliveryStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnOfflineLogDeliveryStatusResponse>(await DoRPCRequestAsync("DescribeDcdnOfflineLogDeliveryStatus", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnOfflineLogDeliveryStatusResponse DescribeDcdnOfflineLogDeliveryStatus(DescribeDcdnOfflineLogDeliveryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnOfflineLogDeliveryStatusWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnOfflineLogDeliveryStatusResponse> DescribeDcdnOfflineLogDeliveryStatusAsync(DescribeDcdnOfflineLogDeliveryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnOfflineLogDeliveryStatusWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnRefreshQuotaResponse DescribeDcdnRefreshQuotaWithOptions(DescribeDcdnRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnRefreshQuotaResponse>(DoRPCRequest("DescribeDcdnRefreshQuota", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnRefreshQuotaResponse> DescribeDcdnRefreshQuotaWithOptionsAsync(DescribeDcdnRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnRefreshQuotaResponse>(await DoRPCRequestAsync("DescribeDcdnRefreshQuota", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnRefreshQuotaResponse DescribeDcdnRefreshQuota(DescribeDcdnRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnRefreshQuotaWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnRefreshQuotaResponse> DescribeDcdnRefreshQuotaAsync(DescribeDcdnRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnRefreshQuotaWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnRefreshTasksResponse DescribeDcdnRefreshTasksWithOptions(DescribeDcdnRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnRefreshTasksResponse>(DoRPCRequest("DescribeDcdnRefreshTasks", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnRefreshTasksResponse> DescribeDcdnRefreshTasksWithOptionsAsync(DescribeDcdnRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnRefreshTasksResponse>(await DoRPCRequestAsync("DescribeDcdnRefreshTasks", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnRefreshTasksResponse DescribeDcdnRefreshTasks(DescribeDcdnRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnRefreshTasksWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnRefreshTasksResponse> DescribeDcdnRefreshTasksAsync(DescribeDcdnRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnRefreshTasksWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnRegionAndIspResponse DescribeDcdnRegionAndIspWithOptions(DescribeDcdnRegionAndIspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnRegionAndIspResponse>(DoRPCRequest("DescribeDcdnRegionAndIsp", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnRegionAndIspResponse> DescribeDcdnRegionAndIspWithOptionsAsync(DescribeDcdnRegionAndIspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnRegionAndIspResponse>(await DoRPCRequestAsync("DescribeDcdnRegionAndIsp", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnRegionAndIspResponse DescribeDcdnRegionAndIsp(DescribeDcdnRegionAndIspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnRegionAndIspWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnRegionAndIspResponse> DescribeDcdnRegionAndIspAsync(DescribeDcdnRegionAndIspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnRegionAndIspWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnServiceResponse DescribeDcdnServiceWithOptions(DescribeDcdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnServiceResponse>(DoRPCRequest("DescribeDcdnService", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnServiceResponse> DescribeDcdnServiceWithOptionsAsync(DescribeDcdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnServiceResponse>(await DoRPCRequestAsync("DescribeDcdnService", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnServiceResponse DescribeDcdnService(DescribeDcdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnServiceWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnServiceResponse> DescribeDcdnServiceAsync(DescribeDcdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnServiceWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnStagingIpResponse DescribeDcdnStagingIpWithOptions(DescribeDcdnStagingIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnStagingIpResponse>(DoRPCRequest("DescribeDcdnStagingIp", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnStagingIpResponse> DescribeDcdnStagingIpWithOptionsAsync(DescribeDcdnStagingIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnStagingIpResponse>(await DoRPCRequestAsync("DescribeDcdnStagingIp", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnStagingIpResponse DescribeDcdnStagingIp(DescribeDcdnStagingIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnStagingIpWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnStagingIpResponse> DescribeDcdnStagingIpAsync(DescribeDcdnStagingIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnStagingIpWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnTagResourcesResponse DescribeDcdnTagResourcesWithOptions(DescribeDcdnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnTagResourcesResponse>(DoRPCRequest("DescribeDcdnTagResources", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnTagResourcesResponse> DescribeDcdnTagResourcesWithOptionsAsync(DescribeDcdnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnTagResourcesResponse>(await DoRPCRequestAsync("DescribeDcdnTagResources", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnTagResourcesResponse DescribeDcdnTagResources(DescribeDcdnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnTagResourcesWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnTagResourcesResponse> DescribeDcdnTagResourcesAsync(DescribeDcdnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnTagResourcesWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnTopDomainsByFlowResponse DescribeDcdnTopDomainsByFlowWithOptions(DescribeDcdnTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnTopDomainsByFlowResponse>(DoRPCRequest("DescribeDcdnTopDomainsByFlow", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnTopDomainsByFlowResponse> DescribeDcdnTopDomainsByFlowWithOptionsAsync(DescribeDcdnTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnTopDomainsByFlowResponse>(await DoRPCRequestAsync("DescribeDcdnTopDomainsByFlow", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnTopDomainsByFlowResponse DescribeDcdnTopDomainsByFlow(DescribeDcdnTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnTopDomainsByFlowWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnTopDomainsByFlowResponse> DescribeDcdnTopDomainsByFlowAsync(DescribeDcdnTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnTopDomainsByFlowWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserBillHistoryResponse DescribeDcdnUserBillHistoryWithOptions(DescribeDcdnUserBillHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserBillHistoryResponse>(DoRPCRequest("DescribeDcdnUserBillHistory", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnUserBillHistoryResponse> DescribeDcdnUserBillHistoryWithOptionsAsync(DescribeDcdnUserBillHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserBillHistoryResponse>(await DoRPCRequestAsync("DescribeDcdnUserBillHistory", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnUserBillHistoryResponse DescribeDcdnUserBillHistory(DescribeDcdnUserBillHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserBillHistoryWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserBillHistoryResponse> DescribeDcdnUserBillHistoryAsync(DescribeDcdnUserBillHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserBillHistoryWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserBillTypeResponse DescribeDcdnUserBillTypeWithOptions(DescribeDcdnUserBillTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserBillTypeResponse>(DoRPCRequest("DescribeDcdnUserBillType", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnUserBillTypeResponse> DescribeDcdnUserBillTypeWithOptionsAsync(DescribeDcdnUserBillTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserBillTypeResponse>(await DoRPCRequestAsync("DescribeDcdnUserBillType", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnUserBillTypeResponse DescribeDcdnUserBillType(DescribeDcdnUserBillTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserBillTypeWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserBillTypeResponse> DescribeDcdnUserBillTypeAsync(DescribeDcdnUserBillTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserBillTypeWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserDomainsResponse DescribeDcdnUserDomainsWithOptions(DescribeDcdnUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserDomainsResponse>(DoRPCRequest("DescribeDcdnUserDomains", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnUserDomainsResponse> DescribeDcdnUserDomainsWithOptionsAsync(DescribeDcdnUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserDomainsResponse>(await DoRPCRequestAsync("DescribeDcdnUserDomains", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnUserDomainsResponse DescribeDcdnUserDomains(DescribeDcdnUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserDomainsResponse> DescribeDcdnUserDomainsAsync(DescribeDcdnUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserDomainsByFuncResponse DescribeDcdnUserDomainsByFuncWithOptions(DescribeDcdnUserDomainsByFuncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserDomainsByFuncResponse>(DoRPCRequest("DescribeDcdnUserDomainsByFunc", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnUserDomainsByFuncResponse> DescribeDcdnUserDomainsByFuncWithOptionsAsync(DescribeDcdnUserDomainsByFuncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserDomainsByFuncResponse>(await DoRPCRequestAsync("DescribeDcdnUserDomainsByFunc", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnUserDomainsByFuncResponse DescribeDcdnUserDomainsByFunc(DescribeDcdnUserDomainsByFuncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserDomainsByFuncWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserDomainsByFuncResponse> DescribeDcdnUserDomainsByFuncAsync(DescribeDcdnUserDomainsByFuncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserDomainsByFuncWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserQuotaResponse DescribeDcdnUserQuotaWithOptions(DescribeDcdnUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserQuotaResponse>(DoRPCRequest("DescribeDcdnUserQuota", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnUserQuotaResponse> DescribeDcdnUserQuotaWithOptionsAsync(DescribeDcdnUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserQuotaResponse>(await DoRPCRequestAsync("DescribeDcdnUserQuota", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnUserQuotaResponse DescribeDcdnUserQuota(DescribeDcdnUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserQuotaWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserQuotaResponse> DescribeDcdnUserQuotaAsync(DescribeDcdnUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserQuotaWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserResourcePackageResponse DescribeDcdnUserResourcePackageWithOptions(DescribeDcdnUserResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserResourcePackageResponse>(DoRPCRequest("DescribeDcdnUserResourcePackage", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnUserResourcePackageResponse> DescribeDcdnUserResourcePackageWithOptionsAsync(DescribeDcdnUserResourcePackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserResourcePackageResponse>(await DoRPCRequestAsync("DescribeDcdnUserResourcePackage", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnUserResourcePackageResponse DescribeDcdnUserResourcePackage(DescribeDcdnUserResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserResourcePackageWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserResourcePackageResponse> DescribeDcdnUserResourcePackageAsync(DescribeDcdnUserResourcePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserResourcePackageWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserSecDropResponse DescribeDcdnUserSecDropWithOptions(DescribeDcdnUserSecDropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserSecDropResponse>(DoRPCRequest("DescribeDcdnUserSecDrop", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnUserSecDropResponse> DescribeDcdnUserSecDropWithOptionsAsync(DescribeDcdnUserSecDropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserSecDropResponse>(await DoRPCRequestAsync("DescribeDcdnUserSecDrop", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnUserSecDropResponse DescribeDcdnUserSecDrop(DescribeDcdnUserSecDropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserSecDropWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserSecDropResponse> DescribeDcdnUserSecDropAsync(DescribeDcdnUserSecDropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserSecDropWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnUserTagsResponse DescribeDcdnUserTagsWithOptions(DescribeDcdnUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserTagsResponse>(DoRPCRequest("DescribeDcdnUserTags", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnUserTagsResponse> DescribeDcdnUserTagsWithOptionsAsync(DescribeDcdnUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnUserTagsResponse>(await DoRPCRequestAsync("DescribeDcdnUserTags", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnUserTagsResponse DescribeDcdnUserTags(DescribeDcdnUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnUserTagsWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnUserTagsResponse> DescribeDcdnUserTagsAsync(DescribeDcdnUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnUserTagsWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnVerifyContentResponse DescribeDcdnVerifyContentWithOptions(DescribeDcdnVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnVerifyContentResponse>(DoRPCRequest("DescribeDcdnVerifyContent", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnVerifyContentResponse> DescribeDcdnVerifyContentWithOptionsAsync(DescribeDcdnVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnVerifyContentResponse>(await DoRPCRequestAsync("DescribeDcdnVerifyContent", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnVerifyContentResponse DescribeDcdnVerifyContent(DescribeDcdnVerifyContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnVerifyContentWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnVerifyContentResponse> DescribeDcdnVerifyContentAsync(DescribeDcdnVerifyContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnVerifyContentWithOptionsAsync(request, runtime);
        }

        public DescribeDcdnWafDomainResponse DescribeDcdnWafDomainWithOptions(DescribeDcdnWafDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnWafDomainResponse>(DoRPCRequest("DescribeDcdnWafDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDcdnWafDomainResponse> DescribeDcdnWafDomainWithOptionsAsync(DescribeDcdnWafDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDcdnWafDomainResponse>(await DoRPCRequestAsync("DescribeDcdnWafDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDcdnWafDomainResponse DescribeDcdnWafDomain(DescribeDcdnWafDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDcdnWafDomainWithOptions(request, runtime);
        }

        public async Task<DescribeDcdnWafDomainResponse> DescribeDcdnWafDomainAsync(DescribeDcdnWafDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDcdnWafDomainWithOptionsAsync(request, runtime);
        }

        public DescribeUserDcdnIpaStatusResponse DescribeUserDcdnIpaStatusWithOptions(DescribeUserDcdnIpaStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserDcdnIpaStatusResponse>(DoRPCRequest("DescribeUserDcdnIpaStatus", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserDcdnIpaStatusResponse> DescribeUserDcdnIpaStatusWithOptionsAsync(DescribeUserDcdnIpaStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserDcdnIpaStatusResponse>(await DoRPCRequestAsync("DescribeUserDcdnIpaStatus", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserDcdnIpaStatusResponse DescribeUserDcdnIpaStatus(DescribeUserDcdnIpaStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserDcdnIpaStatusWithOptions(request, runtime);
        }

        public async Task<DescribeUserDcdnIpaStatusResponse> DescribeUserDcdnIpaStatusAsync(DescribeUserDcdnIpaStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserDcdnIpaStatusWithOptionsAsync(request, runtime);
        }

        public DescribeUserDcdnStatusResponse DescribeUserDcdnStatusWithOptions(DescribeUserDcdnStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserDcdnStatusResponse>(DoRPCRequest("DescribeUserDcdnStatus", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserDcdnStatusResponse> DescribeUserDcdnStatusWithOptionsAsync(DescribeUserDcdnStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserDcdnStatusResponse>(await DoRPCRequestAsync("DescribeUserDcdnStatus", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserDcdnStatusResponse DescribeUserDcdnStatus(DescribeUserDcdnStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserDcdnStatusWithOptions(request, runtime);
        }

        public async Task<DescribeUserDcdnStatusResponse> DescribeUserDcdnStatusAsync(DescribeUserDcdnStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserDcdnStatusWithOptionsAsync(request, runtime);
        }

        public DisableDcdnDomainOfflineLogDeliveryResponse DisableDcdnDomainOfflineLogDeliveryWithOptions(DisableDcdnDomainOfflineLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableDcdnDomainOfflineLogDeliveryResponse>(DoRPCRequest("DisableDcdnDomainOfflineLogDelivery", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableDcdnDomainOfflineLogDeliveryResponse> DisableDcdnDomainOfflineLogDeliveryWithOptionsAsync(DisableDcdnDomainOfflineLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableDcdnDomainOfflineLogDeliveryResponse>(await DoRPCRequestAsync("DisableDcdnDomainOfflineLogDelivery", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableDcdnDomainOfflineLogDeliveryResponse DisableDcdnDomainOfflineLogDelivery(DisableDcdnDomainOfflineLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDcdnDomainOfflineLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DisableDcdnDomainOfflineLogDeliveryResponse> DisableDcdnDomainOfflineLogDeliveryAsync(DisableDcdnDomainOfflineLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDcdnDomainOfflineLogDeliveryWithOptionsAsync(request, runtime);
        }

        public DisableDcdnOfflineLogDeliveryResponse DisableDcdnOfflineLogDeliveryWithOptions(DisableDcdnOfflineLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableDcdnOfflineLogDeliveryResponse>(DoRPCRequest("DisableDcdnOfflineLogDelivery", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableDcdnOfflineLogDeliveryResponse> DisableDcdnOfflineLogDeliveryWithOptionsAsync(DisableDcdnOfflineLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableDcdnOfflineLogDeliveryResponse>(await DoRPCRequestAsync("DisableDcdnOfflineLogDelivery", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableDcdnOfflineLogDeliveryResponse DisableDcdnOfflineLogDelivery(DisableDcdnOfflineLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDcdnOfflineLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DisableDcdnOfflineLogDeliveryResponse> DisableDcdnOfflineLogDeliveryAsync(DisableDcdnOfflineLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDcdnOfflineLogDeliveryWithOptionsAsync(request, runtime);
        }

        public EnableDcdnDomainOfflineLogDeliveryResponse EnableDcdnDomainOfflineLogDeliveryWithOptions(EnableDcdnDomainOfflineLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableDcdnDomainOfflineLogDeliveryResponse>(DoRPCRequest("EnableDcdnDomainOfflineLogDelivery", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableDcdnDomainOfflineLogDeliveryResponse> EnableDcdnDomainOfflineLogDeliveryWithOptionsAsync(EnableDcdnDomainOfflineLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableDcdnDomainOfflineLogDeliveryResponse>(await DoRPCRequestAsync("EnableDcdnDomainOfflineLogDelivery", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableDcdnDomainOfflineLogDeliveryResponse EnableDcdnDomainOfflineLogDelivery(EnableDcdnDomainOfflineLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableDcdnDomainOfflineLogDeliveryWithOptions(request, runtime);
        }

        public async Task<EnableDcdnDomainOfflineLogDeliveryResponse> EnableDcdnDomainOfflineLogDeliveryAsync(EnableDcdnDomainOfflineLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableDcdnDomainOfflineLogDeliveryWithOptionsAsync(request, runtime);
        }

        public ModifyDCdnDomainSchdmByPropertyResponse ModifyDCdnDomainSchdmByPropertyWithOptions(ModifyDCdnDomainSchdmByPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDCdnDomainSchdmByPropertyResponse>(DoRPCRequest("ModifyDCdnDomainSchdmByProperty", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDCdnDomainSchdmByPropertyResponse> ModifyDCdnDomainSchdmByPropertyWithOptionsAsync(ModifyDCdnDomainSchdmByPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDCdnDomainSchdmByPropertyResponse>(await DoRPCRequestAsync("ModifyDCdnDomainSchdmByProperty", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDCdnDomainSchdmByPropertyResponse ModifyDCdnDomainSchdmByProperty(ModifyDCdnDomainSchdmByPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDCdnDomainSchdmByPropertyWithOptions(request, runtime);
        }

        public async Task<ModifyDCdnDomainSchdmByPropertyResponse> ModifyDCdnDomainSchdmByPropertyAsync(ModifyDCdnDomainSchdmByPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDCdnDomainSchdmByPropertyWithOptionsAsync(request, runtime);
        }

        public OpenDcdnServiceResponse OpenDcdnServiceWithOptions(OpenDcdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenDcdnServiceResponse>(DoRPCRequest("OpenDcdnService", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenDcdnServiceResponse> OpenDcdnServiceWithOptionsAsync(OpenDcdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenDcdnServiceResponse>(await DoRPCRequestAsync("OpenDcdnService", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenDcdnServiceResponse OpenDcdnService(OpenDcdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenDcdnServiceWithOptions(request, runtime);
        }

        public async Task<OpenDcdnServiceResponse> OpenDcdnServiceAsync(OpenDcdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenDcdnServiceWithOptionsAsync(request, runtime);
        }

        public PreloadDcdnObjectCachesResponse PreloadDcdnObjectCachesWithOptions(PreloadDcdnObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreloadDcdnObjectCachesResponse>(DoRPCRequest("PreloadDcdnObjectCaches", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PreloadDcdnObjectCachesResponse> PreloadDcdnObjectCachesWithOptionsAsync(PreloadDcdnObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreloadDcdnObjectCachesResponse>(await DoRPCRequestAsync("PreloadDcdnObjectCaches", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PreloadDcdnObjectCachesResponse PreloadDcdnObjectCaches(PreloadDcdnObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreloadDcdnObjectCachesWithOptions(request, runtime);
        }

        public async Task<PreloadDcdnObjectCachesResponse> PreloadDcdnObjectCachesAsync(PreloadDcdnObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreloadDcdnObjectCachesWithOptionsAsync(request, runtime);
        }

        public PublishDcdnStagingConfigToProductionResponse PublishDcdnStagingConfigToProductionWithOptions(PublishDcdnStagingConfigToProductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishDcdnStagingConfigToProductionResponse>(DoRPCRequest("PublishDcdnStagingConfigToProduction", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishDcdnStagingConfigToProductionResponse> PublishDcdnStagingConfigToProductionWithOptionsAsync(PublishDcdnStagingConfigToProductionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishDcdnStagingConfigToProductionResponse>(await DoRPCRequestAsync("PublishDcdnStagingConfigToProduction", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishDcdnStagingConfigToProductionResponse PublishDcdnStagingConfigToProduction(PublishDcdnStagingConfigToProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishDcdnStagingConfigToProductionWithOptions(request, runtime);
        }

        public async Task<PublishDcdnStagingConfigToProductionResponse> PublishDcdnStagingConfigToProductionAsync(PublishDcdnStagingConfigToProductionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishDcdnStagingConfigToProductionWithOptionsAsync(request, runtime);
        }

        public RefreshDcdnObjectCachesResponse RefreshDcdnObjectCachesWithOptions(RefreshDcdnObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshDcdnObjectCachesResponse>(DoRPCRequest("RefreshDcdnObjectCaches", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshDcdnObjectCachesResponse> RefreshDcdnObjectCachesWithOptionsAsync(RefreshDcdnObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshDcdnObjectCachesResponse>(await DoRPCRequestAsync("RefreshDcdnObjectCaches", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshDcdnObjectCachesResponse RefreshDcdnObjectCaches(RefreshDcdnObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshDcdnObjectCachesWithOptions(request, runtime);
        }

        public async Task<RefreshDcdnObjectCachesResponse> RefreshDcdnObjectCachesAsync(RefreshDcdnObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshDcdnObjectCachesWithOptionsAsync(request, runtime);
        }

        public RollbackDcdnStagingConfigResponse RollbackDcdnStagingConfigWithOptions(RollbackDcdnStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackDcdnStagingConfigResponse>(DoRPCRequest("RollbackDcdnStagingConfig", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RollbackDcdnStagingConfigResponse> RollbackDcdnStagingConfigWithOptionsAsync(RollbackDcdnStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackDcdnStagingConfigResponse>(await DoRPCRequestAsync("RollbackDcdnStagingConfig", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RollbackDcdnStagingConfigResponse RollbackDcdnStagingConfig(RollbackDcdnStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackDcdnStagingConfigWithOptions(request, runtime);
        }

        public async Task<RollbackDcdnStagingConfigResponse> RollbackDcdnStagingConfigAsync(RollbackDcdnStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackDcdnStagingConfigWithOptionsAsync(request, runtime);
        }

        public SetDcdnConfigOfVersionResponse SetDcdnConfigOfVersionWithOptions(SetDcdnConfigOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDcdnConfigOfVersionResponse>(DoRPCRequest("SetDcdnConfigOfVersion", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDcdnConfigOfVersionResponse> SetDcdnConfigOfVersionWithOptionsAsync(SetDcdnConfigOfVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDcdnConfigOfVersionResponse>(await DoRPCRequestAsync("SetDcdnConfigOfVersion", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDcdnConfigOfVersionResponse SetDcdnConfigOfVersion(SetDcdnConfigOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDcdnConfigOfVersionWithOptions(request, runtime);
        }

        public async Task<SetDcdnConfigOfVersionResponse> SetDcdnConfigOfVersionAsync(SetDcdnConfigOfVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDcdnConfigOfVersionWithOptionsAsync(request, runtime);
        }

        public SetDcdnDomainCertificateResponse SetDcdnDomainCertificateWithOptions(SetDcdnDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDcdnDomainCertificateResponse>(DoRPCRequest("SetDcdnDomainCertificate", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDcdnDomainCertificateResponse> SetDcdnDomainCertificateWithOptionsAsync(SetDcdnDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDcdnDomainCertificateResponse>(await DoRPCRequestAsync("SetDcdnDomainCertificate", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDcdnDomainCertificateResponse SetDcdnDomainCertificate(SetDcdnDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDcdnDomainCertificateWithOptions(request, runtime);
        }

        public async Task<SetDcdnDomainCertificateResponse> SetDcdnDomainCertificateAsync(SetDcdnDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDcdnDomainCertificateWithOptionsAsync(request, runtime);
        }

        public SetDcdnDomainCSRCertificateResponse SetDcdnDomainCSRCertificateWithOptions(SetDcdnDomainCSRCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDcdnDomainCSRCertificateResponse>(DoRPCRequest("SetDcdnDomainCSRCertificate", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDcdnDomainCSRCertificateResponse> SetDcdnDomainCSRCertificateWithOptionsAsync(SetDcdnDomainCSRCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDcdnDomainCSRCertificateResponse>(await DoRPCRequestAsync("SetDcdnDomainCSRCertificate", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDcdnDomainCSRCertificateResponse SetDcdnDomainCSRCertificate(SetDcdnDomainCSRCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDcdnDomainCSRCertificateWithOptions(request, runtime);
        }

        public async Task<SetDcdnDomainCSRCertificateResponse> SetDcdnDomainCSRCertificateAsync(SetDcdnDomainCSRCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDcdnDomainCSRCertificateWithOptionsAsync(request, runtime);
        }

        public SetDcdnDomainStagingConfigResponse SetDcdnDomainStagingConfigWithOptions(SetDcdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDcdnDomainStagingConfigResponse>(DoRPCRequest("SetDcdnDomainStagingConfig", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDcdnDomainStagingConfigResponse> SetDcdnDomainStagingConfigWithOptionsAsync(SetDcdnDomainStagingConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDcdnDomainStagingConfigResponse>(await DoRPCRequestAsync("SetDcdnDomainStagingConfig", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDcdnDomainStagingConfigResponse SetDcdnDomainStagingConfig(SetDcdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDcdnDomainStagingConfigWithOptions(request, runtime);
        }

        public async Task<SetDcdnDomainStagingConfigResponse> SetDcdnDomainStagingConfigAsync(SetDcdnDomainStagingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDcdnDomainStagingConfigWithOptionsAsync(request, runtime);
        }

        public StartDcdnDomainResponse StartDcdnDomainWithOptions(StartDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDcdnDomainResponse>(DoRPCRequest("StartDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartDcdnDomainResponse> StartDcdnDomainWithOptionsAsync(StartDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDcdnDomainResponse>(await DoRPCRequestAsync("StartDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartDcdnDomainResponse StartDcdnDomain(StartDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDcdnDomainWithOptions(request, runtime);
        }

        public async Task<StartDcdnDomainResponse> StartDcdnDomainAsync(StartDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDcdnDomainWithOptionsAsync(request, runtime);
        }

        public StartDcdnIpaDomainResponse StartDcdnIpaDomainWithOptions(StartDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDcdnIpaDomainResponse>(DoRPCRequest("StartDcdnIpaDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartDcdnIpaDomainResponse> StartDcdnIpaDomainWithOptionsAsync(StartDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartDcdnIpaDomainResponse>(await DoRPCRequestAsync("StartDcdnIpaDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartDcdnIpaDomainResponse StartDcdnIpaDomain(StartDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDcdnIpaDomainWithOptions(request, runtime);
        }

        public async Task<StartDcdnIpaDomainResponse> StartDcdnIpaDomainAsync(StartDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDcdnIpaDomainWithOptionsAsync(request, runtime);
        }

        public StopDcdnDomainResponse StopDcdnDomainWithOptions(StopDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDcdnDomainResponse>(DoRPCRequest("StopDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopDcdnDomainResponse> StopDcdnDomainWithOptionsAsync(StopDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDcdnDomainResponse>(await DoRPCRequestAsync("StopDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopDcdnDomainResponse StopDcdnDomain(StopDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDcdnDomainWithOptions(request, runtime);
        }

        public async Task<StopDcdnDomainResponse> StopDcdnDomainAsync(StopDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDcdnDomainWithOptionsAsync(request, runtime);
        }

        public StopDcdnIpaDomainResponse StopDcdnIpaDomainWithOptions(StopDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDcdnIpaDomainResponse>(DoRPCRequest("StopDcdnIpaDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopDcdnIpaDomainResponse> StopDcdnIpaDomainWithOptionsAsync(StopDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopDcdnIpaDomainResponse>(await DoRPCRequestAsync("StopDcdnIpaDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopDcdnIpaDomainResponse StopDcdnIpaDomain(StopDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDcdnIpaDomainWithOptions(request, runtime);
        }

        public async Task<StopDcdnIpaDomainResponse> StopDcdnIpaDomainAsync(StopDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDcdnIpaDomainWithOptionsAsync(request, runtime);
        }

        public TagDcdnResourcesResponse TagDcdnResourcesWithOptions(TagDcdnResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagDcdnResourcesResponse>(DoRPCRequest("TagDcdnResources", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagDcdnResourcesResponse> TagDcdnResourcesWithOptionsAsync(TagDcdnResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagDcdnResourcesResponse>(await DoRPCRequestAsync("TagDcdnResources", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagDcdnResourcesResponse TagDcdnResources(TagDcdnResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagDcdnResourcesWithOptions(request, runtime);
        }

        public async Task<TagDcdnResourcesResponse> TagDcdnResourcesAsync(TagDcdnResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagDcdnResourcesWithOptionsAsync(request, runtime);
        }

        public UntagDcdnResourcesResponse UntagDcdnResourcesWithOptions(UntagDcdnResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagDcdnResourcesResponse>(DoRPCRequest("UntagDcdnResources", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagDcdnResourcesResponse> UntagDcdnResourcesWithOptionsAsync(UntagDcdnResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagDcdnResourcesResponse>(await DoRPCRequestAsync("UntagDcdnResources", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UntagDcdnResourcesResponse UntagDcdnResources(UntagDcdnResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagDcdnResourcesWithOptions(request, runtime);
        }

        public async Task<UntagDcdnResourcesResponse> UntagDcdnResourcesAsync(UntagDcdnResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagDcdnResourcesWithOptionsAsync(request, runtime);
        }

        public UpdateDcdnDomainResponse UpdateDcdnDomainWithOptions(UpdateDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDcdnDomainResponse>(DoRPCRequest("UpdateDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDcdnDomainResponse> UpdateDcdnDomainWithOptionsAsync(UpdateDcdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDcdnDomainResponse>(await DoRPCRequestAsync("UpdateDcdnDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDcdnDomainResponse UpdateDcdnDomain(UpdateDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDcdnDomainWithOptions(request, runtime);
        }

        public async Task<UpdateDcdnDomainResponse> UpdateDcdnDomainAsync(UpdateDcdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDcdnDomainWithOptionsAsync(request, runtime);
        }

        public UpdateDcdnIpaDomainResponse UpdateDcdnIpaDomainWithOptions(UpdateDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDcdnIpaDomainResponse>(DoRPCRequest("UpdateDcdnIpaDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDcdnIpaDomainResponse> UpdateDcdnIpaDomainWithOptionsAsync(UpdateDcdnIpaDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDcdnIpaDomainResponse>(await DoRPCRequestAsync("UpdateDcdnIpaDomain", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDcdnIpaDomainResponse UpdateDcdnIpaDomain(UpdateDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDcdnIpaDomainWithOptions(request, runtime);
        }

        public async Task<UpdateDcdnIpaDomainResponse> UpdateDcdnIpaDomainAsync(UpdateDcdnIpaDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDcdnIpaDomainWithOptionsAsync(request, runtime);
        }

        public VerifyDcdnDomainOwnerResponse VerifyDcdnDomainOwnerWithOptions(VerifyDcdnDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyDcdnDomainOwnerResponse>(DoRPCRequest("VerifyDcdnDomainOwner", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyDcdnDomainOwnerResponse> VerifyDcdnDomainOwnerWithOptionsAsync(VerifyDcdnDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyDcdnDomainOwnerResponse>(await DoRPCRequestAsync("VerifyDcdnDomainOwner", "2018-01-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyDcdnDomainOwnerResponse VerifyDcdnDomainOwner(VerifyDcdnDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyDcdnDomainOwnerWithOptions(request, runtime);
        }

        public async Task<VerifyDcdnDomainOwnerResponse> VerifyDcdnDomainOwnerAsync(VerifyDcdnDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyDcdnDomainOwnerWithOptionsAsync(request, runtime);
        }

    }
}
