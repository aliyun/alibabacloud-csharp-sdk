// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Alidns20150109.Models;

namespace AlibabaCloud.SDK.Alidns20150109
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "alidns.ap-northeast-1.aliyuncs.com"},
                {"ap-northeast-2-pop", "dns.aliyuncs.com"},
                {"ap-south-1", "alidns.ap-south-1.aliyuncs.com"},
                {"ap-southeast-1", "alidns.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "alidns.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "alidns.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "alidns.ap-southeast-5.aliyuncs.com"},
                {"cn-beijing", "alidns.cn-beijing.aliyuncs.com"},
                {"cn-beijing-finance-1", "dns.aliyuncs.com"},
                {"cn-beijing-finance-pop", "dns.aliyuncs.com"},
                {"cn-beijing-gov-1", "dns.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "dns.aliyuncs.com"},
                {"cn-chengdu", "alidns.cn-chengdu.aliyuncs.com"},
                {"cn-edge-1", "dns.aliyuncs.com"},
                {"cn-fujian", "dns.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "dns.aliyuncs.com"},
                {"cn-hangzhou", "alidns.cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "dns.aliyuncs.com"},
                {"cn-hangzhou-finance", "alidns.cn-hangzhou-finance.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "dns.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "dns.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "dns.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "dns.aliyuncs.com"},
                {"cn-hangzhou-test-306", "dns.aliyuncs.com"},
                {"cn-hongkong", "alidns.cn-hongkong.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "dns.aliyuncs.com"},
                {"cn-huhehaote", "alidns.cn-huhehaote.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "dns.aliyuncs.com"},
                {"cn-north-2-gov-1", "alidns.cn-north-2-gov-1.aliyuncs.com"},
                {"cn-qingdao", "dns.aliyuncs.com"},
                {"cn-qingdao-nebula", "dns.aliyuncs.com"},
                {"cn-shanghai", "alidns.cn-shanghai.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "dns.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "dns.aliyuncs.com"},
                {"cn-shanghai-finance-1", "alidns.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-shanghai-inner", "dns.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "dns.aliyuncs.com"},
                {"cn-shenzhen", "alidns.cn-shenzhen.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "alidns.cn-shenzhen-finance-1.aliyuncs.com"},
                {"cn-shenzhen-inner", "dns.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "dns.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "dns.aliyuncs.com"},
                {"cn-wuhan", "dns.aliyuncs.com"},
                {"cn-wulanchabu", "dns.aliyuncs.com"},
                {"cn-yushanfang", "dns.aliyuncs.com"},
                {"cn-zhangbei", "dns.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "dns.aliyuncs.com"},
                {"cn-zhangjiakou", "alidns.cn-zhangjiakou.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "dns.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "dns.aliyuncs.com"},
                {"eu-central-1", "alidns.eu-central-1.aliyuncs.com"},
                {"eu-west-1", "alidns.eu-west-1.aliyuncs.com"},
                {"eu-west-1-oxs", "dns.aliyuncs.com"},
                {"me-east-1", "alidns.me-east-1.aliyuncs.com"},
                {"rus-west-1-pop", "dns.aliyuncs.com"},
                {"us-east-1", "alidns.us-east-1.aliyuncs.com"},
                {"us-west-1", "alidns.us-west-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("alidns", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddCustomLineResponse AddCustomLineWithOptions(AddCustomLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCustomLineResponse>(DoRPCRequest("AddCustomLine", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCustomLineResponse> AddCustomLineWithOptionsAsync(AddCustomLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCustomLineResponse>(await DoRPCRequestAsync("AddCustomLine", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCustomLineResponse AddCustomLine(AddCustomLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomLineWithOptions(request, runtime);
        }

        public async Task<AddCustomLineResponse> AddCustomLineAsync(AddCustomLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomLineWithOptionsAsync(request, runtime);
        }

        public AddDnsCacheDomainResponse AddDnsCacheDomainWithOptions(AddDnsCacheDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDnsCacheDomainResponse>(DoRPCRequest("AddDnsCacheDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDnsCacheDomainResponse> AddDnsCacheDomainWithOptionsAsync(AddDnsCacheDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDnsCacheDomainResponse>(await DoRPCRequestAsync("AddDnsCacheDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDnsCacheDomainResponse AddDnsCacheDomain(AddDnsCacheDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDnsCacheDomainWithOptions(request, runtime);
        }

        public async Task<AddDnsCacheDomainResponse> AddDnsCacheDomainAsync(AddDnsCacheDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDnsCacheDomainWithOptionsAsync(request, runtime);
        }

        public AddDnsGtmAccessStrategyResponse AddDnsGtmAccessStrategyWithOptions(AddDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDnsGtmAccessStrategyResponse>(DoRPCRequest("AddDnsGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDnsGtmAccessStrategyResponse> AddDnsGtmAccessStrategyWithOptionsAsync(AddDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDnsGtmAccessStrategyResponse>(await DoRPCRequestAsync("AddDnsGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDnsGtmAccessStrategyResponse AddDnsGtmAccessStrategy(AddDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDnsGtmAccessStrategyWithOptions(request, runtime);
        }

        public async Task<AddDnsGtmAccessStrategyResponse> AddDnsGtmAccessStrategyAsync(AddDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDnsGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        public AddDnsGtmAddressPoolResponse AddDnsGtmAddressPoolWithOptions(AddDnsGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDnsGtmAddressPoolResponse>(DoRPCRequest("AddDnsGtmAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDnsGtmAddressPoolResponse> AddDnsGtmAddressPoolWithOptionsAsync(AddDnsGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDnsGtmAddressPoolResponse>(await DoRPCRequestAsync("AddDnsGtmAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDnsGtmAddressPoolResponse AddDnsGtmAddressPool(AddDnsGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDnsGtmAddressPoolWithOptions(request, runtime);
        }

        public async Task<AddDnsGtmAddressPoolResponse> AddDnsGtmAddressPoolAsync(AddDnsGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDnsGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        public AddDnsGtmMonitorResponse AddDnsGtmMonitorWithOptions(AddDnsGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDnsGtmMonitorResponse>(DoRPCRequest("AddDnsGtmMonitor", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDnsGtmMonitorResponse> AddDnsGtmMonitorWithOptionsAsync(AddDnsGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDnsGtmMonitorResponse>(await DoRPCRequestAsync("AddDnsGtmMonitor", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDnsGtmMonitorResponse AddDnsGtmMonitor(AddDnsGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDnsGtmMonitorWithOptions(request, runtime);
        }

        public async Task<AddDnsGtmMonitorResponse> AddDnsGtmMonitorAsync(AddDnsGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDnsGtmMonitorWithOptionsAsync(request, runtime);
        }

        public AddDomainResponse AddDomainWithOptions(AddDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDomainResponse>(DoRPCRequest("AddDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDomainResponse> AddDomainWithOptionsAsync(AddDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDomainResponse>(await DoRPCRequestAsync("AddDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDomainResponse AddDomain(AddDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDomainWithOptions(request, runtime);
        }

        public async Task<AddDomainResponse> AddDomainAsync(AddDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDomainWithOptionsAsync(request, runtime);
        }

        public AddDomainBackupResponse AddDomainBackupWithOptions(AddDomainBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDomainBackupResponse>(DoRPCRequest("AddDomainBackup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDomainBackupResponse> AddDomainBackupWithOptionsAsync(AddDomainBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDomainBackupResponse>(await DoRPCRequestAsync("AddDomainBackup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDomainBackupResponse AddDomainBackup(AddDomainBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDomainBackupWithOptions(request, runtime);
        }

        public async Task<AddDomainBackupResponse> AddDomainBackupAsync(AddDomainBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDomainBackupWithOptionsAsync(request, runtime);
        }

        public AddDomainGroupResponse AddDomainGroupWithOptions(AddDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDomainGroupResponse>(DoRPCRequest("AddDomainGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDomainGroupResponse> AddDomainGroupWithOptionsAsync(AddDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDomainGroupResponse>(await DoRPCRequestAsync("AddDomainGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDomainGroupResponse AddDomainGroup(AddDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDomainGroupWithOptions(request, runtime);
        }

        public async Task<AddDomainGroupResponse> AddDomainGroupAsync(AddDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDomainGroupWithOptionsAsync(request, runtime);
        }

        public AddDomainRecordResponse AddDomainRecordWithOptions(AddDomainRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDomainRecordResponse>(DoRPCRequest("AddDomainRecord", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDomainRecordResponse> AddDomainRecordWithOptionsAsync(AddDomainRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDomainRecordResponse>(await DoRPCRequestAsync("AddDomainRecord", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDomainRecordResponse AddDomainRecord(AddDomainRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDomainRecordWithOptions(request, runtime);
        }

        public async Task<AddDomainRecordResponse> AddDomainRecordAsync(AddDomainRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDomainRecordWithOptionsAsync(request, runtime);
        }

        public AddGtmAccessStrategyResponse AddGtmAccessStrategyWithOptions(AddGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGtmAccessStrategyResponse>(DoRPCRequest("AddGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddGtmAccessStrategyResponse> AddGtmAccessStrategyWithOptionsAsync(AddGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGtmAccessStrategyResponse>(await DoRPCRequestAsync("AddGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddGtmAccessStrategyResponse AddGtmAccessStrategy(AddGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGtmAccessStrategyWithOptions(request, runtime);
        }

        public async Task<AddGtmAccessStrategyResponse> AddGtmAccessStrategyAsync(AddGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        public AddGtmAddressPoolResponse AddGtmAddressPoolWithOptions(AddGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGtmAddressPoolResponse>(DoRPCRequest("AddGtmAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddGtmAddressPoolResponse> AddGtmAddressPoolWithOptionsAsync(AddGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGtmAddressPoolResponse>(await DoRPCRequestAsync("AddGtmAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddGtmAddressPoolResponse AddGtmAddressPool(AddGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGtmAddressPoolWithOptions(request, runtime);
        }

        public async Task<AddGtmAddressPoolResponse> AddGtmAddressPoolAsync(AddGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        public AddGtmMonitorResponse AddGtmMonitorWithOptions(AddGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGtmMonitorResponse>(DoRPCRequest("AddGtmMonitor", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddGtmMonitorResponse> AddGtmMonitorWithOptionsAsync(AddGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGtmMonitorResponse>(await DoRPCRequestAsync("AddGtmMonitor", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddGtmMonitorResponse AddGtmMonitor(AddGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGtmMonitorWithOptions(request, runtime);
        }

        public async Task<AddGtmMonitorResponse> AddGtmMonitorAsync(AddGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGtmMonitorWithOptionsAsync(request, runtime);
        }

        public AddGtmRecoveryPlanResponse AddGtmRecoveryPlanWithOptions(AddGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGtmRecoveryPlanResponse>(DoRPCRequest("AddGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddGtmRecoveryPlanResponse> AddGtmRecoveryPlanWithOptionsAsync(AddGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGtmRecoveryPlanResponse>(await DoRPCRequestAsync("AddGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddGtmRecoveryPlanResponse AddGtmRecoveryPlan(AddGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGtmRecoveryPlanWithOptions(request, runtime);
        }

        public async Task<AddGtmRecoveryPlanResponse> AddGtmRecoveryPlanAsync(AddGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        public BindInstanceDomainsResponse BindInstanceDomainsWithOptions(BindInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindInstanceDomainsResponse>(DoRPCRequest("BindInstanceDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindInstanceDomainsResponse> BindInstanceDomainsWithOptionsAsync(BindInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindInstanceDomainsResponse>(await DoRPCRequestAsync("BindInstanceDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindInstanceDomainsResponse BindInstanceDomains(BindInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindInstanceDomainsWithOptions(request, runtime);
        }

        public async Task<BindInstanceDomainsResponse> BindInstanceDomainsAsync(BindInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindInstanceDomainsWithOptionsAsync(request, runtime);
        }

        public ChangeDomainGroupResponse ChangeDomainGroupWithOptions(ChangeDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeDomainGroupResponse>(DoRPCRequest("ChangeDomainGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeDomainGroupResponse> ChangeDomainGroupWithOptionsAsync(ChangeDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeDomainGroupResponse>(await DoRPCRequestAsync("ChangeDomainGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeDomainGroupResponse ChangeDomainGroup(ChangeDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeDomainGroupWithOptions(request, runtime);
        }

        public async Task<ChangeDomainGroupResponse> ChangeDomainGroupAsync(ChangeDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeDomainGroupWithOptionsAsync(request, runtime);
        }

        public ChangeDomainOfDnsProductResponse ChangeDomainOfDnsProductWithOptions(ChangeDomainOfDnsProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeDomainOfDnsProductResponse>(DoRPCRequest("ChangeDomainOfDnsProduct", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeDomainOfDnsProductResponse> ChangeDomainOfDnsProductWithOptionsAsync(ChangeDomainOfDnsProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeDomainOfDnsProductResponse>(await DoRPCRequestAsync("ChangeDomainOfDnsProduct", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeDomainOfDnsProductResponse ChangeDomainOfDnsProduct(ChangeDomainOfDnsProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeDomainOfDnsProductWithOptions(request, runtime);
        }

        public async Task<ChangeDomainOfDnsProductResponse> ChangeDomainOfDnsProductAsync(ChangeDomainOfDnsProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeDomainOfDnsProductWithOptionsAsync(request, runtime);
        }

        public CopyGtmConfigResponse CopyGtmConfigWithOptions(CopyGtmConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyGtmConfigResponse>(DoRPCRequest("CopyGtmConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CopyGtmConfigResponse> CopyGtmConfigWithOptionsAsync(CopyGtmConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyGtmConfigResponse>(await DoRPCRequestAsync("CopyGtmConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CopyGtmConfigResponse CopyGtmConfig(CopyGtmConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyGtmConfigWithOptions(request, runtime);
        }

        public async Task<CopyGtmConfigResponse> CopyGtmConfigAsync(CopyGtmConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyGtmConfigWithOptionsAsync(request, runtime);
        }

        public DeleteCustomLinesResponse DeleteCustomLinesWithOptions(DeleteCustomLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCustomLinesResponse>(DoRPCRequest("DeleteCustomLines", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCustomLinesResponse> DeleteCustomLinesWithOptionsAsync(DeleteCustomLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCustomLinesResponse>(await DoRPCRequestAsync("DeleteCustomLines", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCustomLinesResponse DeleteCustomLines(DeleteCustomLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomLinesWithOptions(request, runtime);
        }

        public async Task<DeleteCustomLinesResponse> DeleteCustomLinesAsync(DeleteCustomLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomLinesWithOptionsAsync(request, runtime);
        }

        public DeleteDnsCacheDomainResponse DeleteDnsCacheDomainWithOptions(DeleteDnsCacheDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDnsCacheDomainResponse>(DoRPCRequest("DeleteDnsCacheDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDnsCacheDomainResponse> DeleteDnsCacheDomainWithOptionsAsync(DeleteDnsCacheDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDnsCacheDomainResponse>(await DoRPCRequestAsync("DeleteDnsCacheDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDnsCacheDomainResponse DeleteDnsCacheDomain(DeleteDnsCacheDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDnsCacheDomainWithOptions(request, runtime);
        }

        public async Task<DeleteDnsCacheDomainResponse> DeleteDnsCacheDomainAsync(DeleteDnsCacheDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDnsCacheDomainWithOptionsAsync(request, runtime);
        }

        public DeleteDnsGtmAccessStrategyResponse DeleteDnsGtmAccessStrategyWithOptions(DeleteDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDnsGtmAccessStrategyResponse>(DoRPCRequest("DeleteDnsGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDnsGtmAccessStrategyResponse> DeleteDnsGtmAccessStrategyWithOptionsAsync(DeleteDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDnsGtmAccessStrategyResponse>(await DoRPCRequestAsync("DeleteDnsGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDnsGtmAccessStrategyResponse DeleteDnsGtmAccessStrategy(DeleteDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDnsGtmAccessStrategyWithOptions(request, runtime);
        }

        public async Task<DeleteDnsGtmAccessStrategyResponse> DeleteDnsGtmAccessStrategyAsync(DeleteDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDnsGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        public DeleteDnsGtmAddressPoolResponse DeleteDnsGtmAddressPoolWithOptions(DeleteDnsGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDnsGtmAddressPoolResponse>(DoRPCRequest("DeleteDnsGtmAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDnsGtmAddressPoolResponse> DeleteDnsGtmAddressPoolWithOptionsAsync(DeleteDnsGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDnsGtmAddressPoolResponse>(await DoRPCRequestAsync("DeleteDnsGtmAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDnsGtmAddressPoolResponse DeleteDnsGtmAddressPool(DeleteDnsGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDnsGtmAddressPoolWithOptions(request, runtime);
        }

        public async Task<DeleteDnsGtmAddressPoolResponse> DeleteDnsGtmAddressPoolAsync(DeleteDnsGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDnsGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        public DeleteDomainResponse DeleteDomainWithOptions(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainResponse>(DoRPCRequest("DeleteDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await DoRPCRequestAsync("DeleteDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainWithOptions(request, runtime);
        }

        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainWithOptionsAsync(request, runtime);
        }

        public DeleteDomainGroupResponse DeleteDomainGroupWithOptions(DeleteDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainGroupResponse>(DoRPCRequest("DeleteDomainGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDomainGroupResponse> DeleteDomainGroupWithOptionsAsync(DeleteDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainGroupResponse>(await DoRPCRequestAsync("DeleteDomainGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDomainGroupResponse DeleteDomainGroup(DeleteDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainGroupWithOptions(request, runtime);
        }

        public async Task<DeleteDomainGroupResponse> DeleteDomainGroupAsync(DeleteDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainGroupWithOptionsAsync(request, runtime);
        }

        public DeleteDomainRecordResponse DeleteDomainRecordWithOptions(DeleteDomainRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainRecordResponse>(DoRPCRequest("DeleteDomainRecord", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDomainRecordResponse> DeleteDomainRecordWithOptionsAsync(DeleteDomainRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainRecordResponse>(await DoRPCRequestAsync("DeleteDomainRecord", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDomainRecordResponse DeleteDomainRecord(DeleteDomainRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainRecordWithOptions(request, runtime);
        }

        public async Task<DeleteDomainRecordResponse> DeleteDomainRecordAsync(DeleteDomainRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainRecordWithOptionsAsync(request, runtime);
        }

        public DeleteGtmAccessStrategyResponse DeleteGtmAccessStrategyWithOptions(DeleteGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGtmAccessStrategyResponse>(DoRPCRequest("DeleteGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteGtmAccessStrategyResponse> DeleteGtmAccessStrategyWithOptionsAsync(DeleteGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGtmAccessStrategyResponse>(await DoRPCRequestAsync("DeleteGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteGtmAccessStrategyResponse DeleteGtmAccessStrategy(DeleteGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGtmAccessStrategyWithOptions(request, runtime);
        }

        public async Task<DeleteGtmAccessStrategyResponse> DeleteGtmAccessStrategyAsync(DeleteGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        public DeleteGtmAddressPoolResponse DeleteGtmAddressPoolWithOptions(DeleteGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGtmAddressPoolResponse>(DoRPCRequest("DeleteGtmAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteGtmAddressPoolResponse> DeleteGtmAddressPoolWithOptionsAsync(DeleteGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGtmAddressPoolResponse>(await DoRPCRequestAsync("DeleteGtmAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteGtmAddressPoolResponse DeleteGtmAddressPool(DeleteGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGtmAddressPoolWithOptions(request, runtime);
        }

        public async Task<DeleteGtmAddressPoolResponse> DeleteGtmAddressPoolAsync(DeleteGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        public DeleteGtmRecoveryPlanResponse DeleteGtmRecoveryPlanWithOptions(DeleteGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGtmRecoveryPlanResponse>(DoRPCRequest("DeleteGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteGtmRecoveryPlanResponse> DeleteGtmRecoveryPlanWithOptionsAsync(DeleteGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGtmRecoveryPlanResponse>(await DoRPCRequestAsync("DeleteGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteGtmRecoveryPlanResponse DeleteGtmRecoveryPlan(DeleteGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGtmRecoveryPlanWithOptions(request, runtime);
        }

        public async Task<DeleteGtmRecoveryPlanResponse> DeleteGtmRecoveryPlanAsync(DeleteGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        public DeleteSubDomainRecordsResponse DeleteSubDomainRecordsWithOptions(DeleteSubDomainRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSubDomainRecordsResponse>(DoRPCRequest("DeleteSubDomainRecords", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSubDomainRecordsResponse> DeleteSubDomainRecordsWithOptionsAsync(DeleteSubDomainRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSubDomainRecordsResponse>(await DoRPCRequestAsync("DeleteSubDomainRecords", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSubDomainRecordsResponse DeleteSubDomainRecords(DeleteSubDomainRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSubDomainRecordsWithOptions(request, runtime);
        }

        public async Task<DeleteSubDomainRecordsResponse> DeleteSubDomainRecordsAsync(DeleteSubDomainRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSubDomainRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeBatchResultCountResponse DescribeBatchResultCountWithOptions(DescribeBatchResultCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBatchResultCountResponse>(DoRPCRequest("DescribeBatchResultCount", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBatchResultCountResponse> DescribeBatchResultCountWithOptionsAsync(DescribeBatchResultCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBatchResultCountResponse>(await DoRPCRequestAsync("DescribeBatchResultCount", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBatchResultCountResponse DescribeBatchResultCount(DescribeBatchResultCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBatchResultCountWithOptions(request, runtime);
        }

        public async Task<DescribeBatchResultCountResponse> DescribeBatchResultCountAsync(DescribeBatchResultCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBatchResultCountWithOptionsAsync(request, runtime);
        }

        public DescribeBatchResultDetailResponse DescribeBatchResultDetailWithOptions(DescribeBatchResultDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBatchResultDetailResponse>(DoRPCRequest("DescribeBatchResultDetail", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBatchResultDetailResponse> DescribeBatchResultDetailWithOptionsAsync(DescribeBatchResultDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBatchResultDetailResponse>(await DoRPCRequestAsync("DescribeBatchResultDetail", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBatchResultDetailResponse DescribeBatchResultDetail(DescribeBatchResultDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBatchResultDetailWithOptions(request, runtime);
        }

        public async Task<DescribeBatchResultDetailResponse> DescribeBatchResultDetailAsync(DescribeBatchResultDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBatchResultDetailWithOptionsAsync(request, runtime);
        }

        public DescribeCustomLineResponse DescribeCustomLineWithOptions(DescribeCustomLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomLineResponse>(DoRPCRequest("DescribeCustomLine", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCustomLineResponse> DescribeCustomLineWithOptionsAsync(DescribeCustomLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomLineResponse>(await DoRPCRequestAsync("DescribeCustomLine", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCustomLineResponse DescribeCustomLine(DescribeCustomLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomLineWithOptions(request, runtime);
        }

        public async Task<DescribeCustomLineResponse> DescribeCustomLineAsync(DescribeCustomLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomLineWithOptionsAsync(request, runtime);
        }

        public DescribeCustomLinesResponse DescribeCustomLinesWithOptions(DescribeCustomLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomLinesResponse>(DoRPCRequest("DescribeCustomLines", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCustomLinesResponse> DescribeCustomLinesWithOptionsAsync(DescribeCustomLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomLinesResponse>(await DoRPCRequestAsync("DescribeCustomLines", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCustomLinesResponse DescribeCustomLines(DescribeCustomLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomLinesWithOptions(request, runtime);
        }

        public async Task<DescribeCustomLinesResponse> DescribeCustomLinesAsync(DescribeCustomLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomLinesWithOptionsAsync(request, runtime);
        }

        public DescribeDnsCacheDomainsResponse DescribeDnsCacheDomainsWithOptions(DescribeDnsCacheDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsCacheDomainsResponse>(DoRPCRequest("DescribeDnsCacheDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsCacheDomainsResponse> DescribeDnsCacheDomainsWithOptionsAsync(DescribeDnsCacheDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsCacheDomainsResponse>(await DoRPCRequestAsync("DescribeDnsCacheDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsCacheDomainsResponse DescribeDnsCacheDomains(DescribeDnsCacheDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsCacheDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeDnsCacheDomainsResponse> DescribeDnsCacheDomainsAsync(DescribeDnsCacheDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsCacheDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmAccessStrategiesResponse DescribeDnsGtmAccessStrategiesWithOptions(DescribeDnsGtmAccessStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmAccessStrategiesResponse>(DoRPCRequest("DescribeDnsGtmAccessStrategies", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmAccessStrategiesResponse> DescribeDnsGtmAccessStrategiesWithOptionsAsync(DescribeDnsGtmAccessStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmAccessStrategiesResponse>(await DoRPCRequestAsync("DescribeDnsGtmAccessStrategies", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmAccessStrategiesResponse DescribeDnsGtmAccessStrategies(DescribeDnsGtmAccessStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmAccessStrategiesWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmAccessStrategiesResponse> DescribeDnsGtmAccessStrategiesAsync(DescribeDnsGtmAccessStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmAccessStrategiesWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmAccessStrategyResponse DescribeDnsGtmAccessStrategyWithOptions(DescribeDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmAccessStrategyResponse>(DoRPCRequest("DescribeDnsGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmAccessStrategyResponse> DescribeDnsGtmAccessStrategyWithOptionsAsync(DescribeDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmAccessStrategyResponse>(await DoRPCRequestAsync("DescribeDnsGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmAccessStrategyResponse DescribeDnsGtmAccessStrategy(DescribeDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmAccessStrategyWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmAccessStrategyResponse> DescribeDnsGtmAccessStrategyAsync(DescribeDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmAccessStrategyAvailableConfigResponse DescribeDnsGtmAccessStrategyAvailableConfigWithOptions(DescribeDnsGtmAccessStrategyAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmAccessStrategyAvailableConfigResponse>(DoRPCRequest("DescribeDnsGtmAccessStrategyAvailableConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmAccessStrategyAvailableConfigResponse> DescribeDnsGtmAccessStrategyAvailableConfigWithOptionsAsync(DescribeDnsGtmAccessStrategyAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmAccessStrategyAvailableConfigResponse>(await DoRPCRequestAsync("DescribeDnsGtmAccessStrategyAvailableConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmAccessStrategyAvailableConfigResponse DescribeDnsGtmAccessStrategyAvailableConfig(DescribeDnsGtmAccessStrategyAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmAccessStrategyAvailableConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmAccessStrategyAvailableConfigResponse> DescribeDnsGtmAccessStrategyAvailableConfigAsync(DescribeDnsGtmAccessStrategyAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmAccessStrategyAvailableConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmAddrAttributeInfoResponse DescribeDnsGtmAddrAttributeInfoWithOptions(DescribeDnsGtmAddrAttributeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmAddrAttributeInfoResponse>(DoRPCRequest("DescribeDnsGtmAddrAttributeInfo", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmAddrAttributeInfoResponse> DescribeDnsGtmAddrAttributeInfoWithOptionsAsync(DescribeDnsGtmAddrAttributeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmAddrAttributeInfoResponse>(await DoRPCRequestAsync("DescribeDnsGtmAddrAttributeInfo", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmAddrAttributeInfoResponse DescribeDnsGtmAddrAttributeInfo(DescribeDnsGtmAddrAttributeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmAddrAttributeInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmAddrAttributeInfoResponse> DescribeDnsGtmAddrAttributeInfoAsync(DescribeDnsGtmAddrAttributeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmAddrAttributeInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmAddressPoolAvailableConfigResponse DescribeDnsGtmAddressPoolAvailableConfigWithOptions(DescribeDnsGtmAddressPoolAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmAddressPoolAvailableConfigResponse>(DoRPCRequest("DescribeDnsGtmAddressPoolAvailableConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmAddressPoolAvailableConfigResponse> DescribeDnsGtmAddressPoolAvailableConfigWithOptionsAsync(DescribeDnsGtmAddressPoolAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmAddressPoolAvailableConfigResponse>(await DoRPCRequestAsync("DescribeDnsGtmAddressPoolAvailableConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmAddressPoolAvailableConfigResponse DescribeDnsGtmAddressPoolAvailableConfig(DescribeDnsGtmAddressPoolAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmAddressPoolAvailableConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmAddressPoolAvailableConfigResponse> DescribeDnsGtmAddressPoolAvailableConfigAsync(DescribeDnsGtmAddressPoolAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmAddressPoolAvailableConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmAvailableAlertGroupResponse DescribeDnsGtmAvailableAlertGroupWithOptions(DescribeDnsGtmAvailableAlertGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmAvailableAlertGroupResponse>(DoRPCRequest("DescribeDnsGtmAvailableAlertGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmAvailableAlertGroupResponse> DescribeDnsGtmAvailableAlertGroupWithOptionsAsync(DescribeDnsGtmAvailableAlertGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmAvailableAlertGroupResponse>(await DoRPCRequestAsync("DescribeDnsGtmAvailableAlertGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmAvailableAlertGroupResponse DescribeDnsGtmAvailableAlertGroup(DescribeDnsGtmAvailableAlertGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmAvailableAlertGroupWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmAvailableAlertGroupResponse> DescribeDnsGtmAvailableAlertGroupAsync(DescribeDnsGtmAvailableAlertGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmAvailableAlertGroupWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmInstanceResponse DescribeDnsGtmInstanceWithOptions(DescribeDnsGtmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceResponse>(DoRPCRequest("DescribeDnsGtmInstance", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmInstanceResponse> DescribeDnsGtmInstanceWithOptionsAsync(DescribeDnsGtmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceResponse>(await DoRPCRequestAsync("DescribeDnsGtmInstance", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmInstanceResponse DescribeDnsGtmInstance(DescribeDnsGtmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmInstanceResponse> DescribeDnsGtmInstanceAsync(DescribeDnsGtmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmInstanceAddressPoolResponse DescribeDnsGtmInstanceAddressPoolWithOptions(DescribeDnsGtmInstanceAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceAddressPoolResponse>(DoRPCRequest("DescribeDnsGtmInstanceAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmInstanceAddressPoolResponse> DescribeDnsGtmInstanceAddressPoolWithOptionsAsync(DescribeDnsGtmInstanceAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceAddressPoolResponse>(await DoRPCRequestAsync("DescribeDnsGtmInstanceAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmInstanceAddressPoolResponse DescribeDnsGtmInstanceAddressPool(DescribeDnsGtmInstanceAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmInstanceAddressPoolWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmInstanceAddressPoolResponse> DescribeDnsGtmInstanceAddressPoolAsync(DescribeDnsGtmInstanceAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmInstanceAddressPoolWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmInstanceAddressPoolsResponse DescribeDnsGtmInstanceAddressPoolsWithOptions(DescribeDnsGtmInstanceAddressPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceAddressPoolsResponse>(DoRPCRequest("DescribeDnsGtmInstanceAddressPools", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmInstanceAddressPoolsResponse> DescribeDnsGtmInstanceAddressPoolsWithOptionsAsync(DescribeDnsGtmInstanceAddressPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceAddressPoolsResponse>(await DoRPCRequestAsync("DescribeDnsGtmInstanceAddressPools", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmInstanceAddressPoolsResponse DescribeDnsGtmInstanceAddressPools(DescribeDnsGtmInstanceAddressPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmInstanceAddressPoolsWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmInstanceAddressPoolsResponse> DescribeDnsGtmInstanceAddressPoolsAsync(DescribeDnsGtmInstanceAddressPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmInstanceAddressPoolsWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmInstancesResponse DescribeDnsGtmInstancesWithOptions(DescribeDnsGtmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmInstancesResponse>(DoRPCRequest("DescribeDnsGtmInstances", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmInstancesResponse> DescribeDnsGtmInstancesWithOptionsAsync(DescribeDnsGtmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmInstancesResponse>(await DoRPCRequestAsync("DescribeDnsGtmInstances", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmInstancesResponse DescribeDnsGtmInstances(DescribeDnsGtmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmInstancesResponse> DescribeDnsGtmInstancesAsync(DescribeDnsGtmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmInstanceStatusResponse DescribeDnsGtmInstanceStatusWithOptions(DescribeDnsGtmInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceStatusResponse>(DoRPCRequest("DescribeDnsGtmInstanceStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmInstanceStatusResponse> DescribeDnsGtmInstanceStatusWithOptionsAsync(DescribeDnsGtmInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceStatusResponse>(await DoRPCRequestAsync("DescribeDnsGtmInstanceStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmInstanceStatusResponse DescribeDnsGtmInstanceStatus(DescribeDnsGtmInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmInstanceStatusWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmInstanceStatusResponse> DescribeDnsGtmInstanceStatusAsync(DescribeDnsGtmInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmInstanceStatusWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmInstanceSystemCnameResponse DescribeDnsGtmInstanceSystemCnameWithOptions(DescribeDnsGtmInstanceSystemCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceSystemCnameResponse>(DoRPCRequest("DescribeDnsGtmInstanceSystemCname", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmInstanceSystemCnameResponse> DescribeDnsGtmInstanceSystemCnameWithOptionsAsync(DescribeDnsGtmInstanceSystemCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmInstanceSystemCnameResponse>(await DoRPCRequestAsync("DescribeDnsGtmInstanceSystemCname", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmInstanceSystemCnameResponse DescribeDnsGtmInstanceSystemCname(DescribeDnsGtmInstanceSystemCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmInstanceSystemCnameWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmInstanceSystemCnameResponse> DescribeDnsGtmInstanceSystemCnameAsync(DescribeDnsGtmInstanceSystemCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmInstanceSystemCnameWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmLogsResponse DescribeDnsGtmLogsWithOptions(DescribeDnsGtmLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmLogsResponse>(DoRPCRequest("DescribeDnsGtmLogs", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmLogsResponse> DescribeDnsGtmLogsWithOptionsAsync(DescribeDnsGtmLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmLogsResponse>(await DoRPCRequestAsync("DescribeDnsGtmLogs", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmLogsResponse DescribeDnsGtmLogs(DescribeDnsGtmLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmLogsWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmLogsResponse> DescribeDnsGtmLogsAsync(DescribeDnsGtmLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmLogsWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmMonitorAvailableConfigResponse DescribeDnsGtmMonitorAvailableConfigWithOptions(DescribeDnsGtmMonitorAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmMonitorAvailableConfigResponse>(DoRPCRequest("DescribeDnsGtmMonitorAvailableConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmMonitorAvailableConfigResponse> DescribeDnsGtmMonitorAvailableConfigWithOptionsAsync(DescribeDnsGtmMonitorAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmMonitorAvailableConfigResponse>(await DoRPCRequestAsync("DescribeDnsGtmMonitorAvailableConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmMonitorAvailableConfigResponse DescribeDnsGtmMonitorAvailableConfig(DescribeDnsGtmMonitorAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmMonitorAvailableConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmMonitorAvailableConfigResponse> DescribeDnsGtmMonitorAvailableConfigAsync(DescribeDnsGtmMonitorAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmMonitorAvailableConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDnsGtmMonitorConfigResponse DescribeDnsGtmMonitorConfigWithOptions(DescribeDnsGtmMonitorConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmMonitorConfigResponse>(DoRPCRequest("DescribeDnsGtmMonitorConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsGtmMonitorConfigResponse> DescribeDnsGtmMonitorConfigWithOptionsAsync(DescribeDnsGtmMonitorConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsGtmMonitorConfigResponse>(await DoRPCRequestAsync("DescribeDnsGtmMonitorConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsGtmMonitorConfigResponse DescribeDnsGtmMonitorConfig(DescribeDnsGtmMonitorConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsGtmMonitorConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDnsGtmMonitorConfigResponse> DescribeDnsGtmMonitorConfigAsync(DescribeDnsGtmMonitorConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsGtmMonitorConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDnsProductInstanceResponse DescribeDnsProductInstanceWithOptions(DescribeDnsProductInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsProductInstanceResponse>(DoRPCRequest("DescribeDnsProductInstance", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsProductInstanceResponse> DescribeDnsProductInstanceWithOptionsAsync(DescribeDnsProductInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsProductInstanceResponse>(await DoRPCRequestAsync("DescribeDnsProductInstance", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsProductInstanceResponse DescribeDnsProductInstance(DescribeDnsProductInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsProductInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeDnsProductInstanceResponse> DescribeDnsProductInstanceAsync(DescribeDnsProductInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsProductInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeDnsProductInstancesResponse DescribeDnsProductInstancesWithOptions(DescribeDnsProductInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsProductInstancesResponse>(DoRPCRequest("DescribeDnsProductInstances", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnsProductInstancesResponse> DescribeDnsProductInstancesWithOptionsAsync(DescribeDnsProductInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnsProductInstancesResponse>(await DoRPCRequestAsync("DescribeDnsProductInstances", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnsProductInstancesResponse DescribeDnsProductInstances(DescribeDnsProductInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnsProductInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeDnsProductInstancesResponse> DescribeDnsProductInstancesAsync(DescribeDnsProductInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnsProductInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeDNSSLBSubDomainsResponse DescribeDNSSLBSubDomainsWithOptions(DescribeDNSSLBSubDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDNSSLBSubDomainsResponse>(DoRPCRequest("DescribeDNSSLBSubDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDNSSLBSubDomainsResponse> DescribeDNSSLBSubDomainsWithOptionsAsync(DescribeDNSSLBSubDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDNSSLBSubDomainsResponse>(await DoRPCRequestAsync("DescribeDNSSLBSubDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDNSSLBSubDomainsResponse DescribeDNSSLBSubDomains(DescribeDNSSLBSubDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDNSSLBSubDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeDNSSLBSubDomainsResponse> DescribeDNSSLBSubDomainsAsync(DescribeDNSSLBSubDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDNSSLBSubDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeDohAccountStatisticsResponse DescribeDohAccountStatisticsWithOptions(DescribeDohAccountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDohAccountStatisticsResponse>(DoRPCRequest("DescribeDohAccountStatistics", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDohAccountStatisticsResponse> DescribeDohAccountStatisticsWithOptionsAsync(DescribeDohAccountStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDohAccountStatisticsResponse>(await DoRPCRequestAsync("DescribeDohAccountStatistics", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDohAccountStatisticsResponse DescribeDohAccountStatistics(DescribeDohAccountStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDohAccountStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeDohAccountStatisticsResponse> DescribeDohAccountStatisticsAsync(DescribeDohAccountStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDohAccountStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeDohDomainStatisticsResponse DescribeDohDomainStatisticsWithOptions(DescribeDohDomainStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDohDomainStatisticsResponse>(DoRPCRequest("DescribeDohDomainStatistics", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDohDomainStatisticsResponse> DescribeDohDomainStatisticsWithOptionsAsync(DescribeDohDomainStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDohDomainStatisticsResponse>(await DoRPCRequestAsync("DescribeDohDomainStatistics", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDohDomainStatisticsResponse DescribeDohDomainStatistics(DescribeDohDomainStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDohDomainStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeDohDomainStatisticsResponse> DescribeDohDomainStatisticsAsync(DescribeDohDomainStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDohDomainStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeDohDomainStatisticsSummaryResponse DescribeDohDomainStatisticsSummaryWithOptions(DescribeDohDomainStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDohDomainStatisticsSummaryResponse>(DoRPCRequest("DescribeDohDomainStatisticsSummary", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDohDomainStatisticsSummaryResponse> DescribeDohDomainStatisticsSummaryWithOptionsAsync(DescribeDohDomainStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDohDomainStatisticsSummaryResponse>(await DoRPCRequestAsync("DescribeDohDomainStatisticsSummary", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDohDomainStatisticsSummaryResponse DescribeDohDomainStatisticsSummary(DescribeDohDomainStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDohDomainStatisticsSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeDohDomainStatisticsSummaryResponse> DescribeDohDomainStatisticsSummaryAsync(DescribeDohDomainStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDohDomainStatisticsSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeDohSubDomainStatisticsResponse DescribeDohSubDomainStatisticsWithOptions(DescribeDohSubDomainStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDohSubDomainStatisticsResponse>(DoRPCRequest("DescribeDohSubDomainStatistics", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDohSubDomainStatisticsResponse> DescribeDohSubDomainStatisticsWithOptionsAsync(DescribeDohSubDomainStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDohSubDomainStatisticsResponse>(await DoRPCRequestAsync("DescribeDohSubDomainStatistics", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDohSubDomainStatisticsResponse DescribeDohSubDomainStatistics(DescribeDohSubDomainStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDohSubDomainStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeDohSubDomainStatisticsResponse> DescribeDohSubDomainStatisticsAsync(DescribeDohSubDomainStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDohSubDomainStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeDohSubDomainStatisticsSummaryResponse DescribeDohSubDomainStatisticsSummaryWithOptions(DescribeDohSubDomainStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDohSubDomainStatisticsSummaryResponse>(DoRPCRequest("DescribeDohSubDomainStatisticsSummary", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDohSubDomainStatisticsSummaryResponse> DescribeDohSubDomainStatisticsSummaryWithOptionsAsync(DescribeDohSubDomainStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDohSubDomainStatisticsSummaryResponse>(await DoRPCRequestAsync("DescribeDohSubDomainStatisticsSummary", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDohSubDomainStatisticsSummaryResponse DescribeDohSubDomainStatisticsSummary(DescribeDohSubDomainStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDohSubDomainStatisticsSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeDohSubDomainStatisticsSummaryResponse> DescribeDohSubDomainStatisticsSummaryAsync(DescribeDohSubDomainStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDohSubDomainStatisticsSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeDohUserInfoResponse DescribeDohUserInfoWithOptions(DescribeDohUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDohUserInfoResponse>(DoRPCRequest("DescribeDohUserInfo", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDohUserInfoResponse> DescribeDohUserInfoWithOptionsAsync(DescribeDohUserInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDohUserInfoResponse>(await DoRPCRequestAsync("DescribeDohUserInfo", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDohUserInfoResponse DescribeDohUserInfo(DescribeDohUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDohUserInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDohUserInfoResponse> DescribeDohUserInfoAsync(DescribeDohUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDohUserInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDomainDnssecInfoResponse DescribeDomainDnssecInfoWithOptions(DescribeDomainDnssecInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainDnssecInfoResponse>(DoRPCRequest("DescribeDomainDnssecInfo", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainDnssecInfoResponse> DescribeDomainDnssecInfoWithOptionsAsync(DescribeDomainDnssecInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainDnssecInfoResponse>(await DoRPCRequestAsync("DescribeDomainDnssecInfo", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainDnssecInfoResponse DescribeDomainDnssecInfo(DescribeDomainDnssecInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainDnssecInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDomainDnssecInfoResponse> DescribeDomainDnssecInfoAsync(DescribeDomainDnssecInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainDnssecInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDomainGroupsResponse DescribeDomainGroupsWithOptions(DescribeDomainGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainGroupsResponse>(DoRPCRequest("DescribeDomainGroups", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainGroupsResponse> DescribeDomainGroupsWithOptionsAsync(DescribeDomainGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainGroupsResponse>(await DoRPCRequestAsync("DescribeDomainGroups", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainGroupsResponse DescribeDomainGroups(DescribeDomainGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainGroupsResponse> DescribeDomainGroupsAsync(DescribeDomainGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeDomainInfoResponse DescribeDomainInfoWithOptions(DescribeDomainInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainInfoResponse>(DoRPCRequest("DescribeDomainInfo", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainInfoResponse> DescribeDomainInfoWithOptionsAsync(DescribeDomainInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainInfoResponse>(await DoRPCRequestAsync("DescribeDomainInfo", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainInfoResponse DescribeDomainInfo(DescribeDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDomainInfoResponse> DescribeDomainInfoAsync(DescribeDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDomainLogsResponse DescribeDomainLogsWithOptions(DescribeDomainLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainLogsResponse>(DoRPCRequest("DescribeDomainLogs", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainLogsResponse> DescribeDomainLogsWithOptionsAsync(DescribeDomainLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainLogsResponse>(await DoRPCRequestAsync("DescribeDomainLogs", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainLogsResponse DescribeDomainLogs(DescribeDomainLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainLogsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainLogsResponse> DescribeDomainLogsAsync(DescribeDomainLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainLogsWithOptionsAsync(request, runtime);
        }

        public DescribeDomainNsResponse DescribeDomainNsWithOptions(DescribeDomainNsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainNsResponse>(DoRPCRequest("DescribeDomainNs", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainNsResponse> DescribeDomainNsWithOptionsAsync(DescribeDomainNsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainNsResponse>(await DoRPCRequestAsync("DescribeDomainNs", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainNsResponse DescribeDomainNs(DescribeDomainNsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainNsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainNsResponse> DescribeDomainNsAsync(DescribeDomainNsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainNsWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRecordInfoResponse DescribeDomainRecordInfoWithOptions(DescribeDomainRecordInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRecordInfoResponse>(DoRPCRequest("DescribeDomainRecordInfo", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRecordInfoResponse> DescribeDomainRecordInfoWithOptionsAsync(DescribeDomainRecordInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRecordInfoResponse>(await DoRPCRequestAsync("DescribeDomainRecordInfo", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainRecordInfoResponse DescribeDomainRecordInfo(DescribeDomainRecordInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRecordInfoWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRecordInfoResponse> DescribeDomainRecordInfoAsync(DescribeDomainRecordInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRecordInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDomainRecordsResponse DescribeDomainRecordsWithOptions(DescribeDomainRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRecordsResponse>(DoRPCRequest("DescribeDomainRecords", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainRecordsResponse> DescribeDomainRecordsWithOptionsAsync(DescribeDomainRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainRecordsResponse>(await DoRPCRequestAsync("DescribeDomainRecords", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainRecordsResponse DescribeDomainRecords(DescribeDomainRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainRecordsResponse> DescribeDomainRecordsAsync(DescribeDomainRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeDomainsResponse DescribeDomainsWithOptions(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsResponse>(DoRPCRequest("DescribeDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainsResponse> DescribeDomainsWithOptionsAsync(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsResponse>(await DoRPCRequestAsync("DescribeDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeDomainStatisticsResponse DescribeDomainStatisticsWithOptions(DescribeDomainStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainStatisticsResponse>(DoRPCRequest("DescribeDomainStatistics", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainStatisticsResponse> DescribeDomainStatisticsWithOptionsAsync(DescribeDomainStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainStatisticsResponse>(await DoRPCRequestAsync("DescribeDomainStatistics", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainStatisticsResponse DescribeDomainStatistics(DescribeDomainStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainStatisticsResponse> DescribeDomainStatisticsAsync(DescribeDomainStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeDomainStatisticsSummaryResponse DescribeDomainStatisticsSummaryWithOptions(DescribeDomainStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainStatisticsSummaryResponse>(DoRPCRequest("DescribeDomainStatisticsSummary", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainStatisticsSummaryResponse> DescribeDomainStatisticsSummaryWithOptionsAsync(DescribeDomainStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainStatisticsSummaryResponse>(await DoRPCRequestAsync("DescribeDomainStatisticsSummary", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainStatisticsSummaryResponse DescribeDomainStatisticsSummary(DescribeDomainStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainStatisticsSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeDomainStatisticsSummaryResponse> DescribeDomainStatisticsSummaryAsync(DescribeDomainStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainStatisticsSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeGtmAccessStrategiesResponse DescribeGtmAccessStrategiesWithOptions(DescribeGtmAccessStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmAccessStrategiesResponse>(DoRPCRequest("DescribeGtmAccessStrategies", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmAccessStrategiesResponse> DescribeGtmAccessStrategiesWithOptionsAsync(DescribeGtmAccessStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmAccessStrategiesResponse>(await DoRPCRequestAsync("DescribeGtmAccessStrategies", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmAccessStrategiesResponse DescribeGtmAccessStrategies(DescribeGtmAccessStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmAccessStrategiesWithOptions(request, runtime);
        }

        public async Task<DescribeGtmAccessStrategiesResponse> DescribeGtmAccessStrategiesAsync(DescribeGtmAccessStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmAccessStrategiesWithOptionsAsync(request, runtime);
        }

        public DescribeGtmAccessStrategyResponse DescribeGtmAccessStrategyWithOptions(DescribeGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmAccessStrategyResponse>(DoRPCRequest("DescribeGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmAccessStrategyResponse> DescribeGtmAccessStrategyWithOptionsAsync(DescribeGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmAccessStrategyResponse>(await DoRPCRequestAsync("DescribeGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmAccessStrategyResponse DescribeGtmAccessStrategy(DescribeGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmAccessStrategyWithOptions(request, runtime);
        }

        public async Task<DescribeGtmAccessStrategyResponse> DescribeGtmAccessStrategyAsync(DescribeGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        public DescribeGtmAccessStrategyAvailableConfigResponse DescribeGtmAccessStrategyAvailableConfigWithOptions(DescribeGtmAccessStrategyAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmAccessStrategyAvailableConfigResponse>(DoRPCRequest("DescribeGtmAccessStrategyAvailableConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmAccessStrategyAvailableConfigResponse> DescribeGtmAccessStrategyAvailableConfigWithOptionsAsync(DescribeGtmAccessStrategyAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmAccessStrategyAvailableConfigResponse>(await DoRPCRequestAsync("DescribeGtmAccessStrategyAvailableConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmAccessStrategyAvailableConfigResponse DescribeGtmAccessStrategyAvailableConfig(DescribeGtmAccessStrategyAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmAccessStrategyAvailableConfigWithOptions(request, runtime);
        }

        public async Task<DescribeGtmAccessStrategyAvailableConfigResponse> DescribeGtmAccessStrategyAvailableConfigAsync(DescribeGtmAccessStrategyAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmAccessStrategyAvailableConfigWithOptionsAsync(request, runtime);
        }

        public DescribeGtmAvailableAlertGroupResponse DescribeGtmAvailableAlertGroupWithOptions(DescribeGtmAvailableAlertGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmAvailableAlertGroupResponse>(DoRPCRequest("DescribeGtmAvailableAlertGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmAvailableAlertGroupResponse> DescribeGtmAvailableAlertGroupWithOptionsAsync(DescribeGtmAvailableAlertGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmAvailableAlertGroupResponse>(await DoRPCRequestAsync("DescribeGtmAvailableAlertGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmAvailableAlertGroupResponse DescribeGtmAvailableAlertGroup(DescribeGtmAvailableAlertGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmAvailableAlertGroupWithOptions(request, runtime);
        }

        public async Task<DescribeGtmAvailableAlertGroupResponse> DescribeGtmAvailableAlertGroupAsync(DescribeGtmAvailableAlertGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmAvailableAlertGroupWithOptionsAsync(request, runtime);
        }

        public DescribeGtmInstanceResponse DescribeGtmInstanceWithOptions(DescribeGtmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmInstanceResponse>(DoRPCRequest("DescribeGtmInstance", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmInstanceResponse> DescribeGtmInstanceWithOptionsAsync(DescribeGtmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmInstanceResponse>(await DoRPCRequestAsync("DescribeGtmInstance", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmInstanceResponse DescribeGtmInstance(DescribeGtmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeGtmInstanceResponse> DescribeGtmInstanceAsync(DescribeGtmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeGtmInstanceAddressPoolResponse DescribeGtmInstanceAddressPoolWithOptions(DescribeGtmInstanceAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmInstanceAddressPoolResponse>(DoRPCRequest("DescribeGtmInstanceAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmInstanceAddressPoolResponse> DescribeGtmInstanceAddressPoolWithOptionsAsync(DescribeGtmInstanceAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmInstanceAddressPoolResponse>(await DoRPCRequestAsync("DescribeGtmInstanceAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmInstanceAddressPoolResponse DescribeGtmInstanceAddressPool(DescribeGtmInstanceAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmInstanceAddressPoolWithOptions(request, runtime);
        }

        public async Task<DescribeGtmInstanceAddressPoolResponse> DescribeGtmInstanceAddressPoolAsync(DescribeGtmInstanceAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmInstanceAddressPoolWithOptionsAsync(request, runtime);
        }

        public DescribeGtmInstanceAddressPoolsResponse DescribeGtmInstanceAddressPoolsWithOptions(DescribeGtmInstanceAddressPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmInstanceAddressPoolsResponse>(DoRPCRequest("DescribeGtmInstanceAddressPools", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmInstanceAddressPoolsResponse> DescribeGtmInstanceAddressPoolsWithOptionsAsync(DescribeGtmInstanceAddressPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmInstanceAddressPoolsResponse>(await DoRPCRequestAsync("DescribeGtmInstanceAddressPools", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmInstanceAddressPoolsResponse DescribeGtmInstanceAddressPools(DescribeGtmInstanceAddressPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmInstanceAddressPoolsWithOptions(request, runtime);
        }

        public async Task<DescribeGtmInstanceAddressPoolsResponse> DescribeGtmInstanceAddressPoolsAsync(DescribeGtmInstanceAddressPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmInstanceAddressPoolsWithOptionsAsync(request, runtime);
        }

        public DescribeGtmInstancesResponse DescribeGtmInstancesWithOptions(DescribeGtmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmInstancesResponse>(DoRPCRequest("DescribeGtmInstances", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmInstancesResponse> DescribeGtmInstancesWithOptionsAsync(DescribeGtmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmInstancesResponse>(await DoRPCRequestAsync("DescribeGtmInstances", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmInstancesResponse DescribeGtmInstances(DescribeGtmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeGtmInstancesResponse> DescribeGtmInstancesAsync(DescribeGtmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeGtmInstanceStatusResponse DescribeGtmInstanceStatusWithOptions(DescribeGtmInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmInstanceStatusResponse>(DoRPCRequest("DescribeGtmInstanceStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmInstanceStatusResponse> DescribeGtmInstanceStatusWithOptionsAsync(DescribeGtmInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmInstanceStatusResponse>(await DoRPCRequestAsync("DescribeGtmInstanceStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmInstanceStatusResponse DescribeGtmInstanceStatus(DescribeGtmInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmInstanceStatusWithOptions(request, runtime);
        }

        public async Task<DescribeGtmInstanceStatusResponse> DescribeGtmInstanceStatusAsync(DescribeGtmInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmInstanceStatusWithOptionsAsync(request, runtime);
        }

        public DescribeGtmInstanceSystemCnameResponse DescribeGtmInstanceSystemCnameWithOptions(DescribeGtmInstanceSystemCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmInstanceSystemCnameResponse>(DoRPCRequest("DescribeGtmInstanceSystemCname", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmInstanceSystemCnameResponse> DescribeGtmInstanceSystemCnameWithOptionsAsync(DescribeGtmInstanceSystemCnameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmInstanceSystemCnameResponse>(await DoRPCRequestAsync("DescribeGtmInstanceSystemCname", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmInstanceSystemCnameResponse DescribeGtmInstanceSystemCname(DescribeGtmInstanceSystemCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmInstanceSystemCnameWithOptions(request, runtime);
        }

        public async Task<DescribeGtmInstanceSystemCnameResponse> DescribeGtmInstanceSystemCnameAsync(DescribeGtmInstanceSystemCnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmInstanceSystemCnameWithOptionsAsync(request, runtime);
        }

        public DescribeGtmLogsResponse DescribeGtmLogsWithOptions(DescribeGtmLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmLogsResponse>(DoRPCRequest("DescribeGtmLogs", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmLogsResponse> DescribeGtmLogsWithOptionsAsync(DescribeGtmLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmLogsResponse>(await DoRPCRequestAsync("DescribeGtmLogs", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmLogsResponse DescribeGtmLogs(DescribeGtmLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmLogsWithOptions(request, runtime);
        }

        public async Task<DescribeGtmLogsResponse> DescribeGtmLogsAsync(DescribeGtmLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmLogsWithOptionsAsync(request, runtime);
        }

        public DescribeGtmMonitorAvailableConfigResponse DescribeGtmMonitorAvailableConfigWithOptions(DescribeGtmMonitorAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmMonitorAvailableConfigResponse>(DoRPCRequest("DescribeGtmMonitorAvailableConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmMonitorAvailableConfigResponse> DescribeGtmMonitorAvailableConfigWithOptionsAsync(DescribeGtmMonitorAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmMonitorAvailableConfigResponse>(await DoRPCRequestAsync("DescribeGtmMonitorAvailableConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmMonitorAvailableConfigResponse DescribeGtmMonitorAvailableConfig(DescribeGtmMonitorAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmMonitorAvailableConfigWithOptions(request, runtime);
        }

        public async Task<DescribeGtmMonitorAvailableConfigResponse> DescribeGtmMonitorAvailableConfigAsync(DescribeGtmMonitorAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmMonitorAvailableConfigWithOptionsAsync(request, runtime);
        }

        public DescribeGtmMonitorConfigResponse DescribeGtmMonitorConfigWithOptions(DescribeGtmMonitorConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmMonitorConfigResponse>(DoRPCRequest("DescribeGtmMonitorConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmMonitorConfigResponse> DescribeGtmMonitorConfigWithOptionsAsync(DescribeGtmMonitorConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmMonitorConfigResponse>(await DoRPCRequestAsync("DescribeGtmMonitorConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmMonitorConfigResponse DescribeGtmMonitorConfig(DescribeGtmMonitorConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmMonitorConfigWithOptions(request, runtime);
        }

        public async Task<DescribeGtmMonitorConfigResponse> DescribeGtmMonitorConfigAsync(DescribeGtmMonitorConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmMonitorConfigWithOptionsAsync(request, runtime);
        }

        public DescribeGtmRecoveryPlanResponse DescribeGtmRecoveryPlanWithOptions(DescribeGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmRecoveryPlanResponse>(DoRPCRequest("DescribeGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmRecoveryPlanResponse> DescribeGtmRecoveryPlanWithOptionsAsync(DescribeGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmRecoveryPlanResponse>(await DoRPCRequestAsync("DescribeGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmRecoveryPlanResponse DescribeGtmRecoveryPlan(DescribeGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmRecoveryPlanWithOptions(request, runtime);
        }

        public async Task<DescribeGtmRecoveryPlanResponse> DescribeGtmRecoveryPlanAsync(DescribeGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        public DescribeGtmRecoveryPlanAvailableConfigResponse DescribeGtmRecoveryPlanAvailableConfigWithOptions(DescribeGtmRecoveryPlanAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmRecoveryPlanAvailableConfigResponse>(DoRPCRequest("DescribeGtmRecoveryPlanAvailableConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmRecoveryPlanAvailableConfigResponse> DescribeGtmRecoveryPlanAvailableConfigWithOptionsAsync(DescribeGtmRecoveryPlanAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmRecoveryPlanAvailableConfigResponse>(await DoRPCRequestAsync("DescribeGtmRecoveryPlanAvailableConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmRecoveryPlanAvailableConfigResponse DescribeGtmRecoveryPlanAvailableConfig(DescribeGtmRecoveryPlanAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmRecoveryPlanAvailableConfigWithOptions(request, runtime);
        }

        public async Task<DescribeGtmRecoveryPlanAvailableConfigResponse> DescribeGtmRecoveryPlanAvailableConfigAsync(DescribeGtmRecoveryPlanAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmRecoveryPlanAvailableConfigWithOptionsAsync(request, runtime);
        }

        public DescribeGtmRecoveryPlansResponse DescribeGtmRecoveryPlansWithOptions(DescribeGtmRecoveryPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmRecoveryPlansResponse>(DoRPCRequest("DescribeGtmRecoveryPlans", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGtmRecoveryPlansResponse> DescribeGtmRecoveryPlansWithOptionsAsync(DescribeGtmRecoveryPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGtmRecoveryPlansResponse>(await DoRPCRequestAsync("DescribeGtmRecoveryPlans", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGtmRecoveryPlansResponse DescribeGtmRecoveryPlans(DescribeGtmRecoveryPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGtmRecoveryPlansWithOptions(request, runtime);
        }

        public async Task<DescribeGtmRecoveryPlansResponse> DescribeGtmRecoveryPlansAsync(DescribeGtmRecoveryPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGtmRecoveryPlansWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceDomainsResponse DescribeInstanceDomainsWithOptions(DescribeInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceDomainsResponse>(DoRPCRequest("DescribeInstanceDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceDomainsResponse> DescribeInstanceDomainsWithOptionsAsync(DescribeInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceDomainsResponse>(await DoRPCRequestAsync("DescribeInstanceDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceDomainsResponse DescribeInstanceDomains(DescribeInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceDomainsResponse> DescribeInstanceDomainsAsync(DescribeInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeRecordLogsResponse DescribeRecordLogsWithOptions(DescribeRecordLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordLogsResponse>(DoRPCRequest("DescribeRecordLogs", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordLogsResponse> DescribeRecordLogsWithOptionsAsync(DescribeRecordLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordLogsResponse>(await DoRPCRequestAsync("DescribeRecordLogs", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordLogsResponse DescribeRecordLogs(DescribeRecordLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordLogsWithOptions(request, runtime);
        }

        public async Task<DescribeRecordLogsResponse> DescribeRecordLogsAsync(DescribeRecordLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordLogsWithOptionsAsync(request, runtime);
        }

        public DescribeRecordStatisticsResponse DescribeRecordStatisticsWithOptions(DescribeRecordStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordStatisticsResponse>(DoRPCRequest("DescribeRecordStatistics", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordStatisticsResponse> DescribeRecordStatisticsWithOptionsAsync(DescribeRecordStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordStatisticsResponse>(await DoRPCRequestAsync("DescribeRecordStatistics", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordStatisticsResponse DescribeRecordStatistics(DescribeRecordStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeRecordStatisticsResponse> DescribeRecordStatisticsAsync(DescribeRecordStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeRecordStatisticsSummaryResponse DescribeRecordStatisticsSummaryWithOptions(DescribeRecordStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordStatisticsSummaryResponse>(DoRPCRequest("DescribeRecordStatisticsSummary", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordStatisticsSummaryResponse> DescribeRecordStatisticsSummaryWithOptionsAsync(DescribeRecordStatisticsSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordStatisticsSummaryResponse>(await DoRPCRequestAsync("DescribeRecordStatisticsSummary", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordStatisticsSummaryResponse DescribeRecordStatisticsSummary(DescribeRecordStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordStatisticsSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeRecordStatisticsSummaryResponse> DescribeRecordStatisticsSummaryAsync(DescribeRecordStatisticsSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordStatisticsSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeSubDomainRecordsResponse DescribeSubDomainRecordsWithOptions(DescribeSubDomainRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubDomainRecordsResponse>(DoRPCRequest("DescribeSubDomainRecords", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSubDomainRecordsResponse> DescribeSubDomainRecordsWithOptionsAsync(DescribeSubDomainRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubDomainRecordsResponse>(await DoRPCRequestAsync("DescribeSubDomainRecords", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSubDomainRecordsResponse DescribeSubDomainRecords(DescribeSubDomainRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubDomainRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeSubDomainRecordsResponse> DescribeSubDomainRecordsAsync(DescribeSubDomainRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubDomainRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeSupportLinesResponse DescribeSupportLinesWithOptions(DescribeSupportLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSupportLinesResponse>(DoRPCRequest("DescribeSupportLines", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSupportLinesResponse> DescribeSupportLinesWithOptionsAsync(DescribeSupportLinesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSupportLinesResponse>(await DoRPCRequestAsync("DescribeSupportLines", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSupportLinesResponse DescribeSupportLines(DescribeSupportLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSupportLinesWithOptions(request, runtime);
        }

        public async Task<DescribeSupportLinesResponse> DescribeSupportLinesAsync(DescribeSupportLinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSupportLinesWithOptionsAsync(request, runtime);
        }

        public DescribeTagsResponse DescribeTagsWithOptions(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagsResponse>(DoRPCRequest("DescribeTags", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTagsResponse> DescribeTagsWithOptionsAsync(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagsResponse>(await DoRPCRequestAsync("DescribeTags", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagsWithOptions(request, runtime);
        }

        public async Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagsWithOptionsAsync(request, runtime);
        }

        public DescribeTransferDomainsResponse DescribeTransferDomainsWithOptions(DescribeTransferDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTransferDomainsResponse>(DoRPCRequest("DescribeTransferDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTransferDomainsResponse> DescribeTransferDomainsWithOptionsAsync(DescribeTransferDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTransferDomainsResponse>(await DoRPCRequestAsync("DescribeTransferDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTransferDomainsResponse DescribeTransferDomains(DescribeTransferDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTransferDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeTransferDomainsResponse> DescribeTransferDomainsAsync(DescribeTransferDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTransferDomainsWithOptionsAsync(request, runtime);
        }

        public ExecuteGtmRecoveryPlanResponse ExecuteGtmRecoveryPlanWithOptions(ExecuteGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteGtmRecoveryPlanResponse>(DoRPCRequest("ExecuteGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecuteGtmRecoveryPlanResponse> ExecuteGtmRecoveryPlanWithOptionsAsync(ExecuteGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteGtmRecoveryPlanResponse>(await DoRPCRequestAsync("ExecuteGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecuteGtmRecoveryPlanResponse ExecuteGtmRecoveryPlan(ExecuteGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteGtmRecoveryPlanWithOptions(request, runtime);
        }

        public async Task<ExecuteGtmRecoveryPlanResponse> ExecuteGtmRecoveryPlanAsync(ExecuteGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        public GetMainDomainNameResponse GetMainDomainNameWithOptions(GetMainDomainNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMainDomainNameResponse>(DoRPCRequest("GetMainDomainName", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMainDomainNameResponse> GetMainDomainNameWithOptionsAsync(GetMainDomainNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMainDomainNameResponse>(await DoRPCRequestAsync("GetMainDomainName", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMainDomainNameResponse GetMainDomainName(GetMainDomainNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMainDomainNameWithOptions(request, runtime);
        }

        public async Task<GetMainDomainNameResponse> GetMainDomainNameAsync(GetMainDomainNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMainDomainNameWithOptionsAsync(request, runtime);
        }

        public GetTxtRecordForVerifyResponse GetTxtRecordForVerifyWithOptions(GetTxtRecordForVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTxtRecordForVerifyResponse>(DoRPCRequest("GetTxtRecordForVerify", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTxtRecordForVerifyResponse> GetTxtRecordForVerifyWithOptionsAsync(GetTxtRecordForVerifyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTxtRecordForVerifyResponse>(await DoRPCRequestAsync("GetTxtRecordForVerify", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTxtRecordForVerifyResponse GetTxtRecordForVerify(GetTxtRecordForVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTxtRecordForVerifyWithOptions(request, runtime);
        }

        public async Task<GetTxtRecordForVerifyResponse> GetTxtRecordForVerifyAsync(GetTxtRecordForVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTxtRecordForVerifyWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyHichinaDomainDNSResponse ModifyHichinaDomainDNSWithOptions(ModifyHichinaDomainDNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHichinaDomainDNSResponse>(DoRPCRequest("ModifyHichinaDomainDNS", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHichinaDomainDNSResponse> ModifyHichinaDomainDNSWithOptionsAsync(ModifyHichinaDomainDNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHichinaDomainDNSResponse>(await DoRPCRequestAsync("ModifyHichinaDomainDNS", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHichinaDomainDNSResponse ModifyHichinaDomainDNS(ModifyHichinaDomainDNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHichinaDomainDNSWithOptions(request, runtime);
        }

        public async Task<ModifyHichinaDomainDNSResponse> ModifyHichinaDomainDNSAsync(ModifyHichinaDomainDNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHichinaDomainDNSWithOptionsAsync(request, runtime);
        }

        public MoveDomainResourceGroupResponse MoveDomainResourceGroupWithOptions(MoveDomainResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveDomainResourceGroupResponse>(DoRPCRequest("MoveDomainResourceGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MoveDomainResourceGroupResponse> MoveDomainResourceGroupWithOptionsAsync(MoveDomainResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveDomainResourceGroupResponse>(await DoRPCRequestAsync("MoveDomainResourceGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MoveDomainResourceGroupResponse MoveDomainResourceGroup(MoveDomainResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveDomainResourceGroupWithOptions(request, runtime);
        }

        public async Task<MoveDomainResourceGroupResponse> MoveDomainResourceGroupAsync(MoveDomainResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveDomainResourceGroupWithOptionsAsync(request, runtime);
        }

        public MoveGtmResourceGroupResponse MoveGtmResourceGroupWithOptions(MoveGtmResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveGtmResourceGroupResponse>(DoRPCRequest("MoveGtmResourceGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MoveGtmResourceGroupResponse> MoveGtmResourceGroupWithOptionsAsync(MoveGtmResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveGtmResourceGroupResponse>(await DoRPCRequestAsync("MoveGtmResourceGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MoveGtmResourceGroupResponse MoveGtmResourceGroup(MoveGtmResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveGtmResourceGroupWithOptions(request, runtime);
        }

        public async Task<MoveGtmResourceGroupResponse> MoveGtmResourceGroupAsync(MoveGtmResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveGtmResourceGroupWithOptionsAsync(request, runtime);
        }

        public OperateBatchDomainResponse OperateBatchDomainWithOptions(OperateBatchDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OperateBatchDomainResponse>(DoRPCRequest("OperateBatchDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OperateBatchDomainResponse> OperateBatchDomainWithOptionsAsync(OperateBatchDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OperateBatchDomainResponse>(await DoRPCRequestAsync("OperateBatchDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OperateBatchDomainResponse OperateBatchDomain(OperateBatchDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OperateBatchDomainWithOptions(request, runtime);
        }

        public async Task<OperateBatchDomainResponse> OperateBatchDomainAsync(OperateBatchDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OperateBatchDomainWithOptionsAsync(request, runtime);
        }

        public PreviewGtmRecoveryPlanResponse PreviewGtmRecoveryPlanWithOptions(PreviewGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreviewGtmRecoveryPlanResponse>(DoRPCRequest("PreviewGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PreviewGtmRecoveryPlanResponse> PreviewGtmRecoveryPlanWithOptionsAsync(PreviewGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PreviewGtmRecoveryPlanResponse>(await DoRPCRequestAsync("PreviewGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PreviewGtmRecoveryPlanResponse PreviewGtmRecoveryPlan(PreviewGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PreviewGtmRecoveryPlanWithOptions(request, runtime);
        }

        public async Task<PreviewGtmRecoveryPlanResponse> PreviewGtmRecoveryPlanAsync(PreviewGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PreviewGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        public RetrieveDomainResponse RetrieveDomainWithOptions(RetrieveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RetrieveDomainResponse>(DoRPCRequest("RetrieveDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RetrieveDomainResponse> RetrieveDomainWithOptionsAsync(RetrieveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RetrieveDomainResponse>(await DoRPCRequestAsync("RetrieveDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RetrieveDomainResponse RetrieveDomain(RetrieveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetrieveDomainWithOptions(request, runtime);
        }

        public async Task<RetrieveDomainResponse> RetrieveDomainAsync(RetrieveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetrieveDomainWithOptionsAsync(request, runtime);
        }

        public RollbackGtmRecoveryPlanResponse RollbackGtmRecoveryPlanWithOptions(RollbackGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackGtmRecoveryPlanResponse>(DoRPCRequest("RollbackGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RollbackGtmRecoveryPlanResponse> RollbackGtmRecoveryPlanWithOptionsAsync(RollbackGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RollbackGtmRecoveryPlanResponse>(await DoRPCRequestAsync("RollbackGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RollbackGtmRecoveryPlanResponse RollbackGtmRecoveryPlan(RollbackGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RollbackGtmRecoveryPlanWithOptions(request, runtime);
        }

        public async Task<RollbackGtmRecoveryPlanResponse> RollbackGtmRecoveryPlanAsync(RollbackGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RollbackGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        public SetDnsGtmAccessModeResponse SetDnsGtmAccessModeWithOptions(SetDnsGtmAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDnsGtmAccessModeResponse>(DoRPCRequest("SetDnsGtmAccessMode", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDnsGtmAccessModeResponse> SetDnsGtmAccessModeWithOptionsAsync(SetDnsGtmAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDnsGtmAccessModeResponse>(await DoRPCRequestAsync("SetDnsGtmAccessMode", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDnsGtmAccessModeResponse SetDnsGtmAccessMode(SetDnsGtmAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDnsGtmAccessModeWithOptions(request, runtime);
        }

        public async Task<SetDnsGtmAccessModeResponse> SetDnsGtmAccessModeAsync(SetDnsGtmAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDnsGtmAccessModeWithOptionsAsync(request, runtime);
        }

        public SetDnsGtmMonitorStatusResponse SetDnsGtmMonitorStatusWithOptions(SetDnsGtmMonitorStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDnsGtmMonitorStatusResponse>(DoRPCRequest("SetDnsGtmMonitorStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDnsGtmMonitorStatusResponse> SetDnsGtmMonitorStatusWithOptionsAsync(SetDnsGtmMonitorStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDnsGtmMonitorStatusResponse>(await DoRPCRequestAsync("SetDnsGtmMonitorStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDnsGtmMonitorStatusResponse SetDnsGtmMonitorStatus(SetDnsGtmMonitorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDnsGtmMonitorStatusWithOptions(request, runtime);
        }

        public async Task<SetDnsGtmMonitorStatusResponse> SetDnsGtmMonitorStatusAsync(SetDnsGtmMonitorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDnsGtmMonitorStatusWithOptionsAsync(request, runtime);
        }

        public SetDNSSLBStatusResponse SetDNSSLBStatusWithOptions(SetDNSSLBStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDNSSLBStatusResponse>(DoRPCRequest("SetDNSSLBStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDNSSLBStatusResponse> SetDNSSLBStatusWithOptionsAsync(SetDNSSLBStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDNSSLBStatusResponse>(await DoRPCRequestAsync("SetDNSSLBStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDNSSLBStatusResponse SetDNSSLBStatus(SetDNSSLBStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDNSSLBStatusWithOptions(request, runtime);
        }

        public async Task<SetDNSSLBStatusResponse> SetDNSSLBStatusAsync(SetDNSSLBStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDNSSLBStatusWithOptionsAsync(request, runtime);
        }

        public SetDomainDnssecStatusResponse SetDomainDnssecStatusWithOptions(SetDomainDnssecStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainDnssecStatusResponse>(DoRPCRequest("SetDomainDnssecStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDomainDnssecStatusResponse> SetDomainDnssecStatusWithOptionsAsync(SetDomainDnssecStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainDnssecStatusResponse>(await DoRPCRequestAsync("SetDomainDnssecStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDomainDnssecStatusResponse SetDomainDnssecStatus(SetDomainDnssecStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainDnssecStatusWithOptions(request, runtime);
        }

        public async Task<SetDomainDnssecStatusResponse> SetDomainDnssecStatusAsync(SetDomainDnssecStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainDnssecStatusWithOptionsAsync(request, runtime);
        }

        public SetDomainRecordStatusResponse SetDomainRecordStatusWithOptions(SetDomainRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainRecordStatusResponse>(DoRPCRequest("SetDomainRecordStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDomainRecordStatusResponse> SetDomainRecordStatusWithOptionsAsync(SetDomainRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainRecordStatusResponse>(await DoRPCRequestAsync("SetDomainRecordStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDomainRecordStatusResponse SetDomainRecordStatus(SetDomainRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainRecordStatusWithOptions(request, runtime);
        }

        public async Task<SetDomainRecordStatusResponse> SetDomainRecordStatusAsync(SetDomainRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainRecordStatusWithOptionsAsync(request, runtime);
        }

        public SetGtmAccessModeResponse SetGtmAccessModeWithOptions(SetGtmAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGtmAccessModeResponse>(DoRPCRequest("SetGtmAccessMode", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetGtmAccessModeResponse> SetGtmAccessModeWithOptionsAsync(SetGtmAccessModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGtmAccessModeResponse>(await DoRPCRequestAsync("SetGtmAccessMode", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetGtmAccessModeResponse SetGtmAccessMode(SetGtmAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGtmAccessModeWithOptions(request, runtime);
        }

        public async Task<SetGtmAccessModeResponse> SetGtmAccessModeAsync(SetGtmAccessModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGtmAccessModeWithOptionsAsync(request, runtime);
        }

        public SetGtmMonitorStatusResponse SetGtmMonitorStatusWithOptions(SetGtmMonitorStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGtmMonitorStatusResponse>(DoRPCRequest("SetGtmMonitorStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetGtmMonitorStatusResponse> SetGtmMonitorStatusWithOptionsAsync(SetGtmMonitorStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGtmMonitorStatusResponse>(await DoRPCRequestAsync("SetGtmMonitorStatus", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetGtmMonitorStatusResponse SetGtmMonitorStatus(SetGtmMonitorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGtmMonitorStatusWithOptions(request, runtime);
        }

        public async Task<SetGtmMonitorStatusResponse> SetGtmMonitorStatusAsync(SetGtmMonitorStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGtmMonitorStatusWithOptionsAsync(request, runtime);
        }

        public SwitchDnsGtmInstanceStrategyModeResponse SwitchDnsGtmInstanceStrategyModeWithOptions(SwitchDnsGtmInstanceStrategyModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchDnsGtmInstanceStrategyModeResponse>(DoRPCRequest("SwitchDnsGtmInstanceStrategyMode", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SwitchDnsGtmInstanceStrategyModeResponse> SwitchDnsGtmInstanceStrategyModeWithOptionsAsync(SwitchDnsGtmInstanceStrategyModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchDnsGtmInstanceStrategyModeResponse>(await DoRPCRequestAsync("SwitchDnsGtmInstanceStrategyMode", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SwitchDnsGtmInstanceStrategyModeResponse SwitchDnsGtmInstanceStrategyMode(SwitchDnsGtmInstanceStrategyModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchDnsGtmInstanceStrategyModeWithOptions(request, runtime);
        }

        public async Task<SwitchDnsGtmInstanceStrategyModeResponse> SwitchDnsGtmInstanceStrategyModeAsync(SwitchDnsGtmInstanceStrategyModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchDnsGtmInstanceStrategyModeWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TransferDomainResponse TransferDomainWithOptions(TransferDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferDomainResponse>(DoRPCRequest("TransferDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TransferDomainResponse> TransferDomainWithOptionsAsync(TransferDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TransferDomainResponse>(await DoRPCRequestAsync("TransferDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TransferDomainResponse TransferDomain(TransferDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TransferDomainWithOptions(request, runtime);
        }

        public async Task<TransferDomainResponse> TransferDomainAsync(TransferDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TransferDomainWithOptionsAsync(request, runtime);
        }

        public UnbindInstanceDomainsResponse UnbindInstanceDomainsWithOptions(UnbindInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindInstanceDomainsResponse>(DoRPCRequest("UnbindInstanceDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindInstanceDomainsResponse> UnbindInstanceDomainsWithOptionsAsync(UnbindInstanceDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindInstanceDomainsResponse>(await DoRPCRequestAsync("UnbindInstanceDomains", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindInstanceDomainsResponse UnbindInstanceDomains(UnbindInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindInstanceDomainsWithOptions(request, runtime);
        }

        public async Task<UnbindInstanceDomainsResponse> UnbindInstanceDomainsAsync(UnbindInstanceDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindInstanceDomainsWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateCustomLineResponse UpdateCustomLineWithOptions(UpdateCustomLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCustomLineResponse>(DoRPCRequest("UpdateCustomLine", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCustomLineResponse> UpdateCustomLineWithOptionsAsync(UpdateCustomLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCustomLineResponse>(await DoRPCRequestAsync("UpdateCustomLine", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCustomLineResponse UpdateCustomLine(UpdateCustomLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomLineWithOptions(request, runtime);
        }

        public async Task<UpdateCustomLineResponse> UpdateCustomLineAsync(UpdateCustomLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomLineWithOptionsAsync(request, runtime);
        }

        public UpdateDnsCacheDomainResponse UpdateDnsCacheDomainWithOptions(UpdateDnsCacheDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDnsCacheDomainResponse>(DoRPCRequest("UpdateDnsCacheDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDnsCacheDomainResponse> UpdateDnsCacheDomainWithOptionsAsync(UpdateDnsCacheDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDnsCacheDomainResponse>(await DoRPCRequestAsync("UpdateDnsCacheDomain", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDnsCacheDomainResponse UpdateDnsCacheDomain(UpdateDnsCacheDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDnsCacheDomainWithOptions(request, runtime);
        }

        public async Task<UpdateDnsCacheDomainResponse> UpdateDnsCacheDomainAsync(UpdateDnsCacheDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDnsCacheDomainWithOptionsAsync(request, runtime);
        }

        public UpdateDnsCacheDomainRemarkResponse UpdateDnsCacheDomainRemarkWithOptions(UpdateDnsCacheDomainRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDnsCacheDomainRemarkResponse>(DoRPCRequest("UpdateDnsCacheDomainRemark", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDnsCacheDomainRemarkResponse> UpdateDnsCacheDomainRemarkWithOptionsAsync(UpdateDnsCacheDomainRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDnsCacheDomainRemarkResponse>(await DoRPCRequestAsync("UpdateDnsCacheDomainRemark", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDnsCacheDomainRemarkResponse UpdateDnsCacheDomainRemark(UpdateDnsCacheDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDnsCacheDomainRemarkWithOptions(request, runtime);
        }

        public async Task<UpdateDnsCacheDomainRemarkResponse> UpdateDnsCacheDomainRemarkAsync(UpdateDnsCacheDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDnsCacheDomainRemarkWithOptionsAsync(request, runtime);
        }

        public UpdateDnsGtmAccessStrategyResponse UpdateDnsGtmAccessStrategyWithOptions(UpdateDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDnsGtmAccessStrategyResponse>(DoRPCRequest("UpdateDnsGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDnsGtmAccessStrategyResponse> UpdateDnsGtmAccessStrategyWithOptionsAsync(UpdateDnsGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDnsGtmAccessStrategyResponse>(await DoRPCRequestAsync("UpdateDnsGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDnsGtmAccessStrategyResponse UpdateDnsGtmAccessStrategy(UpdateDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDnsGtmAccessStrategyWithOptions(request, runtime);
        }

        public async Task<UpdateDnsGtmAccessStrategyResponse> UpdateDnsGtmAccessStrategyAsync(UpdateDnsGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDnsGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        public UpdateDnsGtmAddressPoolResponse UpdateDnsGtmAddressPoolWithOptions(UpdateDnsGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDnsGtmAddressPoolResponse>(DoRPCRequest("UpdateDnsGtmAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDnsGtmAddressPoolResponse> UpdateDnsGtmAddressPoolWithOptionsAsync(UpdateDnsGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDnsGtmAddressPoolResponse>(await DoRPCRequestAsync("UpdateDnsGtmAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDnsGtmAddressPoolResponse UpdateDnsGtmAddressPool(UpdateDnsGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDnsGtmAddressPoolWithOptions(request, runtime);
        }

        public async Task<UpdateDnsGtmAddressPoolResponse> UpdateDnsGtmAddressPoolAsync(UpdateDnsGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDnsGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        public UpdateDnsGtmInstanceGlobalConfigResponse UpdateDnsGtmInstanceGlobalConfigWithOptions(UpdateDnsGtmInstanceGlobalConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDnsGtmInstanceGlobalConfigResponse>(DoRPCRequest("UpdateDnsGtmInstanceGlobalConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDnsGtmInstanceGlobalConfigResponse> UpdateDnsGtmInstanceGlobalConfigWithOptionsAsync(UpdateDnsGtmInstanceGlobalConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDnsGtmInstanceGlobalConfigResponse>(await DoRPCRequestAsync("UpdateDnsGtmInstanceGlobalConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDnsGtmInstanceGlobalConfigResponse UpdateDnsGtmInstanceGlobalConfig(UpdateDnsGtmInstanceGlobalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDnsGtmInstanceGlobalConfigWithOptions(request, runtime);
        }

        public async Task<UpdateDnsGtmInstanceGlobalConfigResponse> UpdateDnsGtmInstanceGlobalConfigAsync(UpdateDnsGtmInstanceGlobalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDnsGtmInstanceGlobalConfigWithOptionsAsync(request, runtime);
        }

        public UpdateDnsGtmMonitorResponse UpdateDnsGtmMonitorWithOptions(UpdateDnsGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDnsGtmMonitorResponse>(DoRPCRequest("UpdateDnsGtmMonitor", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDnsGtmMonitorResponse> UpdateDnsGtmMonitorWithOptionsAsync(UpdateDnsGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDnsGtmMonitorResponse>(await DoRPCRequestAsync("UpdateDnsGtmMonitor", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDnsGtmMonitorResponse UpdateDnsGtmMonitor(UpdateDnsGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDnsGtmMonitorWithOptions(request, runtime);
        }

        public async Task<UpdateDnsGtmMonitorResponse> UpdateDnsGtmMonitorAsync(UpdateDnsGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDnsGtmMonitorWithOptionsAsync(request, runtime);
        }

        public UpdateDNSSLBWeightResponse UpdateDNSSLBWeightWithOptions(UpdateDNSSLBWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDNSSLBWeightResponse>(DoRPCRequest("UpdateDNSSLBWeight", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDNSSLBWeightResponse> UpdateDNSSLBWeightWithOptionsAsync(UpdateDNSSLBWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDNSSLBWeightResponse>(await DoRPCRequestAsync("UpdateDNSSLBWeight", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDNSSLBWeightResponse UpdateDNSSLBWeight(UpdateDNSSLBWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDNSSLBWeightWithOptions(request, runtime);
        }

        public async Task<UpdateDNSSLBWeightResponse> UpdateDNSSLBWeightAsync(UpdateDNSSLBWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDNSSLBWeightWithOptionsAsync(request, runtime);
        }

        public UpdateDomainGroupResponse UpdateDomainGroupWithOptions(UpdateDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDomainGroupResponse>(DoRPCRequest("UpdateDomainGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDomainGroupResponse> UpdateDomainGroupWithOptionsAsync(UpdateDomainGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDomainGroupResponse>(await DoRPCRequestAsync("UpdateDomainGroup", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDomainGroupResponse UpdateDomainGroup(UpdateDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDomainGroupWithOptions(request, runtime);
        }

        public async Task<UpdateDomainGroupResponse> UpdateDomainGroupAsync(UpdateDomainGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDomainGroupWithOptionsAsync(request, runtime);
        }

        public UpdateDomainRecordResponse UpdateDomainRecordWithOptions(UpdateDomainRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDomainRecordResponse>(DoRPCRequest("UpdateDomainRecord", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDomainRecordResponse> UpdateDomainRecordWithOptionsAsync(UpdateDomainRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDomainRecordResponse>(await DoRPCRequestAsync("UpdateDomainRecord", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDomainRecordResponse UpdateDomainRecord(UpdateDomainRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDomainRecordWithOptions(request, runtime);
        }

        public async Task<UpdateDomainRecordResponse> UpdateDomainRecordAsync(UpdateDomainRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDomainRecordWithOptionsAsync(request, runtime);
        }

        public UpdateDomainRecordRemarkResponse UpdateDomainRecordRemarkWithOptions(UpdateDomainRecordRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDomainRecordRemarkResponse>(DoRPCRequest("UpdateDomainRecordRemark", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDomainRecordRemarkResponse> UpdateDomainRecordRemarkWithOptionsAsync(UpdateDomainRecordRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDomainRecordRemarkResponse>(await DoRPCRequestAsync("UpdateDomainRecordRemark", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDomainRecordRemarkResponse UpdateDomainRecordRemark(UpdateDomainRecordRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDomainRecordRemarkWithOptions(request, runtime);
        }

        public async Task<UpdateDomainRecordRemarkResponse> UpdateDomainRecordRemarkAsync(UpdateDomainRecordRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDomainRecordRemarkWithOptionsAsync(request, runtime);
        }

        public UpdateDomainRemarkResponse UpdateDomainRemarkWithOptions(UpdateDomainRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDomainRemarkResponse>(DoRPCRequest("UpdateDomainRemark", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDomainRemarkResponse> UpdateDomainRemarkWithOptionsAsync(UpdateDomainRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDomainRemarkResponse>(await DoRPCRequestAsync("UpdateDomainRemark", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDomainRemarkResponse UpdateDomainRemark(UpdateDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDomainRemarkWithOptions(request, runtime);
        }

        public async Task<UpdateDomainRemarkResponse> UpdateDomainRemarkAsync(UpdateDomainRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDomainRemarkWithOptionsAsync(request, runtime);
        }

        public UpdateGtmAccessStrategyResponse UpdateGtmAccessStrategyWithOptions(UpdateGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGtmAccessStrategyResponse>(DoRPCRequest("UpdateGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateGtmAccessStrategyResponse> UpdateGtmAccessStrategyWithOptionsAsync(UpdateGtmAccessStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGtmAccessStrategyResponse>(await DoRPCRequestAsync("UpdateGtmAccessStrategy", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateGtmAccessStrategyResponse UpdateGtmAccessStrategy(UpdateGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGtmAccessStrategyWithOptions(request, runtime);
        }

        public async Task<UpdateGtmAccessStrategyResponse> UpdateGtmAccessStrategyAsync(UpdateGtmAccessStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGtmAccessStrategyWithOptionsAsync(request, runtime);
        }

        public UpdateGtmAddressPoolResponse UpdateGtmAddressPoolWithOptions(UpdateGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGtmAddressPoolResponse>(DoRPCRequest("UpdateGtmAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateGtmAddressPoolResponse> UpdateGtmAddressPoolWithOptionsAsync(UpdateGtmAddressPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGtmAddressPoolResponse>(await DoRPCRequestAsync("UpdateGtmAddressPool", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateGtmAddressPoolResponse UpdateGtmAddressPool(UpdateGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGtmAddressPoolWithOptions(request, runtime);
        }

        public async Task<UpdateGtmAddressPoolResponse> UpdateGtmAddressPoolAsync(UpdateGtmAddressPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGtmAddressPoolWithOptionsAsync(request, runtime);
        }

        public UpdateGtmInstanceGlobalConfigResponse UpdateGtmInstanceGlobalConfigWithOptions(UpdateGtmInstanceGlobalConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGtmInstanceGlobalConfigResponse>(DoRPCRequest("UpdateGtmInstanceGlobalConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateGtmInstanceGlobalConfigResponse> UpdateGtmInstanceGlobalConfigWithOptionsAsync(UpdateGtmInstanceGlobalConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGtmInstanceGlobalConfigResponse>(await DoRPCRequestAsync("UpdateGtmInstanceGlobalConfig", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateGtmInstanceGlobalConfigResponse UpdateGtmInstanceGlobalConfig(UpdateGtmInstanceGlobalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGtmInstanceGlobalConfigWithOptions(request, runtime);
        }

        public async Task<UpdateGtmInstanceGlobalConfigResponse> UpdateGtmInstanceGlobalConfigAsync(UpdateGtmInstanceGlobalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGtmInstanceGlobalConfigWithOptionsAsync(request, runtime);
        }

        public UpdateGtmMonitorResponse UpdateGtmMonitorWithOptions(UpdateGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGtmMonitorResponse>(DoRPCRequest("UpdateGtmMonitor", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateGtmMonitorResponse> UpdateGtmMonitorWithOptionsAsync(UpdateGtmMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGtmMonitorResponse>(await DoRPCRequestAsync("UpdateGtmMonitor", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateGtmMonitorResponse UpdateGtmMonitor(UpdateGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGtmMonitorWithOptions(request, runtime);
        }

        public async Task<UpdateGtmMonitorResponse> UpdateGtmMonitorAsync(UpdateGtmMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGtmMonitorWithOptionsAsync(request, runtime);
        }

        public UpdateGtmRecoveryPlanResponse UpdateGtmRecoveryPlanWithOptions(UpdateGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGtmRecoveryPlanResponse>(DoRPCRequest("UpdateGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateGtmRecoveryPlanResponse> UpdateGtmRecoveryPlanWithOptionsAsync(UpdateGtmRecoveryPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateGtmRecoveryPlanResponse>(await DoRPCRequestAsync("UpdateGtmRecoveryPlan", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateGtmRecoveryPlanResponse UpdateGtmRecoveryPlan(UpdateGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGtmRecoveryPlanWithOptions(request, runtime);
        }

        public async Task<UpdateGtmRecoveryPlanResponse> UpdateGtmRecoveryPlanAsync(UpdateGtmRecoveryPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGtmRecoveryPlanWithOptionsAsync(request, runtime);
        }

        public ValidateDnsGtmAttributeInfoResponse ValidateDnsGtmAttributeInfoWithOptions(ValidateDnsGtmAttributeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ValidateDnsGtmAttributeInfoResponse>(DoRPCRequest("ValidateDnsGtmAttributeInfo", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ValidateDnsGtmAttributeInfoResponse> ValidateDnsGtmAttributeInfoWithOptionsAsync(ValidateDnsGtmAttributeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ValidateDnsGtmAttributeInfoResponse>(await DoRPCRequestAsync("ValidateDnsGtmAttributeInfo", "2015-01-09", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ValidateDnsGtmAttributeInfoResponse ValidateDnsGtmAttributeInfo(ValidateDnsGtmAttributeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateDnsGtmAttributeInfoWithOptions(request, runtime);
        }

        public async Task<ValidateDnsGtmAttributeInfoResponse> ValidateDnsGtmAttributeInfoAsync(ValidateDnsGtmAttributeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateDnsGtmAttributeInfoWithOptionsAsync(request, runtime);
        }

    }
}
