// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Mse20190531.Models;

namespace AlibabaCloud.SDK.Mse20190531
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-chengdu", "mse.cn-chegndu.aliyuncs.com"},
                {"ap-northeast-1", "mse. ap-northeast-1.aliyuncs.com"},
                {"cn-shanghai-finance-1", "msefinance-share.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "msefinance-share.cn-shenzhen-finance-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("mse", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddMockRuleResponse AddMockRuleWithOptions(AddMockRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMockRuleResponse>(DoRPCRequest("AddMockRule", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddMockRuleResponse> AddMockRuleWithOptionsAsync(AddMockRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMockRuleResponse>(await DoRPCRequestAsync("AddMockRule", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddMockRuleResponse AddMockRule(AddMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMockRuleWithOptions(request, runtime);
        }

        public async Task<AddMockRuleResponse> AddMockRuleAsync(AddMockRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMockRuleWithOptionsAsync(request, runtime);
        }

        public CloneNacosConfigResponse CloneNacosConfigWithOptions(CloneNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneNacosConfigResponse>(DoRPCRequest("CloneNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloneNacosConfigResponse> CloneNacosConfigWithOptionsAsync(CloneNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneNacosConfigResponse>(await DoRPCRequestAsync("CloneNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CloneNacosConfigResponse CloneNacosConfig(CloneNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloneNacosConfigWithOptions(request, runtime);
        }

        public async Task<CloneNacosConfigResponse> CloneNacosConfigAsync(CloneNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloneNacosConfigWithOptionsAsync(request, runtime);
        }

        public CreateAlarmRuleResponse CreateAlarmRuleWithOptions(CreateAlarmRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAlarmRuleShrinkRequest request = new CreateAlarmRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlertWay))
            {
                request.AlertWayShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlertWay, "AlertWay", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactGroupIds))
            {
                request.ContactGroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactGroupIds, "ContactGroupIds", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlarmRuleResponse>(DoRPCRequest("CreateAlarmRule", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAlarmRuleResponse> CreateAlarmRuleWithOptionsAsync(CreateAlarmRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAlarmRuleShrinkRequest request = new CreateAlarmRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AlertWay))
            {
                request.AlertWayShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AlertWay, "AlertWay", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactGroupIds))
            {
                request.ContactGroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactGroupIds, "ContactGroupIds", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlarmRuleResponse>(await DoRPCRequestAsync("CreateAlarmRule", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAlarmRuleResponse CreateAlarmRule(CreateAlarmRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAlarmRuleWithOptions(request, runtime);
        }

        public async Task<CreateAlarmRuleResponse> CreateAlarmRuleAsync(CreateAlarmRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAlarmRuleWithOptionsAsync(request, runtime);
        }

        public CreateApplicationResponse CreateApplicationWithOptions(CreateApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateApplicationResponse>(DoRPCRequest("CreateApplication", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateApplicationResponse> CreateApplicationWithOptionsAsync(CreateApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateApplicationResponse>(await DoRPCRequestAsync("CreateApplication", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApplicationWithOptions(request, runtime);
        }

        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApplicationWithOptionsAsync(request, runtime);
        }

        public CreateClusterResponse CreateClusterWithOptions(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterResponse>(DoRPCRequest("CreateCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterResponse>(await DoRPCRequestAsync("CreateCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterWithOptions(request, runtime);
        }

        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterWithOptionsAsync(request, runtime);
        }

        public CreateEngineNamespaceResponse CreateEngineNamespaceWithOptions(CreateEngineNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEngineNamespaceResponse>(DoRPCRequest("CreateEngineNamespace", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEngineNamespaceResponse> CreateEngineNamespaceWithOptionsAsync(CreateEngineNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEngineNamespaceResponse>(await DoRPCRequestAsync("CreateEngineNamespace", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEngineNamespaceResponse CreateEngineNamespace(CreateEngineNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEngineNamespaceWithOptions(request, runtime);
        }

        public async Task<CreateEngineNamespaceResponse> CreateEngineNamespaceAsync(CreateEngineNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEngineNamespaceWithOptionsAsync(request, runtime);
        }

        public CreateNacosConfigResponse CreateNacosConfigWithOptions(CreateNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNacosConfigResponse>(DoRPCRequest("CreateNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNacosConfigResponse> CreateNacosConfigWithOptionsAsync(CreateNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNacosConfigResponse>(await DoRPCRequestAsync("CreateNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNacosConfigResponse CreateNacosConfig(CreateNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNacosConfigWithOptions(request, runtime);
        }

        public async Task<CreateNacosConfigResponse> CreateNacosConfigAsync(CreateNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNacosConfigWithOptionsAsync(request, runtime);
        }

        public CreateZnodeResponse CreateZnodeWithOptions(CreateZnodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateZnodeResponse>(DoRPCRequest("CreateZnode", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateZnodeResponse> CreateZnodeWithOptionsAsync(CreateZnodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateZnodeResponse>(await DoRPCRequestAsync("CreateZnode", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateZnodeResponse CreateZnode(CreateZnodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateZnodeWithOptions(request, runtime);
        }

        public async Task<CreateZnodeResponse> CreateZnodeAsync(CreateZnodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateZnodeWithOptionsAsync(request, runtime);
        }

        public DeleteAlarmRuleResponse DeleteAlarmRuleWithOptions(DeleteAlarmRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlarmRuleResponse>(DoRPCRequest("DeleteAlarmRule", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAlarmRuleResponse> DeleteAlarmRuleWithOptionsAsync(DeleteAlarmRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlarmRuleResponse>(await DoRPCRequestAsync("DeleteAlarmRule", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAlarmRuleResponse DeleteAlarmRule(DeleteAlarmRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAlarmRuleWithOptions(request, runtime);
        }

        public async Task<DeleteAlarmRuleResponse> DeleteAlarmRuleAsync(DeleteAlarmRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAlarmRuleWithOptionsAsync(request, runtime);
        }

        public DeleteClusterResponse DeleteClusterWithOptions(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteClusterResponse>(DoRPCRequest("DeleteCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteClusterResponse> DeleteClusterWithOptionsAsync(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteClusterResponse>(await DoRPCRequestAsync("DeleteCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClusterWithOptions(request, runtime);
        }

        public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClusterWithOptionsAsync(request, runtime);
        }

        public DeleteEngineNamespaceResponse DeleteEngineNamespaceWithOptions(DeleteEngineNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEngineNamespaceResponse>(DoRPCRequest("DeleteEngineNamespace", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEngineNamespaceResponse> DeleteEngineNamespaceWithOptionsAsync(DeleteEngineNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEngineNamespaceResponse>(await DoRPCRequestAsync("DeleteEngineNamespace", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEngineNamespaceResponse DeleteEngineNamespace(DeleteEngineNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEngineNamespaceWithOptions(request, runtime);
        }

        public async Task<DeleteEngineNamespaceResponse> DeleteEngineNamespaceAsync(DeleteEngineNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEngineNamespaceWithOptionsAsync(request, runtime);
        }

        public DeleteNacosConfigResponse DeleteNacosConfigWithOptions(DeleteNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNacosConfigResponse>(DoRPCRequest("DeleteNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNacosConfigResponse> DeleteNacosConfigWithOptionsAsync(DeleteNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNacosConfigResponse>(await DoRPCRequestAsync("DeleteNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNacosConfigResponse DeleteNacosConfig(DeleteNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNacosConfigWithOptions(request, runtime);
        }

        public async Task<DeleteNacosConfigResponse> DeleteNacosConfigAsync(DeleteNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNacosConfigWithOptionsAsync(request, runtime);
        }

        public DeleteNacosConfigsResponse DeleteNacosConfigsWithOptions(DeleteNacosConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNacosConfigsResponse>(DoRPCRequest("DeleteNacosConfigs", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNacosConfigsResponse> DeleteNacosConfigsWithOptionsAsync(DeleteNacosConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNacosConfigsResponse>(await DoRPCRequestAsync("DeleteNacosConfigs", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNacosConfigsResponse DeleteNacosConfigs(DeleteNacosConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNacosConfigsWithOptions(request, runtime);
        }

        public async Task<DeleteNacosConfigsResponse> DeleteNacosConfigsAsync(DeleteNacosConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNacosConfigsWithOptionsAsync(request, runtime);
        }

        public DeleteNacosServiceResponse DeleteNacosServiceWithOptions(DeleteNacosServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNacosServiceResponse>(DoRPCRequest("DeleteNacosService", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNacosServiceResponse> DeleteNacosServiceWithOptionsAsync(DeleteNacosServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNacosServiceResponse>(await DoRPCRequestAsync("DeleteNacosService", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNacosServiceResponse DeleteNacosService(DeleteNacosServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNacosServiceWithOptions(request, runtime);
        }

        public async Task<DeleteNacosServiceResponse> DeleteNacosServiceAsync(DeleteNacosServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNacosServiceWithOptionsAsync(request, runtime);
        }

        public DeleteZnodeResponse DeleteZnodeWithOptions(DeleteZnodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteZnodeResponse>(DoRPCRequest("DeleteZnode", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteZnodeResponse> DeleteZnodeWithOptionsAsync(DeleteZnodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteZnodeResponse>(await DoRPCRequestAsync("DeleteZnode", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteZnodeResponse DeleteZnode(DeleteZnodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteZnodeWithOptions(request, runtime);
        }

        public async Task<DeleteZnodeResponse> DeleteZnodeAsync(DeleteZnodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteZnodeWithOptionsAsync(request, runtime);
        }

        public ExportNacosConfigResponse ExportNacosConfigWithOptions(ExportNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportNacosConfigResponse>(DoRPCRequest("ExportNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportNacosConfigResponse> ExportNacosConfigWithOptionsAsync(ExportNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportNacosConfigResponse>(await DoRPCRequestAsync("ExportNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportNacosConfigResponse ExportNacosConfig(ExportNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportNacosConfigWithOptions(request, runtime);
        }

        public async Task<ExportNacosConfigResponse> ExportNacosConfigAsync(ExportNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportNacosConfigWithOptionsAsync(request, runtime);
        }

        public GetEngineNamepaceResponse GetEngineNamepaceWithOptions(GetEngineNamepaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetEngineNamepaceResponse>(DoRPCRequest("GetEngineNamepace", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetEngineNamepaceResponse> GetEngineNamepaceWithOptionsAsync(GetEngineNamepaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetEngineNamepaceResponse>(await DoRPCRequestAsync("GetEngineNamepace", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetEngineNamepaceResponse GetEngineNamepace(GetEngineNamepaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEngineNamepaceWithOptions(request, runtime);
        }

        public async Task<GetEngineNamepaceResponse> GetEngineNamepaceAsync(GetEngineNamepaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEngineNamepaceWithOptionsAsync(request, runtime);
        }

        public GetImportFileUrlResponse GetImportFileUrlWithOptions(GetImportFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImportFileUrlResponse>(DoRPCRequest("GetImportFileUrl", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetImportFileUrlResponse> GetImportFileUrlWithOptionsAsync(GetImportFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetImportFileUrlResponse>(await DoRPCRequestAsync("GetImportFileUrl", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetImportFileUrlResponse GetImportFileUrl(GetImportFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetImportFileUrlWithOptions(request, runtime);
        }

        public async Task<GetImportFileUrlResponse> GetImportFileUrlAsync(GetImportFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetImportFileUrlWithOptionsAsync(request, runtime);
        }

        public GetNacosConfigResponse GetNacosConfigWithOptions(GetNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNacosConfigResponse>(DoRPCRequest("GetNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNacosConfigResponse> GetNacosConfigWithOptionsAsync(GetNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNacosConfigResponse>(await DoRPCRequestAsync("GetNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNacosConfigResponse GetNacosConfig(GetNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNacosConfigWithOptions(request, runtime);
        }

        public async Task<GetNacosConfigResponse> GetNacosConfigAsync(GetNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNacosConfigWithOptionsAsync(request, runtime);
        }

        public GetNacosHistoryConfigResponse GetNacosHistoryConfigWithOptions(GetNacosHistoryConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNacosHistoryConfigResponse>(DoRPCRequest("GetNacosHistoryConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNacosHistoryConfigResponse> GetNacosHistoryConfigWithOptionsAsync(GetNacosHistoryConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNacosHistoryConfigResponse>(await DoRPCRequestAsync("GetNacosHistoryConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNacosHistoryConfigResponse GetNacosHistoryConfig(GetNacosHistoryConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNacosHistoryConfigWithOptions(request, runtime);
        }

        public async Task<GetNacosHistoryConfigResponse> GetNacosHistoryConfigAsync(GetNacosHistoryConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNacosHistoryConfigWithOptionsAsync(request, runtime);
        }

        public GetOverviewResponse GetOverviewWithOptions(GetOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOverviewResponse>(DoRPCRequest("GetOverview", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetOverviewResponse> GetOverviewWithOptionsAsync(GetOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetOverviewResponse>(await DoRPCRequestAsync("GetOverview", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetOverviewResponse GetOverview(GetOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOverviewWithOptions(request, runtime);
        }

        public async Task<GetOverviewResponse> GetOverviewAsync(GetOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOverviewWithOptionsAsync(request, runtime);
        }

        public ImportNacosConfigResponse ImportNacosConfigWithOptions(ImportNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportNacosConfigResponse>(DoRPCRequest("ImportNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportNacosConfigResponse> ImportNacosConfigWithOptionsAsync(ImportNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportNacosConfigResponse>(await DoRPCRequestAsync("ImportNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportNacosConfigResponse ImportNacosConfig(ImportNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportNacosConfigWithOptions(request, runtime);
        }

        public async Task<ImportNacosConfigResponse> ImportNacosConfigAsync(ImportNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportNacosConfigWithOptionsAsync(request, runtime);
        }

        public ListAlarmContactGroupsResponse ListAlarmContactGroupsWithOptions(ListAlarmContactGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAlarmContactGroupsResponse>(DoRPCRequest("ListAlarmContactGroups", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAlarmContactGroupsResponse> ListAlarmContactGroupsWithOptionsAsync(ListAlarmContactGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAlarmContactGroupsResponse>(await DoRPCRequestAsync("ListAlarmContactGroups", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAlarmContactGroupsResponse ListAlarmContactGroups(ListAlarmContactGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlarmContactGroupsWithOptions(request, runtime);
        }

        public async Task<ListAlarmContactGroupsResponse> ListAlarmContactGroupsAsync(ListAlarmContactGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlarmContactGroupsWithOptionsAsync(request, runtime);
        }

        public ListAlarmHistoriesResponse ListAlarmHistoriesWithOptions(ListAlarmHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAlarmHistoriesResponse>(DoRPCRequest("ListAlarmHistories", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesWithOptionsAsync(ListAlarmHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAlarmHistoriesResponse>(await DoRPCRequestAsync("ListAlarmHistories", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAlarmHistoriesResponse ListAlarmHistories(ListAlarmHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlarmHistoriesWithOptions(request, runtime);
        }

        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesAsync(ListAlarmHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlarmHistoriesWithOptionsAsync(request, runtime);
        }

        public ListAlarmItemsResponse ListAlarmItemsWithOptions(ListAlarmItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAlarmItemsResponse>(DoRPCRequest("ListAlarmItems", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAlarmItemsResponse> ListAlarmItemsWithOptionsAsync(ListAlarmItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAlarmItemsResponse>(await DoRPCRequestAsync("ListAlarmItems", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAlarmItemsResponse ListAlarmItems(ListAlarmItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlarmItemsWithOptions(request, runtime);
        }

        public async Task<ListAlarmItemsResponse> ListAlarmItemsAsync(ListAlarmItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlarmItemsWithOptionsAsync(request, runtime);
        }

        public ListAlarmRulesResponse ListAlarmRulesWithOptions(ListAlarmRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAlarmRulesResponse>(DoRPCRequest("ListAlarmRules", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAlarmRulesResponse> ListAlarmRulesWithOptionsAsync(ListAlarmRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAlarmRulesResponse>(await DoRPCRequestAsync("ListAlarmRules", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAlarmRulesResponse ListAlarmRules(ListAlarmRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlarmRulesWithOptions(request, runtime);
        }

        public async Task<ListAlarmRulesResponse> ListAlarmRulesAsync(ListAlarmRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlarmRulesWithOptionsAsync(request, runtime);
        }

        public ListAnsInstancesResponse ListAnsInstancesWithOptions(ListAnsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAnsInstancesResponse>(DoRPCRequest("ListAnsInstances", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAnsInstancesResponse> ListAnsInstancesWithOptionsAsync(ListAnsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAnsInstancesResponse>(await DoRPCRequestAsync("ListAnsInstances", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAnsInstancesResponse ListAnsInstances(ListAnsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAnsInstancesWithOptions(request, runtime);
        }

        public async Task<ListAnsInstancesResponse> ListAnsInstancesAsync(ListAnsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAnsInstancesWithOptionsAsync(request, runtime);
        }

        public ListAnsServiceClustersResponse ListAnsServiceClustersWithOptions(ListAnsServiceClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAnsServiceClustersResponse>(DoRPCRequest("ListAnsServiceClusters", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAnsServiceClustersResponse> ListAnsServiceClustersWithOptionsAsync(ListAnsServiceClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAnsServiceClustersResponse>(await DoRPCRequestAsync("ListAnsServiceClusters", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAnsServiceClustersResponse ListAnsServiceClusters(ListAnsServiceClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAnsServiceClustersWithOptions(request, runtime);
        }

        public async Task<ListAnsServiceClustersResponse> ListAnsServiceClustersAsync(ListAnsServiceClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAnsServiceClustersWithOptionsAsync(request, runtime);
        }

        public ListAnsServicesResponse ListAnsServicesWithOptions(ListAnsServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAnsServicesResponse>(DoRPCRequest("ListAnsServices", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAnsServicesResponse> ListAnsServicesWithOptionsAsync(ListAnsServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAnsServicesResponse>(await DoRPCRequestAsync("ListAnsServices", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAnsServicesResponse ListAnsServices(ListAnsServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAnsServicesWithOptions(request, runtime);
        }

        public async Task<ListAnsServicesResponse> ListAnsServicesAsync(ListAnsServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAnsServicesWithOptionsAsync(request, runtime);
        }

        public ListClusterConnectionTypesResponse ListClusterConnectionTypesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListClusterConnectionTypesResponse>(DoRPCRequest("ListClusterConnectionTypes", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterConnectionTypesResponse> ListClusterConnectionTypesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListClusterConnectionTypesResponse>(await DoRPCRequestAsync("ListClusterConnectionTypes", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterConnectionTypesResponse ListClusterConnectionTypes()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterConnectionTypesWithOptions(runtime);
        }

        public async Task<ListClusterConnectionTypesResponse> ListClusterConnectionTypesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterConnectionTypesWithOptionsAsync(runtime);
        }

        public ListClustersResponse ListClustersWithOptions(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListClustersResponse>(DoRPCRequest("ListClusters", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListClustersResponse> ListClustersWithOptionsAsync(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListClustersResponse>(await DoRPCRequestAsync("ListClusters", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListClustersResponse ListClusters(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClustersWithOptions(request, runtime);
        }

        public async Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClustersWithOptionsAsync(request, runtime);
        }

        public ListClusterTypesResponse ListClusterTypesWithOptions(ListClusterTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterTypesResponse>(DoRPCRequest("ListClusterTypes", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterTypesResponse> ListClusterTypesWithOptionsAsync(ListClusterTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterTypesResponse>(await DoRPCRequestAsync("ListClusterTypes", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterTypesResponse ListClusterTypes(ListClusterTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterTypesWithOptions(request, runtime);
        }

        public async Task<ListClusterTypesResponse> ListClusterTypesAsync(ListClusterTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterTypesWithOptionsAsync(request, runtime);
        }

        public ListClusterVersionsResponse ListClusterVersionsWithOptions(ListClusterVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterVersionsResponse>(DoRPCRequest("ListClusterVersions", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterVersionsResponse> ListClusterVersionsWithOptionsAsync(ListClusterVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterVersionsResponse>(await DoRPCRequestAsync("ListClusterVersions", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterVersionsResponse ListClusterVersions(ListClusterVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterVersionsWithOptions(request, runtime);
        }

        public async Task<ListClusterVersionsResponse> ListClusterVersionsAsync(ListClusterVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterVersionsWithOptionsAsync(request, runtime);
        }

        public ListEngineNamespacesResponse ListEngineNamespacesWithOptions(ListEngineNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListEngineNamespacesResponse>(DoRPCRequest("ListEngineNamespaces", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListEngineNamespacesResponse> ListEngineNamespacesWithOptionsAsync(ListEngineNamespacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListEngineNamespacesResponse>(await DoRPCRequestAsync("ListEngineNamespaces", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListEngineNamespacesResponse ListEngineNamespaces(ListEngineNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEngineNamespacesWithOptions(request, runtime);
        }

        public async Task<ListEngineNamespacesResponse> ListEngineNamespacesAsync(ListEngineNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEngineNamespacesWithOptionsAsync(request, runtime);
        }

        public ListEurekaInstancesResponse ListEurekaInstancesWithOptions(ListEurekaInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListEurekaInstancesResponse>(DoRPCRequest("ListEurekaInstances", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListEurekaInstancesResponse> ListEurekaInstancesWithOptionsAsync(ListEurekaInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListEurekaInstancesResponse>(await DoRPCRequestAsync("ListEurekaInstances", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListEurekaInstancesResponse ListEurekaInstances(ListEurekaInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEurekaInstancesWithOptions(request, runtime);
        }

        public async Task<ListEurekaInstancesResponse> ListEurekaInstancesAsync(ListEurekaInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEurekaInstancesWithOptionsAsync(request, runtime);
        }

        public ListEurekaServicesResponse ListEurekaServicesWithOptions(ListEurekaServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListEurekaServicesResponse>(DoRPCRequest("ListEurekaServices", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListEurekaServicesResponse> ListEurekaServicesWithOptionsAsync(ListEurekaServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListEurekaServicesResponse>(await DoRPCRequestAsync("ListEurekaServices", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListEurekaServicesResponse ListEurekaServices(ListEurekaServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEurekaServicesWithOptions(request, runtime);
        }

        public async Task<ListEurekaServicesResponse> ListEurekaServicesAsync(ListEurekaServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEurekaServicesWithOptionsAsync(request, runtime);
        }

        public ListListenersByConfigResponse ListListenersByConfigWithOptions(ListListenersByConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListListenersByConfigResponse>(DoRPCRequest("ListListenersByConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListListenersByConfigResponse> ListListenersByConfigWithOptionsAsync(ListListenersByConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListListenersByConfigResponse>(await DoRPCRequestAsync("ListListenersByConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListListenersByConfigResponse ListListenersByConfig(ListListenersByConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListListenersByConfigWithOptions(request, runtime);
        }

        public async Task<ListListenersByConfigResponse> ListListenersByConfigAsync(ListListenersByConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListListenersByConfigWithOptionsAsync(request, runtime);
        }

        public ListListenersByIpResponse ListListenersByIpWithOptions(ListListenersByIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListListenersByIpResponse>(DoRPCRequest("ListListenersByIp", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListListenersByIpResponse> ListListenersByIpWithOptionsAsync(ListListenersByIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListListenersByIpResponse>(await DoRPCRequestAsync("ListListenersByIp", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListListenersByIpResponse ListListenersByIp(ListListenersByIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListListenersByIpWithOptions(request, runtime);
        }

        public async Task<ListListenersByIpResponse> ListListenersByIpAsync(ListListenersByIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListListenersByIpWithOptionsAsync(request, runtime);
        }

        public ListNacosConfigsResponse ListNacosConfigsWithOptions(ListNacosConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNacosConfigsResponse>(DoRPCRequest("ListNacosConfigs", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNacosConfigsResponse> ListNacosConfigsWithOptionsAsync(ListNacosConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNacosConfigsResponse>(await DoRPCRequestAsync("ListNacosConfigs", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNacosConfigsResponse ListNacosConfigs(ListNacosConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNacosConfigsWithOptions(request, runtime);
        }

        public async Task<ListNacosConfigsResponse> ListNacosConfigsAsync(ListNacosConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNacosConfigsWithOptionsAsync(request, runtime);
        }

        public ListNacosHistoryConfigsResponse ListNacosHistoryConfigsWithOptions(ListNacosHistoryConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNacosHistoryConfigsResponse>(DoRPCRequest("ListNacosHistoryConfigs", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNacosHistoryConfigsResponse> ListNacosHistoryConfigsWithOptionsAsync(ListNacosHistoryConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNacosHistoryConfigsResponse>(await DoRPCRequestAsync("ListNacosHistoryConfigs", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNacosHistoryConfigsResponse ListNacosHistoryConfigs(ListNacosHistoryConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNacosHistoryConfigsWithOptions(request, runtime);
        }

        public async Task<ListNacosHistoryConfigsResponse> ListNacosHistoryConfigsAsync(ListNacosHistoryConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNacosHistoryConfigsWithOptionsAsync(request, runtime);
        }

        public ListZnodeChildrenResponse ListZnodeChildrenWithOptions(ListZnodeChildrenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListZnodeChildrenResponse>(DoRPCRequest("ListZnodeChildren", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListZnodeChildrenResponse> ListZnodeChildrenWithOptionsAsync(ListZnodeChildrenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListZnodeChildrenResponse>(await DoRPCRequestAsync("ListZnodeChildren", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListZnodeChildrenResponse ListZnodeChildren(ListZnodeChildrenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListZnodeChildrenWithOptions(request, runtime);
        }

        public async Task<ListZnodeChildrenResponse> ListZnodeChildrenAsync(ListZnodeChildrenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListZnodeChildrenWithOptionsAsync(request, runtime);
        }

        public QueryBusinessLocationsResponse QueryBusinessLocationsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryBusinessLocationsResponse>(DoRPCRequest("QueryBusinessLocations", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<QueryBusinessLocationsResponse> QueryBusinessLocationsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryBusinessLocationsResponse>(await DoRPCRequestAsync("QueryBusinessLocations", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public QueryBusinessLocationsResponse QueryBusinessLocations()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBusinessLocationsWithOptions(runtime);
        }

        public async Task<QueryBusinessLocationsResponse> QueryBusinessLocationsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBusinessLocationsWithOptionsAsync(runtime);
        }

        public QueryClusterDetailResponse QueryClusterDetailWithOptions(QueryClusterDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryClusterDetailResponse>(DoRPCRequest("QueryClusterDetail", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryClusterDetailResponse> QueryClusterDetailWithOptionsAsync(QueryClusterDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryClusterDetailResponse>(await DoRPCRequestAsync("QueryClusterDetail", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryClusterDetailResponse QueryClusterDetail(QueryClusterDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryClusterDetailWithOptions(request, runtime);
        }

        public async Task<QueryClusterDetailResponse> QueryClusterDetailAsync(QueryClusterDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryClusterDetailWithOptionsAsync(request, runtime);
        }

        public QueryClusterDiskSpecificationResponse QueryClusterDiskSpecificationWithOptions(QueryClusterDiskSpecificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryClusterDiskSpecificationResponse>(DoRPCRequest("QueryClusterDiskSpecification", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryClusterDiskSpecificationResponse> QueryClusterDiskSpecificationWithOptionsAsync(QueryClusterDiskSpecificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryClusterDiskSpecificationResponse>(await DoRPCRequestAsync("QueryClusterDiskSpecification", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryClusterDiskSpecificationResponse QueryClusterDiskSpecification(QueryClusterDiskSpecificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryClusterDiskSpecificationWithOptions(request, runtime);
        }

        public async Task<QueryClusterDiskSpecificationResponse> QueryClusterDiskSpecificationAsync(QueryClusterDiskSpecificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryClusterDiskSpecificationWithOptionsAsync(request, runtime);
        }

        public QueryClusterSpecificationResponse QueryClusterSpecificationWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryClusterSpecificationResponse>(DoRPCRequest("QueryClusterSpecification", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryClusterSpecificationResponse> QueryClusterSpecificationWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryClusterSpecificationResponse>(await DoRPCRequestAsync("QueryClusterSpecification", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryClusterSpecificationResponse QueryClusterSpecification()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryClusterSpecificationWithOptions(runtime);
        }

        public async Task<QueryClusterSpecificationResponse> QueryClusterSpecificationAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryClusterSpecificationWithOptionsAsync(runtime);
        }

        public QueryConfigResponse QueryConfigWithOptions(QueryConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryConfigResponse>(DoRPCRequest("QueryConfig", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<QueryConfigResponse> QueryConfigWithOptionsAsync(QueryConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryConfigResponse>(await DoRPCRequestAsync("QueryConfig", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public QueryConfigResponse QueryConfig(QueryConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryConfigWithOptions(request, runtime);
        }

        public async Task<QueryConfigResponse> QueryConfigAsync(QueryConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryConfigWithOptionsAsync(request, runtime);
        }

        public QueryMonitorResponse QueryMonitorWithOptions(QueryMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryMonitorResponse>(DoRPCRequest("QueryMonitor", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<QueryMonitorResponse> QueryMonitorWithOptionsAsync(QueryMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryMonitorResponse>(await DoRPCRequestAsync("QueryMonitor", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public QueryMonitorResponse QueryMonitor(QueryMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMonitorWithOptions(request, runtime);
        }

        public async Task<QueryMonitorResponse> QueryMonitorAsync(QueryMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMonitorWithOptionsAsync(request, runtime);
        }

        public QueryZnodeDetailResponse QueryZnodeDetailWithOptions(QueryZnodeDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryZnodeDetailResponse>(DoRPCRequest("QueryZnodeDetail", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<QueryZnodeDetailResponse> QueryZnodeDetailWithOptionsAsync(QueryZnodeDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<QueryZnodeDetailResponse>(await DoRPCRequestAsync("QueryZnodeDetail", "2019-05-31", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public QueryZnodeDetailResponse QueryZnodeDetail(QueryZnodeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryZnodeDetailWithOptions(request, runtime);
        }

        public async Task<QueryZnodeDetailResponse> QueryZnodeDetailAsync(QueryZnodeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryZnodeDetailWithOptionsAsync(request, runtime);
        }

        public RestartClusterResponse RestartClusterWithOptions(RestartClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartClusterResponse>(DoRPCRequest("RestartCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartClusterResponse> RestartClusterWithOptionsAsync(RestartClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartClusterResponse>(await DoRPCRequestAsync("RestartCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestartClusterResponse RestartCluster(RestartClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartClusterWithOptions(request, runtime);
        }

        public async Task<RestartClusterResponse> RestartClusterAsync(RestartClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartClusterWithOptionsAsync(request, runtime);
        }

        public RetryClusterResponse RetryClusterWithOptions(RetryClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RetryClusterResponse>(DoRPCRequest("RetryCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RetryClusterResponse> RetryClusterWithOptionsAsync(RetryClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RetryClusterResponse>(await DoRPCRequestAsync("RetryCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RetryClusterResponse RetryCluster(RetryClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryClusterWithOptions(request, runtime);
        }

        public async Task<RetryClusterResponse> RetryClusterAsync(RetryClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryClusterWithOptionsAsync(request, runtime);
        }

        public ScalingClusterResponse ScalingClusterWithOptions(ScalingClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ScalingClusterResponse>(DoRPCRequest("ScalingCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ScalingClusterResponse> ScalingClusterWithOptionsAsync(ScalingClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ScalingClusterResponse>(await DoRPCRequestAsync("ScalingCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ScalingClusterResponse ScalingCluster(ScalingClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScalingClusterWithOptions(request, runtime);
        }

        public async Task<ScalingClusterResponse> ScalingClusterAsync(ScalingClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScalingClusterWithOptionsAsync(request, runtime);
        }

        public UpdateAclResponse UpdateAclWithOptions(UpdateAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAclResponse>(DoRPCRequest("UpdateAcl", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAclResponse> UpdateAclWithOptionsAsync(UpdateAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAclResponse>(await DoRPCRequestAsync("UpdateAcl", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAclResponse UpdateAcl(UpdateAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAclWithOptions(request, runtime);
        }

        public async Task<UpdateAclResponse> UpdateAclAsync(UpdateAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAclWithOptionsAsync(request, runtime);
        }

        public UpdateClusterResponse UpdateClusterWithOptions(UpdateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateClusterResponse>(DoRPCRequest("UpdateCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateClusterResponse> UpdateClusterWithOptionsAsync(UpdateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateClusterResponse>(await DoRPCRequestAsync("UpdateCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClusterWithOptions(request, runtime);
        }

        public async Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClusterWithOptionsAsync(request, runtime);
        }

        public UpdateConfigResponse UpdateConfigWithOptions(UpdateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConfigResponse>(DoRPCRequest("UpdateConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateConfigResponse> UpdateConfigWithOptionsAsync(UpdateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConfigResponse>(await DoRPCRequestAsync("UpdateConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateConfigResponse UpdateConfig(UpdateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConfigWithOptions(request, runtime);
        }

        public async Task<UpdateConfigResponse> UpdateConfigAsync(UpdateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConfigWithOptionsAsync(request, runtime);
        }

        public UpdateEngineNamespaceResponse UpdateEngineNamespaceWithOptions(UpdateEngineNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEngineNamespaceResponse>(DoRPCRequest("UpdateEngineNamespace", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateEngineNamespaceResponse> UpdateEngineNamespaceWithOptionsAsync(UpdateEngineNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEngineNamespaceResponse>(await DoRPCRequestAsync("UpdateEngineNamespace", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateEngineNamespaceResponse UpdateEngineNamespace(UpdateEngineNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEngineNamespaceWithOptions(request, runtime);
        }

        public async Task<UpdateEngineNamespaceResponse> UpdateEngineNamespaceAsync(UpdateEngineNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEngineNamespaceWithOptionsAsync(request, runtime);
        }

        public UpdateNacosConfigResponse UpdateNacosConfigWithOptions(UpdateNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNacosConfigResponse>(DoRPCRequest("UpdateNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateNacosConfigResponse> UpdateNacosConfigWithOptionsAsync(UpdateNacosConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNacosConfigResponse>(await DoRPCRequestAsync("UpdateNacosConfig", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateNacosConfigResponse UpdateNacosConfig(UpdateNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNacosConfigWithOptions(request, runtime);
        }

        public async Task<UpdateNacosConfigResponse> UpdateNacosConfigAsync(UpdateNacosConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNacosConfigWithOptionsAsync(request, runtime);
        }

        public UpdateNacosInstanceResponse UpdateNacosInstanceWithOptions(UpdateNacosInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNacosInstanceResponse>(DoRPCRequest("UpdateNacosInstance", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateNacosInstanceResponse> UpdateNacosInstanceWithOptionsAsync(UpdateNacosInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNacosInstanceResponse>(await DoRPCRequestAsync("UpdateNacosInstance", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateNacosInstanceResponse UpdateNacosInstance(UpdateNacosInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNacosInstanceWithOptions(request, runtime);
        }

        public async Task<UpdateNacosInstanceResponse> UpdateNacosInstanceAsync(UpdateNacosInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNacosInstanceWithOptionsAsync(request, runtime);
        }

        public UpdateZnodeResponse UpdateZnodeWithOptions(UpdateZnodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateZnodeResponse>(DoRPCRequest("UpdateZnode", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateZnodeResponse> UpdateZnodeWithOptionsAsync(UpdateZnodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateZnodeResponse>(await DoRPCRequestAsync("UpdateZnode", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateZnodeResponse UpdateZnode(UpdateZnodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateZnodeWithOptions(request, runtime);
        }

        public async Task<UpdateZnodeResponse> UpdateZnodeAsync(UpdateZnodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateZnodeWithOptionsAsync(request, runtime);
        }

        public UpgradeClusterResponse UpgradeClusterWithOptions(UpgradeClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeClusterResponse>(DoRPCRequest("UpgradeCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeClusterResponse> UpgradeClusterWithOptionsAsync(UpgradeClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeClusterResponse>(await DoRPCRequestAsync("UpgradeCluster", "2019-05-31", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeClusterResponse UpgradeCluster(UpgradeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeClusterWithOptions(request, runtime);
        }

        public async Task<UpgradeClusterResponse> UpgradeClusterAsync(UpgradeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeClusterWithOptionsAsync(request, runtime);
        }

    }
}
