// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Slb20140515.Models;

namespace AlibabaCloud.SDK.Slb20140515
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "slb.aliyuncs.com"},
                {"cn-beijing", "slb.aliyuncs.com"},
                {"cn-hangzhou", "slb.aliyuncs.com"},
                {"cn-shanghai", "slb.aliyuncs.com"},
                {"cn-shenzhen", "slb.aliyuncs.com"},
                {"cn-hongkong", "slb.aliyuncs.com"},
                {"ap-southeast-1", "slb.aliyuncs.com"},
                {"us-west-1", "slb.aliyuncs.com"},
                {"us-east-1", "slb.aliyuncs.com"},
                {"cn-shanghai-finance-1", "slb.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "slb.aliyuncs.com"},
                {"cn-north-2-gov-1", "slb.aliyuncs.com"},
                {"ap-northeast-2-pop", "slb.aliyuncs.com"},
                {"cn-beijing-finance-1", "slb.aliyuncs.com"},
                {"cn-beijing-finance-pop", "slb.aliyuncs.com"},
                {"cn-beijing-gov-1", "slb.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "slb.aliyuncs.com"},
                {"cn-edge-1", "slb.aliyuncs.com"},
                {"cn-fujian", "slb.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "slb.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "slb.aliyuncs.com"},
                {"cn-hangzhou-finance", "slb.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "slb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "slb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "slb.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "slb.aliyuncs.com"},
                {"cn-hangzhou-test-306", "slb.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "slb.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "slb-api.cn-qingdao-nebula.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "slb.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "slb.aliyuncs.com"},
                {"cn-shanghai-inner", "slb.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "slb.aliyuncs.com"},
                {"cn-shenzhen-inner", "slb.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "slb.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "slb.aliyuncs.com"},
                {"cn-wuhan", "slb.aliyuncs.com"},
                {"cn-yushanfang", "slb.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "slb.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "slb.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "slb.aliyuncs.com"},
                {"eu-west-1-oxs", "slb.aliyuncs.com"},
                {"rus-west-1-pop", "slb.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("slb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddAccessControlListEntryResponse AddAccessControlListEntryWithOptions(AddAccessControlListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAccessControlListEntryResponse>(DoRPCRequest("AddAccessControlListEntry", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddAccessControlListEntryResponse> AddAccessControlListEntryWithOptionsAsync(AddAccessControlListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAccessControlListEntryResponse>(await DoRPCRequestAsync("AddAccessControlListEntry", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddAccessControlListEntryResponse AddAccessControlListEntry(AddAccessControlListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAccessControlListEntryWithOptions(request, runtime);
        }

        public async Task<AddAccessControlListEntryResponse> AddAccessControlListEntryAsync(AddAccessControlListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAccessControlListEntryWithOptionsAsync(request, runtime);
        }

        public AddBackendServersResponse AddBackendServersWithOptions(AddBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddBackendServersResponse>(DoRPCRequest("AddBackendServers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddBackendServersResponse> AddBackendServersWithOptionsAsync(AddBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddBackendServersResponse>(await DoRPCRequestAsync("AddBackendServers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddBackendServersResponse AddBackendServers(AddBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBackendServersWithOptions(request, runtime);
        }

        public async Task<AddBackendServersResponse> AddBackendServersAsync(AddBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBackendServersWithOptionsAsync(request, runtime);
        }

        public AddListenerWhiteListItemResponse AddListenerWhiteListItemWithOptions(AddListenerWhiteListItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddListenerWhiteListItemResponse>(DoRPCRequest("AddListenerWhiteListItem", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddListenerWhiteListItemResponse> AddListenerWhiteListItemWithOptionsAsync(AddListenerWhiteListItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddListenerWhiteListItemResponse>(await DoRPCRequestAsync("AddListenerWhiteListItem", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddListenerWhiteListItemResponse AddListenerWhiteListItem(AddListenerWhiteListItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddListenerWhiteListItemWithOptions(request, runtime);
        }

        public async Task<AddListenerWhiteListItemResponse> AddListenerWhiteListItemAsync(AddListenerWhiteListItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddListenerWhiteListItemWithOptionsAsync(request, runtime);
        }

        public AddTagsResponse AddTagsWithOptions(AddTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTagsResponse>(DoRPCRequest("AddTags", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddTagsResponse> AddTagsWithOptionsAsync(AddTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTagsResponse>(await DoRPCRequestAsync("AddTags", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddTagsResponse AddTags(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTagsWithOptions(request, runtime);
        }

        public async Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTagsWithOptionsAsync(request, runtime);
        }

        public AddVServerGroupBackendServersResponse AddVServerGroupBackendServersWithOptions(AddVServerGroupBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVServerGroupBackendServersResponse>(DoRPCRequest("AddVServerGroupBackendServers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddVServerGroupBackendServersResponse> AddVServerGroupBackendServersWithOptionsAsync(AddVServerGroupBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddVServerGroupBackendServersResponse>(await DoRPCRequestAsync("AddVServerGroupBackendServers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddVServerGroupBackendServersResponse AddVServerGroupBackendServers(AddVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddVServerGroupBackendServersWithOptions(request, runtime);
        }

        public async Task<AddVServerGroupBackendServersResponse> AddVServerGroupBackendServersAsync(AddVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddVServerGroupBackendServersWithOptionsAsync(request, runtime);
        }

        public CreateAccessControlListResponse CreateAccessControlListWithOptions(CreateAccessControlListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAccessControlListResponse>(DoRPCRequest("CreateAccessControlList", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAccessControlListResponse> CreateAccessControlListWithOptionsAsync(CreateAccessControlListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAccessControlListResponse>(await DoRPCRequestAsync("CreateAccessControlList", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAccessControlListResponse CreateAccessControlList(CreateAccessControlListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccessControlListWithOptions(request, runtime);
        }

        public async Task<CreateAccessControlListResponse> CreateAccessControlListAsync(CreateAccessControlListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccessControlListWithOptionsAsync(request, runtime);
        }

        public CreateDomainExtensionResponse CreateDomainExtensionWithOptions(CreateDomainExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDomainExtensionResponse>(DoRPCRequest("CreateDomainExtension", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDomainExtensionResponse> CreateDomainExtensionWithOptionsAsync(CreateDomainExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDomainExtensionResponse>(await DoRPCRequestAsync("CreateDomainExtension", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDomainExtensionResponse CreateDomainExtension(CreateDomainExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDomainExtensionWithOptions(request, runtime);
        }

        public async Task<CreateDomainExtensionResponse> CreateDomainExtensionAsync(CreateDomainExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDomainExtensionWithOptionsAsync(request, runtime);
        }

        public CreateLoadBalancerResponse CreateLoadBalancerWithOptions(CreateLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLoadBalancerResponse>(DoRPCRequest("CreateLoadBalancer", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLoadBalancerResponse> CreateLoadBalancerWithOptionsAsync(CreateLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLoadBalancerResponse>(await DoRPCRequestAsync("CreateLoadBalancer", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerWithOptions(request, runtime);
        }

        public async Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerWithOptionsAsync(request, runtime);
        }

        public CreateLoadBalancerHTTPListenerResponse CreateLoadBalancerHTTPListenerWithOptions(CreateLoadBalancerHTTPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLoadBalancerHTTPListenerResponse>(DoRPCRequest("CreateLoadBalancerHTTPListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLoadBalancerHTTPListenerResponse> CreateLoadBalancerHTTPListenerWithOptionsAsync(CreateLoadBalancerHTTPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLoadBalancerHTTPListenerResponse>(await DoRPCRequestAsync("CreateLoadBalancerHTTPListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLoadBalancerHTTPListenerResponse CreateLoadBalancerHTTPListener(CreateLoadBalancerHTTPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerHTTPListenerWithOptions(request, runtime);
        }

        public async Task<CreateLoadBalancerHTTPListenerResponse> CreateLoadBalancerHTTPListenerAsync(CreateLoadBalancerHTTPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerHTTPListenerWithOptionsAsync(request, runtime);
        }

        public CreateLoadBalancerHTTPSListenerResponse CreateLoadBalancerHTTPSListenerWithOptions(CreateLoadBalancerHTTPSListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLoadBalancerHTTPSListenerResponse>(DoRPCRequest("CreateLoadBalancerHTTPSListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLoadBalancerHTTPSListenerResponse> CreateLoadBalancerHTTPSListenerWithOptionsAsync(CreateLoadBalancerHTTPSListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLoadBalancerHTTPSListenerResponse>(await DoRPCRequestAsync("CreateLoadBalancerHTTPSListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLoadBalancerHTTPSListenerResponse CreateLoadBalancerHTTPSListener(CreateLoadBalancerHTTPSListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerHTTPSListenerWithOptions(request, runtime);
        }

        public async Task<CreateLoadBalancerHTTPSListenerResponse> CreateLoadBalancerHTTPSListenerAsync(CreateLoadBalancerHTTPSListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerHTTPSListenerWithOptionsAsync(request, runtime);
        }

        public CreateLoadBalancerTCPListenerResponse CreateLoadBalancerTCPListenerWithOptions(CreateLoadBalancerTCPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLoadBalancerTCPListenerResponse>(DoRPCRequest("CreateLoadBalancerTCPListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLoadBalancerTCPListenerResponse> CreateLoadBalancerTCPListenerWithOptionsAsync(CreateLoadBalancerTCPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLoadBalancerTCPListenerResponse>(await DoRPCRequestAsync("CreateLoadBalancerTCPListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLoadBalancerTCPListenerResponse CreateLoadBalancerTCPListener(CreateLoadBalancerTCPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerTCPListenerWithOptions(request, runtime);
        }

        public async Task<CreateLoadBalancerTCPListenerResponse> CreateLoadBalancerTCPListenerAsync(CreateLoadBalancerTCPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerTCPListenerWithOptionsAsync(request, runtime);
        }

        public CreateLoadBalancerUDPListenerResponse CreateLoadBalancerUDPListenerWithOptions(CreateLoadBalancerUDPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLoadBalancerUDPListenerResponse>(DoRPCRequest("CreateLoadBalancerUDPListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLoadBalancerUDPListenerResponse> CreateLoadBalancerUDPListenerWithOptionsAsync(CreateLoadBalancerUDPListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLoadBalancerUDPListenerResponse>(await DoRPCRequestAsync("CreateLoadBalancerUDPListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLoadBalancerUDPListenerResponse CreateLoadBalancerUDPListener(CreateLoadBalancerUDPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoadBalancerUDPListenerWithOptions(request, runtime);
        }

        public async Task<CreateLoadBalancerUDPListenerResponse> CreateLoadBalancerUDPListenerAsync(CreateLoadBalancerUDPListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoadBalancerUDPListenerWithOptionsAsync(request, runtime);
        }

        public CreateMasterSlaveServerGroupResponse CreateMasterSlaveServerGroupWithOptions(CreateMasterSlaveServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMasterSlaveServerGroupResponse>(DoRPCRequest("CreateMasterSlaveServerGroup", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMasterSlaveServerGroupResponse> CreateMasterSlaveServerGroupWithOptionsAsync(CreateMasterSlaveServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMasterSlaveServerGroupResponse>(await DoRPCRequestAsync("CreateMasterSlaveServerGroup", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMasterSlaveServerGroupResponse CreateMasterSlaveServerGroup(CreateMasterSlaveServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMasterSlaveServerGroupWithOptions(request, runtime);
        }

        public async Task<CreateMasterSlaveServerGroupResponse> CreateMasterSlaveServerGroupAsync(CreateMasterSlaveServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMasterSlaveServerGroupWithOptionsAsync(request, runtime);
        }

        public CreateRulesResponse CreateRulesWithOptions(CreateRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRulesResponse>(DoRPCRequest("CreateRules", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRulesResponse> CreateRulesWithOptionsAsync(CreateRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRulesResponse>(await DoRPCRequestAsync("CreateRules", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRulesResponse CreateRules(CreateRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRulesWithOptions(request, runtime);
        }

        public async Task<CreateRulesResponse> CreateRulesAsync(CreateRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRulesWithOptionsAsync(request, runtime);
        }

        public CreateTLSCipherPolicyResponse CreateTLSCipherPolicyWithOptions(CreateTLSCipherPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTLSCipherPolicyResponse>(DoRPCRequest("CreateTLSCipherPolicy", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTLSCipherPolicyResponse> CreateTLSCipherPolicyWithOptionsAsync(CreateTLSCipherPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTLSCipherPolicyResponse>(await DoRPCRequestAsync("CreateTLSCipherPolicy", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTLSCipherPolicyResponse CreateTLSCipherPolicy(CreateTLSCipherPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTLSCipherPolicyWithOptions(request, runtime);
        }

        public async Task<CreateTLSCipherPolicyResponse> CreateTLSCipherPolicyAsync(CreateTLSCipherPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTLSCipherPolicyWithOptionsAsync(request, runtime);
        }

        public CreateVServerGroupResponse CreateVServerGroupWithOptions(CreateVServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVServerGroupResponse>(DoRPCRequest("CreateVServerGroup", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVServerGroupResponse> CreateVServerGroupWithOptionsAsync(CreateVServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVServerGroupResponse>(await DoRPCRequestAsync("CreateVServerGroup", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVServerGroupResponse CreateVServerGroup(CreateVServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVServerGroupWithOptions(request, runtime);
        }

        public async Task<CreateVServerGroupResponse> CreateVServerGroupAsync(CreateVServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVServerGroupWithOptionsAsync(request, runtime);
        }

        public DeleteAccessControlListResponse DeleteAccessControlListWithOptions(DeleteAccessControlListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAccessControlListResponse>(DoRPCRequest("DeleteAccessControlList", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAccessControlListResponse> DeleteAccessControlListWithOptionsAsync(DeleteAccessControlListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAccessControlListResponse>(await DoRPCRequestAsync("DeleteAccessControlList", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAccessControlListResponse DeleteAccessControlList(DeleteAccessControlListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccessControlListWithOptions(request, runtime);
        }

        public async Task<DeleteAccessControlListResponse> DeleteAccessControlListAsync(DeleteAccessControlListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccessControlListWithOptionsAsync(request, runtime);
        }

        public DeleteCACertificateResponse DeleteCACertificateWithOptions(DeleteCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCACertificateResponse>(DoRPCRequest("DeleteCACertificate", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCACertificateResponse> DeleteCACertificateWithOptionsAsync(DeleteCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCACertificateResponse>(await DoRPCRequestAsync("DeleteCACertificate", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCACertificateResponse DeleteCACertificate(DeleteCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCACertificateWithOptions(request, runtime);
        }

        public async Task<DeleteCACertificateResponse> DeleteCACertificateAsync(DeleteCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCACertificateWithOptionsAsync(request, runtime);
        }

        public DeleteDomainExtensionResponse DeleteDomainExtensionWithOptions(DeleteDomainExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainExtensionResponse>(DoRPCRequest("DeleteDomainExtension", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDomainExtensionResponse> DeleteDomainExtensionWithOptionsAsync(DeleteDomainExtensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainExtensionResponse>(await DoRPCRequestAsync("DeleteDomainExtension", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDomainExtensionResponse DeleteDomainExtension(DeleteDomainExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainExtensionWithOptions(request, runtime);
        }

        public async Task<DeleteDomainExtensionResponse> DeleteDomainExtensionAsync(DeleteDomainExtensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainExtensionWithOptionsAsync(request, runtime);
        }

        public DeleteLoadBalancerResponse DeleteLoadBalancerWithOptions(DeleteLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLoadBalancerResponse>(DoRPCRequest("DeleteLoadBalancer", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancerWithOptionsAsync(DeleteLoadBalancerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLoadBalancerResponse>(await DoRPCRequestAsync("DeleteLoadBalancer", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLoadBalancerWithOptions(request, runtime);
        }

        public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLoadBalancerWithOptionsAsync(request, runtime);
        }

        public DeleteLoadBalancerListenerResponse DeleteLoadBalancerListenerWithOptions(DeleteLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLoadBalancerListenerResponse>(DoRPCRequest("DeleteLoadBalancerListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLoadBalancerListenerResponse> DeleteLoadBalancerListenerWithOptionsAsync(DeleteLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLoadBalancerListenerResponse>(await DoRPCRequestAsync("DeleteLoadBalancerListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLoadBalancerListenerResponse DeleteLoadBalancerListener(DeleteLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLoadBalancerListenerWithOptions(request, runtime);
        }

        public async Task<DeleteLoadBalancerListenerResponse> DeleteLoadBalancerListenerAsync(DeleteLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLoadBalancerListenerWithOptionsAsync(request, runtime);
        }

        public DeleteMasterSlaveServerGroupResponse DeleteMasterSlaveServerGroupWithOptions(DeleteMasterSlaveServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMasterSlaveServerGroupResponse>(DoRPCRequest("DeleteMasterSlaveServerGroup", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMasterSlaveServerGroupResponse> DeleteMasterSlaveServerGroupWithOptionsAsync(DeleteMasterSlaveServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMasterSlaveServerGroupResponse>(await DoRPCRequestAsync("DeleteMasterSlaveServerGroup", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMasterSlaveServerGroupResponse DeleteMasterSlaveServerGroup(DeleteMasterSlaveServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMasterSlaveServerGroupWithOptions(request, runtime);
        }

        public async Task<DeleteMasterSlaveServerGroupResponse> DeleteMasterSlaveServerGroupAsync(DeleteMasterSlaveServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMasterSlaveServerGroupWithOptionsAsync(request, runtime);
        }

        public DeleteRulesResponse DeleteRulesWithOptions(DeleteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRulesResponse>(DoRPCRequest("DeleteRules", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRulesResponse> DeleteRulesWithOptionsAsync(DeleteRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRulesResponse>(await DoRPCRequestAsync("DeleteRules", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRulesResponse DeleteRules(DeleteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRulesWithOptions(request, runtime);
        }

        public async Task<DeleteRulesResponse> DeleteRulesAsync(DeleteRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRulesWithOptionsAsync(request, runtime);
        }

        public DeleteServerCertificateResponse DeleteServerCertificateWithOptions(DeleteServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteServerCertificateResponse>(DoRPCRequest("DeleteServerCertificate", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteServerCertificateResponse> DeleteServerCertificateWithOptionsAsync(DeleteServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteServerCertificateResponse>(await DoRPCRequestAsync("DeleteServerCertificate", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServerCertificateWithOptions(request, runtime);
        }

        public async Task<DeleteServerCertificateResponse> DeleteServerCertificateAsync(DeleteServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServerCertificateWithOptionsAsync(request, runtime);
        }

        public DeleteTLSCipherPolicyResponse DeleteTLSCipherPolicyWithOptions(DeleteTLSCipherPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTLSCipherPolicyResponse>(DoRPCRequest("DeleteTLSCipherPolicy", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTLSCipherPolicyResponse> DeleteTLSCipherPolicyWithOptionsAsync(DeleteTLSCipherPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTLSCipherPolicyResponse>(await DoRPCRequestAsync("DeleteTLSCipherPolicy", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTLSCipherPolicyResponse DeleteTLSCipherPolicy(DeleteTLSCipherPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTLSCipherPolicyWithOptions(request, runtime);
        }

        public async Task<DeleteTLSCipherPolicyResponse> DeleteTLSCipherPolicyAsync(DeleteTLSCipherPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTLSCipherPolicyWithOptionsAsync(request, runtime);
        }

        public DeleteVServerGroupResponse DeleteVServerGroupWithOptions(DeleteVServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVServerGroupResponse>(DoRPCRequest("DeleteVServerGroup", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVServerGroupResponse> DeleteVServerGroupWithOptionsAsync(DeleteVServerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVServerGroupResponse>(await DoRPCRequestAsync("DeleteVServerGroup", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVServerGroupResponse DeleteVServerGroup(DeleteVServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVServerGroupWithOptions(request, runtime);
        }

        public async Task<DeleteVServerGroupResponse> DeleteVServerGroupAsync(DeleteVServerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVServerGroupWithOptionsAsync(request, runtime);
        }

        public DescribeAccessControlListAttributeResponse DescribeAccessControlListAttributeWithOptions(DescribeAccessControlListAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccessControlListAttributeResponse>(DoRPCRequest("DescribeAccessControlListAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccessControlListAttributeResponse> DescribeAccessControlListAttributeWithOptionsAsync(DescribeAccessControlListAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccessControlListAttributeResponse>(await DoRPCRequestAsync("DescribeAccessControlListAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccessControlListAttributeResponse DescribeAccessControlListAttribute(DescribeAccessControlListAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessControlListAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeAccessControlListAttributeResponse> DescribeAccessControlListAttributeAsync(DescribeAccessControlListAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessControlListAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeAccessControlListsResponse DescribeAccessControlListsWithOptions(DescribeAccessControlListsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccessControlListsResponse>(DoRPCRequest("DescribeAccessControlLists", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccessControlListsResponse> DescribeAccessControlListsWithOptionsAsync(DescribeAccessControlListsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccessControlListsResponse>(await DoRPCRequestAsync("DescribeAccessControlLists", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccessControlListsResponse DescribeAccessControlLists(DescribeAccessControlListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessControlListsWithOptions(request, runtime);
        }

        public async Task<DescribeAccessControlListsResponse> DescribeAccessControlListsAsync(DescribeAccessControlListsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessControlListsWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(DoRPCRequest("DescribeAvailableResource", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await DoRPCRequestAsync("DescribeAvailableResource", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableResourceResponse DescribeAvailableResource(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(request, runtime);
        }

        public DescribeCACertificatesResponse DescribeCACertificatesWithOptions(DescribeCACertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCACertificatesResponse>(DoRPCRequest("DescribeCACertificates", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCACertificatesResponse> DescribeCACertificatesWithOptionsAsync(DescribeCACertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCACertificatesResponse>(await DoRPCRequestAsync("DescribeCACertificates", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCACertificatesResponse DescribeCACertificates(DescribeCACertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCACertificatesWithOptions(request, runtime);
        }

        public async Task<DescribeCACertificatesResponse> DescribeCACertificatesAsync(DescribeCACertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCACertificatesWithOptionsAsync(request, runtime);
        }

        public DescribeDomainExtensionAttributeResponse DescribeDomainExtensionAttributeWithOptions(DescribeDomainExtensionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainExtensionAttributeResponse>(DoRPCRequest("DescribeDomainExtensionAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainExtensionAttributeResponse> DescribeDomainExtensionAttributeWithOptionsAsync(DescribeDomainExtensionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainExtensionAttributeResponse>(await DoRPCRequestAsync("DescribeDomainExtensionAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainExtensionAttributeResponse DescribeDomainExtensionAttribute(DescribeDomainExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainExtensionAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeDomainExtensionAttributeResponse> DescribeDomainExtensionAttributeAsync(DescribeDomainExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainExtensionAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeDomainExtensionsResponse DescribeDomainExtensionsWithOptions(DescribeDomainExtensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainExtensionsResponse>(DoRPCRequest("DescribeDomainExtensions", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainExtensionsResponse> DescribeDomainExtensionsWithOptionsAsync(DescribeDomainExtensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainExtensionsResponse>(await DoRPCRequestAsync("DescribeDomainExtensions", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainExtensionsResponse DescribeDomainExtensions(DescribeDomainExtensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainExtensionsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainExtensionsResponse> DescribeDomainExtensionsAsync(DescribeDomainExtensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainExtensionsWithOptionsAsync(request, runtime);
        }

        public DescribeHealthStatusResponse DescribeHealthStatusWithOptions(DescribeHealthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthStatusResponse>(DoRPCRequest("DescribeHealthStatus", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHealthStatusResponse> DescribeHealthStatusWithOptionsAsync(DescribeHealthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthStatusResponse>(await DoRPCRequestAsync("DescribeHealthStatus", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHealthStatusResponse DescribeHealthStatus(DescribeHealthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHealthStatusWithOptions(request, runtime);
        }

        public async Task<DescribeHealthStatusResponse> DescribeHealthStatusAsync(DescribeHealthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHealthStatusWithOptionsAsync(request, runtime);
        }

        public DescribeListenerAccessControlAttributeResponse DescribeListenerAccessControlAttributeWithOptions(DescribeListenerAccessControlAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeListenerAccessControlAttributeResponse>(DoRPCRequest("DescribeListenerAccessControlAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeListenerAccessControlAttributeResponse> DescribeListenerAccessControlAttributeWithOptionsAsync(DescribeListenerAccessControlAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeListenerAccessControlAttributeResponse>(await DoRPCRequestAsync("DescribeListenerAccessControlAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeListenerAccessControlAttributeResponse DescribeListenerAccessControlAttribute(DescribeListenerAccessControlAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeListenerAccessControlAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeListenerAccessControlAttributeResponse> DescribeListenerAccessControlAttributeAsync(DescribeListenerAccessControlAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeListenerAccessControlAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeLoadBalancerAttributeResponse DescribeLoadBalancerAttributeWithOptions(DescribeLoadBalancerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoadBalancerAttributeResponse>(DoRPCRequest("DescribeLoadBalancerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLoadBalancerAttributeResponse> DescribeLoadBalancerAttributeWithOptionsAsync(DescribeLoadBalancerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoadBalancerAttributeResponse>(await DoRPCRequestAsync("DescribeLoadBalancerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLoadBalancerAttributeResponse DescribeLoadBalancerAttribute(DescribeLoadBalancerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeLoadBalancerAttributeResponse> DescribeLoadBalancerAttributeAsync(DescribeLoadBalancerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeLoadBalancerHTTPListenerAttributeResponse DescribeLoadBalancerHTTPListenerAttributeWithOptions(DescribeLoadBalancerHTTPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoadBalancerHTTPListenerAttributeResponse>(DoRPCRequest("DescribeLoadBalancerHTTPListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLoadBalancerHTTPListenerAttributeResponse> DescribeLoadBalancerHTTPListenerAttributeWithOptionsAsync(DescribeLoadBalancerHTTPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoadBalancerHTTPListenerAttributeResponse>(await DoRPCRequestAsync("DescribeLoadBalancerHTTPListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLoadBalancerHTTPListenerAttributeResponse DescribeLoadBalancerHTTPListenerAttribute(DescribeLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerHTTPListenerAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeLoadBalancerHTTPListenerAttributeResponse> DescribeLoadBalancerHTTPListenerAttributeAsync(DescribeLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerHTTPListenerAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeLoadBalancerHTTPSListenerAttributeResponse DescribeLoadBalancerHTTPSListenerAttributeWithOptions(DescribeLoadBalancerHTTPSListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoadBalancerHTTPSListenerAttributeResponse>(DoRPCRequest("DescribeLoadBalancerHTTPSListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLoadBalancerHTTPSListenerAttributeResponse> DescribeLoadBalancerHTTPSListenerAttributeWithOptionsAsync(DescribeLoadBalancerHTTPSListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoadBalancerHTTPSListenerAttributeResponse>(await DoRPCRequestAsync("DescribeLoadBalancerHTTPSListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLoadBalancerHTTPSListenerAttributeResponse DescribeLoadBalancerHTTPSListenerAttribute(DescribeLoadBalancerHTTPSListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerHTTPSListenerAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeLoadBalancerHTTPSListenerAttributeResponse> DescribeLoadBalancerHTTPSListenerAttributeAsync(DescribeLoadBalancerHTTPSListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerHTTPSListenerAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeLoadBalancersResponse DescribeLoadBalancersWithOptions(DescribeLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoadBalancersResponse>(DoRPCRequest("DescribeLoadBalancers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLoadBalancersResponse> DescribeLoadBalancersWithOptionsAsync(DescribeLoadBalancersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoadBalancersResponse>(await DoRPCRequestAsync("DescribeLoadBalancers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancersWithOptions(request, runtime);
        }

        public async Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancersWithOptionsAsync(request, runtime);
        }

        public DescribeLoadBalancerTCPListenerAttributeResponse DescribeLoadBalancerTCPListenerAttributeWithOptions(DescribeLoadBalancerTCPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoadBalancerTCPListenerAttributeResponse>(DoRPCRequest("DescribeLoadBalancerTCPListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLoadBalancerTCPListenerAttributeResponse> DescribeLoadBalancerTCPListenerAttributeWithOptionsAsync(DescribeLoadBalancerTCPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoadBalancerTCPListenerAttributeResponse>(await DoRPCRequestAsync("DescribeLoadBalancerTCPListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLoadBalancerTCPListenerAttributeResponse DescribeLoadBalancerTCPListenerAttribute(DescribeLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerTCPListenerAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeLoadBalancerTCPListenerAttributeResponse> DescribeLoadBalancerTCPListenerAttributeAsync(DescribeLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerTCPListenerAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeLoadBalancerUDPListenerAttributeResponse DescribeLoadBalancerUDPListenerAttributeWithOptions(DescribeLoadBalancerUDPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoadBalancerUDPListenerAttributeResponse>(DoRPCRequest("DescribeLoadBalancerUDPListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLoadBalancerUDPListenerAttributeResponse> DescribeLoadBalancerUDPListenerAttributeWithOptionsAsync(DescribeLoadBalancerUDPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoadBalancerUDPListenerAttributeResponse>(await DoRPCRequestAsync("DescribeLoadBalancerUDPListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLoadBalancerUDPListenerAttributeResponse DescribeLoadBalancerUDPListenerAttribute(DescribeLoadBalancerUDPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoadBalancerUDPListenerAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeLoadBalancerUDPListenerAttributeResponse> DescribeLoadBalancerUDPListenerAttributeAsync(DescribeLoadBalancerUDPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoadBalancerUDPListenerAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeMasterSlaveServerGroupAttributeResponse DescribeMasterSlaveServerGroupAttributeWithOptions(DescribeMasterSlaveServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMasterSlaveServerGroupAttributeResponse>(DoRPCRequest("DescribeMasterSlaveServerGroupAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMasterSlaveServerGroupAttributeResponse> DescribeMasterSlaveServerGroupAttributeWithOptionsAsync(DescribeMasterSlaveServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMasterSlaveServerGroupAttributeResponse>(await DoRPCRequestAsync("DescribeMasterSlaveServerGroupAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMasterSlaveServerGroupAttributeResponse DescribeMasterSlaveServerGroupAttribute(DescribeMasterSlaveServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMasterSlaveServerGroupAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeMasterSlaveServerGroupAttributeResponse> DescribeMasterSlaveServerGroupAttributeAsync(DescribeMasterSlaveServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMasterSlaveServerGroupAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeMasterSlaveServerGroupsResponse DescribeMasterSlaveServerGroupsWithOptions(DescribeMasterSlaveServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMasterSlaveServerGroupsResponse>(DoRPCRequest("DescribeMasterSlaveServerGroups", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMasterSlaveServerGroupsResponse> DescribeMasterSlaveServerGroupsWithOptionsAsync(DescribeMasterSlaveServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMasterSlaveServerGroupsResponse>(await DoRPCRequestAsync("DescribeMasterSlaveServerGroups", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMasterSlaveServerGroupsResponse DescribeMasterSlaveServerGroups(DescribeMasterSlaveServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMasterSlaveServerGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeMasterSlaveServerGroupsResponse> DescribeMasterSlaveServerGroupsAsync(DescribeMasterSlaveServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMasterSlaveServerGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeRuleAttributeResponse DescribeRuleAttributeWithOptions(DescribeRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRuleAttributeResponse>(DoRPCRequest("DescribeRuleAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRuleAttributeResponse> DescribeRuleAttributeWithOptionsAsync(DescribeRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRuleAttributeResponse>(await DoRPCRequestAsync("DescribeRuleAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRuleAttributeResponse DescribeRuleAttribute(DescribeRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRuleAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeRuleAttributeResponse> DescribeRuleAttributeAsync(DescribeRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRuleAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeRulesResponse DescribeRulesWithOptions(DescribeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRulesResponse>(DoRPCRequest("DescribeRules", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRulesResponse> DescribeRulesWithOptionsAsync(DescribeRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRulesResponse>(await DoRPCRequestAsync("DescribeRules", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRulesResponse DescribeRules(DescribeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRulesWithOptions(request, runtime);
        }

        public async Task<DescribeRulesResponse> DescribeRulesAsync(DescribeRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRulesWithOptionsAsync(request, runtime);
        }

        public DescribeServerCertificatesResponse DescribeServerCertificatesWithOptions(DescribeServerCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServerCertificatesResponse>(DoRPCRequest("DescribeServerCertificates", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeServerCertificatesResponse> DescribeServerCertificatesWithOptionsAsync(DescribeServerCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeServerCertificatesResponse>(await DoRPCRequestAsync("DescribeServerCertificates", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeServerCertificatesResponse DescribeServerCertificates(DescribeServerCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeServerCertificatesWithOptions(request, runtime);
        }

        public async Task<DescribeServerCertificatesResponse> DescribeServerCertificatesAsync(DescribeServerCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeServerCertificatesWithOptionsAsync(request, runtime);
        }

        public DescribeTagsResponse DescribeTagsWithOptions(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagsResponse>(DoRPCRequest("DescribeTags", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTagsResponse> DescribeTagsWithOptionsAsync(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagsResponse>(await DoRPCRequestAsync("DescribeTags", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeVServerGroupAttributeResponse DescribeVServerGroupAttributeWithOptions(DescribeVServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVServerGroupAttributeResponse>(DoRPCRequest("DescribeVServerGroupAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVServerGroupAttributeResponse> DescribeVServerGroupAttributeWithOptionsAsync(DescribeVServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVServerGroupAttributeResponse>(await DoRPCRequestAsync("DescribeVServerGroupAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVServerGroupAttributeResponse DescribeVServerGroupAttribute(DescribeVServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVServerGroupAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeVServerGroupAttributeResponse> DescribeVServerGroupAttributeAsync(DescribeVServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVServerGroupAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeVServerGroupsResponse DescribeVServerGroupsWithOptions(DescribeVServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVServerGroupsResponse>(DoRPCRequest("DescribeVServerGroups", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVServerGroupsResponse> DescribeVServerGroupsWithOptionsAsync(DescribeVServerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVServerGroupsResponse>(await DoRPCRequestAsync("DescribeVServerGroups", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVServerGroupsResponse DescribeVServerGroups(DescribeVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVServerGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeVServerGroupsResponse> DescribeVServerGroupsAsync(DescribeVServerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVServerGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(DoRPCRequest("DescribeZones", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await DoRPCRequestAsync("DescribeZones", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListTLSCipherPoliciesResponse ListTLSCipherPoliciesWithOptions(ListTLSCipherPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTLSCipherPoliciesResponse>(DoRPCRequest("ListTLSCipherPolicies", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTLSCipherPoliciesResponse> ListTLSCipherPoliciesWithOptionsAsync(ListTLSCipherPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTLSCipherPoliciesResponse>(await DoRPCRequestAsync("ListTLSCipherPolicies", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTLSCipherPoliciesResponse ListTLSCipherPolicies(ListTLSCipherPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTLSCipherPoliciesWithOptions(request, runtime);
        }

        public async Task<ListTLSCipherPoliciesResponse> ListTLSCipherPoliciesAsync(ListTLSCipherPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTLSCipherPoliciesWithOptionsAsync(request, runtime);
        }

        public ModifyLoadBalancerInstanceSpecResponse ModifyLoadBalancerInstanceSpecWithOptions(ModifyLoadBalancerInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLoadBalancerInstanceSpecResponse>(DoRPCRequest("ModifyLoadBalancerInstanceSpec", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLoadBalancerInstanceSpecResponse> ModifyLoadBalancerInstanceSpecWithOptionsAsync(ModifyLoadBalancerInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLoadBalancerInstanceSpecResponse>(await DoRPCRequestAsync("ModifyLoadBalancerInstanceSpec", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLoadBalancerInstanceSpecResponse ModifyLoadBalancerInstanceSpec(ModifyLoadBalancerInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoadBalancerInstanceSpecWithOptions(request, runtime);
        }

        public async Task<ModifyLoadBalancerInstanceSpecResponse> ModifyLoadBalancerInstanceSpecAsync(ModifyLoadBalancerInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoadBalancerInstanceSpecWithOptionsAsync(request, runtime);
        }

        public ModifyLoadBalancerInternetSpecResponse ModifyLoadBalancerInternetSpecWithOptions(ModifyLoadBalancerInternetSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLoadBalancerInternetSpecResponse>(DoRPCRequest("ModifyLoadBalancerInternetSpec", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLoadBalancerInternetSpecResponse> ModifyLoadBalancerInternetSpecWithOptionsAsync(ModifyLoadBalancerInternetSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLoadBalancerInternetSpecResponse>(await DoRPCRequestAsync("ModifyLoadBalancerInternetSpec", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLoadBalancerInternetSpecResponse ModifyLoadBalancerInternetSpec(ModifyLoadBalancerInternetSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoadBalancerInternetSpecWithOptions(request, runtime);
        }

        public async Task<ModifyLoadBalancerInternetSpecResponse> ModifyLoadBalancerInternetSpecAsync(ModifyLoadBalancerInternetSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoadBalancerInternetSpecWithOptionsAsync(request, runtime);
        }

        public ModifyLoadBalancerPayTypeResponse ModifyLoadBalancerPayTypeWithOptions(ModifyLoadBalancerPayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLoadBalancerPayTypeResponse>(DoRPCRequest("ModifyLoadBalancerPayType", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLoadBalancerPayTypeResponse> ModifyLoadBalancerPayTypeWithOptionsAsync(ModifyLoadBalancerPayTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLoadBalancerPayTypeResponse>(await DoRPCRequestAsync("ModifyLoadBalancerPayType", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLoadBalancerPayTypeResponse ModifyLoadBalancerPayType(ModifyLoadBalancerPayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLoadBalancerPayTypeWithOptions(request, runtime);
        }

        public async Task<ModifyLoadBalancerPayTypeResponse> ModifyLoadBalancerPayTypeAsync(ModifyLoadBalancerPayTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLoadBalancerPayTypeWithOptionsAsync(request, runtime);
        }

        public ModifyVServerGroupBackendServersResponse ModifyVServerGroupBackendServersWithOptions(ModifyVServerGroupBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVServerGroupBackendServersResponse>(DoRPCRequest("ModifyVServerGroupBackendServers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVServerGroupBackendServersResponse> ModifyVServerGroupBackendServersWithOptionsAsync(ModifyVServerGroupBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVServerGroupBackendServersResponse>(await DoRPCRequestAsync("ModifyVServerGroupBackendServers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVServerGroupBackendServersResponse ModifyVServerGroupBackendServers(ModifyVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVServerGroupBackendServersWithOptions(request, runtime);
        }

        public async Task<ModifyVServerGroupBackendServersResponse> ModifyVServerGroupBackendServersAsync(ModifyVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVServerGroupBackendServersWithOptionsAsync(request, runtime);
        }

        public RemoveAccessControlListEntryResponse RemoveAccessControlListEntryWithOptions(RemoveAccessControlListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveAccessControlListEntryResponse>(DoRPCRequest("RemoveAccessControlListEntry", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveAccessControlListEntryResponse> RemoveAccessControlListEntryWithOptionsAsync(RemoveAccessControlListEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveAccessControlListEntryResponse>(await DoRPCRequestAsync("RemoveAccessControlListEntry", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveAccessControlListEntryResponse RemoveAccessControlListEntry(RemoveAccessControlListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveAccessControlListEntryWithOptions(request, runtime);
        }

        public async Task<RemoveAccessControlListEntryResponse> RemoveAccessControlListEntryAsync(RemoveAccessControlListEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveAccessControlListEntryWithOptionsAsync(request, runtime);
        }

        public RemoveBackendServersResponse RemoveBackendServersWithOptions(RemoveBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveBackendServersResponse>(DoRPCRequest("RemoveBackendServers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveBackendServersResponse> RemoveBackendServersWithOptionsAsync(RemoveBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveBackendServersResponse>(await DoRPCRequestAsync("RemoveBackendServers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveBackendServersResponse RemoveBackendServers(RemoveBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveBackendServersWithOptions(request, runtime);
        }

        public async Task<RemoveBackendServersResponse> RemoveBackendServersAsync(RemoveBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveBackendServersWithOptionsAsync(request, runtime);
        }

        public RemoveListenerWhiteListItemResponse RemoveListenerWhiteListItemWithOptions(RemoveListenerWhiteListItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveListenerWhiteListItemResponse>(DoRPCRequest("RemoveListenerWhiteListItem", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveListenerWhiteListItemResponse> RemoveListenerWhiteListItemWithOptionsAsync(RemoveListenerWhiteListItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveListenerWhiteListItemResponse>(await DoRPCRequestAsync("RemoveListenerWhiteListItem", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveListenerWhiteListItemResponse RemoveListenerWhiteListItem(RemoveListenerWhiteListItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveListenerWhiteListItemWithOptions(request, runtime);
        }

        public async Task<RemoveListenerWhiteListItemResponse> RemoveListenerWhiteListItemAsync(RemoveListenerWhiteListItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveListenerWhiteListItemWithOptionsAsync(request, runtime);
        }

        public RemoveTagsResponse RemoveTagsWithOptions(RemoveTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTagsResponse>(DoRPCRequest("RemoveTags", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveTagsResponse> RemoveTagsWithOptionsAsync(RemoveTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTagsResponse>(await DoRPCRequestAsync("RemoveTags", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagsWithOptions(request, runtime);
        }

        public async Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagsWithOptionsAsync(request, runtime);
        }

        public RemoveVServerGroupBackendServersResponse RemoveVServerGroupBackendServersWithOptions(RemoveVServerGroupBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveVServerGroupBackendServersResponse>(DoRPCRequest("RemoveVServerGroupBackendServers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveVServerGroupBackendServersResponse> RemoveVServerGroupBackendServersWithOptionsAsync(RemoveVServerGroupBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveVServerGroupBackendServersResponse>(await DoRPCRequestAsync("RemoveVServerGroupBackendServers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveVServerGroupBackendServersResponse RemoveVServerGroupBackendServers(RemoveVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveVServerGroupBackendServersWithOptions(request, runtime);
        }

        public async Task<RemoveVServerGroupBackendServersResponse> RemoveVServerGroupBackendServersAsync(RemoveVServerGroupBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveVServerGroupBackendServersWithOptionsAsync(request, runtime);
        }

        public SetAccessControlListAttributeResponse SetAccessControlListAttributeWithOptions(SetAccessControlListAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAccessControlListAttributeResponse>(DoRPCRequest("SetAccessControlListAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetAccessControlListAttributeResponse> SetAccessControlListAttributeWithOptionsAsync(SetAccessControlListAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAccessControlListAttributeResponse>(await DoRPCRequestAsync("SetAccessControlListAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetAccessControlListAttributeResponse SetAccessControlListAttribute(SetAccessControlListAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAccessControlListAttributeWithOptions(request, runtime);
        }

        public async Task<SetAccessControlListAttributeResponse> SetAccessControlListAttributeAsync(SetAccessControlListAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAccessControlListAttributeWithOptionsAsync(request, runtime);
        }

        public SetBackendServersResponse SetBackendServersWithOptions(SetBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetBackendServersResponse>(DoRPCRequest("SetBackendServers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetBackendServersResponse> SetBackendServersWithOptionsAsync(SetBackendServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetBackendServersResponse>(await DoRPCRequestAsync("SetBackendServers", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetBackendServersResponse SetBackendServers(SetBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetBackendServersWithOptions(request, runtime);
        }

        public async Task<SetBackendServersResponse> SetBackendServersAsync(SetBackendServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetBackendServersWithOptionsAsync(request, runtime);
        }

        public SetCACertificateNameResponse SetCACertificateNameWithOptions(SetCACertificateNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCACertificateNameResponse>(DoRPCRequest("SetCACertificateName", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetCACertificateNameResponse> SetCACertificateNameWithOptionsAsync(SetCACertificateNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCACertificateNameResponse>(await DoRPCRequestAsync("SetCACertificateName", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetCACertificateNameResponse SetCACertificateName(SetCACertificateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCACertificateNameWithOptions(request, runtime);
        }

        public async Task<SetCACertificateNameResponse> SetCACertificateNameAsync(SetCACertificateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCACertificateNameWithOptionsAsync(request, runtime);
        }

        public SetDomainExtensionAttributeResponse SetDomainExtensionAttributeWithOptions(SetDomainExtensionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainExtensionAttributeResponse>(DoRPCRequest("SetDomainExtensionAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDomainExtensionAttributeResponse> SetDomainExtensionAttributeWithOptionsAsync(SetDomainExtensionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainExtensionAttributeResponse>(await DoRPCRequestAsync("SetDomainExtensionAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDomainExtensionAttributeResponse SetDomainExtensionAttribute(SetDomainExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainExtensionAttributeWithOptions(request, runtime);
        }

        public async Task<SetDomainExtensionAttributeResponse> SetDomainExtensionAttributeAsync(SetDomainExtensionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainExtensionAttributeWithOptionsAsync(request, runtime);
        }

        public SetListenerAccessControlStatusResponse SetListenerAccessControlStatusWithOptions(SetListenerAccessControlStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetListenerAccessControlStatusResponse>(DoRPCRequest("SetListenerAccessControlStatus", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetListenerAccessControlStatusResponse> SetListenerAccessControlStatusWithOptionsAsync(SetListenerAccessControlStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetListenerAccessControlStatusResponse>(await DoRPCRequestAsync("SetListenerAccessControlStatus", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetListenerAccessControlStatusResponse SetListenerAccessControlStatus(SetListenerAccessControlStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetListenerAccessControlStatusWithOptions(request, runtime);
        }

        public async Task<SetListenerAccessControlStatusResponse> SetListenerAccessControlStatusAsync(SetListenerAccessControlStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetListenerAccessControlStatusWithOptionsAsync(request, runtime);
        }

        public SetLoadBalancerDeleteProtectionResponse SetLoadBalancerDeleteProtectionWithOptions(SetLoadBalancerDeleteProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerDeleteProtectionResponse>(DoRPCRequest("SetLoadBalancerDeleteProtection", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLoadBalancerDeleteProtectionResponse> SetLoadBalancerDeleteProtectionWithOptionsAsync(SetLoadBalancerDeleteProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerDeleteProtectionResponse>(await DoRPCRequestAsync("SetLoadBalancerDeleteProtection", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLoadBalancerDeleteProtectionResponse SetLoadBalancerDeleteProtection(SetLoadBalancerDeleteProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerDeleteProtectionWithOptions(request, runtime);
        }

        public async Task<SetLoadBalancerDeleteProtectionResponse> SetLoadBalancerDeleteProtectionAsync(SetLoadBalancerDeleteProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerDeleteProtectionWithOptionsAsync(request, runtime);
        }

        public SetLoadBalancerHTTPListenerAttributeResponse SetLoadBalancerHTTPListenerAttributeWithOptions(SetLoadBalancerHTTPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerHTTPListenerAttributeResponse>(DoRPCRequest("SetLoadBalancerHTTPListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLoadBalancerHTTPListenerAttributeResponse> SetLoadBalancerHTTPListenerAttributeWithOptionsAsync(SetLoadBalancerHTTPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerHTTPListenerAttributeResponse>(await DoRPCRequestAsync("SetLoadBalancerHTTPListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLoadBalancerHTTPListenerAttributeResponse SetLoadBalancerHTTPListenerAttribute(SetLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerHTTPListenerAttributeWithOptions(request, runtime);
        }

        public async Task<SetLoadBalancerHTTPListenerAttributeResponse> SetLoadBalancerHTTPListenerAttributeAsync(SetLoadBalancerHTTPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerHTTPListenerAttributeWithOptionsAsync(request, runtime);
        }

        public SetLoadBalancerHTTPSListenerAttributeResponse SetLoadBalancerHTTPSListenerAttributeWithOptions(SetLoadBalancerHTTPSListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerHTTPSListenerAttributeResponse>(DoRPCRequest("SetLoadBalancerHTTPSListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLoadBalancerHTTPSListenerAttributeResponse> SetLoadBalancerHTTPSListenerAttributeWithOptionsAsync(SetLoadBalancerHTTPSListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerHTTPSListenerAttributeResponse>(await DoRPCRequestAsync("SetLoadBalancerHTTPSListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLoadBalancerHTTPSListenerAttributeResponse SetLoadBalancerHTTPSListenerAttribute(SetLoadBalancerHTTPSListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerHTTPSListenerAttributeWithOptions(request, runtime);
        }

        public async Task<SetLoadBalancerHTTPSListenerAttributeResponse> SetLoadBalancerHTTPSListenerAttributeAsync(SetLoadBalancerHTTPSListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerHTTPSListenerAttributeWithOptionsAsync(request, runtime);
        }

        public SetLoadBalancerModificationProtectionResponse SetLoadBalancerModificationProtectionWithOptions(SetLoadBalancerModificationProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerModificationProtectionResponse>(DoRPCRequest("SetLoadBalancerModificationProtection", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLoadBalancerModificationProtectionResponse> SetLoadBalancerModificationProtectionWithOptionsAsync(SetLoadBalancerModificationProtectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerModificationProtectionResponse>(await DoRPCRequestAsync("SetLoadBalancerModificationProtection", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLoadBalancerModificationProtectionResponse SetLoadBalancerModificationProtection(SetLoadBalancerModificationProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerModificationProtectionWithOptions(request, runtime);
        }

        public async Task<SetLoadBalancerModificationProtectionResponse> SetLoadBalancerModificationProtectionAsync(SetLoadBalancerModificationProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerModificationProtectionWithOptionsAsync(request, runtime);
        }

        public SetLoadBalancerNameResponse SetLoadBalancerNameWithOptions(SetLoadBalancerNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerNameResponse>(DoRPCRequest("SetLoadBalancerName", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLoadBalancerNameResponse> SetLoadBalancerNameWithOptionsAsync(SetLoadBalancerNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerNameResponse>(await DoRPCRequestAsync("SetLoadBalancerName", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLoadBalancerNameResponse SetLoadBalancerName(SetLoadBalancerNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerNameWithOptions(request, runtime);
        }

        public async Task<SetLoadBalancerNameResponse> SetLoadBalancerNameAsync(SetLoadBalancerNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerNameWithOptionsAsync(request, runtime);
        }

        public SetLoadBalancerStatusResponse SetLoadBalancerStatusWithOptions(SetLoadBalancerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerStatusResponse>(DoRPCRequest("SetLoadBalancerStatus", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLoadBalancerStatusResponse> SetLoadBalancerStatusWithOptionsAsync(SetLoadBalancerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerStatusResponse>(await DoRPCRequestAsync("SetLoadBalancerStatus", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLoadBalancerStatusResponse SetLoadBalancerStatus(SetLoadBalancerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerStatusWithOptions(request, runtime);
        }

        public async Task<SetLoadBalancerStatusResponse> SetLoadBalancerStatusAsync(SetLoadBalancerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerStatusWithOptionsAsync(request, runtime);
        }

        public SetLoadBalancerTCPListenerAttributeResponse SetLoadBalancerTCPListenerAttributeWithOptions(SetLoadBalancerTCPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerTCPListenerAttributeResponse>(DoRPCRequest("SetLoadBalancerTCPListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLoadBalancerTCPListenerAttributeResponse> SetLoadBalancerTCPListenerAttributeWithOptionsAsync(SetLoadBalancerTCPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerTCPListenerAttributeResponse>(await DoRPCRequestAsync("SetLoadBalancerTCPListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLoadBalancerTCPListenerAttributeResponse SetLoadBalancerTCPListenerAttribute(SetLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerTCPListenerAttributeWithOptions(request, runtime);
        }

        public async Task<SetLoadBalancerTCPListenerAttributeResponse> SetLoadBalancerTCPListenerAttributeAsync(SetLoadBalancerTCPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerTCPListenerAttributeWithOptionsAsync(request, runtime);
        }

        public SetLoadBalancerUDPListenerAttributeResponse SetLoadBalancerUDPListenerAttributeWithOptions(SetLoadBalancerUDPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerUDPListenerAttributeResponse>(DoRPCRequest("SetLoadBalancerUDPListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLoadBalancerUDPListenerAttributeResponse> SetLoadBalancerUDPListenerAttributeWithOptionsAsync(SetLoadBalancerUDPListenerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLoadBalancerUDPListenerAttributeResponse>(await DoRPCRequestAsync("SetLoadBalancerUDPListenerAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLoadBalancerUDPListenerAttributeResponse SetLoadBalancerUDPListenerAttribute(SetLoadBalancerUDPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLoadBalancerUDPListenerAttributeWithOptions(request, runtime);
        }

        public async Task<SetLoadBalancerUDPListenerAttributeResponse> SetLoadBalancerUDPListenerAttributeAsync(SetLoadBalancerUDPListenerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLoadBalancerUDPListenerAttributeWithOptionsAsync(request, runtime);
        }

        public SetRuleResponse SetRuleWithOptions(SetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetRuleResponse>(DoRPCRequest("SetRule", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetRuleResponse> SetRuleWithOptionsAsync(SetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetRuleResponse>(await DoRPCRequestAsync("SetRule", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetRuleResponse SetRule(SetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetRuleWithOptions(request, runtime);
        }

        public async Task<SetRuleResponse> SetRuleAsync(SetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetRuleWithOptionsAsync(request, runtime);
        }

        public SetServerCertificateNameResponse SetServerCertificateNameWithOptions(SetServerCertificateNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetServerCertificateNameResponse>(DoRPCRequest("SetServerCertificateName", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetServerCertificateNameResponse> SetServerCertificateNameWithOptionsAsync(SetServerCertificateNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetServerCertificateNameResponse>(await DoRPCRequestAsync("SetServerCertificateName", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetServerCertificateNameResponse SetServerCertificateName(SetServerCertificateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetServerCertificateNameWithOptions(request, runtime);
        }

        public async Task<SetServerCertificateNameResponse> SetServerCertificateNameAsync(SetServerCertificateNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetServerCertificateNameWithOptionsAsync(request, runtime);
        }

        public SetTLSCipherPolicyAttributeResponse SetTLSCipherPolicyAttributeWithOptions(SetTLSCipherPolicyAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetTLSCipherPolicyAttributeResponse>(DoRPCRequest("SetTLSCipherPolicyAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetTLSCipherPolicyAttributeResponse> SetTLSCipherPolicyAttributeWithOptionsAsync(SetTLSCipherPolicyAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetTLSCipherPolicyAttributeResponse>(await DoRPCRequestAsync("SetTLSCipherPolicyAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetTLSCipherPolicyAttributeResponse SetTLSCipherPolicyAttribute(SetTLSCipherPolicyAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetTLSCipherPolicyAttributeWithOptions(request, runtime);
        }

        public async Task<SetTLSCipherPolicyAttributeResponse> SetTLSCipherPolicyAttributeAsync(SetTLSCipherPolicyAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetTLSCipherPolicyAttributeWithOptionsAsync(request, runtime);
        }

        public SetVServerGroupAttributeResponse SetVServerGroupAttributeWithOptions(SetVServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetVServerGroupAttributeResponse>(DoRPCRequest("SetVServerGroupAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetVServerGroupAttributeResponse> SetVServerGroupAttributeWithOptionsAsync(SetVServerGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetVServerGroupAttributeResponse>(await DoRPCRequestAsync("SetVServerGroupAttribute", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetVServerGroupAttributeResponse SetVServerGroupAttribute(SetVServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetVServerGroupAttributeWithOptions(request, runtime);
        }

        public async Task<SetVServerGroupAttributeResponse> SetVServerGroupAttributeAsync(SetVServerGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetVServerGroupAttributeWithOptionsAsync(request, runtime);
        }

        public StartLoadBalancerListenerResponse StartLoadBalancerListenerWithOptions(StartLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartLoadBalancerListenerResponse>(DoRPCRequest("StartLoadBalancerListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartLoadBalancerListenerResponse> StartLoadBalancerListenerWithOptionsAsync(StartLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartLoadBalancerListenerResponse>(await DoRPCRequestAsync("StartLoadBalancerListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartLoadBalancerListenerResponse StartLoadBalancerListener(StartLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartLoadBalancerListenerWithOptions(request, runtime);
        }

        public async Task<StartLoadBalancerListenerResponse> StartLoadBalancerListenerAsync(StartLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartLoadBalancerListenerWithOptionsAsync(request, runtime);
        }

        public StopLoadBalancerListenerResponse StopLoadBalancerListenerWithOptions(StopLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopLoadBalancerListenerResponse>(DoRPCRequest("StopLoadBalancerListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopLoadBalancerListenerResponse> StopLoadBalancerListenerWithOptionsAsync(StopLoadBalancerListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopLoadBalancerListenerResponse>(await DoRPCRequestAsync("StopLoadBalancerListener", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopLoadBalancerListenerResponse StopLoadBalancerListener(StopLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopLoadBalancerListenerWithOptions(request, runtime);
        }

        public async Task<StopLoadBalancerListenerResponse> StopLoadBalancerListenerAsync(StopLoadBalancerListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopLoadBalancerListenerWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UploadCACertificateResponse UploadCACertificateWithOptions(UploadCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadCACertificateResponse>(DoRPCRequest("UploadCACertificate", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadCACertificateResponse> UploadCACertificateWithOptionsAsync(UploadCACertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadCACertificateResponse>(await DoRPCRequestAsync("UploadCACertificate", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadCACertificateResponse UploadCACertificate(UploadCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadCACertificateWithOptions(request, runtime);
        }

        public async Task<UploadCACertificateResponse> UploadCACertificateAsync(UploadCACertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadCACertificateWithOptionsAsync(request, runtime);
        }

        public UploadServerCertificateResponse UploadServerCertificateWithOptions(UploadServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadServerCertificateResponse>(DoRPCRequest("UploadServerCertificate", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadServerCertificateResponse> UploadServerCertificateWithOptionsAsync(UploadServerCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadServerCertificateResponse>(await DoRPCRequestAsync("UploadServerCertificate", "2014-05-15", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadServerCertificateWithOptions(request, runtime);
        }

        public async Task<UploadServerCertificateResponse> UploadServerCertificateAsync(UploadServerCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadServerCertificateWithOptionsAsync(request, runtime);
        }

    }
}
