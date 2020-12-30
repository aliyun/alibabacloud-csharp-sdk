// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Vpc20160428.Models;

namespace AlibabaCloud.SDK.Vpc20160428
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "vpc.aliyuncs.com"},
                {"cn-beijing", "vpc.aliyuncs.com"},
                {"cn-hangzhou", "vpc.aliyuncs.com"},
                {"cn-shanghai", "vpc.aliyuncs.com"},
                {"cn-shenzhen", "vpc.aliyuncs.com"},
                {"cn-hongkong", "vpc.aliyuncs.com"},
                {"ap-southeast-1", "vpc.aliyuncs.com"},
                {"us-west-1", "vpc.aliyuncs.com"},
                {"us-east-1", "vpc.aliyuncs.com"},
                {"cn-shanghai-finance-1", "vpc.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "vpc.aliyuncs.com"},
                {"cn-north-2-gov-1", "vpc.aliyuncs.com"},
                {"ap-northeast-2-pop", "vpc.aliyuncs.com"},
                {"cn-beijing-finance-1", "vpc.aliyuncs.com"},
                {"cn-beijing-finance-pop", "vpc.aliyuncs.com"},
                {"cn-beijing-gov-1", "vpc.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "vpc.aliyuncs.com"},
                {"cn-edge-1", "vpc-nebula.cn-qingdao-nebula.aliyuncs.com"},
                {"cn-fujian", "vpc.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "vpc.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "vpc.aliyuncs.com"},
                {"cn-hangzhou-finance", "vpc.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "vpc.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "vpc.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "vpc.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "vpc.aliyuncs.com"},
                {"cn-hangzhou-test-306", "vpc.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "vpc.aliyuncs.com"},
                {"cn-qingdao-nebula", "vpc-nebula.cn-qingdao-nebula.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "vpc.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "vpc.aliyuncs.com"},
                {"cn-shanghai-inner", "vpc.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "vpc.aliyuncs.com"},
                {"cn-shenzhen-inner", "vpc.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "vpc.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "vpc.aliyuncs.com"},
                {"cn-wuhan", "vpc.aliyuncs.com"},
                {"cn-yushanfang", "vpc.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "vpc.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "vpc.cn-zhangjiakou.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "vpc-nebula.cn-qingdao-nebula.aliyuncs.com"},
                {"eu-west-1-oxs", "vpc-nebula.cn-shenzhen-cloudstone.aliyuncs.com"},
                {"rus-west-1-pop", "vpc.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("vpc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ActivateRouterInterfaceResponse ActivateRouterInterfaceWithOptions(ActivateRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivateRouterInterfaceResponse>(DoRPCRequest("ActivateRouterInterface", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ActivateRouterInterfaceResponse> ActivateRouterInterfaceWithOptionsAsync(ActivateRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivateRouterInterfaceResponse>(await DoRPCRequestAsync("ActivateRouterInterface", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ActivateRouterInterfaceResponse ActivateRouterInterface(ActivateRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateRouterInterfaceWithOptions(request, runtime);
        }

        public async Task<ActivateRouterInterfaceResponse> ActivateRouterInterfaceAsync(ActivateRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateRouterInterfaceWithOptionsAsync(request, runtime);
        }

        public ActiveFlowLogResponse ActiveFlowLogWithOptions(ActiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActiveFlowLogResponse>(DoRPCRequest("ActiveFlowLog", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ActiveFlowLogResponse> ActiveFlowLogWithOptionsAsync(ActiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActiveFlowLogResponse>(await DoRPCRequestAsync("ActiveFlowLog", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ActiveFlowLogResponse ActiveFlowLog(ActiveFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveFlowLogWithOptions(request, runtime);
        }

        public async Task<ActiveFlowLogResponse> ActiveFlowLogAsync(ActiveFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveFlowLogWithOptionsAsync(request, runtime);
        }

        public AddBgpNetworkResponse AddBgpNetworkWithOptions(AddBgpNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddBgpNetworkResponse>(DoRPCRequest("AddBgpNetwork", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddBgpNetworkResponse> AddBgpNetworkWithOptionsAsync(AddBgpNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddBgpNetworkResponse>(await DoRPCRequestAsync("AddBgpNetwork", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddBgpNetworkResponse AddBgpNetwork(AddBgpNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBgpNetworkWithOptions(request, runtime);
        }

        public async Task<AddBgpNetworkResponse> AddBgpNetworkAsync(AddBgpNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBgpNetworkWithOptionsAsync(request, runtime);
        }

        public AddCommonBandwidthPackageIpResponse AddCommonBandwidthPackageIpWithOptions(AddCommonBandwidthPackageIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCommonBandwidthPackageIpResponse>(DoRPCRequest("AddCommonBandwidthPackageIp", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCommonBandwidthPackageIpResponse> AddCommonBandwidthPackageIpWithOptionsAsync(AddCommonBandwidthPackageIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCommonBandwidthPackageIpResponse>(await DoRPCRequestAsync("AddCommonBandwidthPackageIp", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCommonBandwidthPackageIpResponse AddCommonBandwidthPackageIp(AddCommonBandwidthPackageIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCommonBandwidthPackageIpWithOptions(request, runtime);
        }

        public async Task<AddCommonBandwidthPackageIpResponse> AddCommonBandwidthPackageIpAsync(AddCommonBandwidthPackageIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCommonBandwidthPackageIpWithOptionsAsync(request, runtime);
        }

        public AddCommonBandwidthPackageIpsResponse AddCommonBandwidthPackageIpsWithOptions(AddCommonBandwidthPackageIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCommonBandwidthPackageIpsResponse>(DoRPCRequest("AddCommonBandwidthPackageIps", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCommonBandwidthPackageIpsResponse> AddCommonBandwidthPackageIpsWithOptionsAsync(AddCommonBandwidthPackageIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCommonBandwidthPackageIpsResponse>(await DoRPCRequestAsync("AddCommonBandwidthPackageIps", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCommonBandwidthPackageIpsResponse AddCommonBandwidthPackageIps(AddCommonBandwidthPackageIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCommonBandwidthPackageIpsWithOptions(request, runtime);
        }

        public async Task<AddCommonBandwidthPackageIpsResponse> AddCommonBandwidthPackageIpsAsync(AddCommonBandwidthPackageIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCommonBandwidthPackageIpsWithOptionsAsync(request, runtime);
        }

        public AddGlobalAccelerationInstanceIpResponse AddGlobalAccelerationInstanceIpWithOptions(AddGlobalAccelerationInstanceIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGlobalAccelerationInstanceIpResponse>(DoRPCRequest("AddGlobalAccelerationInstanceIp", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddGlobalAccelerationInstanceIpResponse> AddGlobalAccelerationInstanceIpWithOptionsAsync(AddGlobalAccelerationInstanceIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGlobalAccelerationInstanceIpResponse>(await DoRPCRequestAsync("AddGlobalAccelerationInstanceIp", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddGlobalAccelerationInstanceIpResponse AddGlobalAccelerationInstanceIp(AddGlobalAccelerationInstanceIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGlobalAccelerationInstanceIpWithOptions(request, runtime);
        }

        public async Task<AddGlobalAccelerationInstanceIpResponse> AddGlobalAccelerationInstanceIpAsync(AddGlobalAccelerationInstanceIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGlobalAccelerationInstanceIpWithOptionsAsync(request, runtime);
        }

        public AddIPv6TranslatorAclListEntryResponse AddIPv6TranslatorAclListEntryWithOptions(AddIPv6TranslatorAclListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddIPv6TranslatorAclListEntryResponse>(DoRPCRequest("AddIPv6TranslatorAclListEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddIPv6TranslatorAclListEntryResponse> AddIPv6TranslatorAclListEntryWithOptionsAsync(AddIPv6TranslatorAclListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddIPv6TranslatorAclListEntryResponse>(await DoRPCRequestAsync("AddIPv6TranslatorAclListEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddIPv6TranslatorAclListEntryResponse AddIPv6TranslatorAclListEntry(AddIPv6TranslatorAclListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddIPv6TranslatorAclListEntryWithOptions(request, runtime);
        }

        public async Task<AddIPv6TranslatorAclListEntryResponse> AddIPv6TranslatorAclListEntryAsync(AddIPv6TranslatorAclListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddIPv6TranslatorAclListEntryWithOptionsAsync(request, runtime);
        }

        public AllocateEipAddressResponse AllocateEipAddressWithOptions(AllocateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateEipAddressResponse>(DoRPCRequest("AllocateEipAddress", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateEipAddressResponse> AllocateEipAddressWithOptionsAsync(AllocateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateEipAddressResponse>(await DoRPCRequestAsync("AllocateEipAddress", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocateEipAddressResponse AllocateEipAddress(AllocateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateEipAddressWithOptions(request, runtime);
        }

        public async Task<AllocateEipAddressResponse> AllocateEipAddressAsync(AllocateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateEipAddressWithOptionsAsync(request, runtime);
        }

        public AllocateEipAddressProResponse AllocateEipAddressProWithOptions(AllocateEipAddressProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateEipAddressProResponse>(DoRPCRequest("AllocateEipAddressPro", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateEipAddressProResponse> AllocateEipAddressProWithOptionsAsync(AllocateEipAddressProRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateEipAddressProResponse>(await DoRPCRequestAsync("AllocateEipAddressPro", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocateEipAddressProResponse AllocateEipAddressPro(AllocateEipAddressProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateEipAddressProWithOptions(request, runtime);
        }

        public async Task<AllocateEipAddressProResponse> AllocateEipAddressProAsync(AllocateEipAddressProRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateEipAddressProWithOptionsAsync(request, runtime);
        }

        public AllocateEipSegmentAddressResponse AllocateEipSegmentAddressWithOptions(AllocateEipSegmentAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateEipSegmentAddressResponse>(DoRPCRequest("AllocateEipSegmentAddress", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateEipSegmentAddressResponse> AllocateEipSegmentAddressWithOptionsAsync(AllocateEipSegmentAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateEipSegmentAddressResponse>(await DoRPCRequestAsync("AllocateEipSegmentAddress", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocateEipSegmentAddressResponse AllocateEipSegmentAddress(AllocateEipSegmentAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateEipSegmentAddressWithOptions(request, runtime);
        }

        public async Task<AllocateEipSegmentAddressResponse> AllocateEipSegmentAddressAsync(AllocateEipSegmentAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateEipSegmentAddressWithOptionsAsync(request, runtime);
        }

        public AllocateIpv6InternetBandwidthResponse AllocateIpv6InternetBandwidthWithOptions(AllocateIpv6InternetBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateIpv6InternetBandwidthResponse>(DoRPCRequest("AllocateIpv6InternetBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateIpv6InternetBandwidthResponse> AllocateIpv6InternetBandwidthWithOptionsAsync(AllocateIpv6InternetBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateIpv6InternetBandwidthResponse>(await DoRPCRequestAsync("AllocateIpv6InternetBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocateIpv6InternetBandwidthResponse AllocateIpv6InternetBandwidth(AllocateIpv6InternetBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateIpv6InternetBandwidthWithOptions(request, runtime);
        }

        public async Task<AllocateIpv6InternetBandwidthResponse> AllocateIpv6InternetBandwidthAsync(AllocateIpv6InternetBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateIpv6InternetBandwidthWithOptionsAsync(request, runtime);
        }

        public AssociateEipAddressResponse AssociateEipAddressWithOptions(AssociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateEipAddressResponse>(DoRPCRequest("AssociateEipAddress", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateEipAddressResponse> AssociateEipAddressWithOptionsAsync(AssociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateEipAddressResponse>(await DoRPCRequestAsync("AssociateEipAddress", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateEipAddressResponse AssociateEipAddress(AssociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateEipAddressWithOptions(request, runtime);
        }

        public async Task<AssociateEipAddressResponse> AssociateEipAddressAsync(AssociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateEipAddressWithOptionsAsync(request, runtime);
        }

        public AssociateGlobalAccelerationInstanceResponse AssociateGlobalAccelerationInstanceWithOptions(AssociateGlobalAccelerationInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateGlobalAccelerationInstanceResponse>(DoRPCRequest("AssociateGlobalAccelerationInstance", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateGlobalAccelerationInstanceResponse> AssociateGlobalAccelerationInstanceWithOptionsAsync(AssociateGlobalAccelerationInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateGlobalAccelerationInstanceResponse>(await DoRPCRequestAsync("AssociateGlobalAccelerationInstance", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateGlobalAccelerationInstanceResponse AssociateGlobalAccelerationInstance(AssociateGlobalAccelerationInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateGlobalAccelerationInstanceWithOptions(request, runtime);
        }

        public async Task<AssociateGlobalAccelerationInstanceResponse> AssociateGlobalAccelerationInstanceAsync(AssociateGlobalAccelerationInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateGlobalAccelerationInstanceWithOptionsAsync(request, runtime);
        }

        public AssociateHaVipResponse AssociateHaVipWithOptions(AssociateHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateHaVipResponse>(DoRPCRequest("AssociateHaVip", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateHaVipResponse> AssociateHaVipWithOptionsAsync(AssociateHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateHaVipResponse>(await DoRPCRequestAsync("AssociateHaVip", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateHaVipResponse AssociateHaVip(AssociateHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateHaVipWithOptions(request, runtime);
        }

        public async Task<AssociateHaVipResponse> AssociateHaVipAsync(AssociateHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateHaVipWithOptionsAsync(request, runtime);
        }

        public AssociateNetworkAclResponse AssociateNetworkAclWithOptions(AssociateNetworkAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateNetworkAclResponse>(DoRPCRequest("AssociateNetworkAcl", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateNetworkAclResponse> AssociateNetworkAclWithOptionsAsync(AssociateNetworkAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateNetworkAclResponse>(await DoRPCRequestAsync("AssociateNetworkAcl", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateNetworkAclResponse AssociateNetworkAcl(AssociateNetworkAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateNetworkAclWithOptions(request, runtime);
        }

        public async Task<AssociateNetworkAclResponse> AssociateNetworkAclAsync(AssociateNetworkAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateNetworkAclWithOptionsAsync(request, runtime);
        }

        public AssociatePhysicalConnectionToVirtualBorderRouterResponse AssociatePhysicalConnectionToVirtualBorderRouterWithOptions(AssociatePhysicalConnectionToVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociatePhysicalConnectionToVirtualBorderRouterResponse>(DoRPCRequest("AssociatePhysicalConnectionToVirtualBorderRouter", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociatePhysicalConnectionToVirtualBorderRouterResponse> AssociatePhysicalConnectionToVirtualBorderRouterWithOptionsAsync(AssociatePhysicalConnectionToVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociatePhysicalConnectionToVirtualBorderRouterResponse>(await DoRPCRequestAsync("AssociatePhysicalConnectionToVirtualBorderRouter", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociatePhysicalConnectionToVirtualBorderRouterResponse AssociatePhysicalConnectionToVirtualBorderRouter(AssociatePhysicalConnectionToVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociatePhysicalConnectionToVirtualBorderRouterWithOptions(request, runtime);
        }

        public async Task<AssociatePhysicalConnectionToVirtualBorderRouterResponse> AssociatePhysicalConnectionToVirtualBorderRouterAsync(AssociatePhysicalConnectionToVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociatePhysicalConnectionToVirtualBorderRouterWithOptionsAsync(request, runtime);
        }

        public AssociateRouteTableResponse AssociateRouteTableWithOptions(AssociateRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateRouteTableResponse>(DoRPCRequest("AssociateRouteTable", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateRouteTableResponse> AssociateRouteTableWithOptionsAsync(AssociateRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateRouteTableResponse>(await DoRPCRequestAsync("AssociateRouteTable", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateRouteTableWithOptions(request, runtime);
        }

        public async Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateRouteTableWithOptionsAsync(request, runtime);
        }

        public AssociateVpcCidrBlockResponse AssociateVpcCidrBlockWithOptions(AssociateVpcCidrBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateVpcCidrBlockResponse>(DoRPCRequest("AssociateVpcCidrBlock", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateVpcCidrBlockResponse> AssociateVpcCidrBlockWithOptionsAsync(AssociateVpcCidrBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateVpcCidrBlockResponse>(await DoRPCRequestAsync("AssociateVpcCidrBlock", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateVpcCidrBlockResponse AssociateVpcCidrBlock(AssociateVpcCidrBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateVpcCidrBlockWithOptions(request, runtime);
        }

        public async Task<AssociateVpcCidrBlockResponse> AssociateVpcCidrBlockAsync(AssociateVpcCidrBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateVpcCidrBlockWithOptionsAsync(request, runtime);
        }

        public AssociateVpnGatewayWithCertificateResponse AssociateVpnGatewayWithCertificateWithOptions(AssociateVpnGatewayWithCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateVpnGatewayWithCertificateResponse>(DoRPCRequest("AssociateVpnGatewayWithCertificate", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateVpnGatewayWithCertificateResponse> AssociateVpnGatewayWithCertificateWithOptionsAsync(AssociateVpnGatewayWithCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateVpnGatewayWithCertificateResponse>(await DoRPCRequestAsync("AssociateVpnGatewayWithCertificate", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateVpnGatewayWithCertificateResponse AssociateVpnGatewayWithCertificate(AssociateVpnGatewayWithCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateVpnGatewayWithCertificateWithOptions(request, runtime);
        }

        public async Task<AssociateVpnGatewayWithCertificateResponse> AssociateVpnGatewayWithCertificateAsync(AssociateVpnGatewayWithCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateVpnGatewayWithCertificateWithOptionsAsync(request, runtime);
        }

        public AttachDhcpOptionsSetToVpcResponse AttachDhcpOptionsSetToVpcWithOptions(AttachDhcpOptionsSetToVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachDhcpOptionsSetToVpcResponse>(DoRPCRequest("AttachDhcpOptionsSetToVpc", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachDhcpOptionsSetToVpcResponse> AttachDhcpOptionsSetToVpcWithOptionsAsync(AttachDhcpOptionsSetToVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachDhcpOptionsSetToVpcResponse>(await DoRPCRequestAsync("AttachDhcpOptionsSetToVpc", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachDhcpOptionsSetToVpcResponse AttachDhcpOptionsSetToVpc(AttachDhcpOptionsSetToVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachDhcpOptionsSetToVpcWithOptions(request, runtime);
        }

        public async Task<AttachDhcpOptionsSetToVpcResponse> AttachDhcpOptionsSetToVpcAsync(AttachDhcpOptionsSetToVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachDhcpOptionsSetToVpcWithOptionsAsync(request, runtime);
        }

        public CancelCommonBandwidthPackageIpBandwidthResponse CancelCommonBandwidthPackageIpBandwidthWithOptions(CancelCommonBandwidthPackageIpBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelCommonBandwidthPackageIpBandwidthResponse>(DoRPCRequest("CancelCommonBandwidthPackageIpBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelCommonBandwidthPackageIpBandwidthResponse> CancelCommonBandwidthPackageIpBandwidthWithOptionsAsync(CancelCommonBandwidthPackageIpBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelCommonBandwidthPackageIpBandwidthResponse>(await DoRPCRequestAsync("CancelCommonBandwidthPackageIpBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelCommonBandwidthPackageIpBandwidthResponse CancelCommonBandwidthPackageIpBandwidth(CancelCommonBandwidthPackageIpBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelCommonBandwidthPackageIpBandwidthWithOptions(request, runtime);
        }

        public async Task<CancelCommonBandwidthPackageIpBandwidthResponse> CancelCommonBandwidthPackageIpBandwidthAsync(CancelCommonBandwidthPackageIpBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelCommonBandwidthPackageIpBandwidthWithOptionsAsync(request, runtime);
        }

        public CancelExpressCloudConnectionResponse CancelExpressCloudConnectionWithOptions(CancelExpressCloudConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelExpressCloudConnectionResponse>(DoRPCRequest("CancelExpressCloudConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelExpressCloudConnectionResponse> CancelExpressCloudConnectionWithOptionsAsync(CancelExpressCloudConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelExpressCloudConnectionResponse>(await DoRPCRequestAsync("CancelExpressCloudConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelExpressCloudConnectionResponse CancelExpressCloudConnection(CancelExpressCloudConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelExpressCloudConnectionWithOptions(request, runtime);
        }

        public async Task<CancelExpressCloudConnectionResponse> CancelExpressCloudConnectionAsync(CancelExpressCloudConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelExpressCloudConnectionWithOptionsAsync(request, runtime);
        }

        public CancelPhysicalConnectionResponse CancelPhysicalConnectionWithOptions(CancelPhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelPhysicalConnectionResponse>(DoRPCRequest("CancelPhysicalConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelPhysicalConnectionResponse> CancelPhysicalConnectionWithOptionsAsync(CancelPhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelPhysicalConnectionResponse>(await DoRPCRequestAsync("CancelPhysicalConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelPhysicalConnectionResponse CancelPhysicalConnection(CancelPhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPhysicalConnectionWithOptions(request, runtime);
        }

        public async Task<CancelPhysicalConnectionResponse> CancelPhysicalConnectionAsync(CancelPhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPhysicalConnectionWithOptionsAsync(request, runtime);
        }

        public ConfirmPhysicalConnectionResponse ConfirmPhysicalConnectionWithOptions(ConfirmPhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfirmPhysicalConnectionResponse>(DoRPCRequest("ConfirmPhysicalConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfirmPhysicalConnectionResponse> ConfirmPhysicalConnectionWithOptionsAsync(ConfirmPhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfirmPhysicalConnectionResponse>(await DoRPCRequestAsync("ConfirmPhysicalConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfirmPhysicalConnectionResponse ConfirmPhysicalConnection(ConfirmPhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfirmPhysicalConnectionWithOptions(request, runtime);
        }

        public async Task<ConfirmPhysicalConnectionResponse> ConfirmPhysicalConnectionAsync(ConfirmPhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfirmPhysicalConnectionWithOptionsAsync(request, runtime);
        }

        public ConnectRouterInterfaceResponse ConnectRouterInterfaceWithOptions(ConnectRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConnectRouterInterfaceResponse>(DoRPCRequest("ConnectRouterInterface", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConnectRouterInterfaceResponse> ConnectRouterInterfaceWithOptionsAsync(ConnectRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConnectRouterInterfaceResponse>(await DoRPCRequestAsync("ConnectRouterInterface", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConnectRouterInterfaceResponse ConnectRouterInterface(ConnectRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConnectRouterInterfaceWithOptions(request, runtime);
        }

        public async Task<ConnectRouterInterfaceResponse> ConnectRouterInterfaceAsync(ConnectRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConnectRouterInterfaceWithOptionsAsync(request, runtime);
        }

        public ConvertBandwidthPackageResponse ConvertBandwidthPackageWithOptions(ConvertBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConvertBandwidthPackageResponse>(DoRPCRequest("ConvertBandwidthPackage", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConvertBandwidthPackageResponse> ConvertBandwidthPackageWithOptionsAsync(ConvertBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConvertBandwidthPackageResponse>(await DoRPCRequestAsync("ConvertBandwidthPackage", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConvertBandwidthPackageResponse ConvertBandwidthPackage(ConvertBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<ConvertBandwidthPackageResponse> ConvertBandwidthPackageAsync(ConvertBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public CopyNetworkAclEntriesResponse CopyNetworkAclEntriesWithOptions(CopyNetworkAclEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyNetworkAclEntriesResponse>(DoRPCRequest("CopyNetworkAclEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CopyNetworkAclEntriesResponse> CopyNetworkAclEntriesWithOptionsAsync(CopyNetworkAclEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyNetworkAclEntriesResponse>(await DoRPCRequestAsync("CopyNetworkAclEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CopyNetworkAclEntriesResponse CopyNetworkAclEntries(CopyNetworkAclEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyNetworkAclEntriesWithOptions(request, runtime);
        }

        public async Task<CopyNetworkAclEntriesResponse> CopyNetworkAclEntriesAsync(CopyNetworkAclEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyNetworkAclEntriesWithOptionsAsync(request, runtime);
        }

        public CreateBgpGroupResponse CreateBgpGroupWithOptions(CreateBgpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBgpGroupResponse>(DoRPCRequest("CreateBgpGroup", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBgpGroupResponse> CreateBgpGroupWithOptionsAsync(CreateBgpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBgpGroupResponse>(await DoRPCRequestAsync("CreateBgpGroup", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBgpGroupResponse CreateBgpGroup(CreateBgpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBgpGroupWithOptions(request, runtime);
        }

        public async Task<CreateBgpGroupResponse> CreateBgpGroupAsync(CreateBgpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBgpGroupWithOptionsAsync(request, runtime);
        }

        public CreateBgpPeerResponse CreateBgpPeerWithOptions(CreateBgpPeerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBgpPeerResponse>(DoRPCRequest("CreateBgpPeer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBgpPeerResponse> CreateBgpPeerWithOptionsAsync(CreateBgpPeerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBgpPeerResponse>(await DoRPCRequestAsync("CreateBgpPeer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBgpPeerResponse CreateBgpPeer(CreateBgpPeerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBgpPeerWithOptions(request, runtime);
        }

        public async Task<CreateBgpPeerResponse> CreateBgpPeerAsync(CreateBgpPeerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBgpPeerWithOptionsAsync(request, runtime);
        }

        public CreateCommonBandwidthPackageResponse CreateCommonBandwidthPackageWithOptions(CreateCommonBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCommonBandwidthPackageResponse>(DoRPCRequest("CreateCommonBandwidthPackage", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCommonBandwidthPackageResponse> CreateCommonBandwidthPackageWithOptionsAsync(CreateCommonBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCommonBandwidthPackageResponse>(await DoRPCRequestAsync("CreateCommonBandwidthPackage", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCommonBandwidthPackageResponse CreateCommonBandwidthPackage(CreateCommonBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCommonBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<CreateCommonBandwidthPackageResponse> CreateCommonBandwidthPackageAsync(CreateCommonBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCommonBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public CreateCustomerGatewayResponse CreateCustomerGatewayWithOptions(CreateCustomerGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomerGatewayResponse>(DoRPCRequest("CreateCustomerGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCustomerGatewayResponse> CreateCustomerGatewayWithOptionsAsync(CreateCustomerGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCustomerGatewayResponse>(await DoRPCRequestAsync("CreateCustomerGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomerGatewayWithOptions(request, runtime);
        }

        public async Task<CreateCustomerGatewayResponse> CreateCustomerGatewayAsync(CreateCustomerGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomerGatewayWithOptionsAsync(request, runtime);
        }

        public CreateDhcpOptionsSetResponse CreateDhcpOptionsSetWithOptions(CreateDhcpOptionsSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDhcpOptionsSetResponse>(DoRPCRequest("CreateDhcpOptionsSet", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDhcpOptionsSetResponse> CreateDhcpOptionsSetWithOptionsAsync(CreateDhcpOptionsSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDhcpOptionsSetResponse>(await DoRPCRequestAsync("CreateDhcpOptionsSet", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDhcpOptionsSetResponse CreateDhcpOptionsSet(CreateDhcpOptionsSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDhcpOptionsSetWithOptions(request, runtime);
        }

        public async Task<CreateDhcpOptionsSetResponse> CreateDhcpOptionsSetAsync(CreateDhcpOptionsSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDhcpOptionsSetWithOptionsAsync(request, runtime);
        }

        public CreateExpressCloudConnectionResponse CreateExpressCloudConnectionWithOptions(CreateExpressCloudConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateExpressCloudConnectionResponse>(DoRPCRequest("CreateExpressCloudConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateExpressCloudConnectionResponse> CreateExpressCloudConnectionWithOptionsAsync(CreateExpressCloudConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateExpressCloudConnectionResponse>(await DoRPCRequestAsync("CreateExpressCloudConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateExpressCloudConnectionResponse CreateExpressCloudConnection(CreateExpressCloudConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExpressCloudConnectionWithOptions(request, runtime);
        }

        public async Task<CreateExpressCloudConnectionResponse> CreateExpressCloudConnectionAsync(CreateExpressCloudConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExpressCloudConnectionWithOptionsAsync(request, runtime);
        }

        public CreateFlowLogResponse CreateFlowLogWithOptions(CreateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowLogResponse>(DoRPCRequest("CreateFlowLog", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowLogResponse> CreateFlowLogWithOptionsAsync(CreateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowLogResponse>(await DoRPCRequestAsync("CreateFlowLog", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowLogResponse CreateFlowLog(CreateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowLogWithOptions(request, runtime);
        }

        public async Task<CreateFlowLogResponse> CreateFlowLogAsync(CreateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowLogWithOptionsAsync(request, runtime);
        }

        public CreateForwardEntryResponse CreateForwardEntryWithOptions(CreateForwardEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateForwardEntryResponse>(DoRPCRequest("CreateForwardEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateForwardEntryResponse> CreateForwardEntryWithOptionsAsync(CreateForwardEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateForwardEntryResponse>(await DoRPCRequestAsync("CreateForwardEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateForwardEntryResponse CreateForwardEntry(CreateForwardEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateForwardEntryWithOptions(request, runtime);
        }

        public async Task<CreateForwardEntryResponse> CreateForwardEntryAsync(CreateForwardEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateForwardEntryWithOptionsAsync(request, runtime);
        }

        public CreateGlobalAccelerationInstanceResponse CreateGlobalAccelerationInstanceWithOptions(CreateGlobalAccelerationInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGlobalAccelerationInstanceResponse>(DoRPCRequest("CreateGlobalAccelerationInstance", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGlobalAccelerationInstanceResponse> CreateGlobalAccelerationInstanceWithOptionsAsync(CreateGlobalAccelerationInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGlobalAccelerationInstanceResponse>(await DoRPCRequestAsync("CreateGlobalAccelerationInstance", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGlobalAccelerationInstanceResponse CreateGlobalAccelerationInstance(CreateGlobalAccelerationInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGlobalAccelerationInstanceWithOptions(request, runtime);
        }

        public async Task<CreateGlobalAccelerationInstanceResponse> CreateGlobalAccelerationInstanceAsync(CreateGlobalAccelerationInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGlobalAccelerationInstanceWithOptionsAsync(request, runtime);
        }

        public CreateHaVipResponse CreateHaVipWithOptions(CreateHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHaVipResponse>(DoRPCRequest("CreateHaVip", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHaVipResponse> CreateHaVipWithOptionsAsync(CreateHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHaVipResponse>(await DoRPCRequestAsync("CreateHaVip", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHaVipResponse CreateHaVip(CreateHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHaVipWithOptions(request, runtime);
        }

        public async Task<CreateHaVipResponse> CreateHaVipAsync(CreateHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHaVipWithOptionsAsync(request, runtime);
        }

        public CreateIpsecServerResponse CreateIpsecServerWithOptions(CreateIpsecServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIpsecServerResponse>(DoRPCRequest("CreateIpsecServer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIpsecServerResponse> CreateIpsecServerWithOptionsAsync(CreateIpsecServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIpsecServerResponse>(await DoRPCRequestAsync("CreateIpsecServer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIpsecServerResponse CreateIpsecServer(CreateIpsecServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIpsecServerWithOptions(request, runtime);
        }

        public async Task<CreateIpsecServerResponse> CreateIpsecServerAsync(CreateIpsecServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIpsecServerWithOptionsAsync(request, runtime);
        }

        public CreateIpv6EgressOnlyRuleResponse CreateIpv6EgressOnlyRuleWithOptions(CreateIpv6EgressOnlyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIpv6EgressOnlyRuleResponse>(DoRPCRequest("CreateIpv6EgressOnlyRule", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIpv6EgressOnlyRuleResponse> CreateIpv6EgressOnlyRuleWithOptionsAsync(CreateIpv6EgressOnlyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIpv6EgressOnlyRuleResponse>(await DoRPCRequestAsync("CreateIpv6EgressOnlyRule", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIpv6EgressOnlyRuleResponse CreateIpv6EgressOnlyRule(CreateIpv6EgressOnlyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIpv6EgressOnlyRuleWithOptions(request, runtime);
        }

        public async Task<CreateIpv6EgressOnlyRuleResponse> CreateIpv6EgressOnlyRuleAsync(CreateIpv6EgressOnlyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIpv6EgressOnlyRuleWithOptionsAsync(request, runtime);
        }

        public CreateIpv6GatewayResponse CreateIpv6GatewayWithOptions(CreateIpv6GatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIpv6GatewayResponse>(DoRPCRequest("CreateIpv6Gateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIpv6GatewayResponse> CreateIpv6GatewayWithOptionsAsync(CreateIpv6GatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIpv6GatewayResponse>(await DoRPCRequestAsync("CreateIpv6Gateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIpv6GatewayResponse CreateIpv6Gateway(CreateIpv6GatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIpv6GatewayWithOptions(request, runtime);
        }

        public async Task<CreateIpv6GatewayResponse> CreateIpv6GatewayAsync(CreateIpv6GatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIpv6GatewayWithOptionsAsync(request, runtime);
        }

        public CreateIPv6TranslatorResponse CreateIPv6TranslatorWithOptions(CreateIPv6TranslatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIPv6TranslatorResponse>(DoRPCRequest("CreateIPv6Translator", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIPv6TranslatorResponse> CreateIPv6TranslatorWithOptionsAsync(CreateIPv6TranslatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIPv6TranslatorResponse>(await DoRPCRequestAsync("CreateIPv6Translator", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIPv6TranslatorResponse CreateIPv6Translator(CreateIPv6TranslatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIPv6TranslatorWithOptions(request, runtime);
        }

        public async Task<CreateIPv6TranslatorResponse> CreateIPv6TranslatorAsync(CreateIPv6TranslatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIPv6TranslatorWithOptionsAsync(request, runtime);
        }

        public CreateIPv6TranslatorAclListResponse CreateIPv6TranslatorAclListWithOptions(CreateIPv6TranslatorAclListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIPv6TranslatorAclListResponse>(DoRPCRequest("CreateIPv6TranslatorAclList", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIPv6TranslatorAclListResponse> CreateIPv6TranslatorAclListWithOptionsAsync(CreateIPv6TranslatorAclListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIPv6TranslatorAclListResponse>(await DoRPCRequestAsync("CreateIPv6TranslatorAclList", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIPv6TranslatorAclListResponse CreateIPv6TranslatorAclList(CreateIPv6TranslatorAclListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIPv6TranslatorAclListWithOptions(request, runtime);
        }

        public async Task<CreateIPv6TranslatorAclListResponse> CreateIPv6TranslatorAclListAsync(CreateIPv6TranslatorAclListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIPv6TranslatorAclListWithOptionsAsync(request, runtime);
        }

        public CreateIPv6TranslatorEntryResponse CreateIPv6TranslatorEntryWithOptions(CreateIPv6TranslatorEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIPv6TranslatorEntryResponse>(DoRPCRequest("CreateIPv6TranslatorEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIPv6TranslatorEntryResponse> CreateIPv6TranslatorEntryWithOptionsAsync(CreateIPv6TranslatorEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIPv6TranslatorEntryResponse>(await DoRPCRequestAsync("CreateIPv6TranslatorEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIPv6TranslatorEntryResponse CreateIPv6TranslatorEntry(CreateIPv6TranslatorEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIPv6TranslatorEntryWithOptions(request, runtime);
        }

        public async Task<CreateIPv6TranslatorEntryResponse> CreateIPv6TranslatorEntryAsync(CreateIPv6TranslatorEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIPv6TranslatorEntryWithOptionsAsync(request, runtime);
        }

        public CreateNatGatewayResponse CreateNatGatewayWithOptions(CreateNatGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNatGatewayResponse>(DoRPCRequest("CreateNatGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNatGatewayResponse> CreateNatGatewayWithOptionsAsync(CreateNatGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNatGatewayResponse>(await DoRPCRequestAsync("CreateNatGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNatGatewayResponse CreateNatGateway(CreateNatGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNatGatewayWithOptions(request, runtime);
        }

        public async Task<CreateNatGatewayResponse> CreateNatGatewayAsync(CreateNatGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNatGatewayWithOptionsAsync(request, runtime);
        }

        public CreateNetworkAclResponse CreateNetworkAclWithOptions(CreateNetworkAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNetworkAclResponse>(DoRPCRequest("CreateNetworkAcl", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNetworkAclResponse> CreateNetworkAclWithOptionsAsync(CreateNetworkAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNetworkAclResponse>(await DoRPCRequestAsync("CreateNetworkAcl", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNetworkAclWithOptions(request, runtime);
        }

        public async Task<CreateNetworkAclResponse> CreateNetworkAclAsync(CreateNetworkAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNetworkAclWithOptionsAsync(request, runtime);
        }

        public CreatePhysicalConnectionOccupancyOrderResponse CreatePhysicalConnectionOccupancyOrderWithOptions(CreatePhysicalConnectionOccupancyOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePhysicalConnectionOccupancyOrderResponse>(DoRPCRequest("CreatePhysicalConnectionOccupancyOrder", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePhysicalConnectionOccupancyOrderResponse> CreatePhysicalConnectionOccupancyOrderWithOptionsAsync(CreatePhysicalConnectionOccupancyOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePhysicalConnectionOccupancyOrderResponse>(await DoRPCRequestAsync("CreatePhysicalConnectionOccupancyOrder", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePhysicalConnectionOccupancyOrderResponse CreatePhysicalConnectionOccupancyOrder(CreatePhysicalConnectionOccupancyOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePhysicalConnectionOccupancyOrderWithOptions(request, runtime);
        }

        public async Task<CreatePhysicalConnectionOccupancyOrderResponse> CreatePhysicalConnectionOccupancyOrderAsync(CreatePhysicalConnectionOccupancyOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePhysicalConnectionOccupancyOrderWithOptionsAsync(request, runtime);
        }

        public CreateRouteEntryResponse CreateRouteEntryWithOptions(CreateRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRouteEntryResponse>(DoRPCRequest("CreateRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRouteEntryResponse> CreateRouteEntryWithOptionsAsync(CreateRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRouteEntryResponse>(await DoRPCRequestAsync("CreateRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRouteEntryResponse CreateRouteEntry(CreateRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRouteEntryWithOptions(request, runtime);
        }

        public async Task<CreateRouteEntryResponse> CreateRouteEntryAsync(CreateRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRouteEntryWithOptionsAsync(request, runtime);
        }

        public CreateRouteTableResponse CreateRouteTableWithOptions(CreateRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRouteTableResponse>(DoRPCRequest("CreateRouteTable", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRouteTableResponse> CreateRouteTableWithOptionsAsync(CreateRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRouteTableResponse>(await DoRPCRequestAsync("CreateRouteTable", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRouteTableWithOptions(request, runtime);
        }

        public async Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRouteTableWithOptionsAsync(request, runtime);
        }

        public CreateSnatEntryResponse CreateSnatEntryWithOptions(CreateSnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSnatEntryResponse>(DoRPCRequest("CreateSnatEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSnatEntryResponse> CreateSnatEntryWithOptionsAsync(CreateSnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSnatEntryResponse>(await DoRPCRequestAsync("CreateSnatEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSnatEntryResponse CreateSnatEntry(CreateSnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSnatEntryWithOptions(request, runtime);
        }

        public async Task<CreateSnatEntryResponse> CreateSnatEntryAsync(CreateSnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSnatEntryWithOptionsAsync(request, runtime);
        }

        public CreateSslVpnClientCertResponse CreateSslVpnClientCertWithOptions(CreateSslVpnClientCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSslVpnClientCertResponse>(DoRPCRequest("CreateSslVpnClientCert", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSslVpnClientCertResponse> CreateSslVpnClientCertWithOptionsAsync(CreateSslVpnClientCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSslVpnClientCertResponse>(await DoRPCRequestAsync("CreateSslVpnClientCert", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSslVpnClientCertResponse CreateSslVpnClientCert(CreateSslVpnClientCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSslVpnClientCertWithOptions(request, runtime);
        }

        public async Task<CreateSslVpnClientCertResponse> CreateSslVpnClientCertAsync(CreateSslVpnClientCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSslVpnClientCertWithOptionsAsync(request, runtime);
        }

        public CreateSslVpnServerResponse CreateSslVpnServerWithOptions(CreateSslVpnServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSslVpnServerResponse>(DoRPCRequest("CreateSslVpnServer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSslVpnServerResponse> CreateSslVpnServerWithOptionsAsync(CreateSslVpnServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSslVpnServerResponse>(await DoRPCRequestAsync("CreateSslVpnServer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSslVpnServerResponse CreateSslVpnServer(CreateSslVpnServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSslVpnServerWithOptions(request, runtime);
        }

        public async Task<CreateSslVpnServerResponse> CreateSslVpnServerAsync(CreateSslVpnServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSslVpnServerWithOptionsAsync(request, runtime);
        }

        public CreateVpcResponse CreateVpcWithOptions(CreateVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpcResponse>(DoRPCRequest("CreateVpc", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVpcResponse> CreateVpcWithOptionsAsync(CreateVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpcResponse>(await DoRPCRequestAsync("CreateVpc", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVpcResponse CreateVpc(CreateVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcWithOptions(request, runtime);
        }

        public async Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcWithOptionsAsync(request, runtime);
        }

        public CreateVpnConnectionResponse CreateVpnConnectionWithOptions(CreateVpnConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpnConnectionResponse>(DoRPCRequest("CreateVpnConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVpnConnectionResponse> CreateVpnConnectionWithOptionsAsync(CreateVpnConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpnConnectionResponse>(await DoRPCRequestAsync("CreateVpnConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpnConnectionWithOptions(request, runtime);
        }

        public async Task<CreateVpnConnectionResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpnConnectionWithOptionsAsync(request, runtime);
        }

        public CreateVpnGatewayResponse CreateVpnGatewayWithOptions(CreateVpnGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpnGatewayResponse>(DoRPCRequest("CreateVpnGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVpnGatewayResponse> CreateVpnGatewayWithOptionsAsync(CreateVpnGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpnGatewayResponse>(await DoRPCRequestAsync("CreateVpnGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpnGatewayWithOptions(request, runtime);
        }

        public async Task<CreateVpnGatewayResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpnGatewayWithOptionsAsync(request, runtime);
        }

        public CreateVpnPbrRouteEntryResponse CreateVpnPbrRouteEntryWithOptions(CreateVpnPbrRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpnPbrRouteEntryResponse>(DoRPCRequest("CreateVpnPbrRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVpnPbrRouteEntryResponse> CreateVpnPbrRouteEntryWithOptionsAsync(CreateVpnPbrRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpnPbrRouteEntryResponse>(await DoRPCRequestAsync("CreateVpnPbrRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVpnPbrRouteEntryResponse CreateVpnPbrRouteEntry(CreateVpnPbrRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpnPbrRouteEntryWithOptions(request, runtime);
        }

        public async Task<CreateVpnPbrRouteEntryResponse> CreateVpnPbrRouteEntryAsync(CreateVpnPbrRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpnPbrRouteEntryWithOptionsAsync(request, runtime);
        }

        public CreateVpnRouteEntryResponse CreateVpnRouteEntryWithOptions(CreateVpnRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpnRouteEntryResponse>(DoRPCRequest("CreateVpnRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVpnRouteEntryResponse> CreateVpnRouteEntryWithOptionsAsync(CreateVpnRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpnRouteEntryResponse>(await DoRPCRequestAsync("CreateVpnRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVpnRouteEntryResponse CreateVpnRouteEntry(CreateVpnRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpnRouteEntryWithOptions(request, runtime);
        }

        public async Task<CreateVpnRouteEntryResponse> CreateVpnRouteEntryAsync(CreateVpnRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpnRouteEntryWithOptionsAsync(request, runtime);
        }

        public CreateVSwitchResponse CreateVSwitchWithOptions(CreateVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVSwitchResponse>(DoRPCRequest("CreateVSwitch", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVSwitchResponse> CreateVSwitchWithOptionsAsync(CreateVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVSwitchResponse>(await DoRPCRequestAsync("CreateVSwitch", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVSwitchResponse CreateVSwitch(CreateVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVSwitchWithOptions(request, runtime);
        }

        public async Task<CreateVSwitchResponse> CreateVSwitchAsync(CreateVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVSwitchWithOptionsAsync(request, runtime);
        }

        public DeactivateRouterInterfaceResponse DeactivateRouterInterfaceWithOptions(DeactivateRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactivateRouterInterfaceResponse>(DoRPCRequest("DeactivateRouterInterface", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeactivateRouterInterfaceResponse> DeactivateRouterInterfaceWithOptionsAsync(DeactivateRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactivateRouterInterfaceResponse>(await DoRPCRequestAsync("DeactivateRouterInterface", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeactivateRouterInterfaceResponse DeactivateRouterInterface(DeactivateRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactivateRouterInterfaceWithOptions(request, runtime);
        }

        public async Task<DeactivateRouterInterfaceResponse> DeactivateRouterInterfaceAsync(DeactivateRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactivateRouterInterfaceWithOptionsAsync(request, runtime);
        }

        public DeactiveFlowLogResponse DeactiveFlowLogWithOptions(DeactiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactiveFlowLogResponse>(DoRPCRequest("DeactiveFlowLog", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeactiveFlowLogResponse> DeactiveFlowLogWithOptionsAsync(DeactiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactiveFlowLogResponse>(await DoRPCRequestAsync("DeactiveFlowLog", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeactiveFlowLogResponse DeactiveFlowLog(DeactiveFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactiveFlowLogWithOptions(request, runtime);
        }

        public async Task<DeactiveFlowLogResponse> DeactiveFlowLogAsync(DeactiveFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactiveFlowLogWithOptionsAsync(request, runtime);
        }

        public DeleteBgpGroupResponse DeleteBgpGroupWithOptions(DeleteBgpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBgpGroupResponse>(DoRPCRequest("DeleteBgpGroup", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBgpGroupResponse> DeleteBgpGroupWithOptionsAsync(DeleteBgpGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBgpGroupResponse>(await DoRPCRequestAsync("DeleteBgpGroup", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBgpGroupResponse DeleteBgpGroup(DeleteBgpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBgpGroupWithOptions(request, runtime);
        }

        public async Task<DeleteBgpGroupResponse> DeleteBgpGroupAsync(DeleteBgpGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBgpGroupWithOptionsAsync(request, runtime);
        }

        public DeleteBgpNetworkResponse DeleteBgpNetworkWithOptions(DeleteBgpNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBgpNetworkResponse>(DoRPCRequest("DeleteBgpNetwork", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBgpNetworkResponse> DeleteBgpNetworkWithOptionsAsync(DeleteBgpNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBgpNetworkResponse>(await DoRPCRequestAsync("DeleteBgpNetwork", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBgpNetworkResponse DeleteBgpNetwork(DeleteBgpNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBgpNetworkWithOptions(request, runtime);
        }

        public async Task<DeleteBgpNetworkResponse> DeleteBgpNetworkAsync(DeleteBgpNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBgpNetworkWithOptionsAsync(request, runtime);
        }

        public DeleteBgpPeerResponse DeleteBgpPeerWithOptions(DeleteBgpPeerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBgpPeerResponse>(DoRPCRequest("DeleteBgpPeer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBgpPeerResponse> DeleteBgpPeerWithOptionsAsync(DeleteBgpPeerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBgpPeerResponse>(await DoRPCRequestAsync("DeleteBgpPeer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBgpPeerResponse DeleteBgpPeer(DeleteBgpPeerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBgpPeerWithOptions(request, runtime);
        }

        public async Task<DeleteBgpPeerResponse> DeleteBgpPeerAsync(DeleteBgpPeerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBgpPeerWithOptionsAsync(request, runtime);
        }

        public DeleteCommonBandwidthPackageResponse DeleteCommonBandwidthPackageWithOptions(DeleteCommonBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCommonBandwidthPackageResponse>(DoRPCRequest("DeleteCommonBandwidthPackage", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCommonBandwidthPackageResponse> DeleteCommonBandwidthPackageWithOptionsAsync(DeleteCommonBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCommonBandwidthPackageResponse>(await DoRPCRequestAsync("DeleteCommonBandwidthPackage", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCommonBandwidthPackageResponse DeleteCommonBandwidthPackage(DeleteCommonBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCommonBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<DeleteCommonBandwidthPackageResponse> DeleteCommonBandwidthPackageAsync(DeleteCommonBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCommonBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public DeleteCustomerGatewayResponse DeleteCustomerGatewayWithOptions(DeleteCustomerGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCustomerGatewayResponse>(DoRPCRequest("DeleteCustomerGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayWithOptionsAsync(DeleteCustomerGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCustomerGatewayResponse>(await DoRPCRequestAsync("DeleteCustomerGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomerGatewayWithOptions(request, runtime);
        }

        public async Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayAsync(DeleteCustomerGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomerGatewayWithOptionsAsync(request, runtime);
        }

        public DeleteDhcpOptionsSetResponse DeleteDhcpOptionsSetWithOptions(DeleteDhcpOptionsSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDhcpOptionsSetResponse>(DoRPCRequest("DeleteDhcpOptionsSet", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDhcpOptionsSetResponse> DeleteDhcpOptionsSetWithOptionsAsync(DeleteDhcpOptionsSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDhcpOptionsSetResponse>(await DoRPCRequestAsync("DeleteDhcpOptionsSet", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDhcpOptionsSetResponse DeleteDhcpOptionsSet(DeleteDhcpOptionsSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDhcpOptionsSetWithOptions(request, runtime);
        }

        public async Task<DeleteDhcpOptionsSetResponse> DeleteDhcpOptionsSetAsync(DeleteDhcpOptionsSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDhcpOptionsSetWithOptionsAsync(request, runtime);
        }

        public DeleteExpressCloudConnectionResponse DeleteExpressCloudConnectionWithOptions(DeleteExpressCloudConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExpressCloudConnectionResponse>(DoRPCRequest("DeleteExpressCloudConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteExpressCloudConnectionResponse> DeleteExpressCloudConnectionWithOptionsAsync(DeleteExpressCloudConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExpressCloudConnectionResponse>(await DoRPCRequestAsync("DeleteExpressCloudConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteExpressCloudConnectionResponse DeleteExpressCloudConnection(DeleteExpressCloudConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExpressCloudConnectionWithOptions(request, runtime);
        }

        public async Task<DeleteExpressCloudConnectionResponse> DeleteExpressCloudConnectionAsync(DeleteExpressCloudConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExpressCloudConnectionWithOptionsAsync(request, runtime);
        }

        public DeleteExpressConnectResponse DeleteExpressConnectWithOptions(DeleteExpressConnectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExpressConnectResponse>(DoRPCRequest("DeleteExpressConnect", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteExpressConnectResponse> DeleteExpressConnectWithOptionsAsync(DeleteExpressConnectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExpressConnectResponse>(await DoRPCRequestAsync("DeleteExpressConnect", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteExpressConnectResponse DeleteExpressConnect(DeleteExpressConnectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExpressConnectWithOptions(request, runtime);
        }

        public async Task<DeleteExpressConnectResponse> DeleteExpressConnectAsync(DeleteExpressConnectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExpressConnectWithOptionsAsync(request, runtime);
        }

        public DeleteFlowLogResponse DeleteFlowLogWithOptions(DeleteFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowLogResponse>(DoRPCRequest("DeleteFlowLog", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowLogResponse> DeleteFlowLogWithOptionsAsync(DeleteFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowLogResponse>(await DoRPCRequestAsync("DeleteFlowLog", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlowLogResponse DeleteFlowLog(DeleteFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowLogWithOptions(request, runtime);
        }

        public async Task<DeleteFlowLogResponse> DeleteFlowLogAsync(DeleteFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowLogWithOptionsAsync(request, runtime);
        }

        public DeleteForwardEntryResponse DeleteForwardEntryWithOptions(DeleteForwardEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteForwardEntryResponse>(DoRPCRequest("DeleteForwardEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteForwardEntryResponse> DeleteForwardEntryWithOptionsAsync(DeleteForwardEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteForwardEntryResponse>(await DoRPCRequestAsync("DeleteForwardEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteForwardEntryResponse DeleteForwardEntry(DeleteForwardEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteForwardEntryWithOptions(request, runtime);
        }

        public async Task<DeleteForwardEntryResponse> DeleteForwardEntryAsync(DeleteForwardEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteForwardEntryWithOptionsAsync(request, runtime);
        }

        public DeleteGlobalAccelerationInstanceResponse DeleteGlobalAccelerationInstanceWithOptions(DeleteGlobalAccelerationInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGlobalAccelerationInstanceResponse>(DoRPCRequest("DeleteGlobalAccelerationInstance", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteGlobalAccelerationInstanceResponse> DeleteGlobalAccelerationInstanceWithOptionsAsync(DeleteGlobalAccelerationInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteGlobalAccelerationInstanceResponse>(await DoRPCRequestAsync("DeleteGlobalAccelerationInstance", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteGlobalAccelerationInstanceResponse DeleteGlobalAccelerationInstance(DeleteGlobalAccelerationInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGlobalAccelerationInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteGlobalAccelerationInstanceResponse> DeleteGlobalAccelerationInstanceAsync(DeleteGlobalAccelerationInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGlobalAccelerationInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteHaVipResponse DeleteHaVipWithOptions(DeleteHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHaVipResponse>(DoRPCRequest("DeleteHaVip", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHaVipResponse> DeleteHaVipWithOptionsAsync(DeleteHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHaVipResponse>(await DoRPCRequestAsync("DeleteHaVip", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHaVipResponse DeleteHaVip(DeleteHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHaVipWithOptions(request, runtime);
        }

        public async Task<DeleteHaVipResponse> DeleteHaVipAsync(DeleteHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHaVipWithOptionsAsync(request, runtime);
        }

        public DeleteIpsecServerResponse DeleteIpsecServerWithOptions(DeleteIpsecServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpsecServerResponse>(DoRPCRequest("DeleteIpsecServer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIpsecServerResponse> DeleteIpsecServerWithOptionsAsync(DeleteIpsecServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpsecServerResponse>(await DoRPCRequestAsync("DeleteIpsecServer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIpsecServerResponse DeleteIpsecServer(DeleteIpsecServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpsecServerWithOptions(request, runtime);
        }

        public async Task<DeleteIpsecServerResponse> DeleteIpsecServerAsync(DeleteIpsecServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpsecServerWithOptionsAsync(request, runtime);
        }

        public DeleteIpv6EgressOnlyRuleResponse DeleteIpv6EgressOnlyRuleWithOptions(DeleteIpv6EgressOnlyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpv6EgressOnlyRuleResponse>(DoRPCRequest("DeleteIpv6EgressOnlyRule", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIpv6EgressOnlyRuleResponse> DeleteIpv6EgressOnlyRuleWithOptionsAsync(DeleteIpv6EgressOnlyRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpv6EgressOnlyRuleResponse>(await DoRPCRequestAsync("DeleteIpv6EgressOnlyRule", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIpv6EgressOnlyRuleResponse DeleteIpv6EgressOnlyRule(DeleteIpv6EgressOnlyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpv6EgressOnlyRuleWithOptions(request, runtime);
        }

        public async Task<DeleteIpv6EgressOnlyRuleResponse> DeleteIpv6EgressOnlyRuleAsync(DeleteIpv6EgressOnlyRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpv6EgressOnlyRuleWithOptionsAsync(request, runtime);
        }

        public DeleteIpv6GatewayResponse DeleteIpv6GatewayWithOptions(DeleteIpv6GatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpv6GatewayResponse>(DoRPCRequest("DeleteIpv6Gateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIpv6GatewayResponse> DeleteIpv6GatewayWithOptionsAsync(DeleteIpv6GatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpv6GatewayResponse>(await DoRPCRequestAsync("DeleteIpv6Gateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIpv6GatewayResponse DeleteIpv6Gateway(DeleteIpv6GatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpv6GatewayWithOptions(request, runtime);
        }

        public async Task<DeleteIpv6GatewayResponse> DeleteIpv6GatewayAsync(DeleteIpv6GatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpv6GatewayWithOptionsAsync(request, runtime);
        }

        public DeleteIpv6InternetBandwidthResponse DeleteIpv6InternetBandwidthWithOptions(DeleteIpv6InternetBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpv6InternetBandwidthResponse>(DoRPCRequest("DeleteIpv6InternetBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIpv6InternetBandwidthResponse> DeleteIpv6InternetBandwidthWithOptionsAsync(DeleteIpv6InternetBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpv6InternetBandwidthResponse>(await DoRPCRequestAsync("DeleteIpv6InternetBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIpv6InternetBandwidthResponse DeleteIpv6InternetBandwidth(DeleteIpv6InternetBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpv6InternetBandwidthWithOptions(request, runtime);
        }

        public async Task<DeleteIpv6InternetBandwidthResponse> DeleteIpv6InternetBandwidthAsync(DeleteIpv6InternetBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpv6InternetBandwidthWithOptionsAsync(request, runtime);
        }

        public DeleteIPv6TranslatorResponse DeleteIPv6TranslatorWithOptions(DeleteIPv6TranslatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIPv6TranslatorResponse>(DoRPCRequest("DeleteIPv6Translator", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIPv6TranslatorResponse> DeleteIPv6TranslatorWithOptionsAsync(DeleteIPv6TranslatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIPv6TranslatorResponse>(await DoRPCRequestAsync("DeleteIPv6Translator", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIPv6TranslatorResponse DeleteIPv6Translator(DeleteIPv6TranslatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIPv6TranslatorWithOptions(request, runtime);
        }

        public async Task<DeleteIPv6TranslatorResponse> DeleteIPv6TranslatorAsync(DeleteIPv6TranslatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIPv6TranslatorWithOptionsAsync(request, runtime);
        }

        public DeleteIPv6TranslatorAclListResponse DeleteIPv6TranslatorAclListWithOptions(DeleteIPv6TranslatorAclListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIPv6TranslatorAclListResponse>(DoRPCRequest("DeleteIPv6TranslatorAclList", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIPv6TranslatorAclListResponse> DeleteIPv6TranslatorAclListWithOptionsAsync(DeleteIPv6TranslatorAclListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIPv6TranslatorAclListResponse>(await DoRPCRequestAsync("DeleteIPv6TranslatorAclList", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIPv6TranslatorAclListResponse DeleteIPv6TranslatorAclList(DeleteIPv6TranslatorAclListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIPv6TranslatorAclListWithOptions(request, runtime);
        }

        public async Task<DeleteIPv6TranslatorAclListResponse> DeleteIPv6TranslatorAclListAsync(DeleteIPv6TranslatorAclListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIPv6TranslatorAclListWithOptionsAsync(request, runtime);
        }

        public DeleteIPv6TranslatorEntryResponse DeleteIPv6TranslatorEntryWithOptions(DeleteIPv6TranslatorEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIPv6TranslatorEntryResponse>(DoRPCRequest("DeleteIPv6TranslatorEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIPv6TranslatorEntryResponse> DeleteIPv6TranslatorEntryWithOptionsAsync(DeleteIPv6TranslatorEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIPv6TranslatorEntryResponse>(await DoRPCRequestAsync("DeleteIPv6TranslatorEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIPv6TranslatorEntryResponse DeleteIPv6TranslatorEntry(DeleteIPv6TranslatorEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIPv6TranslatorEntryWithOptions(request, runtime);
        }

        public async Task<DeleteIPv6TranslatorEntryResponse> DeleteIPv6TranslatorEntryAsync(DeleteIPv6TranslatorEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIPv6TranslatorEntryWithOptionsAsync(request, runtime);
        }

        public DeleteNatGatewayResponse DeleteNatGatewayWithOptions(DeleteNatGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNatGatewayResponse>(DoRPCRequest("DeleteNatGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNatGatewayResponse> DeleteNatGatewayWithOptionsAsync(DeleteNatGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNatGatewayResponse>(await DoRPCRequestAsync("DeleteNatGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNatGatewayResponse DeleteNatGateway(DeleteNatGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNatGatewayWithOptions(request, runtime);
        }

        public async Task<DeleteNatGatewayResponse> DeleteNatGatewayAsync(DeleteNatGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNatGatewayWithOptionsAsync(request, runtime);
        }

        public DeleteNetworkAclResponse DeleteNetworkAclWithOptions(DeleteNetworkAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNetworkAclResponse>(DoRPCRequest("DeleteNetworkAcl", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNetworkAclResponse> DeleteNetworkAclWithOptionsAsync(DeleteNetworkAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNetworkAclResponse>(await DoRPCRequestAsync("DeleteNetworkAcl", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetworkAclWithOptions(request, runtime);
        }

        public async Task<DeleteNetworkAclResponse> DeleteNetworkAclAsync(DeleteNetworkAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetworkAclWithOptionsAsync(request, runtime);
        }

        public DeletePhysicalConnectionResponse DeletePhysicalConnectionWithOptions(DeletePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePhysicalConnectionResponse>(DoRPCRequest("DeletePhysicalConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePhysicalConnectionResponse> DeletePhysicalConnectionWithOptionsAsync(DeletePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePhysicalConnectionResponse>(await DoRPCRequestAsync("DeletePhysicalConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePhysicalConnectionResponse DeletePhysicalConnection(DeletePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePhysicalConnectionWithOptions(request, runtime);
        }

        public async Task<DeletePhysicalConnectionResponse> DeletePhysicalConnectionAsync(DeletePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePhysicalConnectionWithOptionsAsync(request, runtime);
        }

        public DeleteRouteEntryResponse DeleteRouteEntryWithOptions(DeleteRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouteEntryResponse>(DoRPCRequest("DeleteRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRouteEntryResponse> DeleteRouteEntryWithOptionsAsync(DeleteRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouteEntryResponse>(await DoRPCRequestAsync("DeleteRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRouteEntryResponse DeleteRouteEntry(DeleteRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRouteEntryWithOptions(request, runtime);
        }

        public async Task<DeleteRouteEntryResponse> DeleteRouteEntryAsync(DeleteRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRouteEntryWithOptionsAsync(request, runtime);
        }

        public DeleteRouterInterfaceResponse DeleteRouterInterfaceWithOptions(DeleteRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouterInterfaceResponse>(DoRPCRequest("DeleteRouterInterface", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRouterInterfaceResponse> DeleteRouterInterfaceWithOptionsAsync(DeleteRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouterInterfaceResponse>(await DoRPCRequestAsync("DeleteRouterInterface", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRouterInterfaceResponse DeleteRouterInterface(DeleteRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRouterInterfaceWithOptions(request, runtime);
        }

        public async Task<DeleteRouterInterfaceResponse> DeleteRouterInterfaceAsync(DeleteRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRouterInterfaceWithOptionsAsync(request, runtime);
        }

        public DeleteRouteTableResponse DeleteRouteTableWithOptions(DeleteRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouteTableResponse>(DoRPCRequest("DeleteRouteTable", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRouteTableResponse> DeleteRouteTableWithOptionsAsync(DeleteRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouteTableResponse>(await DoRPCRequestAsync("DeleteRouteTable", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRouteTableWithOptions(request, runtime);
        }

        public async Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRouteTableWithOptionsAsync(request, runtime);
        }

        public DeleteSnatEntryResponse DeleteSnatEntryWithOptions(DeleteSnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSnatEntryResponse>(DoRPCRequest("DeleteSnatEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSnatEntryResponse> DeleteSnatEntryWithOptionsAsync(DeleteSnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSnatEntryResponse>(await DoRPCRequestAsync("DeleteSnatEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSnatEntryResponse DeleteSnatEntry(DeleteSnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSnatEntryWithOptions(request, runtime);
        }

        public async Task<DeleteSnatEntryResponse> DeleteSnatEntryAsync(DeleteSnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSnatEntryWithOptionsAsync(request, runtime);
        }

        public DeleteSslVpnClientCertResponse DeleteSslVpnClientCertWithOptions(DeleteSslVpnClientCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSslVpnClientCertResponse>(DoRPCRequest("DeleteSslVpnClientCert", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSslVpnClientCertResponse> DeleteSslVpnClientCertWithOptionsAsync(DeleteSslVpnClientCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSslVpnClientCertResponse>(await DoRPCRequestAsync("DeleteSslVpnClientCert", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSslVpnClientCertResponse DeleteSslVpnClientCert(DeleteSslVpnClientCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSslVpnClientCertWithOptions(request, runtime);
        }

        public async Task<DeleteSslVpnClientCertResponse> DeleteSslVpnClientCertAsync(DeleteSslVpnClientCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSslVpnClientCertWithOptionsAsync(request, runtime);
        }

        public DeleteSslVpnServerResponse DeleteSslVpnServerWithOptions(DeleteSslVpnServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSslVpnServerResponse>(DoRPCRequest("DeleteSslVpnServer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSslVpnServerResponse> DeleteSslVpnServerWithOptionsAsync(DeleteSslVpnServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSslVpnServerResponse>(await DoRPCRequestAsync("DeleteSslVpnServer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSslVpnServerResponse DeleteSslVpnServer(DeleteSslVpnServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSslVpnServerWithOptions(request, runtime);
        }

        public async Task<DeleteSslVpnServerResponse> DeleteSslVpnServerAsync(DeleteSslVpnServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSslVpnServerWithOptionsAsync(request, runtime);
        }

        public DeleteVirtualBorderRouterResponse DeleteVirtualBorderRouterWithOptions(DeleteVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVirtualBorderRouterResponse>(DoRPCRequest("DeleteVirtualBorderRouter", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVirtualBorderRouterResponse> DeleteVirtualBorderRouterWithOptionsAsync(DeleteVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVirtualBorderRouterResponse>(await DoRPCRequestAsync("DeleteVirtualBorderRouter", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVirtualBorderRouterResponse DeleteVirtualBorderRouter(DeleteVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVirtualBorderRouterWithOptions(request, runtime);
        }

        public async Task<DeleteVirtualBorderRouterResponse> DeleteVirtualBorderRouterAsync(DeleteVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVirtualBorderRouterWithOptionsAsync(request, runtime);
        }

        public DeleteVpcResponse DeleteVpcWithOptions(DeleteVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpcResponse>(DoRPCRequest("DeleteVpc", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVpcResponse> DeleteVpcWithOptionsAsync(DeleteVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpcResponse>(await DoRPCRequestAsync("DeleteVpc", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcWithOptions(request, runtime);
        }

        public async Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcWithOptionsAsync(request, runtime);
        }

        public DeleteVpnConnectionResponse DeleteVpnConnectionWithOptions(DeleteVpnConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpnConnectionResponse>(DoRPCRequest("DeleteVpnConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVpnConnectionResponse> DeleteVpnConnectionWithOptionsAsync(DeleteVpnConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpnConnectionResponse>(await DoRPCRequestAsync("DeleteVpnConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpnConnectionWithOptions(request, runtime);
        }

        public async Task<DeleteVpnConnectionResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpnConnectionWithOptionsAsync(request, runtime);
        }

        public DeleteVpnGatewayResponse DeleteVpnGatewayWithOptions(DeleteVpnGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpnGatewayResponse>(DoRPCRequest("DeleteVpnGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVpnGatewayResponse> DeleteVpnGatewayWithOptionsAsync(DeleteVpnGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpnGatewayResponse>(await DoRPCRequestAsync("DeleteVpnGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpnGatewayWithOptions(request, runtime);
        }

        public async Task<DeleteVpnGatewayResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpnGatewayWithOptionsAsync(request, runtime);
        }

        public DeleteVpnPbrRouteEntryResponse DeleteVpnPbrRouteEntryWithOptions(DeleteVpnPbrRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpnPbrRouteEntryResponse>(DoRPCRequest("DeleteVpnPbrRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVpnPbrRouteEntryResponse> DeleteVpnPbrRouteEntryWithOptionsAsync(DeleteVpnPbrRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpnPbrRouteEntryResponse>(await DoRPCRequestAsync("DeleteVpnPbrRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVpnPbrRouteEntryResponse DeleteVpnPbrRouteEntry(DeleteVpnPbrRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpnPbrRouteEntryWithOptions(request, runtime);
        }

        public async Task<DeleteVpnPbrRouteEntryResponse> DeleteVpnPbrRouteEntryAsync(DeleteVpnPbrRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpnPbrRouteEntryWithOptionsAsync(request, runtime);
        }

        public DeleteVpnRouteEntryResponse DeleteVpnRouteEntryWithOptions(DeleteVpnRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpnRouteEntryResponse>(DoRPCRequest("DeleteVpnRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVpnRouteEntryResponse> DeleteVpnRouteEntryWithOptionsAsync(DeleteVpnRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpnRouteEntryResponse>(await DoRPCRequestAsync("DeleteVpnRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVpnRouteEntryResponse DeleteVpnRouteEntry(DeleteVpnRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpnRouteEntryWithOptions(request, runtime);
        }

        public async Task<DeleteVpnRouteEntryResponse> DeleteVpnRouteEntryAsync(DeleteVpnRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpnRouteEntryWithOptionsAsync(request, runtime);
        }

        public DeleteVSwitchResponse DeleteVSwitchWithOptions(DeleteVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVSwitchResponse>(DoRPCRequest("DeleteVSwitch", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVSwitchResponse> DeleteVSwitchWithOptionsAsync(DeleteVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVSwitchResponse>(await DoRPCRequestAsync("DeleteVSwitch", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVSwitchResponse DeleteVSwitch(DeleteVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVSwitchWithOptions(request, runtime);
        }

        public async Task<DeleteVSwitchResponse> DeleteVSwitchAsync(DeleteVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVSwitchWithOptionsAsync(request, runtime);
        }

        public DeletionProtectionResponse DeletionProtectionWithOptions(DeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletionProtectionResponse>(DoRPCRequest("DeletionProtection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletionProtectionResponse> DeletionProtectionWithOptionsAsync(DeletionProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletionProtectionResponse>(await DoRPCRequestAsync("DeletionProtection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletionProtectionResponse DeletionProtection(DeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletionProtectionWithOptions(request, runtime);
        }

        public async Task<DeletionProtectionResponse> DeletionProtectionAsync(DeletionProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletionProtectionWithOptionsAsync(request, runtime);
        }

        public DescribeAccessPointsResponse DescribeAccessPointsWithOptions(DescribeAccessPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccessPointsResponse>(DoRPCRequest("DescribeAccessPoints", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccessPointsResponse> DescribeAccessPointsWithOptionsAsync(DescribeAccessPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccessPointsResponse>(await DoRPCRequestAsync("DescribeAccessPoints", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccessPointsResponse DescribeAccessPoints(DescribeAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessPointsWithOptions(request, runtime);
        }

        public async Task<DescribeAccessPointsResponse> DescribeAccessPointsAsync(DescribeAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessPointsWithOptionsAsync(request, runtime);
        }

        public DescribeBgpGroupsResponse DescribeBgpGroupsWithOptions(DescribeBgpGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBgpGroupsResponse>(DoRPCRequest("DescribeBgpGroups", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBgpGroupsResponse> DescribeBgpGroupsWithOptionsAsync(DescribeBgpGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBgpGroupsResponse>(await DoRPCRequestAsync("DescribeBgpGroups", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBgpGroupsResponse DescribeBgpGroups(DescribeBgpGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBgpGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeBgpGroupsResponse> DescribeBgpGroupsAsync(DescribeBgpGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBgpGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeBgpNetworksResponse DescribeBgpNetworksWithOptions(DescribeBgpNetworksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBgpNetworksResponse>(DoRPCRequest("DescribeBgpNetworks", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBgpNetworksResponse> DescribeBgpNetworksWithOptionsAsync(DescribeBgpNetworksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBgpNetworksResponse>(await DoRPCRequestAsync("DescribeBgpNetworks", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBgpNetworksResponse DescribeBgpNetworks(DescribeBgpNetworksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBgpNetworksWithOptions(request, runtime);
        }

        public async Task<DescribeBgpNetworksResponse> DescribeBgpNetworksAsync(DescribeBgpNetworksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBgpNetworksWithOptionsAsync(request, runtime);
        }

        public DescribeBgpPeersResponse DescribeBgpPeersWithOptions(DescribeBgpPeersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBgpPeersResponse>(DoRPCRequest("DescribeBgpPeers", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBgpPeersResponse> DescribeBgpPeersWithOptionsAsync(DescribeBgpPeersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBgpPeersResponse>(await DoRPCRequestAsync("DescribeBgpPeers", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBgpPeersResponse DescribeBgpPeers(DescribeBgpPeersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBgpPeersWithOptions(request, runtime);
        }

        public async Task<DescribeBgpPeersResponse> DescribeBgpPeersAsync(DescribeBgpPeersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBgpPeersWithOptionsAsync(request, runtime);
        }

        public DescribeCommonBandwidthPackagesResponse DescribeCommonBandwidthPackagesWithOptions(DescribeCommonBandwidthPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCommonBandwidthPackagesResponse>(DoRPCRequest("DescribeCommonBandwidthPackages", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCommonBandwidthPackagesResponse> DescribeCommonBandwidthPackagesWithOptionsAsync(DescribeCommonBandwidthPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCommonBandwidthPackagesResponse>(await DoRPCRequestAsync("DescribeCommonBandwidthPackages", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCommonBandwidthPackagesResponse DescribeCommonBandwidthPackages(DescribeCommonBandwidthPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCommonBandwidthPackagesWithOptions(request, runtime);
        }

        public async Task<DescribeCommonBandwidthPackagesResponse> DescribeCommonBandwidthPackagesAsync(DescribeCommonBandwidthPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCommonBandwidthPackagesWithOptionsAsync(request, runtime);
        }

        public DescribeCustomerGatewayResponse DescribeCustomerGatewayWithOptions(DescribeCustomerGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomerGatewayResponse>(DoRPCRequest("DescribeCustomerGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCustomerGatewayResponse> DescribeCustomerGatewayWithOptionsAsync(DescribeCustomerGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomerGatewayResponse>(await DoRPCRequestAsync("DescribeCustomerGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCustomerGatewayResponse DescribeCustomerGateway(DescribeCustomerGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomerGatewayWithOptions(request, runtime);
        }

        public async Task<DescribeCustomerGatewayResponse> DescribeCustomerGatewayAsync(DescribeCustomerGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomerGatewayWithOptionsAsync(request, runtime);
        }

        public DescribeCustomerGatewaysResponse DescribeCustomerGatewaysWithOptions(DescribeCustomerGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomerGatewaysResponse>(DoRPCRequest("DescribeCustomerGateways", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysWithOptionsAsync(DescribeCustomerGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCustomerGatewaysResponse>(await DoRPCRequestAsync("DescribeCustomerGateways", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCustomerGatewaysWithOptions(request, runtime);
        }

        public async Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(DescribeCustomerGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCustomerGatewaysWithOptionsAsync(request, runtime);
        }

        public DescribeEipAddressesResponse DescribeEipAddressesWithOptions(DescribeEipAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipAddressesResponse>(DoRPCRequest("DescribeEipAddresses", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEipAddressesResponse> DescribeEipAddressesWithOptionsAsync(DescribeEipAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipAddressesResponse>(await DoRPCRequestAsync("DescribeEipAddresses", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEipAddressesResponse DescribeEipAddresses(DescribeEipAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEipAddressesWithOptions(request, runtime);
        }

        public async Task<DescribeEipAddressesResponse> DescribeEipAddressesAsync(DescribeEipAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEipAddressesWithOptionsAsync(request, runtime);
        }

        public DescribeEipGatewayInfoResponse DescribeEipGatewayInfoWithOptions(DescribeEipGatewayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipGatewayInfoResponse>(DoRPCRequest("DescribeEipGatewayInfo", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEipGatewayInfoResponse> DescribeEipGatewayInfoWithOptionsAsync(DescribeEipGatewayInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipGatewayInfoResponse>(await DoRPCRequestAsync("DescribeEipGatewayInfo", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEipGatewayInfoResponse DescribeEipGatewayInfo(DescribeEipGatewayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEipGatewayInfoWithOptions(request, runtime);
        }

        public async Task<DescribeEipGatewayInfoResponse> DescribeEipGatewayInfoAsync(DescribeEipGatewayInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEipGatewayInfoWithOptionsAsync(request, runtime);
        }

        public DescribeEipMonitorDataResponse DescribeEipMonitorDataWithOptions(DescribeEipMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipMonitorDataResponse>(DoRPCRequest("DescribeEipMonitorData", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEipMonitorDataResponse> DescribeEipMonitorDataWithOptionsAsync(DescribeEipMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipMonitorDataResponse>(await DoRPCRequestAsync("DescribeEipMonitorData", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEipMonitorDataResponse DescribeEipMonitorData(DescribeEipMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEipMonitorDataWithOptions(request, runtime);
        }

        public async Task<DescribeEipMonitorDataResponse> DescribeEipMonitorDataAsync(DescribeEipMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEipMonitorDataWithOptionsAsync(request, runtime);
        }

        public DescribeEipSegmentResponse DescribeEipSegmentWithOptions(DescribeEipSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipSegmentResponse>(DoRPCRequest("DescribeEipSegment", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEipSegmentResponse> DescribeEipSegmentWithOptionsAsync(DescribeEipSegmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipSegmentResponse>(await DoRPCRequestAsync("DescribeEipSegment", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEipSegmentResponse DescribeEipSegment(DescribeEipSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEipSegmentWithOptions(request, runtime);
        }

        public async Task<DescribeEipSegmentResponse> DescribeEipSegmentAsync(DescribeEipSegmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEipSegmentWithOptionsAsync(request, runtime);
        }

        public DescribeExpressCloudConnectionsResponse DescribeExpressCloudConnectionsWithOptions(DescribeExpressCloudConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExpressCloudConnectionsResponse>(DoRPCRequest("DescribeExpressCloudConnections", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExpressCloudConnectionsResponse> DescribeExpressCloudConnectionsWithOptionsAsync(DescribeExpressCloudConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExpressCloudConnectionsResponse>(await DoRPCRequestAsync("DescribeExpressCloudConnections", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExpressCloudConnectionsResponse DescribeExpressCloudConnections(DescribeExpressCloudConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExpressCloudConnectionsWithOptions(request, runtime);
        }

        public async Task<DescribeExpressCloudConnectionsResponse> DescribeExpressCloudConnectionsAsync(DescribeExpressCloudConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExpressCloudConnectionsWithOptionsAsync(request, runtime);
        }

        public DescribeFlowLogsResponse DescribeFlowLogsWithOptions(DescribeFlowLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowLogsResponse>(DoRPCRequest("DescribeFlowLogs", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowLogsResponse> DescribeFlowLogsWithOptionsAsync(DescribeFlowLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowLogsResponse>(await DoRPCRequestAsync("DescribeFlowLogs", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowLogsResponse DescribeFlowLogs(DescribeFlowLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowLogsWithOptions(request, runtime);
        }

        public async Task<DescribeFlowLogsResponse> DescribeFlowLogsAsync(DescribeFlowLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowLogsWithOptionsAsync(request, runtime);
        }

        public DescribeForwardTableEntriesResponse DescribeForwardTableEntriesWithOptions(DescribeForwardTableEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeForwardTableEntriesResponse>(DoRPCRequest("DescribeForwardTableEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeForwardTableEntriesResponse> DescribeForwardTableEntriesWithOptionsAsync(DescribeForwardTableEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeForwardTableEntriesResponse>(await DoRPCRequestAsync("DescribeForwardTableEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeForwardTableEntriesResponse DescribeForwardTableEntries(DescribeForwardTableEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeForwardTableEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeForwardTableEntriesResponse> DescribeForwardTableEntriesAsync(DescribeForwardTableEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeForwardTableEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeGlobalAccelerationInstancesResponse DescribeGlobalAccelerationInstancesWithOptions(DescribeGlobalAccelerationInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGlobalAccelerationInstancesResponse>(DoRPCRequest("DescribeGlobalAccelerationInstances", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGlobalAccelerationInstancesResponse> DescribeGlobalAccelerationInstancesWithOptionsAsync(DescribeGlobalAccelerationInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGlobalAccelerationInstancesResponse>(await DoRPCRequestAsync("DescribeGlobalAccelerationInstances", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGlobalAccelerationInstancesResponse DescribeGlobalAccelerationInstances(DescribeGlobalAccelerationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGlobalAccelerationInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeGlobalAccelerationInstancesResponse> DescribeGlobalAccelerationInstancesAsync(DescribeGlobalAccelerationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGlobalAccelerationInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeGrantRulesToCenResponse DescribeGrantRulesToCenWithOptions(DescribeGrantRulesToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGrantRulesToCenResponse>(DoRPCRequest("DescribeGrantRulesToCen", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGrantRulesToCenResponse> DescribeGrantRulesToCenWithOptionsAsync(DescribeGrantRulesToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGrantRulesToCenResponse>(await DoRPCRequestAsync("DescribeGrantRulesToCen", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGrantRulesToCenResponse DescribeGrantRulesToCen(DescribeGrantRulesToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGrantRulesToCenWithOptions(request, runtime);
        }

        public async Task<DescribeGrantRulesToCenResponse> DescribeGrantRulesToCenAsync(DescribeGrantRulesToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGrantRulesToCenWithOptionsAsync(request, runtime);
        }

        public DescribeHaVipsResponse DescribeHaVipsWithOptions(DescribeHaVipsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHaVipsResponse>(DoRPCRequest("DescribeHaVips", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHaVipsResponse> DescribeHaVipsWithOptionsAsync(DescribeHaVipsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHaVipsResponse>(await DoRPCRequestAsync("DescribeHaVips", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHaVipsResponse DescribeHaVips(DescribeHaVipsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHaVipsWithOptions(request, runtime);
        }

        public async Task<DescribeHaVipsResponse> DescribeHaVipsAsync(DescribeHaVipsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHaVipsWithOptionsAsync(request, runtime);
        }

        public DescribeHighDefinitionMonitorLogAttributeResponse DescribeHighDefinitionMonitorLogAttributeWithOptions(DescribeHighDefinitionMonitorLogAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHighDefinitionMonitorLogAttributeResponse>(DoRPCRequest("DescribeHighDefinitionMonitorLogAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHighDefinitionMonitorLogAttributeResponse> DescribeHighDefinitionMonitorLogAttributeWithOptionsAsync(DescribeHighDefinitionMonitorLogAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHighDefinitionMonitorLogAttributeResponse>(await DoRPCRequestAsync("DescribeHighDefinitionMonitorLogAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHighDefinitionMonitorLogAttributeResponse DescribeHighDefinitionMonitorLogAttribute(DescribeHighDefinitionMonitorLogAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHighDefinitionMonitorLogAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeHighDefinitionMonitorLogAttributeResponse> DescribeHighDefinitionMonitorLogAttributeAsync(DescribeHighDefinitionMonitorLogAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHighDefinitionMonitorLogAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAutoRenewAttributeResponse DescribeInstanceAutoRenewAttributeWithOptions(DescribeInstanceAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewAttributeResponse>(DoRPCRequest("DescribeInstanceAutoRenewAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceAutoRenewAttributeResponse> DescribeInstanceAutoRenewAttributeWithOptionsAsync(DescribeInstanceAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewAttributeResponse>(await DoRPCRequestAsync("DescribeInstanceAutoRenewAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceAutoRenewAttributeResponse DescribeInstanceAutoRenewAttribute(DescribeInstanceAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAutoRenewAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAutoRenewAttributeResponse> DescribeInstanceAutoRenewAttributeAsync(DescribeInstanceAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAutoRenewAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeIpv6AddressesResponse DescribeIpv6AddressesWithOptions(DescribeIpv6AddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpv6AddressesResponse>(DoRPCRequest("DescribeIpv6Addresses", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpv6AddressesResponse> DescribeIpv6AddressesWithOptionsAsync(DescribeIpv6AddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpv6AddressesResponse>(await DoRPCRequestAsync("DescribeIpv6Addresses", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpv6AddressesResponse DescribeIpv6Addresses(DescribeIpv6AddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpv6AddressesWithOptions(request, runtime);
        }

        public async Task<DescribeIpv6AddressesResponse> DescribeIpv6AddressesAsync(DescribeIpv6AddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpv6AddressesWithOptionsAsync(request, runtime);
        }

        public DescribeIpv6EgressOnlyRulesResponse DescribeIpv6EgressOnlyRulesWithOptions(DescribeIpv6EgressOnlyRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpv6EgressOnlyRulesResponse>(DoRPCRequest("DescribeIpv6EgressOnlyRules", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpv6EgressOnlyRulesResponse> DescribeIpv6EgressOnlyRulesWithOptionsAsync(DescribeIpv6EgressOnlyRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpv6EgressOnlyRulesResponse>(await DoRPCRequestAsync("DescribeIpv6EgressOnlyRules", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpv6EgressOnlyRulesResponse DescribeIpv6EgressOnlyRules(DescribeIpv6EgressOnlyRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpv6EgressOnlyRulesWithOptions(request, runtime);
        }

        public async Task<DescribeIpv6EgressOnlyRulesResponse> DescribeIpv6EgressOnlyRulesAsync(DescribeIpv6EgressOnlyRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpv6EgressOnlyRulesWithOptionsAsync(request, runtime);
        }

        public DescribeIpv6GatewayAttributeResponse DescribeIpv6GatewayAttributeWithOptions(DescribeIpv6GatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpv6GatewayAttributeResponse>(DoRPCRequest("DescribeIpv6GatewayAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpv6GatewayAttributeResponse> DescribeIpv6GatewayAttributeWithOptionsAsync(DescribeIpv6GatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpv6GatewayAttributeResponse>(await DoRPCRequestAsync("DescribeIpv6GatewayAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpv6GatewayAttributeResponse DescribeIpv6GatewayAttribute(DescribeIpv6GatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpv6GatewayAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeIpv6GatewayAttributeResponse> DescribeIpv6GatewayAttributeAsync(DescribeIpv6GatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpv6GatewayAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeIpv6GatewaysResponse DescribeIpv6GatewaysWithOptions(DescribeIpv6GatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpv6GatewaysResponse>(DoRPCRequest("DescribeIpv6Gateways", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpv6GatewaysResponse> DescribeIpv6GatewaysWithOptionsAsync(DescribeIpv6GatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpv6GatewaysResponse>(await DoRPCRequestAsync("DescribeIpv6Gateways", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpv6GatewaysResponse DescribeIpv6Gateways(DescribeIpv6GatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpv6GatewaysWithOptions(request, runtime);
        }

        public async Task<DescribeIpv6GatewaysResponse> DescribeIpv6GatewaysAsync(DescribeIpv6GatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpv6GatewaysWithOptionsAsync(request, runtime);
        }

        public DescribeIPv6TranslatorAclListAttributesResponse DescribeIPv6TranslatorAclListAttributesWithOptions(DescribeIPv6TranslatorAclListAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIPv6TranslatorAclListAttributesResponse>(DoRPCRequest("DescribeIPv6TranslatorAclListAttributes", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIPv6TranslatorAclListAttributesResponse> DescribeIPv6TranslatorAclListAttributesWithOptionsAsync(DescribeIPv6TranslatorAclListAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIPv6TranslatorAclListAttributesResponse>(await DoRPCRequestAsync("DescribeIPv6TranslatorAclListAttributes", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIPv6TranslatorAclListAttributesResponse DescribeIPv6TranslatorAclListAttributes(DescribeIPv6TranslatorAclListAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIPv6TranslatorAclListAttributesWithOptions(request, runtime);
        }

        public async Task<DescribeIPv6TranslatorAclListAttributesResponse> DescribeIPv6TranslatorAclListAttributesAsync(DescribeIPv6TranslatorAclListAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIPv6TranslatorAclListAttributesWithOptionsAsync(request, runtime);
        }

        public DescribeIPv6TranslatorAclListsResponse DescribeIPv6TranslatorAclListsWithOptions(DescribeIPv6TranslatorAclListsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIPv6TranslatorAclListsResponse>(DoRPCRequest("DescribeIPv6TranslatorAclLists", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIPv6TranslatorAclListsResponse> DescribeIPv6TranslatorAclListsWithOptionsAsync(DescribeIPv6TranslatorAclListsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIPv6TranslatorAclListsResponse>(await DoRPCRequestAsync("DescribeIPv6TranslatorAclLists", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIPv6TranslatorAclListsResponse DescribeIPv6TranslatorAclLists(DescribeIPv6TranslatorAclListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIPv6TranslatorAclListsWithOptions(request, runtime);
        }

        public async Task<DescribeIPv6TranslatorAclListsResponse> DescribeIPv6TranslatorAclListsAsync(DescribeIPv6TranslatorAclListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIPv6TranslatorAclListsWithOptionsAsync(request, runtime);
        }

        public DescribeIPv6TranslatorEntriesResponse DescribeIPv6TranslatorEntriesWithOptions(DescribeIPv6TranslatorEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIPv6TranslatorEntriesResponse>(DoRPCRequest("DescribeIPv6TranslatorEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIPv6TranslatorEntriesResponse> DescribeIPv6TranslatorEntriesWithOptionsAsync(DescribeIPv6TranslatorEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIPv6TranslatorEntriesResponse>(await DoRPCRequestAsync("DescribeIPv6TranslatorEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIPv6TranslatorEntriesResponse DescribeIPv6TranslatorEntries(DescribeIPv6TranslatorEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIPv6TranslatorEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeIPv6TranslatorEntriesResponse> DescribeIPv6TranslatorEntriesAsync(DescribeIPv6TranslatorEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIPv6TranslatorEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeIPv6TranslatorsResponse DescribeIPv6TranslatorsWithOptions(DescribeIPv6TranslatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIPv6TranslatorsResponse>(DoRPCRequest("DescribeIPv6Translators", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIPv6TranslatorsResponse> DescribeIPv6TranslatorsWithOptionsAsync(DescribeIPv6TranslatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIPv6TranslatorsResponse>(await DoRPCRequestAsync("DescribeIPv6Translators", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIPv6TranslatorsResponse DescribeIPv6Translators(DescribeIPv6TranslatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIPv6TranslatorsWithOptions(request, runtime);
        }

        public async Task<DescribeIPv6TranslatorsResponse> DescribeIPv6TranslatorsAsync(DescribeIPv6TranslatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIPv6TranslatorsWithOptionsAsync(request, runtime);
        }

        public DescribeNatGatewaysResponse DescribeNatGatewaysWithOptions(DescribeNatGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNatGatewaysResponse>(DoRPCRequest("DescribeNatGateways", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNatGatewaysResponse> DescribeNatGatewaysWithOptionsAsync(DescribeNatGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNatGatewaysResponse>(await DoRPCRequestAsync("DescribeNatGateways", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNatGatewaysResponse DescribeNatGateways(DescribeNatGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNatGatewaysWithOptions(request, runtime);
        }

        public async Task<DescribeNatGatewaysResponse> DescribeNatGatewaysAsync(DescribeNatGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNatGatewaysWithOptionsAsync(request, runtime);
        }

        public DescribeNetworkAclAttributesResponse DescribeNetworkAclAttributesWithOptions(DescribeNetworkAclAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkAclAttributesResponse>(DoRPCRequest("DescribeNetworkAclAttributes", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNetworkAclAttributesResponse> DescribeNetworkAclAttributesWithOptionsAsync(DescribeNetworkAclAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkAclAttributesResponse>(await DoRPCRequestAsync("DescribeNetworkAclAttributes", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNetworkAclAttributesResponse DescribeNetworkAclAttributes(DescribeNetworkAclAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkAclAttributesWithOptions(request, runtime);
        }

        public async Task<DescribeNetworkAclAttributesResponse> DescribeNetworkAclAttributesAsync(DescribeNetworkAclAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkAclAttributesWithOptionsAsync(request, runtime);
        }

        public DescribeNetworkAclsResponse DescribeNetworkAclsWithOptions(DescribeNetworkAclsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkAclsResponse>(DoRPCRequest("DescribeNetworkAcls", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNetworkAclsResponse> DescribeNetworkAclsWithOptionsAsync(DescribeNetworkAclsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkAclsResponse>(await DoRPCRequestAsync("DescribeNetworkAcls", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkAclsWithOptions(request, runtime);
        }

        public async Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(DescribeNetworkAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkAclsWithOptionsAsync(request, runtime);
        }

        public DescribeNewProjectEipMonitorDataResponse DescribeNewProjectEipMonitorDataWithOptions(DescribeNewProjectEipMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNewProjectEipMonitorDataResponse>(DoRPCRequest("DescribeNewProjectEipMonitorData", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNewProjectEipMonitorDataResponse> DescribeNewProjectEipMonitorDataWithOptionsAsync(DescribeNewProjectEipMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNewProjectEipMonitorDataResponse>(await DoRPCRequestAsync("DescribeNewProjectEipMonitorData", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNewProjectEipMonitorDataResponse DescribeNewProjectEipMonitorData(DescribeNewProjectEipMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNewProjectEipMonitorDataWithOptions(request, runtime);
        }

        public async Task<DescribeNewProjectEipMonitorDataResponse> DescribeNewProjectEipMonitorDataAsync(DescribeNewProjectEipMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNewProjectEipMonitorDataWithOptionsAsync(request, runtime);
        }

        public DescribePhysicalConnectionLOAResponse DescribePhysicalConnectionLOAWithOptions(DescribePhysicalConnectionLOARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePhysicalConnectionLOAResponse>(DoRPCRequest("DescribePhysicalConnectionLOA", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePhysicalConnectionLOAResponse> DescribePhysicalConnectionLOAWithOptionsAsync(DescribePhysicalConnectionLOARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePhysicalConnectionLOAResponse>(await DoRPCRequestAsync("DescribePhysicalConnectionLOA", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePhysicalConnectionLOAResponse DescribePhysicalConnectionLOA(DescribePhysicalConnectionLOARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhysicalConnectionLOAWithOptions(request, runtime);
        }

        public async Task<DescribePhysicalConnectionLOAResponse> DescribePhysicalConnectionLOAAsync(DescribePhysicalConnectionLOARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhysicalConnectionLOAWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeRouteEntryListResponse DescribeRouteEntryListWithOptions(DescribeRouteEntryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteEntryListResponse>(DoRPCRequest("DescribeRouteEntryList", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRouteEntryListResponse> DescribeRouteEntryListWithOptionsAsync(DescribeRouteEntryListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteEntryListResponse>(await DoRPCRequestAsync("DescribeRouteEntryList", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRouteEntryListResponse DescribeRouteEntryList(DescribeRouteEntryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRouteEntryListWithOptions(request, runtime);
        }

        public async Task<DescribeRouteEntryListResponse> DescribeRouteEntryListAsync(DescribeRouteEntryListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRouteEntryListWithOptionsAsync(request, runtime);
        }

        public DescribeRouterInterfaceAttributeResponse DescribeRouterInterfaceAttributeWithOptions(DescribeRouterInterfaceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouterInterfaceAttributeResponse>(DoRPCRequest("DescribeRouterInterfaceAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRouterInterfaceAttributeResponse> DescribeRouterInterfaceAttributeWithOptionsAsync(DescribeRouterInterfaceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouterInterfaceAttributeResponse>(await DoRPCRequestAsync("DescribeRouterInterfaceAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRouterInterfaceAttributeResponse DescribeRouterInterfaceAttribute(DescribeRouterInterfaceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRouterInterfaceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeRouterInterfaceAttributeResponse> DescribeRouterInterfaceAttributeAsync(DescribeRouterInterfaceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRouterInterfaceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeRouterInterfacesResponse DescribeRouterInterfacesWithOptions(DescribeRouterInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouterInterfacesResponse>(DoRPCRequest("DescribeRouterInterfaces", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRouterInterfacesResponse> DescribeRouterInterfacesWithOptionsAsync(DescribeRouterInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouterInterfacesResponse>(await DoRPCRequestAsync("DescribeRouterInterfaces", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRouterInterfacesResponse DescribeRouterInterfaces(DescribeRouterInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRouterInterfacesWithOptions(request, runtime);
        }

        public async Task<DescribeRouterInterfacesResponse> DescribeRouterInterfacesAsync(DescribeRouterInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRouterInterfacesWithOptionsAsync(request, runtime);
        }

        public DescribeRouteTableListResponse DescribeRouteTableListWithOptions(DescribeRouteTableListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteTableListResponse>(DoRPCRequest("DescribeRouteTableList", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRouteTableListResponse> DescribeRouteTableListWithOptionsAsync(DescribeRouteTableListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteTableListResponse>(await DoRPCRequestAsync("DescribeRouteTableList", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRouteTableListResponse DescribeRouteTableList(DescribeRouteTableListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRouteTableListWithOptions(request, runtime);
        }

        public async Task<DescribeRouteTableListResponse> DescribeRouteTableListAsync(DescribeRouteTableListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRouteTableListWithOptionsAsync(request, runtime);
        }

        public DescribeRouteTablesResponse DescribeRouteTablesWithOptions(DescribeRouteTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteTablesResponse>(DoRPCRequest("DescribeRouteTables", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRouteTablesResponse> DescribeRouteTablesWithOptionsAsync(DescribeRouteTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteTablesResponse>(await DoRPCRequestAsync("DescribeRouteTables", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRouteTablesWithOptions(request, runtime);
        }

        public async Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRouteTablesWithOptionsAsync(request, runtime);
        }

        public DescribeServerRelatedGlobalAccelerationInstancesResponse DescribeServerRelatedGlobalAccelerationInstancesWithOptions(DescribeServerRelatedGlobalAccelerationInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServerRelatedGlobalAccelerationInstancesResponse>(DoRPCRequest("DescribeServerRelatedGlobalAccelerationInstances", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeServerRelatedGlobalAccelerationInstancesResponse> DescribeServerRelatedGlobalAccelerationInstancesWithOptionsAsync(DescribeServerRelatedGlobalAccelerationInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServerRelatedGlobalAccelerationInstancesResponse>(await DoRPCRequestAsync("DescribeServerRelatedGlobalAccelerationInstances", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeServerRelatedGlobalAccelerationInstancesResponse DescribeServerRelatedGlobalAccelerationInstances(DescribeServerRelatedGlobalAccelerationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServerRelatedGlobalAccelerationInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeServerRelatedGlobalAccelerationInstancesResponse> DescribeServerRelatedGlobalAccelerationInstancesAsync(DescribeServerRelatedGlobalAccelerationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServerRelatedGlobalAccelerationInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeSnatTableEntriesResponse DescribeSnatTableEntriesWithOptions(DescribeSnatTableEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnatTableEntriesResponse>(DoRPCRequest("DescribeSnatTableEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSnatTableEntriesResponse> DescribeSnatTableEntriesWithOptionsAsync(DescribeSnatTableEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnatTableEntriesResponse>(await DoRPCRequestAsync("DescribeSnatTableEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSnatTableEntriesResponse DescribeSnatTableEntries(DescribeSnatTableEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSnatTableEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeSnatTableEntriesResponse> DescribeSnatTableEntriesAsync(DescribeSnatTableEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSnatTableEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeSslVpnClientCertResponse DescribeSslVpnClientCertWithOptions(DescribeSslVpnClientCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSslVpnClientCertResponse>(DoRPCRequest("DescribeSslVpnClientCert", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSslVpnClientCertResponse> DescribeSslVpnClientCertWithOptionsAsync(DescribeSslVpnClientCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSslVpnClientCertResponse>(await DoRPCRequestAsync("DescribeSslVpnClientCert", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSslVpnClientCertResponse DescribeSslVpnClientCert(DescribeSslVpnClientCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSslVpnClientCertWithOptions(request, runtime);
        }

        public async Task<DescribeSslVpnClientCertResponse> DescribeSslVpnClientCertAsync(DescribeSslVpnClientCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSslVpnClientCertWithOptionsAsync(request, runtime);
        }

        public DescribeSslVpnClientCertsResponse DescribeSslVpnClientCertsWithOptions(DescribeSslVpnClientCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSslVpnClientCertsResponse>(DoRPCRequest("DescribeSslVpnClientCerts", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSslVpnClientCertsResponse> DescribeSslVpnClientCertsWithOptionsAsync(DescribeSslVpnClientCertsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSslVpnClientCertsResponse>(await DoRPCRequestAsync("DescribeSslVpnClientCerts", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSslVpnClientCertsResponse DescribeSslVpnClientCerts(DescribeSslVpnClientCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSslVpnClientCertsWithOptions(request, runtime);
        }

        public async Task<DescribeSslVpnClientCertsResponse> DescribeSslVpnClientCertsAsync(DescribeSslVpnClientCertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSslVpnClientCertsWithOptionsAsync(request, runtime);
        }

        public DescribeSslVpnServersResponse DescribeSslVpnServersWithOptions(DescribeSslVpnServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSslVpnServersResponse>(DoRPCRequest("DescribeSslVpnServers", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSslVpnServersResponse> DescribeSslVpnServersWithOptionsAsync(DescribeSslVpnServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSslVpnServersResponse>(await DoRPCRequestAsync("DescribeSslVpnServers", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSslVpnServersResponse DescribeSslVpnServers(DescribeSslVpnServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSslVpnServersWithOptions(request, runtime);
        }

        public async Task<DescribeSslVpnServersResponse> DescribeSslVpnServersAsync(DescribeSslVpnServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSslVpnServersWithOptionsAsync(request, runtime);
        }

        public DescribeVirtualBorderRoutersResponse DescribeVirtualBorderRoutersWithOptions(DescribeVirtualBorderRoutersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVirtualBorderRoutersResponse>(DoRPCRequest("DescribeVirtualBorderRouters", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVirtualBorderRoutersResponse> DescribeVirtualBorderRoutersWithOptionsAsync(DescribeVirtualBorderRoutersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVirtualBorderRoutersResponse>(await DoRPCRequestAsync("DescribeVirtualBorderRouters", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVirtualBorderRoutersResponse DescribeVirtualBorderRouters(DescribeVirtualBorderRoutersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVirtualBorderRoutersWithOptions(request, runtime);
        }

        public async Task<DescribeVirtualBorderRoutersResponse> DescribeVirtualBorderRoutersAsync(DescribeVirtualBorderRoutersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVirtualBorderRoutersWithOptionsAsync(request, runtime);
        }

        public DescribeVirtualBorderRoutersForPhysicalConnectionResponse DescribeVirtualBorderRoutersForPhysicalConnectionWithOptions(DescribeVirtualBorderRoutersForPhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVirtualBorderRoutersForPhysicalConnectionResponse>(DoRPCRequest("DescribeVirtualBorderRoutersForPhysicalConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVirtualBorderRoutersForPhysicalConnectionResponse> DescribeVirtualBorderRoutersForPhysicalConnectionWithOptionsAsync(DescribeVirtualBorderRoutersForPhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVirtualBorderRoutersForPhysicalConnectionResponse>(await DoRPCRequestAsync("DescribeVirtualBorderRoutersForPhysicalConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVirtualBorderRoutersForPhysicalConnectionResponse DescribeVirtualBorderRoutersForPhysicalConnection(DescribeVirtualBorderRoutersForPhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVirtualBorderRoutersForPhysicalConnectionWithOptions(request, runtime);
        }

        public async Task<DescribeVirtualBorderRoutersForPhysicalConnectionResponse> DescribeVirtualBorderRoutersForPhysicalConnectionAsync(DescribeVirtualBorderRoutersForPhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVirtualBorderRoutersForPhysicalConnectionWithOptionsAsync(request, runtime);
        }

        public DescribeVpcAttributeResponse DescribeVpcAttributeWithOptions(DescribeVpcAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcAttributeResponse>(DoRPCRequest("DescribeVpcAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpcAttributeResponse> DescribeVpcAttributeWithOptionsAsync(DescribeVpcAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcAttributeResponse>(await DoRPCRequestAsync("DescribeVpcAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeVpcAttributeResponse> DescribeVpcAttributeAsync(DescribeVpcAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeVpcsResponse DescribeVpcsWithOptions(DescribeVpcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcsResponse>(DoRPCRequest("DescribeVpcs", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpcsResponse> DescribeVpcsWithOptionsAsync(DescribeVpcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcsResponse>(await DoRPCRequestAsync("DescribeVpcs", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcsWithOptions(request, runtime);
        }

        public async Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcsWithOptionsAsync(request, runtime);
        }

        public DescribeVpnConnectionResponse DescribeVpnConnectionWithOptions(DescribeVpnConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnConnectionResponse>(DoRPCRequest("DescribeVpnConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpnConnectionResponse> DescribeVpnConnectionWithOptionsAsync(DescribeVpnConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnConnectionResponse>(await DoRPCRequestAsync("DescribeVpnConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpnConnectionResponse DescribeVpnConnection(DescribeVpnConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpnConnectionWithOptions(request, runtime);
        }

        public async Task<DescribeVpnConnectionResponse> DescribeVpnConnectionAsync(DescribeVpnConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpnConnectionWithOptionsAsync(request, runtime);
        }

        public DescribeVpnConnectionsResponse DescribeVpnConnectionsWithOptions(DescribeVpnConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnConnectionsResponse>(DoRPCRequest("DescribeVpnConnections", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsWithOptionsAsync(DescribeVpnConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnConnectionsResponse>(await DoRPCRequestAsync("DescribeVpnConnections", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpnConnectionsWithOptions(request, runtime);
        }

        public async Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(DescribeVpnConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpnConnectionsWithOptionsAsync(request, runtime);
        }

        public DescribeVpnGatewayResponse DescribeVpnGatewayWithOptions(DescribeVpnGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnGatewayResponse>(DoRPCRequest("DescribeVpnGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpnGatewayResponse> DescribeVpnGatewayWithOptionsAsync(DescribeVpnGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnGatewayResponse>(await DoRPCRequestAsync("DescribeVpnGateway", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpnGatewayResponse DescribeVpnGateway(DescribeVpnGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpnGatewayWithOptions(request, runtime);
        }

        public async Task<DescribeVpnGatewayResponse> DescribeVpnGatewayAsync(DescribeVpnGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpnGatewayWithOptionsAsync(request, runtime);
        }

        public DescribeVpnGatewaysResponse DescribeVpnGatewaysWithOptions(DescribeVpnGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnGatewaysResponse>(DoRPCRequest("DescribeVpnGateways", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysWithOptionsAsync(DescribeVpnGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnGatewaysResponse>(await DoRPCRequestAsync("DescribeVpnGateways", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpnGatewaysWithOptions(request, runtime);
        }

        public async Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(DescribeVpnGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpnGatewaysWithOptionsAsync(request, runtime);
        }

        public DescribeVpnPbrRouteEntriesResponse DescribeVpnPbrRouteEntriesWithOptions(DescribeVpnPbrRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnPbrRouteEntriesResponse>(DoRPCRequest("DescribeVpnPbrRouteEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpnPbrRouteEntriesResponse> DescribeVpnPbrRouteEntriesWithOptionsAsync(DescribeVpnPbrRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnPbrRouteEntriesResponse>(await DoRPCRequestAsync("DescribeVpnPbrRouteEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpnPbrRouteEntriesResponse DescribeVpnPbrRouteEntries(DescribeVpnPbrRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpnPbrRouteEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeVpnPbrRouteEntriesResponse> DescribeVpnPbrRouteEntriesAsync(DescribeVpnPbrRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpnPbrRouteEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeVpnRouteEntriesResponse DescribeVpnRouteEntriesWithOptions(DescribeVpnRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnRouteEntriesResponse>(DoRPCRequest("DescribeVpnRouteEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpnRouteEntriesResponse> DescribeVpnRouteEntriesWithOptionsAsync(DescribeVpnRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnRouteEntriesResponse>(await DoRPCRequestAsync("DescribeVpnRouteEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpnRouteEntriesResponse DescribeVpnRouteEntries(DescribeVpnRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpnRouteEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeVpnRouteEntriesResponse> DescribeVpnRouteEntriesAsync(DescribeVpnRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpnRouteEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeVpnSslServerLogsResponse DescribeVpnSslServerLogsWithOptions(DescribeVpnSslServerLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnSslServerLogsResponse>(DoRPCRequest("DescribeVpnSslServerLogs", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpnSslServerLogsResponse> DescribeVpnSslServerLogsWithOptionsAsync(DescribeVpnSslServerLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpnSslServerLogsResponse>(await DoRPCRequestAsync("DescribeVpnSslServerLogs", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpnSslServerLogsResponse DescribeVpnSslServerLogs(DescribeVpnSslServerLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpnSslServerLogsWithOptions(request, runtime);
        }

        public async Task<DescribeVpnSslServerLogsResponse> DescribeVpnSslServerLogsAsync(DescribeVpnSslServerLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpnSslServerLogsWithOptionsAsync(request, runtime);
        }

        public DescribeVRoutersResponse DescribeVRoutersWithOptions(DescribeVRoutersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVRoutersResponse>(DoRPCRequest("DescribeVRouters", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVRoutersResponse> DescribeVRoutersWithOptionsAsync(DescribeVRoutersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVRoutersResponse>(await DoRPCRequestAsync("DescribeVRouters", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVRoutersResponse DescribeVRouters(DescribeVRoutersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVRoutersWithOptions(request, runtime);
        }

        public async Task<DescribeVRoutersResponse> DescribeVRoutersAsync(DescribeVRoutersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVRoutersWithOptionsAsync(request, runtime);
        }

        public DescribeVSwitchAttributesResponse DescribeVSwitchAttributesWithOptions(DescribeVSwitchAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVSwitchAttributesResponse>(DoRPCRequest("DescribeVSwitchAttributes", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVSwitchAttributesResponse> DescribeVSwitchAttributesWithOptionsAsync(DescribeVSwitchAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVSwitchAttributesResponse>(await DoRPCRequestAsync("DescribeVSwitchAttributes", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVSwitchAttributesResponse DescribeVSwitchAttributes(DescribeVSwitchAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVSwitchAttributesWithOptions(request, runtime);
        }

        public async Task<DescribeVSwitchAttributesResponse> DescribeVSwitchAttributesAsync(DescribeVSwitchAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVSwitchAttributesWithOptionsAsync(request, runtime);
        }

        public DescribeVSwitchesResponse DescribeVSwitchesWithOptions(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVSwitchesResponse>(DoRPCRequest("DescribeVSwitches", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVSwitchesResponse> DescribeVSwitchesWithOptionsAsync(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVSwitchesResponse>(await DoRPCRequestAsync("DescribeVSwitches", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVSwitchesResponse DescribeVSwitches(DescribeVSwitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVSwitchesWithOptions(request, runtime);
        }

        public async Task<DescribeVSwitchesResponse> DescribeVSwitchesAsync(DescribeVSwitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVSwitchesWithOptionsAsync(request, runtime);
        }

        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(DoRPCRequest("DescribeZones", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await DoRPCRequestAsync("DescribeZones", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        public DetachDhcpOptionsSetFromVpcResponse DetachDhcpOptionsSetFromVpcWithOptions(DetachDhcpOptionsSetFromVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachDhcpOptionsSetFromVpcResponse>(DoRPCRequest("DetachDhcpOptionsSetFromVpc", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachDhcpOptionsSetFromVpcResponse> DetachDhcpOptionsSetFromVpcWithOptionsAsync(DetachDhcpOptionsSetFromVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachDhcpOptionsSetFromVpcResponse>(await DoRPCRequestAsync("DetachDhcpOptionsSetFromVpc", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachDhcpOptionsSetFromVpcResponse DetachDhcpOptionsSetFromVpc(DetachDhcpOptionsSetFromVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachDhcpOptionsSetFromVpcWithOptions(request, runtime);
        }

        public async Task<DetachDhcpOptionsSetFromVpcResponse> DetachDhcpOptionsSetFromVpcAsync(DetachDhcpOptionsSetFromVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachDhcpOptionsSetFromVpcWithOptionsAsync(request, runtime);
        }

        public DisableNatGatewayEcsMetricResponse DisableNatGatewayEcsMetricWithOptions(DisableNatGatewayEcsMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableNatGatewayEcsMetricResponse>(DoRPCRequest("DisableNatGatewayEcsMetric", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableNatGatewayEcsMetricResponse> DisableNatGatewayEcsMetricWithOptionsAsync(DisableNatGatewayEcsMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableNatGatewayEcsMetricResponse>(await DoRPCRequestAsync("DisableNatGatewayEcsMetric", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableNatGatewayEcsMetricResponse DisableNatGatewayEcsMetric(DisableNatGatewayEcsMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableNatGatewayEcsMetricWithOptions(request, runtime);
        }

        public async Task<DisableNatGatewayEcsMetricResponse> DisableNatGatewayEcsMetricAsync(DisableNatGatewayEcsMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableNatGatewayEcsMetricWithOptionsAsync(request, runtime);
        }

        public DisableVpcClassicLinkResponse DisableVpcClassicLinkWithOptions(DisableVpcClassicLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableVpcClassicLinkResponse>(DoRPCRequest("DisableVpcClassicLink", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableVpcClassicLinkResponse> DisableVpcClassicLinkWithOptionsAsync(DisableVpcClassicLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableVpcClassicLinkResponse>(await DoRPCRequestAsync("DisableVpcClassicLink", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableVpcClassicLinkResponse DisableVpcClassicLink(DisableVpcClassicLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableVpcClassicLinkWithOptions(request, runtime);
        }

        public async Task<DisableVpcClassicLinkResponse> DisableVpcClassicLinkAsync(DisableVpcClassicLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableVpcClassicLinkWithOptionsAsync(request, runtime);
        }

        public DissociateVpnGatewayWithCertificateResponse DissociateVpnGatewayWithCertificateWithOptions(DissociateVpnGatewayWithCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DissociateVpnGatewayWithCertificateResponse>(DoRPCRequest("DissociateVpnGatewayWithCertificate", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DissociateVpnGatewayWithCertificateResponse> DissociateVpnGatewayWithCertificateWithOptionsAsync(DissociateVpnGatewayWithCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DissociateVpnGatewayWithCertificateResponse>(await DoRPCRequestAsync("DissociateVpnGatewayWithCertificate", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DissociateVpnGatewayWithCertificateResponse DissociateVpnGatewayWithCertificate(DissociateVpnGatewayWithCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DissociateVpnGatewayWithCertificateWithOptions(request, runtime);
        }

        public async Task<DissociateVpnGatewayWithCertificateResponse> DissociateVpnGatewayWithCertificateAsync(DissociateVpnGatewayWithCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DissociateVpnGatewayWithCertificateWithOptionsAsync(request, runtime);
        }

        public DownloadVpnConnectionConfigResponse DownloadVpnConnectionConfigWithOptions(DownloadVpnConnectionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadVpnConnectionConfigResponse>(DoRPCRequest("DownloadVpnConnectionConfig", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DownloadVpnConnectionConfigResponse> DownloadVpnConnectionConfigWithOptionsAsync(DownloadVpnConnectionConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DownloadVpnConnectionConfigResponse>(await DoRPCRequestAsync("DownloadVpnConnectionConfig", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DownloadVpnConnectionConfigResponse DownloadVpnConnectionConfig(DownloadVpnConnectionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DownloadVpnConnectionConfigWithOptions(request, runtime);
        }

        public async Task<DownloadVpnConnectionConfigResponse> DownloadVpnConnectionConfigAsync(DownloadVpnConnectionConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DownloadVpnConnectionConfigWithOptionsAsync(request, runtime);
        }

        public EnableNatGatewayEcsMetricResponse EnableNatGatewayEcsMetricWithOptions(EnableNatGatewayEcsMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableNatGatewayEcsMetricResponse>(DoRPCRequest("EnableNatGatewayEcsMetric", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableNatGatewayEcsMetricResponse> EnableNatGatewayEcsMetricWithOptionsAsync(EnableNatGatewayEcsMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableNatGatewayEcsMetricResponse>(await DoRPCRequestAsync("EnableNatGatewayEcsMetric", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableNatGatewayEcsMetricResponse EnableNatGatewayEcsMetric(EnableNatGatewayEcsMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableNatGatewayEcsMetricWithOptions(request, runtime);
        }

        public async Task<EnableNatGatewayEcsMetricResponse> EnableNatGatewayEcsMetricAsync(EnableNatGatewayEcsMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableNatGatewayEcsMetricWithOptionsAsync(request, runtime);
        }

        public EnablePhysicalConnectionResponse EnablePhysicalConnectionWithOptions(EnablePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnablePhysicalConnectionResponse>(DoRPCRequest("EnablePhysicalConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnablePhysicalConnectionResponse> EnablePhysicalConnectionWithOptionsAsync(EnablePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnablePhysicalConnectionResponse>(await DoRPCRequestAsync("EnablePhysicalConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnablePhysicalConnectionResponse EnablePhysicalConnection(EnablePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnablePhysicalConnectionWithOptions(request, runtime);
        }

        public async Task<EnablePhysicalConnectionResponse> EnablePhysicalConnectionAsync(EnablePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnablePhysicalConnectionWithOptionsAsync(request, runtime);
        }

        public EnableVpcClassicLinkResponse EnableVpcClassicLinkWithOptions(EnableVpcClassicLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableVpcClassicLinkResponse>(DoRPCRequest("EnableVpcClassicLink", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableVpcClassicLinkResponse> EnableVpcClassicLinkWithOptionsAsync(EnableVpcClassicLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableVpcClassicLinkResponse>(await DoRPCRequestAsync("EnableVpcClassicLink", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableVpcClassicLinkResponse EnableVpcClassicLink(EnableVpcClassicLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableVpcClassicLinkWithOptions(request, runtime);
        }

        public async Task<EnableVpcClassicLinkResponse> EnableVpcClassicLinkAsync(EnableVpcClassicLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableVpcClassicLinkWithOptionsAsync(request, runtime);
        }

        public GetDhcpOptionsSetResponse GetDhcpOptionsSetWithOptions(GetDhcpOptionsSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDhcpOptionsSetResponse>(DoRPCRequest("GetDhcpOptionsSet", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDhcpOptionsSetResponse> GetDhcpOptionsSetWithOptionsAsync(GetDhcpOptionsSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDhcpOptionsSetResponse>(await DoRPCRequestAsync("GetDhcpOptionsSet", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDhcpOptionsSetResponse GetDhcpOptionsSet(GetDhcpOptionsSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDhcpOptionsSetWithOptions(request, runtime);
        }

        public async Task<GetDhcpOptionsSetResponse> GetDhcpOptionsSetAsync(GetDhcpOptionsSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDhcpOptionsSetWithOptionsAsync(request, runtime);
        }

        public GetNatGatewayAttributeResponse GetNatGatewayAttributeWithOptions(GetNatGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNatGatewayAttributeResponse>(DoRPCRequest("GetNatGatewayAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNatGatewayAttributeResponse> GetNatGatewayAttributeWithOptionsAsync(GetNatGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNatGatewayAttributeResponse>(await DoRPCRequestAsync("GetNatGatewayAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNatGatewayAttributeResponse GetNatGatewayAttribute(GetNatGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNatGatewayAttributeWithOptions(request, runtime);
        }

        public async Task<GetNatGatewayAttributeResponse> GetNatGatewayAttributeAsync(GetNatGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNatGatewayAttributeWithOptionsAsync(request, runtime);
        }

        public GetNatGatewayConvertStatusResponse GetNatGatewayConvertStatusWithOptions(GetNatGatewayConvertStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNatGatewayConvertStatusResponse>(DoRPCRequest("GetNatGatewayConvertStatus", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNatGatewayConvertStatusResponse> GetNatGatewayConvertStatusWithOptionsAsync(GetNatGatewayConvertStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNatGatewayConvertStatusResponse>(await DoRPCRequestAsync("GetNatGatewayConvertStatus", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNatGatewayConvertStatusResponse GetNatGatewayConvertStatus(GetNatGatewayConvertStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNatGatewayConvertStatusWithOptions(request, runtime);
        }

        public async Task<GetNatGatewayConvertStatusResponse> GetNatGatewayConvertStatusAsync(GetNatGatewayConvertStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNatGatewayConvertStatusWithOptionsAsync(request, runtime);
        }

        public GrantInstanceToCenResponse GrantInstanceToCenWithOptions(GrantInstanceToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantInstanceToCenResponse>(DoRPCRequest("GrantInstanceToCen", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GrantInstanceToCenResponse> GrantInstanceToCenWithOptionsAsync(GrantInstanceToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantInstanceToCenResponse>(await DoRPCRequestAsync("GrantInstanceToCen", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GrantInstanceToCenResponse GrantInstanceToCen(GrantInstanceToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantInstanceToCenWithOptions(request, runtime);
        }

        public async Task<GrantInstanceToCenResponse> GrantInstanceToCenAsync(GrantInstanceToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantInstanceToCenWithOptionsAsync(request, runtime);
        }

        public ListDhcpOptionsSetsResponse ListDhcpOptionsSetsWithOptions(ListDhcpOptionsSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDhcpOptionsSetsResponse>(DoRPCRequest("ListDhcpOptionsSets", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDhcpOptionsSetsResponse> ListDhcpOptionsSetsWithOptionsAsync(ListDhcpOptionsSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDhcpOptionsSetsResponse>(await DoRPCRequestAsync("ListDhcpOptionsSets", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDhcpOptionsSetsResponse ListDhcpOptionsSets(ListDhcpOptionsSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDhcpOptionsSetsWithOptions(request, runtime);
        }

        public async Task<ListDhcpOptionsSetsResponse> ListDhcpOptionsSetsAsync(ListDhcpOptionsSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDhcpOptionsSetsWithOptionsAsync(request, runtime);
        }

        public ListEnhanhcedNatGatewayAvailableZonesResponse ListEnhanhcedNatGatewayAvailableZonesWithOptions(ListEnhanhcedNatGatewayAvailableZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEnhanhcedNatGatewayAvailableZonesResponse>(DoRPCRequest("ListEnhanhcedNatGatewayAvailableZones", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListEnhanhcedNatGatewayAvailableZonesResponse> ListEnhanhcedNatGatewayAvailableZonesWithOptionsAsync(ListEnhanhcedNatGatewayAvailableZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEnhanhcedNatGatewayAvailableZonesResponse>(await DoRPCRequestAsync("ListEnhanhcedNatGatewayAvailableZones", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListEnhanhcedNatGatewayAvailableZonesResponse ListEnhanhcedNatGatewayAvailableZones(ListEnhanhcedNatGatewayAvailableZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnhanhcedNatGatewayAvailableZonesWithOptions(request, runtime);
        }

        public async Task<ListEnhanhcedNatGatewayAvailableZonesResponse> ListEnhanhcedNatGatewayAvailableZonesAsync(ListEnhanhcedNatGatewayAvailableZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnhanhcedNatGatewayAvailableZonesWithOptionsAsync(request, runtime);
        }

        public ListIpsecServersResponse ListIpsecServersWithOptions(ListIpsecServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIpsecServersResponse>(DoRPCRequest("ListIpsecServers", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListIpsecServersResponse> ListIpsecServersWithOptionsAsync(ListIpsecServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIpsecServersResponse>(await DoRPCRequestAsync("ListIpsecServers", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListIpsecServersResponse ListIpsecServers(ListIpsecServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIpsecServersWithOptions(request, runtime);
        }

        public async Task<ListIpsecServersResponse> ListIpsecServersAsync(ListIpsecServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIpsecServersWithOptionsAsync(request, runtime);
        }

        public ListNatGatewayEcsMetricResponse ListNatGatewayEcsMetricWithOptions(ListNatGatewayEcsMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNatGatewayEcsMetricResponse>(DoRPCRequest("ListNatGatewayEcsMetric", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNatGatewayEcsMetricResponse> ListNatGatewayEcsMetricWithOptionsAsync(ListNatGatewayEcsMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNatGatewayEcsMetricResponse>(await DoRPCRequestAsync("ListNatGatewayEcsMetric", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNatGatewayEcsMetricResponse ListNatGatewayEcsMetric(ListNatGatewayEcsMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNatGatewayEcsMetricWithOptions(request, runtime);
        }

        public async Task<ListNatGatewayEcsMetricResponse> ListNatGatewayEcsMetricAsync(ListNatGatewayEcsMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNatGatewayEcsMetricWithOptionsAsync(request, runtime);
        }

        public ListPhysicalConnectionFeaturesResponse ListPhysicalConnectionFeaturesWithOptions(ListPhysicalConnectionFeaturesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhysicalConnectionFeaturesResponse>(DoRPCRequest("ListPhysicalConnectionFeatures", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPhysicalConnectionFeaturesResponse> ListPhysicalConnectionFeaturesWithOptionsAsync(ListPhysicalConnectionFeaturesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPhysicalConnectionFeaturesResponse>(await DoRPCRequestAsync("ListPhysicalConnectionFeatures", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPhysicalConnectionFeaturesResponse ListPhysicalConnectionFeatures(ListPhysicalConnectionFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPhysicalConnectionFeaturesWithOptions(request, runtime);
        }

        public async Task<ListPhysicalConnectionFeaturesResponse> ListPhysicalConnectionFeaturesAsync(ListPhysicalConnectionFeaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPhysicalConnectionFeaturesWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListVpnCertificateAssociationsResponse ListVpnCertificateAssociationsWithOptions(ListVpnCertificateAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVpnCertificateAssociationsResponse>(DoRPCRequest("ListVpnCertificateAssociations", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVpnCertificateAssociationsResponse> ListVpnCertificateAssociationsWithOptionsAsync(ListVpnCertificateAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVpnCertificateAssociationsResponse>(await DoRPCRequestAsync("ListVpnCertificateAssociations", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVpnCertificateAssociationsResponse ListVpnCertificateAssociations(ListVpnCertificateAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpnCertificateAssociationsWithOptions(request, runtime);
        }

        public async Task<ListVpnCertificateAssociationsResponse> ListVpnCertificateAssociationsAsync(ListVpnCertificateAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpnCertificateAssociationsWithOptionsAsync(request, runtime);
        }

        public ModifyBgpGroupAttributeResponse ModifyBgpGroupAttributeWithOptions(ModifyBgpGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBgpGroupAttributeResponse>(DoRPCRequest("ModifyBgpGroupAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBgpGroupAttributeResponse> ModifyBgpGroupAttributeWithOptionsAsync(ModifyBgpGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBgpGroupAttributeResponse>(await DoRPCRequestAsync("ModifyBgpGroupAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBgpGroupAttributeResponse ModifyBgpGroupAttribute(ModifyBgpGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBgpGroupAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyBgpGroupAttributeResponse> ModifyBgpGroupAttributeAsync(ModifyBgpGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBgpGroupAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyBgpPeerAttributeResponse ModifyBgpPeerAttributeWithOptions(ModifyBgpPeerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBgpPeerAttributeResponse>(DoRPCRequest("ModifyBgpPeerAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBgpPeerAttributeResponse> ModifyBgpPeerAttributeWithOptionsAsync(ModifyBgpPeerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBgpPeerAttributeResponse>(await DoRPCRequestAsync("ModifyBgpPeerAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBgpPeerAttributeResponse ModifyBgpPeerAttribute(ModifyBgpPeerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBgpPeerAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyBgpPeerAttributeResponse> ModifyBgpPeerAttributeAsync(ModifyBgpPeerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBgpPeerAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyCommonBandwidthPackageAttributeResponse ModifyCommonBandwidthPackageAttributeWithOptions(ModifyCommonBandwidthPackageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCommonBandwidthPackageAttributeResponse>(DoRPCRequest("ModifyCommonBandwidthPackageAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCommonBandwidthPackageAttributeResponse> ModifyCommonBandwidthPackageAttributeWithOptionsAsync(ModifyCommonBandwidthPackageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCommonBandwidthPackageAttributeResponse>(await DoRPCRequestAsync("ModifyCommonBandwidthPackageAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCommonBandwidthPackageAttributeResponse ModifyCommonBandwidthPackageAttribute(ModifyCommonBandwidthPackageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCommonBandwidthPackageAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyCommonBandwidthPackageAttributeResponse> ModifyCommonBandwidthPackageAttributeAsync(ModifyCommonBandwidthPackageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCommonBandwidthPackageAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyCommonBandwidthPackageInternetChargeTypeResponse ModifyCommonBandwidthPackageInternetChargeTypeWithOptions(ModifyCommonBandwidthPackageInternetChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCommonBandwidthPackageInternetChargeTypeResponse>(DoRPCRequest("ModifyCommonBandwidthPackageInternetChargeType", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCommonBandwidthPackageInternetChargeTypeResponse> ModifyCommonBandwidthPackageInternetChargeTypeWithOptionsAsync(ModifyCommonBandwidthPackageInternetChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCommonBandwidthPackageInternetChargeTypeResponse>(await DoRPCRequestAsync("ModifyCommonBandwidthPackageInternetChargeType", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCommonBandwidthPackageInternetChargeTypeResponse ModifyCommonBandwidthPackageInternetChargeType(ModifyCommonBandwidthPackageInternetChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCommonBandwidthPackageInternetChargeTypeWithOptions(request, runtime);
        }

        public async Task<ModifyCommonBandwidthPackageInternetChargeTypeResponse> ModifyCommonBandwidthPackageInternetChargeTypeAsync(ModifyCommonBandwidthPackageInternetChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCommonBandwidthPackageInternetChargeTypeWithOptionsAsync(request, runtime);
        }

        public ModifyCommonBandwidthPackageIpBandwidthResponse ModifyCommonBandwidthPackageIpBandwidthWithOptions(ModifyCommonBandwidthPackageIpBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCommonBandwidthPackageIpBandwidthResponse>(DoRPCRequest("ModifyCommonBandwidthPackageIpBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCommonBandwidthPackageIpBandwidthResponse> ModifyCommonBandwidthPackageIpBandwidthWithOptionsAsync(ModifyCommonBandwidthPackageIpBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCommonBandwidthPackageIpBandwidthResponse>(await DoRPCRequestAsync("ModifyCommonBandwidthPackageIpBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCommonBandwidthPackageIpBandwidthResponse ModifyCommonBandwidthPackageIpBandwidth(ModifyCommonBandwidthPackageIpBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCommonBandwidthPackageIpBandwidthWithOptions(request, runtime);
        }

        public async Task<ModifyCommonBandwidthPackageIpBandwidthResponse> ModifyCommonBandwidthPackageIpBandwidthAsync(ModifyCommonBandwidthPackageIpBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCommonBandwidthPackageIpBandwidthWithOptionsAsync(request, runtime);
        }

        public ModifyCommonBandwidthPackagePayTypeResponse ModifyCommonBandwidthPackagePayTypeWithOptions(ModifyCommonBandwidthPackagePayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCommonBandwidthPackagePayTypeResponse>(DoRPCRequest("ModifyCommonBandwidthPackagePayType", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCommonBandwidthPackagePayTypeResponse> ModifyCommonBandwidthPackagePayTypeWithOptionsAsync(ModifyCommonBandwidthPackagePayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCommonBandwidthPackagePayTypeResponse>(await DoRPCRequestAsync("ModifyCommonBandwidthPackagePayType", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCommonBandwidthPackagePayTypeResponse ModifyCommonBandwidthPackagePayType(ModifyCommonBandwidthPackagePayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCommonBandwidthPackagePayTypeWithOptions(request, runtime);
        }

        public async Task<ModifyCommonBandwidthPackagePayTypeResponse> ModifyCommonBandwidthPackagePayTypeAsync(ModifyCommonBandwidthPackagePayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCommonBandwidthPackagePayTypeWithOptionsAsync(request, runtime);
        }

        public ModifyCommonBandwidthPackageSpecResponse ModifyCommonBandwidthPackageSpecWithOptions(ModifyCommonBandwidthPackageSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCommonBandwidthPackageSpecResponse>(DoRPCRequest("ModifyCommonBandwidthPackageSpec", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCommonBandwidthPackageSpecResponse> ModifyCommonBandwidthPackageSpecWithOptionsAsync(ModifyCommonBandwidthPackageSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCommonBandwidthPackageSpecResponse>(await DoRPCRequestAsync("ModifyCommonBandwidthPackageSpec", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCommonBandwidthPackageSpecResponse ModifyCommonBandwidthPackageSpec(ModifyCommonBandwidthPackageSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCommonBandwidthPackageSpecWithOptions(request, runtime);
        }

        public async Task<ModifyCommonBandwidthPackageSpecResponse> ModifyCommonBandwidthPackageSpecAsync(ModifyCommonBandwidthPackageSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCommonBandwidthPackageSpecWithOptionsAsync(request, runtime);
        }

        public ModifyCustomerGatewayAttributeResponse ModifyCustomerGatewayAttributeWithOptions(ModifyCustomerGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCustomerGatewayAttributeResponse>(DoRPCRequest("ModifyCustomerGatewayAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCustomerGatewayAttributeResponse> ModifyCustomerGatewayAttributeWithOptionsAsync(ModifyCustomerGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCustomerGatewayAttributeResponse>(await DoRPCRequestAsync("ModifyCustomerGatewayAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCustomerGatewayAttributeResponse ModifyCustomerGatewayAttribute(ModifyCustomerGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCustomerGatewayAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyCustomerGatewayAttributeResponse> ModifyCustomerGatewayAttributeAsync(ModifyCustomerGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCustomerGatewayAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyEipAddressAttributeResponse ModifyEipAddressAttributeWithOptions(ModifyEipAddressAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEipAddressAttributeResponse>(DoRPCRequest("ModifyEipAddressAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyEipAddressAttributeResponse> ModifyEipAddressAttributeWithOptionsAsync(ModifyEipAddressAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEipAddressAttributeResponse>(await DoRPCRequestAsync("ModifyEipAddressAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyEipAddressAttributeResponse ModifyEipAddressAttribute(ModifyEipAddressAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEipAddressAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyEipAddressAttributeResponse> ModifyEipAddressAttributeAsync(ModifyEipAddressAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEipAddressAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyExpressCloudConnectionAttributeResponse ModifyExpressCloudConnectionAttributeWithOptions(ModifyExpressCloudConnectionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyExpressCloudConnectionAttributeResponse>(DoRPCRequest("ModifyExpressCloudConnectionAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyExpressCloudConnectionAttributeResponse> ModifyExpressCloudConnectionAttributeWithOptionsAsync(ModifyExpressCloudConnectionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyExpressCloudConnectionAttributeResponse>(await DoRPCRequestAsync("ModifyExpressCloudConnectionAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyExpressCloudConnectionAttributeResponse ModifyExpressCloudConnectionAttribute(ModifyExpressCloudConnectionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyExpressCloudConnectionAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyExpressCloudConnectionAttributeResponse> ModifyExpressCloudConnectionAttributeAsync(ModifyExpressCloudConnectionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyExpressCloudConnectionAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyExpressCloudConnectionBandwidthResponse ModifyExpressCloudConnectionBandwidthWithOptions(ModifyExpressCloudConnectionBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyExpressCloudConnectionBandwidthResponse>(DoRPCRequest("ModifyExpressCloudConnectionBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyExpressCloudConnectionBandwidthResponse> ModifyExpressCloudConnectionBandwidthWithOptionsAsync(ModifyExpressCloudConnectionBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyExpressCloudConnectionBandwidthResponse>(await DoRPCRequestAsync("ModifyExpressCloudConnectionBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyExpressCloudConnectionBandwidthResponse ModifyExpressCloudConnectionBandwidth(ModifyExpressCloudConnectionBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyExpressCloudConnectionBandwidthWithOptions(request, runtime);
        }

        public async Task<ModifyExpressCloudConnectionBandwidthResponse> ModifyExpressCloudConnectionBandwidthAsync(ModifyExpressCloudConnectionBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyExpressCloudConnectionBandwidthWithOptionsAsync(request, runtime);
        }

        public ModifyFlowLogAttributeResponse ModifyFlowLogAttributeWithOptions(ModifyFlowLogAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowLogAttributeResponse>(DoRPCRequest("ModifyFlowLogAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttributeWithOptionsAsync(ModifyFlowLogAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowLogAttributeResponse>(await DoRPCRequestAsync("ModifyFlowLogAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyFlowLogAttributeResponse ModifyFlowLogAttribute(ModifyFlowLogAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowLogAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttributeAsync(ModifyFlowLogAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowLogAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyForwardEntryResponse ModifyForwardEntryWithOptions(ModifyForwardEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyForwardEntryResponse>(DoRPCRequest("ModifyForwardEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyForwardEntryResponse> ModifyForwardEntryWithOptionsAsync(ModifyForwardEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyForwardEntryResponse>(await DoRPCRequestAsync("ModifyForwardEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyForwardEntryResponse ModifyForwardEntry(ModifyForwardEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyForwardEntryWithOptions(request, runtime);
        }

        public async Task<ModifyForwardEntryResponse> ModifyForwardEntryAsync(ModifyForwardEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyForwardEntryWithOptionsAsync(request, runtime);
        }

        public ModifyGlobalAccelerationInstanceAttributesResponse ModifyGlobalAccelerationInstanceAttributesWithOptions(ModifyGlobalAccelerationInstanceAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGlobalAccelerationInstanceAttributesResponse>(DoRPCRequest("ModifyGlobalAccelerationInstanceAttributes", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyGlobalAccelerationInstanceAttributesResponse> ModifyGlobalAccelerationInstanceAttributesWithOptionsAsync(ModifyGlobalAccelerationInstanceAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGlobalAccelerationInstanceAttributesResponse>(await DoRPCRequestAsync("ModifyGlobalAccelerationInstanceAttributes", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyGlobalAccelerationInstanceAttributesResponse ModifyGlobalAccelerationInstanceAttributes(ModifyGlobalAccelerationInstanceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGlobalAccelerationInstanceAttributesWithOptions(request, runtime);
        }

        public async Task<ModifyGlobalAccelerationInstanceAttributesResponse> ModifyGlobalAccelerationInstanceAttributesAsync(ModifyGlobalAccelerationInstanceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGlobalAccelerationInstanceAttributesWithOptionsAsync(request, runtime);
        }

        public ModifyGlobalAccelerationInstanceSpecResponse ModifyGlobalAccelerationInstanceSpecWithOptions(ModifyGlobalAccelerationInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGlobalAccelerationInstanceSpecResponse>(DoRPCRequest("ModifyGlobalAccelerationInstanceSpec", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyGlobalAccelerationInstanceSpecResponse> ModifyGlobalAccelerationInstanceSpecWithOptionsAsync(ModifyGlobalAccelerationInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyGlobalAccelerationInstanceSpecResponse>(await DoRPCRequestAsync("ModifyGlobalAccelerationInstanceSpec", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyGlobalAccelerationInstanceSpecResponse ModifyGlobalAccelerationInstanceSpec(ModifyGlobalAccelerationInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyGlobalAccelerationInstanceSpecWithOptions(request, runtime);
        }

        public async Task<ModifyGlobalAccelerationInstanceSpecResponse> ModifyGlobalAccelerationInstanceSpecAsync(ModifyGlobalAccelerationInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyGlobalAccelerationInstanceSpecWithOptionsAsync(request, runtime);
        }

        public ModifyHaVipAttributeResponse ModifyHaVipAttributeWithOptions(ModifyHaVipAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHaVipAttributeResponse>(DoRPCRequest("ModifyHaVipAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHaVipAttributeResponse> ModifyHaVipAttributeWithOptionsAsync(ModifyHaVipAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHaVipAttributeResponse>(await DoRPCRequestAsync("ModifyHaVipAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHaVipAttributeResponse ModifyHaVipAttribute(ModifyHaVipAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHaVipAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyHaVipAttributeResponse> ModifyHaVipAttributeAsync(ModifyHaVipAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHaVipAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAutoRenewalAttributeResponse ModifyInstanceAutoRenewalAttributeWithOptions(ModifyInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAutoRenewalAttributeResponse>(DoRPCRequest("ModifyInstanceAutoRenewalAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceAutoRenewalAttributeResponse> ModifyInstanceAutoRenewalAttributeWithOptionsAsync(ModifyInstanceAutoRenewalAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAutoRenewalAttributeResponse>(await DoRPCRequestAsync("ModifyInstanceAutoRenewalAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceAutoRenewalAttributeResponse ModifyInstanceAutoRenewalAttribute(ModifyInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAutoRenewalAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAutoRenewalAttributeResponse> ModifyInstanceAutoRenewalAttributeAsync(ModifyInstanceAutoRenewalAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAutoRenewalAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyIpv6AddressAttributeResponse ModifyIpv6AddressAttributeWithOptions(ModifyIpv6AddressAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpv6AddressAttributeResponse>(DoRPCRequest("ModifyIpv6AddressAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIpv6AddressAttributeResponse> ModifyIpv6AddressAttributeWithOptionsAsync(ModifyIpv6AddressAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpv6AddressAttributeResponse>(await DoRPCRequestAsync("ModifyIpv6AddressAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIpv6AddressAttributeResponse ModifyIpv6AddressAttribute(ModifyIpv6AddressAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpv6AddressAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyIpv6AddressAttributeResponse> ModifyIpv6AddressAttributeAsync(ModifyIpv6AddressAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpv6AddressAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyIpv6GatewayAttributeResponse ModifyIpv6GatewayAttributeWithOptions(ModifyIpv6GatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpv6GatewayAttributeResponse>(DoRPCRequest("ModifyIpv6GatewayAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIpv6GatewayAttributeResponse> ModifyIpv6GatewayAttributeWithOptionsAsync(ModifyIpv6GatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpv6GatewayAttributeResponse>(await DoRPCRequestAsync("ModifyIpv6GatewayAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIpv6GatewayAttributeResponse ModifyIpv6GatewayAttribute(ModifyIpv6GatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpv6GatewayAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyIpv6GatewayAttributeResponse> ModifyIpv6GatewayAttributeAsync(ModifyIpv6GatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpv6GatewayAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyIpv6GatewaySpecResponse ModifyIpv6GatewaySpecWithOptions(ModifyIpv6GatewaySpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpv6GatewaySpecResponse>(DoRPCRequest("ModifyIpv6GatewaySpec", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIpv6GatewaySpecResponse> ModifyIpv6GatewaySpecWithOptionsAsync(ModifyIpv6GatewaySpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpv6GatewaySpecResponse>(await DoRPCRequestAsync("ModifyIpv6GatewaySpec", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIpv6GatewaySpecResponse ModifyIpv6GatewaySpec(ModifyIpv6GatewaySpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpv6GatewaySpecWithOptions(request, runtime);
        }

        public async Task<ModifyIpv6GatewaySpecResponse> ModifyIpv6GatewaySpecAsync(ModifyIpv6GatewaySpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpv6GatewaySpecWithOptionsAsync(request, runtime);
        }

        public ModifyIpv6InternetBandwidthResponse ModifyIpv6InternetBandwidthWithOptions(ModifyIpv6InternetBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpv6InternetBandwidthResponse>(DoRPCRequest("ModifyIpv6InternetBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIpv6InternetBandwidthResponse> ModifyIpv6InternetBandwidthWithOptionsAsync(ModifyIpv6InternetBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpv6InternetBandwidthResponse>(await DoRPCRequestAsync("ModifyIpv6InternetBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIpv6InternetBandwidthResponse ModifyIpv6InternetBandwidth(ModifyIpv6InternetBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpv6InternetBandwidthWithOptions(request, runtime);
        }

        public async Task<ModifyIpv6InternetBandwidthResponse> ModifyIpv6InternetBandwidthAsync(ModifyIpv6InternetBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpv6InternetBandwidthWithOptionsAsync(request, runtime);
        }

        public ModifyIPv6TranslatorAclAttributeResponse ModifyIPv6TranslatorAclAttributeWithOptions(ModifyIPv6TranslatorAclAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIPv6TranslatorAclAttributeResponse>(DoRPCRequest("ModifyIPv6TranslatorAclAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIPv6TranslatorAclAttributeResponse> ModifyIPv6TranslatorAclAttributeWithOptionsAsync(ModifyIPv6TranslatorAclAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIPv6TranslatorAclAttributeResponse>(await DoRPCRequestAsync("ModifyIPv6TranslatorAclAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIPv6TranslatorAclAttributeResponse ModifyIPv6TranslatorAclAttribute(ModifyIPv6TranslatorAclAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIPv6TranslatorAclAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyIPv6TranslatorAclAttributeResponse> ModifyIPv6TranslatorAclAttributeAsync(ModifyIPv6TranslatorAclAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIPv6TranslatorAclAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyIPv6TranslatorAclListEntryResponse ModifyIPv6TranslatorAclListEntryWithOptions(ModifyIPv6TranslatorAclListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIPv6TranslatorAclListEntryResponse>(DoRPCRequest("ModifyIPv6TranslatorAclListEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIPv6TranslatorAclListEntryResponse> ModifyIPv6TranslatorAclListEntryWithOptionsAsync(ModifyIPv6TranslatorAclListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIPv6TranslatorAclListEntryResponse>(await DoRPCRequestAsync("ModifyIPv6TranslatorAclListEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIPv6TranslatorAclListEntryResponse ModifyIPv6TranslatorAclListEntry(ModifyIPv6TranslatorAclListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIPv6TranslatorAclListEntryWithOptions(request, runtime);
        }

        public async Task<ModifyIPv6TranslatorAclListEntryResponse> ModifyIPv6TranslatorAclListEntryAsync(ModifyIPv6TranslatorAclListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIPv6TranslatorAclListEntryWithOptionsAsync(request, runtime);
        }

        public ModifyIPv6TranslatorAttributeResponse ModifyIPv6TranslatorAttributeWithOptions(ModifyIPv6TranslatorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIPv6TranslatorAttributeResponse>(DoRPCRequest("ModifyIPv6TranslatorAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIPv6TranslatorAttributeResponse> ModifyIPv6TranslatorAttributeWithOptionsAsync(ModifyIPv6TranslatorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIPv6TranslatorAttributeResponse>(await DoRPCRequestAsync("ModifyIPv6TranslatorAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIPv6TranslatorAttributeResponse ModifyIPv6TranslatorAttribute(ModifyIPv6TranslatorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIPv6TranslatorAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyIPv6TranslatorAttributeResponse> ModifyIPv6TranslatorAttributeAsync(ModifyIPv6TranslatorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIPv6TranslatorAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyIPv6TranslatorBandwidthResponse ModifyIPv6TranslatorBandwidthWithOptions(ModifyIPv6TranslatorBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIPv6TranslatorBandwidthResponse>(DoRPCRequest("ModifyIPv6TranslatorBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIPv6TranslatorBandwidthResponse> ModifyIPv6TranslatorBandwidthWithOptionsAsync(ModifyIPv6TranslatorBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIPv6TranslatorBandwidthResponse>(await DoRPCRequestAsync("ModifyIPv6TranslatorBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIPv6TranslatorBandwidthResponse ModifyIPv6TranslatorBandwidth(ModifyIPv6TranslatorBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIPv6TranslatorBandwidthWithOptions(request, runtime);
        }

        public async Task<ModifyIPv6TranslatorBandwidthResponse> ModifyIPv6TranslatorBandwidthAsync(ModifyIPv6TranslatorBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIPv6TranslatorBandwidthWithOptionsAsync(request, runtime);
        }

        public ModifyIPv6TranslatorEntryResponse ModifyIPv6TranslatorEntryWithOptions(ModifyIPv6TranslatorEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIPv6TranslatorEntryResponse>(DoRPCRequest("ModifyIPv6TranslatorEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIPv6TranslatorEntryResponse> ModifyIPv6TranslatorEntryWithOptionsAsync(ModifyIPv6TranslatorEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIPv6TranslatorEntryResponse>(await DoRPCRequestAsync("ModifyIPv6TranslatorEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIPv6TranslatorEntryResponse ModifyIPv6TranslatorEntry(ModifyIPv6TranslatorEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIPv6TranslatorEntryWithOptions(request, runtime);
        }

        public async Task<ModifyIPv6TranslatorEntryResponse> ModifyIPv6TranslatorEntryAsync(ModifyIPv6TranslatorEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIPv6TranslatorEntryWithOptionsAsync(request, runtime);
        }

        public ModifyNatGatewayAttributeResponse ModifyNatGatewayAttributeWithOptions(ModifyNatGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNatGatewayAttributeResponse>(DoRPCRequest("ModifyNatGatewayAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyNatGatewayAttributeResponse> ModifyNatGatewayAttributeWithOptionsAsync(ModifyNatGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNatGatewayAttributeResponse>(await DoRPCRequestAsync("ModifyNatGatewayAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyNatGatewayAttributeResponse ModifyNatGatewayAttribute(ModifyNatGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNatGatewayAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyNatGatewayAttributeResponse> ModifyNatGatewayAttributeAsync(ModifyNatGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNatGatewayAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyNatGatewaySpecResponse ModifyNatGatewaySpecWithOptions(ModifyNatGatewaySpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNatGatewaySpecResponse>(DoRPCRequest("ModifyNatGatewaySpec", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyNatGatewaySpecResponse> ModifyNatGatewaySpecWithOptionsAsync(ModifyNatGatewaySpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNatGatewaySpecResponse>(await DoRPCRequestAsync("ModifyNatGatewaySpec", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyNatGatewaySpecResponse ModifyNatGatewaySpec(ModifyNatGatewaySpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNatGatewaySpecWithOptions(request, runtime);
        }

        public async Task<ModifyNatGatewaySpecResponse> ModifyNatGatewaySpecAsync(ModifyNatGatewaySpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNatGatewaySpecWithOptionsAsync(request, runtime);
        }

        public ModifyNetworkAclAttributesResponse ModifyNetworkAclAttributesWithOptions(ModifyNetworkAclAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNetworkAclAttributesResponse>(DoRPCRequest("ModifyNetworkAclAttributes", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyNetworkAclAttributesResponse> ModifyNetworkAclAttributesWithOptionsAsync(ModifyNetworkAclAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNetworkAclAttributesResponse>(await DoRPCRequestAsync("ModifyNetworkAclAttributes", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyNetworkAclAttributesResponse ModifyNetworkAclAttributes(ModifyNetworkAclAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNetworkAclAttributesWithOptions(request, runtime);
        }

        public async Task<ModifyNetworkAclAttributesResponse> ModifyNetworkAclAttributesAsync(ModifyNetworkAclAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNetworkAclAttributesWithOptionsAsync(request, runtime);
        }

        public ModifyRouteEntryResponse ModifyRouteEntryWithOptions(ModifyRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouteEntryResponse>(DoRPCRequest("ModifyRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRouteEntryResponse> ModifyRouteEntryWithOptionsAsync(ModifyRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouteEntryResponse>(await DoRPCRequestAsync("ModifyRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRouteEntryResponse ModifyRouteEntry(ModifyRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRouteEntryWithOptions(request, runtime);
        }

        public async Task<ModifyRouteEntryResponse> ModifyRouteEntryAsync(ModifyRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRouteEntryWithOptionsAsync(request, runtime);
        }

        public ModifyRouterInterfaceAttributeResponse ModifyRouterInterfaceAttributeWithOptions(ModifyRouterInterfaceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouterInterfaceAttributeResponse>(DoRPCRequest("ModifyRouterInterfaceAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRouterInterfaceAttributeResponse> ModifyRouterInterfaceAttributeWithOptionsAsync(ModifyRouterInterfaceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouterInterfaceAttributeResponse>(await DoRPCRequestAsync("ModifyRouterInterfaceAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRouterInterfaceAttributeResponse ModifyRouterInterfaceAttribute(ModifyRouterInterfaceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRouterInterfaceAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyRouterInterfaceAttributeResponse> ModifyRouterInterfaceAttributeAsync(ModifyRouterInterfaceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRouterInterfaceAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyRouterInterfaceSpecResponse ModifyRouterInterfaceSpecWithOptions(ModifyRouterInterfaceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouterInterfaceSpecResponse>(DoRPCRequest("ModifyRouterInterfaceSpec", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRouterInterfaceSpecResponse> ModifyRouterInterfaceSpecWithOptionsAsync(ModifyRouterInterfaceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouterInterfaceSpecResponse>(await DoRPCRequestAsync("ModifyRouterInterfaceSpec", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRouterInterfaceSpecResponse ModifyRouterInterfaceSpec(ModifyRouterInterfaceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRouterInterfaceSpecWithOptions(request, runtime);
        }

        public async Task<ModifyRouterInterfaceSpecResponse> ModifyRouterInterfaceSpecAsync(ModifyRouterInterfaceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRouterInterfaceSpecWithOptionsAsync(request, runtime);
        }

        public ModifyRouteTableAttributesResponse ModifyRouteTableAttributesWithOptions(ModifyRouteTableAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouteTableAttributesResponse>(DoRPCRequest("ModifyRouteTableAttributes", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRouteTableAttributesResponse> ModifyRouteTableAttributesWithOptionsAsync(ModifyRouteTableAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouteTableAttributesResponse>(await DoRPCRequestAsync("ModifyRouteTableAttributes", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRouteTableAttributesResponse ModifyRouteTableAttributes(ModifyRouteTableAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRouteTableAttributesWithOptions(request, runtime);
        }

        public async Task<ModifyRouteTableAttributesResponse> ModifyRouteTableAttributesAsync(ModifyRouteTableAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRouteTableAttributesWithOptionsAsync(request, runtime);
        }

        public ModifySnatEntryResponse ModifySnatEntryWithOptions(ModifySnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySnatEntryResponse>(DoRPCRequest("ModifySnatEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySnatEntryResponse> ModifySnatEntryWithOptionsAsync(ModifySnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySnatEntryResponse>(await DoRPCRequestAsync("ModifySnatEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySnatEntryResponse ModifySnatEntry(ModifySnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySnatEntryWithOptions(request, runtime);
        }

        public async Task<ModifySnatEntryResponse> ModifySnatEntryAsync(ModifySnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySnatEntryWithOptionsAsync(request, runtime);
        }

        public ModifySslVpnClientCertResponse ModifySslVpnClientCertWithOptions(ModifySslVpnClientCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySslVpnClientCertResponse>(DoRPCRequest("ModifySslVpnClientCert", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySslVpnClientCertResponse> ModifySslVpnClientCertWithOptionsAsync(ModifySslVpnClientCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySslVpnClientCertResponse>(await DoRPCRequestAsync("ModifySslVpnClientCert", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySslVpnClientCertResponse ModifySslVpnClientCert(ModifySslVpnClientCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySslVpnClientCertWithOptions(request, runtime);
        }

        public async Task<ModifySslVpnClientCertResponse> ModifySslVpnClientCertAsync(ModifySslVpnClientCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySslVpnClientCertWithOptionsAsync(request, runtime);
        }

        public ModifySslVpnServerResponse ModifySslVpnServerWithOptions(ModifySslVpnServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySslVpnServerResponse>(DoRPCRequest("ModifySslVpnServer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySslVpnServerResponse> ModifySslVpnServerWithOptionsAsync(ModifySslVpnServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySslVpnServerResponse>(await DoRPCRequestAsync("ModifySslVpnServer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySslVpnServerResponse ModifySslVpnServer(ModifySslVpnServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySslVpnServerWithOptions(request, runtime);
        }

        public async Task<ModifySslVpnServerResponse> ModifySslVpnServerAsync(ModifySslVpnServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySslVpnServerWithOptionsAsync(request, runtime);
        }

        public ModifyVirtualBorderRouterAttributeResponse ModifyVirtualBorderRouterAttributeWithOptions(ModifyVirtualBorderRouterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVirtualBorderRouterAttributeResponse>(DoRPCRequest("ModifyVirtualBorderRouterAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVirtualBorderRouterAttributeResponse> ModifyVirtualBorderRouterAttributeWithOptionsAsync(ModifyVirtualBorderRouterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVirtualBorderRouterAttributeResponse>(await DoRPCRequestAsync("ModifyVirtualBorderRouterAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVirtualBorderRouterAttributeResponse ModifyVirtualBorderRouterAttribute(ModifyVirtualBorderRouterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVirtualBorderRouterAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyVirtualBorderRouterAttributeResponse> ModifyVirtualBorderRouterAttributeAsync(ModifyVirtualBorderRouterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVirtualBorderRouterAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyVpcAttributeResponse ModifyVpcAttributeWithOptions(ModifyVpcAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpcAttributeResponse>(DoRPCRequest("ModifyVpcAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVpcAttributeResponse> ModifyVpcAttributeWithOptionsAsync(ModifyVpcAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpcAttributeResponse>(await DoRPCRequestAsync("ModifyVpcAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyVpnConnectionAttributeResponse ModifyVpnConnectionAttributeWithOptions(ModifyVpnConnectionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpnConnectionAttributeResponse>(DoRPCRequest("ModifyVpnConnectionAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVpnConnectionAttributeResponse> ModifyVpnConnectionAttributeWithOptionsAsync(ModifyVpnConnectionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpnConnectionAttributeResponse>(await DoRPCRequestAsync("ModifyVpnConnectionAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVpnConnectionAttributeResponse ModifyVpnConnectionAttribute(ModifyVpnConnectionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpnConnectionAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyVpnConnectionAttributeResponse> ModifyVpnConnectionAttributeAsync(ModifyVpnConnectionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpnConnectionAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyVpnGatewayAttributeResponse ModifyVpnGatewayAttributeWithOptions(ModifyVpnGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpnGatewayAttributeResponse>(DoRPCRequest("ModifyVpnGatewayAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVpnGatewayAttributeResponse> ModifyVpnGatewayAttributeWithOptionsAsync(ModifyVpnGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpnGatewayAttributeResponse>(await DoRPCRequestAsync("ModifyVpnGatewayAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVpnGatewayAttributeResponse ModifyVpnGatewayAttribute(ModifyVpnGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpnGatewayAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyVpnGatewayAttributeResponse> ModifyVpnGatewayAttributeAsync(ModifyVpnGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpnGatewayAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyVpnPbrRouteEntryWeightResponse ModifyVpnPbrRouteEntryWeightWithOptions(ModifyVpnPbrRouteEntryWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpnPbrRouteEntryWeightResponse>(DoRPCRequest("ModifyVpnPbrRouteEntryWeight", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVpnPbrRouteEntryWeightResponse> ModifyVpnPbrRouteEntryWeightWithOptionsAsync(ModifyVpnPbrRouteEntryWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpnPbrRouteEntryWeightResponse>(await DoRPCRequestAsync("ModifyVpnPbrRouteEntryWeight", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVpnPbrRouteEntryWeightResponse ModifyVpnPbrRouteEntryWeight(ModifyVpnPbrRouteEntryWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpnPbrRouteEntryWeightWithOptions(request, runtime);
        }

        public async Task<ModifyVpnPbrRouteEntryWeightResponse> ModifyVpnPbrRouteEntryWeightAsync(ModifyVpnPbrRouteEntryWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpnPbrRouteEntryWeightWithOptionsAsync(request, runtime);
        }

        public ModifyVpnRouteEntryWeightResponse ModifyVpnRouteEntryWeightWithOptions(ModifyVpnRouteEntryWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpnRouteEntryWeightResponse>(DoRPCRequest("ModifyVpnRouteEntryWeight", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVpnRouteEntryWeightResponse> ModifyVpnRouteEntryWeightWithOptionsAsync(ModifyVpnRouteEntryWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpnRouteEntryWeightResponse>(await DoRPCRequestAsync("ModifyVpnRouteEntryWeight", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVpnRouteEntryWeightResponse ModifyVpnRouteEntryWeight(ModifyVpnRouteEntryWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpnRouteEntryWeightWithOptions(request, runtime);
        }

        public async Task<ModifyVpnRouteEntryWeightResponse> ModifyVpnRouteEntryWeightAsync(ModifyVpnRouteEntryWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpnRouteEntryWeightWithOptionsAsync(request, runtime);
        }

        public ModifyVRouterAttributeResponse ModifyVRouterAttributeWithOptions(ModifyVRouterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVRouterAttributeResponse>(DoRPCRequest("ModifyVRouterAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVRouterAttributeResponse> ModifyVRouterAttributeWithOptionsAsync(ModifyVRouterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVRouterAttributeResponse>(await DoRPCRequestAsync("ModifyVRouterAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVRouterAttributeResponse ModifyVRouterAttribute(ModifyVRouterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVRouterAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyVRouterAttributeResponse> ModifyVRouterAttributeAsync(ModifyVRouterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVRouterAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyVSwitchAttributeResponse ModifyVSwitchAttributeWithOptions(ModifyVSwitchAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVSwitchAttributeResponse>(DoRPCRequest("ModifyVSwitchAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVSwitchAttributeResponse> ModifyVSwitchAttributeWithOptionsAsync(ModifyVSwitchAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVSwitchAttributeResponse>(await DoRPCRequestAsync("ModifyVSwitchAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVSwitchAttributeResponse ModifyVSwitchAttribute(ModifyVSwitchAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVSwitchAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyVSwitchAttributeResponse> ModifyVSwitchAttributeAsync(ModifyVSwitchAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVSwitchAttributeWithOptionsAsync(request, runtime);
        }

        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(DoRPCRequest("MoveResourceGroup", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await DoRPCRequestAsync("MoveResourceGroup", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        public PublishVpnRouteEntryResponse PublishVpnRouteEntryWithOptions(PublishVpnRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishVpnRouteEntryResponse>(DoRPCRequest("PublishVpnRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishVpnRouteEntryResponse> PublishVpnRouteEntryWithOptionsAsync(PublishVpnRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishVpnRouteEntryResponse>(await DoRPCRequestAsync("PublishVpnRouteEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishVpnRouteEntryResponse PublishVpnRouteEntry(PublishVpnRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishVpnRouteEntryWithOptions(request, runtime);
        }

        public async Task<PublishVpnRouteEntryResponse> PublishVpnRouteEntryAsync(PublishVpnRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishVpnRouteEntryWithOptionsAsync(request, runtime);
        }

        public RecoverVirtualBorderRouterResponse RecoverVirtualBorderRouterWithOptions(RecoverVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecoverVirtualBorderRouterResponse>(DoRPCRequest("RecoverVirtualBorderRouter", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecoverVirtualBorderRouterResponse> RecoverVirtualBorderRouterWithOptionsAsync(RecoverVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecoverVirtualBorderRouterResponse>(await DoRPCRequestAsync("RecoverVirtualBorderRouter", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RecoverVirtualBorderRouterResponse RecoverVirtualBorderRouter(RecoverVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecoverVirtualBorderRouterWithOptions(request, runtime);
        }

        public async Task<RecoverVirtualBorderRouterResponse> RecoverVirtualBorderRouterAsync(RecoverVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecoverVirtualBorderRouterWithOptionsAsync(request, runtime);
        }

        public ReleaseEipAddressResponse ReleaseEipAddressWithOptions(ReleaseEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseEipAddressResponse>(DoRPCRequest("ReleaseEipAddress", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseEipAddressResponse> ReleaseEipAddressWithOptionsAsync(ReleaseEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseEipAddressResponse>(await DoRPCRequestAsync("ReleaseEipAddress", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseEipAddressResponse ReleaseEipAddress(ReleaseEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseEipAddressWithOptions(request, runtime);
        }

        public async Task<ReleaseEipAddressResponse> ReleaseEipAddressAsync(ReleaseEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseEipAddressWithOptionsAsync(request, runtime);
        }

        public ReleaseEipSegmentAddressResponse ReleaseEipSegmentAddressWithOptions(ReleaseEipSegmentAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseEipSegmentAddressResponse>(DoRPCRequest("ReleaseEipSegmentAddress", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseEipSegmentAddressResponse> ReleaseEipSegmentAddressWithOptionsAsync(ReleaseEipSegmentAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseEipSegmentAddressResponse>(await DoRPCRequestAsync("ReleaseEipSegmentAddress", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseEipSegmentAddressResponse ReleaseEipSegmentAddress(ReleaseEipSegmentAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseEipSegmentAddressWithOptions(request, runtime);
        }

        public async Task<ReleaseEipSegmentAddressResponse> ReleaseEipSegmentAddressAsync(ReleaseEipSegmentAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseEipSegmentAddressWithOptionsAsync(request, runtime);
        }

        public RemoveCommonBandwidthPackageIpResponse RemoveCommonBandwidthPackageIpWithOptions(RemoveCommonBandwidthPackageIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveCommonBandwidthPackageIpResponse>(DoRPCRequest("RemoveCommonBandwidthPackageIp", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveCommonBandwidthPackageIpResponse> RemoveCommonBandwidthPackageIpWithOptionsAsync(RemoveCommonBandwidthPackageIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveCommonBandwidthPackageIpResponse>(await DoRPCRequestAsync("RemoveCommonBandwidthPackageIp", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveCommonBandwidthPackageIpResponse RemoveCommonBandwidthPackageIp(RemoveCommonBandwidthPackageIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveCommonBandwidthPackageIpWithOptions(request, runtime);
        }

        public async Task<RemoveCommonBandwidthPackageIpResponse> RemoveCommonBandwidthPackageIpAsync(RemoveCommonBandwidthPackageIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveCommonBandwidthPackageIpWithOptionsAsync(request, runtime);
        }

        public RemoveGlobalAccelerationInstanceIpResponse RemoveGlobalAccelerationInstanceIpWithOptions(RemoveGlobalAccelerationInstanceIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveGlobalAccelerationInstanceIpResponse>(DoRPCRequest("RemoveGlobalAccelerationInstanceIp", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveGlobalAccelerationInstanceIpResponse> RemoveGlobalAccelerationInstanceIpWithOptionsAsync(RemoveGlobalAccelerationInstanceIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveGlobalAccelerationInstanceIpResponse>(await DoRPCRequestAsync("RemoveGlobalAccelerationInstanceIp", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveGlobalAccelerationInstanceIpResponse RemoveGlobalAccelerationInstanceIp(RemoveGlobalAccelerationInstanceIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveGlobalAccelerationInstanceIpWithOptions(request, runtime);
        }

        public async Task<RemoveGlobalAccelerationInstanceIpResponse> RemoveGlobalAccelerationInstanceIpAsync(RemoveGlobalAccelerationInstanceIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveGlobalAccelerationInstanceIpWithOptionsAsync(request, runtime);
        }

        public RemoveIPv6TranslatorAclListEntryResponse RemoveIPv6TranslatorAclListEntryWithOptions(RemoveIPv6TranslatorAclListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveIPv6TranslatorAclListEntryResponse>(DoRPCRequest("RemoveIPv6TranslatorAclListEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveIPv6TranslatorAclListEntryResponse> RemoveIPv6TranslatorAclListEntryWithOptionsAsync(RemoveIPv6TranslatorAclListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveIPv6TranslatorAclListEntryResponse>(await DoRPCRequestAsync("RemoveIPv6TranslatorAclListEntry", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveIPv6TranslatorAclListEntryResponse RemoveIPv6TranslatorAclListEntry(RemoveIPv6TranslatorAclListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveIPv6TranslatorAclListEntryWithOptions(request, runtime);
        }

        public async Task<RemoveIPv6TranslatorAclListEntryResponse> RemoveIPv6TranslatorAclListEntryAsync(RemoveIPv6TranslatorAclListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveIPv6TranslatorAclListEntryWithOptionsAsync(request, runtime);
        }

        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(DoRPCRequest("RenewInstance", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await DoRPCRequestAsync("RenewInstance", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenewInstanceResponse RenewInstance(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewInstanceWithOptions(request, runtime);
        }

        public async Task<RenewInstanceResponse> RenewInstanceAsync(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewInstanceWithOptionsAsync(request, runtime);
        }

        public ReplaceVpcDhcpOptionsSetResponse ReplaceVpcDhcpOptionsSetWithOptions(ReplaceVpcDhcpOptionsSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceVpcDhcpOptionsSetResponse>(DoRPCRequest("ReplaceVpcDhcpOptionsSet", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReplaceVpcDhcpOptionsSetResponse> ReplaceVpcDhcpOptionsSetWithOptionsAsync(ReplaceVpcDhcpOptionsSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceVpcDhcpOptionsSetResponse>(await DoRPCRequestAsync("ReplaceVpcDhcpOptionsSet", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReplaceVpcDhcpOptionsSetResponse ReplaceVpcDhcpOptionsSet(ReplaceVpcDhcpOptionsSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceVpcDhcpOptionsSetWithOptions(request, runtime);
        }

        public async Task<ReplaceVpcDhcpOptionsSetResponse> ReplaceVpcDhcpOptionsSetAsync(ReplaceVpcDhcpOptionsSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceVpcDhcpOptionsSetWithOptionsAsync(request, runtime);
        }

        public RevokeInstanceFromCenResponse RevokeInstanceFromCenWithOptions(RevokeInstanceFromCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeInstanceFromCenResponse>(DoRPCRequest("RevokeInstanceFromCen", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeInstanceFromCenResponse> RevokeInstanceFromCenWithOptionsAsync(RevokeInstanceFromCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeInstanceFromCenResponse>(await DoRPCRequestAsync("RevokeInstanceFromCen", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeInstanceFromCenResponse RevokeInstanceFromCen(RevokeInstanceFromCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeInstanceFromCenWithOptions(request, runtime);
        }

        public async Task<RevokeInstanceFromCenResponse> RevokeInstanceFromCenAsync(RevokeInstanceFromCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeInstanceFromCenWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TerminatePhysicalConnectionResponse TerminatePhysicalConnectionWithOptions(TerminatePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TerminatePhysicalConnectionResponse>(DoRPCRequest("TerminatePhysicalConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TerminatePhysicalConnectionResponse> TerminatePhysicalConnectionWithOptionsAsync(TerminatePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TerminatePhysicalConnectionResponse>(await DoRPCRequestAsync("TerminatePhysicalConnection", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TerminatePhysicalConnectionResponse TerminatePhysicalConnection(TerminatePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TerminatePhysicalConnectionWithOptions(request, runtime);
        }

        public async Task<TerminatePhysicalConnectionResponse> TerminatePhysicalConnectionAsync(TerminatePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TerminatePhysicalConnectionWithOptionsAsync(request, runtime);
        }

        public TerminateVirtualBorderRouterResponse TerminateVirtualBorderRouterWithOptions(TerminateVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TerminateVirtualBorderRouterResponse>(DoRPCRequest("TerminateVirtualBorderRouter", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TerminateVirtualBorderRouterResponse> TerminateVirtualBorderRouterWithOptionsAsync(TerminateVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TerminateVirtualBorderRouterResponse>(await DoRPCRequestAsync("TerminateVirtualBorderRouter", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TerminateVirtualBorderRouterResponse TerminateVirtualBorderRouter(TerminateVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TerminateVirtualBorderRouterWithOptions(request, runtime);
        }

        public async Task<TerminateVirtualBorderRouterResponse> TerminateVirtualBorderRouterAsync(TerminateVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TerminateVirtualBorderRouterWithOptionsAsync(request, runtime);
        }

        public UnassociateEipAddressResponse UnassociateEipAddressWithOptions(UnassociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateEipAddressResponse>(DoRPCRequest("UnassociateEipAddress", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassociateEipAddressResponse> UnassociateEipAddressWithOptionsAsync(UnassociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateEipAddressResponse>(await DoRPCRequestAsync("UnassociateEipAddress", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassociateEipAddressResponse UnassociateEipAddress(UnassociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateEipAddressWithOptions(request, runtime);
        }

        public async Task<UnassociateEipAddressResponse> UnassociateEipAddressAsync(UnassociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateEipAddressWithOptionsAsync(request, runtime);
        }

        public UnassociateGlobalAccelerationInstanceResponse UnassociateGlobalAccelerationInstanceWithOptions(UnassociateGlobalAccelerationInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateGlobalAccelerationInstanceResponse>(DoRPCRequest("UnassociateGlobalAccelerationInstance", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassociateGlobalAccelerationInstanceResponse> UnassociateGlobalAccelerationInstanceWithOptionsAsync(UnassociateGlobalAccelerationInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateGlobalAccelerationInstanceResponse>(await DoRPCRequestAsync("UnassociateGlobalAccelerationInstance", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassociateGlobalAccelerationInstanceResponse UnassociateGlobalAccelerationInstance(UnassociateGlobalAccelerationInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateGlobalAccelerationInstanceWithOptions(request, runtime);
        }

        public async Task<UnassociateGlobalAccelerationInstanceResponse> UnassociateGlobalAccelerationInstanceAsync(UnassociateGlobalAccelerationInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateGlobalAccelerationInstanceWithOptionsAsync(request, runtime);
        }

        public UnassociateHaVipResponse UnassociateHaVipWithOptions(UnassociateHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateHaVipResponse>(DoRPCRequest("UnassociateHaVip", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassociateHaVipResponse> UnassociateHaVipWithOptionsAsync(UnassociateHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateHaVipResponse>(await DoRPCRequestAsync("UnassociateHaVip", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassociateHaVipResponse UnassociateHaVip(UnassociateHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateHaVipWithOptions(request, runtime);
        }

        public async Task<UnassociateHaVipResponse> UnassociateHaVipAsync(UnassociateHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateHaVipWithOptionsAsync(request, runtime);
        }

        public UnassociateNetworkAclResponse UnassociateNetworkAclWithOptions(UnassociateNetworkAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateNetworkAclResponse>(DoRPCRequest("UnassociateNetworkAcl", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassociateNetworkAclResponse> UnassociateNetworkAclWithOptionsAsync(UnassociateNetworkAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateNetworkAclResponse>(await DoRPCRequestAsync("UnassociateNetworkAcl", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassociateNetworkAclResponse UnassociateNetworkAcl(UnassociateNetworkAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateNetworkAclWithOptions(request, runtime);
        }

        public async Task<UnassociateNetworkAclResponse> UnassociateNetworkAclAsync(UnassociateNetworkAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateNetworkAclWithOptionsAsync(request, runtime);
        }

        public UnassociatePhysicalConnectionFromVirtualBorderRouterResponse UnassociatePhysicalConnectionFromVirtualBorderRouterWithOptions(UnassociatePhysicalConnectionFromVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociatePhysicalConnectionFromVirtualBorderRouterResponse>(DoRPCRequest("UnassociatePhysicalConnectionFromVirtualBorderRouter", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassociatePhysicalConnectionFromVirtualBorderRouterResponse> UnassociatePhysicalConnectionFromVirtualBorderRouterWithOptionsAsync(UnassociatePhysicalConnectionFromVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociatePhysicalConnectionFromVirtualBorderRouterResponse>(await DoRPCRequestAsync("UnassociatePhysicalConnectionFromVirtualBorderRouter", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassociatePhysicalConnectionFromVirtualBorderRouterResponse UnassociatePhysicalConnectionFromVirtualBorderRouter(UnassociatePhysicalConnectionFromVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociatePhysicalConnectionFromVirtualBorderRouterWithOptions(request, runtime);
        }

        public async Task<UnassociatePhysicalConnectionFromVirtualBorderRouterResponse> UnassociatePhysicalConnectionFromVirtualBorderRouterAsync(UnassociatePhysicalConnectionFromVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociatePhysicalConnectionFromVirtualBorderRouterWithOptionsAsync(request, runtime);
        }

        public UnassociateRouteTableResponse UnassociateRouteTableWithOptions(UnassociateRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateRouteTableResponse>(DoRPCRequest("UnassociateRouteTable", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassociateRouteTableResponse> UnassociateRouteTableWithOptionsAsync(UnassociateRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateRouteTableResponse>(await DoRPCRequestAsync("UnassociateRouteTable", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassociateRouteTableResponse UnassociateRouteTable(UnassociateRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateRouteTableWithOptions(request, runtime);
        }

        public async Task<UnassociateRouteTableResponse> UnassociateRouteTableAsync(UnassociateRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateRouteTableWithOptionsAsync(request, runtime);
        }

        public UnassociateVpcCidrBlockResponse UnassociateVpcCidrBlockWithOptions(UnassociateVpcCidrBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateVpcCidrBlockResponse>(DoRPCRequest("UnassociateVpcCidrBlock", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassociateVpcCidrBlockResponse> UnassociateVpcCidrBlockWithOptionsAsync(UnassociateVpcCidrBlockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateVpcCidrBlockResponse>(await DoRPCRequestAsync("UnassociateVpcCidrBlock", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassociateVpcCidrBlockResponse UnassociateVpcCidrBlock(UnassociateVpcCidrBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateVpcCidrBlockWithOptions(request, runtime);
        }

        public async Task<UnassociateVpcCidrBlockResponse> UnassociateVpcCidrBlockAsync(UnassociateVpcCidrBlockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateVpcCidrBlockWithOptionsAsync(request, runtime);
        }

        public UnTagResourcesResponse UnTagResourcesWithOptions(UnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(DoRPCRequest("UnTagResources", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnTagResourcesResponse> UnTagResourcesWithOptionsAsync(UnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(await DoRPCRequestAsync("UnTagResources", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnTagResourcesResponse UnTagResources(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnTagResourcesWithOptions(request, runtime);
        }

        public async Task<UnTagResourcesResponse> UnTagResourcesAsync(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnTagResourcesWithOptionsAsync(request, runtime);
        }

        public UpdateDhcpOptionsSetAttributeResponse UpdateDhcpOptionsSetAttributeWithOptions(UpdateDhcpOptionsSetAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDhcpOptionsSetAttributeResponse>(DoRPCRequest("UpdateDhcpOptionsSetAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDhcpOptionsSetAttributeResponse> UpdateDhcpOptionsSetAttributeWithOptionsAsync(UpdateDhcpOptionsSetAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDhcpOptionsSetAttributeResponse>(await DoRPCRequestAsync("UpdateDhcpOptionsSetAttribute", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDhcpOptionsSetAttributeResponse UpdateDhcpOptionsSetAttribute(UpdateDhcpOptionsSetAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDhcpOptionsSetAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateDhcpOptionsSetAttributeResponse> UpdateDhcpOptionsSetAttributeAsync(UpdateDhcpOptionsSetAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDhcpOptionsSetAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateIpsecServerResponse UpdateIpsecServerWithOptions(UpdateIpsecServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateIpsecServerResponse>(DoRPCRequest("UpdateIpsecServer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateIpsecServerResponse> UpdateIpsecServerWithOptionsAsync(UpdateIpsecServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateIpsecServerResponse>(await DoRPCRequestAsync("UpdateIpsecServer", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateIpsecServerResponse UpdateIpsecServer(UpdateIpsecServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIpsecServerWithOptions(request, runtime);
        }

        public async Task<UpdateIpsecServerResponse> UpdateIpsecServerAsync(UpdateIpsecServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIpsecServerWithOptionsAsync(request, runtime);
        }

        public UpdateNatGatewayNatTypeResponse UpdateNatGatewayNatTypeWithOptions(UpdateNatGatewayNatTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNatGatewayNatTypeResponse>(DoRPCRequest("UpdateNatGatewayNatType", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateNatGatewayNatTypeResponse> UpdateNatGatewayNatTypeWithOptionsAsync(UpdateNatGatewayNatTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNatGatewayNatTypeResponse>(await DoRPCRequestAsync("UpdateNatGatewayNatType", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateNatGatewayNatTypeResponse UpdateNatGatewayNatType(UpdateNatGatewayNatTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNatGatewayNatTypeWithOptions(request, runtime);
        }

        public async Task<UpdateNatGatewayNatTypeResponse> UpdateNatGatewayNatTypeAsync(UpdateNatGatewayNatTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNatGatewayNatTypeWithOptionsAsync(request, runtime);
        }

        public UpdateNetworkAclEntriesResponse UpdateNetworkAclEntriesWithOptions(UpdateNetworkAclEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNetworkAclEntriesResponse>(DoRPCRequest("UpdateNetworkAclEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateNetworkAclEntriesResponse> UpdateNetworkAclEntriesWithOptionsAsync(UpdateNetworkAclEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNetworkAclEntriesResponse>(await DoRPCRequestAsync("UpdateNetworkAclEntries", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateNetworkAclEntriesResponse UpdateNetworkAclEntries(UpdateNetworkAclEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNetworkAclEntriesWithOptions(request, runtime);
        }

        public async Task<UpdateNetworkAclEntriesResponse> UpdateNetworkAclEntriesAsync(UpdateNetworkAclEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNetworkAclEntriesWithOptionsAsync(request, runtime);
        }

        public UpdateVirtualBorderBandwidthResponse UpdateVirtualBorderBandwidthWithOptions(UpdateVirtualBorderBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateVirtualBorderBandwidthResponse>(DoRPCRequest("UpdateVirtualBorderBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateVirtualBorderBandwidthResponse> UpdateVirtualBorderBandwidthWithOptionsAsync(UpdateVirtualBorderBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateVirtualBorderBandwidthResponse>(await DoRPCRequestAsync("UpdateVirtualBorderBandwidth", "2016-04-28", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateVirtualBorderBandwidthResponse UpdateVirtualBorderBandwidth(UpdateVirtualBorderBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVirtualBorderBandwidthWithOptions(request, runtime);
        }

        public async Task<UpdateVirtualBorderBandwidthResponse> UpdateVirtualBorderBandwidthAsync(UpdateVirtualBorderBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVirtualBorderBandwidthWithOptionsAsync(request, runtime);
        }

    }
}
