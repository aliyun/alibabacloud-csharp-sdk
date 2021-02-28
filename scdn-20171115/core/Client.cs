// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Scdn20171115.Models;

namespace AlibabaCloud.SDK.Scdn20171115
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "scdn.aliyuncs.com"},
                {"ap-northeast-2-pop", "scdn.aliyuncs.com"},
                {"ap-south-1", "scdn.aliyuncs.com"},
                {"ap-southeast-1", "scdn.aliyuncs.com"},
                {"ap-southeast-2", "scdn.aliyuncs.com"},
                {"ap-southeast-3", "scdn.aliyuncs.com"},
                {"ap-southeast-5", "scdn.aliyuncs.com"},
                {"cn-beijing", "scdn.aliyuncs.com"},
                {"cn-beijing-finance-1", "scdn.aliyuncs.com"},
                {"cn-beijing-finance-pop", "scdn.aliyuncs.com"},
                {"cn-beijing-gov-1", "scdn.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "scdn.aliyuncs.com"},
                {"cn-chengdu", "scdn.aliyuncs.com"},
                {"cn-edge-1", "scdn.aliyuncs.com"},
                {"cn-fujian", "scdn.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "scdn.aliyuncs.com"},
                {"cn-hangzhou", "scdn.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "scdn.aliyuncs.com"},
                {"cn-hangzhou-finance", "scdn.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "scdn.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "scdn.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "scdn.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "scdn.aliyuncs.com"},
                {"cn-hangzhou-test-306", "scdn.aliyuncs.com"},
                {"cn-hongkong", "scdn.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "scdn.aliyuncs.com"},
                {"cn-huhehaote", "scdn.aliyuncs.com"},
                {"cn-north-2-gov-1", "scdn.aliyuncs.com"},
                {"cn-qingdao", "scdn.aliyuncs.com"},
                {"cn-qingdao-nebula", "scdn.aliyuncs.com"},
                {"cn-shanghai", "scdn.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "scdn.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "scdn.aliyuncs.com"},
                {"cn-shanghai-finance-1", "scdn.aliyuncs.com"},
                {"cn-shanghai-inner", "scdn.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "scdn.aliyuncs.com"},
                {"cn-shenzhen", "scdn.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "scdn.aliyuncs.com"},
                {"cn-shenzhen-inner", "scdn.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "scdn.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "scdn.aliyuncs.com"},
                {"cn-wuhan", "scdn.aliyuncs.com"},
                {"cn-yushanfang", "scdn.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "scdn.aliyuncs.com"},
                {"cn-zhangjiakou", "scdn.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "scdn.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "scdn.aliyuncs.com"},
                {"eu-central-1", "scdn.aliyuncs.com"},
                {"eu-west-1", "scdn.aliyuncs.com"},
                {"eu-west-1-oxs", "scdn.aliyuncs.com"},
                {"me-east-1", "scdn.aliyuncs.com"},
                {"rus-west-1-pop", "scdn.aliyuncs.com"},
                {"us-east-1", "scdn.aliyuncs.com"},
                {"us-west-1", "scdn.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("scdn", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddScdnDomainResponse AddScdnDomainWithOptions(AddScdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddScdnDomainResponse>(DoRPCRequest("AddScdnDomain", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddScdnDomainResponse> AddScdnDomainWithOptionsAsync(AddScdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddScdnDomainResponse>(await DoRPCRequestAsync("AddScdnDomain", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddScdnDomainResponse AddScdnDomain(AddScdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddScdnDomainWithOptions(request, runtime);
        }

        public async Task<AddScdnDomainResponse> AddScdnDomainAsync(AddScdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddScdnDomainWithOptionsAsync(request, runtime);
        }

        public BatchDeleteScdnDomainConfigsResponse BatchDeleteScdnDomainConfigsWithOptions(BatchDeleteScdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeleteScdnDomainConfigsResponse>(DoRPCRequest("BatchDeleteScdnDomainConfigs", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchDeleteScdnDomainConfigsResponse> BatchDeleteScdnDomainConfigsWithOptionsAsync(BatchDeleteScdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeleteScdnDomainConfigsResponse>(await DoRPCRequestAsync("BatchDeleteScdnDomainConfigs", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchDeleteScdnDomainConfigsResponse BatchDeleteScdnDomainConfigs(BatchDeleteScdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteScdnDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchDeleteScdnDomainConfigsResponse> BatchDeleteScdnDomainConfigsAsync(BatchDeleteScdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteScdnDomainConfigsWithOptionsAsync(request, runtime);
        }

        public BatchSetScdnDomainConfigsResponse BatchSetScdnDomainConfigsWithOptions(BatchSetScdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetScdnDomainConfigsResponse>(DoRPCRequest("BatchSetScdnDomainConfigs", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchSetScdnDomainConfigsResponse> BatchSetScdnDomainConfigsWithOptionsAsync(BatchSetScdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetScdnDomainConfigsResponse>(await DoRPCRequestAsync("BatchSetScdnDomainConfigs", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchSetScdnDomainConfigsResponse BatchSetScdnDomainConfigs(BatchSetScdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetScdnDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchSetScdnDomainConfigsResponse> BatchSetScdnDomainConfigsAsync(BatchSetScdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetScdnDomainConfigsWithOptionsAsync(request, runtime);
        }

        public BatchUpdateScdnDomainResponse BatchUpdateScdnDomainWithOptions(BatchUpdateScdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUpdateScdnDomainResponse>(DoRPCRequest("BatchUpdateScdnDomain", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchUpdateScdnDomainResponse> BatchUpdateScdnDomainWithOptionsAsync(BatchUpdateScdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUpdateScdnDomainResponse>(await DoRPCRequestAsync("BatchUpdateScdnDomain", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchUpdateScdnDomainResponse BatchUpdateScdnDomain(BatchUpdateScdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUpdateScdnDomainWithOptions(request, runtime);
        }

        public async Task<BatchUpdateScdnDomainResponse> BatchUpdateScdnDomainAsync(BatchUpdateScdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUpdateScdnDomainWithOptionsAsync(request, runtime);
        }

        public CheckScdnServiceResponse CheckScdnServiceWithOptions(CheckScdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckScdnServiceResponse>(DoRPCRequest("CheckScdnService", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckScdnServiceResponse> CheckScdnServiceWithOptionsAsync(CheckScdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckScdnServiceResponse>(await DoRPCRequestAsync("CheckScdnService", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckScdnServiceResponse CheckScdnService(CheckScdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckScdnServiceWithOptions(request, runtime);
        }

        public async Task<CheckScdnServiceResponse> CheckScdnServiceAsync(CheckScdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckScdnServiceWithOptionsAsync(request, runtime);
        }

        public DeleteScdnDomainResponse DeleteScdnDomainWithOptions(DeleteScdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScdnDomainResponse>(DoRPCRequest("DeleteScdnDomain", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteScdnDomainResponse> DeleteScdnDomainWithOptionsAsync(DeleteScdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScdnDomainResponse>(await DoRPCRequestAsync("DeleteScdnDomain", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteScdnDomainResponse DeleteScdnDomain(DeleteScdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScdnDomainWithOptions(request, runtime);
        }

        public async Task<DeleteScdnDomainResponse> DeleteScdnDomainAsync(DeleteScdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScdnDomainWithOptionsAsync(request, runtime);
        }

        public DeleteScdnSpecificConfigResponse DeleteScdnSpecificConfigWithOptions(DeleteScdnSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScdnSpecificConfigResponse>(DoRPCRequest("DeleteScdnSpecificConfig", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteScdnSpecificConfigResponse> DeleteScdnSpecificConfigWithOptionsAsync(DeleteScdnSpecificConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScdnSpecificConfigResponse>(await DoRPCRequestAsync("DeleteScdnSpecificConfig", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteScdnSpecificConfigResponse DeleteScdnSpecificConfig(DeleteScdnSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScdnSpecificConfigWithOptions(request, runtime);
        }

        public async Task<DeleteScdnSpecificConfigResponse> DeleteScdnSpecificConfigAsync(DeleteScdnSpecificConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScdnSpecificConfigWithOptionsAsync(request, runtime);
        }

        public DescribeScdnCcQpsInfoResponse DescribeScdnCcQpsInfoWithOptions(DescribeScdnCcQpsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnCcQpsInfoResponse>(DoRPCRequest("DescribeScdnCcQpsInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnCcQpsInfoResponse> DescribeScdnCcQpsInfoWithOptionsAsync(DescribeScdnCcQpsInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnCcQpsInfoResponse>(await DoRPCRequestAsync("DescribeScdnCcQpsInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeScdnCcQpsInfoResponse DescribeScdnCcQpsInfo(DescribeScdnCcQpsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnCcQpsInfoWithOptions(request, runtime);
        }

        public async Task<DescribeScdnCcQpsInfoResponse> DescribeScdnCcQpsInfoAsync(DescribeScdnCcQpsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnCcQpsInfoWithOptionsAsync(request, runtime);
        }

        public DescribeScdnCcTopIpResponse DescribeScdnCcTopIpWithOptions(DescribeScdnCcTopIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnCcTopIpResponse>(DoRPCRequest("DescribeScdnCcTopIp", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnCcTopIpResponse> DescribeScdnCcTopIpWithOptionsAsync(DescribeScdnCcTopIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnCcTopIpResponse>(await DoRPCRequestAsync("DescribeScdnCcTopIp", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeScdnCcTopIpResponse DescribeScdnCcTopIp(DescribeScdnCcTopIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnCcTopIpWithOptions(request, runtime);
        }

        public async Task<DescribeScdnCcTopIpResponse> DescribeScdnCcTopIpAsync(DescribeScdnCcTopIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnCcTopIpWithOptionsAsync(request, runtime);
        }

        public DescribeScdnCcTopUrlResponse DescribeScdnCcTopUrlWithOptions(DescribeScdnCcTopUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnCcTopUrlResponse>(DoRPCRequest("DescribeScdnCcTopUrl", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnCcTopUrlResponse> DescribeScdnCcTopUrlWithOptionsAsync(DescribeScdnCcTopUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnCcTopUrlResponse>(await DoRPCRequestAsync("DescribeScdnCcTopUrl", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeScdnCcTopUrlResponse DescribeScdnCcTopUrl(DescribeScdnCcTopUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnCcTopUrlWithOptions(request, runtime);
        }

        public async Task<DescribeScdnCcTopUrlResponse> DescribeScdnCcTopUrlAsync(DescribeScdnCcTopUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnCcTopUrlWithOptionsAsync(request, runtime);
        }

        public DescribeScdnCertificateDetailResponse DescribeScdnCertificateDetailWithOptions(DescribeScdnCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnCertificateDetailResponse>(DoRPCRequest("DescribeScdnCertificateDetail", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnCertificateDetailResponse> DescribeScdnCertificateDetailWithOptionsAsync(DescribeScdnCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnCertificateDetailResponse>(await DoRPCRequestAsync("DescribeScdnCertificateDetail", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnCertificateDetailResponse DescribeScdnCertificateDetail(DescribeScdnCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnCertificateDetailWithOptions(request, runtime);
        }

        public async Task<DescribeScdnCertificateDetailResponse> DescribeScdnCertificateDetailAsync(DescribeScdnCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnCertificateDetailWithOptionsAsync(request, runtime);
        }

        public DescribeScdnCertificateListResponse DescribeScdnCertificateListWithOptions(DescribeScdnCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnCertificateListResponse>(DoRPCRequest("DescribeScdnCertificateList", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnCertificateListResponse> DescribeScdnCertificateListWithOptionsAsync(DescribeScdnCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnCertificateListResponse>(await DoRPCRequestAsync("DescribeScdnCertificateList", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnCertificateListResponse DescribeScdnCertificateList(DescribeScdnCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnCertificateListWithOptions(request, runtime);
        }

        public async Task<DescribeScdnCertificateListResponse> DescribeScdnCertificateListAsync(DescribeScdnCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnCertificateListWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDDoSInfoResponse DescribeScdnDDoSInfoWithOptions(DescribeScdnDDoSInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDDoSInfoResponse>(DoRPCRequest("DescribeScdnDDoSInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDDoSInfoResponse> DescribeScdnDDoSInfoWithOptionsAsync(DescribeScdnDDoSInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDDoSInfoResponse>(await DoRPCRequestAsync("DescribeScdnDDoSInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeScdnDDoSInfoResponse DescribeScdnDDoSInfo(DescribeScdnDDoSInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDDoSInfoWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDDoSInfoResponse> DescribeScdnDDoSInfoAsync(DescribeScdnDDoSInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDDoSInfoWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDDoSTrafficInfoResponse DescribeScdnDDoSTrafficInfoWithOptions(DescribeScdnDDoSTrafficInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDDoSTrafficInfoResponse>(DoRPCRequest("DescribeScdnDDoSTrafficInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDDoSTrafficInfoResponse> DescribeScdnDDoSTrafficInfoWithOptionsAsync(DescribeScdnDDoSTrafficInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDDoSTrafficInfoResponse>(await DoRPCRequestAsync("DescribeScdnDDoSTrafficInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeScdnDDoSTrafficInfoResponse DescribeScdnDDoSTrafficInfo(DescribeScdnDDoSTrafficInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDDoSTrafficInfoWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDDoSTrafficInfoResponse> DescribeScdnDDoSTrafficInfoAsync(DescribeScdnDDoSTrafficInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDDoSTrafficInfoWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainBpsDataResponse DescribeScdnDomainBpsDataWithOptions(DescribeScdnDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainBpsDataResponse>(DoRPCRequest("DescribeScdnDomainBpsData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainBpsDataResponse> DescribeScdnDomainBpsDataWithOptionsAsync(DescribeScdnDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainBpsDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainBpsData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainBpsDataResponse DescribeScdnDomainBpsData(DescribeScdnDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainBpsDataResponse> DescribeScdnDomainBpsDataAsync(DescribeScdnDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainCertificateInfoResponse DescribeScdnDomainCertificateInfoWithOptions(DescribeScdnDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainCertificateInfoResponse>(DoRPCRequest("DescribeScdnDomainCertificateInfo", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainCertificateInfoResponse> DescribeScdnDomainCertificateInfoWithOptionsAsync(DescribeScdnDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainCertificateInfoResponse>(await DoRPCRequestAsync("DescribeScdnDomainCertificateInfo", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainCertificateInfoResponse DescribeScdnDomainCertificateInfo(DescribeScdnDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainCertificateInfoWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainCertificateInfoResponse> DescribeScdnDomainCertificateInfoAsync(DescribeScdnDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainCertificateInfoWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainCnameResponse DescribeScdnDomainCnameWithOptions(DescribeScdnDomainCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDomainCnameResponse>(DoRPCRequest("DescribeScdnDomainCname", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainCnameResponse> DescribeScdnDomainCnameWithOptionsAsync(DescribeScdnDomainCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDomainCnameResponse>(await DoRPCRequestAsync("DescribeScdnDomainCname", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainCnameResponse DescribeScdnDomainCname(DescribeScdnDomainCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainCnameWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainCnameResponse> DescribeScdnDomainCnameAsync(DescribeScdnDomainCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainCnameWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainConfigsResponse DescribeScdnDomainConfigsWithOptions(DescribeScdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainConfigsResponse>(DoRPCRequest("DescribeScdnDomainConfigs", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainConfigsResponse> DescribeScdnDomainConfigsWithOptionsAsync(DescribeScdnDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainConfigsResponse>(await DoRPCRequestAsync("DescribeScdnDomainConfigs", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainConfigsResponse DescribeScdnDomainConfigs(DescribeScdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainConfigsResponse> DescribeScdnDomainConfigsAsync(DescribeScdnDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainDetailResponse DescribeScdnDomainDetailWithOptions(DescribeScdnDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainDetailResponse>(DoRPCRequest("DescribeScdnDomainDetail", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainDetailResponse> DescribeScdnDomainDetailWithOptionsAsync(DescribeScdnDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainDetailResponse>(await DoRPCRequestAsync("DescribeScdnDomainDetail", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainDetailResponse DescribeScdnDomainDetail(DescribeScdnDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainDetailWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainDetailResponse> DescribeScdnDomainDetailAsync(DescribeScdnDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainDetailWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainHitRateDataResponse DescribeScdnDomainHitRateDataWithOptions(DescribeScdnDomainHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainHitRateDataResponse>(DoRPCRequest("DescribeScdnDomainHitRateData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainHitRateDataResponse> DescribeScdnDomainHitRateDataWithOptionsAsync(DescribeScdnDomainHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainHitRateDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainHitRateData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainHitRateDataResponse DescribeScdnDomainHitRateData(DescribeScdnDomainHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainHitRateDataResponse> DescribeScdnDomainHitRateDataAsync(DescribeScdnDomainHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainHttpCodeDataResponse DescribeScdnDomainHttpCodeDataWithOptions(DescribeScdnDomainHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainHttpCodeDataResponse>(DoRPCRequest("DescribeScdnDomainHttpCodeData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainHttpCodeDataResponse> DescribeScdnDomainHttpCodeDataWithOptionsAsync(DescribeScdnDomainHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainHttpCodeDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainHttpCodeData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainHttpCodeDataResponse DescribeScdnDomainHttpCodeData(DescribeScdnDomainHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainHttpCodeDataResponse> DescribeScdnDomainHttpCodeDataAsync(DescribeScdnDomainHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainIspDataResponse DescribeScdnDomainIspDataWithOptions(DescribeScdnDomainIspDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainIspDataResponse>(DoRPCRequest("DescribeScdnDomainIspData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainIspDataResponse> DescribeScdnDomainIspDataWithOptionsAsync(DescribeScdnDomainIspDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainIspDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainIspData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainIspDataResponse DescribeScdnDomainIspData(DescribeScdnDomainIspDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainIspDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainIspDataResponse> DescribeScdnDomainIspDataAsync(DescribeScdnDomainIspDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainIspDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainLogResponse DescribeScdnDomainLogWithOptions(DescribeScdnDomainLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainLogResponse>(DoRPCRequest("DescribeScdnDomainLog", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainLogResponse> DescribeScdnDomainLogWithOptionsAsync(DescribeScdnDomainLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainLogResponse>(await DoRPCRequestAsync("DescribeScdnDomainLog", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainLogResponse DescribeScdnDomainLog(DescribeScdnDomainLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainLogWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainLogResponse> DescribeScdnDomainLogAsync(DescribeScdnDomainLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainLogWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainOriginBpsDataResponse DescribeScdnDomainOriginBpsDataWithOptions(DescribeScdnDomainOriginBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainOriginBpsDataResponse>(DoRPCRequest("DescribeScdnDomainOriginBpsData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainOriginBpsDataResponse> DescribeScdnDomainOriginBpsDataWithOptionsAsync(DescribeScdnDomainOriginBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainOriginBpsDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainOriginBpsData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainOriginBpsDataResponse DescribeScdnDomainOriginBpsData(DescribeScdnDomainOriginBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainOriginBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainOriginBpsDataResponse> DescribeScdnDomainOriginBpsDataAsync(DescribeScdnDomainOriginBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainOriginBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainOriginTrafficDataResponse DescribeScdnDomainOriginTrafficDataWithOptions(DescribeScdnDomainOriginTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainOriginTrafficDataResponse>(DoRPCRequest("DescribeScdnDomainOriginTrafficData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainOriginTrafficDataResponse> DescribeScdnDomainOriginTrafficDataWithOptionsAsync(DescribeScdnDomainOriginTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainOriginTrafficDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainOriginTrafficData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainOriginTrafficDataResponse DescribeScdnDomainOriginTrafficData(DescribeScdnDomainOriginTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainOriginTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainOriginTrafficDataResponse> DescribeScdnDomainOriginTrafficDataAsync(DescribeScdnDomainOriginTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainOriginTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainPvDataResponse DescribeScdnDomainPvDataWithOptions(DescribeScdnDomainPvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainPvDataResponse>(DoRPCRequest("DescribeScdnDomainPvData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainPvDataResponse> DescribeScdnDomainPvDataWithOptionsAsync(DescribeScdnDomainPvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainPvDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainPvData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainPvDataResponse DescribeScdnDomainPvData(DescribeScdnDomainPvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainPvDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainPvDataResponse> DescribeScdnDomainPvDataAsync(DescribeScdnDomainPvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainPvDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainQpsDataResponse DescribeScdnDomainQpsDataWithOptions(DescribeScdnDomainQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainQpsDataResponse>(DoRPCRequest("DescribeScdnDomainQpsData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainQpsDataResponse> DescribeScdnDomainQpsDataWithOptionsAsync(DescribeScdnDomainQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainQpsDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainQpsData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainQpsDataResponse DescribeScdnDomainQpsData(DescribeScdnDomainQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainQpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainQpsDataResponse> DescribeScdnDomainQpsDataAsync(DescribeScdnDomainQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainQpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainRealTimeBpsDataResponse DescribeScdnDomainRealTimeBpsDataWithOptions(DescribeScdnDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeBpsDataResponse>(DoRPCRequest("DescribeScdnDomainRealTimeBpsData", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainRealTimeBpsDataResponse> DescribeScdnDomainRealTimeBpsDataWithOptionsAsync(DescribeScdnDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeBpsDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainRealTimeBpsData", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainRealTimeBpsDataResponse DescribeScdnDomainRealTimeBpsData(DescribeScdnDomainRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainRealTimeBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainRealTimeBpsDataResponse> DescribeScdnDomainRealTimeBpsDataAsync(DescribeScdnDomainRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainRealTimeBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainRealTimeByteHitRateDataResponse DescribeScdnDomainRealTimeByteHitRateDataWithOptions(DescribeScdnDomainRealTimeByteHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeByteHitRateDataResponse>(DoRPCRequest("DescribeScdnDomainRealTimeByteHitRateData", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainRealTimeByteHitRateDataResponse> DescribeScdnDomainRealTimeByteHitRateDataWithOptionsAsync(DescribeScdnDomainRealTimeByteHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeByteHitRateDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainRealTimeByteHitRateData", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainRealTimeByteHitRateDataResponse DescribeScdnDomainRealTimeByteHitRateData(DescribeScdnDomainRealTimeByteHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainRealTimeByteHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainRealTimeByteHitRateDataResponse> DescribeScdnDomainRealTimeByteHitRateDataAsync(DescribeScdnDomainRealTimeByteHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainRealTimeByteHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainRealTimeHttpCodeDataResponse DescribeScdnDomainRealTimeHttpCodeDataWithOptions(DescribeScdnDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeHttpCodeDataResponse>(DoRPCRequest("DescribeScdnDomainRealTimeHttpCodeData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainRealTimeHttpCodeDataResponse> DescribeScdnDomainRealTimeHttpCodeDataWithOptionsAsync(DescribeScdnDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeHttpCodeDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainRealTimeHttpCodeData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainRealTimeHttpCodeDataResponse DescribeScdnDomainRealTimeHttpCodeData(DescribeScdnDomainRealTimeHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainRealTimeHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainRealTimeHttpCodeDataResponse> DescribeScdnDomainRealTimeHttpCodeDataAsync(DescribeScdnDomainRealTimeHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainRealTimeHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainRealTimeQpsDataResponse DescribeScdnDomainRealTimeQpsDataWithOptions(DescribeScdnDomainRealTimeQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeQpsDataResponse>(DoRPCRequest("DescribeScdnDomainRealTimeQpsData", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainRealTimeQpsDataResponse> DescribeScdnDomainRealTimeQpsDataWithOptionsAsync(DescribeScdnDomainRealTimeQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeQpsDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainRealTimeQpsData", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainRealTimeQpsDataResponse DescribeScdnDomainRealTimeQpsData(DescribeScdnDomainRealTimeQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainRealTimeQpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainRealTimeQpsDataResponse> DescribeScdnDomainRealTimeQpsDataAsync(DescribeScdnDomainRealTimeQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainRealTimeQpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainRealTimeReqHitRateDataResponse DescribeScdnDomainRealTimeReqHitRateDataWithOptions(DescribeScdnDomainRealTimeReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeReqHitRateDataResponse>(DoRPCRequest("DescribeScdnDomainRealTimeReqHitRateData", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainRealTimeReqHitRateDataResponse> DescribeScdnDomainRealTimeReqHitRateDataWithOptionsAsync(DescribeScdnDomainRealTimeReqHitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeReqHitRateDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainRealTimeReqHitRateData", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainRealTimeReqHitRateDataResponse DescribeScdnDomainRealTimeReqHitRateData(DescribeScdnDomainRealTimeReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainRealTimeReqHitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainRealTimeReqHitRateDataResponse> DescribeScdnDomainRealTimeReqHitRateDataAsync(DescribeScdnDomainRealTimeReqHitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainRealTimeReqHitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainRealTimeSrcBpsDataResponse DescribeScdnDomainRealTimeSrcBpsDataWithOptions(DescribeScdnDomainRealTimeSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeSrcBpsDataResponse>(DoRPCRequest("DescribeScdnDomainRealTimeSrcBpsData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainRealTimeSrcBpsDataResponse> DescribeScdnDomainRealTimeSrcBpsDataWithOptionsAsync(DescribeScdnDomainRealTimeSrcBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeSrcBpsDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainRealTimeSrcBpsData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainRealTimeSrcBpsDataResponse DescribeScdnDomainRealTimeSrcBpsData(DescribeScdnDomainRealTimeSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainRealTimeSrcBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainRealTimeSrcBpsDataResponse> DescribeScdnDomainRealTimeSrcBpsDataAsync(DescribeScdnDomainRealTimeSrcBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainRealTimeSrcBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainRealTimeSrcTrafficDataResponse DescribeScdnDomainRealTimeSrcTrafficDataWithOptions(DescribeScdnDomainRealTimeSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeSrcTrafficDataResponse>(DoRPCRequest("DescribeScdnDomainRealTimeSrcTrafficData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainRealTimeSrcTrafficDataResponse> DescribeScdnDomainRealTimeSrcTrafficDataWithOptionsAsync(DescribeScdnDomainRealTimeSrcTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeSrcTrafficDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainRealTimeSrcTrafficData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainRealTimeSrcTrafficDataResponse DescribeScdnDomainRealTimeSrcTrafficData(DescribeScdnDomainRealTimeSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainRealTimeSrcTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainRealTimeSrcTrafficDataResponse> DescribeScdnDomainRealTimeSrcTrafficDataAsync(DescribeScdnDomainRealTimeSrcTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainRealTimeSrcTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainRealTimeTrafficDataResponse DescribeScdnDomainRealTimeTrafficDataWithOptions(DescribeScdnDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeTrafficDataResponse>(DoRPCRequest("DescribeScdnDomainRealTimeTrafficData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainRealTimeTrafficDataResponse> DescribeScdnDomainRealTimeTrafficDataWithOptionsAsync(DescribeScdnDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainRealTimeTrafficDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainRealTimeTrafficData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainRealTimeTrafficDataResponse DescribeScdnDomainRealTimeTrafficData(DescribeScdnDomainRealTimeTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainRealTimeTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainRealTimeTrafficDataResponse> DescribeScdnDomainRealTimeTrafficDataAsync(DescribeScdnDomainRealTimeTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainRealTimeTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainRegionDataResponse DescribeScdnDomainRegionDataWithOptions(DescribeScdnDomainRegionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainRegionDataResponse>(DoRPCRequest("DescribeScdnDomainRegionData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainRegionDataResponse> DescribeScdnDomainRegionDataWithOptionsAsync(DescribeScdnDomainRegionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainRegionDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainRegionData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainRegionDataResponse DescribeScdnDomainRegionData(DescribeScdnDomainRegionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainRegionDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainRegionDataResponse> DescribeScdnDomainRegionDataAsync(DescribeScdnDomainRegionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainRegionDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainTopReferVisitResponse DescribeScdnDomainTopReferVisitWithOptions(DescribeScdnDomainTopReferVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainTopReferVisitResponse>(DoRPCRequest("DescribeScdnDomainTopReferVisit", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainTopReferVisitResponse> DescribeScdnDomainTopReferVisitWithOptionsAsync(DescribeScdnDomainTopReferVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainTopReferVisitResponse>(await DoRPCRequestAsync("DescribeScdnDomainTopReferVisit", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainTopReferVisitResponse DescribeScdnDomainTopReferVisit(DescribeScdnDomainTopReferVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainTopReferVisitWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainTopReferVisitResponse> DescribeScdnDomainTopReferVisitAsync(DescribeScdnDomainTopReferVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainTopReferVisitWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainTopUrlVisitResponse DescribeScdnDomainTopUrlVisitWithOptions(DescribeScdnDomainTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainTopUrlVisitResponse>(DoRPCRequest("DescribeScdnDomainTopUrlVisit", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainTopUrlVisitResponse> DescribeScdnDomainTopUrlVisitWithOptionsAsync(DescribeScdnDomainTopUrlVisitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainTopUrlVisitResponse>(await DoRPCRequestAsync("DescribeScdnDomainTopUrlVisit", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainTopUrlVisitResponse DescribeScdnDomainTopUrlVisit(DescribeScdnDomainTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainTopUrlVisitWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainTopUrlVisitResponse> DescribeScdnDomainTopUrlVisitAsync(DescribeScdnDomainTopUrlVisitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainTopUrlVisitWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainTrafficDataResponse DescribeScdnDomainTrafficDataWithOptions(DescribeScdnDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainTrafficDataResponse>(DoRPCRequest("DescribeScdnDomainTrafficData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainTrafficDataResponse> DescribeScdnDomainTrafficDataWithOptionsAsync(DescribeScdnDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainTrafficDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainTrafficData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainTrafficDataResponse DescribeScdnDomainTrafficData(DescribeScdnDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainTrafficDataResponse> DescribeScdnDomainTrafficDataAsync(DescribeScdnDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnDomainUvDataResponse DescribeScdnDomainUvDataWithOptions(DescribeScdnDomainUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainUvDataResponse>(DoRPCRequest("DescribeScdnDomainUvData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnDomainUvDataResponse> DescribeScdnDomainUvDataWithOptionsAsync(DescribeScdnDomainUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnDomainUvDataResponse>(await DoRPCRequestAsync("DescribeScdnDomainUvData", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnDomainUvDataResponse DescribeScdnDomainUvData(DescribeScdnDomainUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnDomainUvDataWithOptions(request, runtime);
        }

        public async Task<DescribeScdnDomainUvDataResponse> DescribeScdnDomainUvDataAsync(DescribeScdnDomainUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnDomainUvDataWithOptionsAsync(request, runtime);
        }

        public DescribeScdnRefreshQuotaResponse DescribeScdnRefreshQuotaWithOptions(DescribeScdnRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnRefreshQuotaResponse>(DoRPCRequest("DescribeScdnRefreshQuota", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnRefreshQuotaResponse> DescribeScdnRefreshQuotaWithOptionsAsync(DescribeScdnRefreshQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnRefreshQuotaResponse>(await DoRPCRequestAsync("DescribeScdnRefreshQuota", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnRefreshQuotaResponse DescribeScdnRefreshQuota(DescribeScdnRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnRefreshQuotaWithOptions(request, runtime);
        }

        public async Task<DescribeScdnRefreshQuotaResponse> DescribeScdnRefreshQuotaAsync(DescribeScdnRefreshQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnRefreshQuotaWithOptionsAsync(request, runtime);
        }

        public DescribeScdnRefreshTasksResponse DescribeScdnRefreshTasksWithOptions(DescribeScdnRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnRefreshTasksResponse>(DoRPCRequest("DescribeScdnRefreshTasks", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnRefreshTasksResponse> DescribeScdnRefreshTasksWithOptionsAsync(DescribeScdnRefreshTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnRefreshTasksResponse>(await DoRPCRequestAsync("DescribeScdnRefreshTasks", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnRefreshTasksResponse DescribeScdnRefreshTasks(DescribeScdnRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnRefreshTasksWithOptions(request, runtime);
        }

        public async Task<DescribeScdnRefreshTasksResponse> DescribeScdnRefreshTasksAsync(DescribeScdnRefreshTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnRefreshTasksWithOptionsAsync(request, runtime);
        }

        public DescribeScdnServiceResponse DescribeScdnServiceWithOptions(DescribeScdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnServiceResponse>(DoRPCRequest("DescribeScdnService", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnServiceResponse> DescribeScdnServiceWithOptionsAsync(DescribeScdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnServiceResponse>(await DoRPCRequestAsync("DescribeScdnService", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnServiceResponse DescribeScdnService(DescribeScdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnServiceWithOptions(request, runtime);
        }

        public async Task<DescribeScdnServiceResponse> DescribeScdnServiceAsync(DescribeScdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnServiceWithOptionsAsync(request, runtime);
        }

        public DescribeScdnTopDomainsByFlowResponse DescribeScdnTopDomainsByFlowWithOptions(DescribeScdnTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnTopDomainsByFlowResponse>(DoRPCRequest("DescribeScdnTopDomainsByFlow", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnTopDomainsByFlowResponse> DescribeScdnTopDomainsByFlowWithOptionsAsync(DescribeScdnTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnTopDomainsByFlowResponse>(await DoRPCRequestAsync("DescribeScdnTopDomainsByFlow", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnTopDomainsByFlowResponse DescribeScdnTopDomainsByFlow(DescribeScdnTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnTopDomainsByFlowWithOptions(request, runtime);
        }

        public async Task<DescribeScdnTopDomainsByFlowResponse> DescribeScdnTopDomainsByFlowAsync(DescribeScdnTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnTopDomainsByFlowWithOptionsAsync(request, runtime);
        }

        public DescribeScdnUserDomainsResponse DescribeScdnUserDomainsWithOptions(DescribeScdnUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnUserDomainsResponse>(DoRPCRequest("DescribeScdnUserDomains", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnUserDomainsResponse> DescribeScdnUserDomainsWithOptionsAsync(DescribeScdnUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnUserDomainsResponse>(await DoRPCRequestAsync("DescribeScdnUserDomains", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnUserDomainsResponse DescribeScdnUserDomains(DescribeScdnUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnUserDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeScdnUserDomainsResponse> DescribeScdnUserDomainsAsync(DescribeScdnUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnUserDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeScdnUserProtectInfoResponse DescribeScdnUserProtectInfoWithOptions(DescribeScdnUserProtectInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnUserProtectInfoResponse>(DoRPCRequest("DescribeScdnUserProtectInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnUserProtectInfoResponse> DescribeScdnUserProtectInfoWithOptionsAsync(DescribeScdnUserProtectInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeScdnUserProtectInfoResponse>(await DoRPCRequestAsync("DescribeScdnUserProtectInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeScdnUserProtectInfoResponse DescribeScdnUserProtectInfo(DescribeScdnUserProtectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnUserProtectInfoWithOptions(request, runtime);
        }

        public async Task<DescribeScdnUserProtectInfoResponse> DescribeScdnUserProtectInfoAsync(DescribeScdnUserProtectInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnUserProtectInfoWithOptionsAsync(request, runtime);
        }

        public DescribeScdnUserQuotaResponse DescribeScdnUserQuotaWithOptions(DescribeScdnUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnUserQuotaResponse>(DoRPCRequest("DescribeScdnUserQuota", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScdnUserQuotaResponse> DescribeScdnUserQuotaWithOptionsAsync(DescribeScdnUserQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScdnUserQuotaResponse>(await DoRPCRequestAsync("DescribeScdnUserQuota", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScdnUserQuotaResponse DescribeScdnUserQuota(DescribeScdnUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScdnUserQuotaWithOptions(request, runtime);
        }

        public async Task<DescribeScdnUserQuotaResponse> DescribeScdnUserQuotaAsync(DescribeScdnUserQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScdnUserQuotaWithOptionsAsync(request, runtime);
        }

        public OpenScdnServiceResponse OpenScdnServiceWithOptions(OpenScdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenScdnServiceResponse>(DoRPCRequest("OpenScdnService", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenScdnServiceResponse> OpenScdnServiceWithOptionsAsync(OpenScdnServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenScdnServiceResponse>(await DoRPCRequestAsync("OpenScdnService", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenScdnServiceResponse OpenScdnService(OpenScdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenScdnServiceWithOptions(request, runtime);
        }

        public async Task<OpenScdnServiceResponse> OpenScdnServiceAsync(OpenScdnServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenScdnServiceWithOptionsAsync(request, runtime);
        }

        public PreloadScdnObjectCachesResponse PreloadScdnObjectCachesWithOptions(PreloadScdnObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreloadScdnObjectCachesResponse>(DoRPCRequest("PreloadScdnObjectCaches", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PreloadScdnObjectCachesResponse> PreloadScdnObjectCachesWithOptionsAsync(PreloadScdnObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreloadScdnObjectCachesResponse>(await DoRPCRequestAsync("PreloadScdnObjectCaches", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PreloadScdnObjectCachesResponse PreloadScdnObjectCaches(PreloadScdnObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreloadScdnObjectCachesWithOptions(request, runtime);
        }

        public async Task<PreloadScdnObjectCachesResponse> PreloadScdnObjectCachesAsync(PreloadScdnObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreloadScdnObjectCachesWithOptionsAsync(request, runtime);
        }

        public RefreshScdnObjectCachesResponse RefreshScdnObjectCachesWithOptions(RefreshScdnObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshScdnObjectCachesResponse>(DoRPCRequest("RefreshScdnObjectCaches", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshScdnObjectCachesResponse> RefreshScdnObjectCachesWithOptionsAsync(RefreshScdnObjectCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshScdnObjectCachesResponse>(await DoRPCRequestAsync("RefreshScdnObjectCaches", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshScdnObjectCachesResponse RefreshScdnObjectCaches(RefreshScdnObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshScdnObjectCachesWithOptions(request, runtime);
        }

        public async Task<RefreshScdnObjectCachesResponse> RefreshScdnObjectCachesAsync(RefreshScdnObjectCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshScdnObjectCachesWithOptionsAsync(request, runtime);
        }

        public SetScdnBotInfoResponse SetScdnBotInfoWithOptions(SetScdnBotInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetScdnBotInfoResponse>(DoRPCRequest("SetScdnBotInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SetScdnBotInfoResponse> SetScdnBotInfoWithOptionsAsync(SetScdnBotInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetScdnBotInfoResponse>(await DoRPCRequestAsync("SetScdnBotInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SetScdnBotInfoResponse SetScdnBotInfo(SetScdnBotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetScdnBotInfoWithOptions(request, runtime);
        }

        public async Task<SetScdnBotInfoResponse> SetScdnBotInfoAsync(SetScdnBotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetScdnBotInfoWithOptionsAsync(request, runtime);
        }

        public SetScdnCcInfoResponse SetScdnCcInfoWithOptions(SetScdnCcInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetScdnCcInfoResponse>(DoRPCRequest("SetScdnCcInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SetScdnCcInfoResponse> SetScdnCcInfoWithOptionsAsync(SetScdnCcInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetScdnCcInfoResponse>(await DoRPCRequestAsync("SetScdnCcInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SetScdnCcInfoResponse SetScdnCcInfo(SetScdnCcInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetScdnCcInfoWithOptions(request, runtime);
        }

        public async Task<SetScdnCcInfoResponse> SetScdnCcInfoAsync(SetScdnCcInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetScdnCcInfoWithOptionsAsync(request, runtime);
        }

        public SetScdnDDoSInfoResponse SetScdnDDoSInfoWithOptions(SetScdnDDoSInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetScdnDDoSInfoResponse>(DoRPCRequest("SetScdnDDoSInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SetScdnDDoSInfoResponse> SetScdnDDoSInfoWithOptionsAsync(SetScdnDDoSInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetScdnDDoSInfoResponse>(await DoRPCRequestAsync("SetScdnDDoSInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SetScdnDDoSInfoResponse SetScdnDDoSInfo(SetScdnDDoSInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetScdnDDoSInfoWithOptions(request, runtime);
        }

        public async Task<SetScdnDDoSInfoResponse> SetScdnDDoSInfoAsync(SetScdnDDoSInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetScdnDDoSInfoWithOptionsAsync(request, runtime);
        }

        public SetScdnDomainBizInfoResponse SetScdnDomainBizInfoWithOptions(SetScdnDomainBizInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetScdnDomainBizInfoResponse>(DoRPCRequest("SetScdnDomainBizInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SetScdnDomainBizInfoResponse> SetScdnDomainBizInfoWithOptionsAsync(SetScdnDomainBizInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetScdnDomainBizInfoResponse>(await DoRPCRequestAsync("SetScdnDomainBizInfo", "2017-11-15", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SetScdnDomainBizInfoResponse SetScdnDomainBizInfo(SetScdnDomainBizInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetScdnDomainBizInfoWithOptions(request, runtime);
        }

        public async Task<SetScdnDomainBizInfoResponse> SetScdnDomainBizInfoAsync(SetScdnDomainBizInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetScdnDomainBizInfoWithOptionsAsync(request, runtime);
        }

        public SetScdnDomainCertificateResponse SetScdnDomainCertificateWithOptions(SetScdnDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetScdnDomainCertificateResponse>(DoRPCRequest("SetScdnDomainCertificate", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetScdnDomainCertificateResponse> SetScdnDomainCertificateWithOptionsAsync(SetScdnDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetScdnDomainCertificateResponse>(await DoRPCRequestAsync("SetScdnDomainCertificate", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetScdnDomainCertificateResponse SetScdnDomainCertificate(SetScdnDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetScdnDomainCertificateWithOptions(request, runtime);
        }

        public async Task<SetScdnDomainCertificateResponse> SetScdnDomainCertificateAsync(SetScdnDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetScdnDomainCertificateWithOptionsAsync(request, runtime);
        }

        public StartScdnDomainResponse StartScdnDomainWithOptions(StartScdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartScdnDomainResponse>(DoRPCRequest("StartScdnDomain", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartScdnDomainResponse> StartScdnDomainWithOptionsAsync(StartScdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartScdnDomainResponse>(await DoRPCRequestAsync("StartScdnDomain", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartScdnDomainResponse StartScdnDomain(StartScdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartScdnDomainWithOptions(request, runtime);
        }

        public async Task<StartScdnDomainResponse> StartScdnDomainAsync(StartScdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartScdnDomainWithOptionsAsync(request, runtime);
        }

        public StopScdnDomainResponse StopScdnDomainWithOptions(StopScdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopScdnDomainResponse>(DoRPCRequest("StopScdnDomain", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopScdnDomainResponse> StopScdnDomainWithOptionsAsync(StopScdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopScdnDomainResponse>(await DoRPCRequestAsync("StopScdnDomain", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopScdnDomainResponse StopScdnDomain(StopScdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopScdnDomainWithOptions(request, runtime);
        }

        public async Task<StopScdnDomainResponse> StopScdnDomainAsync(StopScdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopScdnDomainWithOptionsAsync(request, runtime);
        }

        public UpdateScdnDomainResponse UpdateScdnDomainWithOptions(UpdateScdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateScdnDomainResponse>(DoRPCRequest("UpdateScdnDomain", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateScdnDomainResponse> UpdateScdnDomainWithOptionsAsync(UpdateScdnDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateScdnDomainResponse>(await DoRPCRequestAsync("UpdateScdnDomain", "2017-11-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateScdnDomainResponse UpdateScdnDomain(UpdateScdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateScdnDomainWithOptions(request, runtime);
        }

        public async Task<UpdateScdnDomainResponse> UpdateScdnDomainAsync(UpdateScdnDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateScdnDomainWithOptionsAsync(request, runtime);
        }

    }
}
