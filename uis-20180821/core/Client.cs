// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Uis20180821.Models;

namespace AlibabaCloud.SDK.Uis20180821
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-north-2-gov-1", "uis.cn-hangzhou.aliyuncs.com"},
                {"ap-northeast-1", "uis.aliyuncs.com"},
                {"ap-northeast-2-pop", "uis.aliyuncs.com"},
                {"ap-south-1", "uis.aliyuncs.com"},
                {"ap-southeast-1", "uis.aliyuncs.com"},
                {"ap-southeast-2", "uis.aliyuncs.com"},
                {"ap-southeast-3", "uis.aliyuncs.com"},
                {"ap-southeast-5", "uis.aliyuncs.com"},
                {"cn-beijing", "uis.aliyuncs.com"},
                {"cn-beijing-finance-1", "uis.aliyuncs.com"},
                {"cn-beijing-finance-pop", "uis.aliyuncs.com"},
                {"cn-beijing-gov-1", "uis.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "uis.aliyuncs.com"},
                {"cn-chengdu", "uis.aliyuncs.com"},
                {"cn-edge-1", "uis.aliyuncs.com"},
                {"cn-fujian", "uis.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "uis.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "uis.aliyuncs.com"},
                {"cn-hangzhou-finance", "uis.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "uis.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "uis.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "uis.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "uis.aliyuncs.com"},
                {"cn-hangzhou-test-306", "uis.aliyuncs.com"},
                {"cn-hongkong", "uis.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "uis.aliyuncs.com"},
                {"cn-huhehaote", "uis.aliyuncs.com"},
                {"cn-qingdao", "uis.aliyuncs.com"},
                {"cn-qingdao-nebula", "uis.aliyuncs.com"},
                {"cn-shanghai", "uis.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "uis.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "uis.aliyuncs.com"},
                {"cn-shanghai-finance-1", "uis.aliyuncs.com"},
                {"cn-shanghai-inner", "uis.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "uis.aliyuncs.com"},
                {"cn-shenzhen", "uis.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "uis.aliyuncs.com"},
                {"cn-shenzhen-inner", "uis.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "uis.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "uis.aliyuncs.com"},
                {"cn-wuhan", "uis.aliyuncs.com"},
                {"cn-yushanfang", "uis.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "uis.aliyuncs.com"},
                {"cn-zhangjiakou", "uis.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "uis.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "uis.aliyuncs.com"},
                {"eu-central-1", "uis.aliyuncs.com"},
                {"eu-west-1", "uis.aliyuncs.com"},
                {"eu-west-1-oxs", "uis.aliyuncs.com"},
                {"me-east-1", "uis.aliyuncs.com"},
                {"rus-west-1-pop", "uis.aliyuncs.com"},
                {"us-east-1", "uis.aliyuncs.com"},
                {"us-west-1", "uis.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("uis", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddHighPriorityIpResponse AddHighPriorityIpWithOptions(AddHighPriorityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddHighPriorityIpResponse>(DoRPCRequest("AddHighPriorityIp", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddHighPriorityIpResponse> AddHighPriorityIpWithOptionsAsync(AddHighPriorityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddHighPriorityIpResponse>(await DoRPCRequestAsync("AddHighPriorityIp", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddHighPriorityIpResponse AddHighPriorityIp(AddHighPriorityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddHighPriorityIpWithOptions(request, runtime);
        }

        public async Task<AddHighPriorityIpResponse> AddHighPriorityIpAsync(AddHighPriorityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddHighPriorityIpWithOptionsAsync(request, runtime);
        }

        public AddUisNodeIpResponse AddUisNodeIpWithOptions(AddUisNodeIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUisNodeIpResponse>(DoRPCRequest("AddUisNodeIp", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddUisNodeIpResponse> AddUisNodeIpWithOptionsAsync(AddUisNodeIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddUisNodeIpResponse>(await DoRPCRequestAsync("AddUisNodeIp", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddUisNodeIpResponse AddUisNodeIp(AddUisNodeIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUisNodeIpWithOptions(request, runtime);
        }

        public async Task<AddUisNodeIpResponse> AddUisNodeIpAsync(AddUisNodeIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUisNodeIpWithOptionsAsync(request, runtime);
        }

        public CreateDnatEntryResponse CreateDnatEntryWithOptions(CreateDnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDnatEntryResponse>(DoRPCRequest("CreateDnatEntry", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDnatEntryResponse> CreateDnatEntryWithOptionsAsync(CreateDnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDnatEntryResponse>(await DoRPCRequestAsync("CreateDnatEntry", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDnatEntryResponse CreateDnatEntry(CreateDnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDnatEntryWithOptions(request, runtime);
        }

        public async Task<CreateDnatEntryResponse> CreateDnatEntryAsync(CreateDnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDnatEntryWithOptionsAsync(request, runtime);
        }

        public CreateSubConnectionResponse CreateSubConnectionWithOptions(CreateSubConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSubConnectionResponse>(DoRPCRequest("CreateSubConnection", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSubConnectionResponse> CreateSubConnectionWithOptionsAsync(CreateSubConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSubConnectionResponse>(await DoRPCRequestAsync("CreateSubConnection", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSubConnectionResponse CreateSubConnection(CreateSubConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubConnectionWithOptions(request, runtime);
        }

        public async Task<CreateSubConnectionResponse> CreateSubConnectionAsync(CreateSubConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubConnectionWithOptionsAsync(request, runtime);
        }

        public CreateUisResponse CreateUisWithOptions(CreateUisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUisResponse>(DoRPCRequest("CreateUis", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUisResponse> CreateUisWithOptionsAsync(CreateUisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUisResponse>(await DoRPCRequestAsync("CreateUis", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUisResponse CreateUis(CreateUisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUisWithOptions(request, runtime);
        }

        public async Task<CreateUisResponse> CreateUisAsync(CreateUisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUisWithOptionsAsync(request, runtime);
        }

        public CreateUisConnectionResponse CreateUisConnectionWithOptions(CreateUisConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUisConnectionResponse>(DoRPCRequest("CreateUisConnection", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUisConnectionResponse> CreateUisConnectionWithOptionsAsync(CreateUisConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUisConnectionResponse>(await DoRPCRequestAsync("CreateUisConnection", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUisConnectionResponse CreateUisConnection(CreateUisConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUisConnectionWithOptions(request, runtime);
        }

        public async Task<CreateUisConnectionResponse> CreateUisConnectionAsync(CreateUisConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUisConnectionWithOptionsAsync(request, runtime);
        }

        public CreateUisNetworkInterfaceResponse CreateUisNetworkInterfaceWithOptions(CreateUisNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUisNetworkInterfaceResponse>(DoRPCRequest("CreateUisNetworkInterface", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUisNetworkInterfaceResponse> CreateUisNetworkInterfaceWithOptionsAsync(CreateUisNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUisNetworkInterfaceResponse>(await DoRPCRequestAsync("CreateUisNetworkInterface", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUisNetworkInterfaceResponse CreateUisNetworkInterface(CreateUisNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUisNetworkInterfaceWithOptions(request, runtime);
        }

        public async Task<CreateUisNetworkInterfaceResponse> CreateUisNetworkInterfaceAsync(CreateUisNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUisNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        public CreateUisNodeResponse CreateUisNodeWithOptions(CreateUisNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUisNodeResponse>(DoRPCRequest("CreateUisNode", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUisNodeResponse> CreateUisNodeWithOptionsAsync(CreateUisNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUisNodeResponse>(await DoRPCRequestAsync("CreateUisNode", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUisNodeResponse CreateUisNode(CreateUisNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUisNodeWithOptions(request, runtime);
        }

        public async Task<CreateUisNodeResponse> CreateUisNodeAsync(CreateUisNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUisNodeWithOptionsAsync(request, runtime);
        }

        public DeleteDnatEntryResponse DeleteDnatEntryWithOptions(DeleteDnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDnatEntryResponse>(DoRPCRequest("DeleteDnatEntry", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDnatEntryResponse> DeleteDnatEntryWithOptionsAsync(DeleteDnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDnatEntryResponse>(await DoRPCRequestAsync("DeleteDnatEntry", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDnatEntryResponse DeleteDnatEntry(DeleteDnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDnatEntryWithOptions(request, runtime);
        }

        public async Task<DeleteDnatEntryResponse> DeleteDnatEntryAsync(DeleteDnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDnatEntryWithOptionsAsync(request, runtime);
        }

        public DeleteHighPriorityIpResponse DeleteHighPriorityIpWithOptions(DeleteHighPriorityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHighPriorityIpResponse>(DoRPCRequest("DeleteHighPriorityIp", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHighPriorityIpResponse> DeleteHighPriorityIpWithOptionsAsync(DeleteHighPriorityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHighPriorityIpResponse>(await DoRPCRequestAsync("DeleteHighPriorityIp", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHighPriorityIpResponse DeleteHighPriorityIp(DeleteHighPriorityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHighPriorityIpWithOptions(request, runtime);
        }

        public async Task<DeleteHighPriorityIpResponse> DeleteHighPriorityIpAsync(DeleteHighPriorityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHighPriorityIpWithOptionsAsync(request, runtime);
        }

        public DeleteSubConnectionResponse DeleteSubConnectionWithOptions(DeleteSubConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSubConnectionResponse>(DoRPCRequest("DeleteSubConnection", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSubConnectionResponse> DeleteSubConnectionWithOptionsAsync(DeleteSubConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSubConnectionResponse>(await DoRPCRequestAsync("DeleteSubConnection", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSubConnectionResponse DeleteSubConnection(DeleteSubConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSubConnectionWithOptions(request, runtime);
        }

        public async Task<DeleteSubConnectionResponse> DeleteSubConnectionAsync(DeleteSubConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSubConnectionWithOptionsAsync(request, runtime);
        }

        public DeleteUisResponse DeleteUisWithOptions(DeleteUisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUisResponse>(DoRPCRequest("DeleteUis", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUisResponse> DeleteUisWithOptionsAsync(DeleteUisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUisResponse>(await DoRPCRequestAsync("DeleteUis", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUisResponse DeleteUis(DeleteUisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUisWithOptions(request, runtime);
        }

        public async Task<DeleteUisResponse> DeleteUisAsync(DeleteUisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUisWithOptionsAsync(request, runtime);
        }

        public DeleteUisConnectionResponse DeleteUisConnectionWithOptions(DeleteUisConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUisConnectionResponse>(DoRPCRequest("DeleteUisConnection", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUisConnectionResponse> DeleteUisConnectionWithOptionsAsync(DeleteUisConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUisConnectionResponse>(await DoRPCRequestAsync("DeleteUisConnection", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUisConnectionResponse DeleteUisConnection(DeleteUisConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUisConnectionWithOptions(request, runtime);
        }

        public async Task<DeleteUisConnectionResponse> DeleteUisConnectionAsync(DeleteUisConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUisConnectionWithOptionsAsync(request, runtime);
        }

        public DeleteUisNetworkInterfaceResponse DeleteUisNetworkInterfaceWithOptions(DeleteUisNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUisNetworkInterfaceResponse>(DoRPCRequest("DeleteUisNetworkInterface", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUisNetworkInterfaceResponse> DeleteUisNetworkInterfaceWithOptionsAsync(DeleteUisNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUisNetworkInterfaceResponse>(await DoRPCRequestAsync("DeleteUisNetworkInterface", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUisNetworkInterfaceResponse DeleteUisNetworkInterface(DeleteUisNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUisNetworkInterfaceWithOptions(request, runtime);
        }

        public async Task<DeleteUisNetworkInterfaceResponse> DeleteUisNetworkInterfaceAsync(DeleteUisNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUisNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        public DeleteUisNodeResponse DeleteUisNodeWithOptions(DeleteUisNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUisNodeResponse>(DoRPCRequest("DeleteUisNode", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUisNodeResponse> DeleteUisNodeWithOptionsAsync(DeleteUisNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUisNodeResponse>(await DoRPCRequestAsync("DeleteUisNode", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUisNodeResponse DeleteUisNode(DeleteUisNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUisNodeWithOptions(request, runtime);
        }

        public async Task<DeleteUisNodeResponse> DeleteUisNodeAsync(DeleteUisNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUisNodeWithOptionsAsync(request, runtime);
        }

        public DeleteUisNodeIpResponse DeleteUisNodeIpWithOptions(DeleteUisNodeIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUisNodeIpResponse>(DoRPCRequest("DeleteUisNodeIp", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUisNodeIpResponse> DeleteUisNodeIpWithOptionsAsync(DeleteUisNodeIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUisNodeIpResponse>(await DoRPCRequestAsync("DeleteUisNodeIp", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUisNodeIpResponse DeleteUisNodeIp(DeleteUisNodeIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUisNodeIpWithOptions(request, runtime);
        }

        public async Task<DeleteUisNodeIpResponse> DeleteUisNodeIpAsync(DeleteUisNodeIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUisNodeIpWithOptionsAsync(request, runtime);
        }

        public DescribeAreasResponse DescribeAreasWithOptions(DescribeAreasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAreasResponse>(DoRPCRequest("DescribeAreas", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAreasResponse> DescribeAreasWithOptionsAsync(DescribeAreasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAreasResponse>(await DoRPCRequestAsync("DescribeAreas", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAreasResponse DescribeAreas(DescribeAreasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAreasWithOptions(request, runtime);
        }

        public async Task<DescribeAreasResponse> DescribeAreasAsync(DescribeAreasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAreasWithOptionsAsync(request, runtime);
        }

        public DescribeDnatEntriesResponse DescribeDnatEntriesWithOptions(DescribeDnatEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnatEntriesResponse>(DoRPCRequest("DescribeDnatEntries", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnatEntriesResponse> DescribeDnatEntriesWithOptionsAsync(DescribeDnatEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnatEntriesResponse>(await DoRPCRequestAsync("DescribeDnatEntries", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnatEntriesResponse DescribeDnatEntries(DescribeDnatEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnatEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeDnatEntriesResponse> DescribeDnatEntriesAsync(DescribeDnatEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnatEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeHighPriorityIpResponse DescribeHighPriorityIpWithOptions(DescribeHighPriorityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHighPriorityIpResponse>(DoRPCRequest("DescribeHighPriorityIp", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHighPriorityIpResponse> DescribeHighPriorityIpWithOptionsAsync(DescribeHighPriorityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHighPriorityIpResponse>(await DoRPCRequestAsync("DescribeHighPriorityIp", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHighPriorityIpResponse DescribeHighPriorityIp(DescribeHighPriorityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHighPriorityIpWithOptions(request, runtime);
        }

        public async Task<DescribeHighPriorityIpResponse> DescribeHighPriorityIpAsync(DescribeHighPriorityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHighPriorityIpWithOptionsAsync(request, runtime);
        }

        public DescribeHighPriorityIpsResponse DescribeHighPriorityIpsWithOptions(DescribeHighPriorityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHighPriorityIpsResponse>(DoRPCRequest("DescribeHighPriorityIps", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHighPriorityIpsResponse> DescribeHighPriorityIpsWithOptionsAsync(DescribeHighPriorityIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHighPriorityIpsResponse>(await DoRPCRequestAsync("DescribeHighPriorityIps", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHighPriorityIpsResponse DescribeHighPriorityIps(DescribeHighPriorityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHighPriorityIpsWithOptions(request, runtime);
        }

        public async Task<DescribeHighPriorityIpsResponse> DescribeHighPriorityIpsAsync(DescribeHighPriorityIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHighPriorityIpsWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSubConnectionResponse DescribeSubConnectionWithOptions(DescribeSubConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubConnectionResponse>(DoRPCRequest("DescribeSubConnection", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSubConnectionResponse> DescribeSubConnectionWithOptionsAsync(DescribeSubConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubConnectionResponse>(await DoRPCRequestAsync("DescribeSubConnection", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSubConnectionResponse DescribeSubConnection(DescribeSubConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubConnectionWithOptions(request, runtime);
        }

        public async Task<DescribeSubConnectionResponse> DescribeSubConnectionAsync(DescribeSubConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubConnectionWithOptionsAsync(request, runtime);
        }

        public DescribeSubConnectionsResponse DescribeSubConnectionsWithOptions(DescribeSubConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubConnectionsResponse>(DoRPCRequest("DescribeSubConnections", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSubConnectionsResponse> DescribeSubConnectionsWithOptionsAsync(DescribeSubConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubConnectionsResponse>(await DoRPCRequestAsync("DescribeSubConnections", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSubConnectionsResponse DescribeSubConnections(DescribeSubConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubConnectionsWithOptions(request, runtime);
        }

        public async Task<DescribeSubConnectionsResponse> DescribeSubConnectionsAsync(DescribeSubConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubConnectionsWithOptionsAsync(request, runtime);
        }

        public DescribeUisConnectionsResponse DescribeUisConnectionsWithOptions(DescribeUisConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUisConnectionsResponse>(DoRPCRequest("DescribeUisConnections", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUisConnectionsResponse> DescribeUisConnectionsWithOptionsAsync(DescribeUisConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUisConnectionsResponse>(await DoRPCRequestAsync("DescribeUisConnections", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUisConnectionsResponse DescribeUisConnections(DescribeUisConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUisConnectionsWithOptions(request, runtime);
        }

        public async Task<DescribeUisConnectionsResponse> DescribeUisConnectionsAsync(DescribeUisConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUisConnectionsWithOptionsAsync(request, runtime);
        }

        public DescribeUiseNodeStatusResponse DescribeUiseNodeStatusWithOptions(DescribeUiseNodeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUiseNodeStatusResponse>(DoRPCRequest("DescribeUiseNodeStatus", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUiseNodeStatusResponse> DescribeUiseNodeStatusWithOptionsAsync(DescribeUiseNodeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUiseNodeStatusResponse>(await DoRPCRequestAsync("DescribeUiseNodeStatus", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUiseNodeStatusResponse DescribeUiseNodeStatus(DescribeUiseNodeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUiseNodeStatusWithOptions(request, runtime);
        }

        public async Task<DescribeUiseNodeStatusResponse> DescribeUiseNodeStatusAsync(DescribeUiseNodeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUiseNodeStatusWithOptionsAsync(request, runtime);
        }

        public DescribeUisesResponse DescribeUisesWithOptions(DescribeUisesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUisesResponse>(DoRPCRequest("DescribeUises", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUisesResponse> DescribeUisesWithOptionsAsync(DescribeUisesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUisesResponse>(await DoRPCRequestAsync("DescribeUises", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUisesResponse DescribeUises(DescribeUisesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUisesWithOptions(request, runtime);
        }

        public async Task<DescribeUisesResponse> DescribeUisesAsync(DescribeUisesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUisesWithOptionsAsync(request, runtime);
        }

        public DescribeUisNetworkInterfacesResponse DescribeUisNetworkInterfacesWithOptions(DescribeUisNetworkInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUisNetworkInterfacesResponse>(DoRPCRequest("DescribeUisNetworkInterfaces", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUisNetworkInterfacesResponse> DescribeUisNetworkInterfacesWithOptionsAsync(DescribeUisNetworkInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUisNetworkInterfacesResponse>(await DoRPCRequestAsync("DescribeUisNetworkInterfaces", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUisNetworkInterfacesResponse DescribeUisNetworkInterfaces(DescribeUisNetworkInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUisNetworkInterfacesWithOptions(request, runtime);
        }

        public async Task<DescribeUisNetworkInterfacesResponse> DescribeUisNetworkInterfacesAsync(DescribeUisNetworkInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUisNetworkInterfacesWithOptionsAsync(request, runtime);
        }

        public DescribeUisNodesResponse DescribeUisNodesWithOptions(DescribeUisNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUisNodesResponse>(DoRPCRequest("DescribeUisNodes", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUisNodesResponse> DescribeUisNodesWithOptionsAsync(DescribeUisNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUisNodesResponse>(await DoRPCRequestAsync("DescribeUisNodes", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUisNodesResponse DescribeUisNodes(DescribeUisNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUisNodesWithOptions(request, runtime);
        }

        public async Task<DescribeUisNodesResponse> DescribeUisNodesAsync(DescribeUisNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUisNodesWithOptionsAsync(request, runtime);
        }

        public DescribeWhiteListResponse DescribeWhiteListWithOptions(DescribeWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWhiteListResponse>(DoRPCRequest("DescribeWhiteList", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWhiteListResponse> DescribeWhiteListWithOptionsAsync(DescribeWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWhiteListResponse>(await DoRPCRequestAsync("DescribeWhiteList", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWhiteListResponse DescribeWhiteList(DescribeWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWhiteListWithOptions(request, runtime);
        }

        public async Task<DescribeWhiteListResponse> DescribeWhiteListAsync(DescribeWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWhiteListWithOptionsAsync(request, runtime);
        }

        public GetDroppedIpListResponse GetDroppedIpListWithOptions(GetDroppedIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDroppedIpListResponse>(DoRPCRequest("GetDroppedIpList", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDroppedIpListResponse> GetDroppedIpListWithOptionsAsync(GetDroppedIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDroppedIpListResponse>(await DoRPCRequestAsync("GetDroppedIpList", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDroppedIpListResponse GetDroppedIpList(GetDroppedIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDroppedIpListWithOptions(request, runtime);
        }

        public async Task<GetDroppedIpListResponse> GetDroppedIpListAsync(GetDroppedIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDroppedIpListWithOptionsAsync(request, runtime);
        }

        public ModifyDnatEntryResponse ModifyDnatEntryWithOptions(ModifyDnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDnatEntryResponse>(DoRPCRequest("ModifyDnatEntry", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDnatEntryResponse> ModifyDnatEntryWithOptionsAsync(ModifyDnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDnatEntryResponse>(await DoRPCRequestAsync("ModifyDnatEntry", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDnatEntryResponse ModifyDnatEntry(ModifyDnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDnatEntryWithOptions(request, runtime);
        }

        public async Task<ModifyDnatEntryResponse> ModifyDnatEntryAsync(ModifyDnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDnatEntryWithOptionsAsync(request, runtime);
        }

        public ModifyHighPriorityIpResponse ModifyHighPriorityIpWithOptions(ModifyHighPriorityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHighPriorityIpResponse>(DoRPCRequest("ModifyHighPriorityIp", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHighPriorityIpResponse> ModifyHighPriorityIpWithOptionsAsync(ModifyHighPriorityIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHighPriorityIpResponse>(await DoRPCRequestAsync("ModifyHighPriorityIp", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHighPriorityIpResponse ModifyHighPriorityIp(ModifyHighPriorityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHighPriorityIpWithOptions(request, runtime);
        }

        public async Task<ModifyHighPriorityIpResponse> ModifyHighPriorityIpAsync(ModifyHighPriorityIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHighPriorityIpWithOptionsAsync(request, runtime);
        }

        public ModifySubConnectionResponse ModifySubConnectionWithOptions(ModifySubConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySubConnectionResponse>(DoRPCRequest("ModifySubConnection", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySubConnectionResponse> ModifySubConnectionWithOptionsAsync(ModifySubConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySubConnectionResponse>(await DoRPCRequestAsync("ModifySubConnection", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySubConnectionResponse ModifySubConnection(ModifySubConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySubConnectionWithOptions(request, runtime);
        }

        public async Task<ModifySubConnectionResponse> ModifySubConnectionAsync(ModifySubConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySubConnectionWithOptionsAsync(request, runtime);
        }

        public ModifyUisAttributeResponse ModifyUisAttributeWithOptions(ModifyUisAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUisAttributeResponse>(DoRPCRequest("ModifyUisAttribute", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUisAttributeResponse> ModifyUisAttributeWithOptionsAsync(ModifyUisAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUisAttributeResponse>(await DoRPCRequestAsync("ModifyUisAttribute", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUisAttributeResponse ModifyUisAttribute(ModifyUisAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUisAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyUisAttributeResponse> ModifyUisAttributeAsync(ModifyUisAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUisAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyUisConnectionAttributeResponse ModifyUisConnectionAttributeWithOptions(ModifyUisConnectionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUisConnectionAttributeResponse>(DoRPCRequest("ModifyUisConnectionAttribute", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUisConnectionAttributeResponse> ModifyUisConnectionAttributeWithOptionsAsync(ModifyUisConnectionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUisConnectionAttributeResponse>(await DoRPCRequestAsync("ModifyUisConnectionAttribute", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUisConnectionAttributeResponse ModifyUisConnectionAttribute(ModifyUisConnectionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUisConnectionAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyUisConnectionAttributeResponse> ModifyUisConnectionAttributeAsync(ModifyUisConnectionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUisConnectionAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyUisNodeAttributeResponse ModifyUisNodeAttributeWithOptions(ModifyUisNodeAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUisNodeAttributeResponse>(DoRPCRequest("ModifyUisNodeAttribute", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUisNodeAttributeResponse> ModifyUisNodeAttributeWithOptionsAsync(ModifyUisNodeAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUisNodeAttributeResponse>(await DoRPCRequestAsync("ModifyUisNodeAttribute", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUisNodeAttributeResponse ModifyUisNodeAttribute(ModifyUisNodeAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUisNodeAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyUisNodeAttributeResponse> ModifyUisNodeAttributeAsync(ModifyUisNodeAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUisNodeAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyWhiteListResponse ModifyWhiteListWithOptions(ModifyWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWhiteListResponse>(DoRPCRequest("ModifyWhiteList", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyWhiteListResponse> ModifyWhiteListWithOptionsAsync(ModifyWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyWhiteListResponse>(await DoRPCRequestAsync("ModifyWhiteList", "2018-08-21", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyWhiteListResponse ModifyWhiteList(ModifyWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWhiteListWithOptions(request, runtime);
        }

        public async Task<ModifyWhiteListResponse> ModifyWhiteListAsync(ModifyWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWhiteListWithOptionsAsync(request, runtime);
        }

    }
}
